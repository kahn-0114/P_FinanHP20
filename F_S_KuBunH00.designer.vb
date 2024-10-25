<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_S_KuBunH00
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"999", "手数料負担区分"}, -1)
        Me.LV = New System.Windows.Forms.ListView()
        Me.LVCD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV名称 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnEnd = New System.Windows.Forms.Button()
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
        Me.LV.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.LV.Location = New System.Drawing.Point(5, 55)
        Me.LV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LV.MultiSelect = False
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(400, 564)
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
        Me.btnEnd.Location = New System.Drawing.Point(295, 1)
        Me.btnEnd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(112, 50)
        Me.btnEnd.TabIndex = 31
        Me.btnEnd.Text = "F11 終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'F_S_KuBunH00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 628)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.LV)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "F_S_KuBunH00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "区分名称参照"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents LVCD As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV名称 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
