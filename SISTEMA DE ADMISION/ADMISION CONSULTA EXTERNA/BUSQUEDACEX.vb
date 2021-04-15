Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSQUEDACEX
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Private Sub CBSI_CheckedChanged(sender As Object, e As EventArgs) Handles CBSI.CheckedChanged
        If CBSI.Checked = True Then
            CBNO.Checked = False
            GENERAL()
        ElseIf CBSI.Checked = False Then
            CBNO.Checked = True
            ESPECIFICO()
        End If
    End Sub
    Sub GIDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
                                & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
                                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, " _
                                & "FECHA_NACIMIENTO, DIAGNOSTICO, ESTADO_CIVIL, OCUPACION, DEFUNCION  FROM UNICO WHERE IDENTIDAD='" _
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
                DGVGENERAL.Columns("LUNES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MARTES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MIERCOLES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("JUEVES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("VIERNES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SABADO").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DOMINGO").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NACIMIENTO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO_CIVIL").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("OCUPACION").Width = 150 'DAR ANCHO A LA COLUMNA
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
                DGVGENERAL.Columns("LUNES").HeaderText = "LU" '20
                DGVGENERAL.Columns("MARTES").HeaderText = "MA" '21
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI" '22
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU" '23
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI" '24
                DGVGENERAL.Columns("SABADO").HeaderText = "SA" '25
                DGVGENERAL.Columns("DOMINGO").HeaderText = "DO" '26
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC." '27
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO" '28
                DGVGENERAL.Columns("ESTADO_CIVIL").HeaderText = "ESTADO CIVIL" '29
                DGVGENERAL.Columns("OCUPACION").HeaderText = "OCUPACION" '30
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "DEFUNCION" '31
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CITASCEX.TXTNOMBRES.Clear() : CITASCEX.TXTPRIMERAPELLIDO.Clear()
                CITASCEX.TXTSEGUNDOAPELLIDO.Clear() : CITASCEX.TXTCORRELATIVO.Text = "0000-0000"
                CITASCEX.TXTCOLONIA.Clear() : CITASCEX.TXTCASA.Clear()
                CITASCEX.TXTPAIS.Clear()
                CITASCEX.TXTTELEFONO1.Clear() : CITASCEX.TXTTELEFONO2.Clear()
                CITASCEX.CMBSEXO.Text = Nothing : CITASCEX.CMBTIPO.Text = Nothing
                CITASCEX.TXTPADRE.Clear() : CITASCEX.TXTMADRE.Clear()
                CITASCEX.TXTEDAD.Clear()
                CITASCEX.FN.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_FICHA.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_CITADO.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_REFERENCIA.Value = (DateTime.Now.Date)
                CITASCEX.TXTNOMBRES.Enabled = True : CITASCEX.TXTPRIMERAPELLIDO.Enabled = True
                CITASCEX.TXTSEGUNDOAPELLIDO.Enabled = True : CITASCEX.TXTCORRELATIVO.Enabled = False
                CITASCEX.TXTCOLONIA.Enabled = True : CITASCEX.TXTCASA.Enabled = True
                CITASCEX.CMBDEPARTAMENTO.Enabled = True : CITASCEX.CMBMUNICIPIO.Enabled = True
                CITASCEX.TXTTELEFONO1.Enabled = True : CITASCEX.TXTTELEFONO2.Enabled = True
                CITASCEX.CMBSEXO.Enabled = True : CITASCEX.FN.Enabled = True
                CITASCEX.TXTPADRE.Enabled = True : CITASCEX.TXTMADRE.Enabled = True
                CITASCEX.TXTEDAD.Enabled = True : CITASCEX.CMBTIPO.Enabled = True
                CITASCEX.CBLUNES.Checked = False : CITASCEX.CBLUNES.Enabled = True
                CITASCEX.CBMARTES.Checked = False : CITASCEX.CBMARTES.Enabled = True
                CITASCEX.CBMIERCOLES.Checked = False : CITASCEX.CBMIERCOLES.Enabled = True
                CITASCEX.CBJUEVES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
                CITASCEX.CBVIERNES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
                CITASCEX.CBSABADO.Checked = False : CITASCEX.CBSABADO.Enabled = True
                CITASCEX.CBDOMINGO.Checked = False : CITASCEX.CBDOMINGO.Enabled = True
                CITASCEX.FN.Enabled = True : CITASCEX.FECHA_FICHA.Enabled = True
                CITASCEX.FECHA_REFERENCIA.Enabled = True : CITASCEX.FECHA_CITADO.Enabled = False
                CITASCEX.CMBESPECIALIDAD.Enabled = True : CITASCEX.CMBMEDICO.Enabled = True
                CITASCEX.BTNBITACORA.Enabled = False : CITASCEX.BTNGUARDA.Enabled = True
                CITASCEX.CBPREFERENTE.Enabled = True : CITASCEX.CBPREFERENTE.Checked = False
                CITASCEX.CBNORMAL.Enabled = True : CITASCEX.CBNORMAL.Checked = False
                CITASCEX.CBNUEVO.Enabled = True : CITASCEX.CBNUEVO.Checked = False
                CITASCEX.CBSUBSIGUIENTE.Enabled = True : CITASCEX.CBSUBSIGUIENTE.Checked = False
                CITASCEX.CBREPROGRAMADO.Enabled = True : CITASCEX.CBREPROGRAMADO.Checked = False
                CITASCEX.CBCAMBIO.Enabled = True : CITASCEX.CBCAMBIO.Checked = False
                CITASCEX.CMBREFERENCIA.Enabled = True
                CITASCEX.CMBDEPARTAMENTO1.Enabled = False
                CITASCEX.CMBMUNICIPIO1.Enabled = False
                CITASCEX.TXTCENTRO.Enabled = False : CITASCEX.BTNCENTRO.Enabled = False
                CITASCEX.TXTDIRECCIONCENTRO.Enabled = False : CITASCEX.TXTSERVICIO.Enabled = False
                CITASCEX.TXTSALA.Enabled = False : CITASCEX.TXTDIAGNOSTICO.Enabled = False
                CITASCEX.TXTMEDICO.Enabled = False
                CITASCEX.TXTOBSERVACION.Enabled = True
                CITASCEX.BTNMODIFICAR.Enabled = False : CITASCEX.BTNGUARDAR.Enabled = True
                CITASCEX.TXTIDENTIDAD.Focus()
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
                                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, " _
                                & "FECHA_NACIMIENTO, DIAGNOSTICO, ESTADO_CIVIL, OCUPACION, DEFUNCION  FROM UNICO WHERE CORRELATIVO='" _
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
                DGVGENERAL.Columns("LUNES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MARTES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MIERCOLES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("JUEVES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("VIERNES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SABADO").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DOMINGO").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NACIMIENTO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO_CIVIL").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("OCUPACION").Width = 150 'DAR ANCHO A LA COLUMNA
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
                DGVGENERAL.Columns("LUNES").HeaderText = "LU" '20
                DGVGENERAL.Columns("MARTES").HeaderText = "MA" '21
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI" '22
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU" '23
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI" '24
                DGVGENERAL.Columns("SABADO").HeaderText = "SA" '25
                DGVGENERAL.Columns("DOMINGO").HeaderText = "DO" '26
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC." '27
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO" '28
                DGVGENERAL.Columns("ESTADO_CIVIL").HeaderText = "ESTADO CIVIL" '29
                DGVGENERAL.Columns("OCUPACION").HeaderText = "OCUPACION" '30
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "DEFUNCION" '31
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CITASCEX.TXTNOMBRES.Clear() : CITASCEX.TXTPRIMERAPELLIDO.Clear()
                CITASCEX.TXTSEGUNDOAPELLIDO.Clear() : CITASCEX.TXTIDENTIDAD.Text = "0000-0000-00000"
                CITASCEX.TXTCOLONIA.Clear() : CITASCEX.TXTCASA.Clear()
                CITASCEX.TXTPAIS.Clear()
                CITASCEX.TXTTELEFONO1.Clear() : CITASCEX.TXTTELEFONO2.Clear()
                CITASCEX.CMBSEXO.Text = Nothing : CITASCEX.CMBTIPO.Text = Nothing
                CITASCEX.TXTPADRE.Clear() : CITASCEX.TXTMADRE.Clear()
                CITASCEX.TXTEDAD.Clear()
                CITASCEX.FN.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_FICHA.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_CITADO.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_REFERENCIA.Value = (DateTime.Now.Date)
                CITASCEX.TXTNOMBRES.Enabled = True : CITASCEX.TXTPRIMERAPELLIDO.Enabled = True
                CITASCEX.TXTSEGUNDOAPELLIDO.Enabled = True : CITASCEX.TXTIDENTIDAD.Enabled = True
                CITASCEX.TXTCOLONIA.Enabled = True : CITASCEX.TXTCASA.Enabled = True
                CITASCEX.CMBDEPARTAMENTO.Enabled = True : CITASCEX.CMBMUNICIPIO.Enabled = True
                CITASCEX.TXTTELEFONO1.Enabled = True : CITASCEX.TXTTELEFONO2.Enabled = True
                CITASCEX.CMBSEXO.Enabled = True : CITASCEX.FN.Enabled = True
                CITASCEX.TXTPADRE.Enabled = True : CITASCEX.TXTMADRE.Enabled = True
                CITASCEX.TXTEDAD.Enabled = True : CITASCEX.CMBTIPO.Enabled = True
                CITASCEX.CBLUNES.Checked = False : CITASCEX.CBLUNES.Enabled = True
                CITASCEX.CBMARTES.Checked = False : CITASCEX.CBMARTES.Enabled = True
                CITASCEX.CBMIERCOLES.Checked = False : CITASCEX.CBMIERCOLES.Enabled = True
                CITASCEX.CBJUEVES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
                CITASCEX.CBVIERNES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
                CITASCEX.CBSABADO.Checked = False : CITASCEX.CBSABADO.Enabled = True
                CITASCEX.CBDOMINGO.Checked = False : CITASCEX.CBDOMINGO.Enabled = True
                CITASCEX.FN.Enabled = True : CITASCEX.FECHA_FICHA.Enabled = True
                CITASCEX.FECHA_REFERENCIA.Enabled = True : CITASCEX.FECHA_CITADO.Enabled = False
                CITASCEX.CMBESPECIALIDAD.Enabled = True : CITASCEX.CMBMEDICO.Enabled = True
                CITASCEX.BTNBITACORA.Enabled = False : CITASCEX.BTNGUARDA.Enabled = True
                CITASCEX.CBPREFERENTE.Enabled = True : CITASCEX.CBPREFERENTE.Checked = False
                CITASCEX.CBNORMAL.Enabled = True : CITASCEX.CBNORMAL.Checked = False
                CITASCEX.CBNUEVO.Enabled = True : CITASCEX.CBNUEVO.Checked = False
                CITASCEX.CBSUBSIGUIENTE.Enabled = True : CITASCEX.CBSUBSIGUIENTE.Checked = False
                CITASCEX.CBREPROGRAMADO.Enabled = True : CITASCEX.CBREPROGRAMADO.Checked = False
                CITASCEX.CBCAMBIO.Enabled = True : CITASCEX.CBCAMBIO.Checked = False
                CITASCEX.CMBREFERENCIA.Enabled = True
                CITASCEX.CMBDEPARTAMENTO1.Enabled = False
                CITASCEX.CMBMUNICIPIO1.Enabled = False
                CITASCEX.TXTCENTRO.Enabled = False : CITASCEX.BTNCENTRO.Enabled = False
                CITASCEX.TXTDIRECCIONCENTRO.Enabled = False : CITASCEX.TXTSERVICIO.Enabled = False
                CITASCEX.TXTSALA.Enabled = False : CITASCEX.TXTDIAGNOSTICO.Enabled = False
                CITASCEX.TXTMEDICO.Enabled = False
                CITASCEX.TXTOBSERVACION.Enabled = True
                CITASCEX.BTNMODIFICAR.Enabled = False : CITASCEX.BTNGUARDAR.Enabled = True
                CITASCEX.TXTIDENTIDAD.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub BUSQUEDACEX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CMBCLASIFICACION.Text = "" And CMBNACIONALIDAD.Text = "" And CMBBUSQUEDA.Text = "" Then
            Me.Close()
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        DGVGENERAL.Columns.Clear()
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        CITASCEX.TXTNOMBRES.Clear() : CITASCEX.TXTPRIMERAPELLIDO.Clear()
        CITASCEX.TXTSEGUNDOAPELLIDO.Clear() : CITASCEX.TXTIDENTIDAD.Text = "0000-0000"
        CITASCEX.TXTCOLONIA.Clear() : CITASCEX.TXTCASA.Clear()
        CITASCEX.TXTPAIS.Clear()
        CITASCEX.TXTTELEFONO1.Clear() : CITASCEX.TXTTELEFONO2.Clear()
        CITASCEX.CMBSEXO.Text = Nothing : CITASCEX.CMBTIPO.Text = Nothing
        CITASCEX.TXTPADRE.Clear() : CITASCEX.TXTMADRE.Clear()
        CITASCEX.TXTEDAD.Clear()
        CITASCEX.FN.Value = (DateTime.Now.Date)
        CITASCEX.FECHA_FICHA.Value = (DateTime.Now.Date)
        CITASCEX.FECHA_CITADO.Value = (DateTime.Now.Date)
        CITASCEX.FECHA_REFERENCIA.Value = (DateTime.Now.Date)
        CITASCEX.TXTNOMBRES.Enabled = True : CITASCEX.TXTPRIMERAPELLIDO.Enabled = True
        CITASCEX.TXTSEGUNDOAPELLIDO.Enabled = True : CITASCEX.TXTIDENTIDAD.Enabled = True
        CITASCEX.TXTCOLONIA.Enabled = True : CITASCEX.TXTCASA.Enabled = True
        CITASCEX.CMBDEPARTAMENTO.Enabled = True : CITASCEX.CMBMUNICIPIO.Enabled = True
        CITASCEX.TXTTELEFONO1.Enabled = True : CITASCEX.TXTTELEFONO2.Enabled = True
        CITASCEX.CMBSEXO.Enabled = True : CITASCEX.FN.Enabled = True
        CITASCEX.TXTPADRE.Enabled = True : CITASCEX.TXTMADRE.Enabled = True
        CITASCEX.TXTEDAD.Enabled = True : CITASCEX.CMBTIPO.Enabled = True
        CITASCEX.CBLUNES.Checked = False : CITASCEX.CBLUNES.Enabled = True
        CITASCEX.CBMARTES.Checked = False : CITASCEX.CBMARTES.Enabled = True
        CITASCEX.CBMIERCOLES.Checked = False : CITASCEX.CBMIERCOLES.Enabled = True
        CITASCEX.CBJUEVES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
        CITASCEX.CBVIERNES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
        CITASCEX.CBSABADO.Checked = False : CITASCEX.CBSABADO.Enabled = True
        CITASCEX.CBDOMINGO.Checked = False : CITASCEX.CBDOMINGO.Enabled = True
        CITASCEX.FN.Enabled = True : CITASCEX.FECHA_FICHA.Enabled = True
        CITASCEX.FECHA_REFERENCIA.Enabled = True : CITASCEX.FECHA_CITADO.Enabled = False
        CITASCEX.CMBESPECIALIDAD.Enabled = True : CITASCEX.CMBMEDICO.Enabled = True
        CITASCEX.BTNBITACORA.Enabled = False : CITASCEX.BTNGUARDA.Enabled = True
        CITASCEX.CBPREFERENTE.Enabled = True : CITASCEX.CBPREFERENTE.Checked = False
        CITASCEX.CBNORMAL.Enabled = True : CITASCEX.CBNORMAL.Checked = False
        CITASCEX.CBNUEVO.Enabled = True : CITASCEX.CBNUEVO.Checked = False
        CITASCEX.CBSUBSIGUIENTE.Enabled = True : CITASCEX.CBSUBSIGUIENTE.Checked = False
        CITASCEX.CBREPROGRAMADO.Enabled = True : CITASCEX.CBREPROGRAMADO.Checked = False
        CITASCEX.CBCAMBIO.Enabled = True : CITASCEX.CBCAMBIO.Checked = False
        CITASCEX.CMBREFERENCIA.Enabled = True
        CITASCEX.CMBDEPARTAMENTO1.Enabled = False
        CITASCEX.CMBMUNICIPIO1.Enabled = False
        CITASCEX.TXTCENTRO.Enabled = False : CITASCEX.BTNCENTRO.Enabled = False
        CITASCEX.TXTDIRECCIONCENTRO.Enabled = False : CITASCEX.TXTSERVICIO.Enabled = False
        CITASCEX.TXTSALA.Enabled = False : CITASCEX.TXTDIAGNOSTICO.Enabled = False
        CITASCEX.TXTMEDICO.Enabled = False
        CITASCEX.TXTOBSERVACION.Enabled = True
        CITASCEX.BTNMODIFICAR.Enabled = False : CITASCEX.BTNGUARDAR.Enabled = True
        CITASCEX.TXTIDENTIDAD.Focus()
        Me.Close()
    End Sub

    Private Sub BTNCAEPTAR_Click(sender As Object, e As EventArgs) Handles BTNCAEPTAR.Click
        Try
            Dim A As Integer
            If DGVGENERAL.Rows.Count > 0 Then
                A = DGVGENERAL.CurrentRow.Index
                If DGVGENERAL.Item(31, A).Value() = "0101-01-01" Then
                    CITASCEX.CMBCLASIFICACION.Text = DGVGENERAL.Item(3, A).Value() 'TIPO CLASIFICACION
                    CITASCEX.CMBNACIONALIDAD.Text = DGVGENERAL.Item(1, A).Value() ' NACIONALIDAD
                    CITASCEX.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text 'TIPO BSUQUEDA
                    CITASCEX.TXTIDENTIDAD.Text = DGVGENERAL.Item(10, A).Value() 'IDENTIDAD
                    CITASCEX.TXTCORRELATIVO.Text = DGVGENERAL.Item(9, A).Value() 'CORRELATIVO
                    CITASCEX.TXTPAIS.Text = DGVGENERAL.Item(2, A).Value() 'PAIS
                    CITASCEX.TXTNOMBRES.Text = DGVGENERAL.Item(4, A).Value() 'NOMBRE DEL PACIENTE
                    CITASCEX.TXTPRIMERAPELLIDO.Text = DGVGENERAL.Item(5, A).Value() 'PRIMER APELLIDO
                    CITASCEX.TXTSEGUNDOAPELLIDO.Text = DGVGENERAL.Item(6, A).Value() 'SEGUNDO APELLIDO
                    CITASCEX.TXTCOLONIA.Text = DGVGENERAL.Item(11, A).Value() 'COLONIA
                    CITASCEX.TXTCASA.Text = DGVGENERAL.Item(12, A).Value() 'CASA
                    CITASCEX.CMBDEPARTAMENTO.Text = DGVGENERAL.Item(13, A).Value() 'DEPARTAMENTO
                    CITASCEX.CMBMUNICIPIO.Text = DGVGENERAL.Item(14, A).Value() 'MUNICIPIO
                    CITASCEX.TXTTELEFONO1.Text = DGVGENERAL.Item(15, A).Value() 'TELEFONO 1
                    CITASCEX.TXTTELEFONO2.Text = DGVGENERAL.Item(16, A).Value() 'TELEFONO 2
                    CITASCEX.CMBSEXO.Text = DGVGENERAL.Item(17, A).Value() 'SEXO
                    CITASCEX.TXTPADRE.Text = DGVGENERAL.Item(18, A).Value() 'PADRE
                    CITASCEX.TXTMADRE.Text = DGVGENERAL.Item(19, A).Value() 'MADRE
                    If DGVGENERAL.Item(20, A).Value() = "SI" Then 'LUNES
                        CITASCEX.CBLUNES.CheckState = CheckState.Checked
                    Else
                        CITASCEX.CBLUNES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(21, A).Value() = "SI" Then 'MARTES
                        CITASCEX.CBMARTES.CheckState = CheckState.Checked
                    Else
                        CITASCEX.CBMARTES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(22, A).Value() = "SI" Then 'MIERCOLES
                        CITASCEX.CBMIERCOLES.CheckState = CheckState.Checked
                    Else
                        CITASCEX.CBMIERCOLES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(23, A).Value() = "SI" Then 'JUEVES
                        CITASCEX.CBJUEVES.CheckState = CheckState.Checked
                    Else
                        CITASCEX.CBJUEVES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(24, A).Value() = "SI" Then 'VIERNES
                        CITASCEX.CBVIERNES.CheckState = CheckState.Checked
                    Else
                        CITASCEX.CBVIERNES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(25, A).Value() = "SI" Then 'SABADO
                        CITASCEX.CBSABADO.CheckState = CheckState.Checked
                    Else
                        CITASCEX.CBSABADO.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(26, A).Value() = "SI" Then 'DOMINGO
                        CITASCEX.CBDOMINGO.CheckState = CheckState.Checked
                    Else
                        CITASCEX.CBDOMINGO.CheckState = CheckState.Unchecked
                    End If
                    CITASCEX.FN.Value = DGVGENERAL.Item(27, A).Value() 'FECHA NACIMIENTO
                    CITASCEX.TXTDIAGNOSTICO.Text = DGVGENERAL.Item(28, A).Value() 'DIAGNOSTICO
                    'CITASCEX.CMBESTADO.Text = DGVGENERAL.Item(29, A).Value() 'ESTADO CIVIL
                    'CITASCEX.CMBOCUPACION.Text = DGVGENERAL.Item(30, A).Value() 'OCUPACION
                    CITASCEX.TXTNOMBRES.Enabled = True : CITASCEX.TXTPRIMERAPELLIDO.Enabled = True
                    CITASCEX.TXTSEGUNDOAPELLIDO.Enabled = True : CITASCEX.TXTCORRELATIVO.Enabled = False
                    CITASCEX.TXTCOLONIA.Enabled = True : CITASCEX.TXTCASA.Enabled = True
                    CITASCEX.CMBDEPARTAMENTO.Enabled = True : CITASCEX.CMBMUNICIPIO.Enabled = True
                    CITASCEX.TXTTELEFONO1.Enabled = True : CITASCEX.TXTTELEFONO2.Enabled = True
                    CITASCEX.CMBSEXO.Enabled = True : CITASCEX.FN.Enabled = True
                    CITASCEX.TXTPADRE.Enabled = True : CITASCEX.TXTMADRE.Enabled = True
                    CITASCEX.TXTEDAD.Enabled = True : CITASCEX.CMBTIPO.Enabled = True
                    CITASCEX.CBLUNES.Enabled = True
                    CITASCEX.CBMARTES.Enabled = True
                    CITASCEX.CBMIERCOLES.Enabled = True
                    CITASCEX.CBVIERNES.Enabled = True
                    CITASCEX.CBVIERNES.Enabled = True
                    CITASCEX.CBSABADO.Enabled = True
                    CITASCEX.CBDOMINGO.Enabled = True
                    CITASCEX.FN.Enabled = True : CITASCEX.FECHA_FICHA.Enabled = True
                    CITASCEX.FECHA_REFERENCIA.Enabled = True : CITASCEX.FECHA_CITADO.Enabled = False
                    CITASCEX.CMBESPECIALIDAD.Enabled = True : CITASCEX.CMBMEDICO.Enabled = True
                    CITASCEX.BTNBITACORA.Enabled = True : CITASCEX.BTNGUARDA.Enabled = False
                    CITASCEX.CBPREFERENTE.Enabled = True : CITASCEX.CBPREFERENTE.Checked = False
                    CITASCEX.CBNORMAL.Enabled = True : CITASCEX.CBNORMAL.Checked = False
                    CITASCEX.CBNUEVO.Enabled = True : CITASCEX.CBNUEVO.Checked = False
                    CITASCEX.CBSUBSIGUIENTE.Enabled = True : CITASCEX.CBSUBSIGUIENTE.Checked = False
                    CITASCEX.CBREPROGRAMADO.Enabled = True : CITASCEX.CBREPROGRAMADO.Checked = False
                    CITASCEX.CBCAMBIO.Enabled = True : CITASCEX.CBCAMBIO.Checked = False
                    CITASCEX.CMBREFERENCIA.Enabled = True
                    CITASCEX.CMBDEPARTAMENTO1.Enabled = False
                    CITASCEX.CMBMUNICIPIO1.Enabled = False
                    CITASCEX.TXTCENTRO.Enabled = False : CITASCEX.BTNCENTRO.Enabled = False
                    CITASCEX.TXTDIRECCIONCENTRO.Enabled = False : CITASCEX.TXTSERVICIO.Enabled = False
                    CITASCEX.TXTSALA.Enabled = False : CITASCEX.TXTDIAGNOSTICO.Enabled = False
                    CITASCEX.TXTMEDICO.Enabled = False
                    CITASCEX.TXTOBSERVACION.Enabled = True
                    CITASCEX.BTNMODIFICAR.Enabled = True : CITASCEX.BTNGUARDAR.Enabled = False
                    CITASCEX.TXTIDENTIDAD.Focus()
                    Me.Close()
                ElseIf DGVGENERAL.Item(31, A).Value() <> "0101-01-01" Then
                    MsgBox("NO SE PUEDE USAR EL REGISTRO YA QUE TIENE UNA FECHA DE DEFUNCION: " _
                           & DGVGENERAL.Item(31, A).Value() & Chr(13) _
                           & "SELECCIONE OTRO ITEM", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    CITASCEX.TXTNOMBRES.Enabled = False : CITASCEX.TXTPRIMERAPELLIDO.Enabled = False
                    CITASCEX.TXTSEGUNDOAPELLIDO.Enabled = False : CITASCEX.TXTCORRELATIVO.Enabled = False
                    CITASCEX.TXTCOLONIA.Enabled = False : CITASCEX.TXTCASA.Enabled = False
                    CITASCEX.CMBDEPARTAMENTO.Enabled = False : CITASCEX.CMBMUNICIPIO.Enabled = False
                    CITASCEX.TXTTELEFONO1.Enabled = False : CITASCEX.TXTTELEFONO2.Enabled = False
                    CITASCEX.CMBSEXO.Enabled = False : CITASCEX.FN.Enabled = False
                    CITASCEX.TXTPADRE.Enabled = False : CITASCEX.TXTMADRE.Enabled = False
                    CITASCEX.TXTEDAD.Enabled = False : CITASCEX.CMBTIPO.Enabled = False
                    CITASCEX.CBLUNES.Checked = False : CITASCEX.CBLUNES.Enabled = False
                    CITASCEX.CBMARTES.Checked = False : CITASCEX.CBMARTES.Enabled = False
                    CITASCEX.CBMIERCOLES.Checked = False : CITASCEX.CBMIERCOLES.Enabled = False
                    CITASCEX.CBJUEVES.Checked = False : CITASCEX.CBVIERNES.Enabled = False
                    CITASCEX.CBVIERNES.Checked = False : CITASCEX.CBVIERNES.Enabled = False
                    CITASCEX.CBSABADO.Checked = False : CITASCEX.CBSABADO.Enabled = False
                    CITASCEX.CBDOMINGO.Checked = False : CITASCEX.CBDOMINGO.Enabled = False
                    CITASCEX.FN.Enabled = False : CITASCEX.FECHA_FICHA.Enabled = False
                    CITASCEX.FECHA_REFERENCIA.Enabled = False : CITASCEX.FECHA_CITADO.Enabled = False
                    CITASCEX.CMBESPECIALIDAD.Enabled = False : CITASCEX.CMBMEDICO.Enabled = False
                    CITASCEX.BTNBITACORA.Enabled = False : CITASCEX.BTNGUARDA.Enabled = False
                    CITASCEX.CBPREFERENTE.Enabled = False : CITASCEX.CBPREFERENTE.Checked = False
                    CITASCEX.CBNORMAL.Enabled = False : CITASCEX.CBNORMAL.Checked = False
                    CITASCEX.CBNUEVO.Enabled = False : CITASCEX.CBNUEVO.Checked = False
                    CITASCEX.CBSUBSIGUIENTE.Enabled = False : CITASCEX.CBSUBSIGUIENTE.Checked = False
                    CITASCEX.CBREPROGRAMADO.Enabled = False : CITASCEX.CBREPROGRAMADO.Checked = False
                    CITASCEX.CBCAMBIO.Enabled = False : CITASCEX.CBCAMBIO.Checked = False
                    CITASCEX.CMBREFERENCIA.Enabled = False
                    CITASCEX.CMBDEPARTAMENTO1.Enabled = False
                    CITASCEX.CMBMUNICIPIO1.Enabled = False
                    CITASCEX.TXTCENTRO.Enabled = False : CITASCEX.BTNCENTRO.Enabled = False
                    CITASCEX.TXTDIRECCIONCENTRO.Enabled = False : CITASCEX.TXTSERVICIO.Enabled = False
                    CITASCEX.TXTSALA.Enabled = False : CITASCEX.TXTDIAGNOSTICO.Enabled = False
                    CITASCEX.TXTMEDICO.Enabled = False
                    CITASCEX.TXTOBSERVACION.Enabled = True
                    CITASCEX.BTNMODIFICAR.Enabled = False : CITASCEX.BTNGUARDAR.Enabled = False
                    CITASCEX.TXTIDENTIDAD.Text = ""
                    CITASCEX.TXTCORRELATIVO.Text = "0000-0000"
                    CITASCEX.TXTIDENTIDAD.Focus()
                    Me.Close()
                End If
            ElseIf DGVGENERAL.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN ITEM CARGADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                Me.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            CITASCEX.TXTNOMBRES.Enabled = True : CITASCEX.TXTPRIMERAPELLIDO.Enabled = True
            CITASCEX.TXTSEGUNDOAPELLIDO.Enabled = True : CITASCEX.TXTCORRELATIVO.Enabled = False
            CITASCEX.TXTCOLONIA.Enabled = True : CITASCEX.TXTCASA.Enabled = True
            CITASCEX.CMBDEPARTAMENTO.Enabled = True : CITASCEX.CMBMUNICIPIO.Enabled = True
            CITASCEX.TXTTELEFONO1.Enabled = True : CITASCEX.TXTTELEFONO2.Enabled = True
            CITASCEX.CMBSEXO.Enabled = True : CITASCEX.FN.Enabled = True
            CITASCEX.TXTPADRE.Enabled = True : CITASCEX.TXTMADRE.Enabled = True
            CITASCEX.TXTEDAD.Enabled = True : CITASCEX.CMBTIPO.Enabled = True
            CITASCEX.CBLUNES.Enabled = True
            CITASCEX.CBMARTES.Enabled = True
            CITASCEX.CBMIERCOLES.Enabled = True
            CITASCEX.CBVIERNES.Enabled = True
            CITASCEX.CBVIERNES.Enabled = True
            CITASCEX.CBSABADO.Enabled = True
            CITASCEX.CBDOMINGO.Enabled = True
            CITASCEX.FN.Enabled = True : CITASCEX.FECHA_FICHA.Enabled = True
            CITASCEX.FECHA_REFERENCIA.Enabled = True : CITASCEX.FECHA_CITADO.Enabled = False
            CITASCEX.CMBESPECIALIDAD.Enabled = True : CITASCEX.CMBMEDICO.Enabled = True
            CITASCEX.BTNBITACORA.Enabled = True : CITASCEX.BTNGUARDA.Enabled = False
            CITASCEX.CBPREFERENTE.Enabled = True : CITASCEX.CBPREFERENTE.Checked = False
            CITASCEX.CBNORMAL.Enabled = True : CITASCEX.CBNORMAL.Checked = False
            CITASCEX.CBNUEVO.Enabled = True : CITASCEX.CBNUEVO.Checked = False
            CITASCEX.CBSUBSIGUIENTE.Enabled = True : CITASCEX.CBSUBSIGUIENTE.Checked = False
            CITASCEX.CBREPROGRAMADO.Enabled = True : CITASCEX.CBREPROGRAMADO.Checked = False
            CITASCEX.CBCAMBIO.Enabled = True : CITASCEX.CBCAMBIO.Checked = False
            CITASCEX.CMBREFERENCIA.Enabled = True
            CITASCEX.CMBDEPARTAMENTO1.Enabled = False
            CITASCEX.CMBMUNICIPIO1.Enabled = False
            CITASCEX.TXTCENTRO.Enabled = False : CITASCEX.BTNCENTRO.Enabled = False
            CITASCEX.TXTDIRECCIONCENTRO.Enabled = False : CITASCEX.TXTSERVICIO.Enabled = False
            CITASCEX.TXTSALA.Enabled = False : CITASCEX.TXTDIAGNOSTICO.Enabled = False
            CITASCEX.TXTMEDICO.Enabled = False
            CITASCEX.TXTOBSERVACION.Enabled = True
            CITASCEX.BTNMODIFICAR.Enabled = True : CITASCEX.BTNGUARDAR.Enabled = False
            CITASCEX.TXTIDENTIDAD.Focus()
            Me.Close()
        End Try
    End Sub
    Sub EIDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
                                & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
                                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, " _
                                & "FECHA_NACIMIENTO, DIAGNOSTICO, ESTADO_CIVIL, OCUPACION, DEFUNCION  FROM UNICO WHERE TIPO='" _
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
                DGVGENERAL.Columns("LUNES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MARTES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MIERCOLES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("JUEVES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("VIERNES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SABADO").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DOMINGO").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NACIMIENTO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO_CIVIL").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("OCUPACION").Width = 150 'DAR ANCHO A LA COLUMNA
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
                DGVGENERAL.Columns("LUNES").HeaderText = "LU" '20
                DGVGENERAL.Columns("MARTES").HeaderText = "MA" '21
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI" '22
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU" '23
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI" '24
                DGVGENERAL.Columns("SABADO").HeaderText = "SA" '25
                DGVGENERAL.Columns("DOMINGO").HeaderText = "DO" '26
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC." '27
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO" '28
                DGVGENERAL.Columns("ESTADO_CIVIL").HeaderText = "ESTADO CIVIL" '29
                DGVGENERAL.Columns("OCUPACION").HeaderText = "OCUPACION" '30
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "DEFUNCION" '31
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CITASCEX.TXTNOMBRES.Clear() : CITASCEX.TXTPRIMERAPELLIDO.Clear()
                CITASCEX.TXTSEGUNDOAPELLIDO.Clear() : CITASCEX.TXTCORRELATIVO.Text = "0000-0000"
                CITASCEX.TXTCOLONIA.Clear() : CITASCEX.TXTCASA.Clear()
                CITASCEX.TXTPAIS.Clear()
                CITASCEX.TXTTELEFONO1.Clear() : CITASCEX.TXTTELEFONO2.Clear()
                CITASCEX.CMBSEXO.Text = Nothing : CITASCEX.CMBTIPO.Text = Nothing
                CITASCEX.TXTPADRE.Clear() : CITASCEX.TXTMADRE.Clear()
                CITASCEX.TXTEDAD.Clear()
                CITASCEX.FN.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_FICHA.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_CITADO.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_REFERENCIA.Value = (DateTime.Now.Date)
                CITASCEX.TXTNOMBRES.Enabled = True : CITASCEX.TXTPRIMERAPELLIDO.Enabled = True
                CITASCEX.TXTSEGUNDOAPELLIDO.Enabled = True : CITASCEX.TXTCORRELATIVO.Enabled = False
                CITASCEX.TXTCOLONIA.Enabled = True : CITASCEX.TXTCASA.Enabled = True
                CITASCEX.CMBDEPARTAMENTO.Enabled = True : CITASCEX.CMBMUNICIPIO.Enabled = True
                CITASCEX.TXTTELEFONO1.Enabled = True : CITASCEX.TXTTELEFONO2.Enabled = True
                CITASCEX.CMBSEXO.Enabled = True : CITASCEX.FN.Enabled = True
                CITASCEX.TXTPADRE.Enabled = True : CITASCEX.TXTMADRE.Enabled = True
                CITASCEX.TXTEDAD.Enabled = True : CITASCEX.CMBTIPO.Enabled = True
                CITASCEX.CBLUNES.Checked = False : CITASCEX.CBLUNES.Enabled = True
                CITASCEX.CBMARTES.Checked = False : CITASCEX.CBMARTES.Enabled = True
                CITASCEX.CBMIERCOLES.Checked = False : CITASCEX.CBMIERCOLES.Enabled = True
                CITASCEX.CBJUEVES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
                CITASCEX.CBVIERNES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
                CITASCEX.CBSABADO.Checked = False : CITASCEX.CBSABADO.Enabled = True
                CITASCEX.CBDOMINGO.Checked = False : CITASCEX.CBDOMINGO.Enabled = True
                CITASCEX.FN.Enabled = True : CITASCEX.FECHA_FICHA.Enabled = True
                CITASCEX.FECHA_REFERENCIA.Enabled = True : CITASCEX.FECHA_CITADO.Enabled = False
                CITASCEX.CMBESPECIALIDAD.Enabled = True : CITASCEX.CMBMEDICO.Enabled = True
                CITASCEX.BTNBITACORA.Enabled = False : CITASCEX.BTNGUARDA.Enabled = True
                CITASCEX.CBPREFERENTE.Enabled = True : CITASCEX.CBPREFERENTE.Checked = False
                CITASCEX.CBNORMAL.Enabled = True : CITASCEX.CBNORMAL.Checked = False
                CITASCEX.CBNUEVO.Enabled = True : CITASCEX.CBNUEVO.Checked = False
                CITASCEX.CBSUBSIGUIENTE.Enabled = True : CITASCEX.CBSUBSIGUIENTE.Checked = False
                CITASCEX.CBREPROGRAMADO.Enabled = True : CITASCEX.CBREPROGRAMADO.Checked = False
                CITASCEX.CBCAMBIO.Enabled = True : CITASCEX.CBCAMBIO.Checked = False
                CITASCEX.CMBREFERENCIA.Enabled = True
                CITASCEX.CMBDEPARTAMENTO1.Enabled = False
                CITASCEX.CMBMUNICIPIO1.Enabled = False
                CITASCEX.TXTCENTRO.Enabled = False : CITASCEX.BTNCENTRO.Enabled = False
                CITASCEX.TXTDIRECCIONCENTRO.Enabled = False : CITASCEX.TXTSERVICIO.Enabled = False
                CITASCEX.TXTSALA.Enabled = False : CITASCEX.TXTDIAGNOSTICO.Enabled = False
                CITASCEX.TXTMEDICO.Enabled = False
                CITASCEX.TXTOBSERVACION.Enabled = True
                CITASCEX.BTNMODIFICAR.Enabled = False : CITASCEX.BTNGUARDAR.Enabled = True
                CITASCEX.TXTIDENTIDAD.Focus()
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
                                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, " _
                                & "FECHA_NACIMIENTO, DIAGNOSTICO, ESTADO_CIVIL, OCUPACION, DEFUNCION  FROM UNICO WHERE TIPO='" _
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
                DGVGENERAL.Columns("LUNES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MARTES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MIERCOLES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("JUEVES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("VIERNES").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SABADO").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DOMINGO").Width = 30 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NACIMIENTO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO_CIVIL").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("OCUPACION").Width = 150 'DAR ANCHO A LA COLUMNA
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
                DGVGENERAL.Columns("LUNES").HeaderText = "LU" '20
                DGVGENERAL.Columns("MARTES").HeaderText = "MA" '21
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI" '22
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU" '23
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI" '24
                DGVGENERAL.Columns("SABADO").HeaderText = "SA" '25
                DGVGENERAL.Columns("DOMINGO").HeaderText = "DO" '26
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC." '27
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO" '28
                DGVGENERAL.Columns("ESTADO_CIVIL").HeaderText = "ESTADO CIVIL" '29
                DGVGENERAL.Columns("OCUPACION").HeaderText = "OCUPACION" '30
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "DEFUNCION" '31
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CITASCEX.TXTNOMBRES.Clear() : CITASCEX.TXTPRIMERAPELLIDO.Clear()
                CITASCEX.TXTSEGUNDOAPELLIDO.Clear() : CITASCEX.TXTIDENTIDAD.Text = "0000-0000-00000"
                CITASCEX.TXTCOLONIA.Clear() : CITASCEX.TXTCASA.Clear()
                CITASCEX.TXTPAIS.Clear()
                CITASCEX.TXTTELEFONO1.Clear() : CITASCEX.TXTTELEFONO2.Clear()
                CITASCEX.CMBSEXO.Text = Nothing : CITASCEX.CMBTIPO.Text = Nothing
                CITASCEX.TXTPADRE.Clear() : CITASCEX.TXTMADRE.Clear()
                CITASCEX.TXTEDAD.Clear()
                CITASCEX.FN.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_FICHA.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_CITADO.Value = (DateTime.Now.Date)
                CITASCEX.FECHA_REFERENCIA.Value = (DateTime.Now.Date)
                CITASCEX.TXTNOMBRES.Enabled = True : CITASCEX.TXTPRIMERAPELLIDO.Enabled = True
                CITASCEX.TXTSEGUNDOAPELLIDO.Enabled = True : CITASCEX.TXTIDENTIDAD.Enabled = True
                CITASCEX.TXTCOLONIA.Enabled = True : CITASCEX.TXTCASA.Enabled = True
                CITASCEX.CMBDEPARTAMENTO.Enabled = True : CITASCEX.CMBMUNICIPIO.Enabled = True
                CITASCEX.TXTTELEFONO1.Enabled = True : CITASCEX.TXTTELEFONO2.Enabled = True
                CITASCEX.CMBSEXO.Enabled = True : CITASCEX.FN.Enabled = True
                CITASCEX.TXTPADRE.Enabled = True : CITASCEX.TXTMADRE.Enabled = True
                CITASCEX.TXTEDAD.Enabled = True : CITASCEX.CMBTIPO.Enabled = True
                CITASCEX.CBLUNES.Checked = False : CITASCEX.CBLUNES.Enabled = True
                CITASCEX.CBMARTES.Checked = False : CITASCEX.CBMARTES.Enabled = True
                CITASCEX.CBMIERCOLES.Checked = False : CITASCEX.CBMIERCOLES.Enabled = True
                CITASCEX.CBJUEVES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
                CITASCEX.CBVIERNES.Checked = False : CITASCEX.CBVIERNES.Enabled = True
                CITASCEX.CBSABADO.Checked = False : CITASCEX.CBSABADO.Enabled = True
                CITASCEX.CBDOMINGO.Checked = False : CITASCEX.CBDOMINGO.Enabled = True
                CITASCEX.FN.Enabled = True : CITASCEX.FECHA_FICHA.Enabled = True
                CITASCEX.FECHA_REFERENCIA.Enabled = True : CITASCEX.FECHA_CITADO.Enabled = False
                CITASCEX.CMBESPECIALIDAD.Enabled = True : CITASCEX.CMBMEDICO.Enabled = True
                CITASCEX.BTNBITACORA.Enabled = False : CITASCEX.BTNGUARDA.Enabled = True
                CITASCEX.CBPREFERENTE.Enabled = True : CITASCEX.CBPREFERENTE.Checked = False
                CITASCEX.CBNORMAL.Enabled = True : CITASCEX.CBNORMAL.Checked = False
                CITASCEX.CBNUEVO.Enabled = True : CITASCEX.CBNUEVO.Checked = False
                CITASCEX.CBSUBSIGUIENTE.Enabled = True : CITASCEX.CBSUBSIGUIENTE.Checked = False
                CITASCEX.CBREPROGRAMADO.Enabled = True : CITASCEX.CBREPROGRAMADO.Checked = False
                CITASCEX.CBCAMBIO.Enabled = True : CITASCEX.CBCAMBIO.Checked = False
                CITASCEX.CMBREFERENCIA.Enabled = True
                CITASCEX.CMBDEPARTAMENTO1.Enabled = False
                CITASCEX.CMBMUNICIPIO1.Enabled = False
                CITASCEX.TXTCENTRO.Enabled = False : CITASCEX.BTNCENTRO.Enabled = False
                CITASCEX.TXTDIRECCIONCENTRO.Enabled = False : CITASCEX.TXTSERVICIO.Enabled = False
                CITASCEX.TXTSALA.Enabled = False : CITASCEX.TXTDIAGNOSTICO.Enabled = False
                CITASCEX.TXTMEDICO.Enabled = False
                CITASCEX.TXTOBSERVACION.Enabled = True
                CITASCEX.BTNMODIFICAR.Enabled = False : CITASCEX.BTNGUARDAR.Enabled = True
                CITASCEX.TXTIDENTIDAD.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
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

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        DGVGENERAL.Columns.Clear()
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
    End Sub
End Class