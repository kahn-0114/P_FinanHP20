Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.ComponentModel
Public Class F_Ms_KubunH00
    Dim pFocus(10) As Object
    Dim pubCom As New Com
    Dim pubProc As New Proc
    Private Mysqlserver As SQLServer = New SQLServer()
    '******************************************************
    '* リストにItemを表示する共通関数
    '******************************************************
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

    End Sub

    '******************************************************
    '*
    '******************************************************
    Public Sub Dsp_Init00()
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
    End Sub
    '******************************************************
    '* フィールドクリア関数
    '******************************************************
    Private Sub Inp_Clr00()

        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        Next
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        Next
        LV.Items.Clear()
        txtMsg.Text = "" : txtMsg.Visible = False
    End Sub
    Private Sub txtInp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub

        pTxtBox.SelectAll() : pTxtBox.BackColor = Color.MistyRose
        txtModified.Text = ""
        Select Case pTxtBox.Name
            Case "txt区分CD"
                AddHandler txt区分CD.TextChanged, AddressOf txtModified_TextChanged
        End Select
        pFocus(0) = pTxtBox
    End Sub
    Private Sub txtInp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        Select Case e.KeyCode
            Case 38
                Me.SelectNextControl(sender, False, True, True, True)
                e.Handled = True
        End Select
    End Sub
    Private Sub txtInp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then
            Me.SelectNextControl(sender, True, True, True, True)
            Exit Sub
        End If

        Select Case pTxtBox.Name
            Case "txt区分CD"
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select
            Case "txt桁数"
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(52), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select
        End Select

        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                Dim pRet As Boolean = Inp_Chk00(sender)
                If pRet = False Then Exit Sub
                Me.SelectNextControl(sender, True, True, True, True)
                e.Handled = True
        End Select
    End Sub
    Private Sub txtInp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub

        Select Case pTxtBox.Name
            Case "txt区分CD"
                If txtModified.Text = "1" Then
                    btnOK00.PerformClick()
                End If
                RemoveHandler txt区分CD.TextChanged, AddressOf txtModified_TextChanged
        End Select
        txtModified.Text = ""
        pTxtBox.BackColor = Color.White
    End Sub

    Private Sub txtModified_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtModified.Text = "1"
    End Sub

    Private Sub Cmd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd11.Click
        Me.Close()
    End Sub



    Private Sub F_Ms_KubunH00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 116
                Cmd05.PerformClick() : e.Handled = True
            Case 122
                Cmd11.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_Ms_KubunH00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inp_Clr00()
        Dsp_Init00()
        Add_Item00()
        Me.ActiveControl = Me.txt区分CD
    End Sub

    '******************************************************
    '* GroupBox10設定
    '******************************************************
    Private Sub btnOK00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK00.Click
        Dim pRet As Boolean = Inp_Chk00(txt区分CD)
        If pRet = False Then Exit Sub
        Data_Get00()
        txt区分名.Focus()
    End Sub

    '******************************************************
    '* 入力項目ﾁｪｯｸ
    '******************************************************
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True
        txtMsg.Visible = False
        txtMsg.Text = ""

        Select Case ctxtInp.Name
            Case "txt区分CD"
                ctxtInp.BackColor = Color.White
                If txt区分CD.Text = "" Then
                    txtMsg.Text = "区分CD未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt区分名"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(ctxtInp.Text)
                If LenB > 40 Then
                    txtMsg.Text = "区分名超過:40"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt桁数"
                ctxtInp.BackColor = Color.White
                If Not IsNumeric(ctxtInp.Text) Then
                    ctxtInp.Text = 3
                End If
        End Select
    End Function

    '******************************************************
    '* MM_区分H00削除
    '******************************************************
    Public Sub Data_Del00()

        ' SQLクエリの構築
        Dim condition As String = "会社No = @会社No " &
                                     "AND 区分 = @区分"

        Dim parameters As New List(Of SqlParameter) From {
        New SqlParameter("@会社No", pubComPany),
        New SqlParameter("@区分", txt区分CD.Text)
    }

        Mysqlserver.DeleteData("MM_区分H00", condition, parameters.ToArray())
    End Sub



    '******************************************************
    '* MM_区分H00取得
    '******************************************************
    Public Sub Data_Get00()
        'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        Dim SQL As String
        SQL = "SELECT * " _
            & "FROM MM_区分H00 " _
            & "WHERE 会社No = @会社No " _
            & "AND 区分 = @区分"
        Dim parameters As New List(Of SqlParameter) From {
                   New SqlParameter("@会社No", pubComPany),
                   New SqlParameter("@区分", txt区分CD.Text)
                   }
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())
        If result.Rows.Count > 0 Then
            txt区分名.Text = pubCom.ChgNull(result.Rows(0)("区分名"), 1)
            RaType0.Checked = True
            If pubCom.ChgNull(result.Rows(0)("Type"), 0) = 2 Then
                RaType1.Checked = True
            End If
            txt桁数.Text = pubCom.ChgNull(result.Rows(0)("桁数"), 0)
            RaUp0.Checked = True
            If pubCom.ChgNull(result.Rows(0)("更新区分"), 0) = 9 Then
                RaUp1.Checked = True
            End If

        End If
        result.Dispose()
    End Sub
    '******************************************************
    '* MM_区分H00保存
    '******************************************************
    Public Sub Data_Put00()
        Dim SQL As String

        SQL = " SELECT * " &
              " FROM MM_区分H00 " &
              " WHERE 会社No = @会社No" &
              " And 区分= @区分"
        Dim wtype As String = 1
        If RaType1.Checked = True Then
            wtype = 2
        End If
        Dim wUp As String = 0
        If RaUp1.Checked = True Then
            wUp = 9
        End If
        ' パラメータのリストを作成
        Dim parameters As New List(Of SqlParameter) From {
                   New SqlParameter("@会社No", pubComPany),
                   New SqlParameter("@区分", txt区分CD.Text),
                   New SqlParameter("@Type", wtype),
                   New SqlParameter("@桁数", txt桁数.Text),
                   New SqlParameter("@更新区分", wUp),
                   New SqlParameter("@削除", 0)
       }
        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())
        'For i As Integer = 0 To result.Rows.Count - 1
        parameters.Clear()
        parameters.Add(New SqlParameter("@会社No", pubComPany))
        parameters.Add(New SqlParameter("@区分", txt区分CD.Text))
        parameters.Add(New SqlParameter("@区分名", txt区分名.Text))
        parameters.Add(New SqlParameter("@Type", wtype))
        parameters.Add(New SqlParameter("@桁数", txt桁数.Text))
        parameters.Add(New SqlParameter("@更新区分", wUp))
        parameters.Add(New SqlParameter("@削除", 0))

        If result.Rows.Count = 0 Then
            Dim columns As String = "会社No " &
                                    ", 区分 " &
                                    ", 区分名 " &
                                    ", Type " &
                                    ", 桁数 " &
                                    ", 更新区分 " &
                                    ", 削除 "
            ' 登録する値を指定
            Dim values As String = "@会社No " &
                                   ", @区分 " &
                                   ", @区分名 " &
                                   ", @Type " &
                                   ", @桁数 " &
                                   ", @更新区分 " &
                                   ", @削除 "
            Mysqlserver.InsertData("MM_区分H00", columns, values, parameters.ToArray())
        Else
            Dim setStatement As String = "区分名 = @区分名" &
                                         ", Type = @Type " &
                                         ", 桁数 = @桁数 " &
                                         ", 更新区分 = @更新区分 " &
                                         ", 削除 = @削除 "
            ' 更新条件を指定
            Dim condition As String = "会社No = @会社No " &
                                      "AND 区分 = @区分 "
            Mysqlserver.UpdateData("MM_区分H00", setStatement, condition, parameters.ToArray())
        End If
        result.Dispose()
    End Sub

    '******************************************************
    '* 保存処理
    '******************************************************
    Private Sub btnUp00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp00.Click
        Dim pRet As Boolean = Inp_Chk00(txt区分CD)
        If pRet = False Then Exit Sub
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                pRet = Inp_Chk00(CtrlItem)
                If pRet = False Then Exit Sub
            End If
        Next

        Data_Put00()
        Inp_Clr00()
        Add_Item00()
        txt区分CD.Focus()
    End Sub

    '******************************************************
    '* 削除処理
    '******************************************************
    Private Sub btnDel00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel00.Click
        Dim pRet As Boolean = Inp_Chk00(txt区分CD)
        If pRet = False Then Exit Sub

        Dim pMsg As String = "CD:" & txt区分CD.Text & Chr(13) _
            & "名称:" & txt区分名.Text & Chr(13) _
            & "このデータをマスタから削除します。"
        Dim pAns As Integer = MsgBox(pMsg, vbYesNo + vbQuestion, "データ削除")
        If pAns = vbNo Then Exit Sub

        Data_Del00()
        Inp_Clr00()
        Add_Item00()
        txt区分CD.Focus()
    End Sub

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.ItemActivate
        Dim lv As ListView = DirectCast(sender, ListView)

        txt区分CD.Text = lv.FocusedItem.Text
        btnOK00.PerformClick()
    End Sub

    Private Sub Cmd05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd05.Click
        Inp_Clr00()
        Add_Item00()
        txt区分CD.Focus()
    End Sub

    Private Sub Cmd12_Click(sender As Object, e As EventArgs) Handles Cmd12.Click

    End Sub

    Private Sub Cmd06_Click(sender As Object, e As EventArgs) Handles Cmd06.Click

    End Sub

    Private Sub Cmd07_Click(sender As Object, e As EventArgs) Handles Cmd07.Click

    End Sub

    Private Sub Cmd08_Click(sender As Object, e As EventArgs) Handles Cmd08.Click

    End Sub

    Private Sub Cmd09_Click(sender As Object, e As EventArgs) Handles Cmd09.Click

    End Sub

    Private Sub Cmd10_Click(sender As Object, e As EventArgs) Handles Cmd10.Click

    End Sub


End Class