
Imports System.Security.Policy
Imports System.Text
Imports Microsoft.Office.Interop.Access.Dao
Imports System.Data.SqlClient

Public Class SQLServer
    Private connectionString As String

    Public Enum ENUM_ValueType
        ''' <summary>
        ''' パラメーター指定
        ''' </summary>
        Parameter
        ''' <summary>
        ''' 直接値（シングルクォーテーションで囲まない）
        ''' </summary>
        DirectValue
        ''' <summary>
        ''' 直接値（シングルクォーテーションで囲う）
        ''' </summary>
        DirectValueStr
        ''' <summary>
        ''' SQL指定
        ''' </summary>
        DirectSQL
    End Enum

    Public Sub New()
        connectionString = pubDsn
        'connectionString = $"server={My.Settings.ServerName};user={My.Settings.UserID};database={My.Settings.Database};port=3306;password={My.Settings.Password};"
    End Sub

    Public Function GetData(query As String, Optional sqlParameters As SqlParameter() = Nothing) As DataTable
        Return ExecuteQuery(query, sqlParameters)
    End Function

    Public Function InsertData(table As String, columns As String, values As String, Optional sqlParameters As SqlParameter() = Nothing) As Boolean
        ' 定数として登録日と登録端末IDのカラム名を定義
        Const insertDateColumn As String = "登録日"
        Const insertProcessIdColumn As String = "登録処理ID"
        Const insertTerminalIdColumn As String = "登録端末ID"
        Const insertDateValue As String = "InsertDate"
        Const insertProcessIdValue As String = "InsertProcess"
        Const insertTerminalIdValue As String = "InsertTerminal"
        Const updateDateColumn As String = "更新日"
        Const updateProcessIdColumn As String = "更新処理ID"
        Const updateTerminalIdColumn As String = "更新端末ID"
        Const updateDateValue As String = "UpdateDate"
        Const updateProcessIdValue As String = "UpdateProcess"
        Const updateTerminalIdValue As String = "UpdateTerminal"

        ' 現在の日付時刻と端末名を取得
        Dim currentDate As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        Dim processId As String = pubLogIn     ' 処理IDを取得
        Dim terminalName As String = Environment.MachineName    ' 端末名を取得

        ' カラムと値の文字列に登録日と登録端末IDを追加
        columns &= $", {insertDateColumn}, {insertProcessIdColumn}, {insertTerminalIdColumn}, {updateDateColumn}, {updateProcessIdColumn}, {updateTerminalIdColumn}"
        values &= $", @{insertDateValue}, @{insertProcessIdValue}, @{insertTerminalIdValue}, @{updateDateValue}, @{updateProcessIdValue}, @{updateTerminalIdValue}"

        ' SQLコマンド文字列を生成
        Dim sql As String = $"INSERT INTO {table} ({columns}) VALUES ({values});"

        ' SQLパラメータに登録日と登録端末IDのパラメータを追加
        Dim parameterList As New List(Of SqlParameter)
        If sqlParameters IsNot Nothing Then
            parameterList.AddRange(sqlParameters)
        End If
        parameterList.Add(New SqlParameter($"@{insertDateValue}", currentDate))
        parameterList.Add(New SqlParameter($"@{insertProcessIdValue}", processId))
        parameterList.Add(New SqlParameter($"@{insertTerminalIdValue}", terminalName))
        parameterList.Add(New SqlParameter($"@{updateDateValue}", currentDate))
        parameterList.Add(New SqlParameter($"@{updateProcessIdValue}", processId))
        parameterList.Add(New SqlParameter($"@{updateTerminalIdValue}", terminalName))

        ' SQLコマンドを実行
        Return ExecuteNonQuery(sql, parameterList.ToArray())
    End Function

    Public Function UpdateData(table As String, setStatement As String, condition As String, Optional sqlParameters() As SqlParameter = Nothing) As Boolean
        ' 定数として更新日と更新端末IDのカラム名を定義GlobalVariables.pubLogIn
        Const updateDateColumn As String = "更新日"
        Const updateProcessIdColumn As String = "更新処理ID"
        Const updateTerminalIdColumn As String = "更新端末ID"
        Const updateDateValue As String = "UpdateDate"
        Const updateProcessIdValue As String = "UpdateProcess"
        Const updateTerminalIdValue As String = "UpdateTerminal"

        ' 現在の日付時刻と端末名を取得
        Dim currentDate As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        Dim processId As String = pubLogIn    ' 処理IDを取得
        Dim terminalName As String = Environment.MachineName    ' 端末名を取得

        ' setStatementに更新日と更新端末IDのセット文を追加
        setStatement &= $", {updateDateColumn} = @{updateDateValue}, {updateProcessIdColumn} = @{updateProcessIdValue}, {updateTerminalIdColumn} = @{updateTerminalIdValue}"

        ' SQLコマンド文字列を生成
        Dim sql As String = $"UPDATE {table} SET {setStatement} WHERE {condition};"

        ' SQLパラメータに更新日と更新端末IDのパラメータを追加
        Dim parameterList As New List(Of SqlParameter)
        If sqlParameters IsNot Nothing Then
            parameterList.AddRange(sqlParameters)
        End If
        parameterList.Add(New SqlParameter($"@{updateDateValue}", currentDate))
        parameterList.Add(New SqlParameter($"@{updateProcessIdValue}", processId))
        parameterList.Add(New SqlParameter($"@{updateTerminalIdValue}", terminalName))

        ' SQLコマンドを実行
        Return ExecuteNonQuery(sql, parameterList.ToArray())
    End Function

    Public Function DeleteData(table As String, condition As String, Optional sqlParameters() As SqlParameter = Nothing) As Boolean
        Dim sql As String = $"DELETE FROM {table} WHERE {condition};"
        Return ExecuteNonQuery(sql, sqlParameters)
    End Function

    Public Function InsertOrUpdateData(table As String, columns As String, values As String, updateStatement As String, Optional sqlParameters() As SqlParameter = Nothing) As Boolean
        Dim sql As String = $"INSERT INTO {table} ({columns}) VALUES ({values}) ON DUPLICATE KEY UPDATE {updateStatement};"
        Return ExecuteNonQuery(sql, sqlParameters)
    End Function

    Protected Friend Overridable Function ExecuteQuery(query As String, sqlParameters() As SqlParameter) As DataTable
        Dim resultTable As New DataTable()

        Using connection As New SqlConnection(connectionString), command As New SqlCommand(query, connection)

            If sqlParameters IsNot Nothing Then
                command.Parameters.AddRange(sqlParameters)
            End If
            Try
                connection.Open()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(resultTable)
                End Using
            Catch ex As SqlException
                MsgBox("★SQL例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                Logger.log("★SQL例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
            Catch ex As Exception
                MsgBox("★一般例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                Logger.log("★一般例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
            End Try
        End Using
        Return resultTable
    End Function

    Protected Friend Overridable Function ExecuteNonQuery(sql As String, sqlParameters As SqlParameter()) As Boolean
        Using connection As New SqlConnection(connectionString), command As New SqlCommand(sql, connection)
            If sqlParameters IsNot Nothing Then
                command.Parameters.AddRange(sqlParameters)
            End If
            Try
                connection.Open()
                command.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MsgBox("★例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                Logger.log("★例外エラー" & ex.Message & vbNewLine & ex.StackTrace)
                Return False
            End Try
        End Using

    End Function

#Region "Truncate Table"
    ''' <summary>
    ''' テーブル内容のトランケート
    ''' </summary>
    ''' <param name="tableName"></param>
    ''' <returns></returns>
    Public Function TruncateTable(tableName As String) As Boolean

        Return ExecuteNonQuery(String.Format("Truncate {0}", tableName), Nothing)

    End Function

#End Region

    ''' <summary>
    ''' データ取得
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDataSimple(tableName As String, condition As Dictionary(Of String, Object), SelectColumns As List(Of String)) As DataTable
        If SelectColumns Is Nothing Then
            Return GetDataSimple(tableName, condition, String.Empty, Nothing)
        Else
            Return GetDataSimple(tableName, condition, String.Join(",", SelectColumns), Nothing)
        End If
    End Function
    ''' <summary>
    ''' データ取得
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDataSimple(tableName As String, condition As Dictionary(Of String, Object)) As DataTable
        Return GetDataSimple(tableName, condition, String.Empty, Nothing)
    End Function
    ''' <summary>
    ''' データ取得
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDataSimple(tableName As String, condition As Dictionary(Of String, Object), Columns As String) As DataTable
        Return GetDataSimple(tableName, condition, Columns, Nothing)
    End Function

    ''' <summary>
    ''' データ取得
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDataSimple(tableName As String, condition As Dictionary(Of String, Object), Columns As String, orderby As String) As DataTable
        Dim sbSQL As New System.Text.StringBuilder
        Dim parameters As New List(Of SqlParameter)()
        Dim prmIdx As Integer = 0
        If String.IsNullOrEmpty(Columns) Then
            Columns = "*"
        End If
        sbSQL.AppendFormat("SELECT {1} FROM {0}", tableName, Columns).AppendLine()
        sbSQL.AppendFormat(" WHERE")
        For Each prm As KeyValuePair(Of String, Object) In condition
            If parameters.Count > 0 Then
                sbSQL.Append(" AND")
            End If
            prmIdx += 1
            parameters.Add(New SqlParameter("@prm" & prmIdx.ToString, prm.Value))
            sbSQL.AppendFormat(" {0} = @prm{1} ", prm.Key, prmIdx.ToString).AppendLine()
        Next

        If String.IsNullOrWhiteSpace(orderby) = False Then
            sbSQL.AppendFormat("ORDER BY {0}", orderby)
        End If

        Dim dt As DataTable
        dt = GetData(sbSQL.ToString, parameters.ToArray)
        Return dt

    End Function

    Public Function createDBManager() As DBManager
        Return New DBManager()
    End Function

    Public Class DBManager
        Inherits SQLServer
        Implements IDisposable

        Private m_Connection As SqlConnection = Nothing
        Private m_Transaction As SqlTransaction = Nothing

        Protected Friend Sub New()
            MyBase.New()
            Call DBOpen()
        End Sub
        Private Sub DBOpen()
            Try
                m_Connection = New SqlConnection(connectionString)
                m_Connection.Open()
            Catch ex As Exception
                MsgBox("★例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                Logger.log("★例外エラー" & ex.Message & vbNewLine & ex.StackTrace)
            End Try
        End Sub

        Public Function BeginTrans() As Boolean

            Try
                If m_Transaction IsNot Nothing Then
                    Return False
                End If
                m_Transaction = m_Connection.BeginTransaction
                If m_Transaction IsNot Nothing Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox("★例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                Logger.log("★例外エラー" & ex.Message & vbNewLine & ex.StackTrace)
                Try
                    m_Connection.Close()
                    m_Connection.Open()
                    m_Transaction = Nothing
                Catch ex2 As Exception
                    MsgBox("★例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                    Logger.log("★例外エラー" & ex2.Message & vbNewLine & ex2.StackTrace)
                End Try
                Return False
            End Try

        End Function

        Public Function Commit() As Boolean
            Try
                If m_Transaction Is Nothing Then
                    Return True
                End If
                m_Transaction.Commit()
                Return True
            Catch ex As Exception
                MsgBox("★例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                Logger.log("★例外エラー" & ex.Message & vbNewLine & ex.StackTrace)
                Return False
            End Try
        End Function

        Public Function Rollback() As Boolean
            Try
                If m_Transaction Is Nothing Then
                    Return True
                End If
                m_Transaction.Rollback()
                Return True
            Catch ex As Exception
                MsgBox("★例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                Logger.log("★例外エラー" & ex.Message)
                Return False
            End Try
        End Function

        Protected Friend Overrides Function ExecuteNonQuery(sql As String, sqlParameters() As SqlParameter) As Boolean
            Using command As New SqlCommand(sql, m_Connection)
                If sqlParameters IsNot Nothing Then
                    command.Parameters.AddRange(sqlParameters)
                End If
                Try
                    command.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MsgBox("★例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                    Logger.log("★例外エラー" & ex.Message)
                    Return False
                End Try
            End Using
        End Function

        Protected Friend Overrides Function ExecuteQuery(query As String, sqlParameters() As SqlParameter) As DataTable
            Dim resultTable As New DataTable()
            Using command As New SqlCommand(query, m_Connection)
                If sqlParameters IsNot Nothing Then
                    command.Parameters.AddRange(sqlParameters)
                End If
                Try
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(resultTable)
                    End Using
                Catch ex As SqlException
                    MsgBox("★SQL例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                    Logger.log("★MSQL例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                Catch ex As Exception
                    MsgBox("★例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                    Logger.log("★一般例外エラー: " & ex.Message & vbNewLine & ex.StackTrace)
                End Try
            End Using
            Return resultTable
        End Function

        ''' <summary>
        ''' 指定条件のデータ存在チェック
        ''' </summary>
        ''' <returns></returns>
        Public Function Exists(tableName As String, condition As Dictionary(Of String, Object)) As Boolean
            Return Exists(tableName, condition, Nothing)
        End Function

        ''' <summary>
        ''' 指定条件のデータ存在チェック
        ''' </summary>
        ''' <returns></returns>
        Public Function Exists(tableName As String, condition As Dictionary(Of String, Object), dicGetVal As Dictionary(Of String, String)) As Boolean
            Dim sbSQL As New System.Text.StringBuilder
            Dim parameters As New List(Of SqlParameter)()
            Dim columns As String
            If dicGetVal IsNot Nothing Then
                columns = String.Join(",", dicGetVal.Keys)
            Else
                columns = "'X'"
            End If
            sbSQL.AppendFormat("SELECT {1} FROM {0}", tableName, columns).AppendLine()
            sbSQL.AppendFormat(" WHERE")
            For Each prm As KeyValuePair(Of String, Object) In condition
                If parameters.Count > 0 Then
                    sbSQL.Append(" AND")
                End If
                parameters.Add(New SqlParameter("@" & prm.Key, prm.Value))
                sbSQL.AppendFormat(" {0} = @{0} ", prm.Key).AppendLine()
            Next
            sbSQL.AppendLine(" LIMIT 1 ")

            Dim dt As DataTable
            dt = GetData(sbSQL.ToString, parameters.ToArray)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                If dicGetVal IsNot Nothing Then

                    For Each col As DataColumn In dt.Columns
                        If dicGetVal.ContainsKey(col.ColumnName) Then
                            If dt.Rows(0).IsNull(col.ColumnName) Then
                                dicGetVal(col.ColumnName) = String.Empty
                            Else
                                dicGetVal(col.ColumnName) = dt.Rows(0).Item(col.ColumnName)
                            End If
                        End If

                    Next

                End If

                Return True
            Else
                Return False
            End If

        End Function

        ''' <summary>
        ''' データ登録/更新SQL実行　Key：パラメータ名（DBカラム名）,Value：値）
        ''' </summary>
        ''' <param name="data"></param>
        ''' <param name="newFlg"></param>
        ''' <returns></returns>
        Public Function ExecSQL(tableName As String, data As Dictionary(Of String, Object), condition As Dictionary(Of String, Object), newFlg As Boolean) As Boolean
            Dim parameters As New List(Of SqlParameter)()
            Dim lbNull As Boolean = False
            ' パラメータの追加

            If newFlg Then

                Dim sbColumns As New StringBuilder
                Dim sbValues As New StringBuilder

                For Each prm As KeyValuePair(Of String, Object) In data

                    If sbColumns.Length <> 0 Then
                        sbColumns.Append(",")
                        sbValues.Append(",")
                    End If

                    sbColumns.AppendFormat(" {0} ", prm.Key)

                    If TypeOf prm.Value Is Tuple(Of ENUM_ValueType, String) Then
                        With DirectCast(prm.Value, Tuple(Of ENUM_ValueType, String))
                            Select Case .Item1
                                Case ENUM_ValueType.DirectValue
                                    sbValues.AppendFormat(" {0} ", .Item2)
                                    Continue For
                                Case ENUM_ValueType.DirectValueStr
                                    sbValues.AppendFormat(" '{0}' ", .Item2)
                                    Continue For
                                Case ENUM_ValueType.DirectSQL
                                    sbValues.AppendFormat(" '{0}' ", .Item2)
                                    Continue For
                            End Select
                        End With
                    End If

                    If TypeOf prm.Value Is Tuple(Of ENUM_ValueType, String, List(Of SqlParameter)) Then
                        With DirectCast(prm.Value, Tuple(Of ENUM_ValueType, String, List(Of SqlParameter)))
                            Select Case .Item1
                                Case ENUM_ValueType.DirectSQL
                                    sbValues.AppendFormat(" {0} ", .Item2)
                                    parameters.AddRange(.Item3)
                                    Continue For
                            End Select
                        End With
                    End If

                    If prm.Value IsNot Nothing AndAlso String.IsNullOrEmpty(prm.Value.ToString) = False Then
                        parameters.Add(New SqlParameter("@" & prm.Key, prm.Value))
                        lbNull = False
                    Else
                        lbNull = True
                    End If

                    If lbNull Then
                        sbValues.AppendFormat(" null ")
                    Else
                        sbValues.AppendFormat(" @{0} ", prm.Key)
                    End If

                Next

                Return InsertData(tableName, sbColumns.ToString, sbValues.ToString, parameters.ToArray())

            Else

                Dim lsCondicionKeys As New HashSet(Of String)

                Dim sbsStatement As New StringBuilder
                Dim sbCondition As New StringBuilder

                For Each prm As KeyValuePair(Of String, Object) In condition
                    lsCondicionKeys.Add(prm.Key)
                Next

                For Each prm As KeyValuePair(Of String, Object) In data
                    If lsCondicionKeys.Contains(prm.Key) = False Then

                        If TypeOf prm.Value Is Tuple(Of ENUM_ValueType, String) Then
                            With DirectCast(prm.Value, Tuple(Of ENUM_ValueType, String))
                                Select Case .Item1
                                    Case ENUM_ValueType.DirectValue
                                        If sbsStatement.Length <> 0 Then sbsStatement.Append(",")
                                        sbsStatement.AppendFormat(" {0} = {1}", prm.Key, .Item2)
                                        Continue For
                                    Case ENUM_ValueType.DirectValueStr
                                        If sbsStatement.Length <> 0 Then sbsStatement.Append(",")
                                        sbsStatement.AppendFormat(" {0} = '{1}' ", prm.Key, .Item2)
                                        Continue For
                                    Case ENUM_ValueType.DirectSQL
                                        If sbsStatement.Length <> 0 Then sbsStatement.Append(",")
                                        sbsStatement.AppendFormat(" {0} = {1} ", prm.Key, .Item2)
                                        Continue For
                                End Select
                            End With
                        End If

                        If TypeOf prm.Value Is Tuple(Of ENUM_ValueType, String, List(Of SqlParameter)) Then
                            With DirectCast(prm.Value, Tuple(Of ENUM_ValueType, String, List(Of SqlParameter)))
                                Select Case .Item1
                                    Case ENUM_ValueType.DirectSQL
                                        If sbsStatement.Length <> 0 Then sbsStatement.Append(",")
                                        sbsStatement.AppendFormat(" {0} = {1} ", prm.Key, .Item2)
                                        parameters.AddRange(.Item3)
                                        Continue For
                                End Select
                            End With
                        End If


                        If prm.Value IsNot Nothing AndAlso String.IsNullOrEmpty(prm.Value.ToString) = False Then
                            parameters.Add(New SqlParameter("@" & prm.Key, prm.Value))
                            lbNull = False
                        Else
                            lbNull = True
                        End If
                        If sbsStatement.Length <> 0 Then sbsStatement.Append(",")
                        If lbNull Then
                            sbsStatement.AppendFormat(" {0} = null ", prm.Key)
                        Else
                            sbsStatement.AppendFormat(" {0} = @{0} ", prm.Key)
                        End If
                    End If
                Next

                For Each prm As KeyValuePair(Of String, Object) In condition
                    If sbCondition.Length <> 0 Then sbCondition.Append(" AND ")
                    sbCondition.AppendFormat(" {0} = @{0} ", prm.Key)
                    parameters.Add(New SqlParameter("@" & prm.Key, prm.Value))
                Next

                Return UpdateData(tableName, sbsStatement.ToString, sbCondition.ToString, parameters.ToArray())

            End If

        End Function

#Region "IDisposable実装"
        Private disposedValue As Boolean
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: マネージド状態を破棄します (マネージド オブジェクト)
                    Try
                        If m_Transaction IsNot Nothing Then
                            m_Transaction.Dispose()
                            m_Transaction = Nothing
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If m_Connection IsNot Nothing Then
                            m_Connection.Dispose()
                            m_Connection = Nothing
                        End If
                    Catch ex As Exception
                    End Try

                End If

                ' TODO: アンマネージド リソース (アンマネージド オブジェクト) を解放し、ファイナライザーをオーバーライドします
                ' TODO: 大きなフィールドを null に設定します
                disposedValue = True
            End If
        End Sub

        ' ' TODO: 'Dispose(disposing As Boolean)' にアンマネージド リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします
        ' Protected Overrides Sub Finalize()
        '     ' このコードを変更しないでください。クリーンアップ コードを 'Dispose(disposing As Boolean)' メソッドに記述します
        '     Dispose(disposing:=False)
        '     MyBase.Finalize()
        ' End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ' このコードを変更しないでください。クリーンアップ コードを 'Dispose(disposing As Boolean)' メソッドに記述します
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

End Class
