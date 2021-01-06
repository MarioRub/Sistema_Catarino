<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VACA_MEDICO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VACA_MEDICO))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TXTCOD_ESPECIALIDAD = New System.Windows.Forms.TextBox()
        Me.CMBMEDICO = New System.Windows.Forms.ComboBox()
        Me.CMBESPECIALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.V_INICIAL = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.V_FINAL = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTNORMAL = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTPROF = New System.Windows.Forms.TextBox()
        Me.F_INICIAL = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.F_FINAL = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNMODIFICA = New System.Windows.Forms.Button()
        Me.BTNGUARDA = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TXTCLINICA = New System.Windows.Forms.TextBox()
        Me.CBNORMAL = New System.Windows.Forms.CheckBox()
        Me.CBPROF = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(497, 25)
        Me.Label3.TabIndex = 185
        Me.Label3.Text = "VACACIONES DE MEDICO CONSULTA EXTERNA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 25)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "SECRETARIA DE SALUD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 25)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "HOSPITAL NACIONAL DR. MARIO CATARINO RIVAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 182
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(905, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 91)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 186
        Me.PictureBox4.TabStop = False
        '
        'TXTCOD_ESPECIALIDAD
        '
        Me.TXTCOD_ESPECIALIDAD.Enabled = False
        Me.TXTCOD_ESPECIALIDAD.Location = New System.Drawing.Point(12, 157)
        Me.TXTCOD_ESPECIALIDAD.Name = "TXTCOD_ESPECIALIDAD"
        Me.TXTCOD_ESPECIALIDAD.Size = New System.Drawing.Size(43, 20)
        Me.TXTCOD_ESPECIALIDAD.TabIndex = 189
        Me.TXTCOD_ESPECIALIDAD.Visible = False
        '
        'CMBMEDICO
        '
        Me.CMBMEDICO.Enabled = False
        Me.CMBMEDICO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEDICO.FormattingEnabled = True
        Me.CMBMEDICO.Location = New System.Drawing.Point(325, 138)
        Me.CMBMEDICO.Name = "CMBMEDICO"
        Me.CMBMEDICO.Size = New System.Drawing.Size(289, 21)
        Me.CMBMEDICO.TabIndex = 2
        '
        'CMBESPECIALIDAD
        '
        Me.CMBESPECIALIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBESPECIALIDAD.FormattingEnabled = True
        Me.CMBESPECIALIDAD.Location = New System.Drawing.Point(12, 138)
        Me.CMBESPECIALIDAD.Name = "CMBESPECIALIDAD"
        Me.CMBESPECIALIDAD.Size = New System.Drawing.Size(304, 21)
        Me.CMBESPECIALIDAD.TabIndex = 1
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(12, 120)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(92, 15)
        Me.Label38.TabIndex = 190
        Me.Label38.Text = "ESPECIALIDAD"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(325, 120)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(139, 15)
        Me.Label40.TabIndex = 191
        Me.Label40.Text = "NOMBRE DEL MEDICO"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(48, 55)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(89, 15)
        Me.Label36.TabIndex = 193
        Me.Label36.Text = "FECHA INICIAL"
        '
        'V_INICIAL
        '
        Me.V_INICIAL.CustomFormat = "dd/MMM/yyyy"
        Me.V_INICIAL.Enabled = False
        Me.V_INICIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_INICIAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.V_INICIAL.Location = New System.Drawing.Point(18, 30)
        Me.V_INICIAL.Name = "V_INICIAL"
        Me.V_INICIAL.Size = New System.Drawing.Size(145, 22)
        Me.V_INICIAL.TabIndex = 1
        Me.V_INICIAL.Value = New Date(2019, 6, 18, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(755, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 15)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "TIPO VACACIONES"
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.Silver
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNBUSCAR.Location = New System.Drawing.Point(913, 110)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(73, 78)
        Me.BTNBUSCAR.TabIndex = 4
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "FECHA FINAL"
        '
        'V_FINAL
        '
        Me.V_FINAL.CustomFormat = "dd/MMM/yyyy"
        Me.V_FINAL.Enabled = False
        Me.V_FINAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_FINAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.V_FINAL.Location = New System.Drawing.Point(201, 30)
        Me.V_FINAL.Name = "V_FINAL"
        Me.V_FINAL.Size = New System.Drawing.Size(145, 22)
        Me.V_FINAL.TabIndex = 2
        Me.V_FINAL.Value = New Date(2019, 6, 18, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 15)
        Me.Label10.TabIndex = 200
        Me.Label10.Text = "QUIEN LO REPORTO"
        '
        'TXTNORMAL
        '
        Me.TXTNORMAL.Enabled = False
        Me.TXTNORMAL.Location = New System.Drawing.Point(147, 95)
        Me.TXTNORMAL.Name = "TXTNORMAL"
        Me.TXTNORMAL.Size = New System.Drawing.Size(211, 20)
        Me.TXTNORMAL.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.V_INICIAL)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXTNORMAL)
        Me.GroupBox1.Controls.Add(Me.V_FINAL)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 128)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VACACIONES NORMALES"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TXTPROF)
        Me.GroupBox2.Controls.Add(Me.F_INICIAL)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.F_FINAL)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(591, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 128)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VACACIONES PROFILACTICAS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 15)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "QUIEN LO REPORTO"
        '
        'TXTPROF
        '
        Me.TXTPROF.Enabled = False
        Me.TXTPROF.Location = New System.Drawing.Point(147, 94)
        Me.TXTPROF.Name = "TXTPROF"
        Me.TXTPROF.Size = New System.Drawing.Size(211, 20)
        Me.TXTPROF.TabIndex = 3
        '
        'F_INICIAL
        '
        Me.F_INICIAL.CustomFormat = "dd/MMM/yyyy"
        Me.F_INICIAL.Enabled = False
        Me.F_INICIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_INICIAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.F_INICIAL.Location = New System.Drawing.Point(18, 30)
        Me.F_INICIAL.Name = "F_INICIAL"
        Me.F_INICIAL.Size = New System.Drawing.Size(145, 22)
        Me.F_INICIAL.TabIndex = 1
        Me.F_INICIAL.Value = New Date(2019, 6, 18, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "FECHA INICIAL"
        '
        'F_FINAL
        '
        Me.F_FINAL.CustomFormat = "dd/MMM/yyyy"
        Me.F_FINAL.Enabled = False
        Me.F_FINAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_FINAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.F_FINAL.Location = New System.Drawing.Point(201, 30)
        Me.F_FINAL.Name = "F_FINAL"
        Me.F_FINAL.Size = New System.Drawing.Size(145, 22)
        Me.F_FINAL.TabIndex = 2
        Me.F_FINAL.Value = New Date(2019, 6, 18, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(231, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "FECHA FINAL"
        '
        'BTNMODIFICA
        '
        Me.BTNMODIFICA.BackColor = System.Drawing.Color.Silver
        Me.BTNMODIFICA.BackgroundImage = CType(resources.GetObject("BTNMODIFICA.BackgroundImage"), System.Drawing.Image)
        Me.BTNMODIFICA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNMODIFICA.Enabled = False
        Me.BTNMODIFICA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICA.Location = New System.Drawing.Point(120, 378)
        Me.BTNMODIFICA.Name = "BTNMODIFICA"
        Me.BTNMODIFICA.Size = New System.Drawing.Size(101, 111)
        Me.BTNMODIFICA.TabIndex = 7
        Me.BTNMODIFICA.UseVisualStyleBackColor = False
        '
        'BTNGUARDA
        '
        Me.BTNGUARDA.BackColor = System.Drawing.Color.Silver
        Me.BTNGUARDA.BackgroundImage = CType(resources.GetObject("BTNGUARDA.BackgroundImage"), System.Drawing.Image)
        Me.BTNGUARDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNGUARDA.Enabled = False
        Me.BTNGUARDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDA.Location = New System.Drawing.Point(403, 376)
        Me.BTNGUARDA.Name = "BTNGUARDA"
        Me.BTNGUARDA.Size = New System.Drawing.Size(101, 111)
        Me.BTNGUARDA.TabIndex = 8
        Me.BTNGUARDA.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(673, 376)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(101, 109)
        Me.BTNSALIR.TabIndex = 9
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(631, 121)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(62, 15)
        Me.Label39.TabIndex = 197
        Me.Label39.Text = "# CLINICA"
        '
        'TXTCLINICA
        '
        Me.TXTCLINICA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCLINICA.Location = New System.Drawing.Point(621, 139)
        Me.TXTCLINICA.Multiline = True
        Me.TXTCLINICA.Name = "TXTCLINICA"
        Me.TXTCLINICA.ReadOnly = True
        Me.TXTCLINICA.Size = New System.Drawing.Size(91, 22)
        Me.TXTCLINICA.TabIndex = 196
        Me.TXTCLINICA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBNORMAL
        '
        Me.CBNORMAL.AutoSize = True
        Me.CBNORMAL.Location = New System.Drawing.Point(728, 144)
        Me.CBNORMAL.Name = "CBNORMAL"
        Me.CBNORMAL.Size = New System.Drawing.Size(72, 17)
        Me.CBNORMAL.TabIndex = 198
        Me.CBNORMAL.Text = "NORMAL"
        Me.CBNORMAL.UseVisualStyleBackColor = True
        '
        'CBPROF
        '
        Me.CBPROF.AutoSize = True
        Me.CBPROF.Location = New System.Drawing.Point(806, 144)
        Me.CBPROF.Name = "CBPROF"
        Me.CBPROF.Size = New System.Drawing.Size(102, 17)
        Me.CBPROF.TabIndex = 199
        Me.CBPROF.Text = "PROFILACTICA"
        Me.CBPROF.UseVisualStyleBackColor = True
        '
        'VACA_MEDICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(989, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.CBPROF)
        Me.Controls.Add(Me.CBNORMAL)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.TXTCLINICA)
        Me.Controls.Add(Me.BTNMODIFICA)
        Me.Controls.Add(Me.BTNGUARDA)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.TXTCOD_ESPECIALIDAD)
        Me.Controls.Add(Me.CMBMEDICO)
        Me.Controls.Add(Me.CMBESPECIALIDAD)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VACA_MEDICO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VACACIONES MEDICA"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TXTCOD_ESPECIALIDAD As System.Windows.Forms.TextBox
    Friend WithEvents CMBMEDICO As System.Windows.Forms.ComboBox
    Friend WithEvents CMBESPECIALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents V_INICIAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents V_FINAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTNORMAL As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTPROF As System.Windows.Forms.TextBox
    Friend WithEvents F_INICIAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents F_FINAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTNMODIFICA As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDA As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TXTCLINICA As System.Windows.Forms.TextBox
    Friend WithEvents CBNORMAL As System.Windows.Forms.CheckBox
    Friend WithEvents CBPROF As System.Windows.Forms.CheckBox
End Class
