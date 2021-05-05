Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class AGREGAR_REFERENCIA
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Sub DEPA()
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBDEPARTAMENTO.DropDownStyle = ComboBoxStyle.DropDownList
        'CMBDEPARTAMENTO.SelectedItem = ""
        Dim DS As String = "SELECT CODIGO_DEPARTAMENTO, DEPARTAMENTO FROM DEPARTAMENTO_HONDURAS"
        Dim DA As New SqlDataAdapter(DS, CONEXION)
        Dim CMB As New DataSet
        DA.Fill(CMB)
        With CMBDEPARTAMENTO
            .DataSource = CMB.Tables(0)
            .DisplayMember = "DEPARTAMENTO"
            TXTCOD_DEPA.Text = CMB.Tables(0).Rows(0)("CODIGO_DEPARTAMENTO") 'TXTCOD_DEPA.Text = CMBDEPARTAMENTO.SelectedItem("CODIGO_DEPARTAMENTO").ToString
            '--------------------------------------------------------
        End With
    End Sub
    Private Sub AGREGAR_REFERENCIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTCENTRO.Focus()
        DEPA()
        Try
            CONE.Open()
            Dim COMANDO As String = "SELECT CENTRO, DEPARTAMENTO, MUNICIPIO, UBICACION FROM CENTRO_REFERENCIA"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            'DGVREFERENCIA.Rows.Clear()
            DGVREFERENCIA.Columns.Clear()
            If DATO.Rows.Count > 0 Then
                DGVREFERENCIA.DataSource = DATO
                DGVREFERENCIA.Columns("CENTRO").Width = 300 'DAR ANCGO A LA COLUMNA
                DGVREFERENCIA.Columns("DEPARTAMENTO").Width = 250 'DAR ANCGO A LA COLUMNA
                DGVREFERENCIA.Columns("MUNICIPIO").Width = 300 'DAR ANCGO A LA COLUMNA
                DGVREFERENCIA.Columns("UBICACION").Width = 500 'DAR ANCGO A LA COLUMNA
                DGVREFERENCIA.Columns("CENTRO").HeaderText = "CENTRO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                DGVREFERENCIA.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                DGVREFERENCIA.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                DGVREFERENCIA.Columns("UBICACION").HeaderText = "UBICACION" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVREFERENCIA.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO EXISTE NINGUN REGISTRO EN LA TABLA DE REFERENCIA, FAVOR AGREGAR EL CENTRO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
        BTNACEPTAR.Enabled = False
    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCENTRO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTCENTRO.TextChanged
        If DGVREFERENCIA.Rows.Count = 0 And (TXTCENTRO.Text <> "" Or CMBDEPARTAMENTO.Text <> "SELECCIONE" Or _
            CMBMUNICIPIO.Text <> "SELECCIONE" Or TXTDIRECCION.Text <> "") Then
            BTNACEPTAR.Enabled = True
        ElseIf DGVREFERENCIA.Rows.Count > 0 And (TXTCENTRO.Text <> "" Or CMBDEPARTAMENTO.Text <> "SELECCIONE" Or _
            CMBMUNICIPIO.Text <> "SELECCIONE" Or TXTDIRECCION.Text <> "") Then
            BTNACEPTAR.Enabled = False
        End If
        Try
            CONE.Open()
            Dim COMANDO As String = "SELECT CENTRO, DEPARTAMENTO, MUNICIPIO, UBICACION FROM CENTRO_REFERENCIA WHERE CENTRO LIKE '" _
                                    & "%" & TXTCENTRO.Text & "%" & "'"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            DGVREFERENCIA.DataSource = DATO
            DGVREFERENCIA.Columns("CENTRO").Width = 300 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("DEPARTAMENTO").Width = 250 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("MUNICIPIO").Width = 300 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("UBICACION").Width = 500 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("CENTRO").HeaderText = "CENTRO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVREFERENCIA.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVREFERENCIA.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVREFERENCIA.Columns("UBICACION").HeaderText = "UBICACION" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVREFERENCIA.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub CMBDEPARTAMENTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBDEPARTAMENTO.SelectedIndexChanged
        If DGVREFERENCIA.Rows.Count = 0 And (TXTCENTRO.Text <> "" Or CMBDEPARTAMENTO.Text <> "SELECCIONE" Or _
            CMBMUNICIPIO.Text <> "SELECCIONE" Or TXTDIRECCION.Text <> "") Then
            BTNACEPTAR.Enabled = True
        ElseIf DGVREFERENCIA.Rows.Count > 0 And (TXTCENTRO.Text <> "" Or CMBDEPARTAMENTO.Text <> "SELECCIONE" Or _
            CMBMUNICIPIO.Text <> "SELECCIONE" Or TXTDIRECCION.Text <> "") Then
            BTNACEPTAR.Enabled = False
        End If
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBDEPARTAMENTO.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_DEPARTAMENTO, DEPARTAMENTO FROM DEPARTAMENTO_HONDURAS WHERE DEPARTAMENTO ='" & CMBDEPARTAMENTO.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMAND, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "DEPARTAMENTO_HONDURAS")
        TXTCOD_DEPA.Text = CMBDEPARTAMENTO.SelectedItem("CODIGO_DEPARTAMENTO").ToString
        '---------------------------------------------------------------------------------------
        Dim ADAPTA As New SqlDataAdapter
        Dim COMAN As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE CODIGO_DEPARTAMENTO ='" & TXTCOD_DEPA.Text & "'"
        Dim DAT As DataSet
        ADAPTA = New SqlDataAdapter(COMAN, CONEXION)
        DAT = New DataSet
        ADAPTA.Fill(DAT, "MUNICIPIO_HONDURAS")
        With CMBMUNICIPIO
            .DataSource = DAT.Tables(0)
            .DisplayMember = "MUNICIPIO"
            '.ValueMember = "CODIGO_MUNICIPIO"
        End With
        'TXTCOD_MUNI.Text = CMBMUNICIPIO.SelectedItem("CODIGO_MUNICIPIO").ToString
        Try
            CONE.Open()
            Dim COMANDO As String = "SELECT CENTRO, DEPARTAMENTO, MUNICIPIO, UBICACION FROM CENTRO_REFERENCIA WHERE CENTRO LIKE '" & "%" & TXTCENTRO.Text & "%" & "' AND DEPARTAMENTO LIKE '" & "%" & CMBDEPARTAMENTO.Text & "%" & "'"
            Dim ADAPTADO As New SqlDataAdapter(COMANDO, CONE)
            Dim DA As New DataTable
            ADAPTADO.Fill(DA)
            DGVREFERENCIA.DataSource = DA
            DGVREFERENCIA.Columns("CENTRO").Width = 300 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("DEPARTAMENTO").Width = 250 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("MUNICIPIO").Width = 300 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("UBICACION").Width = 500 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("CENTRO").HeaderText = "CENTRO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVREFERENCIA.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVREFERENCIA.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVREFERENCIA.Columns("UBICACION").HeaderText = "UBICACION" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVREFERENCIA.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub CMBMUNICIPIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBMUNICIPIO.SelectedIndexChanged
        If DGVREFERENCIA.Rows.Count = 0 And (TXTCENTRO.Text <> "" Or CMBDEPARTAMENTO.Text <> "SELECCIONE" Or _
            CMBMUNICIPIO.Text <> "SELECCIONE" Or TXTDIRECCION.Text <> "") Then
            BTNACEPTAR.Enabled = True
        ElseIf DGVREFERENCIA.Rows.Count > 0 And (TXTCENTRO.Text <> "" Or CMBDEPARTAMENTO.Text <> "SELECCIONE" Or _
            CMBMUNICIPIO.Text <> "SELECCIONE" Or TXTDIRECCION.Text <> "") Then
            BTNACEPTAR.Enabled = False
        End If
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBMUNICIPIO.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTA As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE CODIGO_DEPARTAMENTO ='" & TXTCOD_DEPA.Text & "'"
        Dim DAT As DataSet
        ADAPTA = New SqlDataAdapter(COMAND, CONEXION)
        DAT = New DataSet
        ADAPTA.Fill(DAT, "MUNICIPIO_HONDURAS")
        TXTCOD_MUNI.Text = CMBMUNICIPIO.SelectedItem("CODIGO_MUNICIPIO").ToString
        '---------------------------------------------------------------------------------------
        Try
            CONE.Open()
            Dim COMANDO As String = "SELECT CENTRO, DEPARTAMENTO, MUNICIPIO, UBICACION FROM CENTRO_REFERENCIA WHERE CENTRO LIKE '" & "%" & TXTCENTRO.Text & "%" & "' AND DEPARTAMENTO LIKE '" & "%" & CMBDEPARTAMENTO.Text & "%" & "' AND MUNICIPIO LIKE '" & "%" & CMBMUNICIPIO.Text & "%" & "'"
            Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
            Dim DATO As New DataTable
            ADAPTADOR.Fill(DATO)
            DGVREFERENCIA.DataSource = DATO
            DGVREFERENCIA.Columns("CENTRO").Width = 300 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("DEPARTAMENTO").Width = 250 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("MUNICIPIO").Width = 300 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("UBICACION").Width = 500 'DAR ANCGO A LA COLUMNA
            DGVREFERENCIA.Columns("CENTRO").HeaderText = "CENTRO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVREFERENCIA.Columns("DEPARTAMENTO").HeaderText = "DEPARTAMENTO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVREFERENCIA.Columns("MUNICIPIO").HeaderText = "MUNICIPIO" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            DGVREFERENCIA.Columns("UBICACION").HeaderText = "UBICACION" 'DAR NOMBRE A LA COLUMNA CARGADA DESDE TABLA
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVREFERENCIA.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            CONE.Close()
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO LLEGAR EL CUADRO DEBIDO A:" + ex.ToString)
            CONE.Close()
        End Try
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub
    Sub VERIFICAREFERENCIA()
        Dim COMANDO As String = "SELECT CENTRO, DEPARTAMENTO, MUNICIPIO, UBICACION FROM CENTRO_REFERENCIA WHERE CENTRO ='" & TXTCENTRO.Text & "' AND DEPARTAMENTO ='" & CMBDEPARTAMENTO.Text & "' AND MUNICIPIO ='" & CMBMUNICIPIO.Text & "'"
        Dim DATO As New DataTable
        Dim ADAPTADOR As SqlDataAdapter
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        ADAPTADOR.Fill(DATO)
        Dim REFE As Boolean = False
        If TXTCENTRO.Text <> "" And CMBDEPARTAMENTO.Text <> "" And CMBMUNICIPIO.Text <> "" Then
            Try
                CONE.Open()
                If DATO.Rows.Count > 0 Then
                    For Each ROW As DataRow In DATO.Rows
                        TXTCENTRO.Text = ROW("CENTRO").ToString
                        CMBDEPARTAMENTO.Text = ROW("DEPARTAMENTO").ToString
                        CMBMUNICIPIO.Text = ROW("MUNICIPIO").ToString
                        TXTDIRECCION.Text = ROW("UBICACION").ToString
                        REFE = True
                    Next
                End If
                CONE.Close()
            Catch ex As Exception
                MsgBox("NO SE PUDO VERIFICAR")
                CONE.Close()
            End Try
        End If
        If REFE = True Then
            MsgBox("YA EXISTE EL REGISTRO FAVOR INGRESE UNA ESPECIALIDAD NUEVA")
            TXTCENTRO.Focus()
        ElseIf REFE = False Then
            GUARDAREFERENCIA()
            Me.Close()
        End If
    End Sub
    Sub GUARDAREFERENCIA()
        '---------------------------------GUARDAR EN TABLA CENTRO_REFERENCIA-------------------
        CONE.Open()
        Dim GUARDA As String = "INSERT INTO CENTRO_REFERENCIA (CENTRO, DEPARTAMENTO, MUNICIPIO, UBICACION) VALUES ('" & TXTCENTRO.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTDIRECCION.Text & "')"
        Dim COMANDO As SqlCommand
        COMANDO = New SqlCommand(GUARDA, CONE) 'INSERTAR REGISTRO EN CENTRO_REFERENCIA
        COMANDO.ExecuteNonQuery()
        MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
        CONE.Close()
        '-----------------------------------------------------------
    End Sub
    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        Dim COMANDO As String = "SELECT CENTRO, DEPARTAMENTO, MUNICIPIO, UBICACION FROM CENTRO_REFERENCIA WHERE CENTRO '" & TXTCENTRO.Text & "' AND DEPARTAMENTO '" & CMBDEPARTAMENTO.Text & "' AND MUNICIPIO '" & CMBMUNICIPIO.Text & "'"
        Dim ADAPTADOR As New SqlDataAdapter(COMANDO, CONE)
        Dim DATO As New DataTable
        If TXTCENTRO.Text <> "" And CMBDEPARTAMENTO.Text <> "" And CMBMUNICIPIO.Text <> "" Then
            Try
                ADAPTADOR.Fill(DATO)
            Catch ex As Exception
                If DGVREFERENCIA.Rows.Count > 0 Then
                    MsgBox("EL REGISTRO YA EXISTE EN LAS TABLAS", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                End If
                If DGVREFERENCIA.Rows.Count = 0 Then
                    VERIFICAREFERENCIA()
                End If
            End Try
        End If
    End Sub

    Private Sub TXTDIRECCION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDIRECCION.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTDIRECCION_TextChanged(sender As Object, e As EventArgs) Handles TXTDIRECCION.TextChanged
        If DGVREFERENCIA.Rows.Count = 0 And (TXTCENTRO.Text <> "" Or CMBDEPARTAMENTO.Text <> "SELECCIONE" Or _
            CMBMUNICIPIO.Text <> "SELECCIONE" Or TXTDIRECCION.Text <> "") Then
            BTNACEPTAR.Enabled = True
        ElseIf DGVREFERENCIA.Rows.Count > 0 And (TXTCENTRO.Text <> "" Or CMBDEPARTAMENTO.Text <> "SELECCIONE" Or _
            CMBMUNICIPIO.Text <> "SELECCIONE" Or TXTDIRECCION.Text <> "") Then
            BTNACEPTAR.Enabled = False
        End If
    End Sub
End Class