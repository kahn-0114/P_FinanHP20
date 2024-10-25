<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_S_Kam00
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
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.txt科目CDF = New System.Windows.Forms.TextBox()
        Me.txt科目CDT = New System.Windows.Forms.TextBox()
        Me.GcMultiRow1 = New GrapeCity.Win.MultiRow.GcMultiRow()
        Me.F_S_Kam00T1 = New p_FinanHp10.F_S_Kam00T()
        CType(Me.GcMultiRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(474, 1)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(84, 40)
        Me.btnEnd.TabIndex = 31
        Me.btnEnd.Text = "F11 終了"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'txt科目CDF
        '
        Me.txt科目CDF.BackColor = System.Drawing.SystemColors.Control
        Me.txt科目CDF.Enabled = False
        Me.txt科目CDF.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt科目CDF.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt科目CDF.Location = New System.Drawing.Point(4, 1)
        Me.txt科目CDF.Name = "txt科目CDF"
        Me.txt科目CDF.ReadOnly = True
        Me.txt科目CDF.Size = New System.Drawing.Size(38, 20)
        Me.txt科目CDF.TabIndex = 99
        Me.txt科目CDF.Visible = False
        '
        'txt科目CDT
        '
        Me.txt科目CDT.BackColor = System.Drawing.SystemColors.Control
        Me.txt科目CDT.Enabled = False
        Me.txt科目CDT.Font = New System.Drawing.Font("ＭＳ Ｐゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt科目CDT.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt科目CDT.Location = New System.Drawing.Point(43, 1)
        Me.txt科目CDT.Name = "txt科目CDT"
        Me.txt科目CDT.ReadOnly = True
        Me.txt科目CDT.Size = New System.Drawing.Size(38, 20)
        Me.txt科目CDT.TabIndex = 100
        Me.txt科目CDT.Visible = False
        '
        'GcMultiRow1
        '
        Me.GcMultiRow1.Location = New System.Drawing.Point(4, 44)
        Me.GcMultiRow1.Name = "GcMultiRow1"
        Me.GcMultiRow1.Size = New System.Drawing.Size(554, 500)
        Me.GcMultiRow1.TabIndex = 101
        Me.GcMultiRow1.Template = Me.F_S_Kam00T1
        Me.GcMultiRow1.Text = "GcMultiRow1"
        '
        'F_S_Kam00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 551)
        Me.Controls.Add(Me.GcMultiRow1)
        Me.Controls.Add(Me.txt科目CDT)
        Me.Controls.Add(Me.txt科目CDF)
        Me.Controls.Add(Me.btnEnd)
        Me.KeyPreview = True
        Me.Name = "F_S_Kam00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "財務科目参照"
        CType(Me.GcMultiRow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents txt科目CDF As System.Windows.Forms.TextBox
    Friend WithEvents txt科目CDT As System.Windows.Forms.TextBox
    Friend WithEvents GcMultiRow1 As GrapeCity.Win.MultiRow.GcMultiRow
    Friend WithEvents F_S_Kam00T1 As p_FinanHp10.F_S_Kam00T
End Class
