Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class PRINCIPAL
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub SALIRToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("ESTA SEGURO QUE DESEA CERRAR EL SISTEMA", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
            CONE.Open()
            Dim LOGINBD As String = "UPDATE LOGIN SET ESTATUS='OFF' WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
            Dim LOGIN As SqlCommand
            LOGIN = New SqlCommand(LOGINBD, CONE) 'INSERTAR ESTATUS
            LOGIN.ExecuteNonQuery()
            CONE.Close()
            CONE.Dispose()
            LOGIN.Dispose()
            Application.Exit()
            Me.Dispose()
        Else
            TXTIDENTIDAD.Focus()
        End If
    End Sub

    Private Sub NUEVOToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUEVOToolStripMenuItem1.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "NUEVO_USUARIO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO NUEVO USUARIO YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            NUEVO_USUARIO.MdiParent = Me
            NUEVO_USUARIO.Show()
        End If
    End Sub

    Private Sub NUEVOToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles NUEVOToolStripMenuItem2.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "IMPRONTO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO IMPRONTO YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            IMPRONTO.MdiParent = Me
            IMPRONTO.Show()
        End If
    End Sub

    Private Sub NUEVOToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles NUEVOToolStripMenuItem3.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "HOSPITALIZACION" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO HOSPITALIZACION YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            HOSPITALIZACION.MdiParent = Me
            HOSPITALIZACION.Show()
        End If
    End Sub

    Private Sub REIMPRIMIRToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles REIMPRIMIRToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "REIMPRIMIR_IMPRONTO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO REIMPRIMIR IMPRONTO YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            REIMPRIMIR_IMPRONTO.MdiParent = Me
            REIMPRIMIR_IMPRONTO.Show()
        End If
    End Sub

    Private Sub PRINCIPAL_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MsgBox("ESTA SEGURO QUE DESEA CERRAR EL SISTEMA", MsgBoxStyle.YesNo, "AVISO DEL SISTEMA") = MsgBoxResult.Yes Then
                CONE.Open()
                Dim LOGINBD As String = "UPDATE LOGIN SET ESTATUS='OFF' WHERE IDENTIDAD='" & TXTIDENTIDAD.Text & "'"
                Dim LOGIN As SqlCommand
                LOGIN = New SqlCommand(LOGINBD, CONE) 'INSERTAR ESTATUS
                LOGIN.ExecuteNonQuery()
                CONE.Close()
                CONE.Dispose()
                LOGIN.Dispose()
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub PRINCIPAL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim CTL As Control
        Dim CTRLMDI As MdiClient
        For Each CTL In Me.Controls
            Try
                CTRLMDI = CType(CTL, MdiClient)
                CTRLMDI.BackColor = Me.BackColor
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        Next
        Text = "SISTEMA DE ADMISION" & "  ( " & LOGIN.TXTUSUARIO.Text & " )  "
        FECHAYHORA.MdiParent = Me
        FECHAYHORA.Show()
        'RPIMPRONTO.Hide()
        'RPEVOLUCION.Hide()
        'ATENCIONCEX.Hide()
        'RPHOSPITALIZACION.Hide()
    End Sub
    Private Sub HOSPITALIZACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HOSPITALIZACIONToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        For Each FORMULARIO In Me.MdiChildren
            If FORMULARIO.Name = "HOSPITALIZACION" Then
                CARGADO = True
                MessageBox.Show("EL FORMULARIO HOSPITALIZACION YA ESTA ABIERTO")
                Exit For
            End If
        Next FORMULARIO
        FORMULARIO = Nothing
        If CARGADO = False Then
            'Dim MDIHOSPITALIZACION As New HOSPITALIZACION
            HOSPITALIZACION.MdiParent = Me
            HOSPITALIZACION.Show()
        End If
    End Sub

    Private Sub REIMPRIMIRToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REIMPRIMIRToolStripMenuItem1.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "REIMPRIMIR_HOSPITALIZACION" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO REIMPRIMIR HOSPITALIZACION YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            REIMPRIMIR_HOSPITALIZACION.MdiParent = Me
            REIMPRIMIR_HOSPITALIZACION.Show()
        End If
    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BUSCARToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "BUSCAR_MEDICO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO BUSCAR MEDICO YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            'Dim MDICITA As New CITASCEX
            BUSCAR_MEDICO.MdiParent = Me
            BUSCAR_MEDICO.Show()
        End If
    End Sub
    Private Sub MODIFICARREGISTROToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MODIFICARREGISTROToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "MODIFICAR_REGISTRO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO MODIFICAR REGISTRO YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            'Dim MDIMODIFICAR As New MODIFICAR_REGISTRO
            MODIFICAR_REGISTRO.MdiParent = Me
            MODIFICAR_REGISTRO.Show()
        End If
    End Sub

    Private Sub NUEVAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUEVAToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "CITASCEX" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO CITAS YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            CITASCEX.MdiParent = Me
            CITASCEX.Show()
        End If
    End Sub

    Private Sub ELIMINARToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELIMINARToolStripMenuItem1.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "ELIMINAR_CITA" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO ELIMINAR CITA YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            ELIMINAR_CITA.MdiParent = Me
            ELIMINAR_CITA.Show()
        End If
    End Sub

    Private Sub ESPECIALIDADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESPECIALIDADToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "AGREGAR_ESPECIALIDAD" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO AGREGAR ESPECIALDIAD YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            AGREGAR_ESPECIALIDAD.MdiParent = Me
            AGREGAR_ESPECIALIDAD.Show()
        End If
    End Sub

    Private Sub AGREGARFERENCIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGREGARFERENCIAToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "AGREGAR_REFERENCIA" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO CITAS YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            'AGREGAR_REFERENCIA.MdiParent = Me
            AGREGAR_REFERENCIA.Show()
        End If
    End Sub

    Private Sub BUSCARPACIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARPACIENTEToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "BUSCAR_PACIENTE" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO BUSCAR PACIENTE YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            'Dim MDICITA As New CITASCEX
            BUSCAR_PACIENTE.MdiParent = Me
            BUSCAR_PACIENTE.Show()
        End If
    End Sub

    Private Sub REIMPRIMIREXPEDIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REIMPRIMIREXPEDIENTEToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "REIMPRIMIRCEX" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO REIMPRIMIR EXPEDIENTE YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            'Dim MDICITA As New CITASCEX
            REIMPRIMIRCEX.MdiParent = Me
            REIMPRIMIRCEX.Show()
        End If
    End Sub

    Private Sub AGREGARSALASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGREGARSALASToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Application.OpenForms
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "AGREGAR_SALA" Then
                        CARGADO = True
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            'AGREGAR_SALA.MdiParent = Me
            AGREGAR_SALA.Show()
        End If
    End Sub

    Private Sub MEDICOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MEDICOToolStripMenuItem1.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "NUEVO_MEDICO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO NUEVO MEDICO YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            NUEVO_MEDICO.MdiParent = Me
            NUEVO_MEDICO.Show()
        End If
    End Sub

    Private Sub LISTADOEMPLEADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADOEMPLEADOToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "LISTA_EMPLEADO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO LISTADO DE EMPLEADO YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            LISTA_EMPLEADO.MdiParent = Me
            LISTA_EMPLEADO.Show()
        End If
    End Sub

    Private Sub NUEVOToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem4.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "HOSPITALIZACION" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO HOSPITALIZACION YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            HOSPITALIZACION.MdiParent = Me
            HOSPITALIZACION.Show()
        End If
    End Sub

    Private Sub ADMISIONEMERGENCIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMISIONEMERGENCIAToolStripMenuItem.Click

    End Sub

    Private Sub MODIFICARCLAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARCLAVEToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "CAMBIO_CLAVE" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO CAMBIO DE CLAVE YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            CAMBIO_CLAVE.MdiParent = Me
            CAMBIO_CLAVE.Show()
        End If
    End Sub

    Private Sub CITADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CITADOToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "CITADO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO CITADO YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            CITADO.MdiParent = Me
            CITADO.Show()
        End If
    End Sub

    Private Sub RECEPCIONARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECEPCIONARToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "REC_DEFUNCION" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO RECEPCION DE DEFUNCION YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            REC_DEFUNCION.MdiParent = Me
            REC_DEFUNCION.Show()
        End If
    End Sub

    Private Sub ENTREGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTREGARToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "ENT_DEFUNCION" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO RECEPCION DE DEFUNCION YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            ENT_DEFUNCION.MdiParent = Me
            ENT_DEFUNCION.Show()
        End If
    End Sub

    Private Sub REIMPRIMIRToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles REIMPRIMIRToolStripMenuItem3.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "REIMPRIMIRDEF" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO REIMPRIMIR DEFUNCION YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            REIMPRIMIRDEF.MdiParent = Me
            REIMPRIMIRDEF.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "HORA" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO HORA YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            'HORA.MdiParent = Me
            HORA.Show()
        End If
    End Sub

    Private Sub BITACORAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BITACORAToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "EMER_BITACORA" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO HISTORIAL DE EMERGENCIA YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            EMER_BITACORA.MdiParent = Me
            EMER_BITACORA.Show()
        End If
    End Sub

    Private Sub BUSCARDEFUNCIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARDEFUNCIONToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "BUSREGDEF" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO BUSCAR DEFUNCION YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            BUSREGDEF.MdiParent = Me
            BUSREGDEF.Show()
        End If
    End Sub

    Private Sub MODIFICARCONTROLDEDEFUNCIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARCONTROLDEDEFUNCIONToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "MOD_DEF" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO MODIFICAR CONTROL DE DEFUNCION YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            MOD_DEF.MdiParent = Me
            MOD_DEF.Show()
        End If
    End Sub

    Private Sub NUEVOToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem5.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "TAR_VISITA" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO TARJETA DE VISITA YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            TAR_VISITA.MdiParent = Me
            TAR_VISITA.Show()
        End If
    End Sub

    Private Sub BUSCARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem1.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "TAR_BITACORA" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO BUSCAR TARJETA DE VISITA YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            TAR_BITACORA.MdiParent = Me
            TAR_BITACORA.Show()
        End If
    End Sub

    Private Sub VACACIONESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VACACIONESToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "VACA_MEDICO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO VACACIONES DE MEDICO YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            'Dim MDICITA As New CITASCEX
            VACA_MEDICO.MdiParent = Me
            VACA_MEDICO.Show()
        End If
    End Sub

    Private Sub NUEVOUSUARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NUEVOUSUARIOToolStripMenuItem.Click

    End Sub

    Private Sub SOLICITUDEXPEDIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SOLICITUDEXPEDIENTEToolStripMenuItem.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "SOLICITUD_EXPEDIENTEARCHIVO" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO DE EXPEDIENTES YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            SOLICITUD_EXPEDIENTEARCHIVO.TXTIDENTIDAD.Text = TXTIDENTIDAD.Text
            SOLICITUD_EXPEDIENTEARCHIVO.Show()
        End If
    End Sub

    Private Sub BUSCAREXPEDIENTEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BUSCAREXPEDIENTEToolStripMenuItem1.Click
        Dim FORMULARIO As Form
        Dim CARGADO As Boolean
        CARGADO = False
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT USUARIO,ESTADO, DEPARTAMENTO, ESTATUS FROM LOGIN WHERE IDENTIDAD ='" & TXTIDENTIDAD.Text & "'"
        Dim DATO As DataSet
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONEXION)
        Try
            DATO = New DataSet
            ADAPTADOR.Fill(DATO, "LOGIN")
            For Each FORMULARIO In Me.MdiChildren
                If DATO.Tables(0).Rows(0)("ESTATUS") = "ON" Then
                    If FORMULARIO.Name = "BUSCAR_EXPEDIENTE" Then
                        CARGADO = True
                        MsgBox("EL FORMULARIO DE EXPEDIENTES YA ESTA ABIERTO POR EL USUARIO: " & Chr(13) & DATO.Tables(0).Rows(0)("USUARIO"), MsgBoxStyle.Critical, "AVISO DEL SISTEMA")
                        Exit For
                    End If
                End If
            Next FORMULARIO
            ADAPTADOR.Dispose()
            DATO.Dispose()
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("EL USUARIO NO EXISTE")
        End Try
        FORMULARIO = Nothing
        If CARGADO = False Then
            BUSCAR_EXPEDIENTE.Show()
        End If
    End Sub
End Class
