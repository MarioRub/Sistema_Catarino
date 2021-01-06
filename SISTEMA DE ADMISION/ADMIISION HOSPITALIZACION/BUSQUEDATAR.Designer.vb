<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BUSQUEDATAR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BUSQUEDATAR))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CBNO = New System.Windows.Forms.CheckBox()
        Me.CBSI = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CMBCLASIFICACION = New System.Windows.Forms.ComboBox()
        Me.CMBBUSQUEDA = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LBCORRELATIVO = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTCORRELATIVO = New System.Windows.Forms.TextBox()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.LBIDENTIDAD = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTIDENTIDAD = New System.Windows.Forms.TextBox()
        Me.DGVGENERAL = New System.Windows.Forms.DataGridView()
        Me.BTNCAEPTAR = New System.Windows.Forms.Button()
        Me.CMBNACIONALIDAD = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(347, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 15)
        Me.Label12.TabIndex = 200
        Me.Label12.Text = "CLASIFICACION"
        '
        'CBNO
        '
        Me.CBNO.AutoSize = True
        Me.CBNO.Location = New System.Drawing.Point(139, 19)
        Me.CBNO.Name = "CBNO"
        Me.CBNO.Size = New System.Drawing.Size(88, 17)
        Me.CBNO.TabIndex = 171
        Me.CBNO.Text = "ESPECIFICO"
        Me.CBNO.UseVisualStyleBackColor = True
        '
        'CBSI
        '
        Me.CBSI.AutoSize = True
        Me.CBSI.Location = New System.Drawing.Point(20, 19)
        Me.CBSI.Name = "CBSI"
        Me.CBSI.Size = New System.Drawing.Size(77, 17)
        Me.CBSI.TabIndex = 170
        Me.CBSI.Text = "GENERAL"
        Me.CBSI.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBNO)
        Me.GroupBox1.Controls.Add(Me.CBSI)
        Me.GroupBox1.Location = New System.Drawing.Point(350, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 44)
        Me.GroupBox1.TabIndex = 201
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BUSQUEDA"
        '
        'CMBCLASIFICACION
        '
        Me.CMBCLASIFICACION.Enabled = False
        Me.CMBCLASIFICACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCLASIFICACION.FormattingEnabled = True
        Me.CMBCLASIFICACION.Location = New System.Drawing.Point(447, 95)
        Me.CMBCLASIFICACION.Name = "CMBCLASIFICACION"
        Me.CMBCLASIFICACION.Size = New System.Drawing.Size(144, 21)
        Me.CMBCLASIFICACION.TabIndex = 199
        '
        'CMBBUSQUEDA
        '
        Me.CMBBUSQUEDA.Enabled = False
        Me.CMBBUSQUEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBBUSQUEDA.FormattingEnabled = True
        Me.CMBBUSQUEDA.Location = New System.Drawing.Point(130, 126)
        Me.CMBBUSQUEDA.Name = "CMBBUSQUEDA"
        Me.CMBBUSQUEDA.Size = New System.Drawing.Size(207, 21)
        Me.CMBBUSQUEDA.TabIndex = 197
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 15)
        Me.Label11.TabIndex = 198
        Me.Label11.Text = "TIPO BUSQUEDA"
        '
        'LBCORRELATIVO
        '
        Me.LBCORRELATIVO.Enabled = False
        Me.LBCORRELATIVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCORRELATIVO.Location = New System.Drawing.Point(1063, 117)
        Me.LBCORRELATIVO.Name = "LBCORRELATIVO"
        Me.LBCORRELATIVO.Size = New System.Drawing.Size(21, 18)
        Me.LBCORRELATIVO.TabIndex = 192
        Me.LBCORRELATIVO.Text = "0"
        Me.LBCORRELATIVO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(954, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 191
        Me.Label6.Text = "CORRELATIVO"
        '
        'TXTCORRELATIVO
        '
        Me.TXTCORRELATIVO.Enabled = False
        Me.TXTCORRELATIVO.Location = New System.Drawing.Point(913, 96)
        Me.TXTCORRELATIVO.Name = "TXTCORRELATIVO"
        Me.TXTCORRELATIVO.Size = New System.Drawing.Size(214, 20)
        Me.TXTCORRELATIVO.TabIndex = 190
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(1173, 312)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(98, 101)
        Me.BTNSALIR.TabIndex = 189
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 431)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 188
        Me.Label9.Text = "TOTAL ITEMS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.BackColor = System.Drawing.Color.White
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(99, 424)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(105, 24)
        Me.TXTTOTAL.TabIndex = 187
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBIDENTIDAD
        '
        Me.LBIDENTIDAD.Enabled = False
        Me.LBIDENTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBIDENTIDAD.Location = New System.Drawing.Point(794, 117)
        Me.LBIDENTIDAD.Name = "LBIDENTIDAD"
        Me.LBIDENTIDAD.Size = New System.Drawing.Size(21, 18)
        Me.LBIDENTIDAD.TabIndex = 186
        Me.LBIDENTIDAD.Text = "0"
        Me.LBIDENTIDAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(719, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 15)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "IDENTIDAD"
        '
        'TXTIDENTIDAD
        '
        Me.TXTIDENTIDAD.Enabled = False
        Me.TXTIDENTIDAD.Location = New System.Drawing.Point(615, 96)
        Me.TXTIDENTIDAD.Name = "TXTIDENTIDAD"
        Me.TXTIDENTIDAD.Size = New System.Drawing.Size(292, 20)
        Me.TXTIDENTIDAD.TabIndex = 176
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
        Me.DGVGENERAL.Location = New System.Drawing.Point(12, 175)
        Me.DGVGENERAL.MultiSelect = False
        Me.DGVGENERAL.Name = "DGVGENERAL"
        Me.DGVGENERAL.ReadOnly = True
        Me.DGVGENERAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGENERAL.Size = New System.Drawing.Size(1153, 237)
        Me.DGVGENERAL.TabIndex = 184
        '
        'BTNCAEPTAR
        '
        Me.BTNCAEPTAR.BackColor = System.Drawing.Color.Silver
        Me.BTNCAEPTAR.BackgroundImage = CType(resources.GetObject("BTNCAEPTAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNCAEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNCAEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCAEPTAR.Location = New System.Drawing.Point(1172, 175)
        Me.BTNCAEPTAR.Name = "BTNCAEPTAR"
        Me.BTNCAEPTAR.Size = New System.Drawing.Size(98, 105)
        Me.BTNCAEPTAR.TabIndex = 177
        Me.BTNCAEPTAR.UseVisualStyleBackColor = False
        '
        'CMBNACIONALIDAD
        '
        Me.CMBNACIONALIDAD.Enabled = False
        Me.CMBNACIONALIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBNACIONALIDAD.FormattingEnabled = True
        Me.CMBNACIONALIDAD.Location = New System.Drawing.Point(130, 96)
        Me.CMBNACIONALIDAD.Name = "CMBNACIONALIDAD"
        Me.CMBNACIONALIDAD.Size = New System.Drawing.Size(207, 21)
        Me.CMBNACIONALIDAD.TabIndex = 175
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 183
        Me.Label4.Text = "NACIONALIDAD"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1179, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 91)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 182
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(402, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(478, 25)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "BUSCAR PACIENTE PARA TARJETA DE VISITA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(498, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 25)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "SECRETARIA DE SALUD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 25)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "HOSPITAL NACIONAL DR. MARIO CATARINO RIVAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 178
        Me.PictureBox2.TabStop = False
        '
        'BUSQUEDATAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1282, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CMBCLASIFICACION)
        Me.Controls.Add(Me.CMBBUSQUEDA)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LBCORRELATIVO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTCORRELATIVO)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.LBIDENTIDAD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTIDENTIDAD)
        Me.Controls.Add(Me.DGVGENERAL)
        Me.Controls.Add(Me.BTNCAEPTAR)
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
        Me.Name = "BUSQUEDATAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR PACIENTE PARA TARJETA DE VISITA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CBNO As System.Windows.Forms.CheckBox
    Friend WithEvents CBSI As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CMBCLASIFICACION As System.Windows.Forms.ComboBox
    Friend WithEvents CMBBUSQUEDA As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LBCORRELATIVO As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTCORRELATIVO As System.Windows.Forms.TextBox
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents LBIDENTIDAD As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTIDENTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents DGVGENERAL As System.Windows.Forms.DataGridView
    Friend WithEvents BTNCAEPTAR As System.Windows.Forms.Button
    Friend WithEvents CMBNACIONALIDAD As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
