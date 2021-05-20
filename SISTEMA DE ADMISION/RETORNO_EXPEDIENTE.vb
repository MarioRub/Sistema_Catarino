Imports System.Data.SqlClient

Public Class RETORNO_EXPEDIENTE
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Public ESTADO As Boolean = False
    Private Sub RETORNO_EXPEDIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        CMBBUSQUEDA.Enabled = True
        TXTPACIENTE.Enabled = False

    End Sub

    Private Sub TXTEXPEDIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTEXPEDIENTE.KeyPress
        Dim IDENTIDAD As String = TXTEXPEDIENTE.Text
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTEXPEDIENTE.MaxLength = 15
            If TXTEXPEDIENTE.Text.Length = 4 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTEXPEDIENTE.Text = IDENTIDAD
                e.Handled = True
                TXTEXPEDIENTE.Select(TXTEXPEDIENTE.Text.Length, 0)
            End If
            If TXTEXPEDIENTE.Text.Length = 9 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTEXPEDIENTE.Text = IDENTIDAD
                e.Handled = True
                TXTEXPEDIENTE.Select(TXTEXPEDIENTE.Text.Length, 0)
            End If
            If TXTEXPEDIENTE.Text.Length = 15 Then
                BTNBUSCAR.Enabled = True
                BTNBUSCAR.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then
                e.Handled = False
            End If
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTEXPEDIENTE.MaxLength = 9
            If TXTEXPEDIENTE.Text.Length = 4 Then
                IDENTIDAD = IDENTIDAD + "-" + e.KeyChar
                TXTEXPEDIENTE.Text = IDENTIDAD
                e.Handled = True
                TXTEXPEDIENTE.Select(TXTEXPEDIENTE.Text.Length, 0)
            End If
            If TXTEXPEDIENTE.Text.Length = 9 Then
                BTNBUSCAR.Enabled = True
                BTNBUSCAR.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click

        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, " _
                                    & "CASE WHEN (DEFUNCION = '0101-01-01')" _
                                    & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO FROM UNICO " _
                                    & "WHERE IDENTIDAD='" & TXTEXPEDIENTE.Text & "'"

            Dim DATO As DataSet
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
            DATO = New DataSet
            ADAPTADOR.Fill(DATO)
            Try
                If TXTEXPEDIENTE.Text <> "" Then
                    TXTPACIENTE.Text = DATO.Tables(0).Rows(0)("NOMBRE_PACIENTE") + " " + DATO.Tables(0).Rows(0)("PRIMER_APELLIDO")
                End If
            Catch ex As Exception
                MsgBox("NO SE HA ENCONTRADO AL PACIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End Try
            ADAPTADOR.Dispose()
            DATO.Dispose()

        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, " _
                                    & "CASE WHEN (DEFUNCION = '0101-01-01')" _
                                    & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO FROM UNICO " _
                                    & "WHERE CORRELATIVO='" & TXTEXPEDIENTE.Text & "'"

            Dim DATO As DataSet
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
            DATO = New DataSet
            ADAPTADOR.Fill(DATO)
            Try
                If TXTEXPEDIENTE.Text <> "" Then
                    TXTPACIENTE.Text = DATO.Tables(0).Rows(0)("NOMBRE_PACIENTE") + " " + DATO.Tables(0).Rows(0)("PRIMER_APELLIDO")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ADAPTADOR.Dispose()
            DATO.Dispose()
        End If

    End Sub

    Private Sub BTNCONFIRMAR_Click(sender As Object, e As EventArgs) Handles BTNCONFIRMAR.Click

        Dim FECHA As Date = Date.Now

        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            Dim ADAPTADOR2 As New SqlDataAdapter
            Dim COMANDO2 As String = "SELECT ESTADO FROM SOLICITUD_EXPEDIENTE WHERE IDENTIDAD ='" & TXTEXPEDIENTE.Text & "'"
            Dim DATO2 As DataSet
            ADAPTADOR2 = New SqlDataAdapter(COMANDO2, CONEXION)
            DATO2 = New DataSet
            ADAPTADOR2.Fill(DATO2)

            For Each row As DataRow In DATO2.Tables(0).Rows
                If row("ESTADO").ToString() = "PRESTADO" Then
                    ESTADO = True
                    Exit For
                Else
                    ESTADO = False
                End If
            Next
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            Dim ADAPTADOR2 As New SqlDataAdapter
            Dim COMANDO2 As String = "SELECT ESTADO FROM WHERE CORRELATIVO ='" & TXTEXPEDIENTE.Text & "' AND NO = (SELECT MAX(NO) FROM SOLICITUD_EXPEDIENTE)"
            Dim DATO2 As DataSet
            ADAPTADOR2 = New SqlDataAdapter(COMANDO2, CONEXION)
            DATO2 = New DataSet
            ADAPTADOR2.Fill(DATO2)
            For Each row As DataRow In DATO2.Tables(0).Rows
                If row("ESTADO").ToString() = "PRESTADO" Then
                    ESTADO = True
                    Exit For
                Else
                    ESTADO = False
                End If
            Next
        End If

        If TXTEXPEDIENTE.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTEXPEDIENTE, "Ingrese el numero de Identidad o Correlativo")
            MsgBox("INGRESE EL NUMERO DE IDENTIDAD O CORRELATIVO A BUSCAR.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTPACIENTE.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTPACIENTE, "No hay un expediente seleccionado")
            MsgBox("SELECCIONE UN EXPEDIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf ESTADO = False Then
            MsgBox("EL EXPEDIENTE NO SE ENCUENTRA PRESTADO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        Else
            If CMBBUSQUEDA.Text = "IDENTIDAD" Then

                CONE.Open()
                Dim ESTADO As String = ""
                Try
                    Dim GUARDAR As String = "UPDATE SOLICITUD_EXPEDIENTE SET ESTADO='" & "DISPONIBLE'" & " ,COMENTARIO='" & TXTCOMENTARIO.Text & "', FECHA_ENTREGA='" & FECHA & "', HORA_ENTREGA='" & FECHA & "'  WHERE IDENTIDAD='" & TXTEXPEDIENTE.Text & "' AND NO = (SELECT MAX(NO) FROM SOLICITUD_EXPEDIENTE)"
                    Dim COMAND As SqlCommand
                    COMAND = New SqlCommand(GUARDAR, CONE) 'ACTUALIZAR REGISTRO EN TABLA
                    COMAND.ExecuteNonQuery()
                    MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                    CONE.Close()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    CONE.Close()
                End Try

            End If
            If CMBBUSQUEDA.Text = "CORRELATIVO" Then

                CONE.Open()
                Dim ESTADO As String = ""
                Try
                    Dim GUARDAR As String = "UPDATE SOLICITUD_EXPEDIENTE SET ESTADO='" & "DISPONIBLE'" & " ,COMENTARIO='" & TXTCOMENTARIO.Text & "', FECHA_ENTREGA='" & FECHA & "', HORA_ENTREGA='" & FECHA & "'  WHERE CORRELATIVO='" & TXTEXPEDIENTE.Text & "' AND NO = (SELECT MAX(NO) FROM SOLICITUD_EXPEDIENTE)"

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
        End If
    End Sub
End Class