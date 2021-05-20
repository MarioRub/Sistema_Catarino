Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class BUSCAR_CENSO
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BUSCAR_CENSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBID.Checked = True
        BTNBUSCAR.Enabled = True
    End Sub
    Sub NOMBRECOMPLETO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SET LANGUAGE SPANISH SELECT IDENTIDAD, PRIMER_NOMBRE, SEGUNDO_NOMBRE, PRIMER_APELLIDO, " _
        & "SEGUNDO_APELLIDO, FORMAT(CONVERT(DATE,FECHA_NAC,0),'dd/MMM/yyyy') AS FECHA " _
        & "FROM CENSO WHERE (PRIMER_NOMBRE LIKE '" & "%" & PNOMBRE.Text & "%" _
        & "') AND (SEGUNDO_NOMBRE LIKE '" & "%" & SNOMBRE.Text & "%" _
        & "') AND (PRIMER_APELLIDO LIKE '" & "%" & PAPELLIDO.Text & "%" _
        & "') AND (SEGUNDO_APELLIDO LIKE '" & "%" & SAPELLIDO.Text & "%" & "') ORDER BY IDENTIDAD ASC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("IDENTIDAD").Width = 150
                DGVGENERAL.Columns("PRIMER_NOMBRE").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_NOMBRE").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("FECHA").Width = 100 'DAR ANCGO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '0
                DGVGENERAL.Columns("PRIMER_NOMBRE").HeaderText = "PRIMER NOMBRE" '1
                DGVGENERAL.Columns("SEGUNDO_NOMBRE").HeaderText = "SEGUNDO NOMBRE" '2
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '3
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO_APELLIDO" '4
                DGVGENERAL.Columns("FECHA").HeaderText = "FECHA NAC." '5
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBID.Checked = False
                CBNOMBRE.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub NOMBRESIN2()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SET LANGUAGE SPANISH SELECT IDENTIDAD, PRIMER_NOMBRE, SEGUNDO_NOMBRE, PRIMER_APELLIDO, " _
        & "SEGUNDO_APELLIDO, FORMAT(CONVERT(DATE,FECHA_NAC,0),'dd/MMM/yyyy') AS FECHA " _
        & "FROM CENSO WHERE (PRIMER_NOMBRE LIKE '" & "%" & PNOMBRE.Text & "%" _
        & "') AND (PRIMER_APELLIDO LIKE '" & "%" & PAPELLIDO.Text & "%" _
        & "') AND (SEGUNDO_APELLIDO LIKE '" & "%" & SAPELLIDO.Text & "%" & "') ORDER BY IDENTIDAD ASC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("IDENTIDAD").Width = 150
                DGVGENERAL.Columns("PRIMER_NOMBRE").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_NOMBRE").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("FECHA").Width = 100 'DAR ANCGO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '0
                DGVGENERAL.Columns("PRIMER_NOMBRE").HeaderText = "PRIMER NOMBRE" '1
                DGVGENERAL.Columns("SEGUNDO_NOMBRE").HeaderText = "SEGUNDO NOMBRE" '2
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '3
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO_APELLIDO" '4
                DGVGENERAL.Columns("FECHA").HeaderText = "FECHA NAC." '5
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBID.Checked = False
                CBNOMBRE.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub NOMBRESIN2APELLIDO()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SET LANGUAGE SPANISH SELECT IDENTIDAD, PRIMER_NOMBRE, SEGUNDO_NOMBRE, PRIMER_APELLIDO, " _
        & "SEGUNDO_APELLIDO, FORMAT(CONVERT(DATE,FECHA_NAC,0),'dd/MMM/yyyy') AS FECHA " _
        & "FROM CENSO WHERE (PRIMER_NOMBRE LIKE '" & "%" & PNOMBRE.Text & "%" _
        & "') AND (PRIMER_APELLIDO LIKE '" & "%" & PAPELLIDO.Text & "%" _
        & "') ORDER BY IDENTIDAD ASC"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("IDENTIDAD").Width = 150
                DGVGENERAL.Columns("PRIMER_NOMBRE").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_NOMBRE").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("FECHA").Width = 100 'DAR ANCGO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '0
                DGVGENERAL.Columns("PRIMER_NOMBRE").HeaderText = "PRIMER NOMBRE" '1
                DGVGENERAL.Columns("SEGUNDO_NOMBRE").HeaderText = "SEGUNDO NOMBRE" '2
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '3
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO_APELLIDO" '4
                DGVGENERAL.Columns("FECHA").HeaderText = "FECHA NAC." '5
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBID.Checked = False
                CBNOMBRE.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub
    Sub IDENTIDAD()
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SET LANGUAGE SPANISH SELECT IDENTIDAD, PRIMER_NOMBRE, SEGUNDO_NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, " _
                                & "FORMAT(CONVERT(DATE,FECHA_NAC,0),'dd/MMM/yyyy') AS FECHA " _
                                & "FROM CENSO WHERE IDENTIDAD='" & ID1.Text & ID2.Text & ID3.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVGENERAL.DataSource = DATO
            If DATO.Rows.Count > 0 Then
                DGVGENERAL.Columns("IDENTIDAD").Width = 150
                DGVGENERAL.Columns("PRIMER_NOMBRE").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_NOMBRE").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("PRIMER_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").Width = 150 'DAR ANCGO A LA COLUMNA
                DGVGENERAL.Columns("FECHA").Width = 100 'DAR ANCGO A LA COLUMNA
                'OTORGAR EL TITULO
                DGVGENERAL.Columns("IDENTIDAD").HeaderText = "IDENTIDAD" '0
                DGVGENERAL.Columns("PRIMER_NOMBRE").HeaderText = "PRIMER NOMBRE" '1
                DGVGENERAL.Columns("SEGUNDO_NOMBRE").HeaderText = "SEGUNDO NOMBRE" '2
                DGVGENERAL.Columns("PRIMER_APELLIDO").HeaderText = "PRIMER APELLIDO" '3
                DGVGENERAL.Columns("SEGUNDO_APELLIDO").HeaderText = "SEGUNDO_APELLIDO" '4
                DGVGENERAL.Columns("FECHA").HeaderText = "FECHA NAC." '5
                Dim DGV As New DataGridViewCellStyle()
                DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVGENERAL.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            ElseIf DATO.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTRO ALMACENADO", MsgBoxStyle.Information, "AVISO DEL SISTEMA")
                CBID.Checked = False
                CBNOMBRE.Checked = False
            End If
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVGENERAL.Rows.Count
    End Sub

    Private Sub ID1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ID1.KeyPress
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If
    End Sub

    Private Sub ID1_TextChanged(sender As Object, e As EventArgs) Handles ID1.TextChanged
        If ID1.Text.Length = 4 Then
            ID2.Focus()
        End If
    End Sub

    Private Sub ID2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ID2.KeyPress
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If
    End Sub

    Private Sub ID2_TextChanged(sender As Object, e As EventArgs) Handles ID2.TextChanged
        If ID2.Text.Length = 4 Then
            ID3.Focus()
        End If
    End Sub

    Private Sub ID3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ID3.KeyPress
        If Not IsNumeric(e.KeyChar) Then 'COMPARA QUE SEA NUMERO
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then 'COMPARA SI TECLA ES BORRAR
            e.Handled = False      'PERMITE ESCRITURA
        End If
    End Sub

    Private Sub ID3_TextChanged(sender As Object, e As EventArgs) Handles ID3.TextChanged
        If ID3.Text.Length = 5 Then
            BTNBUSCAR.Focus()
        End If
    End Sub

    Private Sub PNOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PNOMBRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub PNOMBRE_TextChanged(sender As Object, e As EventArgs) Handles PNOMBRE.TextChanged

    End Sub

    Private Sub SNOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SNOMBRE.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub SNOMBRE_TextChanged(sender As Object, e As EventArgs) Handles SNOMBRE.TextChanged

    End Sub

    Private Sub PAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PAPELLIDO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub PAPELLIDO_TextChanged(sender As Object, e As EventArgs) Handles PAPELLIDO.TextChanged

    End Sub

    Private Sub SAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SAPELLIDO.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar) 'solo mayusculas
    End Sub

    Private Sub SAPELLIDO_TextChanged(sender As Object, e As EventArgs) Handles SAPELLIDO.TextChanged

    End Sub

    Private Sub CBID_CheckedChanged(sender As Object, e As EventArgs) Handles CBID.CheckedChanged
        If CBID.Checked = True Then
            DGVGENERAL.Columns.Clear()
            ID1.Text = "" : ID2.Text = "" : ID3.Text = ""
            PNOMBRE.Text = "" : SNOMBRE.Text = "" : PAPELLIDO.Text = "" : SAPELLIDO.Text = ""
            CBNOMBRE.Checked = False
            PNOMBRE.Enabled = False : SNOMBRE.Enabled = False : PAPELLIDO.Enabled = False : SAPELLIDO.Enabled = False
            ID1.Enabled = True : ID2.Enabled = True : ID3.Enabled = True
        ElseIf CBID.Checked = False Then
            DGVGENERAL.Columns.Clear()
            ID1.Text = "" : ID2.Text = "" : ID3.Text = ""
            PNOMBRE.Text = "" : SNOMBRE.Text = "" : PAPELLIDO.Text = "" : SAPELLIDO.Text = ""
            CBNOMBRE.Checked = True
            PNOMBRE.Enabled = True : SNOMBRE.Enabled = True : PAPELLIDO.Enabled = True : SAPELLIDO.Enabled = True
            ID1.Enabled = False : ID2.Enabled = False : ID3.Enabled = False
        End If
    End Sub

    Private Sub CBNOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles CBNOMBRE.CheckedChanged
        If CBNOMBRE.Checked = True Then
            DGVGENERAL.Columns.Clear()
            TXTTOTAL.Clear()
            ID1.Text = "" : ID2.Text = "" : ID3.Text = ""
            PNOMBRE.Text = "" : SNOMBRE.Text = "" : PAPELLIDO.Text = "" : SAPELLIDO.Text = ""
            CBID.Checked = False
            PNOMBRE.Enabled = True : SNOMBRE.Enabled = True : PAPELLIDO.Enabled = True : SAPELLIDO.Enabled = True
            ID1.Enabled = False : ID2.Enabled = False : ID3.Enabled = False
        ElseIf CBNOMBRE.Checked = False Then
            DGVGENERAL.Columns.Clear()
            TXTTOTAL.Clear()
            ID1.Text = "" : ID2.Text = "" : ID3.Text = ""
            PNOMBRE.Text = "" : SNOMBRE.Text = "" : PAPELLIDO.Text = "" : SAPELLIDO.Text = ""
            CBID.Checked = True
            PNOMBRE.Enabled = False : SNOMBRE.Enabled = False : PAPELLIDO.Enabled = False : SAPELLIDO.Enabled = False
            ID1.Enabled = True : ID2.Enabled = True : ID3.Enabled = True
        End If
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        If CBID.Checked = True And CBNOMBRE.Checked = False Then
            IDENTIDAD()
        ElseIf CBID.Checked = False And CBNOMBRE.Checked = True Then
            If PNOMBRE.Text <> "" And SNOMBRE.Text = "" And PAPELLIDO.Text <> "" And SAPELLIDO.Text <> "" Then
                NOMBRESIN2()
            ElseIf PNOMBRE.Text <> "" And SNOMBRE.Text = "" And PAPELLIDO.Text <> "" And SAPELLIDO.Text = "" Then
                NOMBRESIN2APELLIDO()
            ElseIf PNOMBRE.Text <> "" And SNOMBRE.Text <> "" And PAPELLIDO.Text <> "" And SAPELLIDO.Text <> "" Then
                NOMBRECOMPLETO()
            ElseIf PNOMBRE.Text <> "" And SNOMBRE.Text <> "" And PAPELLIDO.Text <> "" And SAPELLIDO.Text = "" Then
                NOMBRECOMPLETO()
            ElseIf PNOMBRE.Text <> "" And SNOMBRE.Text <> "" And PAPELLIDO.Text = "" And SAPELLIDO.Text = "" Then
                NOMBRECOMPLETO()
            ElseIf PNOMBRE.Text <> "" And SNOMBRE.Text = "" And PAPELLIDO.Text = "" And SAPELLIDO.Text <> "" Then
                NOMBRECOMPLETO()
            ElseIf PNOMBRE.Text <> "" And SNOMBRE.Text <> "" And PAPELLIDO.Text = "" And SAPELLIDO.Text <> "" Then
                NOMBRECOMPLETO()
            ElseIf PNOMBRE.Text = "" And SNOMBRE.Text <> "" And PAPELLIDO.Text = "" And SAPELLIDO.Text <> "" Then
                NOMBRECOMPLETO()
            ElseIf PNOMBRE.Text = "" And SNOMBRE.Text <> "" And PAPELLIDO.Text <> "" And SAPELLIDO.Text <> "" Then
                NOMBRECOMPLETO()
            End If
        End If
    End Sub

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        ID1.Clear() : ID2.Clear() : ID3.Clear()
        PNOMBRE.Clear() : SNOMBRE.Clear() : PAPELLIDO.Clear() : SAPELLIDO.Clear()
        DGVGENERAL.Columns.Clear()
    End Sub

    Private Sub BTNSALIR_Click_1(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Me.Close()
    End Sub

    Private Sub BTNSALIR_Click(sender As Object, e As EventArgs)

    End Sub
End Class