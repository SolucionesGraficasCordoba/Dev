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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
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
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.SystemColors.Control
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
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(24, 41)
        Me.Chart1.Name = "Chart1"
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
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(1335, 222)
        Me.Chart1.TabIndex = 134
        Me.Chart1.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        Me.Chart1.Titles.Add(Title1)
        '
        'frm_Grafico_Totales_Mensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1686, 280)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "frm_Grafico_Totales_Mensuales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grafico Totales Mensuales"
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
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
