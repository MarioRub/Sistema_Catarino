Public Class BUSCAR_EXPEDIENTE
    Private Sub BUSCAR_EXPEDIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        CMBBUSQUEDA.Enabled = False
        TXTEXPEDIENTE.Enabled = False
        TXTNOMBREPACIENTE.Enabled = False
        CBIDENTIDAD.Enabled = True
        CBNOMBRE.Enabled = True
    End Sub

    Private Sub TXTEXPEDIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTEXPEDIENTE.KeyPress
        Dim IDENTIDAD As String = TXTEXPEDIENTE.Text
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 15
            If TXTEXPEDIENTE.Text.Length = 4 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTEXPEDIENTE.Text = IDENTIDAD
                e.Handled = True
                TXTEXPEDIENTE.Select(TXTEXPEDIENTE.Text.Length, 0)
            End If
            If TXTEXPEDIENTE.Text.Length = 9 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTEXPEDIENTE.Text = IDENTIDAD
                e.Handled = True
                TXTEXPEDIENTE.Select(TXTEXPEDIENTE.Text.Length, 0)
            End If
            If TXTEXPEDIENTE.Text.Length = 15 Then
                BTNBUSCAR.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then
                e.Handled = False
            End If
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTEXPEDIENTE.MaxLength = 9
            TXTEXPEDIENTE.Enabled = True
            If TXTEXPEDIENTE.Text.Length = 4 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTEXPEDIENTE.Text = IDENTIDAD
                e.Handled = True
                TXTEXPEDIENTE.Select(TXTEXPEDIENTE.Text.Length, 0)
            End If
            If TXTEXPEDIENTE.Text.Length = 9 Then
                BTNBUSCAR.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then
                e.Handled = False
            End If
        End If
    End Sub
    Private Sub CBIDENTIDAD_CheckedChanged(sender As Object, e As EventArgs) Handles CBIDENTIDAD.CheckedChanged
        If CBIDENTIDAD.Checked = True Then
            CBNOMBRE.Checked = False
            CMBBUSQUEDA.Enabled = True
            TXTNOMBREPACIENTE.Enabled = False
            BTNBUSCAR.Enabled = True
        ElseIf CBIDENTIDAD.Checked = False Then
            CBNOMBRE.Checked = False
            CMBBUSQUEDA.Enabled = False
            TXTNOMBREPACIENTE.Enabled = False
            BTNBUSCAR.Enabled = False
        End If
    End Sub

    Private Sub CBNOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles CBNOMBRE.CheckedChanged
        If CBNOMBRE.Checked = True Then
            CBIDENTIDAD.Checked = False
            TXTNOMBREPACIENTE.Enabled = True
            CMBBUSQUEDA.Enabled = False
            TXTEXPEDIENTE.Enabled = False
            BTNBUSCAR.Enabled = True
        ElseIf CBNOMBRE.Checked = False Then
            CBIDENTIDAD.Checked = False
            TXTNOMBREPACIENTE.Enabled = False
            CMBBUSQUEDA.Enabled = False
            TXTEXPEDIENTE.Enabled = False
            BTNBUSCAR.Enabled = False
        End If
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged
        Dim IDENTIDAD As String = TXTEXPEDIENTE.Text
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 15
            TXTEXPEDIENTE.Text = ""
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 9
            TXTEXPEDIENTE.Text = ""
        End If
    End Sub
End Class