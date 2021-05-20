Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CALENDARIO_CITA
    Public CONE As SqlConnection = New SqlConnection("Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!")
    Public CONEXION As String = "Data Source=probono-db.cjy2jdticell.us-east-2.rds.amazonaws.com;Initial Catalog=ADMISION;User ID=acklen;Password=acklen11!"
    Private Sub BTNREGRESAR_Click(sender As System.Object, e As System.EventArgs) Handles BTNREGRESAR.Click
        Me.Close()
    End Sub

    Private Sub CALENDARIO_CITA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMAND As String = "SELECT CODIGO_ESPECIALIDAD, IDENTIDAD, NOMBRE, ESPECIALIDAD, CONSULTORIO, TARJETA, HORARIO, LUNES, " _
        & "MARTES, MIERCOLES, JUEVES, VIERNES, COMENTARIO, ESTADO, CUPO FROM MEDICO WHERE ESPECIALIDAD='" _
        & CMBESPECIALIDAD.Text & "' AND NOMBRE='" & CMBMEDICO.Text & "'"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMAND, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        If DATO.Rows.Count > 0 Then
            If DATO.Rows(0)("LUNES") = "SI" Then
                CBLUNES.CheckState = CheckState.Checked
            ElseIf DATO.Rows(0)("LUNES") = "NO" Then
                CBLUNES.CheckState = CheckState.Unchecked
            End If
            If DATO.Rows(0)("MARTES") = "SI" Then
                CBMARTES.CheckState = CheckState.Checked
            ElseIf DATO.Rows(0)("MARTES") = "NO" Then
                CBMARTES.CheckState = CheckState.Unchecked
            End If
            If DATO.Rows(0)("MIERCOLES") = "SI" Then
                CBMIERCOLES.CheckState = CheckState.Checked
            ElseIf DATO.Rows(0)("MIERCOLES") = "NO" Then
                CBMIERCOLES.CheckState = CheckState.Unchecked
            End If
            If DATO.Rows(0)("JUEVES") = "SI" Then
                CBJUEVES.CheckState = CheckState.Checked
            ElseIf DATO.Rows(0)("JUEVES") = "NO" Then
                CBJUEVES.CheckState = CheckState.Unchecked
            End If
            If DATO.Rows(0)("VIERNES") = "SI" Then
                CBVIERNES.CheckState = CheckState.Checked
            ElseIf DATO.Rows(0)("VIERNES") = "NO" Then
                CBVIERNES.CheckState = CheckState.Unchecked
            End If
        End If
        BTNNO.Enabled = False
        BTNACTIVO.Enabled = False
        BTNNOACTIVO.Enabled = False
        BUSCAR_ACTIVO()
    End Sub
    Sub DGVNOACTIVOS()
        If DGVACTIVO.Rows.Count > 0 Then
            Dim MisFechas As New DataSet
            Dim TFechasNoOtorgadas As New DataTable  ' Para Fechas NO Ogornadas
            Dim Fecha As Date = DateTime.Now.ToString("dd/MM/yyyy")
            '----------obtener la fecha maxima------------------
            Dim FECHAMAX As Date
            'FECHAMAX = (From FILA As DataGridViewRow In DGVACTIVO.Rows Where FILA.Cells(0).FormattedValue.ToString() <> String.Empty
            '           Select (FILA.Cells(0).FormattedValue)).Max().ToString()

            For Each row As DataGridViewRow In DGVACTIVO.Rows
                If Not row.IsNewRow Then
                    If (row.Cells(0).Value) > FECHAMAX Then
                        FECHAMAX = (row.Cells(0).Value)
                    End If
                End If
            Next
            '-------------------------------------------------------------------
            Dim clinica As String = DGVACTIVO.Rows(0).Cells(2).Value 'CONSULTORIO
            Dim CUPO_TOTAL As String = DGVACTIVO.Rows(0).Cells(3).Value 'CUPOS TOTAL
            Dim OTORGADO As Integer = 0

            Dim FechaFinale As Date = Format(CDate(FECHAMAX), "dd/MM/yyyy")
            Dim FechaNoExiste As Boolean
            TFechasNoOtorgadas.TableName = "FechasNoOtorgadas"
            TFechasNoOtorgadas.Columns.Add("FECHA_CITADO")  '0
            TFechasNoOtorgadas.Columns.Add("DIA") '1
            TFechasNoOtorgadas.Columns.Add("CONSULTORIO") '2
            TFechasNoOtorgadas.Columns.Add("CUPOS") '3
            TFechasNoOtorgadas.Columns.Add("CUPO_OTORGADO") '4
            Dim LUNES As String = ""
            Dim MARTES As String = ""
            Dim MIERCOLES As String = ""
            Dim JUEVES As String = ""
            Dim VIERNES As String = ""
            If (CBLUNES.Checked = True And CBL.Checked = False) Then
                LUNES = "LUNES"
            ElseIf (CBLUNES.Checked = False And CBL.Checked = True) Or (CBLUNES.Checked = True And CBL.Checked = True) Then
                LUNES = ""
            End If
            If (CBMARTES.Checked = True And CBM.Checked = False) Then
                MARTES = "MARTES"
            ElseIf (CBMARTES.Checked = False And CBM.Checked = True) Or (CBMARTES.Checked = True And CBM.Checked = True) Then
                MARTES = ""
            End If
            If (CBMIERCOLES.Checked = True And CBMI.Checked = False) Then
                MIERCOLES = "MIÉRCOLES"
            ElseIf (CBMIERCOLES.Checked = False And CBMI.Checked = True) Or (CBMIERCOLES.Checked = True And CBMI.Checked = True) Then
                MIERCOLES = ""
            End If
            If (CBJUEVES.Checked = True And CBJ.Checked = False) Then
                JUEVES = "JUEVES"
            ElseIf (CBJUEVES.Checked = False And CBJ.Checked = True) Or (CBJUEVES.Checked = True And CBJ.Checked = True) Then
                JUEVES = ""
            End If
            If (CBVIERNES.Checked = True And CBV.Checked = False) Then
                VIERNES = "VIERNES"
            ElseIf (CBVIERNES.Checked = False And CBV.Checked = True) Or (CBVIERNES.Checked = True And CBV.Checked = True) Then
                VIERNES = ""
            End If
            Do
                FechaNoExiste = True
                If Not ((Fecha.DayOfWeek = System.DayOfWeek.Sunday Or Fecha.DayOfWeek = System.DayOfWeek.Saturday) And _
                        (LUNES = "" Or MARTES = "" Or MIERCOLES = "" Or JUEVES = "" Or VIERNES = "")) Then  ' no incluye domingo o sabado
                    If (LUNES <> "" And UCase(Format(Fecha, "dddd")) = LUNES) Or (MARTES <> "" And UCase(Format(Fecha, "dddd")) = MARTES) _
                        Or (MIERCOLES <> "" And UCase(Format(Fecha, "dddd")) = MIERCOLES) Or _
                        (JUEVES <> "" And UCase(Format(Fecha, "dddd")) = JUEVES) Or (VIERNES <> "" And UCase(Format(Fecha, "dddd")) = VIERNES) Then
                        For R = 0 To DGVACTIVO.Rows.Count - 1 ' -2 por que DGV tiene linea vacia a la ultima, escribir -1 si el DGV no tiene la ultima linea vacia.
                            Dim FechaDGV As Date = CType(DGVACTIVO.Item(0, R).Value, Date)
                            If Fecha = FechaDGV Then   ' Entonces, este es una fecha otorgada
                                FechaNoExiste = False
                                'DIA = Char.ToUpper(Format(Fecha, "dddd"))
                                Exit For
                            End If
                        Next
                        If FechaNoExiste Then
                            TFechasNoOtorgadas.Rows.Add(Format(Fecha, "dd/MMM/yyyy"),
                                                        UCase(Format(Fecha, "dddd")),
                                                        clinica.ToString, CUPO_TOTAL.ToString, OTORGADO)
                        End If
                    End If
                End If
                Fecha = Fecha.AddDays(1)
            Loop Until Fecha > FechaFinale
            MisFechas.Tables.Add(TFechasNoOtorgadas)
            ' Llenar el DGVNoActivo con las fechas qui vienen del calculo precedente
            DGVNOACTIVO.DataSource = MisFechas.Tables("FechasNoOtorgadas")
            DGVNOACTIVO.Columns("FECHA_CITADO").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVNOACTIVO.Columns("DIA").Width = 100
            DGVNOACTIVO.Columns("CONSULTORIO").Width = 60 'DAR ANCGO A LA COLUMNA
            DGVNOACTIVO.Columns("CUPOS").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVNOACTIVO.Columns("CUPO_OTORGADO").Width = 120 'DAR ANCHO A LA COLUMNA
            DGVNOACTIVO.Columns("FECHA_CITADO").HeaderText = "FECHA CITADO" 'DAR FECHA CITADO A LA COLUMNA CARGADA DESDE TABLA
            DGVNOACTIVO.Columns("DIA").HeaderText = "DIA DE CITADO"
            DGVNOACTIVO.Columns("CONSULTORIO").HeaderText = "CLINICA" 'COLOCAR DIA DE CONSULTORIO
            DGVNOACTIVO.Columns("CUPOS").HeaderText = "CUPO TOTAL" 'DAR CUPO TOTAL A LA COLUMNA CARGADA DESDE TABLA
            DGVNOACTIVO.Columns("CUPO_OTORGADO").HeaderText = "CUPO OTORGADO" 'DAR CUPO OTORGADO A LA COLUMNA CARGADA DESDE TABLA
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVNOACTIVO.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
        ElseIf DGVACTIVO.Rows.Count = 0 Then
            MsgBox("NO EXISTEN FECHAS EN EL CUADRO DE FECHAS OTORGADAS", MsgBoxStyle.Exclamation, AcceptButton)
        End If
        TXTTOTALNO.Text = DGVNOACTIVO.Rows.Count
    End Sub
    Private Sub BTNNO_Click(sender As Object, e As EventArgs) Handles BTNNO.Click
        DGVNOACTIVOS()
    End Sub
    Sub BUSCAR_ACTIVO()
        Dim LUNES As String = ""
        Dim MARTES As String = ""
        Dim MIERCOLES As String = ""
        Dim JUEVES As String = ""
        Dim VIERNES As String = ""
        If (CBLUNES.Checked = True And CBL.Checked = False) Then
            LUNES = "LUNES"
        ElseIf (CBLUNES.Checked = False And CBL.Checked = True) Or (CBLUNES.Checked = True And CBL.Checked = True) Then
            LUNES = ""
        End If
        If (CBMARTES.Checked = True And CBM.Checked = False) Then
            MARTES = "MARTES"
        ElseIf (CBMARTES.Checked = False And CBM.Checked = True) Or (CBMARTES.Checked = True And CBM.Checked = True) Then
            MARTES = ""
        End If
        If (CBMIERCOLES.Checked = True And CBMI.Checked = False) Then
            MIERCOLES = "MIÉRCOLES"
        ElseIf (CBMIERCOLES.Checked = False And CBMI.Checked = True) Or (CBMIERCOLES.Checked = True And CBMI.Checked = True) Then
            MIERCOLES = ""
        End If
        If (CBJUEVES.Checked = True And CBJ.Checked = False) Then
            JUEVES = "JUEVES"
        ElseIf (CBJUEVES.Checked = False And CBJ.Checked = True) Or (CBJUEVES.Checked = True And CBJ.Checked = True) Then
            JUEVES = ""
        End If
        If (CBVIERNES.Checked = True And CBV.Checked = False) Then
            VIERNES = "VIERNES"
        ElseIf (CBVIERNES.Checked = False And CBV.Checked = True) Or (CBVIERNES.Checked = True And CBV.Checked = True) Then
            VIERNES = ""
        End If

        Dim ADAPTADOR As New SqlDataAdapter
        Dim COMANDO As String = "SET LANGUAGE SPANISH SELECT FECHA_CITADO,UPPER(FORMAT(CONVERT(DATE,FECHA_CITADO, 0), 'dddd')) AS DIA," _
        & " CONSULTORIO,CUPOS, COUNT(FECHA_CITADO) AS CUPO_OTORGADO FROM [ADMISION].[dbo].[BITACORA] WHERE ((ESPECIALIDAD='" _
        & CMBESPECIALIDAD.Text & "' AND MEDICO='" & CMBMEDICO.Text & "') AND " _
        & "(UPPER(FORMAT(CONVERT(DATE,FECHA_CITADO, 0), 'dddd'))='" _
        & LUNES & "' OR UPPER(FORMAT(CONVERT(DATE,FECHA_CITADO, 0), 'dddd'))='" _
        & MARTES & "' OR UPPER(FORMAT(CONVERT(DATE,FECHA_CITADO, 0), 'dddd'))='" _
        & MIERCOLES & "' OR UPPER(FORMAT(CONVERT(DATE,FECHA_CITADO, 0), 'dddd'))='" _
        & JUEVES & "' OR UPPER(FORMAT(CONVERT(DATE,FECHA_CITADO, 0), 'dddd'))='" _
        & VIERNES & "')) AND (FECHA_CITADO BETWEEN FORMAT(CONVERT(DATE,GETDATE(),0),'dd/MM/yyyy')" _
        & "AND FORMAT((SELECT MAX(FECHA_CITADO) FROM [ADMISION].[dbo].[BITACORA]),'dd/MM/yyyy'))" _
        & "GROUP BY FECHA_CITADO, CONSULTORIO, CUPOS ORDER BY FECHA_CITADO"
        Dim DATO As DataTable
        ADAPTADOR = New SqlDataAdapter(COMANDO, CONE)
        DATO = New DataTable
        ADAPTADOR.Fill(DATO)
        Try
            DGVACTIVO.DataSource = DATO
            DGVACTIVO.Columns("FECHA_CITADO").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVACTIVO.Columns("DIA").Width = 100
            DGVACTIVO.Columns("CONSULTORIO").Width = 60 'DAR ANCGO A LA COLUMNA
            DGVACTIVO.Columns("CUPOS").Width = 100 'DAR ANCHO A LA COLUMNA
            DGVACTIVO.Columns("CUPO_OTORGADO").Width = 120 'DAR ANCHO A LA COLUMNA
            DGVACTIVO.Columns("FECHA_CITADO").HeaderText = "FECHA CITADO" 'DAR FECHA CITADO A LA COLUMNA CARGADA DESDE TABLA
            DGVACTIVO.Columns("DIA").HeaderText = "DIA DE CITADO"
            DGVACTIVO.Columns("CONSULTORIO").HeaderText = "CLINICA" 'COLOCAR DIA DE CONSULTORIO
            DGVACTIVO.Columns("CUPOS").HeaderText = "CUPO TOTAL" 'DAR CUPO TOTAL A LA COLUMNA CARGADA DESDE TABLA
            DGVACTIVO.Columns("CUPO_OTORGADO").HeaderText = "CUPO OTORGADO" 'DAR CUPO OTORGADO A LA COLUMNA CARGADA DESDE TABLA
            Dim DGV As New DataGridViewCellStyle()
            DGV.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVACTIVO.ColumnHeadersDefaultCellStyle = DGV 'PONER CENTRADO EL ENCABEZADO
            BTNNO.Enabled = True
        Catch ex As Exception
            MsgBox("NO SE ESTABLECIO CONEXION POR: " & ex.ToString)
        End Try
        TXTTOTAL.Text = DGVACTIVO.Rows.Count
    End Sub

    Private Sub DGVACTIVO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVACTIVO.CellClick
        For I As Integer = 0 To DGVACTIVO.Rows.Count - 1
            If DGVACTIVO.Rows(I).Selected = True Then
                'DGVNOACTIVO.Rows(0).Selected = False
                DGVNOACTIVO.CurrentCell = Nothing
                BTNACTIVO.Enabled = True
                BTNNOACTIVO.Enabled = False
            End If
        Next
    End Sub

    Private Sub DGVACTIVO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVACTIVO.CellContentClick
        If DGVACTIVO.Rows.Count = 0 Then
            BTNACTIVO.Enabled = False
        ElseIf DGVACTIVO.Rows.Count > 0 Then
            BTNACTIVO.Enabled = True
        End If
        For I As Integer = 0 To DGVACTIVO.Rows.Count - 1
            If DGVACTIVO.Rows(I).Selected = True Then
                DGVNOACTIVO.CurrentCell = Nothing
                BTNACTIVO.Enabled = True
                BTNNOACTIVO.Enabled = False
            End If
        Next
    End Sub

    Private Sub DGVNOACTIVO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVNOACTIVO.CellClick
        For I As Integer = 0 To DGVNOACTIVO.Rows.Count - 1
            If DGVNOACTIVO.Rows(I).Selected = True Then
                'DGVACTIVO.Rows(0).Selected = False
                DGVACTIVO.CurrentCell = Nothing
                BTNACTIVO.Enabled = False
                BTNNOACTIVO.Enabled = True
            End If
        Next
    End Sub

    Private Sub DGVNOACTIVO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVNOACTIVO.CellContentClick
        If DGVNOACTIVO.Rows.Count = 0 Then
            BTNNO.Visible = True
        ElseIf DGVNOACTIVO.Rows.Count > 0 Then
            BTNNO.Visible = False
        End If
        For I As Integer = 0 To DGVNOACTIVO.Rows.Count - 1
            If DGVNOACTIVO.Rows(I).Selected = True Then
                'DGVACTIVO.Rows(0).Selected = False
                DGVACTIVO.CurrentCell = Nothing
                BTNACTIVO.Enabled = False
                BTNNOACTIVO.Enabled = True
            End If
        Next
    End Sub

    Private Sub BTNACTIVO_MouseEnter(sender As Object, e As EventArgs) Handles BTNACTIVO.MouseEnter
        BTNACTIVO.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNACTIVO.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNACTIVO_MouseLeave(sender As Object, e As EventArgs) Handles BTNACTIVO.MouseLeave
        BTNACTIVO.FlatAppearance.BorderColor = Color.Silver
        BTNACTIVO.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNNOACTIVO_Click(sender As Object, e As EventArgs) Handles BTNNOACTIVO.Click
        Dim A As Integer
        If DGVNOACTIVO.ColumnCount > 0 Then
            A = DGVNOACTIVO.CurrentRow.Index
            CITASCEX.FECHA_CITADO.Value = DGVNOACTIVO.Item(0, A).Value() 'FILA FECHA CITADO
            CITASCEX.TXTTOTAL.Text = DGVNOACTIVO.Item(3, A).Value()  'FILA CUPO TOTAL
            CITASCEX.TXTOTORGADO.Text = DGVNOACTIVO.Item(4, A).Value()  'FILA CUPO OTORGADO
        End If
        Dim TOTAL As Integer
        Dim ACTUAL As Date = Format(DateTime.Now.Date, "dd/MM/yyyy")
        Dim FECHAS As Date = DGVNOACTIVO.Item(0, A).Value()
        Do
            If Not ((ACTUAL.DayOfWeek = System.DayOfWeek.Sunday Or ACTUAL.DayOfWeek = System.DayOfWeek.Saturday)) Then
                TOTAL = TOTAL + 1
            End If
            ACTUAL = ACTUAL.AddDays(1)
        Loop Until ACTUAL >= FECHAS

        If TOTAL <= 15 Then
            CITASCEX.LBN.Text = ""
            CITASCEX.LBP.Text = TOTAL.ToString
        ElseIf TOTAL > 15 Then
            CITASCEX.LBN.Text = TOTAL.ToString
            CITASCEX.LBP.Text = ""
        End If
        Me.Close()
    End Sub

    Private Sub BTNNOACTIVO_MouseEnter(sender As Object, e As EventArgs) Handles BTNNOACTIVO.MouseEnter
        BTNNOACTIVO.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNNOACTIVO.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNNOACTIVO_MouseLeave(sender As Object, e As EventArgs) Handles BTNNOACTIVO.MouseLeave
        BTNNOACTIVO.FlatAppearance.BorderColor = Color.Silver
        BTNNOACTIVO.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNACTIVO_Click(sender As Object, e As EventArgs) Handles BTNACTIVO.Click
        Dim A As Integer
        If DGVACTIVO.ColumnCount > 0 Then
            A = DGVACTIVO.CurrentRow.Index
            CITASCEX.FECHA_CITADO.Value = DGVACTIVO.Item(0, A).Value() 'FILA FECHA CITADO
            CITASCEX.TXTTOTAL.Text = DGVACTIVO.Item(3, A).Value()  'FILA CUPO TOTAL
            CITASCEX.TXTOTORGADO.Text = DGVACTIVO.Item(4, A).Value()  'FILA CUPO OTORGADO
        End If
        Dim TOTAL As Integer
        Dim ACTUAL As Date = Format(DateTime.Now.Date, "dd/MM/yyyy")
        Dim FECHAS As Date = Format(DGVACTIVO.Item(0, A).Value(), "dd/MM/yyyy")
        Do
            If Not ((ACTUAL.DayOfWeek = System.DayOfWeek.Sunday Or ACTUAL.DayOfWeek = System.DayOfWeek.Saturday)) Then
                TOTAL = TOTAL + 1
            End If
            ACTUAL = ACTUAL.AddDays(1)
        Loop Until ACTUAL >= FECHAS

        If TOTAL <= 15 Then
            CITASCEX.LBN.Text = ""
            CITASCEX.LBP.Text = TOTAL.ToString
        ElseIf TOTAL > 15 Then
            CITASCEX.LBN.Text = TOTAL.ToString
            CITASCEX.LBP.Text = ""
        End If
        Me.Close()
    End Sub

    Private Sub BTNREGRESAR_MouseEnter(sender As Object, e As EventArgs) Handles BTNREGRESAR.MouseEnter
        BTNREGRESAR.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNREGRESAR.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNREGRESAR_MouseLeave(sender As Object, e As EventArgs) Handles BTNREGRESAR.MouseLeave
        BTNREGRESAR.FlatAppearance.BorderColor = Color.Silver
        BTNREGRESAR.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BTNNO_MouseEnter(sender As Object, e As EventArgs) Handles BTNNO.MouseEnter
        BTNNO.FlatAppearance.BorderColor = Color.DodgerBlue
        BTNNO.FlatAppearance.BorderSize = 3
    End Sub

    Private Sub BTNNO_MouseLeave(sender As Object, e As EventArgs) Handles BTNNO.MouseLeave
        BTNNO.FlatAppearance.BorderColor = Color.Silver
        BTNNO.FlatAppearance.BorderSize = 1
    End Sub
End Class