Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.ComponentModel
Imports Microsoft.Office.Interop.Access.Dao
Public Class F_Ms_Test
    Dim pFocus(10) As Object
    Dim SQLCmd As New SqlCommand()
    Dim pubCom As New Com
    Dim pubProc As New Proc
    Private Mysqlserver As SQLServer = New SQLServer()
    '******************************************************
    '* テキストBOXの操作設定
    '******************************************************
    Public Sub Dsp_Init00()
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
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
    '* テキストボックスにフォーカスが入った時
    '******************************************************
    Private Sub txtInp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub

        pTxtBox.SelectAll() : pTxtBox.BackColor = Color.MistyRose
        txtModified.Text = ""
        Select Case pTxtBox.Name
            Case "txt区分CD"
                AddHandler txt区分CD.TextChanged, AddressOf txtModified_TextChanged
            Case "txt明細CD"
                AddHandler txt明細CD.TextChanged, AddressOf txtModified_TextChanged
        End Select
        pFocus(0) = pTxtBox
    End Sub
    '******************************************************
    '* テキストBOX内でキーが押されたとき
    '******************************************************
    Private Sub txtInp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case 38
                Me.SelectNextControl(sender, False, True, True, True)
                e.Handled = True
        End Select
    End Sub
    '******************************************************
    '* テキストBOX内の入力文字の制限設定
    '******************************************************
    Private Sub txtInp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim pRet As Boolean
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        Select Case pTxtBox.Name
            Case "txt区分CD", "txt明細CD"
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select
        End Select

        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                pRet = Inp_Chk00(sender)
                If pRet = False Then Exit Sub
                Me.SelectNextControl(sender, True, True, True, True)
                e.Handled = True
        End Select
    End Sub
    '******************************************************
    '* テキストBOXからフォーカスが離れた時
    '******************************************************
    Private Sub txtInp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub

        Select Case pTxtBox.Name
            Case "txt区分CD"
                If txtModified.Text = "1" Then
                    btnOK00.PerformClick()
                    RemoveHandler pTxtBox.TextChanged, AddressOf txtModified_TextChanged
                End If
            Case "txt明細CD"
                If txtModified.Text = "1" Then
                    Data_Get00()
                    RemoveHandler pTxtBox.TextChanged, AddressOf txtModified_TextChanged
                End If
        End Select
        txtModified.Text = "" : pTxtBox.BackColor = Color.White
    End Sub
    '******************************************************
    '* リストビューにItemを表示する共通関数
    '******************************************************
    Private Sub Add_Item00()
        Dim SQL As String



        SQL = "SELECT * From MM_区分M00 WHERE 会社No = @会社No AND 区分 = @区分 ORDER BY CD"

        ' パラメータのリストを作成
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@会社No", pubComPany),
            New SqlParameter("@区分", txt区分CD.Text)
            }

        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        ' 取得したデータの処理
        LV.Items.Clear()
        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            Dim i0 As Integer = 0
            For Each Row As DataRow In result.Rows
                LV.Items.Add(Integer.Parse(Row("CD")).ToString("000"), i0)
                LV.Items(i0).SubItems.Add(pubCom.ChgNull(Row("名称"), 1))
                i0 += 1
            Next
        End If

        result.Dispose()

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
        For Each CtrlItem As Control In Me.GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        Next
        LV.Items.Clear()
        txtMsg.Text = ""
        txtMsg.Visible = False

        GroupBox10.Enabled = False
        GroupBox20.Enabled = False
    End Sub
    '******************************************************
    '* フィールドクリア関数
    '******************************************************
    Private Sub Inp_Clr10()
        'For Each CtrlItem As Control In Me.GroupBox10.Controls
        '    If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        'Next
        'For Each CtrlItem As Control In Me.GroupBox20.Controls
        '    If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        'Next
        'lv.Items.Clear()
        'txtMsg.Text = "" : txtMsg.Visible = False
    End Sub


    Private Sub txtModified_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtModified.Text = "1"
    End Sub

    Private Sub Cmd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd11.Click
        'Me.Close()
    End Sub



    Private Sub F_Ms_Test_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Select Case e.KeyCode
        '    Case 116
        '        Cmd05.PerformClick() : e.Handled = True
        '    Case 120
        '        Cmd09.PerformClick() : e.Handled = True
        '    Case 122
        '        Cmd11.PerformClick() : e.Handled = True
        'End Select
    End Sub

    Private Sub F_Ms_Test_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Inp_Clr00()
        Dsp_Init00()

        Me.ActiveControl = txt区分CD
    End Sub

    Private Sub Cmd09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd09.Click
        Dim strName As String = pFocus(0).Name
        'Select Case strName
        '    Case "txt区分CD"
        '        La区分CD_Click(sender, e)
        'End Select
        'Me.ActiveControl = pFocus(0)
    End Sub

    Private Sub btnOK00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK00.Click
        'Dim pRet As Boolean = Inp_Chk00(txt区分CD)
        'If pRet = False Then Exit Sub


        Add_Item00()
        GroupBox10.Enabled = True
        GroupBox20.Enabled = True
        txt明細CD.Focus()
        GroupBox00.Enabled = False
    End Sub
    Private Sub btnOK10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim pRet As Boolean = Inp_Chk00(txt区分CD)
        'If pRet = False Then Exit Sub
        'pRet = Inp_Chk00(txt明細CD)
        'If pRet = False Then Exit Sub

        'Data_Get00()
        'txt明細名.Focus()
    End Sub

    '******************************************************
    '* 入力項目ﾁｪｯｸ
    '******************************************************
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        '    Inp_Chk00 = True
        '    txtMsg.Visible = False : txtMsg.Text = ""
        '    Select Case ctxtInp.Name
        '        Case "txt区分CD"
        '            ctxtInp.BackColor = Color.White
        '            If txt区分CD.Text = "" Then
        '                txtMsg.Text = "区分CD未入力"
        '                Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
        '            End If

        '            Dim SQL As String
        '            SQL = "SELECT * " _
        '                & "FROM MM_区分M00 " _
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

    End Function
    '******************************************************
    '* データの削除
    '******************************************************
    Public Sub Data_Del00()
        'Dim condition As String = "会社No = @会社No " &
        '                          "AND 区分 = @区分 " &
        '                          "AND CD = @CD "

        'Dim parameters As New List(Of SqlParameter) From {
        '    New SqlParameter("@会社No", pubComPany),
        '    New SqlParameter("@区分", txt区分CD.Text),
        '    New SqlParameter("@CD", txt明細CD.Text)
        '}

        'Mysqlserver.DeleteData("MM_区分M00", condition, parameters.ToArray())
    End Sub

    '******************************************************
    '* データの取得
    '******************************************************
    Public Sub Data_Get00()

        Dim SQL As String

        SQL = "SELECT * " _
            & "FROM MM_区分M00 " _
            & "WHERE 会社No = @会社No " _
            & "AND 区分 = @区分 " _
            & "AND CD = @CD"

        Dim parameters As New List(Of SqlParameter) From {
        New SqlParameter("@会社No", pubComPany),
        New SqlParameter("@区分", txt区分CD.Text),
        New SqlParameter("@CD", txt明細CD.Text),
        New SqlParameter("@区分名", txt区分名.Text),
        New SqlParameter("@名称", txt明細名.Text),
        New SqlParameter("@Sub項目1", txtSub項目1.Text),
        New SqlParameter("@Sub項目2", txtSub項目2.Text)
        }

        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())


        If result.Rows.Count > 0 Then
            txt明細CD.Text = pubCom.ChgNull(result.Rows(0)("CD"), 1)
            txt明細名.Text = pubCom.ChgNull(result.Rows(0)("名称"), 1)
            txtSub項目1.Text = pubCom.ChgNull(result.Rows(0)("Sub項目1"), 1)
            txtSub項目2.Text = pubCom.ChgNull(result.Rows(0)("Sub項目2"), 1)
            For Each CtrlItem As Control In Me.GroupBox10.Controls
                If TypeOf CtrlItem Is TextBox Then Inp_Chk00(CtrlItem)
            Next
        End If


    End Sub
    '******************************************************
    '* MM_区分M00保存
    '******************************************************
    Public Sub Data_Put00()
        'Dim SQL As String
        'SQL = " SELECT * FROM MM_区分M00 WHERE 会社No = @会社No AND 区分 = @区分 AND CD = @CD"

        'Dim parameters As New List(Of SqlParameter) From {
        'New SqlParameter("@会社No", pubComPany),
        'New SqlParameter("@区分", txt区分CD.Text),
        'New SqlParameter("@CD", txt明細CD.Text),
        'New SqlParameter("@区分名", txt区分名.Text),
        'New SqlParameter("@名称", txt明細名.Text),
        'New SqlParameter("@Sub項目1", txtSub項目1.Text),
        'New SqlParameter("@Sub項目2", txtSub項目2.Text),
        'New SqlParameter("@削除", 0)
        '}

        'Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        'parameters.Clear()
        'parameters.Add(New SqlParameter("@会社No", pubComPany))
        'parameters.Add(New SqlParameter("@区分", txt区分CD.Text))
        'parameters.Add(New SqlParameter("@CD", txt明細CD.Text))
        'parameters.Add(New SqlParameter("@区分名", txt区分名.Text))
        'parameters.Add(New SqlParameter("@名称", txt明細名.Text))
        'parameters.Add(New SqlParameter("@Sub項目1", txtSub項目1.Text))
        'parameters.Add(New SqlParameter("@Sub項目2", txtSub項目2.Text))
        'parameters.Add(New SqlParameter("@削除", 0))

        'If result.Rows.Count = 0 Then
        '    Dim columns As String = "会社No " &
        '        ", 区分 " &
        '        ", CD " &
        '        ", 区分名 " &
        '        ", 名称 " &
        '        ", Sub項目1 " &
        '        ", Sub項目2 " &
        '        ", 削除 "

        '    Dim values As String = "@会社No " &
        '        ", @区分 " &
        '        ", @CD " &
        '        ", @区分名 " &
        '        ", @名称 " &
        '        ", @Sub項目1 " &
        '        ", @Sub項目2 " &
        '        ", @削除 "

        '    Mysqlserver.InsertData("MM_区分M00", columns, values, parameters.ToArray())

        'Else
        '    Dim setStatement As String = "区分名 = @区分名" &
        '                                 ", 名称 = @名称 " &
        '                                 ", Sub項目1 = @Sub項目1 " &
        '                                 ", Sub項目2 = @Sub項目2 " &
        '                                 ", 削除 = @削除 "
        '    ' 更新条件を指定
        '    Dim condition As String = "会社No = @会社No " &
        '                              "AND 区分 = @区分 " &
        '                              "AND CD = @CD "
        '    Mysqlserver.UpdateData("MM_区分M00", setStatement, condition, parameters.ToArray())
        'End If
        'result.Dispose()



    End Sub

    '******************************************************
    '* MM_区分M00保存
    '******************************************************
    Private Sub btnUp00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp00.Click
        'Dim pRet As Boolean = Inp_Chk00(txt区分CD)
        'If pRet = False Then Exit Sub
        'pRet = Inp_Chk00(txt明細CD)
        'If pRet = False Then Exit Sub

        'For Each CtrlItem As Control In Me.GroupBox10.Controls
        '    If TypeOf CtrlItem Is TextBox Then
        '        pRet = Inp_Chk00(CtrlItem)
        '        If pRet = False Then Exit Sub
        '    End If
        'Next

        'Data_Put00()
        'Inp_Clr10()
        'Add_Item00()
        'txt明細CD.Focus()
    End Sub

    '******************************************************
    '* MM_区分M00削除
    '******************************************************
    Private Sub btnDel00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel00.Click
        'Dim pRet As Boolean = Inp_Chk00(txt区分CD)
        'If pRet = False Then Exit Sub
        'pRet = Inp_Chk00(txt明細CD)
        'If pRet = False Then Exit Sub

        'Dim wMsg As String = "CD:" & txt明細CD.Text & Chr(13) _
        '    & "名称:" & txt明細名.Text & Chr(13) _
        '    & "このデータをマスタから削除します。"
        'Dim wAns As Integer = MsgBox(wMsg, vbYesNo + vbQuestion, "データ削除")
        'If wAns = vbNo Then Exit Sub

        'Data_Del00()
        'Inp_Clr10()
        'Add_Item00()
        'txt明細CD.Focus()
    End Sub

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.ItemActivate
        'Dim lv As ListView = DirectCast(sender, ListView)

        'txt明細CD.Text = lv.FocusedItem.Text
        'Data_Get00()
    End Sub

    Private Sub La区分CD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles La区分CD.Click
        'Dim frmForm = New F_S_KuBunH00
        'frmForm.pubCD = ""
        'If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    If IsNumeric(frmForm.pubCD) Then
        '        txt区分CD.Text = Integer.Parse(frmForm.pubCD)
        '        btnOK00.PerformClick()
        '    End If
        '    txt区分CD.Focus()
        'End If
    End Sub

    Private Sub Cmd05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd05.Click
        'Inp_Clr00()
        'GroupBox00.Enabled = True
        'txt区分CD.Focus()
    End Sub

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    '    Dim frmForm = New F_S_KuBunM00
    '    frmForm.pubCD = ""
    '    frmForm.pubKuCD = txt区分CD.Text
    '    frmForm.pubNM = txt明細名.Text
    '    If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        If IsNumeric(frmForm.pubCD) Then
    '            txt明細CD.Text = Integer.Parse(frmForm.pubCD)

    '        End If
    '        txt明細CD.Focus()
    '    End If
    'End Sub
End Class