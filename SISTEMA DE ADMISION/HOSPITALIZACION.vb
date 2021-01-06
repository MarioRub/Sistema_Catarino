Public Class HOSPITALIZACION

    Private Sub BTNSALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub HOSPITALIZACION_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TXTAÑO.Text = DateTime.Now.ToString("yyyy")
        TXTMES.Text = UCase(DateTime.Now.ToString("MMM"))
        TXTDIA.Text = DateTime.Now.ToString("dd")
        TXTHORA.Text = Format(Now, "hh:mm:ss tt") 'extraer hora de 12 del sistema
    End Sub
End Class