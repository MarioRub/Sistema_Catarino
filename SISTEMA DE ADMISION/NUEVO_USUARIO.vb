Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class NUEVO_USUARIO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub NUEVO_USUARIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
    End Sub

    Private Sub TXTUSUARIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTUSUARIO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTUSUARIO_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXTUSUARIO.TextChanged

    End Sub

    Private Sub TXTCLAVE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCLAVE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCLAVE_TextChanged(sender As System.Object, e As System.EventArgs) Handles TXTCLAVE.TextChanged

    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            Dim TEXTO As String = TXTIDENTIDAD.Text
            If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
            End If
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNIDENTIDAD.Focus()
            End If
            If TXTIDENTIDAD.Text.Length = 4 Then
                TEXTO = TEXTO + "-" + e.KeyChar
                TXTIDENTIDAD.Text = TEXTO
                e.Handled = True
                TXTIDENTIDAD.Select(TXTIDENTIDAD.Text.Length, 0)
            End If
            If TXTIDENTIDAD.Text.Length = 9 Then
                TEXTO = TEXTO + "-" + e.KeyChar
                TXTIDENTIDAD.Text = TEXTO
                e.Handled = True
                TXTIDENTIDAD.Select(TXTIDENTIDAD.Text.Length, 0)
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
                e.Handled = True
                MsgBox("NO SE PERMITEN ESPACIOS", MsgBoxStyle.Critical, "ALERTA")
            End If
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.MaxLength = 15
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNIDENTIDAD.Visible = True
            ElseIf TXTIDENTIDAD.Text.Length < 15 Then
                BTNIDENTIDAD.Visible = False
                TXTIDENTIDAD.Focus()
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
            If TXTIDENTIDAD.Text.Length >= 6 Then
                BTNIDENTIDAD.Visible = True
            ElseIf TXTIDENTIDAD.Text.Length <= 5 Then
                BTNIDENTIDAD.Visible = False
                TXTIDENTIDAD.Focus()
            End If
        End If
        TXTUSUARIO.Text = "" : TXTUSUARIO.Enabled = False
        TXTCLAVE.Text = "" : TXTCLAVE.Enabled = False
        CBACTIVO.Checked = False : CBACTIVO.Enabled = False
        CBINACTIVO.Checked = False : CBINACTIVO.Enabled = False
        BTNACEPTAR.Enabled = False : BTNMODIFICAR.Enabled = False
        TXTESTATUS.Text = "" : TXTESTATUS.Enabled = False
        TXTDEPA.Text = "" : TXTDEPA.Enabled = False
    End Sub

    Private Sub BTNIDENTIDAD_Click(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.Click
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NACIONALIDAD, IDENTIDAD, USUARIO, CLAVE, ESTADO, ESTATUS, DEPARTAMENTO FROM LOGIN " _
        & "WHERE IDENTIDAD ='" & Me.TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO)
        Try
            TXTUSUARIO.Text = DATO.Tables(0).Rows(0)("USUARIO")
            TXTCLAVE.Text = DATO.Tables(0).Rows(0)("CLAVE")
            TXTESTATUS.Text = DATO.Tables(0).Rows(0)("ESTATUS")
            TXTDEPA.Text = DATO.Tables(0).Rows(0)("DEPARTAMENTO")
            If DATO.Tables(0).Rows(0)("ESTADO") = "ACTIVO" Then
                CBACTIVO.Checked = True
                CBINACTIVO.Checked = False
            ElseIf DATO.Tables(0).Rows(0)("ESTADO") = "INACTIVO" Then
                CBACTIVO.Checked = False
                CBINACTIVO.Checked = True
            End If
            CBACTIVO.Enabled = True : CBINACTIVO.Enabled = True
            TXTUSUARIO.Enabled = True : TXTCLAVE.Enabled = True
            TXTDEPA.Enabled = True
            BTNDEPA.Visible = True
            BTNACEPTAR.Enabled = False : BTNMODIFICAR.Enabled = True
            TXTIDENTIDAD.Focus()
        Catch ex As Exception
            'MsgBox(ex.Message)
            TXTUSUARIO.Enabled = True : TXTCLAVE.Enabled = True
            TXTDEPA.Enabled = True
            BTNACEPTAR.Enabled = False : BTNMODIFICAR.Enabled = True
            BTNDEPA.Visible = True
            CBACTIVO.Enabled = True : CBINACTIVO.Enabled = True
            TXTIDENTIDAD.Focus()
            If DATO.Tables(0).Rows.Count = 0 Then
                MsgBox("EL PACIENTE NO EXISTE EN LA BASE DE DATOS, FAVOR INGRESARLO", MsgBoxStyle.Exclamation, AcceptButton)
                TXTUSUARIO.Enabled = True : TXTCLAVE.Enabled = True
                TXTDEPA.Enabled = True
                BTNDEPA.Visible = True
                BTNACEPTAR.Enabled = True : BTNMODIFICAR.Enabled = False
                TXTUSUARIO.Text = ""
                TXTCLAVE.Text = ""
                TXTDEPA.Text = ""
                CBACTIVO.Enabled = False : CBINACTIVO.Enabled = False
                CBACTIVO.Checked = True
                CBINACTIVO.Checked = False
                TXTESTATUS.Text = "OFF"
                TXTIDENTIDAD.Focus()
            End If
        End Try
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBNACIONALIDAD.Text <> "" Then
            TXTIDENTIDAD.Enabled = True
        Else
            TXTIDENTIDAD.Enabled = False
        End If
    End Sub

    Private Sub BTNDEPA_Click(sender As Object, e As EventArgs) Handles BTNDEPA.Click
        DEPARTAMENTO.Show()
    End Sub

    Private Sub CBACTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CBACTIVO.CheckedChanged
        If CBACTIVO.Checked = True Then
            CBINACTIVO.Checked = False
        End If
    End Sub

    Private Sub CBINACTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CBINACTIVO.CheckedChanged
        If CBINACTIVO.Checked = True Then
            CBACTIVO.Checked = False
        End If
    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        CONE.Open()
        Dim ESTADO As String = ""
        If CBACTIVO.Checked = True And CBINACTIVO.Checked = False Then
            ESTADO = "ACTIVO"
        ElseIf CBACTIVO.Checked = False And CBINACTIVO.Checked = True Then
            ESTADO = "INACTIVO"
        End If
        Try
            Dim GUARDAR As String = "INSERT INTO LOGIN (NACIONALIDAD, IDENTIDAD, USUARIO, CLAVE, ESTADO, ESTATUS, DEPARTAMENTO) " _
            & "VALUES ('" & CMBNACIONALIDAD.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTUSUARIO.Text & "','" _
            & TXTCLAVE.Text & "','" & ESTADO & "','" & TXTESTATUS.Text & "','" & TXTDEPA.Text & "')"
            Dim COMAND As SqlCommand
            COMAND = New SqlCommand(GUARDAR, CONE) 'INSERTAR REGISTRO EN TABLA
            COMAND.ExecuteNonQuery()
            MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            CONE.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONE.Close()
        End Try
    End Sub

    Private Sub BTNACEPTAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNACEPTAR.MouseEnter
        BTNACEPTAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNACEPTAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNACEPTAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNACEPTAR.MouseLeave
        BTNACEPTAR.FlatAppearance.BorderColor = Color.Silver
        BTNACEPTAR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNSALIR_MouseEnter(sender As Object, e As EventArgs) Handles BTNSALIR.MouseEnter
        BTNSALIR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNSALIR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNSALIR_MouseLeave(sender As Object, e As EventArgs) Handles BTNSALIR.MouseLeave
        BTNSALIR.FlatAppearance.BorderColor = Color.Silver
        BTNSALIR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNMODIFICAR_Click(sender As Object, e As EventArgs) Handles BTNMODIFICAR.Click
        Dim ESTADO As String = ""
        If CBACTIVO.Checked = True And CBINACTIVO.Checked = False Then
            ESTADO = "ACTIVO"
        ElseIf CBACTIVO.Checked = False And CBINACTIVO.Checked = True Then
            ESTADO = "INACTIVO"
        End If
        CONE.Open()
        Try
            '---------------------------------MODIFICAR LOGIN-------------------
            Dim LOGIN As String = "UPDATE LOGIN SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', IDENTIDAD='" _
            & TXTIDENTIDAD.Text & "', USUARIO='" & TXTUSUARIO.Text & "', CLAVE='" & TXTCLAVE.Text & "', ESTADO='" _
            & ESTADO & "', ESTATUS='" & TXTESTATUS.Text & "', DEPARTAMENTO='" & TXTDEPA.Text & "' WHERE IDENTIDAD='" _
            & TXTIDENTIDAD.Text & "'"
            Dim UNI As SqlCommand
            UNI = New SqlCommand(LOGIN, CONE)
            UNI.ExecuteNonQuery()
            CONE.Close()
            MsgBox("REGISTRO MODIFICADO CON EXITO", MsgBoxStyle.Information, "MENSAJE DEL SISTEMA")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONE.Close()
        End Try
    End Sub
End Class