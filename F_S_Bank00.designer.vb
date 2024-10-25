<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_S_Bank00
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
        Me.components = New System.ComponentModel.Container
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GcMultiRow1 = New GrapeCity.Win.MultiRow.GcMultiRow
        Me.F_S_Bank00T1 = New p_FinanHp10.F_S_Bank00T
        Me.GroupBox00 = New System.Windows.Forms.GroupBox
        Me.txtMsg = New System.Windows.Forms.TextBox
        Me.Cmd11 = New System.Windows.Forms.Button
        Me.Cmd09 = New System.Windows.Forms.Button
        Me.btnOK00 = New System.Windows.Forms.Button
        Me.txt銀行名 = New System.Windows.Forms.TextBox
        Me.txt銀行CD = New System.Windows.Forms.TextBox
        Me.La銀行 = New System.Windows.Forms.Label
        Me.txtModified = New System.Windows.Forms.TextBox
        CType(Me.GcMultiRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox00.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(1, 20)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GcMultiRow1
        '
        Me.GcMultiRow1.Location = New System.Drawing.Point(1, 55)
        Me.GcMultiRow1.Name = "GcMultiRow1"
        Me.GcMultiRow1.Size = New System.Drawing.Size(712, 600)
        Me.GcMultiRow1.TabIndex = 252
        Me.GcMultiRow1.Template = Me.F_S_Bank00T1
        Me.GcMultiRow1.Text = "GcMultiRow1"
        '
        'GroupBox00
        '
        Me.GroupBox00.Controls.Add(Me.txtModified)
        Me.GroupBox00.Controls.Add(Me.txtMsg)
        Me.GroupBox00.Controls.Add(Me.Cmd11)
        Me.GroupBox00.Controls.Add(Me.Cmd09)
        Me.GroupBox00.Controls.Add(Me.btnOK00)
        Me.GroupBox00.Controls.Add(Me.txt銀行名)
        Me.GroupBox00.Controls.Add(Me.txt銀行CD)
        Me.GroupBox00.Controls.Add(Me.La銀行)
        Me.GroupBox00.Location = New System.Drawing.Point(2, -3)
        Me.GroupBox00.Name = "GroupBox00"
        Me.GroupBox00.Size = New System.Drawing.Size(710, 55)
        Me.GroupBox00.TabIndex = 253
        Me.GroupBox00.TabStop = False
        '
        'txtMsg
        '
        Me.txtMsg.BackColor = System.Drawing.SystemColors.Control
        Me.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMsg.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtMsg.ForeColor = System.Drawing.Color.Red
        Me.txtMsg.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtMsg.Location = New System.Drawing.Point(401, 28)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ReadOnly = True
        Me.txtMsg.Size = New System.Drawing.Size(138, 15)
        Me.txtMsg.TabIndex = 102
        Me.txtMsg.Text = "メッセージ"
        '
        'Cmd11
        '
        Me.Cmd11.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd11.Location = New System.Drawing.Point(624, 9)
        Me.Cmd11.Name = "Cmd11"
        Me.Cmd11.Size = New System.Drawing.Size(80, 38)
        Me.Cmd11.TabIndex = 100
        Me.Cmd11.Text = "F11終了"
        Me.Cmd11.UseVisualStyleBackColor = True
        '
        'Cmd09
        '
        Me.Cmd09.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd09.Location = New System.Drawing.Point(542, 9)
        Me.Cmd09.Name = "Cmd09"
        Me.Cmd09.Size = New System.Drawing.Size(80, 38)
        Me.Cmd09.TabIndex = 101
        Me.Cmd09.Text = "F9 検索"
        Me.Cmd09.UseVisualStyleBackColor = True
        '
        'btnOK00
        '
        Me.btnOK00.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOK00.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK00.Location = New System.Drawing.Point(308, 15)
        Me.btnOK00.Name = "btnOK00"
        Me.btnOK00.Size = New System.Drawing.Size(89, 30)
        Me.btnOK00.TabIndex = 1
        Me.btnOK00.Text = "F1 抽出"
        Me.btnOK00.UseVisualStyleBackColor = False
        '
        'txt銀行名
        '
        Me.txt銀行名.BackColor = System.Drawing.SystemColors.Control
        Me.txt銀行名.Enabled = False
        Me.txt銀行名.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt銀行名.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt銀行名.Location = New System.Drawing.Point(135, 24)
        Me.txt銀行名.Name = "txt銀行名"
        Me.txt銀行名.ReadOnly = True
        Me.txt銀行名.Size = New System.Drawing.Size(167, 20)
        Me.txt銀行名.TabIndex = 99
        '
        'txt銀行CD
        '
        Me.txt銀行CD.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt銀行CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt銀行CD.Location = New System.Drawing.Point(90, 24)
        Me.txt銀行CD.MaxLength = 4
        Me.txt銀行CD.Name = "txt銀行CD"
        Me.txt銀行CD.Size = New System.Drawing.Size(44, 20)
        Me.txt銀行CD.TabIndex = 0
        Me.txt銀行CD.Text = "9999"
        Me.txt銀行CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'La銀行
        '
        Me.La銀行.BackColor = System.Drawing.Color.RoyalBlue
        Me.La銀行.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.La銀行.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.La銀行.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.La銀行.Location = New System.Drawing.Point(5, 24)
        Me.La銀行.Name = "La銀行"
        Me.La銀行.Size = New System.Drawing.Size(85, 20)
        Me.La銀行.TabIndex = 98
        Me.La銀行.Text = "銀行CD"
        Me.La銀行.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtModified
        '
        Me.txtModified.BackColor = System.Drawing.SystemColors.Control
        Me.txtModified.Enabled = False
        Me.txtModified.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtModified.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtModified.Location = New System.Drawing.Point(524, 9)
        Me.txtModified.Name = "txtModified"
        Me.txtModified.ReadOnly = True
        Me.txtModified.Size = New System.Drawing.Size(15, 20)
        Me.txtModified.TabIndex = 515
        Me.txtModified.TabStop = False
        Me.txtModified.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtModified.Visible = False
        '
        'F_S_Bank00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 661)
        Me.Controls.Add(Me.GcMultiRow1)
        Me.Controls.Add(Me.GroupBox00)
        Me.KeyPreview = True
        Me.Name = "F_S_Bank00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "銀行支店参照"
        CType(Me.GcMultiRow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox00.ResumeLayout(False)
        Me.GroupBox00.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GcMultiRow1 As GrapeCity.Win.MultiRow.GcMultiRow
    Friend F_S_Bank00T1 As p_FinanHp10.F_S_Bank00T
    Friend WithEvents GroupBox00 As System.Windows.Forms.GroupBox
    Friend WithEvents txt銀行名 As System.Windows.Forms.TextBox
    Friend WithEvents txt銀行CD As System.Windows.Forms.TextBox
    Friend WithEvents La銀行 As System.Windows.Forms.Label
    Friend WithEvents btnOK00 As System.Windows.Forms.Button
    Friend WithEvents Cmd11 As System.Windows.Forms.Button
    Friend WithEvents Cmd09 As System.Windows.Forms.Button
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents txtModified As System.Windows.Forms.TextBox
End Class
