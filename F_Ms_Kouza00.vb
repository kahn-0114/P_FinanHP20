Imports System.Data.SqlClient
Imports dao
Public Class s
    Dim pFocus(10) As Object
    Dim SQLCmd As New SqlCommand()
    Dim pDateFormat As String = "yyyy/MM/dd"
    Dim PubCom As New Com

    Private Sub F_Ms_Comp00_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SQLCmd.Dispose() : SQLCmd = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub F_Ms_Comp00_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 120
                Cmd09.PerformClick() : e.Handled = True
            Case 122
                Cmd11.PerformClick() : e.Handled = True
        End Select
    End Sub

    Private Sub F_Ms_Comp00_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SQLCmd = Cn00.CreateCommand()
        Inp_Clr00()
        Add_Cmb()
        Dsp_Init00()
        Me.ActiveControl = txt会社No
    End Sub
    '******************************************************
    '* ComboBoxにItemを追加
    '******************************************************
    Private Sub Add_Cmb()
        Dim SQL As String
        Dim ComboItemA As New ArrayList()
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        SQL = "SELECT * " _
            & "FROM MM_会社00 " _
            & "ORDER BY 会社No"
        SQLCmd.CommandText = SQL
        da0.SelectCommand = SQLCmd
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            For i As Integer = 0 To .Rows.Count - 1
                Dim wCD As String = PubCom.ChgNull(.Rows(i)("会社No"), 0)
                Dim wName As String = PubCom.ChgNull(.Rows(i)("会社名"), 1)
                ComboItemA.Add(New MyComboBoxItemA(wName, wCD))
            Next
        End With
        dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing

        CmbComp.DisplayMember = "ItemName"
        CmbComp.ValueMember = "ItemCode"
        CmbComp.DataSource = ComboItemA
        CmbComp.SelectedIndex = -1
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
        For Each CtrlItem As Control In Me.GroupBox11.Controls
            If TypeOf CtrlItem Is TextBox Then CtrlItem.Text = ""
        Next
        txtMsg.Text = "" : txtMsg.Visible = False
        CmbComp.SelectedIndex = -1
        'Pic会社Logo.Image = Nothing
        'Pic印鑑.Image = Nothing
        '
        GroupBox00.Enabled = True
        LV.Items.Clear()
    End Sub
    '******************************************************
    '* MM_会社00取得
    '******************************************************
    Public Sub Data_Get00()
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        Dim SQL As String

        SQL = "SELECT * " _
            & "From MM_会社00 " _
            & "WHERE (会社No =" & txt会社No.Text & ")"
        SQLCmd.CommandText = SQL
        da0.SelectCommand = SQLCmd
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            If .Rows.Count > 0 Then
                txt会社名.Text = PubCom.ChgNull(.Rows(0)("会社名"), 1)
                txt会社Kana名.Text = PubCom.ChgNull(.Rows(0)("会社名Kana"), 1)

                txt郵便番号.Text = PubCom.ChgNull(.Rows(0)("郵便番号1"), 1)
                txt郵便番号2.Text = PubCom.ChgNull(.Rows(0)("郵便番号2"), 1)
                txt住所.Text = PubCom.ChgNull(.Rows(0)("住所1"), 1)
                txt住所2.Text = PubCom.ChgNull(.Rows(0)("住所2"), 1)
                txt電話番号.Text = PubCom.ChgNull(.Rows(0)("電話番号"), 1)
                txtFAX番号.Text = PubCom.ChgNull(.Rows(0)("FAX番号"), 1)
                txt代表役職.Text = PubCom.ChgNull(.Rows(0)("代表者役職"), 1)
                txt代表者名.Text = PubCom.ChgNull(.Rows(0)("代表者名"), 1)
                txt決算月.Text = PubCom.ChgNull(.Rows(0)("決算月"), 1)
                txt決算日.Text = PubCom.ChgNull(.Rows(0)("決算日"), 1)
                txt端数計算区分.Text = PubCom.ChgNull(.Rows(0)("端数計算区分"), 1)
                txt消費税実施日.Text = PubCom.GetGengo(.Rows(0)("消費税実施日"), "yyyy/MM/dd")
                txt消費税率.Text = PubCom.ChgNull(.Rows(0)("消費税率"), 1)
                txt旧消費税率.Text = PubCom.ChgNull(.Rows(0)("旧消費税率"), 1)
                txt消費税区分.Text = PubCom.ChgNull(.Rows(0)("消費税区分"), 1)
                txt消費税計算.Text = PubCom.ChgNull(.Rows(0)("消費税計算区分"), 1)
                txt消費税端数.Text = PubCom.ChgNull(.Rows(0)("消費税端数区分"), 1)
                txt会社Logo.Text = PubCom.ChgNull(.Rows(0)("会社LogoPass"), 1)
                If IsDBNull(.Rows(0)("会社Logo")) Then
                    Pic会社Logo.Image = Nothing
                Else
                    Dim imgconv As New ImageConverter()
                    Dim img As Image = CType(imgconv.ConvertFrom(.Rows(0)("会社Logo")), Image)
                    Pic会社Logo.Image = img
                End If

                txt印鑑Image.Text = PubCom.ChgNull(.Rows(0)("印鑑Pass"), 1)
                If IsDBNull(.Rows(0)("印鑑Image")) Then
                    Pic印鑑.Image = Nothing
                Else
                    Dim imgconv As New ImageConverter()
                    Dim img As Image = CType(imgconv.ConvertFrom(.Rows(0)("印鑑Image")), Image)
                    Pic印鑑.Image = img
                End If

                For Each CtrlItem As Control In Me.GroupBox00.Controls
                    If TypeOf CtrlItem Is TextBox Then
                        Dim pRet As Boolean = Inp_Chk00(CtrlItem)
                        If pRet = False Then Exit Sub
                    End If
                Next
            End If
        End With
        dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing

    End Sub
    '******************************************************
    '* データの取得
    '******************************************************
    Public Sub Data_Put00()
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        Dim SQL As String

        SQL = "SELECT * " _
            & "FROM MM_会社00 " _
            & "WHERE (会社No=" & txt会社No.Text & ")"
        SQLCmd.CommandText = SQL
        da0.SelectCommand = SQLCmd
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            If .Rows.Count = 0 Then
                Data_Put00S0()
            Else
                Data_Put00S1()
            End If
        End With
        dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
    End Sub
    '******************************************************
    '* MM_会社00追加
    '******************************************************
    Public Sub Data_Put00S0()
        Dim SQL As String
        SQL = "INSERT INTO " & SQLDB & ".[dbo].[MM_会社00] (" _
            & "会社No,会社名,会社名Kana,郵便番号,郵便番号1,郵便番号2,住所1,住所2,電話番号,FAX番号,代表者名,代表者役職,決算月,決算日,決算基準," _
            & "端数計算区分,消費税実施日,消費税率,旧消費税率,消費税区分,消費税計算区分,消費税端数区分,会社Logo,会社LogoPass,印鑑Image,印鑑Pass," _
            & "在庫評価法,在庫端数処理,得意先CD,得意先枝CD,仕入先CD,仕入先枝CD,商品CD,商品枝CD,工事CD,工事枝CD,部門CD,科目CD,科目枝CD,財務部門CD) "
        SQL = SQL & "VALUES (@会社No,@会社名,@会社名Kana,@郵便番号,@郵便番号1,@郵便番号2,@住所1,@住所2,@電話番号,@FAX番号,@代表者名,@代表者役職,@決算月,@決算日,@決算基準," _
            & "@端数計算区分,@消費税実施日,@消費税率,@旧消費税率,@消費税区分,@消費税計算区分,@消費税端数区分,@会社Logo,@会社LogoPass,@印鑑Image,@印鑑Pass," _
            & "@在庫評価法,@在庫端数処理,@得意先CD,@得意先枝CD,@仕入先CD,@仕入先枝CD,@商品CD,@商品枝CD,@工事CD,@工事枝CD,@部門CD,@科目CD,@科目枝CD,@財務部門CD)"
        Dim command As SqlCommand = New SqlCommand(SQL, Cn00)
        command.Parameters.Clear()
        command.Parameters.Add("@会社No", SqlDbType.Int).Value = txt会社No.Text
        command.Parameters.Add("@会社名", SqlDbType.NVarChar).Value = txt会社名.Text
        command.Parameters.Add("@会社名Kana", SqlDbType.NVarChar).Value = txt会社Kana名.Text
        command.Parameters.Add("@郵便番号", SqlDbType.NVarChar).Value = txt郵便番号.Text & "-" & txt郵便番号2.Text
        command.Parameters.Add("@郵便番号1", SqlDbType.NVarChar).Value = txt郵便番号.Text
        command.Parameters.Add("@郵便番号2", SqlDbType.NVarChar).Value = txt郵便番号2.Text
        command.Parameters.Add("@住所1", SqlDbType.NVarChar).Value = txt住所.Text
        command.Parameters.Add("@住所2", SqlDbType.NVarChar).Value = txt住所2.Text
        command.Parameters.Add("@電話番号", SqlDbType.NVarChar).Value = txt電話番号.Text
        command.Parameters.Add("@FAX番号", SqlDbType.NVarChar).Value = txtFAX番号.Text
        command.Parameters.Add("@代表者名", SqlDbType.NVarChar).Value = txt代表者名.Text
        command.Parameters.Add("@代表者役職", SqlDbType.NVarChar).Value = txt代表役職.Text
        command.Parameters.Add("@決算月", SqlDbType.Int).Value = IIf(IsNumeric(txt決算月.Text), txt決算月.Text, DBNull.Value)
        command.Parameters.Add("@決算日", SqlDbType.Int).Value = IIf(IsNumeric(txt決算日.Text), txt決算日.Text, DBNull.Value)
        command.Parameters.Add("@決算基準", SqlDbType.TinyInt).Value = 1

        command.Parameters.Add("@端数計算区分", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt端数計算区分.Text), txt端数計算区分.Text, DBNull.Value)
        command.Parameters.Add("@消費税実施日", SqlDbType.Int).Value = DBNull.Value
        If IsDate(txt消費税実施日.Text) Then
            command.Parameters("@消費税実施日").Value = Date.Parse(txt消費税実施日.Text).ToString("yyyyMMdd")
        End If
        command.Parameters.Add("@消費税率", SqlDbType.Decimal).Value = IIf(IsNumeric(txt消費税率.Text), txt消費税率.Text, 0)
        command.Parameters.Add("@旧消費税率", SqlDbType.Decimal).Value = IIf(IsNumeric(txt旧消費税率.Text), txt旧消費税率.Text, 0)
        command.Parameters.Add("@消費税区分", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt消費税区分.Text), txt消費税区分.Text, DBNull.Value)
        command.Parameters.Add("@消費税計算区分", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt消費税計算.Text), txt消費税計算.Text, DBNull.Value)
        command.Parameters.Add("@消費税端数区分", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt消費税端数.Text), txt消費税端数.Text, DBNull.Value)
        command.Parameters.Add("@会社Logo", SqlDbType.VarBinary).Value = DBNull.Value
        If Pic会社Logo.Image Is Nothing Then
        Else
            Dim ImgByte As Byte()
            Using ms As New IO.MemoryStream
                Pic会社Logo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                ImgByte = ms.GetBuffer()
            End Using
            command.Parameters("@会社Logo").Value = ImgByte
        End If
        command.Parameters.Add("@会社LogoPass", SqlDbType.NVarChar).Value = txt会社Logo.Text
        command.Parameters.Add("@印鑑Image", SqlDbType.VarBinary).Value = DBNull.Value
        If Pic印鑑.Image Is Nothing Then
        Else
            Dim ImgByte As Byte()
            Using ms As New IO.MemoryStream
                Pic印鑑.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                ImgByte = ms.GetBuffer()
            End Using
            command.Parameters("@印鑑Image").Value = ImgByte
        End If
        command.Parameters.Add("@印鑑Pass", SqlDbType.NVarChar).Value = txt印鑑Image.Text

        command.Parameters.Add("@在庫評価法", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@在庫端数処理", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@得意先CD", SqlDbType.TinyInt).Value = 5
        command.Parameters.Add("@得意先枝CD", SqlDbType.TinyInt).Value = 3
        command.Parameters.Add("@仕入先CD", SqlDbType.TinyInt).Value = 5
        command.Parameters.Add("@仕入先枝CD", SqlDbType.TinyInt).Value = 3
        command.Parameters.Add("@商品CD", SqlDbType.TinyInt).Value = 5
        command.Parameters.Add("@商品枝CD", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@工事CD", SqlDbType.TinyInt).Value = 7
        command.Parameters.Add("@工事枝CD", SqlDbType.TinyInt).Value = 0
        command.Parameters.Add("@部門CD", SqlDbType.TinyInt).Value = 4
        command.Parameters.Add("@科目CD", SqlDbType.TinyInt).Value = 4
        command.Parameters.Add("@科目枝CD", SqlDbType.TinyInt).Value = 4
        command.Parameters.Add("@財務部門CD", SqlDbType.TinyInt).Value = 4
        Dim wRet As Integer = command.ExecuteNonQuery()
        command.Dispose()

    End Sub
    ''******************************************************
    ''* MM_会社00更新
    ''******************************************************
    'Public Sub Data_Put00S1()
    '    Dim SQL As String
    '    SQL = "UPDATE MM_会社00 SET "
    '    SQL = SQL & "会社名= @会社名"
    '    SQL = SQL & ",会社名Kana= @会社名Kana"
    '    SQL = SQL & ",郵便番号= @郵便番号"
    '    SQL = SQL & ",郵便番号1= @郵便番号1"
    '    SQL = SQL & ",郵便番号2= @郵便番号2"
    '    SQL = SQL & ",住所1= @住所1"
    '    SQL = SQL & ",住所2= @住所2"
    '    SQL = SQL & ",電話番号= @電話番号"
    '    SQL = SQL & ",FAX番号= @FAX番号"
    '    SQL = SQL & ",代表者名= @代表者名"
    '    SQL = SQL & ",代表者役職= @代表者役職"
    '    SQL = SQL & ",決算月= @決算月"
    '    SQL = SQL & ",決算日= @決算日"
    '    SQL = SQL & ",端数計算区分= @端数計算区分"
    '    SQL = SQL & ",消費税実施日= @消費税実施日"
    '    SQL = SQL & ",消費税率= @消費税率"
    '    SQL = SQL & ",旧消費税率= @旧消費税率"
    '    SQL = SQL & ",消費税区分= @消費税区分"
    '    SQL = SQL & ",消費税計算区分= @消費税計算区分"
    '    SQL = SQL & ",消費税端数区分= @消費税端数区分"
    '    SQL = SQL & ",会社Logo= @会社Logo"
    '    SQL = SQL & ",会社LogoPass= @会社LogoPass"
    '    SQL = SQL & ",印鑑Image= @印鑑Image"
    '    SQL = SQL & ",印鑑Pass= @印鑑Pass"
    '    SQL = SQL & " WHERE (会社No=" & txt会社No.Text & ")"
    '    Dim command As SqlCommand = New SqlCommand(SQL, Cn00)
    '    command.Parameters.Clear()

    '    command.Parameters.Add("@会社名", SqlDbType.NVarChar).Value = txt会社名.Text
    '    command.Parameters.Add("@会社名Kana", SqlDbType.NVarChar).Value = txt会社Kana名.Text
    '    command.Parameters.Add("@郵便番号", SqlDbType.NVarChar).Value = txt郵便番号.Text & "-" & txt郵便番号2.Text
    '    command.Parameters.Add("@郵便番号1", SqlDbType.NVarChar).Value = txt郵便番号.Text
    '    command.Parameters.Add("@郵便番号2", SqlDbType.NVarChar).Value = txt郵便番号2.Text
    '    command.Parameters.Add("@住所1", SqlDbType.NVarChar).Value = txt住所.Text
    '    command.Parameters.Add("@住所2", SqlDbType.NVarChar).Value = txt住所2.Text
    '    command.Parameters.Add("@電話番号", SqlDbType.NVarChar).Value = txt電話番号.Text
    '    command.Parameters.Add("@FAX番号", SqlDbType.NVarChar).Value = txtFAX番号.Text
    '    command.Parameters.Add("@代表者名", SqlDbType.NVarChar).Value = DBNull.Value
    '    command.Parameters.Add("@代表者役職", SqlDbType.NVarChar).Value = DBNull.Value
    '    command.Parameters.Add("@決算月", SqlDbType.Int).Value = IIf(IsNumeric(txt決算月.Text), txt決算月.Text, DBNull.Value)
    '    command.Parameters.Add("@決算日", SqlDbType.Int).Value = IIf(IsNumeric(txt決算日.Text), txt決算日.Text, DBNull.Value)

    '    command.Parameters.Add("@端数計算区分", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt端数計算区分.Text), txt端数計算区分.Text, DBNull.Value)
    '    command.Parameters.Add("@消費税実施日", SqlDbType.Int).Value = DBNull.Value
    '    If IsDate(txt消費税実施日.Text) Then
    '        command.Parameters("@消費税実施日").Value = Date.Parse(txt消費税実施日.Text).ToString("yyyyMMdd")
    '    End If
    '    command.Parameters.Add("@消費税率", SqlDbType.Decimal).Value = IIf(IsNumeric(txt消費税率.Text), txt消費税率.Text, 0)
    '    command.Parameters.Add("@旧消費税率", SqlDbType.Decimal).Value = IIf(IsNumeric(txt旧消費税率.Text), txt旧消費税率.Text, 0)
    '    command.Parameters.Add("@消費税区分", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt消費税区分.Text), txt消費税区分.Text, DBNull.Value)
    '    command.Parameters.Add("@消費税計算区分", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt消費税計算.Text), txt消費税計算.Text, DBNull.Value)
    '    command.Parameters.Add("@消費税端数区分", SqlDbType.TinyInt).Value = IIf(IsNumeric(txt消費税端数.Text), txt消費税端数.Text, DBNull.Value)
    '    command.Parameters.Add("@会社Logo", SqlDbType.VarBinary).Value = DBNull.Value
    '    If Pic会社Logo.Image Is Nothing Then
    '    Else
    '        Dim ImgByte As Byte()
    '        Using ms As New IO.MemoryStream
    '            Pic会社Logo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
    '            ImgByte = ms.GetBuffer()
    '        End Using
    '        command.Parameters("@会社Logo").Value = ImgByte
    '    End If
    '    command.Parameters.Add("@会社LogoPass", SqlDbType.NVarChar).Value = txt会社Logo.Text
    '    command.Parameters.Add("@印鑑Image", SqlDbType.VarBinary).Value = DBNull.Value
    '    If Pic印鑑.Image Is Nothing Then
    '    Else
    '        Dim ImgByte As Byte()
    '        Using ms As New IO.MemoryStream
    '            Pic印鑑.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
    '            ImgByte = ms.GetBuffer()
    '        End Using
    '        command.Parameters("@印鑑Image").Value = ImgByte
    '    End If
    '    command.Parameters.Add("@印鑑Pass", SqlDbType.NVarChar).Value = txt印鑑Image.Text
    '    Dim wRet As Integer = command.ExecuteNonQuery()
    '    command.Dispose()

    'End Sub

    '******************************************************
    '* データの取得
    '******************************************************
    Public Sub Data_Del00()
        Dim SQL As String
        SQL = "DELETE FROM MM_会社00 " _
            & "WHERE (会社No =" & txt会社No.Text & ")"
        Dim command As SqlCommand = New SqlCommand(SQL, Cn00)
        command.ExecuteNonQuery()
        command.Dispose() : command = Nothing
    End Sub

    '******************************************************
    '* 入力項目ﾁｪｯｸ
    '******************************************************
    Private Function Inp_Chk00(ByVal ctxtInp As Control)
        Inp_Chk00 = True
        txtMsg.Visible = False : txtMsg.Text = ""
        Select Case ctxtInp.Name
          
            Case "txt会社名"
                ctxtInp.BackColor = Color.White
                If txt会社名.Text = "" Then
                    txtMsg.Text = "会社名未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                Else
                    Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txt会社名.Text)
                    If LenB > 50 Then
                        txtMsg.Text = "会社名超過:50"
                        Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                    End If
                End If
            Case "txt口座名Kana"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txt口座名Kana.Text)
                If LenB > 40 Then
                    txtMsg.Text = "会社名かな超過:40"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt住所1"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txt住所.Text)
                If LenB > 100 Then
                    txtMsg.Text = "住所超過1:100"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt住所2"
                ctxtInp.BackColor = Color.White
                If txt住所2.Text = "" Then
                Else
                    Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txt住所2.Text)
                    If LenB > 100 Then
                        txtMsg.Text = "住所超過2:100"
                        Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                    End If
                End If
            Case "txt代表役職"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txt代表役職.Text)
                If LenB > 30 Then
                    txtMsg.Text = "代表役職超過:30"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt代表者名"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txt代表者名.Text)
                If LenB > 30 Then
                    txtMsg.Text = "代表者名超過:30"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt決算月"
                ctxtInp.BackColor = Color.White
                If txt決算月.Text = "" Then Exit Function

                If Not IsNumeric(txt決算月.Text) Then
                    txtMsg.Text = "決算月不正"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

                Dim wTmp10 As Byte = Byte.Parse(txt決算月.Text)
                If wTmp10 < 1 Or wTmp10 > 12 Then
                    txtMsg.Text = "決算月不正"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt決算日"
                ctxtInp.BackColor = Color.White
                If txt決算日.Text = "" Then Exit Function

                If Not IsNumeric(txt決算日.Text) Then
                    txtMsg.Text = "決算日不正"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If

                Dim wTmp10 As Byte = Byte.Parse(txt決算日.Text)
                If wTmp10 < 1 Or wTmp10 > 31 Then
                    txtMsg.Text = "決算日不正"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt端数計算区分"
                'txt端数計算名.Text = ""
                'If txt端数計算区分.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wKu As String = "3"
                'Dim wCode As String = ctxtInp.Text
                'Dim wRes As Byte = Mst.区分M00(wKu, wCode, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "端数計算区分不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt端数計算名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("名称"), 1)
                'End If
                'dt0.Tables("m0").Clear()
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt消費税実施日"
                ctxtInp.BackColor = Color.White
                If txt消費税実施日.Text = "" Then Exit Function

                If IsDate(txt消費税実施日.Text) Then
                    txt消費税実施日.Text = Date.Parse(txt消費税実施日.Text).ToString("yyyy/MM/dd")
                    Exit Function
                End If

                Dim w日付 As String = ""
                Dim wResult = PubCom.DateChk00(txt消費税実施日.Text, w日付)
                If wResult = 1 Then
                    txtMsg.Text = "消費税実施日不正"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                Else
                    txt消費税実施日.Text = w日付
                End If
                Exit Function
            Case "txt消費税区分"
                'ctxtInp.BackColor = Color.White
                'txt消費税区分名.Text = ""
                'If txt消費税区分.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wKu As String = "1"
                'Dim wCode As String = ctxtInp.Text
                'Dim wRes As Byte = Mst.区分M00(wKu, wCode, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "消費税計算区分不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt消費税区分名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("名称"), 1)
                'End If
                'dt0.Tables("m0").Clear()
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt消費税計算"
                'txt消費税計算名.Text = ""
                'If txt消費税計算.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wKu As String = "6"
                'Dim wCode As String = ctxtInp.Text
                'Dim wRes As Byte = Mst.区分M00(wKu, wCode, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "消費税計算区分不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt消費税計算名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("名称"), 1)
                'End If
                'dt0.Tables("m0").Clear()
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
            Case "txt消費税端数"
                'ctxtInp.BackColor = Color.White
                'txt消費税端数名.Text = ""
                'If txt消費税端数.Text = "" Then Exit Function

                'Dim da0 As New SqlDataAdapter, dt0 As New DataSet
                'Dim wKu As String = "3"
                'Dim wCode As String = ctxtInp.Text
                'Dim wRes As Byte = Mst.区分M00(wKu, wCode, SQLCmd, da0, dt0)
                'If wRes = 9 Then
                '    txtMsg.Text = "消費税計算区分不正入力"
                '    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral
                'Else
                '    txt消費税計算名.Text = Com.ChgNull(dt0.Tables("m0").Rows(0)("名称"), 1)
                'End If
                'dt0.Tables("m0").Clear()
                'dt0.Dispose() : dt0 = Nothing : da0.Dispose() : da0 = Nothing
                'Exit Function
        End Select
    End Function

    '******************************************************
    '* 会社情報取得
    '******************************************************
    Private Sub btnOK00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pRet As Boolean = Inp_Chk00(txt会社No)
        If pRet = False Then Exit Sub
        Data_Get00()
        txt会社名.Focus()
        GroupBox00.Enabled = False
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
    Private Sub txtInp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then Exit Sub
        pTxtBox.SelectAll()
        pTxtBox.BackColor = Color.MistyRose
        txtModified.Text = ""
        Select Case pTxtBox.Name
            Case "txt会社No"
                AddHandler txt会社No.TextChanged, AddressOf txtModified_TextChanged
        End Select
        pFocus(0) = pTxtBox
    End Sub
    Private Sub txtInp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)
        If pTxtBox.ReadOnly = True Then
            Me.SelectNextControl(sender, True, True, True, True)
            Exit Sub
        End If

        Select Case pTxtBox.Name
            Case Else
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


    Private Sub txtInp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim pTxtBox As TextBox = CType(sender, TextBox)

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
            Case "txt会社No"
                If txtModified.Text = "1" Then
                    btnOK00.PerformClick()
                    RemoveHandler pTxtBox.TextChanged, AddressOf txtModified_TextChanged
                End If
        End Select
        txtModified.Text = "" : pTxtBox.BackColor = Color.White
    End Sub

    Private Sub txtModified_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtModified.Text = "1"
    End Sub

    'Private Sub Cmd09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd09.Click
    '    Dim strName As String = pFocus(0).Name
    '    Select Case strName
    '        Case "txt端数計算区分"
    '            La端数区分_Click(sender, e)
    '        Case "txt消費税区分"
    '            La消費税区分_Click(sender, e)
    '        Case "txt消費税計算"
    '            La消費税計算_Click(sender, e)
    '        Case "txt消費税端数"
    '            La消費税端数_Click(sender, e)
    '    End Select
    '    Me.ActiveControl = pFocus(0)
    'End Sub

    Private Sub Cmd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd11.Click
        Me.Close()
    End Sub

    Private Sub Cmd04_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd04.Click
        Dim pRet As Boolean = Inp_Chk00(txt会社No)
        If pRet = False Then Exit Sub

        If MsgBox("該当データを削除します。確認してください。", vbOKCancel) = vbCancel Then Exit Sub
        Data_Del00()
        Inp_Clr00()
        txt会社No.Focus()
    End Sub

    'Private Sub btnOK10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim dialog As New OpenFileDialog

    '    dialog.InitialDirectory = Application.StartupPath
    '    dialog.Filter = "すべてのファイル(*.*)|*.*"
    '    dialog.FilterIndex = 0
    '    dialog.RestoreDirectory = True
    '    dialog.CheckFileExists = False
    '    dialog.CheckPathExists = True

    '    If dialog.ShowDialog() = DialogResult.OK Then
    '        Try
    '            Pic会社Logo.Image = Nothing
    '            Pic会社Logo.Image = System.Drawing.Image.FromFile(dialog.FileName)
    '            txt会社Logo.Text = dialog.FileName
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub

    'Private Sub btnOK20_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim dialog As New OpenFileDialog

    '    dialog.InitialDirectory = Application.StartupPath
    '    dialog.Filter = "すべてのファイル(*.*)|*.*"
    '    dialog.FilterIndex = 0
    '    dialog.RestoreDirectory = True
    '    dialog.CheckFileExists = False
    '    dialog.CheckPathExists = True

    '    If dialog.ShowDialog() = DialogResult.OK Then
    '        Try
    '            Pic印鑑.Image = Nothing
    '            Pic印鑑.Image = System.Drawing.Image.FromFile(dialog.FileName)
    '            txt印鑑Image.Text = dialog.FileName
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub

    Private Sub Cmd01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd01.Click
        Dim pRet As Boolean = Inp_Chk00(txt会社No)
        If pRet = False Then Exit Sub

        For Each CtrlItem As Control In Me.GroupBox00.Controls
            If TypeOf CtrlItem Is TextBox Then
                pRet = Inp_Chk00(CtrlItem)
                If pRet = False Then Exit Sub
            End If
        Next
        Data_Put00()
        Inp_Clr00()
        txt会社No.Focus()
    End Sub

    Private Sub CmbComp_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        Add_Cmb()
        AddHandler CmbComp.SelectedIndexChanged, AddressOf CmbComp_SelectedIndexChanged
    End Sub

    Private Sub CmbComp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim item As MyComboBoxItemA
        If CmbComp.SelectedIndex = -1 Then
            txt会社No.Text = ""
        Else
            item = DirectCast(CmbComp.SelectedItem, MyComboBoxItemA)
            txt会社No.Text = item.ItemCode
            pubComPany = Integer.Parse(txt会社No.Text)
            btnOK00.PerformClick()
        End If
    End Sub

    Private Sub CmbComp_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CmbComp.SelectedIndexChanged, AddressOf CmbComp_SelectedIndexChanged
    End Sub

    Private Sub MenuItem00_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem00.Click
        Dim frmForm = New F_Ms_Comp10
        frmForm.pubCD = txt会社No.Text
        frmForm.Show()
    End Sub

    Private Sub MenuItem01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem01.Click
        Dim frmForm = New F_Ms_Comp20
        frmForm.pubCD = txt会社No.Text
        frmForm.Show()
    End Sub

    Private Sub MenuItem02_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem02.Click
        Dim frmForm = New F_Ms_Comp30
        frmForm.pubCD = txt会社No.Text
        frmForm.Show()
    End Sub

    'Private Sub La端数区分_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim frmForm = New F_S_KuBunM00
    '    frmForm.pubKuCD = 3 : frmForm.pubCD = ""
    '    If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        If IsNumeric(frmForm.pubCD) Then
    '            txt端数計算区分.Text = Integer.Parse(frmForm.pubCD)
    '            Inp_Chk00(txt端数計算区分)
    '        End If
    '        txt端数計算区分.Focus()
    '    End If
    'End Sub

    'Private Sub La消費税区分_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmForm = New F_S_KuBunM00
    '    frmForm.pubKuCD = 1 : frmForm.pubCD = ""
    '    If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        If IsNumeric(frmForm.pubCD) Then
    '            txt消費税区分.Text = Integer.Parse(frmForm.pubCD)
    '            Inp_Chk00(txt消費税区分)
    '        End If
    '        txt消費税区分.Focus()
    '    End If
    'End Sub

    'Private Sub La消費税計算_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmForm = New F_S_KuBunM00
    '    frmForm.pubKuCD = 6 : frmForm.pubCD = ""
    '    If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        If IsNumeric(frmForm.pubCD) Then
    '            txt消費税計算.Text = Integer.Parse(frmForm.pubCD)
    '            Inp_Chk00(txt消費税計算)
    '        End If
    '        txt消費税計算.Focus()
    '    End If
    'End Sub

    'Private Sub La消費税端数_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmForm = New F_S_KuBunM00
    '    frmForm.pubKuCD = 3 : frmForm.pubCD = ""
    '    If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        If IsNumeric(frmForm.pubCD) Then
    '            txt消費税端数.Text = Integer.Parse(frmForm.pubCD)
    '            Inp_Chk00(txt消費税端数)
    '        End If
    '        txt消費税端数.Focus()
    '    End If
    'End Sub

    Private Sub Cmd05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd05.Click
        Inp_Clr00()
        txt会社No.Focus()
    End Sub



    '* ！のやつ　　　　　　　　 　 r10.Fields("").Value  = dt0.Fields("").Value 
    '*  iのやつ　　　　　　　　　  For i AS Integer 、　Next i　←　i省略可  
    '*  Formatのやつ               r10("" & i).Value = r0("" & i.ToString("00") & "0").Value
    '*  Closeのやつ　　　　　　　  r10.Close() : r10 = Nothing  
    '*  Null → DBNull.Value 　　　IsDBNull →　IsDBNull
    '*オフにしていい　Workspace　OpenConnection
    '*
    '*Dim r0 As dao.Recordset = ComDB.OpenRecordset("〇", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
    '*Dim r0 As dao.Recordset = ComDB.OpenRecordset("〇", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
    '*
    '*Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
    '*Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenDynaset, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
    '
    'Dim r0 As Recordset = DB.OpenRecordset(Sql, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
    'r0 = DB.OpenRecordset(Sql, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)

    '*
    '*Screen.MousePointer　→　Cursor.Current = Cursors.Default
    '*MsgBox(txtMsg)
    '*RepDB = OpenDatabase(pubRepDB, False)　→　RepDB = DaoEngine.OpenDatabase(pubRepDB)
    '*Currency →　Decimal
    '*r0.Fields("").Value  →   .Rows(i0)("")
    '*ｑ0のときだけr0.Fields("").Value  →   .Rows(i0)("")
    'Ceant→Integer.Parse
    'ChgNull    ってそのまま？
    '******************************************************
    '* 合計計算
    '******************************************************
    Public Function Dsp_Set00()
        'Dim i As Integer, SQL As String, TmpDT(3, 20) As Decimal, TmpGt(2) As Decimal

        'For i = 0 To 11
        '    If IsNumeric(txtInpE(i)) = True Then
        '        TmpDT(0, i) = CCur(txtInpE(i))
        '    Else
        '        TmpDT(0, i) = 0
        '    End If
        '    If IsNumeric(txtInpC(i)) = True Then
        '        TmpDT(1, i) = CCur(txtInpC(i))
        '    Else
        '        TmpDT(1, i) = 0
        '    End If
        '    If IsNumeric(txtInpD(i)) = True Then
        '        TmpDT(2, i) = CCur(txtInpD(i))
        '    Else
        '        TmpDT(2, i) = 0
        '    End If
        '    TmpDT(3, i) = TmpDT(0, i) - TmpDT(1, i) + TmpDT(2, i)
        '    txtOutC(i).Caption = Format(TmpDT(3, i), "#,##0")
        'Next i
        'TmpGt(0) = 0 : TmpGt(1) = 0 : TmpGt(2) = 0
        'For i = 0 To 11
        '    TmpGt(0) = TmpGt(1) + TmpDT(1, i)
        '    TmpGt(1) = TmpGt(2) + TmpDT(2, i)
        'Next i
        'txt払出合計.Text = Format(TmpGt(0), "#,##0")
        'txt預入合計.Text = Format(TmpGt(1), "#,##0")
        '    txtOutD(2).Caption = Format(TmpGt(2), "#,##0")
    End Function
    '******************************************************
    '* 残高抽出
    '******************************************************
    Public Function Dsp_Set10()
        Dim dt0 As QueryDef
        Dim m1 As Recordset
        Dim r0 As Recordset
        Dim r10 As Recordset
        Dim SQL As String, Tmp(10), i As Integer, Msg As String, pKin(2) As Decimal

        Dim m0 As dao.Recordset = ComDB.OpenRecordset("MM_決算期", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        m0.Index = "Key_0"
        m0.Seek("=", pubComPany, txt年度.Text, 1)
        If m0.NoMatch Then
        Else
            txt開始.Text = Format(m0.Fields("開始").Value, "yyyy/mm/dd")
            txt終了.Text = Format(m0.Fields("終了").Value, "yyyy/mm/dd")
        End If
        m0.Close() : m0 = Nothing

        On Error Resume Next

        'Set WrkSp = CreateWorkspace("", "", "", dbUseODBC)
        'Set dbsPubs = WrkSp.OpenConnection("", dbDriverNoPrompt, False, pubDsn)

        'Set dt0 = dbsPubs.CreateQueryDef("")
        'dt0.Prepare = dbQUnprepare

        txt決算期.Text = 1
        Tmp(0) = Format(txt開始.Text, "yyyymmdd")
        Tmp(1) = Format(txt終了.Text, "yyyymmdd")

        'If IsNumeric(Tmp(0)) And IsNumeric(Tmp(1)) Then
        '    SQL = "SELECT A_VOLUM2.KI " _
        '        & "From A_VOLUM2 " _
        '        & "WHERE (A_VOLUM2.SYMD Between " & Tmp(0) & " And " & Tmp(1) & ");"
        '    dt0.SQL = SQL
        '    Set r0 = dt0.OpenRecordset()
        '    If Not r0.EOF Then
        '        txt決算期.Text = IIf(IsDBNull(r0.Fields("KI").Value ), 1, r0.Fields("KI").Value )
        '    End If
        '    r0.Close: Set r0 = Nothing
        'End If

        'If IsNumeric(txt対応科目CD.Text) And IsNumeric(txt対応枝番CD.Text) Then
        '    SQL = "SELECT A_EDZAN.* " _
        '        & "From A_EDZAN " _
        '        & "WHERE (A_EDZAN.KI=" & txt決算期.Text & ") " _
        '        & "AND (A_EDZAN.KCOD=" & txt対応科目CD.Text & ") " _
        '        & "AND (A_EDZAN.ECOD=" & txt対応枝番CD.Text & ");"
        '    dt0.SQL = SQL
        '    Set r0 = dt0.OpenRecordset()
        '    If Not r0.EOF Then
        '        pKin(0) = r0.Fields("K000").Value 
        '        For i = 1 To 12
        '            pKin(1) = r0("R" & Format(i, "00") & "0")
        '            pKin(2) = r0("S" & Format(i, "00") & "0")
        '            pKin(0) = pKin(0) + pKin(1) - pKin(2)
        '            txtOutE(i - 1) = Format(pKin(0), "#,##0")
        '        Next i
        '    End If
        '    r0.Close: Set r0 = Nothing
        'End If

        'dt0.Close: Set dt0 = Nothing
        'dbsPubs.Close: Set dbsPubs = Nothing
        'WrkSp.Close: Set WrkSp = Nothing

        On Error GoTo 0

    End Function

    '******************************************************
    '* データの削除
    '******************************************************
    Public Function Data_Del00()
        Dim i As Integer
        Dim SQL As String

        Ret = Inp_Chk00(0, txtInpA.Count - 1)
        If Ret = False Then
            Exit Function
        End If

        If MsgBox("該当データを削除します。確認してください。", vbOKCancel) = vbCancel Then
            Exit Function
        End If

        If Not txt口座No.Text = "" Then
            Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_元受銀行", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
            r0.Index = "Key_0"
            r0.Seek("=", txt会社No.Text, txt口座No.Text)
            If r0.NoMatch Then
            Else
                r0.Delete()
            End If
            r0.Close() : r0 = Nothing

            SQL = "DELETE M_元受銀行CTL.* " _
            & "From M_元受銀行CTL " _
            & "WHERE (((M_元受銀行CTL.会社No)=" & pubComPany & ") " _
            & "AND ((M_元受銀行CTL.元受銀行No)=" & txt口座No.Text & "));"
            ComDB.Execute(SQL)

            r0 = DB.OpenRecordset("M_預金残高", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
            r0.Index = "Key_0"
            r0.Seek("=", txt会社No.Text, txt年度.Text, txt口座No.Text)
            If r0.NoMatch Then
            Else
                r0.Delete()
            End If
            r0.Close() : r0 = Nothing

            Call Add_Item()
            Call Inp_Clr00()
            txt銀行CD.SetFocus
        End If
    End Function
    '******************************************************
    '* データの登録
    '******************************************************
    Public Function Data_Put00()
        Dim i As Long
        Dim SQL As String, Tmp(10)

        If txt口座No.Text = "" Then
            txt会社No.Text = pubComPany
            i = Data_Get10()
            txt口座No.Text = i
        End If

        Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_元受銀行", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"
        r0.Seek("=", pubComPany, txt口座No.Text)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("会社No").Value = txt会社No.Text
            r0.Fields("元受銀行No").Value = txt口座No.Text
        Else
            r0.Edit()
        End If
        r0.Fields("銀行CD").Value = Format(txt銀行CD.Text, "0000")
        r0.Fields("支店CD").Value = Format(txt支店CD.Text, "000")
        r0.Fields("預金種別").Value = txt預金種別CD.Text
        r0.Fields("口座番号").Value = IIf(txt口座番号.Text = "", DBNull.Value, txt口座番号.Text)
        Tmp(0) = StrConv(txt口座名Kana.Text, vbNarrow)
        Tmp(0) = StrConv(Tmp(0), vbUpperCase)
        r0.Fields("口座番号").Value x = Tmp(0)
        r0.Fields("部門CD").Value = IIf(txt対応部門CD.Text = "", DBNull.Value, txt対応部門CD.Text)
        r0.Fields("科目CD").Value = IIf(txt対応科目CD.Text = "", DBNull.Value, txt対応科目CD.Text)
        r0.Fields("補助科目CD").Value = IIf(txt対応枝番CD.Text = "", DBNull.Value, txt対応枝番CD.Text)
        r0.Fields("振込区分").Value = 0
        r0.Fields("内部口座名").Value = txt口座名.Text
        r0.Fields("本社管轄F").Value = IIf(txt本社管轄名.Text = "", 0, txt本社管轄名.Text)
        r0.Fields("削除").Value = IIf(txt削除CD.Text = "", 0, txt削除CD.Text)
        r0.Fields("依頼銀行区分").Value = IIf(txt依頼銀行区分CD.Text = "", 0, txt依頼銀行区分CD.Text)
        r0.Update()
        r0.Close() : r0 = Nothing

    End Function
    '******************************************************
    '* データの登録
    '******************************************************
    Public Function Data_Put01()
        Dim r1 As Recordset
        Dim SQL As String, i As Integer

        Dim r0 As dao.Recordset = DB.OpenRecordset("M_預金残高", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"

        r0.Seek("=", txt会社No.Text, txt年度.Text, txt口座No.Text)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("会社No").Value = txt会社No.Text
            r0.Fields("年度").Value = txt年度.Text
            r0.Fields("元受銀行No").Value = txt口座No.Text
        Else
            r0.Edit()
        End If
        'r0.Fields("期首金額").Value  = 0
        'If IsNumeric(txtOutC(0)) = True Then
        '    r0.Fields("期首金額").Value  = txtOutC(0)
        'End If

        For i = 1 To 12
            If IsNumeric(txt払出.Text(i - 1)) = True Then
                r0("払出金額" & i) = txt払出.Text(i - 1)
            Else
                r0("払出金額" & i) = 0
            End If
            If IsNumeric(txtInpD(i - 1)) = True Then
                r0("預入金額" & i) = txt預入.Text(i - 1)
            Else
                r0("預入金額" & i) = 0
            End If
            If IsNumeric(txt初月金額.Text(i - 1)) = True Then
                r0("残高" & i) = txt初月金額.Text(i - 1)
            Else
                r0("残高" & i) = 0
            End If
        Next i
        r0.Update()

        r0.Close() : r0 = Nothing

    End Function

    '******************************************************
    '* データの取得
    '******************************************************
    Public Function Data_Get00()
        Dim r1 As Recordset
        Dim i As Integer

        Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_元受銀行", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_1"

        r0.Seek("=", txt銀行CD.Text, txt支店CD.Text, txt預金種別CD.Text, txt口座番号.Text)
        If r0.NoMatch Then
            Call Inp_Clr01
        Else
            txt口座No.Text = IIf(IsDBNull(r0.Fields("元受銀行No").Value), "", r0.Fields("元受銀行No").Value)
            txt会社No.Text = IIf(IsDBNull(r0.Fields("会社No").Value), "", r0.Fields("会社No").Value)

            txt対応部門CD.Text = IIf(IsDBNull(r0.Fields("部門CD").Value), "", r0.Fields("部門CD").Value)
            txt対応科目CD.Text = IIf(IsDBNull(r0.Fields("科目CD").Value), "", r0.Fields("科目CD").Value)
            txt対応枝番CD.Text = IIf(IsDBNull(r0.Fields("補助科目CD").Value), "", r0.Fields("補助科目CD").Value)
            txt口座名.Text = IIf(IsDBNull(r0.Fields("内部口座名").Value), "", r0.Fields("内部口座名").Value)
            txt口座名Kana.Text = IIf(IsDBNull(r0.Fields("口座名").Value), "", r0.Fields("口座名").Value)
            txt本社管轄名.Text = IIf(IsDBNull(r0.Fields("本社管轄F").Value), "", r0.Fields("本社管轄F").Value)
            txt削除CD.Text = IIf(IsDBNull(r0.Fields("削除").Value), "", r0.Fields("削除").Value)
            txt依頼銀行区分CD.Text = IIf(IsDBNull(r0.Fields("依頼銀行区分").Value), "", r0.Fields("依頼銀行区分").Value)
        End If
        r0.Close() : r0 = Nothing
    End Function
    '******************************************************
    '* データの取得
    '******************************************************
    Public Function Data_Get01()
        Dim i As Integer, Tmp(2)

        Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_預金残高", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"

        txt年度.Text = pubNNen
        r0.Seek("=", pubComPany, txt年度.Text, txt口座No.Text)
        If r0.NoMatch Then
        Else
            txt預入1.Text = IIf(IsDBNull(r0.Fields("期首金額").Value), 0, Format(r0.Fields("期首金額").Value, "#,##0"))
            For i = 1 To 12
                txtInpE(i - 1) = IIf(IsDBNull(r0("残高" & i)), 0, Format(r0("残高" & i), "#,##0"))
                txtInpC(i - 1) = IIf(IsDBNull(r0("払出金額" & i)), 0, Format(r0("払出金額" & i), "#,##0"))
                txtInpD(i - 1) = IIf(IsDBNull(r0("預入金額" & i)), 0, Format(r0("預入金額" & i), "#,##0"))
                Tmp(0) = IIf(IsDBNull(r0("残高" & i)), 0, Format(r0("残高" & i), "#,##0"))
                Tmp(0) = Tmp(0) + IIf(IsDBNull(r0("預入金額" & i)), 0, Format(r0("預入金額" & i), "#,##0"))
                Tmp(0) = Tmp(0) - IIf(IsDBNull(r0("払出金額" & i)), 0, Format(r0("払出金額" & i), "#,##0"))
                txtOutC(i - 1) = Format(Tmp(0), "#,##0")
            Next i
        End If

        r0.Close() : r0 = Nothing
    End Function
    '******************************************************
    '*
    '******************************************************
    Public Function Data_Get20()
        Dim i As Integer

        txt会社No.Text = pubComPany

        Dim r0 As dao.Recordset = ComDB.OpenRecordset("M_元受銀行", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"

        r0.Seek("=", pubComPany, txt口座No.Text)
        If r0.NoMatch Then
        Else
            txt銀行CD.Text = IIf(IsDBNull(r0.Fields("銀行CD").Value), "", r0.Fields("銀行CD").Value)
            txt支店CD.Text = IIf(IsDBNull(r0.Fields("支店CD").Value), "", r0.Fields("支店CD").Value)
            txt預金種別CD.Text = IIf(IsDBNull(r0.Fields("預金種別").Value), "", r0.Fields("預金種別").Value)
            txt口座番号.Text = IIf(IsDBNull(r0.Fields("口座番号").Value), "", r0.Fields("口座番号").Value)
        End If
        r0.Close() : r0 = Nothing
    End Function
    '******************************************************
    '* 銀行No 取得
    '******************************************************
    Public Function Data_Get10()
        Dim r0 As Recordset, r1 As Recordset
        Dim i As Integer

        Data_Get10 = 1
        Sql = "SELECT M_元受銀行.元受銀行No " _
            & "From M_元受銀行 " _
            & "Where (M_元受銀行.会社No =" & txt会社No.Text & ") " _
            & "ORDER BY M_元受銀行.元受銀行No DESC;"
        r0 =Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
    If Not r0.EOF Then
            Data_Get10 = IIf(IsDBNull(r0.Fields("元受銀行No").Value), 0, r0.Fields("元受銀行No").Value) + 1
        End If
        r0.Close() : r0 = Nothing
    End Function
    '******************************************************
    '* リストにItemを表示する共通関数
    '******************************************************
    Private Function Add_Item()
        Dim r0 As Recordset
        Dim itmX As ListItem
        Dim MaxNo As Long, i As Integer, Tmp(1)

        Dim m0 As dao.Recordset = ComDB.OpenRecordset("M_銀行", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        m0.Index = "Key_0"
        Dim m1 As dao.Recordset = ComDB.OpenRecordset("M_科目", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        m1.Index = "Key_0"
        Dim m2 As dao.Recordset = ComDB.OpenRecordset("M_科目枝番", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        m2.Index = "Key_0"

        LV.ListItems.Clear
        Sql = "SELECT M_元受銀行.* " _
            & "From M_元受銀行 " _
            & "WHERE (M_元受銀行.会社No=" & pubComPany & ") " _
            & "AND (M_元受銀行.削除=0) " _
            & "ORDER BY M_元受銀行.銀行CD,M_元受銀行.口座番号,M_元受銀行.元受銀行No;"
        r0 =Dim r0 As dao.Recordset = ComDB.OpenRecordset(SQL, dao.RecordsetTypeEnum.dbOpenForwardOnly, dao.RecordsetOptionEnum.dbReadOnly)
    Do Until r0.EOF
            'Itemの追加
            itmX = LV.ListItems.Add(, , r0.Fields("元受銀行No").Value)
            itmX.SubItems(1) = IIf(IsDBNull(r0.Fields("銀行CD").Value), " ", r0.Fields("銀行CD").Value)
            itmX.SubItems(3) = IIf(IsDBNull(r0.Fields("支店CD").Value), " ", r0.Fields("支店CD").Value)
            m0.Seek("=", r0.Fields("銀行CD").Value, r0.Fields("支店CD").Value)
            If m0.NoMatch Then
                itmX.SubItems(2) = ""
            Else
                itmX.SubItems(2) = IIf(IsDBNull(m0.Fields("銀行名").Value), " ", m0.Fields("銀行名").Value)
            End If
            itmX.SubItems(4) = IIf(IsDBNull(r0.Fields("預金種別").Value), " ", r0.Fields("預金種別").Value)
            itmX.SubItems(5) = IIf(IsDBNull(r0.Fields("口座番号").Value), " ", r0.Fields("口座番号").Value)
            itmX.SubItems(6) = IIf(IsDBNull(r0.Fields("内部口座名").Value), "", r0.Fields("内部口座名").Value)
            r0.MoveNext()
        Loop

        r0.Close() : r0 = Nothing
        m0.Close() : m0 = Nothing
        m1.Close() :    m1 = Nothing
        m2.Close() : m2 = Nothing
    End Function


End Class
