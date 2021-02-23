<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SOLICITUD_EXPEDIENTEARCHIVO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SOLICITUD_EXPEDIENTEARCHIVO))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBPROCESOS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTMEDICO = New System.Windows.Forms.TextBox()
        Me.BTNMEDICO = New System.Windows.Forms.Button()
        Me.TXTCONSULTORIO = New System.Windows.Forms.TextBox()
        Me.BTNCONSULTORIO = New System.Windows.Forms.Button()
        Me.TXTEXPEDIENTE = New System.Windows.Forms.TextBox()
        Me.BTNEXPEDIENTE = New System.Windows.Forms.Button()
        Me.TXTPACIENTE = New System.Windows.Forms.TextBox()
        Me.BTNPACIENTE = New System.Windows.Forms.Button()
        Me.BTNCONFIRMAR = New System.Windows.Forms.Button()
        Me.CMBESPECIALIDAD = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(208, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Retiro de Archivos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CMBPROCESOS
        '
        Me.CMBPROCESOS.FormattingEnabled = True
        Me.CMBPROCESOS.Location = New System.Drawing.Point(106, 115)
        Me.CMBPROCESOS.Name = "CMBPROCESOS"
        Me.CMBPROCESOS.Size = New System.Drawing.Size(181, 21)
        Me.CMBPROCESOS.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(103, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Procesos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(66, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Area que solicita"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(103, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Especialidad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(346, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Medico"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(103, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Consultorio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(66, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Datos del Paciente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(103, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "No. Expediente"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(346, 403)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Nombre del Paciente"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TXTMEDICO
        '
        Me.TXTMEDICO.Location = New System.Drawing.Point(349, 227)
        Me.TXTMEDICO.Name = "TXTMEDICO"
        Me.TXTMEDICO.Size = New System.Drawing.Size(148, 20)
        Me.TXTMEDICO.TabIndex = 12
        '
        'BTNMEDICO
        '
        Me.BTNMEDICO.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNMEDICO.BackgroundImage = CType(resources.GetObject("BTNMEDICO.BackgroundImage"), System.Drawing.Image)
        Me.BTNMEDICO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNMEDICO.FlatAppearance.BorderSize = 50
        Me.BTNMEDICO.Location = New System.Drawing.Point(503, 224)
        Me.BTNMEDICO.Name = "BTNMEDICO"
        Me.BTNMEDICO.Size = New System.Drawing.Size(31, 25)
        Me.BTNMEDICO.TabIndex = 13
        Me.BTNMEDICO.UseVisualStyleBackColor = False
        '
        'TXTCONSULTORIO
        '
        Me.TXTCONSULTORIO.Location = New System.Drawing.Point(106, 283)
        Me.TXTCONSULTORIO.Name = "TXTCONSULTORIO"
        Me.TXTCONSULTORIO.Size = New System.Drawing.Size(148, 20)
        Me.TXTCONSULTORIO.TabIndex = 14
        '
        'BTNCONSULTORIO
        '
        Me.BTNCONSULTORIO.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNCONSULTORIO.BackgroundImage = CType(resources.GetObject("BTNCONSULTORIO.BackgroundImage"), System.Drawing.Image)
        Me.BTNCONSULTORIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCONSULTORIO.FlatAppearance.BorderSize = 50
        Me.BTNCONSULTORIO.Location = New System.Drawing.Point(260, 280)
        Me.BTNCONSULTORIO.Name = "BTNCONSULTORIO"
        Me.BTNCONSULTORIO.Size = New System.Drawing.Size(31, 25)
        Me.BTNCONSULTORIO.TabIndex = 15
        Me.BTNCONSULTORIO.UseVisualStyleBackColor = False
        '
        'TXTEXPEDIENTE
        '
        Me.TXTEXPEDIENTE.Location = New System.Drawing.Point(106, 423)
        Me.TXTEXPEDIENTE.Name = "TXTEXPEDIENTE"
        Me.TXTEXPEDIENTE.Size = New System.Drawing.Size(148, 20)
        Me.TXTEXPEDIENTE.TabIndex = 16
        '
        'BTNEXPEDIENTE
        '
        Me.BTNEXPEDIENTE.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNEXPEDIENTE.BackgroundImage = CType(resources.GetObject("BTNEXPEDIENTE.BackgroundImage"), System.Drawing.Image)
        Me.BTNEXPEDIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNEXPEDIENTE.FlatAppearance.BorderSize = 50
        Me.BTNEXPEDIENTE.Location = New System.Drawing.Point(260, 418)
        Me.BTNEXPEDIENTE.Name = "BTNEXPEDIENTE"
        Me.BTNEXPEDIENTE.Size = New System.Drawing.Size(31, 25)
        Me.BTNEXPEDIENTE.TabIndex = 17
        Me.BTNEXPEDIENTE.UseVisualStyleBackColor = False
        '
        'TXTPACIENTE
        '
        Me.TXTPACIENTE.Location = New System.Drawing.Point(349, 423)
        Me.TXTPACIENTE.Name = "TXTPACIENTE"
        Me.TXTPACIENTE.Size = New System.Drawing.Size(148, 20)
        Me.TXTPACIENTE.TabIndex = 18
        '
        'BTNPACIENTE
        '
        Me.BTNPACIENTE.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNPACIENTE.BackgroundImage = CType(resources.GetObject("BTNPACIENTE.BackgroundImage"), System.Drawing.Image)
        Me.BTNPACIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNPACIENTE.FlatAppearance.BorderSize = 50
        Me.BTNPACIENTE.Location = New System.Drawing.Point(503, 418)
        Me.BTNPACIENTE.Name = "BTNPACIENTE"
        Me.BTNPACIENTE.Size = New System.Drawing.Size(31, 25)
        Me.BTNPACIENTE.TabIndex = 19
        Me.BTNPACIENTE.UseVisualStyleBackColor = False
        '
        'BTNCONFIRMAR
        '
        Me.BTNCONFIRMAR.Location = New System.Drawing.Point(249, 513)
        Me.BTNCONFIRMAR.Name = "BTNCONFIRMAR"
        Me.BTNCONFIRMAR.Size = New System.Drawing.Size(150, 32)
        Me.BTNCONFIRMAR.TabIndex = 20
        Me.BTNCONFIRMAR.Text = "Confirmar Retiro"
        Me.BTNCONFIRMAR.UseVisualStyleBackColor = True
        '
        'CMBESPECIALIDAD
        '
        Me.CMBESPECIALIDAD.FormattingEnabled = True
        Me.CMBESPECIALIDAD.Location = New System.Drawing.Point(106, 227)
        Me.CMBESPECIALIDAD.Name = "CMBESPECIALIDAD"
        Me.CMBESPECIALIDAD.Size = New System.Drawing.Size(181, 21)
        Me.CMBESPECIALIDAD.TabIndex = 21
        '
        'SOLICITUD_EXPEDIENTEARCHIVO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 574)
        Me.Controls.Add(Me.CMBESPECIALIDAD)
        Me.Controls.Add(Me.BTNCONFIRMAR)
        Me.Controls.Add(Me.BTNPACIENTE)
        Me.Controls.Add(Me.TXTPACIENTE)
        Me.Controls.Add(Me.BTNEXPEDIENTE)
        Me.Controls.Add(Me.TXTEXPEDIENTE)
        Me.Controls.Add(Me.BTNCONSULTORIO)
        Me.Controls.Add(Me.TXTCONSULTORIO)
        Me.Controls.Add(Me.BTNMEDICO)
        Me.Controls.Add(Me.TXTMEDICO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CMBPROCESOS)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SOLICITUD_EXPEDIENTEARCHIVO"
        Me.Text = "SOLICITUD_EXPEDIENTEARCHIVO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CMBPROCESOS As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTMEDICO As TextBox
    Friend WithEvents BTNMEDICO As Button
    Friend WithEvents TXTCONSULTORIO As TextBox
    Friend WithEvents BTNCONSULTORIO As Button
    Friend WithEvents TXTEXPEDIENTE As TextBox
    Friend WithEvents BTNEXPEDIENTE As Button
    Friend WithEvents TXTPACIENTE As TextBox
    Friend WithEvents BTNPACIENTE As Button
    Friend WithEvents BTNCONFIRMAR As Button
    Friend WithEvents CMBESPECIALIDAD As ComboBox
End Class
