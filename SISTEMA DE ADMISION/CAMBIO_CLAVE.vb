Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CAMBIO_CLAVE
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NACIONALIDAD, IDENTIDAD, CLAVE, USUARIO, CLAVE, ESTADO, ESTATUS, DEPARTAMENTO " _
                                & "FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO)
        If DATO.Tables(0).Rows.Count = 0 Then
            MsgBox("EL USUARIO NO EXISTE")
            TXTIDENTIDAD.Clear()
            TXTUSUARIO.Clear()
            TXTACTUAL.Clear()
            TXTNUEVA.Clear()
            TXTIDENTIDAD.Focus()
        ElseIf DATO.Tables(0).Rows.Count > 0 Then
                Try
                    If TXTIDENTIDAD.Text <> "" Then
                    TXTUSUARIO.Text = DATO.Tables(0).Rows(0)("USUARIO")
                    TXTACTUAL.Text = DATO.Tables(0).Rows(0)("CLAVE")
                    TXTACTUAL.Enabled = True
                    TXTNUEVA.Enabled = True
                    BTNACEPTAR.Enabled = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
        End If
    End Sub

    Private Sub CAMBIO_CLAVE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
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
        TXTACTUAL.Text = ""
        TXTNUEVA.Text = ""
    End Sub

    Private Sub TXTACTUAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTACTUAL.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTACTUAL_TextChanged(sender As Object, e As EventArgs) Handles TXTACTUAL.TextChanged

    End Sub

    Private Sub TXTNUEVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNUEVA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTNUEVA_TextChanged(sender As Object, e As EventArgs) Handles TXTNUEVA.TextChanged

    End Sub

    Private Sub TXTUSUARIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTUSUARIO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTUSUARIO_TextChanged(sender As Object, e As EventArgs) Handles TXTUSUARIO.TextChanged

    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        If (TXTACTUAL.Text <> "" And TXTNUEVA.Text <> "") And (TXTACTUAL.Text <> TXTNUEVA.Text) Then
            CONE.Open()
            Try
                '---------------------------------MODIFICAR LOGIN-------------------
                Dim LOGIN As String = "UPDATE LOGIN SET CLAVE='" & TXTNUEVA.Text & "' WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
                Dim UNI As SqlCommand
                UNI = New SqlCommand(LOGIN, CONE)
                UNI.ExecuteNonQuery()
                CONE.Close()
                MsgBox("CLAVE MODIFICADA CON EXITO", MsgBoxStyle.Information, "MENSAJE DEL SISTEMA")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                CONE.Close()
            End Try
        End If
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

    Private Sub BTNBUSCAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNBUSCAR.MouseEnter
        BTNBUSCAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNBUSCAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNBUSCAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNBUSCAR.MouseLeave
        BTNBUSCAR.FlatAppearance.BorderColor = Color.Silver
        BTNBUSCAR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.Clear()
            TXTIDENTIDAD.Enabled = True
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Clear()
            TXTIDENTIDAD.Enabled = True
        End If
    End Sub
End Class