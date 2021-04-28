Imports System.Data.SqlClient
Public Class DICTAMEN_MEDICO

    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"

    Private Sub DICTAMEN_MEDICO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBPARENTEZCO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBPARENTEZCO.Items.Add("AMBULANCIA 911")
        CMBPARENTEZCO.Items.Add("AMBULANCIA PRIVADA")
        CMBPARENTEZCO.Items.Add("ABUELA")
        CMBPARENTEZCO.Items.Add("ABUELO")
        CMBPARENTEZCO.Items.Add("AMIGA")
        CMBPARENTEZCO.Items.Add("AMIGO")
        CMBPARENTEZCO.Items.Add("BOMBERO")
        CMBPARENTEZCO.Items.Add("COMPAÑERA LABORAL")
        CMBPARENTEZCO.Items.Add("COMPAÑERO LABORAL")
        CMBPARENTEZCO.Items.Add("COPECO")
        CMBPARENTEZCO.Items.Add("CUÑADA")
        CMBPARENTEZCO.Items.Add("CUÑADO")
        CMBPARENTEZCO.Items.Add("CRUZ ROJA")
        CMBPARENTEZCO.Items.Add("DESCONOCIDO")
        CMBPARENTEZCO.Items.Add("DERECHOS HUMANOS")
        CMBPARENTEZCO.Items.Add("ESPOSA")
        CMBPARENTEZCO.Items.Add("ESPOSO")
        CMBPARENTEZCO.Items.Add("EX-ESPOSA")
        CMBPARENTEZCO.Items.Add("EX-ESPOSO")
        CMBPARENTEZCO.Items.Add("FISCALIA DE LA NIÑEZ")
        CMBPARENTEZCO.Items.Add("FISCALIA")
        CMBPARENTEZCO.Items.Add("HERMANA")
        CMBPARENTEZCO.Items.Add("HERMANO")
        CMBPARENTEZCO.Items.Add("HIJA")
        CMBPARENTEZCO.Items.Add("HIJASTRA")
        CMBPARENTEZCO.Items.Add("HIJASTRO")
        CMBPARENTEZCO.Items.Add("HIJO")
        CMBPARENTEZCO.Items.Add("JEFE LABORAL")
        CMBPARENTEZCO.Items.Add("MADRASTRA")
        CMBPARENTEZCO.Items.Add("MADRE")
        CMBPARENTEZCO.Items.Add("NIETA")
        CMBPARENTEZCO.Items.Add("NIETO")
        CMBPARENTEZCO.Items.Add("NOVIA")
        CMBPARENTEZCO.Items.Add("NOVIO")
        CMBPARENTEZCO.Items.Add("NUERA")
        CMBPARENTEZCO.Items.Add("PADRE")
        CMBPARENTEZCO.Items.Add("PADRASTRO")
        CMBPARENTEZCO.Items.Add("PAREJA")
        CMBPARENTEZCO.Items.Add("PARIENTE POLITICO")
        CMBPARENTEZCO.Items.Add("PRIMA")
        CMBPARENTEZCO.Items.Add("PRIMO")
        CMBPARENTEZCO.Items.Add("POLICIA ATIC")
        CMBPARENTEZCO.Items.Add("POLICIA DPI")
        CMBPARENTEZCO.Items.Add("POLICIA TRANSITO")
        CMBPARENTEZCO.Items.Add("RESPONSABLE")
        CMBPARENTEZCO.Items.Add("SOBRINA")
        CMBPARENTEZCO.Items.Add("SOBRINO")
        CMBPARENTEZCO.Items.Add("SUEGRA")
        CMBPARENTEZCO.Items.Add("SUEGRO")
        CMBPARENTEZCO.Items.Add("TIA")
        CMBPARENTEZCO.Items.Add("TIO")
        CMBPARENTEZCO.Items.Add("TUTOR")
        CMBPARENTEZCO.Items.Add("VECINA")
        CMBPARENTEZCO.Items.Add("VECINO")
        CMBPARENTEZCO.Items.Add("YERNO")

        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        CMBBUSQUEDA.Enabled = True

        TXTNOMBRE.Enabled = False
        TXTEDAD.Enabled = False
        DTPINGRESO.Enabled = True
        DTPEGRESO.Enabled = True
        DTPEGRESO.Value = DateTime.Now.Date
        DTPINGRESO.Value = DateTime.Now.Date

    End Sub

    Private Sub TXTEXPEDIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXTEXPEDIENTE.TextChanged

        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTEXPEDIENTE.MaxLength = 15
            If TXTEXPEDIENTE.Text.Length = 15 Then
                BTNBUSCAR.Enabled = True
            ElseIf TXTEXPEDIENTE.Text.Length < 15 Then
                BTNBUSCAR.Enabled = False
            End If
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTEXPEDIENTE.MaxLength = 9
            If TXTEXPEDIENTE.Text.Length = 9 Then
                BTNBUSCAR.Enabled = True
            ElseIf TXTEXPEDIENTE.Text.Length < 9 Then
                BTNBUSCAR.Enabled = False
            End If
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
                BTNBUSCAR.Focus()
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
                BTNBUSCAR.Focus()
            End If
            If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
            End If
        End If
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, " _
                                    & "CASE WHEN (DEFUNCION = '0101-01-01')" _
                                    & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO FROM UNICO " _
                                    & "WHERE IDENTIDAD='" & TXTEXPEDIENTE.Text & "'"

            Dim DATO As DataSet
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
            DATO = New DataSet
            ADAPTADOR.Fill(DATO)
            Try
                If TXTEXPEDIENTE.Text <> "" Then
                    TXTNOMBRE.Text = DATO.Tables(0).Rows(0)("NOMBRE_PACIENTE") + " " + DATO.Tables(0).Rows(0)("PRIMER_APELLIDO") + " " + DATO.Tables(0).Rows(0)("SEGUNDO_APELLIDO")
                    TXTEDAD.Text = DATO.Tables(0).Rows(0)("EDAD")
                End If
            Catch ex As Exception
                MsgBox("NO SE HA ENCONTRADO AL PACIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End Try
            ADAPTADOR.Dispose()
            DATO.Dispose()

        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, " _
                                    & "CASE WHEN (DEFUNCION = '0101-01-01')" _
                                    & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO FROM UNICO " _
                                    & "WHERE CORRELATIVO='" & TXTEXPEDIENTE.Text & "'"

            Dim DATO As DataSet
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
            DATO = New DataSet
            ADAPTADOR.Fill(DATO)
            Try
                If TXTEXPEDIENTE.Text <> "" Then
                    TXTNOMBRE.Text = DATO.Tables(0).Rows(0)("NOMBRE_PACIENTE") + " " + DATO.Tables(0).Rows(0)("PRIMER_APELLIDO") + " " + DATO.Tables(0).Rows(0)("SEGUNDO_APELLIDO")
                    TXTEDAD.Text = DATO.Tables(0).Rows(0)("EDAD")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ADAPTADOR.Dispose()
            DATO.Dispose()
        End If


    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged

        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTEXPEDIENTE.Text = ""
            TXTNOMBRE.Text = ""
            TXTEDAD.Text = ""
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 15
            If TXTEXPEDIENTE.Text.Length = 15 Then
                BTNBUSCAR.Enabled = True
            ElseIf TXTEXPEDIENTE.Text.Length < 15 Then
                BTNBUSCAR.Enabled = False
            End If
        End If
        If CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTEXPEDIENTE.Text = ""
            TXTNOMBRE.Text = ""
            TXTEDAD.Text = ""
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 9
            If TXTEXPEDIENTE.Text.Length = 9 Then
                BTNBUSCAR.Enabled = True
            ElseIf TXTEXPEDIENTE.Text.Length < 9 Then
                BTNBUSCAR.Enabled = False
            End If
        End If
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click

        Dim FECHA_ING As String = Format(CDate(DTPINGRESO.Value), "yyyy/MM/dd")
        Dim FECHA_EGRE As String = Format(CDate(DTPEGRESO.Value), "yyyy/MM/dd")
        Dim HOY As Date = (DateTime.Now.Date)

        If TXTPRIMERNOMBRE.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTPRIMERNOMBRE, "Escriba el Nombre.")
            MsgBox("POR FAVOR ESCRIBA EL PRIMER NOMBRE DEL SOLCITANTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTSEGUNDONOMBRE.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTSEGUNDONOMBRE, "Escriba el Nombre.")
            MsgBox("POR FAVOR ESCRIBA EL SEGUNDO NOMBRE DEL SOLCITANTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTPRIMERAPELLIDO.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTPRIMERAPELLIDO, "Escriba el Apellido.")
            MsgBox("POR FAVOR ESCRIBA EL PRIMER APELLIDO DEL SOLCITANTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTSEGUNDOAPELLIDO.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTSEGUNDOAPELLIDO, "Escriba el Apellido.")
            MsgBox("POR FAVOR ESCRIBA EL SEGUNDO APELLIDO DEL SOLCITANTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf CMBPARENTEZCO.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(CMBPARENTEZCO, "Seleccione un Parentezco.")
            MsgBox("POR FAVOR SELECCIONE EL PARENTEZCO DEL SOLCITANTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTTELEFONO.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTTELEFONO, "Escriba el Numero de Telefono.")
            MsgBox("POR FAVOR ESCRIBA EL NUMERO DE TELEFONO DEL SOLCITANTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTPROPOSITO.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTPROPOSITO, "Escriba el Proposito del Dictamen Medico.")
            MsgBox("POR FAVOR ESCRIBA EL PROPOSITO DEL DICTAMEN MEDICO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTNOMBRE.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTNOMBRE, "Seleccione un Paciente.")
            MsgBox("POR FAVOR SELECCIONE UN PACIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf FECHA_EGRE < HOY Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(DTPEGRESO, "Seleccione una Fecha Correcta.")
            MsgBox("POR FAVOR SELECCIONE UNA FECHA CORRECTA.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTSERVICIO.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTSERVICIO, "Ingrese el Nombre del Servicio.")
            MsgBox("POR FAVOR INGRESE EL NOMBRE DEL SERVICIO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTDIAGNOSTICOFINAL.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTDIAGNOSTICOFINAL, "Ingrese el Diagnostico Final.")
            MsgBox("POR FAVOR INGRESE EL DIAGNOSTICO FINAL.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTTRATAMIENTOREALIZADO.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTTRATAMIENTOREALIZADO, "Ingrese el Tratamiento Realizado.")
            MsgBox("POR FAVOR INGRESE EL TRATAMIENTO REALIZADO.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTLESIONESCURABLES.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTLESIONESCURABLES, "Ingrese las Lesiones Curables.")
            MsgBox("POR FAVOR INGRESE LAS LESIONES CURABLES.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTIMPEDIMIENTOFISICOS.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTIMPEDIMIENTOFISICOS, "Ingrese los Impedimentos Fisicos.")
            MsgBox("POR FAVOR INGRESE LOS IMPEDIMENTOS FISICOS.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTINCAPACIDADLABORAL.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTINCAPACIDADLABORAL, "Ingrese la Incapacidad Laboral.")
            MsgBox("POR FAVOR INGRESE LA INCAPACIDAD LABORAL.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTRECOMENDACIONES.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider1.SetError(TXTRECOMENDACIONES, "Ingrese las Recomendaciones.")
            MsgBox("POR FAVOR INGRESE LA LAS RECOMENDACIONES.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        Else

            If CMBBUSQUEDA.Text = "IDENTIDAD" Then

                CONE.Open()
                Dim ESTADO As String = ""
                Try
                    Dim GUARDAR As String = "INSERT INTO DICTAMEN_MEDICO (PRIMER_NOMBRE_SOLICITANTE, SEGUNDO_NOMBRE_SOLICITANTE, PRIMER_APELLIDO_SOLICITANTE, SEGUNDO_APELLIDO_SOLICITANTE, PARENTEZCO, TELEFONO_SOLICITANTE, PROPOSITO, IDENTIDAD, NOMBRE_PACIENTE, EDAD, FECHA_INGRESO, FECHA_EGRESO, SERVICIO, DIAGNOSTICO_FINAL, TRATAMIENTO_REALIZADO, LESIONES_CURABLES, IMPEDIMENTOS_FISICOS, INCAPACIDAD_LABORAL, RECOMENDACIONES) " _
                    & "VALUES ('" & TXTPRIMERNOMBRE.Text & "','" & TXTSEGUNDONOMBRE.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & CMBPARENTEZCO.Text & "','" & TXTTELEFONO.Text & "','" & TXTPROPOSITO.Text & "','" _
                    & TXTEXPEDIENTE.Text & "','" & TXTNOMBRE.Text & "','" & TXTEDAD.Text & "','" & FECHA_ING & "','" & FECHA_EGRE & "','" & TXTSERVICIO.Text & "','" & TXTDIAGNOSTICOFINAL.Text & "','" & TXTTRATAMIENTOREALIZADO.Text & "','" & TXTLESIONESCURABLES.Text & "','" & TXTIMPEDIMIENTOFISICOS.Text & "','" & TXTINCAPACIDADLABORAL.Text & "','" & TXTRECOMENDACIONES.Text & "')"
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
                    Dim GUARDAR As String = "INSERT INTO DICTAMEN_MEDICO (PRIMER_NOMBRE_SOLICITANTE, SEGUNDO_NOMBRE_SOLICITANTE, PRIMER_APELLIDO_SOLICITANTE, SEGUNDO_APELLIDO_SOLICITANTE, PARENTEZCO, TELEFONO_SOLICITANTE, PROPOSITO, CORRELATIVO, NOMBRE_PACIENTE, EDAD, FECHA_INGRESO, FECHA_EGRESO, SERVICIO, DIAGNOSTICO_FINAL, TRATAMIENTO_REALIZADO, LESIONES_CURABLES, IMPEDIMENTOS_FISICOS, INCAPACIDAD_LABORAL, RECOMENDACIONES) " _
                    & "VALUES ('" & TXTPRIMERNOMBRE.Text & "','" & TXTSEGUNDONOMBRE.Text & "','" & TXTPRIMERAPELLIDO.Text & "','" & TXTSEGUNDOAPELLIDO.Text & "','" & CMBPARENTEZCO.Text & "','" & TXTTELEFONO.Text & "','" & TXTPROPOSITO.Text & "','" _
                    & TXTEXPEDIENTE.Text & "','" & TXTNOMBRE.Text & "','" & TXTEDAD.Text & "','" & FECHA_ING & "','" & FECHA_EGRE & "','" & TXTSERVICIO.Text & "','" & TXTDIAGNOSTICOFINAL.Text & "','" & TXTTRATAMIENTOREALIZADO.Text & "','" & TXTLESIONESCURABLES.Text & "','" & TXTIMPEDIMIENTOFISICOS.Text & "','" & TXTINCAPACIDADLABORAL.Text & "','" & TXTRECOMENDACIONES.Text & "')"
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

    Private Sub TXTPRIMERNOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRIMERNOMBRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub TXTSEGUNDONOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEGUNDONOMBRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub TXTPRIMERAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRIMERAPELLIDO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub TXTSEGUNDOAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSEGUNDOAPELLIDO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.Close()
    End Sub
End Class