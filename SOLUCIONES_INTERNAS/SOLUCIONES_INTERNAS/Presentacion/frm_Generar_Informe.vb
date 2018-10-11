Imports System.Text
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_Generar_Informe
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Private Sub frm_Generar_Informe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARGA COMBOBOX SECTOR
        Dim combosector = (From sec In datacontext.SECTOR
                           Select sec.SEC_id_sector, sec.SEC_nombre_sector)
        cbo_sector.DataSource = combosector
        cbo_sector.DisplayMember = "SEC_nombre_sector"
        cbo_sector.ValueMember = "SEC_id_sector"
        cbo_sector.SelectedIndex = -1
        btnGenerar_Informe.Visible = False
    End Sub

    'ARMA LA GRILLA DEL COLABORADOR
    Private Sub armargrillacolaborador()
        dgvColaboradores.Enabled = True
        dgvColaboradores.AutoGenerateColumns = False
        dgvColaboradores.Columns.Clear()
        ' dgvColaboradores.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvColaboradores.Columns.Add("Total_estimado", "Total estimado")
        dgvColaboradores.Columns.Add("Total_real", "Total real")
        dgvColaboradores.Columns.Add("Asignacion", "Asignación")
        dgvColaboradores.Columns.Add("TAR_fecha", "Fecha")
        dgvColaboradores.Columns.Add("COL_nombre_col", "Colaborador")

        ' dgvColaboradores.Columns.Add("SEC_id_sector", "id_sector")
        ' dgvColaboradores.Columns.Add("SEC_nombre_sector", "Sector")
        ' dgvColaboradores.Columns(0).DataPropertyName = "COL_id_colaborador"
        ' dgvColaboradores.Columns(0).Visible = False
        dgvColaboradores.Columns(0).DataPropertyName = "Total_estimado"
        dgvColaboradores.Columns(1).DataPropertyName = "Total_real"
        dgvColaboradores.Columns(2).DataPropertyName = "Asignacion"
        dgvColaboradores.Columns(3).DataPropertyName = "TAR_fecha"
        dgvColaboradores.Columns(4).DataPropertyName = "COL_nombre_col"
        ' dgvColaboradores.Columns(4).DataPropertyName = "SEC_id_sector"
        '  dgvColaboradores.Columns(4).Visible = False
        '  dgvColaboradores.Columns(5).DataPropertyName = "SEC_nombre_sector"
    End Sub

    Private Sub cbo_sector_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_sector.SelectedIndexChanged
        Filtrar_Mes_Sector()
        Totales_Mensuales()
        TipoGrafico()
    End Sub

    Private Sub Filtrar_Mes_Sector()
        armargrillacolaborador()
        Dim consultaporsector = (From A In datavistas.Tiempos_Totales
                                Select A.COL_id_colaborador,
                                A.COL_nombre_col,
                                A.TAR_fecha,
                               A.Total_estimado,
                                A.Total_real,
                                A.SEC_id_sector,
                                A.SEC_nombre_sector,
                                A.Asignacion
        Where (SEC_id_sector = cbo_sector.SelectedIndex + 1 And TAR_fecha.Value.Month = cboMes.SelectedIndex + 1))
        dgvColaboradores.DataSource = consultaporsector
    End Sub

    'ARMA LA GRILLA MENSUAL
    Private Sub armargrillamensual()
        dgvTotalesMensuales.Enabled = True
        dgvTotalesMensuales.AutoGenerateColumns = False
        dgvTotalesMensuales.Columns.Clear()

        dgvTotalesMensuales.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvTotalesMensuales.Columns.Add("COL_nombre_col", "Colaborador")
        dgvTotalesMensuales.Columns.Add("Mes", "Mes")
        dgvTotalesMensuales.Columns.Add("SEC_id_sector", "id_sector")
        dgvTotalesMensuales.Columns.Add("SEC_nombre_sector", "Sector")
        dgvTotalesMensuales.Columns.Add("Total_estimado_mensual", "Total estimado")
        dgvTotalesMensuales.Columns.Add("Total_real_mensual", "Total real")
        dgvTotalesMensuales.Columns.Add("Asignacion", "Asignacion")

        dgvTotalesMensuales.Columns(0).DataPropertyName = "COL_id_colaborador"
        dgvTotalesMensuales.Columns(0).Visible = False
        dgvTotalesMensuales.Columns(1).DataPropertyName = "COL_nombre_col"
        dgvTotalesMensuales.Columns(2).DataPropertyName = "Mes"
        dgvTotalesMensuales.Columns(3).DataPropertyName = "SEC_id_sector"
        dgvTotalesMensuales.Columns(3).Visible = False
        dgvTotalesMensuales.Columns(4).DataPropertyName = "SEC_nombre_sector"
        dgvTotalesMensuales.Columns(5).DataPropertyName = "Total_estimado_mensual"
        dgvTotalesMensuales.Columns(6).DataPropertyName = "Total_real_mensual"
        dgvTotalesMensuales.Columns(7).DataPropertyName = "Asignacion"

    End Sub

    Private Sub Totales_Mensuales()
        armargrillamensual()
        Dim totales_mensuales = (From t In datavistas.Totales_mensuales
                                Select t.COL_id_colaborador,
                                t.COL_nombre_col,
                                t.Mes,
                                t.SEC_id_sector,
                                t.SEC_nombre_sector,
                                t.Total_estimado_mensual,
                                t.Total_real_mensual,
                                t.Asignacion
          Where (SEC_id_sector = cbo_sector.SelectedIndex + 1 And Mes = cboMes.SelectedIndex + 1))
        dgvTotalesMensuales.DataSource = totales_mensuales
        dgvTotalesMensuales.ClearSelection()
    End Sub

    Private Sub cboMes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMes.SelectedIndexChanged
        Filtrar_Mes_Sector()
        Totales_Mensuales()
        TipoGrafico()
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar_Informe.Click

        Dim consulta As String = "consulta_total_x_dia_" + Date.Now.Millisecond.ToString + ".csv"
        Dim consulta1 As String = "consulta_total_mensual_" + Date.Now.Millisecond.ToString + ".csv"
        Dim filePath As String = "\\wsmaldig3\PlanetPress\INTERNO\IN\" + consulta
        Dim filePath1 As String = "\\wsmaldig3\PlanetPress\INTERNO\IN\" + consulta1
        Dim delimeter As String = ","
        Dim sb As New StringBuilder
        Dim sb1 As New StringBuilder
        Try
            For i As Integer = 0 To dgvColaboradores.Rows.Count - 1
                Dim array As String() = New String(dgvColaboradores.Columns.Count - 1) {}
                If i.Equals(0) Then
                    For j As Integer = 0 To dgvColaboradores.Columns.Count - 1
                        array(j) = dgvColaboradores.Columns(j).HeaderText
                    Next
                    sb.AppendLine(String.Join(delimeter, array))
                End If
                For j As Integer = 0 To dgvColaboradores.Columns.Count - 1

                    If Not dgvColaboradores.Rows(i).IsNewRow Then

                        If dgvColaboradores.Columns(j).HeaderText = "Fecha" Or dgvColaboradores.Columns(j).HeaderText = "Colaborador" Then
                            array(j) = dgvColaboradores(j, i).Value.ToString
                        Else
                            array(j) = Microsoft.VisualBasic.Right("   " + dgvColaboradores(j, i).Value.ToString, 3)
                        End If
                    End If
                Next
                If Not dgvColaboradores.Rows(i).IsNewRow Then
                    sb.AppendLine(String.Join(delimeter, array))
                End If
            Next
            For i As Integer = 0 To dgvTotalesMensuales.Rows.Count - 1
                Dim array1 As String() = New String(dgvTotalesMensuales.Columns.Count - 1) {}
                If i.Equals(0) Then
                    For j As Integer = 0 To dgvTotalesMensuales.Columns.Count - 1
                        array1(j) = dgvTotalesMensuales.Columns(j).HeaderText
                    Next
                    sb1.AppendLine(String.Join(delimeter, array1))
                End If
                For j As Integer = 0 To dgvTotalesMensuales.Columns.Count - 1
                    If Not dgvTotalesMensuales.Rows(i).IsNewRow Then
                        array1(j) = dgvTotalesMensuales(j, i).Value.ToString
                    End If
                Next
                If Not dgvTotalesMensuales.Rows(i).IsNewRow Then
                    sb1.AppendLine(String.Join(delimeter, array1))
                End If
            Next
            File.WriteAllText(filePath, sb.ToString)
            File.WriteAllText(filePath1, sb1.ToString)
            ' File.AppendAllText(filePath, sb1.ToString)
            MsgBox("La consulta se ha generado correctamente")
            ' Process.Start(filePath)
            Me.Close()
        Catch ex As Exception
            MsgBox("Hubo un error al generar la consulta")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnGenerarGrafico_Click(sender As System.Object, e As System.EventArgs)
        'Select Case cbotipo.SelectedIndex
        '    Case 0
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Pie)
        '    Case 1
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Column)
        '    Case 2
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Point)
        '    Case 3
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Bar)
        '    Case 4
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Polar)
        '    Case 5
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Range)
        '    Case Else
        '        TipoGrafico(DataVisualization.Charting.SeriesChartType.Pyramid)

        'End Select
    End Sub

    'BOTON CARGAR
    Sub TipoGrafico()
        Dim totalgrafico As Integer
        totalgrafico = dgvTotalesMensuales.Rows.Count

        '************************inicio grafico 1
        'If 1 <= totalgrafico Then

        '    Chart1.Series(0).Points.Clear()
        '    Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
        '    Chart1.Series(0).YValueMembers = "Total_estimado"
        '    Chart1.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
        '    Chart1.Series(1).YValueMembers = "Total_real"
        '    Chart1.Series(2).YValueMembers = "Asignacion"
        '    Chart1.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(0).Cells(1).Value)
        '    Chart1.Series(0).XValueMember = "CADENA"
        '    Chart1.Series(1).XValueMember = "CADENA"
        '    Chart1.Series(2).XValueMember = "CADENA"
        '    Chart1.DataSource = llenargrafico(0)
        'Else
        '    Chart1.DataSource = Nothing
        'End If
        '***************************fin grafico 1*********************************

        ''************************inicio grafico 2*********************************
        'If 2 <= totalgrafico Then
        '    Chart2.Series(0).Points.Clear()
        '    Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        '    Chart2.Series(0).YValueMembers = "Total_estimado"
        '    Chart2.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
        '    Chart2.Series(1).YValueMembers = "Total_real"
        '    Chart2.Series(2).YValueMembers = "Asignacion"
        '    Chart2.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(1).Cells(1).Value)
        '    Chart2.Series(0).XValueMember = "CADENA"
        '    Chart2.Series(1).XValueMember = "CADENA"
        '    Chart2.Series(2).XValueMember = "CADENA"
        '    Chart2.DataSource = llenargrafico(1)
        'Else
        '    Chart2.DataSource = Nothing
        'End If
        ''***************************fin grafico 2*********************************

        ''************************inicio grafico 3*********************************
        'If 3 <= totalgrafico Then
        '    Chart3.Series(0).Points.Clear()
        '    Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
        '    Chart3.Series(0).YValueMembers = "Total_estimado"
        '    Chart3.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
        '    Chart3.Series(1).YValueMembers = "Total_real"
        '    Chart3.Series(2).YValueMembers = "Asignacion"
        '    Chart3.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(2).Cells(1).Value)
        '    Chart3.Series(0).XValueMember = "CADENA"
        '    Chart3.Series(1).XValueMember = "CADENA"
        '    Chart3.Series(2).XValueMember = "CADENA"
        '    Chart3.DataSource = llenargrafico(2)
        'Else
        '    Chart3.DataSource = Nothing
        'End If
        ''***************************fin grafico 3*********************************

        ''************************inicio grafico 4*********************************
        'If 4 <= totalgrafico Then
        '    Chart4.Series(0).Points.Clear()
        '    Chart4.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
        '    Chart4.Series(0).YValueMembers = "Total_estimado"
        '    Chart4.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
        '    Chart4.Series(1).YValueMembers = "Total_real"
        '    Chart4.Series(2).YValueMembers = "Asignacion"
        '    Chart4.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(3).Cells(1).Value)
        '    Chart4.Series(0).XValueMember = "CADENA"
        '    Chart4.Series(1).XValueMember = "CADENA"
        '    Chart4.Series(2).XValueMember = "CADENA"
        '    Chart4.DataSource = llenargrafico(3)
        'End If
        ''***************************fin grafico 4*********************************

        ''************************inicio grafico 5*********************************
        'If 5 <= totalgrafico Then
        '    Chart5.Series(0).Points.Clear()
        '    Chart5.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
        '    Chart5.Series(0).YValueMembers = "Total_estimado"
        '    Chart5.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
        '    Chart5.Series(1).YValueMembers = "Total_real"
        '    Chart5.Series(2).YValueMembers = "Asignacion"
        '    Chart5.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(4).Cells(1).Value)
        '    Chart5.Series(0).XValueMember = "CADENA"
        '    Chart5.Series(1).XValueMember = "CADENA"
        '    Chart5.Series(2).XValueMember = "CADENA"
        '    Chart5.DataSource = llenargrafico(4)
        'End If
        ''***************************fin grafico 5*********************************

        ''************************inicio grafico 6*********************************
        'If 5 <= totalgrafico Or 5 <= totalcolaborador Then
        '    Chart6.Series(0).Points.Clear()
        '    Chart6.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
        '    Chart6.Series(0).Color = Color.Blue
        '    Chart6.Series(0).YValueMembers = "Total_estimado"
        '    Chart6.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
        '    Chart6.Series(1).Color = Color.Red
        '    Chart6.Series(1).YValueMembers = "Total_real"
        '    Chart6.Series(1).IsValueShownAsLabel = True
        '    Chart6.Series(2).Color = Color.Yellow
        '    Chart6.Series(2).YValueMembers = "Asignacion"
        '    Chart6.Series(2).IsValueShownAsLabel = True
        '    Chart6.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(5).Cells(1).Value)
        '    Chart6.DataSource = llenargrafico(5)
        'End If
        ''***************************fin grafico 6*********************************

        ''***************************fin grafico 7*********************************
        'If 6 <= totalgrafico Or 6 <= totalcolaborador Then
        '    Chart7.Series(0).Points.Clear()
        '    Chart7.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
        '    Chart7.Series(0).Color = Color.Blue
        '    Chart7.Series(0).YValueMembers = "Total_estimado"
        '    Chart7.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
        '    Chart7.Series(1).Color = Color.Red
        '    Chart7.Series(1).YValueMembers = "Total_real"
        '    Chart7.Series(1).IsValueShownAsLabel = True
        '    Chart7.Series(2).Color = Color.Yellow
        '    Chart7.Series(2).YValueMembers = "Asignacion"
        '    Chart7.Series(2).IsValueShownAsLabel = True
        '    Chart7.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(6).Cells(1).Value)
        '    Chart7.DataSource = llenargrafico(6)
        'End If
        ''***************************fin grafico 7*********************************

        ''***************************fin grafico 8*********************************
        'If 7 <= totalgrafico Or 7 <= totalcolaborador Then
        '    Chart8.Series(0).Points.Clear()
        '    Chart8.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
        '    Chart8.Series(0).Color = Color.Blue
        '    Chart8.Series(0).YValueMembers = "Total_estimado"
        '    Chart8.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
        '    Chart8.Series(1).Color = Color.Red
        '    Chart8.Series(1).YValueMembers = "Total_real"
        '    Chart8.Series(1).IsValueShownAsLabel = True
        '    Chart8.Series(2).Color = Color.Yellow
        '    Chart8.Series(2).YValueMembers = "Asignacion"
        '    Chart8.Series(2).IsValueShownAsLabel = True
        '    Chart8.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(7).Cells(1).Value)
        '    Chart8.DataSource = llenargrafico(7)
        'End If
        ''***************************fin grafico 8*********************************

        ''***************************fin grafico 9*********************************
        'If 8 <= totalgrafico Or 8 <= totalcolaborador Then
        '    Chart9.Series(0).Points.Clear()
        '    Chart9.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
        '    Chart9.Series(0).Color = Color.Blue
        '    Chart9.Series(0).YValueMembers = "Total_estimado"
        '    Chart9.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
        '    Chart9.Series(1).Color = Color.Red
        '    Chart9.Series(1).YValueMembers = "Total_real"
        '    Chart9.Series(1).IsValueShownAsLabel = True
        '    Chart9.Series(2).Color = Color.Yellow
        '    Chart9.Series(2).YValueMembers = "Asignacion"
        '    Chart9.Series(2).IsValueShownAsLabel = True
        '    Chart9.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(8).Cells(1).Value)
        '    Chart9.DataSource = llenargrafico(8)
        'End If
        ''***************************fin grafico 9*********************************

        ''***************************fin grafico 10*********************************
        'If 8 <= totalgrafico Or 9 <= totalcolaborador Then
        '    Chart10.Series(0).Points.Clear()
        '    Chart10.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
        '    Chart10.Series(0).Color = Color.Blue
        '    Chart10.Series(0).YValueMembers = "Total_estimado"
        '    Chart10.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
        '    Chart10.Series(1).Color = Color.Red
        '    Chart10.Series(1).YValueMembers = "Total_real"
        '    Chart10.Series(1).IsValueShownAsLabel = True
        '    Chart10.Series(2).Color = Color.Yellow
        '    Chart10.Series(2).YValueMembers = "Asignacion"
        '    Chart10.Series(2).IsValueShownAsLabel = True
        '    Chart10.Titles(0).Text = CStr(dgvTotalesMensuales.Rows(9).Cells(1).Value)
        '    Chart10.DataSource = llenargrafico(9)
        'End If
        ''***************************fin grafico 10*********************************
    End Sub

    Private Sub btnVerGraficos_Click(sender As System.Object, e As System.EventArgs) Handles btnVerGraficos.Click
        Frm_Graficos.Show()
    End Sub

    Private Sub frm_Generar_Informe_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class
