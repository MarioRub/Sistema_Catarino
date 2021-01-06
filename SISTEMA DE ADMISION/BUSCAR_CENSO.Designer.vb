<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BUSCAR_CENSO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BUSCAR_CENSO))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CBNOMBRE = New System.Windows.Forms.CheckBox()
        Me.CBID = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ID1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ID2 = New System.Windows.Forms.TextBox()
        Me.ID3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PAPELLIDO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SAPELLIDO = New System.Windows.Forms.TextBox()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.DGVGENERAL = New System.Windows.Forms.DataGridView()
        Me.BTNLIMPIAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.CBNOMBRE)
        Me.GroupBox6.Controls.Add(Me.CBID)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(284, 50)
        Me.GroupBox6.TabIndex = 125
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "METODO DE BUSQUEDA"
        '
        'CBNOMBRE
        '
        Me.CBNOMBRE.AutoSize = True
        Me.CBNOMBRE.Location = New System.Drawing.Point(183, 19)
        Me.CBNOMBRE.Name = "CBNOMBRE"
        Me.CBNOMBRE.Size = New System.Drawing.Size(73, 17)
        Me.CBNOMBRE.TabIndex = 4
        Me.CBNOMBRE.Text = "NOMBRE"
        Me.CBNOMBRE.UseVisualStyleBackColor = True
        '
        'CBID
        '
        Me.CBID.AutoSize = True
        Me.CBID.Location = New System.Drawing.Point(15, 19)
        Me.CBID.Name = "CBID"
        Me.CBID.Size = New System.Drawing.Size(85, 17)
        Me.CBID.TabIndex = 1
        Me.CBID.Text = "IDENTIDAD"
        Me.CBID.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(205, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 126
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(926, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 93)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 127
        Me.PictureBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(435, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "IDENTIDAD"
        '
        'ID1
        '
        Me.ID1.Enabled = False
        Me.ID1.Location = New System.Drawing.Point(341, 95)
        Me.ID1.MaxLength = 4
        Me.ID1.Name = "ID1"
        Me.ID1.Size = New System.Drawing.Size(76, 20)
        Me.ID1.TabIndex = 135
        Me.ID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "PRIMER NOMBRE"
        '
        'PNOMBRE
        '
        Me.PNOMBRE.Enabled = False
        Me.PNOMBRE.Location = New System.Drawing.Point(32, 145)
        Me.PNOMBRE.Name = "PNOMBRE"
        Me.PNOMBRE.Size = New System.Drawing.Size(139, 20)
        Me.PNOMBRE.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(254, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(605, 55)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "FORMULARIO PARA BUSCAR PACIENTE EN BASE DE DATO DE RNP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ID2
        '
        Me.ID2.Enabled = False
        Me.ID2.Location = New System.Drawing.Point(433, 95)
        Me.ID2.MaxLength = 4
        Me.ID2.Name = "ID2"
        Me.ID2.Size = New System.Drawing.Size(76, 20)
        Me.ID2.TabIndex = 141
        Me.ID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID3
        '
        Me.ID3.Enabled = False
        Me.ID3.Location = New System.Drawing.Point(524, 95)
        Me.ID3.MaxLength = 5
        Me.ID3.Name = "ID3"
        Me.ID3.Size = New System.Drawing.Size(80, 20)
        Me.ID3.TabIndex = 142
        Me.ID3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(414, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 18)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "-"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(506, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 18)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(185, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "SEGUNDO NOMBRE"
        '
        'SNOMBRE
        '
        Me.SNOMBRE.Enabled = False
        Me.SNOMBRE.Location = New System.Drawing.Point(177, 145)
        Me.SNOMBRE.Name = "SNOMBRE"
        Me.SNOMBRE.Size = New System.Drawing.Size(139, 20)
        Me.SNOMBRE.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 15)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "PRIMER APELLIDO"
        '
        'PAPELLIDO
        '
        Me.PAPELLIDO.Enabled = False
        Me.PAPELLIDO.Location = New System.Drawing.Point(322, 145)
        Me.PAPELLIDO.Name = "PAPELLIDO"
        Me.PAPELLIDO.Size = New System.Drawing.Size(139, 20)
        Me.PAPELLIDO.TabIndex = 147
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(475, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 15)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "SEGUNDO APELLIDO"
        '
        'SAPELLIDO
        '
        Me.SAPELLIDO.Enabled = False
        Me.SAPELLIDO.Location = New System.Drawing.Point(467, 145)
        Me.SAPELLIDO.Name = "SAPELLIDO"
        Me.SAPELLIDO.Size = New System.Drawing.Size(139, 20)
        Me.SAPELLIDO.TabIndex = 149
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.Silver
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.Enabled = False
        Me.BTNBUSCAR.Location = New System.Drawing.Point(719, 113)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(81, 83)
        Me.BTNBUSCAR.TabIndex = 151
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 540)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "TOTAL ITEMS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.BackColor = System.Drawing.Color.White
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(96, 533)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(103, 24)
        Me.TXTTOTAL.TabIndex = 154
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVGENERAL
        '
        Me.DGVGENERAL.AllowUserToAddRows = False
        Me.DGVGENERAL.AllowUserToResizeColumns = False
        Me.DGVGENERAL.AllowUserToResizeRows = False
        Me.DGVGENERAL.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVGENERAL.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGENERAL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVGENERAL.ColumnHeadersHeight = 30
        Me.DGVGENERAL.Location = New System.Drawing.Point(13, 202)
        Me.DGVGENERAL.MultiSelect = False
        Me.DGVGENERAL.Name = "DGVGENERAL"
        Me.DGVGENERAL.ReadOnly = True
        Me.DGVGENERAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGENERAL.Size = New System.Drawing.Size(999, 315)
        Me.DGVGENERAL.TabIndex = 153
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.BackColor = System.Drawing.Color.Silver
        Me.BTNLIMPIAR.BackgroundImage = CType(resources.GetObject("BTNLIMPIAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNLIMPIAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(623, 113)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(81, 83)
        Me.BTNLIMPIAR.TabIndex = 156
        Me.BTNLIMPIAR.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(820, 114)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(81, 82)
        Me.BTNSALIR.TabIndex = 157
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'BUSCAR_CENSO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1019, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNLIMPIAR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.DGVGENERAL)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SAPELLIDO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PAPELLIDO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SNOMBRE)
        Me.Controls.Add(Me.ID3)
        Me.Controls.Add(Me.ID2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ID1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PNOMBRE)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BUSCAR_CENSO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR EN CENSO ELECTORAL DEL RNP"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CBNOMBRE As System.Windows.Forms.CheckBox
    Friend WithEvents CBID As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ID1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ID2 As System.Windows.Forms.TextBox
    Friend WithEvents ID3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PAPELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SAPELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents DGVGENERAL As System.Windows.Forms.DataGridView
    Friend WithEvents BTNLIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
End Class
