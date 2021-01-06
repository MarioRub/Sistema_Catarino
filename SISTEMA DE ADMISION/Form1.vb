Public Class FORM_LOGIN

    Private Sub FORM_LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBFECHA.Text = DateTime.Now.ToString("dd/MM/yyyy") 'extraer la fecha en dia/mes/año del sistema
        LBHORARIO.Text = Format(Now, "hh:mm:ss tt") 'extraer hora de 12 del sistema
    End Sub

    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        End 'cerrar el formulario
    End Sub

    Private Sub CMBUSUARIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBUSUARIO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas 
    End Sub

    Private Sub CMBTURNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBTURNO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub
End Class
