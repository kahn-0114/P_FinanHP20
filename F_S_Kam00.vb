Imports System.Data
Imports System.Data.SqlClient
Imports GrapeCity.Win.MultiRow
Public Class F_S_Kam00
    Dim pFocus(10) As Object
    Dim SQLCmdA As New SqlCommand()
    Dim _pubKaCD As String = String.Empty
    Dim _pubFrom As String = String.Empty
    Dim _pubTo As String = String.Empty

    '* 科目CD
    Public Property pubKaCD() As String
        Get
            pubKaCD = _pubKaCD
        End Get
        Set(ByVal value As String)
            _pubKaCD = value
        End Set
    End Property

    '* 科目範囲From
    Public Property pubFrom() As String
        Get
            pubFrom = _pubFrom
        End Get
        Set(ByVal value As String)
            _pubFrom = value
        End Set
    End Property

    '* 科目範囲To
    Public Property pubTo() As String
        Get
            pubTo = _pubTo
        End Get
        Set(ByVal value As String)
            _pubTo = value
        End Set
    End Property

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
    '******************************************************
    '* ﾌｨﾙﾄﾞｸﾘｱ
    '******************************************************
    Private Sub Inp_Clr00()
        With GcMultiRow1
            .AllowUserToAddRows = False
            .Rows.Clear()
            .ColumnHeaders(0).Cells("Fi科目CD").Value = ""
            .ColumnHeaders(0).Cells("Fi科目Kana").Value = ""
            .ColumnHeaders(0).Cells("Fi科目名").Value = ""
        End With
        txt科目CDF.Text = ""
        txt科目CDT.Text = ""
    End Sub
    '***************************************
    '* ﾘｽﾄにItemを追加する
    '***************************************
    Private Sub Add_Item00()
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        Dim SQL As String

        With GcMultiRow1
            .AllowUserToAddRows = False
            .Rows.Clear()
            .ResumeLayout()
            .SuspendLayout()
            .ColumnHeaders(0).Cells("Fi科目CD").Value = ""
            .ColumnHeaders(0).Cells("Fi科目Kana").Value = ""
            .ColumnHeaders(0).Cells("Fi科目名").Value = ""

            SQL = "SELECT * " _
                & "FROM M_財務科目00 " _
                & "WHERE (会社No =" & pubComPany & ") " _
                & "AND (年度 =0) " _
                & "AND (削除区分 =0)"
            If Len(txt科目CDF.Text) > 0 Then
                SQL = SQL & "And (科目CD>='" & txt科目CDF.Text & "')"
            End If
            If Len(txt科目CDT.Text) > 0 Then
                SQL = SQL & "And (科目CD<='" & txt科目CDT.Text & "')"
            End If
            SQL = SQL & "ORDER BY 科目CD"
            SQLCmdA.CommandText = SQL
            da0.SelectCommand = SQLCmdA
            da0.Fill(dt0, "t0")
            For i0 As Integer = 0 To dt0.Tables("t0").Rows.Count - 1
                .Rows.Add(1)
                .Rows(i0).Cells("SEQ").Value = i0 + 1
                .Rows(i0).Cells("科目CD").Value = dt0.Tables("t0").Rows(i0)("科目CD")
                .Rows(i0).Cells("科目Kana名").Value = dt0.Tables("t0").Rows(i0)("科目Kana名")
                .Rows(i0).Cells("科目名").Value = dt0.Tables("t0").Rows(i0)("科目略称名")
                .Rows(i0).Cells("内部CD").Value = dt0.Tables("t0").Rows(i0)("科目内部CD")
            Next
            .ResumeLayout()
        End With
        dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
    End Sub

    Private Sub F_S_Kam00_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SQLCmdA.Dispose() : SQLCmdA = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_S_Kam00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 122
                btnEnd.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_S_Kam00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SQLCmdA = Cn00.CreateCommand()

        Inp_Clr00()
        Add_Item00()
        If GcMultiRow1.Rows.Count > 0 Then
            Me.ActiveControl = Me.GcMultiRow1
            GcMultiRow1.CurrentCellPosition = New GrapeCity.Win.MultiRow.CellPosition(GrapeCity.Win.MultiRow.CellScope.ColumnHeader, 0, "Fi科目Kana")
        End If
    End Sub

    Private Sub GcMultiRow1_CellDoubleClick(ByVal sender As Object, ByVal e As GrapeCity.Win.MultiRow.CellEventArgs) Handles GcMultiRow1.CellDoubleClick
        If Not e.Scope = CellScope.Row Then Exit Sub

        With GcMultiRow1
            If .Rows.Count > 0 Then
                pubKaCD = .Rows(e.RowIndex).Cells("科目CD").Value
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
                        Dim Row As Integer = .CurrentCell.RowIndex
                        pubKaCD = .Rows(Row).Cells("科目CD").Value
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                End Select
            End With
        Catch ex As System.InvalidOperationException
        End Try
    End Sub

    Private Sub F_S_Kam00_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        GcMultiRow1.Height = Me.Height - 90
    End Sub
End Class