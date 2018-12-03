Public Class frm_ingreso
    Dim datacontext As New DataS_Interno

    Private Sub frm_ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_usuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click

        ' DeshabilitarGeneral()
        ' HabilitarGeneral()

        'HABILITA SEGUN PERFIL USUARIO
        Try
            Dim Buscausuario = (From I In datacontext.USUARIO Where I.USU_usuario = (txt_usuario.Text) And I.USU_contraseña = (txt_contraseña.Text)).ToList()(0)

            Select Case Buscausuario.USU_perfil

                Case "ADMINISTRADOR"
                    'tiene habilitado todas las pestañas, las cuales se habilitan desde el Sub HabilitarGeneral()

                Case "GERENCIA"
                    'tiene habilitado todas las pestañas, las cuales se habilitan desde el Sub HabilitarGeneral()

                Case "SUPERVISOR"
                    Usuario(False, False, False, False)
                    Colaborador(False, False, False, False)
                    Vendedor(False, False, False, False)
                    Cliente(False, False, False, False)
                    Pieza(False, False, False, False)
                    Sector(False, False, False, False)
                    Tarea(True, True, True, False)
                    Producto(False, False, False, False, False, False, False)
                    Orden(True, True, True, False)
                    Retrabajo(False, False, False)
                    Etiquetas()
                    Estadistica(False, False, False, False, False)
                    CorreoElectronico()

                Case "COLABORADOR"
                    ' HabilitarGeneral()
            End Select

            'HABILITA SEGUN PERMISOS ESPECIALES
            Dim contadorpermisos As Integer = (From P In datacontext.PERMISO Where P.USU_id_usuario = Buscausuario.USU_id_usuario).Count
            If contadorpermisos > 0 Then

                Dim flaga = 0, flagb = 0, flagm = 0, flagc = 0, flagalta = 0, flagbaja = 0, flagconsprod = 0, flagconsmov = 0
                For i = 0 To contadorpermisos - 1
                    Dim permisos = (From A In datacontext.PERMISO Select A.PER_permiso, A.PER_abm, A.USU_id_usuario Where USU_id_usuario = Buscausuario.USU_id_usuario).ToList()(i)

                    Select Case permisos.PER_permiso

                        Case "USUARIO"
                            If permisos.PER_abm = "A" Then
                                Usuario(True, flagb, flagm, flagc)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Usuario(flaga, True, flagm, flagc)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "M" Then
                                Usuario(flaga, flagb, True, flagc)
                                flagm = 1
                            End If
                            If permisos.PER_abm = "C" Then
                                Usuario(flaga, flagb, flagm, True)
                                flagc = 1
                            End If

                            '-------------------------------------------------------
                        Case "COLABORADOR"
                            If permisos.PER_abm = "A" Then
                                Colaborador(True, flagb, flagm, flagc)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Colaborador(flaga, True, flagm, flagc)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "M" Then
                                Colaborador(flaga, flagb, True, flagc)
                                flagm = 1
                            End If
                            If permisos.PER_abm = "C" Then
                                Colaborador(flaga, flagb, flagm, True)
                                flagc = 1
                            End If
                            '-----------------------------------------------

                        Case "VENDEDOR"
                            If permisos.PER_abm = "A" Then
                                Vendedor(True, flagb, flagm, flagc)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Vendedor(flaga, True, flagm, flagc)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "M" Then
                                Vendedor(flaga, flagb, True, flagc)
                                flagm = 1
                            End If
                            If permisos.PER_abm = "C" Then
                                Vendedor(flaga, flagb, flagm, True)
                                flagc = 1
                            End If
                            '-----------------------------------------------

                        Case "CLIENTE"
                            If permisos.PER_abm = "A" Then
                                Cliente(True, flagb, flagm, flagc)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Cliente(flaga, True, flagm, flagc)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "M" Then
                                Cliente(flaga, flagb, True, flagc)
                                flagm = 1
                            End If
                            If permisos.PER_abm = "C" Then
                                Cliente(flaga, flagb, flagm, True)
                                flagc = 1
                            End If
                            '-----------------------------------------------

                        Case "PIEZA"
                            If permisos.PER_abm = "A" Then
                                Pieza(True, flagb, flagm, flagc)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Pieza(flaga, True, flagm, flagc)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "M" Then
                                Pieza(flaga, flagb, True, flagc)
                                flagm = 1
                            End If
                            If permisos.PER_abm = "C" Then
                                Pieza(flaga, flagb, flagm, True)
                                flagc = 1
                            End If
                            '-----------------------------------------------

                        Case "SECTOR"
                            If permisos.PER_abm = "A" Then
                                Sector(True, flagb, flagm, flagc)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Sector(flaga, True, flagm, flagc)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "M" Then
                                Sector(flaga, flagb, True, flagc)
                                flagm = 1
                            End If
                            If permisos.PER_abm = "C" Then
                                Sector(flaga, flagb, flagm, True)
                                flagc = 1
                            End If
                            '-----------------------------------------------

                        Case "TAREA"
                            If permisos.PER_abm = "A" Then
                                Tarea(True, flagb, flagm, flagc)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Tarea(flaga, True, flagm, flagc)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "M" Then
                                Tarea(flaga, flagb, True, flagc)
                                flagm = 1
                            End If
                            If permisos.PER_abm = "C" Then
                                Tarea(flaga, flagb, flagm, True)
                                flagc = 1
                            End If
                            '-----------------------------------------------

                        Case "PRODUCTO"
                            If permisos.PER_abm = "A" Then
                                Producto(True, flagb, flagm, flagalta, flagbaja, flagconsprod, flagconsmov)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Producto(flaga, True, flagm, flagalta, flagbaja, flagconsprod, flagconsmov)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "M" Then
                                Producto(flaga, flagb, True, flagalta, flagbaja, flagconsprod, flagconsmov)
                                flagm = 1
                            End If

                            If permisos.PER_abm = "ALTA" Then
                                Producto(flaga, flagb, flagm, True, flagbaja, flagconsprod, flagconsmov)
                                flagalta = 1
                            End If
                            If permisos.PER_abm = "BAJA" Then
                                Producto(flaga, flagb, flagm, flagalta, True, flagconsprod, flagconsmov)
                                flagbaja = 1
                            End If
                            If permisos.PER_abm = "C_PRO" Then
                                Producto(flaga, flagb, flagm, flagalta, flagbaja, True, flagconsmov)
                                flagconsprod = 1
                            End If
                            If permisos.PER_abm = "C_MOV" Then
                                Producto(flaga, flagb, flagm, flagalta, flagbaja, flagconsprod, True)
                                flagconsmov = 1
                            End If

                            '-----------------------------------------------

                        Case "ORDEN TRABAJO"
                            If permisos.PER_abm = "A" Then
                                Orden(True, flagb, flagm, flagc)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Orden(flaga, True, flagm, flagc)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "M" Then
                                Orden(flaga, flagb, True, flagc)
                                flagm = 1
                            End If
                            If permisos.PER_abm = "C" Then
                                Orden(flaga, flagb, flagm, True)
                                flagm = 1
                            End If
                            '-----------------------------------------------

                        Case "RE-TRABAJO"
                            If permisos.PER_abm = "A" Then
                                Retrabajo(True, flagb, flagm)
                                flaga = 1
                            End If
                            If permisos.PER_abm = "B" Then
                                Retrabajo(flaga, True, flagm)
                                flagb = 1
                            End If
                            If permisos.PER_abm = "C" Then
                                Retrabajo(flaga, flagb, True)
                                flagc = 1
                            End If
                            '-----------------------------------------------
                    End Select
                Next
            End If
            If Buscausuario.USU_perfil = "SUPERVISOR" Then
                Usuario(False, False, False, False)
                Colaborador(False, False, False, False)
                Vendedor(False, False, False, False)
                Cliente(True, True, True, True)
                Pieza(False, False, False, False)
                Sector(False, False, False, False)
                Tarea(True, True, True, True)
                Producto(True, True, True, False, True, True, True)
                Orden(True, True, True, True)
                Retrabajo(True, True, True)
                Etiquetas()
                Estadistica(False, False, False, False, False)
                CorreoElectronico()
                Acercade()
            ElseIf Buscausuario.USU_perfil = "COLABORADOR" Then

                Colaborador(True, True, True, True)
                Vendedor(True, True, True, True)
                Cliente(True, True, True, True)
                Pieza(True, True, True, True)
                Sector(True, True, True, True)
                Tarea(True, True, True, True)
                Producto(True, True, True, True, True, True, True)
                Orden(True, True, True, True)
                Retrabajo(True, True, True)
                Etiquetas()
                Estadistica(True, True, True, True, True)
                CorreoElectronico()
                Acercade()

            ElseIf Buscausuario.USU_perfil = "ADMINISTRADOR" Then
                Colaborador(True, True, True, True)
                Vendedor(True, True, True, True)
                Cliente(True, True, True, True)
                Pieza(True, True, True, True)
                Sector(True, True, True, True)
                Tarea(True, True, True, True)
                Producto(True, True, True, True, True, True, True)
                Orden(True, True, True, True)
                Retrabajo(True, True, True)
                Etiquetas()
                Estadistica(True, True, True, True, True)
                CorreoElectronico()
                Acercade()

            ElseIf Buscausuario.USU_perfil = "GERENCIA" Then
                Colaborador(True, True, True, True)
                Vendedor(True, True, True, True)
                Cliente(True, True, True, True)
                Pieza(True, True, True, True)
                Sector(True, True, True, True)
                Tarea(True, True, True, True)
                Producto(True, True, True, True, True, True, True)
                Orden(True, True, True, True)
                Retrabajo(True, True, True)
                Etiquetas()
                Estadistica(True, True, True, True, True)
                CorreoElectronico()
                Acercade()
            End If

            'PASAR USUARIO Y PERFIL A LOS LABEL DEL MENUUU!!!! PARA LUEGO TOMAR EL USUARIO PARA
            'ACTUALIZAR PASS DESDE ADENTRO
            frm_Principal.LBL_MENU_PERFIL.Text = Buscausuario.USU_perfil.ToString
            frm_Principal.LBL_MENU_USU.Text = Buscausuario.USU_usuario.ToString

            frm_Principal.Show()
            Me.Hide()
            ''Me.Finalize()
            ''Me.Close()
            ''Me.Dispose()
        Catch ex As Exception
            MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            txt_usuario.Select()
            limpiarcontroles()
        End Try
    End Sub

    Sub HabilitarGeneral()
        frm_Principal.UsuarioToolStripMenuItem.Visible = True
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Enabled = True
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Enabled = True

        frm_Principal.ColaboradorToolStripMenuItem.Enabled = True
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Enabled = True

        frm_Principal.VendedorToolStripMenuItem.Enabled = True
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Enabled = True

        frm_Principal.ClienteToolStripMenuItem.Enabled = True
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Enabled = True

        frm_Principal.PiezaToolStripMenuItem.Enabled = True
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Enabled = True

        frm_Principal.SectorToolStripMenuItem.Enabled = True
        frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Enabled = True

        frm_Principal.TareasToolStripMenuItem.Enabled = True
        frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Enabled = True

        frm_Principal.ProductoToolStripMenuItem.Enabled = True
        frm_Principal.GestiónDeProductosToolStripMenuItem.Enabled = True
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Enabled = True

        frm_Principal.StockDeProductosToolStripMenuItem.Enabled = True
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Enabled = True

        frm_Principal.OrdenTrabajoToolStripMenuItem.Enabled = True
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Enabled = True
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Enabled = True

        frm_Principal.ReTrabajoToolStripMenuItem1.Enabled = True
        frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(0).Enabled = True
        frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(1).Enabled = True

        frm_Principal.EtiquetasToolStripMenuItem.Enabled = True
        frm_Principal.EstadisticasToolStripMenuItem.Enabled = True
        frm_Principal.CorreoElectrónicoToolStripMenuItem.Enabled = True
        frm_Principal.AcercadeToolStripMenuItem.Enabled = True
    End Sub

    Sub DeshabilitarGeneral()

        frm_Principal.UsuarioToolStripMenuItem.Enabled = False
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Enabled = False 'modificar
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Enabled = False 'eliminar
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Enabled = False 'consultar

        frm_Principal.ColaboradorToolStripMenuItem.Enabled = False
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Enabled = False 'modificar
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Enabled = False 'eliminar
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(3).Enabled = False 'consultar

        frm_Principal.VendedorToolStripMenuItem.Enabled = False
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Enabled = False 'modificar
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Enabled = False 'eliminar
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Enabled = False 'consultar

        frm_Principal.ClienteToolStripMenuItem.Enabled = False
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Enabled = False 'modificar
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Enabled = False 'eliminar
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(3).Enabled = False 'consultar

        frm_Principal.PiezaToolStripMenuItem.Enabled = False
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Enabled = False 'modificar
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Enabled = False 'eliminar
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Enabled = False 'consultar

        frm_Principal.SectorToolStripMenuItem.Enabled = False
        frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Enabled = False 'modificar
        frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Enabled = False 'eliminar
        frm_Principal.SectorToolStripMenuItem.DropDownItems(3).Enabled = False 'consultar

        frm_Principal.TareasToolStripMenuItem.Enabled = False
        frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Enabled = False 'modificar
        frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Enabled = False 'eliminar
        frm_Principal.TareasToolStripMenuItem.DropDownItems(3).Enabled = False 'consultar

        frm_Principal.ProductoToolStripMenuItem.Enabled = False
        frm_Principal.GestiónDeProductosToolStripMenuItem.Enabled = False
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Enabled = False 'modificar
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Enabled = False 'eliminar

        frm_Principal.StockDeProductosToolStripMenuItem.Enabled = False
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Enabled = False 'alta
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Enabled = False 'baja
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Enabled = False 'consulta producto
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(3).Enabled = False 'consulta movimiento producto

        frm_Principal.OrdenTrabajoToolStripMenuItem.Enabled = False
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Enabled = False 'modificar
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Enabled = False 'eliminar
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Enabled = False 'consultar

        frm_Principal.ReTrabajoToolStripMenuItem1.Enabled = False
        frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(0).Enabled = False 'nuevo
        frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(1).Enabled = False 'eliminar
        frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(2).Enabled = False 'consultar

        frm_Principal.EtiquetasToolStripMenuItem.Enabled = False
        frm_Principal.EstadisticasToolStripMenuItem.Enabled = False
        frm_Principal.CorreoElectrónicoToolStripMenuItem.Enabled = False
        frm_Principal.AcercadeToolStripMenuItem.Enabled = False
    End Sub

    Sub Archivo()
        frm_Principal.ArchivoToolStripMenuItem.Enabled = True
        frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.ArchivoToolStripMenuItem.DropDownItems(1).Enabled = True
    End Sub

    Sub Usuario(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal cons As Boolean)
        frm_Principal.UsuarioToolStripMenuItem.Visible = True
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Visible = elim
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Visible = cons
    End Sub

    Sub Colaborador(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal cons As Boolean)
        frm_Principal.ColaboradorToolStripMenuItem.Enabled = True
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = elim
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(3).Visible = cons
    End Sub

    Sub Vendedor(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal cons As Boolean)
        frm_Principal.VendedorToolStripMenuItem.Enabled = True
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Visible = elim
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = cons

    End Sub

    Sub Cliente(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal cons As Boolean)
        frm_Principal.ClienteToolStripMenuItem.Enabled = True
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Visible = elim
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(3).Visible = cons
    End Sub

    Sub Pieza(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal cons As Boolean)
        frm_Principal.PiezaToolStripMenuItem.Enabled = True
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Visible = elim
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(3).Visible = cons
    End Sub

    Sub Sector(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal cons As Boolean)
        frm_Principal.SectorToolStripMenuItem.Enabled = True
        frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Visible = elim
        frm_Principal.SectorToolStripMenuItem.DropDownItems(3).Visible = cons
    End Sub

    Sub Tarea(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal cons As Boolean)
        frm_Principal.TareasToolStripMenuItem.Enabled = True
        frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Visible = elim
        frm_Principal.TareasToolStripMenuItem.DropDownItems(3).Visible = cons
    End Sub

    Sub Producto(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal alta As Boolean, ByVal baja As Boolean, ByVal cons_prod As Boolean, ByVal cons_mov As Boolean)
        frm_Principal.ProductoToolStripMenuItem.Enabled = True

        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Visible = elim

        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = alta
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = baja
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Visible = cons_prod
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(3).Visible = cons_mov
    End Sub

    Sub Orden(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean, ByVal cons As Boolean)
        frm_Principal.OrdenTrabajoToolStripMenuItem.Enabled = True
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = nuevo 'nueva
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = modif 'modificar
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = elim 'eliminar
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = cons 'consultar
    End Sub

    Sub Retrabajo(ByVal nuevo As Boolean, ByVal elim As Boolean, ByVal cons As Boolean)
        frm_Principal.ReTrabajoToolStripMenuItem1.Enabled = True
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = nuevo 'nuevo
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = elim 'eliminar
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = cons 'consultar
    End Sub

    Sub Estadistica(ByVal tarea As Boolean, ByVal diaria As Boolean, ByVal mensual As Boolean, ByVal orden As Boolean, ByVal movim As Boolean)
        frm_Principal.EstadisticasToolStripMenuItem.Enabled = True 'pestaña

        frm_Principal.TareasToolStripMenuItem1.Enabled = True 'tarea
        frm_Principal.TareasToolStripMenuItem1.DropDownItems(0).Visible = diaria 'diarias por colaborador
        frm_Principal.TareasToolStripMenuItem1.DropDownItems(1).Visible = mensual 'mensuales por sector

        frm_Principal.OrdenDeTrabajoToolStripMenuItem.Enabled = True 'orden
        frm_Principal.OrdenDeTrabajoToolStripMenuItem.DropDownItems(0).Visible = movim 'movimiento de orden
    End Sub

    Sub Etiquetas()
        frm_Principal.EtiquetasToolStripMenuItem.Enabled = True
    End Sub

    Sub CorreoElectronico()
        frm_Principal.CorreoElectrónicoToolStripMenuItem.Enabled = True
    End Sub

    Sub Acercade()
        frm_Principal.AcercadeToolStripMenuItem.Enabled = True
    End Sub

    Public Sub limpiarcontroles()
        txt_contraseña.Clear()
        txt_usuario.Clear()
    End Sub

    Private Sub btnCambiar_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiarContraseña.Click
        Try
            Dim Buscausuario = (From I In datacontext.USUARIO Where I.USU_usuario = (txt_usuario.Text) And I.USU_contraseña = (txt_contraseña.Text)).ToList()(0)
            frm_gestion_usuarios.txt_usuario.Text = Buscausuario.USU_usuario
            frm_gestion_usuarios.cbo_perfil.Text = Buscausuario.USU_perfil
            frm_gestion_usuarios.cbo_perfil.Enabled = False
            frm_gestion_usuarios.txt_usuario.Enabled = False
            frm_gestion_usuarios.btnGuardar.Visible = False
            frm_gestion_usuarios.Show()
        Catch ex As Exception
            MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            txt_usuario.Select()
            limpiarcontroles()
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Application.ExitThread()
        Me.Dispose()
    End Sub

    Private Sub frm_ingreso_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class