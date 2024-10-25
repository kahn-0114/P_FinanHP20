Imports System.IO
Imports System.Text

Public Class Logger

    Private Shared Sub CheckDirectory()
        Dim exePath As String = AppDomain.CurrentDomain.BaseDirectory
        Dim logDir As String = Path.Combine(exePath, "Log")
        Dim dateDir As String = Path.Combine(logDir, DateTime.Now.ToString("yyyyMMdd"))

        ' Logフォルダがなければ作成
        If Not Directory.Exists(logDir) Then
            Directory.CreateDirectory(logDir)
        End If

        ' 日付フォルダがなければ作成
        If Not Directory.Exists(dateDir) Then
            Directory.CreateDirectory(dateDir)
        End If
    End Sub

    Public Shared Sub log(message As String)
        CheckDirectory() ' ディレクトリの確認と作成

        Dim exePath As String = AppDomain.CurrentDomain.BaseDirectory
        Dim filePath As String = Path.Combine(exePath, "Log", DateTime.Now.ToString("yyyyMMdd"), "log.txt")

        'スタックトレースを取得
        Dim stackTrace As String = String.Empty
        Try
            Dim st As New StackTrace(1, True)
            stackTrace = st.ToString
        Catch ex As Exception
        End Try

        ' ログファイルにメッセージを追記
        Using sw As StreamWriter = New StreamWriter(filePath, True, Encoding.UTF8)
            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " " & message)
            If String.IsNullOrWhiteSpace(stackTrace) = False Then sw.WriteLine(stackTrace)
        End Using
    End Sub

    Public Shared Sub log(ex As Exception)
        CheckDirectory() ' ディレクトリの確認と作成

        Dim exePath As String = AppDomain.CurrentDomain.BaseDirectory
        Dim filePath As String = Path.Combine(exePath, "Log", DateTime.Now.ToString("yyyyMMdd"), "log.txt")

        'スタックトレースを取得
        Dim stackTrace As String = String.Empty
        Try
            Dim st As New StackTrace(1, True)
            stackTrace = st.ToString
        Catch ex2 As Exception
        End Try

        ' ログファイルにメッセージを追記
        Using sw As StreamWriter = New StreamWriter(filePath, True, Encoding.UTF8)
            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " " & ex.Message)
            If String.IsNullOrWhiteSpace(StackTrace) = False Then sw.WriteLine(StackTrace)
        End Using
    End Sub


End Class