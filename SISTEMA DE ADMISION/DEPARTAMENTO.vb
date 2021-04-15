Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class DEPARTAMENTO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub DEPARTAMENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONE.Open()
        Try
            Dim COMANDO As String = "SELECT CODIGO_DEPA, DEPARTAMENTO FROM DEPA_JEFATURA"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CODIGO_DEPA").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 335 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CODIGO_DEPA").HeaderText = "CODIGO"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                'MsgBox("NO EXISTE EL DEPARTAMENTO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                TXTCODIGO.Text = "" : TXTCODIGO.Focus()
                TXTDEPARTAMENTO.Text = ""
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub TXTCODIGO_TextChanged(sender As Object, e As EventArgs) Handles TXTCODIGO.TextChanged
            CONE.Open()
            Try
            'Dim COMANDO As String = "SELECT CODIGO_DEPA, DEPARTAMENTO FROM DEPA_JEFATURA WHERE CODIGO_DEPA LIKE '" _
            '& "%" & TXTCODIGO.Text & "%" & "'"
            Dim COMANDO As String = "SELECT CODIGO_DEPA, DEPARTAMENTO FROM DEPA_JEFATURA WHERE CODIGO_DEPA LIKE '" _
            & "%" & TXTCODIGO.Text & "%" & "' AND DEPARTAMENTO LIKE '" & "%" & TXTDEPARTAMENTO.Text & "%" & "'"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
                Dim DATO As New DataTable
                ADAPTADOR.Fill(DATO)
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CODIGO_DEPA").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 335 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CODIGO_DEPA").HeaderText = "CODIGO"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                CONE.Close()
            Catch ex As Exception
                MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
                CONE.Close()
            End Try
    End Sub

    Private Sub TXTDEPARTAMENTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDEPARTAMENTO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTDEPARTAMENTO_TextChanged(sender As Object, e As EventArgs) Handles TXTDEPARTAMENTO.TextChanged
        'If TXTCODIGO.Text <> "" And TXTDEPARTAMENTO.Text <> "" Then
        CONE.Open()
        Try
            Dim COMANDO As String = "SELECT CODIGO_DEPA, DEPARTAMENTO FROM DEPA_JEFATURA WHERE CODIGO_DEPA LIKE '" _
            & "%" & TXTCODIGO.Text & "%" & "' AND DEPARTAMENTO LIKE '" & "%" & TXTDEPARTAMENTO.Text & "%" & "'"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CODIGO_DEPA").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 335 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CODIGO_DEPA").HeaderText = "CODIGO"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                DGVGENERAL.Columns.Clear()
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
        'End If
    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        Dim A As Integer
        If DGVGENERAL.Rows.Count > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            NUEVO_USUARIO.TXTDEPA.Text = DGVGENERAL.Item(1, A).Value() 'NOMBRE DEL DEPARTAMENTO
        ElseIf DGVGENERAL.Rows.Count = 0 Then
            MsgBox("NO HAY NINGUN ITEM CARGADO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
        End If
        Me.Close()
    End Sub

    Private Sub BTNAGREGAR_Click(sender As Object, e As EventArgs) Handles BTNAGREGAR.Click
        If (TXTCODIGO.Text <> "" And TXTDEPARTAMENTO.Text <> "") And (DGVGENERAL.Rows.Count = 0) Then
            CONE.Open()
            Try
                Dim GUARDAR As String = "INSERT INTO DEPA_JEFATURA (CODIGO_DEPA, DEPARTAMENTO) VALUES ('" _
                & TXTCODIGO.Text & "','" & TXTDEPARTAMENTO.Text & "')"
                Dim COMAND As SqlCommand
                COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN TABLA
                COMAND.ExecuteNonQuery()
                MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CONE.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                CONE.Close()
            End Try
        ElseIf ((TXTCODIGO.Text = "" And TXTDEPARTAMENTO.Text = "") Or (TXTCODIGO.Text <> "" And TXTDEPARTAMENTO.Text = "") _
                Or (TXTCODIGO.Text = "" And TXTDEPARTAMENTO.Text <> "")) And (DGVGENERAL.Rows.Count > 0) Then
            MsgBox("PARA AGREGAR DEBE LLENAR LOS CAMPO DE CODIGO Y DEPARTAMENTO")
        End If
    End Sub
End Class