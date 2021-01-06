Public Class REIMPRIMIRDEF
    Private Sub REIMPRIMIRDEF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
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
        CMBNACIONALIDAD.Items.Add("")
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
        CMBBUSQUEDA.Items.Add("")
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
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
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
        End If
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBBUSQUEDA.Text = "" Then
            TXTIDENTIDAD.Enabled = False
            TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
        ElseIf CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTIDENTIDAD.Enabled = True
            TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = "0000-0000"
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTIDENTIDAD.Enabled = False
            TXTCORRELATIVO.Enabled = True
            TXTIDENTIDAD.Text = "0000-0000-00000"
            TXTCORRELATIVO.Text = ""
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
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.MaxLength = 15
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNBUSQUEDA.Enabled = True
            ElseIf TXTIDENTIDAD.Text.Length < 15 Then
                BTNBUSQUEDA.Enabled = False
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
            If TXTIDENTIDAD.Text.Length >= 6 Then
                BTNBUSQUEDA.Enabled = True
            ElseIf TXTIDENTIDAD.Text.Length <= 5 Then
                BTNBUSQUEDA.Enabled = False
            End If
        End If
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
        TXTIDENTIDAD.Focus()
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
        If TXTCORRELATIVO.Text.Length >= 8 Then
            BTNBUSQUEDA.Enabled = True
        ElseIf TXTCORRELATIVO.Text.Length <= 7 Then
            BTNBUSQUEDA.Enabled = False
        End If
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
        TXTCORRELATIVO.Focus()
    End Sub

    Private Sub BTNBUSQUEDA_Click(sender As Object, e As EventArgs) Handles BTNBUSQUEDA.Click
        If TXTIDENTIDAD.Text <> "0000-0000-00000" And (TXTCORRELATIVO.Text = "0000-0000" Or TXTCORRELATIVO.Text <> "0000-0000") Then
            BUSCAR_DEF.LBTIPO.Text = CMBBUSQUEDA.Text
            BUSCAR_DEF.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            BUSCAR_DEF.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            BUSCAR_DEF.LBIDENTIDAD.Text = TXTIDENTIDAD.Text
            BUSCAR_DEF.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        ElseIf TXTCORRELATIVO.Text <> "0000-0000" And (TXTIDENTIDAD.Text = "0000-0000-00000") Then
            BUSCAR_DEF.LBTIPO.Text = CMBBUSQUEDA.Text
            BUSCAR_DEF.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            BUSCAR_DEF.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            BUSCAR_DEF.LBIDENTIDAD.Text = TXTCORRELATIVO.Text
            BUSCAR_DEF.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        End If
        BUSCAR_DEF.Show()
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNREIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNREIMPRIMIR.Click
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

            REPORT.SetParameterValue("TXTNOMBRE", NOMBRE)
            REPORT.SetParameterValue("TXTSEXO", SEXO)
            REPORT.SetParameterValue("TXTEDAD", TXTEDAD.Text & " " & TIPO)
            REPORT.SetParameterValue("TXTCLINICA", IDENTIDAD)
            REPORT.SetParameterValue("TXTDIRECCION", TXTCOLONIA.Text & "," & CMBMUNICIPIO.Text & "," & CMBDEPARTAMENTO.Text)
            REPORT.SetParameterValue("TXTINGRESO", INGRESO.Text)
            REPORT.SetParameterValue("TXTHORAING", HORA_INGRESO.Text)
            REPORT.SetParameterValue("TXTSALA", TXTSALA.Text)
            REPORT.SetParameterValue("TXTFECHADEF", DEFUNCION.Text)
            REPORT.SetParameterValue("TXTHORADEF", HORA_DEFUNCION.Text)
            REPORT.SetParameterValue("TXTMEDICO", TXTMEDICO.Text)
            REPORT.SetParameterValue("TXTDIAGNOSTICO", TXTDIAGNOSTICO.Text)
            REPORT.SetParameterValue("TXTFECHAHORAAREA", RECEPCION.Text & "  " & HORA_RECEPCION.Text)
            REPORT.SetParameterValue("TXTAREA", TXTREPORTE.Text)
            REPORT.SetParameterValue("TXTFISCALIA", TXTFISCALIA.Text)
            REPORT.SetParameterValue("TXTFECHAFISCAL", FISCALIA.Text & "  " & HORA_FISCALIA.Text)
            REPORT.SetParameterValue("TXTRECIBE", TXTEMPLEADO.Text)
            REPORT.SetParameterValue("TXTRECIBETURNO", TXTTURNO.Text)
            'REPORT.SetParameterValue("TXTENTREGA", LOGIN.TXTUSUARIO.Text)
            'REPORT.SetParameterValue("TXTENTREGATURNO", LOGIN.CMBTURNO.Text)
            RPDEFUNCION.CrystalReportViewer1.ReportSource = REPORT
            RPDEFUNCION.CrystalReportViewer1.Refresh()
            RPDEFUNCION.Show()
        Else
            Me.Close()
        End If
    End Sub
End Class