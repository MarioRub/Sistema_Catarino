<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CALENDARIO_CITA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CALENDARIO_CITA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CMBESPECIALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBMEDICO = New System.Windows.Forms.ComboBox()
        Me.BTNREGRESAR = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTTOTALNO = New System.Windows.Forms.TextBox()
        Me.LBMEDICO = New System.Windows.Forms.Label()
        Me.DGVACTIVO = New System.Windows.Forms.DataGridView()
        Me.DGVNOACTIVO = New System.Windows.Forms.DataGridView()
        Me.BTNNO = New System.Windows.Forms.Button()
        Me.BTNACTIVO = New System.Windows.Forms.Button()
        Me.BTNNOACTIVO = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CBVIERNES = New System.Windows.Forms.CheckBox()
        Me.CBJUEVES = New System.Windows.Forms.CheckBox()
        Me.CBMIERCOLES = New System.Windows.Forms.CheckBox()
        Me.CBMARTES = New System.Windows.Forms.CheckBox()
        Me.CBLUNES = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBV = New System.Windows.Forms.CheckBox()
        Me.CBJ = New System.Windows.Forms.CheckBox()
        Me.CBMI = New System.Windows.Forms.CheckBox()
        Me.CBM = New System.Windows.Forms.CheckBox()
        Me.CBL = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVACTIVO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVNOACTIVO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(983, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(101, 114)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(267, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(12, 91)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(92, 15)
        Me.Label38.TabIndex = 59
        Me.Label38.Text = "ESPECIALIDAD"
        '
        'CMBESPECIALIDAD
        '
        Me.CMBESPECIALIDAD.Enabled = False
        Me.CMBESPECIALIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBESPECIALIDAD.FormattingEnabled = True
        Me.CMBESPECIALIDAD.Location = New System.Drawing.Point(15, 109)
        Me.CMBESPECIALIDAD.Name = "CMBESPECIALIDAD"
        Me.CMBESPECIALIDAD.Size = New System.Drawing.Size(326, 21)
        Me.CMBESPECIALIDAD.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(431, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 33)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "CALENDARIO DE CITA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(347, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "MEDICO"
        '
        'CMBMEDICO
        '
        Me.CMBMEDICO.Enabled = False
        Me.CMBMEDICO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEDICO.FormattingEnabled = True
        Me.CMBMEDICO.Location = New System.Drawing.Point(347, 109)
        Me.CMBMEDICO.Name = "CMBMEDICO"
        Me.CMBMEDICO.Size = New System.Drawing.Size(242, 21)
        Me.CMBMEDICO.TabIndex = 61
        '
        'BTNREGRESAR
        '
        Me.BTNREGRESAR.BackColor = System.Drawing.Color.Silver
        Me.BTNREGRESAR.BackgroundImage = CType(resources.GetObject("BTNREGRESAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNREGRESAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNREGRESAR.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTNREGRESAR.FlatAppearance.BorderSize = 3
        Me.BTNREGRESAR.Location = New System.Drawing.Point(595, 71)
        Me.BTNREGRESAR.Name = "BTNREGRESAR"
        Me.BTNREGRESAR.Size = New System.Drawing.Size(74, 61)
        Me.BTNREGRESAR.TabIndex = 64
        Me.BTNREGRESAR.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 29)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "FECHAS OTORGADAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(652, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 29)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "FECHAS OTORGADAS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.BackColor = System.Drawing.Color.White
        Me.TXTTOTAL.Location = New System.Drawing.Point(98, 566)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(85, 20)
        Me.TXTTOTAL.TabIndex = 71
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 573)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "TOTAL ITEMS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(915, 573)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "TOTAL ITEMS"
        '
        'TXTTOTALNO
        '
        Me.TXTTOTALNO.BackColor = System.Drawing.Color.White
        Me.TXTTOTALNO.Location = New System.Drawing.Point(997, 566)
        Me.TXTTOTALNO.Name = "TXTTOTALNO"
        Me.TXTTOTALNO.ReadOnly = True
        Me.TXTTOTALNO.Size = New System.Drawing.Size(85, 20)
        Me.TXTTOTALNO.TabIndex = 73
        Me.TXTTOTALNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBMEDICO
        '
        Me.LBMEDICO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMEDICO.ForeColor = System.Drawing.Color.Blue
        Me.LBMEDICO.Location = New System.Drawing.Point(15, 629)
        Me.LBMEDICO.Name = "LBMEDICO"
        Me.LBMEDICO.Size = New System.Drawing.Size(1064, 86)
        Me.LBMEDICO.TabIndex = 75
        Me.LBMEDICO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DGVACTIVO
        '
        Me.DGVACTIVO.AllowUserToAddRows = False
        Me.DGVACTIVO.AllowUserToResizeColumns = False
        Me.DGVACTIVO.AllowUserToResizeRows = False
        Me.DGVACTIVO.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVACTIVO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVACTIVO.ColumnHeadersHeight = 30
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVACTIVO.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVACTIVO.Location = New System.Drawing.Point(17, 200)
        Me.DGVACTIVO.MultiSelect = False
        Me.DGVACTIVO.Name = "DGVACTIVO"
        Me.DGVACTIVO.ReadOnly = True
        Me.DGVACTIVO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVACTIVO.Size = New System.Drawing.Size(528, 360)
        Me.DGVACTIVO.TabIndex = 97
        '
        'DGVNOACTIVO
        '
        Me.DGVNOACTIVO.AllowUserToAddRows = False
        Me.DGVNOACTIVO.AllowUserToResizeColumns = False
        Me.DGVNOACTIVO.AllowUserToResizeRows = False
        Me.DGVNOACTIVO.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVNOACTIVO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVNOACTIVO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVNOACTIVO.ColumnHeadersHeight = 30
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVNOACTIVO.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVNOACTIVO.Location = New System.Drawing.Point(558, 200)
        Me.DGVNOACTIVO.MultiSelect = False
        Me.DGVNOACTIVO.Name = "DGVNOACTIVO"
        Me.DGVNOACTIVO.ReadOnly = True
        Me.DGVNOACTIVO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVNOACTIVO.Size = New System.Drawing.Size(528, 360)
        Me.DGVNOACTIVO.TabIndex = 98
        '
        'BTNNO
        '
        Me.BTNNO.BackColor = System.Drawing.Color.Silver
        Me.BTNNO.BackgroundImage = CType(resources.GetObject("BTNNO.BackgroundImage"), System.Drawing.Image)
        Me.BTNNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNNO.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTNNO.Location = New System.Drawing.Point(1010, 135)
        Me.BTNNO.Name = "BTNNO"
        Me.BTNNO.Size = New System.Drawing.Size(74, 61)
        Me.BTNNO.TabIndex = 99
        Me.BTNNO.UseVisualStyleBackColor = False
        '
        'BTNACTIVO
        '
        Me.BTNACTIVO.BackColor = System.Drawing.Color.Silver
        Me.BTNACTIVO.BackgroundImage = CType(resources.GetObject("BTNACTIVO.BackgroundImage"), System.Drawing.Image)
        Me.BTNACTIVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACTIVO.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTNACTIVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACTIVO.Location = New System.Drawing.Point(392, 136)
        Me.BTNACTIVO.Name = "BTNACTIVO"
        Me.BTNACTIVO.Size = New System.Drawing.Size(74, 61)
        Me.BTNACTIVO.TabIndex = 100
        Me.BTNACTIVO.UseVisualStyleBackColor = False
        '
        'BTNNOACTIVO
        '
        Me.BTNNOACTIVO.BackColor = System.Drawing.Color.Silver
        Me.BTNNOACTIVO.BackgroundImage = CType(resources.GetObject("BTNNOACTIVO.BackgroundImage"), System.Drawing.Image)
        Me.BTNNOACTIVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNNOACTIVO.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTNNOACTIVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNOACTIVO.Location = New System.Drawing.Point(930, 135)
        Me.BTNNOACTIVO.Name = "BTNNOACTIVO"
        Me.BTNNOACTIVO.Size = New System.Drawing.Size(74, 61)
        Me.BTNNOACTIVO.TabIndex = 101
        Me.BTNNOACTIVO.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox7.Controls.Add(Me.CBVIERNES)
        Me.GroupBox7.Controls.Add(Me.CBJUEVES)
        Me.GroupBox7.Controls.Add(Me.CBMIERCOLES)
        Me.GroupBox7.Controls.Add(Me.CBMARTES)
        Me.GroupBox7.Controls.Add(Me.CBLUNES)
        Me.GroupBox7.Enabled = False
        Me.GroupBox7.Location = New System.Drawing.Point(187, 566)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(364, 60)
        Me.GroupBox7.TabIndex = 102
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "DIAS QUE LABORA EL MEDICO"
        '
        'CBVIERNES
        '
        Me.CBVIERNES.AutoSize = True
        Me.CBVIERNES.Enabled = False
        Me.CBVIERNES.Location = New System.Drawing.Point(287, 29)
        Me.CBVIERNES.Name = "CBVIERNES"
        Me.CBVIERNES.Size = New System.Drawing.Size(73, 17)
        Me.CBVIERNES.TabIndex = 5
        Me.CBVIERNES.Text = "VIERNES"
        Me.CBVIERNES.UseVisualStyleBackColor = True
        '
        'CBJUEVES
        '
        Me.CBJUEVES.AutoSize = True
        Me.CBJUEVES.Enabled = False
        Me.CBJUEVES.Location = New System.Drawing.Point(222, 29)
        Me.CBJUEVES.Name = "CBJUEVES"
        Me.CBJUEVES.Size = New System.Drawing.Size(67, 17)
        Me.CBJUEVES.TabIndex = 4
        Me.CBJUEVES.Text = "JUEVES"
        Me.CBJUEVES.UseVisualStyleBackColor = True
        '
        'CBMIERCOLES
        '
        Me.CBMIERCOLES.AutoSize = True
        Me.CBMIERCOLES.Enabled = False
        Me.CBMIERCOLES.Location = New System.Drawing.Point(136, 29)
        Me.CBMIERCOLES.Name = "CBMIERCOLES"
        Me.CBMIERCOLES.Size = New System.Drawing.Size(88, 17)
        Me.CBMIERCOLES.TabIndex = 3
        Me.CBMIERCOLES.Text = "MIERCOLES"
        Me.CBMIERCOLES.UseVisualStyleBackColor = True
        '
        'CBMARTES
        '
        Me.CBMARTES.AutoSize = True
        Me.CBMARTES.Enabled = False
        Me.CBMARTES.Location = New System.Drawing.Point(67, 29)
        Me.CBMARTES.Name = "CBMARTES"
        Me.CBMARTES.Size = New System.Drawing.Size(71, 17)
        Me.CBMARTES.TabIndex = 2
        Me.CBMARTES.Text = "MARTES"
        Me.CBMARTES.UseVisualStyleBackColor = True
        '
        'CBLUNES
        '
        Me.CBLUNES.AutoSize = True
        Me.CBLUNES.Enabled = False
        Me.CBLUNES.Location = New System.Drawing.Point(7, 29)
        Me.CBLUNES.Name = "CBLUNES"
        Me.CBLUNES.Size = New System.Drawing.Size(62, 17)
        Me.CBLUNES.TabIndex = 1
        Me.CBLUNES.Text = "LUNES"
        Me.CBLUNES.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.CBV)
        Me.GroupBox1.Controls.Add(Me.CBJ)
        Me.GroupBox1.Controls.Add(Me.CBMI)
        Me.GroupBox1.Controls.Add(Me.CBM)
        Me.GroupBox1.Controls.Add(Me.CBL)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(557, 566)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 60)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DIAS QUE SE DIALISA"
        '
        'CBV
        '
        Me.CBV.AutoSize = True
        Me.CBV.Enabled = False
        Me.CBV.Location = New System.Drawing.Point(284, 29)
        Me.CBV.Name = "CBV"
        Me.CBV.Size = New System.Drawing.Size(73, 17)
        Me.CBV.TabIndex = 5
        Me.CBV.Text = "VIERNES"
        Me.CBV.UseVisualStyleBackColor = True
        '
        'CBJ
        '
        Me.CBJ.AutoSize = True
        Me.CBJ.Enabled = False
        Me.CBJ.Location = New System.Drawing.Point(220, 29)
        Me.CBJ.Name = "CBJ"
        Me.CBJ.Size = New System.Drawing.Size(67, 17)
        Me.CBJ.TabIndex = 4
        Me.CBJ.Text = "JUEVES"
        Me.CBJ.UseVisualStyleBackColor = True
        '
        'CBMI
        '
        Me.CBMI.AutoSize = True
        Me.CBMI.Enabled = False
        Me.CBMI.Location = New System.Drawing.Point(135, 29)
        Me.CBMI.Name = "CBMI"
        Me.CBMI.Size = New System.Drawing.Size(88, 17)
        Me.CBMI.TabIndex = 3
        Me.CBMI.Text = "MIERCOLES"
        Me.CBMI.UseVisualStyleBackColor = True
        '
        'CBM
        '
        Me.CBM.AutoSize = True
        Me.CBM.Enabled = False
        Me.CBM.Location = New System.Drawing.Point(67, 29)
        Me.CBM.Name = "CBM"
        Me.CBM.Size = New System.Drawing.Size(71, 17)
        Me.CBM.TabIndex = 2
        Me.CBM.Text = "MARTES"
        Me.CBM.UseVisualStyleBackColor = True
        '
        'CBL
        '
        Me.CBL.AutoSize = True
        Me.CBL.Enabled = False
        Me.CBL.Location = New System.Drawing.Point(8, 29)
        Me.CBL.Name = "CBL"
        Me.CBL.Size = New System.Drawing.Size(62, 17)
        Me.CBL.TabIndex = 1
        Me.CBL.Text = "LUNES"
        Me.CBL.UseVisualStyleBackColor = True
        '
        'CALENDARIO_CITA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1091, 724)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.BTNNOACTIVO)
        Me.Controls.Add(Me.BTNACTIVO)
        Me.Controls.Add(Me.BTNNO)
        Me.Controls.Add(Me.DGVNOACTIVO)
        Me.Controls.Add(Me.DGVACTIVO)
        Me.Controls.Add(Me.LBMEDICO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTTOTALNO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNREGRESAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CMBMEDICO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.CMBESPECIALIDAD)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "CALENDARIO_CITA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CALENDARIO DE CITA DE CONSULTA EXTERNA"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVACTIVO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVNOACTIVO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CMBESPECIALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMBMEDICO As System.Windows.Forms.ComboBox
    Friend WithEvents BTNREGRESAR As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTALNO As System.Windows.Forms.TextBox
    Friend WithEvents LBMEDICO As System.Windows.Forms.Label
    Friend WithEvents DGVACTIVO As System.Windows.Forms.DataGridView
    Friend WithEvents DGVNOACTIVO As System.Windows.Forms.DataGridView
    Friend WithEvents BTNNO As System.Windows.Forms.Button
    Friend WithEvents BTNACTIVO As System.Windows.Forms.Button
    Friend WithEvents BTNNOACTIVO As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents CBVIERNES As System.Windows.Forms.CheckBox
    Friend WithEvents CBJUEVES As System.Windows.Forms.CheckBox
    Friend WithEvents CBMIERCOLES As System.Windows.Forms.CheckBox
    Friend WithEvents CBMARTES As System.Windows.Forms.CheckBox
    Friend WithEvents CBLUNES As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBV As System.Windows.Forms.CheckBox
    Friend WithEvents CBJ As System.Windows.Forms.CheckBox
    Friend WithEvents CBMI As System.Windows.Forms.CheckBox
    Friend WithEvents CBM As System.Windows.Forms.CheckBox
    Friend WithEvents CBL As System.Windows.Forms.CheckBox
End Class
