<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ELIMINAR_CITA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ELIMINAR_CITA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTNCORRELATIVO = New System.Windows.Forms.Button()
        Me.BTNIDENTIDAD = New System.Windows.Forms.Button()
        Me.TXTCORRELATIVO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTIDENTIDAD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CMBNACIONALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CMBBUSQUEDA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LBPACIENTE = New System.Windows.Forms.Label()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.DGVGENERAL = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNCORRELATIVO
        '
        Me.BTNCORRELATIVO.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNCORRELATIVO.BackgroundImage = CType(resources.GetObject("BTNCORRELATIVO.BackgroundImage"), System.Drawing.Image)
        Me.BTNCORRELATIVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCORRELATIVO.Location = New System.Drawing.Point(381, 227)
        Me.BTNCORRELATIVO.Name = "BTNCORRELATIVO"
        Me.BTNCORRELATIVO.Size = New System.Drawing.Size(31, 25)
        Me.BTNCORRELATIVO.TabIndex = 15
        Me.BTNCORRELATIVO.UseVisualStyleBackColor = False
        '
        'BTNIDENTIDAD
        '
        Me.BTNIDENTIDAD.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNIDENTIDAD.BackgroundImage = CType(resources.GetObject("BTNIDENTIDAD.BackgroundImage"), System.Drawing.Image)
        Me.BTNIDENTIDAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIDENTIDAD.FlatAppearance.BorderSize = 50
        Me.BTNIDENTIDAD.Location = New System.Drawing.Point(381, 202)
        Me.BTNIDENTIDAD.Name = "BTNIDENTIDAD"
        Me.BTNIDENTIDAD.Size = New System.Drawing.Size(31, 25)
        Me.BTNIDENTIDAD.TabIndex = 12
        Me.BTNIDENTIDAD.UseVisualStyleBackColor = False
        '
        'TXTCORRELATIVO
        '
        Me.TXTCORRELATIVO.Location = New System.Drawing.Point(164, 227)
        Me.TXTCORRELATIVO.MaxLength = 15
        Me.TXTCORRELATIVO.Name = "TXTCORRELATIVO"
        Me.TXTCORRELATIVO.Size = New System.Drawing.Size(211, 20)
        Me.TXTCORRELATIVO.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "CORRELATIVO"
        '
        'TXTIDENTIDAD
        '
        Me.TXTIDENTIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIDENTIDAD.Location = New System.Drawing.Point(164, 202)
        Me.TXTIDENTIDAD.MaxLength = 30
        Me.TXTIDENTIDAD.Name = "TXTIDENTIDAD"
        Me.TXTIDENTIDAD.Size = New System.Drawing.Size(211, 20)
        Me.TXTIDENTIDAD.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "TARJETA DE IDENTIDAD"
        '
        'CMBNACIONALIDAD
        '
        Me.CMBNACIONALIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBNACIONALIDAD.FormattingEnabled = True
        Me.CMBNACIONALIDAD.Location = New System.Drawing.Point(164, 146)
        Me.CMBNACIONALIDAD.Name = "CMBNACIONALIDAD"
        Me.CMBNACIONALIDAD.Size = New System.Drawing.Size(233, 21)
        Me.CMBNACIONALIDAD.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "NACIONALIDAD"
        '
        'CMBBUSQUEDA
        '
        Me.CMBBUSQUEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBBUSQUEDA.FormattingEnabled = True
        Me.CMBBUSQUEDA.Location = New System.Drawing.Point(164, 173)
        Me.CMBBUSQUEDA.Name = "CMBBUSQUEDA"
        Me.CMBBUSQUEDA.Size = New System.Drawing.Size(233, 21)
        Me.CMBBUSQUEDA.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TIPO DE BUSQUEDA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(422, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 33)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "HISTORIAL DE CITA DEL PACIENTE"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1043, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(103, 123)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 68
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(306, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'LBPACIENTE
        '
        Me.LBPACIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPACIENTE.ForeColor = System.Drawing.Color.Black
        Me.LBPACIENTE.Location = New System.Drawing.Point(336, 62)
        Me.LBPACIENTE.Name = "LBPACIENTE"
        Me.LBPACIENTE.Size = New System.Drawing.Size(686, 64)
        Me.LBPACIENTE.TabIndex = 70
        Me.LBPACIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.BackColor = System.Drawing.Color.Silver
        Me.BTNELIMINAR.BackgroundImage = CType(resources.GetObject("BTNELIMINAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNELIMINAR.Location = New System.Drawing.Point(436, 153)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(87, 94)
        Me.BTNELIMINAR.TabIndex = 71
        Me.BTNELIMINAR.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.Location = New System.Drawing.Point(529, 152)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(87, 94)
        Me.BTNSALIR.TabIndex = 72
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 529)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "TOTAL ITEMS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(96, 522)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.Size = New System.Drawing.Size(141, 24)
        Me.TXTTOTAL.TabIndex = 97
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVGENERAL
        '
        Me.DGVGENERAL.AllowUserToAddRows = False
        Me.DGVGENERAL.AllowUserToResizeColumns = False
        Me.DGVGENERAL.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGENERAL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVGENERAL.ColumnHeadersHeight = 30
        Me.DGVGENERAL.Location = New System.Drawing.Point(12, 258)
        Me.DGVGENERAL.MultiSelect = False
        Me.DGVGENERAL.Name = "DGVGENERAL"
        Me.DGVGENERAL.ReadOnly = True
        Me.DGVGENERAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGENERAL.Size = New System.Drawing.Size(1134, 253)
        Me.DGVGENERAL.TabIndex = 99
        '
        'ELIMINAR_CITA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1154, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVGENERAL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.LBPACIENTE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BTNCORRELATIVO)
        Me.Controls.Add(Me.BTNIDENTIDAD)
        Me.Controls.Add(Me.TXTCORRELATIVO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTIDENTIDAD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CMBNACIONALIDAD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CMBBUSQUEDA)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ELIMINAR_CITA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO PARA ELIMINAR CITA"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNCORRELATIVO As System.Windows.Forms.Button
    Friend WithEvents BTNIDENTIDAD As System.Windows.Forms.Button
    Friend WithEvents TXTCORRELATIVO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTIDENTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CMBNACIONALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CMBBUSQUEDA As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LBPACIENTE As System.Windows.Forms.Label
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents DGVGENERAL As System.Windows.Forms.DataGridView
End Class
