<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Si_GtSum00
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"00", "9999", "99", "9999/99/99", "99", "9999/99/99 99:99:99", "9999/99/99 99:99:99"}, -1)
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItem00 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem01 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem02 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox00 = New System.Windows.Forms.GroupBox()
        Me.btnOK00 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt支払No = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt支払年度 = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txt支払日 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.btnUp00 = New System.Windows.Forms.Button()
        Me.txt支払月 = New System.Windows.Forms.TextBox()
        Me.txt支払予定日 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LV = New System.Windows.Forms.ListView()
        Me.LVNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV年度 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV支払No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV支払日 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVCD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV集計日 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV完了日 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Cmd01 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox00.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmd01
        '
        Cmd01.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Cmd01.ForeColor = System.Drawing.Color.Blue
        Cmd01.Location = New System.Drawing.Point(1, 28)
        Cmd01.Name = "Cmd01"
        Cmd01.Size = New System.Drawing.Size(67, 39)
        Cmd01.TabIndex = 1
        Cmd01.TabStop = False
        Cmd01.UseVisualStyleBackColor = True
        '
        'Cmd02
        '
        Me.Cmd02.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd02.Location = New System.Drawing.Point(67, 28)
        Me.Cmd02.Name = "Cmd02"
        Me.Cmd02.Size = New System.Drawing.Size(67, 39)
        Me.Cmd02.TabIndex = 31
        Me.Cmd02.TabStop = False
        Me.Cmd02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd02.UseVisualStyleBackColor = True
        '
        'Cmd03
        '
        Me.Cmd03.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd03.Location = New System.Drawing.Point(133, 28)
        Me.Cmd03.Name = "Cmd03"
        Me.Cmd03.Size = New System.Drawing.Size(67, 39)
        Me.Cmd03.TabIndex = 32
        Me.Cmd03.TabStop = False
        Me.Cmd03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd03.UseVisualStyleBackColor = True
        '
        'Cmd10
        '
        Me.Cmd10.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd10.Location = New System.Drawing.Point(605, 28)
        Me.Cmd10.Name = "Cmd10"
        Me.Cmd10.Size = New System.Drawing.Size(67, 39)
        Me.Cmd10.TabIndex = 0
        Me.Cmd10.Text = "F10 終了"
        Me.Cmd10.UseVisualStyleBackColor = True
        '
        'Cmd09
        '
        Me.Cmd09.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd09.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd09.Location = New System.Drawing.Point(539, 28)
        Me.Cmd09.Name = "Cmd09"
        Me.Cmd09.Size = New System.Drawing.Size(67, 39)
        Me.Cmd09.TabIndex = 1
        Me.Cmd09.TabStop = False
        Me.Cmd09.UseVisualStyleBackColor = True
        '
        'Cmd08
        '
        Me.Cmd08.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd08.Location = New System.Drawing.Point(468, 28)
        Me.Cmd08.Name = "Cmd08"
        Me.Cmd08.Size = New System.Drawing.Size(67, 39)
        Me.Cmd08.TabIndex = 35
        Me.Cmd08.TabStop = False
        Me.Cmd08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd08.UseVisualStyleBackColor = True
        '
        'Cmd07
        '
        Me.Cmd07.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd07.Location = New System.Drawing.Point(402, 28)
        Me.Cmd07.Name = "Cmd07"
        Me.Cmd07.Size = New System.Drawing.Size(67, 39)
        Me.Cmd07.TabIndex = 36
        Me.Cmd07.TabStop = False
        Me.Cmd07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd07.UseVisualStyleBackColor = True
        '
        'Cmd06
        '
        Me.Cmd06.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd06.Location = New System.Drawing.Point(336, 28)
        Me.Cmd06.Name = "Cmd06"
        Me.Cmd06.Size = New System.Drawing.Size(67, 39)
        Me.Cmd06.TabIndex = 37
        Me.Cmd06.TabStop = False
        Me.Cmd06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd06.UseVisualStyleBackColor = True
        '
        'Cmd05
        '
        Me.Cmd05.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd05.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd05.Location = New System.Drawing.Point(270, 28)
        Me.Cmd05.Name = "Cmd05"
        Me.Cmd05.Size = New System.Drawing.Size(67, 39)
        Me.Cmd05.TabIndex = 3
        Me.Cmd05.TabStop = False
        Me.Cmd05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd05.UseVisualStyleBackColor = True
        '
        'Cmd04
        '
        Me.Cmd04.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd04.ForeColor = System.Drawing.Color.Red
        Me.Cmd04.Location = New System.Drawing.Point(199, 28)
        Me.Cmd04.Name = "Cmd04"
        Me.Cmd04.Size = New System.Drawing.Size(67, 39)
        Me.Cmd04.TabIndex = 2
        Me.Cmd04.TabStop = False
        Me.Cmd04.UseVisualStyleBackColor = True
        '
        'Cmd11
        '
        Me.Cmd11.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd11.Location = New System.Drawing.Point(671, 28)
        Me.Cmd11.Name = "Cmd11"
        Me.Cmd11.Size = New System.Drawing.Size(67, 39)
        Me.Cmd11.TabIndex = 5
        Me.Cmd11.TabStop = False
        Me.Cmd11.UseVisualStyleBackColor = True
        '
        'Cmd12
        '
        Me.Cmd12.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd12.Location = New System.Drawing.Point(737, 28)
        Me.Cmd12.Name = "Cmd12"
        Me.Cmd12.Size = New System.Drawing.Size(67, 39)
        Me.Cmd12.TabIndex = 1
        Me.Cmd12.TabStop = False
        Me.Cmd12.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem00, Me.MenuItem01, Me.MenuItem02})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(805, 24)
        Me.MenuStrip1.TabIndex = 240
        Me.MenuStrip1.Text = "ｸﾞﾙｰﾌﾟ体系"
        '
        'MenuItem00
        '
        Me.MenuItem00.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.MenuItem00.Name = "MenuItem00"
        Me.MenuItem00.Size = New System.Drawing.Size(75, 24)
        Me.MenuItem00.Text = "ｺｰﾄﾞ体系"
        Me.MenuItem00.Visible = False
        '
        'MenuItem01
        '
        Me.MenuItem01.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.MenuItem01.Name = "MenuItem01"
        Me.MenuItem01.Size = New System.Drawing.Size(89, 24)
        Me.MenuItem01.Text = "ｸﾞﾙｰﾌﾟ体系"
        Me.MenuItem01.Visible = False
        '
        'MenuItem02
        '
        Me.MenuItem02.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.MenuItem02.Name = "MenuItem02"
        Me.MenuItem02.Size = New System.Drawing.Size(73, 24)
        Me.MenuItem02.Text = "追加情報"
        Me.MenuItem02.Visible = False
        '
        'GroupBox00
        '
        Me.GroupBox00.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox00.Controls.Add(Me.btnOK00)
        Me.GroupBox00.Controls.Add(Me.Label1)
        Me.GroupBox00.Controls.Add(Me.txt支払No)
        Me.GroupBox00.Controls.Add(Me.Label2)
        Me.GroupBox00.Controls.Add(Me.txt支払年度)
        Me.GroupBox00.Location = New System.Drawing.Point(6, 216)
        Me.GroupBox00.Name = "GroupBox00"
        Me.GroupBox00.Size = New System.Drawing.Size(798, 51)
        Me.GroupBox00.TabIndex = 2
        Me.GroupBox00.TabStop = False
        '
        'btnOK00
        '
        Me.btnOK00.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK00.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnOK00.Location = New System.Drawing.Point(258, 15)
        Me.btnOK00.Name = "btnOK00"
        Me.btnOK00.Size = New System.Drawing.Size(151, 34)
        Me.btnOK00.TabIndex = 2
        Me.btnOK00.Text = "支払初期設定"
        Me.btnOK00.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 28)
        Me.Label1.TabIndex = 10002
        Me.Label1.Text = "支払年度"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt支払No
        '
        Me.txt支払No.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt支払No.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt支払No.Location = New System.Drawing.Point(220, 19)
        Me.txt支払No.MaxLength = 2
        Me.txt支払No.Multiline = True
        Me.txt支払No.Name = "txt支払No"
        Me.txt支払No.Size = New System.Drawing.Size(27, 27)
        Me.txt支払No.TabIndex = 1
        Me.txt支払No.TabStop = False
        Me.txt支払No.Text = "99"
        Me.txt支払No.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(141, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 28)
        Me.Label2.TabIndex = 10004
        Me.Label2.Text = "支払No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt支払年度
        '
        Me.txt支払年度.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt支払年度.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt支払年度.Location = New System.Drawing.Point(85, 19)
        Me.txt支払年度.MaxLength = 4
        Me.txt支払年度.Multiline = True
        Me.txt支払年度.Name = "txt支払年度"
        Me.txt支払年度.Size = New System.Drawing.Size(55, 27)
        Me.txt支払年度.TabIndex = 0
        Me.txt支払年度.TabStop = False
        Me.txt支払年度.Text = "9999"
        Me.txt支払年度.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtCount)
        Me.GroupBox10.Controls.Add(Me.txtLog)
        Me.GroupBox10.Controls.Add(Me.txt支払日)
        Me.GroupBox10.Controls.Add(Me.Label3)
        Me.GroupBox10.Controls.Add(Me.txtMsg)
        Me.GroupBox10.Controls.Add(Me.btnUp00)
        Me.GroupBox10.Controls.Add(Me.txt支払月)
        Me.GroupBox10.Controls.Add(Me.txt支払予定日)
        Me.GroupBox10.Controls.Add(Me.Label5)
        Me.GroupBox10.Controls.Add(Me.Label4)
        Me.GroupBox10.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(10, 273)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(795, 261)
        Me.GroupBox10.TabIndex = 3
        Me.GroupBox10.TabStop = False
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.SystemColors.Control
        Me.txtCount.ForeColor = System.Drawing.Color.Black
        Me.txtCount.Location = New System.Drawing.Point(333, 228)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(262, 27)
        Me.txtCount.TabIndex = 10007
        Me.txtCount.Text = "エラーメッセージ"
        '
        'txtLog
        '
        Me.txtLog.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtLog.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtLog.Location = New System.Drawing.Point(333, 9)
        Me.txtLog.MaxLength = 10
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(456, 217)
        Me.txtLog.TabIndex = 10000
        Me.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt支払日
        '
        Me.txt支払日.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt支払日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt支払日.Location = New System.Drawing.Point(93, 39)
        Me.txt支払日.MaxLength = 2
        Me.txt支払日.Multiline = True
        Me.txt支払日.Name = "txt支払日"
        Me.txt支払日.Size = New System.Drawing.Size(25, 27)
        Me.txt支払日.TabIndex = 1
        Me.txt支払日.TabStop = False
        Me.txt支払日.Text = "99"
        Me.txt支払日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 28)
        Me.Label3.TabIndex = 10006
        Me.Label3.Text = "支払日"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMsg
        '
        Me.txtMsg.BackColor = System.Drawing.SystemColors.Control
        Me.txtMsg.ForeColor = System.Drawing.Color.Red
        Me.txtMsg.Location = New System.Drawing.Point(2, 164)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(273, 27)
        Me.txtMsg.TabIndex = 10000
        Me.txtMsg.Text = "エラーメッセージ"
        '
        'btnUp00
        '
        Me.btnUp00.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnUp00.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnUp00.Location = New System.Drawing.Point(2, 192)
        Me.btnUp00.Name = "btnUp00"
        Me.btnUp00.Size = New System.Drawing.Size(151, 34)
        Me.btnUp00.TabIndex = 3
        Me.btnUp00.Text = "集計実行"
        Me.btnUp00.UseVisualStyleBackColor = True
        '
        'txt支払月
        '
        Me.txt支払月.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt支払月.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt支払月.Location = New System.Drawing.Point(93, 12)
        Me.txt支払月.MaxLength = 2
        Me.txt支払月.Multiline = True
        Me.txt支払月.Name = "txt支払月"
        Me.txt支払月.Size = New System.Drawing.Size(25, 27)
        Me.txt支払月.TabIndex = 0
        Me.txt支払月.TabStop = False
        Me.txt支払月.Text = "99"
        Me.txt支払月.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt支払予定日
        '
        Me.txt支払予定日.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt支払予定日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt支払予定日.Location = New System.Drawing.Point(93, 66)
        Me.txt支払予定日.MaxLength = 10
        Me.txt支払予定日.Multiline = True
        Me.txt支払予定日.Name = "txt支払予定日"
        Me.txt支払予定日.Size = New System.Drawing.Size(92, 27)
        Me.txt支払予定日.TabIndex = 2
        Me.txt支払予定日.Text = "9999/99/99"
        Me.txt支払予定日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 28)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "支払予定日"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 28)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "支払月"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LV
        '
        Me.LV.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LVNo, Me.LV年度, Me.LV支払No, Me.LV支払日, Me.LVCD, Me.LV集計日, Me.LV完了日})
        Me.LV.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.HideSelection = False
        Me.LV.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LV.Location = New System.Drawing.Point(3, 73)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(798, 152)
        Me.LV.TabIndex = 1
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'LVNo
        '
        Me.LVNo.Text = "No"
        Me.LVNo.Width = 71
        '
        'LV年度
        '
        Me.LV年度.Text = "年度"
        Me.LV年度.Width = 84
        '
        'LV支払No
        '
        Me.LV支払No.Text = "支払No"
        Me.LV支払No.Width = 72
        '
        'LV支払日
        '
        Me.LV支払日.Text = "支払日"
        Me.LV支払日.Width = 134
        '
        'LVCD
        '
        Me.LVCD.Text = "CD"
        Me.LVCD.Width = 61
        '
        'LV集計日
        '
        Me.LV集計日.Text = "集計日"
        Me.LV集計日.Width = 188
        '
        'LV完了日
        '
        Me.LV完了日.Text = "完了日"
        Me.LV完了日.Width = 182
        '
        'F_Si_GtSum00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 532)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Cmd12)
        Me.Controls.Add(Me.Cmd11)
        Me.Controls.Add(Me.Cmd10)
        Me.Controls.Add(Me.GroupBox10)
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
        Me.ForeColor = System.Drawing.Color.Red
        Me.KeyPreview = True
        Me.Name = "F_Si_GtSum00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "支払開始処理"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox00.ResumeLayout(False)
        Me.GroupBox00.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GroupBox00 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuItem00 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem01 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem02 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUp00 As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt支払予定日 As TextBox
    Friend WithEvents txt支払月 As TextBox
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents txtLog As TextBox
    Friend WithEvents txt支払日 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt支払No As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt支払年度 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOK00 As Button
    Friend WithEvents txtCount As TextBox
    Friend WithEvents LV As ListView
    Friend WithEvents LVNo As ColumnHeader
    Friend WithEvents LV年度 As ColumnHeader
    Friend WithEvents LV支払No As ColumnHeader
    Friend WithEvents LV支払日 As ColumnHeader
    Friend WithEvents LVCD As ColumnHeader
    Friend WithEvents LV集計日 As ColumnHeader
    Friend WithEvents LV完了日 As ColumnHeader
End Class
