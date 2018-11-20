Imports iTextSharp.text
Imports System.IO
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing

Public Class frm_Grafico_Totales_Mensuales
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Dim totalgrafico As Integer

    Private Sub frm_Grafico_Totales_Mensuales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TipoGrafico()
        Label1.Text = frm_Generar_Informe.cboMes.Text 'cbomes
        Label2.Text = frm_Generar_Informe.cbo_sector.Text
    End Sub

    Sub cargar_chart(ByVal grafico As Object, ByVal fila As Integer)
        grafico.Series(0).Points.Clear()
        grafico.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
        grafico.Series(0).YValueMembers = "Total_estimado_mensual"
        grafico.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
        grafico.Series(1).YValueMembers = "Total_real_mensual"
        grafico.Series(2).YValueMembers = "Asignacion"

        grafico.Series(0).XValueMember = "COL_nombre_col"
        grafico.Series(1).XValueMember = "COL_nombre_col"
        grafico.Series(2).XValueMember = "COL_nombre_col"
        grafico.DataSource = llenargrafico(fila)
    End Sub

    Function llenargrafico(ByVal indexfila As Integer)
        Dim total_x_colaborador = (From A In datavistas.Totales_mensuales
                                 Select A.COL_id_colaborador,
                                 A.COL_nombre_col,
                                 A.Mes,
                                 A.SEC_id_sector,
                                 A.SEC_nombre_sector,
                                 A.Total_estimado_mensual,
                                 A.Total_real_mensual,
                                 A.Asignacion
         Where (SEC_id_sector = frm_Generar_Informe.cbo_sector.SelectedIndex + 1 _
                And Mes.Value = frm_Generar_Informe.cboMes.SelectedIndex + 1))

        Return total_x_colaborador
    End Function

    Sub TipoGrafico()
        totalgrafico = frm_Generar_Informe.dgvTotalesMensuales.Rows.Count

        '************************inicio grafico 1*********************************
        If 1 <= totalgrafico Then
            cargar_chart(Chart1, 0)
        Else
            Chart1.DataSource = Nothing
        End If
    End Sub
End Class