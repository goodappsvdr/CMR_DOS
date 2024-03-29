﻿Imports CMR_DOS.AD
Imports System.Drawing.Printing
Imports System.IO

Public Class FrmSeccionesTipoCliente
    Dim ID_Turno As Double
    Dim idturno As Integer

    Private Sub FrmPrincipalCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PrintDocument1.PrintController = New System.Drawing.Printing.StandardPrintController()
        ' cargarBotones()
        'ProgressBar1.Maximum = 10
        'ProgressBar1.Minimum = 0
        'ProgressBar1.Visible = False
        Timer3.Start()

    End Sub

    'Private Sub cargarBotones()

    '    Dim I As Integer = 1
    '    Dim oObjeto As New Secciones
    '    Dim G_SeccionTable As DataTable = oObjeto.Secciones_BuscarTodosporEstadoyUsuario(G_UserID).Tables(0)

    '    If G_SeccionTable.Rows.Count > 0 Then
    '        If G_SeccionTable.Rows.Count = 1 Then
    '            Dim id_seccion As String = G_SeccionTable.Rows(0).Item("id_Seccion")
    '            ' FrmSeccionesTipoCliente.Show()
    '            'Me.Dispose()
    '        Else
    '            For Each fila As DataRow In G_SeccionTable.Rows

    '                Dim b As New PictureBox()
    '                b.Text = CStr(fila("Nombre"))
    '                b.Name = CStr(fila("id_seccion")) & "a"

    '                Dim myFontpredet As System.Drawing.Font = b.Font
    '                Dim fontsizepredet As Double = myFontpredet.Size
    '                Dim heightpredet As Double = b.Height
    '                If G_SeccionTable.Rows.Count >= 5 Then
    '                    b.Height = Panel1.Height / G_SeccionTable.Rows.Count - 4
    '                Else
    '                    b.Height = Panel1.Height / 5 - 4
    '                End If

    '                b.Left = 10
    '                b.Width = Panel1.Width - 20

    '                b.Top = (I - 1) * (b.Height + 3)
    '                b.ForeColor = Color.White
    '                Dim newfontsize As Double = ((b.Height * fontsizepredet) / heightpredet) * 0.5
    '                Dim fontsizereal As Single = newfontsize
    '                Dim myFont As System.Drawing.Font
    '                myFont = New System.Drawing.Font("Segoe UI", fontsizereal, FontStyle.Bold Or FontStyle.Italic)
    '                b.Font = myFont

    '                'Opcional, conectar el evento click:
    '                AddHandler b.Click, AddressOf Button_Click
    '                Panel1.Controls.Add(b)
    '                I += 1

    '            Next
    '        End If
    '    End If

    'End Sub

    Private Sub CmdAceptar_Click(sender As System.Object, e As System.EventArgs)
        G_SecciontipoTable = Nothing
        g_seccionID = Nothing
        FrmPrincipalCliente.Show()
        Me.Dispose()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Timer2.Enabled = True
        'ProgressBar1.Visible = True
        Dim id_secciontipo As String = CType(sender, System.Windows.Forms.Button).Name.ToString
        Dim ID_Rresolucion As Integer = 0

        Dim oSeccionesTipos As New SeccionesTipo
        Dim oTurno As New Turnos
        Dim oDsConsultaTurno As New DataSet
        Dim oDsTurno As New DataSet
        Dim id As Integer = CType(Mid(id_secciontipo, 1, Len(id_secciontipo) - 1), Integer)
        Dim oDS As New DataSet

        oDS = oSeccionesTipos.ConsultaParaAgregarTurno(id)
        oDsConsultaTurno = oTurno.BuscarporSeccionyFecha(CType(oDS.Tables(0).Rows(0).Item("Id_Seccion"), Integer))
        If oDsConsultaTurno.Tables(0).Rows.Count > 0 Then
            ID_Turno = oTurno.Agregar(oDS.Tables(0).Rows(0).Item("id_Seccion"),
                                      oDS.Tables(0).Rows(0).Item("CodigoSeccion"),
                                      ValorEstado("Turnos", "GENERADO"),
                                      CType(oDsConsultaTurno.Tables(0).Rows(0).Item("nroTurno"), Integer) + 1, False)
            '  ImprimirTurno(ID_Turno)
            idturno = ID_Turno
            PrintDocument1.PrinterSettings.DefaultPageSettings.Landscape = False
            PrintDocument1.Print()

        Else
            ID_Turno = oTurno.AgregarPrimero(oDS.Tables(0).Rows(0).Item("id_Seccion"),
                                      oDS.Tables(0).Rows(0).Item("CodigoSeccion"),
                                      ValorEstado("Turnos", "GENERADO"), False)
            ' ImprimirTurno(ID_Turno)
            idturno = ID_Turno
            PrintDocument1.PrinterSettings.DefaultPageSettings.Landscape = False
            PrintDocument1.Print()


        End If
        Dim os As New Secciones
        Dim G_SeccionTable As DataTable = os.Secciones_BuscarTodosporEstadoyUsuario(G_UserID).Tables(0)
        If G_SeccionTable.Rows.Count > 1 Then
            FrmPrincipalCliente.Show()
            Me.Dispose()
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim ods As New DataSet
        Dim oTurno As New Turnos
        ods = oTurno.BuscarPorID(idturno)
        Dim NombreSeccion As String = ods.Tables(0).Rows(0).Item("Seccion")
        Dim fechaObtencion As DateTime = ods.Tables(0).Rows(0).Item("FechaObtencion")
        Dim Codigo As String = ods.Tables(0).Rows(0).Item("Turno")

        Dim texto1 As String
        Dim texto2 As String
        Dim texto3 As String

        texto1 = ValorParametro("TICKET", "ENCABEZADO") & vbCrLf & ValorParametro("TICKET", "TITULO") & vbCrLf & "********************************" _
            & vbCrLf & fechaObtencion & vbCrLf & NombreSeccion _
            & vbCrLf & "INTERNO " & idturno
        ' & vbCrLf & objeto & vbCrLf & Codigo & NroTurno & vbCrLf & "********************************" _
        ' & vbCrLf & pie

        texto2 = ValorParametro("TICKET", "OBJETO") & vbCrLf & Codigo & vbCrLf '& "********************************"

        texto3 = "********************************" & vbCrLf & ValorParametro("TICKET", "PIE") & vbCrLf & ValorParametro("TICKET", "WEB")

        Static intCurrentChar As Int32

        Dim font As New Font("Verdana", 8)
        Dim font1 As New Font("Verdana", 40)
        Dim font2 As New Font("Verdana", 8)

        Dim PrintAreaHeight, PrintAreaWidth, marginLeft, marginTop As Int32
        Dim PrintAreaHeight1, PrintAreaHeight2 As Int32

        With PrintDocument1.DefaultPageSettings

            .Margins.Left = 5
            .Margins.Right = 5
            .Margins.Top = 5
            .Margins.Bottom = 5

            PrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            PrintAreaHeight1 = .PaperSize.Height - .Margins.Top + 90 - .Margins.Bottom
            PrintAreaHeight2 = .PaperSize.Height - .Margins.Top + 250 - .Margins.Bottom

            PrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right


            marginLeft = .Margins.Left

            marginTop = .Margins.Top

        End With

        Dim intLineCount As Int32 = CInt(PrintAreaHeight / font.Height)


        Dim rectPrintingArea As New RectangleF(marginLeft, marginTop, PrintAreaWidth, PrintAreaHeight)
        Dim areaimpr2 As New Rectangle(marginLeft, marginTop + 90, PrintAreaWidth, PrintAreaHeight1)
        Dim areaimpr3 As New Rectangle(marginLeft, marginTop + 250, PrintAreaWidth, PrintAreaHeight2)

        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)

        Dim intLinesFilled, intCharsFitted As Int32

        e.Graphics.MeasureString(Mid(texto1, intCurrentChar + 1), font, New SizeF(PrintAreaWidth, PrintAreaHeight), fmt, intCharsFitted, intLinesFilled)
        e.Graphics.MeasureString(texto2, font1)
        e.Graphics.MeasureString(texto3, font2)

        e.Graphics.DrawString(Mid(texto1, intCurrentChar + 1), font, Brushes.Black, rectPrintingArea, fmt)
        e.Graphics.DrawString(texto2, font1, Brushes.Black, areaimpr2)
        e.Graphics.DrawString(texto3, font2, Brushes.Black, areaimpr3)
        intCurrentChar += intCharsFitted



    End Sub



    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LblFechayHs.Text = DateTime.Now.ToString
    End Sub

    'Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
    '    'If ProgressBar1.Value >= ProgressBar1.Maximum Then
    '    '    ProgressBar1.Value = 0
    '    '    ProgressBar1.Visible = False
    '    '    Timer2.Enabled = False
    '    'End If
    '    'ProgressBar1.Value += 1
    'End Sub

    Dim SEGUNDOS As Double = 0
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        SEGUNDOS = SEGUNDOS + 1
        If SEGUNDOS = 300 Then
            Timer3.Stop()
            SEGUNDOS = 0
            FrmPrincipalCliente.Show()
            Me.Dispose()
        End If

    End Sub

    Private Sub ImprimirTurnoPicture(ByVal IDSeccion As Integer)
        Timer2.Enabled = True
        '  ProgressBar1.Visible = True

        Dim oSeccionesTipos As New SeccionesTipo
        Dim oTurno As New Turnos
        Dim oDsConsultaTurno As New DataSet
        Dim oDsTurno As New DataSet
        Dim oDS As New DataSet
        Try


            oDS = oSeccionesTipos.ConsultaParaAgregarTurno(IDSeccion)
            oDsConsultaTurno = oTurno.BuscarporSeccionyFecha(CType(oDS.Tables(0).Rows(0).Item("Id_Seccion"), Integer))
            If oDsConsultaTurno.Tables(0).Rows.Count > 0 Then
                ID_Turno = oTurno.Agregar(oDS.Tables(0).Rows(0).Item("id_Seccion"),
                                          oDS.Tables(0).Rows(0).Item("CodigoSeccion"),
                                          ValorEstado("Turnos", "GENERADO"),
                                          CType(oDsConsultaTurno.Tables(0).Rows(0).Item("nroTurno"), Integer) + 1, False)
                '  ImprimirTurno(ID_Turno)
                idturno = ID_Turno
                PrintDocument1.Print()
            Else
                ID_Turno = oTurno.AgregarPrimero(oDS.Tables(0).Rows(0).Item("id_Seccion"),
                                          oDS.Tables(0).Rows(0).Item("CodigoSeccion"),
                                          ValorEstado("Turnos", "GENERADO"),
                                          False)
                ' ImprimirTurno(ID_Turno)
                idturno = ID_Turno
                PrintDocument1.Print()

            End If
            'Dim ID_Usuario As Integer = BuscarOperadorLibre(ID_Turno, IDSeccion)
            'If ID_Usuario > 0 Then
            '    LlamarSiguiente(ID_Turno, IDSeccion, ID_Usuario)

            'End If

        Catch ex As Exception

        Finally
            oSeccionesTipos = Nothing
            oTurno = Nothing
            oDsConsultaTurno = Nothing
            oDsTurno = Nothing
            oDS = Nothing
            FrmPrincipalCliente.Show()
            Me.Dispose()

        End Try
    End Sub


    Private Sub Btn_Energia_Click(sender As Object, e As EventArgs) Handles Btn_Energia.Click
        ImprimirTurnoPicture(CInt(ValorParametro("SECCION", "ENERGIA")))
    End Sub

    Private Sub Btn_Internet_Click(sender As Object, e As EventArgs) Handles Btn_Internet.Click
        ImprimirTurnoPicture(CInt(ValorParametro("SECCION", "INTERNET")))
    End Sub

    Private Sub Btn_Telefonia_Click(sender As Object, e As EventArgs) Handles Btn_Telefonia.Click
        ImprimirTurnoPicture(CInt(ValorParametro("SECCION", "TELEFONIA")))
    End Sub

    Private Sub Btn_Television_Click_1(sender As Object, e As EventArgs) Handles Btn_Television.Click
        ImprimirTurnoPicture(CInt(ValorParametro("SECCION", "TELEVISION")))
    End Sub

    Private Sub Btn_Servicios_Click_1(sender As Object, e As EventArgs) Handles Btn_Servicios.Click
        ImprimirTurnoPicture(CInt(ValorParametro("SECCION", "SERVICIOSSOCIALES")))
    End Sub

    Private Sub Btn_Cementerio_Click(sender As Object, e As EventArgs) Handles Btn_Cementerio.Click
        ImprimirTurnoPicture(CInt(ValorParametro("SECCION", "CEMENTERIOPARQUE")))
    End Sub

    Private Sub Btn_Amicos_Click(sender As Object, e As EventArgs) Handles Btn_Amicos.Click
        ImprimirTurnoPicture(CInt(ValorParametro("SECCION", "AMICOS")))
    End Sub

    Private Sub Btn_Otros_Click(sender As Object, e As EventArgs) Handles Btn_Otros.Click
        ImprimirTurnoPicture(CInt(ValorParametro("SECCION", "OTROS")))
    End Sub
    Public Function LlamarSiguiente(ByVal ID As Integer, ByVal Seccion As Integer, ByVal ID_Usuario As Integer) As Boolean

        Dim oDs As New DataSet
        Dim oObjeto As New Turnos
        Dim ods2 As New DataSet
        Dim oAuditoria As New AuditoriasUsuarios
        Try
            OrdenPantalla(ID)

            ods2 = oObjeto.llamarTurno(ID,
                                       ValorEstado("Turnos", "Llamado"),
                                        ID_Usuario,
                                        Seccion)
            oAuditoria.ModificarEstado(ID_Usuario, ValorEstado("OPERARIO", "OCUPADO"), True)

            Return True

        Catch ex As Exception
            Return False
        Finally
            oDs = Nothing
            oObjeto = Nothing
            ods2 = Nothing
            oAuditoria = Nothing
        End Try

    End Function

    Private Sub OrdenPantalla(id_turno As Integer)

        Dim ods As New DataSet
        Dim ot As New Turnos
        Dim ultimo As Integer

        Dim ods2 As New DataSet
        Dim oObjeto As New Turnos
        Try
            ods = ot.Turnos_Buscarultimoordenpantalla()
            If ods.Tables(0).Rows.Count < 1 Then

                ultimo = 1
            Else

                If ods.Tables(0).Rows(0).Item("OrdenPantalla").ToString = "" Then

                    ultimo = 1
                Else

                    ultimo = ods.Tables(0).Rows(0).Item("OrdenPantalla")
                    ultimo = ultimo + 1

                End If

            End If

            ods = oObjeto.Turnos_AgregarOrdenPantalla(id_turno, ultimo)

        Catch ex As Exception

        Finally

            ods = Nothing
            ot = Nothing
            ultimo = Nothing

            ods2 = Nothing
            oObjeto = Nothing
        End Try



    End Sub
    'Private Function BuscarOperadorLibre(ByVal ID_Turno As Integer, ByVal ID_Seccion As Integer) As Integer
    '    Dim oDs As New DataSet
    '    Dim ods2 As New DataSet
    '    Dim oObjeto As New AuditoriasUsuarios
    '    Dim oUsaurioTurno As New UsuariosTurnos
    '    oDs = oObjeto.BuscarOperadorLibrePor_Seccion(ID_Seccion)
    '    Try
    '        If oDs.Tables(0).Rows.Count > 0 Then

    '            oUsaurioTurno.Agregar(oDs.Tables(0).Rows(0).Item("ID_AuditoriaUsuario"),
    '                                      oDs.Tables(0).Rows(0).Item("ID_Usuario"),
    '                                      ID_Turno,
    '                                      FechaHoraServidor,
    '                                      ValorEstado("Turnos", "Llamado"))

    '            Return oDs.Tables(0).Rows(0).Item("ID_Usuario")

    '        Else
    '            Return 0
    '        End If
    '    Catch ex As Exception

    '        Return 0

    '    Finally
    '        oDs = Nothing
    '        ods2 = Nothing
    '        oObjeto = Nothing
    '        oUsaurioTurno = Nothing
    '    End Try

    'End Function

End Class
