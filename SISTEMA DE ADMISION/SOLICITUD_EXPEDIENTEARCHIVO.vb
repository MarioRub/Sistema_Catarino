Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class SOLICITUD_EXPEDIENTEARCHIVO

    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Public ESTADO As Boolean = False
    Private Sub SOLICITUD_EXPEDIENTEARCHIVO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBCLASIFICACION.DropDownStyle = ComboBoxStyle.DropDownList
        CMBCLASIFICACION.Items.Add("NORMAL")
        CMBCLASIFICACION.Items.Add("RN#1")
        CMBCLASIFICACION.Items.Add("RN#2")
        CMBCLASIFICACION.Items.Add("RN#3")
        CMBCLASIFICACION.Items.Add("HIJO_1")
        CMBCLASIFICACION.Items.Add("HIJO_2")
        CMBCLASIFICACION.Items.Add("HIJO_3")
        CMBCLASIFICACION.Items.Add("OBITO_1")
        CMBCLASIFICACION.Items.Add("OBITO_2")
        CMBCLASIFICACION.Items.Add("OBITO_3")
        CMBCLASIFICACION.Items.Add("RN_GEMELO_1")
        CMBCLASIFICACION.Items.Add("RN_GEMELO_2")
        CMBCLASIFICACION.Items.Add("RN_GEMELO_3")
        TXTPACIENTE.Enabled = False
        CMBMEDICOS.DropDownStyle = ComboBoxStyle.DropDownList
        CMBEMPLEADOS.DropDownStyle = ComboBoxStyle.DropDownList
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBCONSULTORIO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBEMPLEADOS.Enabled = False
        CMBMEDICOS.Enabled = False
        CMBBUSQUEDA.Enabled = True
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")

        If CMBBUSQUEDA.Text = "" Then
            TXTEXPEDIENTE.Enabled = False

        End If

        Dim DS As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES ORDER BY ESPECIALIDAD ASC"
        Dim DA As New SqlDataAdapter(DS, CONEXION)
        Dim CMB As New DataSet
        DA.Fill(CMB)
        If CMB.Tables(0).Rows.Count > 0 Then
            With CMBESPECIALIDAD
                .DataSource = CMB.Tables(0)
                .DisplayMember = "ESPECIALIDAD"
                TXTCOD_ESPECIALIDAD.Text = CMB.Tables(0).Rows(0)("CODIGO_ESPECIALIDAD")
            End With
        End If



    End Sub

    Private Sub TXTEXPEDIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXTEXPEDIENTE.TextChanged

        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTEXPEDIENTE.MaxLength = 15
            If TXTEXPEDIENTE.Text.Length = 15 Then
                BTNEXPEDIENTE.Enabled = True
            ElseIf TXTEXPEDIENTE.Text.Length < 15 Then
                BTNEXPEDIENTE.Enabled = False
            End If
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTEXPEDIENTE.MaxLength = 9
            If TXTEXPEDIENTE.Text.Length = 9 Then
                BTNEXPEDIENTE.Enabled = True
            ElseIf TXTEXPEDIENTE.Text.Length < 9 Then
                BTNEXPEDIENTE.Enabled = False
            End If
        End If

    End Sub

    Private Sub BTNMEDICO_Click(sender As Object, e As EventArgs) Handles BTNMEDICO.Click
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NOMBRE " _
        & " FROM MEDICO WHERE NOMBRE LIKE '" _
        & "%" & TXTMEDICO.Text & "%" & "'"

        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO)
        Try
            If DATO.Tables(0).Rows.Count = 0 Then
                MsgBox("NO SE HA ENCONTRADO AL MEDICO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ElseIf TXTMEDICO.Text <> "" Then
                With CMBMEDICOS
                    .DataSource = DATO.Tables(0)
                    .DisplayMember = "NOMBRE"
                End With
                CMBMEDICOS.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("NO SE HA ENCONTRADO AL MEDICO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        End Try
        ADAPTADOR.Dispose()
        DATO.Dispose()
    End Sub

    Private Sub BTNEXPEDIENTE_Click(sender As Object, e As EventArgs) Handles BTNEXPEDIENTE.Click

        If CMBBUSQUEDA.Text = "IDENTIDAD" Then

            Dim ADAPTADOR2 As New SqlDataAdapter
            Dim COMANDO2 As String = "SELECT ESTADO FROM SOLICITUD_EXPEDIENTE WHERE IDENTIDAD ='" & TXTEXPEDIENTE.Text & "'"
            Dim DATO2 As DataSet
            ADAPTADOR2 = New SqlDataAdapter(COMANDO2, CONEXION)
            DATO2 = New DataSet
            ADAPTADOR2.Fill(DATO2)

            If DATO2.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In DATO2.Tables(0).Rows
                    If row("ESTADO").ToString() = "PRESTADO" Then
                        Exit For
                    End If
                Next
            Else
                ESTADO = False
            End If

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
                TXTEXPEDIENTE.Text = ""
                MsgBox("NO SE HA ENCONTRADO AL PACIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End Try
            ADAPTADOR.Dispose()
            DATO.Dispose()

        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then

            Dim ADAPTADOR2 As New SqlDataAdapter
            Dim COMANDO2 As String = "SELECT ESTADO FROM SOLICITUD_EXPEDIENTE WHERE CORRELATIVO ='" & TXTEXPEDIENTE.Text & "'"
            Dim DATO2 As DataSet
            ADAPTADOR2 = New SqlDataAdapter(COMANDO2, CONEXION)
            DATO2 = New DataSet
            ADAPTADOR2.Fill(DATO2)

            If DATO2.Tables(0).Rows.Count() = 0 Then
                ESTADO = False
            Else
                For Each row As DataRow In DATO2.Tables(0).Rows
                    If row("ESTADO").ToString() = "PRESTADO" Then
                        ESTADO = True
                        Exit For
                    End If
                Next
            End If

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
                TXTEXPEDIENTE.Text = ""
                MsgBox("NO SE HA ENCONTRADO AL PACIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End Try
            ADAPTADOR.Dispose()
            DATO.Dispose()
        End If


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
                BTNEXPEDIENTE.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
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
                BTNEXPEDIENTE.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
            End If
        End If
    End Sub

    Private Sub CMBCLASIFICACION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBCLASIFICACION.SelectedIndexChanged
        CMBCLASIFICACION.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBCLASIFICACION.Text = "NORMAL" Then
            LBTIPO.Text = "NORMAL = POSEE IDENTIDAD"
        ElseIf CMBCLASIFICACION.Text = "RN#1" Or CMBCLASIFICACION.Text = "RN#2" Or
            CMBCLASIFICACION.Text = "RN#3" Then
            LBTIPO.Text = "RECIEN NACIDO"
        ElseIf CMBCLASIFICACION.Text = "OBITO_1" Or CMBCLASIFICACION.Text = "OBITO_2" Or CMBCLASIFICACION.Text = "OBITO_3" Then
            LBTIPO.Text = "OBITO"
        ElseIf CMBCLASIFICACION.Text = "HIJO_1" Or CMBCLASIFICACION.Text = "HIJO_2" Or CMBCLASIFICACION.Text = "HIJO_3" Then
            LBTIPO.Text = "HIJO"
        ElseIf CMBCLASIFICACION.Text = "RN_GEMELO_1" Or CMBCLASIFICACION.Text = "RN_GEMELO_2" Or CMBCLASIFICACION.Text = "RN_GEMELO_3" Then
            LBTIPO.Text = "RECIEN NACIDO GEMELO"
        End If
    End Sub

    Private Sub CMBESPECIALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBESPECIALIDAD.SelectedIndexChanged
        '----------CARGAR COMBOBOX ESPECIALIDAD------------
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES WHERE ESPECIALIDAD ='" & CMBESPECIALIDAD.Text & "' ORDER BY ESPECIALIDAD ASC"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "ESPECIALIDADES")
        TXTCOD_ESPECIALIDAD.Text = CMBESPECIALIDAD.SelectedItem("CODIGO_ESPECIALIDAD").ToString
        '---------------------------------------------------------------------------------------
        Dim ADAPTA As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_ESPECIALIDAD, CONSULTORIO FROM CONSULTORIOS WHERE CODIGO_ESPECIALIDAD ='" & TXTCOD_ESPECIALIDAD.Text & "' ORDER BY CONSULTORIO ASC"
        Dim DAT As DataSet
        ADAPTA = New SqlDataAdapter(COMAND, CONEXION)
        DAT = New DataSet
        ADAPTA.Fill(DAT, "CONSULTORIOS")
        With CMBCONSULTORIO
            .DataSource = DAT.Tables(0)
            .DisplayMember = "CONSULTORIO"
        End With
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged

        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTPACIENTE.Text = ""
            TXTEXPEDIENTE.Text = ""
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 15
            If TXTEXPEDIENTE.Text.Length = 15 Then
                BTNEXPEDIENTE.Enabled = True
            ElseIf TXTEXPEDIENTE.Text.Length < 15 Then
                BTNEXPEDIENTE.Enabled = False
            End If
        End If
        If CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTPACIENTE.Text = ""
            TXTEXPEDIENTE.Text = ""
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 9
            If TXTEXPEDIENTE.Text.Length = 9 Then
                BTNEXPEDIENTE.Enabled = True
            ElseIf TXTEXPEDIENTE.Text.Length < 9 Then
                BTNEXPEDIENTE.Enabled = False
            End If
        End If
    End Sub

    Private Sub BTNCONFIRMAR_Click(sender As Object, e As EventArgs) Handles BTNCONFIRMAR.Click

        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO, IDENTIDAD FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO)

        If CMBESPECIALIDAD.Text = "" Then
            MsgBox("POR FAVOR SELECCIONE UNA ESPECIALIDAD.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf CMBMEDICOS.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(CMBMEDICOS, "Seleccione una Medico.")
            MsgBox("POR FAVOR SELECCIONE UN MEDICO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf CMBEMPLEADOS.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(CMBEMPLEADOS, "Seleccione un Empleado.")
            MsgBox("INGRESE EL NOMBRE DEL EMPLEADO QUE RETIRA.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTPACIENTE.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTPACIENTE, "Seleccione un Paciente.")
            MsgBox("INGRESE LA IDENTIDAD O CORRELATIVO DE UN PACIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf CMBCLASIFICACION.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(CMBCLASIFICACION, "Seleccione una Clasificacion.")
            MsgBox("SELECCIONE UNA CLASIFICACION PARA LA IDENTIDAD DEL PACIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf ESTADO = True Then
            ErrorProvider1.Clear()
            MsgBox("EL EXPEDIENTE SE ENCUENTRA PRESTADO ACTUALMENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf ESTADO = False Then
            Dim FECHA As Date = Date.Now
            If CMBBUSQUEDA.Text = "IDENTIDAD" Then

                CONE.Open()
                Dim ESTADO As String = ""
                Try
                    Dim GUARDAR As String = "INSERT INTO SOLICITUD_EXPEDIENTE (IDENTIDAD, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, NOMBRE_EMPLEADO, IDENTIDAD_USUARIO, USUARIO, ESTADO, TIPO, FECHA_SALIDA, HORA_SALIDA) " _
                & "VALUES ('" & TXTEXPEDIENTE.Text & "','" & TXTPACIENTE.Text & "','" & CMBMEDICOS.Text & "','" _
                & CMBESPECIALIDAD.Text & "','" & CMBCONSULTORIO.Text & "','" & CMBEMPLEADOS.Text & "','" & DATO.Tables(0).Rows(0)("IDENTIDAD") & "','" & DATO.Tables(0).Rows(0)("USUARIO") & "','" & "PRESTADO" & "','" & CMBCLASIFICACION.Text & "','" & FECHA & "','" & FECHA & "')"
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
            If CMBBUSQUEDA.Text = "CORRELATIVO" Then

                CONE.Open()
                Dim ESTADO As String = ""
                Try
                    Dim GUARDAR As String = "INSERT INTO SOLICITUD_EXPEDIENTE (CORRELATIVO, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, NOMBRE_EMPLEADO, IDENTIDAD_USUARIO, USUARIO, ESTADO, TIPO, FECHA_SALIDA, HORA_SALIDA) " _
                    & "VALUES ('" & TXTEXPEDIENTE.Text & "','" & TXTPACIENTE.Text & "','" & CMBMEDICOS.Text & "','" _
                    & CMBESPECIALIDAD.Text & "','" & CMBCONSULTORIO.Text & "','" & CMBEMPLEADOS.Text & "','" & DATO.Tables(0).Rows(0)("IDENTIDAD") & "','" & DATO.Tables(0).Rows(0)("USUARIO") & "','" & "PRESTADO" & "','" & CMBCLASIFICACION.Text & "','" & FECHA & "','" & FECHA & "')"
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

    Private Sub TXTNOMBREEMPLEADO_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub BTNEMPLEADO_Click(sender As Object, e As EventArgs) Handles BTNEMPLEADO.Click
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO " _
        & " FROM LOGIN WHERE USUARIO LIKE '" _
        & "%" & TXTEMPLEADO.Text & "%" & "'"

        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO)
        Try
            If DATO.Tables(0).Rows.Count = 0 Then
                MsgBox("NO SE HA ENCONTRADO AL EMPLEADO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            ElseIf TXTEMPLEADO.Text <> "" Then
                With CMBEMPLEADOS
                    .DataSource = DATO.Tables(0)
                    .DisplayMember = "USUARIO"
                End With
                CMBEMPLEADOS.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("NO SE HA ENCONTRADO AL EMPLEADO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        End Try
        ADAPTADOR.Dispose()
        DATO.Dispose()
    End Sub

End Class