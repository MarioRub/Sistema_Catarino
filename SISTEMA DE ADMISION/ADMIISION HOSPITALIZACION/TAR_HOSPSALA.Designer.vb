<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TAR_HOSPSALA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TAR_HOSPSALA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LBCLASIFICACION = New System.Windows.Forms.Label()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.LBTIPO = New System.Windows.Forms.Label()
        Me.LBNACIONALIDAD = New System.Windows.Forms.Label()
        Me.DGVGENERAL = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.LBIDENTIDAD = New System.Windows.Forms.Label()
        Me.LBPACIENTE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBCLASIFICACION
        '
        Me.LBCLASIFICACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCLASIFICACION.ForeColor = System.Drawing.Color.Blue
        Me.LBCLASIFICACION.Location = New System.Drawing.Point(102, 70)
        Me.LBCLASIFICACION.Name = "LBCLASIFICACION"
        Me.LBCLASIFICACION.Size = New System.Drawing.Size(178, 25)
        Me.LBCLASIFICACION.TabIndex = 139
        Me.LBCLASIFICACION.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBCLASIFICACION.Visible = False
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackColor = System.Drawing.Color.Silver
        Me.BTNACEPTAR.BackgroundImage = CType(resources.GetObject("BTNACEPTAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACEPTAR.Location = New System.Drawing.Point(363, 517)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(57, 59)
        Me.BTNACEPTAR.TabIndex = 127
        Me.BTNACEPTAR.UseVisualStyleBackColor = False
        '
        'LBTIPO
        '
        Me.LBTIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTIPO.ForeColor = System.Drawing.Color.Blue
        Me.LBTIPO.Location = New System.Drawing.Point(102, 95)
        Me.LBTIPO.Name = "LBTIPO"
        Me.LBTIPO.Size = New System.Drawing.Size(178, 25)
        Me.LBTIPO.TabIndex = 138
        Me.LBTIPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBTIPO.Visible = False
        '
        'LBNACIONALIDAD
        '
        Me.LBNACIONALIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNACIONALIDAD.ForeColor = System.Drawing.Color.Blue
        Me.LBNACIONALIDAD.Location = New System.Drawing.Point(294, 100)
        Me.LBNACIONALIDAD.Name = "LBNACIONALIDAD"
        Me.LBNACIONALIDAD.Size = New System.Drawing.Size(587, 25)
        Me.LBNACIONALIDAD.TabIndex = 137
        Me.LBNACIONALIDAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVGENERAL
        '
        Me.DGVGENERAL.AllowUserToAddRows = False
        Me.DGVGENERAL.AllowUserToResizeColumns = False
        Me.DGVGENERAL.AllowUserToResizeRows = False
        Me.DGVGENERAL.BackgroundColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGENERAL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVGENERAL.ColumnHeadersHeight = 30
        Me.DGVGENERAL.Location = New System.Drawing.Point(8, 126)
        Me.DGVGENERAL.MultiSelect = False
        Me.DGVGENERAL.Name = "DGVGENERAL"
        Me.DGVGENERAL.ReadOnly = True
        Me.DGVGENERAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGENERAL.Size = New System.Drawing.Size(1000, 385)
        Me.DGVGENERAL.TabIndex = 136
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 534)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "TOTAL ITEMS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.BackColor = System.Drawing.Color.White
        Me.TXTTOTAL.Enabled = False
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(107, 527)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(116, 24)
        Me.TXTTOTAL.TabIndex = 134
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(517, 519)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(58, 57)
        Me.BTNSALIR.TabIndex = 128
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'LBIDENTIDAD
        '
        Me.LBIDENTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBIDENTIDAD.ForeColor = System.Drawing.Color.Blue
        Me.LBIDENTIDAD.Location = New System.Drawing.Point(294, 75)
        Me.LBIDENTIDAD.Name = "LBIDENTIDAD"
        Me.LBIDENTIDAD.Size = New System.Drawing.Size(587, 25)
        Me.LBIDENTIDAD.TabIndex = 133
        Me.LBIDENTIDAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBPACIENTE
        '
        Me.LBPACIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPACIENTE.ForeColor = System.Drawing.Color.Blue
        Me.LBPACIENTE.Location = New System.Drawing.Point(294, 50)
        Me.LBPACIENTE.Name = "LBPACIENTE"
        Me.LBPACIENTE.Size = New System.Drawing.Size(587, 25)
        Me.LBPACIENTE.TabIndex = 132
        Me.LBPACIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 33)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "HISTORIAL DE PACIENTE HOSPITALIZADO"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(927, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 94)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 130
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(242, 89)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 129
        Me.PictureBox2.TabStop = False
        '
        'TAR_HOSPSALA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1016, 583)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBCLASIFICACION)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.LBTIPO)
        Me.Controls.Add(Me.LBNACIONALIDAD)
        Me.Controls.Add(Me.DGVGENERAL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.LBIDENTIDAD)
        Me.Controls.Add(Me.LBPACIENTE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TAR_HOSPSALA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR REGISTRO HOSPITALIZACION PARA OTORGAR TARJETA DE VISITA"
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBCLASIFICACION As System.Windows.Forms.Label
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents LBTIPO As System.Windows.Forms.Label
    Friend WithEvents LBNACIONALIDAD As System.Windows.Forms.Label
    Friend WithEvents DGVGENERAL As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents LBIDENTIDAD As System.Windows.Forms.Label
    Friend WithEvents LBPACIENTE As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
