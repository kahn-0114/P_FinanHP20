Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Data.Odbc
Imports dao
Imports GrapeCity.ActiveReports.Rdl.Themes

Public Class F_Si_SiwGet00
    Dim pFocus(10) As Object
    Dim MyCom As New Com
    Dim pubProc As New Proc
    Dim pDateFormat As String = "yyyy/MM/dd"
    Private Mysqlserver As SQLServer = New SQLServer()


    '* ！のやつ　　　　　　　　 　 r10.Fields("").Value = dt0.Fields("").Value
    '*  iのやつ　　　　　　　　　  For i AS Integer 、　Next i　←　i省略可  
    '*  Formatのやつ               r10("" & i).Value = r0("" & i.ToString("00") & "0").Value
    '*  Closeのやつ　　　　　　　  r10.Close() : r10 = Nothing  
    '*  Null → DBNull.Value 　　　IsDBNull →　IsDBNull
    '*オフにしていい　Workspace　OpenConnection
    '*
    '*Dim r0 As dao.Recordset = ComDB.OpenRecordset("〇", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
    '*Dim r0 As dao.Recordset = ComDB.OpenRecordset("〇", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
    '*
    '*Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
    '*Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenDynaset, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
    '
    'Dim r0 As Recordset = DB.OpenRecordset(Sql, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
    'r0 = DB.OpenRecordset(Sql, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)

    '*
    '*Screen.MousePointer　→　Cursor.Current = Cursors.Default
    '*MsgBox(txtMsg)
    '*RepDB = OpenDatabase(pubRepDB, False)　→　RepDB = DaoEngine.OpenDatabase(pubRepDB)
    '*Currency →　Decimal
    '*r0.Fields("").Value →   .Rows(i0)("")
    '*ｑ0のときだけr0.Fields("").Value →   .Rows(i0)("")
    'Ceant→Integer.Parse
    '******************************************************
    '* ComboBoxにItemを追加
    '******************************************************

    '*
    '******************************************************
    Private Function Dsp_Set00()
        Dim SQL As String
        Dim pSino As Integer, Tmp(10), pNen As Long

        For i As Integer = 1 To 12
            GroupBox10.Controls("btn" & i).Text = "" : GroupBox10.Controls("btn" & i).Visible = False
        Next i
        If IsNumeric(txt処理No.Text) = True Then
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
            & "And (年度 =" & cmba.Text & ") " _
            & "ORDER BY MM_決算期.締No;"
        Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Dim i0 As Integer = 0
        Do Until r0.EOF
            i0 += 1
            GroupBox10.Controls("btn" & i0).Text = (Date.Parse(r0.Fields("締月").Value).ToString("MM月"))
            If i0 = pSino Then
                GroupBox10.Controls("btn" & i0).BackColor = Color.LightBlue

                GroupBox10.Controls("btn" & i0).BackColor = SystemColors.Control

            End If
            GroupBox10.Controls("btn" & i0).Visible = True
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
    End Function
    '******************************************************
    '* リストにItemを表示する共通関数
    '******************************************************
    Private Function Item_ADD()
        Dim pRet As Integer, i As Integer
        Dim SQL As String
        Dim itmX As ListItem


        'lv.ListItems.Clear mrutirowになるよ
        SQL = "SELECT T_HIS_財務Imp.* " _
            & "From T_HIS_財務Imp " _
            & "Where (T_HIS_財務Imp.会社No=" & pubComPany & ") " _
            & "ORDER BY T_HIS_財務Imp.RecNo DESC;"
        Dim r0 As dao.Recordset = DB.OpenRecordset(Sql, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        i = 0
        Do Until r0.EOF
            i = i + 1
            If i > 10 Then
                Exit Do
            End If
            'itmX = lv.ListItems.Add(, , Format(i, "00"))
            itmX.SubItems(1) = IIf(IsDBNull(r0.Fields("処理日時").Value), "", r0.Fields("処理日時").Value)
            itmX.SubItems(2) = IIf(IsDBNull(r0.Fields("対象年月").Value), "", Format(r0.Fields("対象年月").Value, "0000年00月"))
            itmX.SubItems(3) = IIf(IsDBNull(r0.Fields("対象処理").Value), "", r0.Fields("対象処理").Value)
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
    End Function
    Public Sub AddLog(ByVal s As String)


        With txtLog
            If Len(.Text) > 32000 Then .Text = ""
            .SelectAll()
        End With
    End Sub

    '******************************************************
    '*
    '******************************************************
    Private Function Dsp_Init00()
        'Dim r1 As Recordset
        'Dim SQL As String, i As Integer, Tmp(10)



        'SQL = "SELECT MM_決算期.年度 " _
        '    & "From MM_決算期 " _
        '    & "Where (MM_決算期.会社No =" & pubComPany & ") " _
        '    & "GROUP BY MM_決算期.年度 " _
        '    & "ORDER BY MM_決算期.年度 DESC;"
        'Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        'i = -1
        'i = 0
        'Do Until r0.EOF
        '    Dim pCD As String = MyCom.ChgNull(i)
        '    Dim pName As String = MyCom.ChgNull(r0.Fields("年度"), 1)
        '    ComboItemA.Add(New MyComboBoxItemA(pName, pCD))
        '    r0.MoveNext()
        'Loop
        'r0.Close() : r0 = Nothing
        'cmba.SelectedIndex = 0

        'txt処理No.Text = 1
        'r0 = DB.OpenRecordset("MM_SYS", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        'r0.Index = "Key_0"
        'r0.Seek("=", pubComPany, pubLogInName, 0)
        'If r0.NoMatch Then
        'Else
        '    For i = 0 To cmba.ListCount - 1
        '        Tmp(0) = -1
        '        If IsNumeric(cmba.ItemData(i)) Then
        '            Tmp(0) = CInt(cmba.ItemData(i))
        '        End If
        '        If Tmp(0) = r0.Fields("年度").Value Then
        '            cmba.ListIndex = i
        '            Exit For
        '        End If
        '    Next
        '    txt処理No.Text = IIf(IsDBNull(r0.Fields("締No").Value), 1, r0.Fields("締No").Value)
        'End If
        'r0.Close() : r0 = Nothing

        'r0 = ComDB.OpenRecordset("MM_SiPat", dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        'r0.Index = "Key_0"
        'r0.Seek("=", pubComPany, 900, 10)
        'If r0.NoMatch Then
        'Else
        '    txt科目CDFrom.Text = r0.Fields("借方科目").Value
        '    txt科目CDTo.Text = r0.Fields("借方科目").Value
        'End If
        'r0.Close() : r0 = Nothing
    End Function
    '****************************************************************
    '**
    '****************************************************************
    Public Function Data_Put00()
        Dim SQL As String, Tmp(10), i As Integer, pNo As Long

        pNo = 1
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
        r0.Fields("処理日時").Value = Format(Now, "yyyy/mm/dd hh:mm:ss")
        r0.Fields("対象年月").Value = Format("対象年月１", "yyyymm")
        Select Case "処理対象仕訳"
            Case 0
                r0.Fields("対象処理").Value = "差分インポート"
            Case 1
                r0.Fields("対象処理").Value = "全件インポート"
        End Select
        r0.Update()
        r0.Close() : r0 = Nothing
    End Function

    Private Sub Btn_Click(Index As Integer)
        txt処理No.Text = Index + 1
        Call Dsp_Set00()
        'Call Inp_Chk00()
    End Sub

    Private Sub btnUp_Click(Index As Integer)
        Dim pRes As Boolean
        Dim SQL As String

        Select Case Index
            Case 0
                'pRes = Inp_Chk00()

                'If pRes = False Then
                '    Exit Sub
                'End If
                'pRes = Inp_Chk01(0, txtInp.Count - 1)
                'If pRes = False Then
                '    Exit Sub
                'End If

                Cursor.Current = Cursors.Default : Me.Enabled = False
                If "処理対象仕訳" = 1 Then
                    Call MakeData000()
                End If
                'Select Case pubComPany
                'Case 5
                '    Call MakeData002
                'Case Else
                '    Call MakeData001
                'End Select
                Call MakeData001()
                Call MakeData010()
                Call Data_Put00()
                MsgBox("支払集計処理が完了しました")
                Close()
                Cursor.Current = Cursors.Default : Me.Enabled = True
        End Select
    End Sub



    'Private Sub CmbCD_Click(Index As Integer)
    '    Select Case Index
    '        Case 0
    '            txt処理No.Text = 1
    '            Call Dsp_00()
    '            Call Inp_Chk00()
    '        Case 1
    '            If CmbCD(Index).ListIndex <> -1 Then
    '                txt処理対象仕訳.Text = CmbCD(Index).ItemData(CmbCD(Index).ListIndex)
    '            End If
    '    End Select
    'End Sub



    'Private Sub CmbCD_KeyDown(Index As Integer, KeyCode As Integer, Shift As Integer)
    '    Select Case KeyCode
    '        Case 38 '↑ 'フォーカスを戻す
    '            Get_TagBak(CmbCD(Index).TabIndex)
    '            KeyCode = 0
    '    End Select
    'End Sub

    'Private Sub CmbCD_KeyPress(Index As Integer, KeyAscii As Integer)
    '    Dim i As Integer

    '    Select Case Index
    '        Case Else
    '            Select Case KeyAscii
    '                Case 13, 38              '数値とBSだけ
    '                Case Else
    '                    KeyAscii = 0
    '            End Select
    '    End Select

    '    If KeyAscii = 13 Then
    '        KeyAscii = 0
    '        Call Get_TagNext(CmbCD(Index).TabIndex)
    '    End If
    'End Sub

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



    Private Sub Form_Load()
        'Call SetLVStyle(Me.LV, 1)
        Call Inp_Clr00()
        Call Dsp_Init00()
        Call Item_ADD()
        'Call Inp_Chk00()

        'If cmba.ListIndex <> -1 Then
        '    Call Dsp_Set00()
        'End If
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

    '******************************************************
    ''* 入力チェック関数
    '            Dim SQL As String
    '            SQL = "SELECT * " _
    '                & "FROM MM_区分H00 " _
    '                & "WHERE 会社No = @会社No " _
    '                & "AND 区分 = @区分 "
    '            Dim parameters As New List(Of SqlParameter) From {
    '    New SqlParameter("@会社No", pubComPany),
    '    New SqlParameter("@区分", txt区分CD.Text)
    '}
    '            Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())
    '            If result.Rows.Count = 0 Then
    '                txtMsg.Text = "区分CD不正入力"
    '                Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
    '            Else
    '                txt区分名.Text = pubCom.ChgNull(result.Rows(0)("区分名"), 1)

    '            End If

    '            Exit Function
    '        Case "txt明細CD"
    '            ctxtInp.BackColor = Color.White
    '            If txt明細CD.Text = "" Then
    '                txtMsg.Text = "CD未入力"
    '                Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
    '            End If
    '        Case "txt名称"
    '            ctxtInp.BackColor = Color.White
    '            Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(ctxtInp.Text)
    '            If LenB > 20 Then
    '                txtMsg.Text = "名称超過:20"
    '                Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
    '            End If
    '    End Select

    'End Function
    '******************************************************

    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True
        txtMsg.Visible = False : txtMsg.Text = ""

        Select Case ctxtInp.Name
            Case "txt伝票日付開始日", "txt伝票日付終了日", "txt支払指定開始日", "txt支払指定終了日"
                ctxtInp.BackColor = Color.White : ctxtInp.Tag = ""
                If ctxtInp.Text = "" Then
                    txtMsg.Text = "日付不正入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

                If IsDate(ctxtInp.Text) Then
                    ctxtInp.Text = Date.Parse(ctxtInp.Text).ToString(pDateFormat)
                Else
                    Dim w日付 As String = ""
                    Dim wResult = MyCom.DateChk00(ctxtInp.Text, w日付)
                    If wResult = 1 Then
                        txtMsg.Text = "有効開始日不正"
                        txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : ctxtInp.Tag = "9"
                        Return False
                    Else
                        ctxtInp.Text = w日付

                    End If


                End If

            Case "cmba"
                ctxtInp.BackColor = Color.White
                If cmba.SelectedIndex = -1 Then
                    Inp_Chk00 = False
                    txtMsg.Text = "年度未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If


                If Inp_Chk00 = True Then
                    Dim r0 As dao.Recordset = ComDB.OpenRecordset("MM_決算期", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
                    r0.Index = "Key_0"
                    r0.Seek("=", pubComPany, cmba, txt処理No.Text)
                    If r0.NoMatch Then
                        Inp_Chk00 = False
                        txtMsg.Text = "年度不正"
                    Else
                        txt対象年月1.Text = IIf(IsDBNull(r0.Fields("締月").Value), "", Format(r0.Fields("締月").Value, "yyyy年月"))
                        txt対象年月2.Text = IIf(IsDBNull(r0.Fields("開始").Value), "", Format(r0.Fields("開始").Value, "yyyy/MM/dd"))
                        txt対象年月3.Text = IIf(IsDBNull(r0.Fields("終了").Value), "", Format(r0.Fields("終了").Value, "yyyy/MM/dd"))
                    End If
                    r0.Close() : r0 = Nothing
                End If

                If Inp_Chk00 = False Then : txtMsg.Visible = True
                End If
    '    End Select


    'End Function




    'Private Function Inp_Chk00(ByVal ctxtInp As Control)
    '    Inp_Chk00 = True
    '    txtMsg.Visible = False : txtMsg.Text = ""
    '    Select Case ctxtInp.Name
            Case "txt科目CDFrom"
                Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_科目", dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
                r0.Index = "Key_0"
                r0.Seek("=", pubComPany, txt科目CDFrom名.Text)
                If r0.NoMatch Then
                    Inp_Chk00 = False
                    txtMsg.Text = "科目不正入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                Else
                    txt科目CDFrom.Text = IIf(IsDBNull(r0.Fields("科目名").Value), "", r0.Fields("科目名").Value)
                End If
                r0.Close() : r0 = Nothing

            Case "txt科目CDTo"
                Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_科目", dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
                r0.Index = "Key_0"
                r0.Seek("=", pubComPany, txt科目CDTo名.Text)
                If r0.NoMatch Then
                    Inp_Chk00 = False
                    txtMsg.Text = "科目不正入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                Else
                    txt科目CDTo.Text = IIf(IsDBNull(r0.Fields("科目名").Value), "", r0.Fields("科目名").Value)
                End If
                r0.Close() : r0 = Nothing

            Case "txt取引先CDFrom"
                Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_取引先", dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
                r0.Index = "Key_0"
                r0.Seek("=", pubComPany, txt取引先CDFrom名.Text)
                If r0.NoMatch Then
                    Inp_Chk00 = False
                    txtMsg.Text = "取引先不正入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                Else
                    txt科目CDFrom.Text = IIf(IsDBNull(r0.Fields("取引先名").Value), "", r0.Fields("取引先名").Value)
                End If
                r0.Close() : r0 = Nothing

            Case "txt取引先CDTo"
                Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_取引先", dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
                r0.Index = "Key_0"
                r0.Seek("=", pubComPany, txt取引先CDTo名.Text)
                If r0.NoMatch Then
                    Inp_Chk00 = False
                    txtMsg.Text = "取引先不正入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                Else
                    txt科目CDTo.Text = IIf(IsDBNull(r0.Fields("取引先名").Value), "", r0.Fields("取引先名").Value)
                End If
                r0.Close() : r0 = Nothing




                '    Case "txt処理対象仕訳"
                '        If txtInp(i) = "" Then
                '                CmbCD(1).ListIndex = -1
                '            Else
                '                pFl(0) = False
                '                For X = 0 To CmbCD(1).ListCount - 1
                '                    If txtInp(i) = CmbCD(1).ItemData(X) Then
                '                        CmbCD(1).ListIndex = X
                '                        pFl(0) = True
                '                        Exit For
                '                    End If
                '                Next X
                '                If pFl(0) = False Then
                '                    Inp_Chk01 = False
                '                    txtMsg.Text = "処理対象仕訳不正入力"
                '                End If
                '            End If

        End Select
        '    If Inp_Chk01() = False Then
        '        txtInp(i).BackColor = &H8080FF
        '    Else
        '        txtInp(i).BackColor = &HFFFFFF
        '    End If
        'Next i
        'If Inp_Chk01() = False Then
        '    txtMsg.Visible = True
        'End If
    End Function



    '***************************
    '* 財務仕訳インポート処理
    '***************************
    Public Function MakeData000()
        Dim SQL As String, Tmp(10), i As Integer

        Tmp(0) = Format("対象年月2", "yyyymmdd")
        Tmp(1) = Format("対象年月3", "yyyymmdd")

        SQL = "DELETE T_支払仕訳明細.* " _
            & "From T_支払仕訳明細 " _
            & "WHERE (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "And (T_支払仕訳明細.伝票日付>=" & Tmp(0) & ") " _
            & "And (T_支払仕訳明細.伝票日付<=" & Tmp(1) & ") " _
            & "And (T_支払仕訳明細.支払完了F= 0);"
        DB.Execute(SQL)

    End Function
    '***************************
    '* 財務仕訳インポート処理
    '***************************
    Public Function MakeData001()
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
            Tmp(0) = Format("対象年月2", "yyyymmdd")
            Tmp(1) = Format("対象年月3", "yyyymmdd")
            Tmp(2) = Format("科目CDFrom", "0000")
            Tmp(3) = Format("科目CDTo", "0000")

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
            odbcCommand.Dispose() : odbcCommand = Nothing
            odbcconn.Close() : odbcconn.Dispose() : odbcconn = Nothing

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
                    If .Rows(i0)("SKMK").Value = Tmp(2) Then
                        r10.Fields("貸方金額").Value = IIf(IsNumeric(.Rows(i0)("VALU")), .Rows(i0)("VALU"), 0)
                    End If
                    If .Rows(i0)("RKMK").Value = Tmp(3) Then
                        r10.Fields("借方金額").Value = IIf(IsNumeric(.Rows(i0)("VALU")), .Rows(i0)("VALU"), 0)
                    End If
                    r10.Fields("借方軽減税率区分").Value = IIf(IsNumeric(.Rows(i0)("RKEIGEN")), .Rows(i0)("RKEIGEN"), DBNull.Value)
                    r10.Fields("借方税率").Value = IIf(IsNumeric(.Rows(i0)("RRIT").Value), .Rows(i0)("RRIT"), DBNull.Value)
                    r10.Fields("貸方軽減税率区分").Value = IIf(IsNumeric(.Rows(i0)("SKEIGEN")), .Rows(i0)("SKEIGEN"), DBNull.Value)
                    r10.Fields("貸方税率").Value = IIf(IsNumeric(.Rows(i0)("SRIT")), .Rows(i0)("SRIT"), DBNull.Value)
                    r10.Fields("借方仕入経過区分").Value = IIf(IsNumeric(.Rows(i0)("RMENZEIKEIKA")), .Rows(i0)("RMENZEIKEIKA"), DBNull.Value)
                    r10.Fields("貸方仕入経過区分").Value = IIf(IsNumeric(.Rows(i0)("SMENZEIKEIKA")), .Rows(i0)("SMENZEIKEIKA"), DBNull.Value)

                    r10.Fields("支払日").Value = IIf(IsNumeric(.Rows(i0)("SYMD")), .Rows(i0)("SYMD"), DBNull.Value)
                    r10.Fields("支払区分").Value = IIf(IsNumeric(.Rows(i0)("SKBN")), .Rows(i0)("SKBN"), DBNull.Value)
                    r10.Fields("支払期日").Value = IIf(IsNumeric(.Rows(i0)("SKIZ")), .Rows(i0)("SKIZ"), DBNull.Value)
                    r10.Fields("支払年度").Value = DBNull.Value
                    r10.Fields("支払No").Value = DBNull.Value
                    'MsgBox (.Rows(i0)("") KI & r0.Fields("").Value DKEI & r0.Fields("").Value DSEQ)
                    r10.Update()

                Next
            End With


        Catch ex As Exception

        End Try



        AddLog("財務仕訳インポート処理-1を開始しました..." & vbCrLf)

        'On Error Resume Next

        'WrkSp = CreateWorkspace("", "", "", dbUseODBC)
        'dbsPubs = WrkSp.OpenConnection("", dbDriverNoPrompt, False, pubDsn)

        'dt0 = dbsPubs.CreateQueryDef("")
        'dt0.Prepare = dbQUnprepare




    End Function
    '***************************
    '* 財務仕訳インポート処理
    '***************************
    Public Function MakeData002()
        Dim odbcconn As New OdbcConnection()
        Dim odbcCommand As New OdbcCommand()
        Dim da0 As New OdbcDataAdapter
        Dim dt0 As New DataSet
        Dim SQL As String, Tmp(10), i As Integer

        AddLog("財務仕訳インポート処理-1を開始しました..." & vbCrLf)

        On Error Resume Next

        'WrkSp = CreateWorkspace("", "", "", dbUseODBC)
        'dbsPubs = WrkSp.OpenConnection("", dbDriverNoPrompt, False, pubDsn)

        'dt0 = dbsPubs.CreateQueryDef("")
        'dt0.Prepare = dbQUnprepare("")

        Tmp(0) = Format("対象年月2", "yyyymmdd")
        Tmp(1) = Format("対象年月3", "yyyymmdd")

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
        odbcCommand.Dispose() : odbcCommand = Nothing
        odbcconn.Close() : odbcconn.Dispose() : odbcconn = Nothing

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
                If .Rows(i0)("SKMK").Value = "0302" Then
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



    End Function
    '***************************
    '*
    '***************************
    Public Function MakeData010()
        Dim r1 As Recordset
        Dim r10 As Recordset
        Dim SQL As String, Tmp(5), pFl(1) As Boolean
        Dim i As Integer

        AddLog("財務仕訳インポート処理-2を開始しました..." & vbCrLf)

        Dim r0 As dao.Recordset = DB.OpenRecordset("T_支払仕訳明細", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r10.Index = "Key_0"

        SQL = "SELECT T_支払仕訳明細.* " _
            & "From T_支払仕訳明細 " _
            & "WHERE (T_支払仕訳明細.会社No=" & pubComPany & ")"
        If Not "伝票日付開始日" = "" Then
            SQL = SQL & " AND (T_支払仕訳明細.伝票日付>=" & Format("伝票日付開始日", "yyyymmdd") & ")"
        End If
        If Not "伝票日付終了日" = "" Then
            SQL = SQL & " AND (T_支払仕訳明細.伝票日付<=" & Format("伝票日付終了日", "yyyymmdd") & ")"
        End If
        If Not "伝票開始番号" = "" Then
            SQL = SQL & " AND (T_支払仕訳明細.伝票No>=" & "伝票開始番号" & ")"
        End If
        If Not "伝票終了番号" = "" Then
            SQL = SQL & " AND (T_支払仕訳明細.伝票No<=" & "伝票終了番号" & ")"
        End If
        If Not "支払指定開始日" = "" Then
            SQL = SQL & " AND (T_支払仕訳明細.支払日>=" & Format("支払指定開始日", "yyyymmdd") & ")"
        End If
        If Not "支払指定終了日" = "" Then
            SQL = SQL & " AND (T_支払仕訳明細.支払日<=" & Format("支払指定終了日", "yyyymmdd") & ")"
        End If
        SQL = SQL & ";"
        r0 = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            pFl(0) = True
            If Not "取引先CDFrom" = "" Then
                If "取引先CDFrom" < r0.Fields("貸方取引先CD").Value Then
                    pFl(0) = False
                End If
            End If
            If pFl(0) = True Then
                If Not "取引先CDTo" = "" Then
                    If "取引先CDTo" > r0.Fields("貸方取引先CD").Value Then
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
    End Function

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
    Private Sub cmba_Enter(sender As Object, e As EventArgs) Handles cmba.Enter
        pFocus(0) = cmba
    End Sub

    Private Sub cmbb_Enter(sender As Object, e As EventArgs) Handles cmbb.Enter
        pFocus(0) = cmbb
    End Sub

    Private Sub btnUp00_Click(sender As Object, e As EventArgs) Handles btnUp00.Click

    End Sub
End Class
