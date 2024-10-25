Imports System.Data.SqlClient
Imports Microsoft
Public Class F_Ms_SiPatM00
    Dim pFocus(10) As Object
    Dim pubCom As New Com
    Private Mysqlserver As SQLServer = New SQLServer()
    '******************************************************
    '* コンボボックスにItemを追加する。
    '******************************************************
    Private Sub Add_Cmb00()
        Dim pCmb00(5) As MyComboBoxItemA
        pCmb00(0) = New MyComboBoxItemA("指定無", "0")
        pCmb00(1) = New MyComboBoxItemA("コード指定", "1")
        pCmb00(2) = New MyComboBoxItemA("依頼銀行マスタ", "2")
        pCmb00(3) = New MyComboBoxItemA("仕入先マスタ", "3")
        pCmb00(4) = New MyComboBoxItemA("得意先マスタ", "4")
        pCmb00(5) = New MyComboBoxItemA("プログラム制御", "999")
        With CmbS部門
            .DisplayMember = "ItemName"
            .ValueMember = "ItemCode"
            .DataSource = pCmb00
            .SelectedIndex = -1
        End With

        Dim pCmb01(5) As MyComboBoxItemA
        pCmb01(0) = New MyComboBoxItemA("指定無", "0")
        pCmb01(1) = New MyComboBoxItemA("コード指定", "1")
        pCmb01(2) = New MyComboBoxItemA("依頼銀行マスタ", "2")
        pCmb01(3) = New MyComboBoxItemA("仕入先マスタ", "3")
        pCmb01(4) = New MyComboBoxItemA("得意先マスタ", "4")
        pCmb01(5) = New MyComboBoxItemA("プログラム制御", "999")
        CmbS科目.DisplayMember = "ItemName"
        CmbS科目.ValueMember = "ItemCode"
        CmbS科目.DataSource = pCmb01
        CmbS科目.SelectedIndex = -1

        Dim pCmb02(5) As MyComboBoxItemA
        pCmb02(0) = New MyComboBoxItemA("指定無", "0")
        pCmb02(1) = New MyComboBoxItemA("コード指定", "1")
        pCmb02(4) = New MyComboBoxItemA("依頼銀行マスタ", "2")
        pCmb02(3) = New MyComboBoxItemA("仕入先マスタ", "3")
        pCmb02(2) = New MyComboBoxItemA("得意先マスタ", "4")
        pCmb02(5) = New MyComboBoxItemA("プログラム制御", "999")
        CmbS枝番.DisplayMember = "ItemName"
        CmbS枝番.ValueMember = "ItemCode"
        CmbS枝番.DataSource = pCmb02
        CmbS枝番.SelectedIndex = -1

        Dim pCmb03(3) As MyComboBoxItemA
        pCmb03(0) = New MyComboBoxItemA("指定無", "0")
        pCmb03(1) = New MyComboBoxItemA("コード指定", "1")
        pCmb03(2) = New MyComboBoxItemA("取引先CD", "2")
        pCmb03(3) = New MyComboBoxItemA("プログラム制御", "999")
        CmbS取引.DisplayMember = "ItemName"
        CmbS取引.ValueMember = "ItemCode"
        CmbS取引.DataSource = pCmb03
        CmbS取引.SelectedIndex = -1

        Dim pCmb04(5) As MyComboBoxItemA
        pCmb04(0) = New MyComboBoxItemA("対象外", "0")
        pCmb04(1) = New MyComboBoxItemA("税込", "1")
        pCmb04(2) = New MyComboBoxItemA("税抜", "2")
        pCmb04(3) = New MyComboBoxItemA("免税", "3")
        pCmb04(4) = New MyComboBoxItemA("非課税", "4")
        pCmb04(5) = New MyComboBoxItemA("プログラム制御", "999")
        CmbS課税.DisplayMember = "ItemName"
        CmbS課税.ValueMember = "ItemCode"
        CmbS課税.DataSource = pCmb04
        CmbS課税.SelectedIndex = -1

        Dim pCmb05(4) As MyComboBoxItemA
        pCmb05(0) = New MyComboBoxItemA("対象外", "0")
        pCmb05(1) = New MyComboBoxItemA("課売", "1")
        pCmb05(2) = New MyComboBoxItemA("非売", "2")
        pCmb05(3) = New MyComboBoxItemA("共売", "3")
        pCmb05(4) = New MyComboBoxItemA("プログラム制御", "999")
        CmbS仕入.DisplayMember = "ItemName"
        CmbS仕入.ValueMember = "ItemCode"
        CmbS仕入.DataSource = pCmb05
        CmbS仕入.SelectedIndex = -1

        Dim pCmb06(5) As MyComboBoxItemA
        pCmb06(0) = New MyComboBoxItemA("指定無", "0")
        pCmb06(1) = New MyComboBoxItemA("コード指定", "1")
        pCmb06(2) = New MyComboBoxItemA("依頼銀行マスタ", "2")
        pCmb06(3) = New MyComboBoxItemA("仕入先マスタ", "3")
        pCmb06(4) = New MyComboBoxItemA("得意先マスタ", "4")
        pCmb06(5) = New MyComboBoxItemA("プログラム制御", "999")
        CmbR部門.DisplayMember = "ItemName"
        CmbR部門.ValueMember = "ItemCode"
        CmbR部門.DataSource = pCmb06
        CmbR部門.SelectedIndex = -1

        Dim pCmb07(5) As MyComboBoxItemA
        pCmb07(0) = New MyComboBoxItemA("指定無", "0")
        pCmb07(1) = New MyComboBoxItemA("コード指定", "1")
        pCmb07(2) = New MyComboBoxItemA("依頼銀行マスタ", "2")
        pCmb07(3) = New MyComboBoxItemA("仕入先マスタ", "3")
        pCmb07(4) = New MyComboBoxItemA("得意先マスタ", "4")
        pCmb07(5) = New MyComboBoxItemA("プログラム制御", "999")
        CmbR科目.DisplayMember = "ItemName"
        CmbR科目.ValueMember = "ItemCode"
        CmbR科目.DataSource = pCmb07
        CmbR科目.SelectedIndex = -1

        Dim pCmb08(5) As MyComboBoxItemA
        pCmb08(0) = New MyComboBoxItemA("指定無", "0")
        pCmb08(1) = New MyComboBoxItemA("コード指定", "1")
        pCmb08(4) = New MyComboBoxItemA("依頼銀行マスタ", "2")
        pCmb08(3) = New MyComboBoxItemA("仕入先マスタ", "3")
        pCmb08(2) = New MyComboBoxItemA("得意先マスタ", "4")
        pCmb08(5) = New MyComboBoxItemA("プログラム制御", "999")
        CmbR枝番.DisplayMember = "ItemName"
        CmbR枝番.ValueMember = "ItemCode"
        CmbR枝番.DataSource = pCmb08
        CmbR枝番.SelectedIndex = -1

        Dim pCmb09(3) As MyComboBoxItemA
        pCmb09(0) = New MyComboBoxItemA("指定無", "0")
        pCmb09(1) = New MyComboBoxItemA("コード指定", "1")
        pCmb09(2) = New MyComboBoxItemA("取引先CD", "2")
        pCmb09(3) = New MyComboBoxItemA("プログラム制御", "999")
        CmbR取引.DisplayMember = "ItemName"
        CmbR取引.ValueMember = "ItemCode"
        CmbR取引.DataSource = pCmb09
        CmbR取引.SelectedIndex = -1

        Dim pCmb10(5) As MyComboBoxItemA
        pCmb10(0) = New MyComboBoxItemA("対象外", "0")
        pCmb10(1) = New MyComboBoxItemA("税込", "1")
        pCmb10(2) = New MyComboBoxItemA("税抜", "2")
        pCmb10(3) = New MyComboBoxItemA("免税", "3")
        pCmb10(4) = New MyComboBoxItemA("非課税", "4")
        pCmb10(5) = New MyComboBoxItemA("プログラム制御", "999")
        CmbR課税.DisplayMember = "ItemName"
        CmbR課税.ValueMember = "ItemCode"
        CmbR課税.DataSource = pCmb10
        CmbR課税.SelectedIndex = -1

        Dim pCmb11(4) As MyComboBoxItemA
        pCmb11(0) = New MyComboBoxItemA("対象外", "0")
        pCmb11(1) = New MyComboBoxItemA("課売", "1")
        pCmb11(2) = New MyComboBoxItemA("非売", "2")
        pCmb11(3) = New MyComboBoxItemA("共売", "3")
        pCmb11(4) = New MyComboBoxItemA("プログラム制御", "999")
        CmbR仕入.DisplayMember = "ItemName"
        CmbR仕入.ValueMember = "ItemCode"
        CmbR仕入.DataSource = pCmb11
        CmbR仕入.SelectedIndex = -1

        Dim pCmb12(2) As MyComboBoxItemA
        pCmb12(0) = New MyComboBoxItemA("指定無", "0")
        pCmb12(1) = New MyComboBoxItemA("指定された番号", "1")
        pCmb12(2) = New MyComboBoxItemA("プログラム制御", "999")
        Cmb伝票区分.DisplayMember = "ItemName"
        Cmb伝票区分.ValueMember = "ItemCode"
        Cmb伝票区分.DataSource = pCmb12
        Cmb伝票区分.SelectedIndex = -1

        Dim pCmb13(7) As MyComboBoxItemA
        pCmb13(0) = New MyComboBoxItemA("指定無", "0")
        pCmb13(1) = New MyComboBoxItemA("内容指定", "1")
        pCmb13(2) = New MyComboBoxItemA("内容指定+対象月", "2")
        pCmb13(3) = New MyComboBoxItemA("取引先名", "3")
        pCmb13(4) = New MyComboBoxItemA("取引先名+内容指定", "4")
        pCmb13(5) = New MyComboBoxItemA("取引先名+外部摘要", "5")
        pCmb13(6) = New MyComboBoxItemA("取引先名+外部摘要+対象月", "6")
        pCmb13(7) = New MyComboBoxItemA("プログラム制御", "999")
        Cmb摘要区分.DisplayMember = "ItemName"
        Cmb摘要区分.ValueMember = "ItemCode"
        Cmb摘要区分.DataSource = pCmb13
        Cmb摘要区分.SelectedIndex = -1

        Dim pCmb14(9) As MyComboBoxItemA
        pCmb14(0) = New MyComboBoxItemA("通常金額", "0")
        pCmb14(1) = New MyComboBoxItemA("振込手数料", "1")
        pCmb14(2) = New MyComboBoxItemA("振込金額+振込手数料", "2")
        pCmb14(3) = New MyComboBoxItemA("手形金額", "3")
        pCmb14(4) = New MyComboBoxItemA("小切手金額", "4")
        pCmb14(5) = New MyComboBoxItemA("相殺計算", "5")
        pCmb14(6) = New MyComboBoxItemA("内税", "6")
        pCmb14(7) = New MyComboBoxItemA("外税", "7")
        pCmb14(8) = New MyComboBoxItemA("非課税", "8")
        pCmb14(9) = New MyComboBoxItemA("プログラム制御", "999")
        Cmb金額区分.DisplayMember = "ItemName"
        Cmb金額区分.ValueMember = "ItemCode"
        Cmb金額区分.DataSource = pCmb14
        Cmb金額区分.SelectedIndex = -1

        'Dim pCmb15(3) As MyComboBoxItemA
        'pCmb15(0) = New MyComboBoxItemA("指定無", "0")
        'pCmb15(1) = New MyComboBoxItemA("指定された番号", "1")
        'pCmb15(2) = New MyComboBoxItemA("伝票より", "2")
        'pCmb15(3) = New MyComboBoxItemA("プログラム制御", "999")
        'CmbS工事.DisplayMember = "ItemName"
        'CmbS工事.ValueMember = "ItemCode"
        'CmbS工事.DataSource = pCmb15
        'CmbS工事.SelectedIndex = -1

        'Dim pCmb16(3) As MyComboBoxItemA
        'pCmb16(0) = New MyComboBoxItemA("指定無", "0")
        'pCmb16(1) = New MyComboBoxItemA("指定された番号", "1")
        'pCmb16(2) = New MyComboBoxItemA("伝票より", "2")
        'pCmb16(3) = New MyComboBoxItemA("プログラム制御", "999")
        'CmbR工事.DisplayMember = "ItemName"
        'CmbR工事.ValueMember = "ItemCode"
        'CmbR工事.DataSource = pCmb16
        'CmbR工事.SelectedIndex = -1
    End Sub
    '******************************************************
    '* コンボボックスにItemを追加する。
    '******************************************************
    Private Sub Add_Cmb01()
        'Dim SQL As String
        'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        'Dim ComboItemA As New ArrayList()

        'SQL = "SELECT * " _
        '    & "FROM MM_区分M00 " _
        '    & "WHERE (会社No =" & pubComPany & ") " _
        '    & "AND (区分 = 901) " _
        '    & "ORDER BY CD"
        ''SQLCmd.CommandText = SQL
        ''da0.SelectCommand = SQLCmd
        'da0.Fill(dt0, "t0")
        'With dt0.Tables("t0")
        '    For i0 As Integer = 0 To .Rows.Count - 1
        '        Dim pCD As String = pubCom.ChgNull(.Rows(i0)("CD"), 1)
        '        Dim pName As String = pubCom.ChgNull(.Rows(i0)("名称"), 1)
        '        ComboItemA.Add(New MyComboBoxItemA(pName, pCD))
        '    Next
        'End With

        'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
    End Sub
    '******************************************************
    '* リストにItemを表示する共通関数
    '******************************************************
    Private Sub Add_Item00()
        Dim SQL As String
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet

        LV.Items.Clear()
        SQL = "SELECT * " _
            & "FROM M_SiPatM00 " _
            & "WHERE 会社No = @会社No " _
            & "And PatCD = @PatCD " _
            & "ORDER BY Pat明細No"

        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@会社No", pubComPany),
            New SqlParameter("@PatCD", txtPatCD.Text)
            }

        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        LV.Items.Clear()
        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            Dim i0 As Integer = 0
            For Each Row As DataRow In result.Rows
                LV.Items.Add(Integer.Parse(Row("Pat明細No")).ToString("000"), i0)
                LV.Items(i0).SubItems.Add(pubCom.ChgNull(Row("項目名称"), 1))
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
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
                AddHandler CtrlItem.Leave, AddressOf txtInp_Leave
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then
                AddHandler CtrlItem.Enter, AddressOf txtInp_Enter
                AddHandler CtrlItem.KeyDown, AddressOf txtInp_KeyDown
                AddHandler CtrlItem.KeyPress, AddressOf txtInp_KeyPress
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
        For Each CtrlItem As Control In Me.GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
            If TypeOf CtrlItem Is ComboBox Then
                Dim pComboBox As ComboBox = CType(CtrlItem, ComboBox)
                pComboBox.SelectedIndex = -1
            End If
        Next
        LV.Items.Clear()
        txtMsg.Text = "" : txtMsg.Visible = False

        'txt借方部門CD.MaxLength = pubDigFOrg
        'txt借方科目CD.MaxLength = pubDigFKa
        'txt借方枝番CD.MaxLength = pubDigFKaS
        'txt貸方部門CD.MaxLength = pubDigFOrg
        'txt貸方科目CD.MaxLength = pubDigFKa
        'txt貸方枝番CD.MaxLength = pubDigFKaS
        'txt消費税対象CD.MaxLength = pubDigFKa

        Me.GroupBox00.Enabled = True

    End Sub
    '******************************************************
    '* フィールドクリア関数
    '******************************************************
    Private Sub Inp_Clr10()

        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                CtrlItem.Text = ""
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then
                CtrlItem.Text = ""
            End If
            If TypeOf CtrlItem Is ComboBox Then
                Dim pComboBox As ComboBox = CType(CtrlItem, ComboBox)
                pComboBox.SelectedIndex = -1
            End If
        Next
        txtMsg.Text = "" : txtMsg.Visible = False
    End Sub
    Private Sub txtInp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub

        pTxtBox.SelectAll()
        pTxtBox.BackColor = Color.MistyRose
        txtModified.Text = ""

        Select Case pTxtBox.Name
            Case "txtPatCD"
                AddHandler txtPatCD.TextChanged, AddressOf txtModified_TextChanged
            Case "txtDetNo"
                AddHandler txtDetNo.TextChanged, AddressOf txtModified_TextChanged
        End Select

        pFocus(0) = pTxtBox
    End Sub
    Private Sub txtInp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case 38
                Me.SelectNextControl(sender, False, True, True, True)
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
                    txtModified.Text = ""
                End If
                RemoveHandler pTxtBox.TextChanged, AddressOf txtModified_TextChanged
            Case "txtDetNo"
                If txtModified.Text = "1" Then
                    btnOK10.PerformClick()
                    txtModified.Text = ""
                End If
                RemoveHandler pTxtBox.TextChanged, AddressOf txtModified_TextChanged
        End Select
        txtModified.Text = ""
        pTxtBox.BackColor = Color.White
    End Sub

    Private Sub txtInp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim pRet As Boolean
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        Select Case pTxtBox.Name
            Case "txtDet名", "txt摘要"
            Case Else
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select
        End Select

        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                Select Case pTxtBox.Name
                    Case "txtPatCD"
                        If txtModified.Text = "1" Then
                            btnOK00.PerformClick()
                            txtModified.Text = ""
                            Exit Sub
                        End If
                    Case "txtDetNo"
                        If txtModified.Text = "1" Then
                            btnOK10.PerformClick()
                            txtModified.Text = ""
                            Exit Sub
                        End If
                End Select

                pRet = Inp_Chk00(sender)
                If pRet = False Then Exit Sub
                Me.SelectNextControl(sender, True, True, True, True)
                e.Handled = True
        End Select
    End Sub

    Private Sub txtModified_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtModified.Text = "1"
    End Sub


    Private Sub F_Ms_SiPat00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 116
                Cmd05.PerformClick() : e.Handled = True
            Case 120
                Cmd09.PerformClick() : e.Handled = True
            Case 122
                Cmd11.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_Ms_SiPat00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inp_Clr00()
        Add_Cmb00()
        Add_Cmb01()
        Dsp_Init00()

        Me.ActiveControl = Me.txtPatCD
    End Sub

    Private Sub btnOK00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK00.Click
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim wRet As Boolean = Inp_Chk00(CtrlItem)
                If wRet = False Then Exit Sub
            End If
        Next

        Add_Item00()
        txtDetNo.Focus()
        Me.GroupBox00.Enabled = False
    End Sub
    Private Sub btnOK10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK10.Click
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim wRet As Boolean = Inp_Chk00(CtrlItem)
                If wRet = False Then Exit Sub
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim wRet As Boolean = Inp_Chk00(CtrlItem)
                If wRet = False Then Exit Sub
            End If
        Next

        Data_Get00()
        txtDet名.Focus()
    End Sub
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True
        txtMsg.Visible = False : txtMsg.Text = ""

        Select Case ctxtInp.Name
            Case "txtPatCD"
                ctxtInp.BackColor = Color.White
                If txtPatCD.Text = "" Then
                    txtMsg.Text = "PatCD未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
                Dim SQL As String
                SQL = "SELECT * " _
                    & "FROM M_SiPatH00 " _
                    & "WHERE 会社No = @会社No " _
                    & "AND PatCD = @PatCD "

                Dim parameters As New List(Of SqlParameter) From {
        New SqlParameter("@会社No", pubComPany),
        New SqlParameter("@PatCD", txtPatCD.Text)
    }
                Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())
                If result.Rows.Count = 0 Then
                    txtMsg.Text = "PatCD不正入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                Else
                    txtPat名.Text = pubCom.ChgNull(result.Rows(0)("Pat名"), 1)
                End If
            Case "txtDet名"
                Dim LenB As Byte = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(ctxtInp.Text)
                If LenB > 60 Then
                    txtMsg.Text = "項目名超過:60"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txtDetNo"
                ctxtInp.BackColor = Color.White
                If txtDetNo.Text = "" Then
                    txtMsg.Text = "仕訳No未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt借方部門区分"
                ctxtInp.BackColor = Color.White
                If txt借方部門区分.Text = "" Then
                    CmbS部門.SelectedIndex = -1
                Else
                    CmbS部門.SelectedValue = txt借方部門区分.Text
                    If CmbS部門.SelectedIndex = -1 Then
                        txtMsg.Text = "借方部門区分"
                        CmbS部門.SelectedIndex = -1
                        Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                    End If
                End If
            Case "txt借方科目区分"
                ctxtInp.BackColor = Color.White
                If txt借方科目区分.Text = "" Then CmbS科目.SelectedIndex = -1 : Exit Function
                CmbS科目.SelectedValue = txt借方科目区分.Text
                If CmbS科目.SelectedIndex = -1 Then
                    CmbS科目.SelectedIndex = -1
                    txtMsg.Text = "借方科目区分"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt借方枝番区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbS枝番.SelectedIndex = -1 : Exit Function
                CmbS枝番.SelectedValue = txt借方枝番区分.Text
                If CmbS枝番.SelectedIndex = -1 Then
                    txtMsg.Text = "借方枝番区分"
                    CmbS枝番.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt借方取引区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbS取引.SelectedIndex = -1 : Exit Function
                CmbS取引.SelectedValue = txt借方取引区分.Text
                If CmbS取引.SelectedIndex = -1 Then
                    txtMsg.Text = "借方取引区分"
                    CmbS取引.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt借方課税区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbS課税.SelectedIndex = -1 : Exit Function
                CmbS課税.SelectedValue = txt借方課税区分.Text
                If CmbS課税.SelectedIndex = -1 Then
                    txtMsg.Text = "借方課税区分"
                    CmbS課税.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt借方仕入区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbS仕入.SelectedIndex = -1 : Exit Function
                CmbS仕入.SelectedValue = txt借方仕入区分.Text
                If CmbS仕入.SelectedIndex = -1 Then
                    txtMsg.Text = "借方仕入区分"
                    CmbS仕入.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt貸方部門区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbR部門.SelectedIndex = -1 : Exit Function
                CmbR部門.SelectedValue = txt貸方部門区分.Text
                If CmbR部門.SelectedIndex = -1 Then
                    txtMsg.Text = "貸方部門区分"
                    CmbR部門.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt貸方科目区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbR科目.SelectedIndex = -1 : Exit Function
                CmbR科目.SelectedValue = txt貸方科目区分.Text
                If CmbR科目.SelectedIndex = -1 Then
                    txtMsg.Text = "貸方科目区分"
                    CmbR科目.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt貸方枝番区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbR枝番.SelectedIndex = -1 : Exit Function
                CmbR枝番.SelectedValue = txt貸方枝番区分.Text
                If CmbR枝番.SelectedIndex = -1 Then
                    txtMsg.Text = "貸方枝番区分"
                    CmbR枝番.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt貸方取引区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbR取引.SelectedIndex = -1 : Exit Function
                CmbR取引.SelectedValue = txt貸方取引区分.Text
                If CmbR取引.SelectedIndex = -1 Then
                    txtMsg.Text = "貸方取引区分"
                    CmbR取引.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt貸方課税区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbR課税.SelectedIndex = -1 : Exit Function
                CmbR課税.SelectedValue = txt貸方課税区分.Text
                If CmbR課税.SelectedIndex = -1 Then
                    txtMsg.Text = "貸方課税区分"
                    CmbR課税.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt貸方仕入区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then CmbR仕入.SelectedIndex = -1 : Exit Function
                CmbR仕入.SelectedValue = txt貸方仕入区分.Text
                If CmbR仕入.SelectedIndex = -1 Then
                    txtMsg.Text = "貸方仕入区分"
                    CmbR仕入.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt伝票区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then Cmb伝票区分.SelectedIndex = -1 : Exit Function
                Cmb伝票区分.SelectedValue = txt伝票区分.Text
                If Cmb伝票区分.SelectedIndex = -1 Then
                    txtMsg.Text = "伝票区分"
                    Cmb伝票区分.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt摘要区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then Cmb摘要区分.SelectedIndex = -1 : Exit Function
                Cmb摘要区分.SelectedValue = txt摘要区分.Text
                If Cmb摘要区分.SelectedIndex = -1 Then
                    txtMsg.Text = "摘要区分"
                    Cmb摘要区分.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt金額区分"
                ctxtInp.BackColor = Color.White
                If ctxtInp.Text = "" Then Cmb金額区分.SelectedIndex = -1 : Exit Function
                Cmb金額区分.SelectedValue = txt金額区分.Text
                If Cmb金額区分.SelectedIndex = -1 Then
                    txtMsg.Text = "金額区分"
                    Cmb金額区分.SelectedIndex = -1
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt借方部門CD"
                'txt借方部門名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wCode As String = txt借方部門CD.Text
                'Dim wRes As Byte = Mst.財務部門00(0, wCode, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "借方部門不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt借方部門名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("部門名"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt借方科目CD"
                'ctxtInp.BackColor = Color.White
                'txt借方科目名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wCode As String = txt借方科目CD.Text
                'Dim wRes As Byte = Mst.財務科目00(0, wCode, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "借方科目CD不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt借方科目名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("科目略称名"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt借方枝番CD"
                'ctxtInp.BackColor = Color.White
                'txt借方枝番名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wCode00 As String = txt借方科目CD.Text
                'Dim wCode10 As String = txt借方枝番CD.Text
                'Dim wRes As Byte = Mst.財務科目S00(0, wCode00, wCode10, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "借方枝番CD不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt借方枝番名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("科目枝番名"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt貸方部門CD"
                'txt貸方部門名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wCode As String = txt貸方部門CD.Text
                'Dim wRes As Byte = Mst.財務部門00(0, wCode, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "貸方部門不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt貸方部門名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("部門名"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt貸方科目CD"
                'ctxtInp.BackColor = Color.White
                'txt貸方科目名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wCode As String = txt貸方科目CD.Text
                'Dim wRes As Byte = Mst.財務科目00(0, wCode, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "貸方科目CD不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt貸方科目名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("科目略称名"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt貸方枝番CD"
                'ctxtInp.BackColor = Color.White
                'txt貸方枝番名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wCode00 As String = txt貸方科目CD.Text
                'Dim wCode10 As String = txt貸方枝番CD.Text
                'Dim wRes As Byte = Mst.財務科目S00(0, wCode00, wCode10, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "貸方枝番CD不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt貸方枝番名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("科目枝番名"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt摘要"
                Dim LenB As Byte = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(ctxtInp.Text)
                If LenB > 60 Then
                    txtMsg.Text = "摘要超過:60"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                End If
            Case "txt消費税対象CD"
                'ctxtInp.BackColor = Color.White
                'txt消費税対象名.Text = ""
                'If ctxtInp.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wCode As String = txt消費税対象CD.Text
                'Dim wRes As Byte = Mst.財務科目00(0, wCode, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "消費税対象CD不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt消費税対象名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("科目略称名"), 1)
                'End If
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
        End Select
    End Function

    '******************************************************
    '* データの削除
    '******************************************************
    Public Sub Data_Del00()
        Dim condition As String
        condition = "会社No = @会社No " _
            & "AND PatCD = @PatCD " _
            & "AND Pat明細No = @Pat明細No"

        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@会社No", pubComPany),
            New SqlParameter("@PatCD", txtPatCD.Text),
            New SqlParameter("@Pat明細No", txtDetNo.Text)
}

        Mysqlserver.DeleteData("M_SiPatM00", condition, parameters.ToArray())

    End Sub

    '******************************************************
    '* データの取得
    '******************************************************
    Public Sub Data_Get00()
        Dim SQL As String


        SQL = "SELECT * " _
            & "FROM M_SiPatM00 " _
            & "WHERE 会社No = @会社No " _
            & "AND PatCD = @PatCD " _
            & "AND Pat明細No = @Pat明細No "

        Dim parameters As New List(Of SqlParameter) From {
        New SqlParameter("@会社No", pubComPany),
        New SqlParameter("@PatCD", txtPatCD.Text),
        New SqlParameter("@Pat明細No", txtDetNo.Text)
        }

        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        If result.Rows.Count > 0 Then
            txtDet名.Text = pubCom.ChgNull(result.Rows(0)("項目名称"), 1)
            txt借方部門区分.Text = pubCom.ChgNull(result.Rows(0)("借方部門区分"), 1)
            txt借方科目区分.Text = pubCom.ChgNull(result.Rows(0)("借方科目区分"), 1)
            txt借方枝番区分.Text = pubCom.ChgNull(result.Rows(0)("借方枝番区分"), 1)
            txt借方取引区分.Text = pubCom.ChgNull(result.Rows(0)("借方取引先区分"), 1)
            txt借方課税区分.Text = pubCom.ChgNull(result.Rows(0)("借方課税区分"), 1)
            txt借方仕入区分.Text = pubCom.ChgNull(result.Rows(0)("借方仕入区分"), 1)
            txt貸方部門区分.Text = pubCom.ChgNull(result.Rows(0)("貸方部門区分"), 1)
            txt貸方科目区分.Text = pubCom.ChgNull(result.Rows(0)("貸方科目区分"), 1)
            txt貸方枝番区分.Text = pubCom.ChgNull(result.Rows(0)("貸方枝番区分"), 1)
            txt貸方取引区分.Text = pubCom.ChgNull(result.Rows(0)("貸方取引先区分"), 1)
            txt貸方課税区分.Text = pubCom.ChgNull(result.Rows(0)("貸方課税区分"), 1)
            txt貸方仕入区分.Text = pubCom.ChgNull(result.Rows(0)("貸方仕入区分"), 1)
            txt伝票区分.Text = pubCom.ChgNull(result.Rows(0)("伝票区分"), 1)
            txt摘要区分.Text = pubCom.ChgNull(result.Rows(0)("摘要区分"), 1)
            txt金額区分.Text = pubCom.ChgNull(result.Rows(0)("金額区分"), 1)
            txt借方部門CD.Text = pubCom.ChgNull(result.Rows(0)("借方部門"), 1)
            txt借方科目CD.Text = pubCom.ChgNull(result.Rows(0)("借方科目"), 1)
            txt借方枝番CD.Text = pubCom.ChgNull(result.Rows(0)("借方枝番"), 1)
            txt借方取引先CD.Text = pubCom.ChgNull(result.Rows(0)("借方取引先"), 1)
            txt貸方部門CD.Text = pubCom.ChgNull(result.Rows(0)("貸方部門"), 1)
            txt貸方科目CD.Text = pubCom.ChgNull(result.Rows(0)("貸方科目"), 1)
            txt貸方枝番CD.Text = pubCom.ChgNull(result.Rows(0)("貸方枝番"), 1)
            txt貸方取引先CD.Text = pubCom.ChgNull(result.Rows(0)("貸方取引先"), 1)
            txt摘要.Text = pubCom.ChgNull(result.Rows(0)("摘要2"), 1)
            txt消費税対象CD.Text = pubCom.ChgNull(result.Rows(0)("課税対象科目"), 1)
            txt伝票番号.Text = pubCom.ChgNull(result.Rows(0)("伝票番号"), 1)
            txt借方工事区分.Text = pubCom.ChgNull(result.Rows(0)("借方工事区分"), 1)
            txt貸方工事区分.Text = pubCom.ChgNull(result.Rows(0)("貸方工事区分"), 1)
            txt借方工事CD.Text = pubCom.ChgNull(result.Rows(0)("借方工事"), 1)
            txt貸方工事CD.Text = pubCom.ChgNull(result.Rows(0)("貸方工事"), 1)
        End If

        For Each CtrlItem As Control In Me.GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then
                Inp_Chk00(CtrlItem)
            End If
        Next
    End Sub

    '******************************************************
    '* ※MM_SiPat00保存:
    '******************************************************
    Public Sub Data_Put00()
        Dim SQL As String
        SQL = "SELECT * " _
            & "FROM M_SiPatM00 " _
            & "WHERE 会社No = @会社No " _
            & "AND PatCD = @PatCD " _
            & "AND Pat明細No = @Pat明細No "

        Dim parameters As New List(Of SqlParameter) From {
        New SqlParameter("@会社No", pubComPany),
        New SqlParameter("@PatCD", txtPatCD.Text),
        New SqlParameter("@Pat明細No", txtDetNo.Text)
        }

        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())
        Dim wTmp00 As Object

        parameters.Clear()
        parameters.Add(New SqlParameter("@会社No", pubComPany))
        parameters.Add(New SqlParameter("@PatCD", txtPatCD.Text))
        parameters.Add(New SqlParameter("@Pat明細No", txtDetNo.Text))
        parameters.Add(New SqlParameter("@項目名称", txtDet名.Text))
        wTmp00 = DBNull.Value : If IsNumeric(txt借方部門区分.Text) Then wTmp00 = Integer.Parse(txt借方部門区分.Text)
        parameters.Add(New SqlParameter("@借方部門区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt借方科目区分.Text) Then wTmp00 = Integer.Parse(txt借方科目区分.Text)
        parameters.Add(New SqlParameter("@借方科目区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt借方枝番区分.Text) Then wTmp00 = Integer.Parse(txt借方枝番区分.Text)
        parameters.Add(New SqlParameter("@借方枝番区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt借方取引区分.Text) Then wTmp00 = Integer.Parse(txt借方取引区分.Text)
        parameters.Add(New SqlParameter("@借方取引先区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt借方課税区分.Text) Then wTmp00 = Integer.Parse(txt借方課税区分.Text)
        parameters.Add(New SqlParameter("@借方課税区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt借方仕入区分.Text) Then wTmp00 = Integer.Parse(txt借方仕入区分.Text)
        parameters.Add(New SqlParameter("@借方仕入区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt貸方部門区分.Text) Then wTmp00 = Integer.Parse(txt貸方部門区分.Text)
        parameters.Add(New SqlParameter("@貸方部門区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt貸方科目区分.Text) Then wTmp00 = Integer.Parse(txt貸方科目区分.Text)
        parameters.Add(New SqlParameter("@貸方科目区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt貸方枝番区分.Text) Then wTmp00 = Integer.Parse(txt貸方枝番区分.Text)
        parameters.Add(New SqlParameter("@貸方枝番区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt貸方取引区分.Text) Then wTmp00 = Integer.Parse(txt貸方取引区分.Text)
        parameters.Add(New SqlParameter("@貸方取引先区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt貸方課税区分.Text) Then wTmp00 = Integer.Parse(txt貸方課税区分.Text)
        parameters.Add(New SqlParameter("@貸方課税区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt貸方仕入区分.Text) Then wTmp00 = Integer.Parse(txt貸方仕入区分.Text)
        parameters.Add(New SqlParameter("@貸方仕入区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt伝票区分.Text) Then wTmp00 = Integer.Parse(txt伝票区分.Text)
        parameters.Add(New SqlParameter("@伝票区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt摘要区分.Text) Then wTmp00 = Integer.Parse(txt摘要区分.Text)
        parameters.Add(New SqlParameter("@摘要区分", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt金額区分.Text) Then wTmp00 = Integer.Parse(txt金額区分.Text)
        parameters.Add(New SqlParameter("@金額区分", wTmp00))

        parameters.Add(New SqlParameter("@借方部門", txt借方部門CD.Text))
        parameters.Add(New SqlParameter("@借方科目", txt借方科目CD.Text))
        parameters.Add(New SqlParameter("@借方枝番", txt借方枝番CD.Text))
        parameters.Add(New SqlParameter("@借方取引先", txt借方取引先CD.Text))
        parameters.Add(New SqlParameter("@貸方部門", txt貸方部門CD.Text))
        parameters.Add(New SqlParameter("@貸方科目", txt貸方科目CD.Text))
        parameters.Add(New SqlParameter("@貸方枝番", txt貸方枝番CD.Text))
        parameters.Add(New SqlParameter("@貸方取引先", txt貸方取引先CD.Text))
        parameters.Add(New SqlParameter("@摘要2", txt摘要.Text))

        wTmp00 = DBNull.Value : If IsNumeric(txt消費税対象CD.Text) Then wTmp00 = Integer.Parse(txt消費税対象CD.Text)
        parameters.Add(New SqlParameter("@課税対象科目", wTmp00))

        wTmp00 = DBNull.Value : If IsNumeric(txt伝票番号.Text) Then wTmp00 = Integer.Parse(txt伝票番号.Text)
        parameters.Add(New SqlParameter("@伝票番号", wTmp00))
        If result.Rows.Count = 0 Then
            Dim columns As String = "会社No " &
                                    ", PatCD " &
                                    ", Pat明細No " &
                                    ", 項目名称 " &
                                    ", 借方部門区分 " &
                                    ", 借方科目区分 " &
                                    ", 借方枝番区分 " &
                                    ", 借方取引先区分 " &
                                    ", 借方課税区分 " &
                                    ", 借方仕入区分 " &
                                    ", 貸方部門区分 " &
                                    ", 貸方科目区分 " &
                                    ", 貸方枝番区分 " &
                                    ", 貸方取引先区分 " &
                                    ", 貸方課税区分 " &
                                    ", 貸方仕入区分 " &
                                    ", 伝票区分 " &
                                    ", 摘要区分 " &
                                    ", 金額区分 " &
                                    ", 借方部門 " &
                                    ", 借方科目 " &
                                    ", 借方枝番 " &
                                    ", 借方取引先 " &
                                    ", 貸方部門 " &
                                    ", 貸方科目 " &
                                    ", 貸方枝番 " &
                                    ", 貸方取引先 " &
                                    ", 摘要2 " &
                                    ", 課税対象科目 " &
                                    ", 伝票番号 "
            ' 登録する値を指定
            Dim values As String = " @会社No " &
                                    ", @PatCD " &
                                    ", @Pat明細No " &
                                    ", @項目名称 " &
                                    ", @借方部門区分 " &
                                    ", @借方科目区分 " &
                                    ", @借方枝番区分 " &
                                    ", @借方取引先区分 " &
                                    ", @借方課税区分 " &
                                    ", @借方仕入区分 " &
                                    ", @貸方部門区分 " &
                                    ", @貸方科目区分 " &
                                    ", @貸方枝番区分 " &
                                    ", @貸方取引先区分 " &
                                    ", @貸方課税区分 " &
                                    ", @貸方仕入区分 " &
                                    ", @伝票区分 " &
                                    ", @摘要区分 " &
                                    ", @金額区分 " &
                                    ", @借方部門 " &
                                    ", @借方科目 " &
                                    ", @借方枝番 " &
                                    ", @借方取引先 " &
                                    ", @貸方部門 " &
                                    ", @貸方科目 " &
                                    ", @貸方枝番 " &
                                    ", @貸方取引先 " &
                                    ", @摘要2 " &
                                    ", @課税対象科目 " &
                                    ", @伝票番号 "
            Mysqlserver.InsertData("M_SiPatM00", columns, values, parameters.ToArray())
        Else
            Dim setstatement As String = "会社No = @会社No " &
                                         ", PatCD = @PatCD " &
                                         ", Pat明細No = @Pat明細No " &
                                         ", 項目名称 = @項目名称 " &
                                         ", 借方部門区分 = @借方部門区分 " &
                                         ", 借方科目区分 = @借方科目区分 " &
                                         ", 借方枝番区分 = @借方枝番区分 " &
                                         ", 借方取引先区分 = @借方取引先区分 " &
                                         ", 借方課税区分 = @借方課税区分 " &
                                         ", 借方仕入区分 = @借方仕入区分 " &
                                         ", 貸方部門区分 = @貸方部門区分 " &
                                         ", 貸方科目区分 = @貸方科目区分 " &
                                         ", 貸方枝番区分 = @貸方枝番区分 " &
                                         ", 貸方取引先区分 = @貸方取引先区分 " &
                                         ", 貸方課税区分 = @貸方課税区分 " &
                                         ", 貸方仕入区分 = @貸方仕入区分 " &
                                         ", 伝票区分 = @伝票区分 " &
                                         ", 摘要区分 = @摘要区分 " &
                                         ", 金額区分 = @金額区分 " &
                                         ", 借方部門 = @借方部門 " &
                                         ", 借方科目 = @借方科目 " &
                                         ", 借方枝番 = @借方枝番 " &
                                         ", 借方取引先 = @借方取引先 " &
                                         ", 貸方部門 = @貸方部門 " &
                                         ", 貸方科目 = @貸方科目 " &
                                         ", 貸方枝番 = @貸方枝番 " &
                                         ", 貸方取引先 = @貸方取引先 " &
                                         ", 摘要2 = @摘要2 " &
                                         ", 課税対象科目 = @課税対象科目 " &
                                         ", 伝票番号 = @伝票番号 "

            Dim condition As String = "会社No = @会社No " &
                                      "AND PatCD = @PatCD " &
                                      "AND Pat明細No = @Pat明細No "
            Mysqlserver.UpdateData("M_SiPatM00", setstatement, condition, parameters.ToArray())
        End If

        result.Dispose()

    End Sub

    Private Sub btnUp00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp00.Click
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim wRet As Boolean = Inp_Chk00(CtrlItem)
                If wRet = False Then Exit Sub
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim wRet As Boolean = Inp_Chk00(CtrlItem)
                If wRet = False Then Exit Sub
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox20.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim wRet As Boolean = Inp_Chk00(CtrlItem)
                If wRet = False Then Exit Sub
            End If
        Next

        Data_Put00()
        Inp_Clr10()
        Add_Item00()
        txtDetNo.Focus()
    End Sub
    Private Sub btnDel00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel00.Click
        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim wRet As Boolean = Inp_Chk00(CtrlItem)
                If wRet = False Then Exit Sub
            End If
        Next
        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                Dim wRet As Boolean = Inp_Chk00(CtrlItem)
                If wRet = False Then Exit Sub
            End If
        Next

        Dim pMsg As String = "コード:" & txtDetNo.Text & Chr(13) _
                & "名称:" & txt借方科目区分.Text & Chr(13) _
                & "このデータをマスタから削除します。"
        Dim pAns As Integer = MsgBox(pMsg, vbYesNo + vbQuestion, "データ削除")
        If pAns = vbNo Then
            Exit Sub
        End If

        Data_Del00()
        Inp_Clr10()
        Add_Item00()
        txtDetNo.Focus()
    End Sub

    Private Sub LV_ItemActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.ItemActivate
        Dim lv As ListView = DirectCast(sender, ListView)

        txtDetNo.Text = lv.FocusedItem.Text
        btnOK10.PerformClick()
    End Sub


    Private Sub Cmd05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd05.Click
        Cmd05.Focus()
        Inp_Clr00()
        txtPatCD.Focus()
    End Sub

    Private Sub Cmd11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd11.Click
        Me.Close()
    End Sub

    Private Sub CmbS部門00_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbS部門.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbS部門.SelectedIndex = -1 Then
            txt借方部門区分.Text = ""
        Else
            item = DirectCast(CmbS部門.SelectedItem, MyComboBoxItemA)
            txt借方部門区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbS科目_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbS科目.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbS科目.SelectedIndex = -1 Then
            txt借方科目区分.Text = ""
        Else
            item = DirectCast(CmbS科目.SelectedItem, MyComboBoxItemA)
            txt借方科目区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbS枝番_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbS枝番.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbS枝番.SelectedIndex = -1 Then
            txt借方枝番区分.Text = ""
        Else
            item = DirectCast(CmbS枝番.SelectedItem, MyComboBoxItemA)
            txt借方枝番区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbS取引_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbS取引.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbS取引.SelectedIndex = -1 Then
            txt借方取引区分.Text = ""
        Else
            item = DirectCast(CmbS取引.SelectedItem, MyComboBoxItemA)
            txt借方取引区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbS課税_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbS課税.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbS課税.SelectedIndex = -1 Then
            txt借方課税区分.Text = ""
        Else
            item = DirectCast(CmbS課税.SelectedItem, MyComboBoxItemA)
            txt借方課税区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbS仕入_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbS仕入.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbS仕入.SelectedIndex = -1 Then
            txt借方仕入区分.Text = ""
        Else
            item = DirectCast(CmbS仕入.SelectedItem, MyComboBoxItemA)
            txt借方仕入区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbR部門00_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbR部門.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbR部門.SelectedIndex = -1 Then
            txt貸方部門区分.Text = ""
        Else
            item = DirectCast(CmbR部門.SelectedItem, MyComboBoxItemA)
            txt貸方部門区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbR科目_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbR科目.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbR科目.SelectedIndex = -1 Then
            txt貸方科目区分.Text = ""
        Else
            item = DirectCast(CmbR科目.SelectedItem, MyComboBoxItemA)
            txt貸方科目区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbR枝番_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbR枝番.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbR枝番.SelectedIndex = -1 Then
            txt貸方枝番区分.Text = ""
        Else
            item = DirectCast(CmbR枝番.SelectedItem, MyComboBoxItemA)
            txt貸方枝番区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbR取引_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbR取引.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbR取引.SelectedIndex = -1 Then
            txt貸方取引区分.Text = ""
        Else
            item = DirectCast(CmbR取引.SelectedItem, MyComboBoxItemA)
            txt貸方取引区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbR課税_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbR課税.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbR課税.SelectedIndex = -1 Then
            txt貸方課税区分.Text = ""
        Else
            item = DirectCast(CmbR課税.SelectedItem, MyComboBoxItemA)
            txt貸方課税区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub CmbR仕入_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbR仕入.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If CmbR仕入.SelectedIndex = -1 Then
            txt貸方仕入区分.Text = ""
        Else
            item = DirectCast(CmbR仕入.SelectedItem, MyComboBoxItemA)
            txt貸方仕入区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub Cmb伝票区分_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb伝票区分.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If Cmb伝票区分.SelectedIndex = -1 Then
            txt伝票区分.Text = ""
        Else
            item = DirectCast(Cmb伝票区分.SelectedItem, MyComboBoxItemA)
            txt伝票区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub Cmb摘要区分_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb摘要区分.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If Cmb摘要区分.SelectedIndex = -1 Then
            txt摘要区分.Text = ""
        Else
            item = DirectCast(Cmb摘要区分.SelectedItem, MyComboBoxItemA)
            txt摘要区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub Cmb金額区分_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb金額区分.SelectedIndexChanged
        Dim item As MyComboBoxItemA
        If Cmb金額区分.SelectedIndex = -1 Then
            txt金額区分.Text = ""
        Else
            item = DirectCast(Cmb金額区分.SelectedItem, MyComboBoxItemA)
            txt金額区分.Text = item.ItemCode
        End If
    End Sub

    Private Sub Cmd09_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd09.Click
        Dim strName As String
        strName = pFocus(0).Name
        Select Case strName
            Case "txt借方部門CD", "txt貸方部門CD"
                'Dim frmForm = New F_S_Forgani00
                'frmForm.pubBuCD = ""
                'If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                '    pFocus(0).Text = frmForm.pubBuCD
                '    Inp_Chk00(sender)
                'End If
                'frmForm.Dispose() : frmForm = Nothing
            Case "txt借方科目CD", "txt貸方科目CD"
                'Dim frmForm = New F_S_Kam00
                'frmForm.pubKaCD = ""
                'If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                '    pFocus(0).Text.Text = frmForm.pubKaCD
                '    Inp_Chk00(sender)
                'End If
                'frmForm.Dispose() : frmForm = Nothing
            Case "txt借方枝番CD"
                'If IsNumeric(txt借方科目CD.Text) Then
                '    Dim frmForm = New F_S_KaEda00
                '    frmForm.pubKaCD = txt借方科目CD.Text
                '    frmForm.pubEdaCD = ""
                '    If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                '        pFocus(0).Text.Text = frmForm.pubEdaCD
                '        Inp_Chk00(sender)
                '    End If
                'End If
            Case "txt貸方枝番CD"
                'If IsNumeric(txt貸方科目CD.Text) Then
                '    Dim frmForm = New F_S_KaEda00
                '    frmForm.pubKaCD = txt貸方科目CD.Text
                '    frmForm.pubEdaCD = ""
                '    If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                '        pFocus(0).Text.Text = frmForm.pubEdaCD
                '        Inp_Chk00(sender)
                '    End If
                'End If
        End Select
        Me.ActiveControl = pFocus(0)
    End Sub

    Private Sub txtDetNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetNo.KeyPress
        Dim pRet As Boolean
        Dim pTxtBox As TextBox = CType(sender, TextBox)

        Select Case e.KeyChar
            Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
            Case Else
                e.Handled = True
        End Select

        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                pRet = Inp_Chk00(sender)
                If pRet = False Then
                    Exit Sub
                End If
                Me.SelectNextControl(sender, True, True, True, True)
                e.Handled = True
        End Select
    End Sub

    Private Sub MenuItem00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem00.Click
        Dim fForm As New F_Ms_KubunM00
        fForm.Show(Me)
        Add_Cmb01()
    End Sub

End Class