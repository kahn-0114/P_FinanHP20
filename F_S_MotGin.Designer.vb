<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_S_MotGin
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
        Me.GroupBox00 = New System.Windows.Forms.GroupBox()
        Me.Cmd10 = New System.Windows.Forms.Button()
        Me.La銀行CD = New System.Windows.Forms.Label()
        Me.txt銀行CD = New System.Windows.Forms.TextBox()
        Me.txt口座名 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt口座番号 = New System.Windows.Forms.TextBox()
        Me.btnOK00 = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox00.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox00
        '
        Me.GroupBox00.Controls.Add(Me.txtMsg)
        Me.GroupBox00.Controls.Add(Me.btnOK00)
        Me.GroupBox00.Controls.Add(Me.txt口座番号)
        Me.GroupBox00.Controls.Add(Me.Label2)
        Me.GroupBox00.Controls.Add(Me.txt口座名)
        Me.GroupBox00.Controls.Add(Me.txt銀行CD)
        Me.GroupBox00.Controls.Add(Me.La銀行CD)
        Me.GroupBox00.Controls.Add(Me.Cmd10)
        Me.GroupBox00.Location = New System.Drawing.Point(3, -2)
        Me.GroupBox00.Name = "GroupBox00"
        Me.GroupBox00.Size = New System.Drawing.Size(793, 78)
        Me.GroupBox00.TabIndex = 0
        Me.GroupBox00.TabStop = False
        '
        'Cmd10
        '
        Me.Cmd10.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd10.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd10.ForeColor = System.Drawing.Color.Black
        Me.Cmd10.Location = New System.Drawing.Point(707, 14)
        Me.Cmd10.Name = "Cmd10"
        Me.Cmd10.Size = New System.Drawing.Size(80, 45)
        Me.Cmd10.TabIndex = 140
        Me.Cmd10.TabStop = False
        Me.Cmd10.Text = "F10 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "閉じる"
        Me.Cmd10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd10.UseVisualStyleBackColor = False
        '
        'La銀行CD
        '
        Me.La銀行CD.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.La銀行CD.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.La銀行CD.ForeColor = System.Drawing.Color.White
        Me.La銀行CD.Location = New System.Drawing.Point(6, 11)
        Me.La銀行CD.Name = "La銀行CD"
        Me.La銀行CD.Size = New System.Drawing.Size(69, 27)
        Me.La銀行CD.TabIndex = 141
        Me.La銀行CD.Text = "銀行CD"
        Me.La銀行CD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt銀行CD
        '
        Me.txt銀行CD.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt銀行CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt銀行CD.Location = New System.Drawing.Point(81, 11)
        Me.txt銀行CD.Name = "txt銀行CD"
        Me.txt銀行CD.Size = New System.Drawing.Size(50, 27)
        Me.txt銀行CD.TabIndex = 0
        Me.txt銀行CD.Text = "1234"
        Me.txt銀行CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt口座名
        '
        Me.txt口座名.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt口座名.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt口座名.Location = New System.Drawing.Point(137, 11)
        Me.txt口座名.Name = "txt口座名"
        Me.txt口座名.ReadOnly = True
        Me.txt口座名.Size = New System.Drawing.Size(226, 27)
        Me.txt口座名.TabIndex = 143
        Me.txt口座名.TabStop = False
        Me.txt口座名.Text = "口座名"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 27)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "口座番号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt口座番号
        '
        Me.txt口座番号.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt口座番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt口座番号.Location = New System.Drawing.Point(81, 42)
        Me.txt口座番号.Name = "txt口座番号"
        Me.txt口座番号.Size = New System.Drawing.Size(110, 27)
        Me.txt口座番号.TabIndex = 1
        Me.txt口座番号.Text = "0123456789"
        Me.txt口座番号.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnOK00
        '
        Me.btnOK00.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOK00.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnOK00.Location = New System.Drawing.Point(260, 39)
        Me.btnOK00.Name = "btnOK00"
        Me.btnOK00.Size = New System.Drawing.Size(103, 33)
        Me.btnOK00.TabIndex = 2
        Me.btnOK00.Text = "検索"
        Me.btnOK00.UseVisualStyleBackColor = False
        '
        'txtMsg
        '
        Me.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMsg.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txtMsg.ForeColor = System.Drawing.Color.Red
        Me.txtMsg.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtMsg.Location = New System.Drawing.Point(369, 42)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ReadOnly = True
        Me.txtMsg.Size = New System.Drawing.Size(162, 27)
        Me.txtMsg.TabIndex = 129
        Me.txtMsg.TabStop = False
        Me.txtMsg.Text = "追加"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 82)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(793, 396)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'F_S_MotGin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 481)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox00)
        Me.Name = "F_S_MotGin"
        Me.Text = "口座マスタ参照"
        Me.GroupBox00.ResumeLayout(False)
        Me.GroupBox00.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox00 As GroupBox
    Friend WithEvents La銀行CD As Label
    Friend WithEvents Cmd10 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt口座名 As TextBox
    Friend WithEvents txt銀行CD As TextBox
    Friend WithEvents btnOK00 As Button
    Friend WithEvents txt口座番号 As TextBox
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents ListView1 As ListView
End Class
