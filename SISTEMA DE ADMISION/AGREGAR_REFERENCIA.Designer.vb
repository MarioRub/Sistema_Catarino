<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGREGAR_REFERENCIA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AGREGAR_REFERENCIA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTCOD_MUNI = New System.Windows.Forms.TextBox()
        Me.TXTCOD_DEPA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTDIRECCION = New System.Windows.Forms.TextBox()
        Me.CMBMUNICIPIO = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCENTRO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMBDEPARTAMENTO = New System.Windows.Forms.ComboBox()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGVREFERENCIA = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVREFERENCIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTCOD_MUNI)
        Me.GroupBox1.Controls.Add(Me.TXTCOD_DEPA)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTDIRECCION)
        Me.GroupBox1.Controls.Add(Me.CMBMUNICIPIO)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXTCENTRO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CMBDEPARTAMENTO)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(152, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 182)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AGREGAR DATOS DEL CENTRO"
        '
        'TXTCOD_MUNI
        '
        Me.TXTCOD_MUNI.Enabled = False
        Me.TXTCOD_MUNI.Location = New System.Drawing.Point(151, 107)
        Me.TXTCOD_MUNI.Name = "TXTCOD_MUNI"
        Me.TXTCOD_MUNI.Size = New System.Drawing.Size(33, 20)
        Me.TXTCOD_MUNI.TabIndex = 68
        '
        'TXTCOD_DEPA
        '
        Me.TXTCOD_DEPA.Enabled = False
        Me.TXTCOD_DEPA.Location = New System.Drawing.Point(151, 68)
        Me.TXTCOD_DEPA.Name = "TXTCOD_DEPA"
        Me.TXTCOD_DEPA.Size = New System.Drawing.Size(33, 20)
        Me.TXTCOD_DEPA.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "DIRECCION"
        '
        'TXTDIRECCION
        '
        Me.TXTDIRECCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDIRECCION.Location = New System.Drawing.Point(152, 149)
        Me.TXTDIRECCION.Multiline = True
        Me.TXTDIRECCION.Name = "TXTDIRECCION"
        Me.TXTDIRECCION.Size = New System.Drawing.Size(395, 20)
        Me.TXTDIRECCION.TabIndex = 65
        '
        'CMBMUNICIPIO
        '
        Me.CMBMUNICIPIO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBMUNICIPIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBMUNICIPIO.FormattingEnabled = True
        Me.CMBMUNICIPIO.Location = New System.Drawing.Point(190, 107)
        Me.CMBMUNICIPIO.Name = "CMBMUNICIPIO"
        Me.CMBMUNICIPIO.Size = New System.Drawing.Size(357, 21)
        Me.CMBMUNICIPIO.TabIndex = 64
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "CENTRO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "MUNICIPIO"
        '
        'TXTCENTRO
        '
        Me.TXTCENTRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCENTRO.Location = New System.Drawing.Point(151, 30)
        Me.TXTCENTRO.Name = "TXTCENTRO"
        Me.TXTCENTRO.Size = New System.Drawing.Size(396, 20)
        Me.TXTCENTRO.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "DEPARTAMENTO"
        '
        'CMBDEPARTAMENTO
        '
        Me.CMBDEPARTAMENTO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBDEPARTAMENTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBDEPARTAMENTO.FormattingEnabled = True
        Me.CMBDEPARTAMENTO.Location = New System.Drawing.Point(190, 67)
        Me.CMBDEPARTAMENTO.Name = "CMBDEPARTAMENTO"
        Me.CMBDEPARTAMENTO.Size = New System.Drawing.Size(357, 21)
        Me.CMBDEPARTAMENTO.TabIndex = 3
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(806, 244)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(95, 89)
        Me.BTNSALIR.TabIndex = 62
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackColor = System.Drawing.Color.Silver
        Me.BTNACEPTAR.BackgroundImage = CType(resources.GetObject("BTNACEPTAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACEPTAR.Location = New System.Drawing.Point(807, 155)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(95, 89)
        Me.BTNACEPTAR.TabIndex = 61
        Me.BTNACEPTAR.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(351, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 29)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "CENTRO QUE REFIERE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 25)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "SAN PEDRO SULA, CORTES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(524, 25)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "HOSPITAL NACIONAL DR. MARIO CATARINO RIVAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(341, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 25)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "SECRETARIA DE SALUD PUBLICA"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(821, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(83, 100)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 65
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(208, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'DGVREFERENCIA
        '
        Me.DGVREFERENCIA.AllowUserToAddRows = False
        Me.DGVREFERENCIA.AllowUserToResizeColumns = False
        Me.DGVREFERENCIA.AllowUserToResizeRows = False
        Me.DGVREFERENCIA.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVREFERENCIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVREFERENCIA.ColumnHeadersHeight = 30
        Me.DGVREFERENCIA.Location = New System.Drawing.Point(11, 340)
        Me.DGVREFERENCIA.Name = "DGVREFERENCIA"
        Me.DGVREFERENCIA.ReadOnly = True
        Me.DGVREFERENCIA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVREFERENCIA.Size = New System.Drawing.Size(890, 221)
        Me.DGVREFERENCIA.TabIndex = 80
        '
        'AGREGAR_REFERENCIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(914, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVREFERENCIA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AGREGAR_REFERENCIA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR REFERENCIA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVREFERENCIA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CMBMUNICIPIO As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTCENTRO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CMBDEPARTAMENTO As System.Windows.Forms.ComboBox
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTDIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents DGVREFERENCIA As System.Windows.Forms.DataGridView
    Friend WithEvents TXTCOD_MUNI As System.Windows.Forms.TextBox
    Friend WithEvents TXTCOD_DEPA As System.Windows.Forms.TextBox
End Class
