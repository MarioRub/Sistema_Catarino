<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CERTIFICACION_NACIMIENTO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CERTIFICACION_NACIMIENTO))
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTIDSOLICITANTE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTTELEFONO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTIDMAMA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTGESTAS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CMBSEXO = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTPENTREGAESTIMADA = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTPPARTO = New System.Windows.Forms.DateTimePicker()
        Me.BTNCONFIRMAR = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(741, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 91)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 27
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(191, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(264, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 31)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Certificacion de Nacimiento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(44, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 26)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Informacion del Solicitante"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(55, 189)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(189, 20)
        Me.TXTNOMBRE.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(52, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nombre Completo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TXTIDSOLICITANTE
        '
        Me.TXTIDSOLICITANTE.Location = New System.Drawing.Point(325, 189)
        Me.TXTIDSOLICITANTE.Name = "TXTIDSOLICITANTE"
        Me.TXTIDSOLICITANTE.Size = New System.Drawing.Size(189, 20)
        Me.TXTIDSOLICITANTE.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(322, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "No. de ID del Solicitante"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(42, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 26)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Informacion de la Mama"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TXTTELEFONO
        '
        Me.TXTTELEFONO.Location = New System.Drawing.Point(583, 189)
        Me.TXTTELEFONO.Name = "TXTTELEFONO"
        Me.TXTTELEFONO.Size = New System.Drawing.Size(189, 20)
        Me.TXTTELEFONO.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(580, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "No. de Telefono"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TXTIDMAMA
        '
        Me.TXTIDMAMA.Location = New System.Drawing.Point(53, 311)
        Me.TXTIDMAMA.Name = "TXTIDMAMA"
        Me.TXTIDMAMA.Size = New System.Drawing.Size(189, 20)
        Me.TXTIDMAMA.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(50, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "ID de la Mama"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TXTGESTAS
        '
        Me.TXTGESTAS.Location = New System.Drawing.Point(323, 312)
        Me.TXTGESTAS.Name = "TXTGESTAS"
        Me.TXTGESTAS.Size = New System.Drawing.Size(189, 20)
        Me.TXTGESTAS.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(320, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 17)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Numero de Gestas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CMBSEXO
        '
        Me.CMBSEXO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBSEXO.FormattingEnabled = True
        Me.CMBSEXO.Location = New System.Drawing.Point(581, 311)
        Me.CMBSEXO.Name = "CMBSEXO"
        Me.CMBSEXO.Size = New System.Drawing.Size(205, 21)
        Me.CMBSEXO.Sorted = True
        Me.CMBSEXO.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(578, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 17)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Sexo del Bebe"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DTPENTREGAESTIMADA
        '
        Me.DTPENTREGAESTIMADA.Checked = False
        Me.DTPENTREGAESTIMADA.CustomFormat = "dd/MMM/yyyy"
        Me.DTPENTREGAESTIMADA.Enabled = False
        Me.DTPENTREGAESTIMADA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPENTREGAESTIMADA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPENTREGAESTIMADA.Location = New System.Drawing.Point(323, 380)
        Me.DTPENTREGAESTIMADA.Name = "DTPENTREGAESTIMADA"
        Me.DTPENTREGAESTIMADA.Size = New System.Drawing.Size(189, 22)
        Me.DTPENTREGAESTIMADA.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(320, 360)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(284, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Fecha de Entrega Estimada de Certificacion"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(50, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 17)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Fecha de Parto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DTPPARTO
        '
        Me.DTPPARTO.Checked = False
        Me.DTPPARTO.CustomFormat = "dd/MMM/yyyy"
        Me.DTPPARTO.Enabled = False
        Me.DTPPARTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPPARTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPPARTO.Location = New System.Drawing.Point(53, 380)
        Me.DTPPARTO.Name = "DTPPARTO"
        Me.DTPPARTO.Size = New System.Drawing.Size(189, 22)
        Me.DTPPARTO.TabIndex = 45
        '
        'BTNCONFIRMAR
        '
        Me.BTNCONFIRMAR.Location = New System.Drawing.Point(295, 469)
        Me.BTNCONFIRMAR.Name = "BTNCONFIRMAR"
        Me.BTNCONFIRMAR.Size = New System.Drawing.Size(242, 50)
        Me.BTNCONFIRMAR.TabIndex = 47
        Me.BTNCONFIRMAR.Text = "Guardar Certificacion"
        Me.BTNCONFIRMAR.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CERTIFICACION_NACIMIENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(834, 550)
        Me.Controls.Add(Me.BTNCONFIRMAR)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DTPPARTO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DTPENTREGAESTIMADA)
        Me.Controls.Add(Me.CMBSEXO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTGESTAS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTIDMAMA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTTELEFONO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTIDSOLICITANTE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "CERTIFICACION_NACIMIENTO"
        Me.Text = "CERTIFICACION_NACIMIENTO"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTIDSOLICITANTE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTTELEFONO As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTIDMAMA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTGESTAS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CMBSEXO As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DTPENTREGAESTIMADA As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DTPPARTO As DateTimePicker
    Friend WithEvents BTNCONFIRMAR As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
