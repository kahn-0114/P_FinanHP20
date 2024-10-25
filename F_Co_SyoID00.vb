Public Class F_Co_SyoID00
    Dim MyCom As New Com
    Dim _pubID As String = String.Empty
    Public Property pubID() As String
        Get
            pubID = _pubID
        End Get
        Set(ByVal value As String)
            _pubID = value
        End Set
    End Property

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub
    '******************************************************
    '* 
    '******************************************************
    Public Sub Data_Put00()
        Dim r0 = DB.OpenRecordset("MM_SYS", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"

        r0.Seek("=", pubComPany, pubLogInName, txtID.Text)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("会社No").Value = pubComPany
            r0.Fields("UsrID").Value = pubLogInName
            r0.Fields("ID").Value = txtID.Text
        Else
            r0.Edit()
        End If
        If IsNumeric(txt年度.Text) Then
            r0.Fields("年度").Value = txt年度.Text
        End If
        r0.Fields("締No").Value = 1
        If IsNumeric(txt締No.Text) Then
            r0.Fields("締No").Value = txt締No.Text
        End If
        r0.Update()
        r0.Close() : r0 = Nothing
        'pubNNen = txt年度.Text
        'pubNNo = txt締No.Text

        'r0 = DB.OpenRecordset("MM_会社", RecordsetTypeEnum.dbOpenTable, RecordsetOptionEnum.dbConsistent, LockTypeEnum.dbOptimistic)
        'r0.Index = "Key_0"
        'r0.Seek("=", pubComPany)
        'If r0.NoMatch Then
        'Else
        '    r0.Edit()
        '    r0.Fields("日次年度").Value = pubNNen
        '    r0.Fields("日次処理No").Value = pubNNo
        '    r0.Update()
        'End If
        'r0.Close() : r0 = Nothing
    End Sub
    '******************************************************
    '* コンボボックスにItemを追加する。
    '******************************************************
    Private Sub Add_Cmb00()
        Dim SQL As String
        Dim ComboItemA As New ArrayList()

        CmbNen.DropDownStyle = ComboBoxStyle.DropDownList
        CmbNen.BeginUpdate()
        SQL = "SELECT 年度 " _
            & "From MM_決算期 " _
            & "Where (会社No =" & pubComPany & ") " _
            & "GROUP BY 年度 " _
            & "ORDER BY 年度 DESC;"
        Dim r0 As dao.Recordset = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            Dim pCD As String = IIf(IsDBNull(r0.Fields("年度").Value), "", r0.Fields("年度").Value)
            Dim pName As String = IIf(IsDBNull(r0.Fields("年度").Value), "", Integer.Parse(r0.Fields("年度").Value))
            pName = pName & "年度"
            ComboItemA.Add(New MyComboBoxItemA(pName, pCD))
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
        CmbNen.DisplayMember = "ItemName"
        CmbNen.ValueMember = "ItemCode"
        CmbNen.DataSource = ComboItemA
        CmbNen.SelectedIndex = -1
        CmbNen.EndUpdate()
    End Sub
    '***************************************
    '* ﾘｽﾄにItemを追加する
    '***************************************
    Private Sub Add_Item()
        Dim SQL As String

        If Not IsNumeric(txt年度.Text) Then
            Exit Sub
        End If

        Dim pMM0 As String = "00"
        If IsNumeric(txt締No.Text) Then
            pMM0 = Integer.Parse(txt締No.Text).ToString("00")
        End If
        SQL = "SELECT * " _
            & "From MM_決算期 " _
            & "Where (会社No =" & pubComPany & ") " _
            & "And (年度 =" & txt年度.Text & ") " _
            & "And (締No <=12) " _
            & "ORDER BY 締No;"
        Dim r0 As dao.Recordset = DB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
        Do Until r0.EOF
            Dim pMM1 As String = Integer.Parse(r0.Fields("締No").Value).ToString("00")
            Me.GroupBox1.Controls("btnUp" & pMM1).Text = IIf(IsDBNull(r0.Fields("締月").Value), "", Date.Parse(r0.Fields("締月").Value).ToString("MM月"))
            If pMM0 = pMM1 Then
                Me.GroupBox1.Controls("btnUp" & pMM1).BackColor = Color.SkyBlue
            Else
                Me.GroupBox1.Controls("btnUp" & pMM1).BackColor = Color.Transparent
            End If
            r0.MoveNext()
        Loop
        r0.Close() : r0 = Nothing
    End Sub
    '******************************************************
    '* 
    '******************************************************
    Public Sub Dsp_Init00()
        Dim r0 As dao.Recordset = DB.OpenRecordset("MM_SYS", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"
        r0.Seek("=", pubComPany, pubLogInName, txtID.Text)
        If r0.NoMatch Then
        Else
            txt年度.Text = MyCom.ChgNull(r0.Fields("年度").Value, 1)
            txt締No.Text = MyCom.ChgNull(r0.Fields("締No").Value, 1)
        End If
        r0.Close() : r0 = Nothing
        CmbNen.SelectedValue = txt年度.Text
    End Sub
    Private Sub F_Co_SyoID00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 122
                btnEnd.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_Co_SyoID00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtID.Text = pubID
        Add_Cmb00()
        Dsp_Init00()
        Add_Item()
        AddHandler CmbNen.SelectedIndexChanged, AddressOf Cmb_SelectedIndexChanged
    End Sub
    Private Sub txtInp00_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.BackColor = Color.MistyRose
    End Sub

    Private Sub txtInp00_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case e.KeyChar
            Case Chr(Keys.Enter)
                Me.SelectNextControl(sender, True, True, True, True)
                e.Handled = True
        End Select
    End Sub

    Private Sub txtInp00_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.BackColor = Color.White
    End Sub

    Private Sub btnUp01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp01.Click
        txt締No.Text = 1
        Add_Item()
    End Sub

    Private Sub btnUp02_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp02.Click
        txt締No.Text = 2
        Add_Item()
    End Sub

    Private Sub btnUp03_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp03.Click
        txt締No.Text = 3
        Add_Item()
    End Sub

    Private Sub btnUp04_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp04.Click
        txt締No.Text = 4
        Add_Item()
    End Sub

    Private Sub btnUp05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp05.Click
        txt締No.Text = 5
        Add_Item()
    End Sub

    Private Sub btnUp06_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp06.Click
        txt締No.Text = 6
        Add_Item()
    End Sub

    Private Sub btnUp07_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp07.Click
        txt締No.Text = 7
        Add_Item()
    End Sub

    Private Sub btnUp08_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp08.Click
        txt締No.Text = 8
        Add_Item()
    End Sub

    Private Sub btnUp09_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp09.Click
        txt締No.Text = 9
        Add_Item()
    End Sub

    Private Sub btnUp10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp10.Click
        txt締No.Text = 10
        Add_Item()
    End Sub

    Private Sub btnUp11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp11.Click
        txt締No.Text = 11
        Add_Item()
    End Sub

    Private Sub btnUp12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp12.Click
        txt締No.Text = 12
        Add_Item()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Data_Put00()
        pubPARM(0) = "1"
        Me.Close()
    End Sub
    Private Sub Cmb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim item As MyComboBoxItemA

        txt締No.Text = ""
        If CmbNen.SelectedIndex = -1 Then
            txt年度.Text = ""
        Else
            item = DirectCast(CmbNen.SelectedItem, MyComboBoxItemA)
            txt年度.Text = item.ItemCode
            Add_Item()
        End If
    End Sub
End Class