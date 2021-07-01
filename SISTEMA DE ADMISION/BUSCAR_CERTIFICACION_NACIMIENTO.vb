Imports System.Data.SqlClient

Public Class BUSCAR_CERTIFICACION_NACIMIENTO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Public ESTADO As Boolean = False

    Private Sub TXTEXPEDIENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTEXPEDIENTE.KeyPress
        Dim IDENTIDAD As String = TXTEXPEDIENTE.Text
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
        If TXTEXPEDIENTE.Text.Length = 14 Then
            BTNBUSCAR.Enabled = True
            BTNBUSCAR.Focus()
        End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then
            e.Handled = False
        End If
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SELECT ESTADO, IDENTIDAD_SOLICITANTE, NOMBRE_SOLICITANTE, TELEFONO_SOLICITANTE, IDENTIDAD_MAMA, NUMERO_GESTAS, SEXO_BEBE, FECHA_PARTO, " _
                            & "FECHA_SOLICITUD, FECHA_CERTIFICACION_ESTIMADA, FECHA_CERTIFICACION_ENTREGA FROM CERTIFICACION_NACIMIENTO WHERE IDENTIDAD_SOLICITANTE='" _
                            & TXTEXPEDIENTE.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("ESTADO").Width = 110 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD_SOLICITANTE").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("NOMBRE_SOLICITANTE").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("TELEFONO_SOLICITANTE").Width = 130 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("IDENTIDAD_MAMA").Width = 180 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("NUMERO_GESTAS").Width = 180 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEXO_BEBE").Width = 120 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_PARTO").Width = 110 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_SOLICITUD").Width = 150 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_CERTIFICACION_ESTIMADA").Width = 180 'DAR ANCHO A LA COLUMNA
                DGVGENERAL.Columns("FECHA_CERTIFICACION_ENTREGA").Width = 130 'DAR ANCHO A LA COLUMNA

                'OTORGAR EL TITULO

                DGVGENERAL.Columns("ESTADO").HeaderText = "ESTADO"
                DGVGENERAL.Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("IDENTIDAD_SOLICITANTE").HeaderText = "IDENTIDAD SOLICITANTE"
                DGVGENERAL.Columns("IDENTIDAD_SOLICITANTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("NOMBRE_SOLICITANTE").HeaderText = "NOMBRE SOLICITANTE"
                DGVGENERAL.Columns("NOMBRE_SOLICITANTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("TELEFONO_SOLICITANTE").HeaderText = "TELEFONO SOLICITANTE"
                DGVGENERAL.Columns("TELEFONO_SOLICITANTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("IDENTIDAD_MAMA").HeaderText = "IDENTIDAD MAMA"
                DGVGENERAL.Columns("IDENTIDAD_MAMA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("NUMERO_GESTAS").HeaderText = "NUMERO DE GESTAS"
                DGVGENERAL.Columns("NUMERO_GESTAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("SEXO_BEBE").HeaderText = "SEXO DEL BEBE"
                DGVGENERAL.Columns("SEXO_BEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("FECHA_PARTO").HeaderText = "FECHA DEL PARTO"
                DGVGENERAL.Columns("FECHA_PARTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("FECHA_SOLICITUD").HeaderText = "FECHA DE SOLICITUD"
                DGVGENERAL.Columns("FECHA_SOLICITUD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("FECHA_CERTIFICACION_ESTIMADA").HeaderText = "FECHA ENTREGA DE CERTIFICACION ESTIMADA"
                DGVGENERAL.Columns("FECHA_CERTIFICACION_ESTIMADA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.Columns("FECHA_CERTIFICACION_ENTREGA").HeaderText = "FECHA DE ENTREGA DE CERTIFICACION"
                DGVGENERAL.Columns("FECHA_CERTIFICACION_ENTREGA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
                BTNCONFIRMAR.Enabled = True
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                TXTEXPEDIENTE.Text = ""
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNCONFIRMAR.Click
        Dim FECHA_ACTUAL As Date = Date.Now

        Dim ADAPTADOR2 As New SqlDataAdapter
        Dim COMANDO2 As String = "SELECT ESTADO FROM CERTIFICACION_NACIMIENTO WHERE IDENTIDAD_SOLICITANTE ='" & TXTEXPEDIENTE.Text & "'"
        Dim DATO2 As DataSet
        ADAPTADOR2 = New SqlDataAdapter(COMANDO2, CONEXION)
        DATO2 = New DataSet
        ADAPTADOR2.Fill(DATO2)

        For Each row As DataRow In DATO2.Tables(0).Rows
            If row("ESTADO").ToString() = "EN ESPERA" Then
                ESTADO = True
                Exit For
            Else
                ESTADO = False
            End If
        Next

        If ESTADO = False Then
            MsgBox("LA CERTIFICACION YA FUE ENTREGADA.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        ElseIf TXTEXPEDIENTE.Text() = "" Then
            MsgBox("NO HAY REGISTRO SELECCIONADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
        Else
            If MsgBox("ESTA SEGURO QUE DESEA CONFIRMAR LA ENTREGA DE LA CERTIFICACION", vbYesNo, "AVISO DEL SISTEMA") = vbYes Then
                CONE.Open()
                Dim GUARDAR As String = "UPDATE CERTIFICACION_NACIMIENTO SET ESTADO='" & "ENTREGADA'" & " ,FECHA_CERTIFICACION_ENTREGA='" & FECHA_ACTUAL & "'   WHERE IDENTIDAD_SOLICITANTE ='" & TXTEXPEDIENTE.Text & "'"
                Dim COMAND As SqlCommand
                COMAND = New SqlCommand(GUARDAR, CONE) 'ACTUALIZAR REGISTRO EN TABLA
                COMAND.ExecuteNonQuery()
                MsgBox("ENTREGA DE CERTIFICACION CONFIRMADA.", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CONE.Close()
                Me.Close()
            Else
                Me.Dispose()
            End If
        End If



    End Sub

    Private Sub BUSCAR_CERTIFICACION_NACIMIENTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTNCONFIRMAR.Enabled = False
    End Sub
End Class