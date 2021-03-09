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
        Me.TXTEXPEDIENTE = New System.Windows.Forms.TextBox()
        Me.BTNEXPEDIENTE = New System.Windows.Forms.Button()
        Me.TXTPACIENTE = New System.Windows.Forms.TextBox()
        Me.BTNCONFIRMAR = New System.Windows.Forms.Button()
        Me.CMBESPECIALIDAD = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCOD_ESPECIALIDAD = New System.Windows.Forms.TextBox()
        Me.CMBCONSULTORIO = New System.Windows.Forms.ComboBox()
        Me.CMBBUSQUEDA = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTNOMBREEMPLEADO = New System.Windows.Forms.TextBox()
        Me.TXTIDENTIDAD = New System.Windows.Forms.TextBox()
        Me.CMBMEDICOS = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(243, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Retiro de Archivos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CMBPROCESOS
        '
        Me.CMBPROCESOS.FormattingEnabled = True
        Me.CMBPROCESOS.Location = New System.Drawing.Point(114, 143)
        Me.CMBPROCESOS.Name = "CMBPROCESOS"
        Me.CMBPROCESOS.Size = New System.Drawing.Size(181, 21)
        Me.CMBPROCESOS.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(111, 123)
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
        Me.Label3.Location = New System.Drawing.Point(74, 187)
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
        Me.Label4.Location = New System.Drawing.Point(104, 219)
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
        Me.Label5.Location = New System.Drawing.Point(347, 219)
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
        Me.Label6.Location = New System.Drawing.Point(104, 277)
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
        Me.Label7.Location = New System.Drawing.Point(79, 427)
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
        Me.Label8.Location = New System.Drawing.Point(106, 522)
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
        Me.Label9.Location = New System.Drawing.Point(347, 464)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Nombre del Paciente"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TXTMEDICO
        '
        Me.TXTMEDICO.Location = New System.Drawing.Point(350, 239)
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
        Me.BTNMEDICO.Location = New System.Drawing.Point(504, 236)
        Me.BTNMEDICO.Name = "BTNMEDICO"
        Me.BTNMEDICO.Size = New System.Drawing.Size(31, 25)
        Me.BTNMEDICO.TabIndex = 13
        Me.BTNMEDICO.UseVisualStyleBackColor = False
        '
        'TXTEXPEDIENTE
        '
        Me.TXTEXPEDIENTE.Location = New System.Drawing.Point(109, 542)
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
        Me.BTNEXPEDIENTE.Location = New System.Drawing.Point(263, 539)
        Me.BTNEXPEDIENTE.Name = "BTNEXPEDIENTE"
        Me.BTNEXPEDIENTE.Size = New System.Drawing.Size(31, 25)
        Me.BTNEXPEDIENTE.TabIndex = 17
        Me.BTNEXPEDIENTE.UseVisualStyleBackColor = False
        '
        'TXTPACIENTE
        '
        Me.TXTPACIENTE.Location = New System.Drawing.Point(350, 484)
        Me.TXTPACIENTE.Name = "TXTPACIENTE"
        Me.TXTPACIENTE.Size = New System.Drawing.Size(185, 20)
        Me.TXTPACIENTE.TabIndex = 18
        '
        'BTNCONFIRMAR
        '
        Me.BTNCONFIRMAR.Location = New System.Drawing.Point(262, 597)
        Me.BTNCONFIRMAR.Name = "BTNCONFIRMAR"
        Me.BTNCONFIRMAR.Size = New System.Drawing.Size(150, 32)
        Me.BTNCONFIRMAR.TabIndex = 20
        Me.BTNCONFIRMAR.Text = "Confirmar Retiro"
        Me.BTNCONFIRMAR.UseVisualStyleBackColor = True
        '
        'CMBESPECIALIDAD
        '
        Me.CMBESPECIALIDAD.FormattingEnabled = True
        Me.CMBESPECIALIDAD.Location = New System.Drawing.Point(107, 239)
        Me.CMBESPECIALIDAD.Name = "CMBESPECIALIDAD"
        Me.CMBESPECIALIDAD.Size = New System.Drawing.Size(181, 21)
        Me.CMBESPECIALIDAD.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(191, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(603, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 91)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(347, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Nombre del Medico Encontrado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TXTCOD_ESPECIALIDAD
        '
        Me.TXTCOD_ESPECIALIDAD.Enabled = False
        Me.TXTCOD_ESPECIALIDAD.Location = New System.Drawing.Point(58, 239)
        Me.TXTCOD_ESPECIALIDAD.Name = "TXTCOD_ESPECIALIDAD"
        Me.TXTCOD_ESPECIALIDAD.Size = New System.Drawing.Size(43, 20)
        Me.TXTCOD_ESPECIALIDAD.TabIndex = 29
        '
        'CMBCONSULTORIO
        '
        Me.CMBCONSULTORIO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBCONSULTORIO.FormattingEnabled = True
        Me.CMBCONSULTORIO.Location = New System.Drawing.Point(107, 297)
        Me.CMBCONSULTORIO.Name = "CMBCONSULTORIO"
        Me.CMBCONSULTORIO.Size = New System.Drawing.Size(181, 21)
        Me.CMBCONSULTORIO.Sorted = True
        Me.CMBCONSULTORIO.TabIndex = 30
        '
        'CMBBUSQUEDA
        '
        Me.CMBBUSQUEDA.Enabled = False
        Me.CMBBUSQUEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBBUSQUEDA.FormattingEnabled = True
        Me.CMBBUSQUEDA.Location = New System.Drawing.Point(106, 483)
        Me.CMBBUSQUEDA.Name = "CMBBUSQUEDA"
        Me.CMBBUSQUEDA.Size = New System.Drawing.Size(189, 21)
        Me.CMBBUSQUEDA.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(103, 463)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 17)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Tipo de Busqueda"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(104, 340)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 17)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Empleado que Solicita"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TXTNOMBREEMPLEADO
        '
        Me.TXTNOMBREEMPLEADO.Location = New System.Drawing.Point(106, 360)
        Me.TXTNOMBREEMPLEADO.Name = "TXTNOMBREEMPLEADO"
        Me.TXTNOMBREEMPLEADO.Size = New System.Drawing.Size(182, 20)
        Me.TXTNOMBREEMPLEADO.TabIndex = 36
        '
        'TXTIDENTIDAD
        '
        Me.TXTIDENTIDAD.BackColor = System.Drawing.Color.White
        Me.TXTIDENTIDAD.Location = New System.Drawing.Point(0, 87)
        Me.TXTIDENTIDAD.Name = "TXTIDENTIDAD"
        Me.TXTIDENTIDAD.Size = New System.Drawing.Size(108, 20)
        Me.TXTIDENTIDAD.TabIndex = 37
        Me.TXTIDENTIDAD.Visible = False
        '
        'CMBMEDICOS
        '
        Me.CMBMEDICOS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBMEDICOS.FormattingEnabled = True
        Me.CMBMEDICOS.Location = New System.Drawing.Point(350, 297)
        Me.CMBMEDICOS.Name = "CMBMEDICOS"
        Me.CMBMEDICOS.Size = New System.Drawing.Size(185, 21)
        Me.CMBMEDICOS.Sorted = True
        Me.CMBMEDICOS.TabIndex = 38
        '
        'SOLICITUD_EXPEDIENTEARCHIVO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(691, 723)
        Me.Controls.Add(Me.CMBMEDICOS)
        Me.Controls.Add(Me.TXTIDENTIDAD)
        Me.Controls.Add(Me.TXTNOMBREEMPLEADO)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CMBBUSQUEDA)
        Me.Controls.Add(Me.CMBCONSULTORIO)
        Me.Controls.Add(Me.TXTCOD_ESPECIALIDAD)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CMBESPECIALIDAD)
        Me.Controls.Add(Me.BTNCONFIRMAR)
        Me.Controls.Add(Me.TXTPACIENTE)
        Me.Controls.Add(Me.BTNEXPEDIENTE)
        Me.Controls.Add(Me.TXTEXPEDIENTE)
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TXTEXPEDIENTE As TextBox
    Friend WithEvents BTNEXPEDIENTE As Button
    Friend WithEvents TXTPACIENTE As TextBox
    Friend WithEvents BTNCONFIRMAR As Button
    Friend WithEvents CMBESPECIALIDAD As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTCOD_ESPECIALIDAD As TextBox
    Friend WithEvents CMBCONSULTORIO As ComboBox
    Friend WithEvents CMBBUSQUEDA As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TXTNOMBREEMPLEADO As TextBox
    Friend WithEvents TXTIDENTIDAD As TextBox
    Friend WithEvents CMBMEDICOS As ComboBox
End Class
