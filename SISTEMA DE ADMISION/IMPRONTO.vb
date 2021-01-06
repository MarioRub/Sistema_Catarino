Public Class IMPRONTO

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub FN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FN.ValueChanged
        Dim EDAD As Date = CDate(Me.FN.Value)
        Dim HOY As Date = CDate(DateTime.Now.ToString("dd/MMM/yyyy"))
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

    Private Sub IMPRONTO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TXTAÑO.Text = DateTime.Now.ToString("yyyy")
        TXTMES.Text = UCase(DateTime.Now.ToString("MMM"))
        TXTDIA.Text = DateTime.Now.ToString("dd")
        TXTHORA.Text = Format(Now, "hh:mm:ss tt") 'extraer hora de 12 del sistema
        Me.MS.IsBalloon = True
        Me.MS.SetToolTip(FN, "SELECCIONE LA FECHA DE NACIMIENTO")
        Me.MS.SetToolTip(BTNIDENTIDAD, "CLICK PARA BUSCAR EL REGISTRO, EN EL CASO QUE NO SE ENCUENTRE INGRESAR LOS DATOS")
        Me.MS.SetToolTip(BTNCORRELATIVO, "CLICK PARA BUSCAR EL REGISTRO, EN EL CASO QUE NO SE ENCUENTRE INGRESAR LOS DATOS")
        Me.MS.SetToolTip(BTNMODIFICAR, "MODIFICAR LA INFORMACION DEL PACIENTE COMO SER: DIRECCCION, DATOS PERSONALES")
        Me.MS.SetToolTip(BTNGUARDAR, "GUARDAR LA INFORMACION DEL PACIENTE COMO SER: DIRECCCION, DATOS PERSONALES")
        CMBPRIORIDAD.Items.Add("ROJO")
        CMBPRIORIDAD.Items.Add("AMARILLO")
        CMBPRIORIDAD.Items.Add("VERDE")
        CMBPRIORIDAD.Items.Add("AZUL")
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        FN.Value = CDate(DateTime.Now.ToString("dd/MMM/yyyy"))
        CMBNACIONALIDAD.Focus()
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
        TXTIDENTIDAD.Enabled = False : TXTCORRELATIVO.Enabled = False
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
End Class