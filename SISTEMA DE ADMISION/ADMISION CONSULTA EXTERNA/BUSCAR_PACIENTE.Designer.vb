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
        Me.LBUSUARIO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CMBBUSQUEDA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTNOMBRES = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LIST_OTORGADOS = New System.Windows.Forms.ListView()
        Me.ITEM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NACIONALIDAD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CLINICA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NOMBRE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SEXO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EDAD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TIPO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FECHA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DIRECCION = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TELEFONO1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TELEFONO2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ESPECIALIDAD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MEDICO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CITADO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DIAS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBUSUARIO
        '
        Me.LBUSUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUSUARIO.ForeColor = System.Drawing.Color.Blue
        Me.LBUSUARIO.Location = New System.Drawing.Point(312, 84)
        Me.LBUSUARIO.Name = "LBUSUARIO"
        Me.LBUSUARIO.Size = New System.Drawing.Size(494, 25)
        Me.LBUSUARIO.TabIndex = 22
        Me.LBUSUARIO.Text = "JOSUE ALEJANDRO RIVAS DE PAZ"
        Me.LBUSUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(494, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "SISTEMA PARA CITAS EN CONSULTA EXTERNA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "DR. MARIO CATARINO RIVAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "FUNDACION APOYO AL HOSPITAL NACIONAL"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(187, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1189, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 53)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(968, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(118, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'CMBBUSQUEDA
        '
        Me.CMBBUSQUEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBBUSQUEDA.FormattingEnabled = True
        Me.CMBBUSQUEDA.Location = New System.Drawing.Point(142, 128)
        Me.CMBBUSQUEDA.Name = "CMBBUSQUEDA"
        Me.CMBBUSQUEDA.Size = New System.Drawing.Size(330, 21)
        Me.CMBBUSQUEDA.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "TIPO DE BUSQUEDA"
        '
        'TXTNOMBRES
        '
        Me.TXTNOMBRES.Location = New System.Drawing.Point(478, 129)
        Me.TXTNOMBRES.Name = "TXTNOMBRES"
        Me.TXTNOMBRES.Size = New System.Drawing.Size(285, 20)
        Me.TXTNOMBRES.TabIndex = 27
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(769, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 20)
        Me.TextBox1.TabIndex = 28
        '
        'LIST_OTORGADOS
        '
        Me.LIST_OTORGADOS.BackColor = System.Drawing.Color.White
        Me.LIST_OTORGADOS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ITEM, Me.NACIONALIDAD, Me.CLINICA, Me.NOMBRE, Me.SEXO, Me.EDAD, Me.TIPO, Me.FECHA, Me.DIRECCION, Me.TELEFONO1, Me.TELEFONO2, Me.ESPECIALIDAD, Me.MEDICO, Me.CITADO, Me.DIAS})
        Me.LIST_OTORGADOS.FullRowSelect = True
        Me.LIST_OTORGADOS.GridLines = True
        Me.LIST_OTORGADOS.Location = New System.Drawing.Point(12, 178)
        Me.LIST_OTORGADOS.MultiSelect = False
        Me.LIST_OTORGADOS.Name = "LIST_OTORGADOS"
        Me.LIST_OTORGADOS.Size = New System.Drawing.Size(1246, 360)
        Me.LIST_OTORGADOS.TabIndex = 68
        Me.LIST_OTORGADOS.UseCompatibleStateImageBehavior = False
        Me.LIST_OTORGADOS.View = System.Windows.Forms.View.Details
        '
        'ITEM
        '
        Me.ITEM.Text = "ITEM"
        Me.ITEM.Width = 56
        '
        'NACIONALIDAD
        '
        Me.NACIONALIDAD.Text = "NACIONALIDAD"
        Me.NACIONALIDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NACIONALIDAD.Width = 199
        '
        'CLINICA
        '
        Me.CLINICA.Text = "HISTORIA CLINICA"
        Me.CLINICA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CLINICA.Width = 208
        '
        'NOMBRE
        '
        Me.NOMBRE.Text = "NOMBRE DEL PACIENTE"
        Me.NOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NOMBRE.Width = 458
        '
        'SEXO
        '
        Me.SEXO.Text = "SEXO"
        Me.SEXO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SEXO.Width = 93
        '
        'EDAD
        '
        Me.EDAD.Text = "EDAD"
        Me.EDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EDAD.Width = 59
        '
        'TIPO
        '
        Me.TIPO.Text = "TIPO"
        Me.TIPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TIPO.Width = 125
        '
        'FECHA
        '
        Me.FECHA.Text = "FECHA DE NACIMIENTO"
        Me.FECHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FECHA.Width = 145
        '
        'DIRECCION
        '
        Me.DIRECCION.Text = "DIRECCION DEL PACIENTE"
        Me.DIRECCION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DIRECCION.Width = 493
        '
        'TELEFONO1
        '
        Me.TELEFONO1.Text = "TELEFONO # 1"
        Me.TELEFONO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TELEFONO1.Width = 122
        '
        'TELEFONO2
        '
        Me.TELEFONO2.Text = "TELEFONO # 2"
        Me.TELEFONO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TELEFONO2.Width = 126
        '
        'ESPECIALIDAD
        '
        Me.ESPECIALIDAD.Text = "ESPECIALIDAD"
        Me.ESPECIALIDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ESPECIALIDAD.Width = 330
        '
        'MEDICO
        '
        Me.MEDICO.Text = "MEDICO"
        Me.MEDICO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MEDICO.Width = 270
        '
        'CITADO
        '
        Me.CITADO.Text = "FECHA CITADO"
        Me.CITADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CITADO.Width = 116
        '
        'DIAS
        '
        Me.DIAS.Text = "DIA DE CITADO"
        Me.DIAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DIAS.Width = 133
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackgroundImage = CType(resources.GetObject("BTNACEPTAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACEPTAR.Location = New System.Drawing.Point(1089, 93)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(56, 56)
        Me.BTNACEPTAR.TabIndex = 70
        Me.BTNACEPTAR.UseVisualStyleBackColor = True
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(1160, 93)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(56, 56)
        Me.BTNSALIR.TabIndex = 69
        Me.BTNSALIR.UseVisualStyleBackColor = True
        '
        'BUSCAR_PACIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1015, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.LIST_OTORGADOS)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TXTNOMBRES)
        Me.Controls.Add(Me.CMBBUSQUEDA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LBUSUARIO)
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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBUSUARIO As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents CMBBUSQUEDA As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMBRES As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LIST_OTORGADOS As System.Windows.Forms.ListView
    Friend WithEvents ITEM As System.Windows.Forms.ColumnHeader
    Friend WithEvents NACIONALIDAD As System.Windows.Forms.ColumnHeader
    Friend WithEvents CLINICA As System.Windows.Forms.ColumnHeader
    Friend WithEvents NOMBRE As System.Windows.Forms.ColumnHeader
    Friend WithEvents SEXO As System.Windows.Forms.ColumnHeader
    Friend WithEvents EDAD As System.Windows.Forms.ColumnHeader
    Friend WithEvents TIPO As System.Windows.Forms.ColumnHeader
    Friend WithEvents FECHA As System.Windows.Forms.ColumnHeader
    Friend WithEvents DIRECCION As System.Windows.Forms.ColumnHeader
    Friend WithEvents TELEFONO1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TELEFONO2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ESPECIALIDAD As System.Windows.Forms.ColumnHeader
    Friend WithEvents MEDICO As System.Windows.Forms.ColumnHeader
    Friend WithEvents CITADO As System.Windows.Forms.ColumnHeader
    Friend WithEvents DIAS As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
End Class
