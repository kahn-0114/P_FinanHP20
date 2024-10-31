Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data.Odbc
Imports dao

Public Class F_Si_SiwGet00
    Dim pFocus(10) As Object
    Dim MyCom As New Com
    Dim MyProc As New Proc
    Dim pDateFormat As String = "yyyy/MM/dd"
    '******************************************************
    '*
    '******************************************************
    Private Sub Dsp_Set00()
        If Not IsNumeric(CmbA.Text) Then Exit Sub

        Dim SQL As String
        Dim pSino As Integer

        For i As Integer = 1 To 12
            GroupBox10.Controls("btn" & i).Text = "" : GroupBox10.Controls("btn" & i).Visible = False
        Next i
        If IsNumeric(txt処理No.Text) Then
            pSino = Integer.Parse(txt処理No.Text)
        Else
            pSino = 1
        End If
        If pSino <= 0 Then
            pSino = 1
        End If

        SQL = "SELECT * " _
            & "From MM_決算期 " _
            & "Where (会社No =" & pubComPany & ") " _
            & "And (年度 =" & CmbA.Text & ") " _
            & "ORDER BY MM_決算期.締No;"
        Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Dim i0 As Integer = 0
        Do Until r0.EOF
            i0 += 1
            GroupBox10.Controls("btn" & i0).Text = (Date.Parse(r0.Fields("締月").Value).ToString("MM月"))
            If i0 = pSino Then
                GroupBox10.Controls("btn" & i0).BackColor = Color.LightPink
            Else
                GroupBox10.Controls("btn" & i0).BackColor = SystemColors.Control
            End If
            GroupBox10.Controls("btn" & i0).Visible = True
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
    End Sub
    '******************************************************
    '* リストにItemを表示する共通関数
    '******************************************************
    Private Sub Item_Add()
        Dim SQL As String
        SQL = "SELECT T_HIS_財務Imp.* " _
            & "From T_HIS_財務Imp " _
            & "Where (T_HIS_財務Imp.会社No=" & pubComPany & ") " _
            & "ORDER BY T_HIS_財務Imp.RecNo DESC;"
        Dim r0 As dao.Recordset = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Dim i As Integer = 0
        Do Until r0.EOF
            If i > 20 Then Exit Do
            LV.Items.Add(i + 1.ToString("00"))
            LV.Items(i).SubItems.Add(MyCom.ChgNull(r0.Fields("処理日時").Value, 1))
            Dim wTmp00 As String = ""
            If IsNumeric(r0.Fields("対象年月").Value) Then
                wTmp00 = Integer.Parse(r0.Fields("対象年月").Value).ToString("0000/00") & "/01"
            End If
            LV.Items(i).SubItems.Add(MyCom.GetGengo(wTmp00, "yyyy年MM月"))
            LV.Items(i).SubItems.Add(MyCom.ChgNull(r0.Fields("対象処理").Value, 1))
            i += 1
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
    End Sub
    Public Sub AddLog(ByVal s As String)
        With txtLog
            If Len(.Text) > 32000 Then .Text = ""
            .SelectAll()
        End With
    End Sub
    '******************************************************
    '* コンボボックスにItemを追加する。
    '******************************************************
    Private Sub Add_Cmb00()
        Dim pCmb00(1) As MyComboBoxItemA
        pCmb00(0) = New MyComboBoxItemA("差分インポート", "0")
        pCmb00(1) = New MyComboBoxItemA("全件インポート", "1")
        With CmbB
            .DisplayMember = "ItemName"
            .ValueMember = "ItemCode"
            .DataSource = pCmb00
            .SelectedIndex = 1
        End With
        txt処理対象仕訳.Text = 1
    End Sub
    '******************************************************
    '*
    '******************************************************
    Public Sub Dsp_Init00()
        For Each CtrlItem As Control In Me.GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
    End Sub

    '******************************************************
    '*
    '******************************************************
    Private Sub Dsp_Init10()
        Dim ComboItemA As New ArrayList()

        Dim SQL As String
        SQL = "SELECT MM_決算期.年度 " _
            & "From MM_決算期 " _
            & "Where (MM_決算期.会社No =" & pubComPany & ") " _
            & "GROUP BY MM_決算期.年度 " _
            & "ORDER BY MM_決算期.年度 DESC;"
        Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Dim i As Integer = 0
        Do Until r0.EOF
            Dim wCD As String = i
            Dim wName As String = MyCom.ChgNull(r0.Fields("年度").Value, 1)
            ComboItemA.Add(New MyComboBoxItemA(wName, wCD))
            i += 1
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing

        With CmbA
            .DisplayMember = "ItemName"
            .ValueMember = "ItemCode"
            .DataSource = ComboItemA
            .SelectedIndex = 0
        End With

        txt処理No.Text = 1
        r0 = DB.OpenRecordset("MM_SYS", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"
        r0.Seek("=", pubComPany, pubLogInName, 0)
        If r0.NoMatch Then
        Else
            'CmbA.SelectedValue = r0.Fields("年度").Value
            CmbA.Text = r0.Fields("年度").Value
            txt処理No.Text = MyCom.ChgNull(r0.Fields("締No").Value, 1)
        End If
        r0.Close() : r0 = Nothing

        r0 = ComDB.OpenRecordset("MM_SiPat", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"
        r0.Seek("=", pubComPany, 900, 10)
        If r0.NoMatch Then
        Else
            txt科目CDFrom.Text = r0.Fields("借方科目").Value
            txt科目CDTo.Text = r0.Fields("借方科目").Value
        End If
        r0.Close() : r0 = Nothing
    End Sub
    '****************************************************************
    '**
    '****************************************************************
    Public Sub Data_Put00()
        Dim SQL As String

        Dim pNo As Integer = 1
        SQL = "SELECT T_HIS_財務Imp.RecNo " _
            & "From T_HIS_財務Imp " _
            & "Where (T_HIS_財務Imp.会社No =" & pubComPany & ") " _
            & "ORDER BY T_HIS_財務Imp.RecNo DESC;"
        Dim r0 As dao.Recordset = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        If Not r0.EOF Then
            pNo = IIf(IsDBNull(r0.Fields("RecNo").Value), 0, r0.Fields("RecNo").Value) + 1
        End If
        r0.Close() : r0 = Nothing

        r0 = DB.OpenRecordset("T_HIS_財務Imp", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"

        r0.Seek("=", pubComPany, pNo)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("会社No").Value = pubComPany
            r0.Fields("RecNo").Value = pNo
        Else
            r0.Edit()
        End If
        r0.Fields("処理日時").Value = Now.ToString("yyyy/MM/dd hh:mm:ss")
        r0.Fields("対象年月").Value = DBNull.Value
        If IsDate(txt締月.Text) Then
            r0.Fields("対象年月").Value = Date.Parse(txt締月.Text).ToString("yyyyMM")
        End If

        Select Case txt処理対象仕訳.Text
            Case 0
                r0.Fields("対象処理").Value = "差分インポート"
            Case 1
                r0.Fields("対象処理").Value = "全件インポート"
        End Select
        r0.Update()
        r0.Close() : r0 = Nothing
    End Sub

    Private Sub Cmd_Click(Index As Integer)
        Dim pRet As Integer, pResp As Boolean, strName As String, i As Integer
        Dim SQL As String
        Dim Tmp(10)

        Select Case Index
            Case 1
            Case 10
                Close()
            Case 12
                'i = CInt(pFocus(0).Index) '整数
                'strName = pFocus(0).Name
                'Select Case strName
                '    Case "txtInp"
                '        Call txtInp_KeyDown(i, 123, 0)
                'End Select
                'pFocus(0).SetFocus
        End Select
    End Sub

    '******************************************************
    '* フィールドクリア関数
    '******************************************************


    Private Sub Inp_Clr00()
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        Next
        For Each CtrlItem As Control In Me.GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        Next
        LV.Items.Clear()
    End Sub

    Private Function Inp_Chk00(ByVal ctxtInp As Control) As Boolean
        txtMsg.Visible = False : txtMsg.Text = ""

        Select Case ctxtInp.Name
            Case "txt伝票日付開始日", "txt伝票日付終了日", "txt支払指定開始日", "txt支払指定終了日"
                ctxtInp.BackColor = Color.White : ctxtInp.Tag = ""
                If ctxtInp.Text = "" Then Return True

                If IsDate(ctxtInp.Text) Then
                    ctxtInp.Text = Date.Parse(ctxtInp.Text).ToString(pDateFormat)
                Else
                    Dim w日付 As String = ""
                    Dim wResult = MyCom.DateChk00(ctxtInp.Text, w日付)
                    If wResult = 1 Then
                        txtMsg.Text = "日付不正"
                        txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : ctxtInp.Tag = "9"
                        Return False
                    Else
                        ctxtInp.Text = w日付
                    End If
                End If
            Case "txt科目CDFrom"
                If ctxtInp.Text = "" Then Return True
                Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_科目", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
                r0.Index = "Key_0"
                r0.Seek("=", pubComPany, txt科目CDFrom.Text)
                If r0.NoMatch Then
                    txtMsg.Text = "科目不正入力"
                    txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : ctxtInp.Tag = "9"
                    Return False
                Else
                    txt科目CDFrom名.Text = MyCom.ChgNull(r0.Fields("科目名").Value, 1)
                End If
                r0.Close()
            Case "txt科目CDTo"
                If ctxtInp.Text = "" Then Return True
                Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_科目", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
                r0.Index = "Key_0"
                r0.Seek("=", pubComPany, txt科目CDTo.Text)
                If r0.NoMatch Then
                    txtMsg.Text = "科目不正入力"
                    txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : ctxtInp.Tag = "9"
                    Return False
                Else
                    txt科目CDTo名.Text = MyCom.ChgNull(r0.Fields("科目名").Value, 1)
                End If
                r0.Close()
            Case "txt取引先CDFrom"
                If ctxtInp.Text = "" Then Return True
                Dim r0 As dao.Recordset = DB.OpenRecordset("M_取引先", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
                r0.Index = "Key_0"
                r0.Seek("=", pubComPany, txt取引先CDFrom.Text)
                If r0.NoMatch Then
                    txtMsg.Text = "取引先不正入力"
                    txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : ctxtInp.Tag = "9"
                    Return False
                Else
                    txt取引先CDFrom名.Text = MyCom.ChgNull(r0.Fields("取引先名").Value, 1)
                End If
                r0.Close()
            Case "txt取引先CDTo"
                If ctxtInp.Text = "" Then Return True
                Dim r0 As dao.Recordset = DB.OpenRecordset("M_取引先", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
                r0.Index = "Key_0"
                r0.Seek("=", pubComPany, txt取引先CDTo.Text)
                If r0.NoMatch Then
                    txtMsg.Text = "取引先不正入力"
                    txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : ctxtInp.Tag = "9"
                    Return False
                Else
                    txt取引先CDTo名.Text = MyCom.ChgNull(r0.Fields("取引先名").Value, 1)
                End If
                r0.Close()
            Case "txt処理対象仕訳"
                ctxtInp.BackColor = Color.White
                If txt処理対象仕訳.Text = "" Then
                    CmbB.SelectedIndex = -1
                    txtMsg.Text = "処理対象仕訳未入力" : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                    Return False
                End If

                CmbB.SelectedValue = txt処理対象仕訳.Text
                If CmbA.SelectedIndex = -1 Then
                    txtMsg.Text = "処理対象仕訳不正" : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                    CmbB.SelectedIndex = -1
                    Return False
                End If
        End Select
        Return True
    End Function
    Private Function Inp_Chk90() As Boolean
        Dim i As Integer

        Inp_Chk90 = True : txtMsg.Text = "" : txtMsg.Visible = False

        If CmbA.SelectedIndex = -1 Then
            Inp_Chk90 = False : txtMsg.Text = "年度不正" : txtMsg.Visible = True : CmbA.BackColor = Color.LightCoral
            CmbA.SelectedIndex = -1
            Exit Function
        End If

        Dim r0 As dao.Recordset = ComDB.OpenRecordset("MM_決算期", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"
        r0.Seek("=", pubComPany, CmbA.Text, txt処理No.Text)
        If r0.NoMatch Then
            Inp_Chk90 = False : txtMsg.Text = "年度不正" : txtMsg.Visible = True : CmbA.BackColor = Color.LightCoral
        Else
            txt締月.Text = MyCom.GetGengo(r0.Fields("締月").Value, "yyyy年MM月")
            txt開始日.Text = MyCom.GetGengo(r0.Fields("開始").Value, "yyyy/MM/dd")
            txt終了日.Text = MyCom.GetGengo(r0.Fields("終了").Value, "yyyy/MM/dd")
        End If
        r0.Close() : r0 = Nothing
    End Function

    '***************************
    '* 財務仕訳インポート処理
    '***************************
    Public Sub MakeData000()
        Dim SQL As String, Tmp(10)

        Tmp(0) = Date.Parse(txt開始日.Text).ToString("yyyyMMdd")
        Tmp(1) = Date.Parse(txt終了日.Text).ToString("yyyyMMdd")

        SQL = "DELETE T_支払仕訳明細.* " _
            & "From T_支払仕訳明細 " _
            & "WHERE (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "And (T_支払仕訳明細.伝票日付>=" & Tmp(0) & ") " _
            & "And (T_支払仕訳明細.伝票日付<=" & Tmp(1) & ") " _
            & "And (T_支払仕訳明細.支払完了F= 0);"
        DB.Execute(SQL)
    End Sub
    '***************************
    '* 財務仕訳インポート処理
    '***************************
    Public Sub MakeData001()
        AddLog("財務仕訳インポート処理-1を開始しました..." & vbCrLf)

        Dim SQL As String
        Dim odbcconn As New OdbcConnection()
        Dim odbcCommand As New OdbcCommand()
        Dim da0 As New OdbcDataAdapter
        Dim dt0 As New DataSet
        Dim Tmp(3) As String

        Try
            odbcconn.ConnectionString = pubDsnODBC
            odbcconn.Open()
            odbcCommand = odbcconn.CreateCommand()
            Tmp(0) = 99999999
            If IsDate(txt開始日.Text) Then
                Tmp(0) = Date.Parse(txt開始日.Text).ToString("yyyyMMdd")
            End If
            Tmp(1) = 99999999
            If IsDate(txt終了日.Text) Then
                Tmp(1) = Date.Parse(txt終了日.Text).ToString("yyyyMMdd")
            End If
            Tmp(2) = "0000"
            If IsNumeric(txt科目CDFrom.Text) Then
                Tmp(2) = Integer.Parse(txt科目CDFrom.Text).ToString("0000")
            End If
            Tmp(3) = "0000"
            If IsNumeric(txt科目CDFrom.Text) Then
                Tmp(3) = Integer.Parse(txt科目CDTo.Text).ToString("0000")
            End If

            txt決算期.Text = 1
            SQL = "Select aexp.a_volum2.ki " _
            & "From aexp.a_volum2 " _
            & "WHERE (aexp.a_volum2.symd Between " & Tmp(0) & " And " & Tmp(1) & ");"
            odbcCommand.CommandText = SQL
            da0.SelectCommand = odbcCommand
            da0.Fill(dt0, "t0")
            If dt0.Tables("t0").Rows.Count > 0 Then
                txt決算期.Text = dt0.Tables("t0").Rows(0)("ki")
            End If
            dt0.Tables("t0").Clear()

            SQL = "DELETE T_支払仕訳明細.* " _
                & "From T_支払仕訳明細;"
            TmpDB.Execute(SQL)

            Dim r10 As dao.Recordset = TmpDB.OpenRecordset("T_支払仕訳明細", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
            r10.Index = "Key_0"
            SQL = "Select aexp.a_zdata.ki, aexp.a_zdata.dkei, aexp.a_zdata.dseq, aexp.a_zdata.dymd, aexp.a_zdata.dcno, " _
                & "aexp.a_zdata.dcpg, aexp.a_zdata.dlin, " _
                & "aexp.a_zdata.rbmn, aexp.a_zdata.rtor, aexp.a_zdata.rkmk, aexp.a_zdata.reda, aexp.a_zdata.rtky, " _
                & "aexp.a_zdata.sbmn, aexp.a_zdata.stor, aexp.a_zdata.skmk, aexp.a_zdata.seda, aexp.a_zdata.stky, " _
                & "aexp.a_zdata.valu, aexp.a_zdata.symd, aexp.a_zdata.skbn, aexp.a_zdata.skiz, aexp.a_zdata.rrit, aexp.a_zdata.srit, " _
                & "aexp.a_zdata.rkeigen, aexp.a_zdata.skeigen, aexp.a_zdata.rmenzeikeika, aexp.a_zdata.smenzeikeika " _
                & "FROM aexp.a_zdata " _
                & "WHERE (aexp.a_zdata.ki=" & txt決算期.Text & ") " _
                & "And (aexp.a_zdata.dymd>=" & Tmp(0) & ") " _
                & "And (aexp.a_zdata.dymd<=" & Tmp(1) & ") " _
                & "And (aexp.a_zdata.skmk='" & Tmp(2) & "') " _
                & "OR (aexp.a_zdata.ki=" & txt決算期.Text & ") " _
                & "AND (aexp.a_zdata.dymd>=" & Tmp(0) & ") " _
                & "AND (aexp.a_zdata.dymd<=" & Tmp(1) & ") " _
                & "AND (aexp.a_zdata.rkmk='" & Tmp(3) & "');"
            odbcCommand.CommandText = SQL
            da0.SelectCommand = odbcCommand
            da0.Fill(dt0, "t0")

            With dt0.Tables("t0")
                For i0 As Integer = 0 To .Rows.Count - 1
                    r10.AddNew()
                    r10.Fields("会社No").Value = pubComPany
                    r10.Fields("決算期").Value = .Rows(i0)("KI")
                    r10.Fields("経過月").Value = .Rows(i0)("DKEI")
                    r10.Fields("SEQNo").Value = .Rows(i0)("DSEQ")
                    r10.Fields("伝票日付").Value = IIf(IsNumeric(.Rows(i0)("DYMD")), .Rows(i0)("DYMD"), DBNull.Value)
                    r10.Fields("伝票No").Value = IIf(IsNumeric(.Rows(i0)("DCNO")), .Rows(i0)("DCNO"), DBNull.Value)
                    r10.Fields("伝票頁").Value = IIf(IsNumeric(.Rows(i0)("DCPG")), .Rows(i0)("DCPG"), DBNull.Value)
                    r10.Fields("伝票行").Value = IIf(IsNumeric(.Rows(i0)("DLIN")), .Rows(i0)("DLIN"), DBNull.Value)
                    r10.Fields("借方部門CD").Value = IIf(IsNumeric(.Rows(i0)("RBMN")), .Rows(i0)("RBMN"), DBNull.Value)
                    r10.Fields("借方取引先CD").Value = IIf(IsNumeric(.Rows(i0)("RTOR")), .Rows(i0)("RTOR"), DBNull.Value)
                    r10.Fields("借方科目CD").Value = IIf(IsNumeric(.Rows(i0)("RKMK")), .Rows(i0)("RKMK"), DBNull.Value)
                    r10.Fields("借方枝番CD").Value = IIf(IsNumeric(.Rows(i0)("REDA")), .Rows(i0)("REDA"), DBNull.Value)
                    r10.Fields("借方摘要").Value = IIf(IsNumeric(.Rows(i0)("RTKY")), .Rows(i0)("RTKY"), DBNull.Value)
                    r10.Fields("貸方部門CD").Value = IIf(IsNumeric(.Rows(i0)("SBMN")), .Rows(i0)("SBMN"), DBNull.Value)
                    r10.Fields("貸方取引先CD").Value = IIf(IsNumeric(.Rows(i0)("STOR")), .Rows(i0)("STOR"), DBNull.Value)
                    r10.Fields("貸方科目CD").Value = IIf(IsNumeric(.Rows(i0)("SKMK")), .Rows(i0)("SKMK"), DBNull.Value)
                    r10.Fields("貸方枝番CD").Value = IIf(IsNumeric(.Rows(i0)("SEDA")), .Rows(i0)("SEDA"), DBNull.Value)
                    r10.Fields("貸方摘要").Value = IIf(IsNumeric(.Rows(i0)("STKY")), .Rows(i0)("STKY"), DBNull.Value)
                    If .Rows(i0)("SKMK") = Tmp(2) Then
                        r10.Fields("貸方金額").Value = IIf(IsNumeric(.Rows(i0)("VALU")), .Rows(i0)("VALU"), 0)
                    End If
                    If .Rows(i0)("RKMK") = Tmp(3) Then
                        r10.Fields("借方金額").Value = IIf(IsNumeric(.Rows(i0)("VALU")), .Rows(i0)("VALU"), 0)
                    End If
                    r10.Fields("借方軽減税率区分").Value = IIf(IsNumeric(.Rows(i0)("RKEIGEN")), .Rows(i0)("RKEIGEN"), DBNull.Value)
                    r10.Fields("借方税率").Value = IIf(IsNumeric(.Rows(i0)("RRIT")), .Rows(i0)("RRIT"), DBNull.Value)
                    r10.Fields("貸方軽減税率区分").Value = IIf(IsNumeric(.Rows(i0)("SKEIGEN")), .Rows(i0)("SKEIGEN"), DBNull.Value)
                    r10.Fields("貸方税率").Value = IIf(IsNumeric(.Rows(i0)("SRIT")), .Rows(i0)("SRIT"), DBNull.Value)
                    r10.Fields("借方仕入経過区分").Value = IIf(IsNumeric(.Rows(i0)("RMENZEIKEIKA")), .Rows(i0)("RMENZEIKEIKA"), DBNull.Value)
                    r10.Fields("貸方仕入経過区分").Value = IIf(IsNumeric(.Rows(i0)("SMENZEIKEIKA")), .Rows(i0)("SMENZEIKEIKA"), DBNull.Value)

                    r10.Fields("支払日").Value = IIf(IsNumeric(.Rows(i0)("SYMD")), .Rows(i0)("SYMD"), DBNull.Value)
                    r10.Fields("支払区分").Value = IIf(IsNumeric(.Rows(i0)("SKBN")), .Rows(i0)("SKBN"), DBNull.Value)
                    r10.Fields("支払期日").Value = IIf(IsNumeric(.Rows(i0)("SKIZ")), .Rows(i0)("SKIZ"), DBNull.Value)
                    r10.Fields("支払年度").Value = DBNull.Value
                    r10.Fields("支払No").Value = DBNull.Value
                    r10.Update()
                Next
            End With
        Catch ex As Exception
            MsgBox("★ODBC例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
            Logger.log("★ODBC例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
        Finally
            dt0.Dispose() : dt0 = Nothing
            da0.Dispose() : da0 = Nothing
            odbcconn.Close() : odbcconn.Dispose()
            odbcCommand.Dispose()
        End Try
    End Sub
    '***************************
    '* 財務仕訳インポート処理
    '***************************
    Public Sub MakeData002()
        Dim odbcconn As New OdbcConnection()
        Dim odbcCommand As New OdbcCommand()
        Dim da0 As New OdbcDataAdapter
        Dim dt0 As New DataSet
        Dim SQL As String, Tmp(10)

        AddLog("財務仕訳インポート処理-1を開始しました..." & vbCrLf)


        Tmp(0) = 99999999
        If IsDate(txt開始日.Text) Then
            Tmp(0) = Date.Parse(txt開始日.Text).ToString("yyyyMMdd")
        End If
        Tmp(1) = 99999999
        If IsDate(txt終了日.Text) Then
            Tmp(1) = Date.Parse(txt終了日.Text).ToString("yyyyMMdd")
        End If

        SQL = "SELECT aexp.a_volum2.ki " _
            & "FROM aexp.a_volum2 " _
            & "WHERE (aexp.a_volum2.symd BETWEEN " & Tmp(0) & " AND " & Tmp(1) & ");"
        odbcCommand.CommandText = SQL
        da0.SelectCommand = odbcCommand
        da0.Fill(dt0, "t0")
        If dt0.Tables("t0").Rows.Count > 0 Then
            txt決算期.Text = dt0.Tables("t0").Rows(0)("ki")
        End If
        dt0.Tables("t0").Clear()

        SQL = "DELETE T_支払仕訳明細.* " _
        & "From T_支払仕訳明細;"
        TmpDB.Execute(SQL)

        Dim r10 As dao.Recordset = ComDB.OpenRecordset("T_支払仕訳明細", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r10.Index = "Key_0"
        SQL = "SELECT aexp.a_zdata.ki, aexp.a_zdata.dkei, aexp.a_zdata.dseq, aexp.a_zdata.dymd, aexp.a_zdata.dcno, " _
            & "aexp.a_zdata.dcpg, aexp.a_zdata.dlin, " _
            & "aexp.a_zdata.rbmn, aexp.a_zdata.rtor, aexp.a_zdata.rkmk, aexp.a_zdata.reda, aexp.a_zdata.rtky, " _
            & "aexp.a_zdata.sbmn, aexp.a_zdata.stor, aexp.a_zdata.skmk, aexp.a_zdata.seda, aexp.a_zdata.stky, " _
            & "aexp.a_zdata.valu, aexp.a_zdata.symd, aexp.a_zdata.skbn, aexp.a_zdata.skiz, aexp.a_zdata.rrit, aexp.a_zdata.srit, " _
            & "aexp.a_zdata.rkeigen, aexp.a_zdata.skeigen, aexp.a_zdata.rmenzeikeika, aexp.a_zdata.smenzeikeika " _
            & "FROM aexp.a_zdata " _
            & "WHERE (aexp.a_zdata.ki=" & "決算期" & ") " _
            & "AND (aexp.a_zdata.dymd>=" & Tmp(0) & ") " _
            & "AND (aexp.a_zdata.dymd<=" & Tmp(1) & ") " _
            & "AND (aexp.a_zdata.skmk='0302') " _
            & "OR (aexp.a_zdata.ki=" & "決算期" & ") " _
            & "AND (aexp.a_zdata.dymd>=" & Tmp(0) & ") " _
            & "AND (aexp.a_zdata.dymd<=" & Tmp(1) & ") " _
            & "AND (aexp.a_zdata.rkmk='0302');"
        odbcCommand.CommandText = SQL
        da0.SelectCommand = odbcCommand
        da0.Fill(dt0, "t0")

        With dt0.Tables("t0")
            For i0 As Integer = 0 To .Rows.Count - 1

                r10.AddNew()
                r10.Fields("会社No").Value = pubComPany
                r10.Fields("決算期").Value = .Rows(i0)("KI")
                r10.Fields("経過月").Value = .Rows(i0)("DKEI")
                r10.Fields("SEQNo").Value = .Rows(i0)("DSEQ")
                r10.Fields("伝票日付").Value = IIf(IsNumeric(.Rows(i0)("DYMD")), .Rows(i0)("DYMD"), DBNull.Value)
                r10.Fields("伝票No").Value = IIf(IsNumeric(.Rows(i0)("DCNO")), .Rows(i0)("DCNO"), DBNull.Value)
                r10.Fields("伝票頁").Value = IIf(IsNumeric(.Rows(i0)("DCPG")), .Rows(i0)("DCPG"), DBNull.Value)
                r10.Fields("伝票行").Value = IIf(IsNumeric(.Rows(i0)("DLIN")), .Rows(i0)("DLIN"), DBNull.Value)
                r10.Fields("借方部門CD").Value = IIf(IsNumeric(.Rows(i0)("RBMN")), .Rows(i0)("RBMN"), DBNull.Value)
                r10.Fields("借方取引先CD").Value = IIf(IsNumeric(.Rows(i0)("RTOR")), .Rows(i0)("RTOR"), DBNull.Value)
                r10.Fields("借方科目CD").Value = IIf(IsNumeric(.Rows(i0)("RKMK")), .Rows(i0)("RKMK"), DBNull.Value)
                r10.Fields("借方枝番CD").Value = IIf(IsNumeric(.Rows(i0)("REDA")), .Rows(i0)("REDA"), DBNull.Value)
                r10.Fields("借方摘要").Value = IIf(IsNumeric(.Rows(i0)("RTKY")), .Rows(i0)("RTKY"), DBNull.Value)
                r10.Fields("貸方部門CD").Value = IIf(IsNumeric(.Rows(i0)("SBMN")), .Rows(i0)("SBMN"), DBNull.Value)
                r10.Fields("貸方取引先CD").Value = IIf(IsNumeric(.Rows(i0)("STOR")), .Rows(i0)("STOR"), DBNull.Value)
                r10.Fields("貸方科目CD").Value = IIf(IsNumeric(.Rows(i0)("SKMK")), .Rows(i0)("SKMK"), DBNull.Value)
                r10.Fields("貸方枝番CD").Value = IIf(IsNumeric(.Rows(i0)("SEDA")), .Rows(i0)("SEDA"), DBNull.Value)
                r10.Fields("貸方摘要").Value = IIf(IsNumeric(.Rows(i0)("STKY")), .Rows(i0)("STKY"), DBNull.Value)
                If .Rows(i0)("SKMK") = "0302" Then
                    r10.Fields("貸方金額").Value = IIf(IsNumeric(.Rows(i0)("VALU")), .Rows(i0)("VALU"), 0)
                End If
                If .Rows(i0)("RKMK") = "0302" Then
                    r10.Fields("借方金額").Value = IIf(IsNumeric(.Rows(i0)("VALU")), .Rows(i0)("VALU"), 0)
                End If
                r10.Fields("借方軽減税率区分").Value = IIf(IsNumeric(.Rows(i0)("RKEIGEN")), .Rows(i0)("RKEIGEN"), DBNull.Value)
                r10.Fields("借方税率").Value = IIf(IsNumeric(.Rows(i0)("RRIT")), .Rows(i0)("RRIT"), DBNull.Value)
                r10.Fields("貸方軽減税率区分").Value = IIf(IsNumeric(.Rows(i0)("SKEIGEN")), .Rows(i0)("SKEIGEN"), DBNull.Value)
                r10.Fields("貸方税率").Value = IIf(IsNumeric(.Rows(i0)("SRIT")), .Rows(i0)("SRIT"), DBNull.Value)
                r10.Fields("借方仕入経過区分").Value = IIf(IsNumeric(.Rows(i0)("RMENZEIKEIKA")), .Rows(i0)("RMENZEIKEIKA"), DBNull.Value)
                r10.Fields("貸方仕入経過区分").Value = IIf(IsNumeric(.Rows(i0)("SMENZEIKEIKA")), .Rows(i0)("SMENZEIKEIKA"), DBNull.Value)

                r10.Fields("支払日").Value = IIf(IsNumeric(.Rows(i0)("SYMD")), .Rows(i0)("SYMD"), DBNull.Value)
                r10.Fields("支払区分").Value = IIf(IsNumeric(.Rows(i0)("SKBN")), .Rows(i0)("SKBN"), DBNull.Value)
                r10.Fields("支払期日").Value = IIf(IsNumeric(.Rows(i0)("SKIZ")), .Rows(i0)("SKIZ"), DBNull.Value)
                r10.Fields("支払年度").Value = DBNull.Value
                r10.Fields("支払No").Value = DBNull.Value
                r10.Update()
            Next
        End With
    End Sub
    '***************************
    '*
    '***************************
    Public Sub MakeData010()
        Dim SQL As String, Tmp(5), pFl(1) As Boolean

        AddLog("財務仕訳インポート処理-2を開始しました..." & vbCrLf)

        Dim r10 As dao.Recordset = DB.OpenRecordset("T_支払仕訳明細", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r10.Index = "Key_0"

        SQL = "SELECT T_支払仕訳明細.* " _
            & "From T_支払仕訳明細 " _
            & "WHERE (T_支払仕訳明細.会社No=" & pubComPany & ")"
        If Not txt伝票日付開始日.Text = "" Then
            SQL &= " AND (T_支払仕訳明細.伝票日付>=" & Date.Parse(txt伝票日付開始日.Text).ToString("yyyyMMdd") & ")"
        End If
        If Not txt伝票日付終了日.Text = "" Then
            SQL &= " AND (T_支払仕訳明細.伝票日付<=" & Date.Parse(txt伝票日付終了日.Text).ToString("yyyyMMdd") & ")"
        End If
        If Not txt伝票開始番号.Text = "" Then
            SQL &= " AND (T_支払仕訳明細.伝票No>=" & txt伝票開始番号.Text & ")"
        End If
        If Not txt伝票終了番号.Text = "" Then
            SQL = SQL & " AND (T_支払仕訳明細.伝票No<=" & txt伝票終了番号.Text & ")"
        End If
        If Not txt支払指定開始日.Text = "" Then
            SQL &= " AND (T_支払仕訳明細.支払日>=" & Date.Parse(txt支払指定開始日.Text).ToString("yyyyMMdd") & ")"
        End If
        If Not txt支払指定終了日.Text = "" Then
            SQL &= " AND (T_支払仕訳明細.支払日<=" & Date.Parse(txt支払指定終了日.Text).ToString("yyyyMMdd") & ")"
        End If

        Dim r0 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            pFl(0) = True
            If Not txt取引先CDFrom.Text = "" Then
                If txt取引先CDFrom.Text < r0.Fields("貸方取引先CD").Value Then
                    pFl(0) = False
                End If
            End If
            If pFl(0) = True Then
                If Not txt取引先CDTo.Text = "" Then
                    If txt取引先CDTo.Text > r0.Fields("貸方取引先CD").Value Then
                        pFl(0) = False
                    End If
                End If
            End If
            If pFl(0) = True Then
                r10.Seek("=", r0.Fields("会社No").Value, r0.Fields("決算期").Value, r0.Fields("経過月").Value, r0.Fields("SEQNo").Value)
                If r10.NoMatch Then
                    r10.AddNew()
                    r10.Fields("会社No").Value = r0.Fields("会社No").Value
                    r10.Fields("決算期").Value = r0.Fields("決算期").Value
                    r10.Fields("経過月").Value = r0.Fields("経過月").Value
                    r10.Fields("SEQNo").Value = r0.Fields("SEQNo").Value
                    r10.Fields("支払年度").Value = DBNull.Value
                    r10.Fields("支払No").Value = DBNull.Value
                Else
                    r10.Edit()
                End If
                r10.Fields("伝票日付").Value = r0.Fields("伝票日付").Value
                r10.Fields("伝票No").Value = r0.Fields("伝票No").Value
                r10.Fields("伝票頁").Value = r0.Fields("伝票頁").Value
                r10.Fields("伝票行").Value = r0.Fields("伝票行").Value
                r10.Fields("借方部門CD").Value = r0.Fields("借方部門CD").Value
                r10.Fields("借方取引先CD").Value = r0.Fields("借方取引先CD").Value
                r10.Fields("借方科目CD").Value = r0.Fields("借方科目CD").Value
                r10.Fields("借方枝番CD").Value = r0.Fields("借方枝番CD").Value
                r10.Fields("借方軽減税率区分").Value = r0.Fields("借方軽減税率区分").Value
                r10.Fields("借方税率").Value = r0.Fields("借方税率").Value
                r10.Fields("借方摘要").Value = r0.Fields("借方摘要").Value
                r10.Fields("借方金額").Value = r0.Fields("借方金額").Value
                r10.Fields("貸方部門CD").Value = r0.Fields("貸方部門CD").Value
                r10.Fields("貸方取引先CD").Value = r0.Fields("貸方取引先CD").Value
                r10.Fields("貸方科目CD").Value = r0.Fields("貸方科目CD").Value
                r10.Fields("貸方枝番CD").Value = r0.Fields("貸方枝番CD").Value
                r10.Fields("貸方軽減税率区分").Value = r0.Fields("貸方軽減税率区分").Value
                r10.Fields("貸方税率").Value = r0.Fields("貸方税率").Value
                r10.Fields("貸方摘要").Value = r0.Fields("貸方摘要").Value
                r10.Fields("貸方金額").Value = r0.Fields("貸方金額").Value
                r10.Fields("借方仕入経過区分").Value = r0.Fields("借方仕入経過区分").Value
                r10.Fields("貸方仕入経過区分").Value = r0.Fields("貸方仕入経過区分").Value
                r10.Fields("支払日").Value = r0.Fields("支払日").Value
                r10.Fields("支払区分").Value = r0.Fields("支払区分").Value
                r10.Fields("支払期日").Value = r0.Fields("支払期日").Value
                r10.Update()
            End If
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        r10.Close() : r10 = Nothing
    End Sub

    Private Sub txtInp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        pTxtBox.SelectAll()
        pTxtBox.BackColor = Color.MistyRose

        pFocus(0) = pTxtBox
    End Sub

    'Private Sub txtInp_KeyDown(Index As Integer, KeyCode As Integer, Shift As Integer)
    '    Select Case KeyCode
    '        Case 38 '↑ 'フォーカスを戻す
    '        Case 123 'F12(検索)
    '            Select Case Index
    '                Case 6, 7
    '                    pubPARM(0) = ""
    '                    F_S_KaM.Show 1
    '        If pubPARM(0) <> "" Then
    '                        txtInp(Index) = Format(pubPARM(0), "00000")
    '                    End If
    '                    pubPARM(0) = ""
    '                Case 8, 9
    '                    pubPARM(0) = ""
    '                    F_S_TorHik.Show 1
    '        If pubPARM(0) <> "" Then
    '                        txtInp(Index) = Format(pubPARM(0), "00000")
    '                    End If
    '                    pubPARM(0) = ""
    '            End Select
    '    End Select
    'End Sub
    Private Sub txtInp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case 38
                Me.SelectNextControl(sender, False, True, True, True)
                e.Handled = True
        End Select
    End Sub

    'Private Sub txtInp_KeyPress(Index As Integer, KeyAscii As Integer)
    '    Dim pRes As Boolean

    '    Select Case Index
    '        Case 0, 1, 4, 5
    '            Select Case KeyAscii
    '                Case 47, 48 To 57, 8, 13
    '                Case Else
    '                    KeyAscii = 0
    '            End Select
    '        Case Else
    '            Select Case KeyAscii
    '                Case 48 To 57, 8, 13
    '                Case Else
    '                    KeyAscii = 0
    '            End Select
    '    End Select

    '    If KeyAscii = 13 Then
    '        pRes = Inp_Chk01(Index, Index)
    '        If pRes = True Then
    '            Call Get_TagNext(txtInp(Index).TabIndex)
    '        End If
    '        KeyAscii = 0
    '    End If
    'End Sub

    Private Sub txtInp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        Select Case pTxtBox.Name
            Case "txt伝票日付開始日", "txt伝票日付終了日", "txt支払指定開始日", "txt支払指定終了日"
                Select Case e.KeyChar
                    Case ChrW(47), ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select

            Case Else
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select

        End Select

        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                Dim pRet As Boolean = Inp_Chk00(sender)
                If pRet = False Then Exit Sub
                SelectNextControl(sender, True, True, True, True)
                e.Handled = True
        End Select
    End Sub

    Private Sub txtInp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub


        pTxtBox.BackColor = Color.White
    End Sub
    Private Sub Cmba_Enter(sender As Object, e As EventArgs) Handles CmbA.Enter
        RemoveHandler CmbA.SelectedIndexChanged, AddressOf CmbA_SelectedIndexChanged
        AddHandler CmbA.SelectedIndexChanged, AddressOf CmbA_SelectedIndexChanged
    End Sub

    Private Sub BtnUp00_Click(sender As Object, e As EventArgs) Handles btnUp00.Click

        Dim wRes As Boolean = Inp_Chk90()
        If wRes = False Then Exit Sub

        For Each CtrlItem As Control In GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then
                wRes = Inp_Chk00(CtrlItem)
                If wRes = False Then Exit Sub
            End If
        Next
        Cursor.Current = Cursors.Default : Me.Enabled = False
        txtLog.Visible = True

        If txt処理対象仕訳.Text = 1 Then MakeData000()
        MakeData001()
        MakeData010()
        Data_Put00()
        MsgBox("支払集計処理が完了しました")
        Close()
        Cursor.Current = Cursors.Default : Me.Enabled = True
    End Sub

    Private Sub F_Si_SiwGet00_Load(sender As Object, e As EventArgs) Handles Me.Load
        MyProc.GetNen10()
        Inp_Clr00()
        Dsp_Init00()
        Add_Cmb00()
        Item_Add()
        Dsp_Init10()
        Dsp_Set00()
        Inp_Chk90()
        For Each CtrlItem As Control In GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then
                Inp_Chk00(CtrlItem)
            End If
        Next

        ActiveControl = txt伝票日付開始日
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txt処理No.Text = 1
        Dsp_Set00()
        Inp_Chk90()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txt処理No.Text = 2
        Dsp_Set00()
        Inp_Chk90()
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txt処理No.Text = 3
        Dsp_Set00()
        Inp_Chk90()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txt処理No.Text = 4
        Dsp_Set00()
        Inp_Chk90()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txt処理No.Text = 5
        Dsp_Set00()
        Inp_Chk90()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txt処理No.Text = 6
        Dsp_Set00()
        Inp_Chk90()

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txt処理No.Text = 7
        Dsp_Set00()
        Inp_Chk90()

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txt処理No.Text = 8
        Dsp_Set00()
        Inp_Chk90()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txt処理No.Text = 9
        Dsp_Set00()
        Inp_Chk90()
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        txt処理No.Text = 10
        Dsp_Set00()
        Inp_Chk90()
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        txt処理No.Text = 11
        Dsp_Set00()
        Inp_Chk90()
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        txt処理No.Text = 12
        Dsp_Set00()
        Inp_Chk90()
    End Sub

    Private Sub Cmd10_Click(sender As Object, e As EventArgs) Handles Cmd10.Click
        Close()
    End Sub

    Private Sub CmbA_SelectedIndexChanged(sender As Object, e As EventArgs)
        If CmbA.SelectedIndex = -1 Then
        Else
            txt決算期.Text = 1
            Dsp_Set00()
            Inp_Chk90()
        End If
    End Sub

    Private Sub La科目From1_Click(sender As Object, e As EventArgs) Handles La科目From1.Click
        Dim frmForm = New F_S_Kam00
        frmForm.pubKaCD = ""
        frmForm.pubFrom = ""
        frmForm.pubTo = ""
        If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt科目CDFrom.Text = frmForm.pubKaCD
            Inp_Chk00(txt科目CDFrom)
        End If
        frmForm.Dispose()
    End Sub

    Private Sub La科目To1_Click(sender As Object, e As EventArgs) Handles La科目To1.Click
        Dim frmForm = New F_S_Kam00
        frmForm.pubKaCD = ""
        frmForm.pubFrom = ""
        frmForm.pubTo = ""
        If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txt科目CDTo.Text = frmForm.pubKaCD
            Inp_Chk00(txt科目CDTo)
        End If
        frmForm.Dispose()
    End Sub

    Private Sub CmbB_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim item As MyComboBoxItemA
        If CmbB.SelectedIndex = -1 Then txt処理対象仕訳.Text = ""

        item = DirectCast(CmbB.SelectedItem, MyComboBoxItemA)
        txt処理対象仕訳.Text = item.ItemCode
    End Sub

    Private Sub CmbB_Enter(sender As Object, e As EventArgs) Handles CmbB.Enter
        RemoveHandler CmbB.SelectedIndexChanged, AddressOf CmbB_SelectedIndexChanged
        AddHandler CmbB.SelectedIndexChanged, AddressOf CmbB_SelectedIndexChanged
    End Sub
End Class
