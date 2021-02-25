Imports System.Data.SqlClient

Public Class SOLICITUD_EXPEDIENTEARCHIVO

    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub SOLICITUD_EXPEDIENTEARCHIVO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTPACIENTE.Enabled = False
        CMBPROCESOS.DropDownStyle = ComboBoxStyle.DropDownList
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBPROCESOS.Items.Add("A")
        CMBPROCESOS.Items.Add("B")
        CMBPROCESOS.Items.Add("C")
        CMBESPECIALIDAD.Items.Add("Especialidad 1")
        CMBESPECIALIDAD.Items.Add("Especialidad 2")
        CMBESPECIALIDAD.Items.Add("Especialidad 3")

    End Sub

    Private Sub TXTEXPEDIENTE_TextChanged(sender As Object, e As EventArgs) Handles TXTEXPEDIENTE.TextChanged

        TXTEXPEDIENTE.MaxLength = 15
        If TXTEXPEDIENTE.Text.Length = 15 Then
            BTNEXPEDIENTE.Enabled = True
        ElseIf TXTEXPEDIENTE.Text.Length < 15 Then
            BTNEXPEDIENTE.Enabled = False

            'ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            '    TXTIDENTIDAD.MaxLength = 30
            '    TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
            '    If TXTIDENTIDAD.Text.Length >= 6 Then
            '        BTNBUSCAR.Enabled = True
            '    ElseIf TXTIDENTIDAD.Text.Length <= 5 Then
            '        BTNBUSCAR.Enabled = False
            '    End If
        End If
    End Sub

    Private Sub BTNMEDICO_Click(sender As Object, e As EventArgs) Handles BTNMEDICO.Click

    End Sub

    Private Sub BTNEXPEDIENTE_Click(sender As Object, e As EventArgs) Handles BTNEXPEDIENTE.Click
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, NACIONALIDAD, PAIS, TIPO, NOMBRE_PACIENTE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, EDAD, TIPO_EDAD, " _
                                & "CORRELATIVO, IDENTIDAD, COLONIA, CASA, DEPARTAMENTO, MUNICIPIO, TELEFONO1, TELEFONO2, SEXO, " _
                                & "NOMBRE_PADRE, NOMBRE_MADRE, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO, " _
                                & "FECHA_NACIMIENTO, DIAGNOSTICO, ESTADO_CIVIL, OCUPACION, CASE WHEN (DEFUNCION = '0101-01-01')" _
                                & "THEN NULL WHEN (DEFUNCION <> '0101-01-01') THEN DEFUNCION END AS MUERTO FROM UNICO " _
                                & "WHERE IDENTIDAD='" & TXTEXPEDIENTE.Text & "'"

        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO)
        Try
            If TXTEXPEDIENTE.Text <> "" Then
                TXTPACIENTE.Text = DATO.Tables(0).Rows(0)("NOMBRE_PACIENTE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ADAPTADOR.Dispose()
        DATO.Dispose()
    End Sub

    Private Sub TXTEXPEDIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTEXPEDIENTE.KeyPress
        Dim IDENTIDAD As String = TXTEXPEDIENTE.Text
        'If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
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
        '    If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
        '        e.Handled = True
        '    End If
        '    If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
        '        e.Handled = False      'PERMITE ESCRITURA
        '    End If
        'ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
        '    TXTIDENTIDAD.MaxLength = 30
        'End If
    End Sub
End Class