Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSQUEDA_IMPRONTO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub
    Sub BUSQUEDA_IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD," _
        & " TIPO_EDAD, FECHA_NAC, FECHA_ING, HORA_ING, TRASLADO, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, PADRE, MADRE, SALA_REMITENTE, " _
        & " PRIORIDAD, RESPONSABLE, PARENTEZCO, DIRECCION, TELEFONO1, TELEFONO2, RASGO, MOTIVO FROM IMPRONTO WHERE TIPO='" _
        & LBCLASIFICACION.Text & "' AND IDENTIDAD='" & LBIDENTIDAD.Text & "' ORDER BY FECHA_ING DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                If LBCLASIFICACION.Text = "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                ElseIf LBCLASIFICACION.Text <> "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("TIPO") & " " & DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                End If
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
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
                DGVGENERAL.Columns("TRASLADO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_REMITENTE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIORIDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RESPONSABLE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIRECCION").Width = 350 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RASGO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MOTIVO").Width = 300 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO"
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO"
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO"
                DGVGENERAL.Columns("TRASLADO").HeaderText = "PERSONA QUE TRASLADO AL PACIENTE"
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("SALA_REMITENTE").HeaderText = "SALA REMITENTE"
                DGVGENERAL.Columns("PRIORIDAD").HeaderText = "PRIORIDAD"
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "PERSONA DE CONTACTO"
                DGVGENERAL.Columns("PARENTEZCO").HeaderText = "PARENTEZCO"
                DGVGENERAL.Columns("DIRECCION").HeaderText = "DIRECCION DEL CONTACTO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO#1"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO#2"
                DGVGENERAL.Columns("RASGO").HeaderText = "RASGO FISICOS DEL PACIENTE"
                DGVGENERAL.Columns("MOTIVO").HeaderText = "MOTIVO DEL INGRESO DEL PACIENTE"
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
        & " TIPO_EDAD, FECHA_NAC, FECHA_ING, HORA_ING, TRASLADO, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, PADRE, MADRE, SALA_REMITENTE, " _
        & " PRIORIDAD, RESPONSABLE, PARENTEZCO, DIRECCION, TELEFONO1, TELEFONO2, RASGO, MOTIVO FROM IMPRONTO WHERE TIPO='" _
        & LBCLASIFICACION.Text & "' AND CORRELATIVO='" & LBIDENTIDAD.Text & "' ORDER BY FECHA_ING DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                If LBCLASIFICACION.Text = "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                ElseIf LBCLASIFICACION.Text <> "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("TIPO") & " " & DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                End If
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
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
                DGVGENERAL.Columns("TRASLADO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_REMITENTE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIORIDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RESPONSABLE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIRECCION").Width = 350 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RASGO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MOTIVO").Width = 300 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO"
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO"
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO"
                DGVGENERAL.Columns("TRASLADO").HeaderText = "PERSONA QUE TRASLADO AL PACIENTE"
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("SALA_REMITENTE").HeaderText = "SALA REMITENTE"
                DGVGENERAL.Columns("PRIORIDAD").HeaderText = "PRIORIDAD"
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "PERSONA DE CONTACTO"
                DGVGENERAL.Columns("PARENTEZCO").HeaderText = "PARENTEZCO"
                DGVGENERAL.Columns("DIRECCION").HeaderText = "DIRECCION DEL CONTACTO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO#1"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO#2"
                DGVGENERAL.Columns("RASGO").HeaderText = "RASGO FISICOS DEL PACIENTE"
                DGVGENERAL.Columns("MOTIVO").HeaderText = "MOTIVO DEL INGRESO DEL PACIENTE"
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
    Private Sub BTNACEPTAR_Click(sender As System.Object, e As System.EventArgs) Handles BTNACEPTAR.Click
        Dim A As Integer
        If DGVGENERAL.ColumnCount > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            REIMPRIMIR_IMPRONTO.CMBCLASIFICACION.Text = DGVGENERAL.Item(0, A).Value() 'TIPO
            REIMPRIMIR_IMPRONTO.TXTNOMBRES.Text = DGVGENERAL.Item(1, A).Value() 'NOMBRE DEL PACIENTE
            REIMPRIMIR_IMPRONTO.TXTPRIMERAPELLIDO.Text = DGVGENERAL.Item(2, A).Value() 'PRIMER APELLIDO
            REIMPRIMIR_IMPRONTO.TXTSEGUNDOAPELLIDO.Text = DGVGENERAL.Item(3, A).Value() 'NOMBRE DEL PACIENTE
            REIMPRIMIR_IMPRONTO.CMBSEXO.Text = DGVGENERAL.Item(4, A).Value() 'SEXO
            REIMPRIMIR_IMPRONTO.TXTIDENTIDAD.Text = DGVGENERAL.Item(5, A).Value() 'IDENTIDAD
            REIMPRIMIR_IMPRONTO.TXTCORRELATIVO.Text = DGVGENERAL.Item(6, A).Value() 'CORRELATIVO
            REIMPRIMIR_IMPRONTO.TXTEDAD.Text = DGVGENERAL.Item(7, A).Value() 'EDAD
            REIMPRIMIR_IMPRONTO.CMBTIPO.Text = DGVGENERAL.Item(8, A).Value() 'TIPO EDAD
            REIMPRIMIR_IMPRONTO.FN.Text = DGVGENERAL.Item(9, A).Value() 'FECHA NACIMIENTO
            REIMPRIMIR_IMPRONTO.INGRESO.Value = DGVGENERAL.Item(10, A).Value() 'FECHA INGRESO
            REIMPRIMIR_IMPRONTO.TXTFECHA_BUSQUEDA.Text = DGVGENERAL.Item(10, A).Value() 'FECHA INGRESO
            REIMPRIMIR_IMPRONTO.TXTHORA.Text = DGVGENERAL.Item(11, A).Value() 'HORA DE INGRESO
            REIMPRIMIR_IMPRONTO.TXTPERSONA.Text = DGVGENERAL.Item(12, A).Value() 'TRASLADO
            REIMPRIMIR_IMPRONTO.TXTCOLONIA.Text = DGVGENERAL.Item(13, A).Value() 'COLONIA
            REIMPRIMIR_IMPRONTO.TXTCASA.Text = DGVGENERAL.Item(14, A).Value() 'CASA
            REIMPRIMIR_IMPRONTO.CMBDEPARTAMENTO.Text = DGVGENERAL.Item(15, A).Value() 'DEPARTAMENTO
            REIMPRIMIR_IMPRONTO.CMBMUNICIPIO.Text = DGVGENERAL.Item(16, A).Value() 'MUNICIPIO
            REIMPRIMIR_IMPRONTO.TXTPADRE.Text = DGVGENERAL.Item(17, A).Value() 'PADRE
            REIMPRIMIR_IMPRONTO.TXTMADRE.Text = DGVGENERAL.Item(18, A).Value() 'MADRE
            REIMPRIMIR_IMPRONTO.TXTREMITENTE.Text = DGVGENERAL.Item(19, A).Value() 'SALA REMITENTE
            REIMPRIMIR_IMPRONTO.CMBPRIORIDAD.Text = DGVGENERAL.Item(20, A).Value() 'PRIORIDAD
            REIMPRIMIR_IMPRONTO.TXTRESPONSABLE.Text = DGVGENERAL.Item(21, A).Value() 'RESPONSABLE
            REIMPRIMIR_IMPRONTO.CMBPARENTEZCO.Text = DGVGENERAL.Item(22, A).Value() 'PARENTEZCO
            REIMPRIMIR_IMPRONTO.TXTDIRECCION.Text = DGVGENERAL.Item(23, A).Value() 'DIRECCION
            REIMPRIMIR_IMPRONTO.TXTTELEFONO1.Text = DGVGENERAL.Item(24, A).Value() 'TELEFONO 1
            REIMPRIMIR_IMPRONTO.TXTTELEFONO2.Text = DGVGENERAL.Item(25, A).Value() 'TELEFONO 2
            REIMPRIMIR_IMPRONTO.TXTFISICO.Text = DGVGENERAL.Item(26, A).Value() 'RASGO
            REIMPRIMIR_IMPRONTO.TXTMOTIVO.Text = DGVGENERAL.Item(27, A).Value() 'MOTIVO
        End If
        Me.Close()
    End Sub
    Private Sub BUSQUEDA_IMPRONTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "IDENTIDAD" Then
            BUSQUEDA_IDENTIDAD()
        ElseIf (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "CORRELATIVO" Then
            BUSQUEDA_CORRELATIVO()
        End If
    End Sub
End Class