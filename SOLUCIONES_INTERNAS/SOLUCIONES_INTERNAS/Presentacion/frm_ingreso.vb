Public Class frm_ingreso
    Dim datacontext As New DataS_Interno

    Private Sub frm_ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_usuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click

        'DESHABILITA PERMISOS
        frm_Principal.ArchivoToolStripMenuItem.Enabled = False
        frm_Principal.UsuarioToolStripMenuItem.Enabled = False
        frm_Principal.ColaboradorToolStripMenuItem.Enabled = False
        frm_Principal.VendedorToolStripMenuItem.Enabled = False
        frm_Principal.ClienteToolStripMenuItem.Enabled = False
        frm_Principal.PiezaToolStripMenuItem.Enabled = False
        frm_Principal.SectorToolStripMenuItem.Enabled = False
        frm_Principal.TareasToolStripMenuItem.Enabled = False
        frm_Principal.ProductoToolStripMenuItem.Enabled = False
        frm_Principal.OrdenTrabajoToolStripMenuItem.Enabled = False
        frm_Principal.ReTrabajoToolStripMenuItem1.Enabled = False
        frm_Principal.EtiquetasToolStripMenuItem.Enabled = False
        frm_Principal.EstadisticasToolStripMenuItem.Enabled = False
        frm_Principal.CorreoElectrónicoToolStripMenuItem.Enabled = False
        frm_Principal.AcercadeToolStripMenuItem.Enabled = False

        'HABILITAR CONSULTAS (SUB)
        habilitargeneral()

        'HABILITA SEGUN PERFIL USUARIO
        '  Try
        Dim Buscausuario = (From I In datacontext.USUARIO Where I.USU_usuario = (txt_usuario.Text) And I.USU_contraseña = (txt_contraseña.Text)).ToList()(0)

        Select Case Buscausuario.USU_perfil
            Case "SUPERVISOR"
                Archivo()

            Case "ADMINISTRADOR"
                Usuario(True, True, True)
                Colaborador(True, True, True)
                Vendedor(True, True, True)
                Cliente(True, True, True)
                Pieza(True, True, True)
                Sector(True, True, True)
                Tarea(True, True, True)
                Producto(True, True, True)
                Orden(True, True, True)
                Retrabajo(True, True, True)
                Etiquetas()
                Estadistica()
                CorreoElectronico()
        End Select

        'HABILITA SEGUN PERMISOS ESPECIALES
        Dim contadorpermisos As Integer = (From P In datacontext.PERMISO Where P.USU_id_usuario = Buscausuario.USU_id_usuario).Count
        If contadorpermisos > 0 Then


            Dim flaga = 0, flagb = 0, flagm = 0
            For i = 0 To contadorpermisos - 1
                Dim permisos = (From A In datacontext.PERMISO Select A.PER_permiso, A.PER_abm, A.USU_id_usuario Where USU_id_usuario = Buscausuario.USU_id_usuario).ToList()(i)


                Select Case permisos.PER_permiso

                    Case "USUARIO"
                        If permisos.PER_abm = "A" Then
                            Usuario(True, flagb, flagm)
                            flaga = 1
                        End If
                        If permisos.PER_abm = "B" Then
                            Usuario(flaga, True, flagm)
                            flagb = 1
                        End If
                        If permisos.PER_abm = "M" Then
                            Usuario(flaga, flagb, True)
                            flagm = 1
                        End If
                        '-------------------------------------------------------
                    Case "COLABORADOR"
                        If permisos.PER_abm = "A" Then
                            Colaborador(True, flagb, flagm)
                            flaga = 1
                        End If
                        If permisos.PER_abm = "B" Then
                            Colaborador(flaga, True, flagm)
                            flagb = 1
                        End If
                        If permisos.PER_abm = "M" Then
                            Colaborador(flaga, flagb, True)
                            flagm = 1
                        End If
                        '-----------------------------------------------

                    Case "VENDEDOR"
                        If permisos.PER_abm = "A" Then
                            Vendedor(True, flagb, flagm)
                            flaga = 1
                        End If
                        If permisos.PER_abm = "B" Then
                            Vendedor(flaga, True, flagm)
                            flagb = 1
                        End If
                        If permisos.PER_abm = "M" Then
                            Vendedor(flaga, flagb, True)
                            flagm = 1
                        End If
                        '-----------------------------------------------

                    Case "CLIENTE"
                        If permisos.PER_abm = "A" Then
                            Cliente(True, flagb, flagm)
                            flaga = 1
                        End If
                        If permisos.PER_abm = "B" Then
                            Cliente(flaga, True, flagm)
                            flagb = 1
                        End If
                        If permisos.PER_abm = "M" Then
                            Cliente(flaga, flagb, True)
                            flagm = 1
                        End If
                        '-----------------------------------------------

                    Case "PIEZA"
                        If permisos.PER_abm = "A" Then
                            Pieza(True, flagb, flagm)
                            flaga = 1
                        End If
                        If permisos.PER_abm = "B" Then
                            Pieza(flaga, True, flagm)
                            flagb = 1
                        End If
                        If permisos.PER_abm = "M" Then
                            Pieza(flaga, flagb, True)
                            flagm = 1
                        End If
                        '-----------------------------------------------



                End Select
            Next
        End If
        If Buscausuario.USU_perfil = "SUPERVISOR" Then

            Archivo()
            frm_Principal.UsuarioToolStripMenuItem.Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.ColaboradorToolStripMenuItem.Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.VendedorToolStripMenuItem.Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.ClienteToolStripMenuItem.Visible = True
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(3).Visible = True

            frm_Principal.PiezaToolStripMenuItem.Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.SectorToolStripMenuItem.Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.TareasToolStripMenuItem.Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(3).Visible = True

            frm_Principal.ProductoToolStripMenuItem.Visible = True

            frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Visible = True
            frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Visible = True

            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = True
            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Visible = True
            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(3).Visible = True

            frm_Principal.OrdenTrabajoToolStripMenuItem.Visible = True
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = True 'nueva
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = True 'modificar
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = True 'eliminar
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = True 'consultar

            frm_Principal.ReTrabajoToolStripMenuItem1.Visible = True
            frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(0).Visible = True 'nueva
            frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(1).Visible = True 'eliminar
            frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(2).Visible = True 'consultar

            frm_Principal.EstadisticasToolStripMenuItem.Visible = True

        ElseIf Buscausuario.USU_perfil = "TAREA" Then
            Archivo()

            frm_Principal.UsuarioToolStripMenuItem.Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.ColaboradorToolStripMenuItem.Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.VendedorToolStripMenuItem.Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.ClienteToolStripMenuItem.Visible = True
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(3).Visible = True

            frm_Principal.PiezaToolStripMenuItem.Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.SectorToolStripMenuItem.Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.TareasToolStripMenuItem.Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(3).Visible = True

            frm_Principal.ProductoToolStripMenuItem.Visible = True
            frm_Principal.GestiónDeProductosToolStripMenuItem.Visible = False
            frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Visible = False

            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = False 'Baja
            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Visible = True 'Consulta prod
            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(3).Visible = True 'Consulta mov

            frm_Principal.OrdenTrabajoToolStripMenuItem.Visible = True
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = False 'nueva
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = False 'modificar
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = False 'eliminar
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = True 'consultar

            frm_Principal.ReTrabajoToolStripMenuItem1.Visible = True
            frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(0).Visible = False 'nueva
            frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(1).Visible = False 'eliminar
            frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(2).Visible = True 'consultar

            frm_Principal.EstadisticasToolStripMenuItem.Visible = False

            frm_Principal.EtiquetasToolStripMenuItem.Visible = False

        ElseIf Buscausuario.USU_perfil = "COLABORADOR" Then
            Archivo()

            frm_Principal.UsuarioToolStripMenuItem.Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.ColaboradorToolStripMenuItem.Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.VendedorToolStripMenuItem.Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.ClienteToolStripMenuItem.Visible = True
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(3).Visible = True

            frm_Principal.PiezaToolStripMenuItem.Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.SectorToolStripMenuItem.Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.SectorToolStripMenuItem.DropDownItems(3).Visible = False

            frm_Principal.TareasToolStripMenuItem.Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Visible = False
            frm_Principal.TareasToolStripMenuItem.DropDownItems(3).Visible = True

            frm_Principal.ProductoToolStripMenuItem.Visible = True
            frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Visible = False
            frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Visible = False
            If Buscausuario.USU_usuario = "calidad" Then
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = True 'Alta
            Else
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = False 'Baja
            End If
            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = False 'Baja
            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Visible = True 'Consulta prod
            frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(3).Visible = True 'Consulta mov

            frm_Principal.OrdenTrabajoToolStripMenuItem.Visible = True
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = False 'nueva
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = False 'modificar
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = False 'eliminar
            frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = True 'consultar

            frm_Principal.ReTrabajoToolStripMenuItem1.Visible = True
            frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(0).Visible = False 'nueva
            frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(1).Visible = False 'eliminar
            frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(2).Visible = True 'consultar

            frm_Principal.EstadisticasToolStripMenuItem.Visible = False
            '  frm_Principal.GenerarInformesToolStripMenuItem.DropDownItems(0).Visible = False 'nueva
            ' frm_Principal.GenerarInformesToolStripMenuItem.DropDownItems(1).Visible = False 'eliminar
            ' frm_Principal.GenerarInformesToolStripMenuItem.DropDownItems(2).Visible = False 'consultar

        ElseIf Buscausuario.USU_perfil = "ADMINISTRADOR" Then
            'Archivo()
            'Usuario()
            'Colaborador()
            'Vendedor()
            'Cliente()
            'Pieza()
            'Sector()
            'Tarea()
            'Producto()
            'Orden()
            'Retrabajo()
            'Etiquetas()
            'Estadistica()
            'CorreoElectronico()
            'Acercade()

        ElseIf Buscausuario.USU_perfil = "GERENCIA" Then
            Archivo()
            ' Usuario()
            Colaborador(True, True, True)
            Vendedor(True, True, True)
            Cliente(True, True, True)
            Pieza(True, True, True)
            Sector(True, True, True)
            Tarea(True, True, True)
            Producto(True, True, True)
            Orden(True, True, True)
            Retrabajo(True, True, True)
            Etiquetas()
            Estadistica()
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
        'Catch ex As Exception
        '    MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
        '    txt_usuario.Select()
        '    limpiarcontroles()
        'End Try
    End Sub

    Sub habilitargeneral()
        'ARCHIVO
        frm_Principal.ArchivoToolStripMenuItem.Enabled = True
        frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.ArchivoToolStripMenuItem.DropDownItems(1).Enabled = True
        'COLABORADOR
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(3).Visible = True
        'VENDEDOR
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = True
        'CLIENTE
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(3).Visible = True
        'PIEZA
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(3).Visible = True
        'SECTOR
        frm_Principal.SectorToolStripMenuItem.DropDownItems(3).Visible = True
        'TAREA
        frm_Principal.TareasToolStripMenuItem.DropDownItems(3).Visible = True
        'ORDEN
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = True 'consultar
        'RETRABAJO
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = True
    End Sub

    Sub Archivo()
        frm_Principal.ArchivoToolStripMenuItem.Enabled = True
        frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Enabled = True
        frm_Principal.ArchivoToolStripMenuItem.DropDownItems(1).Enabled = True
    End Sub

    Sub Usuario(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.UsuarioToolStripMenuItem.Enabled = True
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Visible = elim
        '  frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Visible = True
    End Sub

    Sub Colaborador(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.ColaboradorToolStripMenuItem.Enabled = True
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = elim
    End Sub

    Sub Vendedor(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.VendedorToolStripMenuItem.Enabled = True
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Visible = elim

    End Sub

    Sub Cliente(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.ClienteToolStripMenuItem.Enabled = True
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Visible = elim
    End Sub

    Sub Pieza(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.PiezaToolStripMenuItem.Enabled = True
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Visible = elim
    End Sub

    Sub Sector(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.SectorToolStripMenuItem.Enabled = True
        frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Visible = elim
    End Sub

    Sub Tarea(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.TareasToolStripMenuItem.Enabled = True
        frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Visible = elim
    End Sub

    Sub Producto(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.ProductoToolStripMenuItem.Enabled = True

        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Visible = nuevo
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Visible = modif
        frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Visible = elim

        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = True
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = True
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Visible = True
        frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(3).Visible = True
    End Sub

    Sub Orden(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.OrdenTrabajoToolStripMenuItem.Enabled = True
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = nuevo 'nueva
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = modif 'modificar
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = elim 'eliminar
    End Sub

    Sub Retrabajo(ByVal nuevo As Boolean, ByVal modif As Boolean, ByVal elim As Boolean)
        frm_Principal.ReTrabajoToolStripMenuItem1.Enabled = True
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = True
        frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = True
    End Sub

    Sub Etiquetas()
        frm_Principal.EtiquetasToolStripMenuItem.Enabled = True
    End Sub

    Sub Estadistica()
        frm_Principal.EstadisticasToolStripMenuItem.Enabled = True
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