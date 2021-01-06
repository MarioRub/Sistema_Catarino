Public Class MENUCEX

    Private Sub BTNSALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNCITAS_Click(sender As System.Object, e As System.EventArgs) Handles BTNCITAS.Click
        Me.Close()
        CITASCEX.Show()
    End Sub
End Class