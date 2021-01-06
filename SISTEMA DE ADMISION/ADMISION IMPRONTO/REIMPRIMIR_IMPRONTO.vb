Public Class REIMPRIMIR_IMPRONTO

    Private Sub BTNSALIR_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BTNBUSQUEDA_Click(sender As System.Object, e As System.EventArgs) Handles BTNBUSQUEDA.Click
        If TXTIDENTIDAD.Text <> "0000-0000-00000" And (TXTCORRELATIVO.Text = "0000-0000" Or TXTCORRELATIVO.Text <> "0000-0000") Then
            BUSQUEDA_IMPRONTO.LBTIPO.Text = CMBBUSQUEDA.Text
            BUSQUEDA_IMPRONTO.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            BUSQUEDA_IMPRONTO.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            BUSQUEDA_IMPRONTO.LBIDENTIDAD.Text = TXTIDENTIDAD.Text
            BUSQUEDA_IMPRONTO.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        ElseIf TXTCORRELATIVO.Text <> "0000-0000" And (TXTIDENTIDAD.Text = "0000-0000-00000") Then
            BUSQUEDA_IMPRONTO.LBTIPO.Text = CMBBUSQUEDA.Text
            BUSQUEDA_IMPRONTO.LBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
            BUSQUEDA_IMPRONTO.LBCLASIFICACION.Text = CMBCLASIFICACION.Text
            BUSQUEDA_IMPRONTO.LBIDENTIDAD.Text = TXTCORRELATIVO.Text
            BUSQUEDA_IMPRONTO.LBPACIENTE.Text = TXTNOMBRES.Text & " " & TXTPRIMERAPELLIDO.Text & " " & TXTSEGUNDOAPELLIDO.Text
        End If
        BUSQUEDA_IMPRONTO.Show()
    End Sub

    Private Sub BTNBUSQUEDA_MouseEnter(sender As Object, e As EventArgs) Handles BTNBUSQUEDA.MouseEnter
        BTNBUSQUEDA.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNBUSQUEDA.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNBUSQUEDA_MouseLeave(sender As Object, e As EventArgs) Handles BTNBUSQUEDA.MouseLeave
        BTNBUSQUEDA.FlatAppearance.BorderColor = Color.Silver
        BTNBUSQUEDA.FlatAppearance.BorderSize = 1
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
            Dim DIRE As String = ""
            If CMBDEPARTAMENTO.Text = "SELECCIONE" And CMBMUNICIPIO.Text = "SELECCIONE" And TXTCOLONIA.Text = "" And TXTCASA.Text = "" Then
                DIRE = ""
            Else
                DIRE = TXTCOLONIA.Text & "," & TXTCASA.Text & "," & CMBMUNICIPIO.Text & "," & CMBDEPARTAMENTO.Text
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
            REPORT.SetParameterValue("TXTFN", FN.Text)
            REPORT.SetParameterValue("TXTHORA", TXTHORA.Text)
            REPORT.SetParameterValue("TXTFECHA", INGRESO.Value)
            REPORT.SetParameterValue("TXTTRASLADO", TXTPERSONA.Text)
            REPORT.SetParameterValue("TXTDIRECCION", DIRE)
            REPORT.SetParameterValue("TXTPADRE", TXTPADRE.Text)
            REPORT.SetParameterValue("TXTMADRE", TXTMADRE.Text)
            REPORT.SetParameterValue("TXTRESPONSABLE", TXTRESPONSABLE.Text)
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

    Private Sub BTNREIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNREIMPRIMIR.Click
        If MsgBox("DESEA CONTINUAR CON EL PROCESO", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            IMPRIMIR_IMPRONTO()
            Me.Close()
        Else
            TXTIDENTIDAD.Focus()
        End If

    End Sub

    Private Sub BTNSALIR_Click_1(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNSALIR_MouseEnter(sender As Object, e As EventArgs) Handles BTNSALIR.MouseEnter
        BTNSALIR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNSALIR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNSALIR_MouseLeave(sender As Object, e As EventArgs) Handles BTNSALIR.MouseLeave
        BTNSALIR.FlatAppearance.BorderColor = Color.Silver
        BTNSALIR.FlatAppearance.BorderSize = 2
    End Sub

    Private Sub REIMPRIMIR_IMPRONTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        CMBTIPO.Text = "" : CMBPRIORIDAD.Text = ""
        TXTREMITENTE.Text = "" : TXTPERSONA.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        CMBDEPARTAMENTO.Text = "" : CMBMUNICIPIO.Text = ""
        TXTMOTIVO.Text = "" : TXTFISICO.Text = ""
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
            FN.Text = ""
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
            TXTFISICO.Text = ""
            TXTMOTIVO.Text = ""
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
            FN.Text = ""
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
            TXTFISICO.Text = ""
            TXTMOTIVO.Text = ""
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
            FN.Text = ""
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
            TXTFISICO.Text = ""
            TXTMOTIVO.Text = ""
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
            ElseIf TXTIDENTIDAD.Text.Length < 15 Then
                BTNBUSQUEDA.Visible = False
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
            If TXTIDENTIDAD.Text.Length >= 6 Then
                BTNBUSQUEDA.Visible = True
            ElseIf TXTIDENTIDAD.Text.Length <= 5 Then
                BTNBUSQUEDA.Visible = False
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
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
        TXTCORRELATIVO.Focus()
        If TXTCORRELATIVO.Text.Length >= 6 Then
            BTNBUSQUEDA.Visible = True
        ElseIf TXTCORRELATIVO.Text.Length <= 5 Then
            BTNBUSQUEDA.Visible = False
        End If
    End Sub

    Private Sub TXTFECHA_BUSQUEDA_TextChanged(sender As Object, e As EventArgs) Handles TXTFECHA_BUSQUEDA.TextChanged
        If TXTFECHA_BUSQUEDA.Text <> "" Then
            BTNREIMPRIMIR.Enabled = True
        ElseIf TXTFECHA_BUSQUEDA.Text = "" Then
            BTNREIMPRIMIR.Enabled = False
        End If
    End Sub

    Private Sub BTNREIMPRIMIR_MouseEnter(sender As Object, e As EventArgs) Handles BTNREIMPRIMIR.MouseEnter
        BTNREIMPRIMIR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNREIMPRIMIR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNREIMPRIMIR_MouseLeave(sender As Object, e As EventArgs) Handles BTNREIMPRIMIR.MouseLeave
        BTNREIMPRIMIR.FlatAppearance.BorderColor = Color.Silver
        BTNREIMPRIMIR.FlatAppearance.BorderSize = 1
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

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class