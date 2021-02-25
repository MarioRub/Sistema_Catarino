Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSCAR_PACIENTE
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Sub IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
                                & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
                                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, " _
                                & "FECHA_NACIMIENTO, DIAGNOSTICO, ESTADO_CIVIL, OCUPACION, CASE WHEN (DEFUNCION = '0101-01-01')" _
                                & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO FROM UNICO " _
                                & "WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
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
                DGVGENERAL.Columns("ESTADO_CIVIL").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("OCUPACION").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUERTO").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "ITEM"
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD"
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS"
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("NOMBRE_PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("NOMBRE_MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("LUNES").HeaderText = "LU"
                DGVGENERAL.Columns("MARTES").HeaderText = "MA"
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI"
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU"
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI"
                DGVGENERAL.Columns("SABADO").HeaderText = "SA"
                DGVGENERAL.Columns("DOMINGO").HeaderText = "DO"
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO"
                DGVGENERAL.Columns("ESTADO_CIVIL").HeaderText = "ESTADO CIVIL"
                DGVGENERAL.Columns("OCUPACION").HeaderText = "OCUPACION"
                DGVGENERAL.Columns("MUERTO").HeaderText = "DEFUNCION"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
                CBDIAGNOSTICO.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub DIAGNOSTICO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
                                & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
                                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, " _
                                & "FECHA_NACIMIENTO, DIAGNOSTICO, ESTADO_CIVIL, OCUPACION, CASE WHEN (DEFUNCION = '0101-01-01')" _
                                & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO " _
                                & "FROM UNICO WHERE DIAGNOSTICO LIKE '" & "%" & TXTDIAGNOSTICO.Text & "%" & "'"
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
                DGVGENERAL.Columns("ESTADO_CIVIL").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("OCUPACION").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUERTO").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "ITEM"
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD"
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS"
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("NOMBRE_PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("NOMBRE_MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("LUNES").HeaderText = "LU"
                DGVGENERAL.Columns("MARTES").HeaderText = "MA"
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI"
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU"
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI"
                DGVGENERAL.Columns("SABADO").HeaderText = "SA"
                DGVGENERAL.Columns("DOMINGO").HeaderText = "DO"
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO"
                DGVGENERAL.Columns("ESTADO_CIVIL").HeaderText = "ESTADO CIVIL"
                DGVGENERAL.Columns("OCUPACION").HeaderText = "OCUPACION"
                DGVGENERAL.Columns("MUERTO").HeaderText = "DEFUNCION"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
                CBDIAGNOSTICO.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub NOMBRE()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
                                & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
                                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, " _
                                & "FECHA_NACIMIENTO, DIAGNOSTICO, ESTADO_CIVIL, OCUPACION, CASE WHEN (DEFUNCION = '0101-01-01')" _
                                & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO FROM UNICO " _
                                & "WHERE NOMBRE_PACIENTE LIKE '" & "%" & TXTNOMBRES.Text & "%" _
                                & "' AND PRIMER_APELLIDO LIKE '" & "%" & TXTPRIMER.Text & "%" _
                                & "' AND SEGUNDO_APELLIDO LIKE '" & "%" & TXTSEGUNDO.Text & "%" & "'"
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
                DGVGENERAL.Columns("ESTADO_CIVIL").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("OCUPACION").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUERTO").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "ITEM"
                DGVGENERAL.Columns("NO").Visible = False
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD"
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS"
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("NOMBRE_PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("NOMBRE_MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("LUNES").HeaderText = "LU"
                DGVGENERAL.Columns("MARTES").HeaderText = "MA"
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI"
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU"
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI"
                DGVGENERAL.Columns("SABADO").HeaderText = "SA"
                DGVGENERAL.Columns("DOMINGO").HeaderText = "DO"
                DGVGENERAL.Columns("FECHA_NACIMIENTO").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO"
                DGVGENERAL.Columns("ESTADO_CIVIL").HeaderText = "ESTADO CIVIL"
                DGVGENERAL.Columns("OCUPACION").HeaderText = "OCUPACION"
                DGVGENERAL.Columns("MUERTO").HeaderText = "DEFUNCION"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
                CBDIAGNOSTICO.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub BUSCAR_PACIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBNACIONALIDAD.Items.Add("")
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        If CMBNACIONALIDAD.Text = "" Then
            TXTIDENTIDAD.Text = ""
            TXTNOMBRES.Text = ""
            TXTPRIMER.Text = ""
            TXTSEGUNDO.Text = ""
            DGVGENERAL.Columns.Clear()
            CBIDENTIDAD.Checked = False : CBIDENTIDAD.Enabled = False
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = False
            CBDIAGNOSTICO.Checked = False : CBDIAGNOSTICO.Enabled = False
        ElseIf CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.Text = ""
            TXTNOMBRES.Text = ""
            TXTPRIMER.Text = ""
            TXTSEGUNDO.Text = ""
            DGVGENERAL.Columns.Clear()
            CBIDENTIDAD.Checked = False : CBIDENTIDAD.Enabled = True
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = True
            CBDIAGNOSTICO.Checked = False : CBDIAGNOSTICO.Enabled = True
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Text = ""
            TXTNOMBRES.Text = ""
            TXTPRIMER.Text = ""
            TXTSEGUNDO.Text = ""
            DGVGENERAL.Columns.Clear()
            CBIDENTIDAD.Checked = False : CBIDENTIDAD.Enabled = True
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = True
            CBDIAGNOSTICO.Checked = False : CBDIAGNOSTICO.Enabled = True
        End If
    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            Dim TEXTO As String = TXTIDENTIDAD.Text
            If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
            End If
            If TXTIDENTIDAD.Text.Length = 4 Then
                TEXTO = TEXTO + "-" + e.KeyChar
                TXTIDENTIDAD.Text = TEXTO
                e.Handled = True
                TXTIDENTIDAD.Select(TXTIDENTIDAD.Text.Length, 0)
            End If
            If TXTIDENTIDAD.Text.Length = 9 Then
                TEXTO = TEXTO + "-" + e.KeyChar
                TXTIDENTIDAD.Text = TEXTO
                e.Handled = True
                TXTIDENTIDAD.Select(TXTIDENTIDAD.Text.Length, 0)
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            If Char.IsSeparator(e.KeyChar) Then
                e.Handled = True
                MsgBox("NO SE PERMITEN ESPACIOS", MsgBoxStyle.Critical, "ALERTA")
            End If
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.MaxLength = 15
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
        End If
        DGVGENERAL.Columns.Clear()
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        If CBIDENTIDAD.Checked = True And CBNOMBRE.Checked = False And CBDIAGNOSTICO.Checked = False Then
            IDENTIDAD()
        ElseIf CBIDENTIDAD.Checked = False And CBNOMBRE.Checked = True And CBDIAGNOSTICO.Checked = False Then
            NOMBRE()
        ElseIf CBIDENTIDAD.Checked = False And CBNOMBRE.Checked = False And CBDIAGNOSTICO.Checked = True Then
            DIAGNOSTICO()
        End If
    End Sub

    Private Sub TXTNOMBRES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOMBRES.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTNOMBRES_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBRES.TextChanged
        DGVGENERAL.Columns.Clear()
    End Sub

    Private Sub TXTPRIMER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRIMER.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTPRIMER_TextChanged(sender As Object, e As EventArgs) Handles TXTPRIMER.TextChanged
        DGVGENERAL.Columns.Clear()
    End Sub

    Private Sub TXTSEGUNDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEGUNDO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTSEGUNDO_TextChanged(sender As Object, e As EventArgs) Handles TXTSEGUNDO.TextChanged
        DGVGENERAL.Columns.Clear()
    End Sub

    Private Sub BUSCAR_PACIENTE_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        
    End Sub
    Private Sub BUSCAR_PACIENTE_Click(sender As Object, e As EventArgs) Handles Me.Click
        If TXTNOMBRES.Text <> "" Or TXTPRIMER.Text <> "" Or TXTSEGUNDO.Text <> "" Then
            BTNBUSCAR.Enabled = True
        Else
            BTNBUSCAR.Enabled = False
        End If
    End Sub

    Private Sub TXTDIAGNOSTICO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDIAGNOSTICO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTDIAGNOSTICO_TextChanged(sender As Object, e As EventArgs) Handles TXTDIAGNOSTICO.TextChanged
        DGVGENERAL.Columns.Clear()
    End Sub

    Private Sub CBIDENTIDAD_CheckedChanged(sender As Object, e As EventArgs) Handles CBIDENTIDAD.CheckedChanged
        If CBIDENTIDAD.Checked = True Then
            CBNOMBRE.Checked = False
            CBDIAGNOSTICO.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = True
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = False
            BTNBUSCAR.Enabled = True
        ElseIf CBIDENTIDAD.Checked = False Then
            CBNOMBRE.Checked = False
            CBDIAGNOSTICO.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = False
            BTNBUSCAR.Enabled = False
        End If
    End Sub

    Private Sub CBNOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles CBNOMBRE.CheckedChanged
        If CBNOMBRE.Checked = True Then
            CBIDENTIDAD.Checked = False
            CBDIAGNOSTICO.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = True
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = True
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = True
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = False
            BTNBUSCAR.Enabled = True
        ElseIf CBNOMBRE.Checked = False Then
            CBIDENTIDAD.Checked = False
            CBDIAGNOSTICO.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = False
            BTNBUSCAR.Enabled = False
        End If
    End Sub

    Private Sub CBDIAGNOSTICO_CheckedChanged(sender As Object, e As EventArgs) Handles CBDIAGNOSTICO.CheckedChanged
        If CBDIAGNOSTICO.Checked = True Then
            CBIDENTIDAD.Checked = False
            CBNOMBRE.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = True
            BTNBUSCAR.Enabled = True
        ElseIf CBDIAGNOSTICO.Checked = False Then
            CBIDENTIDAD.Checked = False
            CBNOMBRE.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = False
            BTNBUSCAR.Enabled = False
        End If
    End Sub

    Private Sub BTNBUSCAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNBUSCAR.MouseEnter
        BTNBUSCAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNBUSCAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNBUSCAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNBUSCAR.MouseLeave
        BTNBUSCAR.FlatAppearance.BorderColor = Color.Silver
        BTNBUSCAR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNSALIR_MouseEnter(sender As Object, e As EventArgs) Handles BTNSALIR.MouseEnter
        BTNSALIR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNSALIR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNSALIR_MouseLeave(sender As Object, e As EventArgs) Handles BTNSALIR.MouseLeave
        BTNSALIR.FlatAppearance.BorderColor = Color.Silver
        BTNSALIR.FlatAppearance.BorderSize = 1
    End Sub
End Class