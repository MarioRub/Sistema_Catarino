Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSCAR_MEDICO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BUSCAR_MEDICO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOESPECIALIDAD()
        CMBNACIONALIDAD.Focus()
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
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

    Private Sub TXTPRIMER_TextChanged(sender As Object, e As EventArgs)
        DGVGENERAL.Columns.Clear()
    End Sub

    Private Sub TXTSEGUNDO_TextChanged(sender As Object, e As EventArgs)
        DGVGENERAL.Columns.Clear()
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBNACIONALIDAD.Text = "" Then
            TXTIDENTIDAD.Text = ""
            TXTNOMBRES.Text = ""
            DGVGENERAL.Columns.Clear()
            CBIDENTIDAD.Checked = False : CBIDENTIDAD.Enabled = False
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = False
            CBESPECIALIDAD.Checked = False : CBESPECIALIDAD.Enabled = False
        ElseIf CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.Text = ""
            TXTNOMBRES.Text = ""
            DGVGENERAL.Columns.Clear()
            CBIDENTIDAD.Checked = False : CBIDENTIDAD.Enabled = True
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = True
            CBESPECIALIDAD.Checked = False : CBESPECIALIDAD.Enabled = True
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Text = ""
            TXTNOMBRES.Text = ""
            DGVGENERAL.Columns.Clear()
            CBIDENTIDAD.Checked = False : CBIDENTIDAD.Enabled = True
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = True
            CBESPECIALIDAD.Checked = False : CBESPECIALIDAD.Enabled = True
        End If
    End Sub
    Sub COMBOESPECIALIDAD()
        '----------CARGAR COMBOBOX ESPECIALIDAD------------
        Dim DS As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES ORDER BY ESPECIALIDAD ASC"
        Dim DA As New SqlDataAdapter(DS, CONEXION)
        Dim CMB As New DataSet
        DA.Fill(CMB)
        'AGREGAR UNA LINEA EN BLANCO
        Dim FILA As DataRow
        FILA = CMB.Tables(0).NewRow()
        FILA(0) = ""
        CMB.Tables(0).Rows.InsertAt(FILA, 0)
        TXTCOD_ESPECIALIDAD.Text = ""
        '-----------------------------------------------------
        CMBESPECIALIDAD.DataSource = CMB.Tables(0)
        CMBESPECIALIDAD.SelectedIndex = 0
        CMBESPECIALIDAD.DisplayMember = "ESPECIALIDAD"
        TXTCOD_ESPECIALIDAD.Text = CMB.Tables(0).Rows(0)("CODIGO_ESPECIALIDAD")
        '--------------------------------------------------------
    End Sub
    Private Sub CBESPECIALIDAD_CheckedChanged(sender As Object, e As EventArgs) Handles CBESPECIALIDAD.CheckedChanged
        If CBESPECIALIDAD.Checked = True Then
            CBIDENTIDAD.Checked = False
            CBNOMBRE.Checked = False
            'TXTCOD_ESPECIALIDAD.Text = ""
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            CMBESPECIALIDAD.Enabled = True
            BTNBUSCAR.Enabled = True
            DGVGENERAL.Columns.Clear()
        ElseIf CBESPECIALIDAD.Checked = False Then
            CBIDENTIDAD.Checked = False
            CBNOMBRE.Checked = False
            TXTCOD_ESPECIALIDAD.Text = ""
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            CMBESPECIALIDAD.Text = "" : CMBESPECIALIDAD.Enabled = False
            BTNBUSCAR.Enabled = False
            DGVGENERAL.Columns.Clear()
        End If
    End Sub

    Private Sub CBIDENTIDAD_CheckedChanged(sender As Object, e As EventArgs) Handles CBIDENTIDAD.CheckedChanged
        If CBIDENTIDAD.Checked = True Then
            CBNOMBRE.Checked = False
            CBESPECIALIDAD.Checked = False
            TXTCOD_ESPECIALIDAD.Text = ""
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = True
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            'TXTCOD_ESPECIALIDAD.Text = Nothing
            CMBESPECIALIDAD.Text = Nothing : CMBESPECIALIDAD.Enabled = False
            BTNBUSCAR.Enabled = True
            DGVGENERAL.Columns.Clear()
        ElseIf CBIDENTIDAD.Checked = False Then
            CBNOMBRE.Checked = False
            CBESPECIALIDAD.Checked = False
            TXTCOD_ESPECIALIDAD.Text = ""
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            'TXTCOD_ESPECIALIDAD.Text = Nothing
            CMBESPECIALIDAD.Text = Nothing : CMBESPECIALIDAD.Enabled = False
            BTNBUSCAR.Enabled = False
            DGVGENERAL.Columns.Clear()
        End If
    End Sub

    Private Sub CBNOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles CBNOMBRE.CheckedChanged
        If CBNOMBRE.Checked = True Then
            CBIDENTIDAD.Checked = False
            CBESPECIALIDAD.Checked = False
            TXTCOD_ESPECIALIDAD.Text = ""
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = True
            'TXTCOD_ESPECIALIDAD.Text = Nothing
            CMBESPECIALIDAD.Text = Nothing : CMBESPECIALIDAD.Enabled = False
            BTNBUSCAR.Enabled = True
            DGVGENERAL.Columns.Clear()
        ElseIf CBNOMBRE.Checked = False Then
            CBIDENTIDAD.Checked = False
            CBESPECIALIDAD.Checked = False
            TXTCOD_ESPECIALIDAD.Text = ""
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            'TXTCOD_ESPECIALIDAD.Text = Nothing
            CMBESPECIALIDAD.Text = Nothing : CMBESPECIALIDAD.Enabled = False
            BTNBUSCAR.Enabled = False
            DGVGENERAL.Columns.Clear()
        End If
    End Sub
    Sub ESPECIALIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, " _
        & "HORARIO, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE CODIGO_ESPECIALIDAD ='" _
        & TXTCOD_ESPECIALIDAD.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("CODIGO_ESPECIALIDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150
                DGVGENERAL.Columns("NOMBRE").Width = 300 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("ESPECIALIDAD").Width = 200 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CONSULTORIO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TARJETA").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORARIO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("LUNES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MARTES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MIERCOLES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("JUEVES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("VIERNES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COMENTARIO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CUPO").Width = 50 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("CODIGO_ESPECIALIDAD").HeaderText = "CODIGO"
                DGVGENERAL.Columns("CODIGO_ESPECIALIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("NOMBRE").HeaderText = "NOMBRE DEL MEDICO"
                DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO"
                DGVGENERAL.Columns("CONSULTORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("TARJETA").HeaderText = "TARJETA DE CITA"
                DGVGENERAL.Columns("TARJETA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("HORARIO").HeaderText = "HORARIO DE ATENCION"
                DGVGENERAL.Columns("HORARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("LUNES").HeaderText = "LU"
                DGVGENERAL.Columns("LUNES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("MARTES").HeaderText = "MA"
                DGVGENERAL.Columns("MARTES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI"
                DGVGENERAL.Columns("MIERCOLES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU"
                DGVGENERAL.Columns("JUEVES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI"
                DGVGENERAL.Columns("VIERNES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("COMENTARIO").HeaderText = "COMENTARIO"
                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("CUPO").HeaderText = "CUPO"
                DGVGENERAL.Columns("CUPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
                CBESPECIALIDAD.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub NOMBRE()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, HORARIO, LUNES, MARTES, " _
        & " MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE NOMBRE LIKE '" _
        & "%" & TXTNOMBRES.Text & "%" & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("CODIGO_ESPECIALIDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150
                DGVGENERAL.Columns("NOMBRE").Width = 300 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("ESPECIALIDAD").Width = 200 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CONSULTORIO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TARJETA").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORARIO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("LUNES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MARTES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MIERCOLES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("JUEVES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("VIERNES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COMENTARIO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CUPO").Width = 50 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("CODIGO_ESPECIALIDAD").HeaderText = "CODIGO"
                DGVGENERAL.Columns("CODIGO_ESPECIALIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("NOMBRE").HeaderText = "NOMBRE DEL MEDICO"
                DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO"
                DGVGENERAL.Columns("CONSULTORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("TARJETA").HeaderText = "TARJETA DE CITA"
                DGVGENERAL.Columns("TARJETA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("HORARIO").HeaderText = "HORARIO DE ATENCION"
                DGVGENERAL.Columns("HORARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("LUNES").HeaderText = "LU"
                DGVGENERAL.Columns("LUNES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("MARTES").HeaderText = "MA"
                DGVGENERAL.Columns("MARTES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI"
                DGVGENERAL.Columns("MIERCOLES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU"
                DGVGENERAL.Columns("JUEVES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI"
                DGVGENERAL.Columns("VIERNES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("COMENTARIO").HeaderText = "COMENTARIO"
                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("CUPO").HeaderText = "CUPO"
                DGVGENERAL.Columns("CUPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
                CBESPECIALIDAD.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, HORARIO, LUNES, " _
                                & "MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE IDENTIDAD='" _
                                & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("CODIGO_ESPECIALIDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150
                DGVGENERAL.Columns("NOMBRE").Width = 300 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("ESPECIALIDAD").Width = 200 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CONSULTORIO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TARJETA").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORARIO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("LUNES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MARTES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MIERCOLES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("JUEVES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("VIERNES").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COMENTARIO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CUPO").Width = 50 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("CODIGO_ESPECIALIDAD").HeaderText = "CODIGO"
                DGVGENERAL.Columns("CODIGO_ESPECIALIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("NOMBRE").HeaderText = "NOMBRE DEL MEDICO"
                DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO"
                DGVGENERAL.Columns("CONSULTORIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("TARJETA").HeaderText = "TARJETA DE CITA"
                DGVGENERAL.Columns("TARJETA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("HORARIO").HeaderText = "HORARIO DE ATENCION"
                DGVGENERAL.Columns("HORARIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("LUNES").HeaderText = "LU"
                DGVGENERAL.Columns("LUNES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("MARTES").HeaderText = "MA"
                DGVGENERAL.Columns("MARTES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("MIERCOLES").HeaderText = "MI"
                DGVGENERAL.Columns("MIERCOLES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("JUEVES").HeaderText = "JU"
                DGVGENERAL.Columns("JUEVES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("VIERNES").HeaderText = "VI"
                DGVGENERAL.Columns("VIERNES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("COMENTARIO").HeaderText = "COMENTARIO"
                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("CUPO").HeaderText = "CUPO"
                DGVGENERAL.Columns("CUPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
                CBESPECIALIDAD.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        If CBIDENTIDAD.Checked = True And CBNOMBRE.Checked = False And CBESPECIALIDAD.Checked = False Then
            IDENTIDAD()
        ElseIf CBIDENTIDAD.Checked = False And CBNOMBRE.Checked = True And CBESPECIALIDAD.Checked = False Then
            NOMBRE()
        ElseIf CBIDENTIDAD.Checked = False And CBNOMBRE.Checked = False And CBESPECIALIDAD.Checked = True Then
            ESPECIALIDAD()
        End If
    End Sub

    Private Sub CMBESPECIALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBESPECIALIDAD.SelectedIndexChanged
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        TXTCOD_ESPECIALIDAD.Text = ""
        '----------CARGAR COMBOBOX ESPECIALIDAD------------
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES WHERE ESPECIALIDAD='" _
                           & CMBESPECIALIDAD.Text & "' ORDER BY ESPECIALIDAD ASC"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "ESPECIALIDADES")
        If CMBESPECIALIDAD.Text <> "" Then
            TXTCOD_ESPECIALIDAD.Text = CMBESPECIALIDAD.SelectedItem("CODIGO_ESPECIALIDAD").ToString
        ElseIf CMBESPECIALIDAD.Text = "" Then
            TXTCOD_ESPECIALIDAD.Text = ""
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

    Private Sub TXTCOD_ESPECIALIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTCOD_ESPECIALIDAD.TextChanged

    End Sub
End Class