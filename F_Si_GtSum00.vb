Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Data.Odbc
Imports dao
Imports GrapeCity.ActiveReports.Rdl.Themes
Imports GrapeCity.DataVisualization.TypeScript
Imports GrapeCity.Viewer.Common.Model

Public Class F_Si_GtSum00
    Dim pFocus(10) As Object
    Dim MyCom As New Com
    Dim pubProc As New Proc
    Dim pDateFormat As String = "yyyy/MM/dd"
    Private Mysqlserver As SQLServer = New SQLServer()


    '* ！のやつ　　　　　　　　 　 ! → .Fields("").Value  ←置換の時.Valueの後ろにスペースあると後ろの文字ダブルクリックで選択できる
    '*  iのやつ　　　　　　　　　  For i AS Integer 、　Next i　←　i省略可  
    '*  Formatのやつ               r10("" & i).Value = r0("" & i.ToString("00") & "0").Value 　？ & Format も　& i .ToStringになる？
    '　　　　　　　　　　　　　　 = Format(Now,"yyyy/mm/dd hh:mm:ss")
    '                             →Now.ToString("yyyy/MM/dd hh:mm:ss")　※月のmm→MMに！時間は小文字の㎜
    '*  Closeのやつ　　　　　　　  r10.Close() : r10 = Nothing  
    '*  Null → DBNull.Value 　　　IsDBNull →　IsDBNull
    '*オフにしていい　Workspace　OpenConnection
    '*
    '*Dim 〇 As dao.Recordset = 〇.OpenRecordset("〇", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
    '*Dim 〇 As dao.Recordset = 〇.OpenRecordset("〇", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
    '*
    '*Dim 〇 As dao.Recordset = 〇.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
    '*Dim 〇 As dao.Recordset = 〇.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenDynaset, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
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
    '*  支払No 更新
    '******************************************************
    Private Function Dsp_Set00()
        Dim r1 As Recordset
        Dim SQL As String, i As Integer, X As Integer, Tmp(10)
        Dim pNen, pSino

        Dim r0 As dao.Recordset = DB.OpenRecordset("MM_SYS", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"

        r0.Seek("=", pubComPany, pubLogInName, 0)
        If r0.NoMatch Then
        Else
            txt支払年度.Text = r0.Fields("年度").Value
        End If
        r0.Close() : r0 = Nothing

        SQL = "SELECT M_Ctl_支払.支払処理No " _
        & "From M_Ctl_支払 " _
        & "Where (M_Ctl_支払.会社No =" & pubComPany & ") " _
        & "And (M_Ctl_支払.支払年度 =" & txt支払年度.Text & ") " _
        & "ORDER BY M_Ctl_支払.支払処理No DESC;"
        r0 = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        If r0.EOF Then
            txt支払No.Text = 1
        Else
            txt支払No.Text = IIf(IsDBNull(r0.Fields("支払処理No").Value), 0, r0.Fields("支払処理No").Value) + 1
        End If
        r0.Close() : r0 = Nothing

        GroupBox00.Enabled = True
    End Function
    '******************************************************
    '*
    '******************************************************
    Private Function Dsp_Set10()
        Dim r1 As Recordset
        Dim SQL As String, i As Integer, X As Integer, Tmp(10)

        Dim r0 As dao.Recordset = DB.OpenRecordset("M_Ctl_支払", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"
        r0.Seek("=", pubComPany, txt支払年度, txt支払No)
        If r0.NoMatch Then
        Else
            txt支払月.Text = IIf(IsDBNull(r0.Fields("支払月CD").Value), "", r0.Fields("支払月CD").Value)
            txt支払日.Text = IIf(IsDBNull(r0.Fields("支払日CD").Value), "", r0.Fields("支払日CD").Value)
            txt支払予定日 = IIf(IsDBNull(r0.Fields("支払日").Value), "", Format(r0.Fields("支払日").Value, "yyyy/MM/dd"))
            If Not r0.Fields("更新F").Value = 9 Then
                GroupBox00.Enabled = True
            End If
        End If
        r0.Close() : r0 = Nothing
    End Function
    '*
    '******************************************************
    '* リストにItemを表示する共通関数
    '******************************************************
    Private Function Item_ADD()
        Dim pRet As Integer, i As Integer
        Dim SQL As String
        Dim itmX As ListItem

        ' LV.ListItems.Clear
        SQL = "SELECT M_Ctl_支払.* " _
        & "From M_Ctl_支払 " _
        & "Where (M_Ctl_支払.会社No=" & pubComPany & ") " _
        & "ORDER BY M_Ctl_支払.支払年度 DESC, M_Ctl_支払.支払処理No DESC;"
        Dim r0 As dao.Recordset = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        i = 0
        Do Until r0.EOF
            i = i + 1
            If i > 10 Then
                Exit Do
            End If
            ' itmX = LV.ListItems.Add(, , Format(i, "00"))
            itmX.SubItems(1) = IIf(IsDBNull(r0.Fields("支払年度").Value), "", r0.Fields("支払年度").Value)
            itmX.SubItems(2) = IIf(IsDBNull(r0.Fields("支払処理No").Value), "", r0.Fields("支払処理No").Value)
            itmX.SubItems(3) = IIf(IsDBNull(r0.Fields("支払日").Value), "", Format(r0.Fields("支払日").Value, "yyyy/MM/dd"))
            itmX.SubItems(4) = IIf(IsDBNull(r0.Fields("支払日CD").Value), "", r0.Fields("支払日CD").Value)
            itmX.SubItems(5) = IIf(IsDBNull(r0.Fields("支払日CD").Value), "", Format(r0.Fields("集計日").Value, "yyyy/MM/dd hh:mm:ss"))
            itmX.SubItems(6) = IIf(IsDBNull(r0.Fields("完了日").Value), "", Format(r0.Fields("完了日").Value, "yyyy/MM/dd hh:mm:ss"))
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
    ''**
    ''****************************************************************

    Public Function Data_Put00()
        Dim Tmp(10), i As Integer, SQL As String

        Dim r0 As dao.Recordset = DB.OpenRecordset("M_Ctl_支払", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"
        r0.Seek("=", pubComPany, txt支払年度.Text, txt支払No.Text)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("会社No").Value = pubComPany
            r0.Fields("支払年度").Value = txt支払年度.Text
            r0.Fields("支払処理No").Value = txt支払No.Text
        Else
            r0.Edit()
        End If
        r0.Fields("支払月CD").Value = txt支払月.Text
        r0.Fields("支払日CD").Value = txt支払日.Text
        r0.Fields("支払日").Value = txt支払予定日.Text
        r0.Fields("集計日").Value = Now()
        r0.Fields("更新F").Value = 1
        r0.Update()
        r0.Close() : r0 = Nothing

        r0 = ComDB.OpenRecordset("MM_会社", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"
        r0.Seek("=", pubComPany)
        If r0.NoMatch Then
        Else
            r0.Edit()
            r0.Fields("支払年度").Value = txt支払年度.Text
            r0.Fields("支払処理No").Value = txt支払No.Text
            r0.Update()
        End If
        r0.Close() : r0 = Nothing

        i = 0
        SQL = "SELECT T_HIS_支払.RecNo " _
        & "From T_HIS_支払 " _
        & "Where (T_HIS_支払.会社No =" & pubComPany & ") " _
        & "ORDER BY T_HIS_支払.RecNo DESC;"
        r0 = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        If Not r0.EOF Then
            i = IIf(IsDBNull(r0.Fields("RecNo").Value), 0, r0.Fields("RecNo").Value) + 1
        End If
        r0.Close() : r0 = Nothing

        r0 = DB.OpenRecordset("T_HIS_支払", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.AddNew()
        r0.Fields("会社No").Value = pubComPany
        r0.Fields("RecNo").Value = i
        r0.Fields("年度").Value = txt支払年度.Text
        r0.Fields("更新No").Value = txt支払No.Text
        r0.Fields("集計日").Value = txt支払月.Text & txt支払日.Text
        r0.Fields("処理日").Value = Now()
        r0.Fields("対象").Value = "支払集計処理"
        r0.Update()
        r0.Close() : r0 = Nothing

    End Function

    Private Sub btnOK_Click(Index As Integer)
        Call Dsp_Set00()
        txt支払月.Focus()
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
        For Each CtrlItem As Control In Me.GroupBox10.Controls
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
        Dim Tmp(1)
        Inp_Chk00 = True
        txtMsg.Visible = False : txtMsg.Text = ""

        Select Case ctxtInp.Name
            Case "支払月"
                ctxtInp.BackColor = Color.White : ctxtInp.Tag = ""
                If ctxtInp.Text = "" Then
                    txtMsg.Text = "支払月未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

                If IsDate(ctxtInp.Text) Then
                    ctxtInp.Text = Date.Parse(ctxtInp.Text).ToString(pDateFormat)

                Else
                    Dim w日付 As String = ""
                    Dim wResult = MyCom.DateChk00(ctxtInp.Text, w日付)
                    If wResult = 1 Then
                        txtMsg.Text = "支払月不正"
                        txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : ctxtInp.Tag = "9"
                        Return False

                    Else
                        ctxtInp.Text = w日付
                    End If
                    If IsNumeric(txt支払月.Text) = False Then
                        Inp_Chk00 = False
                        txtMsg.Text = "支払月不正入力"
                    Else
                        Tmp(0) = CInt(txt支払月.Text)
                        If Tmp(0) < 1 Or Tmp(0) > 12 Then
                            Inp_Chk00 = False
                            txtMsg.Text = "支払月不正入力"

                        End If
                    End If
                End If

            Case "txt支払日"
                If ctxtInp.Text = "" Then
                    txtMsg.Text = "日付未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

                If txt支払日.Text = "" Then
                    Inp_Chk00 = False
                    txtMsg.Text = "支払日未入力"
                Else
                    If IsNumeric(txt支払日.Text) = False Then
                        Inp_Chk00 = False
                        txtMsg.Text = "支払日不正入力"
                    Else
                        Tmp(0) = CInt(txt支払日.Text)
                        If Tmp(0) < 1 Or Tmp(0) > 31 Then
                            Inp_Chk00 = False
                            txtMsg.Text = "支払日不正入力"
                        End If
                    End If
                End If

            Case "txt支払予定日"
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

            Case "txt支払年度"
                ctxtInp.BackColor = Color.White : ctxtInp.Tag = ""
                If ctxtInp.Text = "" Then
                    txtMsg.Text = "支払年度未設定"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
                Dim r0 As dao.Recordset = ComDB.OpenRecordset("MM_決算期", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
                r0.Index = "Key_0"
                r0.Seek("=", pubComPany, txt支払年度.Text, 1)
                If r0.NoMatch Then
                    Inp_Chk00 = False
                    txtMsg.Text = "支払年度不正"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
                r0.Close() : r0 = Nothing

            Case "txt支払No"
                ctxtInp.BackColor = Color.White : ctxtInp.Tag = ""
                If Not IsNumeric(txt支払No.Text) Then
                    Inp_Chk00 = False
                    txtMsg.Text = "支払不正"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

        End Select
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
            Case "txt支払年度", "txt支払No"
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select

        End Select

        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                SelectNextControl(sender, True, True, True, True)
                e.Handled = True
        End Select
    End Sub

    Private Sub txtInp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub


        pTxtBox.BackColor = Color.White
    End Sub
    'Private Sub cmba_Enter(sender As Object, e As EventArgs) Handles cmba.Enter
    '    pFocus(0) = cmba
    'End Sub

    'Private Sub cmbb_Enter(sender As Object, e As EventArgs) Handles cmbb.Enter
    '    pFocus(0) = cmbb
    'End Sub

    '***************************
    '* T_支払作成
    '***************************
    Public Sub MakeData000()
        Dim r0 As Recordset
        Dim SQL As String, Tmp(10), i As Integer

        AddLog("T_支払作成-1を開始しました..." & vbCrLf)

        SQL = "DELETE T_支払.* " _
        & "From T_支払 " _
        & "WHERE (T_支払.会社No=" & pubComPany & ");"
        TmpDB.Execute(SQL)

        SQL = "UPDATE M_支払管理 SET " _
        & "M_支払管理.今回締日 = DBNull.Value, " _
        & "M_支払管理.今回支払日 = DBNull.Value, " _
        & "M_支払管理.当月取引額 = 0, " _
        & "M_支払管理.当月消費税額 = 0, " _
        & "M_支払管理.当月支払額 = 0, " _
        & "M_支払管理.当月支払残額 = 0 " _
        & "WHERE (M_支払管理.会社No=" & pubComPany & ");"
        DB.Execute(SQL)

        Dim m0 As dao.Recordset = DB.OpenRecordset("M_支払管理", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        m0.Index = "Key_0"

        Dim r10 As dao.Recordset = TmpDB.OpenRecordset("T_支払", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r10.Index = "Key_0"

        Tmp(0) = 0
        If IsNumeric(txt支払日.Text) Then
            Tmp(0) = CInt(txt支払日.Text)
        End If
        Select Case Tmp(0)
            Case Is > 27, 0
                SQL = "SELECT M_取引先.* " _
            & "From M_取引先 " _
            & "WHERE (M_取引先.会社No=" & pubComPany & ") " _
            & "AND (M_取引先.支払日>27 Or M_取引先.支払日=0) " _
            & "AND (M_取引先.取引先CD<90000);"
            Case Else
                SQL = "SELECT M_取引先.* " _
            & "From M_取引先 " _
            & "WHERE (M_取引先.会社No=" & pubComPany & ") " _
            & "AND (M_取引先.支払日=" & txt支払日.Text & ") " _
            & "AND (M_取引先.取引先CD<90000);"
        End Select
        r0 = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            If IsNumeric(r0.Fields("締日CD").Value) And IsNumeric(r0.Fields("支払月").Value) Then
                r10.AddNew()
                r10.Fields("会社No").Value = pubComPany
                r10.Fields("年度").Value = txt支払年度.Text
                r10.Fields("処理No").Value = txt支払No.Text
                r10.Fields("取引先CD").Value = r0.Fields("取引先CD").Value
                r10.Fields("締No").Value = r0.Fields("締日CD").Value
                r10.Fields("支払月").Value = txt支払月.Text
                r10.Fields("支払日").Value = txt支払日.Text
                r10.Fields("今回支払日").Value = txt支払予定日.Text
                Tmp(0) = Format(r10.Fields("今回支払日").Value, "yyyy/MM") & "/01"
                Tmp(1) = r0.Fields("支払月").Value * -1
                ' Tmp(2) = DateAdd("m", Tmp(1), Tmp(0))
                Select Case r0.Fields("締日CD").Value
                    Case Is >= 28, 0
                        r10.Fields("対象日F").Value = Tmp(2)
                        r10.Fields("対象日T").Value = DateAdd("d", -1, DateAdd("m", 1, Tmp(2)))
                    Case Else
                        r10.Fields("対象日T").Value = Format(Tmp(2), "yyyy/MM") & "/" & r0.Fields("締日CD").Value
                        r10.Fields("対象日F").Value = DateAdd("m", -1, r10.Fields("対象日T").Value)
                        r10.Fields("対象日F").Value = Format(r10.Fields("対象日F").Value, "yyyy/MM") & "/" & r0.Fields("締日CD").Value
                        r10.Fields("対象日F").Value = DateAdd("d", 1, r10.Fields("対象日F").Value)
                End Select

                m0.Seek("=", pubComPany, r10.Fields("取引先CD").Value)
                If m0.NoMatch Then

                    m0.AddNew()
                    m0.Fields("会社No").Value = pubComPany
                    m0.Fields("取引先CD").Value = r0.Fields("取引先CD").Value
                    m0.Fields("今回締日").Value = r10.Fields("対象日T").Value
                    m0.Fields("今回支払日").Value = r10.Fields("今回支払日").Value
                    m0.Update()
                Else
                    r10.Fields("前回締日").Value = m0.Fields("前回締日").Value
                    r10.Fields("前回支払日").Value = m0.Fields("前回支払日").Value
                    'r10.Fields("").Value 前月支払残額 = m0.Fields("").Value 前月支払残額
                    r10.Fields("前月支払残額").Value = 0
                    r10.Fields("前回消費税額").Value = m0.Fields("前回消費税額").Value
                    m0.Edit()
                    m0.Fields("今回締日").Value = r10.Fields("対象日T").Value
                    m0.Fields("今回支払日").Value = r10.Fields("今回支払日").Value
                    m0.Update()


                End If
                r10.Fields("手形元受銀行CD").Value = r0.Fields("手形元受銀行CD").Value
                r10.Fields("振込元受銀行CD").Value = r0.Fields("振込元受銀行CD").Value
                r10.Fields("小切手元受銀行CD").Value = r0.Fields("小切手元受銀行CD").Value
                r10.Update()
            End If
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing

        m0.Close() : m0 = Nothing
        r10.Close() : r10 = Nothing

    End Sub

    '***************************
    '* T_支払作成
    '***************************
    Public Function MakeData001()
        Dim dt0 As QueryDef
        Dim r10 As Recordset
        Dim SQL As String, Tmp(10), pZan As Decimal, p(1) As String
        Dim i As Integer, pNen As Long, pNo As Long, pStr As Long, pEnd As Long, pKi As Long

        AddLog("T_支払作成-2を開始しました..." & vbCrLf)

        On Error Resume Next

        '    WrkSp = CreateWorkspace("", "", "", dbUseODBC)
        '    dbsPubs = WrkSp.OpenConnection("", dbDriverNoPrompt, False, pubDsn)

        'Set q0 = dbsPubs.CreateQueryDef("")
        'q0.Prepare = dbQUnprepare

        Dim r0 As dao.Recordset = TmpDB.OpenRecordset("T_支払", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        Do Until r0.EOF
            ' Tmp(0) = DateAdd("m", -1, r0.Fields("対象日F").Value)
            pNen = -1 : pNo = -1 : pStr = -1 : pEnd = -1
            SQL = "SELECT MM_決算期.* " _
            & "From MM_決算期 " _
            & "Where (MM_決算期.会社No =" & pubComPany & ") " _
            & "And (MM_決算期.締月 <= #" & Format(Tmp(0), "yyyy/MM/dd") & "#) " _
            & "ORDER BY MM_決算期.締月 DESC;"

            Dim m0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            If Not m0.EOF Then
                pNen = m0.Fields("年度").Value
                pNo = m0.Fields("締No").Value
                pStr = Format(m0.Fields("開始").Value, "yyyyMMdd")
                pEnd = Format(m0.Fields("終了").Value, "yyyyMMdd")
            End If
            m0.Close()
            m0 = Nothing

            pKi = 1
            SQL = "SELECT A_VOLUM2.KI " _
            & "From A_VOLUM2 " _
            & "WHERE (A_VOLUM2.SYMD Between " & pStr & " And " & pEnd & ");"
            dt0.SQL = SQL
            m0 = dt0.OpenRecordset()
            If Not m0.EOF Then
                pKi = IIf(IsDBNull(m0.Fields("KI").Value), 1, m0.Fields("KI").Value)
            End If
            m0.Close()
            m0 = Nothing

            pZan = 0
            SQL = "SELECT A_TRZAN.* " _
            & "From A_TRZAN " _
            & "WHERE (A_TRZAN.KI=" & pKi & ") " _
            & "AND (A_TRZAN.TRCD='" & i.ToString(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "AND (A_TRZAN.KCOD='0303');"
            dt0.SQL = SQL
            m0 = dt0.OpenRecordset()
            If Not m0.EOF Then
                pZan = m0.Fields("K000").Value
                For i = 1 To pNo
                    pZan = pZan - m0("R" & i.ToString("00") & "0").Value
                    pZan = pZan + m0("S" & i.ToString("00") & "0").Value
                Next
            End If
            m0.Close()
            m0 = Nothing
            r0.Edit()
            r0.Fields("前月支払残額").Value = pZan
            r0.Update()
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        dt0.Close() : dt0 = Nothing
        On Error GoTo 0
    End Function
    '***************************
    '* T_支払作成
    '***************************
    Public Function MakeData002()
        Dim SQL As String, Tmp(10)

        AddLog("T_支払作成-3を開始しました..." & vbCrLf)

        On Error Resume Next

        SQL = "SELECT T_支払.* " _
        & "From T_支払 " _
        & "WHERE (T_支払.会社No=" & pubComPany & ") " _
        & "AND (T_支払.年度=" & txt支払年度.Text & ") " _
        & "AND (T_支払.処理No=" & txt支払No.Text & ") " _
        & "AND (T_支払.締No Between 1 And 27);"
        Dim r0 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenDynaset, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        Do Until r0.EOF
            Tmp(0) = DateAdd("m", -1, r0.Fields("対象日F").Value)
            Tmp(1) = Format(r0.Fields("対象日F").Value, "yyyymmdd")
            SQL = "SELECT MM_決算期.* " _
            & "From MM_決算期 " _
            & "Where (MM_決算期.会社No =" & pubComPany & ") " _
            & "And (MM_決算期.締月 <= #" & Format(Tmp(0), "yyyy/MM/dd") & "#) " _
            & "ORDER BY MM_決算期.締月 DESC;"
            Dim m0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            If Not m0.EOF Then
                Tmp(2) = Format(m0.Fields("終了").Value, "yyyymmdd")
            End If
            m0.Close() : m0 = Nothing

            r0.Edit()
            SQL = "SELECT T_支払仕訳明細.* " _
            & "From T_支払仕訳明細 " _
            & "WHERE (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.伝票日付>" & Tmp(2) & ") " _
            & "AND (T_支払仕訳明細.伝票日付<" & Tmp(1) & ") " _
            & "AND (T_支払仕訳明細.貸方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "OR (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.伝票日付>" & Tmp(2) & ") " _
            & "AND (T_支払仕訳明細.伝票日付<" & Tmp(1) & ") " _
            & "AND (T_支払仕訳明細.借方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "');"
            Dim r1 As dao.Recordset = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            Do Until r1.EOF
                r0.Fields("前月支払残額").Value = r0.Fields("前月支払残額").Value - IIf(IsDBNull(r1.Fields("借方金額").Value), 0, r1.Fields("借方金額").Value)
                r0.Fields("前月支払残額").Value = r0.Fields("前月支払残額").Value + IIf(IsDBNull(r1.Fields("貸方金額").Value), 0, r1.Fields("貸方金額").Value)
                r1.MoveNext()
            Loop
            r1.Close() : r1 = Nothing
            r0.Update() : r0.MoveNext()
        Loop
        r0.Close()
        r0 = Nothing

    End Function
    '***************************
    '* 請求データ集計
    '***************************
    Public Function MakeData010()
        Dim m0 As Recordset
        Dim SQL As String, Tmp(5), pKin(1)
        Dim i As Integer

        AddLog("請求データ集計を開始しました..." & vbCrLf)

        SQL = "DELETE T_支払伝票M.* " _
        & "FROM T_支払伝票M;"
        TmpDB.Execute(SQL)

        Dim r10 As dao.Recordset = TmpDB.OpenRecordset("T_支払伝票M", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)

        SQL = "SELECT T_請求H.取引先CD " _
        & "From T_請求H " _
        & "Where (T_請求H.会社No =" & pubComPany & ") " _
        & "And (T_請求H.支払日 = #" & Format(txt支払予定日.Text, "yyyy/MM/dd") & "#)" _
        & "And (T_請求H.支払完了F = 0)" _
        & "GROUP BY T_請求H.取引先CD " _
        & "ORDER BY T_請求H.取引先CD;"
        Dim r0 As dao.Recordset = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        i = 0
        Do Until r0.EOF
            SQL = "SELECT T_請求M.* " _
            & "From T_請求M " _
            & "Where (T_請求M.会社No =" & pubComPany & ") " _
            & "And (T_請求M.支払日 = #" & Format(txt支払予定日.Text, "yyyy/MM/dd") & "#) " _
            & "And (T_請求M.取引先CD =" & r0.Fields("取引先CD").Value & ") " _
            & "ORDER BY T_請求M.RecID;"
            Dim r1 As dao.Recordset = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            Do Until r1.EOF
                Select Case r1.Fields("消費税区分").Value
                    Case 1
                        pKin(0) = r1.Fields("金額").Value - r1.Fields("消費税").Value
                        i = i + 1
                        r10.AddNew()
                        r10.Fields("会社No").Value = r1.Fields("会社No").Value
                        r10.Fields("支払日").Value = r1.Fields("支払日").Value
                        r10.Fields("取引先CD").Value = r1.Fields("取引先CD").Value
                        r10.Fields("RecID").Value = i
                        r10.Fields("請求日").Value = r1.Fields("請求日").Value
                        r10.Fields("金額").Value = pKin(0)
                        r10.Fields("部門").Value = r1.Fields("部門").Value
                        r10.Fields("科目").Value = r1.Fields("科目").Value
                        r10.Fields("枝番").Value = r1.Fields("枝番").Value
                        r10.Fields("消費税区分").Value = 2
                        r10.Update()

                        i = i + 1
                        r10.AddNew()
                        r10.Fields("会社No").Value = r1.Fields("会社No").Value
                        r10.Fields("支払日").Value = r1.Fields("支払日").Value
                        r10.Fields("取引先CD").Value = r1.Fields("取引先CD").Value
                        r10.Fields("RecID").Value = i
                        r10.Fields("請求日").Value = r1.Fields("請求日").Value
                        r10.Fields("金額").Value = r1.Fields("消費税").Value
                        r10.Fields("部門").Value = DBNull.Value
                        r10.Fields("科目").Value = 118
                        r10.Fields("枝番").Value = DBNull.Value
                        r10.Fields("消費税区分").Value = 0
                        r10.Update()

                    Case 2
                        pKin(0) = r1.Fields("金額").Value
                        i = i + 1
                        r10.AddNew()
                        r10.Fields("会社No").Value = r1.Fields("会社No").Value
                        r10.Fields("支払日").Value = r1.Fields("支払日").Value
                        r10.Fields("取引先CD").Value = r1.Fields("取引先CD").Value
                        r10.Fields("RecID").Value = i
                        r10.Fields("請求日").Value = r1.Fields("請求日").Value
                        r10.Fields("金額").Value = pKin(0)
                        r10.Fields("部門").Value = r1.Fields("部門").Value
                        r10.Fields("科目").Value = r1.Fields("科目").Value
                        r10.Fields("枝番").Value = r1.Fields("枝番").Value
                        r10.Fields("消費税区分").Value = 2
                        r10.Update()

                        i = i + 1
                        r10.AddNew()
                        r10.Fields("会社No").Value = r1.Fields("会社No").Value
                        r10.Fields("支払日").Value = r1.Fields("支払日").Value
                        r10.Fields("取引先CD").Value = r1.Fields("取引先CD").Value
                        r10.Fields("RecID").Value = i
                        r10.Fields("請求日").Value = r1.Fields("請求日").Value
                        r10.Fields("金額").Value = r1.Fields("消費税").Value
                        r10.Fields("部門").Value = DBNull.Value
                        r10.Fields("科目").Value = 118
                        r10.Fields("枝番").Value = DBNull.Value
                        r10.Fields("消費税区分").Value = 0
                        r10.Update()

                    Case Else
                        i = i + 1
                        r10.AddNew()
                        r10.Fields("会社No").Value = r1.Fields("会社No").Value
                        r10.Fields("支払日").Value = r1.Fields("支払日").Value
                        r10.Fields("取引先CD").Value = r1.Fields("取引先CD").Value
                        r10.Fields("RecID").Value = i
                        r10.Fields("請求日").Value = r1.Fields("請求日").Value
                        r10.Fields("金額").Value = r1.Fields("金額").Value
                        r10.Fields("部門").Value = r1.Fields("部門").Value
                        r10.Fields("科目").Value = r1.Fields("科目").Value
                        r10.Fields("枝番").Value = r1.Fields("枝番").Value
                        r10.Fields("消費税区分").Value = r1.Fields("消費税区分").Value
                        r10.Update()
                End Select
                r1.MoveNext()
            Loop
            r1.Close() : r1 = Nothing
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        r10.Close() : r10 = Nothing

        SQL = "UPDATE T_請求H SET T_請求H.支払年度 =" & txt支払年度.Text & ", " _
        & "T_請求H.支払No =" & txt支払No.Text & " " _
        & "Where (T_請求H.会社No =" & pubComPany & ") " _
        & "And (T_請求H.支払日 = #" & Format(txt支払予定日.Text, "yyyy/MM/dd") & "#)" _
        & "And (T_請求H.支払完了F = 0);"
        DB.Execute(SQL)



    End Function
    '***************************
    '* 仕訳データ集計
    '***************************
    Public Function MakeData020()
        Dim m0 As Recordset
        Dim SQL As String, Tmp(5)
        Dim i As Integer

        AddLog("仕訳抽出を開始しました(A_ZDATA)..." & vbCrLf)
        txtLog.Visible = True

        SQL = "DELETE Wt_仕訳明細.* " _
        & "FROM Wt_仕訳明細;"
        TmpDB.Execute(SQL)

        Dim r10 As dao.Recordset = TmpDB.OpenRecordset("Wt_仕訳明細", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r10.Index = "Key_1"

        SQL = "SELECT T_支払.* " _
        & "FROM T_支払 " _
        & "ORDER BY T_支払.取引先CD;"
        Dim r0 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            txtLog.Text = r0.Fields("取引先CD").Value
            txtLog.Refresh()
            Tmp(0) = Format(r0.Fields("対象日F").Value, "yyyymmdd")
            Tmp(1) = Format(r0.Fields("対象日T").Value, "yyyymmdd")
            Tmp(2) = Format(r0.Fields("今回支払日").Value, "yyyymmdd")
            SQL = "SELECT T_支払仕訳明細.* " _
            & "From T_支払仕訳明細 " _
            & "WHERE (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.伝票日付>=" & Tmp(0) & ") " _
            & "AND (T_支払仕訳明細.伝票日付<=" & Tmp(1) & ") " _
            & "AND (T_支払仕訳明細.貸方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "AND (T_支払仕訳明細.支払完了F = 0) " _
            & "OR (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.伝票日付>=" & Tmp(0) & ") " _
            & "AND (T_支払仕訳明細.伝票日付<=" & Tmp(1) & ") " _
            & "AND (T_支払仕訳明細.借方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "AND (T_支払仕訳明細.支払完了F = 0);"
            Dim r1 As dao.Recordset = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            Do Until r1.EOF
                r10.Seek("=", r1.Fields("伝票日付").Value, r1.Fields("伝票No").Value, r1.Fields("伝票頁").Value, r1.Fields("伝票行").Value)
                If r10.NoMatch Then
                    r10.AddNew()
                    r10.Fields("会社No").Value = r1.Fields("会社No").Value
                    r10.Fields("伝票日付").Value = r1.Fields("伝票日付").Value
                    r10.Fields("整理月F").Value = 0
                    r10.Fields("伝票番号").Value = r1.Fields("伝票No").Value
                    r10.Fields("伝票頁").Value = r1.Fields("伝票頁").Value
                    r10.Fields("行番号").Value = r1.Fields("伝票行").Value
                    r10.Fields("借方部門").Value = IIf(IsNumeric(r1.Fields("借方部門CD").Value), r1.Fields("借方部門CD").Value, DBNull.Value)
                    r10.Fields("借方取引先").Value = IIf(IsNumeric(r1.Fields("借方取引先CD").Value), r1.Fields("借方取引先CD").Value, DBNull.Value)
                    r10.Fields("借方科目").Value = IIf(IsNumeric(r1.Fields("借方科目CD").Value), r1.Fields("借方科目CD").Value, DBNull.Value)
                    r10.Fields("借方枝番").Value = IIf(IsNumeric(r1.Fields("借方枝番CD").Value), r1.Fields("借方枝番CD").Value, DBNull.Value)
                    r10.Fields("借方金額").Value = r1.Fields("借方金額").Value
                    r10.Fields("貸方部門").Value = IIf(IsNumeric(r1.Fields("貸方部門CD").Value), r1.Fields("貸方部門CD").Value, DBNull.Value)
                    r10.Fields("貸方取引先").Value = IIf(IsNumeric(r1.Fields("貸方取引先CD").Value), r1.Fields("貸方取引先CD").Value, DBNull.Value)
                    r10.Fields("貸方科目").Value = IIf(IsNumeric(r1.Fields("貸方科目CD").Value), r1.Fields("貸方科目CD").Value, DBNull.Value)
                    r10.Fields("貸方枝番").Value = IIf(IsNumeric(r1.Fields("貸方枝番CD").Value), r1.Fields("貸方枝番CD").Value, DBNull.Value)
                    r10.Fields("貸方金額").Value = r1.Fields("貸方金額").Value
                    r10.Fields("支払日").Value = IIf(IsNumeric(r1.Fields("支払日").Value), r1.Fields("支払日").Value, DBNull.Value)
                    r10.Update()
                End If
                r1.MoveNext()
            Loop
            r1.Close() : r1 = Nothing
            SQL = "UPDATE T_支払仕訳明細 SET T_支払仕訳明細.支払年度 =" & txt支払年度.Text & ", " _
            & "T_支払仕訳明細.支払No =" & txt支払No.Text & " " _
            & "WHERE (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.伝票日付>=" & Tmp(0) & ") " _
            & "AND (T_支払仕訳明細.伝票日付<=" & Tmp(1) & ") " _
            & "AND (T_支払仕訳明細.貸方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "AND (T_支払仕訳明細.支払完了F = 0) " _
            & "OR (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.伝票日付>=" & Tmp(0) & ") " _
            & "AND (T_支払仕訳明細.伝票日付<=" & Tmp(1) & ") " _
            & "AND (T_支払仕訳明細.借方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "AND (T_支払仕訳明細.支払完了F = 0);"
            DB.Execute(SQL)

            SQL = "SELECT T_支払仕訳明細.* " _
            & "From T_支払仕訳明細 " _
            & "WHERE (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.支払日=" & Tmp(2) & ") " _
            & "AND (T_支払仕訳明細.貸方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "AND (T_支払仕訳明細.支払完了F= 0) " _
            & "AND (T_支払仕訳明細.支払年度 Is DBNull.Value) " _
            & "OR (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.支払日=" & Tmp(2) & ") " _
            & "AND (T_支払仕訳明細.借方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "AND (T_支払仕訳明細.支払完了F= 0) " _
            & "AND (T_支払仕訳明細.支払年度 Is DBNull.Value);"
            r1 = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            Do Until r1.EOF
                r10.Seek("=", r1.Fields("伝票日付").Value, r1.Fields("伝票No").Value, r1.Fields("伝票頁").Value, r1.Fields("伝票行").Value)
                If r10.NoMatch Then
                    r10.AddNew()
                    r10.Fields("会社No").Value = r1.Fields("会社No").Value
                    r10.Fields("伝票日付").Value = r1.Fields("伝票日付").Value
                    r10.Fields("整理月F").Value = 0
                    r10.Fields("伝票番号").Value = r1.Fields("伝票No").Value
                    r10.Fields("伝票頁").Value = r1.Fields("伝票頁").Value
                    r10.Fields("行番号").Value = r1.Fields("伝票行").Value
                    r10.Fields("借方部門").Value = IIf(IsNumeric(r1.Fields("借方部門CD").Value), r1.Fields("借方部門CD").Value, DBNull.Value)
                    r10.Fields("借方取引先").Value = IIf(IsNumeric(r1.Fields("借方取引先CD").Value), r1.Fields("借方取引先CD").Value, DBNull.Value)
                    r10.Fields("借方科目").Value = IIf(IsNumeric(r1.Fields("借方科目CD").Value), r1.Fields("借方科目CD").Value, DBNull.Value)
                    r10.Fields("借方枝番").Value = IIf(IsNumeric(r1.Fields("借方枝番CD").Value), r1.Fields("借方枝番CD").Value, DBNull.Value)
                    r10.Fields("借方金額").Value = r1.Fields("借方金額").Value
                    r10.Fields("貸方部門").Value = IIf(IsNumeric(r1.Fields("貸方部門CD").Value), r1.Fields("貸方部門CD").Value, DBNull.Value)
                    r10.Fields("貸方取引先").Value = IIf(IsNumeric(r1.Fields("貸方取引先CD").Value), r1.Fields("貸方取引先CD").Value, DBNull.Value)
                    r10.Fields("貸方科目").Value = IIf(IsNumeric(r1.Fields("貸方科目CD").Value), r1.Fields("貸方科目CD").Value, DBNull.Value)
                    r10.Fields("貸方枝番").Value = IIf(IsNumeric(r1.Fields("貸方枝番CD").Value), r1.Fields("貸方枝番CD").Value, DBNull.Value)
                    r10.Fields("貸方金額").Value = r1.Fields("貸方金額").Value
                    r10.Fields("支払日").Value = IIf(IsNumeric(r1.Fields("支払日").Value), r1.Fields("支払日").Value, DBNull.Value)
                    r10.Update()
                End If
                r1.MoveNext()
            Loop
            r1.Close() : r1 = Nothing

            SQL = "UPDATE T_支払仕訳明細 SET T_支払仕訳明細.支払年度 =" & txt支払年度.Text & ", " _
            & "T_支払仕訳明細.支払No =" & txt支払No.Text & " " _
            & "WHERE (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.支払日=" & Tmp(2) & ") " _
            & "AND (T_支払仕訳明細.貸方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "AND (T_支払仕訳明細.支払完了F= 0) " _
            & "AND (T_支払仕訳明細.支払年度 Is DBNull.Value) " _
            & "OR (T_支払仕訳明細.会社No=" & pubComPany & ") " _
            & "AND (T_支払仕訳明細.支払日=" & Tmp(2) & ") " _
            & "AND (T_支払仕訳明細.借方取引先CD='" & Format(r0.Fields("取引先CD").Value, "000000") & "') " _
            & "AND (T_支払仕訳明細.支払完了F= 0) " _
            & "AND (T_支払仕訳明細.支払年度 Is DBNull.Value);"
            DB.Execute(SQL)
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        r10.Close() : r10 = Nothing

    End Function
    '***************************
    '* 仕訳データ集計
    '***************************
    Public Function MakeData021()
        Dim SQL As String, Tmp(5)
        Dim i As Integer, pCnt As Long

        AddLog("仕訳集計を開始しました..." & vbCrLf)

        Dim r10 As dao.Recordset = TmpDB.OpenRecordset("T_支払伝票M", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)

        SQL = "SELECT Wt_仕訳明細.貸方取引先 " _
        & "From Wt_仕訳明細 " _
        & "GROUP BY Wt_仕訳明細.貸方取引先 " _
        & "HAVING (Wt_仕訳明細.貸方取引先 Is Not DBNull.Value);"
        Dim r0 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            pCnt = 0
            SQL = "SELECT T_支払伝票M.RecID " _
            & "From T_支払伝票M " _
            & "Where (T_支払伝票M.会社No =" & pubComPany & ") " _
            & "And (T_支払伝票M.支払日 =#" & i.ToString(txt支払予定日.Text, "yyyy/MM/dd") & "#) " _
            & "And (T_支払伝票M.取引先CD =" & r0.Fields("貸方取引先").Value & ") " _
            & "ORDER BY T_支払伝票M.RecID DESC;"
            Dim r1 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            If Not r1.EOF Then
                pCnt = IIf(IsDBNull(r1.Fields("RecID").Value), 0, r1.Fields("RecID").Value)
            End If
            r1.Close() : r1 = Nothing

            SQL = "SELECT Wt_仕訳明細.貸方部門, Wt_仕訳明細.貸方科目, Wt_仕訳明細.貸方枝番, " _
            & "Sum(Wt_仕訳明細.貸方金額) AS 貸方金額計 " _
            & "From Wt_仕訳明細 " _
            & "Where (Wt_仕訳明細.貸方取引先 =" & r0.Fields("貸方取引先").Value & ") " _
            & "GROUP BY Wt_仕訳明細.貸方部門, Wt_仕訳明細.貸方科目, Wt_仕訳明細.貸方枝番;"
            r0 = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            Do Until r1.EOF
                pCnt = pCnt + 1
                r10.AddNew()
                r10.Fields("会社No").Value = pubComPany
                r10.Fields("支払日").Value = txt支払予定日.Text
                r10.Fields("取引先CD").Value = r0.Fields("貸方取引先").Value
                r10.Fields("RecID").Value = pCnt
                r10.Fields("請求日").Value = DBNull.Value
                r10.Fields("支払額").Value = 0
                r10.Fields("金額").Value = r1.Fields("貸方金額計").Value
                r10.Fields("部門").Value = r1.Fields("貸方部門").Value
                r10.Fields("科目").Value = r1.Fields("貸方科目").Value
                r10.Fields("枝番").Value = r1.Fields("貸方枝番").Value
                r10.Fields("消費税区分").Value = 0
                r10.Update()
                r1.MoveNext()
            Loop
            r1.Close() : r1 = Nothing
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing

        SQL = "SELECT Wt_仕訳明細.借方取引先 " _
        & "From Wt_仕訳明細 " _
        & "GROUP BY Wt_仕訳明細.借方取引先 " _
        & "HAVING (Wt_仕訳明細.借方取引先 Is Not DBNull.Value);"
        r0 = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            pCnt = 0
            SQL = "SELECT T_支払伝票M.RecID " _
            & "From T_支払伝票M " _
            & "Where (T_支払伝票M.会社No =" & pubComPany & ") " _
            & "And (T_支払伝票M.支払日 =#" & i.ToString(txt支払予定日.Text, "yyyy/MM/dd") & "#) " _
            & "And (T_支払伝票M.取引先CD =" & r0.Fields("借方取引先").Value & ") " _
            & "ORDER BY T_支払伝票M.RecID DESC;"
            Dim r1 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            If Not r1.EOF Then
                pCnt = IIf(IsDBNull(r1.Fields("RecID").Value), 0, r1.Fields("RecID").Value)
            End If
            r1.Close() : r1 = Nothing

            SQL = "SELECT Wt_仕訳明細.貸方部門, " _
            & "Sum(Wt_仕訳明細.借方金額) AS 借方金額計 " _
            & "From Wt_仕訳明細 " _
            & "Where (Wt_仕訳明細.借方取引先 =" & r0.Fields("借方取引先").Value & ") " _
            & "GROUP BY Wt_仕訳明細.貸方部門;"

            r1 = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            Do Until r1.EOF
                pCnt = pCnt + 1
                r10.AddNew()
                r10.Fields("会社No").Value = pubComPany
                r10.Fields("支払日").Value = txt支払予定日.Text
                r10.Fields("取引先CD").Value = r0.Fields("借方取引先").Value
                r10.Fields("RecID").Value = pCnt
                r10.Fields("請求日").Value = DBNull.Value
                r10.Fields("支払額").Value = r1.Fields("借方金額計").Value
                r10.Fields("金額").Value = 0
                r10.Fields("部門").Value = r1.Fields("貸方部門").Value
                r10.Fields("科目").Value = DBNull.Value
                r10.Fields("枝番").Value = DBNull.Value
                r10.Fields("消費税区分").Value = 0
                r10.Update()
                r1.MoveNext()
            Loop
            r1.Close() : r1 = Nothing
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        r10.Close() : r10 = Nothing
    End Function
    '***************************
    '* 支払伝票集計
    '***************************
    Public Function MakeData030()
        Dim SQL As String, Tmp(5), pKin(1) As Decimal
        Dim i As Integer, pCnt As Long

        AddLog("支払集計を開始しました..." & vbCrLf)

        SQL = "DELETE T_支払伝票H.* " _
        & "FROM T_支払伝票H;"
        TmpDB.Execute(SQL)

        Dim m0 As dao.Recordset = DB.OpenRecordset("M_取引先", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        m0.Index = "Key_0"

        Dim r10 As dao.Recordset = TmpDB.OpenRecordset("T_支払伝票H", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)

        SQL = "SELECT T_支払伝票M.取引先CD, Sum(T_支払伝票M.支払額) AS 支払額計, Sum(T_支払伝票M.金額) AS 金額計 " _
        & "From T_支払伝票M " _
        & "GROUP BY T_支払伝票M.取引先CD;"
        Dim r0 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            r10.AddNew()
            r10.Fields("会社No").Value = pubComPany
            r10.Fields("支払日").Value = txt支払予定日.Text
            r10.Fields("取引先CD").Value = r0.Fields("取引先CD").Value
            r10.Fields("当月支払額").Value = r0.Fields("支払額計").Value
            r10.Fields("請求額").Value = r0.Fields("金額計").Value
            r10.Fields("消費税額").Value = 0
            m0.Seek("=", pubComPany, r10.Fields("取引先CD").Value)
            If m0.NoMatch Then
            Else
                'Select Case m0.Fields("消費税区分").Value
                '    Case 1 '四捨五入
                '        pKin(0) = pubMakeTax00(r10.Fields("請求額").Value, 1, 0.1)
                '        r10.Fields("消費税額").Value = pKin(0)
                '    Case 2 '切捨て
                '        pKin(0) = pubMakeTax00(r10.Fields("請求額").Value, 0, 0.1)
                '        r10.Fields("消費税額").Value = pKin(0)
                '    Case 3 '切上
                '        pKin(0) = pubMakeTax00(r10.Fields("請求額").Value, 2, 0.1)
                '        r10.Fields("消費税額").Value = pKin(0)
                'End Select
            End If
            r10.Update()
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        r10.Close() : r10 = Nothing
    End Function
    '***************************
    '* T_支払更新
    '***************************
    Public Function MakeData031()
        Dim SQL As String

        AddLog("T_支払データ更新を開始しました..." & vbCrLf)

        Dim r0 As dao.Recordset = TmpDB.OpenRecordset("T_支払", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"

        SQL = "SELECT T_支払伝票H.* " _
        & "From T_支払伝票H;"
        Dim r1 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r1.EOF
            r0.Seek("=", pubComPany, txt支払年度.Text, txt支払No.Text, r1.Fields("取引先CD").Value)
            If r0.NoMatch Then
                r0.AddNew()
                r0.Fields("会社No").Value = pubComPany
                r0.Fields("年度").Value = txt支払年度.Text
                r0.Fields("処理No").Value = txt支払No.Text
                r0.Fields("取引先CD").Value = r1.Fields("取引先CD").Value
            Else
                r0.Edit()
            End If
            r0.Fields("当月支払額").Value = r1.Fields("当月支払額").Value
            Select Case r0.Fields("締No").Value
                Case 0
                Case Is >= 28
                Case Else
                    r0.Fields("当月支払額").Value = r0.Fields("当月支払額").Value - IIf(IsDBNull(r0.Fields("前回消費税額").Value), 0, r0.Fields("前回消費税額").Value)
            End Select
            r0.Fields("当月繰越額").Value = r0.Fields("前月支払残額").Value - r0.Fields("当月支払額").Value
            r0.Fields("当月取引額").Value = r1.Fields("請求額").Value
            r0.Fields("当月消費税額").Value = r1.Fields("消費税額").Value
            r0.Fields("消費税0").Value = r1.Fields("消費税額").Value
            r0.Fields("消費税1").Value = 0
            r0.Fields("消費税2").Value = 0
            r0.Fields("支払予定額").Value = r0.Fields("当月繰越額").Value + r0.Fields("当月取引額").Value + r0.Fields("当月消費税額").Value
            r0.Fields("支払額").Value = r0.Fields("支払予定額").Value
            r0.Fields("支払残額").Value = 0
            r0.Update()
            r1.MoveNext()
        Loop
        r1.Close() : r1 = Nothing
        r0.Close() : r0 = Nothing

        r0 = TmpDB.OpenRecordset("T_支払", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        Do Until r0.EOF
            r0.Edit()
            r0.Fields("当月繰越額").Value = r0.Fields("前月支払残額").Value - r0.Fields("当月支払額").Value
            r0.Fields("支払予定額").Value = r0.Fields("当月繰越額").Value + r0.Fields("当月取引額").Value + r0.Fields("当月消費税額").Value
            r0.Fields("支払額").Value = r0.Fields("支払予定額").Value
            r0.Fields("支払残額").Value = 0
            r0.Update()
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing

    End Function
    '***************************
    '* 支払伝票転送
    '***************************
    Public Function MakeData032()
        Dim SQL As String, Tmp(5)
        Dim i As Integer, pCnt As Long

        AddLog("支払データ転送を開始しました..." & vbCrLf)

        SQL = "DELETE T_支払伝票H.* " _
        & "From T_支払伝票H " _
        & "WHERE (T_支払伝票H.会社No=" & pubComPany & ") " _
        & "AND (T_支払伝票H.支払日=#" & Format(txt支払予定日.Text, "yyyy/MM/dd") & "#);"
        DB.Execute(SQL)

        SQL = "DELETE T_支払伝票M.* " _
        & "From T_支払伝票M " _
        & "WHERE (T_支払伝票M.会社No=" & pubComPany & ") " _
        & "AND (T_支払伝票M.支払日=#" & Format(txt支払予定日.Text, "yyyy/MM/dd") & "#);"
        DB.Execute(SQL)

        SQL = "DELETE T_支払.* " _
        & "From T_支払 " _
        & "WHERE (T_支払.会社No=" & pubComPany & ") " _
        & "AND (T_支払.年度=" & txt支払年度.Text & ") " _
        & "AND (T_支払.処理No=" & txt支払No.Text & ");"
        DB.Execute(SQL)

        Dim r10 As dao.Recordset = DB.OpenRecordset("T_支払伝票H", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        Dim r11 As dao.Recordset = DB.OpenRecordset("T_支払伝票M", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        SQL = "SELECT T_支払伝票H.* " _
        & "From T_支払伝票H " _
        & "WHERE (T_支払伝票H.請求額<>0);"
        Dim r0 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            r10.AddNew()
            r10.Fields("会社No").Value = r0.Fields("会社No").Value
            r10.Fields("支払日").Value = r0.Fields("支払日").Value
            r10.Fields("取引先CD").Value = r0.Fields("取引先CD").Value
            r10.Fields("請求額").Value = r0.Fields("請求額").Value
            r10.Fields("消費税額").Value = r0.Fields("消費税額").Value
            r10.Update()
            SQL = "SELECT T_支払伝票M.* " _
            & "From T_支払伝票M " _
            & "WHERE (T_支払伝票M.取引先CD=" & r0.Fields("取引先CD").Value & ");"
            Dim r1 As dao.Recordset = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
            Do Until r1.EOF
                r11.AddNew()
                r11.Fields("会社No").Value = r1.Fields("会社No").Value
                r11.Fields("支払日").Value = r1.Fields("支払日").Value
                r11.Fields("取引先CD").Value = r1.Fields("取引先CD").Value
                r11.Fields("RecID").Value = r1.Fields("RecID").Value
                r11.Fields("請求日").Value = r1.Fields("請求日").Value
                r11.Fields("金額").Value = r1.Fields("金額").Value
                r11.Fields("部門").Value = r1.Fields("部門").Value
                r11.Fields("科目").Value = r1.Fields("科目").Value
                r11.Fields("枝番").Value = r1.Fields("枝番").Value
                r11.Fields("消費税区分").Value = r1.Fields("消費税区分").Value
                r11.Update()
                r1.MoveNext()
            Loop
            r1.Close() : r1 = Nothing
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        r10.Close() : r10 = Nothing
        r11.Close() : r11 = Nothing

        r10 = DB.OpenRecordset("T_支払", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        SQL = "SELECT T_支払.* " _
        & "FROM T_支払;"
        r0 = TmpDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            Tmp(0) = Math.abs(IIf(IsDBNull(r0.Fields("支払予定額").Value), 0, r0.Fields("支払予定額").Value))
            If Tmp(0) > 0 Then
                r10.Fields("会社No").Value = r0.Fields("会社No").Value
                r10.Fields("年度").Value = r0.Fields("年度").Value
                r10.Fields("処理No").Value = r0.Fields("処理No").Value
                r10.Fields("取引先CD").Value = r0.Fields("取引先CD").Value
                r10.Fields("締No").Value = r0.Fields("締No").Value
                r10.Fields("支払月").Value = r0.Fields("支払月").Value
                r10.Fields("支払日").Value = r0.Fields("支払日").Value
                r10.Fields("対象日F").Value = r0.Fields("対象日F").Value
                r10.Fields("対象日T").Value = r0.Fields("対象日T").Value
                r10.Fields("前回締日").Value = r0.Fields("前回締日").Value
                r10.Fields("今回締日").Value = r0.Fields("今回締日").Value
                r10.Fields("前回支払日").Value = r0.Fields("前回支払日").Value
                r10.Fields("今回支払日").Value = r0.Fields("今回支払日").Value
                r10.Fields("前月支払残額").Value = r0.Fields("前月支払残額").Value
                r10.Fields("当月支払額").Value = r0.Fields("当月支払額").Value
                r10.Fields("当月繰越額").Value = r0.Fields("当月繰越額").Value
                r10.Fields("当月取引額").Value = r0.Fields("当月取引額").Value
                r10.Fields("当月消費税額").Value = r0.Fields("当月消費税額").Value
                r10.Fields("当月支払額").Value = r0.Fields("当月支払額").Value
                r10.Fields("支払予定額").Value = r0.Fields("支払予定額").Value
                r10.Fields("支払額").Value = r0.Fields("支払額").Value
                r10.Fields("支払残額").Value = r0.Fields("支払残額").Value
                r10.Fields("前回消費税額").Value = r0.Fields("前回消費税額").Value
                r10.Fields("手数料負担区分").Value = r0.Fields("手数料負担区分").Value
                r10.Fields("相殺金額").Value = r0.Fields("相殺金額").Value
                r10.Fields("手形金額").Value = r0.Fields("手形金額").Value
                r10.Fields("振込金額").Value = r0.Fields("振込金額").Value
                r10.Fields("その他").Value = r0.Fields("その他").Value
                r10.Fields("手数料").Value = r0.Fields("手数料").Value
                r10.Fields("手形元受銀行CD").Value = r0.Fields("手形元受銀行CD").Value
                r10.Fields("振込元受銀行CD").Value = r0.Fields("振込元受銀行CD").Value
                r10.Fields("小切手元受銀行CD").Value = r0.Fields("小切手元受銀行CD").Value
                r10.Fields("手形1").Value = r0.Fields("手形1").Value
                r10.Fields("手形2").Value = r0.Fields("手形2").Value
                r10.Fields("手形3").Value = r0.Fields("手形3").Value
                r10.Fields("消費税0").Value = r0.Fields("消費税0").Value
                r10.Fields("消費税1").Value = r0.Fields("消費税1").Value
                r10.Fields("消費税2").Value = r0.Fields("消費税2").Value
                r10.Update()
            End If
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        r10.Close() : r10 = Nothing

    End Function

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.ItemActivate
        'Dim lv As ListView = DirectCast(sender, ListView)
        'txt支払年度.Text = lv.SelectedItem.SubItems(1)
        'txt支払No.Text = lv.SelectedItem.SubItems(2)
        Dsp_Set10
    End Sub


End Class
