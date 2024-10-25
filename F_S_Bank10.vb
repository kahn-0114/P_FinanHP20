Imports System.Data.SqlClient
Imports GrapeCity.Win.MultiRow
Public Class F_S_Bank10
    Dim CnFi00 As New SqlConnection()
    Dim SQLCmdS0 As New SqlCommand()

    'Dim pubMstSQLFi As New _MstSQLFi
    Dim pFocus(10) As Object

    Dim _pubGinCD As String = String.Empty

    Public Property pubGinCD() As String
        Get
            pubGinCD = _pubGinCD
        End Get
        Set(ByVal value As String)
            _pubGinCD = value
        End Set
    End Property

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

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
            SQL = "SELECT 銀行CD, 銀行名カナ,銀行名 " _
                & "FROM M_銀行00 " _
                & "GROUP BY 銀行CD,銀行名カナ,銀行名 " _
                & "ORDER BY 銀行CD"
            SQLCmdS0.CommandText = SQL
            da0.SelectCommand = SQLCmdS0
            da0.Fill(dt0, "t0")
            For i As Integer = 0 To dt0.Tables("t0").Rows.Count - 1
                .Rows.Add(1)
                .Rows(i).Cells("銀行CD").Value = dt0.Tables("t0").Rows(i)("銀行CD")
                .Rows(i).Cells("銀行Kana名").Value = dt0.Tables("t0").Rows(i)("銀行名カナ")
                '.Rows(i).Cells("銀行名").Value = Com.ChgNull(dt0.Tables("t0").Rows(i)("銀行名"), 1)
            Next
            .ResumeLayout()
        End With
        dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
    End Sub

    Private Sub F_S_Bank10_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SQLCmdS0.Dispose() : SQLCmdS0 = Nothing
            CnFi00.Close() : CnFi00.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_S_Bank10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 122
                btnEnd.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_S_Bank10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Item_Add00()

        Try
            If GcMultiRow1.Rows.Count > 0 Then
                Me.ActiveControl = Me.GcMultiRow1
                GcMultiRow1.CurrentCellPosition = New GrapeCity.Win.MultiRow.CellPosition(GrapeCity.Win.MultiRow.CellScope.Row, 0, "銀行CD")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim lv As ListView = DirectCast(sender, ListView)

        pubPARM(0) = lv.FocusedItem.Text
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LV_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                Me.Close()
        End Select
    End Sub

    Private Sub GcMultiRow1_CellClick(ByVal sender As Object, ByVal e As GrapeCity.Win.MultiRow.CellEventArgs) Handles GcMultiRow1.CellClick
        With GcMultiRow1
            If e.Scope = CellScope.Row Then
                pubGinCD = .Rows(e.RowIndex).Cells("銀行CD").Value
            End If
        End With
    End Sub

    Private Sub GcMultiRow1_CellDoubleClick(ByVal sender As Object, ByVal e As GrapeCity.Win.MultiRow.CellEventArgs) Handles GcMultiRow1.CellDoubleClick
        With GcMultiRow1
            If e.Scope = CellScope.Row Then
                pubGinCD = .Rows(e.RowIndex).Cells("銀行CD").Value
                DialogResult = Windows.Forms.DialogResult.OK
                Close()
            End If
        End With
    End Sub

    Private Sub GcMultiRow1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles GcMultiRow1.PreviewKeyDown
        Try
            With GcMultiRow1
                Select Case e.KeyCode
                    Case Keys.Enter
                        pubGinCD = .Rows(.CurrentCell.RowIndex).Cells("銀行CD").Value
                        DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                End Select
            End With
        Catch ex As System.InvalidOperationException
        End Try
    End Sub

    Private Sub F_S_Bank10_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GcMultiRow1.Height = Size.Height - 90
    End Sub
End Class