Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSQUEDA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        DGVGENERAL.Columns.Clear()
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
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
                HOSPITALIZACION.TXTNOMBRES.Enabled = True : HOSPITALIZACION.TXTPRIMERAPELLIDO.Enabled = True
                HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Enabled = True : HOSPITALIZACION.TXTCORRELATIVO.Enabled = False
                HOSPITALIZACION.TXTCOLONIA.Enabled = True : HOSPITALIZACION.TXTCASA.Enabled = True
                HOSPITALIZACION.CMBDEPARTAMENTO.Enabled = True : HOSPITALIZACION.CMBMUNICIPIO.Enabled = True
                HOSPITALIZACION.TXTTELEFONO1.Enabled = True : HOSPITALIZACION.TXTTELEFONO2.Enabled = True
                HOSPITALIZACION.TXTTELEFONO3.Enabled = True : HOSPITALIZACION.TXTTELEFONO4.Enabled = True
                HOSPITALIZACION.CMBSEXO.Enabled = True : HOSPITALIZACION.FN.Enabled = True
                HOSPITALIZACION.TXTPADRE.Enabled = True : HOSPITALIZACION.TXTMADRE.Enabled = True
                HOSPITALIZACION.TXTEDAD.Enabled = True : HOSPITALIZACION.CMBTIPO.Enabled = True
                HOSPITALIZACION.TXTSALA.Enabled = True
                HOSPITALIZACION.TXTRESPONSABLE.Enabled = True
                HOSPITALIZACION.TXTDIRECCION.Enabled = True
                HOSPITALIZACION.BTNSALA.Enabled = True
                HOSPITALIZACION.TXTSERVICIO.Enabled = True
                HOSPITALIZACION.BTNRESPONSABLE.Enabled = True
                HOSPITALIZACION.CMBPARENTEZCO.Enabled = True
                HOSPITALIZACION.CMBESTADO.Enabled = True
                HOSPITALIZACION.CMBOCUPACION.Enabled = True
                HOSPITALIZACION.CMBESTADO.Enabled = True
                HOSPITALIZACION.CMBINGRESO.Enabled = True
                HOSPITALIZACION.BTNGUARDA.Enabled = True
                HOSPITALIZACION.BTNMODIFICA.Enabled = False : HOSPITALIZACION.BTNGUARDAR.Enabled = True
                HOSPITALIZACION.BTNSALA.Visible = True
                HOSPITALIZACION.TXTIDENTIDAD.Focus()
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
                HOSPITALIZACION.TXTNOMBRES.Enabled = True : HOSPITALIZACION.TXTPRIMERAPELLIDO.Enabled = True
                HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Enabled = True : HOSPITALIZACION.TXTCORRELATIVO.Enabled = False
                HOSPITALIZACION.TXTCOLONIA.Enabled = True : HOSPITALIZACION.TXTCASA.Enabled = True
                HOSPITALIZACION.CMBDEPARTAMENTO.Enabled = True : HOSPITALIZACION.CMBMUNICIPIO.Enabled = True
                HOSPITALIZACION.TXTTELEFONO1.Enabled = True : HOSPITALIZACION.TXTTELEFONO2.Enabled = True
                HOSPITALIZACION.TXTTELEFONO3.Enabled = True : HOSPITALIZACION.TXTTELEFONO4.Enabled = True
                HOSPITALIZACION.CMBSEXO.Enabled = True : HOSPITALIZACION.FN.Enabled = True
                HOSPITALIZACION.TXTPADRE.Enabled = True : HOSPITALIZACION.TXTMADRE.Enabled = True
                HOSPITALIZACION.TXTEDAD.Enabled = True : HOSPITALIZACION.CMBTIPO.Enabled = True
                HOSPITALIZACION.TXTSALA.Enabled = True
                HOSPITALIZACION.TXTRESPONSABLE.Enabled = True
                HOSPITALIZACION.TXTDIRECCION.Enabled = True
                HOSPITALIZACION.BTNSALA.Enabled = True
                HOSPITALIZACION.TXTSERVICIO.Enabled = True
                HOSPITALIZACION.BTNRESPONSABLE.Enabled = True
                HOSPITALIZACION.CMBPARENTEZCO.Enabled = True
                HOSPITALIZACION.CMBESTADO.Enabled = True
                HOSPITALIZACION.CMBOCUPACION.Enabled = True
                HOSPITALIZACION.CMBESTADO.Enabled = True
                HOSPITALIZACION.CMBINGRESO.Enabled = True
                HOSPITALIZACION.BTNGUARDA.Enabled = True
                HOSPITALIZACION.BTNMODIFICA.Enabled = False : HOSPITALIZACION.BTNGUARDAR.Enabled = True
                HOSPITALIZACION.BTNSALA.Visible = True
                HOSPITALIZACION.TXTIDENTIDAD.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        HOSPITALIZACION.TXTNOMBRES.Enabled = True : HOSPITALIZACION.TXTPRIMERAPELLIDO.Enabled = True
        HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Enabled = True : HOSPITALIZACION.TXTCORRELATIVO.Enabled = False
        HOSPITALIZACION.TXTCOLONIA.Enabled = True : HOSPITALIZACION.TXTCASA.Enabled = True
        HOSPITALIZACION.CMBDEPARTAMENTO.Enabled = True : HOSPITALIZACION.CMBMUNICIPIO.Enabled = True
        HOSPITALIZACION.TXTTELEFONO1.Enabled = True : HOSPITALIZACION.TXTTELEFONO2.Enabled = True
        HOSPITALIZACION.TXTTELEFONO3.Enabled = True : HOSPITALIZACION.TXTTELEFONO4.Enabled = True
        HOSPITALIZACION.CMBSEXO.Enabled = True : HOSPITALIZACION.FN.Enabled = True
        HOSPITALIZACION.TXTPADRE.Enabled = True : HOSPITALIZACION.TXTMADRE.Enabled = True
        HOSPITALIZACION.TXTEDAD.Enabled = True : HOSPITALIZACION.CMBTIPO.Enabled = True
        HOSPITALIZACION.TXTSALA.Enabled = True
        HOSPITALIZACION.TXTRESPONSABLE.Enabled = True
        HOSPITALIZACION.TXTDIRECCION.Enabled = True
        HOSPITALIZACION.BTNSALA.Enabled = True
        HOSPITALIZACION.TXTSERVICIO.Enabled = True
        HOSPITALIZACION.BTNRESPONSABLE.Enabled = True
        HOSPITALIZACION.CMBPARENTEZCO.Enabled = True
        HOSPITALIZACION.CMBESTADO.Enabled = True
        HOSPITALIZACION.CMBOCUPACION.Enabled = True
        HOSPITALIZACION.CMBESTADO.Enabled = True
        HOSPITALIZACION.CMBINGRESO.Enabled = True
        HOSPITALIZACION.BTNGUARDA.Enabled = False
        HOSPITALIZACION.BTNMODIFICA.Enabled = False : HOSPITALIZACION.BTNGUARDAR.Enabled = True
        HOSPITALIZACION.BTNSALA.Visible = True
        HOSPITALIZACION.TXTIDENTIDAD.Focus()
        Me.Close()
    End Sub

    Private Sub BTNCAEPTAR_Click(sender As Object, e As EventArgs) Handles BTNCAEPTAR.Click
        Try
            Dim A As Integer
            If DGVGENERAL.Rows.Count > 0 Then
                A = DGVGENERAL.CurrentRow.Index
                If DGVGENERAL.Item(31, A).Value() = "0101-01-01" Then
                    HOSPITALIZACION.CMBCLASIFICACION.Text = DGVGENERAL.Item(3, A).Value() 'TIPO CLASIFICACION
                    HOSPITALIZACION.CMBNACIONALIDAD.Text = DGVGENERAL.Item(1, A).Value() ' NACIONALIDAD
                    HOSPITALIZACION.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text 'TIPO BSUQUEDA
                    HOSPITALIZACION.TXTIDENTIDAD.Text = DGVGENERAL.Item(10, A).Value() 'IDENTIDAD
                    HOSPITALIZACION.TXTCORRELATIVO.Text = DGVGENERAL.Item(9, A).Value() 'CORRELATIVO
                    HOSPITALIZACION.TXTPAIS.Text = DGVGENERAL.Item(2, A).Value() 'PAIS
                    HOSPITALIZACION.TXTNOMBRES.Text = DGVGENERAL.Item(4, A).Value() 'NOMBRE DEL PACIENTE
                    HOSPITALIZACION.TXTPRIMERAPELLIDO.Text = DGVGENERAL.Item(5, A).Value() 'PRIMER APELLIDO
                    HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Text = DGVGENERAL.Item(6, A).Value() 'SEGUNDO APELLIDO
                    HOSPITALIZACION.TXTCOLONIA.Text = DGVGENERAL.Item(11, A).Value() 'COLONIA
                    HOSPITALIZACION.TXTCASA.Text = DGVGENERAL.Item(12, A).Value() 'CASA
                    HOSPITALIZACION.CMBDEPARTAMENTO.Text = DGVGENERAL.Item(13, A).Value() 'DEPARTAMENTO
                    HOSPITALIZACION.CMBMUNICIPIO.Text = DGVGENERAL.Item(14, A).Value() 'MUNICIPIO
                    HOSPITALIZACION.TXTTELEFONO3.Text = DGVGENERAL.Item(15, A).Value() 'TELEFONO 1
                    HOSPITALIZACION.TXTTELEFONO4.Text = DGVGENERAL.Item(16, A).Value() 'TELEFONO 2
                    HOSPITALIZACION.CMBSEXO.Text = DGVGENERAL.Item(17, A).Value() 'SEXO
                    HOSPITALIZACION.TXTPADRE.Text = DGVGENERAL.Item(18, A).Value() 'PADRE
                    HOSPITALIZACION.TXTMADRE.Text = DGVGENERAL.Item(19, A).Value() 'MADRE
                    If DGVGENERAL.Item(20, A).Value() = "SI" Then 'LUNES
                        HOSPITALIZACION.CBLUNES.CheckState = CheckState.Checked
                    Else
                        HOSPITALIZACION.CBLUNES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(21, A).Value() = "SI" Then 'MARTES
                        HOSPITALIZACION.CBMARTES.CheckState = CheckState.Checked
                    Else
                        HOSPITALIZACION.CBMARTES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(22, A).Value() = "SI" Then 'MIERCOLES
                        HOSPITALIZACION.CBMIERCOLES.CheckState = CheckState.Checked
                    Else
                        HOSPITALIZACION.CBMIERCOLES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(23, A).Value() = "SI" Then 'JUEVES
                        HOSPITALIZACION.CBJUEVES.CheckState = CheckState.Checked
                    Else
                        HOSPITALIZACION.CBJUEVES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(24, A).Value() = "SI" Then 'VIERNES
                        HOSPITALIZACION.CBVIERNES.CheckState = CheckState.Checked
                    Else
                        HOSPITALIZACION.CBVIERNES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(25, A).Value() = "SI" Then 'SABADO
                        HOSPITALIZACION.CBSABADO.CheckState = CheckState.Checked
                    Else
                        HOSPITALIZACION.CBSABADO.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(26, A).Value() = "SI" Then 'DOMINGO
                        HOSPITALIZACION.CBDOMINGO.CheckState = CheckState.Checked
                    Else
                        HOSPITALIZACION.CBDOMINGO.CheckState = CheckState.Unchecked
                    End If
                    HOSPITALIZACION.FN.Value = DGVGENERAL.Item(27, A).Value() 'FECHA NACIMIENTO
                    HOSPITALIZACION.TXTDIAGNOSTICO.Text = DGVGENERAL.Item(28, A).Value() 'DIAGNOSTICO
                    HOSPITALIZACION.CMBESTADO.Text = DGVGENERAL.Item(29, A).Value() 'ESTADO CIVIL
                    HOSPITALIZACION.CMBOCUPACION.Text = DGVGENERAL.Item(30, A).Value() 'OCUPACION
                    HOSPITALIZACION.TXTNOMBRES.Enabled = True : HOSPITALIZACION.TXTPRIMERAPELLIDO.Enabled = True
                    HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Enabled = True : HOSPITALIZACION.TXTCORRELATIVO.Enabled = False
                    HOSPITALIZACION.TXTCOLONIA.Enabled = True : HOSPITALIZACION.TXTCASA.Enabled = True
                    HOSPITALIZACION.CMBDEPARTAMENTO.Enabled = True : HOSPITALIZACION.CMBMUNICIPIO.Enabled = True
                    HOSPITALIZACION.TXTTELEFONO1.Enabled = True : HOSPITALIZACION.TXTTELEFONO2.Enabled = True
                    HOSPITALIZACION.TXTTELEFONO3.Enabled = True : HOSPITALIZACION.TXTTELEFONO4.Enabled = True
                    HOSPITALIZACION.CMBSEXO.Enabled = True : HOSPITALIZACION.FN.Enabled = True
                    HOSPITALIZACION.TXTPADRE.Enabled = True : HOSPITALIZACION.TXTMADRE.Enabled = True
                    HOSPITALIZACION.TXTEDAD.Enabled = True : HOSPITALIZACION.CMBTIPO.Enabled = True
                    HOSPITALIZACION.TXTSALA.Enabled = True
                    HOSPITALIZACION.TXTRESPONSABLE.Enabled = True
                    HOSPITALIZACION.TXTDIRECCION.Enabled = True
                    HOSPITALIZACION.BTNSALA.Enabled = True
                    HOSPITALIZACION.TXTSERVICIO.Enabled = True
                    HOSPITALIZACION.BTNRESPONSABLE.Enabled = True
                    HOSPITALIZACION.CMBPARENTEZCO.Enabled = True
                    HOSPITALIZACION.CMBESTADO.Enabled = True
                    HOSPITALIZACION.CMBOCUPACION.Enabled = True
                    HOSPITALIZACION.CMBINGRESO.Enabled = True
                    HOSPITALIZACION.BTNGUARDA.Enabled = False
                    HOSPITALIZACION.BTNMODIFICA.Enabled = True : HOSPITALIZACION.BTNGUARDAR.Enabled = False
                    HOSPITALIZACION.BTNSALA.Visible = True
                    HOSPITALIZACION.TXTIDENTIDAD.Focus()
                    Me.Close()
                ElseIf DGVGENERAL.Item(31, A).Value() <> "0101-01-01" Then
                    MsgBox("NO SE PUEDE USAR EL REGISTRO YA QUE TIENE UNA FECHA DE DEFUNCION: " _
                           & DGVGENERAL.Item(31, A).Value() & Chr(13) _
                           & "SELECCIONE OTRO ITEM", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    HOSPITALIZACION.TXTNOMBRES.Enabled = False : HOSPITALIZACION.TXTPRIMERAPELLIDO.Enabled = False
                    HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Enabled = False : HOSPITALIZACION.TXTCORRELATIVO.Enabled = False
                    HOSPITALIZACION.TXTCOLONIA.Enabled = False : HOSPITALIZACION.TXTCASA.Enabled = False
                    HOSPITALIZACION.CMBDEPARTAMENTO.Enabled = False : HOSPITALIZACION.CMBMUNICIPIO.Enabled = False
                    HOSPITALIZACION.TXTTELEFONO1.Enabled = False : HOSPITALIZACION.TXTTELEFONO2.Enabled = False
                    HOSPITALIZACION.TXTTELEFONO3.Enabled = False : HOSPITALIZACION.TXTTELEFONO4.Enabled = False
                    HOSPITALIZACION.CMBSEXO.Enabled = False : HOSPITALIZACION.FN.Enabled = False
                    HOSPITALIZACION.TXTPADRE.Enabled = False : HOSPITALIZACION.TXTMADRE.Enabled = False
                    HOSPITALIZACION.TXTEDAD.Enabled = False : HOSPITALIZACION.CMBTIPO.Enabled = False
                    HOSPITALIZACION.TXTSALA.Enabled = False
                    HOSPITALIZACION.TXTRESPONSABLE.Enabled = False
                    HOSPITALIZACION.TXTDIRECCION.Enabled = False
                    HOSPITALIZACION.BTNSALA.Enabled = False
                    HOSPITALIZACION.TXTSERVICIO.Enabled = False
                    HOSPITALIZACION.BTNRESPONSABLE.Enabled = False
                    HOSPITALIZACION.CMBPARENTEZCO.Enabled = False
                    HOSPITALIZACION.CMBESTADO.Enabled = False
                    HOSPITALIZACION.CMBOCUPACION.Enabled = False
                    HOSPITALIZACION.CMBESTADO.Enabled = False
                    HOSPITALIZACION.CMBINGRESO.Enabled = False
                    HOSPITALIZACION.BTNGUARDA.Enabled = False
                    HOSPITALIZACION.BTNMODIFICA.Enabled = False : HOSPITALIZACION.BTNGUARDAR.Enabled = False
                    HOSPITALIZACION.BTNSALA.Visible = False
                    HOSPITALIZACION.TXTIDENTIDAD.Text = ""
                    HOSPITALIZACION.TXTCORRELATIVO.Text = "0000-0000"
                    HOSPITALIZACION.TXTIDENTIDAD.Focus()
                    Me.Close()
                End If
            ElseIf DGVGENERAL.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN ITEM CARGADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                Me.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            HOSPITALIZACION.TXTNOMBRES.Enabled = True : HOSPITALIZACION.TXTPRIMERAPELLIDO.Enabled = True
            HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Enabled = True : HOSPITALIZACION.TXTCORRELATIVO.Enabled = False
            HOSPITALIZACION.TXTCOLONIA.Enabled = True : HOSPITALIZACION.TXTCASA.Enabled = True
            HOSPITALIZACION.CMBDEPARTAMENTO.Enabled = True : HOSPITALIZACION.CMBMUNICIPIO.Enabled = True
            HOSPITALIZACION.TXTTELEFONO1.Enabled = True : HOSPITALIZACION.TXTTELEFONO2.Enabled = True
            HOSPITALIZACION.TXTTELEFONO3.Enabled = True : HOSPITALIZACION.TXTTELEFONO4.Enabled = True
            HOSPITALIZACION.CMBSEXO.Enabled = True : HOSPITALIZACION.FN.Enabled = True
            HOSPITALIZACION.TXTPADRE.Enabled = True : HOSPITALIZACION.TXTMADRE.Enabled = True
            HOSPITALIZACION.TXTEDAD.Enabled = True : HOSPITALIZACION.CMBTIPO.Enabled = True
            HOSPITALIZACION.TXTSALA.Enabled = True
            HOSPITALIZACION.TXTRESPONSABLE.Enabled = True
            HOSPITALIZACION.TXTDIRECCION.Enabled = True
            HOSPITALIZACION.BTNSALA.Enabled = True
            HOSPITALIZACION.TXTSERVICIO.Enabled = True
            HOSPITALIZACION.BTNRESPONSABLE.Enabled = True
            HOSPITALIZACION.CMBPARENTEZCO.Enabled = True
            HOSPITALIZACION.CMBESTADO.Enabled = True
            HOSPITALIZACION.CMBOCUPACION.Enabled = True
            HOSPITALIZACION.CMBESTADO.Enabled = True
            HOSPITALIZACION.CMBINGRESO.Enabled = True
            HOSPITALIZACION.BTNGUARDA.Enabled = False
            HOSPITALIZACION.BTNMODIFICA.Enabled = True : HOSPITALIZACION.BTNGUARDAR.Enabled = False
            HOSPITALIZACION.BTNSALA.Visible = True
            HOSPITALIZACION.TXTIDENTIDAD.Focus()
            Me.Close()
        End Try
    End Sub

    Private Sub BUSQUEDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CMBCLASIFICACION.Text = "" And CMBNACIONALIDAD.Text = "" And CMBBUSQUEDA.Text = "" Then
            Me.Close()
        End If
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
                HOSPITALIZACION.TXTNOMBRES.Enabled = True : HOSPITALIZACION.TXTPRIMERAPELLIDO.Enabled = True
                HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Enabled = True : HOSPITALIZACION.TXTCORRELATIVO.Enabled = False
                HOSPITALIZACION.TXTCOLONIA.Enabled = True : HOSPITALIZACION.TXTCASA.Enabled = True
                HOSPITALIZACION.CMBDEPARTAMENTO.Enabled = True : HOSPITALIZACION.CMBMUNICIPIO.Enabled = True
                HOSPITALIZACION.TXTTELEFONO1.Enabled = True : HOSPITALIZACION.TXTTELEFONO2.Enabled = True
                HOSPITALIZACION.TXTTELEFONO3.Enabled = True : HOSPITALIZACION.TXTTELEFONO4.Enabled = True
                HOSPITALIZACION.CMBSEXO.Enabled = True : HOSPITALIZACION.FN.Enabled = True
                HOSPITALIZACION.TXTPADRE.Enabled = True : HOSPITALIZACION.TXTMADRE.Enabled = True
                HOSPITALIZACION.TXTEDAD.Enabled = True : HOSPITALIZACION.CMBTIPO.Enabled = True
                HOSPITALIZACION.TXTSALA.Enabled = True
                HOSPITALIZACION.TXTRESPONSABLE.Enabled = True
                HOSPITALIZACION.TXTDIRECCION.Enabled = True
                HOSPITALIZACION.BTNSALA.Enabled = True
                HOSPITALIZACION.TXTSERVICIO.Enabled = True
                HOSPITALIZACION.BTNRESPONSABLE.Enabled = True
                HOSPITALIZACION.CMBPARENTEZCO.Enabled = True
                HOSPITALIZACION.CMBESTADO.Enabled = True
                HOSPITALIZACION.CMBOCUPACION.Enabled = True
                HOSPITALIZACION.CMBESTADO.Enabled = True
                HOSPITALIZACION.CMBINGRESO.Enabled = True
                HOSPITALIZACION.BTNGUARDA.Enabled = True
                HOSPITALIZACION.BTNMODIFICA.Enabled = False : HOSPITALIZACION.BTNGUARDAR.Enabled = True
                HOSPITALIZACION.BTNSALA.Visible = True
                HOSPITALIZACION.TXTIDENTIDAD.Focus()
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
                HOSPITALIZACION.TXTNOMBRES.Enabled = True : HOSPITALIZACION.TXTPRIMERAPELLIDO.Enabled = True
                HOSPITALIZACION.TXTSEGUNDOAPELLIDO.Enabled = True : HOSPITALIZACION.TXTCORRELATIVO.Enabled = False
                HOSPITALIZACION.TXTCOLONIA.Enabled = True : HOSPITALIZACION.TXTCASA.Enabled = True
                HOSPITALIZACION.CMBDEPARTAMENTO.Enabled = True : HOSPITALIZACION.CMBMUNICIPIO.Enabled = True
                HOSPITALIZACION.TXTTELEFONO1.Enabled = True : HOSPITALIZACION.TXTTELEFONO2.Enabled = True
                HOSPITALIZACION.TXTTELEFONO3.Enabled = True : HOSPITALIZACION.TXTTELEFONO4.Enabled = True
                HOSPITALIZACION.CMBSEXO.Enabled = True : HOSPITALIZACION.FN.Enabled = True
                HOSPITALIZACION.TXTPADRE.Enabled = True : HOSPITALIZACION.TXTMADRE.Enabled = True
                HOSPITALIZACION.TXTEDAD.Enabled = True : HOSPITALIZACION.CMBTIPO.Enabled = True
                HOSPITALIZACION.TXTSALA.Enabled = True
                HOSPITALIZACION.TXTRESPONSABLE.Enabled = True
                HOSPITALIZACION.TXTDIRECCION.Enabled = True
                HOSPITALIZACION.BTNSALA.Enabled = True
                HOSPITALIZACION.TXTSERVICIO.Enabled = True
                HOSPITALIZACION.BTNRESPONSABLE.Enabled = True
                HOSPITALIZACION.CMBPARENTEZCO.Enabled = True
                HOSPITALIZACION.CMBESTADO.Enabled = True
                HOSPITALIZACION.CMBOCUPACION.Enabled = True
                HOSPITALIZACION.CMBESTADO.Enabled = True
                HOSPITALIZACION.CMBINGRESO.Enabled = True
                HOSPITALIZACION.BTNGUARDA.Enabled = True
                HOSPITALIZACION.BTNMODIFICA.Enabled = False : HOSPITALIZACION.BTNGUARDAR.Enabled = True
                HOSPITALIZACION.BTNSALA.Visible = True
                HOSPITALIZACION.TXTIDENTIDAD.Focus()
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

    Private Sub CBSI_CheckedChanged(sender As Object, e As EventArgs) Handles CBSI.CheckedChanged
        If CBSI.Checked = True Then
            CBNO.Checked = False
            GENERAL()
        ElseIf CBSI.Checked = False Then
            CBNO.Checked = True
            ESPECIFICO()
        End If
    End Sub

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        DGVGENERAL.Columns.Clear()
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
    End Sub
End Class