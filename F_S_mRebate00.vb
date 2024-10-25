Imports System.Data.SqlClient
Public Class F_S_mRebate00
    Dim pubCom As New Com
    Dim _pubCD As String = String.Empty
    Private Mysqlserver As SQLServer = New SQLServer()
    Public Property pubCD() As String
        Get
            pubCD = _pubCD
        End Get
        Set(ByVal value As String)
            _pubCD = value
        End Set
    End Property

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    '***************************************
    '* ﾘｽﾄにItemを追加する
    '***************************************
    Private Sub Add_Item()
        Dim SQL As String

        LV.Items.Clear()
        SQL = "SELECT * " _
            & "FROM MM_ReBate00 " _
            & "WHERE 会社No = @会社No " _
            & "ORDER BY 内容CD"

        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@会社No", pubComPany)
        }

        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())
        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            Dim i0 As Integer = 0
            For Each Row As DataRow In result.Rows
                LV.Items.Add(Integer.Parse(result.Rows(i0)("内容CD")).ToString("000"), i0)
                LV.Items(i0).SubItems.Add(pubCom.ChgNull(Row("内容名"), 1))
                i0 += 1
            Next
        End If
        result.Dispose()

        If LV.Items.Count > 0 Then
            LV.Focus() : LV.Items(0).Selected = True
        End If
    End Sub


    Private Sub F_S_mRebate00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 122
                btnEnd.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_S_mRebate00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Add_Item()
    End Sub

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.ItemActivate
        Dim lv As ListView = DirectCast(sender, ListView)
        pubCD = lv.FocusedItem.Text
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub LV_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                DialogResult = Windows.Forms.DialogResult.OK
                Close()
        End Select
    End Sub
End Class