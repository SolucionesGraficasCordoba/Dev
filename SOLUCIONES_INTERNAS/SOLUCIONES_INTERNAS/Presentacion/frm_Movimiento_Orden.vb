Imports System.Drawing.Printing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_Movimiento_Orden
    Dim datacontext As New DataS_Interno
    Dim datavistas As New DataS_Interno_Vistas

    Private Sub frm_Movimiento_Orden_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        CargaMovimientoOrden()
    End Sub

    'CARGA GRILLA ORDEN TRABAJO
    Public Sub CargaMovimientoOrden()
        Dim MovimientoOrden = (From mo In datavistas.Movimiento_Orden
                               Select
                               mo.ORT_id_orden_trabajo,
                               mo.ORT_numero_ot,
                               mo.TAR_id_tarea,
                               mo.TAR_detalle_tarea,
                               mo.TAR_tiempo_real,
                              mo.TAR_fecha,
                              mo.PIE_id_pieza,
                              mo.PIE_nombre_pie,
                              mo.COL_id_colaborador,
                              mo.COL_nombre_col,
                              mo.SEC_id_sector,
                              mo.SEC_nombre_sector
                              Order By TAR_fecha Descending)
        dgvMovimiento_Orden.DataSource = MovimientoOrden
        dgvMovimiento_Orden.ClearSelection()
    End Sub

    'ARMA GRILLA ORDEN
    Private Sub armargrilla()
        dgvMovimiento_Orden.Enabled = True
        dgvMovimiento_Orden.AutoGenerateColumns = False
        dgvMovimiento_Orden.Columns.Clear()

        dgvMovimiento_Orden.Columns.Add("ORT_id_orden_trabajo", "id_orden_trabajo")
        dgvMovimiento_Orden.Columns.Add("ORT_numero_ot", "Número de Orden")
        dgvMovimiento_Orden.Columns.Add("TAR_id_tarea", "id_tarea")
        dgvMovimiento_Orden.Columns.Add("TAR_detalle_tarea", "Tarea")
        dgvMovimiento_Orden.Columns.Add("TAR_tiempo_real", "Tiempo Real")
        dgvMovimiento_Orden.Columns.Add("TAR_fecha", "Fecha Tarea")
        dgvMovimiento_Orden.Columns.Add("PIE_id_pieza", "id_pieza")
        dgvMovimiento_Orden.Columns.Add("PIE_nombre_pie", "Pieza")
        dgvMovimiento_Orden.Columns.Add("COL_id_colaborador", "id_colaborador")
        dgvMovimiento_Orden.Columns.Add("COL_nombre_col", "Colaborador")
        dgvMovimiento_Orden.Columns.Add("SEC_id_sector", "id_sector")
        dgvMovimiento_Orden.Columns.Add("SEC_nombre_sector", "Sector")

        dgvMovimiento_Orden.Columns(0).DataPropertyName = "ORT_id_orden_trabajo"
        dgvMovimiento_Orden.Columns(0).Visible = False
        dgvMovimiento_Orden.Columns(1).DataPropertyName = "ORT_numero_ot"
        dgvMovimiento_Orden.Columns(2).DataPropertyName = "TAR_id_tarea"
        dgvMovimiento_Orden.Columns(2).Visible = False
        dgvMovimiento_Orden.Columns(3).DataPropertyName = "TAR_detalle_tarea"
        dgvMovimiento_Orden.Columns(4).DataPropertyName = "TAR_tiempo_real"
        dgvMovimiento_Orden.Columns(5).DataPropertyName = "TAR_fecha"
        dgvMovimiento_Orden.Columns(6).DataPropertyName = "PIE_id_pieza"
        dgvMovimiento_Orden.Columns(6).Visible = False
        dgvMovimiento_Orden.Columns(7).DataPropertyName = "PIE_nombre_pie"
        dgvMovimiento_Orden.Columns(8).DataPropertyName = "COL_id_colaborador"
        dgvMovimiento_Orden.Columns(8).Visible = False
        dgvMovimiento_Orden.Columns(9).DataPropertyName = "COL_nombre_col"
        dgvMovimiento_Orden.Columns(9).Visible = False
        dgvMovimiento_Orden.Columns(10).DataPropertyName = "SEC_id_sector"
        dgvMovimiento_Orden.Columns(10).Visible = False
        dgvMovimiento_Orden.Columns(11).DataPropertyName = "SEC_nombre_sector"
    End Sub

    Private Sub txt_Buscar_orden_trabajo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Buscar_orden_trabajo.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = "*" & Me.txt_Buscar_orden_trabajo.Text & "*"
        Dim MovimientoOrden = (From mo In datavistas.Movimiento_Orden
                               Select
                               mo.ORT_id_orden_trabajo,
                               mo.ORT_numero_ot,
                               mo.TAR_id_tarea,
                               mo.TAR_detalle_tarea,
                               mo.TAR_tiempo_real,
                              mo.TAR_fecha,
                              mo.PIE_id_pieza,
                              mo.PIE_nombre_pie,
                              mo.COL_id_colaborador,
                              mo.COL_nombre_col,
                              mo.SEC_id_sector,
                              mo.SEC_nombre_sector
                             Where ORT_numero_ot Like buscar.ToString
                             Order By TAR_fecha Descending)
        dgvMovimiento_Orden.DataSource = MovimientoOrden
        dgvMovimiento_Orden.ClearSelection()
    End Sub

    Private Sub btnExportarPDF_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarPDF.Click

    End Sub
End Class

'Punchado De Chapas , Carga Papel Y Pone A Punto Maquina