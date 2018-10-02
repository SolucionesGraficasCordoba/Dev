Imports System.Text
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Frm_Graficos
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Private Sub Frm_Graficos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TipoGrafico()
        btnAnterior.Enabled = False
    End Sub

    Function llenargrafico(ByVal indexfila As Integer)
        Dim consultaporsector = (From A In datavistas.Tiempos_Totales
                                 Select A.COL_id_colaborador,
                                 A.COL_nombre_col,
                                 A.TAR_fecha,
                                A.Total_estimado,
                                 A.Total_real,
                                 A.SEC_id_sector,
                                 A.SEC_nombre_sector,
                                 A.Asignacion,
                                 A.CADENA
         Where (SEC_id_sector = frm_Generar_Informe.cbo_sector.SelectedIndex + 1 And TAR_fecha.Value.Month = frm_Generar_Informe.cboMes.SelectedIndex + 1 And COL_id_colaborador = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(indexfila).Cells(0).Value))) 'PABLO
        Return consultaporsector
    End Function

    Sub TipoGrafico()

        Dim totalgrafico As Integer
        totalgrafico = frm_Generar_Informe.dgvTotalesMensuales.Rows.Count

        '************************inicio grafico 1
        If 1 <= totalgrafico Then

            Chart1.Series(0).Points.Clear()
            Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
            Chart1.Series(0).YValueMembers = "Total_estimado"
            Chart1.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
            Chart1.Series(1).YValueMembers = "Total_real"
            Chart1.Series(2).YValueMembers = "Asignacion"
            Chart1.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(0).Cells(1).Value)
            Chart1.Series(0).XValueMember = "CADENA"
            Chart1.Series(1).XValueMember = "CADENA"
            Chart1.Series(2).XValueMember = "CADENA"
            Chart1.DataSource = llenargrafico(0)
        Else
            Chart1.DataSource = Nothing
        End If
        '***************************fin grafico 1*********************************

        ''************************inicio grafico 2*********************************
        If 2 <= totalgrafico Then
            Chart2.Series(0).Points.Clear()
            Chart2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
            Chart2.Series(0).YValueMembers = "Total_estimado"
            Chart2.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
            Chart2.Series(1).YValueMembers = "Total_real"
            Chart2.Series(2).YValueMembers = "Asignacion"
            Chart2.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(1).Cells(1).Value)
            Chart2.Series(0).XValueMember = "CADENA"
            Chart2.Series(1).XValueMember = "CADENA"
            Chart2.Series(2).XValueMember = "CADENA"
            Chart2.DataSource = llenargrafico(1)
        Else
            Chart2.DataSource = Nothing
        End If
        ''***************************fin grafico 2*********************************

        ''************************inicio grafico 3*********************************
        If 3 <= totalgrafico Then
            Chart3.Series(0).Points.Clear()
            Chart3.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
            Chart3.Series(0).YValueMembers = "Total_estimado"
            Chart3.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
            Chart3.Series(1).YValueMembers = "Total_real"
            Chart3.Series(2).YValueMembers = "Asignacion"
            Chart3.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(2).Cells(1).Value)
            Chart3.Series(0).XValueMember = "CADENA"
            Chart3.Series(1).XValueMember = "CADENA"
            Chart3.Series(2).XValueMember = "CADENA"
            Chart3.DataSource = llenargrafico(2)
        Else
            Chart3.DataSource = Nothing
        End If
        ''***************************fin grafico 3*********************************

        ''************************inicio grafico 4*********************************
        'If 4 <= totalgrafico Then
        '    Chart4.Series(0).Points.Clear()
        '    Chart4.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
        '    Chart4.Series(0).YValueMembers = "Total_estimado"
        '    Chart4.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
        '    Chart4.Series(1).YValueMembers = "Total_real"
        '    Chart4.Series(2).YValueMembers = "Asignacion"
        '    Chart4.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(3).Cells(1).Value)
        '    Chart4.Series(0).XValueMember = "CADENA"
        '    Chart4.Series(1).XValueMember = "CADENA"
        '    Chart4.Series(2).XValueMember = "CADENA"
        '    Chart4.DataSource = llenargrafico(3)
        'End If
        ' ''***************************fin grafico 4*********************************

        ' ''************************inicio grafico 5*********************************
        'If 5 <= totalgrafico Then
        '    Chart5.Series(0).Points.Clear()
        '    Chart5.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column ' tipo de grafico
        '    Chart5.Series(0).YValueMembers = "Total_estimado"
        '    Chart5.Series(0).IsValueShownAsLabel = True ' muestra los valores de cada serie
        '    Chart5.Series(1).YValueMembers = "Total_real"
        '    Chart5.Series(2).YValueMembers = "Asignacion"
        '    Chart5.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(4).Cells(1).Value)
        '    Chart5.Series(0).XValueMember = "CADENA"
        '    Chart5.Series(1).XValueMember = "CADENA"
        '    Chart5.Series(2).XValueMember = "CADENA"
        '    Chart5.DataSource = llenargrafico(4)
        'End If
        ' ''***************************fin grafico 5*********************************

        ' ''************************inicio grafico 6*********************************
        'If 6 <= totalgrafico Then
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
        '    Chart6.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(5).Cells(1).Value)
        '    Chart6.DataSource = llenargrafico(5)
        'End If
        ' ''***************************fin grafico 6*********************************

        ' ''***************************fin grafico 7*********************************
        'If 7 <= totalgrafico Then
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
        '    Chart7.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(6).Cells(1).Value)
        '    Chart7.DataSource = llenargrafico(6)
        'End If
        ' ''***************************fin grafico 7*********************************

        ' ''***************************fin grafico 8*********************************
        'If 8 <= totalgrafico Then
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
        '    Chart8.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(7).Cells(1).Value)
        '    Chart8.DataSource = llenargrafico(7)
        'End If
        ' ''***************************fin grafico 8*********************************

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

    Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
        frm_Grafico_1.Show()
    End Sub
End Class