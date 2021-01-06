<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FECHAYHORA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LBHORAS = New System.Windows.Forms.Label()
        Me.LBHORA = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LBHORAS
        '
        Me.LBHORAS.AutoSize = True
        Me.LBHORAS.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBHORAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 65.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBHORAS.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBHORAS.Location = New System.Drawing.Point(12, 227)
        Me.LBHORAS.Name = "LBHORAS"
        Me.LBHORAS.Size = New System.Drawing.Size(294, 98)
        Me.LBHORAS.TabIndex = 14
        Me.LBHORAS.Text = "HORA"
        Me.LBHORAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBHORA
        '
        Me.LBHORA.AutoSize = True
        Me.LBHORA.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBHORA.Font = New System.Drawing.Font("Microsoft Sans Serif", 65.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBHORA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LBHORA.Location = New System.Drawing.Point(12, 30)
        Me.LBHORA.Name = "LBHORA"
        Me.LBHORA.Size = New System.Drawing.Size(294, 98)
        Me.LBHORA.TabIndex = 13
        Me.LBHORA.Text = "HORA"
        Me.LBHORA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FECHAYHORA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1219, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBHORAS)
        Me.Controls.Add(Me.LBHORA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FECHAYHORA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBHORAS As System.Windows.Forms.Label
    Friend WithEvents LBHORA As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
