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

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        If CMBBUSQUEDA.Text = "IDENTIDAD" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT NOMBRE_PACIENTE, PRIMER_APELLIDO, EDAD, " _
                                    & "CASE WHEN (DEFUNCION = '0101-01-01')" _
                                    & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO FROM UNICO " _
                                    & "WHERE IDENTIDAD='" & TXTEXPEDIENTE.Text & "'"

            Dim DATO As DataSet
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
            DATO = New DataSet
            ADAPTADOR.Fill(DATO)
            Try
                If TXTEXPEDIENTE.Text <> "" Then
                    TXTNOMBRE.Text = DATO.Tables(0).Rows(0)("NOMBRE_PACIENTE") + " " + DATO.Tables(0).Rows(0)("PRIMER_APELLIDO")
                    TXTEDAD.Text = DATO.Tables(0).Rows(0)("EDAD")
                End If
            Catch ex As Exception
                MsgBox("NO SE HA ENCONTRADO AL PACIENTE.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            End Try
            ADAPTADOR.Dispose()
            DATO.Dispose()

        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            Dim ADAPTADOR As New SqlDataAdapter
            Dim COMANDO As String = "SELECT NOMBRE_PACIENTE, PRIMER_APELLIDO, EDAD, " _
                                    & "CASE WHEN (DEFUNCION = '0101-01-01')" _
                                    & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO FROM UNICO " _
                                    & "WHERE CORRELATIVO='" & TXTEXPEDIENTE.Text & "'"

            Dim DATO As DataSet
            ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
            DATO = New DataSet
            ADAPTADOR.Fill(DATO)
            Try
                If TXTEXPEDIENTE.Text <> "" Then
                    TXTNOMBRE.Text = DATO.Tables(0).Rows(0)("NOMBRE_PACIENTE") + " " + DATO.Tables(0).Rows(0)("PRIMER_APELLIDO")
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
            TXTEXPEDIENTE.Enabled = True
            TXTEXPEDIENTE.MaxLength = 9
            If TXTEXPEDIENTE.Text.Length = 9 Then
                BTNBUSCAR.Enabled = True
            ElseIf TXTEXPEDIENTE.Text.Length < 9 Then
                BTNBUSCAR.Enabled = False
            End If
        End If
    End Sub

End Class