Public Class F_ActiveViewer00
    Private Sub F_ActiveViewer00_Load(sender As Object, e As EventArgs) Handles Me.Load
        Viewer1.LoadDocument(Application.StartupPath + "\Report1.rdlx")
    End Sub
End Class