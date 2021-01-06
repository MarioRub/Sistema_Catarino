<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVO_USUARIO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NUEVO_USUARIO))
        Me.TXTUSUARIO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTCLAVE = New System.Windows.Forms.TextBox()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTESTATUS = New System.Windows.Forms.TextBox()
        Me.CBINACTIVO = New System.Windows.Forms.CheckBox()
        Me.CBACTIVO = New System.Windows.Forms.CheckBox()
        Me.BTNDEPA = New System.Windows.Forms.Button()
        Me.TXTDEPA = New System.Windows.Forms.TextBox()
        Me.BTNIDENTIDAD = New System.Windows.Forms.Button()
        Me.CMBNACIONALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTIDENTIDAD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MS = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTUSUARIO
        '
        Me.TXTUSUARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTUSUARIO.Enabled = False
        Me.TXTUSUARIO.Location = New System.Drawing.Point(152, 94)
        Me.TXTUSUARIO.Name = "TXTUSUARIO"
        Me.TXTUSUARIO.Size = New System.Drawing.Size(326, 20)
        Me.TXTUSUARIO.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CLAVE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "USUARIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "SECRETARIA DE SALUD PUBLICA"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(799, 8)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(83, 88)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(187, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 231)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(225, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(524, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "HOSPITAL NACIONAL DR. MARIO CATARINO RIVAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(336, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "SAN PEDRO SULA, CORTES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(415, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 29)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "USUARIO"
        '
        'TXTCLAVE
        '
        Me.TXTCLAVE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCLAVE.Enabled = False
        Me.TXTCLAVE.Location = New System.Drawing.Point(152, 129)
        Me.TXTCLAVE.Name = "TXTCLAVE"
        Me.TXTCLAVE.Size = New System.Drawing.Size(326, 20)
        Me.TXTCLAVE.TabIndex = 5
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackColor = System.Drawing.Color.Silver
        Me.BTNACEPTAR.BackgroundImage = CType(resources.GetObject("BTNACEPTAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACEPTAR.Enabled = False
        Me.BTNACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACEPTAR.Location = New System.Drawing.Point(475, 403)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(95, 89)
        Me.BTNACEPTAR.TabIndex = 3
        Me.BTNACEPTAR.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(677, 403)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(95, 89)
        Me.BTNSALIR.TabIndex = 4
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 16)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "DEPARTAMENTO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TXTESTATUS)
        Me.GroupBox1.Controls.Add(Me.CBINACTIVO)
        Me.GroupBox1.Controls.Add(Me.CBACTIVO)
        Me.GroupBox1.Controls.Add(Me.BTNDEPA)
        Me.GroupBox1.Controls.Add(Me.TXTDEPA)
        Me.GroupBox1.Controls.Add(Me.BTNIDENTIDAD)
        Me.GroupBox1.Controls.Add(Me.CMBNACIONALIDAD)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TXTIDENTIDAD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTUSUARIO)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXTCLAVE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(249, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 257)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NUEVO USUARIO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "ESTATUS"
        '
        'TXTESTATUS
        '
        Me.TXTESTATUS.BackColor = System.Drawing.Color.White
        Me.TXTESTATUS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTESTATUS.Enabled = False
        Me.TXTESTATUS.Location = New System.Drawing.Point(152, 197)
        Me.TXTESTATUS.Name = "TXTESTATUS"
        Me.TXTESTATUS.ReadOnly = True
        Me.TXTESTATUS.Size = New System.Drawing.Size(327, 20)
        Me.TXTESTATUS.TabIndex = 8
        '
        'CBINACTIVO
        '
        Me.CBINACTIVO.AutoSize = True
        Me.CBINACTIVO.Enabled = False
        Me.CBINACTIVO.Location = New System.Drawing.Point(272, 167)
        Me.CBINACTIVO.Name = "CBINACTIVO"
        Me.CBINACTIVO.Size = New System.Drawing.Size(84, 17)
        Me.CBINACTIVO.TabIndex = 7
        Me.CBINACTIVO.Text = "INACTIVO"
        Me.CBINACTIVO.UseVisualStyleBackColor = True
        '
        'CBACTIVO
        '
        Me.CBACTIVO.AutoSize = True
        Me.CBACTIVO.Enabled = False
        Me.CBACTIVO.Location = New System.Drawing.Point(153, 167)
        Me.CBACTIVO.Name = "CBACTIVO"
        Me.CBACTIVO.Size = New System.Drawing.Size(71, 17)
        Me.CBACTIVO.TabIndex = 6
        Me.CBACTIVO.Text = "ACTIVO"
        Me.CBACTIVO.UseVisualStyleBackColor = True
        '
        'BTNDEPA
        '
        Me.BTNDEPA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTNDEPA.BackgroundImage = CType(resources.GetObject("BTNDEPA.BackgroundImage"), System.Drawing.Image)
        Me.BTNDEPA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNDEPA.FlatAppearance.BorderSize = 50
        Me.BTNDEPA.Location = New System.Drawing.Point(482, 226)
        Me.BTNDEPA.Name = "BTNDEPA"
        Me.BTNDEPA.Size = New System.Drawing.Size(25, 21)
        Me.BTNDEPA.TabIndex = 20
        Me.BTNDEPA.UseVisualStyleBackColor = False
        Me.BTNDEPA.Visible = False
        '
        'TXTDEPA
        '
        Me.TXTDEPA.BackColor = System.Drawing.Color.White
        Me.TXTDEPA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDEPA.Enabled = False
        Me.TXTDEPA.Location = New System.Drawing.Point(152, 227)
        Me.TXTDEPA.Name = "TXTDEPA"
        Me.TXTDEPA.ReadOnly = True
        Me.TXTDEPA.Size = New System.Drawing.Size(326, 20)
        Me.TXTDEPA.TabIndex = 9
        '
        'BTNIDENTIDAD
        '
        Me.BTNIDENTIDAD.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNIDENTIDAD.BackgroundImage = CType(resources.GetObject("BTNIDENTIDAD.BackgroundImage"), System.Drawing.Image)
        Me.BTNIDENTIDAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIDENTIDAD.FlatAppearance.BorderSize = 50
        Me.BTNIDENTIDAD.Location = New System.Drawing.Point(482, 57)
        Me.BTNIDENTIDAD.Name = "BTNIDENTIDAD"
        Me.BTNIDENTIDAD.Size = New System.Drawing.Size(35, 31)
        Me.BTNIDENTIDAD.TabIndex = 3
        Me.MS.SetToolTip(Me.BTNIDENTIDAD, "VERIFICAR EL USUARIO")
        Me.BTNIDENTIDAD.UseVisualStyleBackColor = False
        Me.BTNIDENTIDAD.Visible = False
        '
        'CMBNACIONALIDAD
        '
        Me.CMBNACIONALIDAD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBNACIONALIDAD.FormattingEnabled = True
        Me.CMBNACIONALIDAD.Location = New System.Drawing.Point(152, 25)
        Me.CMBNACIONALIDAD.Name = "CMBNACIONALIDAD"
        Me.CMBNACIONALIDAD.Size = New System.Drawing.Size(327, 21)
        Me.CMBNACIONALIDAD.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "NACIONALIDAD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "IDENTIDAD"
        '
        'TXTIDENTIDAD
        '
        Me.TXTIDENTIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIDENTIDAD.Enabled = False
        Me.TXTIDENTIDAD.Location = New System.Drawing.Point(153, 58)
        Me.TXTIDENTIDAD.Name = "TXTIDENTIDAD"
        Me.TXTIDENTIDAD.Size = New System.Drawing.Size(326, 20)
        Me.TXTIDENTIDAD.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ESTADO"
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.BackColor = System.Drawing.Color.Silver
        Me.BTNMODIFICAR.BackgroundImage = CType(resources.GetObject("BTNMODIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNMODIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNMODIFICAR.Enabled = False
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(249, 403)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(94, 89)
        Me.BTNMODIFICAR.TabIndex = 2
        Me.BTNMODIFICAR.UseVisualStyleBackColor = False
        '
        'NUEVO_USUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(892, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNMODIFICAR)
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
        Me.MaximizeBox = False
        Me.Name = "NUEVO_USUARIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTUSUARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTCLAVE As System.Windows.Forms.TextBox
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CMBNACIONALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTIDENTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents BTNIDENTIDAD As System.Windows.Forms.Button
    Friend WithEvents BTNDEPA As System.Windows.Forms.Button
    Friend WithEvents TXTDEPA As System.Windows.Forms.TextBox
    Friend WithEvents MS As System.Windows.Forms.ToolTip
    Friend WithEvents CBINACTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents CBACTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTESTATUS As System.Windows.Forms.TextBox
End Class
