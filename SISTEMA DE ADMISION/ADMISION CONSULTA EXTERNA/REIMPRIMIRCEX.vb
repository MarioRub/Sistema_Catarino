Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class REIMPRIMIRCEX
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub REIMPRIMIRCEX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBBUSQUEDA.Enabled = False
        BTNBUSQUEDA.Visible = False
        TXTIDENTIDAD.Text = ""
        TXTCORRELATIVO.Text = ""
        TXTFECHA_BUSQUEDA.Text = ""
        BTNREIMPRIMIR.Enabled = False
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        CMBNACIONALIDAD.Focus()
        CMBNACIONALIDAD.Items.Add("HONDUREÑO")
        CMBNACIONALIDAD.Items.Add("EXTRANJERO")
        CMBBUSQUEDA.Items.Add("")
        CMBBUSQUEDA.Items.Add("IDENTIDAD")
        CMBBUSQUEDA.Items.Add("CORRELATIVO")
        FN.Value = (DateTime.Now.Date)
    End Sub

    Private Sub CMBNACIONALIDAD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBNACIONALIDAD.SelectedIndexChanged
        CMBNACIONALIDAD.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBNACIONALIDAD.Text = "" Then
            TXTNOMBRES.Text = ""
            TXTPRIMERAPELLIDO.Text = ""
            TXTSEGUNDOAPELLIDO.Text = ""
            CMBSEXO.Text = ""
            TXTPAIS.Text = ""
            FN.Value = (DateTime.Now.Date)
            TXTPADRE.Text = ""
            TXTMADRE.Text = ""
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            TXTTELEFONO1.Text = ""
            TXTTELEFONO2.Text = ""
            TXTCOLONIA.Text = ""
            TXTCASA.Text = ""
            CMBDEPARTAMENTO.Text = ""
            CMBMUNICIPIO.Text = ""
            TXTFECHA_BUSQUEDA.Text = ""
            TXTCORRELATIVO.Text = ""
            TXTIDENTIDAD.Text = ""
            TXTIDENTIDAD.Enabled = False
            TXTCORRELATIVO.Enabled = False
            TXTFECHA_BUSQUEDA.Enabled = False
            BTNBUSQUEDA.Visible = False
            BTNREIMPRIMIR.Enabled = False
            CMBBUSQUEDA.Enabled = False
        ElseIf CMBNACIONALIDAD.Text = "HONDUREÑO" Or CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTNOMBRES.Text = ""
            TXTPRIMERAPELLIDO.Text = ""
            TXTSEGUNDOAPELLIDO.Text = ""
            CMBSEXO.Text = ""
            TXTPAIS.Text = ""
            FN.Value = (DateTime.Now.Date)
            TXTPADRE.Text = ""
            TXTMADRE.Text = ""
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            TXTTELEFONO1.Text = ""
            TXTTELEFONO2.Text = ""
            TXTCOLONIA.Text = ""
            TXTCASA.Text = ""
            CMBDEPARTAMENTO.Text = ""
            CMBMUNICIPIO.Text = ""
            TXTFECHA_BUSQUEDA.Text = ""
            TXTCORRELATIVO.Text = ""
            TXTIDENTIDAD.Text = ""
            TXTIDENTIDAD.Enabled = False
            TXTCORRELATIVO.Enabled = False
            TXTFECHA_BUSQUEDA.Enabled = False
            BTNBUSQUEDA.Visible = False
            BTNREIMPRIMIR.Enabled = False
            CMBBUSQUEDA.Enabled = True
        End If
    End Sub

    Private Sub CMBBUSQUEDA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSQUEDA.SelectedIndexChanged
        CMBBUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList
        If CMBBUSQUEDA.Text = "" Then
            TXTNOMBRES.Text = ""
            TXTPRIMERAPELLIDO.Text = ""
            TXTSEGUNDOAPELLIDO.Text = ""
            CMBSEXO.Text = ""
            TXTPAIS.Text = ""
            FN.Value = (DateTime.Now.Date)
            TXTPADRE.Text = ""
            TXTMADRE.Text = ""
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            TXTTELEFONO1.Text = ""
            TXTTELEFONO2.Text = ""
            TXTCOLONIA.Text = ""
            TXTCASA.Text = ""
            CMBDEPARTAMENTO.Text = ""
            CMBMUNICIPIO.Text = ""
            TXTFECHA_BUSQUEDA.Text = "" : TXTFECHA_BUSQUEDA.Enabled = False
            TXTCORRELATIVO.Text = "" : TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = False
            BTNBUSQUEDA.Visible = False
            BTNREIMPRIMIR.Enabled = False
        ElseIf CMBBUSQUEDA.Text = "IDENTIDAD" Then
            TXTNOMBRES.Text = ""
            TXTPRIMERAPELLIDO.Text = ""
            TXTSEGUNDOAPELLIDO.Text = ""
            CMBSEXO.Text = ""
            TXTPAIS.Text = ""
            FN.Value = (DateTime.Now.Date)
            TXTPADRE.Text = ""
            TXTMADRE.Text = ""
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            TXTTELEFONO1.Text = ""
            TXTTELEFONO2.Text = ""
            TXTCOLONIA.Text = ""
            TXTCASA.Text = ""
            CMBDEPARTAMENTO.Text = ""
            CMBMUNICIPIO.Text = ""
            TXTFECHA_BUSQUEDA.Text = "" : TXTFECHA_BUSQUEDA.Enabled = False
            TXTCORRELATIVO.Text = "0000-0000" : TXTCORRELATIVO.Enabled = False
            TXTIDENTIDAD.Text = "" : TXTIDENTIDAD.Enabled = True
            BTNBUSQUEDA.Visible = False
            BTNREIMPRIMIR.Enabled = False
        ElseIf CMBBUSQUEDA.Text = "CORRELATIVO" Then
            TXTNOMBRES.Text = ""
            TXTPRIMERAPELLIDO.Text = ""
            TXTSEGUNDOAPELLIDO.Text = ""
            CMBSEXO.Text = ""
            TXTPAIS.Text = ""
            FN.Value = (DateTime.Now.Date)
            TXTPADRE.Text = ""
            TXTMADRE.Text = ""
            TXTEDAD.Text = ""
            CMBTIPO.Text = ""
            TXTTELEFONO1.Text = ""
            TXTTELEFONO2.Text = ""
            TXTCOLONIA.Text = ""
            TXTCASA.Text = ""
            CMBDEPARTAMENTO.Text = ""
            CMBMUNICIPIO.Text = ""
            TXTFECHA_BUSQUEDA.Text = "" : TXTFECHA_BUSQUEDA.Enabled = False
            TXTCORRELATIVO.Text = "" : TXTCORRELATIVO.Enabled = True
            TXTIDENTIDAD.Text = "0000-0000-00000" : TXTIDENTIDAD.Enabled = False
            BTNBUSQUEDA.Visible = False
            BTNREIMPRIMIR.Enabled = False
        End If
    End Sub

    Private Sub TXTIDENTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTIDENTIDAD.KeyPress
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
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
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            If Char.IsSeparator(e.KeyChar) Then
                e.Handled = True
                MsgBox("NO SE PERMITEN ESPACIOS", MsgBoxStyle.Critical, "ALERTA")
            End If
        End If
    End Sub

    Private Sub TXTIDENTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTIDENTIDAD.TextChanged
        If CMBNACIONALIDAD.Text = "HONDUREÑO" Then
            TXTIDENTIDAD.MaxLength = 15
            If TXTIDENTIDAD.Text.Length = 15 Then
                BTNBUSQUEDA.Visible = True
            ElseIf TXTIDENTIDAD.Text.Length < 15 Then
                BTNBUSQUEDA.Visible = False
            End If
        ElseIf CMBNACIONALIDAD.Text = "EXTRANJERO" Then
            TXTIDENTIDAD.MaxLength = 30
            TXTIDENTIDAD.CharacterCasing = CharacterCasing.Upper
            If TXTIDENTIDAD.Text.Length >= 6 Then
                BTNBUSQUEDA.Visible = True
            ElseIf TXTIDENTIDAD.Text.Length <= 5 Then
                BTNBUSQUEDA.Visible = False
            End If
        End If
        LBIDENTIDAD.Text = CStr(Len(TXTIDENTIDAD.Text))
        TXTIDENTIDAD.Focus()
    End Sub

    Private Sub TXTCORRELATIVO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCORRELATIVO.KeyPress
        Dim TEXTO As String = TXTCORRELATIVO.Text
        If Char.IsNumber(e.KeyChar) Then 'COMPARA SI ES NUMERO
            e.Handled = False 'PERMITE ESCRITURA
        ElseIf Char.IsControl(e.KeyChar) Then 'COMPARA SI TECLA ES BORAR
            e.Handled = False 'PERMITE ESCRITURA
        Else
            e.Handled = True 'NO PERMITE ESCRITURA
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
        TXTCORRELATIVO.Focus()
        If TXTCORRELATIVO.Text.Length >= 6 Then
            BTNBUSQUEDA.Visible = True
        ElseIf TXTCORRELATIVO.Text.Length <= 5 Then
            BTNBUSQUEDA.Visible = False
        End If
    End Sub

    Private Sub BTNBUSQUEDA_Click(sender As Object, e As EventArgs) Handles BTNBUSQUEDA.Click
        If (TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000") Or _
            (TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000") Then
            BUSCAR_CITA.LBIDENTIDAD.Text = TXTIDENTIDAD.Text
        ElseIf TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
            BUSCAR_CITA.LBIDENTIDAD.Text = TXTCORRELATIVO.Text
        End If
        BUSCAR_CITA.Show()
    End Sub
    Sub IMPRIMIR_ATENCION()
        If MsgBox("DESEA IMPRIMIR HOJA DE ATENCION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            Dim CLINICA As String = ""
            Dim REPORT As New ATENCION
            If TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CLINICA = TXTCORRELATIVO.Text
                REPORT.SetParameterValue("TXTID", LBCORRELATIVO.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000" Then
                CLINICA = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CLINICA = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            End If
            REPORT.SetParameterValue("TXTPRIMER", TXTPRIMERAPELLIDO.Text)
            REPORT.SetParameterValue("TXTSEGUNDO", TXTSEGUNDOAPELLIDO.Text)
            REPORT.SetParameterValue("TXTNOMBRE", TXTNOMBRES.Text)
            REPORT.SetParameterValue("TXTSEXO", CMBSEXO.Text)
            REPORT.SetParameterValue("TXTCLINICA", CLINICA)
            REPORT.SetParameterValue("TXTRESPONSABLE", TXTMADRE.Text)
            REPORT.SetParameterValue("TXTDIRECCION", TXTCOLONIA.Text & "," & CMBMUNICIPIO.Text & "," & CMBDEPARTAMENTO.Text)
            ATENCIONCEX.CrystalReportViewer1.ReportSource = REPORT
            ATENCIONCEX.CrystalReportViewer1.Refresh()
            ATENCIONCEX.Show()
        Else
            Me.Close()
        End If
    End Sub
    Sub IMPRIMIR_EVOLUCION()
        If MsgBox("DESEA IMPRIMIR HOJA DE EVOLUCION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            Dim TIPO As String = ""
            Dim CLINICA As String = ""
            Dim REPORT As New EVOLUCION
            If CMBTIPO.Text = "4. AÑOS" Then
                TIPO = "AÑOS"
            ElseIf CMBTIPO.Text = "3. MESES" Then
                TIPO = "MESES"
            ElseIf CMBTIPO.Text = "2. DIAS" Then
                TIPO = "DIAS"
            ElseIf CMBTIPO.Text = "1. HORAS" Then
                TIPO = "HORAS"
            End If
            If TXTIDENTIDAD.Text = "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CLINICA = TXTCORRELATIVO.Text
                REPORT.SetParameterValue("TXTID", LBCORRELATIVO.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text = "0000-0000" Then
                CLINICA = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            ElseIf TXTIDENTIDAD.Text <> "0000-0000-00000" And TXTCORRELATIVO.Text <> "0000-0000" Then
                CLINICA = TXTIDENTIDAD.Text
                REPORT.SetParameterValue("TXTID", LBIDENTIDAD.Text)
            End If
            REPORT.SetParameterValue("TXTPRIMER", TXTPRIMERAPELLIDO.Text)
            REPORT.SetParameterValue("TXTSEGUNDO", TXTSEGUNDOAPELLIDO.Text)
            REPORT.SetParameterValue("TXTNOMBRE", TXTNOMBRES.Text)
            REPORT.SetParameterValue("TXTSEXO", CMBSEXO.Text)
            REPORT.SetParameterValue("TXTCLINICA", CLINICA)
            REPORT.SetParameterValue("TXTEDAD", TXTEDAD.Text & Chr(13) & Chr(10) & TIPO)
            REPORT.SetParameterValue("TXTFN", Format(FN.Value, "dd/MMM/yyyy"))

            REPORT.SetParameterValue("TXTPRIME", TXTPRIMERAPELLIDO.Text)
            REPORT.SetParameterValue("TXTSEGUND", TXTSEGUNDOAPELLIDO.Text)
            REPORT.SetParameterValue("TXTNOMBR", TXTNOMBRES.Text)
            REPORT.SetParameterValue("TXTSEX", CMBSEXO.Text)
            REPORT.SetParameterValue("TXTCLINIC", CLINICA)
            REPORT.SetParameterValue("TXTEDA", TXTEDAD.Text & Chr(13) & Chr(10) & TIPO)
            RPEVOLUCION.CrystalReportViewer1.ReportSource = REPORT
            RPEVOLUCION.CrystalReportViewer1.Refresh()
            RPEVOLUCION.Show()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub BTNREIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNREIMPRIMIR.Click
        IMPRIMIR_ATENCION()
        IMPRIMIR_EVOLUCION()
        Me.Close()
    End Sub

    Private Sub TXTFECHA_BUSQUEDA_TextChanged(sender As Object, e As EventArgs) Handles TXTFECHA_BUSQUEDA.TextChanged
        If TXTFECHA_BUSQUEDA.Text <> "" Then
            BTNREIMPRIMIR.Enabled = True
        ElseIf TXTFECHA_BUSQUEDA.Text = "" Then
            BTNREIMPRIMIR.Enabled = False
        End If
    End Sub

    Private Sub BTNSALIR_MouseEnter(sender As Object, e As EventArgs) Handles BTNSALIR.MouseEnter
        BTNSALIR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNSALIR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNSALIR_MouseLeave(sender As Object, e As EventArgs) Handles BTNSALIR.MouseLeave
        BTNSALIR.FlatAppearance.BorderColor = Color.Silver
        BTNSALIR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNREIMPRIMIR_MouseEnter(sender As Object, e As EventArgs) Handles BTNREIMPRIMIR.MouseEnter
        BTNREIMPRIMIR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNREIMPRIMIR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNREIMPRIMIR_MouseLeave(sender As Object, e As EventArgs) Handles BTNREIMPRIMIR.MouseLeave
        BTNREIMPRIMIR.FlatAppearance.BorderColor = Color.Silver
        BTNREIMPRIMIR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNBUSQUEDA_MouseEnter(sender As Object, e As EventArgs) Handles BTNBUSQUEDA.MouseEnter
        BTNBUSQUEDA.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNBUSQUEDA.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNBUSQUEDA_MouseLeave(sender As Object, e As EventArgs) Handles BTNBUSQUEDA.MouseLeave
        BTNBUSQUEDA.FlatAppearance.BorderColor = Color.Silver
        BTNBUSQUEDA.FlatAppearance.BorderSize = 1
    End Sub
End Class