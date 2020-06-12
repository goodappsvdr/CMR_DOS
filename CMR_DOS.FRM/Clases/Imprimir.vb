Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.IO.Ports


Public Class Imprimir
    Shared sp As SerialPort

    ' COMANDOS DEL IMPRESOR 

    Public CMD_RESET As Byte() = {&H1B, &H40}
    Public CMD_JUSTIFICAR0 As Byte() = {&H1B, &H61, &H0}
    Public CMD_JUSTIFICAR1 As Byte() = {&H1B, &H61, &H1}
    Public CMD_JUSTIFICAR2 As Byte() = {&H1B, &H61, &H2}
    Public CMD_REVERSE_ON As Byte() = {&H1D, &H42, &H1}
    Public CMD_REVERSE_OFF As Byte() = {&H1D, &H42, &H0}
    Public CMD_CSIZE1 As Byte() = {&H1D, &H21, &H1}
    Public CMD_CSIZE2 As Byte() = {&H1D, &H21, &H2}
    Public CMD_CSIZE3 As Byte() = {&H1D, &H21, &H3}
    Public CMD_NORMAL1 As Byte() = {&H1B, &H21, &H0}
    Public CMD_NORMAL2 As Byte() = {&H1B, &H21, &H3}
    Public CMD_NORMAL3 As Byte() = {&H1B, &H21, &H12}
    Public CMD_NORMAL4 As Byte() = {&H1B, &H21, &H22}
    Public CMD_NORMAL5 As Byte() = {&H1B, &H21, &H30}
    Public CMD_LF2 As Byte() = {&H1B, &H64, &H2}
    Public CMD_LF3 As Byte() = {&H1B, &H64, &H3}
    Public CMD_LF4 As Byte() = {&H1B, &H64, &H4}
    Public CMD_LF As Byte() = {&H1B, &H64, &H5}
    '5 espacios
    Public CMD_LF6 As Byte() = {&H1B, &H64, &H6}

    Public CMD_CORTAR As Byte() = {&H1B, &H69}
    ' corta el papel
    Public CMD_CR As Byte() = {&HA}
    ' CODIGOS DE BARRA 

    Public CMD_BARRA1 As Byte() = {&H1D, &H6B, &H2}
    Public CMD_BARRA2 As Byte() = {&H1D, &H6B, &H3}
    Public CMD_BARRA3 As Byte() = {&H1D, &H6B, &H4}
    Public CMD_BARRA_FIN As Byte() = {&H0}
    ' CONFIGURACION X DEFECTO

    Public CMD_DEFAULT_CONFIG As Byte() = {&H1D, &H23, 0, 1, 1, 0, _
    0, 0, 152, 6, 2, 1, _
    2, 1, 1, 0, 5, 0, _
    1, 8}

    '***************************

    Public Shared Function OpenPort(ByVal puerto As String, ByVal baud As Integer, ByVal paridad As Parity, ByVal Databit As Integer, ByVal [stop] As StopBits) As Boolean
        Try
            sp = New SerialPort(puerto, baud, paridad, Databit, [stop])
            sp.ReadTimeout = 200
            sp.WriteTimeout = 200
            sp.Open()
            If sp.IsOpen Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
    '***************************

    '
    ' C1 '8'=8 bit por carc., '7'=7 bit por caracter
    ' C2 '1'= un stop bit, '2'= dos stop bit
    ' C3 '0'= no parity, '1'= even, '2'= odd
    ' C4 '1'=1200 '2'=2400 '3'=4800 '4'=9600 '5'= 19200 ‘6’=38400,‘7’=57600, ‘8’=115200
    ' C5 '0'=no conectado a ECR, '1'=conectado a ECR
    ' C6 '0'=no autosinc. a inicio de pagina, '1'= si autosinc
    ' C7 '0'= papel sin precorte, '1'= taglio agevolato
    ' C8 '1'=corta solo hija, '2' cortar todo, '0'=no cortar
    ' C9 '0'=cortador deshabilitado, '1'=cortador habilitado
    ' C10 '2'=numero copias / max '3'
    ' C11 '6' dimensión marcar en mm
    ' C12 "152" ejemplo de dimensión de página en mm
    ' C13 '0'=CR dishabilitato, '1'= CR habilitato
    ' C14 '0'= Xon/Xoff, '1'=hardware RTS/CTS
    ' C15 '0'/'1'/'2'= 48/41/36 Char\linea (version 80mm)'0'/'1'/'2'= 36/30/27 Char\line ( version 60mm)
    ' C16 '0'=Standard,'1'=Standard Page, '2'=Page Mode
    ' C17 '0'=NO, '1'=EscPos, '2'=Em. 295S, ‘3’=Em.TM-T88II 
    ' C18 '0'=1252 Latin1, '1'=1251 Cyrillic, '2'=1253 Greek
    ' 

    Public Shared Function SetConfigImp(ByVal c1 As Char, ByVal c2 As Char, ByVal c3 As Char, ByVal c4 As Char, ByVal c5 As Char, ByVal c6 As Char, _
    ByVal c7 As Char, ByVal c8 As Char, ByVal c9 As Char, ByVal c10 As Char, ByVal c11 As Char, ByVal c12 As Char, _
    ByVal c13 As Char, ByVal c14 As Char, ByVal c15 As Char, ByVal c16 As Char, ByVal c17 As Char, ByVal c18 As Char) As Boolean
        If sp.IsOpen Then
            sp.Write(New Byte() {&H1D}, 0, 1)
            sp.Write(("#" & c18) + c17 + c16 + c15 + c14 + c13 + c12 + c11 + c10 + c9 + c8 + c7 + c6 + c5 + c4 + c3 + c2 + c1)
            Return True
        End If
        Return False
    End Function
    '***************************

    Public Function SetConfigDefaultImp() As Boolean
        If sp.IsOpen Then
            sp.Write(New Byte() {&H1D}, 0, 1)
            'sp.Write("#01101029871121104018")
            sp.Write("#01101029962121104018")
            Return True
        End If
        Return False
    End Function
    '***************************

    Public Shared Function SendCommand(ByVal cmd As Byte()) As Boolean
        If sp.IsOpen Then
            sp.Write(cmd, 0, cmd.Length)
            Return True
        End If
        Return False
    End Function
    '***************************

    Public Shared Function SendText(ByVal txt As String) As Boolean
        If sp.IsOpen Then
            sp.Write(txt)
            Return True
        End If
        Return False
    End Function
    '***************************

    Public Shared Function Puertos() As String
        Dim portName As String = ""

        For Each s As String In SerialPort.GetPortNames()
            portName += s & " "
        Next
        Return portName
    End Function
    '***************************
    Public Function Cerrar() As String
        If sp.IsOpen Then
            sp.Close()
        End If
        Cerrar = "0"
    End Function

    Public Shared Sub TestPrint()

        'If sp.IsOpen Then
        '    sp.Write(CMD_RESET, 0, CMD_RESET.Length)
        '    sp.Write(CMD_JUSTIFICAR1, 0, CMD_JUSTIFICAR1.Length)

        '    sp.Write(CMD_NORMAL1, 0, CMD_NORMAL1.Length)

        '    sp.Write("PRUEBA DE IMPRESION")
        '    sp.Write(CMD_CR, 0, CMD_CR.Length)

        '    sp.Write(CMD_REVERSE_ON, 0, CMD_REVERSE_ON.Length)
        '    sp.Write("PRUEBA DE IMPRESION")
        '    sp.Write(CMD_CR, 0, CMD_CR.Length)
        '    sp.Write(CMD_REVERSE_OFF, 0, CMD_REVERSE_OFF.Length)

        '    sp.Write(CMD_CSIZE3, 0, CMD_CSIZE3.Length)
        '    sp.Write("PRUEBA DE IMPRESION DOS")
        '    sp.Write(CMD_CR, 0, CMD_CR.Length)

        '    sp.Write(CMD_CSIZE1, 0, CMD_CSIZE1.Length)
        '    sp.Write("PRUEBA DE IMPRESION TRES")
        '    sp.Write(CMD_CR, 0, CMD_CR.Length)

        '    sp.Write(CMD_NORMAL1, 0, CMD_NORMAL1.Length)
        '    sp.Write("PRUEBA DE IMPRESION cuatro")
        '    sp.Write(CMD_CR, 0, CMD_CR.Length)

        '    sp.Write(CMD_BARRA1, 0, CMD_BARRA1.Length)
        '    sp.Write("*12124312312")
        '    sp.Write(CMD_BARRA_FIN, 0, CMD_BARRA_FIN.Length)

        '    sp.Write(CMD_LF5, 0, CMD_LF5.Length)
        '    sp.Write(CMD_CORTAR, 0, CMD_CORTAR.Length)
        'End If
    End Sub
    '***************************

End Class