Imports System.Data.SqlClient
Imports System.Globalization
Public Class MyComboBoxItem
    Private nameValue As String = ""
    Private CodeValue As String = ""

    Public Sub New(ByVal name As String, ByVal code As String)
        nameValue = name
        CodeValue = code
    End Sub
    Public Property ItemName() As String
        Get
            Return nameValue
        End Get
        Set(ByVal Value As String)
            nameValue = Value
        End Set
    End Property
    Public Property ItemCode() As String
        Get
            Return CodeValue
        End Get
        Set(ByVal Value As String)
            CodeValue = Value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return nameValue
    End Function
End Class
Public Class MyComboBoxItemA
    Private nameValue As String = ""
    Private CodeValue As String = ""

    Public Sub New(ByVal name As String, ByVal code As String)
        nameValue = name
        CodeValue = code
    End Sub
    Public Property ItemName() As String
        Get
            Return nameValue
        End Get
        Set(ByVal Value As String)
            nameValue = Value
        End Set
    End Property
    Public Property ItemCode() As String
        Get
            Return CodeValue
        End Get
        Set(ByVal Value As String)
            CodeValue = Value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return nameValue
    End Function
End Class
Public Class Com
    Public Sub New()

    End Sub
    '********************************************
    '* 日付チェック
    '********************************************
    Public Function DateChk00(ByVal p日付 As String, ByRef p編集日付 As String) As Byte
        Dim Tmp(10)

        DateChk00 = 0
        p編集日付 = ""

        Tmp(0) = Len(p日付)
        If Tmp(0) < 3 Then
            DateChk00 = 1
            Exit Function
        End If
        Select Case Tmp(0)
            Case 3
                If Not IsNumeric(p日付) Then
                    DateChk00 = 1
                    Exit Function
                End If
                Tmp(1) = Format(DateTime.Today, "yyyy") & p日付.PadLeft(4, "0")
                Tmp(1) = Format(CInt(Tmp(1)), "0000/00/00")
                If Not IsDate(Tmp(1)) Then
                    DateChk00 = 1
                    Exit Function
                End If
            Case 4
                If Not IsNumeric(p日付) Then
                    DateChk00 = 1
                    Exit Function
                End If
                Tmp(1) = Format(DateTime.Today, "yyyy") & p日付
                If Not IsDate(Format(CInt(Tmp(1)), "0000/00/00")) Then
                    DateChk00 = 1
                    Exit Function
                Else
                    Tmp(1) = Format(CInt(Tmp(1)), "0000/00/00")
                    If Not IsDate(Tmp(1)) Then
                        DateChk00 = 1
                        Exit Function
                    End If
                End If
            Case 6
                If Not IsNumeric(p日付) Then
                    DateChk00 = 1
                    Exit Function
                End If
                Tmp(1) = p日付
                If Not IsDate(Format(CInt(Tmp(1)), "00/00/00")) Then
                    DateChk00 = 1
                    Exit Function
                Else
                    Tmp(1) = Format(CInt(Tmp(1)), "00/00/00")
                    If IsDate(Tmp(1)) Then
                        Tmp(1) = Date.Parse(Tmp(1)).ToString("yyyy/MM/dd")
                    Else
                        DateChk00 = 1
                        Exit Function
                    End If
                End If
            Case 7 '和暦入力
                Dim pTmp00 As String = p日付.Substring(0, 1)
                Select Case pTmp00
                    Case "S", "s"
                        Dim pTmp01 As String = p日付.Substring(1, 2)
                        Dim pTmp02 As String = p日付.Substring(3, 2)
                        Dim pTmp03 As String = p日付.Substring(5, 2)
                        Dim wTmp00 As Integer = CSByte(pTmp01) + 1925
                        Tmp(1) = wTmp00 & "/" & pTmp02 & "/" & pTmp03
                    Case "H", "h"
                        Dim pTmp01 As String = p日付.Substring(1, 2)
                        Dim pTmp02 As String = p日付.Substring(3, 2)
                        Dim pTmp03 As String = p日付.Substring(5, 2)
                        Dim wTmp00 As Integer = CSByte(pTmp01) + 1988
                        Tmp(1) = wTmp00 & "/" & pTmp02 & "/" & pTmp03
                    Case "M", "m", "T", "t"
                    Case Else
                        DateChk00 = 1
                        Exit Function
                End Select
            Case 8
                If Not IsNumeric(p日付) Then
                    DateChk00 = 1
                    Exit Function
                End If
                Tmp(1) = p日付
                If Not IsDate(Format(CInt(Tmp(1)), "0000/00/00")) Then
                    DateChk00 = 1
                    Exit Function
                Else
                    Tmp(1) = Date.Parse(Format(CInt(Tmp(1)), "0000/00/00"))
                End If
            Case 9 '和暦入力
                Dim pTmp00 As String = p日付.Substring(0, 1)
                Select Case pTmp00
                    Case "M", "m", "T", "t", "S", "s", "H", "h"
                        Dim pTmp01 As String = p日付.Substring(1, 2)
                        Dim pTmp02 As String = p日付.Substring(4, 2)
                        Dim pTmp03 As String = p日付.Substring(7, 2)
                        Dim wTmp00 As SByte = CSByte(pTmp01) - 12
                        Tmp(1) = "20" & wTmp00 & "/" & pTmp02 & "/" & pTmp03
                    Case Else
                        DateChk00 = 1
                        Exit Function
                End Select
            Case Else
                DateChk00 = 1
                Exit Function
        End Select

        p編集日付 = Tmp(1)
    End Function
    '********************************************
    '* 年月チェック
    '********************************************
    Public Function DateChk01(ByVal p日付 As String, ByRef p編集日付 As String)
        Dim Tmp(10)

        DateChk01 = 0
        p編集日付 = ""

        Tmp(0) = Len(p日付)
        If Tmp(0) < 4 Then
            DateChk01 = 1
            Exit Function
        End If
        Select Case Tmp(0)
            Case 4
                If Not IsNumeric(p日付) Then
                    DateChk01 = 1
                    Exit Function
                End If

                Tmp(1) = "20" & p日付 & "01"
                If Not IsDate(Format(CInt(Tmp(1)), "0000/00/00")) Then
                    DateChk01 = 1
                    Exit Function
                Else
                    Tmp(1) = Date.Parse(Format(CInt(Tmp(1)), "0000/00/00"))
                    If Not IsDate(Tmp(1)) Then
                        DateChk01 = 1
                        Exit Function
                    End If
                End If
            Case 5 '和暦
                Dim pTmp00 As String = p日付.Substring(0, 1)
                Select Case pTmp00
                    Case "M", "m", "T", "t", "S", "s", "H", "h"
                        Dim pTmp01 As String = p日付.Substring(1, 2)
                        Dim pTmp02 As String = p日付.Substring(3, 2)
                        Dim wTmp00 As SByte = CSByte(pTmp01) - 12
                        Tmp(1) = "20" & wTmp00 & "/" & pTmp02
                    Case Else
                        Tmp(1) = "20" & p日付
                        If Not IsDate(Tmp(1)) Then
                            DateChk01 = 1
                            Exit Function
                        Else
                            Tmp(1) = Date.Parse(Tmp(1)).ToString("yyyy/MM")
                            If Not IsDate(Tmp(1)) Then
                                DateChk01 = 1
                                Exit Function
                            End If
                        End If
                End Select
            Case 6
                Dim pTmp00 As String = p日付.Substring(0, 1)
                Select Case pTmp00
                    Case "M", "m", "T", "t", "S", "s", "H", "h"
                        Dim pTmp01 As String = p日付.Substring(1, 2)
                        Dim pTmp02 As String = p日付.Substring(4, 2)
                        Dim wTmp00 As SByte = CSByte(pTmp01) - 12
                        Tmp(1) = "20" & wTmp00 & "/" & pTmp02
                    Case Else
                        Tmp(1) = Date.Parse(Format(CInt(p日付), "0000/00"))
                        If Not IsDate(Tmp(1)) Then
                            DateChk01 = 1
                            Exit Function
                        End If
                End Select
            Case Else
                DateChk01 = 1
                Exit Function
        End Select

        If IsDate(Tmp(1)) Then
            p編集日付 = Date.Parse(Tmp(1)).ToString("yyyy/MM")
        End If
    End Function
    Public Function Edit000(ByVal pValue As Object, Optional ByVal pPoint As Integer = 0) As String
        Edit000 = 0
        If IsNumeric(pValue) Then
            Dim pKin00 As Decimal = Decimal.Parse(pValue)
            Select Case pPoint
                Case 0
                    Edit000 = pKin00.ToString("#,##0")
                Case 1
                    Edit000 = pKin00.ToString("#,##0.0")
                Case 2
                    Edit000 = pKin00.ToString("#,##0.00")
                Case 3
                    Edit000 = pKin00.ToString("#,##0.000")
                Case 4
                    Edit000 = pKin00.ToString("#,##0.0000")
                Case 9
                    Edit000 = pKin00.ToString("0")
                Case Else
                    Edit000 = pKin00.ToString("#,##0.0000")
            End Select
        End If
    End Function
    Public Function Edit010(ByVal pValue As Object, Optional ByVal pPoint As Integer = 0) As String
        Edit010 = 0
        If IsNumeric(pValue) Then
            Dim pKin00 As Decimal = Decimal.Parse(pValue)
            Select Case pPoint
                Case 0
                    Edit010 = pKin00.ToString("#,##0;-#,##0;#")
                Case 1
                    Edit010 = pKin00.ToString("#,##0.0;-#,##0.0;#")
                Case 2
                    Edit010 = pKin00.ToString("#,##0.00;-#,##0.00;#")
                Case 3
                    Edit010 = pKin00.ToString("#,##0.000;-#,##0.000;#")
                Case 9
                    Edit010 = pKin00.ToString("#")
                Case Else
                    Edit010 = pKin00.ToString("#,##0.0000;-#,##0.0000;#")
            End Select
        End If
    End Function
    '********************************************
    ' <summary>Mid関数のバイト版。文字数と位置をバイト数で指定して文字列を切り抜く。</summary>
    ' <param name="str">対象の文字列</param>
    ' <param name="Start">切り抜き開始位置。全角文字を分割するよう位置が指定された場合、戻り値の文字列の先頭は意味不明の半角文字となる。</param>
    ' <param name="Length">切り抜く文字列のバイト数</param>
    ' <returns>切り抜かれた文字列</returns>
    ' <remarks>最後の１バイトが全角文字の半分になる場合、その１バイトは無視される。</remarks>
    '********************************************
    Public Function MidB(ByVal str As String, ByVal Start As Integer, Optional ByVal Length As Integer = 0) As String
        '▼空文字に対しては常に空文字を返す

        If str = "" Then
            Return ""
        End If

        '▼Lengthのチェック

        'Lengthが0か、Start以降のバイト数をオーバーする場合はStart以降の全バイトが指定されたものとみなす。

        Dim RestLength As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(str) - Start + 1

        If Length = 0 OrElse Length > RestLength Then
            Length = RestLength
        End If

        '▼切り抜き

        Dim SJIS As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift-JIS")
        Dim B() As Byte = CType(Array.CreateInstance(GetType(Byte), Length), Byte())

        Array.Copy(SJIS.GetBytes(str), Start - 1, B, 0, Length)

        Dim st1 As String = SJIS.GetString(B)

        '▼切り抜いた結果、最後の１バイトが全角文字の半分だった場合、その半分は切り捨てる。

        Dim ResultLength As Integer = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(st1) - Start + 1

        If Asc(Strings.Right(st1, 1)) = 0 Then
            'VB.NET2002,2003の場合、最後の１バイトが全角の半分の時
            Return st1.Substring(0, st1.Length - 1)
        ElseIf Length = ResultLength - 1 Then
            'VB2005の場合で最後の１バイトが全角の半分の時
            Return st1.Substring(0, st1.Length - 1)
        Else
            'その他の場合
            Return st1
        End If

    End Function
    '********************************************
    ' <summary>
    '     文字列の右端から指定されたバイト数分の文字列を返します。</summary>
    ' <param name="stTarget">
    '     取り出す元になる文字列。</param>
    ' <param name="iByteSize">
    '     取り出すバイト数。</param>
    ' <returns>
    '     右端から指定されたバイト数分の文字列。</returns>
    '********************************************
    Public Function RightB(ByVal stTarget As String, ByVal iByteSize As Integer) As String
        Dim hEncoding As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
        Dim btBytes As Byte() = hEncoding.GetBytes(stTarget)

        Return hEncoding.GetString(btBytes, btBytes.Length - iByteSize, iByteSize)
    End Function
    '********************************************
    ' <summary>
    '     文字列の左端から指定したバイト数分の文字列を返します。</summary>
    ' <param name="stTarget">
    '     取り出す元になる文字列。<param>
    ' <param name="iByteSize">
    '     取り出すバイト数。</param>
    ' <returns>
    '     左端から指定されたバイト数分の文字列。</returns>
    '********************************************
    Public Function LeftB(ByVal stTarget As String, ByVal iByteSize As Integer) As String
        Return MidB(stTarget, 1, iByteSize)
    End Function
    '********************************************
    '* 消費税の計算(外税)
    '********************************************
    Public Function MakeTax00(ByVal p金額 As Decimal, ByVal p計算 As Byte, ByVal pTax As Double) As Decimal
        MakeTax00 = 0
        pTax = pTax * 0.01
        Select Case p計算
            Case 0  '切捨て
                If p金額 > 0 Then
                    MakeTax00 = Fix(p金額 * pTax)
                Else
                    MakeTax00 = Fix(System.Math.Abs(p金額) * pTax) * -1
                End If
            Case 1  '四捨五入
                If p金額 > 0 Then
                    MakeTax00 = Fix(p金額 * pTax + 0.5)
                Else
                    MakeTax00 = Fix(System.Math.Abs(p金額) * pTax + 0.5) * -1
                End If
            Case 2  '切上げ
                If p金額 > 0 Then
                    MakeTax00 = Fix(p金額 * pTax + 0.9)
                Else
                    MakeTax00 = Fix(System.Math.Abs(p金額) * pTax + 0.9) * -1
                End If
        End Select
    End Function
    '********************************************
    '* 消費税の計算(内税)
    '********************************************
    Public Function MakeTax01(ByVal p金額 As Decimal, ByVal p計算 As Byte, ByVal pTax As Double) As Decimal
        MakeTax01 = 0
        Select Case p計算
            Case 0  '切捨て
                If p金額 > 0 Then
                    MakeTax01 = Fix(p金額 / (100 + pTax) * pTax)
                Else
                    MakeTax01 = Fix(System.Math.Abs(p金額) / (100 + pTax) * pTax) * -1
                End If
            Case 1  '四捨五入
                If p金額 > 0 Then
                    MakeTax01 = Fix(p金額 / (100 + pTax) * pTax + 0.5)
                Else
                    MakeTax01 = Fix(System.Math.Abs(p金額) / (100 + pTax) * pTax + 0.5) * -1
                End If
            Case 2  '切上げ
                If p金額 > 0 Then
                    MakeTax01 = Fix(p金額 / (100 + pTax) * pTax + 0.9)
                Else
                    MakeTax01 = Fix(System.Math.Abs(p金額) / (100 + pTax) * pTax + 0.9) * -1
                End If
        End Select
    End Function

    Public Function GetGengo(ByVal pRs As Object, Optional ByVal pFormat As String = "") As String
        Dim strRev As String
        Dim dDate As Decimal

        strRev = IIf(IsDBNull(pRs), 0, pRs)
        If Not IsDate(strRev) Then
            strRev = Format(dDate, "0000/00/00")
            If Not IsDate(strRev) Then
                GetGengo = ""
                Exit Function
            End If

        End If
        Try
            Dim culture As CultureInfo = New CultureInfo("ja-JP", True)
            culture.DateTimeFormat.Calendar = New JapaneseCalendar()

            Dim pGengo As Date = Date.Parse(strRev)
            Select Case pFormat
                Case ""
                    GetGengo = pGengo.ToString("ggyy年MM月dd日", culture)
                Case "gyy年mm月dd日", "ggyy年mm月dd日"
                    GetGengo = pGengo.ToString("ggyy年MM月dd日", culture)
                Case "gyy年m月d日", "ggyy年m月d日"
                    GetGengo = pGengo.ToString("ggyy年M月d日", culture)
                Case "gyy/mm/dd", "ggyy/mm/dd"
                    GetGengo = pGengo.ToString("ggyy/MM/dd", culture)
                Case "gyy.mm.dd", "ggyy.mm.dd"
                    GetGengo = pGengo.ToString("ggyy.MM.dd", culture)
                Case "gyy年", "ggyy年"
                    GetGengo = pGengo.ToString("ggyy年", culture)
                Case "gyy年mm月", "ggyy年mm月"
                    GetGengo = pGengo.ToString("ggyy年MM月", culture)
                Case "gyy/mm", "ggyy/mm"
                    GetGengo = pGengo.ToString("ggyy/MM", culture)
                Case "gyy.mm", "ggyy.mm"
                    GetGengo = pGengo.ToString("ggyy.MM", culture)
                Case Else
                    GetGengo = pGengo.ToString(pFormat)
            End Select
            Select Case pFormat
                Case "gyy年mm月dd日", "gyy/mm/dd", "gyy年", "gyy年mm月", "gyy/mm", "gyy.mm.dd", "gyy.mm"
                    If GetGengo.StartsWith("平成") Then
                        Return GetGengo.Replace("平成", "H")
                    ElseIf GetGengo.StartsWith("昭和") Then
                        Return GetGengo.Replace("昭和", "S")
                    ElseIf GetGengo.StartsWith("大正") Then
                        Return GetGengo.Replace("大正", "T")
                    ElseIf GetGengo.StartsWith("明治") Then
                        Return GetGengo.Replace("明治", "M")
                    End If
            End Select
        Catch ex As Exception
            GetGengo = ""
        End Try
    End Function

    Public Function ChgNull(ByVal pValue As Object, ByVal pType As SByte, Optional ByVal pSize As Byte = 0)
        ChgNull = pValue
        Select Case pType
            Case 0
                ChgNull = 0
                If IsDBNull(pValue) Then
                Else
                    Select Case pSize
                        Case 1
                            If IsNumeric(pValue) Then
                                ChgNull = Decimal.Parse(pValue)
                            End If
                        Case 2
                            If IsNumeric(pValue) Then
                                ChgNull = Long.Parse(pValue)
                            End If
                        Case 3
                            If IsNumeric(pValue) Then
                                ChgNull = Double.Parse(pValue)
                            End If
                        Case Else
                            If IsNumeric(pValue) Then
                                ChgNull = pValue
                            End If
                    End Select
                End If
            Case 1
                ChgNull = pValue
                If IsDBNull(pValue) Then
                    ChgNull = ""
                Else
                    If String.IsNullOrEmpty(ChgNull) Then
                        ChgNull = ""
                    End If
                End If
            Case 2
                ChgNull = -1
                If IsDBNull(pValue) Then
                Else
                    If IsNumeric(pValue) Then
                        ChgNull = pValue
                    End If
                End If
            Case 3
                ChgNull = 0
                If IsDBNull(pValue) Then
                Else
                    If IsNumeric(pValue) Then
                        ChgNull = Len(pValue)
                    End If
                End If
        End Select
    End Function
End Class
#Region "マスタチェック処理"
Public Class Mst
    Dim pubCom As New Com
    '**********************************
    '* 会社ﾏｽﾀ
    '**********************************
    Public Function 会社00(ByVal pCode As String, ByRef SQLCommand As SqlCommand, ByRef da0 As SqlDataAdapter, ByRef dt0 As DataSet) As Byte
        会社00 = 0
        pCode = pubCom.ChgNull(pCode, 2)
        If pubCom.ChgNull(pCode, 2) = -1 Then
            会社00 = 9
            Exit Function
        End If

        Dim SQL As String
        SQL = "SELECT * " _
            & "From MM_会社00 " _
            & "WHERE (会社No=" & pubComPany & ")"
        SQLCommand.CommandText = SQL
        da0.SelectCommand = SQLCommand
        da0.Fill(dt0, "m0")
        If dt0.Tables("m0").Rows.Count = 0 Then
            会社00 = 9
        End If
    End Function

    '**********************************
    '* ※MM_LogIn00
    '**********************************
    Public Function LogIn00(ByVal pCode As String, ByRef SQLCommand As SqlCommand, ByRef da0 As SqlDataAdapter, ByRef dt0 As DataSet) As Byte
        LogIn00 = 0

        Dim SQL As String
        SQL = "SELECT * " _
            & "From MM_LogIn00 " _
            & "WHERE (LogInID='" & pCode & "')"
        SQLCommand.CommandText = SQL
        da0.SelectCommand = SQLCommand
        da0.Fill(dt0, "m0")
        If dt0.Tables("m0").Rows.Count = 0 Then
            LogIn00 = 9
        End If
    End Function

    '**********************************
    '* MM_区分H00ﾏｽﾀｰ
    '**********************************
    Public Function 区分H00(ByVal pCode As String, ByRef SQLCommand As SqlCommand, ByRef da0 As SqlDataAdapter, ByRef dt0 As DataSet) As Byte
        区分H00 = 0
        pCode = pubCom.ChgNull(pCode, 2)

        Dim SQL As String
        SQL = "SELECT * " _
            & "From MM_区分H00 " _
            & "WHERE (会社No=" & pubComPany & ") " _
            & "AND (区分=" & pCode & ")"
        SQLCommand.CommandText = SQL
        da0.SelectCommand = SQLCommand
        da0.Fill(dt0, "m0")
        If dt0.Tables("m0").Rows.Count = 0 Then
            区分H00 = 9
        End If
    End Function

    '**********************************
    '* MM_区分M00ﾏｽﾀｰ
    '**********************************
    Public Function 区分M00(ByVal pKu As String, ByVal pCode As String, ByRef SQLCommand As SqlCommand, ByRef da0 As SqlDataAdapter, ByRef dt0 As DataSet) As Byte
        区分M00 = 0
        pKu = pubCom.ChgNull(pKu, 2)
        pCode = pubCom.ChgNull(pCode, 2)

        Dim SQL As String
        SQL = "SELECT * " _
            & "From MM_区分M00 " _
            & "WHERE (会社No=" & pubComPany & ") " _
            & "AND (区分=" & pKu & ") " _
            & "AND (CD=" & pCode & ")"
        SQLCommand.CommandText = SQL
        da0.SelectCommand = SQLCommand
        da0.Fill(dt0, "m0")
        If dt0.Tables("m0").Rows.Count = 0 Then
            区分M00 = 9
        End If
    End Function

    '**********************************
    '* MM_区分M00ﾏｽﾀｰ
    '**********************************
    Public Function 区分M01(ByVal pKu As String, ByVal pCode As String, ByRef SQLCommand As SqlCommand, ByRef da0 As SqlDataAdapter, ByRef dt0 As DataSet) As Byte
        区分M01 = 0
        pKu = pubCom.ChgNull(pKu, 2)

        Dim SQL As String
        SQL = "SELECT * " _
            & "From MM_区分M00 " _
            & "WHERE (会社No=" & pubComPany & ") " _
            & "AND (区分=" & pKu & ") " _
            & "AND (名称='" & pCode & "')"
        SQLCommand.CommandText = SQL
        da0.SelectCommand = SQLCommand
        da0.Fill(dt0, "m0")
        If dt0.Tables("m0").Rows.Count = 0 Then
            区分M01 = 9
        End If
    End Function

End Class
#End Region
#Region "プロセス処理"
Public Class Proc
    Private Mysqlserver As SQLServer = New SQLServer()
    Dim pubCom As New Com
    Dim pubMst As New Mst
    Public Function GetSetting(ByRef pMsg As String) As Byte
        Dim pPath As String, pFileName As String

        GetSetting = 0
        pMsg = ""
        pPath = Application.StartupPath
        pFileName = pPath & "\Setting00.ini"

        If System.IO.File.Exists(pFileName) = False Then
            pMsg = "Setting00.iniがありません"
            GetSetting = 9
            Exit Function
        End If

        pFileName = pPath & "\Tmp.mdb"
        If System.IO.File.Exists(pFileName) = False Then
            pMsg = "Tmp.mdbがありません"
            GetSetting = 9
            Exit Function
        End If

        Dim Items() As String, Dat(10) As String, i As Integer
        pFileName = pPath & "\Setting00.ini"
        Using pReader As New System.IO.StreamReader(pFileName, System.Text.Encoding.Default)
            i = -1
            Do While Not pReader.EndOfStream
                i = i + 1
                Dim Line As String = pReader.ReadLine
                Items = Line.Split(",")
                Dat(i) = Items(0)
            Loop
            pubComDBpath = Dat(0)
            pubDBpath = Dat(1)
            pubDsn = Dat(2)
            SQLDB = Dat(3)
            pubComPanyName = Dat(4)
            pubSYSName = Dat(5)
            pubRight = 0
        End Using

        'Dim pPath As String, pFileName As String

        'GetSetting = 0
        'pMsg = ""
        'pPath = Application.StartupPath
        'pFileName = pPath & "\Setting00.ini"

        'If System.IO.File.Exists(pFileName) = False Then
        '    pMsg = "Setting00.iniがありません"
        '    GetSetting = 9
        '    Exit Function
        'End If

        'pFileName = pPath & "\Tmp.accdb"
        'If System.IO.File.Exists(pFileName) = False Then
        '    pMsg = "Tmp.accdbがありません"
        '    GetSetting = 9
        '    Exit Function
        'End If

        'Dim Items() As String, Dat(10) As String, i As Integer
        'pFileName = pPath & "\Setting00.ini"
        'Using pReader As New System.IO.StreamReader(pFileName, System.Text.Encoding.Default)
        '    i = -1
        '    Do While Not pReader.EndOfStream
        '        i = i + 1
        '        Dim Line As String = pReader.ReadLine
        '        Items = Line.Split(",")
        '        Dat(i) = Items(0)
        '    Loop
        '    pubDsn = Dat(0)
        '    SQLDB = Dat(1)
        '    pubDsnAccess = Dat(2)
        '    pubComPanyName = Dat(3)
        '    pubSYSName = Dat(4)
        '    pubRight = 0
        'End Using

    End Function

    '******************************************************
    '* 終了処理
    '******************************************************
    Public Sub Dsp_End00()
        Dim MyNameA, MyNameB, pPath As String
        Try
            CnTmp.Close() : CnTmp.Dispose() : CnTmp = Nothing

            pPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            For Each stPrompt As String In System.IO.Directory.GetFiles(pPath, "tmp*.*")
                Try
                    MyNameA = StrConv(stPrompt, vbLowerCase)
                    MyNameB = StrConv(pPath & "\Tmp.mdb", vbLowerCase)
                    If Not MyNameA = MyNameB Then Kill(MyNameA)
                Catch ex As Exception
                End Try
            Next stPrompt
        Catch ex As Exception
        End Try
    End Sub

    '**********************************
    '* ※会社情報取得:
    '**********************************
    Public Sub GetNen00()
        pubPtaxDate = "2000/4/1"
        pubPNewtax = 0
        pubPOldtax = 0
        pubPtax = 0 '消費税区分
        pubPtaxKei = 1 '消費税計算区分
        pubPtaxFra = 1 '消費税端数計算
        pubPFra = 1

        ' SQLクエリの構築
        Dim SQL As String = "SELECT * " &
                            "FROM MM_会社 " &
                            "WHERE 会社No = @Company "
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@Company", pubComPany)
        }

        ' データベースからデータを取得
        Dim result As DataTable = Mysqlserver.GetData(SQL, parameters.ToArray())

        ' 取得したデータの処理
        If result IsNot Nothing AndAlso result.Rows.Count > 0 Then
            Dim Row As DataRow = result.Rows(0)
            pubComPanyName = pubCom.ChgNull(result.Rows(0)("会社名"), 1)
            If pubCom.ChgNull(result.Rows(0)("消費税実施日"), 2) > 0 Then pubPtaxDate = pubCom.GetGengo(result.Rows(0)("消費税実施日"), "yyyy/MM/dd")
            If pubCom.ChgNull(result.Rows(0)("消費税率"), 2) > 0 Then pubPNewtax = result.Rows(0)("消費税率")
            If pubCom.ChgNull(result.Rows(0)("旧消費税率"), 2) > 0 Then pubPOldtax = result.Rows(0)("旧消費税率")
            If pubCom.ChgNull(result.Rows(0)("消費税区分"), 2) > 0 Then pubPtax = result.Rows(0)("消費税区分")
            If pubCom.ChgNull(result.Rows(0)("消費税計算区分"), 2) > 0 Then pubPtaxKei = result.Rows(0)("消費税計算区分")
            If pubCom.ChgNull(result.Rows(0)("消費税端数区分"), 2) > 0 Then pubPtaxFra = result.Rows(0)("消費税端数区分")
            If pubCom.ChgNull(result.Rows(0)("端数計算区分"), 2) > 0 Then pubPFra = result.Rows(0)("端数計算区分")
        End If

        ' リソースの解放
        result.Dispose()
    End Sub

    '**********************************
    '* ※会社情報取得:
    '**********************************
    Public Sub GetNen10()
        pubComPany = 2
        Dim r0 = DB.OpenRecordset("MM_LogIn", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"
        r0.Seek("=", pubLogInName)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("LogInName").Value = pubLogInName
            r0.Fields("会社No").Value = pubComPany
            pubRight = 1
            r0.Update()
        Else
            pubComPany = r0.Fields("会社No").Value
            pubRight = r0.Fields("権限").Value
        End If
        r0.Close() : r0 = Nothing

        pubLogIn = 99

        r0 = ComDB.OpenRecordset("MM_会社", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbReadOnly)
        r0.Index = "Key_0"
        r0.Seek("=", pubComPany)
        If r0.NoMatch Then
        Else
            pubNNen = pubCom.ChgNull(r0.Fields("日次年度").Value, 0)
            pubNNo = pubCom.ChgNull(r0.Fields("日次処理No").Value, 0)
            pubNen = pubCom.ChgNull(r0.Fields("売上月次年度").Value, 0)
            pubTu = pubCom.ChgNull(r0.Fields("売上月次処理No").Value, 0)
            pubSNen = pubCom.ChgNull(r0.Fields("請求年度").Value, 0)
            pubSNo = pubCom.ChgNull(r0.Fields("請求処理No").Value, 0)
            pubSiNen = pubCom.ChgNull(r0.Fields("仕入月次年度").Value, 0)
            pubSiNo = pubCom.ChgNull(r0.Fields("仕入月次処理No").Value, 0)
            pubShNen = pubCom.ChgNull(r0.Fields("支払年度").Value, 0)
            pubShNo = pubCom.ChgNull(r0.Fields("支払処理No").Value, 0)
            pubShNen = pubCom.ChgNull(r0.Fields("在庫年度").Value, 0)
            pubShNo = pubCom.ChgNull(r0.Fields("在庫処理No").Value, 0)

            pubComPanyName = pubCom.ChgNull(r0.Fields("会社名").Value, 1)
            pubDsnODBC = pubCom.ChgNull(r0.Fields("DB接続").Value, 1)
        End If
        r0.Close() : r0 = Nothing

        r0 = DB.OpenRecordset("MM_SYS", dao.RecordsetTypeEnum.dbOpenTable, dao.RecordsetOptionEnum.dbConsistent, dao.LockTypeEnum.dbOptimistic)
        r0.Index = "Key_0"

        r0.Seek("=", pubComPany, pubLogInName, 0)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("会社No").Value = pubComPany
            r0.Fields("UsrID").Value = pubLogInName
            r0.Fields("ID").Value = 0
        Else
            r0.Edit()
        End If
        r0.Fields("年度").Value = pubNNen
        r0.Fields("締No").Value = pubNNo
        r0.Update()

        r0.Seek("=", pubComPany, pubLogInName, 1)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("会社No").Value = pubComPany
            r0.Fields("UsrID").Value = pubLogInName
            r0.Fields("ID").Value = 1
        Else
            r0.Edit()
        End If
        r0.Fields("年度").Value = pubNen
        r0.Fields("締No").Value = pubTu
        r0.Update()

        r0.Seek("=", pubComPany, pubLogInName, 2)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("会社No").Value = pubComPany
            r0.Fields("UsrID").Value = pubLogInName
            r0.Fields("ID").Value = 2
        Else
            r0.Edit()
        End If
        r0.Fields("年度").Value = pubSNen
        r0.Fields("締No").Value = pubSNo
        r0.Update()

        r0.Seek("=", pubComPany, pubLogInName, 3)
        If r0.NoMatch Then
            r0.AddNew()
            r0.Fields("会社No").Value = pubComPany
            r0.Fields("UsrID").Value = pubLogInName
            r0.Fields("ID").Value = 3
        Else
            r0.Edit()
        End If
        r0.Fields("年度").Value = pubZNen
        r0.Fields("締No").Value = pubZNo
        r0.Update()

        'r0.Seek("=", pubComPany, pubLogInName, 10)
        'If r0.NoMatch Then
        '    r0.AddNew()
        '    r0.Fields("会社No").Value = pubComPany
        '    r0.Fields("UsrID").Value = pubLogInName
        '    r0.Fields("ID").Value = 10
        'Else
        '    r0.Edit()
        'End If
        'r0.Fields("年度").Value = pubSzNen
        'r0.Fields("締No").Value = pubSzNo
        'r0.Update()

        'r0.Seek("=", pubComPany, pubLogInName, 11)
        'If r0.NoMatch Then
        '    r0.AddNew()
        '    r0.Fields("会社No").Value = pubComPany
        '    r0.Fields("UsrID").Value = pubLogInName
        '    r0.Fields("ID").Value = 11
        'Else
        '    r0.Edit()
        'End If
        'r0.Fields("年度").Value = pubGeNen
        'r0.Fields("締No").Value = pubGeNo
        'r0.Update()

        r0.Close() : r0 = Nothing
    End Sub
End Class

#End Region

