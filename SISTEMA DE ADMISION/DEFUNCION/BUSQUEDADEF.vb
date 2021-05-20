Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSQUEDADEF
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Private Sub BUSQUEDADEF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBTIPO.Text = ""
        For I As Integer = 0 To DGVGENERAL.Rows.Count - 1
            If DGVGENERAL.Rows(I).Selected = True Then
                If DGVGENERAL.Item(3, I).Value() = "NORMAL" Then
                    LBTIPO.Text = "NORMAL = POSEE IDENTIDAD"
                ElseIf DGVGENERAL.Item(3, I).Value() = "RN#1" Or DGVGENERAL.Item(3, I).Value() = "RN#2" Or _
                    DGVGENERAL.Item(3, I).Value() = "RN#3" Then
                    LBTIPO.Text = "RECIEN NACIDO"
                ElseIf DGVGENERAL.Item(3, I).Value() = "OBITO_1" Or DGVGENERAL.Item(3, I).Value() = "OBITO_2" Or _
                    DGVGENERAL.Item(3, I).Value() = "OBITO_3" Then
                    LBTIPO.Text = "OBITO"
                ElseIf DGVGENERAL.Item(3, I).Value() = "HIJO_1" Or DGVGENERAL.Item(3, I).Value() = "HIJO_2" Or _
                    DGVGENERAL.Item(3, I).Value() = "HIJO_3" Then
                    LBTIPO.Text = "HIJO"
                ElseIf DGVGENERAL.Item(3, I).Value() = "RN_GEMELO_1" Or DGVGENERAL.Item(3, I).Value() = "RN_GEMELO_2" Or _
                DGVGENERAL.Item(3, I).Value() = "RN_GEMELO_3" Then
                    LBTIPO.Text = "RECIEN NACIDO GEMELO"
                End If
            End If
        Next
        If CMBCLASIFICACION.Text = "" And CMBNACIONALIDAD.Text = "" And CMBBUSQUEDA.Text = "" Then
            Me.Close()
        End If
    End Sub
    Sub GIDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
        & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
        & "NOMBRE_PADRE, NOMBRE_MADRE, FECHA_NACIMIENTO, DEFUNCION FROM UNICO WHERE IDENTIDAD='" _
        & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NO").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("PAIS").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NACIMIENTO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "ITEM" '0
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '1
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '2
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '3
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE" '4
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '5
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '6
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '7
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '8
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '9
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '10
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '11
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '12
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '13
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '14
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO" '15
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO" '16
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '17
                DGVGENERAL.Columns("NOMBRE_PADRE").HeaderText = "NOMBRE DEL PADRE" '18
                DGVGENERAL.Columns("NOMBRE_MADRE").HeaderText = "NOMBRE DE LA MADRE" '19
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC." '20
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "DEFUNCION" '21
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                REC_DEFUNCION.TXTNOMBRES.Enabled = True : REC_DEFUNCION.TXTPRIMERAPELLIDO.Enabled = True
                REC_DEFUNCION.TXTSEGUNDOAPELLIDO.Enabled = True : REC_DEFUNCION.TXTCORRELATIVO.Enabled = False
                REC_DEFUNCION.TXTCOLONIA.Enabled = True : REC_DEFUNCION.TXTCASA.Enabled = True
                REC_DEFUNCION.CMBDEPARTAMENTO.Enabled = True : REC_DEFUNCION.CMBMUNICIPIO.Enabled = True
                REC_DEFUNCION.TXTTELEFONO1.Enabled = True : REC_DEFUNCION.TXTTELEFONO2.Enabled = True
                REC_DEFUNCION.CMBSEXO.Enabled = True : REC_DEFUNCION.FN.Enabled = True
                REC_DEFUNCION.TXTPADRE.Enabled = True : REC_DEFUNCION.TXTMADRE.Enabled = True
                REC_DEFUNCION.TXTEDAD.Enabled = True : REC_DEFUNCION.CMBTIPO.Enabled = True
                REC_DEFUNCION.TXTSALA.Enabled = True : REC_DEFUNCION.TXTDIAGNOSTICO.Enabled = True
                REC_DEFUNCION.BTNSALA.Visible = True : REC_DEFUNCION.BTNINGRESO.Visible = True
                REC_DEFUNCION.TXTMEDICO.Enabled = True
                REC_DEFUNCION.DEFUNCION.Enabled = True : REC_DEFUNCION.HORA_DEFUNCION.Enabled = True
                REC_DEFUNCION.TXTREPORTE.Enabled = True : REC_DEFUNCION.RECEPCION.Enabled = True
                REC_DEFUNCION.HORA_RECEPCION.Enabled = True
                REC_DEFUNCION.FISCALIA.Enabled = True : REC_DEFUNCION.HORA_FISCALIA.Enabled = True
                REC_DEFUNCION.TXTFISCALIA.Enabled = True
                REC_DEFUNCION.BTNGUARDAR.Enabled = True : REC_DEFUNCION.BTNMODIFICAR.Enabled = False
                REC_DEFUNCION.TXTIDENTIDAD.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub EIDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
        & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
        & "NOMBRE_PADRE, NOMBRE_MADRE, FECHA_NACIMIENTO, DEFUNCION  FROM UNICO WHERE TIPO='" _
        & CMBCLASIFICACION.Text & "' AND IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NO").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("PAIS").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NACIMIENTO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "ITEM" '0
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '1
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '2
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '3
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE" '4
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '5
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '6
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '7
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '8
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '9
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '10
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '11
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '12
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '13
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '14
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO" '15
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO" '16
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '17
                DGVGENERAL.Columns("NOMBRE_PADRE").HeaderText = "NOMBRE DEL PADRE" '18
                DGVGENERAL.Columns("NOMBRE_MADRE").HeaderText = "NOMBRE DE LA MADRE" '19
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC." '20
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "DEFUNCION" '21
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                REC_DEFUNCION.TXTNOMBRES.Enabled = True : REC_DEFUNCION.TXTPRIMERAPELLIDO.Enabled = True
                REC_DEFUNCION.TXTSEGUNDOAPELLIDO.Enabled = True : REC_DEFUNCION.TXTCORRELATIVO.Enabled = False
                REC_DEFUNCION.TXTCOLONIA.Enabled = True : REC_DEFUNCION.TXTCASA.Enabled = True
                REC_DEFUNCION.CMBDEPARTAMENTO.Enabled = True : REC_DEFUNCION.CMBMUNICIPIO.Enabled = True
                REC_DEFUNCION.TXTTELEFONO1.Enabled = True : REC_DEFUNCION.TXTTELEFONO2.Enabled = True
                REC_DEFUNCION.CMBSEXO.Enabled = True : REC_DEFUNCION.FN.Enabled = True
                REC_DEFUNCION.TXTPADRE.Enabled = True : REC_DEFUNCION.TXTMADRE.Enabled = True
                REC_DEFUNCION.TXTEDAD.Enabled = True : REC_DEFUNCION.CMBTIPO.Enabled = True
                REC_DEFUNCION.TXTSALA.Enabled = True : REC_DEFUNCION.TXTDIAGNOSTICO.Enabled = True
                REC_DEFUNCION.BTNSALA.Visible = True : REC_DEFUNCION.BTNINGRESO.Visible = True
                REC_DEFUNCION.TXTMEDICO.Enabled = True
                REC_DEFUNCION.DEFUNCION.Enabled = True : REC_DEFUNCION.HORA_DEFUNCION.Enabled = True
                REC_DEFUNCION.TXTREPORTE.Enabled = True : REC_DEFUNCION.RECEPCION.Enabled = True
                REC_DEFUNCION.HORA_RECEPCION.Enabled = True
                REC_DEFUNCION.FISCALIA.Enabled = True : REC_DEFUNCION.HORA_FISCALIA.Enabled = True
                REC_DEFUNCION.TXTFISCALIA.Enabled = True
                REC_DEFUNCION.BTNGUARDAR.Enabled = True : REC_DEFUNCION.BTNMODIFICAR.Enabled = False
                REC_DEFUNCION.TXTIDENTIDAD.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub GCORRELATIVO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
        & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
        & "NOMBRE_PADRE, NOMBRE_MADRE, FECHA_NACIMIENTO, DEFUNCION FROM UNICO WHERE CORRELATIVO='" _
        & TXTCORRELATIVO.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NO").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("PAIS").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NACIMIENTO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "ITEM" '0
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '1
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '2
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '3
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE" '4
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '5
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '6
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '7
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '8
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '9
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '10
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '11
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '12
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '13
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '14
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO" '15
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO" '16
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '17
                DGVGENERAL.Columns("NOMBRE_PADRE").HeaderText = "NOMBRE DEL PADRE" '18
                DGVGENERAL.Columns("NOMBRE_MADRE").HeaderText = "NOMBRE DE LA MADRE" '19
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC." '20
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "DEFUNCION" '21
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                REC_DEFUNCION.TXTNOMBRES.Enabled = True : REC_DEFUNCION.TXTPRIMERAPELLIDO.Enabled = True
                REC_DEFUNCION.TXTSEGUNDOAPELLIDO.Enabled = True : REC_DEFUNCION.TXTCORRELATIVO.Enabled = False
                REC_DEFUNCION.TXTCOLONIA.Enabled = True : REC_DEFUNCION.TXTCASA.Enabled = True
                REC_DEFUNCION.CMBDEPARTAMENTO.Enabled = True : REC_DEFUNCION.CMBMUNICIPIO.Enabled = True
                REC_DEFUNCION.TXTTELEFONO1.Enabled = True : REC_DEFUNCION.TXTTELEFONO2.Enabled = True
                REC_DEFUNCION.CMBSEXO.Enabled = True : REC_DEFUNCION.FN.Enabled = True
                REC_DEFUNCION.TXTPADRE.Enabled = True : REC_DEFUNCION.TXTMADRE.Enabled = True
                REC_DEFUNCION.TXTEDAD.Enabled = True : REC_DEFUNCION.CMBTIPO.Enabled = True
                REC_DEFUNCION.TXTSALA.Enabled = True : REC_DEFUNCION.TXTDIAGNOSTICO.Enabled = True
                REC_DEFUNCION.BTNSALA.Visible = True : REC_DEFUNCION.BTNINGRESO.Visible = True
                REC_DEFUNCION.TXTMEDICO.Enabled = True
                REC_DEFUNCION.DEFUNCION.Enabled = True : REC_DEFUNCION.HORA_DEFUNCION.Enabled = True
                REC_DEFUNCION.TXTREPORTE.Enabled = True : REC_DEFUNCION.RECEPCION.Enabled = True
                REC_DEFUNCION.HORA_RECEPCION.Enabled = True
                REC_DEFUNCION.FISCALIA.Enabled = True : REC_DEFUNCION.HORA_FISCALIA.Enabled = True
                REC_DEFUNCION.TXTFISCALIA.Enabled = True
                REC_DEFUNCION.BTNGUARDAR.Enabled = True : REC_DEFUNCION.BTNMODIFICAR.Enabled = False
                REC_DEFUNCION.TXTIDENTIDAD.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub ECORRELATIVO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
        & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
        & "NOMBRE_PADRE, NOMBRE_MADRE, FECHA_NACIMIENTO, DEFUNCION  FROM UNICO WHERE TIPO='" _
        & CMBCLASIFICACION.Text & "' AND CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NO").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("PAIS").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NACIMIENTO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "ITEM" '0
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '1
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '2
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '3
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE" '4
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '5
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '6
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '7
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '8
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '9
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '10
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '11
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '12
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '13
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '14
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO" '15
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO" '16
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '17
                DGVGENERAL.Columns("NOMBRE_PADRE").HeaderText = "NOMBRE DEL PADRE" '18
                DGVGENERAL.Columns("NOMBRE_MADRE").HeaderText = "NOMBRE DE LA MADRE" '19
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC." '20
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "DEFUNCION" '21
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                REC_DEFUNCION.TXTNOMBRES.Enabled = True : REC_DEFUNCION.TXTPRIMERAPELLIDO.Enabled = True
                REC_DEFUNCION.TXTSEGUNDOAPELLIDO.Enabled = True : REC_DEFUNCION.TXTCORRELATIVO.Enabled = False
                REC_DEFUNCION.TXTCOLONIA.Enabled = True : REC_DEFUNCION.TXTCASA.Enabled = True
                REC_DEFUNCION.CMBDEPARTAMENTO.Enabled = True : REC_DEFUNCION.CMBMUNICIPIO.Enabled = True
                REC_DEFUNCION.TXTTELEFONO1.Enabled = True : REC_DEFUNCION.TXTTELEFONO2.Enabled = True
                REC_DEFUNCION.CMBSEXO.Enabled = True : REC_DEFUNCION.FN.Enabled = True
                REC_DEFUNCION.TXTPADRE.Enabled = True : REC_DEFUNCION.TXTMADRE.Enabled = True
                REC_DEFUNCION.TXTEDAD.Enabled = True : REC_DEFUNCION.CMBTIPO.Enabled = True
                REC_DEFUNCION.TXTSALA.Enabled = True : REC_DEFUNCION.TXTDIAGNOSTICO.Enabled = True
                REC_DEFUNCION.BTNSALA.Visible = True : REC_DEFUNCION.BTNINGRESO.Visible = True
                REC_DEFUNCION.TXTMEDICO.Enabled = True
                REC_DEFUNCION.DEFUNCION.Enabled = True : REC_DEFUNCION.HORA_DEFUNCION.Enabled = True
                REC_DEFUNCION.TXTREPORTE.Enabled = True : REC_DEFUNCION.RECEPCION.Enabled = True
                REC_DEFUNCION.HORA_RECEPCION.Enabled = True
                REC_DEFUNCION.FISCALIA.Enabled = True : REC_DEFUNCION.HORA_FISCALIA.Enabled = True
                REC_DEFUNCION.TXTFISCALIA.Enabled = True
                REC_DEFUNCION.BTNGUARDAR.Enabled = True : REC_DEFUNCION.BTNMODIFICAR.Enabled = False
                REC_DEFUNCION.TXTIDENTIDAD.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub ESPECIFICO()
        DGVGENERAL.Columns.Clear()
        If TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000" Then
            EIDENTIDAD()
        ElseIf TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
            ECORRELATIVO()
        ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
            EIDENTIDAD()
        End If
    End Sub
    Private Sub CBNO_CheckedChanged(sender As Object, e As EventArgs) Handles CBNO.CheckedChanged
        If CBNO.Checked = True Then
            CBSI.Checked = False
            ESPECIFICO()
        ElseIf CBNO.Checked = False Then
            CBSI.Checked = True
            GENERAL()
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        DGVGENERAL.Columns.Clear()
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
    End Sub

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        DGVGENERAL.Columns.Clear()
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
    End Sub
    Sub GENERAL()
        DGVGENERAL.Columns.Clear()
        If TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000" Then
            GIDENTIDAD()
        ElseIf TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
            GCORRELATIVO()
        ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
            GIDENTIDAD()
        End If
    End Sub
    Private Sub CBSI_CheckedChanged(sender As Object, e As EventArgs) Handles CBSI.CheckedChanged
        If CBSI.Checked = True Then
            CBNO.Checked = False
            GENERAL()
        ElseIf CBSI.Checked = False Then
            CBNO.Checked = True
            ESPECIFICO()
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        REC_DEFUNCION.TXTNOMBRES.Enabled = True : REC_DEFUNCION.TXTPRIMERAPELLIDO.Enabled = True
        REC_DEFUNCION.TXTSEGUNDOAPELLIDO.Enabled = True : REC_DEFUNCION.TXTCORRELATIVO.Enabled = False
        REC_DEFUNCION.TXTCOLONIA.Enabled = True : REC_DEFUNCION.TXTCASA.Enabled = True
        REC_DEFUNCION.CMBDEPARTAMENTO.Enabled = True : REC_DEFUNCION.CMBMUNICIPIO.Enabled = True
        REC_DEFUNCION.TXTTELEFONO1.Enabled = True : REC_DEFUNCION.TXTTELEFONO2.Enabled = True
        REC_DEFUNCION.CMBSEXO.Enabled = True : REC_DEFUNCION.FN.Enabled = True
        REC_DEFUNCION.TXTPADRE.Enabled = True : REC_DEFUNCION.TXTMADRE.Enabled = True
        REC_DEFUNCION.TXTEDAD.Enabled = True : REC_DEFUNCION.CMBTIPO.Enabled = True
        REC_DEFUNCION.TXTSALA.Enabled = True : REC_DEFUNCION.BTNSALA.Visible = True
        REC_DEFUNCION.TXTPAIS.Enabled = True : REC_DEFUNCION.DEFUNCION.Enabled = True
        REC_DEFUNCION.HORA_DEFUNCION.Enabled = True
        REC_DEFUNCION.TXTMEDICO.Enabled = True : REC_DEFUNCION.TXTDIAGNOSTICO.Enabled = True
        REC_DEFUNCION.INGRESO.Enabled = True : REC_DEFUNCION.HORA_INGRESO.Enabled = True
        REC_DEFUNCION.BTNINGRESO.Visible = True
        REC_DEFUNCION.TXTREPORTE.Enabled = True : REC_DEFUNCION.RECEPCION.Enabled = True
        REC_DEFUNCION.HORA_RECEPCION.Enabled = True
        REC_DEFUNCION.TXTFISCALIA.Enabled = True : REC_DEFUNCION.FISCALIA.Enabled = True
        REC_DEFUNCION.HORA_FISCALIA.Enabled = True
        REC_DEFUNCION.BTNGUARDAR.Enabled = True : REC_DEFUNCION.BTNMODIFICAR.Enabled = False
        REC_DEFUNCION.TXTIDENTIDAD.Focus()
        Me.Close()
    End Sub

    Private Sub BTNCAEPTAR_Click(sender As Object, e As EventArgs) Handles BTNCAEPTAR.Click
        Try
            Dim A As Integer
            If DGVGENERAL.Rows.Count > 0 Then
                A = DGVGENERAL.CurrentRow.Index
                If DGVGENERAL.Item(21, A).Value() = "0101-01-01" Then
                    REC_DEFUNCION.CMBCLASIFICACION.Text = DGVGENERAL.Item(3, A).Value() 'TIPO CLASIFICACION
                    REC_DEFUNCION.CMBNACIONALIDAD.Text = DGVGENERAL.Item(1, A).Value() ' NACIONALIDAD
                    REC_DEFUNCION.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text 'TIPO BSUQUEDA
                    REC_DEFUNCION.TXTIDENTIDAD.Text = DGVGENERAL.Item(10, A).Value() 'IDENTIDAD
                    REC_DEFUNCION.TXTCORRELATIVO.Text = DGVGENERAL.Item(9, A).Value() 'CORRELATIVO
                    REC_DEFUNCION.TXTPAIS.Text = DGVGENERAL.Item(2, A).Value() 'PAIS
                    REC_DEFUNCION.TXTNOMBRES.Text = DGVGENERAL.Item(4, A).Value() 'NOMBRE DEL PACIENTE
                    REC_DEFUNCION.TXTPRIMERAPELLIDO.Text = DGVGENERAL.Item(5, A).Value() 'PRIMER APELLIDO
                    REC_DEFUNCION.TXTSEGUNDOAPELLIDO.Text = DGVGENERAL.Item(6, A).Value() 'SEGUNDO APELLIDO
                    REC_DEFUNCION.TXTCOLONIA.Text = DGVGENERAL.Item(11, A).Value() 'COLONIA
                    REC_DEFUNCION.TXTCASA.Text = DGVGENERAL.Item(12, A).Value() 'CASA
                    REC_DEFUNCION.CMBDEPARTAMENTO.Text = DGVGENERAL.Item(13, A).Value() 'DEPARTAMENTO
                    REC_DEFUNCION.CMBMUNICIPIO.Text = DGVGENERAL.Item(14, A).Value() 'MUNICIPIO
                    REC_DEFUNCION.TXTTELEFONO1.Text = DGVGENERAL.Item(15, A).Value() 'TELEFONO 1
                    REC_DEFUNCION.TXTTELEFONO2.Text = DGVGENERAL.Item(16, A).Value() 'TELEFONO 2
                    REC_DEFUNCION.CMBSEXO.Text = DGVGENERAL.Item(17, A).Value() 'SEXO
                    REC_DEFUNCION.TXTPADRE.Text = DGVGENERAL.Item(18, A).Value() 'PADRE
                    REC_DEFUNCION.TXTMADRE.Text = DGVGENERAL.Item(19, A).Value() 'MADRE
                    If DGVGENERAL.Item(20, A).Value() <> "0101-01-01" Then
                        REC_DEFUNCION.FN.Value = DGVGENERAL.Item(20, A).Value() 'FECHA NACIMIENTO
                        REC_DEFUNCION.CBFN.Checked = False
                    ElseIf DGVGENERAL.Item(20, A).Value() = "0101-01-01" Then
                        REC_DEFUNCION.FN.Value = DateTime.Now.Date
                        REC_DEFUNCION.CBFN.Checked = True
                    End If
                    REC_DEFUNCION.TXTNOMBRES.Enabled = True : REC_DEFUNCION.TXTPRIMERAPELLIDO.Enabled = True
                    REC_DEFUNCION.TXTSEGUNDOAPELLIDO.Enabled = True : REC_DEFUNCION.TXTCORRELATIVO.Enabled = False
                    REC_DEFUNCION.TXTCOLONIA.Enabled = True : REC_DEFUNCION.TXTCASA.Enabled = True
                    REC_DEFUNCION.CMBDEPARTAMENTO.Enabled = True : REC_DEFUNCION.CMBMUNICIPIO.Enabled = True
                    REC_DEFUNCION.TXTTELEFONO1.Enabled = True : REC_DEFUNCION.TXTTELEFONO2.Enabled = True
                    REC_DEFUNCION.CMBSEXO.Enabled = True : REC_DEFUNCION.FN.Enabled = True
                    REC_DEFUNCION.TXTPADRE.Enabled = True : REC_DEFUNCION.TXTMADRE.Enabled = True
                    REC_DEFUNCION.TXTEDAD.Enabled = True : REC_DEFUNCION.CMBTIPO.Enabled = True
                    REC_DEFUNCION.TXTSALA.Enabled = True : REC_DEFUNCION.BTNSALA.Visible = True
                    REC_DEFUNCION.TXTPAIS.Enabled = True : REC_DEFUNCION.DEFUNCION.Enabled = True
                    REC_DEFUNCION.HORA_DEFUNCION.Enabled = True
                    REC_DEFUNCION.TXTMEDICO.Enabled = True : REC_DEFUNCION.TXTDIAGNOSTICO.Enabled = True
                    REC_DEFUNCION.INGRESO.Enabled = True : REC_DEFUNCION.HORA_INGRESO.Enabled = True
                    REC_DEFUNCION.BTNINGRESO.Visible = True
                    REC_DEFUNCION.TXTREPORTE.Enabled = True : REC_DEFUNCION.RECEPCION.Enabled = True
                    REC_DEFUNCION.HORA_RECEPCION.Enabled = True
                    REC_DEFUNCION.TXTFISCALIA.Enabled = True : REC_DEFUNCION.FISCALIA.Enabled = True
                    REC_DEFUNCION.HORA_FISCALIA.Enabled = True
                    REC_DEFUNCION.BTNGUARDAR.Enabled = False : REC_DEFUNCION.BTNMODIFICAR.Enabled = True
                    REC_DEFUNCION.TXTIDENTIDAD.Focus()
                    Me.Close()
                ElseIf DGVGENERAL.Item(21, A).Value() <> "0101-01-01" Then
                    MsgBox("NO SE PUEDE USAR EL REGISTRO YA QUE TIENE UNA FECHA DE DEFUNCION: " _
                           & DGVGENERAL.Item(21, A).Value() & Chr(13) _
                           & "SELECCIONE OTRO ITEM", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    REC_DEFUNCION.TXTNOMBRES.Enabled = True : REC_DEFUNCION.TXTPRIMERAPELLIDO.Enabled = True
                    REC_DEFUNCION.TXTSEGUNDOAPELLIDO.Enabled = True : REC_DEFUNCION.TXTCORRELATIVO.Enabled = False
                    REC_DEFUNCION.TXTCOLONIA.Enabled = True : REC_DEFUNCION.TXTCASA.Enabled = True
                    REC_DEFUNCION.CMBDEPARTAMENTO.Enabled = True : REC_DEFUNCION.CMBMUNICIPIO.Enabled = True
                    REC_DEFUNCION.TXTTELEFONO1.Enabled = True : REC_DEFUNCION.TXTTELEFONO2.Enabled = True
                    REC_DEFUNCION.CMBSEXO.Enabled = True : REC_DEFUNCION.FN.Enabled = True
                    REC_DEFUNCION.TXTPADRE.Enabled = True : REC_DEFUNCION.TXTMADRE.Enabled = True
                    REC_DEFUNCION.TXTEDAD.Enabled = True : REC_DEFUNCION.CMBTIPO.Enabled = True
                    REC_DEFUNCION.TXTSALA.Enabled = True : REC_DEFUNCION.BTNSALA.Visible = True
                    REC_DEFUNCION.TXTPAIS.Enabled = True : REC_DEFUNCION.DEFUNCION.Enabled = True
                    REC_DEFUNCION.HORA_DEFUNCION.Enabled = True
                    REC_DEFUNCION.TXTMEDICO.Enabled = True : REC_DEFUNCION.TXTDIAGNOSTICO.Enabled = True
                    REC_DEFUNCION.INGRESO.Enabled = True : REC_DEFUNCION.HORA_INGRESO.Enabled = True
                    REC_DEFUNCION.BTNINGRESO.Visible = True
                    REC_DEFUNCION.TXTREPORTE.Enabled = True : REC_DEFUNCION.RECEPCION.Enabled = True
                    REC_DEFUNCION.HORA_RECEPCION.Enabled = True
                    REC_DEFUNCION.TXTFISCALIA.Enabled = True : REC_DEFUNCION.FISCALIA.Enabled = True
                    REC_DEFUNCION.HORA_FISCALIA.Enabled = True
                    REC_DEFUNCION.BTNGUARDAR.Enabled = False : REC_DEFUNCION.BTNMODIFICAR.Enabled = False
                    REC_DEFUNCION.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
                    REC_DEFUNCION.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
                    REC_DEFUNCION.TXTIDENTIDAD.Focus()
                    Me.Close()
                End If
            ElseIf DGVGENERAL.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN ITEM CARGADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                Me.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            REC_DEFUNCION.TXTNOMBRES.Enabled = True : REC_DEFUNCION.TXTPRIMERAPELLIDO.Enabled = True
            REC_DEFUNCION.TXTSEGUNDOAPELLIDO.Enabled = True : REC_DEFUNCION.TXTCORRELATIVO.Enabled = False
            REC_DEFUNCION.TXTCOLONIA.Enabled = True : REC_DEFUNCION.TXTCASA.Enabled = True
            REC_DEFUNCION.CMBDEPARTAMENTO.Enabled = True : REC_DEFUNCION.CMBMUNICIPIO.Enabled = True
            REC_DEFUNCION.TXTTELEFONO1.Enabled = True : REC_DEFUNCION.TXTTELEFONO2.Enabled = True
            REC_DEFUNCION.CMBSEXO.Enabled = True : REC_DEFUNCION.FN.Enabled = True
            REC_DEFUNCION.TXTPADRE.Enabled = True : REC_DEFUNCION.TXTMADRE.Enabled = True
            REC_DEFUNCION.TXTEDAD.Enabled = True : REC_DEFUNCION.CMBTIPO.Enabled = True
            REC_DEFUNCION.TXTSALA.Enabled = True : REC_DEFUNCION.BTNSALA.Visible = True
            REC_DEFUNCION.TXTPAIS.Enabled = True : REC_DEFUNCION.DEFUNCION.Enabled = True
            REC_DEFUNCION.HORA_DEFUNCION.Enabled = True
            REC_DEFUNCION.TXTMEDICO.Enabled = True : REC_DEFUNCION.TXTDIAGNOSTICO.Enabled = True
            REC_DEFUNCION.INGRESO.Enabled = True : REC_DEFUNCION.HORA_INGRESO.Enabled = True
            REC_DEFUNCION.BTNINGRESO.Visible = True
            REC_DEFUNCION.TXTREPORTE.Enabled = True : REC_DEFUNCION.RECEPCION.Enabled = True
            REC_DEFUNCION.HORA_RECEPCION.Enabled = True
            REC_DEFUNCION.TXTFISCALIA.Enabled = True : REC_DEFUNCION.FISCALIA.Enabled = True
            REC_DEFUNCION.HORA_FISCALIA.Enabled = True
            REC_DEFUNCION.BTNGUARDAR.Enabled = False : REC_DEFUNCION.BTNMODIFICAR.Enabled = False
            REC_DEFUNCION.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
            REC_DEFUNCION.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
            REC_DEFUNCION.TXTIDENTIDAD.Focus()
            Me.Close()
        End Try
    End Sub

    Private Sub DGVGENERAL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGENERAL.CellContentClick
        For I As Integer = 0 To DGVGENERAL.Rows.Count - 1
            If DGVGENERAL.Rows(I).Selected = True Then
                If DGVGENERAL.Item(3, I).Value() = "NORMAL" Then
                    LBTIPO.Text = "NORMAL = POSEE IDENTIDAD"
                ElseIf DGVGENERAL.Item(3, I).Value() = "RN#1" Or DGVGENERAL.Item(3, I).Value() = "RN#2" Or _
                    DGVGENERAL.Item(3, I).Value() = "RN#3" Then
                    LBTIPO.Text = "RECIEN NACIDO"
                ElseIf DGVGENERAL.Item(3, I).Value() = "OBITO_1" Or DGVGENERAL.Item(3, I).Value() = "OBITO_2" Then
                    LBTIPO.Text = "OBITO"
                ElseIf DGVGENERAL.Item(3, I).Value() = "HIJO_1" Or DGVGENERAL.Item(3, I).Value() = "HIJO_2" Then
                    LBTIPO.Text = "HIJO"
                End If
            End If
        Next
    End Sub
End Class