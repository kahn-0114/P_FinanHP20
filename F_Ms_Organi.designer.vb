<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Ms_Organi
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
        Me.txt組織階層CD = New System.Windows.Forms.TextBox()
        Me.La組織階層CD = New System.Windows.Forms.Label()
        Me.btnOK00 = New System.Windows.Forms.Button()
        Me.txtmsg = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItem00 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem01 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem02 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cmd05 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.txt現金枝番 = New System.Windows.Forms.TextBox()
        Me.txt経理部門 = New System.Windows.Forms.TextBox()
        Me.txt階層CD3 = New System.Windows.Forms.TextBox()
        Me.La部門略称 = New System.Windows.Forms.Label()
        Me.Laｶﾅ名 = New System.Windows.Forms.Label()
        Me.La部門順番 = New System.Windows.Forms.Label()
        Me.La経理部門 = New System.Windows.Forms.Label()
        Me.La現金枝番 = New System.Windows.Forms.Label()
        Me.btn削除 = New System.Windows.Forms.Button()
        Me.txt部門名 = New System.Windows.Forms.TextBox()
        Me.btn保存 = New System.Windows.Forms.Button()
        Me.La部門名 = New System.Windows.Forms.Label()
        Me.txt部門順番 = New System.Windows.Forms.TextBox()
        Me.txt部門略称 = New System.Windows.Forms.TextBox()
        Me.txtカナ名 = New System.Windows.Forms.TextBox()
        Me.txt階層CD1 = New System.Windows.Forms.TextBox()
        Me.La階層記号 = New System.Windows.Forms.Label()
        Me.txt階層記号 = New System.Windows.Forms.TextBox()
        Me.txt階層記号CD = New System.Windows.Forms.TextBox()
        Me.txt階層CD2 = New System.Windows.Forms.TextBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.La部門CD = New System.Windows.Forms.Label()
        Me.txt部門CD = New System.Windows.Forms.TextBox()
        Me.btnOK10 = New System.Windows.Forms.Button()
        Me.txt枝番名 = New System.Windows.Forms.TextBox()
        Cmd01 = New System.Windows.Forms.Button()
        Me.GroupBox00.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmd01
        '
        Cmd01.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Cmd01.ForeColor = System.Drawing.SystemColors.WindowText
        Cmd01.Location = New System.Drawing.Point(4, 28)
        Cmd01.Name = "Cmd01"
        Cmd01.Size = New System.Drawing.Size(84, 49)
        Cmd01.TabIndex = 1
        Cmd01.Text = "F1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "階層作成"
        Cmd01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Cmd01.UseVisualStyleBackColor = True
        AddHandler Cmd01.Click, AddressOf Me.Cmd01_Click
        '
        'Cmd02
        '
        Me.Cmd02.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd02.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd02.Location = New System.Drawing.Point(87, 28)
        Me.Cmd02.Name = "Cmd02"
        Me.Cmd02.Size = New System.Drawing.Size(84, 49)
        Me.Cmd02.TabIndex = 2
        Me.Cmd02.Text = "F2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "構想作成"
        Me.Cmd02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd02.UseVisualStyleBackColor = True
        '
        'Cmd03
        '
        Me.Cmd03.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd03.Location = New System.Drawing.Point(170, 28)
        Me.Cmd03.Name = "Cmd03"
        Me.Cmd03.Size = New System.Drawing.Size(84, 49)
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
        Me.Cmd10.Size = New System.Drawing.Size(84, 49)
        Me.Cmd10.TabIndex = 4
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
        Me.Cmd09.Size = New System.Drawing.Size(84, 49)
        Me.Cmd09.TabIndex = 1
        Me.Cmd09.TabStop = False
        Me.Cmd09.UseVisualStyleBackColor = True
        '
        'Cmd08
        '
        Me.Cmd08.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd08.Location = New System.Drawing.Point(588, 28)
        Me.Cmd08.Name = "Cmd08"
        Me.Cmd08.Size = New System.Drawing.Size(84, 49)
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
        Me.Cmd07.Size = New System.Drawing.Size(84, 49)
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
        Me.Cmd06.Size = New System.Drawing.Size(84, 49)
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
        Me.Cmd04.Size = New System.Drawing.Size(84, 49)
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
        Me.Cmd11.Size = New System.Drawing.Size(84, 49)
        Me.Cmd11.TabIndex = 5
        Me.Cmd11.UseVisualStyleBackColor = True
        '
        'Cmd12
        '
        Me.Cmd12.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Cmd12.Location = New System.Drawing.Point(924, 28)
        Me.Cmd12.Name = "Cmd12"
        Me.Cmd12.Size = New System.Drawing.Size(84, 49)
        Me.Cmd12.TabIndex = 3
        Me.Cmd12.TabStop = False
        Me.Cmd12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd12.UseVisualStyleBackColor = True
        '
        'GroupBox00
        '
        Me.GroupBox00.Controls.Add(Me.txt階層CD2)
        Me.GroupBox00.Controls.Add(Me.txt階層記号CD)
        Me.GroupBox00.Controls.Add(Me.txt階層記号)
        Me.GroupBox00.Controls.Add(Me.La階層記号)
        Me.GroupBox00.Controls.Add(Me.txt階層CD1)
        Me.GroupBox00.Controls.Add(Me.txt組織階層CD)
        Me.GroupBox00.Controls.Add(Me.La組織階層CD)
        Me.GroupBox00.Controls.Add(Me.btnOK00)
        Me.GroupBox00.Location = New System.Drawing.Point(447, 72)
        Me.GroupBox00.Name = "GroupBox00"
        Me.GroupBox00.Size = New System.Drawing.Size(561, 79)
        Me.GroupBox00.TabIndex = 1
        Me.GroupBox00.TabStop = False
        '
        'txt組織階層CD
        '
        Me.txt組織階層CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt組織階層CD.Location = New System.Drawing.Point(111, 12)
        Me.txt組織階層CD.MaxLength = 3
        Me.txt組織階層CD.Multiline = True
        Me.txt組織階層CD.Name = "txt組織階層CD"
        Me.txt組織階層CD.Size = New System.Drawing.Size(50, 27)
        Me.txt組織階層CD.TabIndex = 1
        Me.txt組織階層CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'La組織階層CD
        '
        Me.La組織階層CD.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La組織階層CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La組織階層CD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La組織階層CD.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La組織階層CD.ForeColor = System.Drawing.Color.White
        Me.La組織階層CD.Location = New System.Drawing.Point(5, 12)
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
        Me.btnOK00.Location = New System.Drawing.Point(407, 40)
        Me.btnOK00.Name = "btnOK00"
        Me.btnOK00.Size = New System.Drawing.Size(88, 30)
        Me.btnOK00.TabIndex = 3
        Me.btnOK00.Text = "Enter"
        Me.btnOK00.UseVisualStyleBackColor = True
        '
        'txtmsg
        '
        Me.txtmsg.ForeColor = System.Drawing.Color.Red
        Me.txtmsg.Location = New System.Drawing.Point(6, 190)
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.Size = New System.Drawing.Size(262, 19)
        Me.txtmsg.TabIndex = 7
        Me.txtmsg.Text = "エラーメッセージ"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem00, Me.MenuItem01, Me.MenuItem02})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1021, 24)
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
        Me.Cmd05.Size = New System.Drawing.Size(84, 49)
        Me.Cmd05.TabIndex = 3
        Me.Cmd05.Text = "F5  ｷｬﾝｾﾙ"
        Me.Cmd05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd05.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(4, 78)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(439, 509)
        Me.ListView1.TabIndex = 242
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.txt枝番名)
        Me.GroupBox20.Controls.Add(Me.txt現金枝番)
        Me.GroupBox20.Controls.Add(Me.txt経理部門)
        Me.GroupBox20.Controls.Add(Me.txt階層CD3)
        Me.GroupBox20.Controls.Add(Me.La部門略称)
        Me.GroupBox20.Controls.Add(Me.Laｶﾅ名)
        Me.GroupBox20.Controls.Add(Me.La部門順番)
        Me.GroupBox20.Controls.Add(Me.La経理部門)
        Me.GroupBox20.Controls.Add(Me.La現金枝番)
        Me.GroupBox20.Controls.Add(Me.txtmsg)
        Me.GroupBox20.Controls.Add(Me.btn削除)
        Me.GroupBox20.Controls.Add(Me.txt部門名)
        Me.GroupBox20.Controls.Add(Me.btn保存)
        Me.GroupBox20.Controls.Add(Me.La部門名)
        Me.GroupBox20.Controls.Add(Me.txt部門順番)
        Me.GroupBox20.Controls.Add(Me.txt部門略称)
        Me.GroupBox20.Controls.Add(Me.txtカナ名)
        Me.GroupBox20.Location = New System.Drawing.Point(447, 336)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(561, 251)
        Me.GroupBox20.TabIndex = 10006
        Me.GroupBox20.TabStop = False
        '
        'txt現金枝番
        '
        Me.txt現金枝番.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt現金枝番.Location = New System.Drawing.Point(114, 154)
        Me.txt現金枝番.MaxLength = 5
        Me.txt現金枝番.Multiline = True
        Me.txt現金枝番.Name = "txt現金枝番"
        Me.txt現金枝番.Size = New System.Drawing.Size(47, 27)
        Me.txt現金枝番.TabIndex = 6
        Me.txt現金枝番.Text = "12345"
        Me.txt現金枝番.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt経理部門
        '
        Me.txt経理部門.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt経理部門.Location = New System.Drawing.Point(114, 125)
        Me.txt経理部門.MaxLength = 15
        Me.txt経理部門.Multiline = True
        Me.txt経理部門.Name = "txt経理部門"
        Me.txt経理部門.Size = New System.Drawing.Size(197, 27)
        Me.txt経理部門.TabIndex = 5
        Me.txt経理部門.Text = "1ooooooooo12345"
        '
        'txt階層CD3
        '
        Me.txt階層CD3.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt階層CD3.Location = New System.Drawing.Point(326, 111)
        Me.txt階層CD3.MaxLength = 20
        Me.txt階層CD3.Multiline = True
        Me.txt階層CD3.Name = "txt階層CD3"
        Me.txt階層CD3.ReadOnly = True
        Me.txt階層CD3.Size = New System.Drawing.Size(131, 27)
        Me.txt階層CD3.TabIndex = 10012
        Me.txt階層CD3.Text = "階層CD"
        '
        'La部門略称
        '
        Me.La部門略称.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La部門略称.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La部門略称.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La部門略称.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La部門略称.ForeColor = System.Drawing.Color.White
        Me.La部門略称.Location = New System.Drawing.Point(4, 38)
        Me.La部門略称.Name = "La部門略称"
        Me.La部門略称.Size = New System.Drawing.Size(106, 27)
        Me.La部門略称.TabIndex = 10011
        Me.La部門略称.Text = "部門略称"
        Me.La部門略称.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Laｶﾅ名
        '
        Me.Laｶﾅ名.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Laｶﾅ名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Laｶﾅ名.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Laｶﾅ名.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Laｶﾅ名.ForeColor = System.Drawing.Color.White
        Me.Laｶﾅ名.Location = New System.Drawing.Point(4, 67)
        Me.Laｶﾅ名.Name = "Laｶﾅ名"
        Me.Laｶﾅ名.Size = New System.Drawing.Size(106, 27)
        Me.Laｶﾅ名.TabIndex = 10010
        Me.Laｶﾅ名.Text = "カナ名"
        Me.Laｶﾅ名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La部門順番
        '
        Me.La部門順番.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La部門順番.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La部門順番.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La部門順番.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La部門順番.ForeColor = System.Drawing.Color.White
        Me.La部門順番.Location = New System.Drawing.Point(4, 96)
        Me.La部門順番.Name = "La部門順番"
        Me.La部門順番.Size = New System.Drawing.Size(106, 27)
        Me.La部門順番.TabIndex = 10009
        Me.La部門順番.Text = "部門順番"
        Me.La部門順番.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La経理部門
        '
        Me.La経理部門.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La経理部門.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La経理部門.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La経理部門.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La経理部門.ForeColor = System.Drawing.Color.White
        Me.La経理部門.Location = New System.Drawing.Point(4, 125)
        Me.La経理部門.Name = "La経理部門"
        Me.La経理部門.Size = New System.Drawing.Size(106, 27)
        Me.La経理部門.TabIndex = 10008
        Me.La経理部門.Text = "経理部門"
        Me.La経理部門.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La現金枝番
        '
        Me.La現金枝番.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La現金枝番.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La現金枝番.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La現金枝番.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.La現金枝番.ForeColor = System.Drawing.Color.White
        Me.La現金枝番.Location = New System.Drawing.Point(4, 154)
        Me.La現金枝番.Name = "La現金枝番"
        Me.La現金枝番.Size = New System.Drawing.Size(106, 27)
        Me.La現金枝番.TabIndex = 10007
        Me.La現金枝番.Text = "現金枝番"
        Me.La現金枝番.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn削除
        '
        Me.btn削除.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn削除.ForeColor = System.Drawing.Color.Red
        Me.btn削除.Location = New System.Drawing.Point(111, 215)
        Me.btn削除.Name = "btn削除"
        Me.btn削除.Size = New System.Drawing.Size(88, 30)
        Me.btn削除.TabIndex = 9
        Me.btn削除.Text = "削除"
        Me.btn削除.UseVisualStyleBackColor = True
        '
        'txt部門名
        '
        Me.txt部門名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt部門名.Location = New System.Drawing.Point(114, 9)
        Me.txt部門名.MaxLength = 20
        Me.txt部門名.Multiline = True
        Me.txt部門名.Name = "txt部門名"
        Me.txt部門名.Size = New System.Drawing.Size(273, 27)
        Me.txt部門名.TabIndex = 1
        Me.txt部門名.Text = "1ooooooooo2ooooooooo"
        '
        'btn保存
        '
        Me.btn保存.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn保存.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btn保存.Location = New System.Drawing.Point(17, 215)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(88, 30)
        Me.btn保存.TabIndex = 8
        Me.btn保存.Text = "保存"
        Me.btn保存.UseVisualStyleBackColor = True
        '
        'La部門名
        '
        Me.La部門名.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La部門名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La部門名.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La部門名.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La部門名.ForeColor = System.Drawing.Color.White
        Me.La部門名.Location = New System.Drawing.Point(4, 9)
        Me.La部門名.Name = "La部門名"
        Me.La部門名.Size = New System.Drawing.Size(106, 27)
        Me.La部門名.TabIndex = 10006
        Me.La部門名.Text = "部門名"
        Me.La部門名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt部門順番
        '
        Me.txt部門順番.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt部門順番.Location = New System.Drawing.Point(114, 96)
        Me.txt部門順番.MaxLength = 5
        Me.txt部門順番.Multiline = True
        Me.txt部門順番.Name = "txt部門順番"
        Me.txt部門順番.Size = New System.Drawing.Size(47, 27)
        Me.txt部門順番.TabIndex = 4
        Me.txt部門順番.Text = "12345"
        Me.txt部門順番.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt部門略称
        '
        Me.txt部門略称.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt部門略称.Location = New System.Drawing.Point(114, 38)
        Me.txt部門略称.MaxLength = 20
        Me.txt部門略称.Multiline = True
        Me.txt部門略称.Name = "txt部門略称"
        Me.txt部門略称.Size = New System.Drawing.Size(141, 27)
        Me.txt部門略称.TabIndex = 2
        Me.txt部門略称.Text = "1ooooooooo2ooooooooo"
        '
        'txtカナ名
        '
        Me.txtカナ名.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtカナ名.Location = New System.Drawing.Point(114, 67)
        Me.txtカナ名.MaxLength = 20
        Me.txtカナ名.Multiline = True
        Me.txtカナ名.Name = "txtカナ名"
        Me.txtカナ名.Size = New System.Drawing.Size(140, 27)
        Me.txtカナ名.TabIndex = 3
        Me.txtカナ名.Text = "1ooooooooo2ooooooooo"
        '
        'txt階層CD1
        '
        Me.txt階層CD1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt階層CD1.Location = New System.Drawing.Point(163, 12)
        Me.txt階層CD1.MaxLength = 3
        Me.txt階層CD1.Multiline = True
        Me.txt階層CD1.Name = "txt階層CD1"
        Me.txt階層CD1.ReadOnly = True
        Me.txt階層CD1.Size = New System.Drawing.Size(144, 27)
        Me.txt階層CD1.TabIndex = 25
        Me.txt階層CD1.TabStop = False
        Me.txt階層CD1.Text = "階層CD"
        '
        'La階層記号
        '
        Me.La階層記号.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La階層記号.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La階層記号.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La階層記号.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La階層記号.ForeColor = System.Drawing.Color.White
        Me.La階層記号.Location = New System.Drawing.Point(5, 42)
        Me.La階層記号.Name = "La階層記号"
        Me.La階層記号.Size = New System.Drawing.Size(106, 27)
        Me.La階層記号.TabIndex = 26
        Me.La階層記号.Tag = ""
        Me.La階層記号.Text = "階層記号"
        Me.La階層記号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt階層記号
        '
        Me.txt階層記号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt階層記号.Location = New System.Drawing.Point(111, 41)
        Me.txt階層記号.MaxLength = 12
        Me.txt階層記号.Multiline = True
        Me.txt階層記号.Name = "txt階層記号"
        Me.txt階層記号.Size = New System.Drawing.Size(144, 27)
        Me.txt階層記号.TabIndex = 2
        Me.txt階層記号.Text = "1ooooooooo12"
        '
        'txt階層記号CD
        '
        Me.txt階層記号CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt階層記号CD.Location = New System.Drawing.Point(257, 41)
        Me.txt階層記号CD.MaxLength = 3
        Me.txt階層記号CD.Multiline = True
        Me.txt階層記号CD.Name = "txt階層記号CD"
        Me.txt階層記号CD.ReadOnly = True
        Me.txt階層記号CD.Size = New System.Drawing.Size(144, 27)
        Me.txt階層記号CD.TabIndex = 28
        Me.txt階層記号CD.TabStop = False
        Me.txt階層記号CD.Text = "階層CD"
        '
        'txt階層CD2
        '
        Me.txt階層CD2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt階層CD2.Location = New System.Drawing.Point(463, 18)
        Me.txt階層CD2.MaxLength = 3
        Me.txt階層CD2.Multiline = True
        Me.txt階層CD2.Name = "txt階層CD2"
        Me.txt階層CD2.ReadOnly = True
        Me.txt階層CD2.Size = New System.Drawing.Size(32, 16)
        Me.txt階層CD2.TabIndex = 29
        Me.txt階層CD2.TabStop = False
        Me.txt階層CD2.Text = "階" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "層" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CD"
        '
        'ListView2
        '
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(447, 154)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(561, 136)
        Me.ListView2.TabIndex = 10007
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btnOK10)
        Me.GroupBox10.Controls.Add(Me.txt部門CD)
        Me.GroupBox10.Controls.Add(Me.La部門CD)
        Me.GroupBox10.Location = New System.Drawing.Point(447, 290)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(561, 47)
        Me.GroupBox10.TabIndex = 10013
        Me.GroupBox10.TabStop = False
        '
        'La部門CD
        '
        Me.La部門CD.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La部門CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La部門CD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La部門CD.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.La部門CD.ForeColor = System.Drawing.Color.White
        Me.La部門CD.Location = New System.Drawing.Point(5, 13)
        Me.La部門CD.Name = "La部門CD"
        Me.La部門CD.Size = New System.Drawing.Size(106, 27)
        Me.La部門CD.TabIndex = 10007
        Me.La部門CD.Text = "部門CD"
        Me.La部門CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt部門CD
        '
        Me.txt部門CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt部門CD.Location = New System.Drawing.Point(111, 13)
        Me.txt部門CD.MaxLength = 5
        Me.txt部門CD.Multiline = True
        Me.txt部門CD.Name = "txt部門CD"
        Me.txt部門CD.Size = New System.Drawing.Size(50, 27)
        Me.txt部門CD.TabIndex = 1
        Me.txt部門CD.Text = "99999"
        Me.txt部門CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnOK10
        '
        Me.btnOK10.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnOK10.Location = New System.Drawing.Point(166, 10)
        Me.btnOK10.Name = "btnOK10"
        Me.btnOK10.Size = New System.Drawing.Size(88, 30)
        Me.btnOK10.TabIndex = 10009
        Me.btnOK10.Text = "Enter"
        Me.btnOK10.UseVisualStyleBackColor = True
        '
        'txt枝番名
        '
        Me.txt枝番名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt枝番名.Location = New System.Drawing.Point(169, 154)
        Me.txt枝番名.MaxLength = 20
        Me.txt枝番名.Multiline = True
        Me.txt枝番名.Name = "txt枝番名"
        Me.txt枝番名.ReadOnly = True
        Me.txt枝番名.Size = New System.Drawing.Size(131, 27)
        Me.txt枝番名.TabIndex = 10013
        Me.txt枝番名.Text = "枝番名"
        '
        'F_Ms_Organi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 597)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.GroupBox20)
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
        Me.Name = "F_Ms_Organi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "部門マスタメンテナンス"
        Me.GroupBox00.ResumeLayout(False)
        Me.GroupBox00.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
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
    Friend WithEvents txt組織階層CD As TextBox
    Friend WithEvents btnOK00 As Button
    Friend WithEvents La組織階層CD As Label
    Friend WithEvents Cmd05 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents La部門名 As Label
    Friend WithEvents txt部門名 As TextBox
    Friend WithEvents txt部門略称 As TextBox
    Friend WithEvents txtカナ名 As TextBox
    Friend WithEvents btn削除 As Button
    Friend WithEvents btn保存 As Button
    Friend WithEvents txt部門順番 As TextBox
    Friend WithEvents La部門略称 As Label
    Friend WithEvents Laｶﾅ名 As Label
    Friend WithEvents La部門順番 As Label
    Friend WithEvents La経理部門 As Label
    Friend WithEvents La現金枝番 As Label
    Friend WithEvents txt階層CD3 As TextBox
    Friend WithEvents txt現金枝番 As TextBox
    Friend WithEvents txt経理部門 As TextBox
    Friend WithEvents txt階層CD1 As TextBox
    Friend WithEvents txt階層CD2 As TextBox
    Friend WithEvents txt階層記号CD As TextBox
    Friend WithEvents txt階層記号 As TextBox
    Friend WithEvents La階層記号 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents btnOK10 As Button
    Friend WithEvents txt部門CD As TextBox
    Friend WithEvents La部門CD As Label
    Friend WithEvents txt枝番名 As TextBox
End Class
