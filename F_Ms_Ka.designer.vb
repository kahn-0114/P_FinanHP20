<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Ms_Ka

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
        Me.La課税区分 = New System.Windows.Forms.Label()
        Me.La科目名 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtmsg = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.La貸借区分 = New System.Windows.Forms.Label()
        Me.La科目名ｶﾅ = New System.Windows.Forms.Label()
        Me.txt支店No = New System.Windows.Forms.TextBox()
        Me.btn保存 = New System.Windows.Forms.Button()
        Me.btn削除 = New System.Windows.Forms.Button()
        Me.txt科目名 = New System.Windows.Forms.TextBox()
        Me.GroupBox00 = New System.Windows.Forms.GroupBox()
        Me.btnOK00 = New System.Windows.Forms.Button()
        Me.txt科目CD = New System.Windows.Forms.TextBox()
        Me.La科目CD = New System.Windows.Forms.Label()
        Me.cmba = New System.Windows.Forms.ComboBox()
        Me.cmbb = New System.Windows.Forms.ComboBox()
        Me.txt決算期区分 = New System.Windows.Forms.TextBox()
        Cmd01 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox00.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmd01
        '
        Cmd01.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Cmd01.ForeColor = System.Drawing.Color.Blue
        Cmd01.Location = New System.Drawing.Point(4, 28)
        Cmd01.Name = "Cmd01"
        Cmd01.Size = New System.Drawing.Size(84, 44)
        Cmd01.TabIndex = 1
        Cmd01.TabStop = False
        Cmd01.UseVisualStyleBackColor = True
        AddHandler Cmd01.Click, AddressOf Me.Cmd01_Click
        '
        'Cmd02
        '
        Me.Cmd02.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd02.Location = New System.Drawing.Point(87, 28)
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
        Me.Cmd03.Location = New System.Drawing.Point(170, 28)
        Me.Cmd03.Name = "Cmd03"
        Me.Cmd03.Size = New System.Drawing.Size(84, 44)
        Me.Cmd03.TabIndex = 32
        Me.Cmd03.TabStop = False
        Me.Cmd03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd03.UseVisualStyleBackColor = True
        '
        'Cmd10
        '
        Me.Cmd10.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd10.Location = New System.Drawing.Point(758, 28)
        Me.Cmd10.Name = "Cmd10"
        Me.Cmd10.Size = New System.Drawing.Size(84, 44)
        Me.Cmd10.TabIndex = 3
        Me.Cmd10.Text = "F10　終了"
        Me.Cmd10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd10.UseVisualStyleBackColor = True
        '
        'Cmd09
        '
        Me.Cmd09.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Cmd09.Location = New System.Drawing.Point(675, 28)
        Me.Cmd09.Name = "Cmd09"
        Me.Cmd09.Size = New System.Drawing.Size(84, 44)
        Me.Cmd09.TabIndex = 34
        Me.Cmd09.TabStop = False
        Me.Cmd09.UseVisualStyleBackColor = True
        '
        'Cmd08
        '
        Me.Cmd08.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd08.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd08.Location = New System.Drawing.Point(588, 28)
        Me.Cmd08.Name = "Cmd08"
        Me.Cmd08.Size = New System.Drawing.Size(84, 44)
        Me.Cmd08.TabIndex = 2
        Me.Cmd08.Text = "F8　ｲﾝﾎﾟｰﾄ処理"
        Me.Cmd08.UseVisualStyleBackColor = True
        '
        'Cmd07
        '
        Me.Cmd07.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd07.Location = New System.Drawing.Point(505, 28)
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
        Me.Cmd06.Location = New System.Drawing.Point(422, 28)
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
        Me.Cmd05.Location = New System.Drawing.Point(339, 28)
        Me.Cmd05.Name = "Cmd05"
        Me.Cmd05.Size = New System.Drawing.Size(84, 44)
        Me.Cmd05.TabIndex = 1
        Me.Cmd05.Text = "F5  ｷｬﾝｾﾙ"
        Me.Cmd05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd05.UseVisualStyleBackColor = True
        '
        'Cmd04
        '
        Me.Cmd04.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Cmd04.ForeColor = System.Drawing.Color.Red
        Me.Cmd04.Location = New System.Drawing.Point(253, 28)
        Me.Cmd04.Name = "Cmd04"
        Me.Cmd04.Size = New System.Drawing.Size(84, 44)
        Me.Cmd04.TabIndex = 39
        Me.Cmd04.TabStop = False
        Me.Cmd04.UseVisualStyleBackColor = True
        '
        'Cmd11
        '
        Me.Cmd11.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd11.Location = New System.Drawing.Point(841, 28)
        Me.Cmd11.Name = "Cmd11"
        Me.Cmd11.Size = New System.Drawing.Size(84, 44)
        Me.Cmd11.TabIndex = 2
        Me.Cmd11.TabStop = False
        Me.Cmd11.UseVisualStyleBackColor = True
        '
        'Cmd12
        '
        Me.Cmd12.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd12.Location = New System.Drawing.Point(924, 28)
        Me.Cmd12.Name = "Cmd12"
        Me.Cmd12.Size = New System.Drawing.Size(84, 44)
        Me.Cmd12.TabIndex = 3
        Me.Cmd12.TabStop = False
        Me.Cmd12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd12.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem00, Me.MenuItem01, Me.MenuItem02})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1025, 24)
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
        'La課税区分
        '
        Me.La課税区分.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La課税区分.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La課税区分.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La課税区分.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La課税区分.ForeColor = System.Drawing.Color.White
        Me.La課税区分.Location = New System.Drawing.Point(2, 91)
        Me.La課税区分.Name = "La課税区分"
        Me.La課税区分.Size = New System.Drawing.Size(96, 27)
        Me.La課税区分.TabIndex = 24
        Me.La課税区分.Text = "課税区分"
        Me.La課税区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La科目名
        '
        Me.La科目名.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La科目名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La科目名.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La科目名.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La科目名.ForeColor = System.Drawing.Color.White
        Me.La科目名.Location = New System.Drawing.Point(2, 10)
        Me.La科目名.Name = "La科目名"
        Me.La科目名.Size = New System.Drawing.Size(96, 27)
        Me.La科目名.TabIndex = 23
        Me.La科目名.Text = "科目名"
        Me.La科目名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(4, 78)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(448, 551)
        Me.ListView1.TabIndex = 242
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'txtmsg
        '
        Me.txtmsg.ForeColor = System.Drawing.Color.Red
        Me.txtmsg.Location = New System.Drawing.Point(5, 269)
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.Size = New System.Drawing.Size(246, 19)
        Me.txtmsg.TabIndex = 7
        Me.txtmsg.TabStop = False
        Me.txtmsg.Text = "エラーメッセージ"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txt決算期区分)
        Me.GroupBox10.Controls.Add(Me.cmbb)
        Me.GroupBox10.Controls.Add(Me.cmba)
        Me.GroupBox10.Controls.Add(Me.La貸借区分)
        Me.GroupBox10.Controls.Add(Me.La科目名ｶﾅ)
        Me.GroupBox10.Controls.Add(Me.txt支店No)
        Me.GroupBox10.Controls.Add(Me.btn保存)
        Me.GroupBox10.Controls.Add(Me.btn削除)
        Me.GroupBox10.Controls.Add(Me.La課税区分)
        Me.GroupBox10.Controls.Add(Me.La科目名)
        Me.GroupBox10.Controls.Add(Me.txtmsg)
        Me.GroupBox10.Controls.Add(Me.txt科目名)
        Me.GroupBox10.Location = New System.Drawing.Point(459, 123)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(446, 506)
        Me.GroupBox10.TabIndex = 244
        Me.GroupBox10.TabStop = False
        '
        'La貸借区分
        '
        Me.La貸借区分.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La貸借区分.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La貸借区分.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La貸借区分.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La貸借区分.ForeColor = System.Drawing.Color.White
        Me.La貸借区分.Location = New System.Drawing.Point(2, 64)
        Me.La貸借区分.Name = "La貸借区分"
        Me.La貸借区分.Size = New System.Drawing.Size(96, 27)
        Me.La貸借区分.TabIndex = 247
        Me.La貸借区分.Text = "貸借区分"
        Me.La貸借区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La科目名ｶﾅ
        '
        Me.La科目名ｶﾅ.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La科目名ｶﾅ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La科目名ｶﾅ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La科目名ｶﾅ.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La科目名ｶﾅ.ForeColor = System.Drawing.Color.White
        Me.La科目名ｶﾅ.Location = New System.Drawing.Point(2, 37)
        Me.La科目名ｶﾅ.Name = "La科目名ｶﾅ"
        Me.La科目名ｶﾅ.Size = New System.Drawing.Size(96, 27)
        Me.La科目名ｶﾅ.TabIndex = 246
        Me.La科目名ｶﾅ.Text = "科目名カナ"
        Me.La科目名ｶﾅ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt支店No
        '
        Me.txt支店No.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt支店No.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt支店No.Location = New System.Drawing.Point(98, 38)
        Me.txt支店No.MaxLength = 5
        Me.txt支店No.Name = "txt支店No"
        Me.txt支店No.Size = New System.Drawing.Size(121, 27)
        Me.txt支店No.TabIndex = 2
        Me.txt支店No.Text = "99999"
        '
        'btn保存
        '
        Me.btn保存.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn保存.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn保存.Location = New System.Drawing.Point(5, 236)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(69, 27)
        Me.btn保存.TabIndex = 5
        Me.btn保存.Text = "保存"
        Me.btn保存.UseVisualStyleBackColor = True
        '
        'btn削除
        '
        Me.btn削除.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn削除.ForeColor = System.Drawing.Color.Red
        Me.btn削除.Location = New System.Drawing.Point(80, 236)
        Me.btn削除.Name = "btn削除"
        Me.btn削除.Size = New System.Drawing.Size(69, 27)
        Me.btn削除.TabIndex = 6
        Me.btn削除.Text = "削除"
        Me.btn削除.UseVisualStyleBackColor = True
        '
        'txt科目名
        '
        Me.txt科目名.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt科目名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt科目名.Location = New System.Drawing.Point(98, 10)
        Me.txt科目名.MaxLength = 23
        Me.txt科目名.Name = "txt科目名"
        Me.txt科目名.Size = New System.Drawing.Size(285, 27)
        Me.txt科目名.TabIndex = 1
        '
        'GroupBox00
        '
        Me.GroupBox00.Controls.Add(Me.btnOK00)
        Me.GroupBox00.Controls.Add(Me.txt科目CD)
        Me.GroupBox00.Controls.Add(Me.La科目CD)
        Me.GroupBox00.Location = New System.Drawing.Point(458, 71)
        Me.GroupBox00.Name = "GroupBox00"
        Me.GroupBox00.Size = New System.Drawing.Size(449, 46)
        Me.GroupBox00.TabIndex = 245
        Me.GroupBox00.TabStop = False
        '
        'btnOK00
        '
        Me.btnOK00.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK00.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnOK00.Location = New System.Drawing.Point(167, 9)
        Me.btnOK00.Name = "btnOK00"
        Me.btnOK00.Size = New System.Drawing.Size(69, 32)
        Me.btnOK00.TabIndex = 2
        Me.btnOK00.Text = "Enter"
        Me.btnOK00.UseVisualStyleBackColor = True
        '
        'txt科目CD
        '
        Me.txt科目CD.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt科目CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt科目CD.Location = New System.Drawing.Point(99, 12)
        Me.txt科目CD.MaxLength = 7
        Me.txt科目CD.Name = "txt科目CD"
        Me.txt科目CD.Size = New System.Drawing.Size(66, 27)
        Me.txt科目CD.TabIndex = 1
        Me.txt科目CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'La科目CD
        '
        Me.La科目CD.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La科目CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La科目CD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La科目CD.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La科目CD.ForeColor = System.Drawing.Color.White
        Me.La科目CD.Location = New System.Drawing.Point(3, 12)
        Me.La科目CD.Name = "La科目CD"
        Me.La科目CD.Size = New System.Drawing.Size(96, 27)
        Me.La科目CD.TabIndex = 25
        Me.La科目CD.Text = "科目CD"
        Me.La科目CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmba
        '
        Me.cmba.FormattingEnabled = True
        Me.cmba.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmba.Location = New System.Drawing.Point(98, 71)
        Me.cmba.Name = "cmba"
        Me.cmba.Size = New System.Drawing.Size(121, 20)
        Me.cmba.TabIndex = 3
        '
        'cmbb
        '
        Me.cmbb.FormattingEnabled = True
        Me.cmbb.Location = New System.Drawing.Point(98, 98)
        Me.cmbb.Name = "cmbb"
        Me.cmbb.Size = New System.Drawing.Size(121, 20)
        Me.cmbb.TabIndex = 4
        '
        'txt決算期区分
        '
        Me.txt決算期区分.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt決算期区分.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt決算期区分.Location = New System.Drawing.Point(410, 256)
        Me.txt決算期区分.MaxLength = 2
        Me.txt決算期区分.Multiline = True
        Me.txt決算期区分.Name = "txt決算期区分"
        Me.txt決算期区分.ReadOnly = True
        Me.txt決算期区分.Size = New System.Drawing.Size(19, 32)
        Me.txt決算期区分.TabIndex = 503
        Me.txt決算期区分.TabStop = False
        Me.txt決算期区分.Text = "決" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "算" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "期区分"
        Me.txt決算期区分.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'F_Ms_Ka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 679)
        Me.Controls.Add(Me.GroupBox00)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Cmd12)
        Me.Controls.Add(Me.ListView1)
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
        Me.ForeColor = System.Drawing.Color.Red
        Me.KeyPreview = True
        Me.Name = "F_Ms_Ka"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "科目マスタメンテナンス"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox00.ResumeLayout(False)
        Me.GroupBox00.PerformLayout()
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
    Friend WithEvents La科目名 As System.Windows.Forms.Label
    Friend WithEvents MenuItem00 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem01 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem02 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtmsg As TextBox
    Friend WithEvents La課税区分 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents txt科目名 As TextBox
    Friend WithEvents btn保存 As Button
    Friend WithEvents btn削除 As Button
    Friend WithEvents GroupBox00 As GroupBox
    Friend WithEvents La科目CD As Label
    Friend WithEvents btnOK00 As Button
    Friend WithEvents txt科目CD As TextBox
    Friend WithEvents txt支店No As TextBox
    Friend WithEvents La科目名ｶﾅ As Label
    Friend WithEvents La貸借区分 As Label
    Friend WithEvents cmbb As ComboBox
    Friend WithEvents cmba As ComboBox
    Friend WithEvents txt決算期区分 As TextBox
End Class
