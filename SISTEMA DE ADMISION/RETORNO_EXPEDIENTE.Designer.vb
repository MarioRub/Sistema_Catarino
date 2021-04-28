<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RETORNO_EXPEDIENTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RETORNO_EXPEDIENTE))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TXTCOMENTARIO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CMBBUSQUEDA = New System.Windows.Forms.ComboBox()
        Me.TXTEXPEDIENTE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.TXTPACIENTE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTNCONFIRMAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(481, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = " FORMULARIO PARA RETORNAR EXPEDIENTE"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(615, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 93)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'TXTCOMENTARIO
        '
        Me.TXTCOMENTARIO.Location = New System.Drawing.Point(157, 285)
        Me.TXTCOMENTARIO.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TXTCOMENTARIO.Name = "TXTCOMENTARIO"
        Me.TXTCOMENTARIO.Size = New System.Drawing.Size(226, 20)
        Me.TXTCOMENTARIO.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(154, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 17)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Tipo de Busqueda"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CMBBUSQUEDA
        '
        Me.CMBBUSQUEDA.Enabled = False
        Me.CMBBUSQUEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBBUSQUEDA.FormattingEnabled = True
        Me.CMBBUSQUEDA.Location = New System.Drawing.Point(157, 127)
        Me.CMBBUSQUEDA.Name = "CMBBUSQUEDA"
        Me.CMBBUSQUEDA.Size = New System.Drawing.Size(226, 21)
        Me.CMBBUSQUEDA.TabIndex = 40
        '
        'TXTEXPEDIENTE
        '
        Me.TXTEXPEDIENTE.Location = New System.Drawing.Point(157, 177)
        Me.TXTEXPEDIENTE.Name = "TXTEXPEDIENTE"
        Me.TXTEXPEDIENTE.Size = New System.Drawing.Size(226, 20)
        Me.TXTEXPEDIENTE.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(154, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "No. Expediente"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(154, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Comentario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BTNBUSCAR.BackgroundImage = CType(resources.GetObject("BTNBUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNBUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNBUSCAR.FlatAppearance.BorderSize = 50
        Me.BTNBUSCAR.Location = New System.Drawing.Point(388, 174)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(31, 25)
        Me.BTNBUSCAR.TabIndex = 44
        Me.BTNBUSCAR.UseVisualStyleBackColor = False
        '
        'TXTPACIENTE
        '
        Me.TXTPACIENTE.Location = New System.Drawing.Point(157, 232)
        Me.TXTPACIENTE.Name = "TXTPACIENTE"
        Me.TXTPACIENTE.Size = New System.Drawing.Size(226, 20)
        Me.TXTPACIENTE.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(154, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Nombre del Paciente"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BTNCONFIRMAR
        '
        Me.BTNCONFIRMAR.Location = New System.Drawing.Point(157, 326)
        Me.BTNCONFIRMAR.Name = "BTNCONFIRMAR"
        Me.BTNCONFIRMAR.Size = New System.Drawing.Size(150, 32)
        Me.BTNCONFIRMAR.TabIndex = 47
        Me.BTNCONFIRMAR.Text = "Confirmar Entrega"
        Me.BTNCONFIRMAR.UseVisualStyleBackColor = True
        '
        'RETORNO_EXPEDIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(698, 404)
        Me.Controls.Add(Me.BTNCONFIRMAR)
        Me.Controls.Add(Me.TXTPACIENTE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BTNBUSCAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CMBBUSQUEDA)
        Me.Controls.Add(Me.TXTEXPEDIENTE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTCOMENTARIO)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RETORNO_EXPEDIENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RETORNO_EXPEDIENTE"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TXTCOMENTARIO As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CMBBUSQUEDA As ComboBox
    Friend WithEvents TXTEXPEDIENTE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNBUSCAR As Button
    Friend WithEvents TXTPACIENTE As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BTNCONFIRMAR As Button
End Class
