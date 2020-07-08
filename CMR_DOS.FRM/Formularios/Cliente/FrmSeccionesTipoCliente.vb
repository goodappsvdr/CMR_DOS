Imports CMR_DOS.AD
Imports System.IO

Public Class FrmSeccionesTipoCliente


    Dim ID_Turno As Double
    dim idturno As Integer




    Private Sub FrmPrincipalCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarBotones()
        ProgressBar1.Maximum = 10
        ProgressBar1.Minimum = 0
        ProgressBar1.Visible = False
        Timer3.Start()

    End Sub

    Private Sub cargarBotones()

        Dim I As Integer = 1
        Dim oObjeto As New Secciones
        Dim G_SeccionTable As DataTable = oObjeto.Secciones_BuscarTodosporEstadoyUsuario(G_UserID).Tables(0)

        If G_SeccionTable.Rows.Count > 0 Then
            If G_SeccionTable.Rows.Count = 1 Then
                Dim id_seccion As String = G_SeccionTable.Rows(0).Item("id_Seccion")
                ' FrmSeccionesTipoCliente.Show()
                'Me.Dispose()
            Else
                For Each fila As DataRow In G_SeccionTable.Rows

                    Dim b As New Button()
                    b.Text = CStr(fila("Nombre"))
                    b.Name = CStr(fila("id_seccion")) & "a"
                    Dim myFontpredet As System.Drawing.Font = b.Font
                    Dim fontsizepredet As Double = myFontpredet.Size
                    Dim heightpredet As Double = b.Height
                    If G_SeccionTable.Rows.Count >= 5 Then
                        b.Height = Panel1.Height / G_SeccionTable.Rows.Count - 4
                    Else
                        b.Height = Panel1.Height / 5 - 4
                    End If

                    b.Left = 10
                    b.Width = Panel1.Width - 20

                    b.Top = (I - 1) * (b.Height + 3)
                    b.ForeColor = Color.White
                    Dim newfontsize As Double = ((b.Height * fontsizepredet) / heightpredet) * 0.5
                    Dim fontsizereal As Single = newfontsize
                    Dim myFont As System.Drawing.Font
                    myFont = New System.Drawing.Font("Segoe UI", fontsizereal, FontStyle.Bold Or FontStyle.Italic)
                    b.Font = myFont

                    'Opcional, conectar el evento click:
                    AddHandler b.Click, AddressOf Button_Click
                    Panel1.Controls.Add(b)
                    I += 1

                Next
            End If
        End If


    End Sub

    Private Sub CmdAceptar_Click(sender As System.Object, e As System.EventArgs)
        G_SecciontipoTable = Nothing
        g_seccionID = Nothing
        FrmPrincipalCliente.Show()
        Me.Dispose()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Timer2.Enabled = True
        ProgressBar1.Visible = True
        Dim id_secciontipo As String = CType(sender, System.Windows.Forms.Button).Name.ToString

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
                                      ValorResolucion("SIN ASIGNAR", CType(oDS.Tables(0).Rows(0).Item("Id_Seccion"), Integer)),
                                    CType(oDsConsultaTurno.Tables(0).Rows(0).Item("nroTurno"), Integer) + 1,
                                    ValorMotivo("SIN ASIGNAR", CType(oDS.Tables(0).Rows(0).Item("Id_Seccion"), Integer)))
            '  ImprimirTurno(ID_Turno)
            idturno = ID_Turno
            PrintDocument1.Print()
        Else
            ID_Turno = oTurno.AgregarPrimero(oDS.Tables(0).Rows(0).Item("id_Seccion"),
                                      oDS.Tables(0).Rows(0).Item("CodigoSeccion"),
                                      ValorEstado("Turnos", "GENERADO"),
                                      ValorResolucion("SIN ASIGNAR", CType(oDS.Tables(0).Rows(0).Item("Id_Seccion"), Integer)),
                                      ValorMotivo("SIN ASIGNAR", CType(oDS.Tables(0).Rows(0).Item("Id_Seccion"), Integer)))

            ' ImprimirTurno(ID_Turno)
            idturno = ID_Turno
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

    Private Sub ImprimirTurno(id_turno As Integer)
        Dim ods As New DataSet
        Dim oTurno As New Turnos
        ods = oTurno.BuscarPorID(id_turno)
        Dim NombreSeccion As String = ods.Tables(0).Rows(0).Item("Seccion")
        Dim fechaObtencion As DateTime = ods.Tables(0).Rows(0).Item("FechaObtencion")
        Dim Codigo As String = ods.Tables(0).Rows(0).Item("Codigo")
        Dim NroTurno As Integer = ods.Tables(0).Rows(0).Item("nroTurno")


        Dim imp As New Imprimir

        If imp.OpenPort(ValorParametro("PUERTO", "IMPRESORA"), 9600, Ports.Parity.None, 8, Ports.StopBits.One) = True Then

            imp.SendCommand(imp.CMD_RESET)
            imp.SendCommand(imp.CMD_JUSTIFICAR1)
            imp.SendCommand(imp.CMD_NORMAL2)
            imp.SendText(ValorParametro("TICKET", "ENCABEZADO"))
            imp.SendCommand(imp.CMD_CR)
            imp.SendText(ValorParametro("TICKET", "TITULO"))
            imp.SendCommand(imp.CMD_CR)
            imp.SendText("********************************")
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_NORMAL2)
            imp.SendText(fechaObtencion)
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_NORMAL3)
            imp.SendText(NombreSeccion)
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_NORMAL5)
            imp.SendText(ValorParametro("TICKET", "OBJETO"))
            imp.SendCommand(imp.CMD_CR)
            imp.SendText(Codigo & NroTurno)
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_CR)
            'imp.SendCommand(imp.CMD_BARRA2)
            'imp.SendText(idturno)
            'imp.SendCommand(imp.CMD_BARRA_FIN)

            imp.SendCommand(imp.CMD_NORMAL2)
            imp.SendText("********************************")
            imp.SendCommand(imp.CMD_CR)
            imp.SendText(ValorParametro("TICKET", "PIE"))
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_LF4)
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_CORTAR)

            imp.Cerrar()


        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LblFechayHora.Text = DateTime.Now
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
            Timer2.Enabled = False

        End If
        ProgressBar1.Value += 1
    End Sub

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
End Class
