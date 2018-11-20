<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Grafico_Totales_Mensuales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series16 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series17 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series18 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(1284, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 145
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Location = New System.Drawing.Point(1163, 12)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(115, 23)
        Me.btnExportarPDF.TabIndex = 144
        Me.btnExportarPDF.Text = "Exportar a PDF"
        Me.btnExportarPDF.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(972, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 16)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Tiempo Asignado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(732, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Tiempo Estimado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(868, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 16)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "Tiempo Real"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(269, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Sector:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Mes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(351, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Label1"
        '
        'Chart3
        '
        ChartArea4.AxisX.Interval = 1.0R
        ChartArea4.AxisX.IsLabelAutoFit = False
        ChartArea4.AxisX.LabelStyle.Angle = 90
        ChartArea4.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea4.AxisX2.IsLabelAutoFit = False
        ChartArea4.AxisY.IsLabelAutoFit = False
        ChartArea4.AxisY2.IsLabelAutoFit = False
        ChartArea4.Name = "ChartArea1"
        ChartArea4.Position.Auto = False
        ChartArea4.Position.Height = 90.0!
        ChartArea4.Position.Width = 95.0!
        ChartArea4.Position.Y = 5.0!
        Me.Chart3.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend4)
        Me.Chart3.Location = New System.Drawing.Point(22, 506)
        Me.Chart3.Name = "Chart3"
        Series10.ChartArea = "ChartArea1"
        Series10.IsValueShownAsLabel = True
        Series10.IsVisibleInLegend = False
        Series10.Legend = "Legend1"
        Series10.LegendText = "Tiempo Estimado"
        Series10.Name = "Series1"
        Series11.ChartArea = "ChartArea1"
        Series11.IsValueShownAsLabel = True
        Series11.IsVisibleInLegend = False
        Series11.Legend = "Legend1"
        Series11.LegendText = "Tiempo Real"
        Series11.Name = "Series2"
        Series12.ChartArea = "ChartArea1"
        Series12.IsValueShownAsLabel = True
        Series12.IsVisibleInLegend = False
        Series12.Legend = "Legend1"
        Series12.LegendText = "Tiempo Asignado"
        Series12.Name = "Series3"
        Me.Chart3.Series.Add(Series10)
        Me.Chart3.Series.Add(Series11)
        Me.Chart3.Series.Add(Series12)
        Me.Chart3.Size = New System.Drawing.Size(1337, 222)
        Me.Chart3.TabIndex = 136
        Me.Chart3.Text = "Chart3"
        Title4.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart3.Titles.Add(Title4)
        '
        'Chart2
        '
        Me.Chart2.BorderlineColor = System.Drawing.SystemColors.Control
        ChartArea5.AxisX.Interval = 1.0R
        ChartArea5.AxisX.IsLabelAutoFit = False
        ChartArea5.AxisX.LabelStyle.Angle = 90
        ChartArea5.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea5.AxisX2.IsLabelAutoFit = False
        ChartArea5.AxisY.IsLabelAutoFit = False
        ChartArea5.AxisY2.IsLabelAutoFit = False
        ChartArea5.Name = "ChartArea1"
        ChartArea5.Position.Auto = False
        ChartArea5.Position.Height = 90.0!
        ChartArea5.Position.Width = 95.0!
        ChartArea5.Position.Y = 5.0!
        Me.Chart2.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend5)
        Me.Chart2.Location = New System.Drawing.Point(24, 269)
        Me.Chart2.Name = "Chart2"
        Series13.ChartArea = "ChartArea1"
        Series13.IsValueShownAsLabel = True
        Series13.IsVisibleInLegend = False
        Series13.Legend = "Legend1"
        Series13.LegendText = "Tiempo Estimado"
        Series13.Name = "Series1"
        Series14.ChartArea = "ChartArea1"
        Series14.IsValueShownAsLabel = True
        Series14.IsVisibleInLegend = False
        Series14.Legend = "Legend1"
        Series14.LegendText = "Tiempo Real"
        Series14.Name = "Series2"
        Series15.ChartArea = "ChartArea1"
        Series15.IsValueShownAsLabel = True
        Series15.IsVisibleInLegend = False
        Series15.Legend = "Legend1"
        Series15.LegendText = "Tiempo Asignado"
        Series15.Name = "Series3"
        Me.Chart2.Series.Add(Series13)
        Me.Chart2.Series.Add(Series14)
        Me.Chart2.Series.Add(Series15)
        Me.Chart2.Size = New System.Drawing.Size(1335, 222)
        Me.Chart2.TabIndex = 135
        Me.Chart2.Text = "Chart2"
        Title5.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title5.Name = "Title1"
        Title5.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart2.Titles.Add(Title5)
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.SystemColors.Control
        ChartArea6.AxisX.Interval = 1.0R
        ChartArea6.AxisX.IsLabelAutoFit = False
        ChartArea6.AxisX.LabelStyle.Angle = 90
        ChartArea6.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea6.AxisX2.IsLabelAutoFit = False
        ChartArea6.AxisY.IsLabelAutoFit = False
        ChartArea6.AxisY2.IsLabelAutoFit = False
        ChartArea6.Name = "ChartArea1"
        ChartArea6.Position.Auto = False
        ChartArea6.Position.Height = 90.0!
        ChartArea6.Position.Width = 95.0!
        ChartArea6.Position.Y = 5.0!
        Me.Chart1.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend6)
        Me.Chart1.Location = New System.Drawing.Point(24, 41)
        Me.Chart1.Name = "Chart1"
        Series16.ChartArea = "ChartArea1"
        Series16.IsValueShownAsLabel = True
        Series16.IsVisibleInLegend = False
        Series16.Legend = "Legend1"
        Series16.LegendText = "Tiempo Estimado"
        Series16.Name = "Series1"
        Series17.ChartArea = "ChartArea1"
        Series17.IsValueShownAsLabel = True
        Series17.IsVisibleInLegend = False
        Series17.Legend = "Legend1"
        Series17.LegendText = "Tiempo Real"
        Series17.Name = "Series2"
        Series18.ChartArea = "ChartArea1"
        Series18.IsValueShownAsLabel = True
        Series18.IsVisibleInLegend = False
        Series18.Legend = "Legend1"
        Series18.LegendText = "Tiempo Asignado"
        Series18.Name = "Series3"
        Me.Chart1.Series.Add(Series16)
        Me.Chart1.Series.Add(Series17)
        Me.Chart1.Series.Add(Series18)
        Me.Chart1.Size = New System.Drawing.Size(1335, 222)
        Me.Chart1.TabIndex = 134
        Me.Chart1.Text = "Chart1"
        Title6.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title6.Name = "Title1"
        Title6.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart1.Titles.Add(Title6)
        '
        'frm_Grafico_Totales_Mensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1630, 925)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "frm_Grafico_Totales_Mensuales"
        Me.Text = "frm_Grafico_Totales_Mensuales"
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnExportarPDF As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
