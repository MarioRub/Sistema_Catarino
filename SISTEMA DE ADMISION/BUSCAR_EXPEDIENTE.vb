Imports System.Data.SqlClient

Public Class BUSCAR_EXPEDIENTE

    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"

    Private Sub BUSCAR_EXPEDIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        CMBBUSQUEDA.Enabled = False
        TXTEXPEDIENTE.Enabled = False
        TXTNOMBREPACIENTE.Enabled = False
        CBIDENTIDAD.Enabled = True
        CBNOMBRE.Enabled = True
    End Sub

    Private Sub TXTEXPEDIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTEXPEDIENTE.KeyPress
        Dim IDENTIDAD As String = TXTEXPEDIENTE.Text
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTEXPEDIENTE.MaxLength = 15
            If TXTEXPEDIENTE.Text.Length = 4 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTEXPEDIENTE.Text = IDENTIDAD
                e.Handled = True
                TXTEXPEDIENTE.Select(TXTEXPEDIENTE.Text.Length, 0)
            End If
            If TXTEXPEDIENTE.Text.Length = 9 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTEXPEDIENTE.Text = IDENTIDAD
                e.Handled = True
                TXTEXPEDIENTE.Select(TXTEXPEDIENTE.Text.Length, 0)
            End If
            If TXTEXPEDIENTE.Text.Length = 15 Then
                BTNBUSCAR.Enabled = True
                BTNBUSCAR.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then
                e.Handled = False
            End If
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTEXPEDIENTE.MaxLength = 9
            If TXTEXPEDIENTE.Text.Length = 4 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTEXPEDIENTE.Text = IDENTIDAD
                e.Handled = True
                TXTEXPEDIENTE.Select(TXTEXPEDIENTE.Text.Length, 0)
            End If
            If TXTEXPEDIENTE.Text.Length = 9 Then
                BTNBUSCAR.Enabled = True
                BTNBUSCAR.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then
                e.Handled = False
            End If
        End If
    End Sub
    Private Sub CBIDENTIDAD_CheckedChanged(sender As Object, e As EventArgs) Handles CBIDENTIDAD.CheckedChanged
        If CBIDENTIDAD.Checked = True Then
            BTNBUSCAR.Enabled = True
            CBNOMBRE.Checked = False
            TXTEXPEDIENTE.Text = ""
            TXTNOMBREPACIENTE.Text = ""
            TXTNOMBREPACIENTE.Enabled = False
            CMBBUSQUEDA.Enabled = True

        End If
    End Sub

    Private Sub CBNOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles CBNOMBRE.CheckedChanged
        If CBNOMBRE.Checked = True Then
            BTNBUSCAR.Enabled = True
            CBIDENTIDAD.Checked = False
            TXTEXPEDIENTE.Text = ""
            TXTNOMBREPACIENTE.Text = ""
            TXTEXPEDIENTE.Enabled = False
            CMBBUSQUEDA.Enabled = False
            TXTNOMBREPACIENTE.Enabled = True

        End If
    End Sub

    Sub IDENTIDAD()
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT ESTADO, TIPO, IDENTIDAD, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, " _
                                & "NOMBRE_EMPLEADO, USUARIO, FECHA_SALIDA, HORA_SALIDA, FECHA_ENTREGA, HORA_ENTREGA FROM SOLICITUD_EXPEDIENTE WHERE IDENTIDAD='" _
                                & TXTEXPEDIENTE.Text & "'"
            Dim DATO As DataTable
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
            DATO = New DataTable
            ADAPTADOR.Fill(DATO)
            Try
                DGVGENERAL.DataSource = DATO
                If DATO.Rows.Count > 0 Then
                    DGVGENERAL.Columns("ESTADO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("TIPO").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("IDENTIDAD").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 180 'DAR ANCGO A LA COLUMNA
                    DGVGENERAL.Columns("MEDICO").Width = 180 'DAR ANCGO A LA COLUMNA
                    DGVGENERAL.Columns("ESPECIALIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("CONSULTORIO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").Width = 150 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("USUARIO").Width = 180 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("FECHA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("HORA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("FECHA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("HORA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                    'OTORGAR EL TITULO

                    DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                    DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                    DGVGENERAL.Columns("TIPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                    DGVGENERAL.Columns("IDENTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO"
                    DGVGENERAL.Columns("MEDICO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                    DGVGENERAL.Columns("ESPECIALIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO"
                    DGVGENERAL.Columns("CONSULTORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").HeaderText = "NOMBRE EMPLEADO"
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("USUARIO").HeaderText = "USUARIO"
                    DGVGENERAL.Columns("USUARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("FECHA_SALIDA").HeaderText = "FECHA SALIDA"
                    DGVGENERAL.Columns("FECHA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("HORA_SALIDA").HeaderText = "HORA SALIDA"
                    DGVGENERAL.Columns("HORA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("FECHA_ENTREGA").HeaderText = "FECHA ENTREGA"
                    DGVGENERAL.Columns("FECHA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("HORA_ENTREGA").HeaderText = "HORA ENTREGA"
                    DGVGENERAL.Columns("HORA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Dim DGV As New DataGridViewCellStyle()
                    DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                ElseIf DATO.Rows.Count = 0 Then
                    MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    TXTEXPEDIENTE.Text = ""
                    CBIDENTIDAD.Checked = False
                    CBNOMBRE.Checked = False
                End If
            Catch ex As Exception
                MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
            End Try
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT ESTADO, TIPO, CORRELATIVO, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, " _
                                & "NOMBRE_EMPLEADO, USUARIO, FECHA_SALIDA, HORA_SALIDA, FECHA_ENTREGA, HORA_ENTREGA FROM SOLICITUD_EXPEDIENTE WHERE CORRELATIVO='" _
                                & TXTEXPEDIENTE.Text & "'"
            Dim DATO As DataTable
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
            DATO = New DataTable
            ADAPTADOR.Fill(DATO)
            Try
                DGVGENERAL.DataSource = DATO
                If DATO.Rows.Count > 0 Then
                    DGVGENERAL.Columns("ESTADO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("TIPO").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("CORRELATIVO").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 180 'DAR ANCGO A LA COLUMNA
                    DGVGENERAL.Columns("MEDICO").Width = 180 'DAR ANCGO A LA COLUMNA
                    DGVGENERAL.Columns("ESPECIALIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("CONSULTORIO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").Width = 150 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("USUARIO").Width = 180 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("FECHA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("HORA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("FECHA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("HORA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                    'OTORGAR EL TITULO

                    DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                    DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                    DGVGENERAL.Columns("TIPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                    DGVGENERAL.Columns("CORRELATIVO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO"
                    DGVGENERAL.Columns("MEDICO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                    DGVGENERAL.Columns("ESPECIALIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO"
                    DGVGENERAL.Columns("CONSULTORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").HeaderText = "NOMBRE EMPLEADO"
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("USUARIO").HeaderText = "USUARIO"
                    DGVGENERAL.Columns("USUARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("FECHA_SALIDA").HeaderText = "FECHA SALIDA"
                    DGVGENERAL.Columns("FECHA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("HORA_SALIDA").HeaderText = "HORA SALIDA"
                    DGVGENERAL.Columns("HORA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("FECHA_ENTREGA").HeaderText = "FECHA ENTREGA"
                    DGVGENERAL.Columns("FECHA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("HORA_ENTREGA").HeaderText = "HORA ENTREGA"
                    DGVGENERAL.Columns("HORA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Dim DGV As New DataGridViewCellStyle()
                    DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                ElseIf DATO.Rows.Count = 0 Then
                    MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    TXTEXPEDIENTE.Text = ""
                    CBIDENTIDAD.Checked = False
                    CBNOMBRE.Checked = False
                End If
            Catch ex As Exception
                MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
            End Try
        End If
    End Sub

    Sub IDENTIDAD_UNICO()
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT TOP 1 ESTADO, TIPO, IDENTIDAD, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, " _
                                & "NOMBRE_EMPLEADO, USUARIO, FECHA_SALIDA, HORA_SALIDA, FECHA_ENTREGA, HORA_ENTREGA FROM SOLICITUD_EXPEDIENTE WHERE IDENTIDAD='" _
                                & TXTEXPEDIENTE.Text & "'" & " ORDER BY NO DESC"
            Dim DATO As DataTable
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
            DATO = New DataTable
            ADAPTADOR.Fill(DATO)
            Try
                DGVGENERAL.DataSource = DATO
                If DATO.Rows.Count > 0 Then
                    DGVGENERAL.Columns("ESTADO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("TIPO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("IDENTIDAD").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 180 'DAR ANCGO A LA COLUMNA
                    DGVGENERAL.Columns("MEDICO").Width = 180 'DAR ANCGO A LA COLUMNA
                    DGVGENERAL.Columns("ESPECIALIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("CONSULTORIO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").Width = 150 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("USUARIO").Width = 180 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("FECHA_SALIDA").Width = 150 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("HORA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("FECHA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("HORA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                    'OTORGAR EL TITULO

                    DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                    DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                    DGVGENERAL.Columns("TIPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                    DGVGENERAL.Columns("IDENTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO"
                    DGVGENERAL.Columns("MEDICO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                    DGVGENERAL.Columns("ESPECIALIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO"
                    DGVGENERAL.Columns("CONSULTORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").HeaderText = "NOMBRE EMPLEADO"
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("USUARIO").HeaderText = "USUARIO"
                    DGVGENERAL.Columns("USUARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("FECHA_SALIDA").HeaderText = "FECHA SALIDA"
                    DGVGENERAL.Columns("FECHA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("HORA_SALIDA").HeaderText = "HORA SALIDA"
                    DGVGENERAL.Columns("HORA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("FECHA_ENTREGA").HeaderText = "FECHA ENTREGA"
                    DGVGENERAL.Columns("FECHA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("HORA_ENTREGA").HeaderText = "HORA ENTREGA"
                    DGVGENERAL.Columns("HORA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Dim DGV As New DataGridViewCellStyle()
                    DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                ElseIf DATO.Rows.Count = 0 Then
                    MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    TXTEXPEDIENTE.Text = ""
                    CBIDENTIDAD.Checked = False
                    CBNOMBRE.Checked = False
                End If
            Catch ex As Exception
                MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
            End Try
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT TOP 1 ESTADO, TIPO, CORRELATIVO, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, " _
                                & "NOMBRE_EMPLEADO, USUARIO, FECHA_SALIDA, HORA_SALIDA, FECHA_ENTREGA, HORA_ENTREGA FROM SOLICITUD_EXPEDIENTE WHERE CORRELATIVO='" _
                                & TXTEXPEDIENTE.Text & "'" & " ORDER BY NO DESC"
            Dim DATO As DataTable
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
            DATO = New DataTable
            ADAPTADOR.Fill(DATO)
            Try
                DGVGENERAL.DataSource = DATO
                If DATO.Rows.Count > 0 Then
                    DGVGENERAL.Columns("ESTADO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("TIPO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("CORRELATIVO").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 180 'DAR ANCGO A LA COLUMNA
                    DGVGENERAL.Columns("MEDICO").Width = 180 'DAR ANCGO A LA COLUMNA
                    DGVGENERAL.Columns("ESPECIALIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("CONSULTORIO").Width = 110 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").Width = 150 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("USUARIO").Width = 180 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("FECHA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("HORA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("FECHA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                    DGVGENERAL.Columns("HORA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                    'OTORGAR EL TITULO

                    DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                    DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                    DGVGENERAL.Columns("TIPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                    DGVGENERAL.Columns("CORRELATIVO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                    DGVGENERAL.Columns("NOMBRE_PACIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO"
                    DGVGENERAL.Columns("MEDICO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                    DGVGENERAL.Columns("ESPECIALIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO"
                    DGVGENERAL.Columns("CONSULTORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").HeaderText = "NOMBRE EMPLEADO"
                    DGVGENERAL.Columns("NOMBRE_EMPLEADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("USUARIO").HeaderText = "USUARIO"
                    DGVGENERAL.Columns("USUARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("FECHA_SALIDA").HeaderText = "FECHA SALIDA"
                    DGVGENERAL.Columns("FECHA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("HORA_SALIDA").HeaderText = "HORA SALIDA"
                    DGVGENERAL.Columns("HORA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("FECHA_ENTREGA").HeaderText = "FECHA ENTREGA"
                    DGVGENERAL.Columns("FECHA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.Columns("HORA_ENTREGA").HeaderText = "HORA ENTREGA"
                    DGVGENERAL.Columns("HORA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Dim DGV As New DataGridViewCellStyle()
                    DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                    DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                ElseIf DATO.Rows.Count = 0 Then
                    MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    TXTEXPEDIENTE.Text = ""
                    CBIDENTIDAD.Checked = False
                    CBNOMBRE.Checked = False
                End If
            Catch ex As Exception
                MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
            End Try
        End If
    End Sub

    Sub NOMBRE()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT ESTADO, TIPO, IDENTIDAD, CORRELATIVO, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, " _
                                & "NOMBRE_EMPLEADO, USUARIO, FECHA_SALIDA, HORA_SALIDA, FECHA_ENTREGA, HORA_ENTREGA FROM SOLICITUD_EXPEDIENTE WHERE NOMBRE_PACIENTE LIKE '" _
                                & "%" & TXTNOMBREPACIENTE.Text & "%" & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("ESTADO").Width = 110 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 110 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 180 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("MEDICO").Width = 180 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("ESPECIALIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CONSULTORIO").Width = 110 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_EMPLEADO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("USUARIO").Width = 180 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO

                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("TIPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("IDENTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("CORRELATIVO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO"
                DGVGENERAL.Columns("MEDICO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                DGVGENERAL.Columns("ESPECIALIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO"
                DGVGENERAL.Columns("CONSULTORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("NOMBRE_EMPLEADO").HeaderText = "NOMBRE EMPLEADO"
                DGVGENERAL.Columns("NOMBRE_EMPLEADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("USUARIO").HeaderText = "USUARIO"
                DGVGENERAL.Columns("USUARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("FECHA_SALIDA").HeaderText = "FECHA SALIDA"
                DGVGENERAL.Columns("FECHA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("HORA_SALIDA").HeaderText = "HORA SALIDA"
                DGVGENERAL.Columns("HORA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("FECHA_ENTREGA").HeaderText = "FECHA ENTREGA"
                DGVGENERAL.Columns("FECHA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("HORA_ENTREGA").HeaderText = "HORA ENTREGA"
                DGVGENERAL.Columns("HORA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                TXTNOMBREPACIENTE.Text = ""
                TXTEXPEDIENTE.Text = ""
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
    End Sub

    Sub NOMBRE_UNICO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT TOP 1 ESTADO, TIPO, IDENTIDAD, CORRELATIVO, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, " _
                                & "NOMBRE_EMPLEADO, USUARIO, FECHA_SALIDA, HORA_SALIDA, FECHA_ENTREGA, HORA_ENTREGA FROM SOLICITUD_EXPEDIENTE WHERE NOMBRE_PACIENTE LIKE '" _
                                & "%" & TXTNOMBREPACIENTE.Text & "%" & "'" & " ORDER BY NO DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("ESTADO").Width = 110 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 110 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 180 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("MEDICO").Width = 180 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("ESPECIALIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CONSULTORIO").Width = 110 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_EMPLEADO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("USUARIO").Width = 180 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_SALIDA").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO

                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("TIPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("IDENTIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("CORRELATIVO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO"
                DGVGENERAL.Columns("MEDICO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                DGVGENERAL.Columns("ESPECIALIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO"
                DGVGENERAL.Columns("CONSULTORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("NOMBRE_EMPLEADO").HeaderText = "NOMBRE EMPLEADO"
                DGVGENERAL.Columns("NOMBRE_EMPLEADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("USUARIO").HeaderText = "USUARIO"
                DGVGENERAL.Columns("USUARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("FECHA_SALIDA").HeaderText = "FECHA SALIDA"
                DGVGENERAL.Columns("FECHA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("HORA_SALIDA").HeaderText = "HORA SALIDA"
                DGVGENERAL.Columns("HORA_SALIDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("FECHA_ENTREGA").HeaderText = "FECHA ENTREGA"
                DGVGENERAL.Columns("FECHA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("HORA_ENTREGA").HeaderText = "HORA ENTREGA"
                DGVGENERAL.Columns("HORA_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                TXTNOMBREPACIENTE.Text = ""
                TXTEXPEDIENTE.Text = ""
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged

        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTEXPEDIENTE.Text = ""
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 15
        End If
        If CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTEXPEDIENTE.Text = ""
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 9
        End If
    End Sub

    Private Sub TXTNOMBREPACIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOMBREPACIENTE.KeyPress
        If TXTNOMBREPACIENTE.Text.Length < 1 Then
            BTNBUSCAR.Enabled = False
        ElseIf TXTNOMBREPACIENTE.Text.Length > 1 Then
            BTNBUSCAR.Enabled = True
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        If CHKHISTORIAL.Checked = True Then
            If CBIDENTIDAD.Checked = True And CBNOMBRE.Checked = False Then
                IDENTIDAD()
            ElseIf CBIDENTIDAD.Checked = False And CBNOMBRE.Checked = True Then
                NOMBRE()

            End If
        Else
            If CBIDENTIDAD.Checked = True And CBNOMBRE.Checked = False Then
                IDENTIDAD_UNICO()
            ElseIf CBIDENTIDAD.Checked = False And CBNOMBRE.Checked = True Then
                NOMBRE_UNICO()

            End If
        End If
    End Sub

End Class