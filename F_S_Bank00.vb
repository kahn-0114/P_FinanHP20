Imports System.Data.SqlClient
Imports GrapeCity.Win.MultiRow
Public Class F_S_Bank00
    Dim CnFi00 As New SqlConnection()
    Dim SQLCmdS0 As New SqlCommand()

    '    Dim pubMstSQLFi As New _MstSQLFi
    Dim pFocus(10) As Object

    Dim _pubGinCD As String = String.Empty
    Dim _pubSitCD As String = String.Empty

    Public Property pubGinCD() As String
        Get
            pubGinCD = _pubGinCD
        End Get
        Set(ByVal value As String)
            _pubGinCD = value
        End Set
    End Property

    Public Property pubSitCD() As String
        Get
            pubSitCD = _pubSitCD
        End Get
        Set(ByVal value As String)
            _pubSitCD = value
        End Set
    End Property

    '***************************************
    '* ﾘｽﾄにItemを追加する
    '***************************************
    Private Sub Item_Add00()
        Dim SQL As String
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        With GcMultiRow1
            .AllowUserToAddRows = False
            .Rows.Clear()
            .ResumeLayout()
            .SuspendLayout()

            SQL = "SELECT * " _
                & "FROM M_銀行00"
            If Not txt銀行CD.Text = "" Then
                SQL = SQL & " WHERE (銀行CD=" & txt銀行CD.Text & ")"
            End If
            SQL = SQL & " ORDER BY 銀行CD,支店CD"
            SQLCmdS0.CommandText = SQL
            da0.SelectCommand = SQLCmdS0
            da0.Fill(dt0, "t0")
            For i As Integer = 0 To dt0.Tables("t0").Rows.Count - 1
                .Rows.Add(1)
                .Rows(i).Cells("銀行CD").Value = dt0.Tables("t0").Rows(i)("銀行CD")
                .Rows(i).Cells("銀行Kana名").Value = dt0.Tables("t0").Rows(i)("銀行名カナ")
                '.Rows(i).Cells("銀行名").Value = Com.ChgNull(dt0.Tables("t0").Rows(i)("銀行名"), 1)
                .Rows(i).Cells("支店CD").Value = dt0.Tables("t0").Rows(i)("支店CD")
                .Rows(i).Cells("支店Kana名").Value = dt0.Tables("t0").Rows(i)("銀行支店名カナ")
                '.Rows(i).Cells("支店名").Value = Com.ChgNull(dt0.Tables("t0").Rows(i)("銀行支店名"), 1)
            Next
            .ResumeLayout()
            dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing

            If .Rows.Count > 0 Then
                ActiveControl = GcMultiRow1
                .CurrentCellPosition = New GrapeCity.Win.MultiRow.CellPosition(GrapeCity.Win.MultiRow.CellScope.Row, 0, "銀行CD")
            End If
        End With
    End Sub

    Private Sub F_S_Bank00_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SQLCmdS0.Dispose() : SQLCmdS0 = Nothing
            CnFi00.Close() : CnFi00.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_S_Bank00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 112
                btnOK00.PerformClick() : e.Handled = True
            Case 120
                Cmd09.PerformClick() : e.Handled = True
            Case 122
                Cmd11.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_S_Bank00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inp_Clr00()
        Dsp_Init00()
        txt銀行CD.Text = pubGinCD
        ActiveControl = txt銀行CD
        If Len(txt銀行CD.Text) > 0 Then
            Item_Add00()
        End If
    End Sub

    Private Sub GcMultiRow1_CellClick(ByVal sender As Object, ByVal e As GrapeCity.Win.MultiRow.CellEventArgs) Handles GcMultiRow1.CellClick
        With GcMultiRow1
            If e.Scope = CellScope.Row Then
                pubGinCD = .Rows(e.RowIndex).Cells("銀行CD").Value
                pubSitCD = .Rows(e.RowIndex).Cells("支店CD").Value
            End If
        End With
    End Sub

    Private Sub GcMultiRow1_CellDoubleClick(ByVal sender As Object, ByVal e As GrapeCity.Win.MultiRow.CellEventArgs) Handles GcMultiRow1.CellDoubleClick
        With GcMultiRow1
            If e.Scope = CellScope.Row Then
                pubGinCD = .Rows(e.RowIndex).Cells("銀行CD").Value
                pubSitCD = .Rows(e.RowIndex).Cells("支店CD").Value
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End With
    End Sub

    Private Sub GcMultiRow1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles GcMultiRow1.PreviewKeyDown
        Try
            With GcMultiRow1
                Select Case e.KeyCode
                    Case Keys.Enter
                        pubGinCD = .Rows(.CurrentCell.RowIndex).Cells("銀行CD").Value
                        pubSitCD = .Rows(.CurrentCell.RowIndex).Cells("支店CD").Value
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                End Select
            End With
        Catch ex As System.InvalidOperationException
        End Try
    End Sub

    Private Sub btnOK00_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK00.Click
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim pRet As Boolean = Inp_Chk00(CtrlItem)
                If pRet = False Then Exit Sub
            End If
        Next
        Item_Add00()
    End Sub

    Private Sub txtInp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub

        pTxtBox.SelectAll()
        pTxtBox.BackColor = Color.MistyRose
        Select Case pTxtBox.Name
            Case "txt銀行CD"
                AddHandler txt銀行CD.TextChanged, AddressOf txtModified_TextChanged
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
            Case "txt銀行CD"
                If txtModified.Text = "1" Then
                    btnOK00.PerformClick()
                End If
        End Select
        txtModified.Text = ""
        pTxtBox.BackColor = Color.White
    End Sub

    Private Sub txtInp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub

        Select Case pTxtBox.Name
            Case "txt銀行CD"
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select
        End Select

        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                Select Case pTxtBox.Name
                    Case "txt銀行CD"
                        If txtModified.Text = "1" Then
                            txtModified.Text = ""
                            btnOK00.PerformClick()
                            Exit Sub
                        End If
                End Select

                Dim wRet As Boolean = Inp_Chk00(sender)
                If wRet = False Then Exit Sub
                Me.SelectNextControl(sender, True, True, True, True)
                e.Handled = True
        End Select
    End Sub

    Private Sub txtModified_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtModified.Text = "1"
    End Sub

    '******************************************************
    '*
    '******************************************************
    Public Sub Dsp_Init00()

        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
    End Sub

    '******************************************************
    '* ﾌｨｰﾙﾄﾞｸﾘｱ関数
    '******************************************************
    Private Sub Inp_Clr00()
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        Next
        With GcMultiRow1
            .AllowUserToAddRows = False
            .Rows.Clear()
            .ColumnHeaders(0).Cells("Fi銀行CD").Value = ""
            .ColumnHeaders(0).Cells("Fi銀行Kana").Value = ""
            .ColumnHeaders(0).Cells("Fi銀行名").Value = ""
            .ColumnHeaders(0).Cells("Fi支店CD").Value = ""
            .ColumnHeaders(0).Cells("Fi支店Kana").Value = ""
            .ColumnHeaders(0).Cells("Fi支店名").Value = ""
        End With
        txtMsg.Text = "" : txtMsg.Visible = False
    End Sub

    '******************************************************
    '* ※Check/GroupBox00
    '******************************************************
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True : txtMsg.Visible = False : txtMsg.Text = ""
        Select Case ctxtInp.Name
            Case "txt銀行CD"
                ctxtInp.BackColor = Color.White
                txt銀行名.Text = ""
                If ctxtInp.Text = "" Then Exit Function

                'Dim wCode As String = ctxtInp.Text
                'Dim wRes As Byte = pubMstSQLFi.銀行10(wCode)
                'If wRes = 0 Then
                '    txt銀行名.Text = pubMstSQLFi.sBankNM10
                'Else
                '    txtMsg.Text = "銀行CD不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'End If
                'Exit Function
        End Select
    End Function
    Private Sub Cmd11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd11.Click
        Me.Close()
    End Sub

    Private Sub Cmd09_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd09.Click
        Dim strName As String = pFocus(0).Name
        Select Case strName
            Case "txt銀行CD"
                La銀行_Click(sender, e)
        End Select
        Me.ActiveControl = pFocus(0)
    End Sub

    Private Sub F_S_Bank00_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GcMultiRow1.Height = Size.Height - 100
    End Sub

    Private Sub La銀行_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles La銀行.Click
        Dim frmForm = New F_S_Bank10
        frmForm.pubGinCD = ""
        If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then txt銀行CD.Text = frmForm.pubGinCD
        Inp_Chk00(txt銀行CD)
        txt銀行CD.Focus()
    End Sub
End Class