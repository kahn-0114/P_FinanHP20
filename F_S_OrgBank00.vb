Imports System.Data.SqlClient
Public Class F_S_OrgBank00
    Dim pFocus(10) As Object
    Dim CnFi00 As New SqlConnection()
    Dim SQLCmdS0 As New SqlCommand()

    Dim _pubCD As String = String.Empty

    Public Property pubCD() As String
        Get
            pubCD = _pubCD
        End Get
        Set(ByVal value As String)
            _pubCD = value
        End Set
    End Property

    Private Sub Cmd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd11.Click
        Me.Close()
    End Sub

    '******************************************************
    '* フィールドクリア関数
    '******************************************************
    Private Sub Inp_Clr00()

        For Each CtrlItem As Control In Me.GroupBox1.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        Next
        LV.Items.Clear()
    End Sub

    '***************************************
    '* ﾘｽﾄにItemを追加する
    '***************************************
    Private Sub Add_Item00()
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        Dim SQL As String

        LV.Items.Clear()

        SQL = "SELECT I.*, B.銀行名, B.銀行支店名 " _
            & "FROM M_依頼銀行00 AS I LEFT OUTER JOIN M_銀行00 AS B " _
            & "ON I.支店CD = B.支店CD " _
            & "AND I.銀行CD = B.銀行CD"
        SQLCmdS0.CommandText = SQL
        da0.SelectCommand = SQLCmdS0
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            For i0 As Integer = 0 To .Rows.Count - 1
                'LV.Items.Add(Integer.Parse(.Rows(i0)("依頼銀行No")).ToString("00"), i0)
                'LV.Items(i0).SubItems.Add(Com.ChgNull(.Rows(i0)("銀行名"), 1))
                'LV.Items(i0).SubItems.Add(Com.ChgNull(.Rows(i0)("銀行支店名"), 1))
                'LV.Items(i0).SubItems.Add(Com.ChgNull(.Rows(i0)("口座番号"), 1))
                'LV.Items(i0).SubItems.Add(Com.ChgNull(.Rows(i0)("口座名"), 1))
            Next
        End With
        dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing

        If LV.Items.Count > 0 Then
            LV.Focus() : LV.Items(0).Selected = True
        End If
    End Sub

    Private Sub F_S_MotGin00_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SQLCmdS0.Dispose() : SQLCmdS0 = Nothing
            CnFi00.Close() : CnFi00.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_S_MotGin00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 122
                Cmd11.PerformClick()
        End Select
        e.Handled = True
    End Sub

    Private Sub F_S_MotGin00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inp_Clr00()
        Add_Item00()
        Me.ActiveControl = Me.LV
    End Sub

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.ItemActivate
        Dim lv As ListView = DirectCast(sender, ListView)

        pubCD = lv.FocusedItem.Text
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub LV_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
        End Select
    End Sub
End Class