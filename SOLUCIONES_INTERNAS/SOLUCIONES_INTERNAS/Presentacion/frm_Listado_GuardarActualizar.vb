Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_Listado_GuardarActualizar
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas
    Public vble_id_colaborador As Integer
    Dim vble_colaborador, vble_fecha As String

    'campos y vbles para generar pdf
    Dim contadorcolumnasvisibles As Integer
    Dim interlineado As New Phrase(" ")
    Dim linea As New Phrase("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ")
    Dim fuente As iTextSharp.text.pdf.BaseFont = FontFactory.GetFont(FontFactory.HELVETICA).BaseFont


    Private Sub btnModificarTodas_Click(sender As System.Object, e As System.EventArgs) Handles btnModificarTodas.Click

        'CARGA EL ENCABEZADO DEL FORMULARIO TAREAS
        If dgvColaboradores.Rows.Count = 0 Then
            MsgBox("Debe selecconar un Sector")
            Exit Sub
        Else
        End If
        If dgvTarea_x_Colaborador.Rows.Count <> 0 Then
            frm_GuardarActualizar_tarea.quienllamoatarea = 1
            frm_GuardarActualizar_tarea.txt_id_colaborador.Text = Me.dgvColaboradores.Item("COL_id_colaborador", dgvColaboradores.SelectedRows(0).Index).Value
            frm_GuardarActualizar_tarea.txt_nombre_colaborador.Text = Me.dgvColaboradores.Item("COL_nombre_col", dgvColaboradores.SelectedRows(0).Index).Value
            frm_GuardarActualizar_tarea.dtpFecha.Text = Me.dgvTarea_x_Colaborador.Item("TAR_fecha", dgvTarea_x_Colaborador.Rows(0).Index).Value
            frm_GuardarActualizar_tarea.txt_Carga_Horaria1.Text = Me.dgvTarea_x_Colaborador.Item("TAR_carga_horaria", dgvTarea_x_Colaborador.Rows(0).Index).Value

            frm_GuardarActualizar_tarea.txtEntrada.Text = Me.dgvTarea_x_Colaborador.Item("TAR_entrada", dgvTarea_x_Colaborador.Rows(0).Index).Value
            frm_GuardarActualizar_tarea.txtSalida.Text = Me.dgvTarea_x_Colaborador.Item("TAR_salida", dgvTarea_x_Colaborador.Rows(0).Index).Value

            Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8, flag9, flag10, flag11, flag12, flag13, flag14, flag15, flag16, flag17, flag18, flag19, flag20 As Integer

            If dgvTarea_x_Colaborador.RowCount = 1 Then
                flag1 = 1
                'desab_tarea_2()
                'desab_tarea_3()
                'desab_tarea_4()
                'desab_tarea_5()
                'desab_tarea_6()
                'desab_tarea_7()
                'desab_tarea_8()
                'desab_tarea_9()
                'desab_tarea_10()
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 2 Then
                flag1 = 1
                flag2 = 1
                'desab_tarea_3()
                'desab_tarea_4()
                'desab_tarea_5()
                'desab_tarea_6()
                'desab_tarea_7()
                'desab_tarea_8()
                'desab_tarea_9()
                'desab_tarea_10()
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 3 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                'desab_tarea_4()
                'desab_tarea_5()
                'desab_tarea_6()
                'desab_tarea_7()
                'desab_tarea_8()
                'desab_tarea_9()
                'desab_tarea_10()
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 4 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                'desab_tarea_5()
                'desab_tarea_6()
                'desab_tarea_7()
                'desab_tarea_8()
                'desab_tarea_9()
                'desab_tarea_10()
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 5 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                'desab_tarea_6()
                'desab_tarea_7()
                'desab_tarea_8()
                'desab_tarea_9()
                'desab_tarea_10()
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 6 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                'desab_tarea_7()
                'desab_tarea_8()
                'desab_tarea_9()
                'desab_tarea_10()
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 7 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                'desab_tarea_8()
                'desab_tarea_9()
                'desab_tarea_10()
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 8 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                'desab_tarea_9()
                'desab_tarea_10()
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 9 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                'desab_tarea_10()
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 10 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                'desab_tarea_11()
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 11 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                'desab_tarea_12()
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 12 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                'desab_tarea_13()
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 13 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                'desab_tarea_14()
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 14 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                'desab_tarea_15()
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 15 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                'desab_tarea_16()
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 16 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
                'desab_tarea_17()
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 17 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
                flag17 = 1
                'desab_tarea_18()
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo17.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 18 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
                flag17 = 1
                flag18 = 1
                'desab_tarea_19()
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo17.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo18.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount = 19 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
                flag17 = 1
                flag18 = 1
                flag19 = 1
                'desab_tarea_20()
                OcultarId()
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo17.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo18.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo19.Enabled = False
            ElseIf dgvTarea_x_Colaborador.RowCount >= 20 Then
                flag1 = 1
                flag2 = 1
                flag3 = 1
                flag4 = 1
                flag5 = 1
                flag6 = 1
                flag7 = 1
                flag8 = 1
                flag9 = 1
                flag10 = 1
                flag11 = 1
                flag12 = 1
                flag13 = 1
                flag14 = 1
                flag15 = 1
                flag16 = 1
                flag17 = 1
                flag18 = 1
                flag19 = 1
                flag20 = 1
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo17.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo18.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo19.Enabled = False
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo20.Enabled = False

                If dgvTarea_x_Colaborador.RowCount > 20 Then
                    MsgBox("Sólo se muestran las primeras 20 tareas,para modificar una específca selecciónela de la grilla")
                    btnExportarListado.Focus()
                End If
                If dgvTarea_x_Colaborador.RowCount >= 20 Then
                    OcultarId()
                End If
            End If

            If flag1 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea1.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea1.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado1.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real1.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion1.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones1.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo1.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(0).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(0).Index).Value
            End If

            If flag2 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea2.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea2.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado2.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real2.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion2.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones2.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo2.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(1).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(1).Index).Value
            End If

            If flag3 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea3.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea3.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado3.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real3.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion3.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones3.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo3.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(2).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(2).Index).Value
            End If

            If flag4 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea4.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea4.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado4.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real4.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion4.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones4.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo4.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(3).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(3).Index).Value
            End If

            If flag5 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea5.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea5.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado5.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real5.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion5.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones5.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo5.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(4).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(4).Index).Value
            End If

            If flag6 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea6.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea6.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado6.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real6.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion6.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones6.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo6.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(5).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(5).Index).Value
            End If

            If flag7 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea7.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea7.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado7.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real7.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion7.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones7.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo7.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(6).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(6).Index).Value
            End If

            If flag8 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea8.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea8.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado8.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real8.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion8.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones8.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo8.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(7).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(7).Index).Value
            End If

            If flag9 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea9.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea9.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado9.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real9.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion9.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones9.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo9.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(8).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(8).Index).Value
            End If

            If flag10 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea10.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea10.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado10.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real10.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion10.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones10.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo10.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(9).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(9).Index).Value

            End If

            If flag11 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea11.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea11.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado11.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real11.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion11.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones11.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo11.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(10).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(10).Index).Value
            End If

            If flag12 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea12.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea12.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado12.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real12.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion12.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones12.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo12.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(11).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(11).Index).Value
            End If

            If flag13 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea13.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea13.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado13.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real13.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion13.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones13.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo13.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(12).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(12).Index).Value
            End If

            If flag14 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea14.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea14.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado14.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real14.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion14.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones14.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo14.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(13).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(13).Index).Value
            End If

            If flag15 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea15.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea15.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado15.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real15.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion15.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones15.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo15.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(14).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(14).Index).Value
            End If

            If flag16 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea16.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea16.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado16.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real16.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion16.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones16.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo16.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(15).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(15).Index).Value

            End If

            If flag17 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea17.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea17.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado17.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real17.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion17.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones17.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo17.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(16).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo17.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(16).Index).Value
            End If

            If flag18 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea18.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea18.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado18.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real18.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion18.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones18.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo18.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(17).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo18.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(17).Index).Value
            End If

            If flag19 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea19.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea19.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado19.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real19.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion19.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones19.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo19.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(18).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo19.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(18).Index).Value
            End If

            If flag20 = 1 Then
                frm_GuardarActualizar_tarea.txt_Id_Tarea20.Text = Me.dgvTarea_x_Colaborador.Item("TAR_id_tarea", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_GuardarActualizar_tarea.txt_detalle_tarea20.Text = dgvTarea_x_Colaborador.Item("TAR_detalle_tarea", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Estimado20.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_estimado", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_GuardarActualizar_tarea.txtTiempo_Real20.Text = dgvTarea_x_Colaborador.Item("TAR_tiempo_real", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_GuardarActualizar_tarea.txtHora_Finalizacion20.Text = dgvTarea_x_Colaborador.Item("TAR_hora_fin", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_GuardarActualizar_tarea.txtObservaciones20.Text = dgvTarea_x_Colaborador.Item("TAR_observaciones", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_GuardarActualizar_tarea.txt_id_orden_trabajo20.Text = dgvTarea_x_Colaborador.Item("ORT_id_orden_trabajo", dgvTarea_x_Colaborador.Rows(19).Index).Value
                frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo20.Text = dgvTarea_x_Colaborador.Item("ORT_numero_ot", dgvTarea_x_Colaborador.Rows(19).Index).Value
            End If
        Else
            MsgBox("El Colaborador no tiene tareas por mostrar")
            Exit Sub
        End If
        frm_GuardarActualizar_tarea.Text = "Actualizar Tareas"
        frm_GuardarActualizar_tarea.btnImprimirFormulario.Visible = False
        frm_GuardarActualizar_tarea.txt_nombre_colaborador.Enabled = False

        ' frm_Tarea.btnImprimirFormulario.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Colaborador.Enabled = False
        frm_GuardarActualizar_tarea.dtpFecha.Enabled = False
        frm_GuardarActualizar_tarea.txt_Carga_Horaria1.Enabled = False
        '  frm_Tarea.btnNueva_Tarea.Enabled = False
        frm_GuardarActualizar_tarea.btnGuardar_Tarea.Enabled = False
        frm_GuardarActualizar_tarea.Label1.Visible = False
        frm_GuardarActualizar_tarea.txt_id_colaborador.Visible = False
        frm_GuardarActualizar_tarea.txt_id_tarea.Visible = False
        frm_GuardarActualizar_tarea.btnActualizar.Enabled = True
        frm_GuardarActualizar_tarea.txtEntrada.Enabled = True
        frm_GuardarActualizar_tarea.txtSalida.Enabled = True

        'frm_Tarea.MdiParent = Me
        'frm_Tarea.Show()
        frm_GuardarActualizar_tarea.ShowDialog()
    End Sub


    Sub desab_tarea_1()
        frm_GuardarActualizar_tarea.txt_detalle_tarea1.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado1.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real1.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion1.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones1.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo1.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo1.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden1.Enabled = False

    End Sub

    Sub desab_tarea_2()
        frm_GuardarActualizar_tarea.txt_detalle_tarea2.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado2.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real2.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion2.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones2.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo2.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo2.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden2.Enabled = False


    End Sub

    Sub desab_tarea_3()
        frm_GuardarActualizar_tarea.txt_detalle_tarea3.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado3.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real3.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion3.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones3.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo3.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo3.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden3.Enabled = False


    End Sub

    Sub desab_tarea_4()
        frm_GuardarActualizar_tarea.txt_detalle_tarea4.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado4.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real4.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion4.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones4.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo4.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo4.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden4.Enabled = False


    End Sub

    Sub desab_tarea_5()
        frm_GuardarActualizar_tarea.txt_detalle_tarea5.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado5.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real5.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion5.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones5.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo5.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo5.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden5.Enabled = False

    End Sub

    Sub desab_tarea_6()
        frm_GuardarActualizar_tarea.txt_detalle_tarea6.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado6.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real6.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion6.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones6.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo6.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo6.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden6.Enabled = False

    End Sub

    Sub desab_tarea_7()
        frm_GuardarActualizar_tarea.txt_detalle_tarea7.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado7.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real7.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion7.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones7.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo7.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo7.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden7.Enabled = False
    End Sub

    Sub desab_tarea_8()
        frm_GuardarActualizar_tarea.txt_detalle_tarea8.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado8.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real8.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion8.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones8.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo8.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo8.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden8.Enabled = False


    End Sub

    Sub desab_tarea_9()
        frm_GuardarActualizar_tarea.txt_detalle_tarea9.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado9.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real9.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion9.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones9.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo9.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo9.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden9.Enabled = False

    End Sub

    Sub desab_tarea_10()
        frm_GuardarActualizar_tarea.txt_detalle_tarea10.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado10.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real10.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion10.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones10.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo10.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo10.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden10.Enabled = False

    End Sub

    Sub desab_tarea_11()
        frm_GuardarActualizar_tarea.txt_detalle_tarea11.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado11.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real11.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion11.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones11.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo11.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo11.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden11.Enabled = False

    End Sub

    Sub desab_tarea_12()
        frm_GuardarActualizar_tarea.txt_detalle_tarea12.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado12.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real12.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion12.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones12.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo12.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo12.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden12.Enabled = False

    End Sub

    Sub desab_tarea_13()
        frm_GuardarActualizar_tarea.txt_detalle_tarea13.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado13.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real13.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion13.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones13.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo13.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo13.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden13.Enabled = False

    End Sub

    Sub desab_tarea_14()
        frm_GuardarActualizar_tarea.txt_detalle_tarea14.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado14.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real14.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion14.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones14.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo14.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo14.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden14.Enabled = False

    End Sub

    Sub desab_tarea_15()
        frm_GuardarActualizar_tarea.txt_detalle_tarea15.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado15.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real15.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion15.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones15.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo15.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo15.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden15.Enabled = False

    End Sub

    Sub desab_tarea_16()
        frm_GuardarActualizar_tarea.txt_detalle_tarea16.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado16.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real16.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion16.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones16.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo16.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo16.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden16.Enabled = False

    End Sub

    Sub desab_tarea_17()
        frm_GuardarActualizar_tarea.txt_detalle_tarea17.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado17.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real17.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion17.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones17.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo17.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo17.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden17.Enabled = False

    End Sub

    Sub desab_tarea_18()
        frm_GuardarActualizar_tarea.txt_detalle_tarea18.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado18.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real18.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion18.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones18.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo18.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo18.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden18.Enabled = False

    End Sub

    Sub desab_tarea_19()
        frm_GuardarActualizar_tarea.txt_detalle_tarea19.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado19.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real19.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion19.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones19.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo19.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo19.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden19.Enabled = False

    End Sub

    Sub desab_tarea_20()
        frm_GuardarActualizar_tarea.txt_detalle_tarea20.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Estimado20.Enabled = False
        frm_GuardarActualizar_tarea.txtTiempo_Real20.Enabled = False
        frm_GuardarActualizar_tarea.txtHora_Finalizacion20.Enabled = False
        frm_GuardarActualizar_tarea.txtObservaciones20.Enabled = False
        frm_GuardarActualizar_tarea.txtNumero_Orden_Trabajo20.Enabled = False
        frm_GuardarActualizar_tarea.txt_id_orden_trabajo20.Visible = False
        frm_GuardarActualizar_tarea.btnBuscar_Numero_Orden20.Enabled = False
    End Sub

    Public Sub DeshabilitarText()

        desab_tarea_1()
        desab_tarea_2()
        desab_tarea_3()
        desab_tarea_4()
        desab_tarea_5()
        desab_tarea_6()
        desab_tarea_7()
        desab_tarea_8()
        desab_tarea_9()
        desab_tarea_10()
        desab_tarea_11()
        desab_tarea_12()
        desab_tarea_13()
        desab_tarea_14()
        desab_tarea_15()
        desab_tarea_16()
        desab_tarea_17()
        desab_tarea_18()
        desab_tarea_19()
        desab_tarea_20()

        frm_GuardarActualizar_tarea.btnImprimirFormulario.Enabled = True
        frm_GuardarActualizar_tarea.btnBuscar_Colaborador.Enabled = False
        frm_GuardarActualizar_tarea.dtpFecha.Enabled = False
        frm_GuardarActualizar_tarea.txt_Carga_Horaria1.Enabled = False
        frm_GuardarActualizar_tarea.btnNueva_Tarea.Enabled = False
        frm_GuardarActualizar_tarea.btnGuardar_Tarea.Enabled = False
        frm_GuardarActualizar_tarea.Label1.Visible = False
        frm_GuardarActualizar_tarea.txt_id_colaborador.Visible = False
        frm_GuardarActualizar_tarea.txt_id_tarea.Visible = False
        frm_GuardarActualizar_tarea.btnActualizar.Enabled = False
        frm_GuardarActualizar_tarea.txtEntrada.Enabled = False
        frm_GuardarActualizar_tarea.txtSalida.Enabled = False
    End Sub

    Sub OcultarId()
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo1.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo2.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo3.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo4.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo5.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo6.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo7.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo8.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo9.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo10.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo11.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo12.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo13.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo14.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo15.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo16.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo17.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo18.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo19.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_orden_trabajo20.Visible = False

        'frm_GuardarActualizar_tarea.txt_Id_Tarea1.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea2.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea3.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea4.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea5.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea6.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea7.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea8.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea9.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea10.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea11.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea12.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea13.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea14.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea15.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea16.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea17.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea18.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea19.Visible = False
        'frm_GuardarActualizar_tarea.txt_Id_Tarea20.Visible = False

        'frm_GuardarActualizar_tarea.txt_id_colaborador.Visible = False
        'frm_GuardarActualizar_tarea.txt_id_tarea.Visible = False
        'frm_GuardarActualizar_tarea.Label1.Visible = False

        'frm_GuardarActualizar_tarea.btnNueva_Tarea.Enabled = False
        'frm_GuardarActualizar_tarea.btnGuardar_Tarea.Enabled = False
    End Sub

    Private Sub frm_Listado_GuardarActualizar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label6.Text = dgvColaboradores.Rows.Count
        btnAgregar.Visible = False

        If frm_Principal.LBL_MENU_PERFIL.Text = "ADMINISTRADOR" Or frm_Principal.LBL_MENU_PERFIL.Text = "GERENCIA" Then
            'CARGA COMBOBOX SECTOR
            Dim combosector = (From sec In datacontext.SECTOR
               Select sec.SEC_id_sector, sec.SEC_nombre_sector)
            cbo_sector.DataSource = combosector
            cbo_sector.SelectedIndex = 0
            cbo_sector.DisplayMember = "SEC_nombre_sector"
            cbo_sector.ValueMember = "SEC_id_sector"

            ' Btn_informe_diario.Visible = True
            Btn_informe_diario.Focus()
        Else
            Dim combosector = (From sec In datacontext.SECTOR
                              Join col In datacontext.COLABORADOR
                              On col.SEC_id_sector Equals sec.SEC_id_sector
                              Join usu In datacontext.USUARIO
                              On usu.COL_id_colaborador Equals col.COL_id_colaborador
                              Select usu.USU_usuario, sec.SEC_id_sector, sec.SEC_nombre_sector, col.COL_id_colaborador, col.COL_nombre_col
                              Where USU_usuario = frm_Principal.LBL_MENU_USU.Text)

            cbo_sector.DataSource = combosector
            ' cbo_sector.SelectedIndex = 0
            cbo_sector.DisplayMember = "SEC_nombre_sector"
            cbo_sector.ValueMember = "SEC_id_sector"

            ' Btn_informe_diario.Visible = False
        End If
        dgvColaboradores.ClearSelection()

    End Sub

    Private Sub cbo_sector_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_sector.SelectedIndexChanged
        armargrillacolaborador()
        'SI EL PERFIL ES COLABORADOR SOLO MUESTRA EL COLABORADOR LOGUEADO
        If frm_Principal.LBL_MENU_PERFIL.Text = "COLABORADOR" Then

            Dim cargasupervisor = (From sec In datacontext.SECTOR
                        Join col In datacontext.COLABORADOR
                        On col.SEC_id_sector Equals sec.SEC_id_sector
                        Join usu In datacontext.USUARIO
                        On usu.COL_id_colaborador Equals col.COL_id_colaborador
                        Select usu.USU_usuario, sec.SEC_id_sector, sec.SEC_nombre_sector, col.COL_id_colaborador, col.COL_nombre_col, col.COL_apellido_col
                        Where USU_usuario = frm_Principal.LBL_MENU_USU.Text)
            dgvColaboradores.DataSource = cargasupervisor
        Else

            Dim consultaporsector = (From A In datavistas.Colaborador_por_Sector
                                    Select A.COL_id_colaborador,
                                    A.COL_nombre_col,
                                    A.SEC_id_sector,
                                    A.SEC_nombre_sector
                                    Where SEC_nombre_sector = cbo_sector.Text)
            dgvColaboradores.DataSource = consultaporsector
        End If

        Label6.Text = dgvColaboradores.Rows.Count
        dgvColaboradores.ClearSelection()
    End Sub

    'ARMA LA GRILLA DEL COLABORADOR
    Private Sub armargrillacolaborador()
        dgvColaboradores.Enabled = True
        dgvColaboradores.AutoGenerateColumns = False
        dgvColaboradores.Columns.Clear()

        dgvColaboradores.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvColaboradores.Columns.Add("COL_nombre_col", "Colaborador")

        dgvColaboradores.Columns(0).DataPropertyName = "COL_id_colaborador"
        dgvColaboradores.Columns(0).Visible = False
        dgvColaboradores.Columns(1).DataPropertyName = "COL_nombre_col"
        'dgvColaboradores.Columns(1).Width = 350

    End Sub

    Private Sub dtpFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecha.ValueChanged
        dgvColaboradores.ClearSelection()
        dgvTarea_x_Colaborador.DataSource = ""
    End Sub

    Private Sub dgvColaboradores_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvColaboradores.CellClick
        Try
            If dgvColaboradores.SelectedRows.Count > 0 Then
                vble_id_colaborador = dgvColaboradores.Item("COL_id_colaborador", dgvColaboradores.SelectedRows(0).Index).Value
                btnModificar_Una.Enabled = True
                btnModificarTodas.Enabled = True
                If Me.Text = "Consultar Tarea" Then
                    btnModificar_Una.Enabled = False
                    btnModificarTodas.Enabled = False
                    btnAgregar.Enabled = False
                    Label1.Text = dgvTarea_x_Colaborador.Rows.Count

                ElseIf Me.Text = "Eliminar Tarea" Then
                    btnModificar_Una.Enabled = False
                    btnModificarTodas.Enabled = False
                    btnAgregar.Enabled = False
                End If
            End If
            'vble_colaborador = dgvColaboradores.Item("COL_nombre_col", dgvColaboradores.SelectedRows(0).Index).Value
            vble_colaborador = dgvColaboradores.Item("COL_id_colaborador", dgvColaboradores.SelectedRows(0).Index).Value
            vble_fecha = dtpFecha.Text
            Dim datagridtarea = (From o In datavistas.Vista_Tarea_x_Colaborador
                               Select o.TAR_id_tarea, o.TAR_detalle_tarea, o.TAR_tiempo_estimado, o.TAR_tiempo_real,
                               o.TAR_observaciones, o.ORT_id_orden_trabajo, o.ORT_numero_ot, o.TAR_fecha, o.TAR_carga_horaria, o.TAR_hora_fin, o.Expr1, o.COL_nombre_col, o.TAR_entrada, o.TAR_salida
                               Where Expr1 = vble_colaborador And TAR_fecha = vble_fecha)
            mostrargrillaobligaciones(datagridtarea)

            If dgvTarea_x_Colaborador.Rows.Count = 0 Then
                If Me.Text = "Modificar Tarea" Then
                    MsgBox("No se le ha asignado ninguna tarea", MsgBoxStyle.Information, "Sin tarea")
                    btnModificar_Una.Enabled = False
                    btnModificarTodas.Enabled = False
                    btnAgregar.Enabled = False
                    Exit Sub

                ElseIf Me.Text = "Eliminar Tarea" Then
                    MsgBox("No tiene tareas asignadas para eliminar", MsgBoxStyle.Information, "Listado de tareas")
                    Label6.Text = dgvTarea_x_Colaborador.Rows.Count
                    btnModificar_Una.Enabled = False
                    btnModificarTodas.Enabled = False
                    btnAgregar.Enabled = False
                    Exit Sub

                ElseIf frm_Tarea.Text = "Ver Tarea" Then
                    btnModificar_Una.Enabled = False
                    btnModificarTodas.Enabled = False
                    btnAgregar.Enabled = False
                End If
            End If
        Catch
        End Try
        SumatoriaTiempos()
    End Sub

    Public Sub SumatoriaTiempos()
        Try
            'Declarar variable que acumulará la sumatoria de las celdas
            Dim Sumatoria As Integer = 0
            'Recorrer las filas del objeto de tipo DataGridView
            For Each row As DataGridViewRow In dgvTarea_x_Colaborador.Rows
                'Acumular valores
                Sumatoria += Convert.ToInt32(row.Cells("TAR_tiempo_real").Value)
            Next
            Label35.Text = Sumatoria
            Label1.Text = dgvTarea_x_Colaborador.Rows.Count

            Dim SumatoriaEstimado As Integer = 0
            For Each estimado As DataGridViewRow In dgvTarea_x_Colaborador.Rows
                SumatoriaEstimado += Convert.ToInt32(estimado.Cells("TAR_tiempo_estimado").Value)
            Next
            Label8.Text = SumatoriaEstimado
        Catch ex As Exception
        End Try
    End Sub

    Public Sub mostrargrillaobligaciones(ByVal datasource As System.Linq.IQueryable)
        dgvTarea_x_Colaborador.AutoGenerateColumns = False
        dgvTarea_x_Colaborador.Columns.Clear()

        dgvTarea_x_Colaborador.Columns.Add("TAR_id_tarea", "id_tarea")
        dgvTarea_x_Colaborador.Columns.Add("TAR_detalle_tarea", "Tarea")
        dgvTarea_x_Colaborador.Columns.Add("TAR_tiempo_estimado", "Tiempo Estimado")
        dgvTarea_x_Colaborador.Columns.Add("TAR_tiempo_real", "Tiempo Real")
        dgvTarea_x_Colaborador.Columns.Add("TAR_observaciones", "Observaciones")
        dgvTarea_x_Colaborador.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo")
        dgvTarea_x_Colaborador.Columns.Add("ORT_numero_ot", "Número de orden")
        dgvTarea_x_Colaborador.Columns.Add("TAR_fecha", "Fecha")
        dgvTarea_x_Colaborador.Columns.Add("TAR_carga_horaria", "Carga Horaria")
        dgvTarea_x_Colaborador.Columns.Add("TAR_hora_fin", "Hora de finalización")
        dgvTarea_x_Colaborador.Columns.Add("Expr1", "id_colaborador")
        dgvTarea_x_Colaborador.Columns.Add("COL_nombre_col", "Colaborador")
        dgvTarea_x_Colaborador.Columns.Add("TAR_entrada", "Entrada")
        dgvTarea_x_Colaborador.Columns.Add("TAR_salida", "Salida")

        dgvTarea_x_Colaborador.Columns(0).DataPropertyName = "TAR_id_tarea"
        dgvTarea_x_Colaborador.Columns(0).Visible = False
        dgvTarea_x_Colaborador.Columns(1).DataPropertyName = "TAR_detalle_tarea"
        dgvTarea_x_Colaborador.Columns(1).Width = 200
        dgvTarea_x_Colaborador.Columns(2).DataPropertyName = "TAR_tiempo_estimado"
        dgvTarea_x_Colaborador.Columns(2).Width = 60
        dgvTarea_x_Colaborador.Columns(3).DataPropertyName = "TAR_tiempo_real"
        dgvTarea_x_Colaborador.Columns(3).Width = 60
        dgvTarea_x_Colaborador.Columns(4).DataPropertyName = "TAR_observaciones"
        dgvTarea_x_Colaborador.Columns(5).DataPropertyName = "ORT_id_orden_trabajo"
        dgvTarea_x_Colaborador.Columns(5).Visible = False
        dgvTarea_x_Colaborador.Columns(6).DataPropertyName = "ORT_numero_ot"
        ' dgvTarea_x_Colaborador.Columns(6).Visible = False
        dgvTarea_x_Colaborador.Columns(7).DataPropertyName = "TAR_fecha"
        dgvTarea_x_Colaborador.Columns(7).Visible = False
        dgvTarea_x_Colaborador.Columns(8).DataPropertyName = "TAR_carga_horaria"
        dgvTarea_x_Colaborador.Columns(8).Visible = False
        dgvTarea_x_Colaborador.Columns(9).DataPropertyName = "TAR_hora_fin"
        'dgvTarea_x_Colaborador.Columns(9).Width = 60
        dgvTarea_x_Colaborador.Columns(10).DataPropertyName = "Expr1"
        dgvTarea_x_Colaborador.Columns(10).Visible = False
        dgvTarea_x_Colaborador.Columns(11).DataPropertyName = "COL_nombre_col"
        dgvTarea_x_Colaborador.Columns(11).Visible = False
        dgvTarea_x_Colaborador.Columns(12).DataPropertyName = "TAR_entrada"
        dgvTarea_x_Colaborador.Columns(12).Visible = False
        dgvTarea_x_Colaborador.Columns(13).DataPropertyName = "TAR_salida"
        dgvTarea_x_Colaborador.Columns(13).Visible = False

        dgvTarea_x_Colaborador.DataSource = datasource
        dgvTarea_x_Colaborador.ClearSelection()
    End Sub
End Class