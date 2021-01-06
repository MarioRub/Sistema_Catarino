<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBHORARIO = New System.Windows.Forms.Label()
        Me.LBFECHA = New System.Windows.Forms.Label()
        Me.TXTCLAVE = New System.Windows.Forms.TextBox()
        Me.CMBTURNO = New System.Windows.Forms.ComboBox()
        Me.TXTCOMENTARIO = New System.Windows.Forms.TextBox()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTESTADO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTDEPARTAMENTO = New System.Windows.Forms.TextBox()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.TXTUSUARIO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CMBNACIONALIDAD = New System.Windows.Forms.ComboBox()
        Me.TXTIDENTIDAD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTESTATUS = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Location = New System.Drawing.Point(269, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ACCESO AL SISTEMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "USUARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CLAVE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TURNO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "COMENTARIO"
        '
        'LBHORARIO
        '
        Me.LBHORARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBHORARIO.Location = New System.Drawing.Point(16, 422)
        Me.LBHORARIO.Name = "LBHORARIO"
        Me.LBHORARIO.Size = New System.Drawing.Size(253, 31)
        Me.LBHORARIO.TabIndex = 9
        Me.LBHORARIO.Text = "12:22 PM"
        Me.LBHORARIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBFECHA
        '
        Me.LBFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFECHA.Location = New System.Drawing.Point(20, 453)
        Me.LBFECHA.Name = "LBFECHA"
        Me.LBFECHA.Size = New System.Drawing.Size(249, 31)
        Me.LBFECHA.TabIndex = 10
        Me.LBFECHA.Text = "20/01/2019"
        Me.LBFECHA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTCLAVE
        '
        Me.TXTCLAVE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCLAVE.Location = New System.Drawing.Point(147, 147)
        Me.TXTCLAVE.Name = "TXTCLAVE"
        Me.TXTCLAVE.Size = New System.Drawing.Size(326, 20)
        Me.TXTCLAVE.TabIndex = 6
        Me.TXTCLAVE.UseSystemPasswordChar = True
        '
        'CMBTURNO
        '
        Me.CMBTURNO.FormattingEnabled = True
        Me.CMBTURNO.Location = New System.Drawing.Point(147, 173)
        Me.CMBTURNO.Name = "CMBTURNO"
        Me.CMBTURNO.Size = New System.Drawing.Size(327, 21)
        Me.CMBTURNO.TabIndex = 7
        '
        'TXTCOMENTARIO
        '
        Me.TXTCOMENTARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCOMENTARIO.Location = New System.Drawing.Point(148, 227)
        Me.TXTCOMENTARIO.Multiline = True
        Me.TXTCOMENTARIO.Name = "TXTCOMENTARIO"
        Me.TXTCOMENTARIO.Size = New System.Drawing.Size(326, 44)
        Me.TXTCOMENTARIO.TabIndex = 9
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackColor = System.Drawing.Color.Silver
        Me.BTNACEPTAR.BackgroundImage = CType(resources.GetObject("BTNACEPTAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACEPTAR.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTNACEPTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTNACEPTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BTNACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACEPTAR.Location = New System.Drawing.Point(451, 404)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(95, 105)
        Me.BTNACEPTAR.TabIndex = 10
        Me.BTNACEPTAR.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(552, 404)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(95, 105)
        Me.BTNSALIR.TabIndex = 11
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ESTADO"
        '
        'TXTESTADO
        '
        Me.TXTESTADO.BackColor = System.Drawing.Color.White
        Me.TXTESTADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTESTADO.Location = New System.Drawing.Point(147, 120)
        Me.TXTESTADO.Name = "TXTESTADO"
        Me.TXTESTADO.ReadOnly = True
        Me.TXTESTADO.Size = New System.Drawing.Size(326, 20)
        Me.TXTESTADO.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "DEPARTAMENTO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTDEPARTAMENTO)
        Me.GroupBox1.Controls.Add(Me.BTNBUSCAR)
        Me.GroupBox1.Controls.Add(Me.TXTUSUARIO)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CMBNACIONALIDAD)
        Me.GroupBox1.Controls.Add(Me.TXTIDENTIDAD)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTESTADO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXTCLAVE)
        Me.GroupBox1.Controls.Add(Me.CMBTURNO)
        Me.GroupBox1.Controls.Add(Me.TXTCOMENTARIO)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(171, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 287)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INICIAR SESION"
        '
        'TXTDEPARTAMENTO
        '
        Me.TXTDEPARTAMENTO.BackColor = System.Drawing.Color.White
        Me.TXTDEPARTAMENTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDEPARTAMENTO.Location = New System.Drawing.Point(147, 200)
        Me.TXTDEPARTAMENTO.Name = "TXTDEPARTAMENTO"
        Me.TXTDEPARTAMENTO.ReadOnly = True
        Me.TXTDEPARTAMENTO.Size = New System.Drawing.Size(326, 20)
        Me.TXTDEPARTAMENTO.TabIndex = 8
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTNBUSCAR.FlatAppearance.BorderSize = 50
        Me.BTNBUSCAR.Location = New System.Drawing.Point(474, 81)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(31, 30)
        Me.BTNBUSCAR.TabIndex = 4
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'TXTUSUARIO
        '
        Me.TXTUSUARIO.BackColor = System.Drawing.Color.White
        Me.TXTUSUARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTUSUARIO.Location = New System.Drawing.Point(146, 61)
        Me.TXTUSUARIO.Name = "TXTUSUARIO"
        Me.TXTUSUARIO.ReadOnly = True
        Me.TXTUSUARIO.Size = New System.Drawing.Size(326, 20)
        Me.TXTUSUARIO.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "NACIONALIDAD"
        '
        'CMBNACIONALIDAD
        '
        Me.CMBNACIONALIDAD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBNACIONALIDAD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBNACIONALIDAD.FormattingEnabled = True
        Me.CMBNACIONALIDAD.Location = New System.Drawing.Point(146, 33)
        Me.CMBNACIONALIDAD.Name = "CMBNACIONALIDAD"
        Me.CMBNACIONALIDAD.Size = New System.Drawing.Size(327, 21)
        Me.CMBNACIONALIDAD.TabIndex = 1
        '
        'TXTIDENTIDAD
        '
        Me.TXTIDENTIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIDENTIDAD.Location = New System.Drawing.Point(147, 91)
        Me.TXTIDENTIDAD.Name = "TXTIDENTIDAD"
        Me.TXTIDENTIDAD.Size = New System.Drawing.Size(326, 20)
        Me.TXTIDENTIDAD.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "IDENTIDAD"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label10.Location = New System.Drawing.Point(324, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(218, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "SECRETARIA DE SALUD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label11.Location = New System.Drawing.Point(225, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(444, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "HOSPITAL NACIONAL DR. MARIO CATARINO RIVAS"
        '
        'TXTESTATUS
        '
        Me.TXTESTATUS.BackColor = System.Drawing.Color.White
        Me.TXTESTATUS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTESTATUS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTESTATUS.Location = New System.Drawing.Point(694, 289)
        Me.TXTESTATUS.Name = "TXTESTATUS"
        Me.TXTESTATUS.ReadOnly = True
        Me.TXTESTATUS.Size = New System.Drawing.Size(80, 20)
        Me.TXTESTATUS.TabIndex = 20
        Me.TXTESTATUS.Visible = False
        '
        'Timer1
        '
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(706, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 94)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 100)
        Me.Panel1.TabIndex = 24
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(808, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.TXTESTATUS)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.LBFECHA)
        Me.Controls.Add(Me.LBHORARIO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBHORARIO As System.Windows.Forms.Label
    Friend WithEvents LBFECHA As System.Windows.Forms.Label
    Friend WithEvents TXTCLAVE As System.Windows.Forms.TextBox
    Friend WithEvents CMBTURNO As System.Windows.Forms.ComboBox
    Friend WithEvents TXTCOMENTARIO As System.Windows.Forms.TextBox
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTESTADO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTIDENTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CMBNACIONALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents TXTUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents TXTDEPARTAMENTO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTESTATUS As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
