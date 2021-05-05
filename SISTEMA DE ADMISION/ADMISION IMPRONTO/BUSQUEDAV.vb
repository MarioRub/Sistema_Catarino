Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSQUEDAV
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
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NO").HeaderText = "ITEM" '0
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
                ADAPTADOR.Dispose()
                DATO.Dispose()
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                IMPRONTO.TXTNOMBRES.Enabled = True : IMPRONTO.TXTPRIMERAPELLIDO.Enabled = True
                IMPRONTO.TXTSEGUNDOAPELLIDO.Enabled = True : IMPRONTO.TXTCORRELATIVO.Enabled = False
                IMPRONTO.TXTCOLONIA.Enabled = True : IMPRONTO.TXTCASA.Enabled = True
                IMPRONTO.CMBDEPARTAMENTO.Enabled = True : IMPRONTO.CMBMUNICIPIO.Enabled = True
                IMPRONTO.TXTTELEFONO1.Enabled = True : IMPRONTO.TXTTELEFONO2.Enabled = True
                IMPRONTO.TXTTELEFONO3.Enabled = True : IMPRONTO.TXTTELEFONO4.Enabled = True
                IMPRONTO.CMBSEXO.Enabled = True : IMPRONTO.FN.Enabled = True
                IMPRONTO.TXTPADRE.Enabled = True : IMPRONTO.TXTMADRE.Enabled = True
                IMPRONTO.TXTEDAD.Enabled = True : IMPRONTO.CMBTIPO.Enabled = True
                IMPRONTO.TXTREMITENTE.Enabled = True
                IMPRONTO.TXTRESPONSABLE.Enabled = True
                IMPRONTO.TXTDIRECCION.Enabled = True
                IMPRONTO.BTNSALA.Enabled = True
                IMPRONTO.BTNRESPONSABLE.Enabled = True
                IMPRONTO.CMBPARENTEZCO.Enabled = True
                IMPRONTO.BTNGUARDA.Enabled = True
                IMPRONTO.CMBPRIORIDAD.Enabled = True : IMPRONTO.TXTPERSONA.Enabled = True
                IMPRONTO.TXTMOTIVO.Enabled = True : IMPRONTO.TXTFISICO.Enabled = True
                IMPRONTO.BTNMODIFICA.Enabled = False : IMPRONTO.BTNGUARDAR.Enabled = True
                IMPRONTO.BTNSALA.Visible = True
                IMPRONTO.TXTIDENTIDAD.Focus()
                Me.Close()
                ADAPTADOR.Dispose()
                DATO.Dispose()
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
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NO").HeaderText = "ITEM" '0
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
                ADAPTADOR.Dispose()
                DATO.Dispose()
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                IMPRONTO.TXTNOMBRES.Enabled = True : IMPRONTO.TXTPRIMERAPELLIDO.Enabled = True
                IMPRONTO.TXTSEGUNDOAPELLIDO.Enabled = True : IMPRONTO.TXTCORRELATIVO.Enabled = False
                IMPRONTO.TXTCOLONIA.Enabled = True : IMPRONTO.TXTCASA.Enabled = True
                IMPRONTO.CMBDEPARTAMENTO.Enabled = True : IMPRONTO.CMBMUNICIPIO.Enabled = True
                IMPRONTO.TXTTELEFONO1.Enabled = True : IMPRONTO.TXTTELEFONO2.Enabled = True
                IMPRONTO.TXTTELEFONO3.Enabled = True : IMPRONTO.TXTTELEFONO4.Enabled = True
                IMPRONTO.CMBSEXO.Enabled = True : IMPRONTO.FN.Enabled = True
                IMPRONTO.TXTPADRE.Enabled = True : IMPRONTO.TXTMADRE.Enabled = True
                IMPRONTO.TXTEDAD.Enabled = True : IMPRONTO.CMBTIPO.Enabled = True
                IMPRONTO.TXTREMITENTE.Enabled = True
                IMPRONTO.TXTRESPONSABLE.Enabled = True
                IMPRONTO.TXTDIRECCION.Enabled = True
                IMPRONTO.BTNSALA.Enabled = True
                IMPRONTO.BTNRESPONSABLE.Enabled = True
                IMPRONTO.CMBPARENTEZCO.Enabled = True
                IMPRONTO.CMBPRIORIDAD.Enabled = True : IMPRONTO.TXTPERSONA.Enabled = True
                IMPRONTO.TXTMOTIVO.Enabled = True : IMPRONTO.TXTFISICO.Enabled = True
                IMPRONTO.BTNGUARDA.Enabled = True
                IMPRONTO.BTNMODIFICA.Enabled = False : IMPRONTO.BTNGUARDAR.Enabled = True
                IMPRONTO.BTNSALA.Visible = True
                IMPRONTO.TXTIDENTIDAD.Focus()
                Me.Close()
                ADAPTADOR.Dispose()
                DATO.Dispose()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        IMPRONTO.TXTNOMBRES.Enabled = True : IMPRONTO.TXTPRIMERAPELLIDO.Enabled = True
        IMPRONTO.TXTSEGUNDOAPELLIDO.Enabled = True : IMPRONTO.TXTCORRELATIVO.Enabled = False
        IMPRONTO.TXTCOLONIA.Enabled = True : IMPRONTO.TXTCASA.Enabled = True
        IMPRONTO.CMBDEPARTAMENTO.Enabled = True : IMPRONTO.CMBMUNICIPIO.Enabled = True
        IMPRONTO.TXTTELEFONO1.Enabled = True : IMPRONTO.TXTTELEFONO2.Enabled = True
        IMPRONTO.TXTTELEFONO3.Enabled = True : IMPRONTO.TXTTELEFONO4.Enabled = True
        IMPRONTO.CMBSEXO.Enabled = True : IMPRONTO.FN.Enabled = True
        IMPRONTO.TXTPADRE.Enabled = True : IMPRONTO.TXTMADRE.Enabled = True
        IMPRONTO.TXTEDAD.Enabled = True : IMPRONTO.CMBTIPO.Enabled = True
        IMPRONTO.TXTMOTIVO.Enabled = True : IMPRONTO.TXTFISICO.Enabled = True
        IMPRONTO.TXTREMITENTE.Enabled = True
        IMPRONTO.TXTRESPONSABLE.Enabled = True
        IMPRONTO.TXTPERSONA.Enabled = True
        IMPRONTO.TXTDIRECCION.Enabled = True
        IMPRONTO.BTNSALA.Enabled = True
        IMPRONTO.BTNRESPONSABLE.Enabled = True
        IMPRONTO.CMBPARENTEZCO.Enabled = True
        IMPRONTO.CMBPRIORIDAD.Enabled = True
        IMPRONTO.BTNGUARDA.Enabled = False
        IMPRONTO.BTNMODIFICA.Enabled = False : IMPRONTO.BTNGUARDAR.Enabled = True
        IMPRONTO.BTNSALA.Visible = True
        IMPRONTO.TXTIDENTIDAD.Focus()
        Me.Close()
    End Sub

    Private Sub BTNCAEPTAR_Click(sender As Object, e As EventArgs) Handles BTNCAEPTAR.Click
        Try
            Dim A As Integer
            If DGVGENERAL.Rows.Count > 0 Then
                A = DGVGENERAL.CurrentRow.Index
                If DGVGENERAL.Item(31, A).Value() = "0101-01-01" Then
                    IMPRONTO.CMBCLASIFICACION.Text = DGVGENERAL.Item(3, A).Value() 'TIPO CLASIFICACION
                    IMPRONTO.CMBNACIONALIDAD.Text = DGVGENERAL.Item(1, A).Value() ' NACIONALIDAD
                    IMPRONTO.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text 'TIPO BSUQUEDA
                    IMPRONTO.TXTIDENTIDAD.Text = DGVGENERAL.Item(10, A).Value() 'IDENTIDAD
                    IMPRONTO.TXTCORRELATIVO.Text = DGVGENERAL.Item(9, A).Value() 'CORRELATIVO
                    IMPRONTO.TXTPAIS.Text = DGVGENERAL.Item(2, A).Value() 'PAIS
                    IMPRONTO.TXTNOMBRES.Text = DGVGENERAL.Item(4, A).Value() 'NOMBRE DEL PACIENTE
                    IMPRONTO.TXTPRIMERAPELLIDO.Text = DGVGENERAL.Item(5, A).Value() 'PRIMER APELLIDO
                    IMPRONTO.TXTSEGUNDOAPELLIDO.Text = DGVGENERAL.Item(6, A).Value() 'SEGUNDO APELLIDO
                    IMPRONTO.TXTCOLONIA.Text = DGVGENERAL.Item(11, A).Value() 'COLONIA
                    IMPRONTO.TXTCASA.Text = DGVGENERAL.Item(12, A).Value() 'CASA
                    IMPRONTO.CMBDEPARTAMENTO.Text = DGVGENERAL.Item(13, A).Value() 'DEPARTAMENTO
                    IMPRONTO.CMBMUNICIPIO.Text = DGVGENERAL.Item(14, A).Value() 'MUNICIPIO
                    IMPRONTO.TXTTELEFONO3.Text = DGVGENERAL.Item(15, A).Value() 'TELEFONO 1
                    IMPRONTO.TXTTELEFONO4.Text = DGVGENERAL.Item(16, A).Value() 'TELEFONO 2
                    IMPRONTO.CMBSEXO.Text = DGVGENERAL.Item(17, A).Value() 'SEXO
                    IMPRONTO.TXTPADRE.Text = DGVGENERAL.Item(18, A).Value() 'PADRE
                    IMPRONTO.TXTMADRE.Text = DGVGENERAL.Item(19, A).Value() 'MADRE
                    If DGVGENERAL.Item(20, A).Value() = "SI" Then 'LUNES
                        IMPRONTO.CBLUNES.CheckState = CheckState.Checked
                    Else
                        IMPRONTO.CBLUNES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(21, A).Value() = "SI" Then 'MARTES
                        IMPRONTO.CBMARTES.CheckState = CheckState.Checked
                    Else
                        IMPRONTO.CBMARTES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(22, A).Value() = "SI" Then 'MIERCOLES
                        IMPRONTO.CBMIERCOLES.CheckState = CheckState.Checked
                    Else
                        IMPRONTO.CBMIERCOLES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(23, A).Value() = "SI" Then 'JUEVES
                        IMPRONTO.CBJUEVES.CheckState = CheckState.Checked
                    Else
                        IMPRONTO.CBJUEVES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(24, A).Value() = "SI" Then 'VIERNES
                        IMPRONTO.CBVIERNES.CheckState = CheckState.Checked
                    Else
                        IMPRONTO.CBVIERNES.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(25, A).Value() = "SI" Then 'SABADO
                        IMPRONTO.CBSABADO.CheckState = CheckState.Checked
                    Else
                        IMPRONTO.CBSABADO.CheckState = CheckState.Unchecked
                    End If
                    If DGVGENERAL.Item(26, A).Value() = "SI" Then 'DOMINGO
                        IMPRONTO.CBDOMINGO.CheckState = CheckState.Checked
                    Else
                        IMPRONTO.CBDOMINGO.CheckState = CheckState.Unchecked
                    End If
                    IMPRONTO.FN.Value = DGVGENERAL.Item(27, A).Value() 'FECHA NACIMIENTO
                    IMPRONTO.TXTDIAGNOSTICO.Text = DGVGENERAL.Item(28, A).Value() 'DIAGNOSTICO
                    IMPRONTO.TXTNOMBRES.Enabled = True : IMPRONTO.TXTPRIMERAPELLIDO.Enabled = True
                    IMPRONTO.TXTSEGUNDOAPELLIDO.Enabled = True : IMPRONTO.TXTCORRELATIVO.Enabled = False
                    IMPRONTO.TXTCOLONIA.Enabled = True : IMPRONTO.TXTCASA.Enabled = True
                    IMPRONTO.CMBDEPARTAMENTO.Enabled = True : IMPRONTO.CMBMUNICIPIO.Enabled = True
                    IMPRONTO.TXTTELEFONO1.Enabled = True : IMPRONTO.TXTTELEFONO2.Enabled = True
                    IMPRONTO.TXTTELEFONO3.Enabled = True : IMPRONTO.TXTTELEFONO4.Enabled = True
                    IMPRONTO.CMBSEXO.Enabled = True : IMPRONTO.FN.Enabled = True
                    IMPRONTO.TXTPADRE.Enabled = True : IMPRONTO.TXTMADRE.Enabled = True
                    IMPRONTO.TXTEDAD.Enabled = True : IMPRONTO.CMBTIPO.Enabled = True
                    IMPRONTO.TXTREMITENTE.Enabled = True
                    IMPRONTO.TXTRESPONSABLE.Enabled = True
                    IMPRONTO.TXTDIRECCION.Enabled = True
                    IMPRONTO.BTNSALA.Enabled = True
                    IMPRONTO.BTNRESPONSABLE.Enabled = True
                    IMPRONTO.CMBPARENTEZCO.Enabled = True
                    IMPRONTO.BTNGUARDA.Enabled = False
                    IMPRONTO.CMBPRIORIDAD.Enabled = True
                    IMPRONTO.TXTPERSONA.Enabled = True
                    IMPRONTO.TXTMOTIVO.Enabled = True : IMPRONTO.TXTFISICO.Enabled = True
                    IMPRONTO.BTNMODIFICA.Enabled = True : IMPRONTO.BTNGUARDAR.Enabled = False
                    IMPRONTO.BTNSALA.Visible = True
                    IMPRONTO.TXTIDENTIDAD.Focus()
                    Me.Close()
                ElseIf DGVGENERAL.Item(31, A).Value() <> "0101-01-01" Then
                    MsgBox("NO SE PUEDE USAR EL REGISTRO YA QUE TIENE UNA FECHA DE DEFUNCION: " _
                           & DGVGENERAL.Item(31, A).Value() & Chr(13) _
                           & "SELECCIONE OTRO ITEM", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    IMPRONTO.TXTNOMBRES.Enabled = False : IMPRONTO.TXTPRIMERAPELLIDO.Enabled = False
                    IMPRONTO.TXTSEGUNDOAPELLIDO.Enabled = False : IMPRONTO.TXTCORRELATIVO.Enabled = False
                    IMPRONTO.TXTCOLONIA.Enabled = False : IMPRONTO.TXTCASA.Enabled = False
                    IMPRONTO.CMBDEPARTAMENTO.Enabled = False : IMPRONTO.CMBMUNICIPIO.Enabled = False
                    IMPRONTO.TXTTELEFONO1.Enabled = False : IMPRONTO.TXTTELEFONO2.Enabled = False
                    IMPRONTO.TXTTELEFONO3.Enabled = False : IMPRONTO.TXTTELEFONO4.Enabled = False
                    IMPRONTO.CMBSEXO.Enabled = False : IMPRONTO.FN.Enabled = False
                    IMPRONTO.TXTPADRE.Enabled = False : IMPRONTO.TXTMADRE.Enabled = False
                    IMPRONTO.TXTEDAD.Enabled = False : IMPRONTO.CMBTIPO.Enabled = False
                    IMPRONTO.TXTREMITENTE.Enabled = False
                    IMPRONTO.TXTRESPONSABLE.Enabled = False
                    IMPRONTO.TXTDIRECCION.Enabled = False
                    IMPRONTO.BTNSALA.Enabled = False
                    IMPRONTO.BTNRESPONSABLE.Enabled = False
                    IMPRONTO.CMBPARENTEZCO.Enabled = False
                    IMPRONTO.BTNGUARDA.Enabled = False
                    IMPRONTO.CMBPRIORIDAD.Enabled = False : IMPRONTO.TXTPERSONA.Enabled = False
                    IMPRONTO.TXTMOTIVO.Enabled = False : IMPRONTO.TXTFISICO.Enabled = False
                    IMPRONTO.BTNMODIFICA.Enabled = False : IMPRONTO.BTNGUARDAR.Enabled = False
                    IMPRONTO.BTNSALA.Visible = False
                    IMPRONTO.TXTIDENTIDAD.Text = ""
                    IMPRONTO.TXTCORRELATIVO.Text = "0000-0000"
                    IMPRONTO.TXTIDENTIDAD.Focus()
                    Me.Close()
                End If
            ElseIf DGVGENERAL.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN ITEM CARGADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                Me.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            IMPRONTO.TXTNOMBRES.Enabled = True : IMPRONTO.TXTPRIMERAPELLIDO.Enabled = True
            IMPRONTO.TXTSEGUNDOAPELLIDO.Enabled = True : IMPRONTO.TXTCORRELATIVO.Enabled = False
            IMPRONTO.TXTCOLONIA.Enabled = True : IMPRONTO.TXTCASA.Enabled = True
            IMPRONTO.CMBDEPARTAMENTO.Enabled = True : IMPRONTO.CMBMUNICIPIO.Enabled = True
            IMPRONTO.TXTTELEFONO1.Enabled = True : IMPRONTO.TXTTELEFONO2.Enabled = True
            IMPRONTO.TXTTELEFONO3.Enabled = True : IMPRONTO.TXTTELEFONO4.Enabled = True
            IMPRONTO.CMBSEXO.Enabled = True : IMPRONTO.FN.Enabled = True
            IMPRONTO.TXTPADRE.Enabled = True : IMPRONTO.TXTMADRE.Enabled = True
            IMPRONTO.TXTEDAD.Enabled = True : IMPRONTO.CMBTIPO.Enabled = True
            IMPRONTO.TXTMOTIVO.Enabled = True : IMPRONTO.TXTFISICO.Enabled = True
            IMPRONTO.TXTREMITENTE.Enabled = True
            IMPRONTO.TXTRESPONSABLE.Enabled = True
            IMPRONTO.TXTPERSONA.Enabled = True
            IMPRONTO.TXTDIRECCION.Enabled = True
            IMPRONTO.BTNSALA.Enabled = True
            IMPRONTO.BTNRESPONSABLE.Enabled = True
            IMPRONTO.CMBPARENTEZCO.Enabled = True
            IMPRONTO.CMBPRIORIDAD.Enabled = True
            IMPRONTO.BTNGUARDA.Enabled = False
            IMPRONTO.BTNMODIFICA.Enabled = True : IMPRONTO.BTNGUARDAR.Enabled = False
            IMPRONTO.BTNSALA.Visible = True
            IMPRONTO.TXTIDENTIDAD.Focus()
            Me.Close()
        End Try
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
    Private Sub BUSQUEDAV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NO").HeaderText = "ITEM" '0
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
                ADAPTADOR.Dispose()
                DATO.Dispose()
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                IMPRONTO.TXTNOMBRES.Enabled = True : IMPRONTO.TXTPRIMERAPELLIDO.Enabled = True
                IMPRONTO.TXTSEGUNDOAPELLIDO.Enabled = True : IMPRONTO.TXTCORRELATIVO.Enabled = False
                IMPRONTO.TXTCOLONIA.Enabled = True : IMPRONTO.TXTCASA.Enabled = True
                IMPRONTO.CMBDEPARTAMENTO.Enabled = True : IMPRONTO.CMBMUNICIPIO.Enabled = True
                IMPRONTO.TXTTELEFONO1.Enabled = True : IMPRONTO.TXTTELEFONO2.Enabled = True
                IMPRONTO.TXTTELEFONO3.Enabled = True : IMPRONTO.TXTTELEFONO4.Enabled = True
                IMPRONTO.CMBSEXO.Enabled = True : IMPRONTO.FN.Enabled = True
                IMPRONTO.TXTPADRE.Enabled = True : IMPRONTO.TXTMADRE.Enabled = True
                IMPRONTO.TXTEDAD.Enabled = True : IMPRONTO.CMBTIPO.Enabled = True
                IMPRONTO.TXTREMITENTE.Enabled = True
                IMPRONTO.TXTRESPONSABLE.Enabled = True
                IMPRONTO.TXTDIRECCION.Enabled = True
                IMPRONTO.BTNSALA.Enabled = True
                IMPRONTO.BTNRESPONSABLE.Enabled = True
                IMPRONTO.CMBPARENTEZCO.Enabled = True
                IMPRONTO.BTNGUARDA.Enabled = True
                IMPRONTO.CMBPRIORIDAD.Enabled = True : IMPRONTO.TXTPERSONA.Enabled = True
                IMPRONTO.TXTMOTIVO.Enabled = True : IMPRONTO.TXTFISICO.Enabled = True
                IMPRONTO.BTNMODIFICA.Enabled = False : IMPRONTO.BTNGUARDAR.Enabled = True
                IMPRONTO.BTNSALA.Visible = True
                IMPRONTO.TXTIDENTIDAD.Focus()
                Me.Close()
                ADAPTADOR.Dispose()
                DATO.Dispose()
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
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NO").HeaderText = "ITEM" '0
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
                ADAPTADOR.Dispose()
                DATO.Dispose()
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                IMPRONTO.TXTNOMBRES.Enabled = True : IMPRONTO.TXTPRIMERAPELLIDO.Enabled = True
                IMPRONTO.TXTSEGUNDOAPELLIDO.Enabled = True : IMPRONTO.TXTCORRELATIVO.Enabled = False
                IMPRONTO.TXTCOLONIA.Enabled = True : IMPRONTO.TXTCASA.Enabled = True
                IMPRONTO.CMBDEPARTAMENTO.Enabled = True : IMPRONTO.CMBMUNICIPIO.Enabled = True
                IMPRONTO.TXTTELEFONO1.Enabled = True : IMPRONTO.TXTTELEFONO2.Enabled = True
                IMPRONTO.TXTTELEFONO3.Enabled = True : IMPRONTO.TXTTELEFONO4.Enabled = True
                IMPRONTO.CMBSEXO.Enabled = True : IMPRONTO.FN.Enabled = True
                IMPRONTO.TXTPADRE.Enabled = True : IMPRONTO.TXTMADRE.Enabled = True
                IMPRONTO.TXTEDAD.Enabled = True : IMPRONTO.CMBTIPO.Enabled = True
                IMPRONTO.TXTREMITENTE.Enabled = True
                IMPRONTO.TXTRESPONSABLE.Enabled = True
                IMPRONTO.TXTDIRECCION.Enabled = True
                IMPRONTO.BTNSALA.Enabled = True
                IMPRONTO.BTNRESPONSABLE.Enabled = True
                IMPRONTO.CMBPARENTEZCO.Enabled = True
                IMPRONTO.CMBPRIORIDAD.Enabled = True : IMPRONTO.TXTPERSONA.Enabled = True
                IMPRONTO.TXTMOTIVO.Enabled = True : IMPRONTO.TXTFISICO.Enabled = True
                IMPRONTO.BTNGUARDA.Enabled = True
                IMPRONTO.BTNMODIFICA.Enabled = False : IMPRONTO.BTNGUARDAR.Enabled = True
                IMPRONTO.BTNSALA.Visible = True
                IMPRONTO.TXTIDENTIDAD.Focus()
                Me.Close()
                ADAPTADOR.Dispose()
                DATO.Dispose()
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