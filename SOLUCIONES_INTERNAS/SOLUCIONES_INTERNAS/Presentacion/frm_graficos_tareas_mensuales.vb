﻿Imports iTextSharp.text
Imports System.IO
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf
Imports System.Windows.Forms.DataVisualization.Charting



Public Class frm_graficos_tareas_mensuales
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Private Sub Frm_Graficos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TipoGrafico()

        Label1.Text = frm_Generar_Informe.cboMes.Text 'cbomes
        Label2.Text = frm_Generar_Informe.cbo_sector.Text

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

        '************************inicio grafico 1*********************************
        If 1 <= totalgrafico Then
            cargar_chart(Chart1, 0)
        Else
            Chart1.DataSource = Nothing
        End If
        '************************inicio grafico 2*********************************
        If 2 <= totalgrafico Then
            cargar_chart(Chart2, 1)
        Else
            Chart2.DataSource = Nothing
        End If
        '************************inicio grafico 3*********************************
        If 3 <= totalgrafico Then
            cargar_chart(Chart3, 2)
        Else
            Chart3.DataSource = Nothing
        End If
        '************************inicio grafico 4*********************************
        If 4 <= totalgrafico Then
            cargar_chart(Chart4, 3)
        Else
            Chart4.DataSource = Nothing
        End If
        '************************inicio grafico 5*********************************
        If 5 <= totalgrafico Then
            cargar_chart(Chart5, 4)
        Else
            Chart5.DataSource = Nothing
        End If
        '************************inicio grafico 6*********************************
        If 6 <= totalgrafico Then
            cargar_chart(Chart6, 5)
        Else
            Chart6.DataSource = Nothing
        End If
        '***************************inicio grafico 7*********************************
        If 7 <= totalgrafico Then
            cargar_chart(Chart7, 6)
        Else
            Chart7.DataSource = Nothing
        End If
        '***************************inicio grafico 8*********************************
        If 8 <= totalgrafico Then
            cargar_chart(Chart8, 7)
        Else
            Chart8.DataSource = Nothing
        End If
        '***************************inicio grafico 9*********************************
        If 9 <= totalgrafico Then
            cargar_chart(Chart9, 8)
        Else
            Chart9.DataSource = Nothing
        End If
        '***************************inicio grafico 10*********************************
        If 10 <= totalgrafico Then
            cargar_chart(Chart10, 9)
        Else
            Chart10.DataSource = Nothing
        End If
        '***************************inicio grafico 11*********************************
        If 11 <= totalgrafico Then
            cargar_chart(Chart11, 10)
        Else
            Chart11.DataSource = Nothing
        End If
        '***************************inicio grafico 12*********************************
        If 12 <= totalgrafico Then
            cargar_chart(Chart12, 11)
        Else
            Chart12.DataSource = Nothing
        End If
        '***************************inicio grafico 13*********************************
        If 13 <= totalgrafico Then
            cargar_chart(Chart13, 12)
        Else
            Chart13.DataSource = Nothing
        End If
        '***************************inicio grafico 14*********************************
        If 14 <= totalgrafico Then
            cargar_chart(Chart14, 13)
        Else
            Chart14.DataSource = Nothing
        End If
        '***************************inicio grafico 15*********************************
        If 15 <= totalgrafico Then
            cargar_chart(Chart15, 14)
        Else
            Chart15.DataSource = Nothing
        End If
        '***************************inicio grafico 16*********************************
        If 16 <= totalgrafico Then
            cargar_chart(Chart16, 15)
        Else
            Chart16.DataSource = Nothing
        End If
        '***************************inicio grafico 17*********************************
        If 17 <= totalgrafico Then
            cargar_chart(Chart17, 16)
        Else
            Chart17.DataSource = Nothing
        End If
        '***************************inicio grafico 18*********************************
        If 18 <= totalgrafico Then
            cargar_chart(Chart18, 17)
        Else
            Chart18.DataSource = Nothing
        End If
        '***************************inicio grafico 19*********************************
        If 19 <= totalgrafico Then
            cargar_chart(Chart19, 18)
        Else
            Chart19.DataSource = Nothing
        End If

    End Sub

    Private Sub Frm_Graficos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Sub cargar_chart(ByVal grafico As Object, ByVal fila As Integer)
        grafico.Series(0).Points.Clear()
        grafico.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column 'tipo de grafico
        grafico.Series(0).YValueMembers = "Total_estimado"
        grafico.Series(0).IsValueShownAsLabel = True 'muestra los valores de cada serie
        grafico.Series(1).YValueMembers = "Total_real"
        grafico.Series(2).YValueMembers = "Asignacion"
        grafico.Titles(0).Text = CStr(frm_Generar_Informe.dgvTotalesMensuales.Rows(fila).Cells(1).Value)
        grafico.Series(0).XValueMember = "CADENA"
        grafico.Series(1).XValueMember = "CADENA"
        grafico.Series(2).XValueMember = "CADENA"
        grafico.DataSource = llenargrafico(fila)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnSubir_Click(sender As System.Object, e As System.EventArgs) Handles btnSubir.Click
        btnExportarPDF.Focus()
    End Sub

    Private Sub btnExportarPDF_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarPDF.Click
  
    End Sub
End Class