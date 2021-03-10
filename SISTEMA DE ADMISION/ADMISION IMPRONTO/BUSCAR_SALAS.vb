Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSCAR_SALAS
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
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

    Private Sub TXTCODIGO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCODIGO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCODIGO_TextChanged(sender As Object, e As EventArgs) Handles TXTCODIGO.TextChanged
        CONE.Open()
        Try
            'Dim COMANDO As String = "SELECT CODIGO, SALA FROM SALAS WHERE CODIGO LIKE '" & "%" & TXTCODIGO.Text & "%" & "'"
            Dim COMANDO As String = "SELECT CODIGO, SALA FROM SALAS WHERE CODIGO LIKE '" _
                & "%" & TXTCODIGO.Text & "%" & "' AND SALA LIKE '" & "%" & TXTSALA.Text & "%" & "' ORDER BY SALA ASC"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CODIGO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 365 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CODIGO").HeaderText = "CODIGO"
                DGVGENERAL.Columns("SALA").HeaderText = "SALA"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                CONE.Close()
                MsgBox("NO EXISTE LA SALA", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                TXTCODIGO.Text = "" : TXTCODIGO.Focus()
                TXTSALA.Text = ""
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
            'Dim COMANDO As String = "SELECT CODIGO, SALA FROM SALAS WHERE SALA LIKE '" & "%" & TXTSALA.Text & "%" & "'"
            Dim COMANDO As String = "SELECT CODIGO, SALA FROM SALAS WHERE CODIGO LIKE '" _
                & "%" & TXTCODIGO.Text & "%" & "' AND SALA LIKE '" & "%" & TXTSALA.Text & "%" & "' ORDER BY SALA ASC"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CODIGO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 365 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CODIGO").HeaderText = "CODIGO"
                DGVGENERAL.Columns("SALA").HeaderText = "SALA"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                CONE.Close()
                MsgBox("NO EXISTE LA SALA", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                TXTCODIGO.Text = "" : TXTCODIGO.Focus()
                TXTSALA.Text = ""
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub BUSCAR_SALAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONE.Open()
        Try
            Dim COMANDO As String = "SELECT CODIGO, SALA FROM SALAS ORDER BY SALA ASC"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CODIGO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 365 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CODIGO").HeaderText = "CODIGO"
                DGVGENERAL.Columns("SALA").HeaderText = "SALA"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                CONE.Close()
                MsgBox("NO EXISTE LA SALA", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                TXTCODIGO.Text = "" : TXTCODIGO.Focus()
                TXTSALA.Text = ""
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        Dim A As Integer
        If DGVGENERAL.ColumnCount > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            IMPRONTO.TXTREMITENTE.Text = DGVGENERAL.Item(1, A).Value() 'NOMBRE DE LA SALA
        End If
        Me.Close()
    End Sub

    Private Sub BTNACEPTAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNACEPTAR.MouseEnter
        BTNACEPTAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNACEPTAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNACEPTAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNACEPTAR.MouseLeave
        BTNACEPTAR.FlatAppearance.BorderColor = Color.Silver
        BTNACEPTAR.FlatAppearance.BorderSize = 1
    End Sub
End Class