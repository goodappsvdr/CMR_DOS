Imports System.IO



Public Class FrmPruebaImpresion


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim imp As New Imprimir

        If imp.OpenPort("COM1", 9600, Ports.Parity.None, 8, Ports.StopBits.One) = True Then
            imp.SetConfigDefaultImp()

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim imp As New Imprimir

        If imp.OpenPort("COM1", 9600, Ports.Parity.None, 8, Ports.StopBits.One) = True Then

            imp.SendCommand(imp.CMD_RESET)
            imp.SendCommand(imp.CMD_JUSTIFICAR0)
            imp.SendCommand(imp.CMD_NORMAL2)
            imp.SendText("Municipalidad de Villa del Rosario")
            imp.SendCommand(imp.CMD_CR)
            imp.SendText("GESTION DE TURNOS")
            imp.SendCommand(imp.CMD_CR)
            imp.SendText("********************************")
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_NORMAL5)
            imp.SendText("TURNO")
            imp.SendCommand(imp.CMD_CR)
            imp.SendText("AB123")
            imp.SendCommand(imp.CMD_LF4)
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_BARRA3)
            imp.SendText("5645645656")
            imp.SendCommand(imp.CMD_BARRA_FIN)
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_NORMAL2)
            imp.SendText("Desarrollado por")
            imp.SendCommand(imp.CMD_CR)
            imp.SendCommand(imp.CMD_CORTAR)



            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("********************************")
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendCommand(imp.CMD_JUSTIFICAR0)
            'imp.SendCommand(imp.CMD_NORMAL5)
            'imp.SendText(UCase("TICKET COMPRA"))
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText(UCase(Descripcion))
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("NRO " & CStr(NroDetalle).PadLeft(5, "0") & "-" & NroTicket.PadLeft(2, "0"))
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendCommand(imp.CMD_NORMAL2)
            'imp.SendText("********************************")
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText(Date.Now)
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendCommand(imp.CMD_NORMAL2)
            'imp.SendText("TICKET #: " & Nro)
            'imp.SendText(" CAJA #:" & LblCaja.Text)
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("OPERADOR #:" & G_NombreUsuario)
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("*********************************")
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("SUBTOTAL                 " & ("$" & FormatNumber(Total, 2)))
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("TOTAL                    " & ("$" & FormatNumber(Total, 2)))
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("*********************************")
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendCommand(imp.CMD_BARRA3)
            'imp.SendText(LblPuntoVenta.Text & LblLetra.Text & LblNumero.Text)
            'imp.SendCommand(imp.CMD_BARRA_FIN)
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("DESARROLLADO POR")
            'imp.SendCommand(imp.CMD_CSIZE3)
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("IDEAS SA")
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendText("WWW.IDEASSA.COM.AR")
            'imp.SendCommand(imp.CMD_CR)
            'imp.SendCommand(imp.CMD_LF4)
            'imp.SendCommand(imp.CMD_CORTAR)

            'System.Threading.Thread.Sleep(2000)


            imp.Cerrar()

        End If

    End Sub
End Class