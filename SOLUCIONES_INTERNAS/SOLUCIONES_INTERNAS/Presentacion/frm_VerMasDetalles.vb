﻿Public Class frm_VerMasDetalles

    Private Sub frm_VerMasDetalles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_VerMasDetalles.SelectionStart = False
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        frm_Tarea.Show()
    End Sub
End Class