<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.ComponentModel.ToolboxItem(True)> _
Partial Class F_S_Bank10T
    Inherits GrapeCity.Win.MultiRow.Template

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'MultiRow テンプレート デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは MultiRow テンプレート デザイナで必要です。
    'MultiRow テンプレート デザイナを使用して変更できます。 
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Border1 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle4 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border5 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle5 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border6 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle6 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border7 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle7 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border8 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle8 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border9 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle9 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border10 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle1 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border2 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle2 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border3 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim RangeValidator1 As GrapeCity.Win.MultiRow.RangeValidator = New GrapeCity.Win.MultiRow.RangeValidator
        Dim CellStyle3 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border4 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim RangeValidator2 As GrapeCity.Win.MultiRow.RangeValidator = New GrapeCity.Win.MultiRow.RangeValidator
        Me.ColumnHeaderSection1 = New GrapeCity.Win.MultiRow.ColumnHeaderSection
        Me.Fi銀行CD = New GrapeCity.Win.MultiRow.FilteringTextBoxCell
        Me.Fi銀行Kana = New GrapeCity.Win.MultiRow.FilteringTextBoxCell
        Me.Fi銀行名 = New GrapeCity.Win.MultiRow.FilteringTextBoxCell
        Me.LabelCell1 = New GrapeCity.Win.MultiRow.LabelCell
        Me.LabelCell2 = New GrapeCity.Win.MultiRow.LabelCell
        Me.LabelCell3 = New GrapeCity.Win.MultiRow.LabelCell
        Me.ColumnFooterSection1 = New GrapeCity.Win.MultiRow.ColumnFooterSection
        Me.銀行CD = New GrapeCity.Win.MultiRow.TextBoxCell
        Me.銀行Kana名 = New GrapeCity.Win.MultiRow.TextBoxCell
        Me.銀行名 = New GrapeCity.Win.MultiRow.TextBoxCell
        '
        'Row
        '
        Border1.Bottom = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.MediumTurquoise)
        Me.Row.Border = Border1
        Me.Row.Cells.Add(Me.銀行CD)
        Me.Row.Cells.Add(Me.銀行Kana名)
        Me.Row.Cells.Add(Me.銀行名)
        Me.Row.Height = 22
        Me.Row.Width = 345
        '
        'ColumnHeaderSection1
        '
        Me.ColumnHeaderSection1.Cells.Add(Me.Fi銀行CD)
        Me.ColumnHeaderSection1.Cells.Add(Me.Fi銀行Kana)
        Me.ColumnHeaderSection1.Cells.Add(Me.Fi銀行名)
        Me.ColumnHeaderSection1.Cells.Add(Me.LabelCell1)
        Me.ColumnHeaderSection1.Cells.Add(Me.LabelCell2)
        Me.ColumnHeaderSection1.Cells.Add(Me.LabelCell3)
        Me.ColumnHeaderSection1.Height = 44
        Me.ColumnHeaderSection1.Name = "ColumnHeaderSection1"
        Me.ColumnHeaderSection1.ReadOnly = False
        Me.ColumnHeaderSection1.Selectable = True
        Me.ColumnHeaderSection1.Width = 345
        '
        'Fi銀行CD
        '
        Me.Fi銀行CD.CustomComparisonOperator = Nothing
        Me.Fi銀行CD.FilteringCellName = "銀行CD"
        Me.Fi銀行CD.Location = New System.Drawing.Point(2, 23)
        Me.Fi銀行CD.Name = "Fi銀行CD"
        Me.Fi銀行CD.Size = New System.Drawing.Size(59, 21)
        CellStyle4.BackColor = System.Drawing.SystemColors.Window
        Border5.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle4.Border = Border5
        CellStyle4.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Fi銀行CD.Style = CellStyle4
        Me.Fi銀行CD.TabIndex = 0
        '
        'Fi銀行Kana
        '
        Me.Fi銀行Kana.CustomComparisonOperator = Nothing
        Me.Fi銀行Kana.FilterComparisonOperator = GrapeCity.Win.MultiRow.FilterComparisonOperator.Contains
        Me.Fi銀行Kana.FilteringCellName = "銀行Kana名"
        Me.Fi銀行Kana.Location = New System.Drawing.Point(63, 23)
        Me.Fi銀行Kana.Name = "Fi銀行Kana"
        Me.Fi銀行Kana.Size = New System.Drawing.Size(93, 21)
        CellStyle5.BackColor = System.Drawing.SystemColors.Window
        Border6.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle5.Border = Border6
        CellStyle5.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.Fi銀行Kana.Style = CellStyle5
        Me.Fi銀行Kana.TabIndex = 1
        '
        'Fi銀行名
        '
        Me.Fi銀行名.CustomComparisonOperator = Nothing
        Me.Fi銀行名.FilterComparisonOperator = GrapeCity.Win.MultiRow.FilterComparisonOperator.Contains
        Me.Fi銀行名.FilteringCellName = "銀行名"
        Me.Fi銀行名.Location = New System.Drawing.Point(158, 23)
        Me.Fi銀行名.Name = "Fi銀行名"
        Me.Fi銀行名.Size = New System.Drawing.Size(187, 21)
        CellStyle6.BackColor = System.Drawing.SystemColors.Window
        Border7.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle6.Border = Border7
        CellStyle6.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Fi銀行名.Style = CellStyle6
        Me.Fi銀行名.TabIndex = 2
        '
        'LabelCell1
        '
        Me.LabelCell1.Location = New System.Drawing.Point(2, 1)
        Me.LabelCell1.Name = "LabelCell1"
        Me.LabelCell1.Size = New System.Drawing.Size(59, 21)
        CellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        Border8.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle7.Border = Border8
        CellStyle7.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        CellStyle7.TextVertical = GrapeCity.Win.MultiRow.MultiRowTriState.[False]
        CellStyle7.UseCompatibleTextRendering = GrapeCity.Win.MultiRow.MultiRowTriState.[True]
        Me.LabelCell1.Style = CellStyle7
        Me.LabelCell1.TabIndex = 37
        Me.LabelCell1.Value = "銀行CD"
        '
        'LabelCell2
        '
        Me.LabelCell2.Location = New System.Drawing.Point(63, 1)
        Me.LabelCell2.Name = "LabelCell2"
        Me.LabelCell2.Size = New System.Drawing.Size(93, 21)
        CellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        Border9.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle8.Border = Border9
        CellStyle8.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        CellStyle8.TextVertical = GrapeCity.Win.MultiRow.MultiRowTriState.[False]
        CellStyle8.UseCompatibleTextRendering = GrapeCity.Win.MultiRow.MultiRowTriState.[True]
        Me.LabelCell2.Style = CellStyle8
        Me.LabelCell2.TabIndex = 38
        Me.LabelCell2.Value = "銀行カナ名"
        '
        'LabelCell3
        '
        Me.LabelCell3.Location = New System.Drawing.Point(158, 1)
        Me.LabelCell3.Name = "LabelCell3"
        Me.LabelCell3.Size = New System.Drawing.Size(187, 21)
        CellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        Border10.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle9.Border = Border10
        CellStyle9.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        CellStyle9.TextVertical = GrapeCity.Win.MultiRow.MultiRowTriState.[False]
        CellStyle9.UseCompatibleTextRendering = GrapeCity.Win.MultiRow.MultiRowTriState.[True]
        Me.LabelCell3.Style = CellStyle9
        Me.LabelCell3.TabIndex = 39
        Me.LabelCell3.Value = "銀　行　名"
        '
        'ColumnFooterSection1
        '
        Me.ColumnFooterSection1.Height = 1
        Me.ColumnFooterSection1.Name = "ColumnFooterSection1"
        Me.ColumnFooterSection1.Width = 345
        '
        '銀行CD
        '
        Me.銀行CD.Location = New System.Drawing.Point(2, 1)
        Me.銀行CD.MaxLength = 11
        Me.銀行CD.Name = "銀行CD"
        Me.銀行CD.ReadOnly = True
        Me.銀行CD.Size = New System.Drawing.Size(59, 21)
        CellStyle1.BackColor = System.Drawing.Color.White
        Border2.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle1.Border = Border2
        CellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        CellStyle1.ImeMode = System.Windows.Forms.ImeMode.Disable
        CellStyle1.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleRight
        Me.銀行CD.Style = CellStyle1
        Me.銀行CD.TabIndex = 0
        Me.銀行CD.TabStop = False
        Me.銀行CD.Value = "銀行CD"
        '
        '銀行Kana名
        '
        Me.銀行Kana名.Location = New System.Drawing.Point(63, 1)
        Me.銀行Kana名.MaxLength = 15
        Me.銀行Kana名.Name = "銀行Kana名"
        Me.銀行Kana名.ReadOnly = True
        Me.銀行Kana名.Size = New System.Drawing.Size(93, 21)
        CellStyle2.BackColor = System.Drawing.Color.White
        Border3.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle2.Border = Border3
        CellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        CellStyle2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        CellStyle2.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleLeft
        Me.銀行Kana名.Style = CellStyle2
        Me.銀行Kana名.TabIndex = 1
        RangeValidator1.MaxValue = "99.9"
        RangeValidator1.MinValue = "0"
        Me.銀行Kana名.Validators.Add(RangeValidator1)
        Me.銀行Kana名.Value = "111111111122222"
        '
        '銀行名
        '
        Me.銀行名.Location = New System.Drawing.Point(158, 1)
        Me.銀行名.MaxLength = 4
        Me.銀行名.Name = "銀行名"
        Me.銀行名.ReadOnly = True
        Me.銀行名.Size = New System.Drawing.Size(187, 21)
        CellStyle3.BackColor = System.Drawing.Color.White
        Border4.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle3.Border = Border4
        CellStyle3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        CellStyle3.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        CellStyle3.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleLeft
        Me.銀行名.Style = CellStyle3
        Me.銀行名.TabIndex = 2
        RangeValidator2.MaxValue = "99.9"
        RangeValidator2.MinValue = "0"
        Me.銀行名.Validators.Add(RangeValidator2)
        Me.銀行名.Value = "123456789012345678901234567890"
        '
        'F_S_Bank10T
        '
        Me.ColumnFooters.AddRange(New GrapeCity.Win.MultiRow.ColumnFooterSection() {Me.ColumnFooterSection1})
        Me.ColumnHeaders.AddRange(New GrapeCity.Win.MultiRow.ColumnHeaderSection() {Me.ColumnHeaderSection1})
        Me.Height = 67
        Me.Width = 345

    End Sub
    Friend WithEvents 銀行CD As GrapeCity.Win.MultiRow.TextBoxCell
    Friend WithEvents 銀行Kana名 As GrapeCity.Win.MultiRow.TextBoxCell
    Friend WithEvents 銀行名 As GrapeCity.Win.MultiRow.TextBoxCell
    Friend WithEvents ColumnHeaderSection1 As GrapeCity.Win.MultiRow.ColumnHeaderSection
    Friend WithEvents Fi銀行CD As GrapeCity.Win.MultiRow.FilteringTextBoxCell
    Friend WithEvents Fi銀行Kana As GrapeCity.Win.MultiRow.FilteringTextBoxCell
    Friend WithEvents Fi銀行名 As GrapeCity.Win.MultiRow.FilteringTextBoxCell
    Friend WithEvents ColumnFooterSection1 As GrapeCity.Win.MultiRow.ColumnFooterSection
    Friend WithEvents LabelCell1 As GrapeCity.Win.MultiRow.LabelCell
    Friend WithEvents LabelCell2 As GrapeCity.Win.MultiRow.LabelCell
    Friend WithEvents LabelCell3 As GrapeCity.Win.MultiRow.LabelCell
    



End Class
