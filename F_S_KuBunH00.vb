Imports System.Data.SqlClient
Imports Microsoft
Imports System.Windows.Forms
Imports System.ComponentModel
Imports Microsoft.Office.Interop.Access.Dao
Public Class F_S_KuBunH00
    Dim _pubCD As String = String.Empty
    Dim pubCom As New Com
    Dim pubProc As New Proc
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
    Private Sub Add_Item00()

        ' SQLクエリの構築
        Dim SQL As String = "SELECT 区分,区分名 FROM MM_区分H00 WHERE 会社No = @会社No ORDER BY 区分"

        ' パラメータのリストを作成
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@会社No", pubComPany)
            }

        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        ' 取得したデータの処理
        LV.Items.Clear()
        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            Dim i0 As Integer = 0
            For Each Row As DataRow In result.Rows
                LV.Items.Add(Integer.Parse(Row("区分")).ToString("000"), i0)
                LV.Items(i0).SubItems.Add(pubCom.ChgNull(Row("区分名"), 1))
                i0 += 1
            Next

        End If
        result.Dispose()
        If LV.Items.Count > 0 Then
            LV.Focus() : LV.Items(0).Selected = True
        End If

    End Sub

    Private Sub F_S_KuBun00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 122
                btnEnd.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_S_KuBun00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Add_Item00()
    End Sub

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.ItemActivate
        Dim lv As ListView = DirectCast(sender, ListView)
        pubCD = lv.FocusedItem.Text
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub LV_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
        End Select
    End Sub
End Class