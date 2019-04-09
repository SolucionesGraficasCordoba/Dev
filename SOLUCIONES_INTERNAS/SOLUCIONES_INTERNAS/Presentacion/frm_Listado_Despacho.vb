Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frm_Listado_Despacho
    Dim datacontext As New DataS_Interno
    Dim datacontextvistas As New DataS_Interno_Vistas

    Dim fuente As iTextSharp.text.pdf.BaseFont = FontFactory.GetFont(FontFactory.HELVETICA).BaseFont

    Public Sub frm_Listado_Despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargargrillaremitos()
        armargrilla_odtxrem()
        rbt_entrega.Checked = True
        txt_buscar.Enabled = False
    End Sub
    Sub cargargrillaremitos()
        dgv_remitos.Columns.Clear()
        dgv_remitos.AutoGenerateColumns = False

        Dim chofer As New DataGridViewComboBoxColumn
        chofer.HeaderText = "Chofer"
        chofer.Name = "DES_chofer"

        'LISTA DE CHOFERES. OJO! TIENE QUE COINCIDIR CON LA LISTA DEL COMBOBOX DEL FRM_DESPACHO
        chofer.Items.Add("Seleccionar")
        chofer.Items.Add("Javier Perea")
        chofer.Items.Add("Walter Farías")
        chofer.Items.Add("Laureano")
        chofer.Items.Add("Guillermo Akerman")
        chofer.Items.Add("Sebastián Agote")
        chofer.Items.Add("Marcelo Domínguez")
        chofer.Items.Add("Tercero")
        chofer.Items.Add("Retira de planta")
        chofer.Items.Add("Retira de central")
        chofer.Items.Add("Instalaciones")

        dgv_remitos.Columns.Add("DES_campo_1", "Despacho número")
        dgv_remitos.Columns.Add("DES_nro_remito", "Remito")
        dgv_remitos.Columns.Add("DES_fecha_salida", "Fecha de Salida")
        dgv_remitos.Columns.Add(chofer)

        dgv_remitos.Columns("DES_campo_1").DataPropertyName = "DES_campo_1"
        dgv_remitos.Columns("DES_nro_remito").DataPropertyName = "DES_nro_remito"
        dgv_remitos.Columns("DES_fecha_salida").DataPropertyName = "DES_fecha_salida"
        dgv_remitos.Columns("DES_chofer").DataPropertyName = "DES_chofer"

        Dim cargarremitos = (From c In datacontext.DESPACHO
                             Where c.DES_fecha_salida.Value.Date = dtp_fecha_salida.Text
                             Order By c.DES_campo_1
                             Select New clase_remitos(c.DES_nro_remito, c.DES_fecha_salida, c.DES_chofer, c.DES_campo_1)).Distinct

        dgv_remitos.DataSource = cargarremitos
        dgv_remitos.Sort(dgv_remitos.Columns("DES_campo_1"), SortOrder.Ascending)

        dgv_remitos.Columns("DES_campo_1").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv_remitos.Columns("DES_nro_remito").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv_remitos.Columns("DES_fecha_salida").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgv_remitos.Columns("DES_chofer").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        habilitar_edicion()
    End Sub

    Private Sub dgv_remitos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_remitos.CellClick
        cargargrilla_odtxrem()
    End Sub

    Sub armargrilla_odtxrem()
        dgv_orden_x_remito.AutoGenerateColumns = False
        dgv_orden_x_remito.Columns.Clear()

        dgv_orden_x_remito.Columns.Add("DES_Id", "DES_Id")
        dgv_orden_x_remito.Columns("DES_Id").Visible = False
        dgv_orden_x_remito.Columns.Add("ORT_id_orden_trabajo", "Id_Odt")
        dgv_orden_x_remito.Columns("ORT_id_orden_trabajo").Visible = False
        dgv_orden_x_remito.Columns.Add("ORT_numero_ot", "Odt")
        dgv_orden_x_remito.Columns.Add("DES_fecha_entrega", "Fecha Entrega Real")
        dgv_orden_x_remito.Columns.Add("DES_observaciones", "Observaciones Despacho")
        dgv_orden_x_remito.Columns.Add("ORT_observaciones_ot", "Observaciones Odt")
        dgv_orden_x_remito.Columns.Add("CLI_razon_social", "Cliente")

        dgv_orden_x_remito.Columns("DES_Id").DataPropertyName = "des_id"
        dgv_orden_x_remito.Columns("ORT_id_orden_trabajo").DataPropertyName = "ORT_id_orden_trabajo"
        dgv_orden_x_remito.Columns("ORT_numero_ot").DataPropertyName = "ORT_numero_ot"
        dgv_orden_x_remito.Columns("DES_fecha_entrega").DataPropertyName = "DES_fecha_entrega"
        dgv_orden_x_remito.Columns("DES_observaciones").DataPropertyName = "DES_observaciones"
        dgv_orden_x_remito.Columns("ORT_observaciones_ot").DataPropertyName = "ORT_observaciones_ot"
        dgv_orden_x_remito.Columns("CLI_razon_social").DataPropertyName = "CLI_razon_social"

        dgv_orden_x_remito.Columns("ORT_numero_ot").ReadOnly = True
        dgv_orden_x_remito.Columns("ORT_observaciones_ot").ReadOnly = True
        dgv_orden_x_remito.Columns("CLI_razon_social").ReadOnly = True

        If btn_modificar.Visible = True Then
            dgv_orden_x_remito.Columns("DES_fecha_entrega").ReadOnly = False
            dgv_orden_x_remito.Columns("DES_observaciones").ReadOnly = False
        Else
            dgv_orden_x_remito.Columns("DES_fecha_entrega").ReadOnly = True
            dgv_orden_x_remito.Columns("DES_observaciones").ReadOnly = True
        End If
    End Sub
    Sub cargargrilla_odtxrem()
        Dim buscar As String

        Try
            buscar = dgv_remitos.Item("DES_campo_1", dgv_remitos.CurrentRow.Index).Value

            'SE LLAMA A UNA CLASE YA QUE USANDO EL DATASOURCE NORMAL NO SE PUEDEN EDITAR LAS FILAS DEL DATAGRID.
            'POR LO QUE SE CREA UNA CLASE CON LAS PROPIEDADES Y SE USA LA CLASE COMO DATASOURCE, LO QEU SI PERMITE EDITAR LAS FILAS.
            Dim odtxremito = (From o In datacontextvistas.Vista_Despacho_Orden_Trabajo
                              Where o.DES_campo_1 = buscar
                              Select New clase_odtxrem(o.ORT_id_orden_trabajo, o.DES_nro_remito, o.DES_fecha_entrega, o.DES_observaciones,
                              o.ORT_numero_ot, o.ORT_observaciones_ot, o.CLI_razon_social, o.DES_id, o.DES_campo_1))

            dgv_orden_x_remito.DataSource = odtxremito
            dgv_orden_x_remito.ClearSelection()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Try
            If dgv_orden_x_remito.SelectedRows.Count > 0 Then
                Dim eliminar = (From C In datacontext.DESPACHO Where C.DES_id = CInt(dgv_orden_x_remito.Item("DES_id", dgv_orden_x_remito.SelectedRows(0).Index).Value)).ToList()(0)
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
        Try
            Dim Actualizarremitocount = (From P In datacontext.DESPACHO Where P.DES_campo_1 = CInt(dgv_remitos.Item("DES_campo_1", dgv_remitos.CurrentRow.Index).Value)).Count
            For i = 0 To Actualizarremitocount - 1
                Dim actualizarremito = (From P In datacontext.DESPACHO Where P.DES_campo_1 = CInt(dgv_remitos.Item("DES_campo_1", dgv_remitos.CurrentRow.Index).Value)).ToList()(i)
                actualizarremito.DES_nro_remito = dgv_remitos.Item("DES_nro_remito", dgv_remitos.CurrentRow.Index).Value
                actualizarremito.DES_fecha_salida = CDate(dgv_remitos.Item("DES_fecha_salida", dgv_remitos.CurrentRow.Index).Value)
                actualizarremito.DES_chofer = dgv_remitos.Item("DES_chofer", dgv_remitos.CurrentRow.Index).Value

                actualizarremito.DES_fecha_entrega = CDate(dgv_orden_x_remito.Item("DES_fecha_entrega", i).Value)
                actualizarremito.DES_observaciones = dgv_orden_x_remito.Item("DES_observaciones", i).Value

                datacontext.SubmitChanges()
            Next

            MsgBox("Los datos se han modificado correctamente")
            cargargrilla_odtxrem()
            cargargrillaremitos()

        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Colaborador")
            cargargrilla_odtxrem()
        End Try
    End Sub

    Private Sub btn_agregarodt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregarodt.Click
        If dgv_remitos.SelectedCells.Count = 1 Then
            frm_Despacho.txt_numero_remito.Enabled = False
            frm_Despacho.Show()

            frm_Despacho.txt_numero_despacho.Text = dgv_remitos.Item("DES_campo_1", dgv_remitos.CurrentRow.Index).Value
            frm_Despacho.txt_numero_remito.Text = dgv_remitos.Item("DES_nro_remito", dgv_remitos.CurrentRow.Index).Value
            frm_Despacho.dtp_Fecha_salida.Value = CDate(dgv_remitos.Item("DES_fecha_salida", dgv_remitos.CurrentRow.Index).Value)
            frm_Despacho.dtp_Hora_salida.Value = CDate(dgv_remitos.Item("DES_fecha_salida", dgv_remitos.CurrentRow.Index).Value)
            frm_Despacho.cmb_chofer.Text = dgv_remitos.Item("DES_chofer", dgv_remitos.CurrentRow.Index).Value



        End If
    End Sub

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        If rbt_remito.Checked = True Or rbt_despacho.Checked = True Then
            Dim buscar As String
            buscar = "*" & txt_buscar.Text & "*"

            If rbt_remito.Checked = True Then
                Dim buscaremito = (From br In datacontext.DESPACHO
                                   Where br.DES_nro_remito Like buscar.ToString
                                   Select New clase_remitos(br.DES_nro_remito, br.DES_fecha_salida, br.DES_chofer, br.DES_campo_1)).Distinct
                dgv_remitos.DataSource = buscaremito
            Else
                Dim buscaremito = (From br In datacontext.DESPACHO
                                   Where br.DES_campo_1 Like buscar.ToString
                                   Select New clase_remitos(br.DES_nro_remito, br.DES_fecha_salida, br.DES_chofer, br.DES_campo_1)).Distinct
                dgv_remitos.DataSource = buscaremito
            End If

            dgv_orden_x_remito.Rows.Clear()
            habilitar_edicion()
        End If
    End Sub

    Private Sub dtp_fecha_salida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_fecha_salida.ValueChanged
        If rbt_entrega.Checked = True Then
            Dim buscaremito = (From br In datacontext.DESPACHO
                               Where br.DES_fecha_salida.Value.Date = dtp_fecha_salida.Text
                               Select New clase_remitos(br.DES_nro_remito, br.DES_fecha_salida, br.DES_chofer, br.DES_campo_1)).Distinct
            dgv_remitos.DataSource = buscaremito
            habilitar_edicion()
        End If
    End Sub
    Sub habilitar_edicion()
        dgv_remitos.ClearSelection()
        dgv_remitos.Columns("DES_campo_1").ReadOnly = True

        If btn_modificar.Visible = True Then
            dgv_remitos.Columns("DES_nro_remito").ReadOnly = False
            dgv_remitos.Columns("DES_fecha_salida").ReadOnly = False
            dgv_remitos.Columns("DES_chofer").ReadOnly = False
        Else
            dgv_remitos.Columns("DES_nro_remito").ReadOnly = True
            dgv_remitos.Columns("DES_fecha_salida").ReadOnly = True
            dgv_remitos.Columns("DES_chofer").ReadOnly = True
        End If
    End Sub

    Private Sub rbt_remito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt_remito.CheckedChanged
        If rbt_remito.Checked = True Then
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
            dtp_fecha_salida.Enabled = True
        Else
            dtp_fecha_salida.Enabled = False
        End If
    End Sub

    Private Sub btn_generar_informe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_informe.Click
        'Try

        'intentar generar el documento
        Dim doc As New Document(PageSize.A4, 5, 5, 5, 5)
        'path que guarda el reporte en el escritorio de windows (desktop)
        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Remitos_diarios.pdf"
        Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        PdfWriter.GetInstance(doc, file)
        doc.Open()
        For i = 0 To dgv_remitos.Rows.Count - 1
            dgv_remitos.Rows(i).Selected = True
            dgv_remitos_CellClick(0, Nothing)

            Dim pdf_encabezado As New Paragraph("Despacho N°: " + CStr(dgv_remitos.Item("DES_campo_1", i).Value) _
                                            + "         Remito N°: " + CStr(dgv_remitos.Item("DES_nro_remito", i).Value) _
                                            + "         Salida " + CStr(dgv_remitos.Item("DES_fecha_salida", i).Value))
            doc.Add(pdf_encabezado)

            For j = 0 To dgv_orden_x_remito.RowCount - 1
                Dim pdf_ordenes As New Paragraph(CStr(dgv_orden_x_remito.Item("ORT_numero_ot", j).Value))
                doc.Add(pdf_ordenes)
                'pdf_informe_diario(doc, i)
            Next
        Next
        doc.Close()
        Process.Start(filename)
        ' Me.Close()
        'Catch ex As Exception
        '    'si el mensaje es fallido mostrar msgbox
        '    MessageBox.Show("No se puede generar el pdf, cierre el pdf anterior y vuleva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class

'CLASE PARA PODER MODIFICAR DATOS DESDE LA GRILLA CARGADA CON LINQ
Public Class clase_odtxrem
    Public _ORT_id_orden_trabajo
    Public _DES_nro_remito
    Public _DES_fecha_entrega
    Public _DES_observaciones
    Public _ORT_numero_ot
    Public _ORT_observaciones_ot
    Public _CLI_razon_social
    Public _DES_id
    Public _DES_campo_1

    Sub New(ByVal ot_id As Integer, ByVal remito As String, ByVal entrega As Date, ByVal obs As String, ByVal ot_nro As String,
            ByVal ot_obs As String, ByVal cliente As String, ByVal des_id As Integer, ByVal des_campo_1 As Integer)

        _ORT_id_orden_trabajo = ot_id
        _DES_nro_remito = remito
        _DES_fecha_entrega = entrega
        _DES_observaciones = obs
        _ORT_numero_ot = ot_nro
        _ORT_observaciones_ot = ot_obs
        _CLI_razon_social = cliente
        _DES_id = des_id
        _DES_campo_1 = des_campo_1
    End Sub

    Property ORT_id_orden_trabajo() As String
        Get
            Return _ORT_id_orden_trabajo
        End Get
        Set(ByVal value As String)
            Me._ORT_id_orden_trabajo = value
        End Set
    End Property
    Property DES_nro_remito() As String
        Get
            Return _DES_nro_remito
        End Get
        Set(ByVal value As String)
            Me._DES_nro_remito = value
        End Set
    End Property
    Property DES_fecha_entrega() As String
        Get
            Return _DES_fecha_entrega
        End Get
        Set(ByVal value As String)
            Me._DES_fecha_entrega = value
        End Set
    End Property
    Property DES_observaciones() As String
        Get
            Return _DES_observaciones
        End Get
        Set(ByVal value As String)
            Me._DES_observaciones = value
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
    Property ORT_observaciones_ot() As String
        Get
            Return _ORT_observaciones_ot
        End Get
        Set(ByVal value As String)
            Me._ORT_observaciones_ot = value
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
    Property des_id() As String
        Get
            Return _DES_id
        End Get
        Set(ByVal value As String)
            Me._DES_id = value
        End Set
    End Property
    Property des_campo_1() As String
        Get
            Return _DES_campo_1
        End Get
        Set(ByVal value As String)
            Me._DES_campo_1 = value
        End Set
    End Property
End Class

Public Class clase_remitos

    Public _DES_nro_remito
    Public _DES_fecha_salida
    Public _DES_chofer
    Public _DES_campo_1

    Sub New(ByVal nro_remito As String, ByVal fecha_salida As Date, ByVal chofer As String, ByVal nro_despacho As String)
        _DES_nro_remito = nro_remito
        _DES_fecha_salida = fecha_salida
        _DES_chofer = chofer
        _DES_campo_1 = nro_despacho
    End Sub


    Property DES_nro_remito() As String
        Get
            Return _DES_nro_remito
        End Get
        Set(ByVal value As String)
            Me._DES_nro_remito = value
        End Set
    End Property

    Property DES_fecha_salida() As String
        Get
            Return _DES_fecha_salida
        End Get
        Set(ByVal value As String)
            Me._DES_fecha_salida = value
        End Set
    End Property

    Property DES_chofer() As String
        Get
            Return _DES_chofer
        End Get
        Set(ByVal value As String)
            Me._DES_chofer = value
        End Set
    End Property

    Property DES_campo_1() As String
        Get
            Return _DES_campo_1
        End Get
        Set(ByVal value As String)
            Me._DES_campo_1 = value
        End Set
    End Property
End Class