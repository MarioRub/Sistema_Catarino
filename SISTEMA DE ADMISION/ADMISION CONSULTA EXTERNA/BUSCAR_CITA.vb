Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSCAR_CITA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Sub BUSCAR_CITA()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SET LANGUAGE SPANISH SELECT NACIONALIDAD, PAIS, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO," _
        & "EDAD, TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, NOMBRE_PADRE, NOMBRE_MADRE, " _
        & "COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, ESPECIALIDAD, MEDICO, " _
        & "FECHA_CITADO, SEXO FROM [ADMISION].[dbo].[BITACORA] WHERE (IDENTIDAD='" _
        & LBIDENTIDAD.Text & "') AND (FECHA_CITADO BETWEEN FORMAT(CONVERT(DATE,GETDATE(),0),'dd/MM/yyyy')" _
        & "AND FORMAT((SELECT MAX(FECHA_CITADO) FROM [ADMISION].[dbo].[BITACORA]),'dd/MM/yyyy'))"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            LBPACIENTE.Text = DATO.Rows(0)("NOMBRE_PACIENTE") & " " & DATO.Rows(0)("PRIMER_APELLIDO") & " " & DATO.Rows(0)("SEGUNDO_APELLIDO")
            DGVGENERAL.DataSource = DATO
            DGVGENERAL.Columns("NACIONALIDAD").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("PAIS").Width = 150
            DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 200 'DAR ANCGO A LA COLUMNA
            DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 120 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 120 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("TIPO_EDAD").Width = 80 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("FECHA_NAC").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("CORRELATIVO").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("IDENTIDAD").Width = 140 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("NOMBRE_PADRE").Width = 250 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("NOMBRE_MADRE").Width = 250 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("COLONIA").Width = 250 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("CASA").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("TELEFONO1").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("TELEFONO2").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("ESPECIALIDAD").Width = 200 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("MEDICO").Width = 200 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("FECHA_CITADO").Width = 150 'DAR ANCHO A LA COLUMNA
            DGVGENERAL.Columns("SEXO").Width = 80 'DAR ANCHO A LA COLUMNA
            'OTORGAR EL TITULO
            DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '0
            DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '1
            DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE DEL PACIENTE" '2
            DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '3
            DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '4
            DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '5
            DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '6
            DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC." '7
            DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '8
            DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '9
            DGVGENERAL.Columns("NOMBRE_PADRE").HeaderText = "NOMBRE DEL PADRE" '10
            DGVGENERAL.Columns("NOMBRE_MADRE").HeaderText = "NOMBRE DE LA MADRE" '11
            DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '12
            DGVGENERAL.Columns("CASA").HeaderText = "CASA" '13
            DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '14
            DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '15
            DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO#1" '16
            DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO#2" '17
            DGVGENERAL.Columns("ESPECIALIDAD").HeaderText = "ESPECIALIDAD" '18
            DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO" '19
            DGVGENERAL.Columns("FECHA_CITADO").HeaderText = "FECHA DE CITADO" '20
            DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '21
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.RowCount
    End Sub
    
    Private Sub BUSCAR_CITA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BUSCAR_CITA()
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNACTIVO_Click(sender As Object, e As EventArgs) Handles BTNACTIVO.Click
        Dim A As Integer
        If DGVGENERAL.ColumnCount > 0 Then
            A = DGVGENERAL.CurrentRow.Index
            REIMPRIMIRCEX.TXTPAIS.Text = DGVGENERAL.Item(1, A).Value() 'PAIS
            REIMPRIMIRCEX.TXTNOMBRES.Text = DGVGENERAL.Item(2, A).Value() 'NOMBRE
            REIMPRIMIRCEX.TXTPRIMERAPELLIDO.Text = DGVGENERAL.Item(3, A).Value() 'PRIMER APELLIDO
            REIMPRIMIRCEX.TXTSEGUNDOAPELLIDO.Text = DGVGENERAL.Item(4, A).Value() 'SEGUNDO APELLIDO
            REIMPRIMIRCEX.TXTEDAD.Text = DGVGENERAL.Item(5, A).Value() 'EDAD
            REIMPRIMIRCEX.CMBTIPO.Text = DGVGENERAL.Item(6, A).Value() ' TIPO EDAD
            REIMPRIMIRCEX.FN.Value = DGVGENERAL.Item(7, A).Value() 'FECHA DE NACIMIENTO
            REIMPRIMIRCEX.TXTCORRELATIVO.Text = DGVGENERAL.Item(8, A).Value() 'CORRELATIVO
            REIMPRIMIRCEX.TXTIDENTIDAD.Text = DGVGENERAL.Item(9, A).Value() 'IDENTIDAD
            REIMPRIMIRCEX.TXTPADRE.Text = DGVGENERAL.Item(10, A).Value() 'NOMBRE DEL PADRE
            REIMPRIMIRCEX.TXTMADRE.Text = DGVGENERAL.Item(11, A).Value() 'NOMBRE DE LA MADRE
            REIMPRIMIRCEX.TXTCOLONIA.Text = DGVGENERAL.Item(12, A).Value() ' COLONIA
            REIMPRIMIRCEX.TXTCASA.Text = DGVGENERAL.Item(13, A).Value() 'CASA
            REIMPRIMIRCEX.CMBDEPARTAMENTO.Text = DGVGENERAL.Item(14, A).Value() 'DEPARTAMENTO
            REIMPRIMIRCEX.CMBMUNICIPIO.Text = DGVGENERAL.Item(15, A).Value() 'MUNICIPIO
            REIMPRIMIRCEX.TXTTELEFONO1.Text = DGVGENERAL.Item(16, A).Value() 'TELEFONO 1
            REIMPRIMIRCEX.TXTTELEFONO2.Text = DGVGENERAL.Item(17, A).Value() 'TELEFONO 2
            REIMPRIMIRCEX.TXTFECHA_BUSQUEDA.Text = DGVGENERAL.Item(20, A).Value() 'CITADO
            REIMPRIMIRCEX.CMBSEXO.Text = DGVGENERAL.Item(21, A).Value() 'SEXO
        End If
        Me.Close()
    End Sub

    Private Sub BTNACTIVO_MouseEnter(sender As Object, e As EventArgs) Handles BTNACTIVO.MouseEnter
        BTNACTIVO.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNACTIVO.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNACTIVO_MouseLeave(sender As Object, e As EventArgs) Handles BTNACTIVO.MouseLeave
        BTNACTIVO.FlatAppearance.BorderColor = Color.Silver
        BTNACTIVO.FlatAppearance.BorderSize = 1
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