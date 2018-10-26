<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Graficos
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart11 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart3
        '
        Me.Chart3.BackColor = System.Drawing.SystemColors.ControlLight
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = 90
        ChartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea1.AxisX2.IsLabelAutoFit = False
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY2.IsLabelAutoFit = False
        ChartArea1.Name = "ChartArea1"
        ChartArea1.Position.Auto = False
        ChartArea1.Position.Height = 90.0!
        ChartArea1.Position.Width = 95.0!
        ChartArea1.Position.Y = 5.0!
        Me.Chart3.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend1)
        Me.Chart3.Location = New System.Drawing.Point(12, 468)
        Me.Chart3.Name = "Chart3"
        Series1.ChartArea = "ChartArea1"
        Series1.IsValueShownAsLabel = True
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.LegendText = "Tiempo Estimado"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.IsValueShownAsLabel = True
        Series2.IsVisibleInLegend = False
        Series2.Legend = "Legend1"
        Series2.LegendText = "Tiempo Real"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.IsValueShownAsLabel = True
        Series3.IsVisibleInLegend = False
        Series3.Legend = "Legend1"
        Series3.LegendText = "Tiempo Asignado"
        Series3.Name = "Series3"
        Me.Chart3.Series.Add(Series1)
        Me.Chart3.Series.Add(Series2)
        Me.Chart3.Series.Add(Series3)
        Me.Chart3.Size = New System.Drawing.Size(1335, 222)
        Me.Chart3.TabIndex = 98
        Me.Chart3.Text = "Chart3"
        Title1.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart3.Titles.Add(Title1)
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Chart2.BorderlineColor = System.Drawing.SystemColors.Control
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = 90
        ChartArea2.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea2.AxisX2.IsLabelAutoFit = False
        ChartArea2.AxisY.IsLabelAutoFit = False
        ChartArea2.AxisY2.IsLabelAutoFit = False
        ChartArea2.Name = "ChartArea1"
        ChartArea2.Position.Auto = False
        ChartArea2.Position.Height = 90.0!
        ChartArea2.Position.Width = 95.0!
        ChartArea2.Position.Y = 5.0!
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(12, 240)
        Me.Chart2.Name = "Chart2"
        Series4.ChartArea = "ChartArea1"
        Series4.IsValueShownAsLabel = True
        Series4.IsVisibleInLegend = False
        Series4.Legend = "Legend1"
        Series4.LegendText = "Tiempo Estimado"
        Series4.Name = "Series1"
        Series5.ChartArea = "ChartArea1"
        Series5.IsValueShownAsLabel = True
        Series5.IsVisibleInLegend = False
        Series5.Legend = "Legend1"
        Series5.LegendText = "Tiempo Real"
        Series5.Name = "Series2"
        Series6.ChartArea = "ChartArea1"
        Series6.IsValueShownAsLabel = True
        Series6.IsVisibleInLegend = False
        Series6.Legend = "Legend1"
        Series6.LegendText = "Tiempo Asignado"
        Series6.Name = "Series3"
        Me.Chart2.Series.Add(Series4)
        Me.Chart2.Series.Add(Series5)
        Me.Chart2.Series.Add(Series6)
        Me.Chart2.Size = New System.Drawing.Size(1335, 222)
        Me.Chart2.TabIndex = 97
        Me.Chart2.Text = "Chart2"
        Title2.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart2.Titles.Add(Title2)
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Chart1.BorderlineColor = System.Drawing.SystemColors.Control
        ChartArea3.AxisX.Interval = 1.0R
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.LabelStyle.Angle = 90
        ChartArea3.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea3.AxisX2.IsLabelAutoFit = False
        ChartArea3.AxisY.IsLabelAutoFit = False
        ChartArea3.AxisY2.IsLabelAutoFit = False
        ChartArea3.Name = "ChartArea1"
        ChartArea3.Position.Auto = False
        ChartArea3.Position.Height = 90.0!
        ChartArea3.Position.Width = 95.0!
        ChartArea3.Position.Y = 5.0!
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series7.ChartArea = "ChartArea1"
        Series7.IsValueShownAsLabel = True
        Series7.IsVisibleInLegend = False
        Series7.Legend = "Legend1"
        Series7.LegendText = "Tiempo Estimado"
        Series7.Name = "Series1"
        Series8.ChartArea = "ChartArea1"
        Series8.IsValueShownAsLabel = True
        Series8.IsVisibleInLegend = False
        Series8.Legend = "Legend1"
        Series8.LegendText = "Tiempo Real"
        Series8.Name = "Series2"
        Series9.ChartArea = "ChartArea1"
        Series9.IsValueShownAsLabel = True
        Series9.IsVisibleInLegend = False
        Series9.Legend = "Legend1"
        Series9.LegendText = "Tiempo Asignado"
        Series9.Name = "Series3"
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Series.Add(Series9)
        Me.Chart1.Size = New System.Drawing.Size(1335, 222)
        Me.Chart1.TabIndex = 96
        Me.Chart1.Text = "Chart1"
        Title3.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart1.Titles.Add(Title3)
        '
        'Chart11
        '
        ChartArea4.Name = "ChartArea1"
        ChartArea4.Visible = False
        Me.Chart11.ChartAreas.Add(ChartArea4)
        Legend4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend4.IsTextAutoFit = False
        Legend4.Name = "Legend1"
        Legend4.Position.Auto = False
        Legend4.Position.Height = 43.39622!
        Legend4.Position.Width = 43.39622!
        Legend4.Position.X = 30.0!
        Legend4.Position.Y = 30.0!
        Me.Chart11.Legends.Add(Legend4)
        Me.Chart11.Location = New System.Drawing.Point(515, 696)
        Me.Chart11.Name = "Chart11"
        Series10.BorderColor = System.Drawing.Color.LightCoral
        Series10.ChartArea = "ChartArea1"
        Series10.IsValueShownAsLabel = True
        Series10.Legend = "Legend1"
        Series10.LegendText = "Tiempo Estimado"
        Series10.Name = "Series1"
        Series10.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64
        Series11.ChartArea = "ChartArea1"
        Series11.Legend = "Legend1"
        Series11.LegendText = "Tiempo Real"
        Series11.Name = "Series2"
        Series12.ChartArea = "ChartArea1"
        Series12.Legend = "Legend1"
        Series12.LegendText = "Tiempo Asignado"
        Series12.Name = "Series3"
        Me.Chart11.Series.Add(Series10)
        Me.Chart11.Series.Add(Series11)
        Me.Chart11.Series.Add(Series12)
        Me.Chart11.Size = New System.Drawing.Size(50, 30)
        Me.Chart11.TabIndex = 101
        Me.Chart11.Text = "Chart11"
        Title4.Name = "Title1"
        Me.Chart11.Titles.Add(Title4)
        Me.Chart11.Visible = False
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(895, 699)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 27)
        Me.btnAnterior.TabIndex = 102
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(988, 699)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 27)
        Me.btnSiguiente.TabIndex = 102
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Location = New System.Drawing.Point(1080, 699)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(97, 27)
        Me.btnExportarPDF.TabIndex = 103
        Me.btnExportarPDF.Text = "Exportar a PDF"
        Me.btnExportarPDF.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(1193, 699)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 27)
        Me.btnCancelar.TabIndex = 104
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 706)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 706)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 706)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Mes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 706)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Sector:"
        '
        'Frm_Graficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1359, 738)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.Chart11)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Frm_Graficos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gráficos Tareas"
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart11 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnExportarPDF As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
