Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CONTACTO_HOSPITALIZACION
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        HOSPITALIZACION.Show()
    End Sub
    Sub BUSQUEDA_IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT IDENTIDAD, CORRELATIVO, RESPONSABLE, PARENTEZCO,CAST(DIRECCION AS varchar(MAX)) AS DIRECCION," _
        & "TELEFONO1, TELEFONO2 FROM EME_CONTACTO WHERE IDENTIDAD='" & LBIDENTIDAD.Text & "'GROUP BY IDENTIDAD, CORRELATIVO," _
        & "RESPONSABLE, CAST(DIRECCION AS varchar(MAX)),  PARENTEZCO, TELEFONO1, TELEFONO2 HAVING COUNT(*)>=1"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("IDENTIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RESPONSABLE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIRECCION").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD DEL PACIENTE" '0
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '1
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "NOMBRE DE CONTACTO" '2
                DGVGENERAL.Columns("PARENTEZCO").HeaderText = "PARENTEZCO" '3
                DGVGENERAL.Columns("DIRECCION").HeaderText = "DIRECCION DEL CONTACTO" '4
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO 1" '5
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO 2" '6
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO ALMACENADO, INGRESE UNO NUEVO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                HOSPITALIZACION.TXTVALOR.Text = "NO"
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub BUSQUEDA_CORRELATIVO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT IDENTIDAD, CORRELATIVO, RESPONSABLE, PARENTEZCO,CAST(DIRECCION AS varchar(MAX)) AS DIRECCION," _
        & "TELEFONO1, TELEFONO2 FROM EME_CONTACTO WHERE CORRELATIVO='" & LBIDENTIDAD.Text & "'GROUP BY IDENTIDAD, CORRELATIVO," _
        & "RESPONSABLE, CAST(DIRECCION AS varchar(MAX)),  PARENTEZCO, TELEFONO1, TELEFONO2 HAVING COUNT(*)>=1"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("IDENTIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RESPONSABLE").Width = 250 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PARENTEZCO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIRECCION").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD DEL PACIENTE" '0
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '1
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "NOMBRE DE CONTACTO" '2
                DGVGENERAL.Columns("PARENTEZCO").HeaderText = "PARENTEZCO" '3
                DGVGENERAL.Columns("DIRECCION").HeaderText = "DIRECCION DEL CONTACTO" '4
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO 1" '5
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO 2" '6
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO ALMACENADO, INGRESE UNO NUEVO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                HOSPITALIZACION.TXTVALOR.Text = "NO"
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub CONTACTO_HOSPITALIZACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "IDENTIDAD" Then
            BUSQUEDA_IDENTIDAD()
        ElseIf (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "CORRELATIVO" Then
            BUSQUEDA_CORRELATIVO()
        End If
    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        Dim A As Integer
        If DGVGENERAL.ColumnCount > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            HOSPITALIZACION.TXTRESPONSABLE.Text = DGVGENERAL.Item(2, A).Value() 'NOMBRE DEL CONTACTO
            HOSPITALIZACION.CMBPARENTEZCO.Text = DGVGENERAL.Item(3, A).Value() 'PARENTEZCO
            HOSPITALIZACION.TXTDIRECCION.Text = DGVGENERAL.Item(4, A).Value() 'DIRECCION DEL CONTACTO
            HOSPITALIZACION.TXTTELEFONO1.Text = DGVGENERAL.Item(5, A).Value() 'TELEFONO 1 DEL CONTACTO
            HOSPITALIZACION.TXTTELEFONO2.Text = DGVGENERAL.Item(6, A).Value() 'TELEFONO 2 DEL CONTACTO
            HOSPITALIZACION.TXTVALOR.Text = "SI"
        ElseIf DGVGENERAL.ColumnCount = 0 Then
            HOSPITALIZACION.TXTVALOR.Text = "NO"
            Me.Close()
        End If
        Me.Close()
    End Sub

    Private Sub BTNSALIR_Click_1(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub
End Class