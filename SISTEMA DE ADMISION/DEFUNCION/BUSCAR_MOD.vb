Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSCAR_MOD
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Private Sub BUSCAR_MOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CMBCLASIFICACION.Text = "" And CMBNACIONALIDAD.Text = "" And CMBBUSQUEDA.Text = "" Then
            Me.Close()
        ElseIf CMBCLASIFICACION.Text <> "" And CMBNACIONALIDAD.Text <> "" And CMBBUSQUEDA.Text <> "" Then
            DGVGENERAL.Columns.Clear()
            If TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000" Then
                IDENTIDAD()
            ElseIf TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CORRELATIVO()
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                IDENTIDAD()
            End If
        End If
    End Sub

    Private Sub DGVGENERAL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGENERAL.CellContentClick
        Try
            Dim A As Integer
            If DGVGENERAL.Rows.Count > 0 Then

                A = DGVGENERAL.CurrentRow.Index
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub ULTIMO_BITACORA()
        '-----------------------------------VER ULTIMO REGISTRO------------------------
        Dim CMD As New SqlCommand("SELECT NO FROM DEFUNCION", CONE)
        Dim DA As New SqlDataAdapter(CMD)
        Dim DT As New DataTable
        Dim ULTIMO As Long
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            TXTBITACORA.Text = 1
        ElseIf DT.Rows.Count > 0 Then
            ULTIMO = DT.Rows.Count - 1
            TXTBITACORA.Text = DT.Rows(ULTIMO)("NO").ToString() + 1
        End If
    End Sub
    Sub IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
        & "FECHA_NAC, CORRELATIVO, IDENTIDAD, PADRE, MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
        & "INGRESO, HORA_ING, RECEPCION, HORA_REC, REPORTE, FISCAL, HORA_FIS, CONTESTO, SALA_DEF, DEFUNCION, HORA_DEF, MEDICO, " _
        & "DIAGNOSTICO FROM DEFUNCION WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
        ULTIMO_BITACORA()
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NO").Width = 100
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("PAIS").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INGRESO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RECEPCION").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_REC").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("REPORTE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FISCAL").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_FIS").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CONTESTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_DEF").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_DEF").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MEDICO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 500 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "NO" '0
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '1
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '2
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '3
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE" '4
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '5
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '6
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '7
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '8
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC." '9
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '10
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '11
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE" '12
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE" '13
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '14
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '15
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '16
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '17
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO" '18
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO" '19
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '20
                DGVGENERAL.Columns("INGRESO").HeaderText = "INGRESO" '21
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '22
                DGVGENERAL.Columns("RECEPCION").HeaderText = "FECHA RECEPCION" '23
                DGVGENERAL.Columns("HORA_REC").HeaderText = "HORA RECEPCION" '24
                DGVGENERAL.Columns("REPORTE").HeaderText = "PERSONA QUE LO REPORTA" '25
                DGVGENERAL.Columns("FISCAL").HeaderText = "FECHA FSICALIA" '26
                DGVGENERAL.Columns("HORA_FIS").HeaderText = "HORA FISCALIA" '27
                DGVGENERAL.Columns("CONTESTO").HeaderText = "ABOG. CONTESTO" '28
                DGVGENERAL.Columns("SALA_DEF").HeaderText = "SALA DONDE FALLECIO" '29
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "FECHA DEFUNCION" '30
                DGVGENERAL.Columns("HORA_DEF").HeaderText = "HORA QUE FALLECIO" '31
                DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO QUE LLENO LA DEFUNCION" '32
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO" '33
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO DE FALLECIMIENTO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub CORRELATIVO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
        & "FECHA_NAC, CORRELATIVO, IDENTIDAD, PADRE, MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
        & "INGRESO, HORA_ING, RECEPCION, HORA_REC, REPORTE, FISCAL, HORA_FIS, CONTESTO, SALA_DEF, DEFUNCION, HORA_DEF, MEDICO, " _
        & "DIAGNOSTICO FROM DEFUNCION WHERE CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
        ULTIMO_BITACORA()
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("NO").Width = 100
                DGVGENERAL.Columns("NACIONALIDAD").Width = 120
                DGVGENERAL.Columns("PAIS").Width = 100 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("TIPO").Width = 80 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_PACIENTE").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("EDAD").Width = 50 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TIPO_EDAD").Width = 60 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_NAC").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CORRELATIVO").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("PADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MADRE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("COLONIA").Width = 300 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CASA").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEPARTAMENTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MUNICIPIO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO1").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO2").Width = 80 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SEXO").Width = 100 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("INGRESO").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_ING").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("RECEPCION").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_REC").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("REPORTE").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FISCAL").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_FIS").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("CONTESTO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("SALA_DEF").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DEFUNCION").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("HORA_DEF").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("MEDICO").Width = 200 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("DIAGNOSTICO").Width = 500 'DAR ANCHO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("NO").HeaderText = "NO" '0
                DGVGENERAL.Columns("NACIONALIDAD").HeaderText = "NACIONALIDAD" '1
                DGVGENERAL.Columns("PAIS").HeaderText = "PAIS" '2
                DGVGENERAL.Columns("TIPO").HeaderText = "TIPO" '3
                DGVGENERAL.Columns("NOMBRE_PACIENTE").HeaderText = "NOMBRE" '4
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '5
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO APELLIDO" '6
                DGVGENERAL.Columns("EDAD").HeaderText = "EDAD" '7
                DGVGENERAL.Columns("TIPO_EDAD").HeaderText = "TIPO" '8
                DGVGENERAL.Columns("FECHA_NAC").HeaderText = "FECHA NAC." '9
                DGVGENERAL.Columns("CORRELATIVO").HeaderText = "CORRELATIVO" '10
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '11
                DGVGENERAL.Columns("PADRE").HeaderText = "NOMBRE DEL PADRE" '12
                DGVGENERAL.Columns("MADRE").HeaderText = "NOMBRE DE LA MADRE" '13
                DGVGENERAL.Columns("COLONIA").HeaderText = "COLONIA" '14
                DGVGENERAL.Columns("CASA").HeaderText = "CASA" '15
                DGVGENERAL.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" '16
                DGVGENERAL.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" '17
                DGVGENERAL.Columns("TELEFONO1").HeaderText = "TELEFONO" '18
                DGVGENERAL.Columns("TELEFONO2").HeaderText = "TELEFONO" '19
                DGVGENERAL.Columns("SEXO").HeaderText = "SEXO" '20
                DGVGENERAL.Columns("INGRESO").HeaderText = "INGRESO" '21
                DGVGENERAL.Columns("HORA_ING").HeaderText = "HORA INGRESO" '22
                DGVGENERAL.Columns("RECEPCION").HeaderText = "FECHA RECEPCION" '23
                DGVGENERAL.Columns("HORA_REC").HeaderText = "HORA RECEPCION" '24
                DGVGENERAL.Columns("REPORTE").HeaderText = "PERSONA QUE LO REPORTA" '25
                DGVGENERAL.Columns("FISCAL").HeaderText = "FECHA FSICALIA" '26
                DGVGENERAL.Columns("HORA_FIS").HeaderText = "HORA FISCALIA" '27
                DGVGENERAL.Columns("CONTESTO").HeaderText = "ABOG. CONTESTO" '28
                DGVGENERAL.Columns("SALA_DEF").HeaderText = "SALA DONDE FALLECIO" '29
                DGVGENERAL.Columns("DEFUNCION").HeaderText = "FECHA DEFUNCION" '30
                DGVGENERAL.Columns("HORA_DEF").HeaderText = "HORA QUE FALLECIO" '31
                DGVGENERAL.Columns("MEDICO").HeaderText = "MEDICO QUE LLENO LA DEFUNCION" '32
                DGVGENERAL.Columns("DIAGNOSTICO").HeaderText = "DIAGNOSTICO" '33
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN REGISTRO DE FALLECIMIENTO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Private Sub BTNCAEPTAR_Click(sender As Object, e As EventArgs) Handles BTNCAEPTAR.Click
        Try
            Dim A As Integer
            If DGVGENERAL.Rows.Count > 0 Then
                A = DGVGENERAL.CurrentRow.Index
                MOD_DEF.TXTIDENTIDAD.Text = DGVGENERAL.Item(11, A).Value() 'IDENTIDAD
                MOD_DEF.TXTCORRELATIVO.Text = DGVGENERAL.Item(10, A).Value() 'CORRELATIVO
                MOD_DEF.TXTBITACORA.Text = DGVGENERAL.Item(0, A).Value() 'NO
                MOD_DEF.TXTPAIS.Text = DGVGENERAL.Item(2, A).Value() 'PAIS
                MOD_DEF.TXTNOMBRES.Text = DGVGENERAL.Item(4, A).Value() 'NOMBRE DEL PACIENTE
                MOD_DEF.TXTPRIMERAPELLIDO.Text = DGVGENERAL.Item(5, A).Value() 'PRIMER APELLIDO
                MOD_DEF.TXTSEGUNDOAPELLIDO.Text = DGVGENERAL.Item(6, A).Value() 'SEGUNDO APELLIDO
                MOD_DEF.TXTEDAD.Text = DGVGENERAL.Item(7, A).Value() 'EDAD
                MOD_DEF.CMBTIPO.Text = DGVGENERAL.Item(8, A).Value() 'TIPO EDAD
                MOD_DEF.FN.Value = DGVGENERAL.Item(9, A).Value() 'FECHA NACIMIENTO
                MOD_DEF.TXTPADRE.Text = DGVGENERAL.Item(12, A).Value() ' PADRE
                MOD_DEF.TXTMADRE.Text = DGVGENERAL.Item(13, A).Value() 'MADRE
                MOD_DEF.TXTCOLONIA.Text = DGVGENERAL.Item(14, A).Value() 'COLONIA
                MOD_DEF.TXTCASA.Text = DGVGENERAL.Item(15, A).Value() 'CASA
                MOD_DEF.CMBDEPARTAMENTO.Text = DGVGENERAL.Item(16, A).Value() 'DEPARTAMENTO
                MOD_DEF.CMBMUNICIPIO.Text = DGVGENERAL.Item(17, A).Value() 'MUNICIPIO
                MOD_DEF.TXTTELEFONO1.Text = DGVGENERAL.Item(18, A).Value() 'TELEFONO 1
                MOD_DEF.TXTTELEFONO2.Text = DGVGENERAL.Item(19, A).Value() 'TELEFONO 2
                MOD_DEF.CMBSEXO.Text = DGVGENERAL.Item(20, A).Value() 'SEXO
                MOD_DEF.INGRESO.Value = DGVGENERAL.Item(21, A).Value() 'INGRESO
                MOD_DEF.HORA_INGRESO.Text = DGVGENERAL.Item(22, A).Value() 'HORA DE INGRESO
                MOD_DEF.RECEPCION.Value = DGVGENERAL.Item(23, A).Value() 'RECEPCION
                MOD_DEF.HORA_RECEPCION.Text = DGVGENERAL.Item(24, A).Value() 'HORA DE RECEPCION
                MOD_DEF.TXTREPORTE.Text = DGVGENERAL.Item(25, A).Value() 'REPORTE
                MOD_DEF.TXTSALA.Text = DGVGENERAL.Item(29, A).Value() 'SALA DONDE FALLECIO
                MOD_DEF.DEFUNCION.Value = DGVGENERAL.Item(30, A).Value() 'DEFUNCION
                MOD_DEF.HORA_DEFUNCION.Text = DGVGENERAL.Item(31, A).Value() 'HORA DEFUNCION
                MOD_DEF.TXTMEDICO.Text = DGVGENERAL.Item(32, A).Value() 'MEDICO
                MOD_DEF.TXTDIAGNOSTICO.Text = DGVGENERAL.Item(33, A).Value() 'DIAGNOSTICO
                MOD_DEF.FISCALIA.Value = DGVGENERAL.Item(26, A).Value() 'FISCALIA
                If DGVGENERAL.Item(27, A).Value() <> "" Then
                    MOD_DEF.HORA_FISCALIA.Text = DGVGENERAL.Item(27, A).Value() 'HORA FISCALIA
                Else
                    MOD_DEF.HORA_FISCALIA.Text = Format(Now, "hh:mm tt")
                End If
                MOD_DEF.TXTFISCALIA.Text = DGVGENERAL.Item(28, A).Value() 'CONTESTO
                MOD_DEF.TXTNOMBRES.Enabled = True : MOD_DEF.TXTPRIMERAPELLIDO.Enabled = True
                MOD_DEF.TXTSEGUNDOAPELLIDO.Enabled = True : MOD_DEF.TXTCORRELATIVO.Enabled = False
                MOD_DEF.TXTCOLONIA.Enabled = True : MOD_DEF.TXTCASA.Enabled = True
                MOD_DEF.CMBDEPARTAMENTO.Enabled = True : MOD_DEF.CMBMUNICIPIO.Enabled = True
                MOD_DEF.TXTTELEFONO1.Enabled = True : MOD_DEF.TXTTELEFONO2.Enabled = True
                MOD_DEF.CMBSEXO.Enabled = True : MOD_DEF.FN.Enabled = True
                MOD_DEF.TXTPADRE.Enabled = True : MOD_DEF.TXTMADRE.Enabled = True
                MOD_DEF.TXTEDAD.Enabled = True : MOD_DEF.CMBTIPO.Enabled = True
                MOD_DEF.TXTSALA.Enabled = True : MOD_DEF.BTNSALA.Visible = True
                MOD_DEF.TXTPAIS.Enabled = True : MOD_DEF.DEFUNCION.Enabled = True
                MOD_DEF.HORA_DEFUNCION.Enabled = True
                MOD_DEF.TXTMEDICO.Enabled = True : MOD_DEF.TXTDIAGNOSTICO.Enabled = True
                MOD_DEF.INGRESO.Enabled = True : MOD_DEF.HORA_INGRESO.Enabled = True
                MOD_DEF.TXTREPORTE.Enabled = True : MOD_DEF.RECEPCION.Enabled = True
                MOD_DEF.HORA_RECEPCION.Enabled = True
                MOD_DEF.TXTFISCALIA.Enabled = True : MOD_DEF.FISCALIA.Enabled = True
                MOD_DEF.HORA_FISCALIA.Enabled = True
                MOD_DEF.BTNMODIFICAR.Enabled = True
                MOD_DEF.TXTIDENTIDAD.Focus()
                Me.Close()
            ElseIf DGVGENERAL.Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN ITEM CARGADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                Me.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MOD_DEF.TXTNOMBRES.Enabled = True : MOD_DEF.TXTPRIMERAPELLIDO.Enabled = True
            MOD_DEF.TXTSEGUNDOAPELLIDO.Enabled = True : MOD_DEF.TXTCORRELATIVO.Enabled = False
            MOD_DEF.TXTCOLONIA.Enabled = True : MOD_DEF.TXTCASA.Enabled = True
            MOD_DEF.CMBDEPARTAMENTO.Enabled = True : MOD_DEF.CMBMUNICIPIO.Enabled = True
            MOD_DEF.TXTTELEFONO1.Enabled = True : MOD_DEF.TXTTELEFONO2.Enabled = True
            MOD_DEF.CMBSEXO.Enabled = True : MOD_DEF.FN.Enabled = True
            MOD_DEF.TXTPADRE.Enabled = True : MOD_DEF.TXTMADRE.Enabled = True
            MOD_DEF.TXTEDAD.Enabled = True : MOD_DEF.CMBTIPO.Enabled = True
            MOD_DEF.TXTSALA.Enabled = True : MOD_DEF.BTNSALA.Visible = True
            MOD_DEF.TXTPAIS.Enabled = True : MOD_DEF.DEFUNCION.Enabled = True
            MOD_DEF.HORA_DEFUNCION.Enabled = True
            MOD_DEF.TXTMEDICO.Enabled = True : MOD_DEF.TXTDIAGNOSTICO.Enabled = True
            MOD_DEF.INGRESO.Enabled = True : MOD_DEF.HORA_INGRESO.Enabled = True
            MOD_DEF.TXTREPORTE.Enabled = True : MOD_DEF.RECEPCION.Enabled = True
            MOD_DEF.HORA_RECEPCION.Enabled = True
            MOD_DEF.TXTFISCALIA.Enabled = True : MOD_DEF.FISCALIA.Enabled = True
            MOD_DEF.HORA_FISCALIA.Enabled = True
            MOD_DEF.BTNMODIFICAR.Enabled = True
            MOD_DEF.TXTIDENTIDAD.Focus()
            Me.Close()
        End Try
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        DGVGENERAL.Columns.Clear()
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
    End Sub

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        DGVGENERAL.Columns.Clear()
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class