<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_S_KuBunM00
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
        Me.LV = New System.Windows.Forms.ListView()
        Me.LVCD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV名称 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.txt区分 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LVCD, Me.LV名称})
        Me.LV.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(5, 55)
        Me.LV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(449, 564)
        Me.LV.SmallImageList = Me.ImageList1
        Me.LV.TabIndex = 1
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'LVCD
        '
        Me.LVCD.Text = "CD"
        '
        'LV名称
        '
        Me.LV名称.Text = "名称"
        Me.LV名称.Width = 210
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(1, 20)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.btnEnd.Location = New System.Drawing.Point(343, 2)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(112, 50)
        Me.btnEnd.TabIndex = 31
        Me.btnEnd.Text = "F11 終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'txt区分
        '
        Me.txt区分.BackColor = System.Drawing.SystemColors.Control
        Me.txt区分.Enabled = False
        Me.txt区分.Font = New System.Drawing.Font("メイリオ", 9.75!)
        Me.txt区分.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt区分.Location = New System.Drawing.Point(5, 5)
        Me.txt区分.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt区分.Name = "txt区分"
        Me.txt区分.ReadOnly = True
        Me.txt区分.Size = New System.Drawing.Size(49, 27)
        Me.txt区分.TabIndex = 100
        Me.txt区分.Visible = False
        '
        'F_S_KuBunM00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 628)
        Me.Controls.Add(Me.txt区分)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.LV)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "F_S_KuBunM00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "区分参照"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents LVCD As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV名称 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txt区分 As System.Windows.Forms.TextBox
End Class
