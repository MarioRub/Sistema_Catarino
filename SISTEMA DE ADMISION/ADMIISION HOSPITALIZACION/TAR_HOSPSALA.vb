Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class TAR_HOSPSALA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Sub BUSQUEDA_IDENTIDAD()
        Try
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT NO, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, EDAD, TIPO_EDAD, " _
            & "IDENTIDAD, CORRELATIVO, FECHA_ING, HORA_ING, SALA FROM HOSPITALIZACION WHERE TIPO='" _
            & LBCLASIFICACION.Text & "' AND IDENTIDAD='" & LBIDENTIDAD.Text & "' ORDER BY FECHA_ING DESC"
            Dim DATO As DataTable
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
            DATO = New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                If LBCLASIFICACION.Text = "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                ElseIf LBCLASIFICACION.Text <> "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("TIPO") & " " & DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                End If
                DGVGENERAL.Columns("NO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 300 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "NO" '0
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '1
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '2
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "1ER APELLIDO" '3
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "2DO APELLIDO" '4
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '5
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '6
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '7
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '8
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '9
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO" '10
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '11
                DGVGENERAL.Columns("SALA").HeaderText = "SALA DONDE INGRESO" '12
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                TAR_VISITA.DTFECHA.Enabled = False
                TAR_VISITA.DTHORA.Enabled = False
                TAR_VISITA.BTNSALA.Visible = False
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                TAR_VISITA.DTFECHA.Enabled = True
                TAR_VISITA.DTHORA.Enabled = True
                TAR_VISITA.BTNSALA.Visible = True
                TAR_VISITA.DTHORA.Text = Format(Now, "HH:MM")
                TAR_VISITA.DTFECHA.Value = (DateTime.Now.Date)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub BUSQUEDA_CORRELATIVO()
        Try
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT NO, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, EDAD, TIPO_EDAD, " _
            & "IDENTIDAD, CORRELATIVO, FECHA_ING, HORA_ING, SALA FROM HOSPITALIZACION WHERE TIPO='" _
            & LBCLASIFICACION.Text & "' AND CORRELATIVO='" & LBIDENTIDAD.Text & "' ORDER BY FECHA_ING DESC"
            Dim DATO As DataTable
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
            DATO = New DataTable
            ADAPTADOR.Fill(DATO)
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                If LBCLASIFICACION.Text = "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                ElseIf LBCLASIFICACION.Text <> "NORMAL" Then
                    LBPACIENTE.Text = DATO.Rows(0)("TIPO") & " " & DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
                End If
                DGVGENERAL.Columns("NO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA").Width = 300 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "NO" '0
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '1
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '2
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "1ER APELLIDO" '3
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "2DO APELLIDO" '4
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '5
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '6
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '7
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '8
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '9
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO" '10
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '11
                DGVGENERAL.Columns("SALA").HeaderText = "SALA DONDE INGRESO" '12
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                TAR_VISITA.DTFECHA.Enabled = False
                TAR_VISITA.DTHORA.Enabled = False
                TAR_VISITA.BTNSALA.Visible = False
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                TAR_VISITA.DTFECHA.Enabled = True
                TAR_VISITA.DTHORA.Enabled = True
                TAR_VISITA.BTNSALA.Visible = True
                TAR_VISITA.DTHORA.Text = Format(Now, "HH:MM")
                TAR_VISITA.DTFECHA.Value = (DateTime.Now.Date)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub TAR_HOSPSALA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "IDENTIDAD" Then
            BUSQUEDA_IDENTIDAD()
        ElseIf (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "CORRELATIVO" Then
            BUSQUEDA_CORRELATIVO()
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        TAR_VISITA.DTFECHA.Enabled = True
        TAR_VISITA.DTHORA.Enabled = True
        Me.Close()
    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        Dim A As Integer
        If DGVGENERAL.Rows.Count > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            TAR_VISITA.DTFECHA.Value = DGVGENERAL.Item(10, A).Value() 'FECHA DE INGRESO
            TAR_VISITA.DTHORA.Text = DGVGENERAL.Item(11, A).Value() 'HORA DE INGRESO
            TAR_VISITA.TXTSALA.Text = DGVGENERAL.Item(12, A).Value() 'SALA
        ElseIf DGVGENERAL.Rows.Count = 0 Then
            MsgBox("NO HAY NINGUN ITEM CARGADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        End If
        Me.Close()
    End Sub

    Private Sub DGVGENERAL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGENERAL.CellContentClick

    End Sub
End Class