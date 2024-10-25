Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.Odbc
Imports System.Windows.Forms
Imports System.Drawing

Public Class F_Co_Main10
    Dim pFocus(10) As Object

    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" ( _
        ByVal hWnd As IntPtr, ByVal lpVerb As String, ByVal lpFile As String, _
        ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer _
        ) As Long
    Private Sub F_Co_Main10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Add_Cmb()
        Dsp_Set00()
    End Sub
    Private Sub F_Co_Main10_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dsp_End00()
        End
    End Sub
    '******************************************************
    '*
    '******************************************************
    Public Sub Dsp_Set00()
        Dim r0 As dao.Recordset

        r0 = ComDB.OpenRecordset("MM_会社", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"
        txtInp0.Text = pubComPany
        r0.Seek("=", txtInp0.Text)
        If r0.NoMatch Then
            CmbA.Text = ""
        Else
            CmbA.Text = IIf(IsDBNull(r0.Fields("会社名").Value), "", r0.Fields("会社名").Value)
        End If
        r0.Close() : r0 = Nothing

        SetMenu(1)
        MyProc.GetNen10()
    End Sub
    '******************************************************
    '* コンボボックスにItemを追加する。
    '******************************************************
    Private Sub Add_Cmb()
        Dim SQL As String

        Dim ComboItemA As New ArrayList()

        CmbA.Items.Clear()
        CmbA.DropDownStyle = ComboBoxStyle.DropDownList
        CmbA.BeginUpdate()

        SQL = "SELECT 会社No, 会社名 " _
            & "From MM_会社 " _
            & "ORDER BY 会社No"
        Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Dim i As Integer = 0
        Do Until r0.EOF
            Dim pCD As String = IIf(IsDBNull(r0.Fields("会社No").Value), "", r0.Fields("会社No").Value)
            Dim pName As String = IIf(IsDBNull(r0.Fields("会社名").Value), "", r0.Fields("会社名").Value)
            ComboItemA.Add(New MyComboBoxItemA(pName, pCD))
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        CmbA.DisplayMember = "ItemName"
        CmbA.ValueMember = "ItemCode"
        CmbA.DataSource = ComboItemA
        CmbA.SelectedIndex = -1
        CmbA.EndUpdate()
    End Sub
    '****************************************************
    '* メニューの切り替えを行う。 Menu - メニューのタイトル
    '****************************************************
    Private Sub SetMenu(ByVal pMenu As UShort)
        Dim r0 As dao.Recordset
        Dim SQL As String, i As UShort, Tmp(1), X As UShort

        For i = 1 To 22
            Me.GroupBox5.Controls("Menu" & i).Text = ""
            Me.GroupBox5.Controls("Menu" & i).Tag = ""
        Next i

        X = pubRight
        If Not IsNumeric(X) Then
            X = 0
        End If
        SQL = "SELECT * " _
            & "From MM_Menu " _
            & "Where (Class = 0) " _
            & "And (MenuID = " & pMenu & ") " _
            & "ORDER BY MenuNo"
        r0 = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        i = 0
        Do Until r0.EOF
            If r0.Fields("稼動権限" & X).Value = 0 Then
                If i = 0 Then
                    Label1.Text = IIf(IsDBNull(r0.Fields("Menu名").Value), "", r0.Fields("Menu名").Value)
                End If
                i = IIf(IsDBNull(r0.Fields("MenuNo").Value), 1, r0.Fields("MenuNo").Value)
                Me.GroupBox5.Controls("Menu" & i).Text = IIf(IsDBNull(r0.Fields("名称1").Value), "", r0.Fields("名称1").Value)
                Me.GroupBox5.Controls("Menu" & i).Tag = IIf(IsDBNull(r0.Fields("Program").Value), "", r0.Fields("Program").Value)
            End If
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
    End Sub
    '******************************************************
    '*
    '******************************************************
    Public Sub Dsp_End00()
        Dim MyNameA, MyNameB, pPath As String

        On Error Resume Next

        DB.Close()
        TmpDB.Close()

        pPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        For Each stPrompt As String In System.IO.Directory.GetFiles(pPath, "tmp*.*")
            MyNameA = StrConv(stPrompt, vbLowerCase)
            MyNameB = StrConv(pPath & "\tmp.mdb", vbLowerCase)
            If Not MyNameA = MyNameB Then
                Kill(MyNameA)
            End If
        Next stPrompt

        pPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        For Each stPrompt As String In System.IO.Directory.GetFiles(pPath, "rep*.*")
            MyNameA = StrConv(stPrompt, vbLowerCase)
            MyNameB = StrConv(pPath & "\rep.mdb", vbLowerCase)
            If Not MyNameA = MyNameB Then
                Kill(MyNameA)
            End If
        Next stPrompt
    End Sub

    Private Sub ButtonEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExplorerToolStripMenuItem.Click
        Dim MyFolder As String

        MyFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        ShellExecute(vbNull, "Explore", MyFolder, vbNull, vbNull, 1)

    End Sub

    Private Sub Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu9.Click, Menu8.Click, Menu7.Click, Menu6.Click, Menu5.Click, Menu4.Click, Menu3.Click, Menu22.Click, Menu21.Click, Menu20.Click, Menu2.Click, Menu19.Click, Menu18.Click, Menu17.Click, Menu16.Click, Menu15.Click, Menu14.Click, Menu13.Click, Menu12.Click, Menu11.Click, Menu10.Click, Menu1.Click, Menu24.Click, Menu23.Click, Menu35.Click, Menu34.Click, Menu33.Click, Menu32.Click, Menu31.Click, Menu30.Click, Menu29.Click, Menu28.Click, Menu27.Click, Menu26.Click, Menu25.Click
        Dim cButton As Button = TryCast(sender, Button)
        Dim fromName As String

        If Not cButton.Tag = "" Then
            fromName = "p_FinanHp10." & cButton.Tag
            Dim fForm As Form = DirectCast(Type.GetType(fromName).GetConstructor(New Type() {}).Invoke(Nothing), Form)
            fForm.Show()
        End If
    End Sub

    Private Sub CmbA_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim item As MyComboBoxItemA
        If CmbA.SelectedIndex = -1 Then
            txtInp0.Text = 0
        Else
            item = DirectCast(CmbA.SelectedItem, MyComboBoxItemA)
            txtInp0.Text = item.ItemCode
        End If
        pubComPany = Integer.Parse(txtInp0.Text)

        Dim r0 As dao.Recordset = DB.OpenRecordset("MM_LogIn", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"
        r0.Seek("=", pubLogInName)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("LogInName").Value = pubLogInName
        Else
            r0.Edit()
        End If
        r0.Fields("会社No").Value = pubComPany
        r0.Update()
        r0.Close() : r0 = Nothing
    End Sub

    Private Sub CmbA_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbA.Enter
        AddHandler CmbA.SelectedIndexChanged, AddressOf CmbA_SelectedIndexChanged
    End Sub

    Private Sub CmbA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbA.Leave
        RemoveHandler CmbA.SelectedIndexChanged, AddressOf CmbA_SelectedIndexChanged
    End Sub
End Class
