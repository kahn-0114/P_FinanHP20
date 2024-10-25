Imports System.Data.SqlClient
Imports System.ComponentModel
Imports Microsoft
Imports System.Security.Policy
Public Class F_Ms_SiPatH00
    Dim pFocus(10) As Object
    Dim SQLCmd As New SqlCommand()
    Dim pubCom As New Com
    Dim pubProc As New Proc
    Private Mysqlserver As SQLServer = New SQLServer()

    '******************************************************
    '* リストにItemを表示する共通関数
    '******************************************************
    Private Sub Add_Item00()
        Dim SQL As String



        SQL = "SELECT * " _
            & "From M_SiPatH00 " _
            & "Where 会社No = @会社No " _
            & "ORDER BY PatCD"

        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@会社No", pubComPany)
            }

        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())
        LV.Items.Clear()
        For i As Integer = 0 To result.Rows.Count - 1
            LV.Items.Add(Integer.Parse(result.Rows(i)("PatCD")).ToString("000"), i)
            LV.Items(i).SubItems.Add(pubCom.ChgNull(result.Rows(i)("Pat名"), 1))
        Next

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
        For Each CtrlItem As Control In Me.GroupBox00.Controls
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
            Case "txtPatCD"
                AddHandler txtPatCD.TextChanged, AddressOf txtModified_TextChanged
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
            Case "txtPatCD"
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
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
            Case "txtPatCD"
                If txtModified.Text = "1" Then
                    btnOK00.PerformClick()
                End If
                RemoveHandler txtPatCD.TextChanged, AddressOf txtModified_TextChanged
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



    Private Sub F_Ms_KubunH00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case 116
                Cmd05.PerformClick() : e.Handled = True
            Case 122
                Cmd11.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_Ms_KubunH00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLCmd = Cn00.CreateCommand()
        Inp_Clr00()
        Dsp_Init00()
        Add_Item00()
        Me.ActiveControl = Me.txtPatCD
    End Sub

    '******************************************************
    '* GroupBox10設定
    '******************************************************
    Private Sub btnOK00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK00.Click
        Dim pRet As Boolean = Inp_Chk00(txtPatCD)
        If pRet = False Then Exit Sub
        Data_Get00()
        txtPat名.Focus()
    End Sub

    '******************************************************
    '* 入力項目ﾁｪｯｸ
    '******************************************************
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True
        txtMsg.Visible = False
        txtMsg.Text = ""

        Select Case ctxtInp.Name
            Case "txtPatCD"
                ctxtInp.BackColor = Color.White
                If txtPatCD.Text = "" Then
                    txtMsg.Text = "PatCD未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txtPat名"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(ctxtInp.Text)
                If LenB > 60 Then
                    txtMsg.Text = "Pat名超過:60"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

        End Select
    End Function

    '******************************************************
    '* MM_区分H00削除
    '******************************************************
    Public Sub Data_Del00()

        ' SQLクエリの構築
        Dim condition As String = "会社No = @会社No " &
                                     "AND PatCD = @PatCD"
        Dim parameters As New List(Of SqlParameter) From {
        New SqlParameter("@会社No", pubComPany),
        New SqlParameter("@PatCD", txtPatCD.Text)
    }
        Mysqlserver.DeleteData("M_SiPatH00", condition, parameters.ToArray())

    End Sub
    '******************************************************
    '* MM_区分H00取得
    '******************************************************
    Public Sub Data_Get00()

        Dim SQL As String
        SQL = "SELECT * " _
            & "FROM M_SiPatH00 " _
            & "WHERE 会社No= @会社No " _
            & "AND PatCD= @PatCD "

        Dim parameters As New List(Of SqlParameter) From {
                   New SqlParameter("@会社No", pubComPany),
                   New SqlParameter("@PatCD", txtPatCD.Text)
                   }
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        If result.Rows.Count > 0 Then
            txtPat名.Text = pubCom.ChgNull(result.Rows(0)("Pat名"), 1)
            RaLoan2.Checked = True
            If pubCom.ChgNull(result.Rows(0)("貸借使用区分"), 2) = 0 Then
                RaLoan0.Checked = True
            End If
            If pubCom.ChgNull(result.Rows(0)("貸借使用区分"), 2) = 1 Then
                RaLoan1.Checked = True
            End If
            For Each CtrlItem As Control In Me.GroupBox10.Controls
                If TypeOf CtrlItem Is TextBox Then
                    Inp_Chk00(CtrlItem)
                End If
            Next
        End If
        result.Dispose()

    End Sub
    '******************************************************
    '* MM_区分H00保存
    '******************************************************
    Public Sub Data_Put00()
        Dim SQL As String

        SQL = " SELECT * " &
              " FROM M_SiPatH00 " &
              " WHERE 会社No = @会社No" &
              " And PatCD= @PatCD
"
        Dim tisyak As String = 2
        If RaLoan0.Checked = True Then
            tisyak = 0
        End If
        If RaLoan1.Checked = True Then
            tisyak = 1
        End If


        ' パラメータのリストを作成
        Dim parameters As New List(Of SqlParameter) From {
                   New SqlParameter("@会社No", pubComPany),
                   New SqlParameter("@PatCD", txtPatCD.Text),
                   New SqlParameter("@Pat名", txtPat名.Text),
                   New SqlParameter("@貸借使用区分", tisyak),
                   New SqlParameter("@削除", 0)
       }
        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        parameters.Clear()
        parameters.Add(New SqlParameter("@会社No", pubComPany))
        parameters.Add(New SqlParameter("@PatCD", txtPatCD.Text))
        parameters.Add(New SqlParameter("@Pat名", txtPat名.Text))
        parameters.Add(New SqlParameter("@貸借使用区分", tisyak))
        parameters.Add(New SqlParameter("@削除", 0))

        If result.Rows.Count = 0 Then
            Dim columns As String = "会社No " &
                                    ", PatCD " &
                                    ", Pat名" &
                                    ", 貸借使用区分 " &
                                    ", 削除 "
            ' 登録する値を指定
            Dim values As String = "@会社No " &
                                   ", @PatCD " &
                                   ", @Pat名" &
                                   ", @貸借使用区分 " &
                                   ", @削除 "

            Mysqlserver.InsertData("M_SiPatH00", columns, values, parameters.ToArray())
        Else
            Dim setStatement As String = "Pat名 = @Pat名" &
                                         ", 貸借使用区分 = @貸借使用区分 " &
                                         ", 削除 = @削除 "
            ' 更新条件を指定
            Dim condition As String = "会社No = @会社No " &
                                      "AND PatCD = @PatCD "

            Mysqlserver.UpdateData("M_SiPatH00", setStatement, condition, parameters.ToArray())

        End If
        result.Dispose()
    End Sub

    '******************************************************
    '* 保存処理
    '******************************************************
    Private Sub btnUp00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp00.Click
        Dim pRet As Boolean = Inp_Chk00(txtPatCD)
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
        txtPatCD.Focus()
    End Sub

    '******************************************************
    '* 削除処理
    '******************************************************
    Private Sub btnDel00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel00.Click
        Dim pRet As Boolean = Inp_Chk00(txtPatCD)
        If pRet = False Then Exit Sub

        Dim pMsg As String = "PatCD:" & txtPatCD.Text & Chr(13) _
            & "Pat名:" & txtPat名.Text & Chr(13) _
            & "このデータをマスタから削除します。"
        Dim pAns As Integer = MsgBox(pMsg, vbYesNo + vbQuestion, "データ削除")
        If pAns = vbNo Then Exit Sub

        Data_Del00()
        Inp_Clr00()
        Add_Item00()
        txtPatCD.Focus()
    End Sub

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.ItemActivate
        Dim lv As ListView = DirectCast(sender, ListView)

        txtPatCD.Text = lv.FocusedItem.Text
        btnOK00.PerformClick()
    End Sub

    Private Sub Cmd05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd05.Click
        Inp_Clr00()
        Add_Item00()
        txtPatCD.Focus()
    End Sub

End Class