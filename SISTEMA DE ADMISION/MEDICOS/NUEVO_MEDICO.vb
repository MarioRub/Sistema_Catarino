Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class NUEVO_MEDICO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub NUEVO_MEDICO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBCONSULTORIO.DropDownStyle = ComboBoxStyle.DropDownList
        TXTCOD_ESPECIALIDAD.Text = ""
        '----------CARGAR COMBOBOX ESPECIALIDAD------------
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
        '--------------------------------------------------------
        TXTMEDICO.Enabled = False
        TXTIDENTIDAD.Enabled = True
        BTNIDENTIDAD.Enabled = False
        CMBESPECIALIDAD.Enabled = False
        CMBCONSULTORIO.Enabled = False
        TXTHORARIO.Enabled = False
        CBLUNES.Checked = False : CBLUNES.Enabled = False
        CBMARTES.Checked = False : CBMARTES.Enabled = False
        CBMIERCOLES.Checked = False : CBMIERCOLES.Enabled = False
        CBJUEVES.Checked = False : CBJUEVES.Enabled = False
        CBVIERNES.Checked = False : CBVIERNES.Enabled = False
        CBACTIVO.Checked = False : CBACTIVO.Enabled = False
        CBINACTIVO.Checked = False : CBINACTIVO.Enabled = False
        BTNMODIFICAR.Visible = False : BTNACEPTAR.Visible = False
    End Sub
    Sub ESPECIALIDAD()
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        TXTCOD_ESPECIALIDAD.Text = ""
        Dim DS As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES ORDER BY ESPECIALIDAD ASC"
        Dim DA As New SqlDataAdapter(DS, CONEXION)
        Dim CMB As New DataSet
        DA.Fill(CMB)
        If CMB.Tables(0).Rows.Count > 0 Then
            With CMBESPECIALIDAD
                .DataSource = CMB.Tables(0)
                .DisplayMember = "ESPECIALIDAD"
                TXTCOD_ESPECIALIDAD.Text = CMBESPECIALIDAD.SelectedItem("CODIGO_ESPECIALIDAD").ToString
                '--------------------------------------------------------
            End With
        End If
    End Sub
    Private Sub BTNIDENTIDAD_Click(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.Click
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT NO, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, HORARIO, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO,ESTADO, CUPO FROM MEDICO WHERE IDENTIDAD ='" & Me.TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "MEDICO")
        Try
            TXTMEDICO.Text = DATO.Tables(0).Rows(0)("NOMBRE")
            TXTTARJETA.Text = DATO.Tables(0).Rows(0)("TARJETA")
            TXTHORARIO.Text = DATO.Tables(0).Rows(0)("HORARIO")
            CMBESPECIALIDAD.Text = DATO.Tables(0).Rows(0)("ESPECIALIDAD")
            CMBCONSULTORIO.Text = DATO.Tables(0).Rows(0)("CONSULTORIO")
            TXTCOMENTARIO.Text = DATO.Tables(0).Rows(0)("COMENTARIO")
            TXTCUPO.Text = DATO.Tables(0).Rows(0)("CUPO")
            If DATO.Tables(0).Rows(0)("LUNES") = "SI" Then
                CBLUNES.CheckState = CheckState.Checked
            Else
                CBLUNES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("MARTES") = "SI" Then
                CBMARTES.CheckState = CheckState.Checked
            Else
                CBMARTES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("MIERCOLES") = "SI" Then
                CBMIERCOLES.CheckState = CheckState.Checked
            Else
                CBMIERCOLES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("JUEVES") = "SI" Then
                CBJUEVES.CheckState = CheckState.Checked
            Else
                CBJUEVES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("VIERNES") = "SI" Then
                CBVIERNES.CheckState = CheckState.Checked
            Else
                CBVIERNES.CheckState = CheckState.Unchecked
            End If
            If DATO.Tables(0).Rows(0)("ESTADO") = "ACTIVO" Then
                CBACTIVO.CheckState = CheckState.Checked
            ElseIf DATO.Tables(0).Rows(0)("ESTADO") = "INACTIVO" Then
                CBINACTIVO.CheckState = CheckState.Checked
            End If
            TXTMEDICO.Enabled = True
            TXTHORARIO.Enabled = True
            TXTCOMENTARIO.Enabled = True
            TXTTARJETA.Enabled = True
            CMBESPECIALIDAD.Enabled = True
            CMBCONSULTORIO.Enabled = True
            CBLUNES.Enabled = True
            CBMARTES.Enabled = True
            CBMIERCOLES.Enabled = True
            CBJUEVES.Enabled = True
            CBVIERNES.Enabled = True
            CBACTIVO.Enabled = True
            CBINACTIVO.Enabled = True
            TXTCUPO.Enabled = True
            BTNMODIFICAR.Visible = True : BTNACEPTAR.Visible = False
            TXTIDENTIDAD.Focus()
        Catch ex As Exception
            'MsgBox(ex.Message)
            TXTMEDICO.Enabled = True
            TXTHORARIO.Enabled = True
            TXTCOMENTARIO.Enabled = True
            TXTTARJETA.Enabled = True
            CMBESPECIALIDAD.Enabled = True
            CMBCONSULTORIO.Enabled = True
            CBLUNES.Enabled = True
            CBMARTES.Enabled = True
            CBMIERCOLES.Enabled = True
            CBJUEVES.Enabled = True
            CBVIERNES.Enabled = True
            CBACTIVO.Enabled = True
            CBINACTIVO.Enabled = True
            TXTCUPO.Enabled = True
            BTNMODIFICAR.Visible = True : BTNACEPTAR.Visible = False
            TXTIDENTIDAD.Focus()
            If DATO.Tables(0).Rows.Count = 0 Then
                MsgBox("EL MEDICO NO EXISTE, FAVOR INGRESARLO", MsgBoxStyle.Exclamation, AcceptButton)
                TXTMEDICO.Enabled = True : TXTMEDICO.Clear()
                TXTHORARIO.Enabled = True : TXTHORARIO.Clear()
                TXTCOMENTARIO.Enabled = True : TXTCOMENTARIO.Clear()
                TXTTARJETA.Enabled = True : TXTTARJETA.Clear()
                TXTCUPO.Enabled = True : TXTCUPO.Clear()
                CMBESPECIALIDAD.Enabled = True
                CMBCONSULTORIO.Enabled = True
                ESPECIALIDAD()
                CBLUNES.Enabled = True : CBLUNES.Checked = False
                CBMARTES.Enabled = True : CBMARTES.Checked = False
                CBMIERCOLES.Enabled = True : CBMIERCOLES.Checked = False
                CBJUEVES.Enabled = True : CBJUEVES.Checked = False
                CBVIERNES.Enabled = True : CBVIERNES.Checked = False
                CBACTIVO.Enabled = True : CBACTIVO.Checked = True
                CBINACTIVO.Enabled = True : CBINACTIVO.Checked = False
                BTNMODIFICAR.Visible = False : BTNACEPTAR.Visible = True
                TXTIDENTIDAD.Focus()
            End If
        End Try
    End Sub

    Private Sub TXTMEDICO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMEDICO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTHORARIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTHORARIO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTCOMENTARIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCOMENTARIO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTTARJETA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTARJETA.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
        Dim TEXTO As String = TXTIDENTIDAD.Text
            If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
                e.Handled = True
            End If
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
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
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        TXTIDENTIDAD.MaxLength = 15
        If TXTIDENTIDAD.Text.Length = 15 Then
            BTNIDENTIDAD.Enabled = True
        ElseIf TXTIDENTIDAD.Text.Length < 15 Then
            BTNIDENTIDAD.Enabled = False
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
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

    Private Sub CBACTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CBACTIVO.CheckedChanged
        If CBACTIVO.CheckState = CheckState.Checked Then
            CBINACTIVO.CheckState = CheckState.Unchecked
            TXTESTADO.Text = "ACTIVO"
        ElseIf CBACTIVO.CheckState = CheckState.Unchecked Then
            CBINACTIVO.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub CBINACTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CBINACTIVO.CheckedChanged
        If CBINACTIVO.CheckState = CheckState.Checked Then
            CBACTIVO.CheckState = CheckState.Unchecked
            TXTESTADO.Text = "INACTIVO"
        ElseIf CBINACTIVO.CheckState = CheckState.Unchecked Then
            CBACTIVO.CheckState = CheckState.Checked
        End If
    End Sub
    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        '---------------------------------GUARDAR-------------------
        CONE.Open()
        Dim L As String
        Dim M As String
        Dim MI As String
        Dim J As String
        Dim V As String
        If CBLUNES.Checked = True Then
            L = "SI"
        Else
            L = "NO"
        End If
        If CBMARTES.Checked = True Then
            M = "SI"
        Else
            M = "NO"
        End If
        If CBMIERCOLES.Checked = True Then
            MI = "SI"
        Else
            MI = "NO"
        End If
        If CBJUEVES.Checked = True Then
            J = "SI"
        Else
            J = "NO"
        End If
        If CBVIERNES.Checked = True Then
            V = "SI"
        Else
            V = "NO"
        End If
        Dim GUARDAR As String = "INSERT INTO MEDICO (CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, " _
        & "CONSULTORIO, TARJETA, HORARIO, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO)" _
        & "VALUES ('" & TXTCOD_ESPECIALIDAD.Text & "','" & TXTIDENTIDAD.Text & "','" & TXTMEDICO.Text & "','" _
        & CMBESPECIALIDAD.Text & "','" & CMBCONSULTORIO.Text & "','" & TXTTARJETA.Text & "','" & TXTHORARIO.Text & "','" _
        & L & "','" & M & "','" & MI & "','" & J & "','" & V & "','" & TXTCOMENTARIO.Text & "','" & TXTESTADO.Text & "','" _
        & TXTCUPO.Text & "')"
        Dim COMAND As SqlCommand
        COMAND = New SqlCommand(GUARDAR, CONE)
        If ((TXTIDENTIDAD.Text <> "" And TXTMEDICO.Text <> "" And CMBESPECIALIDAD.Text <> "" And CMBCONSULTORIO.Text <> "" _
             And TXTHORARIO.Text <> "" And TXTCOMENTARIO.Text <> "" And TXTTARJETA.Text <> "" And TXTCUPO.Text <> "") And _
             (CBLUNES.Checked = True Or CBMARTES.Checked = True Or CBMIERCOLES.Checked = True Or CBJUEVES.Checked = True _
              Or CBVIERNES.Checked = True) And (CBACTIVO.Checked = True Or CBINACTIVO.Checked = True)) Then
            COMAND.ExecuteNonQuery()
            MsgBox("REGISTRO GUARDADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
            Me.Close()
            CONE.Close()
            '-----------------------------------------------------------
        Else
            MsgBox("LE FALTA CAMPOS QUE LLENAR, VERIFIQUE PARA PODER GUARDAR EL REGISTRO", MsgBoxStyle.Critical, AcceptButton)
            CONE.Close()
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

    Private Sub TXTCUPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCUPO.KeyPress
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If
    End Sub

    Private Sub BTNMODIFICAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNMODIFICAR.MouseEnter
        BTNMODIFICAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNMODIFICAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNMODIFICAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNMODIFICAR.MouseLeave
        BTNMODIFICAR.FlatAppearance.BorderColor = Color.Silver
        BTNMODIFICAR.FlatAppearance.BorderSize = 1
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
        '---------------------------------MODIFICAR-------------------
        CONE.Open()
        Dim L As String
        Dim M As String
        Dim MI As String
        Dim J As String
        Dim V As String
        If CBLUNES.Checked = True Then
            L = "SI"
        Else
            L = "NO"
        End If
        If CBMARTES.Checked = True Then
            M = "SI"
        Else
            M = "NO"
        End If
        If CBMIERCOLES.Checked = True Then
            MI = "SI"
        Else
            MI = "NO"
        End If
        If CBJUEVES.Checked = True Then
            J = "SI"
        Else
            J = "NO"
        End If
        If CBVIERNES.Checked = True Then
            V = "SI"
        Else
            V = "NO"
        End If
        Dim MEDICOBD As String = "UPDATE MEDICO SET CODIGO_ESPECIALIDAD='" & TXTCOD_ESPECIALIDAD.Text & "', NOMBRE='" _
        & TXTMEDICO.Text & "', ESPECIALIDAD='" & CMBESPECIALIDAD.Text & "', CONSULTORIO='" & CMBCONSULTORIO.Text & "', TARJETA='" _
        & TXTTARJETA.Text & "', HORARIO='" & TXTHORARIO.Text & "', LUNES='" & L & "', MARTES='" & M & "', MIERCOLES='" _
        & MI & "', JUEVES='" & J & "', VIERNES='" & V & "', COMENTARIO='" & TXTCOMENTARIO.Text & "', ESTADO='" _
        & TXTESTADO.Text & "', CUPO='" & TXTCUPO.Text & "' WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
        Dim MED As SqlCommand
        MED = New SqlCommand(MEDICOBD, CONE)
        If ((TXTIDENTIDAD.Text <> "" And TXTMEDICO.Text <> "" And CMBESPECIALIDAD.Text <> "" And CMBCONSULTORIO.Text <> "" _
             And TXTHORARIO.Text <> "" And TXTCOMENTARIO.Text <> "" And TXTTARJETA.Text <> "" And TXTCUPO.Text <> "") And _
             (CBLUNES.Checked = True Or CBMARTES.Checked = True Or CBMIERCOLES.Checked = True Or CBJUEVES.Checked = True _
              Or CBVIERNES.Checked = True) And (CBACTIVO.Checked = True Or CBINACTIVO.Checked = True)) Then
            MED.ExecuteNonQuery()
            MsgBox("REGISTRO MODIFICADO CON EXITO", MsgBoxStyle.Information, AcceptButton)
            Me.Close()
            CONE.Close()
            '-----------------------------------------------------------
        Else
            MsgBox("LE FALTA CAMPOS QUE LLENAR, VERIFIQUE PARA PODER MODIFICAR EL REGISTRO", MsgBoxStyle.Critical, AcceptButton)
            CONE.Close()
        End If
    End Sub
End Class