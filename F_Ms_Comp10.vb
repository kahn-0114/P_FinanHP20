Imports System.Data.SqlClient
Public Class F_Ms_Comp10
    Dim pFocus(10) As Object
    Dim SQLCmdA As New SqlCommand()
    Dim _pubCD As String = String.Empty
    Dim pubCom As New Com

    Public Property pubCD() As String
        Get
            pubCD = _pubCD
        End Get
        Set(ByVal value As String)
            _pubCD = value
        End Set
    End Property

    Private Sub F_Ms_Comp10_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SQLCmdA.Dispose() : SQLCmdA = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_Ms_Comp10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 120
                Cmd09.PerformClick() : e.Handled = True
            Case 122
                Cmd11.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_Ms_Comp10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SQLCmdA = Cn00.CreateCommand()
        Inp_Clr00()
        Dsp_Init00()
        Add_Cmb()
        txt会社No.Text = pubCD
        btnOK00.PerformClick()
        Me.ActiveControl = Me.txt得意先
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
        txtMsg.Text = "" : txtMsg.Visible = False
        Me.GroupBox00.Enabled = True
    End Sub
    '******************************************************
    '* データの取得
    '******************************************************
    Public Sub Data_Get00()
        Dim da0 As New SqlDataAdapter
        Dim dt0 As New DataSet
        Dim SQL As String

        SQL = "SELECT * " _
            & "From MM_会社00 " _
            & "WHERE (会社No =" & txt会社No.Text & ")"
        SQLCmdA.CommandText = SQL
        da0.SelectCommand = SQLCmdA
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            If .Rows.Count > 0 Then
                txt得意先.Text = pubCom.ChgNull(.Rows(0)("得意先CD"), 1)
                txt得意先枝.Text = pubCom.ChgNull(.Rows(0)("得意先枝CD"), 1)
                txt仕入先.Text = pubCom.ChgNull(.Rows(0)("仕入先CD"), 1)
                txt仕入先枝.Text = pubCom.ChgNull(.Rows(0)("仕入先枝CD"), 1)
                txt商品.Text = pubCom.ChgNull(.Rows(0)("商品CD"), 1)
                txt部門.Text = pubCom.ChgNull(.Rows(0)("部門CD"), 1)
                txt財務科目.Text = pubCom.ChgNull(.Rows(0)("科目CD"), 1)
                txt財務科目枝.Text = pubCom.ChgNull(.Rows(0)("科目枝CD"), 1)
                txt財務部門CD.Text = pubCom.ChgNull(.Rows(0)("財務部門CD"), 1)
                For Each CtrlItem As Control In Me.GroupBox10.Controls
                    If TypeOf CtrlItem Is TextBox Then
                        Dim pRet As Boolean = Inp_Chk00(CtrlItem)
                        If pRet = False Then Exit Sub
                    End If
                Next
            End If
        End With
        dt0.Dispose() : dt0 = Nothing
        da0.Dispose() : da0 = Nothing
    End Sub
    '******************************************************
    '* データの取得
    '******************************************************
    Public Sub Data_Put00()
        Dim SQL As String
        SQL = "UPDATE MM_会社00 SET "
        SQL = SQL & "得意先CD= @得意先CD"
        SQL = SQL & ",得意先枝CD= @得意先枝CD"
        SQL = SQL & ",仕入先CD= @仕入先CD"
        SQL = SQL & ",仕入先枝CD= @仕入先枝CD"
        SQL = SQL & ",商品CD= @商品CD"
        SQL = SQL & ",部門CD= @部門CD"
        SQL = SQL & ",科目CD= @科目CD"
        SQL = SQL & ",科目枝CD= @科目枝CD"
        SQL = SQL & ",財務部門CD= @財務部門CD"

        SQL = SQL & " WHERE (会社No=" & pubComPany & ")"
        Dim command As SqlCommand = New SqlCommand(SQL, Cn00)
        command.Parameters.Clear()

        command.Parameters.Add("@得意先CD", SqlDbType.TinyInt).Value = pubCom.ChgNull(txt得意先.Text, 0)
        command.Parameters.Add("@得意先枝CD", SqlDbType.TinyInt).Value = pubCom.ChgNull(txt得意先枝.Text, 0)
        command.Parameters.Add("@仕入先CD", SqlDbType.TinyInt).Value = pubCom.ChgNull(txt仕入先.Text, 0)
        command.Parameters.Add("@仕入先枝CD", SqlDbType.TinyInt).Value = pubCom.ChgNull(txt仕入先枝.Text, 0)
        command.Parameters.Add("@商品CD", SqlDbType.TinyInt).Value = pubCom.ChgNull(txt商品.Text, 0)
        command.Parameters.Add("@部門CD", SqlDbType.TinyInt).Value = pubCom.ChgNull(txt部門.Text, 0)
        command.Parameters.Add("@科目CD", SqlDbType.TinyInt).Value = pubCom.ChgNull(txt財務科目.Text, 0)
        command.Parameters.Add("@科目枝CD", SqlDbType.TinyInt).Value = pubCom.ChgNull(txt財務科目枝.Text, 0)
        command.Parameters.Add("@財務部門CD", SqlDbType.TinyInt).Value = pubCom.ChgNull(txt財務部門CD.Text, 0)

        Dim wRet As Integer = command.ExecuteNonQuery()
        command.Dispose()
    End Sub
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True : txtMsg.Visible = False : txtMsg.Text = ""
        Select Case ctxtInp.Name
            Case "txt会社No"
                ctxtInp.BackColor = Color.White
                If txt会社No.Text = "" Then
                    txtMsg.Text = "会社CD未入力"
                    Inp_Chk00 = False : ctxtInp.BackColor = Color.LightCoral : txtMsg.Visible = True
                End If
        End Select
    End Function
    '******************************************************
    '*
    '******************************************************
    Public Sub Dsp_Init00()
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
    End Sub
    Private Sub txtInp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        pTxtBox.SelectAll()
        pTxtBox.BackColor = Color.MistyRose
        pFocus(0) = pTxtBox
    End Sub
    Private Sub txtInp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim pRet As Boolean
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        Select Case pTxtBox.Name
            Case Else
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select
        End Select

        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                pRet = Inp_Chk00(sender)
                If pRet = False Then
                    Exit Sub
                End If
                Me.SelectNextControl(sender, True, True, True, True)
                e.Handled = True
        End Select
    End Sub
    Private Sub txtInp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        Select Case e.KeyCode
            Case 38
                Me.SelectNextControl(sender, False, True, True, True)
                e.Handled = True
            Case 120
                Cmd09.PerformClick()
        End Select
    End Sub

    Private Sub txtInp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        pTxtBox.BackColor = Color.White
    End Sub

    Private Sub Cmd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd11.Click
        Me.Close()
    End Sub

    Private Sub Cmd01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd01.Click

        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim pRet As Boolean = Inp_Chk00(CtrlItem)
                If pRet = False Then Exit Sub
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim pRet As Boolean = Inp_Chk00(CtrlItem)
                If pRet = False Then Exit Sub
            End If
        Next
        Data_Put00()
        'Com.GetNen(SQLCmdA)
        Close()
    End Sub
    '******************************************************
    '* コンボボックスにItemを追加する。
    '******************************************************
    Private Sub Add_Cmb()
        Dim SQL As String
        Dim ComboItemA As New ArrayList()

        Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        SQL = "SELECT * " _
            & "FROM MM_会社00 " _
            & "ORDER BY 会社No"
        SQLCmdA.CommandText = SQL
        da0.SelectCommand = SQLCmdA
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            For i As Integer = 0 To .Rows.Count - 1
                Dim pCD As String = pubCom.ChgNull(.Rows(i)("会社No"), 0)
                Dim pName As String = pubCom.ChgNull(.Rows(i)("会社名"), 1)
                ComboItemA.Add(New MyComboBoxItemA(pName, pCD))
            Next
        End With
        dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing

        'CmbComp.DisplayMember = "ItemName"
        'CmbComp.ValueMember = "ItemCode"
        'CmbComp.DataSource = ComboItemA
        'CmbComp.SelectedIndex = -1
    End Sub

    Private Sub btnOK00_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK00.Click
        Dim pRet As Boolean = Inp_Chk00(txt会社No)
        If pRet = False Then
            Exit Sub
        End If
        Data_Get00()
        txt得意先.Focus()
        Me.GroupBox00.Enabled = False
    End Sub
End Class
