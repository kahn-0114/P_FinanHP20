<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.ComponentModel.ToolboxItem(True)> _
Partial Class F_S_Forgani00T
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
        Dim CellStyle1 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border2 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle2 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border3 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim CellStyle3 As GrapeCity.Win.MultiRow.CellStyle = New GrapeCity.Win.MultiRow.CellStyle
        Dim Border4 As GrapeCity.Win.MultiRow.Border = New GrapeCity.Win.MultiRow.Border
        Dim RangeValidator1 As GrapeCity.Win.MultiRow.RangeValidator = New GrapeCity.Win.MultiRow.RangeValidator
        Me.ColumnHeaderSection1 = New GrapeCity.Win.MultiRow.ColumnHeaderSection
        Me.Fi部門CD = New GrapeCity.Win.MultiRow.FilteringTextBoxCell
        Me.Fi部門名 = New GrapeCity.Win.MultiRow.FilteringTextBoxCell
        Me.LabelCell2 = New GrapeCity.Win.MultiRow.LabelCell
        Me.so部門CD = New GrapeCity.Win.MultiRow.ColumnHeaderCell
        Me.so部門名 = New GrapeCity.Win.MultiRow.ColumnHeaderCell
        Me.ColumnFooterSection1 = New GrapeCity.Win.MultiRow.ColumnFooterSection
        Me.SEQ = New GrapeCity.Win.MultiRow.RowHeaderCell
        Me.部門CD = New GrapeCity.Win.MultiRow.TextBoxCell
        Me.部門名 = New GrapeCity.Win.MultiRow.TextBoxCell
        '
        'Row
        '
        Border1.Bottom = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.MediumTurquoise)
        Me.Row.Border = Border1
        Me.Row.Cells.Add(Me.SEQ)
        Me.Row.Cells.Add(Me.部門CD)
        Me.Row.Cells.Add(Me.部門名)
        Me.Row.Height = 22
        Me.Row.Width = 290
        '
        'ColumnHeaderSection1
        '
        Me.ColumnHeaderSection1.Cells.Add(Me.Fi部門CD)
        Me.ColumnHeaderSection1.Cells.Add(Me.Fi部門名)
        Me.ColumnHeaderSection1.Cells.Add(Me.LabelCell2)
        Me.ColumnHeaderSection1.Cells.Add(Me.so部門CD)
        Me.ColumnHeaderSection1.Cells.Add(Me.so部門名)
        Me.ColumnHeaderSection1.Height = 47
        Me.ColumnHeaderSection1.Name = "ColumnHeaderSection1"
        Me.ColumnHeaderSection1.ReadOnly = False
        Me.ColumnHeaderSection1.Selectable = True
        Me.ColumnHeaderSection1.Width = 290
        '
        'Fi部門CD
        '
        Me.Fi部門CD.CustomComparisonOperator = Nothing
        Me.Fi部門CD.FilteringCellName = "部門CD"
        Me.Fi部門CD.Location = New System.Drawing.Point(52, 26)
        Me.Fi部門CD.Name = "Fi部門CD"
        Me.Fi部門CD.Size = New System.Drawing.Size(99, 21)
        CellStyle4.BackColor = System.Drawing.SystemColors.Window
        Border5.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle4.Border = Border5
        Me.Fi部門CD.Style = CellStyle4
        Me.Fi部門CD.TabIndex = 2
        '
        'Fi部門名
        '
        Me.Fi部門名.CustomComparisonOperator = Nothing
        Me.Fi部門名.FilterComparisonOperator = GrapeCity.Win.MultiRow.FilterComparisonOperator.Contains
        Me.Fi部門名.FilteringCellName = "部門名"
        Me.Fi部門名.Location = New System.Drawing.Point(153, 26)
        Me.Fi部門名.Name = "Fi部門名"
        Me.Fi部門名.Size = New System.Drawing.Size(137, 21)
        CellStyle5.BackColor = System.Drawing.SystemColors.Window
        Border6.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle5.Border = Border6
        CellStyle5.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Fi部門名.Style = CellStyle5
        Me.Fi部門名.TabIndex = 4
        '
        'LabelCell2
        '
        Me.LabelCell2.Location = New System.Drawing.Point(1, 26)
        Me.LabelCell2.Name = "LabelCell2"
        Me.LabelCell2.Size = New System.Drawing.Size(49, 21)
        CellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        Border7.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle6.Border = Border7
        CellStyle6.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        CellStyle6.TextVertical = GrapeCity.Win.MultiRow.MultiRowTriState.[False]
        CellStyle6.UseCompatibleTextRendering = GrapeCity.Win.MultiRow.MultiRowTriState.[True]
        Me.LabelCell2.Style = CellStyle6
        Me.LabelCell2.TabIndex = 0
        Me.LabelCell2.Value = "No"
        '
        'so部門CD
        '
        Me.so部門CD.Location = New System.Drawing.Point(52, 1)
        Me.so部門CD.Name = "so部門CD"
        Me.so部門CD.SelectionMode = GrapeCity.Win.MultiRow.MultiRowSelectionMode.None
        Me.so部門CD.Size = New System.Drawing.Size(99, 24)
        Me.so部門CD.SortCellName = "部門CD"
        Me.so部門CD.SortMode = GrapeCity.Win.MultiRow.SortMode.Automatic
        Border8.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle7.Border = Border8
        CellStyle7.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        Me.so部門CD.Style = CellStyle7
        Me.so部門CD.TabIndex = 11
        Me.so部門CD.UseVisualStyleBackColor = False
        Me.so部門CD.Value = "部門CD"
        '
        'so部門名
        '
        Me.so部門名.Location = New System.Drawing.Point(153, 1)
        Me.so部門名.Name = "so部門名"
        Me.so部門名.SelectionMode = GrapeCity.Win.MultiRow.MultiRowSelectionMode.None
        Me.so部門名.Size = New System.Drawing.Size(137, 24)
        Me.so部門名.SortCellName = "部門名"
        Me.so部門名.SortMode = GrapeCity.Win.MultiRow.SortMode.Automatic
        Border9.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle8.Border = Border9
        CellStyle8.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleCenter
        Me.so部門名.Style = CellStyle8
        Me.so部門名.TabIndex = 29
        Me.so部門名.UseVisualStyleBackColor = False
        Me.so部門名.Value = "部　門　名"
        '
        'ColumnFooterSection1
        '
        Me.ColumnFooterSection1.Height = 1
        Me.ColumnFooterSection1.Name = "ColumnFooterSection1"
        Me.ColumnFooterSection1.Width = 290
        '
        'SEQ
        '
        Me.SEQ.Location = New System.Drawing.Point(1, 1)
        Me.SEQ.Name = "SEQ"
        Me.SEQ.Size = New System.Drawing.Size(49, 21)
        Border2.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle1.Border = Border2
        Me.SEQ.Style = CellStyle1
        Me.SEQ.TabIndex = 0
        Me.SEQ.Value = "9999"
        '
        '部門CD
        '
        Me.部門CD.Location = New System.Drawing.Point(52, 1)
        Me.部門CD.MaxLength = 15
        Me.部門CD.Name = "部門CD"
        Me.部門CD.ReadOnly = True
        Me.部門CD.Size = New System.Drawing.Size(99, 21)
        CellStyle2.BackColor = System.Drawing.Color.White
        Border3.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle2.Border = Border3
        CellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        CellStyle2.ImeMode = System.Windows.Forms.ImeMode.Disable
        CellStyle2.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleRight
        Me.部門CD.Style = CellStyle2
        Me.部門CD.TabIndex = 1
        Me.部門CD.TabStop = False
        Me.部門CD.Value = "123456789012345"
        '
        '部門名
        '
        Me.部門名.Location = New System.Drawing.Point(153, 1)
        Me.部門名.MaxLength = 20
        Me.部門名.Name = "部門名"
        Me.部門名.ReadOnly = True
        Me.部門名.Size = New System.Drawing.Size(137, 21)
        CellStyle3.BackColor = System.Drawing.Color.White
        Border4.Outline = New GrapeCity.Win.MultiRow.Line(GrapeCity.Win.MultiRow.LineStyle.Thin, System.Drawing.Color.Gray)
        CellStyle3.Border = Border4
        CellStyle3.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        CellStyle3.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        CellStyle3.TextAlign = GrapeCity.Win.MultiRow.MultiRowContentAlignment.MiddleLeft
        Me.部門名.Style = CellStyle3
        Me.部門名.TabIndex = 3
        RangeValidator1.MaxValue = "99.9"
        RangeValidator1.MinValue = "0"
        Me.部門名.Validators.Add(RangeValidator1)
        Me.部門名.Value = "12345678901234567890"
        '
        'F_S_Forgani00T
        '
        Me.ColumnFooters.AddRange(New GrapeCity.Win.MultiRow.ColumnFooterSection() {Me.ColumnFooterSection1})
        Me.ColumnHeaders.AddRange(New GrapeCity.Win.MultiRow.ColumnHeaderSection() {Me.ColumnHeaderSection1})
        Me.Height = 70
        Me.Width = 290

    End Sub
    Friend WithEvents SEQ As GrapeCity.Win.MultiRow.RowHeaderCell
    Friend WithEvents 部門CD As GrapeCity.Win.MultiRow.TextBoxCell
    Friend WithEvents 部門名 As GrapeCity.Win.MultiRow.TextBoxCell
    Friend WithEvents ColumnHeaderSection1 As GrapeCity.Win.MultiRow.ColumnHeaderSection
    Friend WithEvents Fi部門CD As GrapeCity.Win.MultiRow.FilteringTextBoxCell
    Friend WithEvents Fi部門名 As GrapeCity.Win.MultiRow.FilteringTextBoxCell
    Friend WithEvents LabelCell2 As GrapeCity.Win.MultiRow.LabelCell
    Friend WithEvents so部門CD As GrapeCity.Win.MultiRow.ColumnHeaderCell
    Friend WithEvents so部門名 As GrapeCity.Win.MultiRow.ColumnHeaderCell
    Friend WithEvents ColumnFooterSection1 As GrapeCity.Win.MultiRow.ColumnFooterSection
    



End Class
