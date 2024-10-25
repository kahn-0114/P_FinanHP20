Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports dao

Module C_Mconst
    Public pubDBpath As String          'Data Source
    Public pubComDBpath As String       '共通DBのPath
    Public pubProvider As String        'Provider
    Public pubTmpDB As String           '一時ＤＢ
    Public pubRepDB As String           '一時ＤＢ
    Public pubPARM(10) As String
    Public pubData(10) As Decimal
    Public pubComPany As Integer        '会社No
    Public pubComPanyName As String     '会社名
    Public pubSYSName As String         'システム名
    Public pubLogIn As Integer          'ユーザーID
    Public pubPass As String            'パスワード
    Public pubRight As UShort           '権限
    Public pubInpDen(5) As UShort       '伝票入力権限
    Public pubPNewtax As Double         '新消費税率
    Public pubPOldtax As Double         '旧消費税率
    Public pubPtaxDate As Date          '消費税経過
    Public pubPtax As Byte              '消費税区分
    Public pubPtaxKei As Byte           '消費税計算区分
    Public pubPtaxFra As Byte           '消費税端数計算
    Public pubPFra As Byte              '端数計算
    Public pubCTL(10) As Object        '消費税率
    Public pubNo(10) As Object         '納品伝票用
    Public pubKaKeta As Integer         '科目CD桁
    Public pubKaEKeta As Integer        '科目枝番CD桁
    Public pubLogInName As String       'ウィンドウズログインユーザー
    Public pubPcName As String          'PC名
    Public pubNNen As Integer           '日次処理年度
    Public pubNNo As Integer            '日次処理No
    Public pubNen As Integer               '売上月次年度
    Public pubTu As Integer                '売上月次処理No
    Public pubSNen As Integer           '請求年度
    Public pubSNo As Integer            '請求更新No
    Public pubSiNen As Integer          '仕入月次年度
    Public pubSiNo As Integer           '仕入月次処理No
    Public pubShNen As Integer          '支払年度
    Public pubShNo As Integer           '支払処理No
    Public pubZNen As Integer           '在庫更新年度
    Public pubZNo As Integer            '在庫更新No
    Public pubDsn As String
    Public pubDsnODBC As String
    Public pubDsnAccess As String
    Public SQLDB As String
    Public pDspDate As Integer = 0
    Public pTax(2) As Double
    Public pTaxNM(2) As String
    Public dbsPubs As SqlClient.SqlConnection
    Public Cn00 As New SqlConnection
    Public CnTmp As New OleDbConnection
    Public pubExcelVer As String        'EXCELﾊﾞｰｼﾞｮﾝ

    Public DaoEngine As dao.DBEngine
    Public DB As dao.Database
    Public ComDB As dao.Database
    Public RepDB As dao.Database
    Public TmpDB As dao.Database
    Public WrkSp As dao.Workspace

    Public Declare Function GetCurrentProcessId Lib "kernel32" () As Integer
    Public Declare Function GetUserName Lib "advapi32.dll" Alias "GetUserNameA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (
        ByVal hWnd As IntPtr, ByVal lpVerb As String, ByVal lpFile As String,
        ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer
        ) As Long
    Public Structure ComboItem
        Public ComText As String    '表示テキスト        
        Public ComData As Integer   '数値データ        '--- ToStringのオーバーライド(上書) 
        Public Overrides Function ToString() As String
            Return ComText
        End Function        '--- コンストラクタ(Object生成時の初期化)の定義
        Public Sub New(ByVal st As String, ByVal it As Integer)
            ComText = st
            ComData = it
        End Sub
    End Structure
End Module
