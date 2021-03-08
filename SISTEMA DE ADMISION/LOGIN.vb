Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class LOGIN
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub FORM_LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.Opacity = 0.1
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBNACIONALIDAD.Focus()
        TXTIDENTIDAD.Enabled = False
        TXTUSUARIO.Enabled = False
        TXTESTADO.Enabled = False
        TXTCLAVE.Enabled = False
        CMBTURNO.Enabled = False
        TXTDEPARTAMENTO.Enabled = False
        TXTCOMENTARIO.Enabled = False
        BTNBUSCAR.Enabled = False
        BTNACEPTAR.Enabled = False
        CMBTURNO.Items.Add("A")
        CMBTURNO.Items.Add("B")
        CMBTURNO.Items.Add("C")
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
        LBFECHA.Text = DateTime.Now.ToString("dd/MMM/yyyy") 'extraer la fecha en dia/mes/año del sistema
        LBHORARIO.Text = UCase(Format(Now, "hh:mm tt")) 'extraer hora de 12 del sistema
    End Sub
    Private Sub BTNSALIR_MouseEnter(sender As Object, e As EventArgs) Handles BTNSALIR.MouseEnter
        BTNSALIR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNSALIR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNSALIR_MouseLeave(sender As Object, e As EventArgs) Handles BTNSALIR.MouseLeave
        BTNSALIR.FlatAppearance.BorderColor = Color.Silver
        BTNSALIR.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub BTNSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub
    Private Sub CMBTURNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBTURNO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub
    Private Sub BTNACEPTAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNACEPTAR.MouseEnter
        BTNACEPTAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNACEPTAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNACEPTAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNACEPTAR.MouseLeave
        BTNACEPTAR.FlatAppearance.BorderColor = Color.Silver
        BTNACEPTAR.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub BTNACEPTAR_Click(sender As System.Object, e As System.EventArgs) Handles BTNACEPTAR.Click
        Dim FECHA As String = Format(CDate(LBFECHA.Text), "yyyy/MM/dd")
        Dim ADAPTADOR As New SqlDataAdapter
        Dim TABLA As New DataTable
        Dim COMANDO As String = "SELECT * FROM LOGIN WHERE NACIONALIDAD='" & CMBNACIONALIDAD.Text & "' AND IDENTIDAD='" _
                                & TXTIDENTIDAD.Text & "' AND CLAVE='" & TXTCLAVE.Text & "'"
        If CMBTURNO.Text <> "" Then
            Try
                ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
                ADAPTADOR.Fill(TABLA)
                If TABLA.Rows.Count <> 0 Then
                    '---------------------------------GUARDAR-------------------
                    CONE.Open()
                    Dim LOGINBD As String = "UPDATE LOGIN SET ESTATUS='ON' WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
                    Dim GUARDAR As String = "INSERT INTO REG_LOGIN (USUARIO, IDENTIDAD, TURNO, COMENTARIO, FECHA_INGRESO, HORA_INGRESO, " _
                    & "DEPARTAMENTO) VALUES ('" & TXTUSUARIO.Text & "','" & TXTIDENTIDAD.Text & "','" & CMBTURNO.Text & "','" _
                    & TXTCOMENTARIO.Text & "','" & FECHA & "','" & LBHORARIO.Text & "','" & TXTDEPARTAMENTO.Text & "')"
                    Dim COMAND As SqlCommand
                    Dim LOGIN As SqlCommand
                    LOGIN = New SqlCommand(LOGINBD, CONE) 'INSERTAR ESTATUS
                    COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN REG_LOGIN
                    COMAND.ExecuteNonQuery()
                    LOGIN.ExecuteNonQuery()
                    CONE.Close()
                    CONE.Dispose()
                    COMAND.Dispose()
                    LOGIN.Dispose()
                    '-----------------------------------------------------------
                    MsgBox("ACCESO CONCEDIDO", MsgBoxStyle.Information, "BIENVENIDO")
                    PRINCIPAL.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
                    Me.Hide() 'OCULTA FORMULARIO
                    PRINCIPAL.Show() 'EJECUTA FORMULARIO
                Else
                    MsgBox("ACCESO DENEGADO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                    TXTIDENTIDAD.Clear()
                    TXTUSUARIO.Clear()
                    TXTESTADO.Clear()
                    TXTESTATUS.Clear()
                    TXTDEPARTAMENTO.Clear()
                    TXTCLAVE.Clear()
                    CMBTURNO.Text = Nothing
                    TXTCOMENTARIO.Clear()
                    TXTUSUARIO.Clear()
                    TXTIDENTIDAD.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                CONE.Close()
            End Try
        Else
            MsgBox("SELECCIONE EL TURNO", MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
        End If
    End Sub
    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.MaxLength = 15
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNBUSCAR.Enabled = True
            ElseIf TXTIDENTIDAD.Text.Length < 15 Then
                BTNBUSCAR.Enabled = False
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
            If TXTIDENTIDAD.Text.Length >= 6 Then
                BTNBUSCAR.Enabled = True
            ElseIf TXTIDENTIDAD.Text.Length <= 5 Then
                BTNBUSCAR.Enabled = False
            End If
        End If
        TXTIDENTIDAD.Focus()
        TXTUSUARIO.Text = ""
        TXTCLAVE.Text = ""
        TXTESTADO.Text = ""
        TXTESTATUS.Text = ""
        CMBTURNO.Text = Nothing
        TXTCOMENTARIO.Text = ""
    End Sub
    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
        Dim IDENTIDAD As String = TXTIDENTIDAD.Text
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.MaxLength = 15
            If TXTIDENTIDAD.Text.Length = 4 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTIDENTIDAD.Text = IDENTIDAD
                e.Handled = True
                TXTIDENTIDAD.Select(TXTIDENTIDAD.Text.Length, 0)
            End If
            If TXTIDENTIDAD.Text.Length = 9 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTIDENTIDAD.Text = IDENTIDAD
                e.Handled = True
                TXTIDENTIDAD.Select(TXTIDENTIDAD.Text.Length, 0)
            End If
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNBUSCAR.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
        End If
    End Sub
    Private Sub BTNBUSCAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNBUSCAR.MouseEnter
        BTNBUSCAR.FlatAppearance.BorderColor = Color.DodgerBlue
    End Sub

    Private Sub BTNBUSCAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNBUSCAR.MouseLeave
        BTNBUSCAR.FlatAppearance.BorderColor = Color.Silver
    End Sub
    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        CMBTURNO.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NACIONALIDAD, IDENTIDAD, USUARIO, CLAVE, ESTADO, ESTATUS, DEPARTAMENTO FROM LOGIN WHERE IDENTIDAD ='" _
                                & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO)
        If DATO.Tables(0).Rows.Count = 0 Then
            MsgBox("EL USUARIO NO EXISTE")
            TXTIDENTIDAD.Clear()
            TXTUSUARIO.Clear()
            TXTESTADO.Clear()
            TXTESTATUS.Clear()
            TXTDEPARTAMENTO.Clear()
            TXTCLAVE.Clear()
            CMBTURNO.Text = Nothing
            TXTCOMENTARIO.Clear()
            TXTIDENTIDAD.Focus()
        ElseIf DATO.Tables(0).Rows.Count > 0 Then
            If DATO.Tables(0).Rows(0)("ESTADO") = "ACTIVO" Then
                Try
                    If TXTIDENTIDAD.Text <> "" Then
                        TXTUSUARIO.Text = DATO.Tables(0).Rows(0)("USUARIO")
                        TXTESTADO.Text = DATO.Tables(0).Rows(0)("ESTADO")
                        TXTDEPARTAMENTO.Text = DATO.Tables(0).Rows(0)("DEPARTAMENTO")
                        TXTESTATUS.Text = DATO.Tables(0).Rows(0)("ESTATUS")
                        TXTCLAVE.Enabled = True
                        CMBTURNO.Enabled = True
                        TXTCOMENTARIO.Enabled = True
                        BTNACEPTAR.Enabled = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If DATO.Tables(0).Rows(0)("DEPARTAMENTO") = "ADMINISTRADOR" Then
                    PRINCIPAL.NUEVOUSUARIOToolStripMenuItem.Visible = True
                    PRINCIPAL.MEDICOToolStripMenuItem.Visible = True
                    PRINCIPAL.CONSULTAEXTERNAToolStripMenuItem.Visible = True
                    PRINCIPAL.EMERGENCIAToolStripMenuItem.Visible = True
                    PRINCIPAL.GESTIONDECAMAToolStripMenuItem.Visible = True
                    PRINCIPAL.CENSOSToolStripMenuItem.Visible = True
                    PRINCIPAL.HISTORIALToolStripMenuItem.Visible = True
                    PRINCIPAL.ADMISIONCONSULTAEXTERNAToolStripMenuItem.Visible = True
                    PRINCIPAL.ADMISIONEMERGENCIAToolStripMenuItem.Visible = True
                    PRINCIPAL.LEQToolStripMenuItem2.Visible = True
                ElseIf DATO.Tables(0).Rows(0)("DEPARTAMENTO") = "ADMISION EMERGENCIA" Then
                    PRINCIPAL.NUEVOUSUARIOToolStripMenuItem.Visible = False
                    PRINCIPAL.MEDICOToolStripMenuItem.Visible = False
                    PRINCIPAL.CONSULTAEXTERNAToolStripMenuItem.Visible = True
                    'PRINCIPAL.EMERGENCIAToolStripMenuItem.Visible = False
                    PRINCIPAL.GESTIONDECAMAToolStripMenuItem.Visible = False
                    PRINCIPAL.CENSOSToolStripMenuItem.Visible = False
                    PRINCIPAL.HISTORIALToolStripMenuItem.Visible = False
                    PRINCIPAL.ADMISIONCONSULTAEXTERNAToolStripMenuItem.Visible = False
                    PRINCIPAL.LEQToolStripMenuItem2.Visible = False
                End If
            ElseIf DATO.Tables(0).Rows(0)("ESTADO") = "INACTIVO" Then
                MsgBox("EL USUARIO NO ESTA AUTORIZADO PARA INGRESAR AL SISTEMA, FAVOR CONTACTARSE CON EL ADMINISTRADOR", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                TXTIDENTIDAD.Clear()
                TXTUSUARIO.Clear()
                TXTESTADO.Clear()
                TXTESTATUS.Clear()
                TXTDEPARTAMENTO.Clear()
                TXTCLAVE.Clear()
                CMBTURNO.Text = Nothing
                TXTCOMENTARIO.Clear()
                TXTIDENTIDAD.Focus()
            End If
        End If
        ADAPTADOR.Dispose()
        DATO.Dispose()
    End Sub
    Private Sub CMBNACIONALIDAD_SelectedValueChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedValueChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Or CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Enabled = True : TXTIDENTIDAD.Text = ""
            TXTUSUARIO.Enabled = False : TXTUSUARIO.Text = ""
            TXTESTADO.Enabled = False : TXTESTADO.Text = ""
            TXTCLAVE.Enabled = False : TXTCLAVE.Text = ""
            CMBTURNO.Enabled = False : CMBTURNO.Text = ""
            TXTDEPARTAMENTO.Enabled = False : TXTDEPARTAMENTO.Text = ""
            TXTCOMENTARIO.Enabled = False : TXTCOMENTARIO.Text = ""
            BTNBUSCAR.Enabled = False
            BTNACEPTAR.Enabled = False
        End If
    End Sub

    Private Sub TXTESTATUS_TextChanged(sender As Object, e As EventArgs) Handles TXTESTATUS.TextChanged
        If TXTESTATUS.Text = "ON" Then
            MsgBox("EL USUARIO YA ESTA HACIENDO USADO")
            TXTIDENTIDAD.Clear()
            TXTUSUARIO.Clear()
            TXTESTADO.Clear()
            TXTESTATUS.Clear()
            TXTDEPARTAMENTO.Clear()
            TXTCLAVE.Clear()
            CMBTURNO.Text = Nothing
            TXTCOMENTARIO.Clear()
            TXTUSUARIO.Clear()
            TXTIDENTIDAD.Focus()
        End If
    End Sub

    Private Sub CMBTURNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBTURNO.SelectedIndexChanged
        CMBTURNO.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub TXTUSUARIO_TextChanged(sender As Object, e As EventArgs) Handles TXTUSUARIO.TextChanged

    End Sub

    Private Sub TXTCLAVE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCLAVE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCLAVE_TextChanged(sender As Object, e As EventArgs) Handles TXTCLAVE.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity = 2 Then
            Timer1.Enabled = True
        End If
    End Sub
End Class