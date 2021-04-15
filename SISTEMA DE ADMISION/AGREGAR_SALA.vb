Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class AGREGAR_SALA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub TXTCODIGO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCODIGO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCODIGO_TextChanged(sender As Object, e As EventArgs) Handles TXTCODIGO.TextChanged
        CONE.Open()
        Try
            'Dim COMANDO As String = "SELECT CODIGO, SALA FROM SALAS WHERE CODIGO LIKE '" & "%" & TXTCODIGO.Text & "%" & "'"
            Dim COMANDO As String = "SELECT CODIGO, SALA FROM SALAS WHERE CODIGO LIKE '" & "%" & TXTCODIGO.Text & "%" _
                                    & "' AND SALA LIKE '" & "%" & TXTSALA.Text & "%" & "'"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CODIGO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 335 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CODIGO").HeaderText = "CODIGO"
                DGVGENERAL.Columns("SALA").HeaderText = "SALA"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                DGVGENERAL.Columns.Clear()
                'MsgBox("NO EXISTE LA SALA", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub TXTSALA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSALA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTSALA_TextChanged(sender As Object, e As EventArgs) Handles TXTSALA.TextChanged
        CONE.Open()
        Try
            Dim COMANDO As String = "SELECT CODIGO, SALA FROM SALAS WHERE CODIGO LIKE '" & "%" & TXTCODIGO.Text & "%" _
                                    & "' AND SALA LIKE '" & "%" & TXTSALA.Text & "%" & "'"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CODIGO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 335 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CODIGO").HeaderText = "CODIGO"
                DGVGENERAL.Columns("SALA").HeaderText = "SALA"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                BTNACEPTAR.Visible = False
            ElseIf DATO.Rows.Count = 0 Then
                DGVGENERAL.Columns.Clear()
                BTNACEPTAR.Visible = True
                'MsgBox("NO EXISTE LA SALA", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub AGREGAR_SALA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Try
            CONE.Open()
            Dim COMANDO As String = "SELECT CODIGO, SALA FROM SALAS"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CODIGO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 335 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CODIGO").HeaderText = "CODIGO"
                DGVGENERAL.Columns("SALA").HeaderText = "SALA"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                DGVGENERAL.Columns.Clear()
                'MsgBox("NO EXISTE LA SALA", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub
    Sub GUARDAR()
        CONE.Open()
        Dim GUARDAR As String = "INSERT INTO SALAS (CODIGO, SALA) VALUES ('" & TXTCODIGO.Text & "','" & TXTSALA.Text & "')"
        Dim COMAND As SqlCommand
        COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN TABLA
        COMAND.ExecuteNonQuery()
        MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
        CONE.Close()
        Me.Close()
    End Sub
    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        If (TXTCODIGO.Text <> "" And TXTSALA.Text <> "") And (DGVGENERAL.Rows.Count = 0) Then
            GUARDAR()
        ElseIf ((TXTCODIGO.Text = "" And TXTSALA.Text = "") Or (TXTCODIGO.Text <> "" And TXTSALA.Text = "") _
                Or (TXTCODIGO.Text = "" And TXTSALA.Text <> "")) And (DGVGENERAL.Rows.Count > 0) Then
            MsgBox("PARA AGREGAR DEBE LLENAR LOS CAMPO DE CODIGO Y SALA")
        End If
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