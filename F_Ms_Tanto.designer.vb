<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Ms_Tanto
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
        Me.Cmd04 = New System.Windows.Forms.Button()
        Me.Cmd11 = New System.Windows.Forms.Button()
        Me.Cmd12 = New System.Windows.Forms.Button()
        Me.GroupBox00 = New System.Windows.Forms.GroupBox()
        Me.txtmsg = New System.Windows.Forms.TextBox()
        Me.txt担当者CD = New System.Windows.Forms.TextBox()
        Me.La組織階層CD = New System.Windows.Forms.Label()
        Me.btnOK00 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItem00 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem01 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem02 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cmd05 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txt担当者名 = New System.Windows.Forms.TextBox()
        Me.La担当者名 = New System.Windows.Forms.Label()
        Me.txt略称名 = New System.Windows.Forms.TextBox()
        Me.txt部門1 = New System.Windows.Forms.TextBox()
        Me.btn削除 = New System.Windows.Forms.Button()
        Me.btn保存 = New System.Windows.Forms.Button()
        Me.txt携帯電話 = New System.Windows.Forms.TextBox()
        Me.LaLogin = New System.Windows.Forms.Label()
        Me.LaEMail = New System.Windows.Forms.Label()
        Me.La携帯電話 = New System.Windows.Forms.Label()
        Me.La部門 = New System.Windows.Forms.Label()
        Me.La略称名 = New System.Windows.Forms.Label()
        Me.txt部門2 = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Cmd01 = New System.Windows.Forms.Button()
        Me.GroupBox00.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmd01
        '
        Cmd01.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Cmd01.ForeColor = System.Drawing.SystemColors.WindowText
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
        Me.Cmd10.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd10.Location = New System.Drawing.Point(758, 28)
        Me.Cmd10.Name = "Cmd10"
        Me.Cmd10.Size = New System.Drawing.Size(84, 44)
        Me.Cmd10.TabIndex = 2
        Me.Cmd10.Text = "F10　終了"
        Me.Cmd10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd10.UseVisualStyleBackColor = True
        '
        'Cmd09
        '
        Me.Cmd09.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd09.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd09.Location = New System.Drawing.Point(675, 28)
        Me.Cmd09.Name = "Cmd09"
        Me.Cmd09.Size = New System.Drawing.Size(84, 44)
        Me.Cmd09.TabIndex = 1
        Me.Cmd09.TabStop = False
        Me.Cmd09.UseVisualStyleBackColor = True
        '
        'Cmd08
        '
        Me.Cmd08.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd08.Location = New System.Drawing.Point(588, 28)
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
        'Cmd04
        '
        Me.Cmd04.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd04.ForeColor = System.Drawing.Color.Red
        Me.Cmd04.Location = New System.Drawing.Point(253, 28)
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
        Me.Cmd11.Location = New System.Drawing.Point(841, 28)
        Me.Cmd11.Name = "Cmd11"
        Me.Cmd11.Size = New System.Drawing.Size(84, 44)
        Me.Cmd11.TabIndex = 5
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
        'GroupBox00
        '
        Me.GroupBox00.Controls.Add(Me.txt担当者CD)
        Me.GroupBox00.Controls.Add(Me.La組織階層CD)
        Me.GroupBox00.Controls.Add(Me.btnOK00)
        Me.GroupBox00.Location = New System.Drawing.Point(447, 72)
        Me.GroupBox00.Name = "GroupBox00"
        Me.GroupBox00.Size = New System.Drawing.Size(561, 50)
        Me.GroupBox00.TabIndex = 1
        Me.GroupBox00.TabStop = False
        '
        'txtmsg
        '
        Me.txtmsg.ForeColor = System.Drawing.Color.Red
        Me.txtmsg.Location = New System.Drawing.Point(6, 247)
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.Size = New System.Drawing.Size(262, 19)
        Me.txtmsg.TabIndex = 4
        Me.txtmsg.Text = "エラーメッセージ"
        '
        'txt担当者CD
        '
        Me.txt担当者CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt担当者CD.Location = New System.Drawing.Point(111, 15)
        Me.txt担当者CD.MaxLength = 3
        Me.txt担当者CD.Multiline = True
        Me.txt担当者CD.Name = "txt担当者CD"
        Me.txt担当者CD.Size = New System.Drawing.Size(50, 27)
        Me.txt担当者CD.TabIndex = 1
        Me.txt担当者CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'La組織階層CD
        '
        Me.La組織階層CD.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La組織階層CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La組織階層CD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La組織階層CD.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La組織階層CD.ForeColor = System.Drawing.Color.White
        Me.La組織階層CD.Location = New System.Drawing.Point(5, 15)
        Me.La組織階層CD.Name = "La組織階層CD"
        Me.La組織階層CD.Size = New System.Drawing.Size(106, 27)
        Me.La組織階層CD.TabIndex = 24
        Me.La組織階層CD.Tag = "担当者CD"
        Me.La組織階層CD.Text = "組織階層CD"
        Me.La組織階層CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOK00
        '
        Me.btnOK00.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK00.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnOK00.Location = New System.Drawing.Point(167, 12)
        Me.btnOK00.Name = "btnOK00"
        Me.btnOK00.Size = New System.Drawing.Size(88, 30)
        Me.btnOK00.TabIndex = 2
        Me.btnOK00.Text = "Enter"
        Me.btnOK00.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem00, Me.MenuItem01, Me.MenuItem02})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1021, 28)
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
        'Cmd05
        '
        Me.Cmd05.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd05.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd05.Location = New System.Drawing.Point(339, 28)
        Me.Cmd05.Name = "Cmd05"
        Me.Cmd05.Size = New System.Drawing.Size(84, 44)
        Me.Cmd05.TabIndex = 1
        Me.Cmd05.Text = "F5  ｷｬﾝｾﾙ"
        Me.Cmd05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd05.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(4, 78)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(439, 370)
        Me.ListView1.TabIndex = 242
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtLogin)
        Me.GroupBox10.Controls.Add(Me.txtEmail)
        Me.GroupBox10.Controls.Add(Me.txt部門2)
        Me.GroupBox10.Controls.Add(Me.La略称名)
        Me.GroupBox10.Controls.Add(Me.La部門)
        Me.GroupBox10.Controls.Add(Me.La携帯電話)
        Me.GroupBox10.Controls.Add(Me.LaEMail)
        Me.GroupBox10.Controls.Add(Me.LaLogin)
        Me.GroupBox10.Controls.Add(Me.txtmsg)
        Me.GroupBox10.Controls.Add(Me.btn削除)
        Me.GroupBox10.Controls.Add(Me.txt担当者名)
        Me.GroupBox10.Controls.Add(Me.btn保存)
        Me.GroupBox10.Controls.Add(Me.La担当者名)
        Me.GroupBox10.Controls.Add(Me.txt携帯電話)
        Me.GroupBox10.Controls.Add(Me.txt略称名)
        Me.GroupBox10.Controls.Add(Me.txt部門1)
        Me.GroupBox10.Location = New System.Drawing.Point(448, 121)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(561, 327)
        Me.GroupBox10.TabIndex = 10006
        Me.GroupBox10.TabStop = False
        '
        'txt担当者名
        '
        Me.txt担当者名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt担当者名.Location = New System.Drawing.Point(114, 9)
        Me.txt担当者名.MaxLength = 30
        Me.txt担当者名.Multiline = True
        Me.txt担当者名.Name = "txt担当者名"
        Me.txt担当者名.Size = New System.Drawing.Size(273, 27)
        Me.txt担当者名.TabIndex = 1
        Me.txt担当者名.Text = "1ooooooooo2ooooooooo3ooooooooo"
        '
        'La担当者名
        '
        Me.La担当者名.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La担当者名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La担当者名.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La担当者名.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La担当者名.ForeColor = System.Drawing.Color.White
        Me.La担当者名.Location = New System.Drawing.Point(4, 9)
        Me.La担当者名.Name = "La担当者名"
        Me.La担当者名.Size = New System.Drawing.Size(106, 27)
        Me.La担当者名.TabIndex = 10006
        Me.La担当者名.Text = "担当者名"
        Me.La担当者名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt略称名
        '
        Me.txt略称名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt略称名.Location = New System.Drawing.Point(114, 38)
        Me.txt略称名.MaxLength = 6
        Me.txt略称名.Multiline = True
        Me.txt略称名.Name = "txt略称名"
        Me.txt略称名.Size = New System.Drawing.Size(110, 27)
        Me.txt略称名.TabIndex = 2
        Me.txt略称名.Text = "123456"
        '
        'txt部門1
        '
        Me.txt部門1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt部門1.Location = New System.Drawing.Point(114, 67)
        Me.txt部門1.MaxLength = 3
        Me.txt部門1.Multiline = True
        Me.txt部門1.Name = "txt部門1"
        Me.txt部門1.Size = New System.Drawing.Size(46, 27)
        Me.txt部門1.TabIndex = 3
        Me.txt部門1.Text = "123"
        Me.txt部門1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn削除
        '
        Me.btn削除.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn削除.ForeColor = System.Drawing.Color.Red
        Me.btn削除.Location = New System.Drawing.Point(100, 200)
        Me.btn削除.Name = "btn削除"
        Me.btn削除.Size = New System.Drawing.Size(88, 30)
        Me.btn削除.TabIndex = 6
        Me.btn削除.Text = "削除"
        Me.btn削除.UseVisualStyleBackColor = True
        '
        'btn保存
        '
        Me.btn保存.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn保存.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn保存.Location = New System.Drawing.Point(6, 200)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(88, 30)
        Me.btn保存.TabIndex = 5
        Me.btn保存.Text = "保存"
        Me.btn保存.UseVisualStyleBackColor = True
        '
        'txt携帯電話
        '
        Me.txt携帯電話.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt携帯電話.Location = New System.Drawing.Point(114, 96)
        Me.txt携帯電話.MaxLength = 13
        Me.txt携帯電話.Multiline = True
        Me.txt携帯電話.Name = "txt携帯電話"
        Me.txt携帯電話.Size = New System.Drawing.Size(131, 27)
        Me.txt携帯電話.TabIndex = 4
        Me.txt携帯電話.Text = "090-8906-0692"
        '
        'LaLogin
        '
        Me.LaLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.LaLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaLogin.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.LaLogin.ForeColor = System.Drawing.Color.White
        Me.LaLogin.Location = New System.Drawing.Point(4, 154)
        Me.LaLogin.Name = "LaLogin"
        Me.LaLogin.Size = New System.Drawing.Size(106, 27)
        Me.LaLogin.TabIndex = 10007
        Me.LaLogin.Text = "Login"
        Me.LaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaEMail
        '
        Me.LaEMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.LaEMail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LaEMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaEMail.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.LaEMail.ForeColor = System.Drawing.Color.White
        Me.LaEMail.Location = New System.Drawing.Point(4, 125)
        Me.LaEMail.Name = "LaEMail"
        Me.LaEMail.Size = New System.Drawing.Size(106, 27)
        Me.LaEMail.TabIndex = 10008
        Me.LaEMail.Text = "E-Mail"
        Me.LaEMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La携帯電話
        '
        Me.La携帯電話.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La携帯電話.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La携帯電話.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La携帯電話.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La携帯電話.ForeColor = System.Drawing.Color.White
        Me.La携帯電話.Location = New System.Drawing.Point(4, 96)
        Me.La携帯電話.Name = "La携帯電話"
        Me.La携帯電話.Size = New System.Drawing.Size(106, 27)
        Me.La携帯電話.TabIndex = 10009
        Me.La携帯電話.Text = "携帯電話"
        Me.La携帯電話.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La部門
        '
        Me.La部門.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La部門.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La部門.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La部門.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.La部門.ForeColor = System.Drawing.Color.White
        Me.La部門.Location = New System.Drawing.Point(4, 67)
        Me.La部門.Name = "La部門"
        Me.La部門.Size = New System.Drawing.Size(106, 27)
        Me.La部門.TabIndex = 10010
        Me.La部門.Text = "部門"
        Me.La部門.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La略称名
        '
        Me.La略称名.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La略称名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La略称名.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La略称名.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La略称名.ForeColor = System.Drawing.Color.White
        Me.La略称名.Location = New System.Drawing.Point(4, 38)
        Me.La略称名.Name = "La略称名"
        Me.La略称名.Size = New System.Drawing.Size(106, 27)
        Me.La略称名.TabIndex = 10011
        Me.La略称名.Text = "略称名"
        Me.La略称名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt部門2
        '
        Me.txt部門2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt部門2.Location = New System.Drawing.Point(164, 67)
        Me.txt部門2.MaxLength = 20
        Me.txt部門2.Multiline = True
        Me.txt部門2.Name = "txt部門2"
        Me.txt部門2.ReadOnly = True
        Me.txt部門2.Size = New System.Drawing.Size(131, 27)
        Me.txt部門2.TabIndex = 10012
        Me.txt部門2.Text = "部門"
        '
        'txtEmail
        '
        Me.txtEmail.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtEmail.Location = New System.Drawing.Point(114, 125)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(197, 27)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.Text = "090-8906-0692"
        '
        'txtLogin
        '
        Me.txtLogin.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtLogin.Location = New System.Drawing.Point(114, 154)
        Me.txtLogin.MaxLength = 30
        Me.txtLogin.Multiline = True
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(197, 27)
        Me.txtLogin.TabIndex = 6
        Me.txtLogin.Text = "090-8906-0692"
        '
        'F_Ms_Tanto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 629)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.ForeColor = System.Drawing.Color.Red
        Me.KeyPreview = True
        Me.Name = "F_Ms_Tanto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "担当者マスタメンテナンス"
        Me.GroupBox00.ResumeLayout(False)
        Me.GroupBox00.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents Cmd04 As System.Windows.Forms.Button
    Friend WithEvents Cmd11 As System.Windows.Forms.Button
    Friend WithEvents Cmd12 As System.Windows.Forms.Button
    Friend WithEvents GroupBox00 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuItem00 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem01 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem02 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtmsg As TextBox
    Friend WithEvents txt担当者CD As TextBox
    Friend WithEvents btnOK00 As Button
    Friend WithEvents La組織階層CD As Label
    Friend WithEvents Cmd05 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents La担当者名 As Label
    Friend WithEvents txt担当者名 As TextBox
    Friend WithEvents txt略称名 As TextBox
    Friend WithEvents txt部門1 As TextBox
    Friend WithEvents btn削除 As Button
    Friend WithEvents btn保存 As Button
    Friend WithEvents txt携帯電話 As TextBox
    Friend WithEvents La略称名 As Label
    Friend WithEvents La部門 As Label
    Friend WithEvents La携帯電話 As Label
    Friend WithEvents LaEMail As Label
    Friend WithEvents LaLogin As Label
    Friend WithEvents txt部門2 As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtEmail As TextBox
End Class
