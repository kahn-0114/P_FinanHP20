<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_S_OrgBank00
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
        Me.LV = New System.Windows.Forms.ListView
        Me.LVNo = New System.Windows.Forms.ColumnHeader
        Me.LV銀行名 = New System.Windows.Forms.ColumnHeader
        Me.LV支店名 = New System.Windows.Forms.ColumnHeader
        Me.LV口座番号 = New System.Windows.Forms.ColumnHeader
        Me.LV口座名 = New System.Windows.Forms.ColumnHeader
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmd11 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LVNo, Me.LV銀行名, Me.LV支店名, Me.LV口座番号, Me.LV口座名})
        Me.LV.Font = New System.Drawing.Font("ＭＳ 明朝", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.HideSelection = False
        Me.LV.HoverSelection = True
        Me.LV.Location = New System.Drawing.Point(4, 47)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(772, 452)
        Me.LV.SmallImageList = Me.ImageList1
        Me.LV.TabIndex = 1
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'LVNo
        '
        Me.LVNo.Text = "No"
        Me.LVNo.Width = 40
        '
        'LV銀行名
        '
        Me.LV銀行名.Text = "銀行名"
        Me.LV銀行名.Width = 200
        '
        'LV支店名
        '
        Me.LV支店名.Text = "支店名"
        Me.LV支店名.Width = 200
        '
        'LV口座番号
        '
        Me.LV口座番号.Text = "口座番号"
        Me.LV口座番号.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LV口座番号.Width = 100
        '
        'LV口座名
        '
        Me.LV口座名.Text = "口座名"
        Me.LV口座名.Width = 200
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(1, 20)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmd11)
        Me.GroupBox1.Location = New System.Drawing.Point(4, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 48)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Cmd11
        '
        Me.Cmd11.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cmd11.Location = New System.Drawing.Point(648, 6)
        Me.Cmd11.Name = "Cmd11"
        Me.Cmd11.Size = New System.Drawing.Size(120, 40)
        Me.Cmd11.TabIndex = 101
        Me.Cmd11.Text = "F11 終了"
        Me.Cmd11.UseVisualStyleBackColor = True
        '
        'F_S_MotGin00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LV)
        Me.KeyPreview = True
        Me.Name = "F_S_MotGin00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "依頼銀行参照"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents LVNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV銀行名 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LV支店名 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV口座番号 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV口座名 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd11 As System.Windows.Forms.Button
End Class
