Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports CrystalDecisions.Shared
Public Class CITADO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Sub COMBOESPECIALIDAD()
        '----------CARGAR COMBOBOX ESPECIALIDAD------------
        Dim DS As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES ORDER BY ESPECIALIDAD ASC"
        Dim DA As New SqlDataAdapter(DS, CONEXION)
        Dim CMB As New DataSet
        DA.Fill(CMB)
        'AGREGAR UNA LINEA EN BLANCO
        Dim FILA As DataRow
        FILA = CMB.Tables(0).NewRow()
        FILA(0) = ""
        CMB.Tables(0).Rows.InsertAt(FILA, 0)
        '-----------------------------------------------------
        CMBESPECIALIDAD.DataSource = CMB.Tables(0)
        CMBESPECIALIDAD.SelectedIndex = 0
        CMBESPECIALIDAD.DisplayMember = "ESPECIALIDAD"
        'TXTCOD_ESPECIALIDAD.Text = CMB.Tables(0).Rows(0)("CODIGO_ESPECIALIDAD")
        '--------------------------------------------------------
    End Sub
    Private Sub CITADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBMEDICO.DropDownStyle = ComboBoxStyle.DropDownList
        INICIAL.Value = DateTime.Now.Date
        FINAL.Value = DateTime.Now.Date
        COMBOESPECIALIDAD()
    End Sub

    Private Sub CMBESPECIALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBESPECIALIDAD.SelectedIndexChanged
        '----------CARGAR COMBOBOX ESPECIALIDAD------------
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        TXTCOD_ESPECIALIDAD.Text = ""
        Dim COMANDO As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES WHERE ESPECIALIDAD ='" & CMBESPECIALIDAD.Text & "' ORDER BY ESPECIALIDAD ASC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        TXTCOD_ESPECIALIDAD.Text = CMBESPECIALIDAD.SelectedItem("CODIGO_ESPECIALIDAD").ToString
        '---------------------------------------------------------------------------------------
        '------CARGAR COMBOBOX MEDICO-----------------------
        If CMBESPECIALIDAD.SelectedIndex > 0 Then
            CONE.Open()
            Dim ADAPTA As New SqlDataAdapter
            Dim COMAND As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, " _
            & "HORARIO, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE CODIGO_ESPECIALIDAD='" _
            & TXTCOD_ESPECIALIDAD.Text & "' AND ESTADO='ACTIVO' ORDER BY NOMBRE ASC"
            Dim CMB As DataTable
            ADAPTA = New SqlDataAdapter(COMAND, CONE)
            CMB = New DataTable
            ADAPTA.Fill(CMB)
            If CMB.Rows.Count > 0 Then
                CMBMEDICO.Enabled = True
                CMBMEDICO.DataSource = CMB
                CMBMEDICO.DisplayMember = "NOMBRE"
                CMBMEDICO.ValueMember = "ESPECIALIDAD"
                CONE.Close()
            ElseIf CMB.Rows.Count = 0 Then
                CMBMEDICO.DataSource = Nothing
                CMBMEDICO.Items.Clear()
                MsgBox("NO HAY MEDICO AGREGADO, CONTACTE CON EL ADMINISTRADOR PARA QUE INGRESE EL MEDICO")
                CMBMEDICO.Enabled = False
                CONE.Close()
            End If
        ElseIf CMBESPECIALIDAD.SelectedIndex = 0 Then
            CMBMEDICO.DataSource = Nothing
            CMBMEDICO.Items.Clear()
        End If
        '------------------------------
    End Sub

    Private Sub CMBMEDICO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBMEDICO.SelectedIndexChanged
        CMBMEDICO.DropDownStyle = ComboBoxStyle.DropDownList
        '----------CARGAR CONSULTORIO EN TXTCLINICA------------
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, HORARIO, " _
        & "LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE NOMBRE='" _
        & CMBMEDICO.Text & "' AND ESPECIALIDAD='" & CMBESPECIALIDAD.Text & "' AND ESTADO='ACTIVO'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMAND, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        If DATO.Rows.Count > 0 Then
            TXTCLINICA.Text = CMBMEDICO.SelectedItem("CONSULTORIO").ToString
            INICIAL.Enabled = True
            INICIAL.Value = DateTime.Now.Date
            FINAL.Enabled = True
            FINAL.Value = DateTime.Now.Date
        ElseIf DATO.Rows.Count = 0 Then
            TXTCLINICA.Text = ""
            INICIAL.Enabled = False
            INICIAL.Value = DateTime.Now.Date
            FINAL.Enabled = False
            FINAL.Value = DateTime.Now.Date
        End If
    End Sub

    Private Sub INICIAL_CloseUp(sender As Object, e As EventArgs) Handles INICIAL.CloseUp
        If INICIAL.Value >= (DateTime.Now.Date) Then
            FINAL.Enabled = True
        ElseIf INICIAL.Value < DateTime.Now.Date Then
            MsgBox("NO SE PERMITE UNA FECHA INFERIOR A LA ACTUAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            INICIAL.Value = (DateTime.Now.Date)
        End If
    End Sub

    Private Sub INICIAL_ValueChanged(sender As Object, e As EventArgs) Handles INICIAL.ValueChanged
        
    End Sub

    Private Sub FINAL_CloseUp(sender As Object, e As EventArgs) Handles FINAL.CloseUp
        If FINAL.Value < INICIAL.Value Then
            MsgBox("NO SE PERMITE UNA FECHA INFERIOR A LA INICIAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            FINAL.Value = (DateTime.Now.Date)
        End If
    End Sub

    Private Sub BTNBITACORA_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        CONE.Open()
        Try
            DGVGENERAL.Columns.Clear()
            Dim INICIO As String = Format(CDate(INICIAL.Value), "yyyy/MM/dd")
            Dim FIN As String = Format(CDate(FINAL.Value), "yyyy/MM/dd")
            Dim COMANDO As String = "SELECT (NOMBRE_PACIENTE +' '+ PRIMER_APELLIDO +' '+ SEGUNDO_APELLIDO) AS NOMBRE, " _
            & "CASE WHEN (CORRELATIVO='0000-0000' AND IDENTIDAD<>'0000-0000-00000') THEN IDENTIDAD " _
            & "WHEN (CORRELATIVO<>'0000-0000' AND IDENTIDAD='0000-0000-00000') THEN CORRELATIVO " _
            & "WHEN (CORRELATIVO<>'0000-0000' AND IDENTIDAD<>'0000-0000-00000') THEN IDENTIDAD " _
            & "END AS CLINICA, (TELEFONO1+' / '+TELEFONO2) AS TELEFONOS, " _
            & " CASE WHEN SALA <> '' THEN FECHA_REFERENCIA END AS EGRESO, SALA, ESPECIALIDAD, MEDICO, CONSULTORIO, " _
            & "FECHA_CITADO, '" & LOGIN.TXTUSUARIO.Text & "' AS RESPONSABLE FROM BITACORA WHERE (ESPECIALIDAD='" & CMBESPECIALIDAD.Text & "' AND MEDICO ='" & CMBMEDICO.Text & "') AND " _
            & "(FECHA_CITADO BETWEEN '" & INICIO & "' AND '" & FIN & "') ORDER BY FECHA_CITADO ASC "
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            Dim ACTUAL As String = DateTime.Now.Date
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.DataSource = DATO
                DGVGENERAL.Columns("CLINICA").Width = 140 'DAR ANCGO A LA COLUMNA  
                DGVGENERAL.Columns("CLINICA").HeaderText = "HISTORIAL CLINICO" '0
                DGVGENERAL.Columns("NOMBRE").Width = 280 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE").HeaderText = "NOMBRE DEL PACIENTE" '1
                DGVGENERAL.Columns("EGRESO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("EGRESO").HeaderText = "FECHA DE EGRESO" '2
                DGVGENERAL.Columns("SALA").Width = 200 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SALA").HeaderText = "SALA" '3
                DGVGENERAL.Columns("TELEFONOS").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONOS").HeaderText = "TELEFONOS" '4

                DGVGENERAL.Columns("ESPECIALIDAD").Width = 200 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD" '5
                DGVGENERAL.Columns("MEDICO").Width = 200 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO" '6
                DGVGENERAL.Columns("CONSULTORIO").Width = 40 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("CONSULTORIO").HeaderText = "CONSULTORIO" '7
                DGVGENERAL.Columns("ESPECIALIDAD").Visible = False '
                DGVGENERAL.Columns("MEDICO").Visible = False
                DGVGENERAL.Columns("CONSULTORIO").Visible = False

                DGVGENERAL.Columns("FECHA_CITADO").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_CITADO").HeaderText = "FECHA CITADO" '8
                DGVGENERAL.Columns("RESPONSABLE").HeaderText = "RESPONSABLE" '9
                DGVGENERAL.Columns("RESPONSABLE").Visible = False
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                BTNREPORTE.Enabled = True
            ElseIf DATO.Rows.Count = 0 Then
                CONE.Close()
                BTNREPORTE.Enabled = False
                MsgBox("NO EXISTE REGISTRO EN LA FECHA DE CITADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNREIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNREPORTE.Click
        Try
            If DGVGENERAL.Rows.Count > 0 Then
                Dim DT As New DataTable
                With DT
                    .Columns.Add("CLINICA")
                    .Columns.Add("NOMBRE")
                    .Columns.Add("EGRESO")
                    .Columns.Add("SALA")
                    .Columns.Add("TELEFONOS")
                    .Columns.Add("FECHA_CITADO")
                    .Columns.Add("ESPECIALIDAD")
                    .Columns.Add("MEDICO")
                    .Columns.Add("CONSULTORIO")
                    .Columns.Add("RESPONSABLE")
                End With
                For Each ROW As DataGridViewRow In Me.DGVGENERAL.Rows
                    DT.Rows.Add(ROW.Cells("CLINICA").Value,
                                ROW.Cells("NOMBRE").Value,
                                ROW.Cells("EGRESO").Value,
                                ROW.Cells("SALA").Value,
                                ROW.Cells("TELEFONOS").Value,
                                Format(ROW.Cells("FECHA_CITADO").Value, "dd/MMM/yyyy") & "....." & UCase(Format(ROW.Cells("FECHA_CITADO").Value, "dddd")),
                                ROW.Cells("ESPECIALIDAD").Value,
                                ROW.Cells("MEDICO").Value,
                                ROW.Cells("CONSULTORIO").Value,
                                ROW.Cells("RESPONSABLE").Value)
                Next
                Dim IMPRIMIR As CrystalDecisions.CrystalReports.Engine.ReportDocument
                IMPRIMIR = New RCITADO
                IMPRIMIR.SetDataSource(DT)
                RPCITADO.CrystalReportViewer1.ReportSource = IMPRIMIR
                RPCITADO.CrystalReportViewer1.Refresh()
                RPCITADO.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class