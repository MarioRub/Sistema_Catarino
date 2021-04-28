<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BUSCAR_EXPEDIENTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BUSCAR_EXPEDIENTE))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CMBBUSQUEDA = New System.Windows.Forms.ComboBox()
        Me.TXTEXPEDIENTE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.DGVGENERAL = New System.Windows.Forms.DataGridView()
        Me.TXTNOMBREPACIENTE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBNOMBRE = New System.Windows.Forms.RadioButton()
        Me.CBIDENTIDAD = New System.Windows.Forms.RadioButton()
        Me.CHKHISTORIAL = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(983, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 93)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(205, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(445, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "FORMULARIO PARA BUSCAR EXPEDIENTE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(300, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 17)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Tipo de Busqueda"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CMBBUSQUEDA
        '
        Me.CMBBUSQUEDA.Enabled = False
        Me.CMBBUSQUEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBBUSQUEDA.FormattingEnabled = True
        Me.CMBBUSQUEDA.Location = New System.Drawing.Point(303, 110)
        Me.CMBBUSQUEDA.Name = "CMBBUSQUEDA"
        Me.CMBBUSQUEDA.Size = New System.Drawing.Size(226, 21)
        Me.CMBBUSQUEDA.TabIndex = 36
        '
        'TXTEXPEDIENTE
        '
        Me.TXTEXPEDIENTE.Location = New System.Drawing.Point(303, 160)
        Me.TXTEXPEDIENTE.Name = "TXTEXPEDIENTE"
        Me.TXTEXPEDIENTE.Size = New System.Drawing.Size(226, 20)
        Me.TXTEXPEDIENTE.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(300, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "No. Expediente"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackColor = System.Drawing.Color.Silver
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.Enabled = False
        Me.BTNBUSCAR.Location = New System.Drawing.Point(862, 111)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(81, 77)
        Me.BTNBUSCAR.TabIndex = 141
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(947, 111)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(81, 77)
        Me.BTNSALIR.TabIndex = 142
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'DGVGENERAL
        '
        Me.DGVGENERAL.AllowUserToAddRows = False
        Me.DGVGENERAL.AllowUserToResizeColumns = False
        Me.DGVGENERAL.AllowUserToResizeRows = False
        Me.DGVGENERAL.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVGENERAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGENERAL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVGENERAL.ColumnHeadersHeight = 30
        Me.DGVGENERAL.Location = New System.Drawing.Point(39, 208)
        Me.DGVGENERAL.MultiSelect = False
        Me.DGVGENERAL.Name = "DGVGENERAL"
        Me.DGVGENERAL.ReadOnly = True
        Me.DGVGENERAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGENERAL.Size = New System.Drawing.Size(999, 281)
        Me.DGVGENERAL.TabIndex = 143
        '
        'TXTNOMBREPACIENTE
        '
        Me.TXTNOMBREPACIENTE.Location = New System.Drawing.Point(587, 111)
        Me.TXTNOMBREPACIENTE.Name = "TXTNOMBREPACIENTE"
        Me.TXTNOMBREPACIENTE.Size = New System.Drawing.Size(226, 20)
        Me.TXTNOMBREPACIENTE.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(584, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Nombre del Paciente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBNOMBRE)
        Me.GroupBox1.Controls.Add(Me.CBIDENTIDAD)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 64)
        Me.GroupBox1.TabIndex = 150
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "METODO DE BUSQUEDA"
        '
        'CBNOMBRE
        '
        Me.CBNOMBRE.AutoSize = True
        Me.CBNOMBRE.Location = New System.Drawing.Point(12, 38)
        Me.CBNOMBRE.Name = "CBNOMBRE"
        Me.CBNOMBRE.Size = New System.Drawing.Size(152, 17)
        Me.CBNOMBRE.TabIndex = 0
        Me.CBNOMBRE.TabStop = True
        Me.CBNOMBRE.Text = "NOMBRE DEL PACIENTE"
        Me.CBNOMBRE.UseVisualStyleBackColor = True
        '
        'CBIDENTIDAD
        '
        Me.CBIDENTIDAD.AutoSize = True
        Me.CBIDENTIDAD.Location = New System.Drawing.Point(12, 15)
        Me.CBIDENTIDAD.Name = "CBIDENTIDAD"
        Me.CBIDENTIDAD.Size = New System.Drawing.Size(84, 17)
        Me.CBIDENTIDAD.TabIndex = 1
        Me.CBIDENTIDAD.TabStop = True
        Me.CBIDENTIDAD.Text = "IDENTIDAD"
        Me.CBIDENTIDAD.UseVisualStyleBackColor = True
        '
        'CHKHISTORIAL
        '
        Me.CHKHISTORIAL.AutoSize = True
        Me.CHKHISTORIAL.Location = New System.Drawing.Point(587, 149)
        Me.CHKHISTORIAL.Name = "CHKHISTORIAL"
        Me.CHKHISTORIAL.Size = New System.Drawing.Size(148, 17)
        Me.CHKHISTORIAL.TabIndex = 151
        Me.CHKHISTORIAL.Text = "Mostrar Historial Completo"
        Me.CHKHISTORIAL.UseVisualStyleBackColor = True
        '
        'BUSCAR_EXPEDIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1076, 526)
        Me.Controls.Add(Me.CHKHISTORIAL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTNOMBREPACIENTE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVGENERAL)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CMBBUSQUEDA)
        Me.Controls.Add(Me.TXTEXPEDIENTE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "BUSCAR_EXPEDIENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR_EXPEDIENTE"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CMBBUSQUEDA As ComboBox
    Friend WithEvents TXTEXPEDIENTE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BTNBUSCAR As Button
    Friend WithEvents BTNSALIR As Button
    Friend WithEvents DGVGENERAL As DataGridView
    Friend WithEvents TXTNOMBREPACIENTE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBNOMBRE As RadioButton
    Friend WithEvents CBIDENTIDAD As RadioButton
    Friend WithEvents CHKHISTORIAL As CheckBox
End Class
