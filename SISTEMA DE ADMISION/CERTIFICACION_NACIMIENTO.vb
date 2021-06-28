Imports System.Data.SqlClient

Public Class CERTIFICACION_NACIMIENTO

    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"


    Private Sub CERTIFICACION_NACIMIENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBSEXO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBSEXO.Items.Add("MASCULINO")
        CMBSEXO.Items.Add("FEMENINO")
        DTPENTREGAESTIMADA.Enabled = True
        DTPPARTO.Enabled = True
    End Sub

    Private Sub TXTNOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNOMBRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub TXTIDSOLICITANTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDSOLICITANTE.KeyPress
        Dim IDENTIDAD As String = TXTIDSOLICITANTE.Text

        TXTIDSOLICITANTE.MaxLength = 15
        If TXTIDSOLICITANTE.Text.Length = 4 Then
            IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
            TXTIDSOLICITANTE.Text = IDENTIDAD
            e.Handled = True
            TXTIDSOLICITANTE.Select(TXTIDSOLICITANTE.Text.Length, 0)
        End If
        If TXTIDSOLICITANTE.Text.Length = 9 Then
            IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
            TXTIDSOLICITANTE.Text = IDENTIDAD
            e.Handled = True
            TXTIDSOLICITANTE.Select(TXTIDSOLICITANTE.Text.Length, 0)
        End If
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

    End Sub

    Private Sub TXTIDMAMA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDMAMA.KeyPress
        Dim IDENTIDAD As String = TXTIDMAMA.Text

        TXTIDMAMA.MaxLength = 15
        If TXTIDMAMA.Text.Length = 4 Then
            IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
            TXTIDMAMA.Text = IDENTIDAD
            e.Handled = True
            TXTIDMAMA.Select(TXTIDMAMA.Text.Length, 0)
        End If
        If TXTIDMAMA.Text.Length = 9 Then
            IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
            TXTIDMAMA.Text = IDENTIDAD
            e.Handled = True
            TXTIDMAMA.Select(TXTIDMAMA.Text.Length, 0)
        End If
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

    End Sub

    Private Sub TXTTELEFONO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTELEFONO.KeyPress
        Dim TEXTO As String = TXTTELEFONO.Text
        TXTTELEFONO.MaxLength = 9
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

        If TXTTELEFONO.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTTELEFONO.Text = TEXTO
            e.Handled = True
            TXTTELEFONO.Select(TXTTELEFONO.Text.Length, 0)
        End If
    End Sub

    Private Sub BTNCONFIRMAR_Click(sender As Object, e As EventArgs) Handles BTNCONFIRMAR.Click
        Dim FECHA As Date = Format(CDate(Date.Now), "yyyy/MM/dd")
        Dim FECHA_ACTUAL As Date = Date.Now
        Dim DTPPARTFOFECHA As Date = Format(CDate(DTPPARTO.Value), "yyyy/MM/dd")
        Dim DTPENTREGAESTIMADAFECHA As Date = Format(CDate(DTPENTREGAESTIMADA.Value), "yyyy/MM/dd")

        If TXTNOMBRE.Text = "" Then
            ErrorProvider1.Clear()
            MsgBox("POR FAVOR INGRESE EL NOMBRE DEL SOLICITANTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ErrorProvider1.SetError(TXTNOMBRE, "Ingrese el Nombre del Solicitante.")
        ElseIf TXTIDSOLICITANTE.Text = "" Then
            ErrorProvider1.Clear()
            MsgBox("POR FAVOR INGRESE EL ID DEL SOLICITANTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ErrorProvider1.SetError(TXTIDSOLICITANTE, "Ingrese el ID del Solicitante.")
        ElseIf TXTTELEFONO.Text = "" Then
            ErrorProvider1.Clear()
            MsgBox("POR FAVOR INGRESE EL TELEFONO DEL SOLICITANTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ErrorProvider1.SetError(TXTTELEFONO, "Ingrese el Telefono del Solicitante.")
        ElseIf TXTIDMAMA.Text = "" Then
            ErrorProvider1.Clear()
            MsgBox("POR FAVOR INGRESE EL ID DE LA MADRE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ErrorProvider1.SetError(TXTIDMAMA, "Ingrese el ID de la Madre.")
        ElseIf TXTGESTAS.Text = "" Then
            ErrorProvider1.Clear()
            MsgBox("POR FAVOR INGRESE EL NUMERO DE GESTAS DE LA MADRE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ErrorProvider1.SetError(TXTGESTAS, "Ingrese el Numero de Gestas de la Madre.")
        ElseIf CMBSEXO.Text = "" Then
            ErrorProvider1.Clear()
            MsgBox("POR FAVOR SELECCIONE EL SEXO DEL BEBE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ErrorProvider1.SetError(CMBSEXO, "SeleccionE el Sexo del Bebe.")
        ElseIf DTPPARTFOFECHA > FECHA Then
            ErrorProvider1.Clear()
            MsgBox("POR FAVOR SELECCIONE UNA FECHA CORRECTA.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ErrorProvider1.SetError(DTPPARTO, "La Fecha seleccionada es mayor que la actual.")
        ElseIf DTPENTREGAESTIMADA.Value.Date < FECHA Then
            ErrorProvider1.Clear()
            MsgBox("POR FAVOR SELECCIONE UNA FECHA CORRECTA.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ErrorProvider1.SetError(DTPENTREGAESTIMADA, "La Fecha seleccionada es menor que la actual.")
        Else
            CONE.Open()
            Try
                Dim GUARDAR As String = "INSERT INTO CERTIFICACION_NACIMIENTO (NOMBRE_SOLICITANTE, IDENTIDAD_SOLICITANTE, TELEFONO_SOLICITANTE, IDENTIDAD_MAMA, NUMERO_GESTAS, SEXO_BEBE, FECHA_PARTO, FECHA_SOLICITUD, FECHA_CERTIFICACION_ESTIMADA, ESTADO) " _
        & "VALUES ('" & TXTNOMBRE.Text & "','" & TXTIDSOLICITANTE.Text & "','" & TXTTELEFONO.Text & "','" _
        & TXTIDMAMA.Text & "','" & TXTGESTAS.Text & "','" & CMBSEXO.Text & "','" & DTPPARTO.Value.Date & "','" & FECHA_ACTUAL & "','" & DTPENTREGAESTIMADA.Value.Date & "','" & "EN ESPERA" & "')"
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
        End If
    End Sub

    Private Sub TXTGESTAS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTGESTAS.KeyPress
        Dim TEXTO As String = TXTGESTAS.Text
        TXTGESTAS.MaxLength = 3
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

    End Sub
End Class