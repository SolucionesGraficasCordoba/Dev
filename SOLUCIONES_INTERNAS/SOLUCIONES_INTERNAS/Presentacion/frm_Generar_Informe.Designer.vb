<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Generar_Informe
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupListadoTareas = New System.Windows.Forms.GroupBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbo_sector = New System.Windows.Forms.ComboBox()
        Me.dgvColaboradores = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenerar_Informe = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvTotalesMensuales = New System.Windows.Forms.DataGridView()
        Me.Chart11 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupListadoTareas.SuspendLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTotalesMensuales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(474, 659)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(108, 60)
        Me.btnSalir.TabIndex = 39
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupListadoTareas
        '
        Me.GroupListadoTareas.Controls.Add(Me.cboMes)
        Me.GroupListadoTareas.Controls.Add(Me.Label31)
        Me.GroupListadoTareas.Controls.Add(Me.cbo_sector)
        Me.GroupListadoTareas.Controls.Add(Me.dgvColaboradores)
        Me.GroupListadoTareas.Controls.Add(Me.Label4)
        Me.GroupListadoTareas.Location = New System.Drawing.Point(26, 12)
        Me.GroupListadoTareas.Name = "GroupListadoTareas"
        Me.GroupListadoTareas.Size = New System.Drawing.Size(641, 294)
        Me.GroupListadoTareas.TabIndex = 36
        Me.GroupListadoTareas.TabStop = False
        Me.GroupListadoTareas.Text = "Tiempos totales por día"
        '
        'cboMes
        '
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(216, 24)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(150, 21)
        Me.cboMes.TabIndex = 48
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(183, 27)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(27, 13)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Mes"
        '
        'cbo_sector
        '
        Me.cbo_sector.FormattingEnabled = True
        Me.cbo_sector.Location = New System.Drawing.Point(469, 24)
        Me.cbo_sector.Name = "cbo_sector"
        Me.cbo_sector.Size = New System.Drawing.Size(150, 21)
        Me.cbo_sector.TabIndex = 30
        '
        'dgvColaboradores
        '
        Me.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColaboradores.Location = New System.Drawing.Point(22, 70)
        Me.dgvColaboradores.Name = "dgvColaboradores"
        Me.dgvColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvColaboradores.Size = New System.Drawing.Size(597, 198)
        Me.dgvColaboradores.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sector"
        '
        'btnGenerar_Informe
        '
        Me.btnGenerar_Informe.Location = New System.Drawing.Point(137, 568)
        Me.btnGenerar_Informe.Name = "btnGenerar_Informe"
        Me.btnGenerar_Informe.Size = New System.Drawing.Size(108, 23)
        Me.btnGenerar_Informe.TabIndex = 35
        Me.btnGenerar_Informe.Text = "Generar Informe"
        Me.btnGenerar_Informe.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvTotalesMensuales)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 247)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tiempos totales por mes"
        '
        'dgvTotalesMensuales
        '
        Me.dgvTotalesMensuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotalesMensuales.Location = New System.Drawing.Point(22, 28)
        Me.dgvTotalesMensuales.Name = "dgvTotalesMensuales"
        Me.dgvTotalesMensuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTotalesMensuales.Size = New System.Drawing.Size(597, 198)
        Me.dgvTotalesMensuales.TabIndex = 0
        '
        'Chart11
        '
        ChartArea1.Name = "ChartArea1"
        ChartArea1.Visible = False
        Me.Chart11.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.Position.Auto = False
        Legend1.Position.Height = 43.39622!
        Legend1.Position.Width = 43.39622!
        Legend1.Position.X = 30.0!
        Legend1.Position.Y = 30.0!
        Me.Chart11.Legends.Add(Legend1)
        Me.Chart11.Location = New System.Drawing.Point(137, 597)
        Me.Chart11.Name = "Chart11"
        Series1.BorderColor = System.Drawing.Color.LightCoral
        Series1.ChartArea = "ChartArea1"
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.LegendText = "Tiempo Estimado"
        Series1.Name = "Series1"
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.LegendText = "Tiempo Real"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.LegendText = "Tiempo Asignado"
        Series3.Name = "Series3"
        Me.Chart11.Series.Add(Series1)
        Me.Chart11.Series.Add(Series2)
        Me.Chart11.Series.Add(Series3)
        Me.Chart11.Size = New System.Drawing.Size(315, 122)
        Me.Chart11.TabIndex = 91
        Me.Chart11.Text = "Chart11"
        Title1.Name = "Title1"
        Me.Chart11.Titles.Add(Title1)
        '
        'frm_Generar_Informe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(694, 743)
        Me.Controls.Add(Me.Chart11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupListadoTareas)
        Me.Controls.Add(Me.btnGenerar_Informe)
        Me.Name = "frm_Generar_Informe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Informe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupListadoTareas.ResumeLayout(False)
        Me.GroupListadoTareas.PerformLayout()
        CType(Me.dgvColaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvTotalesMensuales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupListadoTareas As System.Windows.Forms.GroupBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cbo_sector As System.Windows.Forms.ComboBox
    Friend WithEvents dgvColaboradores As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar_Informe As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTotalesMensuales As System.Windows.Forms.DataGridView
    Friend WithEvents Chart11 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
