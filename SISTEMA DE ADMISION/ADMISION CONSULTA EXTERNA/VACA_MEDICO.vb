Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class VACA_MEDICO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Sub COMBOESPECIALIDAD()
        '----------CARGAR COMBOBOX ESPECIALIDAD------------
        Dim DS As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES ORDER BY ESPECIALIDAD ASC"
        Dim DA As New SqlDataAdapter(DS, CONEXION)
        Dim CMB As New DataSet
        DA.Fill(CMB)
        'AGREGAR UNA LINEA EN BLANCO
        Dim FILA As DataRow
        FILA = CMB.Tables(0).NewRow()
        FILA(0) = ""
        CMB.Tables(0).Rows.InsertAt(FILA, 0)
        '-----------------------------------------------------
        CMBESPECIALIDAD.DataSource = CMB.Tables(0)
        CMBESPECIALIDAD.SelectedIndex = 0
        CMBESPECIALIDAD.DisplayMember = "ESPECIALIDAD"
        'TXTCOD_ESPECIALIDAD.Text = CMB.Tables(0).Rows(0)("CODIGO_ESPECIALIDAD")
        '--------------------------------------------------------
    End Sub

    Private Sub CMBESPECIALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBESPECIALIDAD.SelectedIndexChanged
        '----------CARGAR COMBOBOX ESPECIALIDAD------------
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        TXTCOD_ESPECIALIDAD.Text = ""
        Dim COMANDO As String = "SELECT CODIGO_ESPECIALIDAD, ESPECIALIDAD FROM ESPECIALIDADES WHERE ESPECIALIDAD ='" _
                                & CMBESPECIALIDAD.Text & "' ORDER BY ESPECIALIDAD ASC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        TXTCOD_ESPECIALIDAD.Text = CMBESPECIALIDAD.SelectedItem("CODIGO_ESPECIALIDAD").ToString
        '------CARGAR COMBOBOX MEDICO-----------------------
        If CMBESPECIALIDAD.SelectedIndex > 0 Then
            CONE.Open()
            Dim ADAPTA As New SqlDataAdapter
            Dim COMAND As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, HORARIO, " _
            & "LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE CODIGO_ESPECIALIDAD='" _
            & TXTCOD_ESPECIALIDAD.Text & "' AND ESTADO='ACTIVO' ORDER BY NOMBRE ASC"
            Dim CMB As DataTable
            ADAPTA = New SqlDataAdapter(COMAND, CONE)
            CMB = New DataTable
            ADAPTA.Fill(CMB)
            If CMB.Rows.Count > 0 Then
                CMBMEDICO.Enabled = True
                CMBMEDICO.DataSource = CMB
                CMBMEDICO.DisplayMember = "NOMBRE"
                CMBMEDICO.ValueMember = "ESPECIALIDAD"
                CONE.Close()
            ElseIf CMB.Rows.Count = 0 Then
                CMBMEDICO.DataSource = Nothing
                CMBMEDICO.Items.Clear()
                MsgBox("NO HAY MEDICO AGREGADO, CONTACTE CON EL ADMINISTRADOR PARA QUE INGRESE EL MEDICO")
                CMBMEDICO.Enabled = False
                CONE.Close()
            End If
        ElseIf CMBESPECIALIDAD.SelectedIndex = 0 Then
            CMBMEDICO.DataSource = Nothing
            CMBMEDICO.Items.Clear()
            TXTCLINICA.Text = ""
        End If
        '------------------------------
    End Sub

    Private Sub CMBMEDICO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBMEDICO.SelectedIndexChanged
        CMBMEDICO.DropDownStyle = ComboBoxStyle.DropDownList
        '----------CARGAR CONSULTORIO EN TXTCLINICA------------
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, HORARIO, LUNES, " _
        & "MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE NOMBRE='" _
        & CMBMEDICO.Text & "' AND ESPECIALIDAD='" & CMBESPECIALIDAD.Text & "' AND ESTADO='ACTIVO'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMAND, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        If DATO.Rows.Count > 0 Then
            TXTCLINICA.Text = CMBMEDICO.SelectedItem("CONSULTORIO").ToString
        ElseIf DATO.Rows.Count = 0 Then
            TXTCLINICA.Text = ""
        End If
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT ESPECIALIDAD, NOMBRE, CLINICA, N_INICIAL, N_FINAL, NORMAL, REPORTEV, F_INICIAL, " _
        & " F_FINAL, PROFI, REPORTEF FROM VACACIONES WHERE ESPECIALIDAD='" & CMBESPECIALIDAD.Text & "' AND NOMBRE='" _
        & CMBMEDICO.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            If DATO.Rows.Count > 0 Then
                TXTCLINICA.Text = DATO.Rows(0)("CLINICA").ToString()
                V_INICIAL.Text = Format(CDate(DATO.Rows(0)("N_INICIAL").ToString()), "dd/MMM/YYYY")
                V_FINAL.Text = Format(CDate(DATO.Rows(0)("N_FINAL").ToString()), "dd/MMM/YYYY")
                TXTNORMAL.Text = DATO.Rows(0)("REPORTEV").ToString()
                If DATO.Rows(0)("NORMAL") = "SI" Then
                    CBNORMAL.Checked = True
                Else
                    CBNORMAL.Checked = False
                End If
                F_INICIAL.Text = Format(CDate(DATO.Rows(0)("F_INICIAL").ToString()), "dd/MMM/YYYY")
                F_FINAL.Text = Format(CDate(DATO.Rows(0)("F_FINAL").ToString()), "dd/MMM/YYYY")
                TXTPROF.Text = DATO.Rows(0)("REPORTEF").ToString()
                V_INICIAL.Enabled = True : F_FINAL.Enabled = True : TXTNORMAL.Enabled = True
                F_INICIAL.Enabled = True : F_FINAL.Enabled = True : TXTPROF.Enabled = True
                BTNMODIFICA.Enabled = True : BTNGUARDA.Enabled = False
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                V_INICIAL.Enabled = True : F_FINAL.Enabled = True : TXTNORMAL.Enabled = True
                F_INICIAL.Enabled = True : F_FINAL.Enabled = True : TXTPROF.Enabled = True
                BTNMODIFICA.Enabled = False : BTNGUARDA.Enabled = True
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
    End Sub

    Private Sub CBNORMAL_CheckedChanged(sender As Object, e As EventArgs) Handles CBNORMAL.CheckedChanged
        If CBNORMAL.Checked = False Then
            CBPROF.Checked = True
        Else
            CBPROF.Checked = False
        End If
    End Sub

    Private Sub CBPROF_CheckedChanged(sender As Object, e As EventArgs) Handles CBPROF.CheckedChanged
        If CBPROF.Checked = False Then
            CBNORMAL.Checked = True
        Else
            CBNORMAL.Checked = False
        End If
    End Sub

    Private Sub VACA_MEDICO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBNORMAL.Checked = True
        CMBESPECIALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBMEDICO.DropDownStyle = ComboBoxStyle.DropDownList
        V_INICIAL.Value = DateTime.Now.Date
        V_FINAL.Value = DateTime.Now.Date
        F_INICIAL.Value = DateTime.Now.Date
        F_FINAL.Value = DateTime.Now.Date
        COMBOESPECIALIDAD()
    End Sub

    Private Sub V_FINAL_CloseUp(sender As Object, e As EventArgs) Handles V_FINAL.CloseUp
        If Format(V_FINAL.Value, "dd/MMM/yyyy") < Format(V_INICIAL.Value, "dd/MMM/yyyy") Then
            MsgBox("NO SE PERMITE UNA FECHA INFERIOR A LA INICIAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            V_FINAL.Value = (DateTime.Now.Date)
        End If
    End Sub

    Private Sub V_FINAL_ValueChanged(sender As Object, e As EventArgs) Handles V_FINAL.ValueChanged

    End Sub

    Private Sub F_FINAL_CloseUp(sender As Object, e As EventArgs) Handles F_FINAL.CloseUp
        If Format(F_FINAL.Value, "dd/MMM/yyyy") < Format(F_INICIAL.Value, "dd/MMM/yyyy") Then
            MsgBox("NO SE PERMITE UNA FECHA INFERIOR A LA INICIAL", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
            V_FINAL.Value = (DateTime.Now.Date)
        End If
    End Sub

    Private Sub F_FINAL_ValueChanged(sender As Object, e As EventArgs) Handles F_FINAL.ValueChanged

    End Sub
    Sub GUARDAR_IDENTIDAD()
        '-------------------------------GUARDAR EN TABLA UNICO-------------------
        CONE.Open()
        Dim N_INICIAL As String = Format(CDate(V_INICIAL.Value), "yyyy/MM/dd")
        Dim N_FINAL As String = Format(CDate(V_FINAL.Value), "yyyy/MM/dd")
        Dim NORMAL As String = ""
        If CBNORMAL.Checked = True Then
            NORMAL = "SI"
        Else
            NORMAL = "NO"
        End If
        Dim F_IN As String = Format(CDate(F_INICIAL.Value), "yyyy/MM/dd")
        Dim F_FIN As String = Format(CDate(F_FINAL.Value), "yyyy/MM/dd")
        Dim PROF As String = ""
        If CBPROF.Checked = True Then
            PROF = "SI"
        Else
            PROF = "NO"
        End If
        '------------------------------------------------------------
        Dim VACA As String = "INSERT INTO VACACIONES (ESPECIALIDAD, NOMBRE, CLINICA, N_INICIAL, N_FINAL, NORMAL, REPORTEV, " _
        & " F_INICIAL, F_FINAL, PROFI, REPORTEF) VALUES ('" & CMBESPECIALIDAD.Text & "','" & CMBMEDICO.Text & "','" _
        & TXTCLINICA.Text & "','" & N_INICIAL & "','" & N_FINAL & "','" & NORMAL & "','" & TXTNORMAL.Text & "','" _
        & F_IN & "','" & F_FIN & "','" & PROF & "','" & TXTPROF.Text & "')"
        Dim COMAND As SqlCommand
        COMAND = New SqlCommand(VACA, CONE)
        COMAND.ExecuteNonQuery()
        CONE.Close()
        Me.Close()
        '------------------TERMINAR DE GUARDAR EN TABLA BITACORA---------------------
    End Sub
    Private Sub BTNGUARDA_Click(sender As Object, e As EventArgs) Handles BTNGUARDA.Click

    End Sub
End Class