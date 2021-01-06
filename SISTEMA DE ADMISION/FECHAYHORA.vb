Public Class FECHAYHORA
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.LBHORA.Text = DateTime.Now.ToString("dd/MMM/yyyy....hh:mm:ss tt")
        Me.LBHORAS.Text = DateTime.Now.ToString("dd/MMM/yyyy....HH:mm:ss")
    End Sub

    Private Sub FECHAYHORA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
    End Sub
End Class