Public Class REIMPRIMIR_HOSPITALIZACION
    Private Sub REIMPRIMIR_HOSPITALIZACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        INGRESO.Value = DateTime.Now.Date
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
        CMBNACIONALIDAD.Focus()
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
        CMBBUSQUEDA.Enabled = False
        CMBBUSQUEDA.Items.Add("")
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        TXTIDENTIDAD.Text = ""
        TXTCORRELATIVO.Text = ""
        TXTNOMBRES.Text = "" : TXTPRIMERAPELLIDO.Text = ""
        TXTSEGUNDOAPELLIDO.Text = "" : CMBSEXO.Text = ""
        TXTPAIS.Text = "" : TXTPADRE.Text = ""
        TXTMADRE.Text = "" : TXTEDAD.Text = ""
        CMBTIPO.Text = "" : CMBESTADO.Text = ""
        CMBOCUPACION.Text = "" : CMBINGRESO.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        CMBDEPARTAMENTO.Text = "" : CMBMUNICIPIO.Text = ""
        TXTRESPONSABLE.Text = "" : TXTTELEFONO1.Text = "" : TXTTELEFONO2.Text = ""
        TXTDIRECCION.Text = ""
        CMBPARENTEZCO.Text = ""
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            LBPAIS.Visible = False : TXTPAIS.Visible = False
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
            LBPAIS.Visible = True : TXTPAIS.Visible = True
        End If
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBBUSQUEDA.Text = "" Then
            TXTNOMBRES.Text = ""
            TXTPRIMERAPELLIDO.Text = ""
            TXTSEGUNDOAPELLIDO.Text = ""
            CMBSEXO.Text = ""
            TXTPAIS.Text = ""
            FN.Value = (DateTime.Now.Date)
            TXTPADRE.Text = ""
            TXTMADRE.Text = ""
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            TXTTELEFONO1.Text = ""
            TXTTELEFONO2.Text = ""
            TXTCOLONIA.Text = ""
            TXTCASA.Text = ""
            CMBDEPARTAMENTO.Text = ""
            CMBMUNICIPIO.Text = ""
            TXTRESPONSABLE.Text = ""
            TXTDIRECCION.Text = ""
            CMBESTADO.Text = ""
            CMBOCUPACION.Text = ""
            CMBINGRESO.Text = ""
            TXTFECHA_BUSQUEDA.Text = "" : TXTFECHA_BUSQUEDA.Enabled = False
            TXTCORRELATIVO.Text = "" : TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            BTNBUSQUEDA.Visible = False
            BTNREIMPRIMIR.Enabled = False
        ElseIf CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTNOMBRES.Text = ""
            TXTPRIMERAPELLIDO.Text = ""
            TXTSEGUNDOAPELLIDO.Text = ""
            CMBSEXO.Text = ""
            TXTPAIS.Text = ""
            FN.Value = (DateTime.Now.Date)
            TXTPADRE.Text = ""
            TXTMADRE.Text = ""
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            TXTTELEFONO1.Text = ""
            TXTTELEFONO2.Text = ""
            TXTCOLONIA.Text = ""
            TXTCASA.Text = ""
            CMBDEPARTAMENTO.Text = ""
            CMBMUNICIPIO.Text = ""
            TXTRESPONSABLE.Text = ""
            TXTDIRECCION.Text = ""
            CMBESTADO.Text = ""
            CMBOCUPACION.Text = ""
            CMBINGRESO.Text = ""
            TXTFECHA_BUSQUEDA.Text = "" : TXTFECHA_BUSQUEDA.Enabled = False
            TXTCORRELATIVO.Text = "0000-0000" : TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = True
            BTNBUSQUEDA.Visible = False
            BTNREIMPRIMIR.Enabled = False
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTNOMBRES.Text = ""
            TXTPRIMERAPELLIDO.Text = ""
            TXTSEGUNDOAPELLIDO.Text = ""
            CMBSEXO.Text = ""
            TXTPAIS.Text = ""
            FN.Value = (DateTime.Now.Date)
            TXTPADRE.Text = ""
            TXTMADRE.Text = ""
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            TXTTELEFONO1.Text = ""
            TXTTELEFONO2.Text = ""
            TXTCOLONIA.Text = ""
            TXTCASA.Text = ""
            CMBDEPARTAMENTO.Text = ""
            CMBMUNICIPIO.Text = ""
            TXTRESPONSABLE.Text = ""
            TXTDIRECCION.Text = ""
            CMBESTADO.Text = ""
            CMBOCUPACION.Text = ""
            CMBINGRESO.Text = ""
            TXTFECHA_BUSQUEDA.Text = "" : TXTFECHA_BUSQUEDA.Enabled = False
            TXTCORRELATIVO.Text = "" : TXTCORRELATIVO.Enabled = True
            TXTIDENTIDAD.Text = "0000-0000-00000" : TXTIDENTIDAD.Enabled = False
            BTNBUSQUEDA.Visible = False
            BTNREIMPRIMIR.Enabled = False
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
                BTNBUSQUEDA.Focus()
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
                BTNBUSQUEDA.Visible = True
                BTNBUSQUEDA.Focus()
            ElseIf TXTIDENTIDAD.Text.Length < 15 Then
                BTNBUSQUEDA.Visible = False
                BTNREIMPRIMIR.Enabled = False
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
            If TXTIDENTIDAD.Text.Length >= 6 Then
                BTNBUSQUEDA.Visible = True
            ElseIf TXTIDENTIDAD.Text.Length <= 5 Then
                BTNBUSQUEDA.Visible = False
                BTNREIMPRIMIR.Enabled = False
            End If
        End If
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
    End Sub

    Private Sub TXTCORRELATIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCORRELATIVO.KeyPress
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

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
        TXTCORRELATIVO.Focus()
        If TXTCORRELATIVO.Text.Length >= 6 Then
            BTNBUSQUEDA.Visible = True
            BTNBUSQUEDA.Focus()
        ElseIf TXTCORRELATIVO.Text.Length <= 5 Then
            BTNBUSQUEDA.Visible = False
        End If
    End Sub

    Private Sub BTNBUSQUEDA_Click(sender As Object, e As EventArgs) Handles BTNBUSQUEDA.Click
        If TXTIDENTIDAD.Text <> "0000-0000-00000" And (TXTCORRELATIVO.Text = "0000-0000" Or TXTCORRELATIVO.Text <> "0000-0000") Then
            BUSQUEDA_HOSPITALIZACION.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
            BUSQUEDA_HOSPITALIZACION.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            BUSQUEDA_HOSPITALIZACION.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            BUSQUEDA_HOSPITALIZACION.LBTIPO.Text = CMBBUSQUEDA.Text
            BUSQUEDA_HOSPITALIZACION.LBIDENTIDAD.Text = TXTIDENTIDAD.Text
        ElseIf TXTCORRELATIVO.Text <> "0000-0000" And (TXTIDENTIDAD.Text = "0000-0000-00000") Then
            BUSQUEDA_HOSPITALIZACION.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
            BUSQUEDA_HOSPITALIZACION.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            BUSQUEDA_HOSPITALIZACION.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            BUSQUEDA_HOSPITALIZACION.LBTIPO.Text = CMBBUSQUEDA.Text
            BUSQUEDA_HOSPITALIZACION.LBIDENTIDAD.Text = TXTCORRELATIVO.Text
        End If
        BUSQUEDA_HOSPITALIZACION.Show()
    End Sub
    Sub IMPRIMIR_HOSPITALIZACION()
        If MsgBox("DESEA IMPRIMIR LA HOJA HOSPITALIZACION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            Dim TIPO As String = ""
            Dim REPORT As New RP_HOSPITALIZACION
            If CMBTIPO.Text = "4. AÑOS" Then
                TIPO = "4"
            ElseIf CMBTIPO.Text = "3. MESES" Then
                TIPO = "3"
            ElseIf CMBTIPO.Text = "2. DIAS" Then
                TIPO = "2"
            ElseIf CMBTIPO.Text = "1. HORAS" Then
                TIPO = "1"
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

            Dim T_ING As String = ""
            If CMBINGRESO.Text = "1. CONSULTA EXTERNA" Then
                T_ING = "1"
            ElseIf CMBINGRESO.Text = "2. EMERGENCIA" Then
                T_ING = "2"
            ElseIf CMBINGRESO.Text = "3. NACIMIENTO" Then
                T_ING = "3"
            End If

            Dim SEXO As String = ""
            If CMBSEXO.Text = "1. HOMBRE" Then
                SEXO = "1"
            ElseIf CMBSEXO.Text = "2. MUJER" Then
                SEXO = "2"
            End If

            Dim ESTADO As String = ""
            If CMBESTADO.Text = "1. CASADO" Then
                ESTADO = "1"
            ElseIf CMBESTADO.Text = "2. SOLTERO" Then
                ESTADO = "2"
            ElseIf CMBESTADO.Text = "3. VIUDO" Then
                ESTADO = "3"
            ElseIf CMBESTADO.Text = "4. UNION LIBRE" Then
                ESTADO = "4"
            ElseIf CMBESTADO.Text = "5. DESCONOCIDO" Then
                ESTADO = "5"
            End If

            Dim OCUPACION As String = ""
            If CMBOCUPACION.Text = "1. EMPLEADO PUBLICO" Then
                OCUPACION = "1"
            ElseIf CMBOCUPACION.Text = "2. EMPLEADO PRIVADO" Then
                OCUPACION = "2"
            ElseIf CMBOCUPACION.Text = "3. SERVICIO DOMESTICO" Then
                OCUPACION = "3"
            ElseIf CMBOCUPACION.Text = "4. DESEMPLEADO" Then
                OCUPACION = "4"
            ElseIf CMBOCUPACION.Text = "5. NEGOCIO PROPIO O SOCIO" Then
                OCUPACION = "5"
            ElseIf CMBOCUPACION.Text = "6. OTROS" Then
                OCUPACION = "6"
            ElseIf CMBOCUPACION.Text = "7. NO APLICA" Then
                OCUPACION = "7"
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

            Dim NUEVO As String = Strings.Right(LOGIN.TXTIDENTIDAD.Text, 4)
            REPORT.SetParameterValue("TXTCLAVE", NUEVO)
            REPORT.SetParameterValue("TXTIDENTIDAD", IDENTIDAD)
            REPORT.SetParameterValue("TXTCORRELATIVO", CORRELATIVO)
            REPORT.SetParameterValue("TXTPRIMER", TXTPRIMERAPELLIDO.Text)
            REPORT.SetParameterValue("TXTSEGUNDO", TXTSEGUNDOAPELLIDO.Text)
            REPORT.SetParameterValue("TXTNOMBRES", NOMBRE)
            REPORT.SetParameterValue("TXTSEXO", SEXO)
            REPORT.SetParameterValue("TXTEDAD", TXTEDAD.Text)
            REPORT.SetParameterValue("TXTTIPO", TIPO)
            REPORT.SetParameterValue("TXTFECHA", Format(FN.Value, "dd/MMM/yyyy"))
            REPORT.SetParameterValue("TXTHORA", TXTHORA.Text)
            REPORT.SetParameterValue("TXTFECHA_INGRESO", INGRESO.Value)
            REPORT.SetParameterValue("TXTINGRESO", T_ING)
            REPORT.SetParameterValue("TXTESTADO", ESTADO)
            REPORT.SetParameterValue("TXTOCUPACION", OCUPACION)
            REPORT.SetParameterValue("TXTSALA", TXTSALA.Text)
            REPORT.SetParameterValue("TXTSERVICIO", TXTSERVICIO.Text)
            REPORT.SetParameterValue("TXTCOLONIA", TXTCOLONIA.Text & ", " & TXTCASA.Text)
            REPORT.SetParameterValue("TXTDEPARTAMENTO", DEPA)
            REPORT.SetParameterValue("TXTMUNICIPIO", MUNI)
            REPORT.SetParameterValue("TXTPADRE", TXTPADRE.Text)
            REPORT.SetParameterValue("TXTMADRE", TXTMADRE.Text)
            REPORT.SetParameterValue("TXTCONTACTO", TXTRESPONSABLE.Text & "(" & CMBPARENTEZCO.Text & ")")
            REPORT.SetParameterValue("TXTDIRCONTACTO", TXTDIRECCION.Text)
            REPORT.SetParameterValue("TXTTELEFONO", TXTTELEFONO1.Text & " / " & TXTTELEFONO2.Text)
            RPHOSPITALIZACION.CrystalReportViewer1.ReportSource = REPORT
            RPHOSPITALIZACION.CrystalReportViewer1.Refresh()
            RPHOSPITALIZACION.Show()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub BTNREIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNREIMPRIMIR.Click
        If MsgBox("DESEA CONTINUAR CON EL PROCESO", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            IMPRIMIR_HOSPITALIZACION()
            Me.Close()
        Else
            TXTIDENTIDAD.Focus()
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub TXTNOMBRES_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBRES.TextChanged
        BTNREIMPRIMIR.Enabled = True
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class