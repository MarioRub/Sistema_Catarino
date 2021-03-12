Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CITASCEX
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            Dim TEXTO As String = TXTIDENTIDAD.Text
            If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
            End If
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNIDENTIDAD.Focus()
            End If
            If TXTIDENTIDAD.Text.Length = 4 Then
                TEXTO = TEXTO + "-" + e.KeyChar
                TXTIDENTIDAD.Text = TEXTO
                e.Handled = True
                TXTIDENTIDAD.Select(TXTIDENTIDAD.Text.Length, 0)
            End If
            If TXTIDENTIDAD.Text.Length = 9 Then
                TEXTO = TEXTO + "-" + e.KeyChar
                TXTIDENTIDAD.Text = TEXTO
                e.Handled = True
                TXTIDENTIDAD.Select(TXTIDENTIDAD.Text.Length, 0)
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
                e.Handled = True
                MsgBox("NO SE PERMITEN ESPACIOS", MsgBoxStyle.Critical, "ALERTA")
            End If
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXTIDENTIDAD.TextChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.MaxLength = 15
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNIDENTIDAD.Enabled = True
            ElseIf TXTIDENTIDAD.Text.Length < 15 Then
                BTNIDENTIDAD.Enabled = False
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
            If TXTIDENTIDAD.Text.Length >= 6 Then
                BTNIDENTIDAD.Enabled = True
            ElseIf TXTIDENTIDAD.Text.Length <= 5 Then
                BTNIDENTIDAD.Enabled = False
            End If
        End If

        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
        TXTIDENTIDAD.Focus()
        TXTNOMBRES.Text = "" : TXTPRIMERAPELLIDO.Text = "" : TXTSEGUNDOAPELLIDO.Text = ""
        CMBSEXO.Text = "" : FN.Value = DateTime.Now.Date
        TXTPAIS.Text = "" : TXTPADRE.Text = "" : TXTMADRE.Text = ""
        TXTBITACORA.Text = ""
        TXTEDAD.Text = "" : CMBTIPO.Text = ""
        TXTTELEFONO1.Text = "" : TXTTELEFONO2.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        CBNUEVO.Checked = False : CBSUBSIGUIENTE.Checked = False : CBCAMBIO.Checked = False
        CBREPROGRAMADO.Checked = False
        FECHA_FICHA.Value = DateTime.Now.Date : TXTFECHA_INCLUSION.Text = Format(DateTime.Now.Date, "dd/MMM/yyyy")
        TXTHORA.Text = UCase(Format(Now, "hh:mm:ss tt"))
        CMBESPECIALIDAD.Text = "" : TXTCLINICA.Text = "" : CMBMEDICO.Text = ""
        TXTSG.Text = "" : FECHA_CITADO.Value = DateTime.Now.Date
        TXTTOTAL.Text = "" : TXTOTORGADO.Text = ""
        CBL.Checked = False : CBM.Checked = False : CBMI.Checked = False : CBJ.Checked = False : CBV.Checked = False
        CBLUNES.Checked = False : CBMARTES.Checked = False : CBMIERCOLES.Checked = False : CBJUEVES.Checked = False
        CBVIERNES.Checked = False
        CMBDEPARTAMENTO1.Text = "SELECCIONE" : CMBMUNICIPIO1.Text = "SELECCIONE"
        TXTDIRECCIONCENTRO.Text = "" : TXTCENTRO.Text = ""
        FECHA_REFERENCIA.Value = DateTime.Now.Date
        TXTSERVICIO.Text = "" : TXTSALA.Text = ""
        TXTDIAGNOSTICO.Text = "" : TXTMEDICO.Text = ""
        TXTOBSERVACION.Text = ""
    End Sub
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
            TXTCOD_DEPA.Text = CMB.Tables(0).Rows(0)("CODIGO_DEPARTAMENTO")
            '--------------------------------------------------------
        End With
    End Sub
    Private Sub CITASCEX_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '-------MOSTRAR ETIQUETAS EMERGENTES...............
        Me.MS.IsBalloon = True
        Me.MS.SetToolTip(FN, "SELECCIONE LA FECHA DE NACIMIENTO")
        '---------FINAL ETIQUETAS EMERGENTES----------------

        Me.WindowState = FormWindowState.Maximized
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBSEXO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBREFERENCIA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBESPECIALIDAD.SelectedIndex = -1
        COMBOESPECIALIDAD()
        CMBCLASIFICACION.DropDownStyle = ComboBoxStyle.DropDownList
        CMBCLASIFICACION.Items.Add("NORMAL")
        CMBCLASIFICACION.Items.Add("RN#1")
        CMBCLASIFICACION.Items.Add("RN#2")
        CMBCLASIFICACION.Items.Add("RN#3")
        CMBCLASIFICACION.Items.Add("HIJO_1")
        CMBCLASIFICACION.Items.Add("HIJO_2")
        CMBCLASIFICACION.Items.Add("HIJO_3")
        CMBCLASIFICACION.Items.Add("OBITO_1")
        CMBCLASIFICACION.Items.Add("OBITO_2")
        CMBCLASIFICACION.Items.Add("OBITO_3")
        CMBCLASIFICACION.Items.Add("RN_GEMELO_1")
        CMBCLASIFICACION.Items.Add("RN_GEMELO_2")
        CMBCLASIFICACION.Items.Add("RN_GEMELO_3")
        CMBCLASIFICACION.SelectedIndex = 0 'SELECCIONA SIEMPRE EL PRIMER ITEM
        DEPA() 'LLAMAR METODO
        FECHA_FICHA.Value = (DateTime.Now.Date)
        FECHA_CITADO.Value = (DateTime.Now.Date)
        FECHA_REFERENCIA.Value = (DateTime.Now.Date)
        FN.Value = (DateTime.Now.Date)
        LBP.Text = "" : LBN.Text = ""
        TXTFECHA_INCLUSION.Text = DateTime.Now.Date
        TXTHORA.Text = UCase(Format(Now, "hh:mm:ss tt"))
        CMBNACIONALIDAD.Focus()
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
        CMBSEXO.Items.Add("")
        CMBSEXO.Items.Add("1. HOMBRE")
        CMBSEXO.Items.Add("2. MUJER")
        CMBBUSQUEDA.Enabled = False
        CMBBUSQUEDA.Items.Add("")
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        CMBTIPO.Items.Add("")
        CMBTIPO.Items.Add("1. HORAS")
        CMBTIPO.Items.Add("2. DIAS")
        CMBTIPO.Items.Add("3. MESES")
        CMBTIPO.Items.Add("4. AÑOS")
        CMBREFERENCIA.Items.Add("")
        CMBREFERENCIA.Items.Add("NINGUNO")
        CMBREFERENCIA.Items.Add("EXTERNA")
        CMBREFERENCIA.Items.Add("INTERNA")
        TXTEDAD.Text = ""
        CMBTIPO.Text = ""
        LBPAIS.Visible = False : TXTPAIS.Enabled = False
        CMBBUSQUEDA.Enabled = False
        BTNIDENTIDAD.Visible = False : BTNCORRELATIVO.Visible = False

        BTNGUARDA.Enabled = False : BTNCALENDARIO.Enabled = False
        BTNBITACORA.Enabled = False
        BTNGUARDAR.Enabled = False : BTNMODIFICAR.Enabled = False
        TXTPAIS.Enabled = False
        TXTIDENTIDAD.Enabled = False : TXTCORRELATIVO.Enabled = False
        TXTNOMBRES.Enabled = False : TXTPRIMERAPELLIDO.Enabled = False
        TXTSEGUNDOAPELLIDO.Enabled = False : CMBSEXO.Enabled = False
        CMBSEXO.Enabled = False : TXTPADRE.Enabled = False
        TXTMADRE.Enabled = False
        TXTBITACORA.Enabled = False : TXTEDAD.Enabled = False
        CMBTIPO.Enabled = False : TXTTELEFONO1.Enabled = False
        TXTTELEFONO2.Enabled = False
        TXTCOLONIA.Enabled = False : TXTCASA.Enabled = False
        CMBDEPARTAMENTO.Enabled = False : CMBMUNICIPIO.Enabled = False
        CMBREFERENCIA.Enabled = False : CMBDEPARTAMENTO1.Enabled = False
        CMBMUNICIPIO1.Enabled = False : TXTCENTRO.Enabled = False
        TXTDIRECCIONCENTRO.Enabled = False : TXTSERVICIO.Enabled = False
        TXTSALA.Enabled = False : TXTDIAGNOSTICO.Enabled = False
        TXTMEDICO.Enabled = False
        LBMEDICO.Text = ""
        FN.Enabled = False : FECHA_FICHA.Enabled = False : FECHA_CITADO.Enabled = False : FECHA_REFERENCIA.Enabled = False
        CBPREFERENTE.Checked = False
        CBNORMAL.Checked = False : CBLUNES.Checked = False
        CBMARTES.Checked = False : CBMIERCOLES.Checked = False
        CBJUEVES.Checked = False : CBVIERNES.Checked = False
        CBSABADO.Checked = False : CBDOMINGO.Checked = False
        CMBESPECIALIDAD.Enabled = False : TXTCLINICA.Enabled = False
        CMBMEDICO.Enabled = False
        TXTTOTAL.Enabled = False
        TXTOTORGADO.Enabled = False : TXTOBSERVACION.Enabled = False
    End Sub

    Private Sub FN_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FN.ValueChanged
        Dim HOY As Date = (DateTime.Now.Date)
        Dim AÑO, MES, DIA, HORA As Integer
        TXTEDAD.Text = ""
        CMBTIPO.Text = ""
        If FN.Value <= HOY Then
            AÑO = DateTime.Today.AddTicks(-FN.Value.Ticks).Year - 1
            MES = DateTime.Today.AddTicks(-FN.Value.Ticks).Month - 1
            DIA = DateTime.Today.AddTicks(-FN.Value.Ticks).Day - 1
            If (AÑO > 0) Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                If (MES > 0 And DIA > 0) Or (MES = 0 And DIA > 0) Then
                    TXTEDAD.Text = AÑO
                    CMBTIPO.Text = "4. AÑOS"
                ElseIf (DIA <= 0) Then
                    TXTEDAD.Text = AÑO - 1
                    CMBTIPO.Text = "4. AÑOS"
                End If
                TXTEDAD.ReadOnly = True
            ElseIf AÑO = 0 And MES > 0 Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                TXTEDAD.Text = MES
                CMBTIPO.Text = "3. MESES"
                TXTEDAD.ReadOnly = True
            ElseIf AÑO = 0 And MES = 0 And DIA > 0 Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                TXTEDAD.Text = DIA
                CMBTIPO.Text = "2. DIAS"
                TXTEDAD.ReadOnly = True
            ElseIf AÑO = 0 And MES = 0 And DIA = 0 Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                TXTEDAD.Text = HORA
                CMBTIPO.Text = "1. HORAS"
                TXTEDAD.ReadOnly = False
            End If
        ElseIf FN.Value > HOY Then
            MessageBox.Show("LA FECHA INGRESADA NO ES PERMITIDA")
            FN.Value = HOY
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            TXTEDAD.ReadOnly = True
        End If
    End Sub

    Private Sub BTNCALENDARIO_Click(sender As System.Object, e As System.EventArgs) Handles BTNCALENDARIO.Click
        CALENDARIO_CITA.CMBESPECIALIDAD.Text = Me.CMBESPECIALIDAD.Text
        CALENDARIO_CITA.CMBMEDICO.Text = Me.CMBMEDICO.Text
        CALENDARIO_CITA.LBMEDICO.Text = Me.LBMEDICO.Text
        If CBLUNES.Checked = True Then
            CALENDARIO_CITA.CBL.Checked = True
        ElseIf CBLUNES.Checked = False Then
            CALENDARIO_CITA.CBL.Checked = False
        End If
        If CBMARTES.Checked = True Then
            CALENDARIO_CITA.CBM.Checked = True
        ElseIf CBMARTES.Checked = False Then
            CALENDARIO_CITA.CBM.Checked = False
        End If
        If CBMIERCOLES.Checked = True Then
            CALENDARIO_CITA.CBMI.Checked = True
        ElseIf CBMIERCOLES.Checked = False Then
            CALENDARIO_CITA.CBMI.Checked = False
        End If
        If CBJUEVES.Checked = True Then
            CALENDARIO_CITA.CBJ.Checked = True
        ElseIf CBJUEVES.Checked = False Then
            CALENDARIO_CITA.CBJ.Checked = False
        End If
        If CBVIERNES.Checked = True Then
            CALENDARIO_CITA.CBV.Checked = True
        ElseIf CBVIERNES.Checked = False Then
            CALENDARIO_CITA.CBV.Checked = False
        End If
        CALENDARIO_CITA.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
            TXTPAIS.Text = "HONDURAS"
            LBPAIS.Visible = False : TXTPAIS.Visible = False
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
            TXTNOMBRES.Enabled = False : TXTPRIMERAPELLIDO.Enabled = False
            TXTSEGUNDOAPELLIDO.Enabled = False
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
            TXTPAIS.Text = ""
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
            LBPAIS.Visible = True : TXTPAIS.Visible = True
        End If
    End Sub

    Private Sub TXTCORRELATIVO_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCORRELATIVO.KeyPress
        Dim TEXTO As String = TXTCORRELATIVO.Text
        If Char.IsNumber(e.KeyChar) Then 'COMPARA SI ES NUMERO
            e.Handled = False 'PERMITE ESCRITURA
        ElseIf Char.IsControl(e.KeyChar) Then 'COMPARA SI TECLA ES BORAR
            e.Handled = False 'PERMITE ESCRITURA
        Else
            e.Handled = True 'NO PERMITE ESCRITURA
        End If

        If TXTCORRELATIVO.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTCORRELATIVO.Text = TEXTO
            e.Handled = True
            TXTCORRELATIVO.Select(TXTCORRELATIVO.Text.Length, 0)
        End If
    End Sub

    Private Sub FECHA_FICHA_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FECHA_FICHA.ValueChanged
        Dim HOY As Date = (DateTime.Now.Date)
        If FECHA_FICHA.Value > HOY Then
            MsgBox("LA FECHA QUE SELECCIONO NO PUEDE SER MAYOR A LA FECHA ACTUAL, FAVOR SELECCIONAR UNA FECHA DIFERENTE", MsgBoxStyle.Information, AcceptButton)
            FECHA_FICHA.Value = HOY
        ElseIf FECHA_FICHA.Value <= HOY Then
            FECHA_REFERENCIA.Value = FECHA_FICHA.Value
        End If
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBBUSQUEDA.Text = "" Then
            TXTIDENTIDAD.Enabled = False
            TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
            BTNIDENTIDAD.Visible = False
            BTNCORRELATIVO.Visible = False
        ElseIf CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTIDENTIDAD.Enabled = True
            TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = "0000-0000"
            BTNIDENTIDAD.Visible = True
            BTNCORRELATIVO.Visible = False
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTIDENTIDAD.Enabled = True
            TXTCORRELATIVO.Enabled = True
            TXTIDENTIDAD.Text = "0000-0000-00000"
            TXTCORRELATIVO.Text = ""
            BTNIDENTIDAD.Visible = False
            BTNCORRELATIVO.Visible = True
        End If
    End Sub

    Private Sub TXTTELEFONO1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTELEFONO1.KeyPress
        Dim TEXTO As String = TXTTELEFONO1.Text
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

        If TXTTELEFONO1.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTTELEFONO1.Text = TEXTO
            e.Handled = True
            TXTTELEFONO1.Select(TXTTELEFONO1.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTTELEFONO2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTELEFONO2.KeyPress
        Dim TEXTO As String = TXTTELEFONO2.Text
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

        If TXTTELEFONO2.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTTELEFONO2.Text = TEXTO
            e.Handled = True
            TXTTELEFONO2.Select(TXTTELEFONO2.Text.Length, 0)
        End If
    End Sub

    Private Sub FECHA_REFERENCIA_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FECHA_REFERENCIA.ValueChanged
        If CDate(FECHA_REFERENCIA.Value) > CDate(FECHA_FICHA.Value) Then
            MsgBox("LA FECHA QUE SELECCIONO NO PUEDE SER MAYOR A LA FECHA DE FICHA, FAVOR SELECCIONAR UNA FECHA DIFERENTE", MsgBoxStyle.Information, AcceptButton)
            FECHA_REFERENCIA.Value = FECHA_FICHA.Value
        End If
    End Sub

    Private Sub CBPREFERENTE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CBPREFERENTE.CheckedChanged
        If CBPREFERENTE.Checked = True Then
            CBNORMAL.Checked = False
        End If
    End Sub

    Private Sub CBNORMAL_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CBNORMAL.CheckedChanged
        If CBNORMAL.Checked = True Then
            CBPREFERENTE.Checked = False
        End If
    End Sub

    Private Sub BTNBITACORA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBITACORA.Click
        If TXTIDENTIDAD.Text <> "0000-0000-00000" And (TXTCORRELATIVO.Text = "0000-0000" Or TXTCORRELATIVO.Text <> "0000-0000") Then
            BITACORA_CITA.LBTIPO.Text = CMBBUSQUEDA.Text
            BITACORA_CITA.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            BITACORA_CITA.LBIDENTIDAD.Text = TXTIDENTIDAD.Text
            BITACORA_CITA.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        ElseIf TXTCORRELATIVO.Text <> "0000-0000" And (TXTIDENTIDAD.Text = "0000-0000-00000") Then
            BITACORA_CITA.LBTIPO.Text = CMBBUSQUEDA.Text
            BITACORA_CITA.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            BITACORA_CITA.LBIDENTIDAD.Text = TXTCORRELATIVO.Text
            BITACORA_CITA.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        End If
        BITACORA_CITA.Show()
    End Sub
    Sub ULTIMO_BITACORA()
        '-----------------------------------VER ULTIMO REGISTRO------------------------
        Dim CMD As New SqlCommand("SELECT * FROM BITACORA", CONE)
        Dim DA As New SqlDataAdapter(CMD)
        Dim DT As New DataTable
        'Dim ULTIMO As Long
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            TXTBITACORA.Text = 1
        ElseIf DT.Rows.Count > 0 Then
            'ULTIMO = DT.Rows.Count - 1
            'TXTBITACORA.Text = DT.Rows(ULTIMO)("NO").ToString() + 1
            TXTBITACORA.Text = DT.Rows.Count + 1
            '----------------------------------------------------------------------------
        End If
    End Sub
    Private Sub BTNIDENTIDAD_Click(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.Click
        ULTIMO_BITACORA()
        BUSQUEDACEX.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        BUSQUEDACEX.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        BUSQUEDACEX.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        BUSQUEDACEX.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        BUSQUEDACEX.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        BUSQUEDACEX.CBSI.Checked = True
        BUSQUEDACEX.Show()
    End Sub

    Private Sub CMBDEPARTAMENTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBDEPARTAMENTO.SelectedIndexChanged
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBDEPARTAMENTO.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_DEPARTAMENTO, DEPARTAMENTO FROM DEPARTAMENTO_HONDURAS WHERE DEPARTAMENTO ='" & CMBDEPARTAMENTO.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "DEPARTAMENTO_HONDURAS")
        TXTCOD_DEPA.Text = CMBDEPARTAMENTO.SelectedItem("CODIGO_DEPARTAMENTO").ToString
        '---------------------------------------------------------------------------------------
        Dim ADAPTA As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE CODIGO_DEPARTAMENTO ='" & TXTCOD_DEPA.Text & "'"
        Dim DAT As DataSet
        ADAPTA = New SqlDataAdapter(COMAND, CONEXION)
        DAT = New DataSet
        ADAPTA.Fill(DAT, "MUNICIPIO_HONDURAS")
        With CMBMUNICIPIO
            .DataSource = DAT.Tables(0)
            .DisplayMember = "MUNICIPIO"
            '.ValueMember = "CODIGO_MUNICIPIO"
        End With
        'TXTCOD_MUNI.Text = CMBMUNICIPIO.SelectedItem("CODIGO_MUNICIPIO").ToString
    End Sub

    Private Sub CMBMUNICIPIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBMUNICIPIO.SelectedIndexChanged
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBMUNICIPIO.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE CODIGO_DEPARTAMENTO ='" & TXTCOD_DEPA.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "MUNICIPIO_HONDURAS")
        TXTCOD_MUNI.Text = CMBMUNICIPIO.SelectedItem("CODIGO_MUNICIPIO").ToString
        '---------------------------------------------------------------------------------------
    End Sub

    Private Sub BTNGUARDA_Click(sender As Object, e As EventArgs) Handles BTNGUARDA.Click
        '---------------------------------GUARDAR-------------------
        If TXTIDENTIDAD.Text <> "" And TXTCORRELATIVO.Text <> "" And TXTNOMBRES.Text <> "" And TXTPRIMERAPELLIDO.Text <> "" _
            And TXTSEGUNDOAPELLIDO.Text <> "" And CMBSEXO.Text <> "" And TXTPADRE.Text <> "" And TXTMADRE.Text <> "" Then
            CONE.Open()
            Dim PAIS As String = vbNull
            If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
                PAIS = "HONDURAS"
            ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
                PAIS = TXTPAIS.Text
            End If
            'PROCESO PARA ALMACENAR LA FECHA dd/MMM/yyyy DE DATETIMEPICKER COMO 
            'FECHA Y NO COMO TEXTO ES DECIR 31/MAR./1987 COMO 31/MAR/1987
            Dim FECHA As String = Format(CDate(FN.Value), "yyyy/MM/dd")
            'Dim FECHA As String = Trim(FN.Value)
            'While FECHA.Contains(".")
            '   FECHA = FECHA.Replace(".", "")
            'End While
            Dim LUNES As String = ""
            Dim MARTES As String = ""
            Dim MIERCOLES As String = ""
            Dim JUEVES As String = ""
            Dim VIERNES As String = ""
            Dim SABADO As String = ""
            Dim DOMINGO As String = ""
            If CBLUNES.Checked = True Then
                LUNES = "SI"
            Else
                LUNES = "NO"
            End If
            If CBMARTES.Checked = True Then
                MARTES = "SI"
            Else
                MARTES = "NO"
            End If
            If CBMIERCOLES.Checked = True Then
                MIERCOLES = "SI"
            Else
                MIERCOLES = "NO"
            End If
            If CBJUEVES.Checked = True Then
                JUEVES = "SI"
            Else
                JUEVES = "NO"
            End If
            If CBVIERNES.Checked = True Then
                VIERNES = "SI"
            Else
                VIERNES = "NO"
            End If
            If CBSABADO.Checked = True Then
                SABADO = "SI"
            Else
                SABADO = "NO"
            End If
            If CBDOMINGO.Checked = True Then
                DOMINGO = "SI"
            Else
                DOMINGO = "NO"
            End If
            '------------------------------------------------------------
            Dim GUARDAR As String = "INSERT INTO UNICO (NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, " _
            & "EDAD, TIPO_EDAD, CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO," _
            & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, FECHA_NACIMIENTO, DIAGNOSTICO) VALUES ('" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" _
            & CMBCLASIFICACION.Text & "','" & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
            & CMBTIPO.Text & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTCOLONIA.Text & "','" _
            & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" _
            & TXTTELEFONO2.Text & "','" & CMBSEXO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & LUNES & "','" _
            & MARTES & "','" & MIERCOLES & "','" & JUEVES & "','" & VIERNES & "','" & SABADO & "','" & DOMINGO & "','" _
            & FECHA & "','" & TXTOBSERVACION.Text & "')"
            Dim COMAND As SqlCommand
            COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
            COMAND.ExecuteNonQuery()
            MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
            Me.Close()
            CONE.Close()
            '-----------------------------------------------------------
        End If
    End Sub

    Private Sub TXTNOMBRES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOMBRES.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
        Dim TEXTO As String = TXTNOMBRES.Text
        If TXTNOMBRES.Text.Length <= 6 Then
            If TXTNOMBRES.Text = "RN" Or TXTNOMBRES.Text = "R/N" Or TXTNOMBRES.Text = "HIJO" Or TXTNOMBRES.Text = "OBITO" Or _
                TXTNOMBRES.Text = "RECIEN" Then
                e.Handled = True
                MsgBox("NO SE PERMITE PALABRAS COMO: RN, HIJO, OBITO, RECIEN AL INICIO DEL NOMBRE", MsgBoxStyle.Critical, "MENSAJE DEL SISTEMA")
                TXTNOMBRES.Text = ""
                TXTNOMBRES.Focus()
            End If
        End If
    End Sub

    Private Sub TXTPRIMERAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRIMERAPELLIDO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTSEGUNDOAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEGUNDOAPELLIDO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTPAIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPAIS.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTPADRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPADRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTMADRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMADRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCOLONIA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCOLONIA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCASA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCASA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCENTRO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCENTRO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTDIRECCIONCENTRO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDIRECCIONCENTRO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTSERVICIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSERVICIO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTSALA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSALA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTDIAGNOSTICO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDIAGNOSTICO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTMEDICO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMEDICO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub
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
    Private Sub CMBESPECIALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBESPECIALIDAD.SelectedIndexChanged
        '----------CARGAR COMBOBOX ESPECIALIDAD------------
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        TXTCOD_ESPECIALIDAD.Text = ""
        Dim COMANDO As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES WHERE ESPECIALIDAD ='" _
                                & CMBESPECIALIDAD.Text & "' ORDER BY ESPECIALIDAD ASC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        TXTCOD_ESPECIALIDAD.Text = CMBESPECIALIDAD.SelectedItem("CODIGO_ESPECIALIDAD").ToString
        If CMBESPECIALIDAD.Text = "LABOR Y PARTO" Then
            TXTSG.Enabled = True
        Else
            TXTSG.Enabled = False
        End If
        '---------------------------------------------------------------------------------------
        '------CARGAR COMBOBOX MEDICO-----------------------
        If CMBESPECIALIDAD.SelectedIndex > 0 Then
            CONE.Open()
            Dim ADAPTA As New SqlDataAdapter
            Dim COMAND As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, HORARIO, " _
            & "LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE CODIGO_ESPECIALIDAD='" _
            & TXTCOD_ESPECIALIDAD.Text & "' AND ESTADO='ACTIVO' ORDER BY NOMBRE ASC"
            Dim CMB As DataTable
            ADAPTA = New SqlDataAdapter(COMAND, CONE)
            CMB = New DataTable
            ADAPTA.Fill(CMB)
            If DATO.Rows(0)("ESPECIALIDAD") = "ALTO RIESGO" Then
                TXTSG.Enabled = True
            Else
                TXTSG.Enabled = False
            End If
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
                TXTSG.Enabled = False
                CBL.Checked = False : CBM.Checked = False
                CBMI.Checked = False : CBJ.Checked = False : CBV.Checked = False
                CONE.Close()
            End If
        ElseIf CMBESPECIALIDAD.SelectedIndex = 0 Then
            CMBMEDICO.DataSource = Nothing
            CMBMEDICO.Items.Clear()
            TXTCLINICA.Text = ""
        End If
        '------------------------------
    End Sub

    Private Sub CMBMEDICO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBMEDICO.SelectedIndexChanged
        CMBMEDICO.DropDownStyle = ComboBoxStyle.DropDownList
        '----------CARGAR CONSULTORIO EN TXTCLINICA------------
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, HORARIO, LUNES, " _
        & "MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE NOMBRE='" _
        & CMBMEDICO.Text & "' AND ESPECIALIDAD='" & CMBESPECIALIDAD.Text & "' AND ESTADO='ACTIVO'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMAND, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        If DATO.Rows.Count > 0 Then
            TXTCLINICA.Text = CMBMEDICO.SelectedItem("CONSULTORIO").ToString
            LBMEDICO.Text = CMBMEDICO.SelectedItem("COMENTARIO").ToString & Chr(13) & "HORARIO DE ATENCION: " _
                & CMBMEDICO.SelectedItem("HORARIO").ToString & Chr(13) & "HORARIO EN TARJETA: " _
                & CMBMEDICO.SelectedItem("TARJETA").ToString
            BTNCALENDARIO.Enabled = True
            If DATO.Rows(0)("LUNES") = "SI" Then
                CBL.Checked = True
            Else
                CBL.Checked = False
            End If
            If DATO.Rows(0)("MARTES") = "SI" Then
                CBM.Checked = True
            Else
                CBM.Checked = False
            End If
            If DATO.Rows(0)("MIERCOLES") = "SI" Then
                CBMI.Checked = True
            Else
                CBMI.Checked = False
            End If
            If DATO.Rows(0)("JUEVES") = "SI" Then
                CBJ.Checked = True
            Else
                CBJ.Checked = False
            End If
            If DATO.Rows(0)("VIERNES") = "SI" Then
                CBV.Checked = True
            Else
                CBV.Checked = False
            End If
            TXTTOTAL.Text = DATO.Rows(0)("CUPO")
            FECHA_CITADO.Enabled = True
        Else
            TXTCLINICA.Text = ""
            LBMEDICO.Text = ""
            BTNCALENDARIO.Enabled = False
            FECHA_CITADO.Enabled = False
        End If
    End Sub

    Private Sub TXTSG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSG.KeyPress
        Dim TEXTO As String = TXTSG.Text
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

        If TXTSG.Text.Length = 2 Then
            TEXTO = TEXTO + "." + e.KeyChar
            TXTIDENTIDAD.Text = TEXTO
            e.Handled = True
            TXTSG.Select(TXTSG.Text.Length, 0)
        End If
    End Sub

    Private Sub FECHA_CITADO_CloseUp(sender As Object, e As EventArgs) Handles FECHA_CITADO.CloseUp
        If FECHA_CITADO.Value > (DateTime.Now.Date) Then
            'If MsgBox("ESTA SEGURO QUE ES LA FECHA QUE REQUIERE", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            If CBL.Checked = False And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "LUNES") Then
                MsgBox("EL MEDICO NO LABORA LOS LUNES, FAVOR SELECCIONE OTRA FECHA")
                FECHA_CITADO.Value = (DateTime.Now.Date)
            ElseIf CBM.Checked = False And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "MARTES") Then
                MsgBox("EL MEDICO NO LABORA LOS MARTES, FAVOR SELECCIONE OTRA FECHA")
                FECHA_CITADO.Value = (DateTime.Now.Date)
            ElseIf CBMI.Checked = False And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "MIÉRCOLES") Then
                MsgBox("EL MEDICO NO LABORA LOS MIERCOLES, FAVOR SELECCIONE OTRA FECHA")
                FECHA_CITADO.Value = (DateTime.Now.Date)
            ElseIf CBJ.Checked = False And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "JUEVES") Then
                MsgBox("EL MEDICO NO LABORA LOS JUEVES, FAVOR SELECCIONE OTRA FECHA")
                FECHA_CITADO.Value = (DateTime.Now.Date)
            ElseIf CBV.Checked = False And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "VIERNES") Then
                MsgBox("EL MEDICO NO LABORA LOS VIERNES, FAVOR SELECCIONE OTRA FECHA")
                FECHA_CITADO.Value = (DateTime.Now.Date)
            ElseIf (Format(FECHA_CITADO.Value, "dddd").ToUpper = "SÁBADO") Or _
                    (Format(FECHA_CITADO.Value, "dddd").ToUpper = "DOMINGO") Then
                MsgBox("EL MEDICO NO LABORA LOS FINES DE SEMANA, FAVOR SELECCIONAR UNA FECHA VALIDA")
                FECHA_CITADO.Value = (DateTime.Now.Date)
            End If

            If CBLUNES.Checked = True And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "LUNES") Then
                MsgBox("SELECCIONE OTRA FECHA YA QUE EL PACIENTE SE DIALISA LOS LUNES", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ElseIf CBMARTES.Checked = True And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "MARTES") Then
                MsgBox("SELECCIONE OTRA FECHA YA QUE EL PACIENTE SE DIALISA LOS MARTES", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ElseIf CBMIERCOLES.Checked = True And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "MIÉRCOLES") Then
                MsgBox("SELECCIONE OTRA FECHA YA QUE EL PACIENTE SE DIALISA LOS MIERCOLES", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ElseIf CBJUEVES.Checked = True And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "JUEVES") Then
                MsgBox("SELECCIONE OTRA FECHA YA QUE EL PACIENTE SE DIALISA LOS JUEVES", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ElseIf CBVIERNES.Checked = True And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "VIERNES") Then
                MsgBox("SELECCIONE OTRA FECHA YA QUE EL PACIENTE SE DIALISA LOS VIERNES", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ElseIf CBSABADO.Checked = True And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "SÁBADO") Then
                MsgBox("SELECCIONE OTRA FECHA YA QUE EL PACIENTE SE DIALISA LOS SÁBADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ElseIf CBDOMINGO.Checked = True And (Format(FECHA_CITADO.Value, "dddd").ToUpper = "DOMINGO") Then
                MsgBox("SELECCIONE OTRA FECHA YA QUE EL PACIENTE SE DIALISA LOS DOMINGO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End If
        ElseIf Format(FECHA_CITADO.Value, "dd/MMM/yyyy") < DateTime.Now.Date Then
            MsgBox("NO SE PERMITE UNA FECHA INFERIOR A LA ACTUAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            FECHA_CITADO.Value = (DateTime.Now.Date)
        End If

        'CONTAR LOS DIAS LABORALES.----------------------------
        Dim TOTAL As Integer
        Dim ACTUAL As Date = Format(DateTime.Now.Date, "dd/MM/yyyy")
        Dim FECHAS As Date = Format(FECHA_CITADO.Value, "dd/MM/yyyy")
        Do
            If Not ((ACTUAL.DayOfWeek = System.DayOfWeek.Sunday Or ACTUAL.DayOfWeek = System.DayOfWeek.Saturday)) Then
                TOTAL = TOTAL + 1
            End If
            ACTUAL = ACTUAL.AddDays(1)
        Loop Until ACTUAL >= FECHAS

        If TOTAL <= 15 Then
            LBN.Text = ""
            LBP.Text = TOTAL.ToString
        ElseIf TOTAL > 15 Then
            LBN.Text = TOTAL.ToString
            LBP.Text = ""
        End If
    End Sub

    Private Sub FECHA_CITADO_ValueChanged(sender As Object, e As EventArgs) Handles FECHA_CITADO.ValueChanged
        LBFECHA.Text = (Format(FECHA_CITADO.Value, "dddd")).ToUpper
    End Sub

    Private Sub CMBTIPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBTIPO.SelectedIndexChanged
        CMBTIPO.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub BTNVERIFICAR_Click(sender As Object, e As EventArgs) Handles BTNVERIFICAR.Click
        If FECHA_CITADO.Value >= Format(DateTime.Now.Date, "dd/MM/yyyy") Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim FECHA As String = Format(CDate(FECHA_CITADO.Value), "yyyy/MM/dd")
            Dim COMANDO As String = "SELECT NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, FECHA_NAC," _
                                    & "CORRELATIVO, IDENTIDAD, NOMBRE_PADRE, NOMBRE_MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, " _
                                    & "TELEFONO1, TELEFONO2,ESPECIALIDAD, MEDICO, CONSULTORIO, CUPOS, PREFERENTE, NORMAL, FECHA_FICHA, " _
                                    & "FECHA_CITADO FROM BITACORA WHERE ESPECIALIDAD ='" _
                                    & Me.CMBESPECIALIDAD.Text & "' AND MEDICO='" & Me.CMBMEDICO.Text & "' AND FECHA_CITADO='" _
                                    & FECHA & "'"
            Dim DATO As DataSet
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "BITACORA")
            Try
                If DATO.Tables(0).Rows.Count > 0 Then
                    CALENDARIO_CITA.CMBESPECIALIDAD.Text = Me.CMBESPECIALIDAD.Text
                    CALENDARIO_CITA.CMBMEDICO.Text = Me.CMBMEDICO.Text
                    CALENDARIO_CITA.LBMEDICO.Text = Me.LBMEDICO.Text
                    CALENDARIO_CITA.Show()
                ElseIf DATO.Tables(0).Rows.Count = 0 Then
                    MsgBox("NO EXISTE LA FECHA, LA PUEDE UTILIZAR")
                    TXTOTORGADO.Text = "0"
                End If
            Catch ex As Exception
                'MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub LBP_TextChanged(sender As Object, e As EventArgs) Handles LBP.TextChanged
        If LBP.Text <> "" Then
            CBPREFERENTE.Checked = True
        ElseIf LBP.Text = "" Then
            CBPREFERENTE.Checked = False
        End If
    End Sub

    Private Sub LBN_TextChanged(sender As Object, e As EventArgs) Handles LBN.TextChanged
        If LBN.Text <> "" Then
            CBNORMAL.Checked = True
        ElseIf LBN.Text = "" Then
            CBNORMAL.Checked = False
        End If
    End Sub

    Private Sub CBNUEVO_CheckedChanged(sender As Object, e As EventArgs) Handles CBNUEVO.CheckedChanged
        If CBNUEVO.Checked = True Then
            CBSUBSIGUIENTE.Checked = False
            CBREPROGRAMADO.Checked = False
            CBCAMBIO.Checked = False
        End If
    End Sub

    Private Sub CBSUBSIGUIENTE_CheckedChanged(sender As Object, e As EventArgs) Handles CBSUBSIGUIENTE.CheckedChanged
        If CBSUBSIGUIENTE.Checked = True Then
            CBNUEVO.Checked = False
            CBREPROGRAMADO.Checked = False
            CBCAMBIO.Checked = False
            CMBREFERENCIA.Text = "NINGUNO"
        End If
    End Sub

    Private Sub CBREPROGRAMADO_CheckedChanged(sender As Object, e As EventArgs) Handles CBREPROGRAMADO.CheckedChanged
        If CBREPROGRAMADO.Checked = True Then
            CBSUBSIGUIENTE.Checked = False
            CBNUEVO.Checked = False
            CBCAMBIO.Checked = False
        ElseIf CBREPROGRAMADO.Checked = True Then
            TXTCONTEO.Text = ""
        End If
        Dim TOTAL As Integer
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT IDENTIDAD, CORRELATIVO, ESPECIALIDAD, MEDICO, CONSULTORIO, PREFERENTE, NORMAL, FECHA_FICHA, " _
        & "FECHA_CITADO, HORA_INCLUSION, NUEVA, SUBSIGUIENTE, REPROGRAMACION, CAMBIO_CITA FROM BITACORA WHERE IDENTIDAD='" _
        & TXTIDENTIDAD.Text & "' AND CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        TOTAL = 0
        Try
            If DATO.Rows.Count > 0 Then
                If DATO.Rows(0)("REPROGRAMADO") = "SI" Then
                    TOTAL = TOTAL + 1
                Else
                    TOTAL = 0
                End If
            ElseIf DATO.Rows.Count = 0 Then
                TOTAL = 0
            End If
            TXTCONTEO.Text = TOTAL.ToString
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
    End Sub

    Private Sub CBCAMBIO_CheckedChanged(sender As Object, e As EventArgs) Handles CBCAMBIO.CheckedChanged
        If CBCAMBIO.Checked = True Then
            CBSUBSIGUIENTE.Checked = False
            CBREPROGRAMADO.Checked = False
            CBNUEVO.Checked = False
        End If
    End Sub

    Private Sub BTNREPROGRAMADO_Click(sender As Object, e As EventArgs) Handles BTNREPROGRAMADO.Click

    End Sub

    Sub DEPA1()
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBDEPARTAMENTO1.DropDownStyle = ComboBoxStyle.DropDownList
        'CMBDEPARTAMENTO.SelectedItem = ""
        Dim DS As String = "SELECT CODIGO_DEPARTAMENTO, DEPARTAMENTO FROM DEPARTAMENTO_HONDURAS"
        Dim DA As New SqlDataAdapter(DS, CONEXION)
        Dim CMB As New DataSet
        DA.Fill(CMB)
        With CMBDEPARTAMENTO1
            .DataSource = CMB.Tables(0)
            .DisplayMember = "DEPARTAMENTO"
            TXTCOD_DEP.Text = CMB.Tables(0).Rows(0)("CODIGO_DEPARTAMENTO")
            '--------------------------------------------------------
        End With
    End Sub
    Private Sub CMBREFERENCIA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBREFERENCIA.SelectedIndexChanged
        If CMBREFERENCIA.Text = "" Then
            BTNCENTRO.Enabled = False
            FECHA_REFERENCIA.Enabled = False
            TXTCENTRO.Enabled = False
            TXTDIRECCIONCENTRO.Enabled = False
            TXTSERVICIO.Enabled = False
            TXTSALA.Enabled = False
            TXTDIAGNOSTICO.Enabled = False
            TXTMEDICO.Enabled = False
            DEPA1()
            CMBDEPARTAMENTO1.Text = ""
            CMBMUNICIPIO1.Text = ""
            TXTCENTRO.Text = ""
            TXTDIRECCIONCENTRO.Text = ""
            FECHA_REFERENCIA.Value = (DateTime.Now.Date)
            TXTSERVICIO.Text = ""
            TXTSALA.Text = ""
            TXTDIAGNOSTICO.Text = ""
            TXTMEDICO.Text = ""
        ElseIf CMBREFERENCIA.Text = "NINGUNO" Then
            BTNCENTRO.Enabled = False
            FECHA_REFERENCIA.Enabled = True
            TXTCENTRO.Enabled = False
            TXTDIRECCIONCENTRO.Enabled = False
            TXTSERVICIO.Enabled = True
            TXTSALA.Enabled = True
            TXTDIAGNOSTICO.Enabled = False
            TXTMEDICO.Enabled = True
            DEPA1()
            CMBDEPARTAMENTO1.Text = "CORTES"
            CMBMUNICIPIO1.Text = "SAN PEDRO SULA"
            TXTCENTRO.Text = "HOSPITAL NACIONAL MARIO CATARINO RIVAS"
            TXTDIRECCIONCENTRO.Text = "BO. EL PLAYON, FRENTE MALL PEDREGAL"
            FECHA_REFERENCIA.Value = (DateTime.Now.Date)
            TXTSERVICIO.Text = ""
            TXTSALA.Text = ""
            TXTDIAGNOSTICO.Text = ""
            TXTMEDICO.Text = ""
        ElseIf CMBREFERENCIA.Text = "EXTERNA" Then
            CMBDEPARTAMENTO1.Enabled = True
            CMBMUNICIPIO1.Enabled = True
            BTNCENTRO.Enabled = True
            FECHA_REFERENCIA.Enabled = True
            TXTCENTRO.Enabled = True
            TXTDIRECCIONCENTRO.Enabled = True
            TXTSALA.Enabled = False
            TXTSERVICIO.Enabled = False
            TXTDIAGNOSTICO.Enabled = True
            TXTMEDICO.Enabled = True
            DEPA1()
            FECHA_REFERENCIA.Value = (DateTime.Now.Date)
            CMBDEPARTAMENTO1.Text = "SELECCIONE"
            CMBMUNICIPIO1.Text = "SELECCIONE"
            TXTCENTRO.Text = ""
            TXTDIRECCIONCENTRO.Text = ""
            TXTSERVICIO.Text = ""
            TXTSALA.Text = ""
            TXTDIAGNOSTICO.Text = ""
            TXTMEDICO.Text = ""
        ElseIf CMBREFERENCIA.Text = "INTERNA" Then
            BTNCENTRO.Enabled = False
            TXTCENTRO.Enabled = True
            TXTDIRECCIONCENTRO.Enabled = True
            TXTSERVICIO.Enabled = True
            TXTSALA.Enabled = True
            FECHA_REFERENCIA.Enabled = True
            TXTDIAGNOSTICO.Enabled = False
            TXTMEDICO.Enabled = True
            DEPA1()
            CMBDEPARTAMENTO1.Text = "CORTES"
            CMBMUNICIPIO1.Text = "SAN PEDRO SULA"
            TXTCENTRO.Text = "HOSPITAL NACIONAL MARIO CATARINO RIVAS"
            TXTDIRECCIONCENTRO.Text = "BO. EL PLAYON, FRENTE MALL PEDREGAL"
            FECHA_REFERENCIA.Value = (DateTime.Now.Date)
            TXTSERVICIO.Text = ""
            TXTSALA.Text = ""
            TXTDIAGNOSTICO.Text = ""
            TXTMEDICO.Text = ""
        End If
    End Sub

    Private Sub TXTCENTRO_TextChanged(sender As Object, e As EventArgs) Handles TXTCENTRO.TextChanged

    End Sub

    Private Sub CMBDEPARTAMENTO1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBDEPARTAMENTO1.SelectedIndexChanged
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBDEPARTAMENTO1.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_DEPARTAMENTO, DEPARTAMENTO FROM DEPARTAMENTO_HONDURAS WHERE DEPARTAMENTO ='" _
                                & CMBDEPARTAMENTO1.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "DEPARTAMENTO_HONDURAS")
        TXTCOD_DEP.Text = CMBDEPARTAMENTO1.SelectedItem("CODIGO_DEPARTAMENTO").ToString
        '---------------------------------------------------------------------------------------
        Dim ADAPTA As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE " _
                               & "CODIGO_DEPARTAMENTO ='" & TXTCOD_DEP.Text & "'"
        Dim DAT As DataSet
        ADAPTA = New SqlDataAdapter(COMAND, CONEXION)
        DAT = New DataSet
        ADAPTA.Fill(DAT, "MUNICIPIO_HONDURAS")
        With CMBMUNICIPIO1
            .DataSource = DAT.Tables(0)
            .DisplayMember = "MUNICIPIO"
            '.ValueMember = "CODIGO_MUNICIPIO"
        End With
        'TXTCOD_MUNI.Text = CMBMUNICIPIO.SelectedItem("CODIGO_MUNICIPIO").ToString
    End Sub

    Private Sub CMBMUNICIPIO1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBMUNICIPIO1.SelectedIndexChanged
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBMUNICIPIO.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE " _
                                & "CODIGO_DEPARTAMENTO ='" & TXTCOD_DEP.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "MUNICIPIO_HONDURAS")
        TXTCOD_MUN.Text = CMBMUNICIPIO1.SelectedItem("CODIGO_MUNICIPIO").ToString
        '---------------------------------------------------------------------------------------
    End Sub

    Private Sub BTNCENTRO_Click(sender As Object, e As EventArgs) Handles BTNCENTRO.Click
        CENTRO_REFERENCIA.TXTDEPARTAMENTO.Text = CMBDEPARTAMENTO1.Text
        CENTRO_REFERENCIA.TXTMUNICIPIO.Text = CMBMUNICIPIO1.Text
        CENTRO_REFERENCIA.Show()
    End Sub


    Private Sub TXTOBSERVACION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTOBSERVACION.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub BTNCORRELATIVO_Click(sender As Object, e As EventArgs) Handles BTNCORRELATIVO.Click
        ULTIMO_BITACORA()
        BUSQUEDACEX.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        BUSQUEDACEX.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        BUSQUEDACEX.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        BUSQUEDACEX.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        BUSQUEDACEX.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        BUSQUEDACEX.CBSI.Checked = True
        BUSQUEDACEX.Show()
    End Sub

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        If TXTCORRELATIVO.Text.Length >= 8 Then
            BTNCORRELATIVO.Enabled = True
        ElseIf TXTCORRELATIVO.Text.Length <= 7 Then
            BTNCORRELATIVO.Enabled = False
        End If
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
        TXTCORRELATIVO.Focus()
        TXTNOMBRES.Text = "" : TXTPRIMERAPELLIDO.Text = "" : TXTSEGUNDOAPELLIDO.Text = ""
        CMBSEXO.Text = "" : FN.Value = DateTime.Now.Date
        TXTPAIS.Text = "" : TXTPADRE.Text = "" : TXTMADRE.Text = ""
        TXTBITACORA.Text = ""
        TXTEDAD.Text = "" : CMBTIPO.Text = ""
        TXTTELEFONO1.Text = "" : TXTTELEFONO2.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        CBNUEVO.Checked = False : CBSUBSIGUIENTE.Checked = False : CBCAMBIO.Checked = False
        CBREPROGRAMADO.Checked = False
        FECHA_FICHA.Value = DateTime.Now.Date : TXTFECHA_INCLUSION.Text = UCase(Format(Now, "dd/MMM/yyyy"))
        TXTHORA.Text = UCase(Format(Now, "hh:mm:ss tt"))
        CMBESPECIALIDAD.Text = "" : TXTCLINICA.Text = "" : CMBMEDICO.Text = ""
        TXTSG.Text = "" : FECHA_CITADO.Value = DateTime.Now.Date
        TXTTOTAL.Text = "" : TXTOTORGADO.Text = ""
        CBL.Checked = False : CBM.Checked = False : CBMI.Checked = False : CBJ.Checked = False : CBV.Checked = False
        CBLUNES.Checked = False : CBMARTES.Checked = False : CBMIERCOLES.Checked = False : CBJUEVES.Checked = False
        CBVIERNES.Checked = False
        CMBDEPARTAMENTO1.Text = "SELECCIONE" : CMBMUNICIPIO1.Text = "SELECCIONE"
        TXTDIRECCIONCENTRO.Text = "" : TXTCENTRO.Text = ""
        FECHA_REFERENCIA.Value = DateTime.Now.Date
        TXTSERVICIO.Text = "" : TXTSALA.Text = ""
        TXTDIAGNOSTICO.Text = "" : TXTMEDICO.Text = ""
        TXTOBSERVACION.Text = ""
    End Sub
    Sub IMPRIMIR_ATENCION()
        If MsgBox("DESEA IMPRIMIR HOJA DE ATENCION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            Dim CLINICA As String = ""
            Dim REPORT As New ATENCION
            If TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CLINICA = TXTCORRELATIVO.Text
                REPORT.SetParameterValue("TXTID", LBCORRELATIVO.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000" Then
                CLINICA = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CLINICA = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            End If
            Dim NUEVO As String = Strings.Right(LOGIN.TXTIDENTIDAD.Text, 4)
            REPORT.SetParameterValue("TXTCODIGO", NUEVO)
            REPORT.SetParameterValue("TXTPRIMER", TXTPRIMERAPELLIDO.Text)
            REPORT.SetParameterValue("TXTSEGUNDO", TXTSEGUNDOAPELLIDO.Text)
            REPORT.SetParameterValue("TXTNOMBRE", TXTNOMBRES.Text)
            REPORT.SetParameterValue("TXTSEXO", CMBSEXO.Text)
            REPORT.SetParameterValue("TXTCLINICA", CLINICA)
            REPORT.SetParameterValue("TXTRESPONSABLE", TXTMADRE.Text)
            REPORT.SetParameterValue("TXTDIRECCION", TXTCOLONIA.Text & "," & CMBMUNICIPIO.Text & "," & CMBDEPARTAMENTO.Text)
            ATENCIONCEX.CrystalReportViewer1.ReportSource = REPORT
            ATENCIONCEX.CrystalReportViewer1.Refresh()
            ATENCIONCEX.Show()
        Else
            Me.Close()
        End If
    End Sub
    Sub IMPRIMIR_EVOLUCION()
        If MsgBox("DESEA IMPRIMIR HOJA DE EVOLUCION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            Dim TIPO As String = ""
            Dim REPORT As New EVOLUCION
            If CMBTIPO.Text = "4. AÑOS" Then
                TIPO = "AÑOS"
            ElseIf CMBTIPO.Text = "3. MESES" Then
                TIPO = "MESES"
            ElseIf CMBTIPO.Text = "2. DIAS" Then
                TIPO = "DIAS"
            ElseIf CMBTIPO.Text = "1. HORAS" Then
                TIPO = "HORAS"
            End If
            Dim CLINICA As String = ""
            If TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CLINICA = TXTCORRELATIVO.Text
                REPORT.SetParameterValue("TXTID", LBCORRELATIVO.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000" Then
                CLINICA = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CLINICA = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            End If
            Dim NUEVO As String = Strings.Right(LOGIN.TXTIDENTIDAD.Text, 4)
            REPORT.SetParameterValue("TXTCODIGO", NUEVO)
            REPORT.SetParameterValue("TXTPRIMER", TXTPRIMERAPELLIDO.Text)
            REPORT.SetParameterValue("TXTSEGUNDO", TXTSEGUNDOAPELLIDO.Text)
            REPORT.SetParameterValue("TXTNOMBRE", TXTNOMBRES.Text)
            REPORT.SetParameterValue("TXTSEXO", CMBSEXO.Text)
            REPORT.SetParameterValue("TXTCLINICA", CLINICA)
            REPORT.SetParameterValue("TXTEDAD", TXTEDAD.Text & Chr(13) & Chr(10) & TIPO)
            REPORT.SetParameterValue("TXTFN", Format(FN.Value, "dd/MMM/yyyy"))

            REPORT.SetParameterValue("TXTPRIME", TXTPRIMERAPELLIDO.Text)
            REPORT.SetParameterValue("TXTSEGUND", TXTSEGUNDOAPELLIDO.Text)
            REPORT.SetParameterValue("TXTNOMBR", TXTNOMBRES.Text)
            REPORT.SetParameterValue("TXTSEX", CMBSEXO.Text)
            REPORT.SetParameterValue("TXTCLINIC", CLINICA)
            REPORT.SetParameterValue("TXTEDA", TXTEDAD.Text & Chr(13) & Chr(10) & TIPO)
            RPEVOLUCION.CrystalReportViewer1.ReportSource = REPORT
            RPEVOLUCION.CrystalReportViewer1.Refresh()
            RPEVOLUCION.Show()
        Else
            Me.Close()
        End If
    End Sub
    Sub GUARDAR_IDENTIDAD()
        '-------------------------------GUARDAR EN TABLA UNICO-------------------
        CONE.Open()
        Dim PAIS As String = vbNull
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            PAIS = "HONDURAS"
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            PAIS = TXTPAIS.Text
        End If
        'PROCESO PARA ALMACENAR LA FECHA dd/MMM/yyyy DE DATETIMEPICKER COMO 
        'FECHA Y NO COMO TEXTO ES DECIR 31/MAR./1987 COMO 31/MAR/1987
        Dim FECHA As String = Format(CDate(FN.Value), "yyyy/MM/dd")
        'Dim FECHA As String = Trim(FN.Value)
        'While FECHA.Contains(".")
        '   FECHA = FECHA.Replace(".", "")
        'End While
        Dim LUNES As String = ""
        Dim MARTES As String = ""
        Dim MIERCOLES As String = ""
        Dim JUEVES As String = ""
        Dim VIERNES As String = ""
        Dim SABADO As String = ""
        Dim DOMINGO As String = ""
        If CBLUNES.Checked = True Then
            LUNES = "SI"
        Else
            LUNES = "NO"
        End If
        If CBMARTES.Checked = True Then
            MARTES = "SI"
        Else
            MARTES = "NO"
        End If
        If CBMIERCOLES.Checked = True Then
            MIERCOLES = "SI"
        Else
            MIERCOLES = "NO"
        End If
        If CBJUEVES.Checked = True Then
            JUEVES = "SI"
        Else
            JUEVES = "NO"
        End If
        If CBVIERNES.Checked = True Then
            VIERNES = "SI"
        Else
            VIERNES = "NO"
        End If
        If CBSABADO.Checked = True Then
            SABADO = "SI"
        Else
            SABADO = "NO"
        End If
        If CBDOMINGO.Checked = True Then
            DOMINGO = "SI"
        Else
            DOMINGO = "NO"
        End If
        If TXTIDENTIDAD.Text = "" Then
            TXTIDENTIDAD.Text = "0000-0000-00000"
        End If
        If TXTCORRELATIVO.Text = "" Then
            TXTCORRELATIVO.Text = "0000-0000"
        End If
        '------------------------------------------------------------
        Dim GUARDAR As String = "INSERT INTO UNICO (NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
        & "TIPO_EDAD, CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO," _
        & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, FECHA_NACIMIENTO, DIAGNOSTICO)" _
        & "VALUES ('" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & "','" & CMBCLASIFICACION.Text & "','" _
        & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
        & CMBTIPO.Text & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTCOLONIA.Text & "','" _
        & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" _
        & TXTTELEFONO2.Text & "','" & CMBSEXO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & LUNES & "','" _
        & MARTES & "','" & MIERCOLES & "','" & JUEVES & "','" & VIERNES & "','" & SABADO & "','" & DOMINGO & "','" _
        & FECHA & "','" & TXTOBSERVACION.Text & "')"
        Dim COMAND As SqlCommand
        COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
        COMAND.ExecuteNonQuery()
        'MsgBox("REGISTRO GUARDADO CON EXITO EN TABLA UNICO", MsgBoxStyle.Information, AcceptButton)
        CONE.Close()
        '------------------TERMINAR DE GUARDAR EN TABLA UNICO---------------------
        '-------------------------------GUARDAR EN TABLA BITACORA-------------------
        CONE.Open()
        Dim PRE As String = ""
        Dim NOR As String = ""
        Dim NUEVA As String = ""
        Dim SUBSI As String = ""
        Dim CAMBIO As String = ""
        Dim REPRO As String = ""

        If CBPREFERENTE.Checked = True Then
            PRE = "SI"
        Else
            PRE = "NO"
        End If
        If CBNORMAL.Checked = True Then
            NOR = "SI"
        Else
            NOR = "NO"
        End If
        Dim FICHA As String = Format(CDate(FECHA_FICHA.Value), "yyyy/MM/dd")
        Dim CITADO As String = Format(CDate(FECHA_CITADO.Value), "yyyy/MM/dd")
        Dim REFERENCIA As String = Format(CDate(FECHA_REFERENCIA.Value), "yyyy/MM/dd")
        If CBNUEVO.Checked = True Then
            NUEVA = "SI"
        Else
            NUEVA = "NO"
        End If
        If CBSUBSIGUIENTE.Checked = True Then
            SUBSI = "SI"
        Else
            SUBSI = "NO"
        End If
        If CBCAMBIO.Checked = True Then
            CAMBIO = "SI"
        Else
            CAMBIO = "NO"
        End If
        If CBREPROGRAMADO.Checked = True Then
            REPRO = "SI"
        Else
            REPRO = "NO"
        End If
        Dim INCLUSION As String = Format(CDate(TXTFECHA_INCLUSION.Text), "yyyy/MM/dd")
        '------------------------------------------------------------
        Dim BITACORA As String = "INSERT INTO BITACORA (IDENTIDAD_EMPLEADO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
        & "TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, NOMBRE_PADRE, NOMBRE_MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, ESPECIALIDAD," _
        & "MEDICO, CONSULTORIO, CUPOS, PREFERENTE, NORMAL, FECHA_FICHA, FECHA_CITADO, MOTIVO, FECHA_INCLUSION, HORA_INCLUSION, FECHA_REFERENCIA, NUEVA, SUBSIGUIENTE," _
        & "REPROGRAMACION, CAMBIO_CITA, SEXO, CENTRO_REFIERE, DIAGNOSTICO, SERVICIO, SALA, COLONIA_CENTRO, DEPA_CENTRO, MUNI_CENTRO)" _
        & "VALUES ('" & LOGIN.TXTIDENTIDAD.Text & "','" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
        & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
        & CMBTIPO.Text & "','" & FECHA & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & TXTCOLONIA.Text & "','" _
        & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" _
        & TXTTELEFONO2.Text & "','" & CMBESPECIALIDAD.Text & "','" & CMBMEDICO.Text & "','" & TXTCLINICA.Text & "','" _
        & TXTTOTAL.Text & "','" & PRE & "','" & NOR & "','" & FICHA & "','" & CITADO & "','" & TXTOBSERVACION.Text & "','" _
        & INCLUSION & "','" & TXTHORA.Text & "','" & REFERENCIA & "','" & NUEVA & "','" _
        & SUBSI & "','" & REPRO & "','" & CAMBIO & "','" & CMBSEXO.Text & "','" _
        & TXTCENTRO.Text & "','" & TXTDIAGNOSTICO.Text & "','" & TXTSERVICIO.Text & "','" _
        & TXTSALA.Text & "','" & TXTDIRECCIONCENTRO.Text & "','" & CMBDEPARTAMENTO1.Text & "','" _
        & CMBMUNICIPIO1.Text & "')"
        Dim COMANDO As SqlCommand
        COMANDO = New SqlCommand(BITACORA, CONE) 'INSERTAR REGISTRO EN TABLA BITACORA
        COMANDO.ExecuteNonQuery()
        MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
        CONE.Close()
        IMPRIMIR_EVOLUCION()
        IMPRIMIR_ATENCION()
        Me.Close()
        '------------------TERMINAR DE GUARDAR EN TABLA BITACORA---------------------
    End Sub
    Sub MODIFICAR_IDENTIDAD()
        Dim LUNES As String = ""
        Dim MARTES As String = ""
        Dim MIERCOLES As String = ""
        Dim JUEVES As String = ""
        Dim VIERNES As String = ""
        Dim SABADO As String = ""
        Dim DOMINGO As String = ""
        If CBLUNES.Checked = True Then
            LUNES = "SI"
        Else
            LUNES = "NO"
        End If
        If CBMARTES.Checked = True Then
            MARTES = "SI"
        Else
            MARTES = "NO"
        End If
        If CBMIERCOLES.Checked = True Then
            MIERCOLES = "SI"
        Else
            MIERCOLES = "NO"
        End If
        If CBJUEVES.Checked = True Then
            JUEVES = "SI"
        Else
            JUEVES = "NO"
        End If
        If CBVIERNES.Checked = True Then
            VIERNES = "SI"
        Else
            VIERNES = "NO"
        End If
        If CBSABADO.Checked = True Then
            SABADO = "SI"
        Else
            SABADO = "NO"
        End If
        If CBDOMINGO.Checked = True Then
            DOMINGO = "SI"
        Else
            DOMINGO = "NO"
        End If
        If TXTCORRELATIVO.Text = "" Then
            TXTCORRELATIVO.Text = "0000-0000"
        End If
        Dim FECHA As String = Format(CDate(FN.Value), "yyyy/MM/dd")
        Dim PAIS As String = vbNull
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            PAIS = "HONDURAS"
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            PAIS = TXTPAIS.Text
        End If
        Try
            '---------------------------------GUARDAR-------------------
            CONE.Open()
            Dim UNICO As String = "UPDATE UNICO SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBCLASIFICACION.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', CORRELATIVO='" _
            & TXTCORRELATIVO.Text & "', IDENTIDAD='" & TXTIDENTIDAD.Text & "', COLONIA='" & TXTCOLONIA.Text & "', CASA='" _
            & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" & CMBMUNICIPIO.Text & "', TELEFONO1='" _
            & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "', NOMBRE_PADRE='" _
            & TXTPADRE.Text & "', NOMBRE_MADRE='" & TXTMADRE.Text & "', LUNES='" & LUNES & "', MARTES='" & MARTES & "', MIERCOLES='" _
            & MIERCOLES & "', JUEVES='" & JUEVES & "', VIERNES='" & VIERNES & "', SABADO='" & SABADO & "', DOMINGO='" _
            & DOMINGO & "', FECHA_NACIMIENTO='" & FECHA & "', DIAGNOSTICO='" & TXTOBSERVACION.Text & "' WHERE TIPO ='" _
            & CMBCLASIFICACION.Text & "' AND IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
            Dim UNI As SqlCommand
            UNI = New SqlCommand(UNICO, CONE)
            UNI.ExecuteNonQuery()
            CONE.Close()
            '-------------------------------GUARDAR EN TABLA BITACORA-------------------
            CONE.Open()
            Dim PRE As String = ""
            Dim NOR As String = ""
            Dim NUEVA As String = ""
            Dim SUBSI As String = ""
            Dim CAMBIO As String = ""
            Dim REPRO As String = ""

            If CBPREFERENTE.Checked = True Then
                PRE = "SI"
            Else
                PRE = "NO"
            End If
            If CBNORMAL.Checked = True Then
                NOR = "SI"
            Else
                NOR = "NO"
            End If
            If CBNUEVO.Checked = True Then
                NUEVA = "SI"
            Else
                NUEVA = "NO"
            End If
            If CBSUBSIGUIENTE.Checked = True Then
                SUBSI = "SI"
            Else
                SUBSI = "NO"
            End If
            If CBCAMBIO.Checked = True Then
                CAMBIO = "SI"
            Else
                CAMBIO = "NO"
            End If
            If CBREPROGRAMADO.Checked = True Then
                REPRO = "SI"
            Else
                REPRO = "NO"
            End If
            Dim FICHA As String = Format(CDate(FECHA_FICHA.Value), "yyyy/MM/dd")
            Dim CITADO As String = Format(CDate(FECHA_CITADO.Value), "yyyy/MM/dd")
            Dim REFERENCIA As String = Format(CDate(FECHA_REFERENCIA.Value), "yyyy/MM/dd")
            Dim INCLUSION As String = Format(CDate(TXTFECHA_INCLUSION.Text), "yyyy/MM/dd")
            '------------------------------------------------------------
            Dim BITACORA As String = "INSERT INTO BITACORA (IDENTIDAD_EMPLEADO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
            & "TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, NOMBRE_PADRE, NOMBRE_MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, ESPECIALIDAD," _
            & "MEDICO, CONSULTORIO, CUPOS, PREFERENTE, NORMAL, FECHA_FICHA, FECHA_CITADO, MOTIVO, FECHA_INCLUSION, HORA_INCLUSION, FECHA_REFERENCIA, NUEVA, SUBSIGUIENTE," _
            & "REPROGRAMACION, CAMBIO_CITA, SEXO, CENTRO_REFIERE, DIAGNOSTICO, SERVICIO, SALA, COLONIA_CENTRO, DEPA_CENTRO, MUNI_CENTRO)" _
            & "VALUES ('" & LOGIN.TXTIDENTIDAD.Text & "','" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
            & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
            & CMBTIPO.Text & "','" & FECHA & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & TXTCOLONIA.Text & "','" _
            & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" _
            & TXTTELEFONO2.Text & "','" & CMBESPECIALIDAD.Text & "','" & CMBMEDICO.Text & "','" & TXTCLINICA.Text & "','" _
            & TXTTOTAL.Text & "','" & PRE & "','" & NOR & "','" & FICHA & "','" & CITADO & "','" & TXTOBSERVACION.Text & "','" _
            & INCLUSION & "','" & TXTHORA.Text & "','" & REFERENCIA & "','" & NUEVA & "','" _
            & SUBSI & "','" & REPRO & "','" & CAMBIO & "','" & CMBSEXO.Text & "','" _
            & TXTCENTRO.Text & "','" & TXTDIAGNOSTICO.Text & "','" & TXTSERVICIO.Text & "','" _
            & TXTSALA.Text & "','" & TXTDIRECCIONCENTRO.Text & "','" & CMBDEPARTAMENTO1.Text & "','" _
            & CMBMUNICIPIO1.Text & "')"
            Dim COMANDO As SqlCommand
            COMANDO = New SqlCommand(BITACORA, CONE) 'INSERTAR REGISTRO EN TABLA BITACORA
            COMANDO.ExecuteNonQuery()
            'MsgBox("REGISTRO GUARDADO CON EXITO EN TABLA BITACORA", MsgBoxStyle.Information, AcceptButton)
            'Me.Close()
            CONE.Close()
            '------------------TERMINAR DE GUARDAR EN TABLA BITACORA---------------------
            '-----------------------------------------------------------
            MsgBox("REGISTRO ALMACENADO CON EXITO", MsgBoxStyle.Information, "MENSAJE DEL SISTEMA")
            IMPRIMIR_EVOLUCION()
            IMPRIMIR_ATENCION()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONE.Close()
        End Try
    End Sub
    Sub MODIFICAR_CORRELATIVO()
        Dim LUNES As String = ""
        Dim MARTES As String = ""
        Dim MIERCOLES As String = ""
        Dim JUEVES As String = ""
        Dim VIERNES As String = ""
        Dim SABADO As String = ""
        Dim DOMINGO As String = ""
        If CBLUNES.Checked = True Then
            LUNES = "SI"
        Else
            LUNES = "NO"
        End If
        If CBMARTES.Checked = True Then
            MARTES = "SI"
        Else
            MARTES = "NO"
        End If
        If CBMIERCOLES.Checked = True Then
            MIERCOLES = "SI"
        Else
            MIERCOLES = "NO"
        End If
        If CBJUEVES.Checked = True Then
            JUEVES = "SI"
        Else
            JUEVES = "NO"
        End If
        If CBVIERNES.Checked = True Then
            VIERNES = "SI"
        Else
            VIERNES = "NO"
        End If
        If CBSABADO.Checked = True Then
            SABADO = "SI"
        Else
            SABADO = "NO"
        End If
        If CBDOMINGO.Checked = True Then
            DOMINGO = "SI"
        Else
            DOMINGO = "NO"
        End If
        If TXTIDENTIDAD.Text = "" Then
            TXTIDENTIDAD.Text = "0000-0000-00000"
        End If
        Dim FECHA As String = Format(CDate(FN.Value), "yyyy/MM/dd")
        Dim PAIS As String = vbNull
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            PAIS = "HONDURAS"
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            PAIS = TXTPAIS.Text
        End If
        Try
            '---------------------------------GUARDAR-------------------
            CONE.Open()
            Dim UNICO As String = "UPDATE UNICO SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBCLASIFICACION.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', CORRELATIVO='" _
            & TXTCORRELATIVO.Text & "', IDENTIDAD='" & TXTIDENTIDAD.Text & "', COLONIA='" & TXTCOLONIA.Text & "', CASA='" _
            & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" & CMBMUNICIPIO.Text & "', TELEFONO1='" _
            & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "', NOMBRE_PADRE='" _
            & TXTPADRE.Text & "', NOMBRE_MADRE='" & TXTMADRE.Text & "', LUNES='" & LUNES & "', MARTES='" & MARTES & "', MIERCOLES='" _
            & MIERCOLES & "', JUEVES='" & JUEVES & "', VIERNES='" & VIERNES & "', SABADO='" & SABADO & "', DOMINGO='" _
            & DOMINGO & "', FECHA_NACIMIENTO='" & FECHA & "', DIAGNOSTICO='" & TXTOBSERVACION.Text & "' WHERE TIPO='" _
            & CMBCLASIFICACION.Text & "' AND CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
            Dim UNI As SqlCommand
            UNI = New SqlCommand(UNICO, CONE)
            UNI.ExecuteNonQuery()
            CONE.Close()
            '-------------------------------GUARDAR EN TABLA BITACORA-------------------
            CONE.Open()
            Dim PRE As String = ""
            Dim NOR As String = ""
            Dim NUEVA As String = ""
            Dim SUBSI As String = ""
            Dim CAMBIO As String = ""
            Dim REPRO As String = ""

            If CBPREFERENTE.Checked = True Then
                PRE = "SI"
            Else
                PRE = "NO"
            End If
            If CBNORMAL.Checked = True Then
                NOR = "SI"
            Else
                NOR = "NO"
            End If
            Dim FICHA As String = Format(CDate(FECHA_FICHA.Value), "yyyy/MM/dd")
            Dim CITADO As String = Format(CDate(FECHA_CITADO.Value), "yyyy/MM/dd")
            Dim REFERENCIA As String = Format(CDate(FECHA_REFERENCIA.Value), "yyyy/MM/dd")
            If CBNUEVO.Checked = True Then
                NUEVA = "SI"
            Else
                NUEVA = "NO"
            End If
            If CBSUBSIGUIENTE.Checked = True Then
                SUBSI = "SI"
            Else
                SUBSI = "NO"
            End If
            If CBCAMBIO.Checked = True Then
                CAMBIO = "SI"
            Else
                CAMBIO = "NO"
            End If
            If CBREPROGRAMADO.Checked = True Then
                REPRO = "SI"
            Else
                REPRO = "NO"
            End If
            Dim INCLUSION As String = Format(CDate(TXTFECHA_INCLUSION.Text), "yyyy/MM/dd")
            '------------------------------------------------------------
            Dim BITACORA As String = "INSERT INTO BITACORA (IDENTIDAD_EMPLEADO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
            & "TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, NOMBRE_PADRE, NOMBRE_MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, ESPECIALIDAD," _
            & "MEDICO, CONSULTORIO, CUPOS, PREFERENTE, NORMAL, FECHA_FICHA, FECHA_CITADO, MOTIVO, FECHA_INCLUSION, HORA_INCLUSION, FECHA_REFERENCIA, NUEVA, SUBSIGUIENTE," _
            & "REPROGRAMACION, CAMBIO_CITA, SEXO, CENTRO_REFIERE, DIAGNOSTICO, SERVICIO, SALA, COLONIA_CENTRO, DEPA_CENTRO, MUNI_CENTRO)" _
            & "VALUES ('" & LOGIN.TXTIDENTIDAD.Text & "','" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
            & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
            & CMBTIPO.Text & "','" & FECHA & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & TXTCOLONIA.Text & "','" _
            & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" _
            & TXTTELEFONO2.Text & "','" & CMBESPECIALIDAD.Text & "','" & CMBMEDICO.Text & "','" & TXTCLINICA.Text & "','" _
            & TXTTOTAL.Text & "','" & PRE & "','" & NOR & "','" & FICHA & "','" & CITADO & "','" & TXTOBSERVACION.Text & "','" _
            & INCLUSION & "','" & TXTHORA.Text & "','" & REFERENCIA & "','" & NUEVA & "','" _
            & SUBSI & "','" & REPRO & "','" & CAMBIO & "','" & CMBSEXO.Text & "','" _
            & TXTCENTRO.Text & "','" & TXTDIAGNOSTICO.Text & "','" & TXTSERVICIO.Text & "','" _
            & TXTSALA.Text & "','" & TXTDIRECCIONCENTRO.Text & "','" & CMBDEPARTAMENTO1.Text & "','" _
            & CMBMUNICIPIO1.Text & "')"
            Dim COMANDO As SqlCommand
            COMANDO = New SqlCommand(BITACORA, CONE) 'INSERTAR REGISTRO EN TABLA BITACORA
            COMANDO.ExecuteNonQuery()
            'MsgBox("REGISTRO GUARDADO CON EXITO EN TABLA BITACORA", MsgBoxStyle.Information, AcceptButton)
            'Me.Close()
            CONE.Close()
            '------------------TERMINAR DE GUARDAR EN TABLA BITACORA---------------------
            '-----------------------------------------------------------
            MsgBox("REGISTRO ALMACENADO CON EXITO", MsgBoxStyle.Information, "MENSAJE DEL SISTEMA")
            IMPRIMIR_EVOLUCION()
            IMPRIMIR_ATENCION()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONE.Close()
        End Try
    End Sub
    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If CBPREFERENTE.Checked = True Or CBNORMAL.Checked = True Then
            If (CBNUEVO.Checked = True Or CBCAMBIO.Checked = True Or CBREPROGRAMADO.Checked = True _
                Or CBSUBSIGUIENTE.Checked = True) Then
                If TXTIDENTIDAD.Text <> "" Or TXTCORRELATIVO.Text <> "" Or (TXTIDENTIDAD.Text = "0000-0000-00000" And _
                    TXTCORRELATIVO.Text <> "0000-0000") Then
                    GUARDAR_IDENTIDAD()
                End If
            ElseIf (CBNUEVO.Checked = False And CBCAMBIO.Checked = False And CBREPROGRAMADO.Checked = False _
                    And CBSUBSIGUIENTE.Checked = False) Then
                MsgBox("FAVOR SELECCIONAR CUALQUIER ITEM QUE CORRESPONDE AL TIPO DE CITA: NUEVO, SUBSIGUIENTE, CAMBIO DE CITA, REPROGRAMADO", MsgBoxStyle.Critical, "SISTEMA ADMISION")
            End If
        ElseIf CBPREFERENTE.Checked = False And CBNORMAL.Checked = False Then
            MsgBox("FAVOR SELECCIONAR EL TIPO DE PRIORIDAD CLINICA", MsgBoxStyle.Critical, "SISTEMA ADMISION")
        End If
    End Sub

    Private Sub BTNMODIFICAR_Click(sender As Object, e As EventArgs) Handles BTNMODIFICAR.Click
        If CBPREFERENTE.Checked = True Or CBNORMAL.Checked = True Then
            If (CBNUEVO.Checked = True Or CBCAMBIO.Checked = True Or CBREPROGRAMADO.Checked = True _
                    Or CBSUBSIGUIENTE.Checked = True) Then
                If (TXTCORRELATIVO.Text <> "" Or TXTCORRELATIVO.Text = "0000-0000") And (TXTIDENTIDAD.Text <> "0000-0000-00000") _
                    And (CBNUEVO.Checked = True Or CBCAMBIO.Checked = True Or CBREPROGRAMADO.Checked = True _
                    Or CBSUBSIGUIENTE.Checked = True) Then
                    MODIFICAR_IDENTIDAD()
                ElseIf (TXTIDENTIDAD.Text <> "" Or TXTIDENTIDAD.Text = "0000-0000-00000") And (TXTCORRELATIVO.Text <> "0000-0000") _
                    And (CBNUEVO.Checked = True Or CBCAMBIO.Checked = True Or CBREPROGRAMADO.Checked = True _
                    Or CBSUBSIGUIENTE.Checked = True) Then
                    MODIFICAR_CORRELATIVO()
                ElseIf TXTCORRELATIVO.Text <> "0000-0000" And TXTIDENTIDAD.Text <> "0000-0000-00000" And _
                    TXTCORRELATIVO.Text <> "" And TXTIDENTIDAD.Text <> "" Then
                    MODIFICAR_IDENTIDAD()
                End If
            ElseIf (CBNUEVO.Checked = False And CBCAMBIO.Checked = False And CBREPROGRAMADO.Checked = False _
                    And CBSUBSIGUIENTE.Checked = False) Then
                MsgBox("FAVOR SELECCIONAR CUALQUIER ITEM QUE CORRESPONDE AL TIPO DE CITA: NUEVO, SUBSIGUIENTE, CAMBIO DE CITA, REPROGRAMADO")
            End If
        ElseIf CBPREFERENTE.Checked = False And CBNORMAL.Checked = False Then
            MsgBox("FAVOR SELECCIONAR EL TIPO DE PRIORIDAD CLINICA", MsgBoxStyle.Critical, "SISTEMA ADMISION")
        End If
    End Sub

    Private Sub BTNRNP_Click(sender As Object, e As EventArgs) Handles BTNRNP.Click
        BUSCAR_CENSO.Show()
    End Sub

    Private Sub CMBCLASIFICACION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBCLASIFICACION.SelectedIndexChanged
        CMBCLASIFICACION.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBCLASIFICACION.Text <> "" Then
            CMBNACIONALIDAD.Enabled = True
            CMBNACIONALIDAD.Text = ""
            CMBBUSQUEDA.Text = ""
        End If
        If CMBCLASIFICACION.Text = "NORMAL" Then
            LBTIPO.Text = "NORMAL = POSEE IDENTIDAD"
        ElseIf CMBCLASIFICACION.Text = "RN#1" Or CMBCLASIFICACION.Text = "RN#2" Or _
            CMBCLASIFICACION.Text = "RN#3" Then
            LBTIPO.Text = "RECIEN NACIDO"
        ElseIf CMBCLASIFICACION.Text = "OBITO_1" Or CMBCLASIFICACION.Text = "OBITO_2" Or CMBCLASIFICACION.Text = "OBITO_3" Then
            LBTIPO.Text = "OBITO"
        ElseIf CMBCLASIFICACION.Text = "HIJO_1" Or CMBCLASIFICACION.Text = "HIJO_2" Or CMBCLASIFICACION.Text = "HIJO_3" Then
            LBTIPO.Text = "HIJO"
        ElseIf CMBCLASIFICACION.Text = "RN_GEMELO_1" Or CMBCLASIFICACION.Text = "RN_GEMELO_2" Or CMBCLASIFICACION.Text = "RN_GEMELO_3" Then
            LBTIPO.Text = "RECIEN NACIDO GEMELO"
        End If
    End Sub

    Private Sub TXTSG_TextChanged(sender As Object, e As EventArgs) Handles TXTSG.TextChanged

    End Sub
End Class