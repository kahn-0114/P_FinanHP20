Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft

Public Class F_Co_Start00
    Private PubProc As New Proc
    Private Mysqlserver As SQLServer = New SQLServer()
    'Private Mysqlserver As New SQLServer()

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Dim pubMsg As String = ""
        Dim wRet00 As Byte = PubProc.GetSetting(pubMsg)
        If wRet00 = 9 Then
            Me.Timer1.Enabled = False
            MsgBox(pubMsg)
            End
        End If
    End Sub
    '******************************************************
    '* 一時ﾃﾞｰﾀ作成
    '******************************************************
    Private Sub Dsp_Init00()
        Dim hProcessHandle As Long
        Dim pPath, Tmp(1), Msg As String

        Try
            hProcessHandle = GetCurrentProcessId
            pPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            pubTmpDB = pPath & "\Tmp" & hProcessHandle & Format(Now(), "hhmmss") & ".MDB"
            Tmp(0) = pPath & "\Tmp.MDB"
            FileCopy(Tmp(0), pubTmpDB)

            pubLogInName = System.Environment.UserName
            pubPcName = System.Environment.MachineName
        Catch ex As Exception
            Select Case Err.Number
                Case Else
                    Msg = "ｴﾗｰ番号 " & Str(Err.Number) _
                        & Chr(13) & Err.Description
                    MsgBox(Msg)
                    Exit Sub
            End Select
        End Try

        'Try
        '    hProcessHandle = GetCurrentProcessId
        '    pPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        '    pubTmpDB = pPath & "\Tmp" & hProcessHandle & Format(Now(), "hhmmss") & ".tmp"
        '    Tmp(1) = pPath & "\Tmp" & hProcessHandle & Format(Now(), "hhmmss") & ".tmp"
        '    Tmp(0) = pPath & "\Tmp.tmp"
        '    FileCopy(Tmp(0), pubTmpDB)
        '    pubTmpDB = "Provider = " & pubDsnAccess & "; Data Source =" & Tmp(1)
        '    'CnTmp.ConnectionString = "Provider = Microsoft.ACE.OLEDB.16.0; Data Source = C:\pgm\仕様\サツドラ\リベート管理システム\書類\Tmp.accdb"
        '    pubLogInName = System.Environment.UserName
        '    'pubPcName = System.Environment.MachineName
        'Catch ex As Exception
        '    Select Case Err.Number
        '        Case Else
        '            Msg = "ｴﾗｰ番号 " & Str(Err.Number) _
        '            & Chr(13) & Err.Description
        '            MsgBox(Msg)
        '            Exit Sub
        '    End Select
        'End Try
    End Sub
    '******************************************************
    '* MM_LogIn 更新
    '******************************************************
    Public Sub Data_Put00()
        Dim SQL As String

        SQL = " SELECT * " &
              " FROM MM_LogIn " &
              " WHERE LogInName = @LogInName"
        Dim wtype As String = 1
        ' パラメータのリストを作成
        Dim parameters As New List(Of SqlParameter) From {
                   New SqlParameter("@LogInName", pubLogInName)
       }
        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        parameters.Clear()
        parameters.Add(New SqlParameter("@LogInName", pubLogInName))
        parameters.Add(New SqlParameter("@会社No", pubComPany))
        parameters.Add(New SqlParameter("@権限", 1))
        If result.Rows.Count = 0 Then
            Dim columns As String = "LogInName, 会社No, 権限 "
            ' 登録する値を指定
            Dim values As String = "@LogInName, @会社No, @権限 "
            Mysqlserver.InsertData("MM_LogIn", columns, values, parameters.ToArray())
        Else
            Dim setStatement As String = "会社No = @会社No" &
                                         ", 権限 = @権限 "
            ' 更新条件を指定
            Dim condition As String = "会社No = @会社No " &
                                      "AND 区分 = @区分 "
            Mysqlserver.UpdateData("MM_LogIn", setStatement, condition, parameters.ToArray())
        End If
        result.Dispose()
    End Sub
    '******************************************************
    '* MM_LogIn 更新
    '******************************************************
    Public Sub Data_Put10()
        Dim r0 As dao.Recordset = DB.OpenRecordset("MM_LogIn", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"

        pubRight = 1
        r0.Seek("=", pubLogInName)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("LogInName").Value = pubLogInName
            r0.Fields("会社No").Value = pubComPany
            r0.Update()
        Else
            pubComPany = r0.Fields("会社No").Value
            pubRight = r0.Fields("権限").Value
        End If
        r0.Close() : r0 = Nothing
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Dim pubMsg As String = ""
        'Dim wRet00 As Byte = pubProc.GetSetting(pubMsg)
        'If wRet00 = 9 Then
        '    Me.Timer1.Enabled = False
        '    MsgBox(pubMsg)
        '    End
        'End If

        Me.Timer1.Enabled = False

        Dsp_Init00()

        DaoEngine = New dao.DBEngine
        DB = DaoEngine.OpenDatabase(pubDBpath)
        ComDB = DaoEngine.OpenDatabase(pubComDBpath)
        TmpDB = DaoEngine.OpenDatabase(pubTmpDB)

        Me.Hide()

        pubComPany = 0
        Dim fForm As Form = F_Co_Main00
        'Dim fForm As Form = F_Co_Main10
        fForm.Show()
    End Sub
    Private Sub F_Start00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
