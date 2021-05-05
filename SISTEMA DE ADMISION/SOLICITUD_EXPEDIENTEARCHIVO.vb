Imports System.Data.SqlClient

Public Class SOLICITUD_EXPEDIENTEARCHIVO

    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub SOLICITUD_EXPEDIENTEARCHIVO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTPACIENTE.Enabled = False
        TXTNOMBREMEDICO.Enabled = False
        CMBPROCESOS.DropDownStyle = ComboBoxStyle.DropDownList
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBCONSULTORIO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.Enabled = True
        CMBPROCESOS.Items.Add("A")
        CMBPROCESOS.Items.Add("B")
        CMBPROCESOS.Items.Add("C")
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
            If TXTMEDICO.Text <> "" Then
                TXTNOMBREMEDICO.Text = DATO.Tables(0).Rows(0)("NOMBRE")
            End If
        Catch ex As Exception
            MsgBox("NO SE HA ENCONTRADO AL MEDICO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        End Try
        ADAPTADOR.Dispose()
        DATO.Dispose()
    End Sub

    Private Sub BTNEXPEDIENTE_Click(sender As Object, e As EventArgs) Handles BTNEXPEDIENTE.Click
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
        If CMBPROCESOS.Text = "" Then
            MsgBox("POR FAVOR SELECCIONE UN PROCESO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf CMBESPECIALIDAD.Text = "" Then
            MsgBox("POR FAVOR SELECCIONE UNA ESPECIALIDAD.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTNOMBREMEDICO.Text = "" Then
            MsgBox("POR FAVOR SELECCIONE UN MEDICO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTNOMBREEMPLEADO.Text = "" Then
            MsgBox("INGRESE EL NOMBRE DEL EMPLEADO QUE RETIRA.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTPACIENTE.Text = "" Then
            MsgBox("INGRESE EL NOMBRE DEL PACIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        End If

        Dim FECHA As Date = Date.Now
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then

            CONE.Open()
            Dim ESTADO As String = ""
            Try
                Dim GUARDAR As String = "INSERT INTO SOLICITUD_EXPEDIENTE (IDENTIDAD, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, PROCESO, NOMBRE_EMPLEADO, IDENTIDAD_USUARIO, FECHA_SALIDA) " _
                & "VALUES ('" & TXTEXPEDIENTE.Text & "','" & TXTPACIENTE.Text & "','" & TXTNOMBREMEDICO.Text & "','" _
                & CMBESPECIALIDAD.Text & "','" & CMBCONSULTORIO.Text & "','" & CMBPROCESOS.Text & "','" & TXTNOMBREEMPLEADO.Text & "','" & TXTEXPEDIENTE.Text & "','" & FECHA & "')"
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
                Dim GUARDAR As String = "INSERT INTO SOLICITUD_EXPEDIENTE (CORRELATIVO, NOMBRE_PACIENTE, MEDICO, ESPECIALIDAD, CONSULTORIO, PROCESO, NOMBRE_EMPLEADO, IDENTIDAD_USUARIO, FECHA_SALIDA) " _
                & "VALUES ('" & TXTEXPEDIENTE.Text & "','" & TXTPACIENTE.Text & "','" & TXTNOMBREMEDICO.Text & "','" _
                & CMBESPECIALIDAD.Text & "','" & CMBCONSULTORIO.Text & "','" & CMBPROCESOS.Text & "','" & TXTNOMBREEMPLEADO.Text & "','" & TXTEXPEDIENTE.Text & "','" & FECHA & "')"
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

End Class