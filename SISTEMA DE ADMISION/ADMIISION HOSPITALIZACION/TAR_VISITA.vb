Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class TAR_VISITA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
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
    Sub ULTIMO_BITACORA()
        '-----------------------------------VER ULTIMO REGISTRO------------------------
        Dim CMD As New SqlCommand("SELECT * FROM TARJETA", CONE)
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
    Private Sub TAR_VISITA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DEPA()
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
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
        DTHORA.Text = Format(Now, "HH:MM")
        DTFECHA.Value = (DateTime.Now.Date)
        INICIAL.Value = DateTime.Now.Date
        FINAL.Value = INICIAL.Value.AddDays(6)
        CMBPARENTEZCO1.DropDownStyle = ComboBoxStyle.DropDownList
        CMBPARENTEZCO1.Items.Add("")
        CMBPARENTEZCO1.Items.Add("AMBULANCIA 911")
        CMBPARENTEZCO1.Items.Add("AMBULANCIA PRIVADA")
        CMBPARENTEZCO1.Items.Add("ABUELA")
        CMBPARENTEZCO1.Items.Add("ABUELO")
        CMBPARENTEZCO1.Items.Add("AMIGA")
        CMBPARENTEZCO1.Items.Add("AMIGO")
        CMBPARENTEZCO1.Items.Add("BOMBERO")
        CMBPARENTEZCO1.Items.Add("COMPAÑERA LABORAL")
        CMBPARENTEZCO1.Items.Add("COMPAÑERO LABORAL")
        CMBPARENTEZCO1.Items.Add("COPECO")
        CMBPARENTEZCO1.Items.Add("CUÑADA")
        CMBPARENTEZCO1.Items.Add("CUÑADO")
        CMBPARENTEZCO1.Items.Add("CRUZ ROJA")
        CMBPARENTEZCO1.Items.Add("DESCONOCIDO")
        CMBPARENTEZCO1.Items.Add("DERECHOS HUMANOS")
        CMBPARENTEZCO1.Items.Add("ESPOSA")
        CMBPARENTEZCO1.Items.Add("ESPOSO")
        CMBPARENTEZCO1.Items.Add("EX-ESPOSA")
        CMBPARENTEZCO1.Items.Add("EX-ESPOSO")
        CMBPARENTEZCO1.Items.Add("FISCALIA DE LA NIÑEZ")
        CMBPARENTEZCO1.Items.Add("FISCALIA")
        CMBPARENTEZCO1.Items.Add("HERMANA")
        CMBPARENTEZCO1.Items.Add("HERMANO")
        CMBPARENTEZCO1.Items.Add("HIJA")
        CMBPARENTEZCO1.Items.Add("HIJASTRA")
        CMBPARENTEZCO1.Items.Add("HIJASTRO")
        CMBPARENTEZCO1.Items.Add("HIJO")
        CMBPARENTEZCO1.Items.Add("JEFE LABORAL")
        CMBPARENTEZCO1.Items.Add("MADRASTRA")
        CMBPARENTEZCO1.Items.Add("MADRE")
        CMBPARENTEZCO1.Items.Add("NIETA")
        CMBPARENTEZCO1.Items.Add("NIETO")
        CMBPARENTEZCO1.Items.Add("NOVIA")
        CMBPARENTEZCO1.Items.Add("NOVIO")
        CMBPARENTEZCO1.Items.Add("NUERA")
        CMBPARENTEZCO1.Items.Add("PADRE")
        CMBPARENTEZCO1.Items.Add("PADRASTRO")
        CMBPARENTEZCO1.Items.Add("PAREJA")
        CMBPARENTEZCO1.Items.Add("PARIENTE POLITICO")
        CMBPARENTEZCO1.Items.Add("PRIMA")
        CMBPARENTEZCO1.Items.Add("PRIMO")
        CMBPARENTEZCO1.Items.Add("POLICIA ATIC")
        CMBPARENTEZCO1.Items.Add("POLICIA DPI")
        CMBPARENTEZCO1.Items.Add("POLICIA TRANSITO")
        CMBPARENTEZCO1.Items.Add("RESPONSABLE")
        CMBPARENTEZCO1.Items.Add("SOBRINA")
        CMBPARENTEZCO1.Items.Add("SOBRINO")
        CMBPARENTEZCO1.Items.Add("SUEGRA")
        CMBPARENTEZCO1.Items.Add("SUEGRO")
        CMBPARENTEZCO1.Items.Add("TIA")
        CMBPARENTEZCO1.Items.Add("TIO")
        CMBPARENTEZCO1.Items.Add("TUTOR")
        CMBPARENTEZCO1.Items.Add("VECINA")
        CMBPARENTEZCO1.Items.Add("VECINO")
        CMBPARENTEZCO1.Items.Add("YERNO")
        CMBPARENTEZCO2.DropDownStyle = ComboBoxStyle.DropDownList
        CMBPARENTEZCO2.Items.Add("")
        CMBPARENTEZCO2.Items.Add("AMBULANCIA 911")
        CMBPARENTEZCO2.Items.Add("AMBULANCIA PRIVADA")
        CMBPARENTEZCO2.Items.Add("ABUELA")
        CMBPARENTEZCO2.Items.Add("ABUELO")
        CMBPARENTEZCO2.Items.Add("AMIGA")
        CMBPARENTEZCO2.Items.Add("AMIGO")
        CMBPARENTEZCO2.Items.Add("BOMBERO")
        CMBPARENTEZCO2.Items.Add("COMPAÑERA LABORAL")
        CMBPARENTEZCO2.Items.Add("COMPAÑERO LABORAL")
        CMBPARENTEZCO2.Items.Add("COPECO")
        CMBPARENTEZCO2.Items.Add("CUÑADA")
        CMBPARENTEZCO2.Items.Add("CUÑADO")
        CMBPARENTEZCO2.Items.Add("CRUZ ROJA")
        CMBPARENTEZCO2.Items.Add("DESCONOCIDO")
        CMBPARENTEZCO2.Items.Add("DERECHOS HUMANOS")
        CMBPARENTEZCO2.Items.Add("ESPOSA")
        CMBPARENTEZCO2.Items.Add("ESPOSO")
        CMBPARENTEZCO2.Items.Add("EX-ESPOSA")
        CMBPARENTEZCO2.Items.Add("EX-ESPOSO")
        CMBPARENTEZCO2.Items.Add("FISCALIA DE LA NIÑEZ")
        CMBPARENTEZCO2.Items.Add("FISCALIA")
        CMBPARENTEZCO2.Items.Add("HERMANA")
        CMBPARENTEZCO2.Items.Add("HERMANO")
        CMBPARENTEZCO2.Items.Add("HIJA")
        CMBPARENTEZCO2.Items.Add("HIJASTRA")
        CMBPARENTEZCO2.Items.Add("HIJASTRO")
        CMBPARENTEZCO2.Items.Add("HIJO")
        CMBPARENTEZCO2.Items.Add("JEFE LABORAL")
        CMBPARENTEZCO2.Items.Add("MADRASTRA")
        CMBPARENTEZCO2.Items.Add("MADRE")
        CMBPARENTEZCO2.Items.Add("NIETA")
        CMBPARENTEZCO2.Items.Add("NIETO")
        CMBPARENTEZCO2.Items.Add("NOVIA")
        CMBPARENTEZCO2.Items.Add("NOVIO")
        CMBPARENTEZCO2.Items.Add("NUERA")
        CMBPARENTEZCO2.Items.Add("PADRE")
        CMBPARENTEZCO2.Items.Add("PADRASTRO")
        CMBPARENTEZCO2.Items.Add("PAREJA")
        CMBPARENTEZCO2.Items.Add("PARIENTE POLITICO")
        CMBPARENTEZCO2.Items.Add("PRIMA")
        CMBPARENTEZCO2.Items.Add("PRIMO")
        CMBPARENTEZCO2.Items.Add("POLICIA ATIC")
        CMBPARENTEZCO2.Items.Add("POLICIA DPI")
        CMBPARENTEZCO2.Items.Add("POLICIA TRANSITO")
        CMBPARENTEZCO2.Items.Add("RESPONSABLE")
        CMBPARENTEZCO2.Items.Add("SOBRINA")
        CMBPARENTEZCO2.Items.Add("SOBRINO")
        CMBPARENTEZCO2.Items.Add("SUEGRA")
        CMBPARENTEZCO2.Items.Add("SUEGRO")
        CMBPARENTEZCO2.Items.Add("TIA")
        CMBPARENTEZCO2.Items.Add("TIO")
        CMBPARENTEZCO2.Items.Add("TUTOR")
        CMBPARENTEZCO2.Items.Add("VECINA")
        CMBPARENTEZCO2.Items.Add("VECINO")
        CMBPARENTEZCO2.Items.Add("YERNO")
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub INICIAL_CloseUp(sender As Object, e As EventArgs) Handles INICIAL.CloseUp
        FINAL.Value = INICIAL.Value.AddDays(6)
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

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
            LBPAIS.Visible = False : TXTPAIS.Visible = False
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
            TXTNOMBRES.Enabled = False : TXTPRIMERAPELLIDO.Enabled = False
            TXTSEGUNDOAPELLIDO.Enabled = False
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
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
            TXTIDENTIDAD.Enabled = True
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
        TXTSALA.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        DTHORA.Text = UCase(Format(Now, "hh:mm tt"))
    End Sub

    Private Sub TXTCORRELATIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCORRELATIVO.KeyPress
        Dim TEXTO As String = TXTCORRELATIVO.Text
        If Char.IsNumber(e.KeyChar) Then 'COMPARA SI ES NUMERO
            e.Handled = False 'PERMITE ESCRITURA
        ElseIf Char.IsControl(e.KeyChar) Then 'COMPARA SI TECLA ES BORAR
            e.Handled = False 'PERMITE ESCRITURA
            'ElseIf Char.IsSeparator(e.KeyChar) Then 'COMPARA QUE SEA ESPACIO
            '   e.Handled = False 'PERMITE ESCRITURA
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
        TXTSALA.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        DTHORA.Text = UCase(Format(Now, "hh:mm tt"))
    End Sub
    Private Sub BTNINGRESO_Click(sender As Object, e As EventArgs) Handles BTNINGRESO.Click
        If TXTIDENTIDAD.Text <> "0000-0000-00000" And (TXTCORRELATIVO.Text = "0000-0000" Or TXTCORRELATIVO.Text <> "0000-0000") Then
            TAR_HOSPSALA.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            TAR_HOSPSALA.LBTIPO.Text = CMBBUSQUEDA.Text
            TAR_HOSPSALA.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            TAR_HOSPSALA.LBIDENTIDAD.Text = TXTIDENTIDAD.Text
            TAR_HOSPSALA.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        ElseIf TXTCORRELATIVO.Text <> "0000-0000" And (TXTIDENTIDAD.Text = "0000-0000-00000") Then
            TAR_HOSPSALA.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            TAR_HOSPSALA.LBTIPO.Text = CMBBUSQUEDA.Text
            TAR_HOSPSALA.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            TAR_HOSPSALA.LBIDENTIDAD.Text = TXTCORRELATIVO.Text
            TAR_HOSPSALA.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        End If
        TAR_HOSPSALA.Show()
    End Sub

    Private Sub BTNIDENTIDAD_Click(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.Click
        ULTIMO_BITACORA()
        BUSQUEDATAR.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        BUSQUEDATAR.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        BUSQUEDATAR.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        BUSQUEDATAR.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        BUSQUEDATAR.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        BUSQUEDATAR.CBSI.Checked = True
        BUSQUEDATAR.Show()
    End Sub

    Private Sub TXT1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT1.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXT1_TextChanged(sender As Object, e As EventArgs) Handles TXT1.TextChanged

    End Sub

    Private Sub TXT2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT2.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXT2_TextChanged(sender As Object, e As EventArgs) Handles TXT2.TextChanged

    End Sub

    Private Sub BTNCORRELATIVO_Click(sender As Object, e As EventArgs) Handles BTNCORRELATIVO.Click
        ULTIMO_BITACORA()
        BUSQUEDATAR.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        BUSQUEDATAR.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        BUSQUEDATAR.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        BUSQUEDATAR.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        BUSQUEDATAR.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        BUSQUEDATAR.CBSI.Checked = True
        BUSQUEDATAR.Show()
    End Sub

    Private Sub BTNSALA_Click(sender As Object, e As EventArgs) Handles BTNSALA.Click
        TAR_SALA.Show()
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
            If TXTIDENTIDAD.Text = "" Then
                TXTIDENTIDAD.Text = "0000-0000-00000"
            End If
            If TXTCORRELATIVO.Text = "" Then
                TXTCORRELATIVO.Text = "0000-0000"
            End If
            Dim DEF As String = "0101-01-01"
            Dim LUNES As String = "NO"
            Dim MARTES As String = "NO"
            Dim MIERCOLES As String = "NO"
            Dim JUEVES As String = "NO"
            Dim VIERNES As String = "NO"
            Dim SABADO As String = "NO"
            Dim DOMINGO As String = "NO"
            Try
                '------------------------------------GUARDAR UNICO------------------------
                CONE.Open()
                Dim GUARDAR As String = "INSERT INTO UNICO (NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD," _
                & "TIPO_EDAD, CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO," _
                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, FECHA_NACIMIENTO, DEFUNCION)" _
                & "VALUES ('" & CMBNACIONALIDAD.Text & "','" & PAIS & "','" & CMBCLASIFICACION.Text & "','" _
                & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & TXTEDAD.Text & "','" _
                & CMBTIPO.Text & "','" & TXTCORRELATIVO.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTCOLONIA.Text & "','" _
                & TXTCASA.Text & "','" & CMBDEPARTAMENTO.Text & "','" & CMBMUNICIPIO.Text & "','" & TXTTELEFONO1.Text & "','" _
                & TXTTELEFONO2.Text & "','" & CMBSEXO.Text & "','" & TXTPADRE.Text & "','" & TXTMADRE.Text & "','" & LUNES & "','" _
                & MARTES & "','" & MIERCOLES & "','" & JUEVES & "','" & VIERNES & "','" & SABADO & "','" & DOMINGO & "','" _
                & FECHA & "','" & DEF & "')"
                Dim COMAND As SqlCommand
                COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN TABLA UNICO
                COMAND.ExecuteNonQuery()
                'MsgBox("REGISTRO GUARDADO CON EXITO EN TABLA UNICO", MsgBoxStyle.Information, AcceptButton)
                CONE.Close()
                '------------------TERMINAR DE GUARDAR EN TABLA UNICO---------------------
                '-------------------------------GUARDAR EN TABLA IMPRONTO-------------------
                CONE.Open()
                Dim FECHA_HOS As String = Format(CDate(DTFECHA.Value), "yyyy/MM/dd")
                Dim HORA_HOS As String = DTHORA.Text
                Dim FECHA_INI As String = Format(CDate(INICIAL.Value), "yyyy/MM/dd")
                Dim FECHA_FIN As String = Format(CDate(FINAL.Value), "yyyy/MM/dd")
                '------------------------------------------------------------
                Dim TARJETA As String = "INSERT INTO TARJETA (TIPO, NACIONALIDAD, " _
                & "IDENTIDAD, CORRELATIVO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, EDAD, TIPO_EDAD, " _
                & "SALA_HOS, FAMILIA1, PARENTEZCO1, FAMILIA2, PARENTEZCO2, FECHA_HOS, HORA_ING, INICIAL, FINAL)" _
                & "VALUES ('" & CMBCLASIFICACION.Text & "','" & CMBNACIONALIDAD.Text & "','" & "','" & TXTIDENTIDAD.Text & "','" _
                & TXTCORRELATIVO.Text & " ','" & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" _
                & TXTSEGUNDOAPELLIDO.Text & "','" & CMBSEXO.Text & "','" & TXTEDAD.Text & "','" & CMBTIPO.Text & "','" _
                & TXTSALA.Text & "','" & TXT1.Text & "','" & CMBPARENTEZCO1.Text & "','" & TXT2.Text & "','" _
                & CMBPARENTEZCO2.Text & "','" & FECHA_HOS & "','" & HORA_HOS & "','" & "','" & FECHA_FIN & "','" & FECHA_FIN & "')"
                Dim COMANDO As SqlCommand
                COMANDO = New SqlCommand(TARJETA, CONE) 'INSERTAR REGISTRO EN TABLA IMPRONTO
                COMANDO.ExecuteNonQuery()
                MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
                CONE.Close()
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
    Sub MODIFICAR_IDENTIDAD()
        If MsgBox("DESEA CONTINUAR CON EL PROCESO DE MODIFICACION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            If TXTCORRELATIVO.Text = "" Then
                TXTCORRELATIVO.Text = "0000-0000"
            End If
            Try
                '-------------------------------GUARDAR EN TABLA IMPRONTO-------------------
                CONE.Open()
                Dim FECHA_HOS As String = Format(CDate(DTFECHA.Value), "yyyy/MM/dd")
                Dim HORA_HOS As String = DTHORA.Text
                Dim FECHA_INI As String = Format(CDate(INICIAL.Value), "yyyy/MM/dd")
                Dim FECHA_FIN As String = Format(CDate(FINAL.Value), "yyyy/MM/dd")
                '------------------------------------------------------------
                Dim TARJETA As String = "INSERT INTO TARJETA (TIPO, NACIONALIDAD, " _
                & "IDENTIDAD, CORRELATIVO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, EDAD, TIPO_EDAD, " _
                & "SALA_HOS, FAMILIA1, PARENTEZCO1, FAMILIA2, PARENTEZCO2, FECHA_HOS, HORA_ING, INICIAL, FINAL)" _
                & "VALUES ('" & CMBCLASIFICACION.Text & "','" & CMBNACIONALIDAD.Text & "','" & TXTIDENTIDAD.Text & "','" _
                & TXTCORRELATIVO.Text & "','" & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" _
                & TXTSEGUNDOAPELLIDO.Text & "','" & CMBSEXO.Text & "','" & TXTEDAD.Text & "','" & CMBTIPO.Text & "','" _
                & TXTSALA.Text & "','" & TXT1.Text & "','" & CMBPARENTEZCO1.Text & "','" & TXT2.Text & "','" _
                & CMBPARENTEZCO2.Text & "','" & FECHA_HOS & "','" & HORA_HOS & "','" & FECHA_INI & "','" & FECHA_FIN & "')"
                Dim COMANDO As SqlCommand
                COMANDO = New SqlCommand(TARJETA, CONE) 'INSERTAR REGISTRO EN TABLA IMPRONTO
                COMANDO.ExecuteNonQuery()
                MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
                CONE.Close()
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
            If TXTCORRELATIVO.Text = "" Then
                TXTCORRELATIVO.Text = "0000-0000"
            End If
            Try
                '-------------------------------GUARDAR EN TABLA IMPRONTO-------------------
                CONE.Open()
                Dim FECHA_HOS As String = Format(CDate(DTFECHA.Value), "yyyy/MM/dd")
                Dim HORA_HOS As String = DTHORA.Text
                Dim FECHA_INI As String = Format(CDate(INICIAL.Value), "yyyy/MM/dd")
                Dim FECHA_FIN As String = Format(CDate(FINAL.Value), "yyyy/MM/dd")
                '------------------------------------------------------------
                Dim TARJETA As String = "INSERT INTO TARJETA (TIPO, NACIONALIDAD, " _
                & "IDENTIDAD, CORRELATIVO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, SEXO, EDAD, TIPO_EDAD, " _
                & "SALA_HOS, FAMILIA1, PARENTEZCO1, FAMILIA2, PARENTEZCO2, FECHA_HOS, HORA_ING, INICIAL, FINAL)" _
                & "VALUES ('" & CMBCLASIFICACION.Text & "','" & CMBNACIONALIDAD.Text & "','" & TXTIDENTIDAD.Text & "','" _
                & TXTCORRELATIVO.Text & "','" & TXTNOMBRES.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" _
                & TXTSEGUNDOAPELLIDO.Text & "','" & CMBSEXO.Text & "','" & TXTEDAD.Text & "','" & CMBTIPO.Text & "','" _
                & TXTSALA.Text & "','" & TXT1.Text & "','" & CMBPARENTEZCO1.Text & "','" & TXT2.Text & "','" _
                & CMBPARENTEZCO2.Text & "','" & FECHA_HOS & "','" & HORA_HOS & "','" & FECHA_INI & "','" & FECHA_FIN & "')"
                Dim COMANDO As SqlCommand
                COMANDO = New SqlCommand(TARJETA, CONE) 'INSERTAR REGISTRO EN TABLA IMPRONTO
                COMANDO.ExecuteNonQuery()
                MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
                CONE.Close()
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
    Private Sub BTNGUARDA_Click(sender As Object, e As EventArgs) Handles BTNGUARDA.Click
        If TXTNOMBRES.Text <> "" Or TXTSALA.Text <> "" Or CMBSEXO.Text <> "" Then
            If TXTIDENTIDAD.Text <> "" Or TXTCORRELATIVO.Text <> "" Or (TXTIDENTIDAD.Text = "0000-0000-00000" And _
               TXTCORRELATIVO.Text <> "0000-0000") Then
                GUARDAR_IDENTIDAD()
            End If
        Else
            MsgBox("REVISE LOS CAMPOS NOMBRE, SALA, SEXO YA QUE NO PUEDEN QUEDAR VACIO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
        End If
    End Sub

    Private Sub BTNMODIFICA_Click(sender As Object, e As EventArgs) Handles BTNMODIFICA.Click
        If TXTNOMBRES.Text <> "" Or TXTSALA.Text <> "" Or CMBSEXO.Text <> "" Then
            If (TXTCORRELATIVO.Text <> "" Or TXTCORRELATIVO.Text = "0000-0000") And (TXTIDENTIDAD.Text <> "0000-0000-00000") Then
                MODIFICAR_IDENTIDAD()
            ElseIf (TXTIDENTIDAD.Text <> "" Or TXTIDENTIDAD.Text = "0000-0000-00000") And (TXTCORRELATIVO.Text <> "0000-0000") Then
                MODIFICAR_CORRELATIVO()
            ElseIf TXTCORRELATIVO.Text <> "0000-0000" And TXTIDENTIDAD.Text <> "0000-0000-00000" And _
                TXTCORRELATIVO.Text <> "" And TXTIDENTIDAD.Text <> "" Then
                MODIFICAR_IDENTIDAD()
            End If
        Else
            MsgBox("REVISAR LOS CAMPO: NOMBRE, SALA, SEXO YA QUE NO PUEDEN QUEDAR VACIO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
        End If
    End Sub

    Private Sub CMBPARENTEZCO2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPARENTEZCO2.SelectedIndexChanged
        CMBPARENTEZCO2.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CMBPARENTEZCO1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPARENTEZCO1.SelectedIndexChanged
        CMBPARENTEZCO1.DropDownStyle = ComboBoxStyle.DropDownList
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

    Private Sub CMBSEXO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBSEXO.SelectedIndexChanged
        CMBSEXO.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CMBTIPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBTIPO.SelectedIndexChanged
        CMBTIPO.DropDownStyle = ComboBoxStyle.DropDownList
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

    Private Sub TXTCOLONIA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCOLONIA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCOLONIA_TextChanged(sender As Object, e As EventArgs) Handles TXTCOLONIA.TextChanged

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

    Private Sub TXTNOMBRES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOMBRES.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
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

    Private Sub TXTCASA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCASA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCASA_TextChanged(sender As Object, e As EventArgs) Handles TXTCASA.TextChanged

    End Sub

    Private Sub CMBDEPARTAMENTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBDEPARTAMENTO.SelectedIndexChanged
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBDEPARTAMENTO.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_DEPARTAMENTO, DEPARTAMENTO FROM DEPARTAMENTO_HONDURAS WHERE DEPARTAMENTO ='" _
                                & CMBDEPARTAMENTO.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "DEPARTAMENTO_HONDURAS")
        TXTCOD_DEPA.Text = CMBDEPARTAMENTO.SelectedItem("CODIGO_DEPARTAMENTO").ToString
        '---------------------------------------------------------------------------------------
        Dim ADAPTA As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE " _
        & "CODIGO_DEPARTAMENTO ='" & TXTCOD_DEPA.Text & "'"
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
        Dim COMANDO As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE " _
                                & "CODIGO_DEPARTAMENTO ='" & TXTCOD_DEPA.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "MUNICIPIO_HONDURAS")
        TXTCOD_MUNI.Text = CMBMUNICIPIO.SelectedItem("CODIGO_MUNICIPIO").ToString
        '---------------------------------------------------------------------------------------
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
End Class