Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSQUEDA_HOSPITALIZACION
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Sub BUSQUEDA_IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD," _
        & " TIPO_EDAD, FECHA_NAC, FECHA_ING, HORA_ING, CAST(SALA AS varchar(MAX)) AS SALA, CAST(SERVICIO AS varchar(MAX)) AS SERVICIO, " _
        & "COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, PADRE, MADRE, RESPONSABLE, PARENTEZCO, DIRECCION, TELEFONO1, TELEFONO2, " _
        & "ESTADO_CIVIL, OCUPACION, INGRESO FROM HOSPITALIZACION WHERE TIPO='" & LBCLASIFICACION.Text & "' AND IDENTIDAD='" _
        & LBIDENTIDAD.Text & "' ORDER BY FECHA_ING DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
                If LBCLASIFICACION.Text = "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                ElseIf LBCLASIFICACION.Text <> "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("TIPO") & " " & DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                End If
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ING").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SERVICIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RESPONSABLE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIRECCION").Width = 350 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO_CIVIL").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("OCUPACION").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INGRESO").Width = 200 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '0
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '1
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '2
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '3
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '4
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '5
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '6
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '7
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '8
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC." '9
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO" '10
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '11
                DGVGENERAL.Columns("SALA").HeaderText = "SALA" '12
                DGVGENERAL.Columns("SERVICIO").HeaderText = "SERVICIO" '13
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '14
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '15
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '16
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '17
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE" '18
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE" '19
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "PERSONA DE CONTACTO" '20
                DGVGENERAL.Columns("PARENTEZCO").HeaderText = "PARENTEZCO" '21
                DGVGENERAL.Columns("DIRECCION").HeaderText = "DIRECCION DEL CONTACTO" '22
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO#1" '23
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO#2" '24
                DGVGENERAL.Columns("ESTADO_CIVIL").HeaderText = "ESTADO CIVIL" '25
                DGVGENERAL.Columns("OCUPACION").HeaderText = "OCUPACION" '26
                DGVGENERAL.Columns("INGRESO").HeaderText = "TIPO DE INGRESO" '27
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO ALMACENADO CON EL HISTORIAL CLINICO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub BUSQUEDA_CORRELATIVO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD," _
        & " TIPO_EDAD, FECHA_NAC, FECHA_ING, HORA_ING, CAST(SALA AS varchar(MAX)) AS SALA, CAST(SERVICIO AS varchar(MAX)) AS SERVICIO, " _
        & "COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, PADRE, MADRE, RESPONSABLE, PARENTEZCO, DIRECCION, TELEFONO1, TELEFONO2, " _
        & "ESTADO_CIVIL, OCUPACION, INGRESO FROM HOSPITALIZACION WHERE TIPO='" & LBCLASIFICACION.Text & "' AND CORRELATIVO='" _
        & LBIDENTIDAD.Text & "' ORDER BY FECHA_ING DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
                If LBCLASIFICACION.Text = "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                ElseIf LBCLASIFICACION.Text <> "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("TIPO") & " " & DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                End If
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ING").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SERVICIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RESPONSABLE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIRECCION").Width = 350 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO_CIVIL").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("OCUPACION").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INGRESO").Width = 200 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '0
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '1
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '2
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '3
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '4
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '5
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '6
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '7
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '8
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC." '9
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO" '10
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '11
                DGVGENERAL.Columns("SALA").HeaderText = "SALA" '12
                DGVGENERAL.Columns("SERVICIO").HeaderText = "SERVICIO" '13
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '14
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '15
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '16
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '17
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE" '18
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE" '19
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "PERSONA DE CONTACTO" '20
                DGVGENERAL.Columns("PARENTEZCO").HeaderText = "PARENTEZCO" '21
                DGVGENERAL.Columns("DIRECCION").HeaderText = "DIRECCION DEL CONTACTO" '22
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO#1" '23
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO#2" '24
                DGVGENERAL.Columns("ESTADO_CIVIL").HeaderText = "ESTADO CIVIL" '25
                DGVGENERAL.Columns("OCUPACION").HeaderText = "OCUPACION" '26
                DGVGENERAL.Columns("INGRESO").HeaderText = "TIPO DE INGRESO" '27
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO ALMACENADO CON EL HISTORIAL CLINICO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub BUSQUEDA_HOSPITALIZACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "IDENTIDAD" Then
            BUSQUEDA_IDENTIDAD()
        ElseIf (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "CORRELATIVO" Then
            BUSQUEDA_CORRELATIVO()
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        Dim A As Integer
        If DGVGENERAL.ColumnCount > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            REIMPRIMIR_HOSPITALIZACION.CMBCLASIFICACION.Text = DGVGENERAL.Item(0, A).Value() 'TIPO
            REIMPRIMIR_HOSPITALIZACION.TXTNOMBRES.Text = DGVGENERAL.Item(1, A).Value() 'NOMBRE DEL PACIENTE
            REIMPRIMIR_HOSPITALIZACION.TXTPRIMERAPELLIDO.Text = DGVGENERAL.Item(2, A).Value() 'PRIMER APELLIDO
            REIMPRIMIR_HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Text = DGVGENERAL.Item(3, A).Value() 'NOMBRE DEL PACIENTE
            REIMPRIMIR_HOSPITALIZACION.CMBSEXO.Text = DGVGENERAL.Item(4, A).Value() 'SEXO
            REIMPRIMIR_HOSPITALIZACION.TXTIDENTIDAD.Text = DGVGENERAL.Item(5, A).Value() 'IDENTIDAD
            REIMPRIMIR_HOSPITALIZACION.TXTCORRELATIVO.Text = DGVGENERAL.Item(6, A).Value() 'CORRELATIVO
            REIMPRIMIR_HOSPITALIZACION.TXTEDAD.Text = DGVGENERAL.Item(7, A).Value() 'EDAD
            REIMPRIMIR_HOSPITALIZACION.CMBTIPO.Text = DGVGENERAL.Item(8, A).Value() 'TIPO EDAD
            REIMPRIMIR_HOSPITALIZACION.FN.Value = DGVGENERAL.Item(9, A).Value() 'FECHA NACIMIENTO
            REIMPRIMIR_HOSPITALIZACION.INGRESO.Value = DGVGENERAL.Item(10, A).Value() 'FECHA INGRESO
            REIMPRIMIR_HOSPITALIZACION.TXTFECHA_BUSQUEDA.Text = DGVGENERAL.Item(10, A).Value() 'FECHA INGRESO
            REIMPRIMIR_HOSPITALIZACION.TXTHORA.Text = DGVGENERAL.Item(11, A).Value() 'HORA DE INGRESO
            REIMPRIMIR_HOSPITALIZACION.TXTSALA.Text = DGVGENERAL.Item(12, A).Value() 'SALA
            REIMPRIMIR_HOSPITALIZACION.TXTSERVICIO.Text = DGVGENERAL.Item(13, A).Value() 'SERVICIO
            REIMPRIMIR_HOSPITALIZACION.TXTCOLONIA.Text = DGVGENERAL.Item(14, A).Value() 'COLONIA
            REIMPRIMIR_HOSPITALIZACION.TXTCASA.Text = DGVGENERAL.Item(15, A).Value() 'CASA
            REIMPRIMIR_HOSPITALIZACION.CMBDEPARTAMENTO.Text = DGVGENERAL.Item(16, A).Value() 'DEPARTAMENTO
            REIMPRIMIR_HOSPITALIZACION.CMBMUNICIPIO.Text = DGVGENERAL.Item(17, A).Value() 'MUNICIPIO
            REIMPRIMIR_HOSPITALIZACION.TXTPADRE.Text = DGVGENERAL.Item(18, A).Value() 'PADRE
            REIMPRIMIR_HOSPITALIZACION.TXTMADRE.Text = DGVGENERAL.Item(19, A).Value() 'MADRE
            REIMPRIMIR_HOSPITALIZACION.TXTRESPONSABLE.Text = DGVGENERAL.Item(20, A).Value() 'RESPONSABLE
            REIMPRIMIR_HOSPITALIZACION.CMBPARENTEZCO.Text = DGVGENERAL.Item(21, A).Value() 'PARENTEZCO
            REIMPRIMIR_HOSPITALIZACION.TXTDIRECCION.Text = DGVGENERAL.Item(22, A).Value() 'DIRECCION
            REIMPRIMIR_HOSPITALIZACION.TXTTELEFONO1.Text = DGVGENERAL.Item(23, A).Value() 'TELEFONO 1
            REIMPRIMIR_HOSPITALIZACION.TXTTELEFONO2.Text = DGVGENERAL.Item(24, A).Value() 'TELEFONO 2
            REIMPRIMIR_HOSPITALIZACION.CMBESTADO.Text = DGVGENERAL.Item(25, A).Value() 'ESTADO CIVIL
            REIMPRIMIR_HOSPITALIZACION.CMBOCUPACION.Text = DGVGENERAL.Item(26, A).Value() 'OCUPACION
            REIMPRIMIR_HOSPITALIZACION.CMBINGRESO.Text = DGVGENERAL.Item(27, A).Value() 'TIPO DE INGRESO
        End If
        Me.Close()
    End Sub
End Class