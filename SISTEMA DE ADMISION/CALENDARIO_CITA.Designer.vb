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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.BTNREGRESAR = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LIST_OTORGADOS = New System.Windows.Forms.ListView()
        Me.ITEM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FECHA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DIA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CONSULTORIO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CUPOS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OTORGADOS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LIST_NOTORGADO = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBMEDICO = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1086, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 53)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(962, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(118, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(187, 53)
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
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(15, 109)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(326, 21)
        Me.ComboBox7.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 23)
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
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(347, 109)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(242, 21)
        Me.ComboBox1.TabIndex = 61
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.FlatAppearance.BorderSize = 100
        Me.BTNBUSCAR.Location = New System.Drawing.Point(595, 69)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(74, 61)
        Me.BTNBUSCAR.TabIndex = 63
        Me.BTNBUSCAR.UseVisualStyleBackColor = True
        '
        'BTNREGRESAR
        '
        Me.BTNREGRESAR.BackgroundImage = CType(resources.GetObject("BTNREGRESAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNREGRESAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNREGRESAR.FlatAppearance.BorderSize = 100
        Me.BTNREGRESAR.Location = New System.Drawing.Point(675, 69)
        Me.BTNREGRESAR.Name = "BTNREGRESAR"
        Me.BTNREGRESAR.Size = New System.Drawing.Size(74, 61)
        Me.BTNREGRESAR.TabIndex = 64
        Me.BTNREGRESAR.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 100
        Me.Button2.Location = New System.Drawing.Point(285, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 47)
        Me.Button2.TabIndex = 66
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LIST_OTORGADOS
        '
        Me.LIST_OTORGADOS.BackColor = System.Drawing.Color.White
        Me.LIST_OTORGADOS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ITEM, Me.FECHA, Me.DIA, Me.CONSULTORIO, Me.CUPOS, Me.OTORGADOS})
        Me.LIST_OTORGADOS.FullRowSelect = True
        Me.LIST_OTORGADOS.GridLines = True
        Me.LIST_OTORGADOS.Location = New System.Drawing.Point(12, 200)
        Me.LIST_OTORGADOS.MultiSelect = False
        Me.LIST_OTORGADOS.Name = "LIST_OTORGADOS"
        Me.LIST_OTORGADOS.Size = New System.Drawing.Size(565, 360)
        Me.LIST_OTORGADOS.TabIndex = 67
        Me.LIST_OTORGADOS.UseCompatibleStateImageBehavior = False
        Me.LIST_OTORGADOS.View = System.Windows.Forms.View.Details
        '
        'ITEM
        '
        Me.ITEM.Text = "ITEM"
        Me.ITEM.Width = 67
        '
        'FECHA
        '
        Me.FECHA.Text = "FECHA DE CITA"
        Me.FECHA.Width = 121
        '
        'DIA
        '
        Me.DIA.Text = "DIA DE LA CITA"
        Me.DIA.Width = 120
        '
        'CONSULTORIO
        '
        Me.CONSULTORIO.Text = "CONSULTORIO"
        Me.CONSULTORIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CONSULTORIO.Width = 91
        '
        'CUPOS
        '
        Me.CUPOS.Text = "CUPOS"
        Me.CUPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CUPOS.Width = 67
        '
        'OTORGADOS
        '
        Me.OTORGADOS.Text = "OTORGADOS"
        Me.OTORGADOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OTORGADOS.Width = 95
        '
        'LIST_NOTORGADO
        '
        Me.LIST_NOTORGADO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LIST_NOTORGADO.FullRowSelect = True
        Me.LIST_NOTORGADO.GridLines = True
        Me.LIST_NOTORGADO.Location = New System.Drawing.Point(595, 200)
        Me.LIST_NOTORGADO.MultiSelect = False
        Me.LIST_NOTORGADO.Name = "LIST_NOTORGADO"
        Me.LIST_NOTORGADO.Size = New System.Drawing.Size(565, 360)
        Me.LIST_NOTORGADO.TabIndex = 70
        Me.LIST_NOTORGADO.UseCompatibleStateImageBehavior = False
        Me.LIST_NOTORGADO.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM"
        Me.ColumnHeader1.Width = 67
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "FECHA DE CITA"
        Me.ColumnHeader2.Width = 121
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DIA DE LA CITA"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CONSULTORIO"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 91
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CUPOS"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 67
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "OTORGADOS"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 95
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 100
        Me.Button1.Location = New System.Drawing.Point(868, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 47)
        Me.Button1.TabIndex = 69
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(595, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 29)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "FECHAS OTORGADAS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Location = New System.Drawing.Point(98, 566)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.Size = New System.Drawing.Size(85, 20)
        Me.TXTTOTAL.TabIndex = 71
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
        Me.Label6.Location = New System.Drawing.Point(991, 573)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "TOTAL ITEMS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1075, 566)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 20)
        Me.TextBox1.TabIndex = 73
        '
        'LBMEDICO
        '
        Me.LBMEDICO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMEDICO.ForeColor = System.Drawing.Color.Blue
        Me.LBMEDICO.Location = New System.Drawing.Point(217, 573)
        Me.LBMEDICO.Name = "LBMEDICO"
        Me.LBMEDICO.Size = New System.Drawing.Size(768, 79)
        Me.LBMEDICO.TabIndex = 75
        Me.LBMEDICO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CALENDARIO_CITA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1181, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBMEDICO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.LIST_NOTORGADO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LIST_OTORGADOS)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNREGRESAR)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "CALENDARIO_CITA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CALENDARIO DE CITA DE CONSULTA EXTERNA"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents BTNREGRESAR As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LIST_OTORGADOS As System.Windows.Forms.ListView
    Friend WithEvents ITEM As System.Windows.Forms.ColumnHeader
    Friend WithEvents FECHA As System.Windows.Forms.ColumnHeader
    Friend WithEvents DIA As System.Windows.Forms.ColumnHeader
    Friend WithEvents CONSULTORIO As System.Windows.Forms.ColumnHeader
    Friend WithEvents CUPOS As System.Windows.Forms.ColumnHeader
    Friend WithEvents OTORGADOS As System.Windows.Forms.ColumnHeader
    Friend WithEvents LIST_NOTORGADO As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LBMEDICO As System.Windows.Forms.Label
End Class
