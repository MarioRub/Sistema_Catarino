Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class EMER_BITACORA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Sub IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT ('IMPRONTO') AS DOCUMENTO, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO," _
        & "SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD, FECHA_NAC, FECHA_ING, HORA_ING, TRASLADO, COLONIA, CASA, MUNICIPIO," _
        & "DEPARTAMENTO,PADRE, MADRE, SALA_REMITENTE,PRIORIDAD, RESPONSABLE, PARENTEZCO, TELEFONO1, TELEFONO2, RASGO," _
        & "MOTIVO FROM IMPRONTO WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "' UNION ALL SELECT ('HOSPITALIZACION') AS DOCUMENTO," _
        & "TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD," _
        & "FECHA_NAC, FECHA_ING, HORA_ING, ('') AS TRASLADO, COLONIA, CASA, MUNICIPIO, DEPARTAMENTO, PADRE, MADRE, " _
        & "(SALA) AS SALA_REMITENTE, ('') AS PRIORIDAD, RESPONSABLE, PARENTEZCO, TELEFONO1, TELEFONO2, ('') AS RASGO, " _
        & "('') AS MOTIVO FROM HOSPITALIZACION WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "' ORDER BY FECHA_ING DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("DOCUMENTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 250 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TRASLADO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 400 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_REMITENTE").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIORIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RESPONSABLE").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RASGO").Width = 400 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MOTIVO").Width = 450 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("DOCUMENTO").HeaderText = "DOCUMENTO"
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMERI APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO_APELLIDO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO EDAD"
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO"
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO"
                DGVGENERAL.Columns("TRASLADO").HeaderText = "QUIEN LO TRAJO"
                DGVGENERAL.Columns("COLONIA").HeaderText = "DIRECCION DONDE VIVE EL PACIENTE"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("SALA_REMITENTE").HeaderText = "SALA REMITENTE"
                DGVGENERAL.Columns("PRIORIDAD").HeaderText = "PRIORIDAD"
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "CONTACTO A QUIEN SE LE PUEDE LLAMAR"
                DGVGENERAL.Columns("PARENTEZCO").HeaderText = "PARENTEZCO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO #1"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO #2"
                DGVGENERAL.Columns("RASGO").HeaderText = "RASGO FISIOLOGICOS"
                DGVGENERAL.Columns("MOTIVO").HeaderText = "DIAGNOSTICO O MOTIVO DEL INGRESO"
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
        Dim COMANDO As String = "SELECT ('IMPRONTO') AS DOCUMENTO, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO," _
        & "SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD, FECHA_NAC, FECHA_ING, HORA_ING, TRASLADO, COLONIA, CASA, MUNICIPIO," _
        & "DEPARTAMENTO,PADRE, MADRE, SALA_REMITENTE,PRIORIDAD, RESPONSABLE, PARENTEZCO, TELEFONO1, TELEFONO2, RASGO," _
        & "MOTIVO FROM IMPRONTO WHERE NOMBRE_PACIENTE LIKE '" & "%" & TXTNOMBRES.Text & "%" & "' AND PRIMER_APELLIDO LIKE '" _
        & "%" & TXTPRIMER.Text & "%" & "' AND SEGUNDO_APELLIDO LIKE '" & "%" & TXTSEGUNDO.Text & "%" & "' UNION ALL SELECT " _
        & "('HOSPITALIZACION') AS DOCUMENTO," _
        & "TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD," _
        & "FECHA_NAC, FECHA_ING, HORA_ING, ('') AS TRASLADO, COLONIA, CASA, MUNICIPIO, DEPARTAMENTO, PADRE, MADRE, " _
        & "(SALA) AS SALA_REMITENTE, ('') AS PRIORIDAD, RESPONSABLE, PARENTEZCO, TELEFONO1, TELEFONO2, ('') AS RASGO, " _
        & "('') AS MOTIVO FROM HOSPITALIZACION WHERE NOMBRE_PACIENTE LIKE '" & "%" & TXTNOMBRES.Text & "%" & "' AND PRIMER_APELLIDO LIKE '" _
        & "%" & TXTPRIMER.Text & "%" & "' AND SEGUNDO_APELLIDO LIKE '" & "%" & TXTSEGUNDO.Text & "%" & "' ORDER BY FECHA_ING DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("DOCUMENTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 250 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TRASLADO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 400 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_REMITENTE").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIORIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RESPONSABLE").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RASGO").Width = 400 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MOTIVO").Width = 450 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("DOCUMENTO").HeaderText = "DOCUMENTO"
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMERI APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO_APELLIDO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO EDAD"
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO"
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO"
                DGVGENERAL.Columns("TRASLADO").HeaderText = "QUIEN LO TRAJO"
                DGVGENERAL.Columns("COLONIA").HeaderText = "DIRECCION DONDE VIVE EL PACIENTE"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("SALA_REMITENTE").HeaderText = "SALA REMITENTE"
                DGVGENERAL.Columns("PRIORIDAD").HeaderText = "PRIORIDAD"
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "CONTACTO A QUIEN SE LE PUEDE LLAMAR"
                DGVGENERAL.Columns("PARENTEZCO").HeaderText = "PARENTEZCO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO #1"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO #2"
                DGVGENERAL.Columns("RASGO").HeaderText = "RASGO FISIOLOGICOS"
                DGVGENERAL.Columns("MOTIVO").HeaderText = "DIAGNOSTICO O MOTIVO DEL INGRESO"
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
        Dim COMANDO As String = "SELECT ('IMPRONTO') AS DOCUMENTO, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO," _
        & "SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD, FECHA_NAC, FECHA_ING, HORA_ING, TRASLADO, COLONIA, CASA, MUNICIPIO," _
        & "DEPARTAMENTO,PADRE, MADRE, SALA_REMITENTE,PRIORIDAD, RESPONSABLE, PARENTEZCO, TELEFONO1, TELEFONO2, RASGO," _
        & "MOTIVO FROM IMPRONTO WHERE MOTIVO LIKE '" & "%" & TXTDIAGNOSTICO.Text & "%" & "' ORDER BY FECHA_ING DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("DOCUMENTO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 250 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TRASLADO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 400 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_REMITENTE").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIORIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RESPONSABLE").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RASGO").Width = 400 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MOTIVO").Width = 450 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("DOCUMENTO").HeaderText = "DOCUMENTO"
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMERI APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO_APELLIDO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO EDAD"
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC."
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO"
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO"
                DGVGENERAL.Columns("TRASLADO").HeaderText = "QUIEN LO TRAJO"
                DGVGENERAL.Columns("COLONIA").HeaderText = "DIRECCION DONDE VIVE EL PACIENTE"
                DGVGENERAL.Columns("CASA").HeaderText = "CASA"
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE"
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE"
                DGVGENERAL.Columns("SALA_REMITENTE").HeaderText = "SALA REMITENTE"
                DGVGENERAL.Columns("PRIORIDAD").HeaderText = "PRIORIDAD"
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "CONTACTO A QUIEN SE LE PUEDE LLAMAR"
                DGVGENERAL.Columns("PARENTEZCO").HeaderText = "PARENTEZCO"
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO #1"
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO #2"
                DGVGENERAL.Columns("RASGO").HeaderText = "RASGO FISIOLOGICOS"
                DGVGENERAL.Columns("MOTIVO").HeaderText = "DIAGNOSTICO O MOTIVO DEL INGRESO"
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
    Private Sub EMER_BITACORA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If CBIDENTIDAD.Checked = True And CBNOMBRE.Checked = False And CBDIAGNOSTICO.Checked = False Then
            IDENTIDAD()
        ElseIf CBIDENTIDAD.Checked = False And CBNOMBRE.Checked = True And CBDIAGNOSTICO.Checked = False Then
            NOMBRE()
        ElseIf CBIDENTIDAD.Checked = False And CBNOMBRE.Checked = False And CBDIAGNOSTICO.Checked = True Then
            DIAGNOSTICO()
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class