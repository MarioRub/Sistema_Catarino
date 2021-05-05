Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class IMPRONTO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
        Me.Dispose()
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
            TXTCOD_DEPA.Text = CMB.Tables(0).Rows(0)("CODIGO_DEPARTAMENTO") 'TXTCOD_DEPA.Text = CMBDEPARTAMENTO.SelectedItem("CODIGO_DEPARTAMENTO").ToString
            '--------------------------------------------------------
        End With
    End Sub
    Private Sub FN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FN.ValueChanged
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
    Sub ULTIMO_BITACORA()
        '-----------------------------------VER ULTIMO REGISTRO------------------------
        Dim CMD As New SqlCommand("SELECT * FROM IMPRONTO", CONE)
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
    Private Sub IMPRONTO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        INGRESO.Value = (DateTime.Now.Date)
        TXTHORA.Text = Format(Now, "hh:mm tt") 'extraer hora de 12 del sistema
        Me.MS.IsBalloon = True
        Me.MS.SetToolTip(FN, "SELECCIONE LA FECHA DE NACIMIENTO")
        Me.MS.SetToolTip(BTNIDENTIDAD, "CLICK PARA BUSCAR EL REGISTRO, EN EL CASO QUE NO SE ENCUENTRE INGRESAR LOS DATOS")
        Me.MS.SetToolTip(BTNCORRELATIVO, "CLICK PARA BUSCAR EL REGISTRO, EN EL CASO QUE NO SE ENCUENTRE INGRESAR LOS DATOS")
        Me.MS.SetToolTip(BTNGUARDAR, "GUARDAR LA INFORMACION DEL PACIENTE COMO SER: DIRECCCION, DATOS PERSONALES")
        TXTVALOR.Text = "NO"
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
        CMBPRIORIDAD.Items.Add("ROJO")
        CMBPRIORIDAD.Items.Add("AMARILLO")
        CMBPRIORIDAD.Items.Add("VERDE")
        CMBPRIORIDAD.Items.Add("AZUL")
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBPRIORIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        FN.Value = (DateTime.Now.Date)
        DEPA()
        CMBPARENTEZCO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBPARENTEZCO.Items.Add("")
        CMBPARENTEZCO.Items.Add("AMBULANCIA 911")
        CMBPARENTEZCO.Items.Add("AMBULANCIA PRIVADA")
        CMBPARENTEZCO.Items.Add("ABUELA")
        CMBPARENTEZCO.Items.Add("ABUELO")
        CMBPARENTEZCO.Items.Add("AMIGA")
        CMBPARENTEZCO.Items.Add("AMIGO")
        CMBPARENTEZCO.Items.Add("BOMBERO")
        CMBPARENTEZCO.Items.Add("COMPAÑERA LABORAL")
        CMBPARENTEZCO.Items.Add("COMPAÑERO LABORAL")
        CMBPARENTEZCO.Items.Add("COPECO")
        CMBPARENTEZCO.Items.Add("CUÑADA")
        CMBPARENTEZCO.Items.Add("CUÑADO")
        CMBPARENTEZCO.Items.Add("CRUZ ROJA")
        CMBPARENTEZCO.Items.Add("DESCONOCIDO")
        CMBPARENTEZCO.Items.Add("DERECHOS HUMANOS")
        CMBPARENTEZCO.Items.Add("ESPOSA")
        CMBPARENTEZCO.Items.Add("ESPOSO")
        CMBPARENTEZCO.Items.Add("EX-ESPOSA")
        CMBPARENTEZCO.Items.Add("EX-ESPOSO")
        CMBPARENTEZCO.Items.Add("FISCALIA DE LA NIÑEZ")
        CMBPARENTEZCO.Items.Add("FISCALIA")
        CMBPARENTEZCO.Items.Add("HERMANA")
        CMBPARENTEZCO.Items.Add("HERMANO")
        CMBPARENTEZCO.Items.Add("HIJA")
        CMBPARENTEZCO.Items.Add("HIJASTRA")
        CMBPARENTEZCO.Items.Add("HIJASTRO")
        CMBPARENTEZCO.Items.Add("HIJO")
        CMBPARENTEZCO.Items.Add("JEFE LABORAL")
        CMBPARENTEZCO.Items.Add("MADRASTRA")
        CMBPARENTEZCO.Items.Add("MADRE")
        CMBPARENTEZCO.Items.Add("NIETA")
        CMBPARENTEZCO.Items.Add("NIETO")
        CMBPARENTEZCO.Items.Add("NOVIA")
        CMBPARENTEZCO.Items.Add("NOVIO")
        CMBPARENTEZCO.Items.Add("NUERA")
        CMBPARENTEZCO.Items.Add("PADRE")
        CMBPARENTEZCO.Items.Add("PADRASTRO")
        CMBPARENTEZCO.Items.Add("PAREJA")
        CMBPARENTEZCO.Items.Add("PARIENTE POLITICO")
        CMBPARENTEZCO.Items.Add("PRIMA")
        CMBPARENTEZCO.Items.Add("PRIMO")
        CMBPARENTEZCO.Items.Add("POLICIA ATIC")
        CMBPARENTEZCO.Items.Add("POLICIA DPI")
        CMBPARENTEZCO.Items.Add("POLICIA TRANSITO")
        CMBPARENTEZCO.Items.Add("RESPONSABLE")
        CMBPARENTEZCO.Items.Add("SOBRINA")
        CMBPARENTEZCO.Items.Add("SOBRINO")
        CMBPARENTEZCO.Items.Add("SUEGRA")
        CMBPARENTEZCO.Items.Add("SUEGRO")
        CMBPARENTEZCO.Items.Add("TIA")
        CMBPARENTEZCO.Items.Add("TIO")
        CMBPARENTEZCO.Items.Add("TUTOR")
        CMBPARENTEZCO.Items.Add("VECINA")
        CMBPARENTEZCO.Items.Add("VECINO")
        CMBPARENTEZCO.Items.Add("YERNO")
        CMBCLASIFICACION.Focus()
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
        CMBBUSQUEDA.Enabled = False
        CMBBUSQUEDA.Items.Add("")
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        CMBTIPO.Items.Add("")
        CMBTIPO.Items.Add("1. HORAS")
        CMBTIPO.Items.Add("2. DIAS")
        CMBTIPO.Items.Add("3. MESES")
        CMBTIPO.Items.Add("4. AÑOS")
        CMBSEXO.Items.Add("")
        CMBSEXO.Items.Add("1. HOMBRE")
        CMBSEXO.Items.Add("2. MUJER")
    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
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
        'TXTCORRELATIVO.Text = "0000-0000"
        TXTNOMBRES.Text = "" : TXTPRIMERAPELLIDO.Text = "" : TXTSEGUNDOAPELLIDO.Text = ""
        CMBSEXO.Text = "" : FN.Value = DateTime.Now.Date
        TXTPAIS.Text = "" : TXTPADRE.Text = "" : TXTMADRE.Text = ""
        TXTBITACORA.Text = ""
        TXTEDAD.Text = "" : CMBTIPO.Text = ""
        TXTTELEFONO1.Text = "" : TXTTELEFONO2.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        TXTREMITENTE.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        TXTHORA.Text = UCase(Format(Now, "hh:mm tt"))
        TXTRESPONSABLE.Text = "" : TXTTELEFONO3.Text = ""
        TXTTELEFONO4.Text = "" : TXTDIRECCION.Text = ""
        CMBPARENTEZCO.Text = ""
        INGRESO.Value = DateTime.Now.Date
        TXTMOTIVO.Text = "" : TXTFISICO.Text = ""
    End Sub

    Private Sub TXTCORRELATIVO_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCORRELATIVO.KeyPress
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

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            LBPAIS.Visible = False : TXTPAIS.Visible = False
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
            TXTNOMBRES.Enabled = False : TXTPRIMERAPELLIDO.Enabled = False
            TXTSEGUNDOAPELLIDO.Enabled = False
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
            LBPAIS.Visible = True : TXTPAIS.Visible = True
        End If
    End Sub
    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        '---------------------------------GUARDAR-------------------
        If CMBPRIORIDAD.Text <> "" Or TXTNOMBRES.Text <> "" Or TXTREMITENTE.Text <> "" Or CMBSEXO.Text <> "" Then
            If TXTIDENTIDAD.Text <> "" And TXTCORRELATIVO.Text <> "" And TXTNOMBRES.Text <> "" And TXTPRIMERAPELLIDO.Text <> "" _
                And TXTSEGUNDOAPELLIDO.Text <> "" And CMBSEXO.Text <> "" And TXTPADRE.Text <> "" And TXTMADRE.Text <> "" Then
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
                Dim DEF As String = "0101-01-01"
                '------------------------------------------------------------
                Dim GUARDAR As String = "INSERT INTO UNICO (NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
                & "TIPO_EDAD, CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO," _
                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, FECHA_NACIMIENTO, DEFUNCION) VALUES ('" _
                & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
                & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
                & CMBTIPO.Text & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTCOLONIA.Text & "','" _
                & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTTELEFONO3.Text & "','" _
                & TXTTELEFONO4.Text & "','" & CMBSEXO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & LUNES & "','" _
                & MARTES & "','" & MIERCOLES & "','" & JUEVES & "','" & VIERNES & "','" & SABADO & "','" & DOMINGO & "','" _
                & FECHA & "','" & DEF & "')"
                Dim COMAND As SqlCommand
                COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
                COMAND.ExecuteNonQuery()
                MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
                CONE.Close()
                Me.Close()
                '-----------------------------------------------------------
            End If
        Else
            MsgBox("REVISE EL CAMPO NOMBRE, SALA REMITENTE, PRIORIDAD,SEXO YA QUE NO DEBE ESTAR VACIO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
        End If
    End Sub

    Private Sub BTNGUARDAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNGUARDAR.MouseEnter
        BTNGUARDAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNGUARDAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNGUARDAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNGUARDAR.MouseLeave
        BTNGUARDAR.FlatAppearance.BorderColor = Color.Silver
        BTNGUARDAR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNRESPONSABLE_MouseEnter(sender As Object, e As EventArgs) Handles BTNRESPONSABLE.MouseEnter
        BTNRESPONSABLE.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNRESPONSABLE.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNRESPONSABLE_MouseLeave(sender As Object, e As EventArgs) Handles BTNRESPONSABLE.MouseLeave
        BTNRESPONSABLE.FlatAppearance.BorderColor = Color.Silver
        BTNRESPONSABLE.FlatAppearance.BorderSize = 1
    End Sub
    Sub NOENCONTRADO()
        Dim PAIS As String = ""
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            PAIS = "HONDURAS"
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            PAIS = TXTPAIS.Text
        End If
        Dim FECHA As String = Format(CDate(FN.Value), "yyyy/MM/dd")
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
        Dim IDENTIDAD As String = ""
        Dim CORRELATIVO As String = ""
        If TXTIDENTIDAD.Text = "" Then
            IDENTIDAD = "0000-0000-00000"
        ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" Then
            IDENTIDAD = TXTIDENTIDAD.Text
        End If
        If TXTCORRELATIVO.Text = "" Then
            CORRELATIVO = "0000-0000"
        ElseIf TXTCORRELATIVO.Text <> "0000-0000" Or TXTCORRELATIVO.Text = "0000-0000" Then
            CORRELATIVO = TXTCORRELATIVO.Text
        End If
        Dim DOCUMENTO As String = "IMPRONTO"
        Dim GUARDAR As String = ""
        Dim MODIFICAR As String = ""
        If BTNMODIFICA.Enabled = True Then
            MODIFICAR = "SI"
        ElseIf BTNMODIFICA.Enabled = False Then
            MODIFICAR = "NO"
        End If
        If BTNGUARDA.Enabled = True Then
            GUARDAR = "SI"
        ElseIf BTNGUARDA.Enabled = False Then
            GUARDAR = "NO"
        End If
        Dim FECHA_ING As String = Format(CDate(INGRESO.Value), "yyyy/MM/dd")
        '-------------------------------GUARDAR EN TABLA HOSPITALIZACION-------------------
        CONE.Open()
        Try
            Dim TEMPO As String = "INSERT INTO TEMPORAL (DOCUMENTO, TIPO, NACIONALIDAD, TIPO_BUSQUEDA, PAIS, BITACORA, " _
        & "NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD, FECHA_NAC, FECHA_ING, " _
        & "HORA_ING, TRASLADO, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, PADRE, MADRE, SALA_REMITENTE, PRIORIDAD, RESPONSABLE, " _
        & "PARENTEZCO, DIRECCION, TELEFONO1, TELEFONO2, TELEFONO3, TELEFONO4, RASGO, MOTIVO, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, " _
        & "SABADO, DOMINGO, MODIFICAR, GUARDAR) VALUES ('" & DOCUMENTO & "','" & CMBCLASIFICACION.Text & "','" & CMBNACIONALIDAD.Text & "','" _
        & CMBBUSQUEDA.Text & "','" & PAIS & "','" & "','" & TXTBITACORA.Text & "','" & TXTNOMBRES.Text & "','" _
        & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & CMBSEXO.Text & "','" & IDENTIDAD & "','" _
        & CORRELATIVO & "','" & TXTEDAD.Text & "','" & CMBTIPO.Text & "','" & FECHA & "','" & FECHA_ING & "','" _
        & TXTHORA.Text & "','" & TXTPERSONA.Text & "','" & TXTCOLONIA.Text & "','" & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" _
        & CMBMUNICIPIO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & TXTREMITENTE.Text & "','" _
        & CMBPRIORIDAD.Text & "','" & TXTRESPONSABLE.Text & "','" & CMBPARENTEZCO.Text & "','" & TXTDIRECCION.Text & "','" _
        & TXTTELEFONO1.Text & "','" & TXTTELEFONO2.Text & "','" & TXTTELEFONO3.Text & "','" & TXTTELEFONO4.Text & "','" _
        & TXTFISICO.Text & "','" & TXTMOTIVO.Text & "','" & LUNES & "','" & MARTES & "','" & MIERCOLES & "','" _
        & JUEVES & "','" & VIERNES & "','" & SABADO & "','" & DOMINGO & "','" & MODIFICAR & "','" & GUARDAR & "')"
            Dim COMANDO As SqlCommand
            COMANDO = New SqlCommand(TEMPO, CONE)
            COMANDO.ExecuteNonQuery()
            MsgBox("REGISTRO GUARDADO CON EXITO DE FORMA TEMPORAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            CONE.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONE.Close()
        End Try
        Me.Close()
        '------------------TERMINAR DE GUARDAR EN TABLA IMPRONTO---------------------
    End Sub
    Sub SIENCONTRADO()
        Dim PAIS As String = vbNull
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            PAIS = "HONDURAS"
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            PAIS = TXTPAIS.Text
        End If
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
        Dim IDENTIDAD As String = ""
        Dim CORRELATIVO As String = ""
        If TXTIDENTIDAD.Text = "" Then
            IDENTIDAD = "0000-0000-00000"
        ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" Then
            IDENTIDAD = TXTIDENTIDAD.Text
        End If
        If TXTCORRELATIVO.Text = "" Then
            CORRELATIVO = "0000-0000"
        ElseIf TXTCORRELATIVO.Text <> "0000-0000" Or TXTCORRELATIVO.Text = "0000-0000" Then
            CORRELATIVO = TXTCORRELATIVO.Text
        End If
        Dim DOCUMENTO As String = "IMPRONTO"
        Dim GUARDAR As String = ""
        Dim MODIFICAR As String = ""

        If BTNMODIFICA.Enabled = True And BTNGUARDAR.Enabled = False Then
            MODIFICAR = "SI"
        ElseIf BTNMODIFICA.Enabled = False And BTNGUARDAR.Enabled = True Then
            MODIFICAR = "NO"
        End If

        If BTNMODIFICA.Enabled = False And BTNGUARDAR.Enabled = True Then
            GUARDAR = "SI"
        ElseIf BTNMODIFICA.Enabled = True And BTNGUARDAR.Enabled = False Then
            GUARDAR = "NO"
        End If
        Dim FECHA As String = Format(CDate(FN.Value), "yyyy/MM/dd")
        Dim FECHA_ING As String = Format(CDate(INGRESO.Value), "yyyy/MM/dd")
        CONE.Open()
        Try
            '---------------------------------GUARDAR-------------------
            Dim TEMPO As String = "UPDATE TEMPORAL SET DOCUMENTO='" & DOCUMENTO & "', TIPO='" & CMBCLASIFICACION.Text & "', NACIONALIDAD='" _
            & CMBNACIONALIDAD.Text & "', TIPO_BUSQUEDA='" & CMBBUSQUEDA.Text & "', PAIS='" & PAIS & "', BITACORA='" _
            & TXTBITACORA.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" _
            & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" & TXTSEGUNDOAPELLIDO.Text & "', SEXO='" & CMBSEXO.Text & "', IDENTIDAD='" _
            & TXTIDENTIDAD.Text & "', CORRELATIVO='" & TXTCORRELATIVO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" _
            & CMBTIPO.Text & "', FECHA_NAC='" & FECHA & "', FECHA_ING='" & FECHA_ING & "', HORA_ING='" & TXTHORA.Text & "', TRASLADO='" _
            & TXTPERSONA.Text & "', COLONIA='" & TXTCOLONIA.Text & "', CASA='" & TXTCASA.Text & "', DEPARTAMENTO='" _
            & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" & CMBMUNICIPIO.Text & "', PADRE='" & TXTPADRE.Text & "', MADRE='" _
            & TXTMADRE.Text & "', SALA_REMITENTE='" & TXTREMITENTE.Text & "', PRIORIDAD='" & CMBPRIORIDAD.Text & "', RESPONSABLE='" _
            & TXTRESPONSABLE.Text & "', PARENTEZCO='" & CMBPARENTEZCO.Text & "', DIRECCION='" & TXTDIRECCION.Text & "', TELEFONO1='" _
            & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "', TELEFONO3='" & TXTTELEFONO3.Text & "', TELEFONO4='" _
            & TXTTELEFONO4.Text & "', RASGO='" & TXTFISICO.Text & "', MOTIVO='" & TXTMOTIVO.Text & "', LUNES='" & LUNES & "', MARTES='" _
            & MARTES & "', MIERCOLES='" & MIERCOLES & "', JUEVES='" & JUEVES & "', VIERNES='" & VIERNES & "', SABADO='" _
            & SABADO & "', DOMINGO='" & DOMINGO & "', MODIFICAR='" & MODIFICAR & "', GUARDAR='" _
            & GUARDAR & "' WHERE DOCUMENTO='" & DOCUMENTO & "'"
            Dim UNI As SqlCommand
            UNI = New SqlCommand(TEMPO, CONE)
            UNI.ExecuteNonQuery()
            MsgBox("REGISTRO MODIFICADO CON EXITO DE FORMA TEMPORAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            CONE.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONE.Close()
        End Try
    End Sub
    Private Sub BTNTEMPORAL_Click(sender As Object, e As EventArgs) Handles BTNTEMPORAL.Click
        If TXTNOMBRES.Text <> "" And TXTIDENTIDAD.Text <> "" And TXTCORRELATIVO.Text <> "" Then
            Dim DOCUMENTO As String = "IMPRONTO"
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT DOCUMENTO FROM TEMPORAL WHERE DOCUMENTO='" & DOCUMENTO & "'"
            Dim DATO As DataSet
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
            DATO = New DataSet
            ADAPTADOR.Fill(DATO)
            Try
                If DATO.Tables(0).Rows.Count > 0 Then
                        SIENCONTRADO()
                ElseIf DATO.Tables(0).Rows.Count = 0 Then
                    NOENCONTRADO()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf TXTNOMBRES.Text <> "" And TXTIDENTIDAD.Text <> "" And TXTCORRELATIVO.Text <> "" Then
            MsgBox("DEBE INGRESAR DATOS PARA ALMACENAR DE FORMA TEMPORAL")
        End If
    End Sub

    Private Sub BTNTEMPORAL_MouseEnter(sender As Object, e As EventArgs) Handles BTNTEMPORAL.MouseEnter
        BTNTEMPORAL.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNTEMPORAL.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNTEMPORAL_MouseLeave(sender As Object, e As EventArgs) Handles BTNTEMPORAL.MouseLeave
        BTNTEMPORAL.FlatAppearance.BorderColor = Color.Silver
        BTNTEMPORAL.FlatAppearance.BorderSize = 1
    End Sub
    Sub CARGAR()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT DOCUMENTO, TIPO, NACIONALIDAD, TIPO_BUSQUEDA, PAIS, BITACORA, NOMBRE_PACIENTE, PRIMER_APELLIDO, " _
        & "SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD, FECHA_NAC, FECHA_ING, HORA_ING, TRASLADO, COLONIA, CASA, " _
        & "DEPARTAMENTO, MUNICIPIO, PADRE, MADRE, SALA_REMITENTE, PRIORIDAD, RESPONSABLE, PARENTEZCO, DIRECCION, TELEFONO1, TELEFONO2, " _
        & "TELEFONO3, TELEFONO4, RASGO, MOTIVO, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, MODIFICAR, " _
        & "GUARDAR FROM TEMPORAL WHERE DOCUMENTO = 'IMPRONTO'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO)
        Try
            CMBCLASIFICACION.Text = DATO.Tables(0).Rows(0)("TIPO")
            CMBNACIONALIDAD.Text = DATO.Tables(0).Rows(0)("NACIONALIDAD")
            CMBBUSQUEDA.Text = DATO.Tables(0).Rows(0)("TIPO_BUSQUEDA")
            TXTPAIS.Text = DATO.Tables(0).Rows(0)("PAIS")
            TXTBITACORA.Text = DATO.Tables(0).Rows(0)("BITACORA")
            TXTNOMBRES.Text = DATO.Tables(0).Rows(0)("NOMBRE_PACIENTE")
            TXTPRIMERAPELLIDO.Text = DATO.Tables(0).Rows(0)("PRIMER_APELLIDO")
            TXTSEGUNDOAPELLIDO.Text = DATO.Tables(0).Rows(0)("SEGUNDO_APELLIDO")
            CMBSEXO.Text = DATO.Tables(0).Rows(0)("SEXO")
            TXTIDENTIDAD.Text = DATO.Tables(0).Rows(0)("IDENTIDAD")
            TXTCORRELATIVO.Text = DATO.Tables(0).Rows(0)("CORRELATIVO")
            TXTEDAD.Text = DATO.Tables(0).Rows(0)("EDAD")
            CMBTIPO.Text = DATO.Tables(0).Rows(0)("TIPO_EDAD")
            FN.Value = Format((DATO.Tables(0).Rows(0)("FECHA_NAC")), "dd/MM/yyyy")
            INGRESO.Value = Format((DATO.Tables(0).Rows(0)("FECHA_ING")), "dd/MM/yyyy")
            TXTHORA.Text = DATO.Tables(0).Rows(0)("HORA_ING")
            TXTPERSONA.Text = DATO.Tables(0).Rows(0)("TRASLADO")
            TXTCOLONIA.Text = DATO.Tables(0).Rows(0)("COLONIA")
            TXTCASA.Text = DATO.Tables(0).Rows(0)("CASA")
            CMBDEPARTAMENTO.Text = DATO.Tables(0).Rows(0)("DEPARTAMENTO")
            CMBMUNICIPIO.Text = DATO.Tables(0).Rows(0)("MUNICIPIO")
            TXTPADRE.Text = DATO.Tables(0).Rows(0)("PADRE")
            TXTMADRE.Text = DATO.Tables(0).Rows(0)("MADRE")
            TXTREMITENTE.Text = DATO.Tables(0).Rows(0)("SALA_REMITENTE")
            CMBPRIORIDAD.Text = DATO.Tables(0).Rows(0)("PRIORIDAD")
            TXTRESPONSABLE.Text = DATO.Tables(0).Rows(0)("RESPONSABLE")
            CMBPARENTEZCO.Text = DATO.Tables(0).Rows(0)("PARENTEZCO")
            TXTDIRECCION.Text = DATO.Tables(0).Rows(0)("DIRECCION")
            TXTTELEFONO1.Text = DATO.Tables(0).Rows(0)("TELEFONO1")
            TXTTELEFONO2.Text = DATO.Tables(0).Rows(0)("TELEFONO2")
            TXTTELEFONO3.Text = DATO.Tables(0).Rows(0)("TELEFONO3")
            TXTTELEFONO4.Text = DATO.Tables(0).Rows(0)("TELEFONO4")
            TXTFISICO.Text = DATO.Tables(0).Rows(0)("RASGO")
            TXTMOTIVO.Text = DATO.Tables(0).Rows(0)("MOTIVO")

            TXTNOMBRES.Text = DATO.Tables(0).Rows(0)("NOMBRE_PACIENTE")
            TXTPRIMERAPELLIDO.Text = DATO.Tables(0).Rows(0)("PRIMER_APELLIDO")
            TXTSEGUNDOAPELLIDO.Text = DATO.Tables(0).Rows(0)("SEGUNDO_APELLIDO")
            TXTBITACORA.Text = DATO.Tables(0).Rows(0)("BITACORA")
            CMBSEXO.Text = DATO.Tables(0).Rows(0)("SEXO")
            If DATO.Tables(0).Rows(0)("LUNES") = "SI" Then
                CBLUNES.CheckState = CheckState.Checked
            Else
                CBLUNES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("MARTES") = "SI" Then
                CBMARTES.CheckState = CheckState.Checked
            Else
                CBMARTES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("MIERCOLES") = "SI" Then
                CBMIERCOLES.CheckState = CheckState.Checked
            Else
                CBMIERCOLES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("JUEVES") = "SI" Then
                CBJUEVES.CheckState = CheckState.Checked
            Else
                CBJUEVES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("VIERNES") = "SI" Then
                CBVIERNES.CheckState = CheckState.Checked
            Else
                CBVIERNES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("SABADO") = "SI" Then
                CBSABADO.CheckState = CheckState.Checked
            Else
                CBSABADO.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("DOMINGO") = "SI" Then
                CBDOMINGO.CheckState = CheckState.Checked
            Else
                CBDOMINGO.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("MODIFICAR") = "SI" Then
                BTNMODIFICA.Enabled = True
                BTNGUARDAR.Enabled = False
                BTNGUARDA.Enabled = False
            ElseIf DATO.Tables(0).Rows(0)("MODIFICAR") = "NO" Then
                BTNMODIFICA.Enabled = False
                BTNGUARDAR.Enabled = True
                BTNGUARDA.Enabled = True
            End If
            If DATO.Tables(0).Rows(0)("GUARDAR") = "SI" Then
                BTNMODIFICA.Enabled = False
                BTNGUARDAR.Enabled = True
                BTNGUARDA.Enabled = True
            ElseIf DATO.Tables(0).Rows(0)("GUARDAR") = "NO" Then
                BTNMODIFICA.Enabled = True
                BTNGUARDAR.Enabled = False
                BTNGUARDA.Enabled = False
            End If
            CMBNACIONALIDAD.Enabled = True : CMBBUSQUEDA.Enabled = True
            TXTNOMBRES.Enabled = True : TXTPRIMERAPELLIDO.Enabled = True
            TXTSEGUNDOAPELLIDO.Enabled = True : TXTCORRELATIVO.Enabled = False
            TXTCOLONIA.Enabled = True : TXTCASA.Enabled = True
            CMBDEPARTAMENTO.Enabled = True : CMBMUNICIPIO.Enabled = True
            TXTTELEFONO1.Enabled = True : TXTTELEFONO2.Enabled = True
            TXTTELEFONO3.Enabled = True : TXTTELEFONO4.Enabled = True
            CMBSEXO.Enabled = True : FN.Enabled = True
            TXTPADRE.Enabled = True : TXTMADRE.Enabled = True
            TXTEDAD.Enabled = True : CMBTIPO.Enabled = True
            TXTRESPONSABLE.Enabled = True
            TXTDIRECCION.Enabled = True
            BTNSALA.Enabled = True
            BTNRESPONSABLE.Enabled = True
            CMBPARENTEZCO.Enabled = True
            TXTPERSONA.Enabled = True
            TXTREMITENTE.Enabled = True
            CMBPRIORIDAD.Enabled = True
            TXTMOTIVO.Enabled = True
            TXTFISICO.Enabled = True
            BTNSALA.Visible = True
            TXTEDAD.Focus()
        Catch ex As Exception
            'MsgBox(ex.Message)
            CMBNACIONALIDAD.Enabled = True : CMBBUSQUEDA.Enabled = True
            TXTNOMBRES.Enabled = True : TXTPRIMERAPELLIDO.Enabled = True
            TXTSEGUNDOAPELLIDO.Enabled = True : TXTCORRELATIVO.Enabled = False
            TXTCOLONIA.Enabled = True : TXTCASA.Enabled = True
            CMBDEPARTAMENTO.Enabled = True : CMBMUNICIPIO.Enabled = True
            TXTTELEFONO1.Enabled = True : TXTTELEFONO2.Enabled = True
            TXTTELEFONO3.Enabled = True : TXTTELEFONO4.Enabled = True
            CMBSEXO.Enabled = True : FN.Enabled = True
            TXTPADRE.Enabled = True : TXTMADRE.Enabled = True
            TXTEDAD.Enabled = True : CMBTIPO.Enabled = True
            TXTRESPONSABLE.Enabled = True
            TXTDIRECCION.Enabled = True
            BTNSALA.Enabled = True
            BTNRESPONSABLE.Enabled = True
            CMBPARENTEZCO.Enabled = True
            TXTPERSONA.Enabled = True
            TXTREMITENTE.Enabled = True
            CMBPRIORIDAD.Enabled = True
            TXTMOTIVO.Enabled = True
            TXTFISICO.Enabled = True
            BTNSALA.Visible = True
        End Try
    End Sub
    Private Sub BTNCARGAR_Click(sender As Object, e As EventArgs) Handles BTNCARGAR.Click
        Dim DOCUMENTO As String = "IMPRONTO"
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT DOCUMENTO FROM TEMPORAL WHERE DOCUMENTO='" & DOCUMENTO & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO)
        Try
            If DATO.Tables(0).Rows.Count > 0 Then
                    CARGAR()
            ElseIf DATO.Tables(0).Rows.Count = 0 Then
                MsgBox("NO HAY NINGUN DATO ALMACENADO PARA CARGAR")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNCARGAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNCARGAR.MouseEnter
        BTNCARGAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNCARGAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNCARGAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNCARGAR.MouseLeave
        BTNCARGAR.FlatAppearance.BorderColor = Color.Silver
        BTNCARGAR.FlatAppearance.BorderSize = 1
    End Sub
    Sub IMPRIMIR_IMPRONTO()
        If MsgBox("DESEA IMPRIMIR EL IMPRONTO", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            Dim TIPO As String = ""
            Dim REPORT As New IMPRONTOS
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
            Dim CORRELATIVO As String = ""
            If TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CORRELATIVO = TXTCORRELATIVO.Text
                IDENTIDAD = ""
                REPORT.SetParameterValue("TXTID", LBCORRELATIVO.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000" Then
                IDENTIDAD = TXTIDENTIDAD.Text
                CORRELATIVO = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                IDENTIDAD = TXTIDENTIDAD.Text
                CORRELATIVO = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            End If
            Dim NOMBRE As String = ""
            If CMBCLASIFICACION.Text = "NORMAL" Then
                NOMBRE = TXTNOMBRES.Text
            ElseIf CMBCLASIFICACION.Text = "RN#1" Or CMBCLASIFICACION.Text = "RN#2" Or _
            CMBCLASIFICACION.Text = "RN#3" Then
                NOMBRE = "RN " & TXTNOMBRES.Text
            ElseIf CMBCLASIFICACION.Text = "OBITO_1" Or CMBCLASIFICACION.Text = "OBITO_2" Or CMBCLASIFICACION.Text = "OBITO_3" Then
                NOMBRE = "OBITO " & TXTNOMBRES.Text
            ElseIf CMBCLASIFICACION.Text = "HIJO_1" Or CMBCLASIFICACION.Text = "HIJO_2" Or CMBCLASIFICACION.Text = "HIJO_3" Then
                NOMBRE = "HIJO DE " & TXTNOMBRES.Text
            ElseIf CMBCLASIFICACION.Text = "RN_GEMELO_1" Then
                NOMBRE = "RN G#1" & TXTNOMBRES.Text
            ElseIf CMBCLASIFICACION.Text = "RN_GEMELO_2" Then
                NOMBRE = "RN G#2" & TXTNOMBRES.Text
            ElseIf CMBCLASIFICACION.Text = "RN_GEMELO_3" Then
                NOMBRE = "RN G#3" & TXTNOMBRES.Text
            End If
            Dim FECHA As String = ""
            If CBFN.Checked = True Then
                FECHA = ""
            ElseIf CBFN.Checked = False Then
                FECHA = Format(FN.Value, "dd/MMM/yyyy")
            End If
            Dim DEPAA As String = ""
            Dim MUNI As String = ""
            If CMBDEPARTAMENTO.Text = "SELECCIONE" Then
                DEPAA = ""
            Else
                DEPAA = CMBDEPARTAMENTO.Text
            End If
            If CMBMUNICIPIO.Text = "SELECCIONE" Then
                MUNI = ""
            Else
                MUNI = CMBMUNICIPIO.Text
            End If
            Dim NUEVO As String = Strings.Right(LOGIN.TXTIDENTIDAD.Text, 4)
            REPORT.SetParameterValue("TXTCLAVE", NUEVO)
            REPORT.SetParameterValue("TXTCLINICA", IDENTIDAD)
            REPORT.SetParameterValue("TXTCORRELATIVO", CORRELATIVO)
            REPORT.SetParameterValue("TXTPRIMER", TXTPRIMERAPELLIDO.Text)
            REPORT.SetParameterValue("TXTSEGUNDO", TXTSEGUNDOAPELLIDO.Text)
            REPORT.SetParameterValue("TXTNOMBRE", NOMBRE)
            REPORT.SetParameterValue("TXTSEXO", CMBSEXO.Text)
            REPORT.SetParameterValue("TXTEDAD", TXTEDAD.Text & Chr(13) & Chr(10) & TIPO)
            REPORT.SetParameterValue("TXTFN", FECHA)
            REPORT.SetParameterValue("TXTHORA", TXTHORA.Text)
            REPORT.SetParameterValue("TXTFECHA", Format(INGRESO.Value, "dd/MMM/yyyy"))
            REPORT.SetParameterValue("TXTTRASLADO", TXTPERSONA.Text)
            REPORT.SetParameterValue("TXTDIRECCION", TXTCOLONIA.Text & "," & TXTCASA.Text & "," & MUNI & "," & DEPAA)
            REPORT.SetParameterValue("TXTPADRE", TXTPADRE.Text)
            REPORT.SetParameterValue("TXTMADRE", TXTMADRE.Text)
            REPORT.SetParameterValue("TXTRESPONSABLE", TXTRESPONSABLE.Text & "--" & CMBPARENTEZCO.Text)
            REPORT.SetParameterValue("TXTDIRRESPONSABLE", TXTDIRECCION.Text)
            REPORT.SetParameterValue("TXTTELEFONO", TXTTELEFONO1.Text & " / " & TXTTELEFONO2.Text)
            REPORT.SetParameterValue("TXTMOTIVO", TXTMOTIVO.Text)
            REPORT.SetParameterValue("TXTRASGOS", TXTFISICO.Text)
            RPIMPRONTO.CrystalReportViewer1.ReportSource = REPORT
            RPIMPRONTO.CrystalReportViewer1.Refresh()
            RPIMPRONTO.Show()
        Else
            Me.Close()
        End If
    End Sub
    Sub MODIFICAR_IDENTIDAD()
        If MsgBox("DESEA CONTINUAR CON EL PROCESO DE MODIFICACION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
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
            Dim FECHA As String = ""
            If CBFN.Checked = True Then
                FECHA = "0101-01-01"
            ElseIf CBFN.Checked = False Then
                FECHA = Format(CDate(FN.Value), "yyyy/MM/dd")
            End If
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
                & DOMINGO & "', FECHA_NACIMIENTO='" & FECHA & "' WHERE TIPO='" & CMBCLASIFICACION.Text & "' AND IDENTIDAD='" _
                & TXTIDENTIDAD.Text & "'"
                Dim UNI As SqlCommand
                UNI = New SqlCommand(UNICO, CONE)
                UNI.ExecuteNonQuery()
                CONE.Close()
                '--------------------------------CIERRE TABLA UNICO-------------------

                '------------------------------------GUARDAR EME_CONTACTO------------------------
                If TXTVALOR.Text = "NO" Then
                    GUARDARCONTACTO()
                ElseIf TXTVALOR.Text = "SI" Then
                    MODIFICARCONTACTO()
                End If
                '------------------TERMINAR DE GUARDAR EN TABLA EME_CONTACTO---------------------

                '-------------------------------GUARDAR EN TABLA IMPRONTO-------------------
                CONE.Open()
                Dim FECHA_ING As String = Format(CDate(INGRESO.Value), "yyyy/MM/dd")
                Dim ING As String = Format(CDate(LOGIN.LBFECHA.Text), "yyyy/MM/dd")
                Dim IMPRONTO As String = "INSERT INTO IMPRONTO (EMPLEADO, TURNO, HORARIO, FECHA_INGRESO, COMENTARIO, NACIONALIDAD, PAIS, " _
                & "TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD, FECHA_NAC, FECHA_ING, " _
                & " HORA_ING, TRASLADO, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, PADRE, MADRE, SALA_REMITENTE, PRIORIDAD, RESPONSABLE, " _
                & " PARENTEZCO, DIRECCION, TELEFONO1, TELEFONO2, RASGO, MOTIVO)" _
                & "VALUES ('" & LOGIN.TXTUSUARIO.Text & "','" & LOGIN.CMBTURNO.Text & "','" & LOGIN.LBHORARIO.Text & "','" _
                & ING & "','" & LOGIN.TXTCOMENTARIO.Text & "','" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" & TXTNOMBRES.Text & "','" _
                & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & CMBSEXO.Text & "','" & TXTIDENTIDAD.Text & "','" _
                & TXTCORRELATIVO.Text & "','" & TXTEDAD.Text & "','" & CMBTIPO.Text & "','" & FECHA & "','" & FECHA_ING & "','" _
                & TXTHORA.Text & "','" & TXTPERSONA.Text & "','" & TXTCOLONIA.Text & "','" & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" _
                & CMBMUNICIPIO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & TXTREMITENTE.Text & "','" & CMBPRIORIDAD.Text & "','" _
                & TXTRESPONSABLE.Text & "','" & CMBPARENTEZCO.Text & "','" & TXTDIRECCION.Text & "','" & TXTTELEFONO1.Text & "','" _
                & TXTTELEFONO2.Text & "','" & TXTFISICO.Text & "','" & TXTMOTIVO.Text & "')"
                Dim COMANDO As SqlCommand
                COMANDO = New SqlCommand(IMPRONTO, CONE) 'INSERTAR REGISTRO EN TABLA IMPRONTO
                COMANDO.ExecuteNonQuery()
                MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
                CONE.Close()
                Dim FORMULARIO As Form
                Dim CARGADO As Boolean
                CARGADO = False
                For Each FORMULARIO In Application.OpenForms
                    If FORMULARIO.Name = "RPIMPRONTO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO HOJA IMPRONTO YA ESTA ABIERTO, REIMPRIMA LA HOJA ", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        RPIMPRONTO.Close()
                        Exit For
                    End If
                Next FORMULARIO
                If CARGADO = False Then
                    IMPRIMIR_IMPRONTO()
                End If
                Me.Close()
                '------------------TERMINAR DE GUARDAR EN TABLA IMPRONTO---------------------
            Catch ex As Exception
                MsgBox(ex.Message)
                If CONE.State = ConnectionState.Open Then
                    CONE.Close()
                ElseIf CONE.State = ConnectionState.Closed Then
                    CONE.Open()
                End If
            End Try
        Else
            TXTNOMBRES.Focus()
        End If
    End Sub
    Sub MODIFICAR_CORRELATIVO()
        If MsgBox("DESEA CONTINUAR CON EL PROCESO DE MODIFICACION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
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
            Dim FECHA As String = ""
            If CBFN.Checked = True Then
                FECHA = "0101-01-01"
            ElseIf CBFN.Checked = False Then
                FECHA = Format(CDate(FN.Value), "yyyy/MM/dd")
            End If
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
                & DOMINGO & "', FECHA_NACIMIENTO='" & FECHA & "' WHERE TIPO='" & CMBCLASIFICACION.Text & "' AND CORRELATIVO='" _
                & TXTCORRELATIVO.Text & "'"
                Dim UNI As SqlCommand
                UNI = New SqlCommand(UNICO, CONE)
                UNI.ExecuteNonQuery()
                CONE.Close()
                '-------------------CIERRE UNICO ---------------------------
                '------------------------------------GUARDAR EME_CONTACTO------------------------
                If TXTVALOR.Text = "NO" Then
                    GUARDARCONTACTO()
                ElseIf TXTVALOR.Text = "SI" Then
                    MODIFICARCONTACTO()
                End If
                '------------------TERMINAR DE GUARDAR EN TABLA EME_CONTACTO---------------------

                '-------------------------------GUARDAR EN TABLA IMPRONTO-------------------
                CONE.Open()
                Dim FECHA_ING As String = Format(CDate(INGRESO.Value), "yyyy/MM/dd")
                Dim ING As String = Format(CDate(LOGIN.LBFECHA.Text), "yyyy/MM/dd")
                '------------------------------------------------------------
                Dim IMPRONTO As String = "INSERT INTO IMPRONTO (EMPLEADO, TURNO, HORARIO, FECHA_INGRESO, COMENTARIO, NACIONALIDAD, PAIS, " _
                & "TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD, FECHA_NAC, FECHA_ING, " _
                & " HORA_ING, TRASLADO, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, PADRE, MADRE, SALA_REMITENTE, PRIORIDAD, RESPONSABLE, " _
                & " PARENTEZCO, DIRECCION, TELEFONO1, TELEFONO2, RASGO, MOTIVO)" _
                & "VALUES ('" & LOGIN.TXTUSUARIO.Text & "','" & LOGIN.CMBTURNO.Text & "','" & LOGIN.LBHORARIO.Text & "','" _
                & ING & "','" & LOGIN.TXTCOMENTARIO.Text & "','" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" & TXTNOMBRES.Text & "','" _
                & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & CMBSEXO.Text & "','" & TXTIDENTIDAD.Text & "','" _
                & TXTCORRELATIVO.Text & "','" & TXTEDAD.Text & "','" & CMBTIPO.Text & "','" & FECHA & "','" & FECHA_ING & "','" _
                & TXTHORA.Text & "','" & TXTPERSONA.Text & "','" & TXTCOLONIA.Text & "','" & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" _
                & CMBMUNICIPIO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & TXTREMITENTE.Text & "','" & CMBPRIORIDAD.Text & "','" _
                & TXTRESPONSABLE.Text & "','" & CMBPARENTEZCO.Text & "','" & TXTDIRECCION.Text & "','" & TXTTELEFONO1.Text & "','" _
                & TXTTELEFONO2.Text & "','" & TXTFISICO.Text & "','" & TXTMOTIVO.Text & "')"
                Dim COMANDO As SqlCommand
                COMANDO = New SqlCommand(IMPRONTO, CONE) 'INSERTAR REGISTRO EN TABLA IMPRONTO
                COMANDO.ExecuteNonQuery()
                MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
                CONE.Close()
                Dim FORMULARIO As Form
                Dim CARGADO As Boolean
                CARGADO = False
                For Each FORMULARIO In Application.OpenForms
                    If FORMULARIO.Name = "RPIMPRONTO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO HOJA IMPRONTO YA ESTA ABIERTO, REIMPRIMA LA HOJA ", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        RPIMPRONTO.Close()
                        Exit For
                    End If
                Next FORMULARIO
                If CARGADO = False Then
                    IMPRIMIR_IMPRONTO()
                End If
                Me.Close()
                '------------------TERMINAR DE GUARDAR EN TABLA IMPRONTO---------------------
            Catch ex As Exception
                MsgBox(ex.Message)
                If CONE.State = ConnectionState.Open Then
                    CONE.Close()
                ElseIf CONE.State = ConnectionState.Closed Then
                    CONE.Open()
                End If
            End Try
        Else
            TXTNOMBRES.Focus()
        End If
    End Sub
    Private Sub BTNMODIFICA_Click(sender As Object, e As EventArgs) Handles BTNMODIFICA.Click
        If CMBPRIORIDAD.Text <> "" Or TXTNOMBRES.Text <> "" Or TXTREMITENTE.Text <> "" Or CMBSEXO.Text <> "" Then
            If (TXTCORRELATIVO.Text <> "" Or TXTCORRELATIVO.Text = "0000-0000") And (TXTIDENTIDAD.Text <> "0000-0000-00000") Then
                MODIFICAR_IDENTIDAD()
            ElseIf (TXTIDENTIDAD.Text <> "" Or TXTIDENTIDAD.Text = "0000-0000-00000") And (TXTCORRELATIVO.Text <> "0000-0000") Then
                MODIFICAR_CORRELATIVO()
            ElseIf TXTCORRELATIVO.Text <> "0000-0000" And TXTIDENTIDAD.Text <> "0000-0000-00000" And _
                TXTCORRELATIVO.Text <> "" And TXTIDENTIDAD.Text <> "" Then
                MODIFICAR_IDENTIDAD()
            End If
        Else
            MsgBox("REVISE EL CAMPO NOMBRE, SALA REMITENTE, PRIORIDAD, SEXO YA QUE NO PUEDE QUEDAR VACIO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
        End If
    End Sub

    Private Sub BTNMODIFICA_MouseEnter(sender As Object, e As EventArgs) Handles BTNMODIFICA.MouseEnter
        BTNMODIFICA.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNMODIFICA.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNMODIFICA_MouseLeave(sender As Object, e As EventArgs) Handles BTNMODIFICA.MouseLeave
        BTNMODIFICA.FlatAppearance.BorderColor = Color.Silver
        BTNMODIFICA.FlatAppearance.BorderSize = 1
    End Sub
    Sub GUARDARCONTACTO()
        If TXTRESPONSABLE.Text <> "" And CMBPARENTEZCO.Text <> "" Then
            CONE.Open()
            Dim CONTACTO As String = "INSERT INTO EME_CONTACTO (IDENTIDAD, CORRELATIVO, RESPONSABLE, PARENTEZCO, " _
            & "DIRECCION, TELEFONO1, TELEFONO2) VALUES ('" & TXTIDENTIDAD.Text & "','" & TXTCORRELATIVO.Text & "','" _
            & TXTRESPONSABLE.Text & "','" & CMBPARENTEZCO.Text & "','" & TXTDIRECCION.Text & "','" & TXTTELEFONO1.Text & "','" _
            & TXTTELEFONO2.Text & "')"
            Dim COMAN As SqlCommand
            COMAN = New SqlCommand(CONTACTO, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
            COMAN.ExecuteNonQuery()
            CONE.Close()
        End If
    End Sub
    Sub MODIFICARCONTACTO()
        If TXTRESPONSABLE.Text <> "" And CMBPARENTEZCO.Text <> "" Then
            CONE.Open()
            Dim CONTACTO As String = "UPDATE EME_CONTACTO SET IDENTIDAD='" & TXTIDENTIDAD.Text & "', CORRELATIVO='" _
            & TXTCORRELATIVO.Text & "', RESPONSABLE='" & TXTRESPONSABLE.Text & "', PARENTEZCO='" & CMBPARENTEZCO.Text & "', DIRECCION='" _
            & TXTDIRECCION.Text & "', TELEFONO1='" & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "' WHERE IDENTIDAD='" _
            & TXTIDENTIDAD.Text & "' AND CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
            Dim COMAN As SqlCommand
            COMAN = New SqlCommand(CONTACTO, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
            COMAN.ExecuteNonQuery()
            CONE.Close()
        End If
    End Sub
    Sub GUARDAR_IDENTIDAD()
        If MsgBox("DESEA CONTINUAR CON EL PROCESO DE GUARDADO", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            '-------------------------------GUARDAR EN TABLA UNICO-------------------
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
            Dim DEF As String = "0101-01-01"
            Try
                '------------------------------------GUARDAR EME_CONTACTO------------------------
                If TXTVALOR.Text = "NO" Then
                    GUARDARCONTACTO()
                ElseIf TXTVALOR.Text = "SI" Then
                    MODIFICARCONTACTO()
                End If
                '------------------TERMINAR DE GUARDAR EN TABLA EME_CONTACTO---------------------
                '-------------------------------GUARDAR EN TABLA IMPRONTO-------------------
                CONE.Open()
                Dim FECHA_ING As String = Format(CDate(INGRESO.Value), "yyyy/MM/dd")
                Dim ING As String = Format(CDate(LOGIN.LBFECHA.Text), "yyyy/MM/dd")
                '------------------------------------------------------------
                Dim IMPRONTO As String = "INSERT INTO IMPRONTO (EMPLEADO, TURNO, HORARIO, FECHA_INGRESO, COMENTARIO, NACIONALIDAD, PAIS, " _
                & "TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, IDENTIDAD, CORRELATIVO, EDAD, TIPO_EDAD, FECHA_NAC, FECHA_ING, " _
                & " HORA_ING, TRASLADO, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, PADRE, MADRE, SALA_REMITENTE, PRIORIDAD, RESPONSABLE, " _
                & " PARENTEZCO, DIRECCION, TELEFONO1, TELEFONO2, RASGO, MOTIVO)" _
                & "VALUES ('" & LOGIN.TXTUSUARIO.Text & "','" & LOGIN.CMBTURNO.Text & "','" & LOGIN.LBHORARIO.Text & "','" _
                & ING & "','" & LOGIN.TXTCOMENTARIO.Text & "','" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" & TXTNOMBRES.Text & "','" _
                & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & CMBSEXO.Text & "','" & TXTIDENTIDAD.Text & "','" _
                & TXTCORRELATIVO.Text & "','" & TXTEDAD.Text & "','" & CMBTIPO.Text & "','" & FECHA & "','" & FECHA_ING & "','" _
                & TXTHORA.Text & "','" & TXTPERSONA.Text & "','" & TXTCOLONIA.Text & "','" & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" _
                & CMBMUNICIPIO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & TXTREMITENTE.Text & "','" & CMBPRIORIDAD.Text & "','" _
                & TXTRESPONSABLE.Text & "','" & CMBPARENTEZCO.Text & "','" & TXTDIRECCION.Text & "','" & TXTTELEFONO1.Text & "','" _
                & TXTTELEFONO2.Text & "','" & TXTFISICO.Text & "','" & TXTMOTIVO.Text & "')"
                Dim COMANDO As SqlCommand
                COMANDO = New SqlCommand(IMPRONTO, CONE) 'INSERTAR REGISTRO EN TABLA IMPRONTO
                COMANDO.ExecuteNonQuery()
                MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
                CONE.Close()
                '------------------------------------GUARDAR UNICO------------------------
                CONE.Open()
                Dim GUARDAR As String = "INSERT INTO UNICO (NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
                    & "TIPO_EDAD, CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO," _
                    & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, FECHA_NACIMIENTO, DEFUNCION)" _
                    & "VALUES ('" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
                    & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
                    & CMBTIPO.Text & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTCOLONIA.Text & "','" _
                    & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTTELEFONO3.Text & "','" _
                    & TXTTELEFONO4.Text & "','" & CMBSEXO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & LUNES & "','" _
                    & MARTES & "','" & MIERCOLES & "','" & JUEVES & "','" & VIERNES & "','" & SABADO & "','" & DOMINGO & "','" _
                    & FECHA & "','" & DEF & "')"
                    Dim COMAND As SqlCommand
                    COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
                    COMAND.ExecuteNonQuery()
                    'MsgBox("REGISTRO GUARDADO CON EXITO EN TABLA UNICO", MsgBoxStyle.Information, AcceptButton)
                    CONE.Close()
                    '------------------TERMINAR DE GUARDAR EN TABLA UNICO---------------------
                Dim FORMULARIO As Form
                Dim CARGADO As Boolean
                CARGADO = False
                For Each FORMULARIO In Application.OpenForms
                    If FORMULARIO.Name = "RPIMPRONTO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO HOJA IMPRONTO YA ESTA ABIERTO ", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        RPIMPRONTO.Close()
                        Exit For
                    End If
                Next FORMULARIO
                If CARGADO = False Then
                    IMPRIMIR_IMPRONTO()
                End If
                Me.Close()
                '------------------TERMINAR DE GUARDAR EN TABLA IMPRONTO---------------------
            Catch ex As Exception
                MsgBox(ex.Message)
                If CONE.State = ConnectionState.Open Then
                    CONE.Close()
                ElseIf CONE.State = ConnectionState.Closed Then
                    CONE.Open()
                End If
            End Try
        Else
            TXTNOMBRES.Focus()
        End If
        Me.Dispose()
    End Sub
    Private Sub BTNGUARDA_Click(sender As Object, e As EventArgs) Handles BTNGUARDA.Click
        If CMBPRIORIDAD.Text <> "" Or TXTNOMBRES.Text <> "" Or TXTREMITENTE.Text <> "" Or CMBSEXO.Text <> "" Then
            If TXTIDENTIDAD.Text <> "" Or TXTCORRELATIVO.Text <> "" Or (TXTIDENTIDAD.Text = "0000-0000-00000" And _
               TXTCORRELATIVO.Text <> "0000-0000") Then
                GUARDAR_IDENTIDAD()
            End If
        Else
            MsgBox("REVISE EL CAMPO NOMBRE, SALA REMITENTE, PRIORIDAD,SEXO YA QUE NO DEBE ESTAR VACIO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
        End If
    End Sub

    Private Sub BTNGUARDA_MouseEnter(sender As Object, e As EventArgs) Handles BTNGUARDA.MouseEnter
        BTNGUARDA.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNGUARDA.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNGUARDA_MouseLeave(sender As Object, e As EventArgs) Handles BTNGUARDA.MouseLeave
        BTNGUARDA.FlatAppearance.BorderColor = Color.Silver
        BTNGUARDA.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNSALIR_MouseEnter(sender As Object, e As EventArgs) Handles BTNSALIR.MouseEnter
        BTNSALIR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNSALIR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNSALIR_MouseLeave(sender As Object, e As EventArgs) Handles BTNSALIR.MouseLeave
        BTNSALIR.FlatAppearance.BorderColor = Color.Silver
        BTNSALIR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNIDENTIDAD_MouseEnter(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.MouseEnter
        BTNIDENTIDAD.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNIDENTIDAD.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNIDENTIDAD_MouseLeave(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.MouseLeave
        BTNIDENTIDAD.FlatAppearance.BorderColor = Color.Silver
        BTNIDENTIDAD.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNCORRELATIVO_Click(sender As Object, e As EventArgs) Handles BTNCORRELATIVO.Click
        ULTIMO_BITACORA()
        BUSQUEDAV.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        BUSQUEDAV.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        BUSQUEDAV.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        BUSQUEDAV.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        BUSQUEDAV.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        BUSQUEDAV.CBSI.Checked = True
        BUSQUEDAV.Show()
    End Sub

    Private Sub BTNCORRELATIVO_MouseEnter(sender As Object, e As EventArgs) Handles BTNCORRELATIVO.MouseEnter
        BTNCORRELATIVO.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNCORRELATIVO.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNCORRELATIVO_MouseLeave(sender As Object, e As EventArgs) Handles BTNCORRELATIVO.MouseLeave
        BTNCORRELATIVO.FlatAppearance.BorderColor = Color.Silver
        BTNCORRELATIVO.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNRESPONSABLE_Click(sender As Object, e As EventArgs) Handles BTNRESPONSABLE.Click
        If TXTIDENTIDAD.Text <> "0000-0000-00000" And (TXTCORRELATIVO.Text = "0000-0000" Or TXTCORRELATIVO.Text <> "0000-0000") Then
            CONTACTO_IMPRONTO.LBTIPO.Text = CMBBUSQUEDA.Text
            CONTACTO_IMPRONTO.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            CONTACTO_IMPRONTO.LBIDENTIDAD.Text = TXTIDENTIDAD.Text
            CONTACTO_IMPRONTO.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        ElseIf TXTCORRELATIVO.Text <> "0000-0000" And TXTIDENTIDAD.Text = "0000-0000-00000" Then
            CONTACTO_IMPRONTO.LBTIPO.Text = CMBBUSQUEDA.Text
            CONTACTO_IMPRONTO.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            CONTACTO_IMPRONTO.LBIDENTIDAD.Text = TXTCORRELATIVO.Text
            CONTACTO_IMPRONTO.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        End If
        CONTACTO_IMPRONTO.Show()
    End Sub
    
    Private Sub BTNIDENTIDAD_Click(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.Click
        ULTIMO_BITACORA()
        BUSQUEDAV.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        BUSQUEDAV.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        BUSQUEDAV.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        BUSQUEDAV.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        BUSQUEDAV.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        BUSQUEDAV.CBSI.Checked = True
        BUSQUEDAV.Show()
    End Sub

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        If TXTCORRELATIVO.Text.Length >= 8 Then
            BTNCORRELATIVO.Enabled = True
        ElseIf TXTCORRELATIVO.Text.Length <= 7 Then
            BTNCORRELATIVO.Enabled = False
        End If
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
        TXTCORRELATIVO.Focus()
        'TXTIDENTIDAD.Text = "0000-0000-00000"
        TXTNOMBRES.Text = "" : TXTPRIMERAPELLIDO.Text = "" : TXTSEGUNDOAPELLIDO.Text = ""
        CMBSEXO.Text = "" : FN.Value = DateTime.Now.Date
        TXTPAIS.Text = "" : TXTPADRE.Text = "" : TXTMADRE.Text = ""
        TXTBITACORA.Text = ""
        TXTEDAD.Text = "" : CMBTIPO.Text = ""
        TXTTELEFONO1.Text = "" : TXTTELEFONO2.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        TXTHORA.Text = UCase(Format(Now, "hh:mm tt"))
        TXTRESPONSABLE.Text = "" : TXTTELEFONO3.Text = ""
        TXTTELEFONO4.Text = "" : TXTDIRECCION.Text = ""
        TXTREMITENTE.Text = ""
        CMBPARENTEZCO.Text = Nothing
        INGRESO.Value = DateTime.Now.Date
        TXTMOTIVO.Text = "" : TXTFISICO.Text = ""
    End Sub

    Private Sub TXTTELEFONO3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTELEFONO3.KeyPress
        Dim TEXTO As String = TXTTELEFONO3.Text
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

        If TXTTELEFONO3.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTTELEFONO3.Text = TEXTO
            e.Handled = True
            TXTTELEFONO3.Select(TXTTELEFONO3.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTTELEFONO3_TextChanged(sender As Object, e As EventArgs) Handles TXTTELEFONO3.TextChanged

    End Sub

    Private Sub TXTTELEFONO4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTELEFONO4.KeyPress
        Dim TEXTO As String = TXTTELEFONO4.Text
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

        If TXTTELEFONO4.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTTELEFONO4.Text = TEXTO
            e.Handled = True
            TXTTELEFONO4.Select(TXTTELEFONO4.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTTELEFONO4_TextChanged(sender As Object, e As EventArgs) Handles TXTTELEFONO4.TextChanged

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

    Private Sub TXTNOMBRES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOMBRES.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
        Dim TEXTO As String = TXTNOMBRES.Text
        If TXTNOMBRES.Text.Length <= 6 Then
            If TXTNOMBRES.Text = "RN" Or TXTNOMBRES.Text = "R N" Or TXTNOMBRES.Text = "R/N" Or TXTNOMBRES.Text = "HIJO" Or _
                TXTNOMBRES.Text = "OBITO" Or TXTNOMBRES.Text = "RECIEN" Then
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

    Private Sub TXTPERSONA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPERSONA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTPERSONA_TextChanged(sender As Object, e As EventArgs) Handles TXTPERSONA.TextChanged

    End Sub

    Private Sub CMBSEXO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBSEXO.SelectedIndexChanged
        CMBSEXO.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CMBTIPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBTIPO.SelectedIndexChanged
        CMBTIPO.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CMBPRIORIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPRIORIDAD.SelectedIndexChanged
        CMBPRIORIDAD.DropDownStyle = ComboBoxStyle.DropDownList
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

    Private Sub TXTMOTIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMOTIVO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTMOTIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTMOTIVO.TextChanged

    End Sub

    Private Sub TXTFISICO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTFISICO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTFISICO_TextChanged(sender As Object, e As EventArgs) Handles TXTFISICO.TextChanged

    End Sub

    Private Sub TXTRESPONSABLE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTRESPONSABLE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTRESPONSABLE_TextChanged(sender As Object, e As EventArgs) Handles TXTRESPONSABLE.TextChanged

    End Sub

    Private Sub TXTDIRECCION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDIRECCION.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTDIRECCION_TextChanged(sender As Object, e As EventArgs) Handles TXTDIRECCION.TextChanged

    End Sub

    Private Sub TXTPARENTEZCO_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTPARENTEZCO_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BTNSALA_Click(sender As Object, e As EventArgs) Handles BTNSALA.Click
        BUSCAR_SALAS.Show()
    End Sub

    Private Sub CMBPARENTEZCO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPARENTEZCO.SelectedIndexChanged
        CMBPARENTEZCO.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        REIMPRIMIR_IMPRONTO.Show()
    End Sub
End Class