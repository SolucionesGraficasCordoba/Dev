Public Class Form1
    'Dim dataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataS_Interno_Vistas
    Dim vble_esp As String

    Private Sub Chart1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    'Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    '    Dim combo = From M In datacontextvistas.Tiempos_Totales Select M.COL_id_colaborador, M.COL_nombre_col
    '    Me.cboCurso.DataSource = combo
    '    Me.cboCurso.DisplayMember = "COL_nombre_col"
    '    Me.cboCurso.ValueMember = "COL_id_colaborador"
    '    Me.cboCurso.SelectedIndex = -1
    'End Sub

    'CARGA MATERIAS SEGUN CURSO
    'Private Sub cargarmaterias(ByVal curso As String)
    '    Try
    '        Dim esp = (From e In datacontextvistas.Alumno_x_curso Select e.id_curso, e.Curso.nombre_curso, e.especialidad Where nombre_curso = CStr(curso)).ToList()(0)
    '        vble_esp = esp.especialidad
    '        TextBox1.Text = esp.especialidad
    '        Dim mat = (From m In datacontextvistas.Materia Select m.id_materia, m.nombre_materia, m.especialidad_textbox Where especialidad_textbox = vble_esp).ToList
    '        CboMateria.DataSource = mat
    '        CboMateria.DisplayMember = "nombre_materia"
    '        CboMateria.ValueMember = "id_materia"
    '        CboMateria.SelectedIndex = -1
    '    Catch ex As Exception
    '        MsgBox("El curso no tiene alumnos")
    '    End Try

    'End Sub

    Private Sub cmdCargar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCargar.Click
        Select Case cbotipo.SelectedIndex
            Case 0
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Pie)
            Case 1
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Column)
            Case 2
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Point)
            Case 3
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Bar)
            Case 4
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Polar)
            Case 5
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Range)
            Case Else
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Pyramid)

        End Select
    End Sub

    'BOTON CARGAR
    Sub TipoGrafico(ByVal grafico As DataVisualization.Charting.SeriesChartType)

        'Dim sql = From s In datacontextvistas.Vista_calif_x_curso_x_mat Select s.nombre_curso, s.Redondeo, s.Total, s.nombre_materia Where nombre_curso = CStr(cboCurso.Text) And nombre_materia = CStr(CboMateria.Text)
        'Chart1.Series(0).Points.Clear()
        'Chart1.Series(0).IsValueShownAsLabel = True
        'Chart1.Series(0).ChartType = grafico
        'Chart1.Series(0)("PieLabelStyle") = "Inside"
        'Chart1.Series(0)("PieDrawingStyle") = "Concave"
        'Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
        'Chart1.Series(0).Color = Color.RoyalBlue
        'Chart1.Series(0).XValueMember = "redondeo"
        'Chart1.Series(0).YValueMembers = "total"
        'Chart1.Series(0)("DrawingStyle") = "Wedge"
        'Chart1.Series(0)("PointWidth") = "0.6"
        'Chart1.BorderSkin.SkinStyle = DataVisualization.Charting.BorderSkinStyle.Emboss
        'Chart1.Series(0).IsValueShownAsLabel = True
        ''Chart1.Series(0).LabelFormat = "P0"
        'Chart1.Series(0)("LabelStyle") = "Bottom"
        'Chart1.Series(0).Font = New Font("Times New Roman", 7)
        'Chart1.BackColor = Color.White
        'Chart1.BackSecondaryColor = Color.SkyBlue
        'Chart1.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom

        'Chart1.ChartAreas(0).BackColor = Color.White
        'Chart1.ChartAreas(0).BackSecondaryColor = Color.SkyBlue
        'Chart1.ChartAreas(0).BackGradientStyle = DataVisualization.Charting.GradientStyle.DiagonalLeft
        'Chart1.ChartAreas(0).ShadowOffset = 3

        'Chart1.ChartAreas(0).AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
        'Chart1.ChartAreas(0).AxisX.MinorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet

        'Chart1.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
        'Chart1.ChartAreas(0).AxisY.MinorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet

        'Chart1.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Arial", 8)
        'Chart1.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Arial", 8)
        'Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "P0"
        'Chart1.DataSource = sql
    End Sub

    Private Sub Btn_salir_est_califxcurso_Click(sender As System.Object, e As System.EventArgs) Handles Btn_salir_est_califxcurso.Click
        Me.Close()
    End Sub

    Private Sub btnbuscarmat_Click(sender As System.Object, e As System.EventArgs)
        '  cargarmaterias(cboCurso.Text)
    End Sub
End Class