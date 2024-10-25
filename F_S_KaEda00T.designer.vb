<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.ComponentModel.ToolboxItem(True)> _
Partial Class F_S_KaEda00T
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
        Dim Border6 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle5 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border7 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle6 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border8 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle7 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border9 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle8 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border10 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle9 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border11 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle10 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border12 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle11 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border13 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle1 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border2 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle2 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border3 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle3 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border4 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim RangeValidator1 As GrapeCity.Win.MultiRow.RangeValidator = New GrapeCity.Win.MultiRow.RangeValidator
        Dim CellStyle4 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border5 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim RangeValidator2 As GrapeCity.Win.MultiRow.RangeValidator = New GrapeCity.Win.MultiRow.RangeValidator
        Me.ColumnHeaderSection1 = New GrapeCity.Win.MultiRow.ColumnHeaderSection
        Me.Fi枝番CD = New GrapeCity.Win.MultiRow.FilteringTextBoxCell
        Me.Fi枝番Kana = New GrapeCity.Win.MultiRow.FilteringTextBoxCell
        Me.Fi枝番名 = New GrapeCity.Win.MultiRow.FilteringTextBoxCell
        Me.LabelCell2 = New GrapeCity.Win.MultiRow.LabelCell
        Me.so枝番CD = New GrapeCity.Win.MultiRow.ColumnHeaderCell
        Me.so枝番Kana = New GrapeCity.Win.MultiRow.ColumnHeaderCell
        Me.so枝番名 = New GrapeCity.Win.MultiRow.ColumnHeaderCell
        Me.ColumnFooterSection1 = New GrapeCity.Win.MultiRow.ColumnFooterSection
        Me.SEQ = New GrapeCity.Win.MultiRow.RowHeaderCell
        Me.枝番CD = New GrapeCity.Win.MultiRow.TextBoxCell
        Me.枝番Kana名 = New GrapeCity.Win.MultiRow.TextBoxCell
        Me.枝番名 = New GrapeCity.Win.MultiRow.TextBoxCell
        '
        'Row
        '
        Border1.Bottom = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.SkyBlue)
        Me.Row.Border = Border1
        Me.Row.Cells.Add(Me.SEQ)
        Me.Row.Cells.Add(Me.枝番CD)
        Me.Row.Cells.Add(Me.枝番Kana名)
        Me.Row.Cells.Add(Me.枝番名)
        Me.Row.Height = 21
        Me.Row.Width = 532
        '
        'ColumnHeaderSection1
        '
        Border6.Bottom = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.SkyBlue)
        Me.ColumnHeaderSection1.Border = Border6
        Me.ColumnHeaderSection1.Cells.Add(Me.Fi枝番CD)
        Me.ColumnHeaderSection1.Cells.Add(Me.Fi枝番Kana)
        Me.ColumnHeaderSection1.Cells.Add(Me.Fi枝番名)
        Me.ColumnHeaderSection1.Cells.Add(Me.LabelCell2)
        Me.ColumnHeaderSection1.Cells.Add(Me.so枝番CD)
        Me.ColumnHeaderSection1.Cells.Add(Me.so枝番Kana)
        Me.ColumnHeaderSection1.Cells.Add(Me.so枝番名)
        Me.ColumnHeaderSection1.Height = 41
        Me.ColumnHeaderSection1.Name = "ColumnHeaderSection1"
        Me.ColumnHeaderSection1.ReadOnly = False
        Me.ColumnHeaderSection1.Selectable = True
        Me.ColumnHeaderSection1.Width = 532
        '
        'Fi枝番CD
        '
        Me.Fi枝番CD.CustomComparisonOperator = Nothing
        Me.Fi枝番CD.FilteringCellName = "枝番CD"
        Me.Fi枝番CD.Location = New System.Drawing.Point(52, 21)
        Me.Fi枝番CD.Name = "Fi枝番CD"
        Me.Fi枝番CD.Size = New System.Drawing.Size(59, 20)
        CellStyle5.BackColor = System.Drawing.SystemColors.Window
        Border7.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle5.Border = Border7
        Me.Fi枝番CD.Style = CellStyle5
        Me.Fi枝番CD.TabIndex = 0
        '
        'Fi枝番Kana
        '
        Me.Fi枝番Kana.CustomComparisonOperator = Nothing
        Me.Fi枝番Kana.FilterComparisonOperator = GrapeCity.Win.MultiRow.FilterComparisonOperator.Contains
        Me.Fi枝番Kana.FilteringCellName = "枝番Kana名"
        Me.Fi枝番Kana.Location = New System.Drawing.Point(113, 21)
        Me.Fi枝番Kana.Name = "Fi枝番Kana"
        Me.Fi枝番Kana.Size = New System.Drawing.Size(117, 20)
        CellStyle6.BackColor = System.Drawing.SystemColors.Window
        Border8.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle6.Border = Border8
        CellStyle6.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.Fi枝番Kana.Style = CellStyle6
        Me.Fi枝番Kana.TabIndex = 1
        '
        'Fi枝番名
        '
        Me.Fi枝番名.CustomComparisonOperator = Nothing
        Me.Fi枝番名.FilterComparisonOperator = GrapeCity.Win.MultiRow.FilterComparisonOperator.Contains
        Me.Fi枝番名.FilteringCellName = "枝番名"
        Me.Fi枝番名.Location = New System.Drawing.Point(232, 21)
        Me.Fi枝番名.Name = "Fi枝番名"
        Me.Fi枝番名.Size = New System.Drawing.Size(300, 20)
        CellStyle7.BackColor = System.Drawing.SystemColors.Window
        Border9.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle7.Border = Border9
        CellStyle7.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Fi枝番名.Style = CellStyle7
        Me.Fi枝番名.TabIndex = 2
        '
        'LabelCell2
        '
        Me.LabelCell2.Location = New System.Drawing.Point(1, 21)
        Me.LabelCell2.Name = "LabelCell2"
        Me.LabelCell2.Size = New System.Drawing.Size(49, 20)
        CellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        Border10.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle8.Border = Border10
        CellStyle8.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        CellStyle8.TextVertical = GrapeCity.Win.MultiRow.MultiRowTriState.[False]
        CellStyle8.UseCompatibleTextRendering = GrapeCity.Win.MultiRow.MultiRowTriState.[True]
        Me.LabelCell2.Style = CellStyle8
        Me.LabelCell2.TabIndex = 0
        Me.LabelCell2.Value = "No"
        '
        'so枝番CD
        '
        Me.so枝番CD.Location = New System.Drawing.Point(52, 1)
        Me.so枝番CD.Name = "so枝番CD"
        Me.so枝番CD.SelectionMode = GrapeCity.Win.MultiRow.MultiRowSelectionMode.None
        Me.so枝番CD.Size = New System.Drawing.Size(59, 20)
        Me.so枝番CD.SortCellName = "枝番CD"
        Me.so枝番CD.SortMode = GrapeCity.Win.MultiRow.SortMode.Automatic
        Border11.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle9.Border = Border11
        CellStyle9.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        Me.so枝番CD.Style = CellStyle9
        Me.so枝番CD.TabIndex = 11
        Me.so枝番CD.UseVisualStyleBackColor = False
        Me.so枝番CD.Value = "枝番CD"
        '
        'so枝番Kana
        '
        Me.so枝番Kana.Location = New System.Drawing.Point(113, 1)
        Me.so枝番Kana.Name = "so枝番Kana"
        Me.so枝番Kana.SelectionMode = GrapeCity.Win.MultiRow.MultiRowSelectionMode.None
        Me.so枝番Kana.Size = New System.Drawing.Size(117, 20)
        Me.so枝番Kana.SortCellName = "枝番Kana名"
        Me.so枝番Kana.SortMode = GrapeCity.Win.MultiRow.SortMode.Automatic
        Border12.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle10.Border = Border12
        CellStyle10.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        Me.so枝番Kana.Style = CellStyle10
        Me.so枝番Kana.TabIndex = 36
        Me.so枝番Kana.UseVisualStyleBackColor = False
        Me.so枝番Kana.Value = "枝番カナ"
        '
        'so枝番名
        '
        Me.so枝番名.Location = New System.Drawing.Point(232, 1)
        Me.so枝番名.Name = "so枝番名"
        Me.so枝番名.SelectionMode = GrapeCity.Win.MultiRow.MultiRowSelectionMode.None
        Me.so枝番名.Size = New System.Drawing.Size(300, 20)
        Me.so枝番名.SortCellName = "枝番名"
        Me.so枝番名.SortMode = GrapeCity.Win.MultiRow.SortMode.Automatic
        Border13.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle11.Border = Border13
        CellStyle11.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        Me.so枝番名.Style = CellStyle11
        Me.so枝番名.TabIndex = 29
        Me.so枝番名.UseVisualStyleBackColor = False
        Me.so枝番名.Value = "枝　番　名"
        '
        'ColumnFooterSection1
        '
        Me.ColumnFooterSection1.Height = 1
        Me.ColumnFooterSection1.Name = "ColumnFooterSection1"
        Me.ColumnFooterSection1.Width = 532
        '
        'SEQ
        '
        Me.SEQ.Location = New System.Drawing.Point(1, 1)
        Me.SEQ.Name = "SEQ"
        Me.SEQ.Size = New System.Drawing.Size(49, 20)
        Border2.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle1.Border = Border2
        Me.SEQ.Style = CellStyle1
        Me.SEQ.TabIndex = 0
        Me.SEQ.Value = "9999"
        '
        '枝番CD
        '
        Me.枝番CD.Location = New System.Drawing.Point(52, 1)
        Me.枝番CD.MaxLength = 11
        Me.枝番CD.Name = "枝番CD"
        Me.枝番CD.ReadOnly = True
        Me.枝番CD.Size = New System.Drawing.Size(59, 20)
        CellStyle2.BackColor = System.Drawing.Color.White
        Border3.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle2.Border = Border3
        CellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        CellStyle2.ImeMode = System.Windows.Forms.ImeMode.Disable
        CellStyle2.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleRight
        Me.枝番CD.Style = CellStyle2
        Me.枝番CD.TabIndex = 1
        Me.枝番CD.TabStop = False
        Me.枝番CD.Value = "枝番CD"
        '
        '枝番Kana名
        '
        Me.枝番Kana名.Location = New System.Drawing.Point(113, 1)
        Me.枝番Kana名.MaxLength = 4
        Me.枝番Kana名.Name = "枝番Kana名"
        Me.枝番Kana名.ReadOnly = True
        Me.枝番Kana名.Size = New System.Drawing.Size(117, 20)
        CellStyle3.BackColor = System.Drawing.Color.White
        Border4.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle3.Border = Border4
        CellStyle3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        CellStyle3.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        CellStyle3.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleLeft
        Me.枝番Kana名.Style = CellStyle3
        Me.枝番Kana名.TabIndex = 2
        RangeValidator1.MaxValue = "99.9"
        RangeValidator1.MinValue = "0"
        Me.枝番Kana名.Validators.Add(RangeValidator1)
        Me.枝番Kana名.Value = "123456789012345678901234567890123456789012345678901234567890"
        '
        '枝番名
        '
        Me.枝番名.Location = New System.Drawing.Point(232, 1)
        Me.枝番名.MaxLength = 4
        Me.枝番名.Name = "枝番名"
        Me.枝番名.ReadOnly = True
        Me.枝番名.Size = New System.Drawing.Size(300, 20)
        CellStyle4.BackColor = System.Drawing.Color.White
        Border5.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle4.Border = Border5
        CellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        CellStyle4.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        CellStyle4.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleLeft
        Me.枝番名.Style = CellStyle4
        Me.枝番名.TabIndex = 3
        RangeValidator2.MaxValue = "99.9"
        RangeValidator2.MinValue = "0"
        Me.枝番名.Validators.Add(RangeValidator2)
        Me.枝番名.Value = "123456789012345678901234567890123456789012345678901234567890"
        '
        'F_S_KaEda00T
        '
        Me.ColumnFooters.AddRange(New GrapeCity.Win.MultiRow.ColumnFooterSection() {Me.ColumnFooterSection1})
        Me.ColumnHeaders.AddRange(New GrapeCity.Win.MultiRow.ColumnHeaderSection() {Me.ColumnHeaderSection1})
        Me.Height = 63
        Me.Width = 532

    End Sub
    Friend WithEvents SEQ As GrapeCity.Win.MultiRow.RowHeaderCell
    Friend WithEvents 枝番CD As GrapeCity.Win.MultiRow.TextBoxCell
    Friend WithEvents 枝番Kana名 As GrapeCity.Win.MultiRow.TextBoxCell
    Friend WithEvents 枝番名 As GrapeCity.Win.MultiRow.TextBoxCell
    Friend WithEvents ColumnHeaderSection1 As GrapeCity.Win.MultiRow.ColumnHeaderSection
    Friend WithEvents Fi枝番CD As GrapeCity.Win.MultiRow.FilteringTextBoxCell
    Friend WithEvents Fi枝番Kana As GrapeCity.Win.MultiRow.FilteringTextBoxCell
    Friend WithEvents Fi枝番名 As GrapeCity.Win.MultiRow.FilteringTextBoxCell
    Friend WithEvents LabelCell2 As GrapeCity.Win.MultiRow.LabelCell
    Friend WithEvents so枝番CD As GrapeCity.Win.MultiRow.ColumnHeaderCell
    Friend WithEvents so枝番Kana As GrapeCity.Win.MultiRow.ColumnHeaderCell
    Friend WithEvents so枝番名 As GrapeCity.Win.MultiRow.ColumnHeaderCell
    Friend WithEvents ColumnFooterSection1 As GrapeCity.Win.MultiRow.ColumnFooterSection
    



End Class
