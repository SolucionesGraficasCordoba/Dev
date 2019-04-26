Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_Listado_Empaque
    Dim datacontext As New DataS_Interno
    Dim datacontextvistas As New DataS_Interno_Vistas

    Dim fuente As iTextSharp.text.pdf.BaseFont = FontFactory.GetFont(FontFactory.HELVETICA).BaseFont

    Public Sub frm_Listado_Despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargargrillaremitos()
        armargrilla_planificacion()
        rbt_entrega.Checked = True
        txt_buscar.Enabled = False
    End Sub
    Sub cargargrillaremitos()
        'dgv_remitos.Columns.Clear()
        'dgv_remitos.AutoGenerateColumns = False

        'Dim chofer As New DataGridViewComboBoxColumn
        'chofer.HeaderText = "Chofer"
        'chofer.Name = "DES_chofer"

        ''LISTA DE CHOFERES. OJO! TIENE QUE COINCIDIR CON LA LISTA DEL COMBOBOX DEL FRM_DESPACHO
        'chofer.Items.Add("Seleccionar")
        'chofer.Items.Add("Javier Perea")
        'chofer.Items.Add("Walter Farías")
        'chofer.Items.Add("Laureano")
        'chofer.Items.Add("Guillermo Akerman")
        'chofer.Items.Add("Sebastián Agote")
        'chofer.Items.Add("Marcelo Domínguez")
        'chofer.Items.Add("Tercero")
        'chofer.Items.Add("Retira de planta")
        'chofer.Items.Add("Retira de central")
        'chofer.Items.Add("Instalaciones")

        'dgv_remitos.Columns.Add("DES_nro_despacho", "Despacho N°")
        'dgv_remitos.Columns.Add("DES_nro_remito", "Remito N°")
        'dgv_remitos.Columns.Add("DES_fecha_salida", "Salida")
        'dgv_remitos.Columns.Add(chofer)

        'dgv_remitos.Columns("DES_nro_despacho").DataPropertyName = "DES_nro_despacho"
        'dgv_remitos.Columns("DES_nro_remito").DataPropertyName = "DES_nro_remito"
        'dgv_remitos.Columns("DES_fecha_salida").DataPropertyName = "DES_fecha_salida"
        'dgv_remitos.Columns("DES_chofer").DataPropertyName = "DES_chofer"

        'Dim cargarremitos = (From c In datacontext.DESPACHO
        '                     Where c.DES_fecha_salida.Value.Date = dtp_fecha_salida.Text
        '                     Order By c.DES_nro_despacho
        '                     Select New clase_remitos(c.DES_nro_remito, c.DES_fecha_salida, c.DES_chofer, c.DES_nro_despacho)).Distinct

        'dgv_remitos.DataSource = cargarremitos
        'dgv_remitos.Sort(dgv_remitos.Columns("DES_nro_despacho"), SortOrder.Ascending)

        'dgv_remitos.Columns("DES_nro_despacho").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'dgv_remitos.Columns("DES_nro_remito").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'dgv_remitos.Columns("DES_fecha_salida").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'dgv_remitos.Columns("DES_chofer").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        'habilitar_edicion()
    End Sub

    Private Sub dgv_remitos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'cargargrilla_odtxrem()
    End Sub

    Sub armargrilla_planificacion()
        dgv_planificacion.AutoGenerateColumns = False
        dgv_planificacion.Columns.Clear()

        Dim estados As New DataGridViewComboBoxColumn
        estados.HeaderText = "Estado"
        estados.Name = "DES_EMB_estado"

        ''LISTA DE CHOFERES. OJO! TIENE QUE COINCIDIR CON LA LISTA DEL COMBOBOX DEL FRM_DESPACHO
        estados.Items.Add("PLANIFICADO")
        estados.Items.Add("IMPRESION")
        estados.Items.Add("TERMINACION")
        estados.Items.Add("TERCERO")
        estados.Items.Add("ENTREGADO")
        

        dgv_planificacion.Columns.Add("DES_Id", "DES_Id")
        dgv_planificacion.Columns("DES_Id").Visible = False
        dgv_planificacion.Columns.Add("ORT_id_orden_trabajo", "Id_Odt")
        dgv_planificacion.Columns("ORT_id_orden_trabajo").Visible = False
        dgv_planificacion.Columns.Add("ORT_numero_ot", "Odt")
        dgv_planificacion.Columns.Add("DES_EMB_bultos", "Bultos")
        dgv_planificacion.Columns.Add(estados)
        dgv_planificacion.Columns.Add("DES_EMB_fecha_estado", "Fecha estado")
        dgv_planificacion.Columns.Add("DES_EMB_observaciones", "Observaciones de empaque")
        dgv_planificacion.Columns.Add("CLI_razon_social", "Cliente")
        dgv_planificacion.Columns.Add("ORT_observaciones_ot", "Observaciones Odt")


        dgv_planificacion.Columns("DES_Id").DataPropertyName = "des_id"
        dgv_planificacion.Columns("ORT_id_orden_trabajo").DataPropertyName = "ORT_id_orden_trabajo"
        dgv_planificacion.Columns("ORT_numero_ot").DataPropertyName = "ORT_numero_ot"
        dgv_planificacion.Columns("DES_EMB_bultos").DataPropertyName = "DES_EMB_bultos"
        dgv_planificacion.Columns("DES_EMB_estado").DataPropertyName = "DES_EMB_estado"
        dgv_planificacion.Columns("DES_EMB_fecha_estado").DataPropertyName = "DES_EMB_fecha_estado"
        dgv_planificacion.Columns("DES_EMB_observaciones").DataPropertyName = "DES_EMB_observaciones"
        dgv_planificacion.Columns("CLI_razon_social").DataPropertyName = "CLI_razon_social"
        dgv_planificacion.Columns("ORT_observaciones_ot").DataPropertyName = "ORT_observaciones_ot"


        dgv_planificacion.Columns("ORT_numero_ot").ReadOnly = True
        dgv_planificacion.Columns("CLI_razon_social").ReadOnly = True
        dgv_planificacion.Columns("ORT_observaciones_ot").ReadOnly = True

        Dim cargar_planificacion = (From p In datacontextvistas.Vista_Despacho_Orden_Trabajo
                                    Where p.DES_EMB_fecha_estado.Value.Date = dtp_fecha_estado.Text
                                    Select New clase_emb_planif(p.DES_id, p.ORT_id_orden_trabajo,
                                    p.ORT_numero_ot, p.DES_EMB_bultos, p.DES_EMB_estado,
                                    p.DES_EMB_observaciones, p.DES_EMB_fecha_estado,
                                    p.CLI_razon_social, p.ORT_observaciones_ot))



        dgv_planificacion.DataSource = cargar_planificacion

        'If btn_modificar.Visible = True Then
        '    dgv_planificacion.Columns("DES_fecha_entrega").ReadOnly = False
        '    dgv_planificacion.Columns("DES_observaciones").ReadOnly = False
        'Else
        '    dgv_planificacion.Columns("DES_fecha_entrega").ReadOnly = True
        '    dgv_planificacion.Columns("DES_observaciones").ReadOnly = True
        'End If
    End Sub
    Sub cargargrilla_odtxrem()
        'Dim buscar As String

        'Try
        '    If btn_modificar.Visible = True Then
        '        buscar = dgv_remitos.Item("DES_nro_despacho", dgv_remitos.CurrentRow.Index).Value
        '    Else
        '        buscar = dgv_remitos.Item("DES_nro_despacho", dgv_remitos.SelectedRows(0).Index).Value
        '    End If

        '    'SE LLAMA A UNA CLASE YA QUE USANDO EL DATASOURCE NORMAL NO SE PUEDEN EDITAR LAS FILAS DEL DATAGRID.
        '    'POR LO QUE SE CREA UNA CLASE CON LAS PROPIEDADES Y SE USA LA CLASE COMO DATASOURCE, LO QEU SI PERMITE EDITAR LAS FILAS.
        '    Dim odtxremito = (From o In datacontextvistas.Vista_Despacho_Orden_Trabajo
        '                      Where o.DES_nro_despacho = buscar
        '                      Select New clase_odtxrem(o.ORT_id_orden_trabajo, o.DES_nro_remito, o.DES_fecha_entrega, o.DES_observaciones,
        '                      o.ORT_numero_ot, o.ORT_observaciones_ot, o.CLI_razon_social, o.DES_id, o.DES_nro_despacho))

        '    dgv_orden_x_remito.DataSource = odtxremito
        '    dgv_orden_x_remito.ClearSelection()
        'Catch ex As Exception
        'End Try

    End Sub


    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Try
            If dgv_planificacion.SelectedRows.Count > 0 Then
                Dim eliminar = (From C In datacontext.DESPACHO Where C.DES_id = CInt(dgv_planificacion.Item("DES_id", dgv_planificacion.SelectedRows(0).Index).Value)).ToList()(0)
                Select Case MsgBox("Se desviculará la orden del remito, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar colaborador")
                    Case MsgBoxResult.Yes
                        datacontext.DESPACHO.DeleteOnSubmit(eliminar)
                        datacontext.SubmitChanges()
                        MsgBox("La orden ha sido desvinculada")
                        cargargrilla_odtxrem()
                        cargargrillaremitos()
                End Select
            Else
                MsgBox("Debe seleccionar una orden")
            End If
        Catch ex As Exception
            MsgBox("La orden no fue desvinculada")
        End Try
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        'Try
        '    Dim Actualizarremitocount = (From P In datacontext.DESPACHO Where P.DES_nro_despacho = CInt(dgv_remitos.Item("DES_nro_despacho", dgv_remitos.CurrentRow.Index).Value)).Count
        '    For i = 0 To Actualizarremitocount - 1
        '        Dim actualizarremito = (From P In datacontext.DESPACHO Where P.DES_nro_despacho = CInt(dgv_remitos.Item("DES_nro_despacho", dgv_remitos.CurrentRow.Index).Value)).ToList()(i)
        '        'actualizarremito.DES_nro_remito = dgv_remitos.Item("DES_nro_remito", dgv_remitos.CurrentRow.Index).Value
        '        'actualizarremito.DES_fecha_salida = CDate(dgv_remitos.Item("DES_fecha_salida", dgv_remitos.CurrentRow.Index).Value)
        '        'actualizarremito.DES_chofer = dgv_remitos.Item("DES_chofer", dgv_remitos.CurrentRow.Index).Value

        '        actualizarremito.DES_fecha_entrega = CDate(dgv_orden_x_remito.Item("DES_fecha_entrega", i).Value)
        '        actualizarremito.DES_observaciones = dgv_orden_x_remito.Item("DES_observaciones", i).Value

        '        datacontext.SubmitChanges()
        '    Next

        '    MsgBox("Los datos se han modificado correctamente")
        '    cargargrilla_odtxrem()
        '    cargargrillaremitos()

        'Catch ex As Exception
        '    MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Colaborador")
        '    cargargrilla_odtxrem()
        'End Try
    End Sub

    Private Sub btn_agregarodt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregarodt.Click
        'If dgv_remitos.SelectedCells.Count = 1 Then
        '    frm_Despacho.txt_numero_remito.Enabled = False
        '    frm_Despacho.Show()

        '    frm_Despacho.txt_numero_despacho.Text = dgv_remitos.Item("DES_nro_despacho", dgv_remitos.CurrentRow.Index).Value
        '    frm_Despacho.txt_numero_remito.Text = dgv_remitos.Item("DES_nro_remito", dgv_remitos.CurrentRow.Index).Value
        '    frm_Despacho.dtp_Fecha_salida.Value = CDate(dgv_remitos.Item("DES_fecha_salida", dgv_remitos.CurrentRow.Index).Value)
        '    frm_Despacho.dtp_Hora_salida.Value = CDate(dgv_remitos.Item("DES_fecha_salida", dgv_remitos.CurrentRow.Index).Value)
        '    frm_Despacho.cmb_chofer.Text = dgv_remitos.Item("DES_chofer", dgv_remitos.CurrentRow.Index).Value



        'End If
    End Sub

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        'If rbt_orden.Checked = True Or rbt_despacho.Checked = True Then
        '    Dim buscar As String
        '    buscar = "*" & txt_buscar.Text & "*"

        '    If rbt_orden.Checked = True Then
        '        Dim buscaremito = (From br In datacontext.DESPACHO
        '                           Where br.DES_nro_remito Like buscar.ToString
        '                           Select New clase_remitos(br.DES_nro_remito, br.DES_fecha_salida, br.DES_chofer, br.DES_nro_despacho)).Distinct
        '        dgv_remitos.DataSource = buscaremito
        '    Else
        '        Dim buscaremito = (From br In datacontext.DESPACHO
        '                           Where br.DES_nro_despacho Like buscar.ToString
        '                           Select New clase_remitos(br.DES_nro_remito, br.DES_fecha_salida, br.DES_chofer, br.DES_nro_despacho)).Distinct
        '        dgv_remitos.DataSource = buscaremito
        '    End If

        '    dgv_orden_x_remito.Rows.Clear()
        '    habilitar_edicion()
        'End If
    End Sub

    Private Sub dtp_fecha_salida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fecha_estado.ValueChanged
        'If rbt_entrega.Checked = True Then
        '    Dim buscaremito = (From br In datacontext.DESPACHO
        '                       Where br.DES_fecha_salida.Value.Date = dtp_fecha_salida.Text
        '                       Select New clase_remitos(br.DES_nro_remito, br.DES_fecha_salida, br.DES_chofer, br.DES_nro_despacho)).Distinct
        '    dgv_remitos.DataSource = buscaremito
        '    habilitar_edicion()
        'End If
    End Sub
    Sub habilitar_edicion()
        'dgv_remitos.ClearSelection()
        'dgv_remitos.Columns("DES_nro_despacho").ReadOnly = True

        'If btn_modificar.Visible = True Then
        '    dgv_remitos.Columns("DES_nro_remito").ReadOnly = False
        '    dgv_remitos.Columns("DES_fecha_salida").ReadOnly = False
        '    dgv_remitos.Columns("DES_chofer").ReadOnly = False
        'Else
        '    dgv_remitos.Columns("DES_nro_remito").ReadOnly = True
        '    dgv_remitos.Columns("DES_fecha_salida").ReadOnly = True
        '    dgv_remitos.Columns("DES_chofer").ReadOnly = True
        'End If
    End Sub

    Private Sub rbt_remito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_orden.CheckedChanged
        If rbt_orden.Checked = True Then
            txt_buscar.Enabled = True
        Else
            txt_buscar.Enabled = False
        End If
    End Sub

    Private Sub rbt_despacho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_despacho.CheckedChanged
        If rbt_despacho.Checked = True Then
            txt_buscar.Enabled = True
        Else
            txt_buscar.Enabled = False
        End If
    End Sub

    Private Sub rbt_entrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_entrega.CheckedChanged
        If rbt_entrega.Checked = True Then
            dtp_fecha_estado.Enabled = True
        Else
            dtp_fecha_estado.Enabled = False
        End If
    End Sub

    Private Sub btn_generar_informe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_informe.Click
        'Try
        '    'intentar generar el documento
        '    Dim doc As New Document(PageSize.A3.Rotate, 5, 5, 5, 5)
        '    'path que guarda el reporte en el escritorio de windows (desktop)
        '    Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Remitos_diarios.pdf"
        '    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        '    PdfWriter.GetInstance(doc, file)
        '    doc.Open()

        '    'se crea un objeto PDFTable con el numero de columnas  del datagridview
        '    Dim datatableencabezado As New PdfPTable(4)
        '    Dim datatablecuerpo As New PdfPTable(4)

        '    datatableencabezado.WidthPercentage = 100
        '    datatableencabezado.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        '    datatableencabezado.HeaderRows = 0
        '    datatableencabezado.DefaultCell.BorderWidth = 1

        '    datatablecuerpo.WidthPercentage = 100
        '    datatablecuerpo.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        '    datatablecuerpo.HeaderRows = 1
        '    datatablecuerpo.DefaultCell.BorderWidth = 0

        '    'se capturan los nombres de las columnas del datagridview de las ordenes por remito
        '    For Y As Integer = 0 To dgv_planificacion.ColumnCount - 1
        '        If dgv_planificacion.Columns(Y).Visible = True And dgv_planificacion.Columns(Y).DataPropertyName <> "ORT_observaciones_ot" Then
        '            datatablecuerpo.AddCell(dgv_planificacion.Columns(Y).HeaderText)
        '        End If
        '    Next

        '    'SE ARMA EL ENCABEZADO COMO TABLA
        '    For i = 0 To dgv_remitos.Rows.Count - 1
        '        dgv_remitos.Rows(i).Selected = True
        '        dgv_remitos_CellClick(0, Nothing)

        '        For Z As Integer = 0 To dgv_remitos.ColumnCount - 1
        '            If dgv_remitos.Columns(Z).Visible = True Then
        '                Try
        '                    datatableencabezado.AddCell(dgv_remitos.Columns(Z).HeaderText + ": " + dgv_remitos(Z, i).Value.ToString())
        '                Catch ex As Exception
        '                    datatableencabezado.AddCell(" ")
        '                End Try
        '            End If
        '        Next
        '        datatableencabezado.CompleteRow()
        '        doc.Add(datatableencabezado)
        '        datatableencabezado.DeleteBodyRows()

        '        'se generan las columnas del datagridview de las ordenes por remito

        '        For Y As Integer = 0 To dgv_planificacion.RowCount - 1
        '            For Z As Integer = 0 To dgv_planificacion.ColumnCount - 1
        '                If dgv_planificacion.Columns(Z).Visible = True And dgv_planificacion.Columns(Z).DataPropertyName <> "ORT_observaciones_ot" Then
        '                    Try
        '                        datatablecuerpo.AddCell(dgv_planificacion(Z, Y).Value.ToString())
        '                    Catch ex As Exception
        '                        datatablecuerpo.AddCell(" ")
        '                    End Try
        '                End If
        '            Next
        '            datatablecuerpo.CompleteRow()
        '        Next

        '        doc.Add(datatablecuerpo)
        '        datatablecuerpo.DeleteBodyRows()

        '    Next
        '    doc.Close()
        '    Process.Start(filename)

        'Catch ex As Exception
        '    'si el mensaje es fallido mostrar msgbox
        '    MessageBox.Show("No se puede generar el pdf, cierre el pdf anterior y vuleva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class

'CLASE PARA PODER MODIFICAR DATOS DESDE LA GRILLA CARGADA CON LINQ
Public Class clase_emb_planif

    Public _DES_id
    Public _ORT_id_orden_trabajo
    Public _ORT_numero_ot
    Public _DES_EMB_bultos
    Public _DES_EMB_estado
    Public _DES_EMB_observaciones
    Public _DES_EMB_fecha_estado
    Public _CLI_razon_social
    Public _ORT_observaciones_ot



    Sub New(ByVal des_id As Integer, ByVal ot_id As Integer, ByVal ot_nro As String, ByVal bultos As String,
            ByVal estado As String, ByVal obs As String, ByVal fecha_estado As Date,
            ByVal cliente As String, ByVal ot_obs As String)

        _DES_id = des_id
        _ORT_id_orden_trabajo = ot_id
        _ORT_numero_ot = ot_nro
        _DES_EMB_bultos = bultos
        _DES_EMB_estado = estado
        _DES_EMB_observaciones = obs
        _DES_EMB_fecha_estado = fecha_estado
        _CLI_razon_social = cliente
        _ORT_observaciones_ot = ot_obs

    End Sub
    Property des_id() As String
        Get
            Return _DES_id
        End Get
        Set(ByVal value As String)
            Me._DES_id = value
        End Set
    End Property
    Property ORT_id_orden_trabajo() As String
        Get
            Return _ORT_id_orden_trabajo
        End Get
        Set(ByVal value As String)
            Me._ORT_id_orden_trabajo = value
        End Set
    End Property
    Property ORT_numero_ot() As String
        Get
            Return _ORT_numero_ot
        End Get
        Set(ByVal value As String)
            Me._ORT_numero_ot = value
        End Set
    End Property
    Property DES_EMB_bultos() As String
        Get
            Return _DES_EMB_bultos
        End Get
        Set(ByVal value As String)
            Me._DES_EMB_bultos = value
        End Set
    End Property
    Property DES_EMB_estado() As String
        Get
            Return _DES_EMB_estado
        End Get
        Set(ByVal value As String)
            Me._DES_EMB_estado = value
        End Set
    End Property
    Property DES_EMB_observaciones() As String
        Get
            Return _DES_EMB_observaciones
        End Get
        Set(ByVal value As String)
            Me._DES_EMB_observaciones = value
        End Set
    End Property
    Property DES_EMB_fecha_estado() As String
        Get
            Return _DES_EMB_fecha_estado
        End Get
        Set(ByVal value As String)
            Me._DES_EMB_fecha_estado = value
        End Set
    End Property
    Property CLI_razon_social() As String
        Get
            Return _CLI_razon_social
        End Get
        Set(ByVal value As String)
            Me._CLI_razon_social = value
        End Set
    End Property
    Property ORT_observaciones_ot() As String
        Get
            Return _ORT_observaciones_ot
        End Get
        Set(ByVal value As String)
            Me._ORT_observaciones_ot = value
        End Set
    End Property
End Class

'Public Class clase_remitos

'    Public _DES_nro_remito
'    Public _DES_fecha_salida
'    Public _DES_chofer
'    Public _DES_nro_despacho

'    Sub New(ByVal nro_remito As String, ByVal fecha_salida As Date, ByVal chofer As String, ByVal nro_despacho As String)
'        _DES_nro_remito = nro_remito
'        _DES_fecha_salida = fecha_salida
'        _DES_chofer = chofer
'        _DES_nro_despacho = nro_despacho
'    End Sub


'    Property DES_nro_remito() As String
'        Get
'            Return _DES_nro_remito
'        End Get
'        Set(ByVal value As String)
'            Me._DES_nro_remito = value
'        End Set
'    End Property

'    Property DES_fecha_salida() As String
'        Get
'            Return _DES_fecha_salida
'        End Get
'        Set(ByVal value As String)
'            Me._DES_fecha_salida = value
'        End Set
'    End Property

'    Property DES_chofer() As String
'        Get
'            Return _DES_chofer
'        End Get
'        Set(ByVal value As String)
'            Me._DES_chofer = value
'        End Set
'    End Property

'    Property DES_nro_despacho() As String
'        Get
'            Return _DES_nro_despacho
'        End Get
'        Set(ByVal value As String)
'            Me._DES_nro_despacho = value
'        End Set
'    End Property
'End Class