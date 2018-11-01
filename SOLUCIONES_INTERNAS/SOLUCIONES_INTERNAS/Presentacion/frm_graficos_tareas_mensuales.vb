Imports iTextSharp.text
'Imports iTextSharp.text.Image
Imports System.IO
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing
'Imports System.Drawing

Public Class frm_graficos_tareas_mensuales
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Dim totalgrafico As Integer

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
        'Me.Dispose()
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

    Private Sub btnExportarPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPDF.Click

        'intentar generar el documento
        Dim ancho, alto As Single
        ancho = 800.0F
        alto = 150.0F
        Dim doc As New Document(PageSize.A3, 25, 25, 10, 10)
        'path que guarda el reporte en el escritorio de windows (desktop)
        Dim ruta_reporte_grafico As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Graficos_tiempos_asignados.pdf"
        Dim reporte As New FileStream(ruta_reporte_grafico, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        PdfWriter.GetInstance(doc, reporte)
        doc.Open()
        Dim encabezado As New Paragraph("Tiempos asignados")
        Dim interlineado As New Paragraph("")
        doc.Add(encabezado)
        '************************inicio grafico 1*********************************
        If 1 <= totalgrafico Then
            Dim grafico1 As New Bitmap(Chart1.Width, Chart1.Height)
            Chart1.DrawToBitmap(grafico1, Chart1.DisplayRectangle)
            Dim file1 As String = "C:\Users\Administrador\Desktop\grafico1.jpg"
            grafico1.Save(file1)
            Dim imagen1 As Image = Image.GetInstance("C:\Users\Administrador\Desktop\grafico1.jpg")
            imagen1.ScaleAbsolute(ancho, alto)
            doc.Add(imagen1)
            doc.Add(interlineado)
        End If
        '************************inicio grafico 2*********************************
        'If 2 <= totalgrafico Then
        '    Dim grafico2 As New Bitmap(Chart2.Width, Chart2.Height)
        '    Chart2.DrawToBitmap(grafico2, Chart2.DisplayRectangle)
        '    Dim file2 As String = "C:\Users\valeh\Documents\grafico2.jpg"
        '    grafico2.Save(file2)
        '    Dim imagen2 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico2.jpg")
        '    imagen2.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen2)
        '    doc.Add(interlineado)
        'End If
        ''************************inicio grafico 3*********************************
        'If 3 <= totalgrafico Then
        '    Dim grafico3 As New Bitmap(Chart3.Width, Chart3.Height)
        '    Chart3.DrawToBitmap(grafico3, Chart3.DisplayRectangle)
        '    Dim file3 As String = "C:\Users\valeh\Documents\grafico3.jpg"
        '    grafico3.Save(file3)
        '    Dim imagen3 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico3.jpg")
        '    imagen3.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen3)
        '    doc.Add(interlineado)
        'End If
        ' ''************************inicio grafico 4*********************************
        'If 4 <= totalgrafico Then
        '    Dim grafico4 As New Bitmap(Chart4.Width, Chart4.Height)
        '    Chart4.DrawToBitmap(grafico4, Chart4.DisplayRectangle)
        '    Dim file4 As String = "C:\Users\valeh\Documents\grafico4.jpg"
        '    grafico4.Save(file4)
        '    Dim imagen4 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico4.jpg")
        '    imagen4.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen4)
        '    doc.Add(interlineado)
        'End If
        ' ''************************inicio grafico 5*********************************
        'If 5 <= totalgrafico Then
        '    Dim grafico5 As New Bitmap(Chart5.Width, Chart5.Height)
        '    Chart5.DrawToBitmap(grafico5, Chart5.DisplayRectangle)
        '    Dim file5 As String = "C:\Users\valeh\Documents\grafico5.jpg"
        '    grafico5.Save(file5)
        '    Dim imagen5 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico5.jpg")
        '    imagen5.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen5)
        '    doc.Add(interlineado)
        'End If
        ' ''************************inicio grafico 6*********************************
        'If 6 <= totalgrafico Then
        '    Dim grafico6 As New Bitmap(Chart6.Width, Chart6.Height)
        '    Chart6.DrawToBitmap(grafico6, Chart6.DisplayRectangle)
        '    Dim file6 As String = "C:\Users\valeh\Documents\grafico6.jpg"
        '    grafico6.Save(file6)
        '    Dim imagen6 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico6.jpg")
        '    imagen6.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen6)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 7*********************************
        'If 7 <= totalgrafico Then
        '    Dim grafico7 As New Bitmap(Chart7.Width, Chart7.Height)
        '    Chart7.DrawToBitmap(grafico7, Chart7.DisplayRectangle)
        '    Dim file7 As String = "C:\Users\valeh\Documents\grafico7.jpg"
        '    grafico7.Save(file7)
        '    Dim imagen7 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico7.jpg")
        '    imagen7.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen7)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 8*********************************
        'If 8 <= totalgrafico Then
        '    Dim grafico8 As New Bitmap(Chart8.Width, Chart8.Height)
        '    Chart8.DrawToBitmap(grafico8, Chart8.DisplayRectangle)
        '    Dim file8 As String = "C:\Users\valeh\Documents\grafico8.jpg"
        '    grafico8.Save(file8)
        '    Dim imagen8 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico8.jpg")
        '    imagen8.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen8)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 9*********************************
        'If 9 <= totalgrafico Then
        '    Dim grafico9 As New Bitmap(Chart9.Width, Chart9.Height)
        '    Chart9.DrawToBitmap(grafico9, Chart9.DisplayRectangle)
        '    Dim file9 As String = "C:\Users\valeh\Documents\grafico9.jpg"
        '    grafico9.Save(file9)
        '    Dim imagen9 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico9.jpg")
        '    imagen9.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen9)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 10*********************************
        'If 10 <= totalgrafico Then
        '    Dim grafico10 As New Bitmap(Chart10.Width, Chart10.Height)
        '    Chart10.DrawToBitmap(grafico10, Chart10.DisplayRectangle)
        '    Dim file10 As String = "C:\Users\valeh\Documents\grafico10.jpg"
        '    grafico10.Save(file10)
        '    Dim imagen10 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico10.jpg")
        '    imagen10.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen10)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 11*********************************
        'If 11 <= totalgrafico Then
        '    Dim grafico11 As New Bitmap(Chart11.Width, Chart11.Height)
        '    Chart11.DrawToBitmap(grafico11, Chart11.DisplayRectangle)
        '    Dim file11 As String = "C:\Users\valeh\Documents\grafico11.jpg"
        '    grafico11.Save(file11)
        '    Dim imagen11 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico11.jpg")
        '    imagen11.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen11)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 12*********************************
        'If 12 <= totalgrafico Then
        '    Dim grafico12 As New Bitmap(Chart12.Width, Chart12.Height)
        '    Chart12.DrawToBitmap(grafico12, Chart12.DisplayRectangle)
        '    Dim file12 As String = "C:\Users\valeh\Documents\grafico12.jpg"
        '    grafico12.Save(file12)
        '    Dim imagen12 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico12.jpg")
        '    imagen12.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen12)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 13*********************************
        'If 13 <= totalgrafico Then
        '    Dim grafico13 As New Bitmap(Chart13.Width, Chart13.Height)
        '    Chart13.DrawToBitmap(grafico13, Chart13.DisplayRectangle)
        '    Dim file13 As String = "C:\Users\valeh\Documents\grafico13.jpg"
        '    grafico13.Save(file13)
        '    Dim imagen13 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico13.jpg")
        '    imagen13.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen13)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 14*********************************
        'If 14 <= totalgrafico Then
        '    Dim grafico14 As New Bitmap(Chart14.Width, Chart14.Height)
        '    Chart14.DrawToBitmap(grafico14, Chart14.DisplayRectangle)
        '    Dim file14 As String = "C:\Users\valeh\Documents\grafico14.jpg"
        '    grafico14.Save(file14)
        '    Dim imagen14 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico14.jpg")
        '    imagen14.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen14)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 15*********************************
        'If 15 <= totalgrafico Then
        '    Dim grafico15 As New Bitmap(Chart15.Width, Chart15.Height)
        '    Chart15.DrawToBitmap(grafico15, Chart15.DisplayRectangle)
        '    Dim file15 As String = "C:\Users\valeh\Documents\grafico15.jpg"
        '    grafico15.Save(file15)
        '    Dim imagen15 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico15.jpg")
        '    imagen15.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen15)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 16*********************************
        'If 16 <= totalgrafico Then
        '    Dim grafico16 As New Bitmap(Chart16.Width, Chart16.Height)
        '    Chart16.DrawToBitmap(grafico16, Chart16.DisplayRectangle)
        '    Dim file16 As String = "C:\Users\valeh\Documents\grafico16.jpg"
        '    grafico16.Save(file16)
        '    Dim imagen16 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico16.jpg")
        '    imagen16.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen16)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 17*********************************
        'If 17 <= totalgrafico Then
        '    Dim grafico17 As New Bitmap(Chart17.Width, Chart17.Height)
        '    Chart17.DrawToBitmap(grafico17, Chart17.DisplayRectangle)
        '    Dim file17 As String = "C:\Users\valeh\Documents\grafico17.jpg"
        '    grafico17.Save(file17)
        '    Dim imagen17 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico17.jpg")
        '    imagen17.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen17)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 18*********************************
        'If 18 <= totalgrafico Then
        '    Dim grafico18 As New Bitmap(Chart18.Width, Chart18.Height)
        '    Chart18.DrawToBitmap(grafico18, Chart18.DisplayRectangle)
        '    Dim file18 As String = "C:\Users\valeh\Documents\grafico18.jpg"
        '    grafico18.Save(file18)
        '    Dim imagen18 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico18.jpg")
        '    imagen18.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen18)
        '    doc.Add(interlineado)
        'End If
        ' ''***************************inicio grafico 19*********************************
        'If 19 <= totalgrafico Then
        '    Dim grafico19 As New Bitmap(Chart19.Width, Chart19.Height)
        '    Chart19.DrawToBitmap(grafico19, Chart19.DisplayRectangle)
        '    Dim file19 As String = "C:\Users\valeh\Documents\grafico19.jpg"
        '    grafico19.Save(file19)
        '    Dim imagen19 As Image = Image.GetInstance("C:\Users\valeh\Documents\grafico19.jpg")
        '    imagen19.ScaleAbsolute(ancho, alto)
        '    doc.Add(imagen19)
        '    doc.Add(interlineado)
        'End If

        'cierra la edicion y abre el archivo
        doc.Close()
        Process.Start(ruta_reporte_grafico)
    End Sub

End Class