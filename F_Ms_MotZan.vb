Imports System.Data.SqlClient
Public Class F_Ms_MotZan
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
        Me.ActiveControl = txt決済1
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
        txtMsg.Text = "" : txtMsg.Visible = False
        CmbComp.SelectedIndex = -1
        Pic会社Logo.Image = Nothing
        Pic印鑑.Image = Nothing
        GroupBox00.Enabled = True
    End Sub
    '******************************************************
    '* MM_会社00取得
    '******************************************************
    Public Sub Data_Get00()
        Dim da0 As New SqlDataAdapter, dt0 As New DataSet
        Dim SQL As String

        SQL = "SELECT * " _
            & "From MM_会社00 " _
            & "WHERE (会社No =" & txt決済1.Text & ")"
        SQLCmd.CommandText = SQL
        da0.SelectCommand = SQLCmd
        da0.Fill(dt0, "t0")
        With dt0.Tables("t0")
            If .Rows.Count > 0 Then
                txt内訳印刷F1.Text = PubCom.ChgNull(.Rows(0)("会社名"), 1)
                txt内訳印刷F2.Text = PubCom.ChgNull(.Rows(0)("会社名Kana"), 1)

                txt郵便番号.Text = PubCom.ChgNull(.Rows(0)("郵便番号1"), 1)
                txt郵便番号2.Text = PubCom.ChgNull(.Rows(0)("郵便番号2"), 1)
                txt住所.Text = PubCom.ChgNull(.Rows(0)("住所1"), 1)
                txt住所2.Text = PubCom.ChgNull(.Rows(0)("住所2"), 1)
                txt電話番号.Text = PubCom.ChgNull(.Rows(0)("電話番号"), 1)
                txtFax番号.Text = PubCom.ChgNull(.Rows(0)("FAX番号"), 1)
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

                For Each CtrlItem As Control In Me.GroupBox10.Controls
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
            & "WHERE (会社No=" & txt決済1.Text & ")"
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
        command.Parameters.Add("@会社No", SqlDbType.Int).Value = txt決済1.Text
        command.Parameters.Add("@会社名", SqlDbType.NVarChar).Value = txt内訳印刷F1.Text
        command.Parameters.Add("@会社名Kana", SqlDbType.NVarChar).Value = txt内訳印刷F2.Text
        command.Parameters.Add("@郵便番号", SqlDbType.NVarChar).Value = txt郵便番号.Text & "-" & txt郵便番号2.Text
        command.Parameters.Add("@郵便番号1", SqlDbType.NVarChar).Value = txt郵便番号.Text
        command.Parameters.Add("@郵便番号2", SqlDbType.NVarChar).Value = txt郵便番号2.Text
        command.Parameters.Add("@住所1", SqlDbType.NVarChar).Value = txt住所.Text
        command.Parameters.Add("@住所2", SqlDbType.NVarChar).Value = txt住所2.Text
        command.Parameters.Add("@電話番号", SqlDbType.NVarChar).Value = txt電話番号.Text
        command.Parameters.Add("@FAX番号", SqlDbType.NVarChar).Value = txtFax番号.Text
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
    '******************************************************
    '* MM_会社00更新
    '******************************************************
    Public Sub Data_Put00S1()
        Dim SQL As String
        SQL = "UPDATE MM_会社00 SET "
        SQL = SQL & "会社名= @会社名"
        SQL = SQL & ",会社名Kana= @会社名Kana"
        SQL = SQL & ",郵便番号= @郵便番号"
        SQL = SQL & ",郵便番号1= @郵便番号1"
        SQL = SQL & ",郵便番号2= @郵便番号2"
        SQL = SQL & ",住所1= @住所1"
        SQL = SQL & ",住所2= @住所2"
        SQL = SQL & ",電話番号= @電話番号"
        SQL = SQL & ",FAX番号= @FAX番号"
        SQL = SQL & ",代表者名= @代表者名"
        SQL = SQL & ",代表者役職= @代表者役職"
        SQL = SQL & ",決算月= @決算月"
        SQL = SQL & ",決算日= @決算日"
        SQL = SQL & ",端数計算区分= @端数計算区分"
        SQL = SQL & ",消費税実施日= @消費税実施日"
        SQL = SQL & ",消費税率= @消費税率"
        SQL = SQL & ",旧消費税率= @旧消費税率"
        SQL = SQL & ",消費税区分= @消費税区分"
        SQL = SQL & ",消費税計算区分= @消費税計算区分"
        SQL = SQL & ",消費税端数区分= @消費税端数区分"
        SQL = SQL & ",会社Logo= @会社Logo"
        SQL = SQL & ",会社LogoPass= @会社LogoPass"
        SQL = SQL & ",印鑑Image= @印鑑Image"
        SQL = SQL & ",印鑑Pass= @印鑑Pass"
        SQL = SQL & " WHERE (会社No=" & txt決済1.Text & ")"
        Dim command As SqlCommand = New SqlCommand(SQL, Cn00)
        command.Parameters.Clear()

        command.Parameters.Add("@会社名", SqlDbType.NVarChar).Value = txt内訳印刷F1.Text
        command.Parameters.Add("@会社名Kana", SqlDbType.NVarChar).Value = txt内訳印刷F2.Text
        command.Parameters.Add("@郵便番号", SqlDbType.NVarChar).Value = txt郵便番号.Text & "-" & txt郵便番号2.Text
        command.Parameters.Add("@郵便番号1", SqlDbType.NVarChar).Value = txt郵便番号.Text
        command.Parameters.Add("@郵便番号2", SqlDbType.NVarChar).Value = txt郵便番号2.Text
        command.Parameters.Add("@住所1", SqlDbType.NVarChar).Value = txt住所.Text
        command.Parameters.Add("@住所2", SqlDbType.NVarChar).Value = txt住所2.Text
        command.Parameters.Add("@電話番号", SqlDbType.NVarChar).Value = txt電話番号.Text
        command.Parameters.Add("@FAX番号", SqlDbType.NVarChar).Value = txtFax番号.Text
        command.Parameters.Add("@代表者名", SqlDbType.NVarChar).Value = DBNull.Value
        command.Parameters.Add("@代表者役職", SqlDbType.NVarChar).Value = DBNull.Value
        command.Parameters.Add("@決算月", SqlDbType.Int).Value = IIf(IsNumeric(txt決算月.Text), txt決算月.Text, DBNull.Value)
        command.Parameters.Add("@決算日", SqlDbType.Int).Value = IIf(IsNumeric(txt決算日.Text), txt決算日.Text, DBNull.Value)

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
        Dim wRet As Integer = command.ExecuteNonQuery()
        command.Dispose()

    End Sub

    '******************************************************
    '* データの取得
    '******************************************************
    Public Sub Data_Del00()
        Dim SQL As String
        SQL = "DELETE FROM MM_会社00 " _
            & "WHERE (会社No =" & txt決済1.Text & ")"
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
            Case "txt会社No"
                If txt決済1.Text = "" Then
                    txtMsg.Text = "会社CD未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txt会社名"
                ctxtInp.BackColor = Color.White
                If txt内訳印刷F1.Text = "" Then
                    txtMsg.Text = "会社名未入力"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                Else
                    Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txt内訳印刷F1.Text)
                    If LenB > 50 Then
                        txtMsg.Text = "会社名超過:50"
                        Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                    End If
                End If
            Case "txt会社Kana名"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txt内訳印刷F2.Text)
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
            Case "txt電話番号"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txt電話番号.Text)
                If LenB > 15 Then
                    txtMsg.Text = "電話番号:15"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
                End If
            Case "txtFax番号"
                ctxtInp.BackColor = Color.White
                Dim LenB As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(txtFax番号.Text)
                If LenB > 15 Then
                    txtMsg.Text = "FAX番号:15"
                    Inp_Chk00 = False : txtMsg.Visible = True : ctxtInp.BackColor = Color.LightCoral : Exit Function
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
        Dim pRet As Boolean = Inp_Chk00(txt決済1)
        If pRet = False Then Exit Sub
        Data_Get00()
        txt内訳印刷F1.Focus()
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
        For Each CtrlItem As Control In Me.GroupBox10.Controls
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
                AddHandler txt決済1.TextChanged, AddressOf txtModified_TextChanged
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
            Case "txt会社No", "txt郵便番号1", "txt郵便番号2", "txt決算月", "txt決算日", "txt端数計算区分", "txt消費税区分", "txt消費税計算", "txt消費税端数"
                Select Case e.KeyChar
                    Case ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
                    Case Else
                        e.Handled = True
                End Select
            Case "txt消費税実施日" '/,0-9,M,m,T,t,S,s,H,h
                Select Case e.KeyChar
                    Case ChrW(45) To ChrW(57), ChrW(8), ChrW(13)
                    Case ChrW(72), ChrW(77), ChrW(82), ChrW(83), ChrW(84), ChrW(104), ChrW(109), ChrW(114), ChrW(115), ChrW(116)
                    Case Else
                        e.Handled = True
                End Select
            Case "txt消費税率", "txt旧消費税率"
                Select Case e.KeyChar
                    Case ChrW(46), ChrW(48) To ChrW(57), ChrW(8), ChrW(13)
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

    Private Sub Cmd09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd09.Click
        Dim strName As String = pFocus(0).Name
        Select Case strName
            Case "txt端数計算区分"
                La端数区分_Click(sender, e)
            Case "txt消費税区分"
                La消費税区分_Click(sender, e)
            Case "txt消費税計算"
                La消費税計算_Click(sender, e)
            Case "txt消費税端数"
                La消費税端数_Click(sender, e)
        End Select
        Me.ActiveControl = pFocus(0)
    End Sub

    Private Sub Cmd11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd11.Click
        Me.Close()
    End Sub

    Private Sub Cmd04_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd04.Click
        Dim pRet As Boolean = Inp_Chk00(txt決済1)
        If pRet = False Then Exit Sub

        If MsgBox("該当データを削除します。確認してください。", vbOKCancel) = vbCancel Then Exit Sub
        Data_Del00()
        Inp_Clr00()
        txt決済1.Focus()
    End Sub

    Private Sub btnOK10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = Application.StartupPath
        dialog.Filter = "すべてのファイル(*.*)|*.*"
        dialog.FilterIndex = 0
        dialog.RestoreDirectory = True
        dialog.CheckFileExists = False
        dialog.CheckPathExists = True

        If dialog.ShowDialog() = DialogResult.OK Then
            Try
                Pic会社Logo.Image = Nothing
                Pic会社Logo.Image = System.Drawing.Image.FromFile(dialog.FileName)
                txt会社Logo.Text = dialog.FileName
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnOK20_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dialog As New OpenFileDialog

        dialog.InitialDirectory = Application.StartupPath
        dialog.Filter = "すべてのファイル(*.*)|*.*"
        dialog.FilterIndex = 0
        dialog.RestoreDirectory = True
        dialog.CheckFileExists = False
        dialog.CheckPathExists = True

        If dialog.ShowDialog() = DialogResult.OK Then
            Try
                Pic印鑑.Image = Nothing
                Pic印鑑.Image = System.Drawing.Image.FromFile(dialog.FileName)
                txt印鑑Image.Text = dialog.FileName
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Cmd01_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim pRet As Boolean = Inp_Chk00(txt決済1)
        If pRet = False Then Exit Sub

        For Each CtrlItem As Control In Me.GroupBox10.Controls
            If TypeOf CtrlItem Is TextBox Then
                pRet = Inp_Chk00(CtrlItem)
                If pRet = False Then Exit Sub
            End If
        Next
        Data_Put00()
        Inp_Clr00()
        txt決済1.Focus()
    End Sub

    Private Sub CmbComp_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        Add_Cmb()
        AddHandler CmbComp.SelectedIndexChanged, AddressOf CmbComp_SelectedIndexChanged
    End Sub

    Private Sub CmbComp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim item As MyComboBoxItemA
        If CmbComp.SelectedIndex = -1 Then
            txt決済1.Text = ""
        Else
            item = DirectCast(CmbComp.SelectedItem, MyComboBoxItemA)
            txt決済1.Text = item.ItemCode
            pubComPany = Integer.Parse(txt決済1.Text)
            btnOK00.PerformClick()
        End If
    End Sub

    Private Sub CmbComp_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CmbComp.SelectedIndexChanged, AddressOf CmbComp_SelectedIndexChanged
    End Sub

    Private Sub MenuItem00_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem00.Click
        Dim frmForm = New F_Ms_Comp10
        frmForm.pubCD = txt決済1.Text
        frmForm.Show()
    End Sub

    Private Sub MenuItem01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem01.Click
        Dim frmForm = New F_Ms_Comp20
        frmForm.pubCD = txt決済1.Text
        frmForm.Show()
    End Sub

    Private Sub MenuItem02_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem02.Click
        Dim frmForm = New F_Ms_Comp30
        frmForm.pubCD = txt決済1.Text
        frmForm.Show()
    End Sub

    Private Sub La端数区分_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frmForm = New F_S_KuBunM00
        frmForm.pubKuCD = 3 : frmForm.pubCD = ""
        If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If IsNumeric(frmForm.pubCD) Then
                txt端数計算区分.Text = Integer.Parse(frmForm.pubCD)
                Inp_Chk00(txt端数計算区分)
            End If
            txt端数計算区分.Focus()
        End If
    End Sub

    Private Sub La消費税区分_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmForm = New F_S_KuBunM00
        frmForm.pubKuCD = 1 : frmForm.pubCD = ""
        If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If IsNumeric(frmForm.pubCD) Then
                txt消費税区分.Text = Integer.Parse(frmForm.pubCD)
                Inp_Chk00(txt消費税区分)
            End If
            txt消費税区分.Focus()
        End If
    End Sub

    Private Sub La消費税計算_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmForm = New F_S_KuBunM00
        frmForm.pubKuCD = 6 : frmForm.pubCD = ""
        If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If IsNumeric(frmForm.pubCD) Then
                txt消費税計算.Text = Integer.Parse(frmForm.pubCD)
                Inp_Chk00(txt消費税計算)
            End If
            txt消費税計算.Focus()
        End If
    End Sub

    Private Sub La消費税端数_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmForm = New F_S_KuBunM00
        frmForm.pubKuCD = 3 : frmForm.pubCD = ""
        If frmForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If IsNumeric(frmForm.pubCD) Then
                txt消費税端数.Text = Integer.Parse(frmForm.pubCD)
                Inp_Chk00(txt消費税端数)
            End If
            txt消費税端数.Focus()
        End If
    End Sub

    Private Sub Cmd05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd05.Click
        Inp_Clr00()
        txt決済1.Focus()
    End Sub

    Private Sub txt科目集計CD_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt会社名_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox00_Enter(sender As Object, e As EventArgs) Handles GroupBox00.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt口座No.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK00.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles txt残高8.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txt合計3.TextChanged

    End Sub
End Class
