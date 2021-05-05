Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSCAR_DEF
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Sub BUSQUEDA_IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT EMP_RECIBE, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, " _
        & " EDAD, TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, PADRE, MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, " _
        & "TELEFONO1, TELEFONO2, SEXO, INGRESO, HORA_ING, RECEPCION, HORA_REC, REPORTE, FISCAL, HORA_FIS, CONTESTO, SALA_DEF, " _
        & " DEFUNCION, HORA_DEF, MEDICO, DIAGNOSTICO FROM DEFUNCION WHERE TIPO='" _
        & LBCLASIFICACION.Text & "' AND IDENTIDAD='" & LBIDENTIDAD.Text & "' ORDER BY DEFUNCION DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                If LBCLASIFICACION.Text = "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & _
                        DATO.Rows(0)("SEGUNDO_APELLIDO")
                ElseIf LBCLASIFICACION.Text <> "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("TIPO") & " " & DATO.Rows(0)("NOMBRE_PACIENTE") & " " & _
                        DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                End If
                DGVGENERAL.Columns("EMP_RECIBE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NACIONALIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PAIS").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INGRESO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RECEPCION").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_REC").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("REPORTE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FISCAL").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_FIS").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CONTESTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_DEF").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_DEF").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MEDICO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 500 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("EMP_RECIBE").HeaderText = "EMPLEADO RECIBIO" '1
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '2
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '3
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '4
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '5
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '6
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '7
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '8
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '9
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC." '10
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '11
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '12
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE" '13
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE" '14
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '15
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '16
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '17
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '18
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO#1" '19
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO#2" '20
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '21
                DGVGENERAL.Columns("INGRESO").HeaderText = "FECHA INGRESO" '22
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '23
                DGVGENERAL.Columns("RECEPCION").HeaderText = "FECHA DE RECEPCION" '24
                DGVGENERAL.Columns("HORA_REC").HeaderText = "HORA RECEPCION" '25
                DGVGENERAL.Columns("REPORTE").HeaderText = "QUIEN LO REPORTA" '26
                DGVGENERAL.Columns("FISCAL").HeaderText = "FECHA FISCALIA" '27
                DGVGENERAL.Columns("HORA_FIS").HeaderText = "HORA LLAMADA FISCAL" '28
                DGVGENERAL.Columns("CONTESTO").HeaderText = "QUIEN CONTESTO" '29
                DGVGENERAL.Columns("SALA_DEF").HeaderText = "SALA DONDE FALLECIO" '30
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "FECHA DE DEFUNCION" '31
                DGVGENERAL.Columns("HORA_DEF").HeaderText = "HORA DE DEFUNCION" '32
                DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO QUIEN HIZO LA DEFUNCION" '33
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO DE DEFUNCION" '34
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
        Dim COMANDO As String = "SELECT EMP_RECIBE, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, " _
        & " EDAD, TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, PADRE, MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, " _
        & "TELEFONO1, TELEFONO2, SEXO, INGRESO, HORA_ING, RECEPCION, HORA_REC, REPORTE, FISCAL, HORA_FIS, CONTESTO, SALA_DEF, " _
        & " DEFUNCION, HORA_DEF, MEDICO, DIAGNOSTICO FROM DEFUNCION WHERE TIPO='" _
        & LBCLASIFICACION.Text & "' AND CORRELATIVO='" & LBIDENTIDAD.Text & "' ORDER BY DEFUNCION DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                If LBCLASIFICACION.Text = "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & _
                        DATO.Rows(0)("SEGUNDO_APELLIDO")
                ElseIf LBCLASIFICACION.Text <> "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("TIPO") & " " & DATO.Rows(0)("NOMBRE_PACIENTE") & " " & _
                        DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                End If
                DGVGENERAL.Columns("EMP_RECIBE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NACIONALIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PAIS").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INGRESO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RECEPCION").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_REC").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("REPORTE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FISCAL").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_FIS").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CONTESTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_DEF").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_DEF").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MEDICO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 500 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("EMP_RECIBE").HeaderText = "EMPLEADO RECIBIO" '1
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '2
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '3
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '4
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '5
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '6
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '7
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '8
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '9
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC." '10
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '11
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '12
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE" '13
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE" '14
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '15
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '16
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '17
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '18
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO#1" '19
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO#2" '20
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '21
                DGVGENERAL.Columns("INGRESO").HeaderText = "FECHA INGRESO" '22
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '23
                DGVGENERAL.Columns("RECEPCION").HeaderText = "FECHA DE RECEPCION" '24
                DGVGENERAL.Columns("HORA_REC").HeaderText = "HORA RECEPCION" '25
                DGVGENERAL.Columns("REPORTE").HeaderText = "QUIEN LO REPORTA" '26
                DGVGENERAL.Columns("FISCAL").HeaderText = "FECHA FISCALIA" '27
                DGVGENERAL.Columns("HORA_FIS").HeaderText = "HORA LLAMADA FISCAL" '28
                DGVGENERAL.Columns("CONTESTO").HeaderText = "QUIEN CONTESTO" '29
                DGVGENERAL.Columns("SALA_DEF").HeaderText = "SALA DONDE FALLECIO" '30
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "FECHA DE DEFUNCION" '31
                DGVGENERAL.Columns("HORA_DEF").HeaderText = "HORA DE DEFUNCION" '32
                DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO QUIEN HIZO LA DEFUNCION" '33
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO DE DEFUNCION" '34
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
    Private Sub BUSCAR_DEF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            DGVGENERAL.Columns("EMP_RECIBE").HeaderText = "EMPLEADO RECIBIO" '0
            DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '1
            DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '2
            DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '3
            DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '4
            DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '5
            DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '6
            DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '7
            DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '8
            DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC." '9
            DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '10
            DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '11
            DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE" '12
            DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE" '13
            DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '14
            DGVGENERAL.Columns("CASA").HeaderText = "CASA" '15
            DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '16
            DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '17
            DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO#1" '18
            DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO#2" '19
            DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '20
            DGVGENERAL.Columns("INGRESO").HeaderText = "FECHA INGRESO" '21
            DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '22
            DGVGENERAL.Columns("RECEPCION").HeaderText = "FECHA DE RECEPCION" '23
            DGVGENERAL.Columns("HORA_REC").HeaderText = "HORA RECEPCION" '24
            DGVGENERAL.Columns("REPORTE").HeaderText = "QUIEN LO REPORTA" '25
            DGVGENERAL.Columns("FISCAL").HeaderText = "FECHA FISCALIA" '26
            DGVGENERAL.Columns("HORA_FIS").HeaderText = "HORA LLAMADA FISCAL" '27
            DGVGENERAL.Columns("CONTESTO").HeaderText = "QUIEN CONTESTO" '28
            DGVGENERAL.Columns("SALA_DEF").HeaderText = "SALA DONDE FALLECIO" '29
            DGVGENERAL.Columns("DEFUNCION").HeaderText = "FECHA DE DEFUNCION" '30
            DGVGENERAL.Columns("HORA_DEF").HeaderText = "HORA DE DEFUNCION" '31
            DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO QUIEN HIZO LA DEFUNCION" '32
            DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO DE DEFUNCION" '33
            REIMPRIMIRDEF.TXTEMPLEADO.Text = DGVGENERAL.Item(0, A).Value() 'NOMBRE DEL EMPELADO QUE RECIBIO 
            REIMPRIMIRDEF.TXTPAIS.Text = DGVGENERAL.Item(2, A).Value() ' PAIS
            REIMPRIMIRDEF.TXTNOMBRES.Text = DGVGENERAL.Item(4, A).Value() 'NOMBRES
            REIMPRIMIRDEF.TXTPRIMERAPELLIDO.Text = DGVGENERAL.Item(5, A).Value() 'PRIMER APELLIDO
            REIMPRIMIRDEF.TXTSEGUNDOAPELLIDO.Text = DGVGENERAL.Item(6, A).Value() 'SEGUNDO APELLIDO
            REIMPRIMIRDEF.TXTEDAD.Text = DGVGENERAL.Item(7, A).Value() 'EDAD
            REIMPRIMIRDEF.CMBTIPO.Text = DGVGENERAL.Item(8, A).Value() 'TIPO EDAD
            REIMPRIMIRDEF.FN.Text = DGVGENERAL.Item(9, A).Value() 'FECHA DE NACIMIENTO
            REIMPRIMIRDEF.TXTCORRELATIVO.Text = DGVGENERAL.Item(10, A).Value() 'CORRELATIVO
            REIMPRIMIRDEF.TXTIDENTIDAD.Text = DGVGENERAL.Item(11, A).Value() 'IDENTIDAD
            REIMPRIMIRDEF.TXTPADRE.Text = DGVGENERAL.Item(12, A).Value() 'PADRE
            REIMPRIMIRDEF.TXTMADRE.Text = DGVGENERAL.Item(13, A).Value() 'MADRE
            REIMPRIMIRDEF.TXTCOLONIA.Text = DGVGENERAL.Item(14, A).Value() 'COLONIA
            REIMPRIMIRDEF.TXTCASA.Text = DGVGENERAL.Item(15, A).Value() 'CASA
            REIMPRIMIRDEF.CMBDEPARTAMENTO.Text = DGVGENERAL.Item(16, A).Value() 'DEPARTAMENTO
            REIMPRIMIRDEF.CMBMUNICIPIO.Text = DGVGENERAL.Item(17, A).Value() 'MUNICIPIO
            REIMPRIMIRDEF.CMBSEXO.Text = DGVGENERAL.Item(20, A).Value() 'SEXO
            REIMPRIMIRDEF.INGRESO.Text = DGVGENERAL.Item(21, A).Value() 'FECHA INGRESO DE IMPRONTO
            REIMPRIMIRDEF.HORA_INGRESO.Text = DGVGENERAL.Item(22, A).Value() 'HORA DE INGRESO DE IMPRONTO
            REIMPRIMIRDEF.RECEPCION.Text = DGVGENERAL.Item(23, A).Value() ' FECHA DE RECEPCION
            REIMPRIMIRDEF.HORA_RECEPCION.Text = DGVGENERAL.Item(24, A).Value() 'HORA DE RECEPCION
            REIMPRIMIRDEF.TXTREPORTE.Text = DGVGENERAL.Item(25, A).Value() 'QUIEN LO REPORTA
            REIMPRIMIRDEF.FISCALIA.Text = Convert.ToString(DGVGENERAL.Item(26, A).Value()) ' FECHA FISCALIA
            REIMPRIMIRDEF.HORA_FISCALIA.Text = Convert.ToString(DGVGENERAL.Item(27, A).Value()) 'HORA QUE SE LLAMO A LA FISCALIA
            REIMPRIMIRDEF.TXTFISCALIA.Text = Convert.ToString(DGVGENERAL.Item(28, A).Value()) ' QUIEN CONTESTO EN LA FISCALIA
            REIMPRIMIRDEF.TXTSALA.Text = DGVGENERAL.Item(29, A).Value() ' SALA DE FALLECIMIENTO
            REIMPRIMIRDEF.DEFUNCION.Text = DGVGENERAL.Item(30, A).Value() 'FECHA DE DEFUNCION
            REIMPRIMIRDEF.HORA_DEFUNCION.Text = DGVGENERAL.Item(31, A).Value() 'HORA DEFUNCION
            REIMPRIMIRDEF.TXTMEDICO.Text = DGVGENERAL.Item(32, A).Value() 'MEDICO QUE LLENO LA DEFUNCION
            REIMPRIMIRDEF.TXTDIAGNOSTICO.Text = DGVGENERAL.Item(33, A).Value() 'DIAGNOSTICO CON EL QUE FALLECIO EL PACIENTE
            REIMPRIMIRDEF.TXTFECHA_BUSQUEDA.Text = DGVGENERAL.Item(30, A).Value() 'FECHA DE BUSQUEDA DEFUNCION
        End If
        Me.Close()
    End Sub
End Class