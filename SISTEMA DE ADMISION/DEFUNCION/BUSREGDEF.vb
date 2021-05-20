Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSREGDEF
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Private Sub BUSREGDEF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBNACIONALIDAD.Items.Add("")
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
    End Sub
    Sub NOMBRE()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
        & "TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, PADRE, MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1," _
        & "TELEFONO2, SEXO, INGRESO, HORA_ING, RECEPCION, HORA_REC, REPORTE, CASE WHEN FISCAL<>'0101-01-01' THEN FISCAL " _
        & " End AS FISCALIA, HORA_FIS, CONTESTO, SALA_DEF, DEFUNCION," _
        & "HORA_DEF, MEDICO, DIAGNOSTICO FROM DEFUNCION WHERE NOMBRE_PACIENTE LIKE '" & "%" & TXTNOMBRES.Text & "%" & "' AND PRIMER_APELLIDO LIKE '" _
        & "%" & TXTPRIMER.Text & "%" & "' AND SEGUNDO_APELLIDO LIKE '" & "%" & TXTSEGUNDO.Text & "%" & "' ORDER BY DEFUNCION DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("PAIS").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INGRESO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RECEPCION").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_REC").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("REPORTE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FISCALIA").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_FIS").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CONTESTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_DEF").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_DEF").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MEDICO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 1000 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD"
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS"
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO"
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("INGRESO").HeaderText = "FECHA DE INGRESO"
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO"
                DGVGENERAL.Columns("RECEPCION").HeaderText = "FECHA RECEPCION"
                DGVGENERAL.Columns("HORA_REC").HeaderText = "HORA RECEPCION"
                DGVGENERAL.Columns("REPORTE").HeaderText = "QUIEN REPORTO LA DEFUNCION"
                DGVGENERAL.Columns("FISCALIA").HeaderText = "FECHA DE LLAMADA"
                DGVGENERAL.Columns("HORA_FIS").HeaderText = "HORA FISCALIA"
                DGVGENERAL.Columns("CONTESTO").HeaderText = "QUIEN CONTESTO LA LLAMADA"
                DGVGENERAL.Columns("SALA_DEF").HeaderText = "SALA DONDE FALLECIO"
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "FECHA DE DEFUNCION"
                DGVGENERAL.Columns("HORA_DEF").HeaderText = "HORA DEFUNCION"
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO DE FALLECIMIENTO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
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
        Dim COMANDO As String = "SELECT NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
        & "TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, PADRE, MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1," _
        & "TELEFONO2, SEXO, INGRESO, HORA_ING, RECEPCION, HORA_REC, REPORTE, CASE WHEN FISCAL<>'0101-01-01' THEN FISCAL " _
        & " End AS FISCALIA, HORA_FIS, CONTESTO, SALA_DEF, DEFUNCION," _
        & "HORA_DEF, MEDICO, DIAGNOSTICO FROM DEFUNCION WHERE DIAGNOSTICO LIKE '" & "%" & TXTDIAGNOSTICO.Text & "%" & "'" _
        & "ORDER BY DEFUNCION DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("PAIS").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INGRESO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RECEPCION").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_REC").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("REPORTE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FISCALIA").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_FIS").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CONTESTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_DEF").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_DEF").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MEDICO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 1000 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD"
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS"
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO"
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("INGRESO").HeaderText = "FECHA DE INGRESO"
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO"
                DGVGENERAL.Columns("RECEPCION").HeaderText = "FECHA RECEPCION"
                DGVGENERAL.Columns("HORA_REC").HeaderText = "HORA RECEPCION"
                DGVGENERAL.Columns("REPORTE").HeaderText = "QUIEN REPORTO LA DEFUNCION"
                DGVGENERAL.Columns("FISCALIA").HeaderText = "FECHA DE LLAMADA"
                DGVGENERAL.Columns("HORA_FIS").HeaderText = "HORA FISCALIA"
                DGVGENERAL.Columns("CONTESTO").HeaderText = "QUIEN CONTESTO LA LLAMADA"
                DGVGENERAL.Columns("SALA_DEF").HeaderText = "SALA DONDE FALLECIO"
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "FECHA DE DEFUNCION"
                DGVGENERAL.Columns("HORA_DEF").HeaderText = "HORA DEFUNCION"
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO DE FALLECIMIENTO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBNOMBRE.Checked = False
                CBDIAGNOSTICO.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        If CMBNACIONALIDAD.Text = "" Then
            TXTNOMBRES.Text = ""
            TXTPRIMER.Text = ""
            TXTSEGUNDO.Text = ""
            DGVGENERAL.Columns.Clear()
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = False
            CBDIAGNOSTICO.Checked = False : CBDIAGNOSTICO.Enabled = False
        ElseIf CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTNOMBRES.Text = ""
            TXTPRIMER.Text = ""
            TXTSEGUNDO.Text = ""
            DGVGENERAL.Columns.Clear()
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = True
            CBDIAGNOSTICO.Checked = False : CBDIAGNOSTICO.Enabled = True
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTNOMBRES.Text = ""
            TXTPRIMER.Text = ""
            TXTSEGUNDO.Text = ""
            DGVGENERAL.Columns.Clear()
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = True
            CBDIAGNOSTICO.Checked = False : CBDIAGNOSTICO.Enabled = True
        End If
    End Sub

    Private Sub CBNOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles CBNOMBRE.CheckedChanged
        If CBNOMBRE.Checked = True Then
            CBDIAGNOSTICO.Checked = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = True
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = True
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = True
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = False
            BTNBUSCAR.Enabled = True
        ElseIf CBNOMBRE.Checked = False Then
            CBDIAGNOSTICO.Checked = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = False
            BTNBUSCAR.Enabled = False
        End If
    End Sub

    Private Sub CBDIAGNOSTICO_CheckedChanged(sender As Object, e As EventArgs) Handles CBDIAGNOSTICO.CheckedChanged
        If CBDIAGNOSTICO.Checked = True Then
            CBNOMBRE.Checked = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = True
            BTNBUSCAR.Enabled = True
        ElseIf CBDIAGNOSTICO.Checked = False Then
            CBNOMBRE.Checked = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            TXTDIAGNOSTICO.Text = "" : TXTDIAGNOSTICO.Enabled = False
            BTNBUSCAR.Enabled = False
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

    Private Sub TXTDIAGNOSTICO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDIAGNOSTICO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTDIAGNOSTICO_TextChanged(sender As Object, e As EventArgs) Handles TXTDIAGNOSTICO.TextChanged
        DGVGENERAL.Columns.Clear()
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        If CBNOMBRE.Checked = True And CBDIAGNOSTICO.Checked = False Then
            NOMBRE()
        ElseIf CBNOMBRE.Checked = False And CBDIAGNOSTICO.Checked = True Then
            DIAGNOSTICO()
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class