<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CITADO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CITADO))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBMEDICO = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CMBESPECIALIDAD = New System.Windows.Forms.ComboBox()
        Me.INICIAL = New System.Windows.Forms.DateTimePicker()
        Me.FINAL = New System.Windows.Forms.DateTimePicker()
        Me.LBINICIAL = New System.Windows.Forms.Label()
        Me.LBFINAL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.BTNREPORTE = New System.Windows.Forms.Button()
        Me.DGVGENERAL = New System.Windows.Forms.DataGridView()
        Me.TXTCOD_ESPECIALIDAD = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TXTCLINICA = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(364, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 33)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "CALENDARIO DE CITADO"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(895, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(96, 113)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 63
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(258, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "MEDICO"
        '
        'CMBMEDICO
        '
        Me.CMBMEDICO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEDICO.FormattingEnabled = True
        Me.CMBMEDICO.Location = New System.Drawing.Point(344, 147)
        Me.CMBMEDICO.Name = "CMBMEDICO"
        Me.CMBMEDICO.Size = New System.Drawing.Size(310, 21)
        Me.CMBMEDICO.TabIndex = 67
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(9, 129)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(92, 15)
        Me.Label38.TabIndex = 66
        Me.Label38.Text = "ESPECIALIDAD"
        '
        'CMBESPECIALIDAD
        '
        Me.CMBESPECIALIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBESPECIALIDAD.FormattingEnabled = True
        Me.CMBESPECIALIDAD.Location = New System.Drawing.Point(12, 147)
        Me.CMBESPECIALIDAD.Name = "CMBESPECIALIDAD"
        Me.CMBESPECIALIDAD.Size = New System.Drawing.Size(326, 21)
        Me.CMBESPECIALIDAD.TabIndex = 65
        '
        'INICIAL
        '
        Me.INICIAL.CustomFormat = "dd/MMM/yyyy"
        Me.INICIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INICIAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.INICIAL.Location = New System.Drawing.Point(844, 119)
        Me.INICIAL.Name = "INICIAL"
        Me.INICIAL.Size = New System.Drawing.Size(139, 22)
        Me.INICIAL.TabIndex = 75
        Me.INICIAL.Value = New Date(2019, 6, 18, 0, 0, 0, 0)
        '
        'FINAL
        '
        Me.FINAL.CustomFormat = "dd/MMM/yyyy"
        Me.FINAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FINAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FINAL.Location = New System.Drawing.Point(844, 147)
        Me.FINAL.Name = "FINAL"
        Me.FINAL.Size = New System.Drawing.Size(140, 22)
        Me.FINAL.TabIndex = 76
        Me.FINAL.Value = New Date(2019, 6, 18, 0, 0, 0, 0)
        '
        'LBINICIAL
        '
        Me.LBINICIAL.AutoSize = True
        Me.LBINICIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBINICIAL.Location = New System.Drawing.Point(781, 124)
        Me.LBINICIAL.Name = "LBINICIAL"
        Me.LBINICIAL.Size = New System.Drawing.Size(47, 15)
        Me.LBINICIAL.TabIndex = 77
        Me.LBINICIAL.Text = "INICIAL"
        '
        'LBFINAL
        '
        Me.LBFINAL.AutoSize = True
        Me.LBFINAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFINAL.Location = New System.Drawing.Point(782, 152)
        Me.LBFINAL.Name = "LBFINAL"
        Me.LBFINAL.Size = New System.Drawing.Size(40, 15)
        Me.LBFINAL.TabIndex = 78
        Me.LBFINAL.Text = "FINAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 579)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "TOTAL ITEMS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Location = New System.Drawing.Point(96, 572)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.Size = New System.Drawing.Size(85, 20)
        Me.TXTTOTAL.TabIndex = 81
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(588, 563)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(66, 70)
        Me.BTNSALIR.TabIndex = 85
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.Silver
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.Location = New System.Drawing.Point(406, 563)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(66, 70)
        Me.BTNBUSCAR.TabIndex = 101
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.BackColor = System.Drawing.Color.Silver
        Me.BTNREPORTE.BackgroundImage = CType(resources.GetObject("BTNREPORTE.BackgroundImage"), System.Drawing.Image)
        Me.BTNREPORTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNREPORTE.Enabled = False
        Me.BTNREPORTE.Location = New System.Drawing.Point(499, 563)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(66, 70)
        Me.BTNREPORTE.TabIndex = 102
        Me.BTNREPORTE.UseVisualStyleBackColor = False
        '
        'DGVGENERAL
        '
        Me.DGVGENERAL.AllowUserToAddRows = False
        Me.DGVGENERAL.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVGENERAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVGENERAL.ColumnHeadersHeight = 30
        Me.DGVGENERAL.Location = New System.Drawing.Point(12, 180)
        Me.DGVGENERAL.Name = "DGVGENERAL"
        Me.DGVGENERAL.ReadOnly = True
        Me.DGVGENERAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGENERAL.Size = New System.Drawing.Size(977, 377)
        Me.DGVGENERAL.TabIndex = 121
        '
        'TXTCOD_ESPECIALIDAD
        '
        Me.TXTCOD_ESPECIALIDAD.Enabled = False
        Me.TXTCOD_ESPECIALIDAD.Location = New System.Drawing.Point(107, 128)
        Me.TXTCOD_ESPECIALIDAD.Name = "TXTCOD_ESPECIALIDAD"
        Me.TXTCOD_ESPECIALIDAD.Size = New System.Drawing.Size(43, 20)
        Me.TXTCOD_ESPECIALIDAD.TabIndex = 122
        Me.TXTCOD_ESPECIALIDAD.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(671, 129)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(62, 15)
        Me.Label39.TabIndex = 124
        Me.Label39.Text = "# CLINICA"
        '
        'TXTCLINICA
        '
        Me.TXTCLINICA.BackColor = System.Drawing.Color.White
        Me.TXTCLINICA.Enabled = False
        Me.TXTCLINICA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCLINICA.Location = New System.Drawing.Point(657, 147)
        Me.TXTCLINICA.Multiline = True
        Me.TXTCLINICA.Name = "TXTCLINICA"
        Me.TXTCLINICA.ReadOnly = True
        Me.TXTCLINICA.Size = New System.Drawing.Size(91, 22)
        Me.TXTCLINICA.TabIndex = 123
        Me.TXTCLINICA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CITADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1001, 639)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.TXTCLINICA)
        Me.Controls.Add(Me.TXTCOD_ESPECIALIDAD)
        Me.Controls.Add(Me.DGVGENERAL)
        Me.Controls.Add(Me.BTNREPORTE)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.LBFINAL)
        Me.Controls.Add(Me.LBINICIAL)
        Me.Controls.Add(Me.FINAL)
        Me.Controls.Add(Me.INICIAL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CMBMEDICO)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.CMBESPECIALIDAD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CITADO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO DE REPORTE DE CITADO"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMBMEDICO As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CMBESPECIALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents INICIAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents FINAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBINICIAL As System.Windows.Forms.Label
    Friend WithEvents LBFINAL As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents DGVGENERAL As System.Windows.Forms.DataGridView
    Friend WithEvents TXTCOD_ESPECIALIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TXTCLINICA As System.Windows.Forms.TextBox
End Class
