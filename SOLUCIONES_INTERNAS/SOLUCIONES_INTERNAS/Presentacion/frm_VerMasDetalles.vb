Imports System.Windows.Forms.Application

Public Class frm_VerMasDetalles

    Private Sub frm_VerMasDetalles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' txt_VerMasDetalles.SelectionStart = False
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        frm_Tarea.Show()
    End Sub

    Private Sub btnCerrar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

End Class

'El formulario PRINCIPAL contiene las siguientes pestañas:

'- USUARIO:  
' * nuevo: da de alta a un nuevo usuario.
' * modificar: actualiza los datos de un usuario existente.
' * eliminar: da de baja a un usuario.
' * consultar: muestra datos de los usuarios.

'- COLABORADOR: 
' * nuevo: da de alta a un nuevo colaborador.
' * modificar: actualiza los datos de un colaborador existente.
' * eliminar: da de baja a un colaborador.
' * consultar: muestra datos de los colaboradores.

'- VENDEDOR: 
' * nuevo: da de alta a un nuevo vendedor.
' * modificar: actualiza los datos de un vendedor existente.
' * eliminar: da de baja a un vendedor.
' * consultar: muestra datos de los vendedores.

'- CLIENTE:   
' * nuevo: da de alta a un nuevo cliente.
' * modificar: actualiza los datos de un cliente existente.
' * eliminar: da de baja a un cliente.
' * consultar: muestra datos de los clientes.

'- PIEZA:   
' * nuevo: da de alta a un nueva pieza.
' * modificar: actualiza los datos de una pieza existente.
' * eliminar: da de baja a una pieza.
' * consultar: muestra datos de las piezas.


'- SECTOR: 
' * nuevo: da de alta a un nuevo sector.
' * modificar: actualiza los datos de un sector existente.
' * eliminar: da de baja a un sector.
' * consultar: muestra datos de los sectores.

'- TAREA:  
' * nuevo: da de alta a una nueva tarea.
' * modificar: actualiza los datos de una tarea existente.
' * eliminar: da de baja a una tarea.
' * consultar: muestra datos de las tareas.

'- PRODUCTO: 
' * Gestión de Productos 
'          ° nuevo: da de alta a un nuevo producto.
'          ° modificar: actualiza los datos de un producto existente.
'          ° eliminar: da de baja a un producto.
' * Stock de Productos
'           ° alta: da de alta una nueva cantidad de un producto.
'           ° baja: da de baja una cantidad de un producto.
'           ° consultar productos: muestra datos de los productos.
'           ° consultar movimientos: muestra altas y bajas de los productos.

'- ORDEN TRABAJO: 
'* nuevo: da de alta a una nueva orden de trabajo.
'* modificar: actualiza los datos de una orden de trabajo existente.
'* eliminar: da de baja a una orden de trabajo.
'* consultar: muestra datos de las orden de trabajo.

'- RE-TRABAJO: 
'* Repetición de Chapas 
'                ° nuevo: da de alta a un nueva repetición de chapas.
'	° eliminar: da de baja a una repetición de chapas.
'* Digital / Offset
'	° nuevo: da de alta a un nuevo re-trabajo de digital/offset.
'	 ° eliminar: da de baja a un nuevo re-trabajo de digital/offset.
'                 ° consultar: 
'	 ° Repetición de Chapas: muestra datos de re-trabajo respecto a la repetición de chapas.
'	 ° Digital / Offset: muestra datos de re-trabajo de digital7offset.

'- ETIQUETAS: genera etiquetas.

'- ESTADISTICAS: 
'* Tareas
'	°Diarias por Colaborador: muestra los tiempos estimado y real de cada colaborador dentro del mes.
'	°Mensuales por Sector: muestra los tiempos estimados y reales de cada sector.

'- CORREO ELECTRONICO: área en construcción.

'- ACERCA DE: hace referencia a las partes más importantes del sistema.

'--------------------------------------------------------------------------------------------


'FUNCIONAMIENTO ORDEN TRABAJO:


'	NUEVA ORDEN:
'1 - completar todos los campos necesarios de acuerdo al tipo de orden a cargar.
'2 - el botón "buscar cliente" abrira el formulario del 'listado de clientes' y mediante un 'doble click' sobre el mismo, 
'	éste se cargará en el campo del cliente previamente establecido.
'3 - el mismo prodecimiento se hará al buscar al vendedor, en su lugar se abrirá el 'listado de vendedores' previamente cargados al sistema.
'4 - se seleccionará un tipo de orden a cargar mediante los check's, según el que se tilde se habilitarán los campos necesarios a cargar. 
'	(puede haber más de un tipo de orden)
'5 - una vez completos todos los campos de la orden, el botón GUARDAR cargara la nueva orden al sistema. 

'Nota1: los campos tildados en rojo son OBLIGATORIOS, lo que significa que no se podrá guardar la orden si alguno de ellos está vacio.
'Nota2: completar el campo observaciones SI Y SOLO SI es necesario, o si cree que es necesaria agregar alguna información extra.

'	MODIFICAR ORDEN:
'1 - 
'-----------------------------------------------------------------------------------------------------------------------------------------------
'								COMPONENTES:

'-	BOTON BUSCAR VENDEDOR (...): abre el formulario de vendedores.
'-	BOTON BUSCAR CLIENTE (...): abre el formulario de clientes.
'-	BOTON GUARDAR: guarda la información cargada. 
'-	BOTON CANCELAR: cierra el formulario sin guardar los cambios.  
'-	CAMPO NRO ORDEN: ingresa el Nro de Orden. 
'-	COMBO DIRECCION DE ENTREGA: la Dirección a la que será entregado el trabajo.
'-	CAMPO FECHA INGRESO: fecha de ingreso de la odt.
'-	CAMPO FECHA ENTREGA: fecha de entrega de la odt.
'-	CAMPO OBSERVACIONES: comentarios que se creen importantes de destacar.
'-	CHECK’S TIPO ORDEN: tipo de orden disponibles para seleccionar.
'-	CAMPO CANTIDAD PRODUCTO: cantidad del producto a realizar.
'-	COMBO PIEZA PRODUCTO: desplegable que muestra todos los productos del cual se seleccionará el deseado.
'-	CAMPO TAMAÑO PRODUCTO: tamaño del producto a realizar.
'-	CAMPO PAPEL 1, 2, 3: Tipo de papel a utilizar.
'-	CAMPO GRAMAJE 1, 2,3: grosor del papel.
'-	CAMPO CANTIDAD 1, 2 ,3 PLIEGO ENTERO PRODUCTO: cantidad de pliego entero a utilizar.
'-	COMBO 1, 2, 3 FORMATO PLIEGO ENTERO PRODUCTO: desplegable que muestra todos los formatos de pliegos enteros.
'-	COMBO TIPO IMPRESIÓN OFFSET: desplegable que muestra los tipos de impresión estandar disponibles.(Se pueden agregar otros).
'-	COMBO MODO IMPRESIÓN OFFSET: desplegable que muestra los modos de impresión disponibles.
'-	COMBO IMPRESORA OFFSET: desplegable que muestra las impresoras disponibles.
'-	COMBO MARCA OFFSET: desplegable que muestra las marcas disponibles.
'-	CAMPO CANTIDAD 1, 2, 3 PLIEGO MAQUINA OFFSET: cantidad de pliegos máquina de offset.
'-	COMBO FORMATO 1, 2, 3 PLIEGO MAQUINA OFFSET:  desplegable que muestra los formato de pliegos máquina de offset.
'-	CAMPO CHAPAS 1, 2, 3: cantidad de chapas.
'-	COMBO TIPO IMPRESIÓN DIGITAL:  desplegable que muestra los tipos de impresión digital disponibles.
'-	CAMPO CANTIDAD 1, 2, 3 PLIEGO MAQUINA DIGITAL: cantidad pliego maquina digital.
'-	COMBO FORMATO 1, 2, 3 PLIEGO MAQUINA DIGITAL: desplegable que muestra los formatos de pliego maquina digital.
'-	CAMPO DATO VARIABLE: comentarios que se creen importantes de destacar sobre un dato variable realizado.
'-	CAMPO CANTIDAD GRAN FORMATO: cantidad de trabajo a realizar en gran formato.
'-	COMBO PIEZA GRAN FORMATO:  desplegable que muestra los productos de gran formato.
'-	CAMPO TAMAÑO GRAN FORMATO: tamaño a realizar en gran formato.
'-	COMBO CALIDAD GRAN FORMATO:  desplegable que muestra la calidad de impresion disponible.
'-	COMBO SISTEMA GRAN FORMATO:  desplegable que muestra el sistema de impresión disponible.
'-	CHECK’S TERMINACION: tipo de terminaciones.
'-	CAMPO DESCRIPCION TERMINACION: comentarios que se creen importantes de destacar para terminación.

'----------------------------------------------------------------------------------------------------------------


'El formulario de TAREA se carga de la siguiente manera:

'-	BOTON COLABORADOR (está al lado del campo colaborador): abre el formulario de colaboradores, 
'                del listado se seleccionara (doble clic) su nombre. 
'-	CAMPO FECHA: día que se guardará la o las  tareas realizadas.
'-	CAMPO ENTRADA: horario de entrada a la planta.
'-	CAMPO SALIDA: horario de salida de la planta.
'-	CAMPO CARGA HORARIA: cantidad (en minutos) del tiempo transcurrido dentro de la planta. 
'                Este campo es automático. (no debe llenarse).
'-	BOTON LIMPIAR: limpia o vacía cada uno de los campos de la fila (por ej. de la tarea 2). 
'-	CAMPO TAREA: la tarea o trabajo que se les ha asignado.
'-	CAMPO TIEMPO ESTIMADO: tiempo aproximado de trabajo asignado a esa tarea.
'-	CAMPO TIEMPO REAL: tiempo que le llevo la realización de la tarea. (obligatorio).
'-	CAMPO OBSERVACIONES: comentario o alguna información extra que sea importante con relación a esa tarea.
'-	BOTON ODT (está al lado del campo ot): abre el formulario de las órdenes, del listado se seleccionara (doble clic) 
'                la orden relacionada a la tarea que se les asigno. 
'-	BOTON GUARDAR: guarda la información cargada. 
'-	BOTON CANCELAR: cierra el formulario sin guardar los cambios.

'---------------------------------------------------------------------------------------------------------------------------

'El formulario de PRODUCTO consta de los siguientes datos: 

'- CAMPO CODIGO: código del producto.
'- CAMPO DESCRIPCION: descripción del producto.
'- STOCK MINIMO: stock mínimo actual de un producto.
'- CANTIDAD EN STOCK: cantidad de stock de un producto.

'- BOTON GUARDAR: guardará el nuevo producto.
'- BOTON ACTUALIZAR: modificará los datos de un producto.
'- BOTON EXPORTAR A PDF: generará un pdf mostrando los datos de un producto.
'- BOTON ELIMINAR: borrará un producto seleccionado.
'- BOTON CANCELAR:cerrará el formulario sin realizar cambios.
'- CHECK PRODUCTO: se buscará por nombre de producto.
'- CHECK CODIGO: se buscará por código de producto.
'- GRILLA PRODUCTOS: muestra el listado de todos los productos.

'-----------------------------------------------------------------------------

'FUNCIONAMIENTO FORMULARIO PRODUCTO: 

'1 - NUEVO PRODUCTO: 
'- completar todos los campos necesarios(campos con asterisco).
'- el botón guardar, guardará el producto.
'- los botones ACTUALIZAR, ELIMINAR, EXPORTAR A PDF estarán deshabilitados.
'- la grilla estará deshabilitada.

'2 - ACTUALIZAR PRODUCTO: 
'- se seleccionará de la grilla un producto al que se desea modificar sus datos.
'- el botón ACTUALIZAR, modificará los datos.
'- los botones GUARDAR, ELIMINAR, EXPORTAR A PDF estarán deshabilitados.
' - se podrán buscar los productos por su nombre o por su código, de acuerdo a lo que se seleccione.

'3 - ELIMINAR PRODUCTO: 
'- se seleccionará de la grilla un producto al que se desea eliminar.
' - el botón ELIMINAR, borrará el producto.
' - los botones GUARDAR, ACTUALIZAR, EXPORTAR A PDF estarán deshabilitados.
'- se podrán buscar los productos por su nombre o por su código, de acuerdo a lo que se seleccione.

'4 - CONSULTAR PRODUCTO: 
'- se seleccionará de la grilla un producto al que se desea consultar sus datos.
'- los datos seleccionados se mostrarán en su campo.
'- los botones GUARDAR, ACTUALIZAR, ELIMINAR, EXPORTAR A PDF estarán deshabilitados.
'- se podrán buscar los productos por su nombre o por su código, de acuerdo a lo que se seleccione.

'-------------------------------------------------------------------------------------------------------

'El formulario de ALTA/BAJA PRODUCTOS consta de los siguientes datos: 

'- CAMPO CODIGO: código del producto.
'- CAMPO DESCRIPCION: descripción del producto.
'- COMBO TIPO DE MOVIMIENTO: alta o baja del producto.
'- CAMPO ORDEN: número de orden de trabajo relacionada.
'- CAMPO CANTIDAD: nueva cantidad que se agregará al stock.
'- CAMPO INGRESE NOMBRE: búsqueda por nombre de producto.
'- BOTON BUSCAR ORDEN(...): abrirá el formulario de órdenes del gual se seleccionará mediante un doble click la orden seleccionada.
'- BOTON INGRESAR STOCK: guardará la cantidad del producto la cual se actualizará a la cantidad actual.
'- BOTON CANCELAR: cerrará el formulario sin hacer cambios.
'- GRILLA: muestra el listado de productos existentes.
'-----------------------------------------------------------------------------------------------------------------

'CAMPOS Y FUNCIONAMIENTO DE FORMULARIO MOVIMIENTO DE PRODUCTOS: 

'- COMBO MES: meses del año.
'- CAMPO PRODUCTO: búsqueda por nombre de producto.
'- GRILLA MOVIMIENTO DE PRODUCTOS: muestra el movimiento de un producto seleccionado.
'- BOTON EXPORTAR A PDF: genera un pdf con el movimiento(alta y baja) de un producto.
'- BOTON CANCELAR: cierra el formulario sin haber cambios.

'1 - se elegirá del combo el mes Y el producto a buscar
'2- la grilla mostrará las altas y bajas del producto en el mes seleccionado.

'---------------------------------------------------------------------------------------------------

