Imports System.Data.SqlClient
Public Class F_pt_Gen020
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

    Private Sub F_Ms_Comp30_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SQLCmdA.Dispose() : SQLCmdA = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_Ms_Comp30_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 120
                Cmd09.PerformClick() : e.Handled = True
            Case 122
                Cmd11.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_Ms_Comp30_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SQLCmdA = Cn00.CreateCommand()
        Inp_Clr00()
        Dsp_Init00()
        txt年度.Text = pubCD
        btnOK00.PerformClick()
        ActiveControl = txt振込休日
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
        txtｴﾗｰﾒｯｾｰｼﾞ.Text = "" : txtｴﾗｰﾒｯｾｰｼﾞ.Visible = False
        Me.GroupBox00.Enabled = True
    End Sub
    '******************************************************
    '* ※MM_会社00取得:
    '******************************************************
    Public Sub Data_Get00()
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        Dim SQL As String

        SQL = "SELECT * " _
            & "From MM_会社00 " _
            & "WHERE (会社No =" & pubComPany & ")"
        SQLCmdA.CommandText = SQL
        da0.SelectCommand = SQLCmdA
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            If .Rows.Count > 0 Then
                txt振込休日.Text = PubCom.ChgNull(.Rows(0)("振込休日"), 1)
                txt手形休日.Text = PubCom.ChgNull(.Rows(0)("手形休日"), 1)
                txt在庫評価区分.Text = PubCom.ChgNull(.Rows(0)("在庫評価法"), 1)
                txt在庫端数計算.Text = PubCom.ChgNull(.Rows(0)("在庫端数処理"), 1)
                For Each CtrlItem As Control In Me.GroupBox10.Controls
                    If TypeOf CtrlItem Is TextBox Then
                        Dim pRet As Boolean = Inp_Chk00(CtrlItem)
                        If pRet = False Then Exit Sub
                    End If
                Next
            End If
        End With
        dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
    End Sub
    '******************************************************
    '* ※MM_会社00更新:
    '******************************************************
    Public Sub Data_Put00()
        Dim SQL As String
        SQL = "UPDATE MM_会社00 SET "
        SQL = SQL & "在庫評価法= @在庫評価法"
        SQL = SQL & ",在庫端数処理= @在庫端数処理"
        SQL = SQL & ",振込休日= @振込休日"
        SQL = SQL & ",手形休日= @手形休日 "

        SQL = SQL & "WHERE (会社No=" & pubComPany & ")"
        Dim command As SqlCommand = New SqlCommand(SQL, Cn00)
        command.Parameters.Clear()

        command.Parameters.Add("@在庫評価法", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt在庫評価区分.Text), txt在庫評価区分.Text, DBNull.Value)
        command.Parameters.Add("@在庫端数処理", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt在庫端数計算.Text), txt在庫端数計算.Text, DBNull.Value)
        command.Parameters.Add("@振込休日", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt振込休日.Text), txt振込休日.Text, DBNull.Value)
        command.Parameters.Add("@手形休日", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt手形休日.Text), txt手形休日.Text, DBNull.Value)

        command.ExecuteNonQuery()
        command.Dispose()
    End Sub

    '******************************************************
    '* ※Check:GroupBox00/10:
    '******************************************************
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True : txtｴﾗｰﾒｯｾｰｼﾞ.Visible = False : txtｴﾗｰﾒｯｾｰｼﾞ.Text = ""
        Select Case ctxtInp.Name
            Case "txt会社No"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then
                    txtｴﾗｰﾒｯｾｰｼﾞ.Text = "会社CD未入力"
                    Inp_Chk00 = False : txtｴﾗｰﾒｯｾｰｼﾞ.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

                'CmbComp.SelectedValue = txt会社No.Text
                'If CmbComp.SelectedIndex = -1 Then
                '    txtMsg.Text = "会社CD不正"
                '    CmbComp.SelectedIndex = -1
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                'End If
            Case "txt振込休日"
                'ctxtInp.BackColor = Color.White
                'txt振込休日名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wKu As String = "810"
                'Dim wCode As String = ctxtInp.Text
                'Dim wRes As Byte = Mst.区分M00(wKu, wCode, SQLCmdA, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "振込休日不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt振込休日名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("名称"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt手形休日"
                'ctxtInp.BackColor = Color.White
                'txt手形休日名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wKu As String = "810"
                'Dim wCode As String = ctxtInp.Text
                'Dim wRes As Byte = Mst.区分M00(wKu, wCode, SQLCmdA, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "手形休日不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt手形休日名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("名称"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt在庫評価区分"
                'ctxtInp.BackColor = Color.White
                'txt在庫評価区分名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wKu As String = "300"
                'Dim wCode As String = ctxtInp.Text
                'Dim wRes As Byte = Mst.区分M00(wKu, wCode, SQLCmdA, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "在庫評価区分不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt在庫評価区分名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("名称"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt在庫端数計算"
                'ctxtInp.BackColor = Color.White
                'txt在庫端数計算名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wKu As String = "3"
                'Dim wCode As String = ctxtInp.Text
                'Dim wRes As Byte = Mst.区分M00(wKu, wCode, SQLCmdA, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "在庫端数計算不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt在庫端数計算名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("名称"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
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

        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then
            Me.SelectNextControl(sender, True, True, True, True)
            Exit Sub
        End If

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
                Dim pRet As Boolean = Inp_Chk00(sender)
                If pRet = False Then Exit Sub
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

    Private Sub btnOK00_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim pRet As Boolean = Inp_Chk00(CtrlItem)
                If pRet = False Then Exit Sub
            End If
        Next
        Data_Get00()
        txt振込休日.Focus()
        GroupBox00.Enabled = False
    End Sub

    Private Sub Cmd09_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd09.Click
        Dim strName As String = pFocus(0).Name
        Select Case strName
            Case "txt振込休日"
                Dim frmForm = New F_S_KuBunM00
                frmForm.pubKuCD = 810
                frmForm.pubCD = ""
                If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pFocus(0).Text = frmForm.pubCD
                    Inp_Chk00(pFocus(0))
                End If
                frmForm.Dispose()
            Case "txt手形休日"
                Dim frmForm = New F_S_KuBunM00
                frmForm.pubKuCD = 810
                frmForm.pubCD = ""
                If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pFocus(0).Text = frmForm.pubCD
                    Inp_Chk00(pFocus(0))
                End If
                frmForm.Dispose()
            Case "txt在庫評価区分"
                Dim frmForm = New F_S_KuBunM00
                frmForm.pubKuCD = 300
                frmForm.pubCD = ""
                If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pFocus(0).Text = frmForm.pubCD
                    Inp_Chk00(pFocus(0))
                End If
                frmForm.Dispose()
            Case "txt在庫端数計算"
                Dim frmForm = New F_S_KuBunM00
                frmForm.pubKuCD = 3
                frmForm.pubCD = ""
                If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    pFocus(0).Text = frmForm.pubCD
                    Inp_Chk00(pFocus(0))
                End If
                frmForm.Dispose()
        End Select
    End Sub

    Private Sub txtMsg_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt決算開始.TextChanged

    End Sub

    Private Sub GroupBox00_Enter(sender As Object, e As EventArgs) Handles GroupBox00.Enter

    End Sub

    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter

    End Sub
End Class
