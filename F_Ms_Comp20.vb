Imports System.Data.SqlClient
Public Class F_Ms_Comp20
    Dim pFocus(10) As Object
    Dim SQLCmdA As New SqlCommand()
    Dim _pubCD As String = String.Empty
    Dim PubCom As New Com

    Public Property pubCD() As String
        Get
            pubCD = _pubCD
        End Get
        Set(ByVal value As String)
            _pubCD = value
        End Set
    End Property

    Private Sub F_Ms_Comp20_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SQLCmdA.Dispose() : SQLCmdA = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_Ms_Comp20_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 120
                Cmd09.PerformClick() : e.Handled = True
            Case 122
                Cmd11.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_Ms_Comp20_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SQLCmdA = Cn00.CreateCommand()
        Inp_Clr00()
        Dsp_Init00()
        Add_Cmb()
        txt会社No.Text = pubCD
        btnOK00.PerformClick()
        Me.ActiveControl = Me.txt得意先Gp名1
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
        '商品Gp取得
        SQL = "SELECT * " _
            & "From MM_会社20 " _
            & "WHERE (会社No =" & pubComPany & ") " _
            & "And (CtlNo = 0)"
        SQLCmdA.CommandText = SQL
        da0.SelectCommand = SQLCmdA
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            If .Rows.Count > 0 Then
                txt商品Gp名1.Text = PubCom.ChgNull(.Rows(0)("Gp名1"), 1)
                txt商品Gp名2.Text = PubCom.ChgNull(.Rows(0)("Gp名2"), 1)
                txt商品Gp名3.Text = PubCom.ChgNull(.Rows(0)("Gp名3"), 1)
                txt商品Gp名4.Text = PubCom.ChgNull(.Rows(0)("Gp名4"), 1)
                txt商品Gp名5.Text = PubCom.ChgNull(.Rows(0)("Gp名5"), 1)
                CChk1.Checked = False
                CChk2.Checked = False
                CChk3.Checked = False
                CChk4.Checked = False
                CChk5.Checked = False
                If PubCom.ChgNull(.Rows(0)("使用1"), 0) = 1 Then
                    CChk1.Checked = True
                    txt商品Gp名1.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用2"), 0) = 1 Then
                    CChk2.Checked = True
                    txt商品Gp名2.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用3"), 0) = 1 Then
                    CChk3.Checked = True
                    txt商品Gp名3.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用4"), 0) = 1 Then
                    CChk4.Checked = True
                    txt商品Gp名4.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用5"), 0) = 1 Then
                    CChk5.Checked = True
                    txt商品Gp名5.Enabled = True
                End If
            End If
            .Clear()
        End With

        '得意先Gp取得
        SQL = "SELECT * " _
            & "From MM_会社20 " _
            & "WHERE (会社No =" & pubComPany & ") " _
            & "And (CtlNo = 1)"
        SQLCmdA.CommandText = SQL
        da0.SelectCommand = SQLCmdA
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            If .Rows.Count > 0 Then
                txt得意先Gp名1.Text = PubCom.ChgNull(.Rows(0)("Gp名1"), 1)
                txt得意先Gp名2.Text = PubCom.ChgNull(.Rows(0)("Gp名2"), 1)
                txt得意先Gp名3.Text = PubCom.ChgNull(.Rows(0)("Gp名3"), 1)
                txt得意先Gp名4.Text = PubCom.ChgNull(.Rows(0)("Gp名4"), 1)
                txt得意先Gp名5.Text = PubCom.ChgNull(.Rows(0)("Gp名5"), 1)
                TChk1.Checked = False
                TChk2.Checked = False
                TChk3.Checked = False
                TChk4.Checked = False
                TChk5.Checked = False
                If PubCom.ChgNull(.Rows(0)("使用1"), 0) = 1 Then
                    TChk1.Checked = True
                    txt得意先Gp名1.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用2"), 0) = 1 Then
                    TChk2.Checked = True
                    txt得意先Gp名2.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用3"), 0) = 1 Then
                    TChk3.Checked = True
                    txt得意先Gp名3.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用4"), 0) = 1 Then
                    TChk4.Checked = True
                    txt得意先Gp名4.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用5"), 0) = 1 Then
                    TChk5.Checked = True
                    txt得意先Gp名5.Enabled = True
                End If
            End If
            .Clear()
        End With

        '仕入先Gp取得
        SQL = "SELECT * " _
            & "From MM_会社20 " _
            & "WHERE (会社No =" & pubComPany & ") " _
            & "And (CtlNo = 2)"
        SQLCmdA.CommandText = SQL
        da0.SelectCommand = SQLCmdA
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            If .Rows.Count > 0 Then
                txt仕入先Gp名1.Text = PubCom.ChgNull(.Rows(0)("Gp名1"), 1)
                txt仕入先Gp名2.Text = PubCom.ChgNull(.Rows(0)("Gp名2"), 1)
                txt仕入先Gp名3.Text = PubCom.ChgNull(.Rows(0)("Gp名3"), 1)
                txt仕入先Gp名4.Text = PubCom.ChgNull(.Rows(0)("Gp名4"), 1)
                txt仕入先Gp名5.Text = PubCom.ChgNull(.Rows(0)("Gp名5"), 1)
                PChk1.Checked = False
                PChk2.Checked = False
                PChk3.Checked = False
                PChk4.Checked = False
                PChk5.Checked = False
                If PubCom.ChgNull(.Rows(0)("使用1"), 0) = 1 Then
                    PChk1.Checked = True
                    txt仕入先Gp名1.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用2"), 0) = 1 Then
                    PChk2.Checked = True
                    txt仕入先Gp名2.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用3"), 0) = 1 Then
                    PChk3.Checked = True
                    txt仕入先Gp名3.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用4"), 0) = 1 Then
                    PChk4.Checked = True
                    txt仕入先Gp名4.Enabled = True
                End If
                If PubCom.ChgNull(.Rows(0)("使用5"), 0) = 1 Then
                    PChk5.Checked = True
                    txt仕入先Gp名5.Enabled = True
                End If
            End If
            .Clear()
        End With

        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim pRet As Boolean = Inp_Chk00(CtrlItem)
                If pRet = False Then Exit Sub
            End If
        Next
        dt0.Dispose() : dt0 = Nothing
        da0.Dispose() : da0 = Nothing
    End Sub
    '******************************************************
    '* データの取得
    '******************************************************
    Public Sub Data_Put00()
        Dim SQL As String
        SQL = "DELETE FROM MM_会社20 " _
            & "WHERE (会社No =" & pubComPany & ")"
        Dim command As SqlCommand = New SqlCommand(SQL, Cn00)
        Dim wRet As Integer = command.ExecuteNonQuery()
        command.Dispose() : command = Nothing

        '商品
        SQL = "INSERT INTO " & SQLDB & ".[dbo].[MM_会社20] (" _
            & "会社No,CtlNo,Gp名1,Gp名2,Gp名3,Gp名4,Gp名5,使用1,使用2,使用3,使用4,使用5)"
        SQL = SQL & "VALUES (@会社No,@CtlNo,@Gp名1,@Gp名2,@Gp名3,@Gp名4,@Gp名5,@使用1,@使用2,@使用3,@使用4,@使用5)"
        command = New SqlCommand(SQL, Cn00)
        command.Parameters.Clear()

        command.Parameters.Add("@会社No", SqlDbType.Int).Value = pubComPany
        command.Parameters.Add("@CtlNo", SqlDbType.Int).Value = 0
        command.Parameters.Add("@Gp名1", SqlDbType.NVarChar).Value = txt商品Gp名1.Text
        command.Parameters.Add("@Gp名2", SqlDbType.NVarChar).Value = txt商品Gp名2.Text
        command.Parameters.Add("@Gp名3", SqlDbType.NVarChar).Value = txt商品Gp名3.Text
        command.Parameters.Add("@Gp名4", SqlDbType.NVarChar).Value = txt商品Gp名4.Text
        command.Parameters.Add("@Gp名5", SqlDbType.NVarChar).Value = txt商品Gp名5.Text
        command.Parameters.Add("@使用1", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用2", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用3", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用4", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用5", SqlDbType.TinyInt).Value = 0
        If CChk1.Checked = True Then
            command.Parameters("@使用1").Value = 1
        End If
        If CChk2.Checked = True Then
            command.Parameters("@使用2").Value = 1
        End If
        If CChk3.Checked = True Then
            command.Parameters("@使用3").Value = 1
        End If
        If CChk4.Checked = True Then
            command.Parameters("@使用4").Value = 1
        End If
        If CChk5.Checked = True Then
            command.Parameters("@使用5").Value = 1
        End If
        wRet = command.ExecuteNonQuery()
        command.Dispose()

        '得意先
        SQL = "INSERT INTO " & SQLDB & ".[dbo].[MM_会社20] (" _
            & "会社No,CtlNo,Gp名1,Gp名2,Gp名3,Gp名4,Gp名5,使用1,使用2,使用3,使用4,使用5)"
        SQL = SQL & "VALUES (@会社No,@CtlNo,@Gp名1,@Gp名2,@Gp名3,@Gp名4,@Gp名5,@使用1,@使用2,@使用3,@使用4,@使用5)"
        command = New SqlCommand(SQL, Cn00)
        command.Parameters.Clear()

        command.Parameters.Add("@会社No", SqlDbType.Int).Value = pubComPany
        command.Parameters.Add("@CtlNo", SqlDbType.Int).Value = 1
        command.Parameters.Add("@Gp名1", SqlDbType.NVarChar).Value = txt得意先Gp名1.Text
        command.Parameters.Add("@Gp名2", SqlDbType.NVarChar).Value = txt得意先Gp名2.Text
        command.Parameters.Add("@Gp名3", SqlDbType.NVarChar).Value = txt得意先Gp名3.Text
        command.Parameters.Add("@Gp名4", SqlDbType.NVarChar).Value = txt得意先Gp名4.Text
        command.Parameters.Add("@Gp名5", SqlDbType.NVarChar).Value = txt得意先Gp名5.Text
        command.Parameters.Add("@使用1", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用2", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用3", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用4", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用5", SqlDbType.TinyInt).Value = 0
        If TChk1.Checked = True Then
            command.Parameters("@使用1").Value = 1
        End If
        If TChk2.Checked = True Then
            command.Parameters("@使用2").Value = 1
        End If
        If TChk3.Checked = True Then
            command.Parameters("@使用3").Value = 1
        End If
        If TChk4.Checked = True Then
            command.Parameters("@使用4").Value = 1
        End If
        If TChk5.Checked = True Then
            command.Parameters("@使用5").Value = 1
        End If
        wRet = command.ExecuteNonQuery()
        command.Dispose()

        '仕入先
        SQL = "INSERT INTO " & SQLDB & ".[dbo].[MM_会社20] (" _
            & "会社No,CtlNo,Gp名1,Gp名2,Gp名3,Gp名4,Gp名5,使用1,使用2,使用3,使用4,使用5)"
        SQL = SQL & "VALUES (@会社No,@CtlNo,@Gp名1,@Gp名2,@Gp名3,@Gp名4,@Gp名5,@使用1,@使用2,@使用3,@使用4,@使用5)"
        command = New SqlCommand(SQL, Cn00)
        command.Parameters.Clear()

        command.Parameters.Add("@会社No", SqlDbType.Int).Value = pubComPany
        command.Parameters.Add("@CtlNo", SqlDbType.Int).Value = 2
        command.Parameters.Add("@Gp名1", SqlDbType.NVarChar).Value = txt仕入先Gp名1.Text
        command.Parameters.Add("@Gp名2", SqlDbType.NVarChar).Value = txt仕入先Gp名2.Text
        command.Parameters.Add("@Gp名3", SqlDbType.NVarChar).Value = txt仕入先Gp名3.Text
        command.Parameters.Add("@Gp名4", SqlDbType.NVarChar).Value = txt仕入先Gp名4.Text
        command.Parameters.Add("@Gp名5", SqlDbType.NVarChar).Value = txt仕入先Gp名5.Text
        command.Parameters.Add("@使用1", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用2", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用3", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用4", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@使用5", SqlDbType.TinyInt).Value = 0
        If PChk1.Checked = True Then
            command.Parameters("@使用1").Value = 1
        End If
        If PChk2.Checked = True Then
            command.Parameters("@使用2").Value = 1
        End If
        If PChk3.Checked = True Then
            command.Parameters("@使用3").Value = 1
        End If
        If PChk4.Checked = True Then
            command.Parameters("@使用4").Value = 1
        End If
        If PChk5.Checked = True Then
            command.Parameters("@使用5").Value = 1
        End If
        wRet = command.ExecuteNonQuery()
        command.Dispose()

    End Sub
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True : txtMsg.Visible = False : txtMsg.Text = ""
        Select Case ctxtInp.Name
            Case "txt会社No"
                ctxtInp.BackColor = Color.White
                If txt会社No.Text = "" Then
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                    txtMsg.Text = "会社CD未入力"
                    'CmbComp.SelectedIndex = -1
                Else
                    'CmbComp.SelectedValue = txt会社No.Text
                    'If CmbComp.SelectedIndex = -1 Then
                    '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                    '    txtMsg.Text = "会社CD不正"
                    '    CmbComp.SelectedIndex = -1
                    'End If
                End If
                Exit Function
            Case "txt得意先Gp名1", "txt得意先Gp名2", "txt得意先Gp名3", "txt得意先Gp名4", "txt得意先Gp名5"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(ctxtInp.Text)
                If LenB > 50 Then
                    txtMsg.Text = "得意先Gp名超過:50"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt仕入先Gp名1", "txt仕入先Gp名2", "txt仕入先Gp名3", "txt仕入先Gp名4", "txt仕入先Gp名5"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(ctxtInp.Text)
                If LenB > 50 Then
                    txtMsg.Text = "仕入先Gp名超過:50"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt商品Gp名1", "txt商品Gp名2", "txt商品Gp名3", "txt商品Gp名4", "txt商品Gp名5"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(ctxtInp.Text)
                If LenB > 50 Then
                    txtMsg.Text = "商品Gp名超過:50"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
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
        If pTxtBox.ReadOnly = True Then Exit Sub

        pTxtBox.SelectAll()
        pTxtBox.BackColor = Color.MistyRose
        pFocus(0) = pTxtBox
    End Sub
    Private Sub txtInp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim pRet As Boolean
        Dim pTxtBox As TextBox = CType(sender, TextBox)

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
        Select Case e.KeyCode
            Case 38
                Me.SelectNextControl(sender, False, True, True, True)
                e.Handled = True
        End Select
    End Sub

    Private Sub txtInp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub

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
                Dim pCD As String = PubCom.ChgNull(.Rows(i)("会社No"), 0)
                Dim pName As String = PubCom.ChgNull(.Rows(i)("会社名"), 1)
                ComboItemA.Add(New MyComboBoxItemA(pName, pCD))
            Next
        End With
        dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
    End Sub

    Private Sub btnOK00_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK00.Click
        Dim pRet As Boolean = Inp_Chk00(txt会社No)
        If pRet = False Then Exit Sub
        Data_Get00()
        Me.GroupBox00.Enabled = False
    End Sub


    Private Sub TChk1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TChk1.CheckedChanged
        If TChk1.Checked = True Then txt得意先Gp名1.Enabled = True
        If TChk1.Checked = False Then txt得意先Gp名1.Enabled = False
    End Sub

    Private Sub TChk2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TChk2.CheckedChanged
        If TChk2.Checked = True Then txt得意先Gp名2.Enabled = True
        If TChk2.Checked = False Then txt得意先Gp名2.Enabled = False
    End Sub

    Private Sub TChk3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TChk3.CheckedChanged
        If TChk3.Checked = True Then txt得意先Gp名3.Enabled = True
        If TChk3.Checked = False Then txt得意先Gp名3.Enabled = False
    End Sub

    Private Sub TChk4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TChk4.CheckedChanged
        If TChk4.Checked = True Then txt得意先Gp名4.Enabled = True
        If TChk4.Checked = False Then txt得意先Gp名4.Enabled = False
    End Sub

    Private Sub TChk5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TChk5.CheckedChanged
        If TChk5.Checked = True Then txt得意先Gp名5.Enabled = True
        If TChk5.Checked = False Then txt得意先Gp名5.Enabled = False
    End Sub

    Private Sub PChk1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PChk1.CheckedChanged
        If PChk1.Checked = True Then txt仕入先Gp名1.Enabled = True
        If PChk1.Checked = False Then txt仕入先Gp名1.Enabled = False
    End Sub

    Private Sub PChk2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PChk2.CheckedChanged
        If PChk2.Checked = True Then txt仕入先Gp名2.Enabled = True
        If PChk2.Checked = False Then txt仕入先Gp名2.Enabled = False
    End Sub

    Private Sub PChk3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PChk3.CheckedChanged
        If PChk3.Checked = True Then txt仕入先Gp名3.Enabled = True
        If PChk3.Checked = False Then txt仕入先Gp名3.Enabled = False
    End Sub

    Private Sub PChk4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PChk4.CheckedChanged
        If PChk4.Checked = True Then txt仕入先Gp名4.Enabled = True
        If PChk4.Checked = False Then txt仕入先Gp名4.Enabled = False
    End Sub

    Private Sub PChk5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PChk5.CheckedChanged
        If PChk5.Checked = True Then txt仕入先Gp名5.Enabled = True
        If PChk5.Checked = False Then txt仕入先Gp名5.Enabled = False
    End Sub

    Private Sub CChk1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CChk1.CheckedChanged
        If CChk1.Checked = True Then txt商品Gp名1.Enabled = True
        If CChk1.Checked = False Then txt商品Gp名1.Enabled = False
    End Sub

    Private Sub CChk2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CChk2.CheckedChanged
        If CChk2.Checked = True Then txt商品Gp名2.Enabled = True
        If CChk2.Checked = False Then txt商品Gp名2.Enabled = False
    End Sub

    Private Sub CChk3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CChk3.CheckedChanged
        If CChk3.Checked = True Then txt商品Gp名3.Enabled = True
        If CChk3.Checked = False Then txt商品Gp名3.Enabled = False
    End Sub


End Class