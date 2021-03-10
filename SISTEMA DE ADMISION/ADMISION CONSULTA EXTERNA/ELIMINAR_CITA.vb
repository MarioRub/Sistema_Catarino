Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class ELIMINAR_CITA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Sub BUSQUEDA_IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT LOGIN.USUARIO ,NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, CORRELATIVO, ESPECIALIDAD, MEDICO, CONSULTORIO, PREFERENTE, NORMAL, FECHA_FICHA, FECHA_CITADO, HORA_INCLUSION, NUEVA, SUBSIGUIENTE, REPROGRAMACION, CAMBIO_CITA FROM BITACORA INNER JOIN LOGIN ON BITACORA.IDENTIDAD_EMPLEADO=LOGIN.IDENTIDAD WHERE BITACORA.IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                TXTCORRELATIVO.Text = DATO.Rows(0)("CORRELATIVO").ToString()
                LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE").ToString() & " " & DATO.Rows(0)("PRIMER_APELLIDO").ToString() & " " & DATO.Rows(0)("SEGUNDO_APELLIDO").ToString()
                DGVGENERAL.Columns("USUARIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Visible = False
                DGVGENERAL.Columns("PRIMER_APELLIDO").Visible = False
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Visible = False
                DGVGENERAL.Columns("CORRELATIVO").Visible = False
                DGVGENERAL.Columns("ESPECIALIDAD").Width = 150
                DGVGENERAL.Columns("MEDICO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CONSULTORIO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PREFERENTE").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NORMAL").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_FICHA").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_CITADO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_INCLUSION").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NUEVA").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SUBSIGUIENTE").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("REPROGRAMACION").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CAMBIO_CITA").Width = 80 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("USUARIO").HeaderText = "NOMBRE DEL EMPLEADO"
                DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD"
                DGVGENERAL.Columns("MEDICO").HeaderText = "NOMBRE DEL MEDICO"
                DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CLINICA"
                DGVGENERAL.Columns("PREFERENTE").HeaderText = "PREF."
                DGVGENERAL.Columns("NORMAL").HeaderText = "NORM."
                DGVGENERAL.Columns("FECHA_FICHA").HeaderText = "FECHA INCLUSION"
                DGVGENERAL.Columns("FECHA_CITADO").HeaderText = "FECHA CITADO"
                DGVGENERAL.Columns("HORA_INCLUSION").HeaderText = "HORA INCLUSION"
                DGVGENERAL.Columns("NUEVA").HeaderText = "NUEVA"
                DGVGENERAL.Columns("SUBSIGUIENTE").HeaderText = "SUB."
                DGVGENERAL.Columns("REPROGRAMACION").HeaderText = "REPR."
                DGVGENERAL.Columns("CAMBIO_CITA").HeaderText = "CA_CITA"
                BTNELIMINAR.Enabled = True
            ElseIf DATO.Rows.Count = 0 Then
                BTNELIMINAR.Enabled = False
                MsgBox("EL PACIENTES NO EXISTE, FAVOR INGRESARLO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
            End If
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.RowCount
    End Sub
    Sub BUSQUEDA_CORRELATIVO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT LOGIN.USUARIO ,NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, BITACORA.IDENTIDAD, ESPECIALIDAD, MEDICO, CONSULTORIO, PREFERENTE, NORMAL, FECHA_FICHA, FECHA_CITADO, HORA_INCLUSION, NUEVA, SUBSIGUIENTE, REPROGRAMACION, CAMBIO_CITA FROM BITACORA INNER JOIN LOGIN ON BITACORA.IDENTIDAD_EMPLEADO=LOGIN.IDENTIDAD WHERE BITACORA.CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            If DATO.Rows.Count > 0 Then
                TXTIDENTIDAD.Text = DATO.Rows(0)("IDENTIDAD")
                LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE").ToString() & " " & DATO.Rows(0)("PRIMER_APELLIDO").ToString() & " " & DATO.Rows(0)("SEGUNDO_APELLIDO").ToString()
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("USUARIO").Width = 200 'DAR ANCHO A LA COLUMNA..........0
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Visible = False '1
                DGVGENERAL.Columns("PRIMER_APELLIDO").Visible = False '2
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Visible = False '3
                DGVGENERAL.Columns("IDENTIDAD").Visible = False '4
                DGVGENERAL.Columns("ESPECIALIDAD").Width = 150 '5
                DGVGENERAL.Columns("MEDICO").Width = 150 'DAR ANCGO A LA COLUMNA......6
                DGVGENERAL.Columns("CONSULTORIO").Width = 80 'DAR ANCHO A LA COLUMNA.....7
                DGVGENERAL.Columns("PREFERENTE").Width = 50 'DAR ANCHO A LA COLUMNA....8
                DGVGENERAL.Columns("NORMAL").Width = 50 'DAR ANCHO A LA COLUMNA......9
                DGVGENERAL.Columns("FECHA_FICHA").Width = 120 'DAR ANCHO A LA COLUMNA........10
                DGVGENERAL.Columns("FECHA_CITADO").Width = 120 'DAR ANCHO A LA COLUMNA..........11
                DGVGENERAL.Columns("HORA_INCLUSION").Width = 130 'DAR ANCHO A LA COLUMNA.......12
                DGVGENERAL.Columns("NUEVA").Width = 50 'DAR ANCHO A LA COLUMNA.........13
                DGVGENERAL.Columns("SUBSIGUIENTE").Width = 50 'DAR ANCHO A LA COLUMNA........14
                DGVGENERAL.Columns("REPROGRAMACION").Width = 50 'DAR ANCHO A LA COLUMNA......15
                DGVGENERAL.Columns("CAMBIO_CITA").Width = 80 'DAR ANCHO A LA COLUMNA............16
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("USUARIO").HeaderText = "NOMBRE DEL EMPLEADO" '0
                DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD" '1
                DGVGENERAL.Columns("MEDICO").HeaderText = "NOMBRE DEL MEDICO" '2
                DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CLINICA" '3
                DGVGENERAL.Columns("PREFERENTE").HeaderText = "PREF." '4
                DGVGENERAL.Columns("NORMAL").HeaderText = "NORM." '5
                DGVGENERAL.Columns("FECHA_FICHA").HeaderText = "FECHA INCLUSION" '6
                DGVGENERAL.Columns("FECHA_CITADO").HeaderText = "FECHA CITADO" '7
                DGVGENERAL.Columns("HORA_INCLUSION").HeaderText = "HORA INCLUSION" '8
                DGVGENERAL.Columns("NUEVA").HeaderText = "NUEVA" '9
                DGVGENERAL.Columns("SUBSIGUIENTE").HeaderText = "SUB." '10
                DGVGENERAL.Columns("REPROGRAMACION").HeaderText = "REPR." '11
                DGVGENERAL.Columns("CAMBIO_CITA").HeaderText = "CA_CITA" '12
                BTNELIMINAR.Enabled = True
            ElseIf DATO.Rows.Count = 0 Then
                BTNELIMINAR.Enabled = False
                MsgBox("NO EXISTE EL PACIENTE, FAVOR INGRESARLO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
            End If
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.RowCount
    End Sub
    Private Sub ELIMINAR_CITA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBNACIONALIDAD.Focus()
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
        CMBBUSQUEDA.Items.Add("")
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        CMBNACIONALIDAD.Enabled = True
        CMBBUSQUEDA.Enabled = False
        TXTIDENTIDAD.Enabled = False
        TXTCORRELATIVO.Enabled = False
        BTNCORRELATIVO.Visible = False
        BTNIDENTIDAD.Visible = False
        BTNELIMINAR.Enabled = False
        TXTIDENTIDAD.Text = ""
        TXTCORRELATIVO.Text = ""
        CMBBUSQUEDA.Text = ""
    End Sub

    Private Sub BTNIDENTIDAD_Click(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.Click
        BUSQUEDA_IDENTIDAD()
    End Sub

    Private Sub BTNCORRELATIVO_Click(sender As Object, e As EventArgs) Handles BTNCORRELATIVO.Click
        BUSQUEDA_CORRELATIVO()
    End Sub

    Private Sub TXTCORRELATIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCORRELATIVO.KeyPress
        Dim TEXTO As String = TXTCORRELATIVO.Text
        If Char.IsNumber(e.KeyChar) Then 'COMPARA SI ES NUMERO
            e.Handled = False 'PERMITE ESCRITURA
        ElseIf Char.IsControl(e.KeyChar) Then 'COMPARA SI TECLA ES BORAR
            e.Handled = False 'PERMITE ESCRITURA
        Else
            e.Handled = True 'NO PERMITE ESCRITURA
        End If

        If TXTCORRELATIVO.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTCORRELATIVO.Text = TEXTO
            e.Handled = True
            TXTCORRELATIVO.Select(TXTCORRELATIVO.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        If CMBBUSQUEDA.Text = "CORRELATIVO" Then
            If TXTCORRELATIVO.Text.Length > 8 Then
                BTNIDENTIDAD.Visible = False
                BTNCORRELATIVO.Visible = True
                'DGVGENERAL.Rows.Clear()
                DGVGENERAL.Columns.Clear()
                TXTTOTAL.Text = ""
                LBPACIENTE.Text = ""
            End If
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
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNIDENTIDAD.Focus()
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
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        BTNCORRELATIVO.Visible = False
        If CMBNACIONALIDAD.Text = "HONDUREÑO" And CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTIDENTIDAD.MaxLength = 15
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNIDENTIDAD.Visible = True
            ElseIf TXTIDENTIDAD.Text.Length < 15 Then
                BTNIDENTIDAD.Visible = False
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
        End If
        'DGVGENERAL.Rows.Clear()
        DGVGENERAL.Columns.Clear()
        TXTTOTAL.Text = ""
        LBPACIENTE.Text = ""
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        If CMBNACIONALIDAD.Text <> "" Then
            CMBBUSQUEDA.Enabled = True
        Else
            CMBBUSQUEDA.Enabled = False
        End If
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged
        If CMBBUSQUEDA.Text = "" Then
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            TXTCORRELATIVO.Text = "" : TXTCORRELATIVO.Enabled = False
            BTNIDENTIDAD.Visible = False
            BTNCORRELATIVO.Visible = False
            DGVGENERAL.Columns.Clear()
            TXTTOTAL.Text = ""
        ELSEIf CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTIDENTIDAD.Enabled = True
            TXTCORRELATIVO.Enabled = False
            BTNIDENTIDAD.Visible = False
            BTNCORRELATIVO.Visible = False
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = "0000-0000"
            'DGVGENERAL.Rows.Clear()
            DGVGENERAL.Columns.Clear()
            TXTTOTAL.Text = ""
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTIDENTIDAD.Enabled = False
            TXTCORRELATIVO.Enabled = True
            BTNIDENTIDAD.Visible = False
            BTNCORRELATIVO.Visible = False
            TXTIDENTIDAD.Text = "0000-0000-00000"
            TXTCORRELATIVO.Text = ""
            ' DGVGENERAL.Rows.Clear()
            DGVGENERAL.Columns.Clear()
            TXTTOTAL.Text = ""
        End If
    End Sub

    Private Sub DGVGENERAL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGENERAL.CellContentClick
        
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim A As Integer
        If DGVGENERAL.ColumnCount > 0 Then
            A = DGVGENERAL.CurrentRow.Index
        End If
        CONE.Open()
        Try
            Dim CITA As String = Format(DGVGENERAL.Item(11, A).Value(), "yyyy/MM/dd")
            Dim BITACORA As String = "DELETE FROM BITACORA WHERE CORRELATIVO='" & TXTCORRELATIVO.Text & "' AND IDENTIDAD='" & TXTIDENTIDAD.Text & "' AND ESPECIALIDAD='" _
            & DGVGENERAL.Item(5, A).Value() & "' AND MEDICO='" & DGVGENERAL.Item(6, A).Value() & "' AND FECHA_CITADO='" _
            & CITA & "'"
            Dim BITA As SqlCommand
            BITA = New SqlCommand(BITACORA, CONE)
            BITA.ExecuteNonQuery()
            MsgBox("LA CITA DEL PACIENTE HA SIDO ELIMINADA CON EXITO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            DGVGENERAL.Columns.Clear()
            CONE.Close()
            '------------------------------------
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub BTNELIMINAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNELIMINAR.MouseEnter
        BTNELIMINAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNELIMINAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNELIMINAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNELIMINAR.MouseLeave
        BTNELIMINAR.FlatAppearance.BorderColor = Color.Silver
        BTNELIMINAR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
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