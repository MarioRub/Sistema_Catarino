<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTA_EMPLEADO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LISTA_EMPLEADO))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CBNOMBRE = New System.Windows.Forms.CheckBox()
        Me.CBINACTIVO = New System.Windows.Forms.CheckBox()
        Me.CBACTIVO = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTNOMBRES = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.DGVGENERAL = New System.Windows.Forms.DataGridView()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.CBNOMBRE)
        Me.GroupBox6.Controls.Add(Me.CBINACTIVO)
        Me.GroupBox6.Controls.Add(Me.CBACTIVO)
        Me.GroupBox6.Location = New System.Drawing.Point(24, 114)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(270, 58)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "METODO DE BUSQUEDA"
        '
        'CBNOMBRE
        '
        Me.CBNOMBRE.AutoSize = True
        Me.CBNOMBRE.Location = New System.Drawing.Point(186, 19)
        Me.CBNOMBRE.Name = "CBNOMBRE"
        Me.CBNOMBRE.Size = New System.Drawing.Size(73, 17)
        Me.CBNOMBRE.TabIndex = 5
        Me.CBNOMBRE.Text = "NOMBRE"
        Me.CBNOMBRE.UseVisualStyleBackColor = True
        '
        'CBINACTIVO
        '
        Me.CBINACTIVO.AutoSize = True
        Me.CBINACTIVO.Location = New System.Drawing.Point(95, 19)
        Me.CBINACTIVO.Name = "CBINACTIVO"
        Me.CBINACTIVO.Size = New System.Drawing.Size(76, 17)
        Me.CBINACTIVO.TabIndex = 4
        Me.CBINACTIVO.Text = "INACTIVO"
        Me.CBINACTIVO.UseVisualStyleBackColor = True
        '
        'CBACTIVO
        '
        Me.CBACTIVO.AutoSize = True
        Me.CBACTIVO.Location = New System.Drawing.Point(9, 19)
        Me.CBACTIVO.Name = "CBACTIVO"
        Me.CBACTIVO.Size = New System.Drawing.Size(65, 17)
        Me.CBACTIVO.TabIndex = 1
        Me.CBACTIVO.Text = "ACTIVO"
        Me.CBACTIVO.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(945, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 77)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(421, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "LISTA DE EMPLEADOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(418, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "SECRETARIA DE SALUD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "HOSPITAL NACIONAL DR. MARIO CATARINO RIVAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(187, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(532, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "NOMBRE"
        '
        'TXTNOMBRES
        '
        Me.TXTNOMBRES.Enabled = False
        Me.TXTNOMBRES.Location = New System.Drawing.Point(327, 122)
        Me.TXTNOMBRES.Name = "TXTNOMBRES"
        Me.TXTNOMBRES.Size = New System.Drawing.Size(476, 20)
        Me.TXTNOMBRES.TabIndex = 103
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 498)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "TOTAL ITEMS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.BackColor = System.Drawing.Color.White
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(108, 491)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(159, 24)
        Me.TXTTOTAL.TabIndex = 110
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVGENERAL
        '
        Me.DGVGENERAL.AllowUserToAddRows = False
        Me.DGVGENERAL.AllowUserToResizeColumns = False
        Me.DGVGENERAL.AllowUserToResizeRows = False
        Me.DGVGENERAL.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGENERAL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVGENERAL.ColumnHeadersHeight = 30
        Me.DGVGENERAL.Location = New System.Drawing.Point(24, 178)
        Me.DGVGENERAL.MultiSelect = False
        Me.DGVGENERAL.Name = "DGVGENERAL"
        Me.DGVGENERAL.ReadOnly = True
        Me.DGVGENERAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGENERAL.Size = New System.Drawing.Size(988, 301)
        Me.DGVGENERAL.TabIndex = 109
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(935, 104)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(77, 68)
        Me.BTNSALIR.TabIndex = 112
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'LISTA_EMPLEADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1041, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.DGVGENERAL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTNOMBRES)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.MaximizeBox = False
        Me.Name = "LISTA_EMPLEADO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTA_EMPLEADO"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents CBNOMBRE As System.Windows.Forms.CheckBox
    Friend WithEvents CBINACTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents CBACTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMBRES As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents DGVGENERAL As System.Windows.Forms.DataGridView
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
End Class
