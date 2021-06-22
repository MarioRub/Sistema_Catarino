Public Class CERTIFICACION_NACIMIENTO
    Private Sub CERTIFICACION_NACIMIENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBSEXO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBSEXO.Items.Add("MASCULINO")
        CMBSEXO.Items.Add("FEMENINO")
    End Sub

    Private Sub TXTNOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOMBRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub TXTIDSOLICITANTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDSOLICITANTE.KeyPress
        Dim IDENTIDAD As String = TXTIDSOLICITANTE.Text

        TXTIDSOLICITANTE.MaxLength = 15
        If TXTIDSOLICITANTE.Text.Length = 4 Then
            IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
            TXTIDSOLICITANTE.Text = IDENTIDAD
            e.Handled = True
            TXTIDSOLICITANTE.Select(TXTIDSOLICITANTE.Text.Length, 0)
        End If
        If TXTIDSOLICITANTE.Text.Length = 9 Then
            IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
            TXTIDSOLICITANTE.Text = IDENTIDAD
            e.Handled = True
            TXTIDSOLICITANTE.Select(TXTIDSOLICITANTE.Text.Length, 0)
        End If
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

    End Sub

    Private Sub TXTIDMAMA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDMAMA.KeyPress
        Dim IDENTIDAD As String = TXTIDSOLICITANTE.Text

        TXTIDMAMA.MaxLength = 15
        If TXTIDMAMA.Text.Length = 4 Then
            IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
            TXTIDMAMA.Text = IDENTIDAD
            e.Handled = True
            TXTIDMAMA.Select(TXTIDMAMA.Text.Length, 0)
        End If
        If TXTIDMAMA.Text.Length = 9 Then
            IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
            TXTIDMAMA.Text = IDENTIDAD
            e.Handled = True
            TXTIDMAMA.Select(TXTIDMAMA.Text.Length, 0)
        End If
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

    End Sub
End Class