<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Co_Start00
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Co_Start00))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtOut0 = New System.Windows.Forms.Label()
        Me.txtOut1 = New System.Windows.Forms.Label()
        Me.txtOut2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtOut0
        '
        Me.txtOut0.Font = New System.Drawing.Font("メイリオ", 21.75!)
        Me.txtOut0.Location = New System.Drawing.Point(36, 108)
        Me.txtOut0.Name = "txtOut0"
        Me.txtOut0.Size = New System.Drawing.Size(359, 45)
        Me.txtOut0.TabIndex = 1
        Me.txtOut0.Text = "リベート管理システム"
        Me.txtOut0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOut1
        '
        Me.txtOut1.Font = New System.Drawing.Font("メイリオ", 15.75!)
        Me.txtOut1.Location = New System.Drawing.Point(208, 153)
        Me.txtOut1.Name = "txtOut1"
        Me.txtOut1.Size = New System.Drawing.Size(344, 23)
        Me.txtOut1.TabIndex = 2
        Me.txtOut1.Text = "For Windows      or later."
        Me.txtOut1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOut2
        '
        Me.txtOut2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOut2.Font = New System.Drawing.Font("メイリオ", 15.75!)
        Me.txtOut2.Location = New System.Drawing.Point(208, 176)
        Me.txtOut2.Name = "txtOut2"
        Me.txtOut2.Size = New System.Drawing.Size(344, 23)
        Me.txtOut2.TabIndex = 3
        Me.txtOut2.Text = "ﾊﾞｰｼﾞｮﾝ 1.0"
        Me.txtOut2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(310, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "著作権"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(310, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "システムイノベーション　株式会社"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'F_Co_Start00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 286)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOut2)
        Me.Controls.Add(Me.txtOut1)
        Me.Controls.Add(Me.txtOut0)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "F_Co_Start00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtOut0 As System.Windows.Forms.Label
    Friend WithEvents txtOut1 As System.Windows.Forms.Label
    Friend WithEvents txtOut2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
