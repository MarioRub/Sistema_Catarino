Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class MODIFICAR_REGISTRO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNIDENTIDAD_Click(sender As Object, e As EventArgs) Handles BTNIDENTIDAD.Click
        CENSO_REGISTROMOD.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        CENSO_REGISTROMOD.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        CENSO_REGISTROMOD.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        CENSO_REGISTROMOD.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        CENSO_REGISTROMOD.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        CENSO_REGISTROMOD.CBSI.Checked = True
        CENSO_REGISTROMOD.Show()
    End Sub

    Private Sub BTNCORRELATIVO_Click(sender As Object, e As EventArgs) Handles BTNCORRELATIVO.Click
        CENSO_REGISTROMOD.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
        CENSO_REGISTROMOD.TXTCORRELATIVO.Text = TXTCORRELATIVO.Text
        CENSO_REGISTROMOD.CMBNACIONALIDAD.Text = CMBNACIONALIDAD.Text
        CENSO_REGISTROMOD.CMBBUSQUEDA.Text = CMBBUSQUEDA.Text
        CENSO_REGISTROMOD.CMBCLASIFICACION.Text = CMBCLASIFICACION.Text
        CENSO_REGISTROMOD.CBSI.Checked = True
        CENSO_REGISTROMOD.Show()
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBBUSQUEDA.Text = "" Then
            TXTIDENTIDAD.Enabled = False
            TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
            BTNIDENTIDAD.Visible = False
            BTNCORRELATIVO.Visible = False
        ElseIf CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTIDENTIDAD.Enabled = True
            TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = "0000-0000"
            BTNIDENTIDAD.Visible = True
            BTNCORRELATIVO.Visible = False
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTIDENTIDAD.Enabled = True
            TXTCORRELATIVO.Enabled = True
            TXTIDENTIDAD.Text = "0000-0000-00000"
            TXTCORRELATIVO.Text = ""
            BTNIDENTIDAD.Visible = False
            BTNCORRELATIVO.Visible = True
        End If
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
            TXTPAIS.Text = "HONDURAS"
            LBPAIS.Visible = False : TXTPAIS.Visible = False
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
            TXTNOMBRES.Enabled = False : TXTPRIMERAPELLIDO.Enabled = False
            TXTSEGUNDOAPELLIDO.Enabled = False
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.Text = ""
            TXTCORRELATIVO.Text = ""
            TXTPAIS.Text = ""
            CMBBUSQUEDA.Enabled = True
            CMBBUSQUEDA.Text = ""
            LBPAIS.Visible = True : TXTPAIS.Visible = True
        End If
    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            Dim TEXTO As String = TXTIDENTIDAD.Text
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
            End If
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
            If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
                e.Handled = True
            End If
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNIDENTIDAD.Focus()
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
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
                e.Handled = True
                MsgBox("NO SE PERMITEN ESPACIOS", MsgBoxStyle.Critical, "ALERTA")
            End If
            If e.KeyChar = "-" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.MaxLength = 15
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNIDENTIDAD.Enabled = True
            ElseIf TXTIDENTIDAD.Text.Length < 15 Then
                BTNIDENTIDAD.Enabled = False
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
        End If
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
        TXTNOMBRES.Text = "" : TXTPRIMERAPELLIDO.Text = "" : TXTSEGUNDOAPELLIDO.Text = ""
        CMBSEXO.Text = "" : FN.Value = DateTime.Now.Date
        TXTPAIS.Text = "" : TXTPADRE.Text = "" : TXTMADRE.Text = ""
        TXTEDAD.Text = "" : CMBTIPO.Text = ""
        TXTTELEFONO1.Text = "" : TXTTELEFONO2.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        TXTDIAGNOSTICO.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        CBLUNES.Checked = False : CBMARTES.Checked = False : CBMIERCOLES.Checked = False : CBJUEVES.Checked = False
        CBVIERNES.Checked = False : CBSABADO.Checked = False : CBDOMINGO.Checked = False
    End Sub

    Private Sub TXTCORRELATIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCORRELATIVO.KeyPress
        Dim TEXTO As String = TXTCORRELATIVO.Text
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
            e.Handled = True
        End If

        If TXTCORRELATIVO.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTCORRELATIVO.Text = TEXTO
            e.Handled = True
            TXTCORRELATIVO.Select(TXTCORRELATIVO.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTCORRELATIVO_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVO.TextChanged
        LBCORRELATIVO.Text = CStr(Len(TXTCORRELATIVO.Text))
        TXTNOMBRES.Text = "" : TXTPRIMERAPELLIDO.Text = "" : TXTSEGUNDOAPELLIDO.Text = ""
        CMBSEXO.Text = "" : FN.Value = DateTime.Now.Date
        TXTPAIS.Text = "" : TXTPADRE.Text = "" : TXTMADRE.Text = ""
        TXTEDAD.Text = "" : CMBTIPO.Text = ""
        TXTTELEFONO1.Text = "" : TXTTELEFONO2.Text = ""
        TXTDIAGNOSTICO.Text = ""
        TXTCOLONIA.Text = "" : TXTCASA.Text = ""
        CMBDEPARTAMENTO.Text = "SELECCIONE" : CMBMUNICIPIO.Text = "SELECCIONE"
        CBLUNES.Checked = False : CBMARTES.Checked = False : CBMIERCOLES.Checked = False : CBJUEVES.Checked = False
        CBVIERNES.Checked = False : CBSABADO.Checked = False : CBDOMINGO.Checked = False
    End Sub
    Sub DEPA()
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBDEPARTAMENTO.DropDownStyle = ComboBoxStyle.DropDownList
        'CMBDEPARTAMENTO.SelectedItem = ""
        Dim DS As String = "SELECT CODIGO_DEPARTAMENTO, DEPARTAMENTO FROM DEPARTAMENTO_HONDURAS"
        Dim DA As New SqlDataAdapter(DS, CONEXION)
        Dim CMB As New DataSet
        DA.Fill(CMB)
        With CMBDEPARTAMENTO
            .DataSource = CMB.Tables(0)
            .DisplayMember = "DEPARTAMENTO"
            TXTCOD_DEPA.Text = CMB.Tables(0).Rows(0)("CODIGO_DEPARTAMENTO") 'TXTCOD_DEPA.Text = CMBDEPARTAMENTO.SelectedItem("CODIGO_DEPARTAMENTO").ToString
            '--------------------------------------------------------
        End With
    End Sub
    Sub MODIFICAR_IDENTIDAD()
        Dim LUNES As String = ""
        Dim MARTES As String = ""
        Dim MIERCOLES As String = ""
        Dim JUEVES As String = ""
        Dim VIERNES As String = ""
        Dim SABADO As String = ""
        Dim DOMINGO As String = ""
        If CBLUNES.Checked = True Then
            LUNES = "SI"
        Else
            LUNES = "NO"
        End If
        If CBMARTES.Checked = True Then
            MARTES = "SI"
        Else
            MARTES = "NO"
        End If
        If CBMIERCOLES.Checked = True Then
            MIERCOLES = "SI"
        Else
            MIERCOLES = "NO"
        End If
        If CBJUEVES.Checked = True Then
            JUEVES = "SI"
        Else
            JUEVES = "NO"
        End If
        If CBVIERNES.Checked = True Then
            VIERNES = "SI"
        Else
            VIERNES = "NO"
        End If
        If CBSABADO.Checked = True Then
            SABADO = "SI"
        Else
            SABADO = "NO"
        End If
        If CBDOMINGO.Checked = True Then
            DOMINGO = "SI"
        Else
            DOMINGO = "NO"
        End If
        If TXTCORRELATIVO.Text = "" Then
            TXTCORRELATIVO.Text = "0000-0000"
        End If
        Dim FECHA As String = Format(CDate(FN.Value), "yyyy/MM/dd")
        Dim PAIS As String = vbNull
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            PAIS = "HONDURAS"
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            PAIS = TXTPAIS.Text
        End If
        Try
            '---------------------------------MODIFICAR UNICO-------------------
            CONE.Open()
            Dim UNICO As String = "UPDATE UNICO SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBNUEVO.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', CORRELATIVO='" _
            & TXTCORRELATIVONUEVA.Text & "', IDENTIDAD='" & TXTIDENTIDADNUEVA.Text & "', COLONIA='" & TXTCOLONIA.Text & "', CASA='" _
            & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" & CMBMUNICIPIO.Text & "', TELEFONO1='" _
            & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "', NOMBRE_PADRE='" _
            & TXTPADRE.Text & "', NOMBRE_MADRE='" & TXTMADRE.Text & "', LUNES='" & LUNES & "', MARTES='" & MARTES & "', MIERCOLES='" _
            & MIERCOLES & "', JUEVES='" & JUEVES & "', VIERNES='" & VIERNES & "', SABADO='" & SABADO & "', DOMINGO='" _
            & DOMINGO & "', FECHA_NACIMIENTO='" & FECHA & "', DIAGNOSTICO='" & TXTDIAGNOSTICO.Text & "' WHERE TIPO='" & _
            CMBCLASIFICACION.Text & "' AND IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
            Dim UNI As SqlCommand
            UNI = New SqlCommand(UNICO, CONE)
            UNI.ExecuteNonQuery()
            CONE.Close()
            '---------------------------------MODIFICAR BITACORA-------------------
            CONE.Open()
            Dim BITACORA As String = "UPDATE BITACORA SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBNUEVO.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', FECHA_NAC='" _
            & FECHA & "', CORRELATIVO='" & TXTCORRELATIVONUEVA.Text & "', IDENTIDAD='" & TXTIDENTIDADNUEVA.Text & "', NOMBRE_PADRE='" _
            & TXTPADRE.Text & "', NOMBRE_MADRE='" & TXTMADRE.Text & "', COLONIA='" _
            & TXTCOLONIA.Text & "', CASA='" & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" _
            & CMBMUNICIPIO.Text & "', TELEFONO1='" & TXTTELEFONO1.Text & "', TELEFONO2='" _
            & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "' WHERE TIPO='" & _
            CMBCLASIFICACION.Text & "' AND IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
            Dim BITA As SqlCommand
            BITA = New SqlCommand(BITACORA, CONE)
            BITA.ExecuteNonQuery()
            CONE.Close()
            '-----------------------------------------------------------
            '---------------------------------MODIFICAR IMPRONTO-------------------
            CONE.Open()
            Dim IMPRONTO As String = "UPDATE IMPRONTO SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBNUEVO.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', FECHA_NAC='" _
            & FECHA & "', CORRELATIVO='" & TXTCORRELATIVONUEVA.Text & "', IDENTIDAD='" & TXTIDENTIDADNUEVA.Text & "', COLONIA='" _
            & TXTCOLONIA.Text & "', CASA='" & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" _
            & CMBMUNICIPIO.Text & "', PADRE='" & TXTPADRE.Text & "', MADRE='" & TXTMADRE.Text & " ', TELEFONO1='" _
            & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "' WHERE TIPO='" & _
            CMBCLASIFICACION.Text & "' AND IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
            Dim IMPR As SqlCommand
            IMPR = New SqlCommand(IMPRONTO, CONE)
            IMPR.ExecuteNonQuery()
            CONE.Close()
            '-----------------------------------------------------------
            '---------------------------------MODIFICAR HOSPITALIZACION-------------------
            CONE.Open()
            Dim HOSPITALIZACION As String = "UPDATE HOSPITALIZACION SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBNUEVO.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', FECHA_NAC='" _
            & FECHA & "', CORRELATIVO='" & TXTCORRELATIVONUEVA.Text & "', IDENTIDAD='" & TXTIDENTIDADNUEVA.Text & "', COLONIA='" _
            & TXTCOLONIA.Text & "', CASA='" & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" _
            & CMBMUNICIPIO.Text & "', PADRE='" & TXTPADRE.Text & "', MADRE='" & TXTMADRE.Text & "', TELEFONO1='" _
            & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "' WHERE TIPO='" & _
            CMBCLASIFICACION.Text & "' AND IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
            Dim HOSP As SqlCommand
            HOSP = New SqlCommand(HOSPITALIZACION, CONE)
            HOSP.ExecuteNonQuery()
            CONE.Close()
            '-----------------------------------------------------------
            MsgBox("REGISTRO MODIFICADO CON EXITO", MsgBoxStyle.Information, "MENSAJE DEL SISTEMA")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONE.Close()
        End Try
    End Sub
    Sub MODIFICA_CORRELATIVO()
        Dim LUNES As String = ""
        Dim MARTES As String = ""
        Dim MIERCOLES As String = ""
        Dim JUEVES As String = ""
        Dim VIERNES As String = ""
        Dim SABADO As String = ""
        Dim DOMINGO As String = ""
        If CBLUNES.Checked = True Then
            LUNES = "SI"
        Else
            LUNES = "NO"
        End If
        If CBMARTES.Checked = True Then
            MARTES = "SI"
        Else
            MARTES = "NO"
        End If
        If CBMIERCOLES.Checked = True Then
            MIERCOLES = "SI"
        Else
            MIERCOLES = "NO"
        End If
        If CBJUEVES.Checked = True Then
            JUEVES = "SI"
        Else
            JUEVES = "NO"
        End If
        If CBVIERNES.Checked = True Then
            VIERNES = "SI"
        Else
            VIERNES = "NO"
        End If
        If CBSABADO.Checked = True Then
            SABADO = "SI"
        Else
            SABADO = "NO"
        End If
        If CBDOMINGO.Checked = True Then
            DOMINGO = "SI"
        Else
            DOMINGO = "NO"
        End If
        If TXTCORRELATIVO.Text = "" Then
            TXTCORRELATIVO.Text = "0000-0000"
        End If
        Dim FECHA As String = Format(CDate(FN.Value), "yyyy/MM/dd")
        Dim PAIS As String = vbNull
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            PAIS = "HONDURAS"
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            PAIS = TXTPAIS.Text
        End If
        Try
            '---------------------------------MODIFICAR UNICO-------------------
            CONE.Open()
            Dim UNICO As String = "UPDATE UNICO SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBNUEVO.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', CORRELATIVO='" _
            & TXTCORRELATIVONUEVA.Text & "', IDENTIDAD='" & TXTIDENTIDADNUEVA.Text & "', COLONIA='" & TXTCOLONIA.Text & "', CASA='" _
            & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" & CMBMUNICIPIO.Text & "', TELEFONO1='" _
            & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "', NOMBRE_PADRE='" _
            & TXTPADRE.Text & "', NOMBRE_MADRE='" & TXTMADRE.Text & "', LUNES='" & LUNES & "', MARTES='" & MARTES & "', MIERCOLES='" _
            & MIERCOLES & "', JUEVES='" & JUEVES & "', VIERNES='" & VIERNES & "', SABADO='" & SABADO & "', DOMINGO='" _
            & DOMINGO & "', FECHA_NACIMIENTO='" & FECHA & "', DIAGNOSTICO='" & TXTDIAGNOSTICO.Text & "' WHERE TIPO='" & _
            CMBCLASIFICACION.Text & "' AND CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
            Dim UNI As SqlCommand
            UNI = New SqlCommand(UNICO, CONE)
            UNI.ExecuteNonQuery()
            CONE.Close()
            '---------------------------------MODIFICAR BITACORA-------------------
            CONE.Open()
            Dim BITACORA As String = "UPDATE BITACORA SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBNUEVO.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', FECHA_NAC='" _
            & FECHA & "', CORRELATIVO='" & TXTCORRELATIVONUEVA.Text & "', IDENTIDAD='" & TXTIDENTIDADNUEVA.Text & "', NOMBRE_PADRE='" _
            & TXTPADRE.Text & "', NOMBRE_MADRE='" & TXTMADRE.Text & "', COLONIA='" _
            & TXTCOLONIA.Text & "', CASA='" & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" _
            & CMBMUNICIPIO.Text & "', TELEFONO1='" & TXTTELEFONO1.Text & "', TELEFONO2='" _
            & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "' WHERE TIPO='" & _
            CMBCLASIFICACION.Text & "' AND CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
            Dim BITA As SqlCommand
            BITA = New SqlCommand(BITACORA, CONE)
            BITA.ExecuteNonQuery()
            CONE.Close()
            '-----------------------------------------------------------
            '---------------------------------MODIFICAR IMPRONTO-------------------
            CONE.Open()
            Dim IMPRONTO As String = "UPDATE IMPRONTO SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBNUEVO.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', FECHA_NAC='" _
            & FECHA & "', CORRELATIVO='" & TXTCORRELATIVONUEVA.Text & "', IDENTIDAD='" & TXTIDENTIDADNUEVA.Text & "', COLONIA='" _
            & TXTCOLONIA.Text & "', CASA='" & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" _
            & CMBMUNICIPIO.Text & "', PADRE='" & TXTPADRE.Text & "', MADRE='" & TXTMADRE.Text & " ', TELEFONO1='" _
            & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "' WHERE TIPO='" & _
            CMBCLASIFICACION.Text & "' AND CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
            Dim IMPR As SqlCommand
            IMPR = New SqlCommand(IMPRONTO, CONE)
            IMPR.ExecuteNonQuery()
            CONE.Close()
            '-----------------------------------------------------------
            '---------------------------------MODIFICAR HOSPITALIZACION-------------------
            CONE.Open()
            Dim HOSPITALIZACION As String = "UPDATE HOSPITALIZACION SET NACIONALIDAD='" & CMBNACIONALIDAD.Text & "', PAIS='" _
            & PAIS & "', TIPO='" & CMBNUEVO.Text & "', NOMBRE_PACIENTE='" & TXTNOMBRES.Text & "', PRIMER_APELLIDO='" & TXTPRIMERAPELLIDO.Text & "', SEGUNDO_APELLIDO='" _
            & TXTSEGUNDOAPELLIDO.Text & "', EDAD='" & TXTEDAD.Text & "', TIPO_EDAD='" & CMBTIPO.Text & "', FECHA_NAC='" _
            & FECHA & "', CORRELATIVO='" & TXTCORRELATIVONUEVA.Text & "', IDENTIDAD='" & TXTIDENTIDADNUEVA.Text & "', COLONIA='" _
            & TXTCOLONIA.Text & "', CASA='" & TXTCASA.Text & "', DEPARTAMENTO='" & CMBDEPARTAMENTO.Text & "', MUNICIPIO='" _
            & CMBMUNICIPIO.Text & "', PADRE='" & TXTPADRE.Text & "', MADRE='" & TXTMADRE.Text & "', TELEFONO1='" _
            & TXTTELEFONO1.Text & "', TELEFONO2='" & TXTTELEFONO2.Text & "', SEXO='" & CMBSEXO.Text & "' WHERE TIPO='" & _
            CMBCLASIFICACION.Text & "' AND CORRELATIVO='" & TXTCORRELATIVO.Text & "'"
            Dim HOSP As SqlCommand
            HOSP = New SqlCommand(HOSPITALIZACION, CONE)
            HOSP.ExecuteNonQuery()
            CONE.Close()
            '-----------------------------------------------------------
            MsgBox("REGISTRO MODIFICADO CON EXITO", MsgBoxStyle.Information, "MENSAJE DEL SISTEMA")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            CONE.Close()
        End Try
    End Sub
    Private Sub MODIFICAR_REGISTRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBSEXO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBESTADO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBESTADO.Items.Add("")
        CMBESTADO.Items.Add("1. CASADO")
        CMBESTADO.Items.Add("2. SOLTERO")
        CMBESTADO.Items.Add("3. VIUDO")
        CMBESTADO.Items.Add("4. UNION LIBRE")
        CMBESTADO.Items.Add("5. DESCONOCIDO")
        DEPA() 'LLAMAR METODO
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
        CMBCLASIFICACION.SelectedIndex = 0 'SELECCIONA SIEMPRE EL PRIMER ITEM
        CMBNUEVO.DropDownStyle = ComboBoxStyle.DropDownList
        CMBNUEVO.Items.Add("NORMAL")
        CMBNUEVO.Items.Add("RN#1")
        CMBNUEVO.Items.Add("RN#2")
        CMBNUEVO.Items.Add("RN#3")
        CMBNUEVO.Items.Add("HIJO_1")
        CMBNUEVO.Items.Add("HIJO_2")
        CMBNUEVO.Items.Add("HIJO_3")
        CMBNUEVO.Items.Add("OBITO_1")
        CMBNUEVO.Items.Add("OBITO_2")
        CMBNUEVO.Items.Add("OBITO_3")
        CMBNUEVO.Items.Add("RN_GEMELO_1")
        CMBNUEVO.Items.Add("RN_GEMELO_2")
        CMBNUEVO.Items.Add("RN_GEMELO_3")
        FN.Value = (DateTime.Now.Date)
        CMBNACIONALIDAD.Focus()
        CMBNACIONALIDAD.Items.Add("")
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
        CMBSEXO.Items.Add("")
        CMBSEXO.Items.Add("1. HOMBRE")
        CMBSEXO.Items.Add("2. MUJER")
        CMBBUSQUEDA.Enabled = False
        CMBBUSQUEDA.Items.Add("")
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        CMBTIPO.Items.Add("")
        CMBTIPO.Items.Add("1. HORAS")
        CMBTIPO.Items.Add("2. DIAS")
        CMBTIPO.Items.Add("3. MESES")
        CMBTIPO.Items.Add("4. AÑOS")
    End Sub

    Private Sub CMBDEPARTAMENTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBDEPARTAMENTO.SelectedIndexChanged
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBDEPARTAMENTO.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_DEPARTAMENTO, DEPARTAMENTO FROM DEPARTAMENTO_HONDURAS WHERE DEPARTAMENTO ='" & CMBDEPARTAMENTO.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "DEPARTAMENTO_HONDURAS")
        TXTCOD_DEPA.Text = CMBDEPARTAMENTO.SelectedItem("CODIGO_DEPARTAMENTO").ToString
        '---------------------------------------------------------------------------------------
        Dim ADAPTA As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE CODIGO_DEPARTAMENTO ='" & TXTCOD_DEPA.Text & "'"
        Dim DAT As DataSet
        ADAPTA = New SqlDataAdapter(COMAND, CONEXION)
        DAT = New DataSet
        ADAPTA.Fill(DAT, "MUNICIPIO_HONDURAS")
        With CMBMUNICIPIO
            .DataSource = DAT.Tables(0)
            .DisplayMember = "MUNICIPIO"
            '.ValueMember = "CODIGO_MUNICIPIO"
        End With
        'TXTCOD_MUNI.Text = CMBMUNICIPIO.SelectedItem("CODIGO_MUNICIPIO").ToString
    End Sub

    Private Sub CMBMUNICIPIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBMUNICIPIO.SelectedIndexChanged
        '----------CARGAR COMBOBOX DEPARTAMENTO------------
        CMBMUNICIPIO.DropDownStyle = ComboBoxStyle.DropDownList
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, MUNICIPIO FROM MUNICIPIO_HONDURAS WHERE CODIGO_DEPARTAMENTO ='" & TXTCOD_DEPA.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        DATO = New DataSet
        ADAPTADOR.Fill(DATO, "MUNICIPIO_HONDURAS")
        TXTCOD_MUNI.Text = CMBMUNICIPIO.SelectedItem("CODIGO_MUNICIPIO").ToString
        '---------------------------------------------------------------------------------------
    End Sub

    Private Sub FN_ValueChanged(sender As Object, e As EventArgs) Handles FN.ValueChanged
        Dim HOY As Date = (DateTime.Now.Date)
        Dim AÑO, MES, DIA As Integer
        TXTEDAD.Text = ""
        CMBTIPO.Text = ""
        If FN.Value <= HOY Then
            AÑO = DateTime.Today.AddTicks(-FN.Value.Ticks).Year - 1
            MES = DateTime.Today.AddTicks(-FN.Value.Ticks).Month - 1
            DIA = DateTime.Today.AddTicks(-FN.Value.Ticks).Day - 1
            If AÑO > 0 Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                TXTEDAD.Text = AÑO
                CMBTIPO.Text = "4. AÑOS"
            ElseIf AÑO = 0 And MES > 0 Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                TXTEDAD.Text = MES
                CMBTIPO.Text = "3. MESES"
            ElseIf AÑO = 0 And MES = 0 And DIA > 0 Then
                TXTEDAD.Text = ""
                CMBTIPO.Text = ""
                TXTEDAD.Text = DIA
                CMBTIPO.Text = "2. DIAS"
            End If
        ElseIf FN.Value > HOY Then
            MessageBox.Show("LA FECHA INGRESADA NO ES PERMITIDA")
            FN.Value = HOY
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
        End If
    End Sub

    Private Sub TXTIDENTIDADNUEVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDENTIDADNUEVA.KeyPress
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            Dim TEXTO As String = TXTIDENTIDADNUEVA.Text
            If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
                e.Handled = False      'PERMITE ESCRITURA
            End If
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

            If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
                e.Handled = True
            End If
            If TXTIDENTIDADNUEVA.Text.Length = 4 Then
                TEXTO = TEXTO + "-" + e.KeyChar
                TXTIDENTIDADNUEVA.Text = TEXTO
                e.Handled = True
                TXTIDENTIDADNUEVA.Select(TXTIDENTIDADNUEVA.Text.Length, 0)
            End If
            If TXTIDENTIDADNUEVA.Text.Length = 9 Then
                TEXTO = TEXTO + "-" + e.KeyChar
                TXTIDENTIDADNUEVA.Text = TEXTO
                e.Handled = True
                TXTIDENTIDADNUEVA.Select(TXTIDENTIDADNUEVA.Text.Length, 0)
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
                e.Handled = True
                MsgBox("NO SE PERMITEN ESPACIOS", MsgBoxStyle.Critical, "ALERTA")
            End If
            If e.KeyChar = "-" Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TXTIDENTIDADNUEVA_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDADNUEVA.TextChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDADNUEVA.MaxLength = 15
            If TXTIDENTIDADNUEVA.Text.Length = 15 Then
                BTNMODIFICAR.Enabled = True
            ElseIf TXTIDENTIDADNUEVA.Text.Length < 15 Then
                BTNMODIFICAR.Enabled = False
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDADNUEVA.MaxLength = 30
            TXTIDENTIDADNUEVA.CharacterCasing = CharacterCasing.Upper
        End If
        LBIN.Text = CStr(Len(TXTIDENTIDADNUEVA.Text))
    End Sub

    Private Sub TXTCORRELATIVONUEVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCORRELATIVONUEVA.KeyPress
        Dim TEXTO As String = TXTCORRELATIVONUEVA.Text
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If Char.IsSeparator(e.KeyChar) Then 'prohibe el espacio
            e.Handled = True
        End If

        If TXTCORRELATIVONUEVA.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTCORRELATIVONUEVA.Text = TEXTO
            e.Handled = True
            TXTCORRELATIVONUEVA.Select(TXTCORRELATIVONUEVA.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTCORRELATIVONUEVA_TextChanged(sender As Object, e As EventArgs) Handles TXTCORRELATIVONUEVA.TextChanged
        LBCN.Text = CStr(Len(TXTCORRELATIVONUEVA.Text))
    End Sub

    Private Sub BTNMODIFICAR_Click(sender As Object, e As EventArgs) Handles BTNMODIFICAR.Click
        If CMBCLASIFICACION.Text <> "" And (TXTCORRELATIVONUEVA.Text <> "" Or TXTCORRELATIVONUEVA.Text = "0000-0000") And _
            (TXTIDENTIDADNUEVA.Text <> "0000-0000-00000") Then
            MODIFICAR_IDENTIDAD()
        ElseIf CMBCLASIFICACION.Text <> "" And (TXTIDENTIDADNUEVA.Text <> "" Or TXTIDENTIDADNUEVA.Text = "0000-0000-00000") And _
            (TXTCORRELATIVONUEVA.Text <> "0000-0000") Then
            MODIFICA_CORRELATIVO()
        ElseIf CMBCLASIFICACION.Text <> "" And TXTCORRELATIVONUEVA.Text <> "0000-0000" And TXTIDENTIDADNUEVA.Text <> "0000-0000-00000" And _
            TXTCORRELATIVONUEVA.Text <> "" And TXTIDENTIDADNUEVA.Text <> "" Then
            MODIFICAR_IDENTIDAD()
        End If
    End Sub

    Private Sub CMBCLASIFICACION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBCLASIFICACION.SelectedIndexChanged
        CMBCLASIFICACION.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBCLASIFICACION.Text <> "" Then
            CMBNACIONALIDAD.Enabled = True
            CMBNACIONALIDAD.Text = ""
            CMBBUSQUEDA.Text = ""
        End If
    End Sub

    Private Sub CMBESTADO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBESTADO.SelectedIndexChanged
        CMBESTADO.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub TXTTELEFONO1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTELEFONO1.KeyPress
        Dim TEXTO As String = TXTTELEFONO1.Text
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

        If TXTTELEFONO1.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTTELEFONO1.Text = TEXTO
            e.Handled = True
            TXTTELEFONO1.Select(TXTTELEFONO1.Text.Length, 0)
        End If
    End Sub

    Private Sub TXTTELEFONO1_TextChanged(sender As Object, e As EventArgs) Handles TXTTELEFONO1.TextChanged

    End Sub

    Private Sub TXTTELEFONO2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTELEFONO2.KeyPress
        Dim TEXTO As String = TXTTELEFONO2.Text
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If

        If TXTTELEFONO2.Text.Length = 4 Then
            TEXTO = TEXTO + "-" + e.KeyChar
            TXTTELEFONO2.Text = TEXTO
            e.Handled = True
            TXTTELEFONO2.Select(TXTTELEFONO2.Text.Length, 0)
        End If
    End Sub

    Private Sub CMBNUEVO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNUEVO.SelectedIndexChanged
        CMBNUEVO.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class