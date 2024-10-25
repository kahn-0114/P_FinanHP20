<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_S_Forgani00
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
        Me.btnEnd = New System.Windows.Forms.Button
        Me.GcMultiRow1 = New GrapeCity.Win.MultiRow.GcMultiRow
        Me.F_S_Forgani00T1 = New p_FinanHp10.F_S_Forgani00T
        CType(Me.GcMultiRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(234, 1)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(84, 40)
        Me.btnEnd.TabIndex = 31
        Me.btnEnd.Text = "F11 終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'GcMultiRow1
        '
        Me.GcMultiRow1.Location = New System.Drawing.Point(5, 44)
        Me.GcMultiRow1.Name = "GcMultiRow1"
        Me.GcMultiRow1.Size = New System.Drawing.Size(311, 470)
        Me.GcMultiRow1.TabIndex = 103
        Me.GcMultiRow1.Template = Me.F_S_Forgani00T1
        Me.GcMultiRow1.Text = "GcMultiRow1"
        '
        'F_S_Forgani00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 521)
        Me.Controls.Add(Me.GcMultiRow1)
        Me.Controls.Add(Me.btnEnd)
        Me.KeyPreview = True
        Me.Name = "F_S_Forgani00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "財務部門参照"
        CType(Me.GcMultiRow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents GcMultiRow1 As GrapeCity.Win.MultiRow.GcMultiRow
    Friend F_S_Forgani00T1 As p_FinanHp10.F_S_Forgani00T
End Class
