<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_An_Siw30
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.btnDel00 = New System.Windows.Forms.Button()
        Me.btnSel00 = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.btnOK00 = New System.Windows.Forms.Button()
        Me.txt対象日 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox00 = New System.Windows.Forms.GroupBox()
        Me.txt決算終了 = New System.Windows.Forms.TextBox()
        Me.txt決算開始 = New System.Windows.Forms.TextBox()
        Me.txt決算期区分 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt処理終了日 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt処理開始日 = New System.Windows.Forms.TextBox()
        Me.txt年度 = New System.Windows.Forms.TextBox()
        Me.txt締年月日 = New System.Windows.Forms.TextBox()
        Me.txt締No = New System.Windows.Forms.TextBox()
        Me.Cmd12 = New System.Windows.Forms.Button()
        Me.Cmd11 = New System.Windows.Forms.Button()
        Me.Cmd10 = New System.Windows.Forms.Button()
        Me.Cmd08 = New System.Windows.Forms.Button()
        Me.Cmd07 = New System.Windows.Forms.Button()
        Me.Cmd06 = New System.Windows.Forms.Button()
        Me.Cmd09 = New System.Windows.Forms.Button()
        Me.Cmd04 = New System.Windows.Forms.Button()
        Me.Cmd05 = New System.Windows.Forms.Button()
        Me.Cmd03 = New System.Windows.Forms.Button()
        Me.Cmd02 = New System.Windows.Forms.Button()
        Me.Cmd01 = New System.Windows.Forms.Button()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox00.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.btnDel00)
        Me.GroupBox20.Controls.Add(Me.btnSel00)
        Me.GroupBox20.Location = New System.Drawing.Point(3, 237)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(1063, 358)
        Me.GroupBox20.TabIndex = 138
        Me.GroupBox20.TabStop = False
        '
        'btnDel00
        '
        Me.btnDel00.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDel00.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDel00.Location = New System.Drawing.Point(107, 11)
        Me.btnDel00.Name = "btnDel00"
        Me.btnDel00.Size = New System.Drawing.Size(103, 37)
        Me.btnDel00.TabIndex = 1
        Me.btnDel00.Text = "取消"
        Me.btnDel00.UseVisualStyleBackColor = False
        '
        'btnSel00
        '
        Me.btnSel00.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSel00.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSel00.Location = New System.Drawing.Point(4, 11)
        Me.btnSel00.Name = "btnSel00"
        Me.btnSel00.Size = New System.Drawing.Size(103, 37)
        Me.btnSel00.TabIndex = 0
        Me.btnSel00.Text = "全て選択"
        Me.btnSel00.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtMsg)
        Me.GroupBox10.Controls.Add(Me.btnOK00)
        Me.GroupBox10.Controls.Add(Me.txt対象日)
        Me.GroupBox10.Controls.Add(Me.Label3)
        Me.GroupBox10.Location = New System.Drawing.Point(3, 106)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1063, 125)
        Me.GroupBox10.TabIndex = 137
        Me.GroupBox10.TabStop = False
        '
        'txtMsg
        '
        Me.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMsg.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txtMsg.ForeColor = System.Drawing.Color.Red
        Me.txtMsg.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtMsg.Location = New System.Drawing.Point(6, 85)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ReadOnly = True
        Me.txtMsg.Size = New System.Drawing.Size(341, 27)
        Me.txtMsg.TabIndex = 128
        Me.txtMsg.TabStop = False
        Me.txtMsg.Text = "エラーメッセージ"
        '
        'btnOK00
        '
        Me.btnOK00.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOK00.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK00.Location = New System.Drawing.Point(6, 48)
        Me.btnOK00.Name = "btnOK00"
        Me.btnOK00.Size = New System.Drawing.Size(103, 37)
        Me.btnOK00.TabIndex = 2
        Me.btnOK00.Text = "印刷対象抽出"
        Me.btnOK00.UseVisualStyleBackColor = False
        '
        'txt対象日
        '
        Me.txt対象日.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt対象日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt対象日.Location = New System.Drawing.Point(68, 15)
        Me.txt対象日.Name = "txt対象日"
        Me.txt対象日.Size = New System.Drawing.Size(61, 27)
        Me.txt対象日.TabIndex = 0
        Me.txt対象日.Text = "9999"
        Me.txt対象日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 27)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "対象日"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox00
        '
        Me.GroupBox00.Controls.Add(Me.txt決算終了)
        Me.GroupBox00.Controls.Add(Me.txt決算開始)
        Me.GroupBox00.Controls.Add(Me.txt決算期区分)
        Me.GroupBox00.Controls.Add(Me.Label2)
        Me.GroupBox00.Controls.Add(Me.txt処理終了日)
        Me.GroupBox00.Controls.Add(Me.Label1)
        Me.GroupBox00.Controls.Add(Me.txt処理開始日)
        Me.GroupBox00.Controls.Add(Me.txt年度)
        Me.GroupBox00.Controls.Add(Me.txt締年月日)
        Me.GroupBox00.Controls.Add(Me.txt締No)
        Me.GroupBox00.Location = New System.Drawing.Point(3, 57)
        Me.GroupBox00.Name = "GroupBox00"
        Me.GroupBox00.Size = New System.Drawing.Size(1063, 43)
        Me.GroupBox00.TabIndex = 136
        Me.GroupBox00.TabStop = False
        '
        'txt決算終了
        '
        Me.txt決算終了.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt決算終了.Location = New System.Drawing.Point(605, 10)
        Me.txt決算終了.Name = "txt決算終了"
        Me.txt決算終了.ReadOnly = True
        Me.txt決算終了.Size = New System.Drawing.Size(19, 27)
        Me.txt決算終了.TabIndex = 123
        Me.txt決算終了.TabStop = False
        Me.txt決算終了.Text = "決算終了"
        '
        'txt決算開始
        '
        Me.txt決算開始.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt決算開始.Location = New System.Drawing.Point(582, 10)
        Me.txt決算開始.Name = "txt決算開始"
        Me.txt決算開始.ReadOnly = True
        Me.txt決算開始.Size = New System.Drawing.Size(19, 27)
        Me.txt決算開始.TabIndex = 122
        Me.txt決算開始.TabStop = False
        Me.txt決算開始.Text = "決算開始"
        '
        'txt決算期区分
        '
        Me.txt決算期区分.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt決算期区分.Location = New System.Drawing.Point(557, 10)
        Me.txt決算期区分.Name = "txt決算期区分"
        Me.txt決算期区分.ReadOnly = True
        Me.txt決算期区分.Size = New System.Drawing.Size(21, 27)
        Me.txt決算期区分.TabIndex = 121
        Me.txt決算期区分.TabStop = False
        Me.txt決算期区分.Text = "決算期区分"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(133, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 27)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "締No"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt処理終了日
        '
        Me.txt処理終了日.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt処理終了日.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt処理終了日.Location = New System.Drawing.Point(447, 10)
        Me.txt処理終了日.Name = "txt処理終了日"
        Me.txt処理終了日.ReadOnly = True
        Me.txt処理終了日.Size = New System.Drawing.Size(104, 27)
        Me.txt処理終了日.TabIndex = 120
        Me.txt処理終了日.TabStop = False
        Me.txt処理終了日.Text = "処理終了日"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 27)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "年度"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt処理開始日
        '
        Me.txt処理開始日.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt処理開始日.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt処理開始日.Location = New System.Drawing.Point(340, 10)
        Me.txt処理開始日.Name = "txt処理開始日"
        Me.txt処理開始日.ReadOnly = True
        Me.txt処理開始日.Size = New System.Drawing.Size(104, 27)
        Me.txt処理開始日.TabIndex = 119
        Me.txt処理開始日.TabStop = False
        Me.txt処理開始日.Text = "処理開始日"
        '
        'txt年度
        '
        Me.txt年度.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt年度.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt年度.Location = New System.Drawing.Point(69, 10)
        Me.txt年度.Name = "txt年度"
        Me.txt年度.Size = New System.Drawing.Size(61, 27)
        Me.txt年度.TabIndex = 0
        Me.txt年度.Text = "9999"
        Me.txt年度.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt締年月日
        '
        Me.txt締年月日.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt締年月日.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt締年月日.Location = New System.Drawing.Point(234, 10)
        Me.txt締年月日.Name = "txt締年月日"
        Me.txt締年月日.ReadOnly = True
        Me.txt締年月日.Size = New System.Drawing.Size(104, 27)
        Me.txt締年月日.TabIndex = 118
        Me.txt締年月日.TabStop = False
        Me.txt締年月日.Text = "9999年99月"
        '
        'txt締No
        '
        Me.txt締No.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt締No.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt締No.Location = New System.Drawing.Point(197, 10)
        Me.txt締No.Name = "txt締No"
        Me.txt締No.Size = New System.Drawing.Size(35, 27)
        Me.txt締No.TabIndex = 1
        Me.txt締No.Text = "999"
        Me.txt締No.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cmd12
        '
        Me.Cmd12.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd12.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd12.ForeColor = System.Drawing.Color.Black
        Me.Cmd12.Location = New System.Drawing.Point(978, 6)
        Me.Cmd12.Name = "Cmd12"
        Me.Cmd12.Size = New System.Drawing.Size(88, 45)
        Me.Cmd12.TabIndex = 132
        Me.Cmd12.TabStop = False
        Me.Cmd12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd12.UseVisualStyleBackColor = False
        '
        'Cmd11
        '
        Me.Cmd11.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd11.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd11.ForeColor = System.Drawing.Color.Black
        Me.Cmd11.Location = New System.Drawing.Point(891, 6)
        Me.Cmd11.Name = "Cmd11"
        Me.Cmd11.Size = New System.Drawing.Size(88, 45)
        Me.Cmd11.TabIndex = 133
        Me.Cmd11.TabStop = False
        Me.Cmd11.UseVisualStyleBackColor = False
        '
        'Cmd10
        '
        Me.Cmd10.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd10.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd10.ForeColor = System.Drawing.Color.Black
        Me.Cmd10.Location = New System.Drawing.Point(804, 6)
        Me.Cmd10.Name = "Cmd10"
        Me.Cmd10.Size = New System.Drawing.Size(88, 45)
        Me.Cmd10.TabIndex = 134
        Me.Cmd10.TabStop = False
        Me.Cmd10.Text = "F10 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "終了"
        Me.Cmd10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd10.UseVisualStyleBackColor = False
        '
        'Cmd08
        '
        Me.Cmd08.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd08.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Cmd08.ForeColor = System.Drawing.Color.Black
        Me.Cmd08.Location = New System.Drawing.Point(621, 6)
        Me.Cmd08.Name = "Cmd08"
        Me.Cmd08.Size = New System.Drawing.Size(88, 45)
        Me.Cmd08.TabIndex = 127
        Me.Cmd08.TabStop = False
        Me.Cmd08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd08.UseVisualStyleBackColor = False
        '
        'Cmd07
        '
        Me.Cmd07.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd07.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd07.ForeColor = System.Drawing.Color.White
        Me.Cmd07.Location = New System.Drawing.Point(534, 6)
        Me.Cmd07.Name = "Cmd07"
        Me.Cmd07.Size = New System.Drawing.Size(88, 45)
        Me.Cmd07.TabIndex = 128
        Me.Cmd07.TabStop = False
        Me.Cmd07.UseVisualStyleBackColor = False
        '
        'Cmd06
        '
        Me.Cmd06.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd06.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd06.ForeColor = System.Drawing.Color.White
        Me.Cmd06.Location = New System.Drawing.Point(447, 6)
        Me.Cmd06.Name = "Cmd06"
        Me.Cmd06.Size = New System.Drawing.Size(88, 45)
        Me.Cmd06.TabIndex = 129
        Me.Cmd06.TabStop = False
        Me.Cmd06.UseVisualStyleBackColor = False
        '
        'Cmd09
        '
        Me.Cmd09.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd09.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd09.Location = New System.Drawing.Point(717, 6)
        Me.Cmd09.Name = "Cmd09"
        Me.Cmd09.Size = New System.Drawing.Size(88, 45)
        Me.Cmd09.TabIndex = 135
        Me.Cmd09.TabStop = False
        Me.Cmd09.UseVisualStyleBackColor = False
        '
        'Cmd04
        '
        Me.Cmd04.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd04.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd04.ForeColor = System.Drawing.Color.Black
        Me.Cmd04.Location = New System.Drawing.Point(264, 6)
        Me.Cmd04.Name = "Cmd04"
        Me.Cmd04.Size = New System.Drawing.Size(88, 45)
        Me.Cmd04.TabIndex = 131
        Me.Cmd04.TabStop = False
        Me.Cmd04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd04.UseVisualStyleBackColor = False
        '
        'Cmd05
        '
        Me.Cmd05.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd05.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Cmd05.FlatAppearance.BorderSize = 2
        Me.Cmd05.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Cmd05.ForeColor = System.Drawing.Color.Black
        Me.Cmd05.Location = New System.Drawing.Point(360, 6)
        Me.Cmd05.Name = "Cmd05"
        Me.Cmd05.Size = New System.Drawing.Size(88, 45)
        Me.Cmd05.TabIndex = 130
        Me.Cmd05.TabStop = False
        Me.Cmd05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd05.UseVisualStyleBackColor = False
        '
        'Cmd03
        '
        Me.Cmd03.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd03.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd03.ForeColor = System.Drawing.Color.White
        Me.Cmd03.Location = New System.Drawing.Point(177, 6)
        Me.Cmd03.Name = "Cmd03"
        Me.Cmd03.Size = New System.Drawing.Size(88, 45)
        Me.Cmd03.TabIndex = 126
        Me.Cmd03.TabStop = False
        Me.Cmd03.UseVisualStyleBackColor = False
        '
        'Cmd02
        '
        Me.Cmd02.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd02.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd02.ForeColor = System.Drawing.Color.White
        Me.Cmd02.Location = New System.Drawing.Point(90, 6)
        Me.Cmd02.Name = "Cmd02"
        Me.Cmd02.Size = New System.Drawing.Size(88, 45)
        Me.Cmd02.TabIndex = 125
        Me.Cmd02.TabStop = False
        Me.Cmd02.UseVisualStyleBackColor = False
        '
        'Cmd01
        '
        Me.Cmd01.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd01.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd01.ForeColor = System.Drawing.Color.Black
        Me.Cmd01.Location = New System.Drawing.Point(3, 6)
        Me.Cmd01.Name = "Cmd01"
        Me.Cmd01.Size = New System.Drawing.Size(88, 45)
        Me.Cmd01.TabIndex = 124
        Me.Cmd01.TabStop = False
        Me.Cmd01.Text = "F1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "印刷実行"
        Me.Cmd01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd01.UseVisualStyleBackColor = False
        '
        'F_An_Siw30
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 601)
        Me.Controls.Add(Me.GroupBox20)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox00)
        Me.Controls.Add(Me.Cmd12)
        Me.Controls.Add(Me.Cmd11)
        Me.Controls.Add(Me.Cmd10)
        Me.Controls.Add(Me.Cmd08)
        Me.Controls.Add(Me.Cmd07)
        Me.Controls.Add(Me.Cmd06)
        Me.Controls.Add(Me.Cmd09)
        Me.Controls.Add(Me.Cmd04)
        Me.Controls.Add(Me.Cmd05)
        Me.Controls.Add(Me.Cmd03)
        Me.Controls.Add(Me.Cmd02)
        Me.Controls.Add(Me.Cmd01)
        Me.Name = "F_An_Siw30"
        Me.Text = "ANSER経理伝票仕訳一覧表"
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox00.ResumeLayout(False)
        Me.GroupBox00.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents btnDel00 As Button
    Friend WithEvents btnSel00 As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents btnOK00 As Button
    Friend WithEvents txt対象日 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox00 As GroupBox
    Friend WithEvents txt決算終了 As TextBox
    Friend WithEvents txt決算開始 As TextBox
    Friend WithEvents txt決算期区分 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt処理終了日 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt処理開始日 As TextBox
    Friend WithEvents txt年度 As TextBox
    Friend WithEvents txt締年月日 As TextBox
    Friend WithEvents txt締No As TextBox
    Friend WithEvents Cmd12 As Button
    Friend WithEvents Cmd11 As Button
    Friend WithEvents Cmd10 As Button
    Friend WithEvents Cmd08 As Button
    Friend WithEvents Cmd07 As Button
    Friend WithEvents Cmd06 As Button
    Friend WithEvents Cmd09 As Button
    Friend WithEvents Cmd04 As Button
    Friend WithEvents Cmd05 As Button
    Friend WithEvents Cmd03 As Button
    Friend WithEvents Cmd02 As Button
    Friend WithEvents Cmd01 As Button
End Class
