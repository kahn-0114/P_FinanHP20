Imports System.Data.SqlClient
Imports GrapeCity.Win.MultiRow
Public Class F_S_Forgani00
    Dim SQLCmdA As New SqlCommand()
    Dim _pubBuCD As String = String.Empty

    '* 部門CD
    Public Property pubBuCD() As String
        Get
            pubBuCD = _pubBuCD
        End Get
        Set(ByVal value As String)
            _pubBuCD = value
        End Set
    End Property

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    '***************************************
    '* ﾘｽﾄにItemを追加する
    '***************************************
    Private Sub Add_Item00()
        Dim SQL As String
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet

        With GcMultiRow1
            .AllowUserToAddRows = False
            .Rows.Clear()
            .ColumnHeaders(0).Cells("Fi部門CD").Value = ""
            .ColumnHeaders(0).Cells("Fi部門名").Value = ""
            .ResumeLayout()
            .SuspendLayout()
            SQL = "SELECT * " _
                & "FROM M_財務部門00 " _
                & "WHERE (会社No =" & pubComPany & ") " _
                & "ORDER BY 部門CD"
            SQLCmdA.CommandText = SQL
            da0.SelectCommand = SQLCmdA
            da0.Fill(dt0, "t0")
            For i As Integer = 0 To dt0.Tables("t0").Rows.Count - 1
                .Rows.Add(1)
                .Rows(i).Cells("SEQ").Value = i + 1
                .Rows(i).Cells("部門CD").Value = dt0.Tables("t0").Rows(i)("部門CD")
                '.Rows(i).Cells("部門名").Value = Com.ChgNull(dt0.Tables("t0").Rows(i)("部門名"), 1)
            Next
            .ResumeLayout()
            dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
        End With
    End Sub

    '******************************************************
    '* ﾌｨﾙﾄﾞｸﾘｱ
    '******************************************************
    Private Sub Inp_Clr00()
        With GcMultiRow1
            .AllowUserToAddRows = False
            .Rows.Clear()
            .ColumnHeaders(0).Cells("Fi部門CD").Value = ""
            .ColumnHeaders(0).Cells("Fi部門名").Value = ""
        End With
    End Sub

    Private Sub F_S_Forgani00_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SQLCmdA.Dispose() : SQLCmdA = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_S_Forgani00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 122
                btnEnd.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_S_Forgani00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SQLCmdA = Cn00.CreateCommand()
        Inp_Clr00()
        Add_Item00()
        Try
            Me.ActiveControl = Me.GcMultiRow1
            If GcMultiRow1.RowCount > 0 Then
                GcMultiRow1.CurrentCellPosition = New GrapeCity.Win.MultiRow.CellPosition(GrapeCity.Win.MultiRow.CellScope.ColumnHeader, 0, "Fi部門CD")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GcMultiRow1_CellDoubleClick(ByVal sender As Object, ByVal e As GrapeCity.Win.MultiRow.CellEventArgs) Handles GcMultiRow1.CellDoubleClick
        With GcMultiRow1
            If Not e.Scope = GrapeCity.Win.MultiRow.CellScope.Row Then Exit Sub
            If .Rows.Count > 0 Then
                pubBuCD = .Rows(e.RowIndex).Cells("部門CD").Value
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
                        pubBuCD = .Rows(.CurrentCell.RowIndex).Cells("部門CD").Value
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                End Select
            End With
        Catch ex As System.InvalidOperationException
        End Try
    End Sub

    Private Sub F_S_Forgani00_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GcMultiRow1.Height = Me.Height - 90
    End Sub
End Class