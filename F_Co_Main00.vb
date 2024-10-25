Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Windows.Forms
Imports p_FinanHp10.C_Mconst

Public Class F_Co_Main00
    Dim pFocus(10) As Object
    Dim PubCom As New Com
    Dim PubProc As New Proc
    Private Mysqlserver As SQLServer = New SQLServer()

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        pubComPany = 2
        Data_Set00()
        Data_Set10()
        pubLogIn = 99

    End Sub

    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (
        ByVal hWnd As IntPtr, ByVal lpVerb As String, ByVal lpFile As String,
        ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer
        ) As Long
    Private Sub F_Co_Main00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'DaoEngine = New dao.DBEngine
        'DB = DaoEngine.OpenDatabase(pubDBpath)
        'ComDB = DaoEngine.OpenDatabase(pubComDBpath)
        'TmpDB = DaoEngine.OpenDatabase(pubTmpDB)

        txtComp.Text = PubCom.ChgNull(pubComPany, 1)
        Add_Cmb()
        Dsp_Init00()
        Dsp_Set00()

        ActiveControl = txtMenu

    End Sub
    Private Sub F_Co_Main00_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            PubProc.Dsp_End00()
            End
        Catch ex As Exception
        End Try
    End Sub
    '******************************************************
    '* ﾒﾆｭｰ設定
    '******************************************************
    Public Sub Dsp_Set00()

        Dim wRet As Boolean = Inp_Chk00(txtComp)
        If wRet = False Then Exit Sub

        '        PubProc.GetNen00()
        SetMenu(1)
        For i As Integer = 1 To 15
            GroupBox20.Controls("ButtonF" & i).BackColor = Color.LightGray
            GroupBox20.Controls("ButtonMenu" & i).BackColor = Color.LightGray
        Next
        GroupBox20.Controls("ButtonF1").BackColor = Color.LightBlue
        GroupBox20.Controls("ButtonMenu1").BackColor = Color.LightBlue

    End Sub

    '******************************************************
    '* Menu項目設定
    '******************************************************
    Public Sub Dsp_Init00()
        ' SQLクエリの構築
        Dim SQL As String = "SELECT MenuID,Menu名 FROM MM_Menu " &
                            "WHERE Class = 0 " &
                            "GROUP BY MenuID,Menu名 " &
                            "ORDER BY MenuID"
        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL)

        ' 取得したデータの処理
        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            Dim i0 As Integer = 0
            For Each Row As DataRow In result.Rows
                Dim wMenu As Integer = Integer.Parse(Row("MenuID"))
                Select Case wMenu
                    Case 1 To 15
                        GroupBox20.Controls("ButtonMenu" & wMenu).Text = Row("Menu名")
                End Select
            Next
        End If

        ' リソースの解放
        result.Dispose()

    End Sub
    '******************************************************
    '* コンボボックスにItemを追加する。
    '******************************************************
    Private Sub Add_Cmb()

        Dim SQL As String

        Dim ComboItemA As New ArrayList()
        SQL = "SELECT 会社No,会社名 " _
            & "From MM_会社 " _
            & "ORDER BY 会社No"
        Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            Dim pCD As String = IIf(IsDBNull(r0.Fields("会社No").Value), "", r0.Fields("会社No").Value)
            Dim pName As String = IIf(IsDBNull(r0.Fields("会社名").Value), "", r0.Fields("会社名").Value)
            ComboItemA.Add(New MyComboBoxItem(pName, pCD))
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing

        With CmbA
            .DisplayMember = "ItemName"
            .ValueMember = "ItemCode"
            .DataSource = ComboItemA
            .SelectedIndex = -1
        End With

        '' SQLクエリの構築
        'Dim SQL As String = "SELECT * FROM MM_会社"

        '' データベースからデータを取得
        'Dim result As DataTable = Mysqlserver.GetData(SQL)

        '' 取得したデータの処理
        'Dim ComboItemA As New ArrayList()
        'If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
        '    For Each row As DataRow In result.Rows
        '        Dim pCD As String = PubCom.ChgNull(row("会社No"), 0)
        '        Dim pName As String = PubCom.ChgNull(row("会社名"), 1)
        '        ComboItemA.Add(New MyComboBoxItemA(pName, pCD))
        '    Next
        'End If

        '' リソースの解放
        'result.Dispose()

        'With CmbA
        '    .DisplayMember = "ItemName"
        '    .ValueMember = "ItemCode"
        '    .DataSource = ComboItemA
        '    .SelectedIndex = -1
        'End With
    End Sub

    '******************************************************
    '* 入力ﾁｪｯｸ
    '******************************************************
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True
        txtMsg.Visible = False : txtMsg.Text = ""

        Select Case ctxtInp.Name
            Case "txtComp"
                ctxtInp.BackColor = Color.White
                If txtComp.Text = "" Then
                    CmbA.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Text = "会社CD未入力" : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

                CmbA.SelectedValue = txtComp.Text
                If CmbA.SelectedIndex = -1 Then
                    Inp_Chk00 = False : txtMsg.Text = "会社CD不正" : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                    CmbA.SelectedIndex = -1
                    Exit Function
                End If
            Case "txtMenu"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then Exit Function
                Dim wTmp00 As Integer = Integer.Parse(txtMenu.Text)
                Select Case wTmp00
                    Case Is <= 0, Is > 22
                        Inp_Chk00 = False : txtMsg.Text = "ﾒﾆｭｰNo不正" : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                        Exit Function
                End Select
        End Select
    End Function
    '****************************************************************
    '* メニューの切り替えを行う。 Menu - メニューのタイトル
    '****************************************************************
    Private Sub SetMenu(ByVal pMenu As Integer)
        For i As Byte = 1 To 22
            GroupBox21.Controls("Menu" & i).Text = ""
            GroupBox21.Controls("Menu" & i).Tag = ""
        Next

        Dim x As Byte = pubRight
        If Not IsNumeric(x) Then x = 0
        Dim MenuVaalue As String = pMenu
        ' SQLクエリの構築
        Dim SQL As String = "SELECT * FROM MM_Menu " &
                            "WHERE Class = 0 " &
                            "AND MenuID = @MenuID " &
                            "ORDER BY MenuNo"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@MenuID", MenuVaalue)
        }

        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        ' 取得したデータの処理
        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            Dim i0 As Integer = 0
            For Each Row As DataRow In result.Rows
                If PubCom.ChgNull(Row("稼動権限" & x), 0) = 0 Then
                    If i0 = 0 Then
                        Laﾒﾆｭｰ名.Text = PubCom.ChgNull(Row("Menu名"), 1)
                    End If
                    i0 += 1
                    Dim i1 As Byte = 1
                    If IsNumeric(Row("MenuNo")) Then
                        i1 = Row("MenuNo")
                    End If
                    GroupBox21.Controls("Menu" & i1).Text = PubCom.ChgNull(Row("名称1"), 1)
                    'Dim strArry As String() = {PubCom.ChgNull(Row("実行区分"), 0), PubCom.ChgNull(Row("Program"), 1)} 'タグに(0)=インデックス (1)=名前を配列でセット
                    Dim strArry As String() = {PubCom.ChgNull(Row("実行区分"), 0), PubCom.ChgNull(Row("Program"), 1), PubCom.ChgNull(Row("実行Path"), 1), PubCom.ChgNull(Row("pubParm0"), 1)} 'タグに(0)=インデックス (1)=名前を配列でセット
                    GroupBox21.Controls("Menu" & i1).Tag = strArry


                End If
            Next
        End If

        ' リソースの解放
        result.Dispose()
    End Sub
    '******************************************************
    '* 会社 更新
    '******************************************************
    Public Sub Data_Put00()

        Dim parameters As New List(Of SqlParameter)()
        '' パラメータの追加
        parameters.Add(New SqlParameter("@会社CD", txtComp.Text))
        parameters.Add(New SqlParameter("@LogInName", pubLogInName))

        Dim SQL As String = "会社CD = @会社CD "
        '' 更新条件を指定
        Dim condition As String = "LogInName = @LogInName "
        Mysqlserver.UpdateData("MM_LogIn", SQL, condition, parameters.ToArray())

    End Sub
    '******************************************************
    '* 会社 更新
    '******************************************************
    Public Sub Data_Put10()
        Dim r0 As dao.Recordset
        r0 = DB.OpenRecordset("MM_LogIn", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"
        r0.Seek("=", pubLogInName)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("LogInName").Value = pubLogInName
        Else
            r0.Edit()
            r0.Fields("会社No").Value = txtComp.Text
            r0.Update()
        End If
        r0.Close() : r0 = Nothing
    End Sub
    '******************************************************
    '* MM_LogIn 更新
    '******************************************************
    Public Sub Data_Set00()
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
            Dim setStatement As String = "会社No = @会社No " &
                                         ", 権限 = @権限 "
            ' 更新条件を指定
            Dim condition As String = "LogInName = @LogInName "
            Mysqlserver.UpdateData("MM_LogIn", setStatement, condition, parameters.ToArray())
        End If
        result.Dispose()
    End Sub
    '******************************************************
    '* MM_LogIn 更新
    '******************************************************
    Public Sub Data_Set10()
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

    Private Sub MenuItem00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyFolder As String

        MyFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        ShellExecute(vbNull, "Explore", MyFolder, vbNull, vbNull, 1)

    End Sub

    Private Sub ButtonMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMenu9.Click, ButtonMenu8.Click, ButtonMenu7.Click, ButtonMenu6.Click, ButtonMenu5.Click, ButtonMenu4.Click, ButtonMenu3.Click, ButtonMenu2.Click, ButtonMenu15.Click, ButtonMenu14.Click, ButtonMenu13.Click, ButtonMenu12.Click, ButtonMenu11.Click, ButtonMenu10.Click, ButtonMenu1.Click
        Dim i As SByte
        Dim cButton As Button = CType(sender, Button)

        For i = 1 To 15
            GroupBox20.Controls("ButtonF" & i).BackColor = Color.LightGray
            GroupBox20.Controls("ButtonMenu" & i).BackColor = Color.LightGray
        Next

        For i = 1 To 15
            If cButton.Name = GroupBox20.Controls("ButtonMenu" & i).Name Then Exit For
        Next
        If i < 16 Then
            Using SQLCmd As SqlCommand = Cn00.CreateCommand()
                SetMenu(i)
            End Using
            GroupBox20.Controls("ButtonF" & i).BackColor = Color.LightBlue
            GroupBox20.Controls("ButtonMenu" & i).BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu9.Click, Menu8.Click, Menu7.Click, Menu6.Click, Menu5.Click, Menu4.Click, Menu3.Click, Menu22.Click, Menu21.Click, Menu20.Click, Menu2.Click, Menu19.Click, Menu18.Click, Menu17.Click, Menu16.Click, Menu15.Click, Menu14.Click, Menu13.Click, Menu12.Click, Menu11.Click, Menu10.Click, Menu1.Click
        Dim cButton As Button = TryCast(sender, Button)
        Dim fromName As String, pExeName As String
        Try
            If cButton.Tag(1) = "" Then Exit Sub
            fromName = "p_FinanHp10." & cButton.Tag(1)
            pExeName = cButton.Tag(0)
            Select Case pExeName
                Case "5"
                    Dim MyPGM As String = cButton.Tag(2) & cButton.Tag(3)
                    Dim p As System.Diagnostics.Process =
                        System.Diagnostics.Process.Start(MyPGM)
                Case "6"
                    'Dim t As Type = asm.GetType(fromName)
                    'Dim frm As Object = t.InvokeMember(Nothing, System.Reflection.BindingFlags.CreateInstance, Nothing, Nothing, Nothing)
                    'Dim result As Object = t.InvokeMember("Show", System.Reflection.BindingFlags.InvokeMethod, Nothing, frm, New Object() {})
                Case Else
                    Dim fForm As Form = DirectCast(Type.GetType(fromName).GetConstructor(New Type() {}).Invoke(Nothing), Form)
                    Select Case pExeName
                        Case "2"
                            fForm.Show(Me)
                        Case Else
                            fForm.Show()
                    End Select
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmbA_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim item As MyComboBoxItem
        If CmbA.SelectedIndex = -1 Then
            txtComp.Text = ""
        Else
            item = DirectCast(CmbA.SelectedItem, MyComboBoxItem)
            txtComp.Text = item.ItemCode
            pubComPany = Long.Parse(txtComp.Text)
            Data_Put00()
            Data_Put10()
            'Com.GetNen00(SQLCmd)
            Dsp_Set00()
        End If

        'Dim item As MyComboBoxItemA
        'If CmbA.SelectedIndex = -1 Then txtComp.Text = ""

        'item = DirectCast(CmbA.SelectedItem, MyComboBoxItemA)
        'txtComp.Text = item.ItemCode
        'pubComPany = Integer.Parse(txtComp.Text)
        'Inp_Chk00(txtComp)
        'Data_Put00()
        'Com.GetNen00(SQLCmd)
    End Sub

    Private Sub CmbA_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbA.Enter
        AddHandler CmbA.SelectedIndexChanged, AddressOf CmbA_SelectedIndexChanged
    End Sub

    Private Sub CmbA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbA.Leave
        RemoveHandler CmbA.SelectedIndexChanged, AddressOf CmbA_SelectedIndexChanged
    End Sub

    Private Sub F_Co_Main00_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            PubProc.Dsp_End00()
            End
        Catch ex As Exception
        End Try
        End
    End Sub

    Private Sub ButtonEnd_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class
