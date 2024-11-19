Imports System.Windows.Forms

Public Class F_Co_Start00
    Dim PubProc As New Proc
    '******************************************************
    '* 一時ﾃﾞｰﾀ作成
    '******************************************************
    Private Sub Dsp_Init00()
        Dim hProcessHandle As Long
        Dim pPath, Tmp(1), Msg As String

        Try
            hProcessHandle = GetCurrentProcessId
            pPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            pubTmpDB = pPath & "\Tmp" & hProcessHandle & Format(Now(), "hhmmss") & ".accdb"
            Tmp(1) = pPath & "\Tmp" & hProcessHandle & Format(Now(), "hhmmss") & ".accdb"
            Tmp(0) = pPath & "\Tmp.accdb"
            FileCopy(Tmp(0), pubTmpDB)
            pubTmpDB = "Provider = " & pubDsnAccess & "; Data Source =" & Tmp(1)
            'CnTmp.ConnectionString = "Provider = Microsoft.ACE.OLEDB.16.0; Data Source = C:\pgm\仕様\サツドラ\リベート管理システム\書類\Tmp.accdb"
            pubLogInName = System.Environment.UserName
            'pubPcName = System.Environment.MachineName
        Catch ex As Exception
            Select Case Err.Number
                Case Else
                    Msg = "ｴﾗｰ番号 " & Str(Err.Number) _
                    & Chr(13) & Err.Description
                    MsgBox(Msg)
                    Exit Sub
            End Select
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim pubMsg As String = ""
        Dim wRet00 As Byte = pubProc.GetSetting(pubMsg)
        If wRet00 = 9 Then
            Me.Timer1.Enabled = False
            MsgBox(pubMsg)
            End
        End If

        Me.Timer1.Enabled = False

        Dsp_Init00()
        Me.Hide()

        pubComPany = 0
        Dim fForm As Form = F_Co_LogIn00
        fForm.Show()
    End Sub
    Private Sub F_Start00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
