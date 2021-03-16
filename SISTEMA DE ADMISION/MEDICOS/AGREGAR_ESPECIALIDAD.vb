Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class AGREGAR_ESPECIALIDAD
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Private Sub AGREGAR_ESPECIALIDAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CONE.Open()
            Dim COMANDO As String = "SELECT ESPECIALIDADES.CODIGO_ESPECIALIDAD, ESPECIALIDAD, CONSULTORIO FROM ESPECIALIDADES INNER JOIN CONSULTORIOS ON ESPECIALIDADES.CODIGO_ESPECIALIDAD=CONSULTORIOS.CODIGO_ESPECIALIDAD"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVESPECIALIDAD.Rows.Clear()
                DGVESPECIALIDAD.Columns.Clear()
                DGVESPECIALIDAD.DataSource = DATO
                DGVESPECIALIDAD.Columns("CODIGO_ESPECIALIDAD").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVESPECIALIDAD.Columns("ESPECIALIDAD").Width = 300 'DAR ANCGO A LA COLUMNA
                DGVESPECIALIDAD.Columns("CONSULTORIO").Width = 200 'DAR ANCGO A LA COLUMNA
                DGVESPECIALIDAD.Columns("CODIGO_ESPECIALIDAD").HeaderText = "CODIGO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                DGVESPECIALIDAD.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                DGVESPECIALIDAD.Columns("CONSULTORIO").HeaderText = "CONSULTORIO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVESPECIALIDAD.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS EN LA TABLA DE ESPECIALIDADES, FAVOR AGREGAR PARA PODER CARGARLAS A LA TABLA", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
        BTNGUARDAR.Enabled = False
    End Sub
    Sub GUARDARCONSULTORIO()
        '---------------------------------GUARDAR EN TABLA CONSULTORIOS-------------------
        CONE.Open()
        Dim GUARDA As String = "INSERT INTO CONSULTORIOS (CODIGO_ESPECIALIDAD, CONSULTORIO) VALUES ('" & TXTCODIGO.Text & "','" & TXTCONSULTORIO.Text & "')"
        Dim COMANDO As SqlCommand
        COMANDO = New SqlCommand(GUARDA, CONE) 'INSERTAR REGISTRO EN REG_LOGIN
        COMANDO.ExecuteNonQuery()
        MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
        CONE.Close()
        '-----------------------------------------------------------
    End Sub
    Sub GUARDARESPECIALIDAD()
        '---------------------------------GUARDAR EN TABLA ESPECIALIDADES-------------------
        CONE.Open()
        Dim GUARDAR As String = "INSERT INTO ESPECIALIDADES (CODIGO_ESPECIALIDAD, ESPECIALIDAD) VALUES ('" & TXTCODIGO.Text & "','" & TXTESPECIALIDAD.Text & "')"
        Dim COMAND As SqlCommand
        COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN REG_LOGIN
        COMAND.ExecuteNonQuery()
        MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
        CONE.Close()
    End Sub

    Private Sub TXTESPECIALIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTESPECIALIDAD.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCONSULTORIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCONSULTORIO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub
    Sub VERIFICARESPECIALIDAD()
        Dim VERESPECIALIDAD As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES WHERE CODIGO_ESPECIALIDAD ='" & TXTCODIGO.Text & "' AND ESPECIALIDAD ='" & TXTESPECIALIDAD.Text & "'"
        Dim VERCONSULTORIO As String = "SELECT CODIGO_ESPECIALIDAD, CONSULTORIO FROM CONSULTORIOS WHERE CODIGO_ESPECIALIDAD ='" & TXTCODIGO.Text & "'AND CONSULTORIO ='" & TXTCONSULTORIO.Text & "'"
        Dim ESPE As DataTable
        Dim CONS As DataTable
        Dim ADAESPECIALIDAD As SqlDataAdapter
        ADAESPECIALIDAD = New SqlDataAdapter(VERESPECIALIDAD, CONE)

        Dim ADACONSULTORIO As SqlDataAdapter
        ADACONSULTORIO = New SqlDataAdapter(VERCONSULTORIO, CONE)

        ESPE = New DataTable
        CONS = New DataTable
        ADAESPECIALIDAD.Fill(ESPE)
        ADACONSULTORIO.Fill(CONS)
        Dim ESPEC As Boolean = False
        Dim CONSUL As Boolean = False
        If TXTCODIGO.Text <> "" And TXTESPECIALIDAD.Text <> "" And TXTCONSULTORIO.Text <> "" Then
            Try
                CONE.Open()
                If ESPE.Rows.Count > 0 Then
                    For Each ROW As DataRow In ESPE.Rows
                        TXTCODIGO.Text = ROW("CODIGO_ESPECIALIDAD").ToString
                        TXTESPECIALIDAD.Text = ROW("ESPECIALIDAD").ToString
                        ESPEC = True
                    Next
                End If
                If CONS.Rows.Count > 0 Then
                    For Each RO As DataRow In CONS.Rows
                        TXTCODIGO.Text = RO("CODIGO_ESPECIALIDAD").ToString
                        TXTCONSULTORIO.Text = RO("CONSULTORIO").ToString
                        CONSUL = True
                    Next
                End If
                CONE.Close()
            Catch ex As Exception
                MsgBox("NO SE PUDO VERIFICAR")
                CONE.Close()
            End Try
        End If
        If ESPEC = True And CONSUL = True Then
            MsgBox("YA EXISTE EL REGISTRO FAVOR INGRESE UNA ESPECIALIDAD NUEVA")
            TXTCONSULTORIO.Focus()
        ElseIf ESPEC = True And CONSUL = False Then
            GUARDARCONSULTORIO()
            Me.Close()
        ElseIf ESPEC = False And CONSUL = False Then
            GUARDARESPECIALIDAD()
            GUARDARCONSULTORIO()
            Me.Close()
        End If
    End Sub
    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        Dim COMANDO As String = "SELECT ESPECIALIDADES.CODIGO_ESPECIALIDAD, ESPECIALIDAD, CONSULTORIO FROM ESPECIALIDADES INNER JOIN CONSULTORIOS ON ESPECIALIDADES.CODIGO_ESPECIALIDAD=CONSULTORIOS.CODIGO_ESPECIALIDAD WHERE ESPECIALIDADES.CODIGO_ESPECIALIDAD '" & TXTCODIGO.Text & "' AND ESPECIALIDADES.ESPECIALIDAD '" & TXTESPECIALIDAD.Text & "' AND CONSULTORIOS.CODIGO_ESPECIALIDAD '" & TXTCODIGO.Text & "'AND CONSULTORIOS.CONSULTORIO '" & TXTCONSULTORIO.Text & "'"
        Dim VERESPECIALIDAD As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES WHERE CODIGO_ESPECIALIDAD ='" & TXTCODIGO.Text & "' AND ESPECIALIDAD ='" & TXTESPECIALIDAD.Text & "'"
        Dim VERCONSULTORIO As String = "SELECT CODIGO_ESPECIALIDAD, CONSULTORIO FROM CONSULTORIOS WHERE CODIGO_ESPECIALIDAD '" & TXTCODIGO.Text & "'AND CONSULTORIO '" & TXTCONSULTORIO.Text & "'"
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
        Dim ADAPESPECIALIDAD As New SqlDataAdapter(VERESPECIALIDAD, CONE)
        Dim ADACONSULTORIO As New SqlDataAdapter(VERCONSULTORIO, CONE)
        Dim DATO As New DataTable
        If TXTCODIGO.Text <> "" And TXTESPECIALIDAD.Text <> "" And TXTCONSULTORIO.Text <> "" Then
            Try
                ADAPTADOR.Fill(DATO)
            Catch ex As Exception
                If DGVESPECIALIDAD.Rows.Count > 0 Then
                    MessageBox.Show("EL REGISTRO YA EXISTE EN LAS TABLAS")
                End If
                If DGVESPECIALIDAD.Rows.Count = 0 Then
                    VERIFICARESPECIALIDAD()
                End If
            End Try
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub
    Private Sub TXTCODIGO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCODIGO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
        TXTCODIGO.MaxLength = 5
        If Char.IsSeparator(e.KeyChar) Then
            MsgBox("NO SE PERMITE ESPACIOS")
            e.Handled = True
            TXTCODIGO.Focus()
        End If
        If Char.IsSymbol(e.KeyChar) Then
            MsgBox("NO SE PERMITE SIMBOLOS ESPECIALES")
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Right) Then 'NIEGA EL APOSTROFE
            MsgBox("NO SE PERMITE APOSTROFE")
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            If TXTCODIGO.TextLength < 5 Then
                MsgBox("EL CODIGO DEBE CONTENER 5 CARACTERES")
                TXTCODIGO.Focus()
            End If
        End If
    End Sub

    Private Sub TXTCODIGO_TextChanged(sender As Object, e As EventArgs) Handles TXTCODIGO.TextChanged
        CONE.Open()
        Try
            Dim COMANDO As String = "SELECT ESPECIALIDADES.CODIGO_ESPECIALIDAD, ESPECIALIDAD, CONSULTORIO FROM ESPECIALIDADES INNER " _
            & "JOIN CONSULTORIOS ON ESPECIALIDADES.CODIGO_ESPECIALIDAD=CONSULTORIOS.CODIGO_ESPECIALIDAD WHERE " _
            & "ESPECIALIDADES.CODIGO_ESPECIALIDAD LIKE '" & "%" & TXTCODIGO.Text & "%" & "' AND CONSULTORIOS.CODIGO_ESPECIALIDAD LIKE '" _
            & "%" & TXTCODIGO.Text & "%" & "'"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVESPECIALIDAD.DataSource = DATO
                DGVESPECIALIDAD.Columns("CODIGO_ESPECIALIDAD").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVESPECIALIDAD.Columns("ESPECIALIDAD").Width = 300 'DAR ANCGO A LA COLUMNA
                DGVESPECIALIDAD.Columns("CONSULTORIO").Width = 200 'DAR ANCGO A LA COLUMNA
                DGVESPECIALIDAD.Columns("CODIGO_ESPECIALIDAD").HeaderText = "CODIGO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                DGVESPECIALIDAD.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                DGVESPECIALIDAD.Columns("CONSULTORIO").HeaderText = "CONSULTORIO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVESPECIALIDAD.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                CONE.Close()
            ElseIf DATO.Rows.Count = 0 Then
                DGVESPECIALIDAD.Columns.Clear()
                'MsgBox("NO EXITE NINGUN CODIGO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CONE.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO CONECTAR A LA TABLA POR:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub TXTESPECIALIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTESPECIALIDAD.TextChanged
        CONE.Open()
        Try
            Dim COMANDO As String = "SELECT ESPECIALIDADES.CODIGO_ESPECIALIDAD, ESPECIALIDAD, CONSULTORIO FROM ESPECIALIDADES " _
            & "INNER JOIN CONSULTORIOS ON ESPECIALIDADES.CODIGO_ESPECIALIDAD=CONSULTORIOS.CODIGO_ESPECIALIDAD WHERE " _
            & "ESPECIALIDADES.CODIGO_ESPECIALIDAD LIKE '" & "%" & TXTCODIGO.Text & "%" & "' AND ESPECIALIDADES.ESPECIALIDAD LIKE '" _
            & "%" & TXTESPECIALIDAD.Text & "%" & "' AND CONSULTORIOS.CODIGO_ESPECIALIDAD LIKE '" & "%" & TXTCODIGO.Text & "%" & "'"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVESPECIALIDAD.DataSource = DATO
                DGVESPECIALIDAD.Columns("CODIGO_ESPECIALIDAD").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVESPECIALIDAD.Columns("ESPECIALIDAD").Width = 300 'DAR ANCGO A LA COLUMNA
                DGVESPECIALIDAD.Columns("CONSULTORIO").Width = 200 'DAR ANCGO A LA COLUMNA
                DGVESPECIALIDAD.Columns("CODIGO_ESPECIALIDAD").HeaderText = "CODIGO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                DGVESPECIALIDAD.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                DGVESPECIALIDAD.Columns("CONSULTORIO").HeaderText = "CONSULTORIO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVESPECIALIDAD.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                CONE.Close()
            ElseIf DATO.Rows.Count = 0 Then
                DGVESPECIALIDAD.Columns.Clear()
                'MsgBox("NO EXISTE LA ESPECIALIDAD", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CONE.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub TXTCONSULTORIO_TextChanged(sender As Object, e As EventArgs) Handles TXTCONSULTORIO.TextChanged
        If TXTCODIGO.Text <> "" And TXTESPECIALIDAD.Text <> "" And TXTCONSULTORIO.Text <> "" Then
            BTNGUARDAR.Enabled = True
        Else
            BTNGUARDAR.Enabled = False
        End If
        CONE.Open()
        Try
            Dim COMANDO As String = "SELECT ESPECIALIDADES.CODIGO_ESPECIALIDAD, ESPECIALIDAD, CONSULTORIO FROM ESPECIALIDADES INNER JOIN CONSULTORIOS ON ESPECIALIDADES.CODIGO_ESPECIALIDAD=CONSULTORIOS.CODIGO_ESPECIALIDAD WHERE ESPECIALIDADES.CODIGO_ESPECIALIDAD LIKE '" & "%" & TXTCODIGO.Text & "%" & "' AND ESPECIALIDADES.ESPECIALIDAD LIKE '" & "%" & TXTESPECIALIDAD.Text & "%" & "' AND CONSULTORIOS.CODIGO_ESPECIALIDAD LIKE '" & "%" & TXTCODIGO.Text & "%" & "'AND CONSULTORIOS.CONSULTORIO LIKE '" & "%" & TXTCONSULTORIO.Text & "%" & "'"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            DGVESPECIALIDAD.DataSource = DATO
            DGVESPECIALIDAD.Columns("CODIGO_ESPECIALIDAD").Width = 100 'DAR ANCGO A LA COLUMNA
            DGVESPECIALIDAD.Columns("ESPECIALIDAD").Width = 300 'DAR ANCGO A LA COLUMNA
            DGVESPECIALIDAD.Columns("CONSULTORIO").Width = 200 'DAR ANCGO A LA COLUMNA
            DGVESPECIALIDAD.Columns("CODIGO_ESPECIALIDAD").HeaderText = "CODIGO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVESPECIALIDAD.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVESPECIALIDAD.Columns("CONSULTORIO").HeaderText = "CONSULTORIO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVESPECIALIDAD.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub BTNGUARDAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNGUARDAR.MouseEnter
        BTNGUARDAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNGUARDAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNGUARDAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNGUARDAR.MouseLeave
        BTNGUARDAR.FlatAppearance.BorderColor = Color.Silver
        BTNGUARDAR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNSALIR_MouseEnter(sender As Object, e As EventArgs) Handles BTNSALIR.MouseEnter
        BTNGUARDAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNGUARDAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNSALIR_MouseLeave(sender As Object, e As EventArgs) Handles BTNSALIR.MouseLeave
        BTNGUARDAR.FlatAppearance.BorderColor = Color.Silver
        BTNGUARDAR.FlatAppearance.BorderSize = 1
    End Sub
End Class