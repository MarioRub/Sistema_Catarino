Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class TAR_SALA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        Dim A As Integer
        If DGVGENERAL.Rows.Count > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            TAR_VISITA.TXTSALA.Text = DGVGENERAL.Item(1, A).Value() 'NOMBRE DE LA SALA
        ElseIf DGVGENERAL.Rows.Count = 0 Then
            MsgBox("NO HAY NINGUN ITEM CARGADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        End If
        Me.Close()
    End Sub

    Private Sub TAR_SALA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                TXTCODIGO.Text = ""
                TXTCODIGO.Focus()
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
End Class