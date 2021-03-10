Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class REC_DEFUNCION
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub TXTNOMBRES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOMBRES.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
        Dim TEXTO As String = TXTNOMBRES.Text
        If TXTNOMBRES.Text.Length <= 6 Then
            If TXTNOMBRES.Text = "RN" Or TXTNOMBRES.Text = "R N" Or TXTNOMBRES.Text = "R/N" Or TXTNOMBRES.Text = "HIJO" _
                Or TXTNOMBRES.Text = "OBITO" Or TXTNOMBRES.Text = "RECIEN" Then
                e.Handled = True
                MsgBox("NO SE PERMITE PALABRAS COMO: RN, HIJO, OBITO, RECIEN AL INICIO DEL NOMBRE", MsgBoxStyle.Critical, "MENSAJE DEL SISTEMA")
                TXTNOMBRES.Text = ""
                TXTNOMBRES.Focus()
            End If
        End If
    End Sub

    Private Sub TXTNOMBRES_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBRES.TextChanged

    End Sub

    Private Sub TXTPRIMERAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRIMERAPELLIDO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTPRIMERAPELLIDO_TextChanged(sender As Object, e As EventArgs) Handles TXTPRIMERAPELLIDO.TextChanged

    End Sub

    Private Sub TXTSEGUNDOAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEGUNDOAPELLIDO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTSEGUNDOAPELLIDO_TextChanged(sender As Object, e As EventArgs) Handles TXTSEGUNDOAPELLIDO.TextChanged

    End Sub

    Private Sub TXTPAIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPAIS.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTPAIS_TextChanged(sender As Object, e As EventArgs) Handles TXTPAIS.TextChanged

    End Sub

    Private Sub TXTPADRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPADRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTPADRE_TextChanged(sender As Object, e As EventArgs) Handles TXTPADRE.TextChanged

    End Sub

    Private Sub TXTMADRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMADRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTMADRE_TextChanged(sender As Object, e As EventArgs) Handles TXTMADRE.TextChanged

    End Sub

    Private Sub TXTREMITENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSALA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTREMITENTE_TextChanged(sender As Object, e As EventArgs) Handles TXTSALA.TextChanged

    End Sub

    Private Sub TXTMEDICO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMEDICO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTMEDICO_TextChanged(sender As Object, e As EventArgs) Handles TXTMEDICO.TextChanged

    End Sub

    Private Sub TXTDIAGNOSTICO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDIAGNOSTICO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
        If CMBCLASIFICACION.Text <> "RN#1" Or CMBCLASIFICACION.Text <> "RN#2" Or CMBCLASIFICACION.Text <> "RN#3" Or _
            CMBCLASIFICACION.Text <> "OBITO_1" Or CMBCLASIFICACION.Text <> "OBITO_2" Then
            If TXTDIAGNOSTICO.Text = "OBITO" Then
                e.Handled = True
                MsgBox("VERIFIQUE LA CLASIFICACION DEL REGISTRO YA QUE NO ES PERMITIDO LA PALABRA: OBITO SI LA CLASIFICACION NO CONTIENE OBITO", MsgBoxStyle.Critical, "MENSAJE DEL SISTEMA")
                TXTDIAGNOSTICO.Text = ""
                TXTDIAGNOSTICO.Focus()
            End If
        End If
    End Sub

    Private Sub TXTDIAGNOSTICO_TextChanged(sender As Object, e As EventArgs) Handles TXTDIAGNOSTICO.TextChanged
        
    End Sub

    Private Sub TXTCOLONIA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCOLONIA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCOLONIA_TextChanged(sender As Object, e As EventArgs) Handles TXTCOLONIA.TextChanged

    End Sub

    Private Sub TXTCASA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCASA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCASA_TextChanged(sender As Object, e As EventArgs) Handles TXTCASA.TextChanged

    End Sub

    Private Sub TXTREPORTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTREPORTE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTREPORTE_TextChanged(sender As Object, e As EventArgs) Handles TXTREPORTE.TextChanged

    End Sub

    Private Sub TXTFISCALIA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTFISCALIA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTFISCALIA_TextChanged(sender As Object, e As EventArgs) Handles TXTFISCALIA.TextChanged

    End Sub
    Private Sub BTNIDENTIDAD_Click(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.Click
        BUSQUEDADEF.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        BUSQUEDADEF.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        BUSQUEDADEF.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        BUSQUEDADEF.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        BUSQUEDADEF.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        BUSQUEDADEF.CBSI.Checked = True
        BUSQUEDADEF.Show()
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
    Private Sub REC_DEFUNCION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBSEXO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBDEPARTAMENTO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBMUNICIPIO.DropDownStyle = ComboBoxStyle.DropDownList
        DEPA() 'LLAMAR METODO
        CBNORMAL.Checked = True
        DT24.Text = Format(Now, "HH:MM")
        DEFUNCION.Value = (DateTime.Now.Date)
        FN.Value = (DateTime.Now.Date)
        INGRESO.Value = (DateTime.Now.Date)
        RECEPCION.Value = (DateTime.Now.Date)
        FISCALIA.Value = (DateTime.Now.Date)
        HORA_DEFUNCION.Text = Format(Now, "hh:mm tt")
        HORA_INGRESO.Text = Format(Now, "hh:mm tt")
        HORA_RECEPCION.Text = Format(Now, "hh:mm tt")
        HORA_FISCALIA.Text = Format(Now, "hh:mm tt")
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
        CMBCLASIFICACION.Focus()
        CMBNACIONALIDAD.Items.Add("")
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

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
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

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged
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
            TXTIDENTIDAD.Enabled = False
            TXTCORRELATIVO.Enabled = True
            TXTIDENTIDAD.Text = "0000-0000-00000"
            TXTCORRELATIVO.Text = ""
            BTNIDENTIDAD.Visible = False
            BTNCORRELATIVO.Visible = True
        End If
    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            Dim TEXTO As String = TXTIDENTIDAD.Text
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
            End If
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

            If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
                e.Handled = True
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
            If e.KeyChar = "-" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
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
        BTNMODIFICAR.Enabled = False : BTNGUARDAR.Enabled = False
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
        TXTIDENTIDAD.Focus()
        TXTNOMBRES.Text = "" : TXTPRIMERAPELLIDO.Text = "" : TXTSEGUNDOAPELLIDO.Text = ""
        CMBSEXO.Text = ""
        TXTPAIS.Text = "" : TXTPADRE.Text = "" : TXTMADRE.Text = ""
        TXTEDAD.Text = "" : CMBTIPO.Text = ""
        TXTTELEFONO1.Text = "" : TXTTELEFONO2.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        HORA_DEFUNCION.Text = Format(Now, "hh:mm tt")
        HORA_INGRESO.Text = Format(Now, "hh:mm tt")
        HORA_RECEPCION.Text = Format(Now, "hh:mm tt")
        HORA_FISCALIA.Text = Format(Now, "hh:mm tt")
        DEFUNCION.Value = (DateTime.Now.Date)
        FN.Value = (DateTime.Now.Date)
        INGRESO.Value = (DateTime.Now.Date)
        RECEPCION.Value = (DateTime.Now.Date)
        FISCALIA.Value = (DateTime.Now.Date)
        TXTSALA.Text = ""
        TXTMEDICO.Text = ""
        TXTDIAGNOSTICO.Text = ""
        TXTREPORTE.Text = ""
        TXTFISCALIA.Text = ""
    End Sub

    Private Sub TXTCORRELATIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCORRELATIVO.KeyPress
        Dim TEXTO As String = TXTCORRELATIVO.Text
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
            e.Handled = True
        End If

        If TXTCORRELATIVO.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTCORRELATIVO.Text = TEXTO
            e.Handled = True
            TXTCORRELATIVO.Select(TXTCORRELATIVO.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        If TXTCORRELATIVO.Text.Length >= 8 Then
            BTNCORRELATIVO.Enabled = True
        ElseIf TXTCORRELATIVO.Text.Length <= 7 Then
            BTNCORRELATIVO.Enabled = False
        End If
        BTNMODIFICAR.Enabled = False : BTNGUARDAR.Enabled = False
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
        TXTCORRELATIVO.Focus()
        TXTNOMBRES.Text = "" : TXTPRIMERAPELLIDO.Text = "" : TXTSEGUNDOAPELLIDO.Text = ""
        CMBSEXO.Text = ""
        TXTPAIS.Text = "" : TXTPADRE.Text = "" : TXTMADRE.Text = ""
        TXTEDAD.Text = "" : CMBTIPO.Text = ""
        TXTTELEFONO1.Text = "" : TXTTELEFONO2.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        HORA_DEFUNCION.Text = Format(Now, "hh:mm tt")
        HORA_INGRESO.Text = Format(Now, "hh:mm tt")
        HORA_RECEPCION.Text = Format(Now, "hh:mm tt")
        HORA_FISCALIA.Text = Format(Now, "hh:mm tt")
        DEFUNCION.Value = (DateTime.Now.Date)
        FN.Value = (DateTime.Now.Date)
        INGRESO.Value = (DateTime.Now.Date)
        RECEPCION.Value = (DateTime.Now.Date)
        FISCALIA.Value = (DateTime.Now.Date)
        TXTSALA.Text = ""
        TXTMEDICO.Text = ""
        TXTDIAGNOSTICO.Text = ""
        TXTREPORTE.Text = ""
        TXTFISCALIA.Text = ""
    End Sub

    Private Sub FN_ValueChanged(sender As Object, e As EventArgs) Handles FN.ValueChanged
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
                TXTEDAD.ReadOnly = False
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

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNSALA_Click(sender As Object, e As EventArgs) Handles BTNSALA.Click
        SALA_DEF.Show()
    End Sub

    Private Sub BTNINGRESO_Click(sender As Object, e As EventArgs) Handles BTNINGRESO.Click
        If TXTIDENTIDAD.Text <> "0000-0000-00000" And (TXTCORRELATIVO.Text = "0000-0000" Or TXTCORRELATIVO.Text <> "0000-0000") Then
            REGISTRO.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            REGISTRO.LBTIPO.Text = CMBBUSQUEDA.Text
            REGISTRO.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            REGISTRO.LBIDENTIDAD.Text = TXTIDENTIDAD.Text
            REGISTRO.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        ElseIf TXTCORRELATIVO.Text <> "0000-0000" And (TXTIDENTIDAD.Text = "0000-0000-00000") Then
            REGISTRO.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            REGISTRO.LBTIPO.Text = CMBBUSQUEDA.Text
            REGISTRO.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            REGISTRO.LBIDENTIDAD.Text = TXTCORRELATIVO.Text
            REGISTRO.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        End If
        REGISTRO.Show()
    End Sub
    Sub GUARDAR_IDENTIDAD()
        If MsgBox("DESEA CONTINUAR CON EL PROCESO PARA ALMACENAR EL REGISTRO DE DEFUNCION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            '-------------------------------GUARDAR EN TABLA UNICO-------------------
            CONE.Open()
            Dim PAIS As String = vbNull
            If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
                PAIS = "HONDURAS"
            ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
                PAIS = TXTPAIS.Text
            End If
            Dim FECHA As String = ""
            If CBFN.Checked = True Then
                FECHA = "0101-01-01"
            ElseIf CBFN.Checked = False Then
                FECHA = Format(CDate(FN.Value), "yyyy/MM/dd")
            End If
            Dim ING As String = Format(CDate(INGRESO.Value), "yyyy/MM/dd") 'FECHA INGRESO
            Dim RECEP As String = Format(CDate(RECEPCION.Value), "yyyy/MM/dd") 'FECHA DE RECEPCION EN EL AREA
            Dim DEF As String = Format(CDate(DEFUNCION.Value), "yyyy/MM/dd") 'FECHA DE DEFUNCION
            If TXTIDENTIDAD.Text = "" Then
                TXTIDENTIDAD.Text = "0000-0000-00000"
            End If
            If TXTCORRELATIVO.Text = "" Then
                TXTCORRELATIVO.Text = "0000-0000"
            End If
            '------------------------------------------------------------
            Dim GUARDAR As String = "INSERT INTO UNICO (NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
            & "TIPO_EDAD, CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO," _
            & "NOMBRE_PADRE, NOMBRE_MADRE, FECHA_NACIMIENTO, DEFUNCION)" _
            & "VALUES ('" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
            & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
            & CMBTIPO.Text & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTCOLONIA.Text & "','" _
            & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" _
            & TXTTELEFONO2.Text & "','" & CMBSEXO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" _
            & FECHA & "','" & DEF & "')"
            Dim COMAND As SqlCommand
            COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
            COMAND.ExecuteNonQuery()
            'MsgBox("REGISTRO GUARDADO CON EXITO EN TABLA UNICO", MsgBoxStyle.Information, AcceptButton)
            CONE.Close()
            '------------------GUARDAR TABLA DEFUNCION.-----------------------
            Dim FISCAL As String = ""
            Dim HFISCAL As String = ""
            Dim CFISCAL As String = ""
            If CBVIOLENTA.Checked = True Then
                FISCAL = Format(CDate(FISCALIA.Value), "yyyy/MM/dd") 'FECHA DE FISCALIA
                HFISCAL = HORA_FISCALIA.Value
                CFISCAL = TXTFISCALIA.Text
            ElseIf CBVIOLENTA.Checked = False Then
                FISCAL = "0101-01-01"
                HFISCAL = Nothing
                CFISCAL = Nothing
            End If
            Dim TURNO As String = ""
            TURNO = LOGIN.CMBTURNO.Text
            CONE.Open()
            '------------------------------------------------------------
            Dim DEFUNCIONES As String = "INSERT INTO DEFUNCION (EMP_RECIBE, TURNO_REC, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, " _
            & "SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, PADRE, MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, " _
            & "TELEFONO1, TELEFONO2, SEXO, INGRESO, HORA_ING, RECEPCION, HORA_REC, REPORTE, FISCAL, HORA_FIS, CONTESTO, SALA_DEF, " _
            & "DEFUNCION, HORA_DEF, MEDICO, DIAGNOSTICO)" _
            & "VALUES ('" & LOGIN.TXTUSUARIO.Text & "','" & TURNO & "','" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
            & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
            & CMBTIPO.Text & "','" & FECHA & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTPADRE.Text & "','" _
            & TXTMADRE.Text & "','" & TXTCOLONIA.Text & "','" & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" _
            & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" & TXTTELEFONO2.Text & "','" & CMBSEXO.Text & "','" & ING & "','" _
            & HORA_INGRESO.Text & "','" & RECEP & "','" & HORA_RECEPCION.Text & "','" & TXTREPORTE.Text & "','" & FISCAL & "','" _
            & HFISCAL & "','" & CFISCAL & "','" & TXTSALA.Text & "','" & DEF & "','" & HORA_DEFUNCION.Text & "','" _
            & TXTMEDICO.Text & "','" & TXTDIAGNOSTICO.Text & "')"
            Dim COMANDO As SqlCommand
            COMANDO = New SqlCommand(DEFUNCIONES, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
            COMANDO.ExecuteNonQuery()
            CONE.Close()
            IMPRIMIR_DEFUNCION()
            Me.Close()
        Else
            TXTIDENTIDAD.Focus()
        End If
    End Sub
    Sub IMPRIMIR_DEFUNCION()
        If MsgBox("DESEA IMPRIMIR CONTROL DE DEFUNCION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            Dim TIPO As String = ""
            Dim REPORT As New CONTROLDEF
            If CMBTIPO.Text = "4. AÑOS" Then
                TIPO = "AÑOS"
            ElseIf CMBTIPO.Text = "3. MESES" Then
                TIPO = "MESES"
            ElseIf CMBTIPO.Text = "2. DIAS" Then
                TIPO = "DIAS"
            ElseIf CMBTIPO.Text = "1. HORAS" Then
                TIPO = "HORAS"
            End If

            Dim IDENTIDAD As String = ""
            If TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                IDENTIDAD = TXTCORRELATIVO.Text
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000" Then
                IDENTIDAD = TXTIDENTIDAD.Text
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                IDENTIDAD = TXTIDENTIDAD.Text & " / " & TXTCORRELATIVO.Text
            End If

            Dim SEXO As String = ""
            If CMBSEXO.Text = "1. HOMBRE" Then
                SEXO = "HOMBRE"
            ElseIf CMBSEXO.Text = "2. MUJER" Then
                SEXO = "MUJER"
            End If

            Dim NOMBRE As String = ""
            If CMBCLASIFICACION.Text = "NORMAL" Then
                NOMBRE = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
            ElseIf CMBCLASIFICACION.Text = "RN#1" Or CMBCLASIFICACION.Text = "RN#2" Or _
            CMBCLASIFICACION.Text = "RN#3" Then
                NOMBRE = "RN " & TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
            ElseIf CMBCLASIFICACION.Text = "OBITO_1" Or CMBCLASIFICACION.Text = "OBITO_2" Or CMBCLASIFICACION.Text = "OBITO_3" Then
                NOMBRE = "OBITO " & TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
            ElseIf CMBCLASIFICACION.Text = "HIJO_1" Or CMBCLASIFICACION.Text = "HIJO_2" Or CMBCLASIFICACION.Text = "HIJO_3" Then
                NOMBRE = "HIJO DE " & TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
            ElseIf CMBCLASIFICACION.Text = "RN_GEMELO_1" Then
                NOMBRE = "RN " & TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text & " GEMELO 1"
            ElseIf CMBCLASIFICACION.Text = "RN_GEMELO_2" Then
                NOMBRE = "RN " & TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text & " GEMELO 2"
            ElseIf CMBCLASIFICACION.Text = "RN_GEMELO_3" Then
                NOMBRE = "RN " & TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text & " GEMELO 3"
            End If

            Dim DEPA As String = ""
            Dim MUNI As String = ""
            If CMBDEPARTAMENTO.Text = "SELECCIONE" Then
                DEPA = ""
            Else
                DEPA = CMBDEPARTAMENTO.Text
            End If
            If CMBMUNICIPIO.Text = "SELECCIONE" Then
                MUNI = ""
            Else
                MUNI = CMBMUNICIPIO.Text
            End If

            REPORT.SetParameterValue("TXTNOMBRE", NOMBRE)
            REPORT.SetParameterValue("TXTSEXO", SEXO)
            REPORT.SetParameterValue("TXTEDAD", TXTEDAD.Text & " " & TIPO)
            REPORT.SetParameterValue("TXTCLINICA", IDENTIDAD)
            REPORT.SetParameterValue("TXTDIRECCION", TXTCOLONIA.Text & "," & MUNI & "," & DEPA)
            REPORT.SetParameterValue("TXTINGRESO", Format(INGRESO.Value, "dd/MMM/yyyy"))
            REPORT.SetParameterValue("TXTHORAING", Format(HORA_INGRESO.Value, "hh:mm tt"))
            REPORT.SetParameterValue("TXTSALA", TXTSALA.Text)
            REPORT.SetParameterValue("TXTFECHADEF", Format(DEFUNCION.Value, "dd/MMM/yyyy"))
            REPORT.SetParameterValue("TXTHORADEF", Format(HORA_DEFUNCION.Value, "hh:mm tt"))
            REPORT.SetParameterValue("TXTMEDICO", TXTMEDICO.Text)
            REPORT.SetParameterValue("TXTDIAGNOSTICO", TXTDIAGNOSTICO.Text)
            REPORT.SetParameterValue("TXTFECHAHORAAREA", Format(RECEPCION.Value, "dd/MMM/yyyy") & "  " & Format(HORA_RECEPCION.Value, "hh:mm tt"))
            REPORT.SetParameterValue("TXTAREA", TXTREPORTE.Text)
            If CBVIOLENTA.Checked = True Then
                REPORT.SetParameterValue("TXTFISCALIA", TXTFISCALIA.Text)
                REPORT.SetParameterValue("TXTFECHAFISCAL", Format(FISCALIA.Value, "dd/MMM/yyyy") & "  " & Format(HORA_FISCALIA.Value, "hh:mm tt"))
            ElseIf CBVIOLENTA.Checked = False Then
                REPORT.SetParameterValue("TXTFISCALIA", "")
                REPORT.SetParameterValue("TXTFECHAFISCAL", "")
            End If
            REPORT.SetParameterValue("TXTRECIBE", LOGIN.TXTUSUARIO.Text)
            REPORT.SetParameterValue("TXTRECIBETURNO", LOGIN.CMBTURNO.Text)
            'REPORT.SetParameterValue("TXTENTREGA", LOGIN.TXTUSUARIO.Text)
            'REPORT.SetParameterValue("TXTENTREGATURNO", LOGIN.CMBTURNO.Text)
            RPDEFUNCION.CrystalReportViewer1.ReportSource = REPORT
            RPDEFUNCION.CrystalReportViewer1.Refresh()
            RPDEFUNCION.Show()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If TXTNOMBRES.Text <> "" Or TXTSALA.Text <> "" Or TXTMEDICO.Text <> "" Or TXTDIAGNOSTICO.Text <> "" Or TXTREPORTE.Text <> "" Or _
            CMBSEXO.Text <> "" Then
            If (TXTIDENTIDAD.Text <> "" Or TXTCORRELATIVO.Text <> "") Or (TXTIDENTIDAD.Text = "0000-0000-00000" And _
                    TXTCORRELATIVO.Text <> "0000-0000") Then
                GUARDAR_IDENTIDAD()
            End If
        Else
            MsgBox("REVISAR LOS CAMPOS: NOMBRE, SALA, SEXO DONDE FALLECIO, NOMBRE DEL MEDICO, DIAGNOSTICO, QUIEN LO REPORTA", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
        End If
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

    Private Sub DEFUNCION_CloseUp(sender As Object, e As EventArgs) Handles DEFUNCION.CloseUp
        If Format(DEFUNCION.Value, "dd/MMM/yyyy") > DateTime.Now.Date Then
            MsgBox("NO SE PERMITE UNA FECHA SUPERIOR A LA ACTUAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            DEFUNCION.Value = (DateTime.Now.Date)
        End If
    End Sub

    Private Sub RECEPCION_CloseUp(sender As Object, e As EventArgs) Handles RECEPCION.CloseUp
        If Format(RECEPCION.Value, "dd/MMM/yyyy") > DateTime.Now.Date Then
            MsgBox("NO SE PERMITE UNA FECHA SUPERIOR A LA ACTUAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            RECEPCION.Value = (DateTime.Now.Date)
        End If
    End Sub

    Private Sub RECEPCION_ValueChanged(sender As Object, e As EventArgs) Handles RECEPCION.ValueChanged

    End Sub

    Private Sub FISCALIA_CloseUp(sender As Object, e As EventArgs) Handles FISCALIA.CloseUp
        If Format(FISCALIA.Value, "dd/MMM/yyyy") > DateTime.Now.Date Then
            MsgBox("NO SE PERMITE UNA FECHA SUPERIOR A LA ACTUAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            FISCALIA.Value = (DateTime.Now.Date)
        End If
    End Sub

    Private Sub FISCALIA_ValueChanged(sender As Object, e As EventArgs) Handles FISCALIA.ValueChanged

    End Sub

    Private Sub TXTEDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTEDAD.KeyPress
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If
    End Sub

    Private Sub TXTEDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTEDAD.TextChanged

    End Sub

    Private Sub TXTTELEFONO1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTELEFONO1.KeyPress
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

    Private Sub TXTTELEFONO1_TextChanged(sender As Object, e As EventArgs) Handles TXTTELEFONO1.TextChanged

    End Sub

    Private Sub TXTTELEFONO2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTELEFONO2.KeyPress
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

    Private Sub TXTTELEFONO2_TextChanged(sender As Object, e As EventArgs) Handles TXTTELEFONO2.TextChanged

    End Sub

    Private Sub CBNORMAL_CheckedChanged(sender As Object, e As EventArgs) Handles CBNORMAL.CheckedChanged
        If CBNORMAL.Checked = True Then
            CMBCLASIFICACION.Text = "NORMAL"
            CMBCLASIFICACION.Enabled = True
            CBVIOLENTA.Checked = False
        ElseIf CBNORMAL.Checked = False Then
            CBVIOLENTA.Checked = True
        End If
    End Sub

    Private Sub CBVIOLENTA_CheckedChanged(sender As Object, e As EventArgs) Handles CBVIOLENTA.CheckedChanged
        If CBVIOLENTA.Checked = True Then
            CMBCLASIFICACION.Text = "NORMAL"
            CMBCLASIFICACION.Enabled = True
            CBNORMAL.Checked = False
        ElseIf CBVIOLENTA.Checked = False Then
            CBNORMAL.Checked = True
        End If
    End Sub

    Private Sub BTNCORRELATIVO_Click(sender As Object, e As EventArgs) Handles BTNCORRELATIVO.Click
        BUSQUEDADEF.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        BUSQUEDADEF.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        BUSQUEDADEF.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        BUSQUEDADEF.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        BUSQUEDADEF.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        BUSQUEDADEF.CBSI.Checked = True
        BUSQUEDADEF.Show()
    End Sub
    Sub MODIFICAR_IDENTIDAD()
        If MsgBox("DESEA CONTINUAR CON EL PROCESO DE GUARDADO", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            Dim PAIS As String = vbNull
            If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
                PAIS = "HONDURAS"
            ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
                PAIS = TXTPAIS.Text
            End If
            Dim FECHA As String = ""
            If CBFN.Checked = True Then
                FECHA = "0101-01-01"
            ElseIf CBFN.Checked = False Then
                FECHA = Format(CDate(FN.Value), "yyyy/MM/dd")
            End If
            Dim ING As String = Format(CDate(INGRESO.Value), "yyyy/MM/dd") 'FECHA INGRESO
            Dim RECEP As String = Format(CDate(RECEPCION.Value), "yyyy/MM/dd") 'FECHA DE RECEPCION EN EL AREA
            Dim DEF As String = Format(CDate(DEFUNCION.Value), "yyyy/MM/dd") 'FECHA DE DEFUNCION
            If TXTIDENTIDAD.Text = "" Then
                TXTIDENTIDAD.Text = "0000-0000-00000"
            End If
            If TXTCORRELATIVO.Text = "" Then
                TXTCORRELATIVO.Text = "0000-0000"
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
                & TXTPADRE.Text & "', NOMBRE_MADRE='" & TXTMADRE.Text & "', FECHA_NACIMIENTO='" & FECHA & "', DEFUNCION='" _
                & DEF & "' WHERE TIPO='" & CMBCLASIFICACION.Text & "' AND IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
                Dim UNI As SqlCommand
                UNI = New SqlCommand(UNICO, CONE)
                UNI.ExecuteNonQuery()
                CONE.Close()
                '-------------------------------------CIERRE DE UNICO---------------------
                '-------------------------------GUARDAR EN TABLA DEFUNCION-------------------
                Dim FISCAL As String = ""
                Dim HFISCAL As String = ""
                Dim CFISCAL As String = ""
                If CBVIOLENTA.Checked = True Then
                    FISCAL = Format(CDate(FISCALIA.Value), "yyyy/MM/dd") 'FECHA DE FISCALIA
                    HFISCAL = HORA_FISCALIA.Value
                    CFISCAL = TXTFISCALIA.Text
                ElseIf CBVIOLENTA.Checked = False Then
                    FISCAL = "0101-01-01"
                    HFISCAL = Nothing
                    CFISCAL = Nothing
                End If
                Dim TURNO As String = ""
                TURNO = LOGIN.CMBTURNO.Text
                CONE.Open()
                '------------------------------------------------------------
                Dim DEFUNCIONES As String = "INSERT INTO DEFUNCION (EMP_RECIBE, TURNO_REC, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, " _
                & "SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, PADRE, MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, " _
                & "TELEFONO1, TELEFONO2, SEXO, INGRESO, HORA_ING, RECEPCION, HORA_REC, REPORTE, FISCAL, HORA_FIS, CONTESTO, SALA_DEF, " _
                & "DEFUNCION, HORA_DEF, MEDICO, DIAGNOSTICO)" _
                & "VALUES ('" & LOGIN.TXTUSUARIO.Text & "','" & TURNO & "','" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
                & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
                & CMBTIPO.Text & "','" & FECHA & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTPADRE.Text & "','" _
                & TXTMADRE.Text & "','" & TXTCOLONIA.Text & "','" & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" _
                & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" & TXTTELEFONO2.Text & "','" & CMBSEXO.Text & "','" & ING & "','" _
                & HORA_INGRESO.Text & "','" & RECEP & "','" & HORA_RECEPCION.Text & "','" & TXTREPORTE.Text & "','" & FISCAL & "','" _
                & HFISCAL & "','" & CFISCAL & "','" & TXTSALA.Text & "','" & DEF & "','" & HORA_DEFUNCION.Text & "','" _
                & TXTMEDICO.Text & "','" & TXTDIAGNOSTICO.Text & "')"
                Dim COMANDO As SqlCommand
                COMANDO = New SqlCommand(DEFUNCIONES, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
                COMANDO.ExecuteNonQuery()
                CONE.Close()
                IMPRIMIR_DEFUNCION()
                Me.Close()
                '------------------TERMINAR DE GUARDAR EN TABLA IMPRONTO---------------------
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            TXTIDENTIDAD.Focus()
        End If
    End Sub
    Sub MODIFICAR_CORRELATIVO()
        If MsgBox("DESEA CONTINUAR CON EL PROCESO DE GUARDADO", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            Dim PAIS As String = vbNull
            If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
                PAIS = "HONDURAS"
            ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
                PAIS = TXTPAIS.Text
            End If
            Dim FECHA As String = ""
            If CBFN.Checked = True Then
                FECHA = "0101-01-01"
            ElseIf CBFN.Checked = False Then
                FECHA = Format(CDate(FN.Value), "yyyy/MM/dd")
            End If
            Dim ING As String = Format(CDate(INGRESO.Value), "yyyy/MM/dd") 'FECHA INGRESO
            Dim RECEP As String = Format(CDate(RECEPCION.Value), "yyyy/MM/dd") 'FECHA DE RECEPCION EN EL AREA
            Dim DEF As String = Format(CDate(DEFUNCION.Value), "yyyy/MM/dd") 'FECHA DE DEFUNCION
            If TXTIDENTIDAD.Text = "" Then
                TXTIDENTIDAD.Text = "0000-0000-00000"
            End If
            If TXTCORRELATIVO.Text = "" Then
                TXTCORRELATIVO.Text = "0000-0000"
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
                & TXTPADRE.Text & "', NOMBRE_MADRE='" & TXTMADRE.Text & "', FECHA_NACIMIENTO='" & FECHA & "', DEFUNCION='" _
                & DEF & "' WHERE TIPO='" & CMBCLASIFICACION.Text & "' AND CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
                Dim UNI As SqlCommand
                UNI = New SqlCommand(UNICO, CONE)
                UNI.ExecuteNonQuery()
                CONE.Close()
                '-------------------------------------CIERRE DE UNICO---------------------
                '-------------------------------GUARDAR EN TABLA DEFUNCION-------------------
                Dim FISCAL As String = ""
                Dim HFISCAL As String = ""
                Dim CFISCAL As String = ""
                If CBVIOLENTA.Checked = True Then
                    FISCAL = Format(CDate(FISCALIA.Value), "yyyy/MM/dd") 'FECHA DE FISCALIA
                    HFISCAL = HORA_FISCALIA.Value
                    CFISCAL = TXTFISCALIA.Text
                ElseIf CBVIOLENTA.Checked = False Then
                    FISCAL = "0101-01-01"
                    HFISCAL = Nothing
                    CFISCAL = Nothing
                End If
                Dim TURNO As String = ""
                TURNO = LOGIN.CMBTURNO.Text
                CONE.Open()
                '------------------------------------------------------------
                Dim DEFUNCIONES As String = "INSERT INTO DEFUNCION (EMP_RECIBE, TURNO_REC, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, " _
                & "SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, FECHA_NAC, CORRELATIVO, IDENTIDAD, PADRE, MADRE, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, " _
                & "TELEFONO1, TELEFONO2, SEXO, INGRESO, HORA_ING, RECEPCION, HORA_REC, REPORTE, FISCAL, HORA_FIS, CONTESTO, SALA_DEF, " _
                & "DEFUNCION, HORA_DEF, MEDICO, DIAGNOSTICO)" _
                & "VALUES ('" & LOGIN.TXTUSUARIO.Text & "','" & TURNO & "','" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
                & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
                & CMBTIPO.Text & "','" & FECHA & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTPADRE.Text & "','" _
                & TXTMADRE.Text & "','" & TXTCOLONIA.Text & "','" & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" _
                & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" & TXTTELEFONO2.Text & "','" & CMBSEXO.Text & "','" & ING & "','" _
                & HORA_INGRESO.Text & "','" & RECEP & "','" & HORA_RECEPCION.Text & "','" & TXTREPORTE.Text & "','" & FISCAL & "','" _
                & HFISCAL & "','" & CFISCAL & "','" & TXTSALA.Text & "','" & DEF & "','" & HORA_DEFUNCION.Text & "','" _
                & TXTMEDICO.Text & "','" & TXTDIAGNOSTICO.Text & "')"
                Dim COMANDO As SqlCommand
                COMANDO = New SqlCommand(DEFUNCIONES, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
                COMANDO.ExecuteNonQuery()
                CONE.Close()
                IMPRIMIR_DEFUNCION()
                Me.Close()
                '------------------TERMINAR DE GUARDAR EN TABLA IMPRONTO---------------------
            Catch ex As Exception
                MsgBox(ex.Message)
                CONE.Close()
            End Try
        Else
            TXTCORRELATIVO.Focus()
        End If
    End Sub
    Private Sub BTNMODIFICAR_Click(sender As Object, e As EventArgs) Handles BTNMODIFICAR.Click
        If TXTNOMBRES.Text <> "" Or TXTSALA.Text <> "" Or TXTMEDICO.Text <> "" Or TXTDIAGNOSTICO.Text <> "" Or TXTREPORTE.Text <> "" Or _
            CMBSEXO.Text <> "" Then
            If (TXTCORRELATIVO.Text <> "" Or TXTCORRELATIVO.Text = "0000-0000") And (TXTIDENTIDAD.Text <> "0000-0000-00000") Then
                MODIFICAR_IDENTIDAD()
            ElseIf (TXTIDENTIDAD.Text <> "" Or TXTIDENTIDAD.Text = "0000-0000-00000") And (TXTCORRELATIVO.Text <> "0000-0000") Then
                MODIFICAR_CORRELATIVO()
            ElseIf TXTCORRELATIVO.Text <> "0000-0000" And TXTIDENTIDAD.Text <> "0000-0000-00000" And _
                TXTCORRELATIVO.Text <> "" And TXTIDENTIDAD.Text <> "" Then
                MODIFICAR_IDENTIDAD()
            End If
        Else
            MsgBox("REVISAR LOS CAMPOS: NOMBRE, SALA, SEXO DONDE FALLECIO, NOMBRE DEL MEDICO, DIAGNOSTICO, QUIEN LO REPORTO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
        End If
    End Sub

    Private Sub BTNRNP_Click(sender As Object, e As EventArgs) Handles BTNRNP.Click
        BUSCAR_CENSO.Show()
    End Sub

    Private Sub CBFN_CheckedChanged(sender As Object, e As EventArgs) Handles CBFN.CheckedChanged
        If CBFN.Checked = False Then
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            FN.Enabled = True
            TXTEDAD.Enabled = True
            CMBTIPO.Enabled = True
        ElseIf CBFN.Enabled = True Then
            FN.Enabled = False
            TXTEDAD.Enabled = False
            CMBTIPO.Enabled = False
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
        End If
    End Sub

    Private Sub DT24_ValueChanged(sender As Object, e As EventArgs) Handles DT24.ValueChanged
        LB12.Text = Format(DT24.Value, "hh tt")
    End Sub
End Class