<<<<<<< .mine
||||||| .r368
﻿Imports System.Data.Sql
Imports System.Data.SqlClient

Module Autocompletar_Textbox
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter

    Sub abrir()
        Try
            conexiones = New SqlConnection("Data Source=DESKTOP-84P9IMQ\SQLEXPRESS;Initial Catalog=SOLUCIONES_INTERNAS;Integrated Security=True")
            conexiones.Open()
            ' MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente") '
        Catch ex As Exception
            MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")
            conexiones.Close() 'Cierra la conexion'
        End Try
    End Sub

    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
        Try
            enunciado = New SqlCommand("select CLI_razon_social from cliente", conexiones)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("CLI_razon_social"))
            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
=======
﻿Imports System.Data.Sql
Imports System.Data.SqlClient

Module Autocompletar_Textbox
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter

    Sub abrir()
        Try
            conexiones = New SqlConnection("Data Source=DESKTOP-84P9IMQ\SQLEXPRESS;Initial Catalog=SOLUCIONES_INTERNAS1;Integrated Security=True")
            conexiones.Open()
            ' MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente") '
        Catch ex As Exception
            MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")
            conexiones.Close() 'Cierra la conexion'
        End Try
    End Sub

    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
        Try
            enunciado = New SqlCommand("select CLI_razon_social from cliente", conexiones)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("CLI_razon_social"))
            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
>>>>>>> .r401
