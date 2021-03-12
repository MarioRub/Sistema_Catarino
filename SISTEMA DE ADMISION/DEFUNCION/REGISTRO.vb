Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class REGISTRO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Sub BUSQUEDA_IDENTIDAD()
        Try
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT ('IMPRONTO') AS DOCUMENTO, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO," _
            & "IDENTIDAD, CORRELATIVO, FECHA_ING, HORA_ING FROM IMPRONTO WHERE TIPO='" _
            & LBCLASIFICACION.Text & "' AND IDENTIDAD='" & LBIDENTIDAD.Text & "' UNION ALL " _
            & "SELECT ('HOSPITALIZACION') AS DOCUMENTO, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, " _
            & "IDENTIDAD, CORRELATIVO, FECHA_ING, HORA_ING FROM HOSPITALIZACION WHERE TIPO='" _
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
                DGVGENERAL.Columns("DOCUMENTO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("DOCUMENTO").HeaderText = "DOCUMENTO" '0
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '1
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '2
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "1ER APELLIDO" '3
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "2DO APELLIDO" '4
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '5
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '6
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO" '7
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '8
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                REC_DEFUNCION.INGRESO.Enabled = False
                REC_DEFUNCION.HORA_INGRESO.Enabled = False
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                REC_DEFUNCION.INGRESO.Enabled = True
                REC_DEFUNCION.HORA_INGRESO.Enabled = True
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
            Dim COMANDO As String = "SELECT ('IMPRONTO') AS DOCUMENTO, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO," _
            & "IDENTIDAD, CORRELATIVO, FECHA_ING, HORA_ING FROM IMPRONTO WHERE TIPO='" _
            & LBCLASIFICACION.Text & "' AND CORRELATIVO='" & LBIDENTIDAD.Text & "' UNION ALL " _
            & "SELECT ('HOSPITALIZACION') AS DOCUMENTO, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, " _
            & "IDENTIDAD, CORRELATIVO, FECHA_ING, HORA_ING FROM HOSPITALIZACION WHERE TIPO='" _
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
                DGVGENERAL.Columns("DOCUMENTO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 135 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 100 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("DOCUMENTO").HeaderText = "DOCUMENTO" '0
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '1
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '2
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "1ER APELLIDO" '3
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "2DO APELLIDO" '4
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '5
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '6
                DGVGENERAL.Columns("FECHA_ING").HeaderText = "FECHA INGRESO" '7
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '8
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                REC_DEFUNCION.INGRESO.Enabled = False
                REC_DEFUNCION.HORA_INGRESO.Enabled = False
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                REC_DEFUNCION.INGRESO.Enabled = True
                REC_DEFUNCION.HORA_INGRESO.Enabled = True
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub REGISTRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "IDENTIDAD" Then
            BUSQUEDA_IDENTIDAD()
        ElseIf (LBNACIONALIDAD.Text = "HONDUREÑO" Or LBNACIONALIDAD.Text = "EXTRANJERO") And LBTIPO.Text = "CORRELATIVO" Then
            BUSQUEDA_CORRELATIVO()
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        REC_DEFUNCION.INGRESO.Enabled = True
        REC_DEFUNCION.HORA_INGRESO.Enabled = True
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

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        Dim A As Integer
        If DGVGENERAL.Rows.Count > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            REC_DEFUNCION.INGRESO.Value = DGVGENERAL.Item(7, A).Value() 'FECHA DE INGRESO
            REC_DEFUNCION.HORA_INGRESO.Text = DGVGENERAL.Item(8, A).Value() 'HORA DE INGRESO
        ElseIf DGVGENERAL.Rows.Count = 0 Then
            MsgBox("NO HAY NINGUN ITEM CARGADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        End If
        Me.Close()
    End Sub
End Class