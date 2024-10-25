Imports System.Data.SqlClient
Imports Microsoft
Public Class F_S_KuBunM00
    Dim pubCom As New Com
    Dim _pubKuCD As String = String.Empty
    Dim _pubCD As String = String.Empty
    Dim _pubNM As String = String.Empty
    Private Mysqlserver As SQLServer = New SQLServer()
    Public Property pubKuCD() As String
        Get
            pubKuCD = _pubKuCD
        End Get
        Set(ByVal value As String)
            _pubKuCD = value
        End Set
    End Property
    Public Property pubCD() As String
        Get
            pubCD = _pubCD
        End Get
        Set(ByVal value As String)
            _pubCD = value
        End Set
    End Property
    Public Property pubNM() As String
        Get
            pubNM = _pubNM
        End Get
        Set(ByVal value As String)
            _pubNM = value
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

        SQL = "SELECT * " _
            & "FROM MM_区分H00 " _
            & "WHERE 会社No = @会社No " _
            & "And 区分 = @区分 "

        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@会社No", pubComPany),
            New SqlParameter("@区分", pubKuCD)
}

        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        Dim wDegi As Byte = 0
        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            wDegi = pubCom.ChgNull(result.Rows(0)("桁数"), 0)
        End If
        result.Dispose()


        LV.Items.Clear()
        SQL = "SELECT * " _
            & "FROM MM_区分M00 " _
            & "WHERE 会社No = @会社No " _
            & "And 区分 = @区分 " _
            & "ORDER BY CD"

        parameters.Clear()
        parameters.Add(New SqlParameter("@会社No", pubComPany))
        parameters.Add(New SqlParameter("@区分", pubKuCD))


        result = Mysqlserver.GetData(SQL, parameters.ToArray())


        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            Dim i0 As Integer = 0
            For Each Row As DataRow In result.Rows
                Select Case wDegi
                    Case 1
                        LV.Items.Add(Integer.Parse(result.Rows(i0)("CD")).ToString("0"), i0)
                    Case 2
                        LV.Items.Add(Integer.Parse(result.Rows(i0)("CD")).ToString("00"), i0)
                    Case 3
                        LV.Items.Add(Integer.Parse(result.Rows(i0)("CD")).ToString("000"), i0)
                    Case Else
                        LV.Items.Add(Integer.Parse(result.Rows(i0)("CD")).ToString("0000"), i0)
                End Select
                LV.Items(i0).SubItems.Add(pubCom.ChgNull(Row("名称"), 1))
                i0 += 1
            Next

        End If

        If LV.Items.Count > 0 Then
            LV.Focus() : LV.Items(0).Selected = True
        End If

        result.Dispose()

    End Sub


    Private Sub F_S_KuBunM00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 122
                btnEnd.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_S_KuBunM00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt区分.Text = pubKuCD
        Add_Item()
    End Sub

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.ItemActivate
        Dim lv As ListView = DirectCast(sender, ListView)
        pubCD = lv.FocusedItem.Text
        pubNM = lv.FocusedItem.SubItems(1).Text
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