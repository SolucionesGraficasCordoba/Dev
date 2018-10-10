Public Class frm_ingreso
    Dim datacontext As New DataS_Interno

    Private Sub frm_ingreso_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub


    Private Sub frm_ingreso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_usuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        Try
            Dim Buscausuario = (From I In datacontext.USUARIO Where I.USU_usuario = (txt_usuario.Text) And I.USU_contraseña = (txt_contraseña.Text)).ToList()(0)

            'TIENE HABILITADO LAS SIGUIENES PESTAÑAS: 
            ' - ARCHIVO----CERRAR SESION Y SALIR
            ' - CLIENTE----NUEVO Y CONSULTA
            ' - TAREA -----NUEVO, MODIFICAR, ELIMINAR Y CONSULTA
            ' - ORDEN------NUEVO, MODIFICAR, ELIMINAR Y CONSULTA
            ' - RETRABAJO-----NUEVO, ELIMINAR Y CONSULTA
            ' - GENERAR INFORME-----TAREA

            If Buscausuario.USU_perfil = "SUPERVISOR" Then

                frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Enabled = True
                frm_Principal.ArchivoToolStripMenuItem.DropDownItems(1).Enabled = True

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
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(3).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Visible = True

                frm_Principal.OrdenTrabajoToolStripMenuItem.Visible = True
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = True 'nueva
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = True 'modificar
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = True 'eliminar
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = True 'consultar

                frm_Principal.ReTrabajoToolStripMenuItem1.Visible = True
                frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(0).Visible = True 'nueva
                frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(1).Visible = True 'eliminar
                frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(2).Visible = True 'consultar

                frm_Principal.GenerarInformesToolStripMenuItem.Visible = True
                frm_Principal.GenerarInformesToolStripMenuItem.DropDownItems(0).Visible = True 'nueva
                frm_Principal.GenerarInformesToolStripMenuItem.DropDownItems(1).Visible = False 'eliminar
                frm_Principal.GenerarInformesToolStripMenuItem.DropDownItems(2).Visible = False 'consultar


                'TIENE HABILITADO LAS SIGUIENES PESTAÑAS: 
                ' - ARCHIVO----CERRAR SESION Y SALIR
                ' - CLIENTE----CONSULTA
                ' - TAREA -----CONSULTA
                ' - ORDEN------CONSULTA
                ' - RETRABAJO-----CONSULTA

            ElseIf Buscausuario.USU_perfil = "COLABORADOR" Then
                frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Enabled = True
                frm_Principal.ArchivoToolStripMenuItem.DropDownItems(1).Enabled = True

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
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(3).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = False
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = False
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Visible = True

                frm_Principal.OrdenTrabajoToolStripMenuItem.Visible = True
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = False 'nueva
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = False 'modificar
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = False 'eliminar
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = True 'consultar

                frm_Principal.ReTrabajoToolStripMenuItem1.Visible = True
                frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(0).Visible = False 'nueva
                frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(1).Visible = False 'eliminar
                frm_Principal.ReTrabajoToolStripMenuItem1.DropDownItems(2).Visible = True 'consultar

                frm_Principal.GenerarInformesToolStripMenuItem.Visible = False
                frm_Principal.GenerarInformesToolStripMenuItem.DropDownItems(0).Visible = False 'nueva
                frm_Principal.GenerarInformesToolStripMenuItem.DropDownItems(1).Visible = False 'eliminar
                frm_Principal.GenerarInformesToolStripMenuItem.DropDownItems(2).Visible = False 'consultar


                'TIENE HABILITADA TODAS LAS PESTAÑAS

            ElseIf Buscausuario.USU_perfil = "ADMINISTRADOR" Then
                frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.ArchivoToolStripMenuItem.DropDownItems(1).Visible = True

                frm_Principal.UsuarioToolStripMenuItem.Visible = True
                frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.ColaboradorToolStripMenuItem.Visible = True
                frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.VendedorToolStripMenuItem.Visible = True
                frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.ClienteToolStripMenuItem.Visible = True
                frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.ClienteToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.PiezaToolStripMenuItem.Visible = True
                frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.PiezaToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.SectorToolStripMenuItem.Visible = True
                frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.SectorToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.ProductoToolStripMenuItem.Visible = True
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(3).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Visible = True

                frm_Principal.TareasToolStripMenuItem.Visible = True
                frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.TareasToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.OrdenTrabajoToolStripMenuItem.Visible = True
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = True 'nueva
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = True 'modificar
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = True 'eliminar
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = True 'consultar

                frm_Principal.GenerarInformesToolStripMenuItem.Visible = True

                'TIENE HABILITADA TODAS LAS PESTAÑAS

            ElseIf Buscausuario.USU_perfil = "GERENCIA" Then
                frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.ArchivoToolStripMenuItem.DropDownItems(1).Visible = True

                frm_Principal.UsuarioToolStripMenuItem.Visible = True
                frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.UsuarioToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.UsuarioToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.ColaboradorToolStripMenuItem.Visible = True
                frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.VendedorToolStripMenuItem.Visible = True
                frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.VendedorToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.VendedorToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.ClienteToolStripMenuItem.Visible = True
                frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.ClienteToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.ClienteToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.ClienteToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.PiezaToolStripMenuItem.Visible = True
                frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.PiezaToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.PiezaToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.PiezaToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.SectorToolStripMenuItem.Visible = True
                frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.SectorToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.SectorToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.SectorToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.TareasToolStripMenuItem.Visible = True
                frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.TareasToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.TareasToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.TareasToolStripMenuItem.DropDownItems(3).Visible = True

                frm_Principal.ProductoToolStripMenuItem.Visible = True
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(2).Visible = True
                frm_Principal.GestiónDeProductosToolStripMenuItem.DropDownItems(3).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(0).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(1).Visible = True
                frm_Principal.StockDeProductosToolStripMenuItem.DropDownItems(2).Visible = True

                frm_Principal.OrdenTrabajoToolStripMenuItem.Visible = True
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(0).Visible = True 'nueva
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(1).Visible = True 'modificar
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(2).Visible = True 'eliminar
                frm_Principal.OrdenTrabajoToolStripMenuItem.DropDownItems(3).Visible = True 'consultar

                frm_Principal.GenerarInformesToolStripMenuItem.Visible = True
            End If

            'PASAR USUARIO Y PERFIL A LOS LABEL DEL MENUUU!!!! PARA LUEGO TOMAR EL USUARIO PARA
            'ACTUALIZAR PASS DESDE ADENTRO
            frm_Principal.LBL_MENU_PERFIL.Text = Buscausuario.USU_perfil.ToString
            frm_Principal.LBL_MENU_USU.Text = Buscausuario.USU_usuario.ToString

            frm_Principal.Show()
            Me.Finalize()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            txt_usuario.Select()
            limpiarcontroles()
        End Try
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

    Private Sub txt_usuario_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_contraseña.Focus()
        End If
    End Sub

    Private Sub txt_contraseña_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnIngresar.Focus()
        End If
    End Sub

    Private Sub txt_contraseña_KeyDown_1(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_contraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnIngresar.Focus()
        End If
    End Sub
End Class