<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Si_SiwGet00
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Cmd01 As System.Windows.Forms.Button
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"0000", "9999/99/99 99:99:99", "9999年99月", "zzzzzzzzz1", "9999999"}, -1)
        Me.Cmd02 = New System.Windows.Forms.Button()
        Me.Cmd03 = New System.Windows.Forms.Button()
        Me.Cmd10 = New System.Windows.Forms.Button()
        Me.Cmd09 = New System.Windows.Forms.Button()
        Me.Cmd08 = New System.Windows.Forms.Button()
        Me.Cmd07 = New System.Windows.Forms.Button()
        Me.Cmd06 = New System.Windows.Forms.Button()
        Me.Cmd05 = New System.Windows.Forms.Button()
        Me.Cmd04 = New System.Windows.Forms.Button()
        Me.Cmd11 = New System.Windows.Forms.Button()
        Me.Cmd12 = New System.Windows.Forms.Button()
        Me.GroupBox00 = New System.Windows.Forms.GroupBox()
        Me.LV = New System.Windows.Forms.ListView()
        Me.LVNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV処理日時 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV対象年月 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV処理 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txt決算期 = New System.Windows.Forms.TextBox()
        Me.txt処理No = New System.Windows.Forms.TextBox()
        Me.txt開始日 = New System.Windows.Forms.TextBox()
        Me.txt終了日 = New System.Windows.Forms.TextBox()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.La対象年月 = New System.Windows.Forms.Label()
        Me.CmbA = New System.Windows.Forms.ComboBox()
        Me.La年度 = New System.Windows.Forms.Label()
        Me.txt締月 = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.La科目CD = New System.Windows.Forms.Label()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.CmbB = New System.Windows.Forms.ComboBox()
        Me.txt科目CDTo名 = New System.Windows.Forms.TextBox()
        Me.btnUp00 = New System.Windows.Forms.Button()
        Me.txt取引先CDFrom名 = New System.Windows.Forms.TextBox()
        Me.txt取引先CDTo名 = New System.Windows.Forms.TextBox()
        Me.txt取引先CDTo = New System.Windows.Forms.TextBox()
        Me.txt取引先CDFrom = New System.Windows.Forms.TextBox()
        Me.txt科目CDTo = New System.Windows.Forms.TextBox()
        Me.LaTo2 = New System.Windows.Forms.Label()
        Me.LaFrom2 = New System.Windows.Forms.Label()
        Me.La科目To1 = New System.Windows.Forms.Label()
        Me.La取引先CD = New System.Windows.Forms.Label()
        Me.txt伝票開始番号 = New System.Windows.Forms.TextBox()
        Me.txt支払指定開始日 = New System.Windows.Forms.TextBox()
        Me.txt伝票日付終了日 = New System.Windows.Forms.TextBox()
        Me.txt伝票終了番号 = New System.Windows.Forms.TextBox()
        Me.txt支払指定終了日 = New System.Windows.Forms.TextBox()
        Me.txtから2 = New System.Windows.Forms.TextBox()
        Me.txtから3 = New System.Windows.Forms.TextBox()
        Me.txtから1 = New System.Windows.Forms.TextBox()
        Me.La支払指定日 = New System.Windows.Forms.Label()
        Me.La伝票番号 = New System.Windows.Forms.Label()
        Me.txt科目CDFrom名 = New System.Windows.Forms.TextBox()
        Me.txt処理対象仕訳 = New System.Windows.Forms.TextBox()
        Me.txt伝票日付開始日 = New System.Windows.Forms.TextBox()
        Me.txt科目CDFrom = New System.Windows.Forms.TextBox()
        Me.La伝票日付 = New System.Windows.Forms.Label()
        Me.La科目From1 = New System.Windows.Forms.Label()
        Me.La処理対象仕訳 = New System.Windows.Forms.Label()
        Me.La抽出範囲指定 = New System.Windows.Forms.Label()
        Cmd01 = New System.Windows.Forms.Button()
        Me.GroupBox00.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmd01
        '
        Cmd01.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Cmd01.ForeColor = System.Drawing.Color.Blue
        Cmd01.Location = New System.Drawing.Point(4, 1)
        Cmd01.Name = "Cmd01"
        Cmd01.Size = New System.Drawing.Size(84, 44)
        Cmd01.TabIndex = 1
        Cmd01.TabStop = False
        Cmd01.UseVisualStyleBackColor = True
        '
        'Cmd02
        '
        Me.Cmd02.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd02.Location = New System.Drawing.Point(87, 1)
        Me.Cmd02.Name = "Cmd02"
        Me.Cmd02.Size = New System.Drawing.Size(84, 44)
        Me.Cmd02.TabIndex = 31
        Me.Cmd02.TabStop = False
        Me.Cmd02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd02.UseVisualStyleBackColor = True
        '
        'Cmd03
        '
        Me.Cmd03.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd03.Location = New System.Drawing.Point(170, 1)
        Me.Cmd03.Name = "Cmd03"
        Me.Cmd03.Size = New System.Drawing.Size(84, 44)
        Me.Cmd03.TabIndex = 32
        Me.Cmd03.TabStop = False
        Me.Cmd03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd03.UseVisualStyleBackColor = True
        '
        'Cmd10
        '
        Me.Cmd10.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd10.Location = New System.Drawing.Point(758, 1)
        Me.Cmd10.Name = "Cmd10"
        Me.Cmd10.Size = New System.Drawing.Size(84, 44)
        Me.Cmd10.TabIndex = 0
        Me.Cmd10.Text = "F10　終了"
        Me.Cmd10.UseVisualStyleBackColor = True
        '
        'Cmd09
        '
        Me.Cmd09.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd09.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd09.Location = New System.Drawing.Point(675, 1)
        Me.Cmd09.Name = "Cmd09"
        Me.Cmd09.Size = New System.Drawing.Size(84, 44)
        Me.Cmd09.TabIndex = 1
        Me.Cmd09.TabStop = False
        Me.Cmd09.UseVisualStyleBackColor = True
        '
        'Cmd08
        '
        Me.Cmd08.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd08.Location = New System.Drawing.Point(588, 1)
        Me.Cmd08.Name = "Cmd08"
        Me.Cmd08.Size = New System.Drawing.Size(84, 44)
        Me.Cmd08.TabIndex = 35
        Me.Cmd08.TabStop = False
        Me.Cmd08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd08.UseVisualStyleBackColor = True
        '
        'Cmd07
        '
        Me.Cmd07.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd07.Location = New System.Drawing.Point(505, 1)
        Me.Cmd07.Name = "Cmd07"
        Me.Cmd07.Size = New System.Drawing.Size(84, 44)
        Me.Cmd07.TabIndex = 36
        Me.Cmd07.TabStop = False
        Me.Cmd07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd07.UseVisualStyleBackColor = True
        '
        'Cmd06
        '
        Me.Cmd06.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd06.Location = New System.Drawing.Point(422, 1)
        Me.Cmd06.Name = "Cmd06"
        Me.Cmd06.Size = New System.Drawing.Size(84, 44)
        Me.Cmd06.TabIndex = 37
        Me.Cmd06.TabStop = False
        Me.Cmd06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd06.UseVisualStyleBackColor = True
        '
        'Cmd05
        '
        Me.Cmd05.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd05.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd05.Location = New System.Drawing.Point(339, 1)
        Me.Cmd05.Name = "Cmd05"
        Me.Cmd05.Size = New System.Drawing.Size(84, 44)
        Me.Cmd05.TabIndex = 3
        Me.Cmd05.TabStop = False
        Me.Cmd05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd05.UseVisualStyleBackColor = True
        '
        'Cmd04
        '
        Me.Cmd04.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd04.ForeColor = System.Drawing.Color.Red
        Me.Cmd04.Location = New System.Drawing.Point(253, 1)
        Me.Cmd04.Name = "Cmd04"
        Me.Cmd04.Size = New System.Drawing.Size(84, 44)
        Me.Cmd04.TabIndex = 2
        Me.Cmd04.TabStop = False
        Me.Cmd04.UseVisualStyleBackColor = True
        '
        'Cmd11
        '
        Me.Cmd11.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd11.Location = New System.Drawing.Point(841, 1)
        Me.Cmd11.Name = "Cmd11"
        Me.Cmd11.Size = New System.Drawing.Size(84, 44)
        Me.Cmd11.TabIndex = 5
        Me.Cmd11.TabStop = False
        Me.Cmd11.UseVisualStyleBackColor = True
        '
        'Cmd12
        '
        Me.Cmd12.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd12.Location = New System.Drawing.Point(924, 1)
        Me.Cmd12.Name = "Cmd12"
        Me.Cmd12.Size = New System.Drawing.Size(84, 44)
        Me.Cmd12.TabIndex = 1
        Me.Cmd12.Text = "F12　検索"
        Me.Cmd12.UseVisualStyleBackColor = True
        '
        'GroupBox00
        '
        Me.GroupBox00.Controls.Add(Me.LV)
        Me.GroupBox00.Location = New System.Drawing.Point(4, 41)
        Me.GroupBox00.Name = "GroupBox00"
        Me.GroupBox00.Size = New System.Drawing.Size(1004, 144)
        Me.GroupBox00.TabIndex = 2
        Me.GroupBox00.TabStop = False
        '
        'LV
        '
        Me.LV.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LVNo, Me.LV処理日時, Me.LV対象年月, Me.LV処理})
        Me.LV.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.HideSelection = False
        Me.LV.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LV.Location = New System.Drawing.Point(6, 12)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(551, 126)
        Me.LV.TabIndex = 4
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'LVNo
        '
        Me.LVNo.Text = "No"
        '
        'LV処理日時
        '
        Me.LV処理日時.Text = "処理日時"
        Me.LV処理日時.Width = 158
        '
        'LV対象年月
        '
        Me.LV対象年月.Text = "対象年月"
        Me.LV対象年月.Width = 115
        '
        'LV処理
        '
        Me.LV処理.Text = "処理"
        Me.LV処理.Width = 200
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox10.Controls.Add(Me.txt決算期)
        Me.GroupBox10.Controls.Add(Me.txt処理No)
        Me.GroupBox10.Controls.Add(Me.txt開始日)
        Me.GroupBox10.Controls.Add(Me.txt終了日)
        Me.GroupBox10.Controls.Add(Me.btn11)
        Me.GroupBox10.Controls.Add(Me.btn12)
        Me.GroupBox10.Controls.Add(Me.btn10)
        Me.GroupBox10.Controls.Add(Me.btn9)
        Me.GroupBox10.Controls.Add(Me.btn8)
        Me.GroupBox10.Controls.Add(Me.btn7)
        Me.GroupBox10.Controls.Add(Me.btn6)
        Me.GroupBox10.Controls.Add(Me.btn5)
        Me.GroupBox10.Controls.Add(Me.btn4)
        Me.GroupBox10.Controls.Add(Me.btn3)
        Me.GroupBox10.Controls.Add(Me.btn2)
        Me.GroupBox10.Controls.Add(Me.La対象年月)
        Me.GroupBox10.Controls.Add(Me.CmbA)
        Me.GroupBox10.Controls.Add(Me.La年度)
        Me.GroupBox10.Controls.Add(Me.txt締月)
        Me.GroupBox10.Controls.Add(Me.btn1)
        Me.GroupBox10.Location = New System.Drawing.Point(4, 181)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1004, 78)
        Me.GroupBox10.TabIndex = 241
        Me.GroupBox10.TabStop = False
        '
        'txt決算期
        '
        Me.txt決算期.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt決算期.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt決算期.Location = New System.Drawing.Point(656, 42)
        Me.txt決算期.MaxLength = 2
        Me.txt決算期.Multiline = True
        Me.txt決算期.Name = "txt決算期"
        Me.txt決算期.ReadOnly = True
        Me.txt決算期.Size = New System.Drawing.Size(19, 32)
        Me.txt決算期.TabIndex = 10008
        Me.txt決算期.TabStop = False
        Me.txt決算期.Text = "決" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "算" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "期"
        Me.txt決算期.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt処理No
        '
        Me.txt処理No.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt処理No.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt処理No.Location = New System.Drawing.Point(636, 42)
        Me.txt処理No.MaxLength = 2
        Me.txt処理No.Multiline = True
        Me.txt処理No.Name = "txt処理No"
        Me.txt処理No.ReadOnly = True
        Me.txt処理No.Size = New System.Drawing.Size(19, 32)
        Me.txt処理No.TabIndex = 10007
        Me.txt処理No.TabStop = False
        Me.txt処理No.Text = "処理No"
        Me.txt処理No.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt開始日
        '
        Me.txt開始日.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt開始日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt開始日.Location = New System.Drawing.Point(212, 42)
        Me.txt開始日.MaxLength = 10
        Me.txt開始日.Multiline = True
        Me.txt開始日.Name = "txt開始日"
        Me.txt開始日.ReadOnly = True
        Me.txt開始日.Size = New System.Drawing.Size(113, 27)
        Me.txt開始日.TabIndex = 10006
        Me.txt開始日.TabStop = False
        Me.txt開始日.Text = "9999/99/99"
        Me.txt開始日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt終了日
        '
        Me.txt終了日.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt終了日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt終了日.Location = New System.Drawing.Point(326, 42)
        Me.txt終了日.MaxLength = 10
        Me.txt終了日.Multiline = True
        Me.txt終了日.Name = "txt終了日"
        Me.txt終了日.ReadOnly = True
        Me.txt終了日.Size = New System.Drawing.Size(113, 27)
        Me.txt終了日.TabIndex = 16
        Me.txt終了日.TabStop = False
        Me.txt終了日.Text = "9999/99/99"
        Me.txt終了日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn11
        '
        Me.btn11.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn11.Location = New System.Drawing.Point(850, 13)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(68, 26)
        Me.btn11.TabIndex = 11
        Me.btn11.Text = "02月"
        Me.btn11.UseVisualStyleBackColor = True
        '
        'btn12
        '
        Me.btn12.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn12.Location = New System.Drawing.Point(917, 13)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(68, 26)
        Me.btn12.TabIndex = 12
        Me.btn12.Text = "03月"
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn10.Location = New System.Drawing.Point(783, 13)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(68, 26)
        Me.btn10.TabIndex = 10
        Me.btn10.Text = "01月"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn9.Location = New System.Drawing.Point(716, 13)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(68, 26)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "12月"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn8.Location = New System.Drawing.Point(649, 13)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(68, 26)
        Me.btn8.TabIndex = 8
        Me.btn8.Text = "11月"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn7.Location = New System.Drawing.Point(582, 13)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(68, 26)
        Me.btn7.TabIndex = 7
        Me.btn7.Text = "10月"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn6.Location = New System.Drawing.Point(515, 13)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(68, 26)
        Me.btn6.TabIndex = 6
        Me.btn6.Text = "09月"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn5.Location = New System.Drawing.Point(448, 13)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(68, 26)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "08月"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn4.Location = New System.Drawing.Point(381, 13)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(68, 26)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "07月"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn3.Location = New System.Drawing.Point(314, 13)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(68, 26)
        Me.btn3.TabIndex = 3
        Me.btn3.Text = "06月"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn2.Location = New System.Drawing.Point(247, 13)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(68, 26)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "05月"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'La対象年月
        '
        Me.La対象年月.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La対象年月.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La対象年月.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La対象年月.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La対象年月.ForeColor = System.Drawing.Color.White
        Me.La対象年月.Location = New System.Drawing.Point(3, 42)
        Me.La対象年月.Name = "La対象年月"
        Me.La対象年月.Size = New System.Drawing.Size(93, 27)
        Me.La対象年月.TabIndex = 10004
        Me.La対象年月.Text = "対象年度"
        Me.La対象年月.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbA
        '
        Me.CmbA.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CmbA.FormattingEnabled = True
        Me.CmbA.Location = New System.Drawing.Point(96, 11)
        Me.CmbA.Name = "CmbA"
        Me.CmbA.Size = New System.Drawing.Size(78, 28)
        Me.CmbA.TabIndex = 0
        Me.CmbA.Text = "2022"
        '
        'La年度
        '
        Me.La年度.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La年度.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La年度.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La年度.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La年度.ForeColor = System.Drawing.Color.White
        Me.La年度.Location = New System.Drawing.Point(3, 11)
        Me.La年度.Name = "La年度"
        Me.La年度.Size = New System.Drawing.Size(93, 28)
        Me.La年度.TabIndex = 37
        Me.La年度.Text = "年度"
        Me.La年度.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt締月
        '
        Me.txt締月.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt締月.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt締月.Location = New System.Drawing.Point(98, 42)
        Me.txt締月.MaxLength = 8
        Me.txt締月.Multiline = True
        Me.txt締月.Name = "txt締月"
        Me.txt締月.ReadOnly = True
        Me.txt締月.Size = New System.Drawing.Size(113, 27)
        Me.txt締月.TabIndex = 15
        Me.txt締月.TabStop = False
        Me.txt締月.Text = "9999年99月"
        Me.txt締月.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn1.Location = New System.Drawing.Point(180, 12)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(68, 26)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "04月"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'La科目CD
        '
        Me.La科目CD.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La科目CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La科目CD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La科目CD.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.La科目CD.ForeColor = System.Drawing.Color.White
        Me.La科目CD.Location = New System.Drawing.Point(439, 14)
        Me.La科目CD.Name = "La科目CD"
        Me.La科目CD.Size = New System.Drawing.Size(93, 27)
        Me.La科目CD.TabIndex = 6
        Me.La科目CD.Text = "科目CD"
        Me.La科目CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.txtLog)
        Me.GroupBox20.Controls.Add(Me.txtMsg)
        Me.GroupBox20.Controls.Add(Me.CmbB)
        Me.GroupBox20.Controls.Add(Me.txt科目CDTo名)
        Me.GroupBox20.Controls.Add(Me.btnUp00)
        Me.GroupBox20.Controls.Add(Me.txt取引先CDFrom名)
        Me.GroupBox20.Controls.Add(Me.txt取引先CDTo名)
        Me.GroupBox20.Controls.Add(Me.txt取引先CDTo)
        Me.GroupBox20.Controls.Add(Me.txt取引先CDFrom)
        Me.GroupBox20.Controls.Add(Me.txt科目CDTo)
        Me.GroupBox20.Controls.Add(Me.LaTo2)
        Me.GroupBox20.Controls.Add(Me.LaFrom2)
        Me.GroupBox20.Controls.Add(Me.La科目To1)
        Me.GroupBox20.Controls.Add(Me.La取引先CD)
        Me.GroupBox20.Controls.Add(Me.txt伝票開始番号)
        Me.GroupBox20.Controls.Add(Me.txt支払指定開始日)
        Me.GroupBox20.Controls.Add(Me.La科目CD)
        Me.GroupBox20.Controls.Add(Me.txt伝票日付終了日)
        Me.GroupBox20.Controls.Add(Me.txt伝票終了番号)
        Me.GroupBox20.Controls.Add(Me.txt支払指定終了日)
        Me.GroupBox20.Controls.Add(Me.txtから2)
        Me.GroupBox20.Controls.Add(Me.txtから3)
        Me.GroupBox20.Controls.Add(Me.txtから1)
        Me.GroupBox20.Controls.Add(Me.La支払指定日)
        Me.GroupBox20.Controls.Add(Me.La伝票番号)
        Me.GroupBox20.Controls.Add(Me.txt科目CDFrom名)
        Me.GroupBox20.Controls.Add(Me.txt処理対象仕訳)
        Me.GroupBox20.Controls.Add(Me.txt伝票日付開始日)
        Me.GroupBox20.Controls.Add(Me.txt科目CDFrom)
        Me.GroupBox20.Controls.Add(Me.La伝票日付)
        Me.GroupBox20.Controls.Add(Me.La科目From1)
        Me.GroupBox20.Controls.Add(Me.La処理対象仕訳)
        Me.GroupBox20.Controls.Add(Me.La抽出範囲指定)
        Me.GroupBox20.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox20.Location = New System.Drawing.Point(4, 251)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(1004, 375)
        Me.GroupBox20.TabIndex = 9999
        Me.GroupBox20.TabStop = False
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.SystemColors.Window
        Me.txtLog.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtLog.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtLog.Location = New System.Drawing.Point(182, 192)
        Me.txtLog.MaxLength = 0
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(638, 135)
        Me.txtLog.TabIndex = 10000
        Me.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLog.Visible = False
        '
        'txtMsg
        '
        Me.txtMsg.BackColor = System.Drawing.SystemColors.Control
        Me.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMsg.ForeColor = System.Drawing.Color.Red
        Me.txtMsg.Location = New System.Drawing.Point(1, 159)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(262, 20)
        Me.txtMsg.TabIndex = 10000
        Me.txtMsg.Text = "エラーメッセージ"
        '
        'CmbB
        '
        Me.CmbB.FormattingEnabled = True
        Me.CmbB.Location = New System.Drawing.Point(118, 129)
        Me.CmbB.Name = "CmbB"
        Me.CmbB.Size = New System.Drawing.Size(121, 28)
        Me.CmbB.TabIndex = 13
        Me.CmbB.Text = "全件インポート"
        '
        'txt科目CDTo名
        '
        Me.txt科目CDTo名.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt科目CDTo名.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt科目CDTo名.Location = New System.Drawing.Point(667, 42)
        Me.txt科目CDTo名.MaxLength = 10
        Me.txt科目CDTo名.Multiline = True
        Me.txt科目CDTo名.Name = "txt科目CDTo名"
        Me.txt科目CDTo名.ReadOnly = True
        Me.txt科目CDTo名.Size = New System.Drawing.Size(307, 27)
        Me.txt科目CDTo名.TabIndex = 10010
        Me.txt科目CDTo名.Text = "zzzzzzzzz1zzzzzzzzz2zzzzzzzzz3"
        '
        'btnUp00
        '
        Me.btnUp00.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnUp00.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnUp00.Location = New System.Drawing.Point(1, 192)
        Me.btnUp00.Name = "btnUp00"
        Me.btnUp00.Size = New System.Drawing.Size(151, 49)
        Me.btnUp00.TabIndex = 14
        Me.btnUp00.Text = "集計実行"
        Me.btnUp00.UseVisualStyleBackColor = True
        '
        'txt取引先CDFrom名
        '
        Me.txt取引先CDFrom名.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取引先CDFrom名.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt取引先CDFrom名.Location = New System.Drawing.Point(667, 70)
        Me.txt取引先CDFrom名.MaxLength = 10
        Me.txt取引先CDFrom名.Multiline = True
        Me.txt取引先CDFrom名.Name = "txt取引先CDFrom名"
        Me.txt取引先CDFrom名.ReadOnly = True
        Me.txt取引先CDFrom名.Size = New System.Drawing.Size(307, 27)
        Me.txt取引先CDFrom名.TabIndex = 10009
        Me.txt取引先CDFrom名.Text = "zzzzzzzzz1zzzzzzzzz2zzzzzzzzz3"
        '
        'txt取引先CDTo名
        '
        Me.txt取引先CDTo名.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取引先CDTo名.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt取引先CDTo名.Location = New System.Drawing.Point(667, 98)
        Me.txt取引先CDTo名.MaxLength = 10
        Me.txt取引先CDTo名.Multiline = True
        Me.txt取引先CDTo名.Name = "txt取引先CDTo名"
        Me.txt取引先CDTo名.ReadOnly = True
        Me.txt取引先CDTo名.Size = New System.Drawing.Size(307, 27)
        Me.txt取引先CDTo名.TabIndex = 10008
        Me.txt取引先CDTo名.Text = "zzzzzzzzz1zzzzzzzzz2zzzzzzzzz3"
        '
        'txt取引先CDTo
        '
        Me.txt取引先CDTo.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取引先CDTo.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt取引先CDTo.Location = New System.Drawing.Point(583, 98)
        Me.txt取引先CDTo.MaxLength = 8
        Me.txt取引先CDTo.Multiline = True
        Me.txt取引先CDTo.Name = "txt取引先CDTo"
        Me.txt取引先CDTo.Size = New System.Drawing.Size(83, 27)
        Me.txt取引先CDTo.TabIndex = 11
        Me.txt取引先CDTo.Text = "99999999"
        Me.txt取引先CDTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt取引先CDFrom
        '
        Me.txt取引先CDFrom.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt取引先CDFrom.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt取引先CDFrom.Location = New System.Drawing.Point(583, 70)
        Me.txt取引先CDFrom.MaxLength = 8
        Me.txt取引先CDFrom.Multiline = True
        Me.txt取引先CDFrom.Name = "txt取引先CDFrom"
        Me.txt取引先CDFrom.Size = New System.Drawing.Size(83, 27)
        Me.txt取引先CDFrom.TabIndex = 10
        Me.txt取引先CDFrom.Text = "99999999"
        Me.txt取引先CDFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt科目CDTo
        '
        Me.txt科目CDTo.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt科目CDTo.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt科目CDTo.Location = New System.Drawing.Point(583, 42)
        Me.txt科目CDTo.MaxLength = 8
        Me.txt科目CDTo.Multiline = True
        Me.txt科目CDTo.Name = "txt科目CDTo"
        Me.txt科目CDTo.Size = New System.Drawing.Size(83, 27)
        Me.txt科目CDTo.TabIndex = 8
        Me.txt科目CDTo.Text = "99999999"
        Me.txt科目CDTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LaTo2
        '
        Me.LaTo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.LaTo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LaTo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaTo2.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.LaTo2.ForeColor = System.Drawing.Color.White
        Me.LaTo2.Location = New System.Drawing.Point(532, 98)
        Me.LaTo2.Name = "LaTo2"
        Me.LaTo2.Size = New System.Drawing.Size(51, 27)
        Me.LaTo2.TabIndex = 10004
        Me.LaTo2.Text = "To"
        Me.LaTo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaFrom2
        '
        Me.LaFrom2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.LaFrom2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LaFrom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaFrom2.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.LaFrom2.ForeColor = System.Drawing.Color.White
        Me.LaFrom2.Location = New System.Drawing.Point(532, 70)
        Me.LaFrom2.Name = "LaFrom2"
        Me.LaFrom2.Size = New System.Drawing.Size(51, 27)
        Me.LaFrom2.TabIndex = 10003
        Me.LaFrom2.Text = "From"
        Me.LaFrom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La科目To1
        '
        Me.La科目To1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La科目To1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La科目To1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La科目To1.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.La科目To1.ForeColor = System.Drawing.Color.White
        Me.La科目To1.Location = New System.Drawing.Point(532, 42)
        Me.La科目To1.Name = "La科目To1"
        Me.La科目To1.Size = New System.Drawing.Size(51, 27)
        Me.La科目To1.TabIndex = 10002
        Me.La科目To1.Text = "To"
        Me.La科目To1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La取引先CD
        '
        Me.La取引先CD.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La取引先CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La取引先CD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La取引先CD.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.La取引先CD.ForeColor = System.Drawing.Color.White
        Me.La取引先CD.Location = New System.Drawing.Point(439, 70)
        Me.La取引先CD.Name = "La取引先CD"
        Me.La取引先CD.Size = New System.Drawing.Size(93, 27)
        Me.La取引先CD.TabIndex = 9
        Me.La取引先CD.Text = "取引先CD"
        Me.La取引先CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt伝票開始番号
        '
        Me.txt伝票開始番号.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt伝票開始番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt伝票開始番号.Location = New System.Drawing.Point(182, 42)
        Me.txt伝票開始番号.MaxLength = 8
        Me.txt伝票開始番号.Multiline = True
        Me.txt伝票開始番号.Name = "txt伝票開始番号"
        Me.txt伝票開始番号.Size = New System.Drawing.Size(113, 27)
        Me.txt伝票開始番号.TabIndex = 2
        Me.txt伝票開始番号.Text = "99999999"
        Me.txt伝票開始番号.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt支払指定開始日
        '
        Me.txt支払指定開始日.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt支払指定開始日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt支払指定開始日.Location = New System.Drawing.Point(182, 70)
        Me.txt支払指定開始日.MaxLength = 8
        Me.txt支払指定開始日.Multiline = True
        Me.txt支払指定開始日.Name = "txt支払指定開始日"
        Me.txt支払指定開始日.Size = New System.Drawing.Size(113, 27)
        Me.txt支払指定開始日.TabIndex = 4
        Me.txt支払指定開始日.Text = "9999/99/99"
        Me.txt支払指定開始日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt伝票日付終了日
        '
        Me.txt伝票日付終了日.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt伝票日付終了日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt伝票日付終了日.Location = New System.Drawing.Point(320, 14)
        Me.txt伝票日付終了日.MaxLength = 10
        Me.txt伝票日付終了日.Multiline = True
        Me.txt伝票日付終了日.Name = "txt伝票日付終了日"
        Me.txt伝票日付終了日.Size = New System.Drawing.Size(113, 27)
        Me.txt伝票日付終了日.TabIndex = 1
        Me.txt伝票日付終了日.Text = "9999/99/99"
        Me.txt伝票日付終了日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt伝票終了番号
        '
        Me.txt伝票終了番号.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt伝票終了番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt伝票終了番号.Location = New System.Drawing.Point(320, 42)
        Me.txt伝票終了番号.MaxLength = 8
        Me.txt伝票終了番号.Multiline = True
        Me.txt伝票終了番号.Name = "txt伝票終了番号"
        Me.txt伝票終了番号.Size = New System.Drawing.Size(113, 27)
        Me.txt伝票終了番号.TabIndex = 3
        Me.txt伝票終了番号.Text = "99999999"
        Me.txt伝票終了番号.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt支払指定終了日
        '
        Me.txt支払指定終了日.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt支払指定終了日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt支払指定終了日.Location = New System.Drawing.Point(320, 70)
        Me.txt支払指定終了日.MaxLength = 8
        Me.txt支払指定終了日.Multiline = True
        Me.txt支払指定終了日.Name = "txt支払指定終了日"
        Me.txt支払指定終了日.Size = New System.Drawing.Size(113, 27)
        Me.txt支払指定終了日.TabIndex = 5
        Me.txt支払指定終了日.Text = "9999/99/99"
        Me.txt支払指定終了日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtから2
        '
        Me.txtから2.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtから2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtから2.Location = New System.Drawing.Point(296, 42)
        Me.txtから2.MaxLength = 10
        Me.txtから2.Multiline = True
        Me.txtから2.Name = "txtから2"
        Me.txtから2.ReadOnly = True
        Me.txtから2.Size = New System.Drawing.Size(23, 27)
        Me.txtから2.TabIndex = 44
        Me.txtから2.TabStop = False
        Me.txtから2.Text = "~"
        Me.txtから2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtから3
        '
        Me.txtから3.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtから3.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtから3.Location = New System.Drawing.Point(296, 70)
        Me.txtから3.MaxLength = 10
        Me.txtから3.Multiline = True
        Me.txtから3.Name = "txtから3"
        Me.txtから3.ReadOnly = True
        Me.txtから3.Size = New System.Drawing.Size(23, 27)
        Me.txtから3.TabIndex = 43
        Me.txtから3.TabStop = False
        Me.txtから3.Text = "~"
        Me.txtから3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtから1
        '
        Me.txtから1.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtから1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtから1.Location = New System.Drawing.Point(296, 14)
        Me.txtから1.MaxLength = 10
        Me.txtから1.Multiline = True
        Me.txtから1.Name = "txtから1"
        Me.txtから1.ReadOnly = True
        Me.txtから1.Size = New System.Drawing.Size(23, 27)
        Me.txtから1.TabIndex = 42
        Me.txtから1.TabStop = False
        Me.txtから1.Text = "~"
        Me.txtから1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'La支払指定日
        '
        Me.La支払指定日.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La支払指定日.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La支払指定日.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La支払指定日.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La支払指定日.ForeColor = System.Drawing.Color.White
        Me.La支払指定日.Location = New System.Drawing.Point(94, 70)
        Me.La支払指定日.Name = "La支払指定日"
        Me.La支払指定日.Size = New System.Drawing.Size(88, 27)
        Me.La支払指定日.TabIndex = 41
        Me.La支払指定日.Text = "支払指定日"
        Me.La支払指定日.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La伝票番号
        '
        Me.La伝票番号.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La伝票番号.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La伝票番号.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La伝票番号.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La伝票番号.ForeColor = System.Drawing.Color.White
        Me.La伝票番号.Location = New System.Drawing.Point(94, 42)
        Me.La伝票番号.Name = "La伝票番号"
        Me.La伝票番号.Size = New System.Drawing.Size(88, 27)
        Me.La伝票番号.TabIndex = 40
        Me.La伝票番号.Text = "伝票番号"
        Me.La伝票番号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt科目CDFrom名
        '
        Me.txt科目CDFrom名.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt科目CDFrom名.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt科目CDFrom名.Location = New System.Drawing.Point(667, 14)
        Me.txt科目CDFrom名.MaxLength = 10
        Me.txt科目CDFrom名.Multiline = True
        Me.txt科目CDFrom名.Name = "txt科目CDFrom名"
        Me.txt科目CDFrom名.ReadOnly = True
        Me.txt科目CDFrom名.Size = New System.Drawing.Size(307, 27)
        Me.txt科目CDFrom名.TabIndex = 39
        Me.txt科目CDFrom名.Text = "zzzzzzzzz1zzzzzzzzz2zzzzzzzzz3"
        '
        'txt処理対象仕訳
        '
        Me.txt処理対象仕訳.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt処理対象仕訳.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt処理対象仕訳.Location = New System.Drawing.Point(95, 130)
        Me.txt処理対象仕訳.MaxLength = 1
        Me.txt処理対象仕訳.Multiline = True
        Me.txt処理対象仕訳.Name = "txt処理対象仕訳"
        Me.txt処理対象仕訳.Size = New System.Drawing.Size(22, 27)
        Me.txt処理対象仕訳.TabIndex = 12
        Me.txt処理対象仕訳.TabStop = False
        Me.txt処理対象仕訳.Text = "1"
        Me.txt処理対象仕訳.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt伝票日付開始日
        '
        Me.txt伝票日付開始日.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt伝票日付開始日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt伝票日付開始日.Location = New System.Drawing.Point(182, 14)
        Me.txt伝票日付開始日.MaxLength = 10
        Me.txt伝票日付開始日.Multiline = True
        Me.txt伝票日付開始日.Name = "txt伝票日付開始日"
        Me.txt伝票日付開始日.Size = New System.Drawing.Size(113, 27)
        Me.txt伝票日付開始日.TabIndex = 0
        Me.txt伝票日付開始日.Text = "9999/99/99"
        Me.txt伝票日付開始日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt科目CDFrom
        '
        Me.txt科目CDFrom.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt科目CDFrom.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt科目CDFrom.Location = New System.Drawing.Point(583, 14)
        Me.txt科目CDFrom.MaxLength = 8
        Me.txt科目CDFrom.Multiline = True
        Me.txt科目CDFrom.Name = "txt科目CDFrom"
        Me.txt科目CDFrom.Size = New System.Drawing.Size(83, 27)
        Me.txt科目CDFrom.TabIndex = 7
        Me.txt科目CDFrom.Text = "99999999"
        Me.txt科目CDFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'La伝票日付
        '
        Me.La伝票日付.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La伝票日付.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La伝票日付.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La伝票日付.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La伝票日付.ForeColor = System.Drawing.Color.White
        Me.La伝票日付.Location = New System.Drawing.Point(94, 14)
        Me.La伝票日付.Name = "La伝票日付"
        Me.La伝票日付.Size = New System.Drawing.Size(88, 27)
        Me.La伝票日付.TabIndex = 39
        Me.La伝票日付.Text = "伝票日付"
        Me.La伝票日付.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La科目From1
        '
        Me.La科目From1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La科目From1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La科目From1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La科目From1.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.La科目From1.ForeColor = System.Drawing.Color.White
        Me.La科目From1.Location = New System.Drawing.Point(532, 14)
        Me.La科目From1.Name = "La科目From1"
        Me.La科目From1.Size = New System.Drawing.Size(51, 27)
        Me.La科目From1.TabIndex = 20
        Me.La科目From1.Text = "From"
        Me.La科目From1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La処理対象仕訳
        '
        Me.La処理対象仕訳.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La処理対象仕訳.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La処理対象仕訳.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La処理対象仕訳.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La処理対象仕訳.ForeColor = System.Drawing.Color.White
        Me.La処理対象仕訳.Location = New System.Drawing.Point(1, 130)
        Me.La処理対象仕訳.Name = "La処理対象仕訳"
        Me.La処理対象仕訳.Size = New System.Drawing.Size(93, 27)
        Me.La処理対象仕訳.TabIndex = 26
        Me.La処理対象仕訳.Text = "処理対象仕訳"
        Me.La処理対象仕訳.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La抽出範囲指定
        '
        Me.La抽出範囲指定.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La抽出範囲指定.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La抽出範囲指定.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La抽出範囲指定.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La抽出範囲指定.ForeColor = System.Drawing.Color.White
        Me.La抽出範囲指定.Location = New System.Drawing.Point(1, 14)
        Me.La抽出範囲指定.Name = "La抽出範囲指定"
        Me.La抽出範囲指定.Size = New System.Drawing.Size(93, 27)
        Me.La抽出範囲指定.TabIndex = 25
        Me.La抽出範囲指定.Text = "抽出範囲指定"
        Me.La抽出範囲指定.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F_Si_SiwGet00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 631)
        Me.Controls.Add(Me.Cmd12)
        Me.Controls.Add(Me.Cmd11)
        Me.Controls.Add(Me.Cmd10)
        Me.Controls.Add(Me.Cmd08)
        Me.Controls.Add(Me.Cmd07)
        Me.Controls.Add(Me.Cmd06)
        Me.Controls.Add(Me.Cmd04)
        Me.Controls.Add(Me.Cmd05)
        Me.Controls.Add(Me.Cmd09)
        Me.Controls.Add(Me.Cmd03)
        Me.Controls.Add(Me.Cmd02)
        Me.Controls.Add(Cmd01)
        Me.Controls.Add(Me.GroupBox00)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox20)
        Me.ForeColor = System.Drawing.Color.Red
        Me.KeyPreview = True
        Me.Name = "F_Si_SiwGet00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " 財務データインポート処理"
        Me.GroupBox00.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cmd02 As System.Windows.Forms.Button
    Friend WithEvents Cmd03 As System.Windows.Forms.Button
    Friend WithEvents Cmd10 As System.Windows.Forms.Button
    Friend WithEvents Cmd09 As System.Windows.Forms.Button
    Friend WithEvents Cmd08 As System.Windows.Forms.Button
    Friend WithEvents Cmd07 As System.Windows.Forms.Button
    Friend WithEvents Cmd06 As System.Windows.Forms.Button
    Friend WithEvents Cmd05 As System.Windows.Forms.Button
    Friend WithEvents Cmd04 As System.Windows.Forms.Button
    Friend WithEvents Cmd11 As System.Windows.Forms.Button
    Friend WithEvents Cmd12 As System.Windows.Forms.Button
    Friend WithEvents GroupBox00 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUp00 As Button
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents La年度 As Label
    Friend WithEvents La処理対象仕訳 As Label
    Friend WithEvents La抽出範囲指定 As Label
    Friend WithEvents La伝票日付 As Label
    Friend WithEvents La科目From1 As Label
    Friend WithEvents txt締月 As TextBox
    Friend WithEvents txt伝票日付開始日 As TextBox
    Friend WithEvents txt科目CDFrom As TextBox
    Friend WithEvents txt処理対象仕訳 As TextBox
    Friend WithEvents txt科目CDFrom名 As TextBox
    Friend WithEvents La科目CD As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents CmbA As ComboBox
    Friend WithEvents btn11 As Button
    Friend WithEvents btn12 As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents La対象年月 As Label
    Friend WithEvents txt開始日 As TextBox
    Friend WithEvents txt終了日 As TextBox
    Friend WithEvents txtから1 As TextBox
    Friend WithEvents La支払指定日 As Label
    Friend WithEvents La伝票番号 As Label
    Friend WithEvents txt伝票開始番号 As TextBox
    Friend WithEvents txt支払指定開始日 As TextBox
    Friend WithEvents txt伝票日付終了日 As TextBox
    Friend WithEvents txt伝票終了番号 As TextBox
    Friend WithEvents txt支払指定終了日 As TextBox
    Friend WithEvents txtから2 As TextBox
    Friend WithEvents txtから3 As TextBox
    Friend WithEvents La取引先CD As Label
    Friend WithEvents LaTo2 As Label
    Friend WithEvents LaFrom2 As Label
    Friend WithEvents La科目To1 As Label
    Friend WithEvents txt科目CDTo名 As TextBox
    Friend WithEvents txt取引先CDFrom名 As TextBox
    Friend WithEvents txt取引先CDTo名 As TextBox
    Friend WithEvents txt取引先CDTo As TextBox
    Friend WithEvents txt取引先CDFrom As TextBox
    Friend WithEvents txt科目CDTo As TextBox
    Friend WithEvents CmbB As ComboBox
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents txt決算期 As TextBox
    Friend WithEvents txt処理No As TextBox
    Friend WithEvents LV As ListView
    Friend WithEvents LVNo As ColumnHeader
    Friend WithEvents LV処理日時 As ColumnHeader
    Friend WithEvents LV対象年月 As ColumnHeader
    Friend WithEvents LV処理 As ColumnHeader
    Friend WithEvents txtLog As TextBox
End Class
