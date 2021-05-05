Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BITACORA_CITA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub
    Sub BUSQUEDA_IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT LOGIN.USUARIO ,ESPECIALIDAD, MEDICO, CONSULTORIO, PREFERENTE, NORMAL, FECHA_FICHA, FECHA_CITADO, " _
        & "HORA_INCLUSION, NUEVA, SUBSIGUIENTE, REPROGRAMACION, CAMBIO_CITA FROM BITACORA INNER JOIN LOGIN ON " _
        & "BITACORA.IDENTIDAD_EMPLEADO=LOGIN.IDENTIDAD WHERE BITACORA.IDENTIDAD='" & LBIDENTIDAD.Text & "' ORDER BY FECHA_CITADO DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            DGVGENERAL.Columns("USUARIO").Width = 200 'DAR ANCHO A LA COLUMNA
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
        Dim COMANDO As String = "SELECT LOGIN.USUARIO ,ESPECIALIDAD, MEDICO, CONSULTORIO, PREFERENTE, NORMAL, FECHA_FICHA, FECHA_CITADO, " _
        & "HORA_INCLUSION, NUEVA, SUBSIGUIENTE, REPROGRAMACION, CAMBIO_CITA FROM BITACORA INNER JOIN LOGIN ON " _
        & "BITACORA.IDENTIDAD_EMPLEADO=LOGIN.IDENTIDAD WHERE BITACORA.CORRELATIVO='" & LBIDENTIDAD.Text & "' ORDER BY FECHA_CITADO DESC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            DGVGENERAL.Columns("USUARIO").Width = 200 'DAR ANCHO A LA COLUMNA
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
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub BITACORA_CITA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "IDENTIDAD" Then
            BUSQUEDA_IDENTIDAD()
        ElseIf (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "CORRELATIVO" Then
            BUSQUEDA_CORRELATIVO()
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