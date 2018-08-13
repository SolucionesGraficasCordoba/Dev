Public Class frm_ingreso
    Dim datacontext As New DataS_Interno

    Private Sub frm_ingreso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_usuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        '   Try
        Dim Buscausuario = (From I In datacontext.USUARIO Where I.USU_usuario = (txt_usuario.Text) And I.USU_contraseña = (txt_contraseña.Text)).ToList()(0)


        If Buscausuario.USU_perfil = "SUPERVISOR" Then
            frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = True
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = True
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = True
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(4).Visible = True
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(5).Visible = True
            frm_Principal.SectorToolStripMenuItem.DropDownItems(6).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(7).Visible = True

        ElseIf Buscausuario.USU_perfil = "COLABORADOR" Then
            frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = False
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = True
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = True
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(4).Visible = True
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(5).Visible = True
            frm_Principal.SectorToolStripMenuItem.DropDownItems(6).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(7).Visible = True

        ElseIf Buscausuario.USU_perfil = "ADMINISTRADOR" Then
            frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.SectorToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(0).Visible = True

        ElseIf Buscausuario.USU_perfil = "GERENCIA" Then
            frm_Principal.ArchivoToolStripMenuItem.DropDownItems(0).Visible = True
            frm_Principal.UsuarioToolStripMenuItem.DropDownItems(1).Visible = True
            frm_Principal.ColaboradorToolStripMenuItem.DropDownItems(2).Visible = True
            frm_Principal.VendedorToolStripMenuItem.DropDownItems(3).Visible = True
            frm_Principal.ClienteToolStripMenuItem.DropDownItems(4).Visible = True
            frm_Principal.PiezaToolStripMenuItem.DropDownItems(5).Visible = True
            frm_Principal.SectorToolStripMenuItem.DropDownItems(6).Visible = True
            frm_Principal.TareasToolStripMenuItem.DropDownItems(7).Visible = True

        End If

        'PASAR USUARIO Y PERFIL A LOS LABEL DEL MENUUU!!!! PARA LUEGO TOMAR EL USUARIO PARA
        'ACTUALIZAR PASS DESDE ADENTRO
        frm_Principal.LBL_MENU_PERFIL.Text = Buscausuario.USU_perfil.ToString
        frm_Principal.LBL_MENU_USU.Text = Buscausuario.USU_usuario.ToString


        frm_Principal.Show()
        Me.Finalize()
        Me.Close()
        '  Catch ex As Exception
        'gBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
        ' txt_usuario.Select()
        '  limpiarcontroles()
        '   End Try
    End Sub

    Public Sub limpiarcontroles()
        txt_contraseña.Clear()
        txt_usuario.Clear()
    End Sub

    Private Sub btnCambiar_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiar.Click
        Try
            Dim Buscausuario = (From I In datacontext.USUARIO Where I.USU_usuario = (txt_usuario.Text.ToUpper) And I.USU_contraseña = (txt_contraseña.Text)).ToList()(0)
            frm_gestion_usuarios.txt_usuario.Text = Buscausuario.USU_USUARIO
            frm_gestion_usuarios.cbo_perfil.Text = Buscausuario.USU_PERFIL
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
        Application.Exit()
        Me.Dispose()
    End Sub
End Class