Public Class CITASCEX
    Private Sub BTNSALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            Dim TEXTO As String = TXTIDENTIDAD.Text
            If Char.IsNumber(e.KeyChar) Then 'COMPARA SI ES NUMERO
                e.Handled = False 'PERMITE ESCRITURA
            ElseIf Char.IsControl(e.KeyChar) Then 'COMPARA SI TECLA ES BORAR
                e.Handled = False 'PERMITE ESCRITURA
                'ElseIf Char.IsSeparator(e.KeyChar) Then 'COMPARA QUE SEA ESPACIO
                '   e.Handled = False 'PERMITE ESCRITURA
            Else
                e.Handled = True 'NO PERMITE ESCRITURA
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
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXTIDENTIDAD.TextChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.MaxLength = 15
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
        End If
    End Sub

    Private Sub CITASCEX_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList

        FECHA_FICHA.Value = CDate(DateTime.Now.ToString("dd/MMM/yyyy"))
        FECHA_REFERENCIA.Value = CDate(DateTime.Now.ToString("dd/MMM/yyyy"))
        FN.Value = CDate(DateTime.Now.ToString("dd/MMM/yyyy"))
        TXTFECHA_INCLUSION.Text = UCase(Format(Now, "dd/MMM/yyyy") & "   " & Format(Now, "hh:mm:ss tt"))
        CMBNACIONALIDAD.Focus()
        CMBESPECIALIDAD.Items.Add("")
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
        CMBBUSQUEDA.Enabled = False
        CMBBUSQUEDA.Items.Add("")
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        CMBTIPO.Items.Add("4. AÑOS")
        CMBTIPO.Items.Add("3. MESES")
        CMBTIPO.Items.Add("2. DIAS")
        CMBTIPO.Items.Add("1. HORAS")
        TXTEDAD.Text = ""
        CMBTIPO.Text = ""
        CMBBUSQUEDA.Enabled = False
        BTNIDENTIDAD.Visible = False : BTNCORRELATIVO.Visible = False
        BTNREPROGRAMADO.Visible = False : TXTCONTEO.Visible = False
        BTNMODIFICA.Enabled = False : BTNBITACORA.Enabled = False
        BTNGUARDA.Enabled = False : BTNCALENDARIO.Enabled = False
        BTNGUARDAR.Enabled = False : BTNMODIFICAR.Enabled = False
        TXTPAIS.Enabled = False
        TXTIDENTIDAD.Enabled = False : TXTCORRELATIVO.Enabled = False
        TXTNOMBRES.Enabled = False : TXTPRIMERAPELLIDO.Enabled = False
        TXTSEGUNDOAPELLIDO.Enabled = False : CMBSEXO.Enabled = False
        CMBSEXO.Enabled = False : TXTPADRE.Enabled = False
        TXTMADRE.Enabled = False : TXTBD.Enabled = False
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
        LBMEDICO.Text = "" : TXTFECHA_CITADO.Enabled = False
        CBOTROS.Checked = False : CBPREFERENTE.Checked = False
        CBNORMAL.Checked = False : CBLUNES.Checked = False
        CBMARTES.Checked = False : CBMIERCOLES.Checked = False
        CBJUEVES.Checked = False : CBVIERNES.Checked = False
        CBSABADO.Checked = False : CBDOMINGO.Checked = False
        CMBESPECIALIDAD.Enabled = False : TXTCLINICA.Enabled = False
        CMBMEDICO.Enabled = False
        TXTSG.Visible = False : LBSG.Visible = False
        TXTFECHA_CITADO.Enabled = False : TXTTOTAL.Enabled = False
        TXTOTORGADO.Enabled = False : TXTOBSERVACION.Enabled = False
    End Sub

    Private Sub FN_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FN.ValueChanged
        Dim EDAD As Date = CDate(Me.FN.Value)
        Dim HOY As Date = UCase(CDate(DateTime.Now.ToString("dd/MMM/yyyy")))
        Dim AÑO, MES, DIA As Integer
        TXTEDAD.Text = ""
        CMBTIPO.Text = ""
        If FN.Value <= HOY Then
            AÑO = DateTime.Today.AddTicks(-FN.Value.Ticks).Year - 1
            MES = DateTime.Today.AddTicks(-FN.Value.Ticks).Month - 1
            DIA = DateTime.Today.AddTicks(-FN.Value.Ticks).Day - 1
            If AÑO > 0 Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                TXTEDAD.Text = AÑO
                CMBTIPO.Text = "4. AÑOS"
            ElseIf AÑO = 0 And MES > 0 Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                TXTEDAD.Text = MES
                CMBTIPO.Text = "3. MESES"
            ElseIf AÑO = 0 And MES = 0 And DIA > 0 Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                TXTEDAD.Text = DIA
                CMBTIPO.Text = "2. DIAS"
            End If
        ElseIf FN.Value > HOY Then
            MessageBox.Show("LA FECHA INGRESADA NO ES PERMITIDA")
            FN.Value = HOY
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
        End If
    End Sub

    Private Sub BTNCALENDARIO_Click(sender As System.Object, e As System.EventArgs) Handles BTNCALENDARIO.Click
        Me.Hide()
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
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
            TXTNOMBRES.Text = ""
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
        End If
    End Sub

    Private Sub TXTCORRELATIVO_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCORRELATIVO.KeyPress
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

    Private Sub FECHA_FICHA_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FECHA_FICHA.ValueChanged
        Dim HOY As Date = UCase(Format(Now, "dd/MMM/yyyy"))
        If FECHA_FICHA.Value > HOY Then
            MsgBox("LA FECHA QUE SELECCIONO NO PUEDE SER MAYOR A LA FECHA ACTUAL, FAVOR SELECCIONAR UNA FECHA DIFERENTE", MsgBoxStyle.Information, AcceptButton)
            FECHA_FICHA.Value = HOY
        ElseIf FECHA_FICHA.Value <= HOY Then
            FECHA_REFERENCIA.Value = FECHA_FICHA.Value
        End If
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
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
        If Char.IsNumber(e.KeyChar) Then 'COMPARA SI ES NUMERO
            e.Handled = False 'PERMITE ESCRITURA
        ElseIf Char.IsControl(e.KeyChar) Then 'COMPARA SI TECLA ES BORAR
            e.Handled = False 'PERMITE ESCRITURA
            'ElseIf Char.IsSeparator(e.KeyChar) Then 'COMPARA QUE SEA ESPACIO
            '   e.Handled = False 'PERMITE ESCRITURA
        Else
            e.Handled = True 'NO PERMITE ESCRITURA
        End If

        If TXTTELEFONO1.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTTELEFONO1.Text = TEXTO
            e.Handled = True
            TXTTELEFONO1.Select(TXTTELEFONO1.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTTELEFONO1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXTTELEFONO1.TextChanged

    End Sub

    Private Sub TXTTELEFONO2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTELEFONO2.KeyPress
        Dim TEXTO As String = TXTTELEFONO2.Text
        If Char.IsNumber(e.KeyChar) Then 'COMPARA SI ES NUMERO
            e.Handled = False 'PERMITE ESCRITURA
        ElseIf Char.IsControl(e.KeyChar) Then 'COMPARA SI TECLA ES BORAR
            e.Handled = False 'PERMITE ESCRITURA
            'ElseIf Char.IsSeparator(e.KeyChar) Then 'COMPARA QUE SEA ESPACIO
            '   e.Handled = False 'PERMITE ESCRITURA
        Else
            e.Handled = True 'NO PERMITE ESCRITURA
        End If

        If TXTTELEFONO2.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTTELEFONO2.Text = TEXTO
            e.Handled = True
            TXTTELEFONO2.Select(TXTTELEFONO2.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTTELEFONO2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXTTELEFONO2.TextChanged

    End Sub
End Class