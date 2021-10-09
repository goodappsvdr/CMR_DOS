
Imports CMR_DOS.AD
Imports System.Globalization
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Telerik.WinControls.UI.Localization

Module ModuloPrincipal

    Public oDsMultiple As DataSet

    Public G_UserID As Double
    Public G_RolID As Double
    Public G_UsuarioLogin As Double
    Public G_UserName As String
    Public G_AppName As String = "COOVILROS LTDA."

    Public G_SecciontipoTable As DataSet
    Public G_nombreSeccion As String
    Public G_SeccionID As Integer
    Public G_BoxID As Integer = Nothing
    Public conexion As SqlConnection
    Public transaccion As SqlTransaction
    Public G_CodTurno As String

    ''variables de reportes:
    Public R_IDEstado As Double
    Public R_IDSeccion As Double
    Public R_IDSeccionTipo As Double
    Public R_IDMotivo As Double
    Public R_IDResolucion As Double
    Public R_Fechadesde As Date
    Public R_FechaHasta As Date
    Public R_IDOperador As Double
    Public R_Reporte As String = ""
#Region "Enumeraciones"


#End Region

    Public Sub main()

        CargarConfiguracionRegional()

        RadGridLocalizationProvider.CurrentProvider = New MyEnglishRadGridLocalizationProvider()

    End Sub


    Public Sub IniciaTransaccion()

        Dim strcon As String

        strcon = System.Configuration.ConfigurationManager.AppSettings("ConnectionString")

        conexion = New SqlConnection(strcon)

        Try
            conexion.Open()
        Catch ex As Exception

            MsgBox(ex.Message)
            End
        End Try

        transaccion = conexion.BeginTransaction
    End Sub


    Public Sub FinalizaTransaccion()
        transaccion.Commit()
        conexion.Close()
    End Sub

    Public Sub CancelaTransaccion()
        On Error Resume Next
        transaccion.Rollback()
        conexion.Close()
    End Sub


    Public Function ToTimeSpan(s As String) As TimeSpan
        Dim t As TimeSpan = TimeSpan.Parse(s.Remove(2, 1).Remove(5, 1))
        Return t
    End Function



    Public Function mkf_validacuit(ByVal mk_p_nro As String) As Boolean
        Dim mk_suma As Integer
        Dim mk_valido As String
        mk_p_nro = mk_p_nro.Replace("-", "")
        If IsNumeric(mk_p_nro) Then
            If mk_p_nro.Length <> 11 Then
                mk_valido = False
            Else
                mk_suma = 0
                mk_suma += CInt(mk_p_nro.Substring(0, 1)) * 5
                mk_suma += CInt(mk_p_nro.Substring(1, 1)) * 4
                mk_suma += CInt(mk_p_nro.Substring(2, 1)) * 3
                mk_suma += CInt(mk_p_nro.Substring(3, 1)) * 2
                mk_suma += CInt(mk_p_nro.Substring(4, 1)) * 7
                mk_suma += CInt(mk_p_nro.Substring(5, 1)) * 6
                mk_suma += CInt(mk_p_nro.Substring(6, 1)) * 5
                mk_suma += CInt(mk_p_nro.Substring(7, 1)) * 4
                mk_suma += CInt(mk_p_nro.Substring(8, 1)) * 3
                mk_suma += CInt(mk_p_nro.Substring(9, 1)) * 2
                mk_suma += CInt(mk_p_nro.Substring(10, 1)) * 1
            End If

            If Math.Round(mk_suma / 11, 0) = (mk_suma / 11) Then
                mk_valido = True
            Else
                mk_valido = False
            End If
        Else
            mk_valido = False
        End If
        Return (mk_valido)
    End Function




    Public Function CUITOK(ByVal Cuit As String) As Boolean
        Dim Acum As Double
        Dim i As Double
        Dim verif As Double

        For i = 5 To 2 Step -1
            Acum = Acum + Val(Mid(Cuit, 12 - (6 + i), 1)) * i
        Next i
        For i = 7 To 2 Step -1
            Acum = Acum + Val(Mid(Cuit, 12 - i, 1)) * i
        Next i
        verif = 11 - (Acum Mod 11)
        If verif = 11 Then
            verif = 0
        End If
        If Val(Mid(Cuit, 11, 1)) = verif Then
            CUITOK = True
        Else
            CUITOK = False
        End If
    End Function



    'Ultimo dia del mes de la fecha especificada
    Function LastDay(ByVal dDate As Date) As Date
        Dim Dias(13) As String
        Dim Fecha As String
        Dias(1) = "31"
        Dias(2) = "28"
        Dias(3) = "31"
        Dias(4) = "30"
        Dias(5) = "31"
        Dias(6) = "30"
        Dias(7) = "31"
        Dias(8) = "31"
        Dias(9) = "30"
        Dias(10) = "31"
        Dias(11) = "30"
        Dias(12) = "31"
        Dias(13) = "29"

        Fecha = IIf(Month(dDate) = 2 And EsBisiesto(dDate), Dias(13), Dias(Month(dDate)))
        Fecha = Fecha & "/" & CStr(Month(dDate)) & "/" & CStr(Year(dDate))

        LastDay = CDate(Fecha)
    End Function

    'Determina si el año es bisiesto
    Function EsBisiesto(ByVal dDate As Date) As Boolean
        Dim nYear As Double

        nYear = Year(dDate)

        EsBisiesto = ((nYear Mod 4) = 0) And (((nYear Mod 100) <> 0) Or ((nYear Mod 400) = 0))
    End Function


    Public Function FechaCuotaMesProximo(ByVal Dia As Double, ByVal FechaDesde As Date) As Date
        Dim FechaVto As String
        Dim Mes As Double
        Dim Anio As Double

        Mes = Month(FechaDesde)
        Anio = Year(FechaDesde)
        Anio = IIf(Mes = 12, Anio + 1, Anio)
        Mes = IIf(Mes = 12, 1, Mes + 1)
        FechaVto = CStr(Dia) & "/" & CStr(Mes) & "/" & CStr(Anio)

        While IsDate(FechaVto) = False
            Dia = Dia - 1
            FechaVto = CStr(Dia) & "/" & CStr(Mes) & "/" & CStr(Anio)
        End While

        FechaCuotaMesProximo = CDate(FechaVto)
    End Function



    Public Function msImpLet(ByVal Cifra1 As Double) 'Conversión de números a Letras
        Dim Letra As String
        Dim cifra As String
        Dim punto As String
        Dim Enter As String
        Dim decim As String
        Dim millo As Double
        Dim miles As Double
        Dim cient As Double
        Dim decim2 As Double
        Dim Numero As Double
        Dim q As Double
        Dim c As Double
        Dim d As Double
        Dim u As Double

        Cifra1 = Math.Abs(Cifra1)


        Letra = ""

        cifra = Format(Cifra1, "########0.#0")
        punto = InStr(1, cifra, ".")
        If punto = 0 Then
            cifra = Right("000000000" + Trim(cifra), 9) + ",00"
        Else
            Enter = Right("000000000" + Trim(Left(cifra, punto - 1)), 9)
            decim = Left(Trim(Mid(cifra, punto)) + "00", 3)
            cifra = Enter + decim
        End If
        Dim x(45)
        x(1) = "uno"
        x(2) = "dos"
        x(3) = "tres"
        x(4) = "cuatro"
        x(5) = "cinco"
        x(6) = "seis"
        x(7) = "siete"
        x(8) = "ocho"
        x(9) = "nueve"
        x(10) = "diez"
        x(11) = "once"
        x(12) = "doce"
        x(13) = "trece"
        x(14) = "catorce"
        x(15) = "quince"
        x(16) = "dieciseis"
        x(17) = "diecisiete"
        x(18) = "dieciocho"
        x(19) = "diecinueve"
        x(20) = "veinte"
        x(21) = "veintiuno"
        x(22) = "veintidos"
        x(23) = "veintitres"
        x(24) = "veinticuatro"
        x(25) = "veinticinco"
        x(26) = "veintiseis"
        x(27) = "veintisiete"
        x(28) = "veintiocho"
        x(29) = "veintinueve"
        x(30) = "treinta"
        x(31) = "cuarenta"
        x(32) = "cincuenta"
        x(33) = "sesenta"
        x(34) = "setenta"
        x(35) = "ochenta"
        x(36) = "noventa"
        x(37) = "ciento"
        x(38) = "doscientos"
        x(39) = "trescientos"
        x(40) = "cuatrocientos"
        x(41) = "quinientos"
        x(42) = "seiscientos"
        x(43) = "setecientos"
        x(44) = "ochocientos"
        x(45) = "novecientos"

        millo = Val(Left(cifra, 3))
        miles = Val(Mid(cifra, 4, 3))
        cient = Val(Mid(cifra, 7, 3))
        decim2 = Val(Right(cifra, 2))
        For q = 1 To 4
            Select Case q
                Case 1
                    Numero = millo
                    If millo = 1 Then
                        Letra = Letra + "un millon "
                        GoTo Loop1
                    End If
                Case 2
                    Numero = miles
                    If millo <> 1 And millo <> 0 Then
                        Letra = Letra + "millones "
                    End If
                    If miles = 1 Then
                        Letra = Letra + "un mil "
                        GoTo Loop1
                    End If
                Case 3
                    Numero = cient
                    If miles <> 1 And miles <> 0 Then
                        Letra = Letra + "mil "
                    End If
                Case 4
                    Numero = decim2
                    If decim2 <> 0 Then
                        If millo = 0 And miles = 0 And cient = 0 Then
                            Letra = Letra + "cero con "
                        Else
                            Letra = Letra + "con "
                        End If
                    End If
            End Select
            c = Int(Numero / 100)
            d = Int((Numero - c * 100) / 10)
            u = Int(Numero - (c * 100 + d * 10))
            If Numero = 0 Then
                GoTo Loop1
            End If
            If Numero = 100 Then
                Letra = Letra + "cien "
                GoTo Loop1
            Else
                If Numero = 101 And q <> 3 Then
                    Letra = Letra + "ciento un "
                    GoTo Loop1
                Else
                    If Numero > 100 Then
                        Letra = Letra + x(c + 36) + " "
                    End If
                End If
            End If
            If d < 3 And d <> 0 Then
                Letra = Letra + x(d * 10 + u) + " "
            Else
                If d > 2 Then
                    Letra = Letra + x(d + 27) + " "
                    If u = 0 Then
                        GoTo Loop1
                    End If
                    Letra = Letra + "y " + x(u) + " "
                Else
                    If d = 0 And u <> 0 Then
                        Letra = Letra + x(u) + " "
                    End If
                End If
            End If
Loop1:

        Next
        If InStr(1, Letra, "con") <> 0 Then
            Letra = Letra + "centavo(s)"
        End If
        msImpLet = Trim(Letra)
    End Function



    Public Function FechaHoraServidor() As Date

        Dim oObjeto As New Estados
        Dim oDs As New DataSet

        oDs = oObjeto.FechaHora

        Return oDs.Tables(0).Rows(0).Item("FechaHora")

        oDs = Nothing
        oObjeto = Nothing

    End Function

  

    Public Function ValorParametro(ByVal Categoria As String, ByVal Nombre As String) As String

        Dim oObjeto As New Parametros
        Dim oDs As New DataSet

        oDs = oObjeto.BuscarPorCategoriaNombre(Categoria, Nombre)

        Return oDs.Tables(0).Rows(0).Item("Valor")

        oDs = Nothing
        oObjeto = Nothing


    End Function

    Public Function ValorEstado(ByVal Categoria As String, ByVal Nombre As String) As String

        Dim oObjeto As New Estados
        Dim oDs As New DataSet

        oDs = oObjeto.BuscarPorCategoriaNombre(Categoria, Nombre)

        Return oDs.Tables(0).Rows(0).Item("ID_Estado")

        oDs = Nothing
        oObjeto = Nothing


    End Function
    'Public Function ValorResolucion(ByVal DESCRIPCION As String, id_seccionTipo As Double) As String

    '    Dim oObjeto As New Resoluciones
    '    Dim oDs As New DataSet

    '    oDs = oObjeto.BuscarPorNombre(DESCRIPCION, id_seccionTipo)

    '    Return oDs.Tables(0).Rows(0).Item("ID_Resolucion")

    '    oDs = Nothing
    '    oObjeto = Nothing

    'End Function

    'Public Function ValorMotivo(ByVal DESCRIPCION As String, ID_Seccion As Double) As String

    '    Dim oObjeto As New Motivos
    '    Dim oDs As New DataSet

    '    oDs = oObjeto.BuscarPorNombre(DESCRIPCION, ID_Seccion)

    '    Return oDs.Tables(0).Rows(0).Item("ID_Motivo")

    '    oDs = Nothing
    '    oObjeto = Nothing


    'End Function

    Public Function ValorRol(ByVal RoleName As String) As Double

        Dim oObjeto As New Roles
        Dim oDs As New DataSet

        oDs = oObjeto.BuscarPorNombre(RoleName)

        Return oDs.Tables(0).Rows(0).Item("id_rol")

        oDs = Nothing
        oObjeto = Nothing


    End Function
    Public Function ValorCategoria(ByVal CategoriaTipo As String, ByVal Nombre As String) As String

        Dim oObjeto As New Categorias
        Dim oDs As New DataSet

        oDs = oObjeto.BuscarPorCategoriaTipoNombre(CategoriaTipo, Nombre)

        Return oDs.Tables(0).Rows(0).Item("ID_Categoria")

        oDs = Nothing
        oObjeto = Nothing


    End Function

    Public Sub CargarConfiguracionRegional()

        Dim configRegional As CultureInfo



        configRegional = Application.CurrentCulture.Clone
        configRegional.NumberFormat.CurrencyDecimalSeparator = "."
        configRegional.NumberFormat.NumberDecimalDigits = 2
        configRegional.NumberFormat.NumberGroupSeparator = ","
        configRegional.NumberFormat.CurrencyDecimalSeparator = "."
        configRegional.NumberFormat.CurrencyGroupSeparator = ","
        configRegional.NumberFormat.NumberDecimalSeparator = "."
        configRegional.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        Application.CurrentCulture = configRegional

    End Sub
    Public Function EsNumero(ByVal Cadena As String) As Boolean
        'Esta función esta hecha para validar un campo del tipo 999,999.99
        'Admite por lo tanto una coma y un punto como caracteres no numericos válidos unicamente
        'Se complementa con la private sub "Mascara()"
        If Len(Cadena) <> 0 Then
            Dim CuentoPunto As Double
            Dim CuentoComa As Double
            Dim CuentoMenos As Double
            Dim i As Double
            Dim Caracter As String
            CuentoPunto = 0
            CuentoComa = 0
            CuentoMenos = 0
            For i = 1 To Len(Cadena)
                Caracter = Right(Left(Cadena, i), 1) 'Para separar de uno por uno
                If Caracter = "0" Or Caracter = "." Or Caracter = "," Or Caracter = "-" Then 'Para no tocar los ceros o puntos o comas y menos
                    If Caracter = "." Then 'Si hay punto, debe ser uno solo
                        CuentoPunto = CuentoPunto + 1
                        If CuentoPunto > 1 Then
                            EsNumero = False
                            Exit Function
                        End If
                    End If
                    If Caracter = "," Then 'Si hay coma, debe ser una sola
                        CuentoComa = CuentoComa + 1
                        If CuentoComa > 3 Then
                            EsNumero = False
                            Exit Function
                        End If
                    End If
                    If Caracter = "-" Then 'Si hay signo negativo, debe ser uno solo
                        CuentoMenos = CuentoMenos + 1
                        If CuentoMenos > 1 Then
                            EsNumero = False
                            Exit Function
                        End If
                    End If
                    If Len(Cadena) = 1 Then
                        If Caracter = "-" Then
                            EsNumero = False
                            Exit Function
                        End If
                        If Caracter = "." Then
                            EsNumero = False
                            Exit Function
                        End If
                        If Caracter = "," Then
                            EsNumero = False
                            Exit Function
                        End If
                    End If
                Else
                    If Val(Caracter) = 0 Then
                        EsNumero = False
                        Exit Function
                    End If
                End If
            Next
            EsNumero = True
        Else
            EsNumero = False
        End If
    End Function

End Module

