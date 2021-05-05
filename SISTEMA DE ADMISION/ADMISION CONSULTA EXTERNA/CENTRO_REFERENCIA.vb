Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CENTRO_REFERENCIA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub CENTRO_REFERENCIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT DEPARTAMENTO, MUNICIPIO, CENTRO, UBICACION FROM CENTRO_REFERENCIA WHERE DEPARTAMENTO='" _
                                & CITASCEX.CMBDEPARTAMENTO1.Text & "'AND MUNICIPIO='" & CITASCEX.CMBMUNICIPIO1.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CENTRO").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("UBICACION").Width = 500
                DGVGENERAL.Columns("CENTRO").HeaderText = "CENTRO QUE REFIERE"
                DGVGENERAL.Columns("UBICACION").HeaderText = "UBICACION DONDE SE ENCUENTRA EL CENTRO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO EN LA TABLA, FAVOR AÑADIRLOS", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNACTIVO_Click(sender As Object, e As EventArgs) Handles BTNACTIVO.Click
        Dim A As Integer
        If DGVGENERAL.ColumnCount > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            CITASCEX.TXTCENTRO.Text = DGVGENERAL.Item(2, A).Value() 'FILA CENTRO
            CITASCEX.TXTDIRECCIONCENTRO.Text = DGVGENERAL.Item(3, A).Value()  'FILA UBICACION
        End If
        Me.Close()
    End Sub

    Private Sub TXTDEPARTAMENTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDEPARTAMENTO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTDEPARTAMENTO_TextChanged(sender As Object, e As EventArgs) Handles TXTDEPARTAMENTO.TextChanged

    End Sub

    Private Sub TXTMUNICIPIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMUNICIPIO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTMUNICIPIO_TextChanged(sender As Object, e As EventArgs) Handles TXTMUNICIPIO.TextChanged

    End Sub
End Class