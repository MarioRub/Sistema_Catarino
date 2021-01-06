<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGREGAR_ESPECIALIDAD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AGREGAR_ESPECIALIDAD))
        Me.TXTESPECIALIDAD = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TXTCONSULTORIO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVESPECIALIDAD = New System.Windows.Forms.DataGridView()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTCODIGO = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVESPECIALIDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTESPECIALIDAD
        '
        Me.TXTESPECIALIDAD.Location = New System.Drawing.Point(132, 65)
        Me.TXTESPECIALIDAD.Name = "TXTESPECIALIDAD"
        Me.TXTESPECIALIDAD.Size = New System.Drawing.Size(496, 20)
        Me.TXTESPECIALIDAD.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(22, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(92, 15)
        Me.Label23.TabIndex = 74
        Me.Label23.Text = "ESPECIALIDAD"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(725, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 89)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 72
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(307, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 25)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "AGREGAR ESPECIALIDAD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(412, 25)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "HOSPITAL DR. MARIO CATARINO RIVAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(213, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 69
        Me.PictureBox2.TabStop = False
        '
        'TXTCONSULTORIO
        '
        Me.TXTCONSULTORIO.Location = New System.Drawing.Point(132, 100)
        Me.TXTCONSULTORIO.Name = "TXTCONSULTORIO"
        Me.TXTCONSULTORIO.Size = New System.Drawing.Size(496, 20)
        Me.TXTCONSULTORIO.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "CONSULTORIO"
        '
        'DGVESPECIALIDAD
        '
        Me.DGVESPECIALIDAD.AllowUserToAddRows = False
        Me.DGVESPECIALIDAD.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DGVESPECIALIDAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVESPECIALIDAD.ColumnHeadersHeight = 30
        Me.DGVESPECIALIDAD.Location = New System.Drawing.Point(64, 233)
        Me.DGVESPECIALIDAD.Name = "DGVESPECIALIDAD"
        Me.DGVESPECIALIDAD.ReadOnly = True
        Me.DGVESPECIALIDAD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVESPECIALIDAD.Size = New System.Drawing.Size(643, 275)
        Me.DGVESPECIALIDAD.TabIndex = 79
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(711, 419)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(95, 89)
        Me.BTNSALIR.TabIndex = 3
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.Color.Silver
        Me.BTNGUARDAR.BackgroundImage = CType(resources.GetObject("BTNGUARDAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNGUARDAR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.Location = New System.Drawing.Point(711, 324)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(95, 89)
        Me.BTNGUARDAR.TabIndex = 2
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTCODIGO)
        Me.GroupBox1.Controls.Add(Me.TXTCONSULTORIO)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.TXTESPECIALIDAD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 133)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AGREGAR DATOS DE LA ESPECIALIDAD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "CODIGO"
        '
        'TXTCODIGO
        '
        Me.TXTCODIGO.Location = New System.Drawing.Point(132, 28)
        Me.TXTCODIGO.Name = "TXTCODIGO"
        Me.TXTCODIGO.Size = New System.Drawing.Size(496, 20)
        Me.TXTCODIGO.TabIndex = 1
        '
        'AGREGAR_ESPECIALIDAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(810, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.DGVESPECIALIDAD)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AGREGAR_ESPECIALIDAD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR_ESPECIALIDAD"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVESPECIALIDAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTESPECIALIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TXTCONSULTORIO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVESPECIALIDAD As System.Windows.Forms.DataGridView
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTCODIGO As System.Windows.Forms.TextBox
End Class
