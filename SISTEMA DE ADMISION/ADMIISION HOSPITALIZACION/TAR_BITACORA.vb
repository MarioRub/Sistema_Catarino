Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class TAR_BITACORA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Sub IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, " _
        & "CORRELATIVO, EDAD, TIPO_EDAD, FAMILIA1, PARENTEZCO1, FAMILIA2, PARENTEZCO2, SALA_HOS, FECHA_HOS, HORA_ING, " _
        & "INICIAL, FINAL FROM TARJETA WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "' ORDER BY FECHA_HOS DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NO").Width = 80 'DAR ANCHO A LA COLUMNA
                'DGVGENERAL.Columns("TIPO").Width = 80
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 250 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FAMILIA1").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO1").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FAMILIA2").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO2").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_HOS").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_HOS").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INICIAL").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FINAL").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "NO"
                'DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMERI APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO_APELLIDO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO EDAD"
                DGVGENERAL.Columns("FAMILIA1").HeaderText = "FAMILIAR # 1"
                DGVGENERAL.Columns("PARENTEZCO1").HeaderText = "PARENTEZCO"
                DGVGENERAL.Columns("FAMILIA2").HeaderText = "FAMILIAR # 2"
                DGVGENERAL.Columns("PARENTEZCO2").HeaderText = "PARENTEZCO"
                DGVGENERAL.Columns("SALA_HOS").HeaderText = "SALA DONDE ESTA HOSPITALIZADO"
                DGVGENERAL.Columns("FECHA_HOS").HeaderText = "FECHA HOSP."
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA ING"
                DGVGENERAL.Columns("INICIAL").HeaderText = "FECHA INICIAL"
                DGVGENERAL.Columns("FINAL").HeaderText = "FECHA FINAL"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub NOMBRE()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, " _
        & "CORRELATIVO, EDAD, TIPO_EDAD, FAMILIA1, PARENTEZCO1, FAMILIA2, PARENTEZCO2, SALA_HOS, FECHA_HOS, HORA_ING, " _
        & "INICIAL, FINAL FROM TARJETA WHERE NOMBRE_PACIENTE LIKE '" & "%" & TXTNOMBRES.Text & "%" & "' AND PRIMER_APELLIDO LIKE '" _
        & "%" & TXTPRIMER.Text & "%" & "' AND SEGUNDO_APELLIDO LIKE '" & "%" & TXTSEGUNDO.Text & "%" & "' ORDER BY FECHA_HOS DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NO").Width = 80 'DAR ANCHO A LA COLUMNA
                'DGVGENERAL.Columns("TIPO").Width = 80
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 250 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FAMILIA1").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO1").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FAMILIA2").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO2").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_HOS").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_HOS").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INICIAL").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FINAL").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "NO"
                'DGVGENERAL.Columns("TIPO").HeaderText = "TIPO"
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE"
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMERI APELLIDO"
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO_APELLIDO"
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO"
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD"
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO EDAD"
                DGVGENERAL.Columns("FAMILIA1").HeaderText = "FAMILIAR # 1"
                DGVGENERAL.Columns("PARENTEZCO1").HeaderText = "PARENTEZCO"
                DGVGENERAL.Columns("FAMILIA2").HeaderText = "FAMILIAR # 2"
                DGVGENERAL.Columns("PARENTEZCO2").HeaderText = "PARENTEZCO"
                DGVGENERAL.Columns("SALA_HOS").HeaderText = "SALA DONDE ESTA HOSPITALIZADO"
                DGVGENERAL.Columns("FECHA_HOS").HeaderText = "FECHA HOSP."
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA ING"
                DGVGENERAL.Columns("INICIAL").HeaderText = "FECHA INICIAL"
                DGVGENERAL.Columns("FINAL").HeaderText = "FECHA FINAL"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBIDENTIDAD.Checked = False
                CBNOMBRE.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub TAR_BITACORA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ElseIf CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.Text = ""
            TXTNOMBRES.Text = ""
            TXTPRIMER.Text = ""
            TXTSEGUNDO.Text = ""
            DGVGENERAL.Columns.Clear()
            CBIDENTIDAD.Checked = False : CBIDENTIDAD.Enabled = True
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = True
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Text = ""
            TXTNOMBRES.Text = ""
            TXTPRIMER.Text = ""
            TXTSEGUNDO.Text = ""
            DGVGENERAL.Columns.Clear()
            CBIDENTIDAD.Checked = False : CBIDENTIDAD.Enabled = True
            CBNOMBRE.Checked = False : CBNOMBRE.Enabled = True
        End If
    End Sub

    Private Sub CBIDENTIDAD_CheckedChanged(sender As Object, e As EventArgs) Handles CBIDENTIDAD.CheckedChanged
        If CBIDENTIDAD.Checked = True Then
            CBNOMBRE.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = True
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            BTNBUSCAR.Enabled = True
        ElseIf CBIDENTIDAD.Checked = False Then
            CBNOMBRE.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
            BTNBUSCAR.Enabled = False
        End If
    End Sub

    Private Sub CBNOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles CBNOMBRE.CheckedChanged
        If CBNOMBRE.Checked = True Then
            CBIDENTIDAD.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = True
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = True
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = True
            BTNBUSCAR.Enabled = True
        ElseIf CBNOMBRE.Checked = False Then
            CBIDENTIDAD.Checked = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
            TXTPRIMER.Text = "" : TXTPRIMER.Enabled = False
            TXTSEGUNDO.Text = "" : TXTSEGUNDO.Enabled = False
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

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        If CBIDENTIDAD.Checked = True And CBNOMBRE.Checked = False Then
            IDENTIDAD()
        ElseIf CBIDENTIDAD.Checked = False And CBNOMBRE.Checked = True Then
            NOMBRE()
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class