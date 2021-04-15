Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class LISTA_EMPLEADO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Private Sub CBACTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CBACTIVO.CheckedChanged
        If CBACTIVO.Checked = True Then
            DGVGENERAL.Columns.Clear()
            ACTIVO()
            CBINACTIVO.Checked = False
            CBNOMBRE.Checked = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
        End If
    End Sub

    Private Sub CBINACTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CBINACTIVO.CheckedChanged
        If CBINACTIVO.Checked = True Then
            DGVGENERAL.Columns.Clear()
            INACTIVO()
            CBACTIVO.Checked = False
            CBNOMBRE.Checked = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = False
        End If
    End Sub

    Private Sub CBNOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles CBNOMBRE.CheckedChanged
        If CBNOMBRE.Checked = True Then
            DGVGENERAL.Columns.Clear()
            CBACTIVO.Checked = False
            CBINACTIVO.Checked = False
            TXTNOMBRES.Text = "" : TXTNOMBRES.Enabled = True
        End If
    End Sub
    Sub ACTIVO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NACIONALIDAD, IDENTIDAD, USUARIO, CLAVE, ESTADO, ESTATUS, DEPARTAMENTO FROM LOGIN " _
        & "WHERE ESTADO='ACTIVO'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA 
                DGVGENERAL.Columns("USUARIO").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CLAVE").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTATUS").Width = 75 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 210 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("USUARIO").HeaderText = "NOMBRE DEL EMPLEADO"
                DGVGENERAL.Columns("CLAVE").HeaderText = "CLAVE"
                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTATUS").HeaderText = "ESTATUS"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBACTIVO.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub INACTIVO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NACIONALIDAD, IDENTIDAD, USUARIO, CLAVE, ESTADO, ESTATUS, DEPARTAMENTO FROM LOGIN " _
        & "WHERE ESTADO='INACTIVO'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA 
                DGVGENERAL.Columns("USUARIO").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CLAVE").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTATUS").Width = 75 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 210 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("USUARIO").HeaderText = "NOMBRE DEL EMPLEADO"
                DGVGENERAL.Columns("CLAVE").HeaderText = "CLAVE"
                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTATUS").HeaderText = "ESTATUS"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBINACTIVO.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub NOMBRE()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NACIONALIDAD, IDENTIDAD, USUARIO, CLAVE, ESTADO, ESTATUS, DEPARTAMENTO FROM LOGIN " _
        & "WHERE USUARIO LIKE'" & "%" & TXTNOMBRES.Text & "%" & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA 
                DGVGENERAL.Columns("USUARIO").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CLAVE").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTATUS").Width = 75 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 210 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("USUARIO").HeaderText = "NOMBRE DEL EMPLEADO"
                DGVGENERAL.Columns("CLAVE").HeaderText = "CLAVE"
                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTATUS").HeaderText = "ESTATUS"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBNOMBRE.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub LISTA_EMPLEADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NACIONALIDAD, IDENTIDAD, USUARIO, CLAVE, ESTADO, ESTATUS, DEPARTAMENTO FROM LOGIN"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA 
                DGVGENERAL.Columns("USUARIO").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CLAVE").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTADO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("ESTATUS").Width = 75 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 210 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD"
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD"
                DGVGENERAL.Columns("USUARIO").HeaderText = "NOMBRE DEL EMPLEADO"
                DGVGENERAL.Columns("CLAVE").HeaderText = "CLAVE"
                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTATUS").HeaderText = "ESTATUS"
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO"
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub TXTNOMBRES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOMBRES.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTNOMBRES_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBRES.TextChanged
        DGVGENERAL.Columns.Clear()
        NOMBRE()
    End Sub
End Class