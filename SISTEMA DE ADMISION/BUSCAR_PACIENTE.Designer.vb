<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BUSCAR_PACIENTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BUSCAR_PACIENTE))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CMBNACIONALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTNOMBRES = New System.Windows.Forms.TextBox()
        Me.TXTPRIMER = New System.Windows.Forms.TextBox()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.DGVGENERAL = New System.Windows.Forms.DataGridView()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTSEGUNDO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTIDENTIDAD = New System.Windows.Forms.TextBox()
        Me.LBIDENTIDAD = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTDIAGNOSTICO = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CBNOMBRE = New System.Windows.Forms.CheckBox()
        Me.CBDIAGNOSTICO = New System.Windows.Forms.CheckBox()
        Me.CBIDENTIDAD = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(505, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "BUSCAR PACIENTE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(373, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "HOSPITAL NACIONAL DR. MARIO CATARINO RIVAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1167, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 91)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'CMBNACIONALIDAD
        '
        Me.CMBNACIONALIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBNACIONALIDAD.FormattingEnabled = True
        Me.CMBNACIONALIDAD.Location = New System.Drawing.Point(152, 88)
        Me.CMBNACIONALIDAD.Name = "CMBNACIONALIDAD"
        Me.CMBNACIONALIDAD.Size = New System.Drawing.Size(207, 21)
        Me.CMBNACIONALIDAD.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "NACIONALIDAD"
        '
        'TXTNOMBRES
        '
        Me.TXTNOMBRES.Enabled = False
        Me.TXTNOMBRES.Location = New System.Drawing.Point(364, 129)
        Me.TXTNOMBRES.Name = "TXTNOMBRES"
        Me.TXTNOMBRES.Size = New System.Drawing.Size(310, 20)
        Me.TXTNOMBRES.TabIndex = 4
        '
        'TXTPRIMER
        '
        Me.TXTPRIMER.Enabled = False
        Me.TXTPRIMER.Location = New System.Drawing.Point(679, 129)
        Me.TXTPRIMER.Name = "TXTPRIMER"
        Me.TXTPRIMER.Size = New System.Drawing.Size(172, 20)
        Me.TXTPRIMER.TabIndex = 5
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(1171, 295)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(77, 68)
        Me.BTNSALIR.TabIndex = 9
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'DGVGENERAL
        '
        Me.DGVGENERAL.AllowUserToAddRows = False
        Me.DGVGENERAL.AllowUserToResizeColumns = False
        Me.DGVGENERAL.AllowUserToResizeRows = False
        Me.DGVGENERAL.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGENERAL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVGENERAL.ColumnHeadersHeight = 30
        Me.DGVGENERAL.Location = New System.Drawing.Point(12, 222)
        Me.DGVGENERAL.MultiSelect = False
        Me.DGVGENERAL.Name = "DGVGENERAL"
        Me.DGVGENERAL.ReadOnly = True
        Me.DGVGENERAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGENERAL.Size = New System.Drawing.Size(1153, 301)
        Me.DGVGENERAL.TabIndex = 97
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.Silver
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.Enabled = False
        Me.BTNBUSCAR.Location = New System.Drawing.Point(1171, 221)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(77, 68)
        Me.BTNBUSCAR.TabIndex = 8
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(486, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "SECRETARIA DE SALUD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(513, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "NOMBRE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(712, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 15)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "PRIMER APELLIDO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(879, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 15)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "SEGUNDO APELLIDO"
        '
        'TXTSEGUNDO
        '
        Me.TXTSEGUNDO.Enabled = False
        Me.TXTSEGUNDO.Location = New System.Drawing.Point(855, 128)
        Me.TXTSEGUNDO.Name = "TXTSEGUNDO"
        Me.TXTSEGUNDO.Size = New System.Drawing.Size(172, 20)
        Me.TXTSEGUNDO.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(446, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "IDENTIDAD"
        '
        'TXTIDENTIDAD
        '
        Me.TXTIDENTIDAD.Enabled = False
        Me.TXTIDENTIDAD.Location = New System.Drawing.Point(365, 88)
        Me.TXTIDENTIDAD.Name = "TXTIDENTIDAD"
        Me.TXTIDENTIDAD.Size = New System.Drawing.Size(230, 20)
        Me.TXTIDENTIDAD.TabIndex = 3
        '
        'LBIDENTIDAD
        '
        Me.LBIDENTIDAD.Enabled = False
        Me.LBIDENTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBIDENTIDAD.Location = New System.Drawing.Point(521, 109)
        Me.LBIDENTIDAD.Name = "LBIDENTIDAD"
        Me.LBIDENTIDAD.Size = New System.Drawing.Size(21, 18)
        Me.LBIDENTIDAD.TabIndex = 105
        Me.LBIDENTIDAD.Text = "0"
        Me.LBIDENTIDAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 537)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "TOTAL ITEMS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.BackColor = System.Drawing.Color.White
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(96, 530)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(105, 24)
        Me.TXTTOTAL.TabIndex = 106
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(645, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 15)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "DIAGNNOSTICO"
        '
        'TXTDIAGNOSTICO
        '
        Me.TXTDIAGNOSTICO.Enabled = False
        Me.TXTDIAGNOSTICO.Location = New System.Drawing.Point(364, 173)
        Me.TXTDIAGNOSTICO.Name = "TXTDIAGNOSTICO"
        Me.TXTDIAGNOSTICO.Size = New System.Drawing.Size(663, 20)
        Me.TXTDIAGNOSTICO.TabIndex = 7
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.CBNOMBRE)
        Me.GroupBox6.Controls.Add(Me.CBDIAGNOSTICO)
        Me.GroupBox6.Controls.Add(Me.CBIDENTIDAD)
        Me.GroupBox6.Location = New System.Drawing.Point(104, 115)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(254, 84)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "METODO DE BUSQUEDA"
        '
        'CBNOMBRE
        '
        Me.CBNOMBRE.AutoSize = True
        Me.CBNOMBRE.Enabled = False
        Me.CBNOMBRE.Location = New System.Drawing.Point(9, 39)
        Me.CBNOMBRE.Name = "CBNOMBRE"
        Me.CBNOMBRE.Size = New System.Drawing.Size(153, 17)
        Me.CBNOMBRE.TabIndex = 4
        Me.CBNOMBRE.Text = "NOMBRE DEL PACIENTE"
        Me.CBNOMBRE.UseVisualStyleBackColor = True
        '
        'CBDIAGNOSTICO
        '
        Me.CBDIAGNOSTICO.AutoSize = True
        Me.CBDIAGNOSTICO.Enabled = False
        Me.CBDIAGNOSTICO.Location = New System.Drawing.Point(9, 60)
        Me.CBDIAGNOSTICO.Name = "CBDIAGNOSTICO"
        Me.CBDIAGNOSTICO.Size = New System.Drawing.Size(100, 17)
        Me.CBDIAGNOSTICO.TabIndex = 2
        Me.CBDIAGNOSTICO.Text = "DIAGNOSTICO"
        Me.CBDIAGNOSTICO.UseVisualStyleBackColor = True
        '
        'CBIDENTIDAD
        '
        Me.CBIDENTIDAD.AutoSize = True
        Me.CBIDENTIDAD.Enabled = False
        Me.CBIDENTIDAD.Location = New System.Drawing.Point(9, 19)
        Me.CBIDENTIDAD.Name = "CBIDENTIDAD"
        Me.CBIDENTIDAD.Size = New System.Drawing.Size(85, 17)
        Me.CBIDENTIDAD.TabIndex = 1
        Me.CBIDENTIDAD.Text = "IDENTIDAD"
        Me.CBIDENTIDAD.UseVisualStyleBackColor = True
        '
        'BUSCAR_PACIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1274, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXTDIAGNOSTICO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.LBIDENTIDAD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTIDENTIDAD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTSEGUNDO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.DGVGENERAL)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.TXTPRIMER)
        Me.Controls.Add(Me.TXTNOMBRES)
        Me.Controls.Add(Me.CMBNACIONALIDAD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BUSCAR_PACIENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR PACIENTE"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents CMBNACIONALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMBRES As System.Windows.Forms.TextBox
    Friend WithEvents TXTPRIMER As System.Windows.Forms.TextBox
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents DGVGENERAL As System.Windows.Forms.DataGridView
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTSEGUNDO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTIDENTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents LBIDENTIDAD As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTDIAGNOSTICO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CBNOMBRE As System.Windows.Forms.CheckBox
    Friend WithEvents CBDIAGNOSTICO As System.Windows.Forms.CheckBox
    Friend WithEvents CBIDENTIDAD As System.Windows.Forms.CheckBox
End Class
