Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Data.OleDb
Public Class F_Co_LogIn00
    Dim pFocus(10) As Object
    Dim pubCom As New Com
    Dim pubProc As New Proc
    Private Mysqlserver As SQLServer = New SQLServer()

    'Public Sub New()
    '    Mysqlserver = New SQLServer()
    'End Sub

    Private Sub F_Co_LogIn00_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            pubProc.Dsp_End00()
            End
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_Co_LogIn00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 122
                Cmd11.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_M_LogIn00_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Cn00.ConnectionString = pubDsn
        'Cn00.Open()

        CnTmp.ConnectionString = pubTmpDB
        Try
            ' データベース接続を開く
            CnTmp.Open()
        Catch ex As OleDbException
            MsgBox("OleDbExceptionが発生しました: " & ex.Message)
        Catch ex As System.Runtime.InteropServices.SEHException
            MsgBox("SEHExceptionが発生しました:  " & ex.Message)
        Catch ex As Exception
            MsgBox("その他の例外が発生しました:  " & ex.Message)
        Finally
        End Try

        Inp_Clr00()
        Add_Cmb()
        Dsp_Init00()
        ActiveControl = txtLogInID
    End Sub

    '******************************************************
    '* TextBoxｸﾘｱ
    '******************************************************
    Private Sub Inp_Clr00()
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        Next
    End Sub
    '******************************************************
    '* ｺﾝﾎﾞﾎﾞｯｸにItemを追加
    '******************************************************
    Private Sub Add_Cmb()

        ' SQLクエリの構築
        Dim SQL As String = "SELECT * FROM MM_会社"

        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL)

        ' 取得したデータの処理
        Dim ComboItemA As New ArrayList()
        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            For Each row As DataRow In result.Rows
                Dim pCD As String = pubCom.ChgNull(row("会社No"), 0)
                Dim pName As String = pubCom.ChgNull(row("会社名"), 1)
                ComboItemA.Add(New MyComboBoxItemA(pName, pCD))
            Next
        End If

        ' リソースの解放
        result.Dispose()

        With CmbA
            .DisplayMember = "ItemName"
            .ValueMember = "ItemCode"
            .DataSource = ComboItemA
            .SelectedIndex = -1
        End With
    End Sub

    '******************************************************
    '* ｲﾍﾞﾝﾄ処理追加
    '******************************************************
    Public Sub Dsp_Init00()
        For Each CtrlItem As Control In GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
    End Sub

    '******************************************************
    '* MM_LogIn00情報取得
    '******************************************************
    Public Function Dsp_Set00() As Byte
        Dsp_Set00 = 0
        If txtLogInID.Text = "" Then Exit Function

        Dim logInIDValue As String = txtLogInID.Text

        ' SQLクエリの構築
        Dim SQL As String = "SELECT * FROM MM_LogIn00 WHERE LogInID = @LogInID"

        ' パラメータのリストを作成
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@LogInID", logInIDValue)
            }

        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        ' 取得したデータの処理
        If result.Rows.Count = 0 Then
            Dsp_Set00 = 9
            Exit Function
        End If

        txtLogIn名.Text = pubCom.ChgNull(result.Rows(0)("名称"), 1)
        txt権限.Text = pubCom.ChgNull(result.Rows(0)("権限"), 1)
        txtComp.Text = pubCom.ChgNull(result.Rows(0)("対象会社CD"), 0)
        txtSvPass.Text = pubCom.ChgNull(result.Rows(0)("PassWord"), 1)

        ' リソースの解放
        result.Dispose()
    End Function
    '******************************************************
    '* MM_LogIn00情報取得/btnPwChange設定無
    '******************************************************
    Public Function Dsp_Set10() As Byte
        Dsp_Set10 = 0

        Dim logInIDValue As String = txtLogInID.Text
        ' SQLクエリの構築
        Dim SQL As String = "SELECT * FROM MM_LogIn00 WHERE LogInID = @LogInID"

        ' パラメータのリストを作成
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@LogInID", logInIDValue)
            }

        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        ' 取得したデータの処理
        If result.Rows.Count = 0 Then
            Dsp_Set10 = 9
            Exit Function
        End If

        txtLogIn名.Text = pubCom.ChgNull(result.Rows(0)("名称"), 1)
        txt権限.Text = pubCom.ChgNull(result.Rows(0)("権限"), 1)
        txtSvPass.Text = pubCom.ChgNull(result.Rows(0)("PassWord"), 1)

        ' リソースの解放
        result.Dispose()

    End Function

    Private Sub txtInp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        Select Case pTxtBox.Name
            Case "txtComp"
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

    Private Sub txtInp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        pTxtBox.SelectAll()
        pTxtBox.BackColor = Color.MistyRose
        txtModified.Text = ""
        Select Case pTxtBox.Name
            Case "txtLogInID"
                AddHandler txtLogInID.TextChanged, AddressOf txtModified_TextChanged
            Case "txtComp"
                AddHandler txtLogInID.TextChanged, AddressOf txtModified_TextChanged
        End Select
        pFocus(0) = pTxtBox
    End Sub

    Private Sub txtInp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case 38
                Me.SelectNextControl(sender, False, True, True, True)
                e.Handled = True
        End Select
    End Sub

    Private Sub txtInp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub

        Select Case pTxtBox.Name
            Case "txtLogInID"
                If txtModified.Text = "1" Then Dsp_Set00()
                RemoveHandler pTxtBox.TextChanged, AddressOf txtModified_TextChanged
            Case "txtComp"
                If txtModified.Text = "1" Then Inp_Chk00(sender)
        End Select
        txtModified.Text = ""
        pTxtBox.BackColor = Color.White
    End Sub
    '******************************************************
    '* MM_LogIn00 更新
    '******************************************************
    Public Sub Data_Put00()
        Dim logInIDValue As String = txtLogInID.Text

        Dim parameters As New List(Of SqlParameter)()
        ' パラメータの追加
        parameters.Add(New SqlParameter("@対象会社CD", txtComp.Text))
        parameters.Add(New SqlParameter("@LogInID", txtLogInID.Text))

        Dim SQL As String = "対象会社CD = @対象会社CD "
        ' 更新条件を指定
        Dim condition As String = "LogInID = @LogInID "
        Mysqlserver.UpdateData("MM_LogIn00", SQL, condition, parameters.ToArray())

    End Sub
    Private Sub Cmd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd11.Click
        Me.Close()
    End Sub
    '******************************************************
    '* 入力ﾁｪｯｸ
    '******************************************************
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True
        txtMsg.Visible = False : txtMsg.Text = ""

        Select Case ctxtInp.Name
            Case "txtLogInID"
                txtLogIn名.Text = ""
                ctxtInp.BackColor = Color.White
                If txtLogInID.Text = "" Then Inp_Chk00 = False : txtMsg.Text = "ﾛｸﾞｲﾝID未入力" : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function

                Dim wRet As Byte = Dsp_Set10()
                If wRet = 9 Then Inp_Chk00 = False : txtMsg.Text = "ﾛｸﾞｲﾝID不正入力" : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
            Case "txtComp"
                ctxtInp.BackColor = Color.White
                If txtComp.Text = "" Then
                    CmbA.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Text = "会社CD未入力" : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

                CmbA.SelectedValue = txtComp.Text
                If CmbA.SelectedIndex = -1 Then
                    Inp_Chk00 = False : txtMsg.Text = "会社CD不正" : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                    CmbA.SelectedIndex = -1
                    Exit Function
                End If
        End Select
    End Function
    '******************************************************
    '* パスワードチェック
    '******************************************************
    Private Function Inp_Chk10()
        Inp_Chk10 = True
        txtMsg.Visible = False : txtMsg.Text = ""

        If txtPass.Text <> txtSvPass.Text Then
            Inp_Chk10 = False : txtMsg.Text = "パスワード不正入力" : txtMsg.Visible = True
        End If
    End Function

    Private Sub btnOK00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK00.Click
        Dim pRet As Boolean

        pRet = Inp_Chk00(txtLogInID)
        If pRet = False Then
            txtLogInID.Focus()
            Exit Sub
        End If

        For Each CtrlItem As Control In GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                pRet = Inp_Chk00(CtrlItem)
                If pRet = False Then Exit Sub
            End If
        Next
        pRet = Inp_Chk10()
        If pRet = True Then
            pubComPany = Integer.Parse(pubCom.ChgNull(txtComp.Text, 0))
            pubLogIn = txtLogInID.Text
            pubRight = Integer.Parse(pubCom.ChgNull(txt権限.Text, 0))
            Data_Put00()
            Dim Fform As New F_Co_Main00
            Fform.Show()
            Me.Hide()
        Else
            txtPass.Focus()
        End If
    End Sub

    Private Sub CmbA_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbA.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbA.SelectedIndex = -1 Then
            txtComp.Text = ""
        Else
            item = DirectCast(CmbA.SelectedItem, MyComboBoxItemA)
            txtComp.Text = item.ItemCode
        End If
    End Sub
    Private Sub txtModified_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtModified.Text = "1"
    End Sub

    Private Sub F_Co_LogIn00_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Cn00.Close() : Cn00.Dispose() : Cn00 = Nothing
        pubProc.Dsp_End00()
        End
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub F_Co_LogIn00_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Me.txtPass.Text = ""
        'If Me.GroupBox00 IsNot Nothing Then
        '    If Me.GroupBox00.Controls Is Nothing Then
        '        MessageBox.Show("GroupBox00のControlsコレクションが初期化されていません。")
        '    Else
        '        MessageBox.Show("GroupBox00のControlsコレクションは初期化されています。")
        '    End If
        'Else
        '    MessageBox.Show("GroupBox00が存在しません。")
        'End If

        'Inp_Clr00()
        'Add_Cmb()
        'Dsp_Init00()
        ActiveControl = txtLogInID

    End Sub
End Class
