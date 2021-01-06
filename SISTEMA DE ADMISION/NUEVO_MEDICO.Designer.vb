<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NUEVO_MEDICO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NUEVO_MEDICO))
        Me.CMBESPECIALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.TXTIDENTIDAD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTMEDICO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXTHORARIO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBJUEVES = New System.Windows.Forms.CheckBox()
        Me.CBMIERCOLES = New System.Windows.Forms.CheckBox()
        Me.CBMARTES = New System.Windows.Forms.CheckBox()
        Me.CBLUNES = New System.Windows.Forms.CheckBox()
        Me.CBVIERNES = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.CBACTIVO = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBINACTIVO = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMBESPECIALIDAD
        '
        Me.CMBESPECIALIDAD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBESPECIALIDAD.FormattingEnabled = True
        Me.CMBESPECIALIDAD.Location = New System.Drawing.Point(442, 288)
        Me.CMBESPECIALIDAD.Name = "CMBESPECIALIDAD"
        Me.CMBESPECIALIDAD.Size = New System.Drawing.Size(327, 21)
        Me.CMBESPECIALIDAD.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "ESPECIALIDAD"
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(591, 534)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(95, 89)
        Me.BTNSALIR.TabIndex = 29
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackgroundImage = CType(resources.GetObject("BTNACEPTAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACEPTAR.Location = New System.Drawing.Point(264, 534)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(95, 89)
        Me.BTNACEPTAR.TabIndex = 28
        Me.BTNACEPTAR.UseVisualStyleBackColor = True
        '
        'TXTIDENTIDAD
        '
        Me.TXTIDENTIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIDENTIDAD.Location = New System.Drawing.Point(442, 253)
        Me.TXTIDENTIDAD.Name = "TXTIDENTIDAD"
        Me.TXTIDENTIDAD.Size = New System.Drawing.Size(326, 20)
        Me.TXTIDENTIDAD.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(303, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 29)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "NUEVO MEDICO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 25)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "SAN PEDRO SULA, CORTES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(163, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(524, 25)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "HOSPITAL NACIONAL DR. MARIO CATARINO RIVAS"
        '
        'TXTMEDICO
        '
        Me.TXTMEDICO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMEDICO.Location = New System.Drawing.Point(442, 218)
        Me.TXTMEDICO.Name = "TXTMEDICO"
        Me.TXTMEDICO.Size = New System.Drawing.Size(326, 20)
        Me.TXTMEDICO.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(261, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "IDENTIDAD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "SECRETARIA DE SALUD PUBLICA"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(698, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 53)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(381, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(118, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(187, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 218)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 231)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'TXTHORARIO
        '
        Me.TXTHORARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTHORARIO.Location = New System.Drawing.Point(443, 362)
        Me.TXTHORARIO.Name = "TXTHORARIO"
        Me.TXTHORARIO.Size = New System.Drawing.Size(326, 20)
        Me.TXTHORARIO.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(262, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "HORARIO DE ATENCION"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(262, 399)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "DIAS DE ATENCION"
        '
        'CBJUEVES
        '
        Me.CBJUEVES.AutoSize = True
        Me.CBJUEVES.Location = New System.Drawing.Point(682, 398)
        Me.CBJUEVES.Name = "CBJUEVES"
        Me.CBJUEVES.Size = New System.Drawing.Size(67, 17)
        Me.CBJUEVES.TabIndex = 49
        Me.CBJUEVES.Text = "JUEVES"
        Me.CBJUEVES.UseVisualStyleBackColor = True
        '
        'CBMIERCOLES
        '
        Me.CBMIERCOLES.AutoSize = True
        Me.CBMIERCOLES.Location = New System.Drawing.Point(588, 398)
        Me.CBMIERCOLES.Name = "CBMIERCOLES"
        Me.CBMIERCOLES.Size = New System.Drawing.Size(88, 17)
        Me.CBMIERCOLES.TabIndex = 48
        Me.CBMIERCOLES.Text = "MIERCOLES"
        Me.CBMIERCOLES.UseVisualStyleBackColor = True
        '
        'CBMARTES
        '
        Me.CBMARTES.AutoSize = True
        Me.CBMARTES.Location = New System.Drawing.Point(511, 398)
        Me.CBMARTES.Name = "CBMARTES"
        Me.CBMARTES.Size = New System.Drawing.Size(71, 17)
        Me.CBMARTES.TabIndex = 47
        Me.CBMARTES.Text = "MARTES"
        Me.CBMARTES.UseVisualStyleBackColor = True
        '
        'CBLUNES
        '
        Me.CBLUNES.AutoSize = True
        Me.CBLUNES.Location = New System.Drawing.Point(443, 398)
        Me.CBLUNES.Name = "CBLUNES"
        Me.CBLUNES.Size = New System.Drawing.Size(62, 17)
        Me.CBLUNES.TabIndex = 46
        Me.CBLUNES.Text = "LUNES"
        Me.CBLUNES.UseVisualStyleBackColor = True
        '
        'CBVIERNES
        '
        Me.CBVIERNES.AutoSize = True
        Me.CBVIERNES.Location = New System.Drawing.Point(443, 421)
        Me.CBVIERNES.Name = "CBVIERNES"
        Me.CBVIERNES.Size = New System.Drawing.Size(73, 17)
        Me.CBVIERNES.TabIndex = 50
        Me.CBVIERNES.Text = "VIERNES"
        Me.CBVIERNES.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(443, 322)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(327, 21)
        Me.ComboBox1.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(262, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 16)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "NO. CONSULTORIO"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(443, 452)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 50)
        Me.TextBox1.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(262, 456)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 16)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "COMENTARIO"
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.BackgroundImage = CType(resources.GetObject("BTNMODIFICAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNMODIFICAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(365, 534)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(95, 89)
        Me.BTNMODIFICAR.TabIndex = 55
        Me.BTNMODIFICAR.UseVisualStyleBackColor = True
        '
        'CBACTIVO
        '
        Me.CBACTIVO.AutoSize = True
        Me.CBACTIVO.Location = New System.Drawing.Point(17, 39)
        Me.CBACTIVO.Name = "CBACTIVO"
        Me.CBACTIVO.Size = New System.Drawing.Size(65, 17)
        Me.CBACTIVO.TabIndex = 56
        Me.CBACTIVO.Text = "ACTIVO"
        Me.CBACTIVO.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBINACTIVO)
        Me.GroupBox1.Controls.Add(Me.CBACTIVO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 477)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ESTADO DEL MEDICO"
        '
        'CBINACTIVO
        '
        Me.CBINACTIVO.AutoSize = True
        Me.CBINACTIVO.Location = New System.Drawing.Point(100, 39)
        Me.CBINACTIVO.Name = "CBINACTIVO"
        Me.CBINACTIVO.Size = New System.Drawing.Size(76, 17)
        Me.CBINACTIVO.TabIndex = 57
        Me.CBINACTIVO.Text = "INACTIVO"
        Me.CBINACTIVO.UseVisualStyleBackColor = True
        '
        'NUEVO_MEDICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(787, 622)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNMODIFICAR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CBVIERNES)
        Me.Controls.Add(Me.CBJUEVES)
        Me.Controls.Add(Me.CBMIERCOLES)
        Me.Controls.Add(Me.CBMARTES)
        Me.Controls.Add(Me.CBLUNES)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTHORARIO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CMBESPECIALIDAD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.TXTIDENTIDAD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTMEDICO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "NUEVO_MEDICO"
        Me.Text = "NUEVO_MEDICO"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMBESPECIALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents TXTIDENTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTMEDICO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TXTHORARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBJUEVES As System.Windows.Forms.CheckBox
    Friend WithEvents CBMIERCOLES As System.Windows.Forms.CheckBox
    Friend WithEvents CBMARTES As System.Windows.Forms.CheckBox
    Friend WithEvents CBLUNES As System.Windows.Forms.CheckBox
    Friend WithEvents CBVIERNES As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents CBACTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBINACTIVO As System.Windows.Forms.CheckBox
End Class
