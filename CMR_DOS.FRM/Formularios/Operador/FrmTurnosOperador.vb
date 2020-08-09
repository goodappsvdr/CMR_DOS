Imports System.Drawing
Imports CMR_DOS.AD
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.UI.Data
Imports System.ComponentModel

Public Class FrmTurnosOperador

#Region "Variables"

    Private eEstado As FormEstado

    Private aAcceso As Boolean
    Private aNuevo As Boolean
    Private aEditar As Boolean
    Private aEliminar As Boolean
    Private aExportar As Boolean
    Private aImprimir As Boolean
    Private aConsultar As Boolean

    Dim ultimo As Integer
    Private id_turno As Integer
    Private ID_Seccion As Integer

#End Region

#Region "Enumeraciones"

    Public Enum FormEstado
        eVacio = 1
        eAgregar = 2
        eConsulta = 3
        eEdicion = 4
        eAparicion = 5
        eEliminar = 6
    End Enum


    Public Enum EstadoObjeto
        eActivo = 0
        eNoActivo = 1
    End Enum

#End Region

#Region "Propiedades"

    Public Property Estado() As FormEstado
        Get
            Return eEstado
        End Get
        Set(ByVal vNewValue As FormEstado)



            Select Case vNewValue

                Case FormEstado.eVacio

                    DeshabilitarComandos()
                    DeshabilitarEdicion()
                    LimpiarDatos()
                    SeccionesCtrl1.Iniciar()
                    CmdAtender.Enabled = False
                    CmdAtender.Visible = False
                    CmdAgregar.Visible = True
                    EstadosCtrl1.Enabled = True
                    SeccionesCtrl1.Enabled = True

                    If aConsultar = True Then
                        Timer1.Enabled = True
                        Grilla.Enabled = True
                    Else

                        Grilla.Enabled = False

                    End If



                    CmdAceptar.Enabled = False
                    CmdLimpiar.Enabled = True

                    If aExportar = True Then
                        CmdExportar.Enabled = True
                    Else
                        CmdExportar.Enabled = False
                    End If

                    'TxtID.Enabled = False

                    PanelColor.BackColor = Color.FromArgb(74, 97, 132)
                    LblAccion.Text = "Listo"
                    Grilla.Focus()

                Case FormEstado.eAgregar
                    DeshabilitarEdicion()
                    CmdAtender.Visible = True
                    CmdAtender.Enabled = True
                    CmdAgregar.Visible = False
                    CmdAceptar.Enabled = False
                    EstadosCtrl1.Enabled = False
                    SeccionesCtrl1.Enabled = False
                    Grilla.Enabled = False
                    CmdCancelar.Enabled = True
                    CmdLimpiar.Enabled = False
                    CmdExportar.Enabled = False

                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "LLAMADO"

                Case FormEstado.eConsulta

                    DeshabilitarComandos()

                    CmdLimpiar.Enabled = True
                    CmdExportar.Enabled = False
                    DeshabilitarEdicion()
                    SeccionesCtrl1.Iniciar()
                    CmdAtender.Visible = False
                    CmdAtender.Enabled = False
                    CmdAgregar.Visible = True


                Case FormEstado.eEdicion

                    HabilitarEdicion()
                    CmdAgregar.Enabled = True
                    CmdAgregar.Visible = False
                    CmdCancelar.Enabled = True
                    CmdExportar.Enabled = False
                    CmdAtender.Visible = True
                    Grilla.Enabled = False
                    CmdAtender.Enabled = False

                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "ATENDIENDO"
                    TxtSeccion.Focus()
                    EstadosCtrl1.Enabled = False
                    SeccionesCtrl1.Enabled = False

                Case FormEstado.eEliminar

                    DeshabilitarComandos()
                    CmdAceptar.Enabled = True
                    CmdCancelar.Enabled = True
                    CmdExportar.Enabled = False

                    Grilla.Enabled = False
                    'TxtID.Enabled = False
                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "Eliminando"


            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

#Region "Procedimientos Propios"

    Public Sub DeshabilitarComandos()

        On Error Resume Next

        CmdAceptar.Enabled = False
        CmdCancelar.Enabled = False

        CmdExportar.Enabled = False
        CmdLimpiar.Enabled = False
        'CmdAtender.Enabled = False

        On Error Resume Next

    End Sub

    Public Sub HabilitarComandos()

        On Error Resume Next

        TxtCodigo.Enabled = True

        txtObservaciones.Focus()

        On Error GoTo 0

    End Sub

    Public Sub DeshabilitarEdicion()

        On Error Resume Next

        'TxtID.Enabled = False
        TxtSeccion.Enabled = False
        TxtFechaObtencion.Enabled = False
        TxtFechaLlamado.Enabled = False
        TxtCodigo.Enabled = False
        ResolucionesCtrl1.Enabled = False

        BtnRecargarResoluciones.Enabled = False
        MotivosCtrl1.Enabled = False
        txtObservaciones.Enabled = False
        btnRecargarMotivos.Enabled = False
        On Error GoTo 0

    End Sub

    Public Sub HabilitarEdicion()

        On Error Resume Next



        ResolucionesCtrl1.Enabled = True
        BtnRecargarResoluciones.Enabled = True
        MotivosCtrl1.Enabled = True
        txtObservaciones.Enabled = True
        btnRecargarMotivos.Enabled = True
        CmdAceptar.Enabled = True

        On Error GoTo 0

    End Sub

    Public Sub LimpiarDatos()

        id_turno = vbNull
        TxtSeccion.Text = ""
        TxtFechaObtencion.Text = ""
        TxtFechaLlamado.Text = ""
        TxtCodigo.Text = ""
        ResolucionesCtrl1.Iniciar()
        MotivosCtrl1.Iniciar()
        TxtSeccion.ReadOnly = True
        TxtFechaObtencion.ReadOnly = True
        TxtFechaLlamado.ReadOnly = True
        TxtCodigo.ReadOnly = True
        Timer2.Stop()
        LblCronometro.Text = "0.00.00"
        txtObservaciones.Text = ""

    End Sub
    Private Sub EstablecerPrioridad()
        Dim VALOR As MsgBoxResult = MsgBox("Desea establecer este turno como prioridad?", MsgBoxStyle.YesNo, "ESTA SEGURO ?")

        If VALOR = MsgBoxResult.Yes Then
            Me.Estado = FormEstado.eAgregar
            establecercomoprioridad(Grilla.CurrentRow.Cells(0).Value)
            LlamarSiguiente()
        End If
    End Sub


    Private Sub CargarPermisos()

        aAcceso = True
        aNuevo = True
        aEditar = True
        aEliminar = True
        aExportar = True
        aImprimir = True
        aConsultar = True

    End Sub

    Private Sub DeshabilitarPermisos()

        aAcceso = False
        aNuevo = False
        aEditar = False
        aEliminar = False
        aExportar = False
        aImprimir = False
        aConsultar = False

    End Sub

    Private Sub Acepto()


        Dim oObjeto As New Turnos

        Try

            Select Case Me.Estado

                Case FormEstado.eEdicion
                    IniciaTransaccion()
                    oObjeto.Resolver(transaccion, TxtID_Turno.Text,
                                    ValorEstado("TURNOS", "SOLUCIONADO"),
                                    ResolucionesCtrl1.SelectedValue,
                                    txtObservaciones.Text,
                                    MotivosCtrl1.SelectedValue,
                                    G_UserID)
                    FinalizaTransaccion()
                    Timer2.Stop()

                    MsgBox("Se modificó el registro" & vbCrLf & "Tiempo: " & LblCronometro.Text, MsgBoxStyle.Information, G_AppName)


                    Me.Estado = FormEstado.eVacio


                Case FormEstado.eEliminar


            End Select

        Catch

            Select Case Me.Estado

                Case FormEstado.eAgregar


                    MsgBox("Ocurrió un error al Agregar - " & vbCrLf &
                     vbCrLf &
                    Err.Description, MsgBoxStyle.Critical, G_AppName)


                Case FormEstado.eEdicion


                    MsgBox("Ocurrió un error al Modificar - " & vbCrLf &
                     vbCrLf &
                    Err.Description, MsgBoxStyle.Critical, G_AppName)



            End Select

        Finally

            oObjeto = Nothing
            LblCronometro.Text = "0.00.00"
        End Try

    End Sub

    Private Sub Cancelo()

        On Error GoTo ManejoErrores

        If MsgBox("Esta seguro de Cancelar?" & vbCrLf &
                  "Se perderán las ultimas modificaciones",
                  vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then
            Dim id_estado As Integer = ValorEstado("Turnos", "Generado")
            If EstadosCtrl1.SelectedValue = id_estado Then
                Dim ods As New DataSet
                Dim ot As New Turnos

                ods = ot.CancelarLlamado(TxtID_Turno.Text, id_estado, SeccionesCtrl1.SelectedValue)
                Timer2.Stop()
                LblCronometro.Text = "0.00.00"

            End If

            If EstadosCtrl1.Text = "ATENDIENDO" Then
                Timer2.Stop()
                LblCronometro.Text = "0.00.00"
            End If

            If EstadosCtrl1.Text = "LLAMADO" Then
                Timer2.Stop()
                LblCronometro.Text = "0.00.00"
            End If


            Me.Estado = FormEstado.eVacio

        End If
        Exit Sub

ManejoErrores:
        MsgBox("Ocurrió el error " & vbCrLf &
                 vbCrLf &
                Err.Description)

    End Sub



#End Region

#Region "Formulario"


    Private Sub FrmTurnosOperador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F3 And CmdAgregar.Enabled = True Then ' agregar
            Me.Estado = FormEstado.eAgregar
        End If


        If e.KeyCode = Keys.F5 And CmdAceptar.Enabled = True Then ' aceptar
            If Validar() = True Then
                Acepto()
            Else
            End If
        End If

        If e.KeyCode = Keys.F8 And CmdCancelar.Enabled = True Then ' cancelar
            Cancelo()
        End If

        If e.KeyCode = Keys.F12 And CmdLimpiar.Enabled = True Then ' modificar
            Me.Estado = FormEstado.eVacio
        End If


    End Sub

    Private Sub FrmTurnosOperador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Dispose()
        End If

    End Sub


    Private Sub FrmTurnosOperador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ODS As New DataSet
        Dim OB As New Boxes
        ODS = OB.BuscarPorID(G_BoxID)

        Me.Text = Text & " " & Convert.ToString(ODS.Tables(0).Rows(0).Item("Box"))
        DeshabilitarPermisos()
        CargarPermisos()

        If aAcceso = True Then
            EstadosCtrl1.Iniciar("Turnos")
            EstadosCtrl1.SelectedText = "Generado"
            Me.BringToFront()
            Me.Estado = FormEstado.eVacio
            txtObservaciones.Focus()

        Else

            MsgBox("No tiene permisos para realizar ninguna tarea en este formulario, consulte con el Administrador del Sistema", MsgBoxStyle.Exclamation, G_AppName)
            Me.Close()

        End If


    End Sub




#End Region

#Region "Botones de Comando"
    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Estado = FormEstado.eEdicion
    End Sub

    Private Sub CmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Estado = FormEstado.eEliminar
    End Sub

    Private Sub CmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLimpiar.Click
        Me.Estado = FormEstado.eVacio
    End Sub




    Private Sub ItemExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExportar.Click

        Dim exporter As ExportToExcelML = New ExportToExcelML(Me.Grilla)

        exporter.ExportVisualSettings = True
        exporter.SheetMaxRows = ExcelMaxRows._1048576

        exporter.SheetName = "Turnos"
        exporter.SummariesExportOption = SummariesOption.DoNotExport

        Dim fileName As String = Application.StartupPath & "\Turnos.xls"
        exporter.RunExport(fileName)

        Process.Start(Application.StartupPath & "\Turnos.xls")

    End Sub




    Private Sub CmdGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrid.Click

        If CmdGrid.Text = "+" Then

            Grilla.Size = New System.Drawing.Size(646, 497)
            CmdGrid.Text = "-"
        Else

            Grilla.Size = New System.Drawing.Size(646, 176)
            CmdGrid.Text = "+"
        End If

    End Sub


#End Region

#Region "Funciones Propias"

    Private Function Validar() As Boolean

        If ResolucionesCtrl1.SelectedIndex = 0 Or MotivosCtrl1.SelectedIndex = 0 Then

            MsgBox("Asigne la resolucion y motivo al turno para continuar ...", MsgBoxStyle.Exclamation, G_AppName)
            Validar = False
            Exit Function

        End If

        Validar = True

    End Function

    Public Function BuscarPorID(ByVal ID As Integer, ByVal ID_Seccion As Integer) As Boolean

        Dim oDs As New DataSet
        Dim oObjeto As New Turnos


        oDs = oObjeto.BuscarPorID_Seccion(ID, ID_Seccion)


        If oDs.Tables(1).Rows.Count > 0 Then
            id_turno = oDs.Tables(1).Rows(0).Item("ID_Turno")
            TxtID_Turno.Text = oDs.Tables(1).Rows(0).Item("ID_Turno")
            TxtCodigo.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("Codigo")))
            TxtSeccion.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("Seccion")))
            TxtFechaObtencion.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("FechaObtencion")))
            TxtFechaLlamado.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("FechaAtencion")))

            ResolucionesCtrl1.Iniciar()
            MotivosCtrl1.Iniciar()

            oDs = Nothing
            oObjeto = Nothing

            BuscarPorID = True

        Else

            oDs = Nothing
            oObjeto = Nothing

            BuscarPorID = False

            Exit Function

        End If




    End Function

    Private Function BuscarTodos() As Boolean

        Dim oDs As New DataSet
        Dim oObjeto As New Turnos

        Select Case EstadosCtrl1.SelectedValue
            Case CInt(ValorEstado("TURNOS", "GENERADO"))
                Grilla.DataSource = Nothing
                oDs = oObjeto.Turnos_BuscarGenerados(EstadosCtrl1.SelectedValue, SeccionesCtrl1.SelectedValue)
                If oDs.Tables(0).Rows.Count > 0 Then
                    Grilla.DataSource = ""
                    Grilla.DataSource = oDs.Tables(0)

                    Grilla.Columns(0).HeaderText = "#"
                    Grilla.Columns(0).Width = 30
                    Grilla.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

                    oDs = Nothing
                    oObjeto = Nothing

                    Return True

                Else
                    oDs = Nothing
                    oObjeto = Nothing

                    Return False

                End If

            Case Else
                Grilla.DataSource = Nothing
                oDs = oObjeto.Turnos_BuscarPorOperadoryEstado(G_UserID, EstadosCtrl1.SelectedValue, SeccionesCtrl1.SelectedValue)
                If oDs.Tables(0).Rows.Count > 0 Then
                    Grilla.DataSource = ""
                    Grilla.DataSource = oDs.Tables(0)

                    Grilla.Columns(0).HeaderText = "#"
                    Grilla.Columns(0).Width = 30
                    Grilla.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

                    oDs = Nothing
                    oObjeto = Nothing

                    Return True

                Else
                    oDs = Nothing
                    oObjeto = Nothing

                    Return False

                End If

        End Select

    End Function

#End Region

#Region "Grilla"

    Private Sub Grilla_CellDoubleClick(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Grilla.CellDoubleClick

        If Grilla.Enabled = True Then
            Select Case EstadosCtrl1.SelectedValue
                Case CInt(ValorEstado("TURNOS", "GENERADO"))
                    EstablecerPrioridad()
                Case CInt(ValorEstado("TURNOS", "ATENDIENDO"))
                    BuscarPorID(Grilla.CurrentRow.Cells(0).Value, SeccionesCtrl1.SelectedValue)
                    Me.Estado = FormEstado.eEdicion
                    startTime = Now.TimeOfDay
                    Timer2.Start()
                Case CInt(ValorEstado("TURNOS", "LLAMADO"))
                    BuscarPorID(Grilla.CurrentRow.Cells(0).Value, SeccionesCtrl1.SelectedValue)
                    Me.Estado = FormEstado.eAgregar
                    LblCronometro.Text = "0.00.00"
                Case CInt(ValorEstado("TURNOS", "SOLUCIONADO"))
                    BuscarPorID(Grilla.CurrentRow.Cells(0).Value, SeccionesCtrl1.SelectedValue)
                    Me.Estado = FormEstado.eConsulta
            End Select

            Grilla.Size = New System.Drawing.Size(646, 176)
            CmdGrid.Text = "+"

        End If

    End Sub

    Private Sub Grilla1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grilla.KeyDown

        If e.KeyCode = 13 Then
            e.Handled = True
            BuscarPorID(Grilla.CurrentRow.Cells(0).Value, G_seccionID)
            Grilla.Size = New System.Drawing.Size(646, 176)
            CmdGrid.Text = "+"
        End If

    End Sub

#End Region



    Public Function LlamarSiguiente() As Boolean

        Dim oDs As New DataSet
        Dim oObjeto As New Turnos
        Dim ods2 As New DataSet
        Dim ODS5 As New DataSet
        Dim OT5 As New Turnos
        'obtenemos el id_turno del siguente turno
        If EstadosCtrl1.SelectedValue = ValorEstado("Turnos", "Generado") Then
            oDs = oObjeto.ObtenerSiguiente(EstadosCtrl1.SelectedValue, SeccionesCtrl1.SelectedValue)

            If oDs.Tables(0).Rows.Count > 0 Then
                OrdenPantalla(oDs.Tables(0).Rows(0).Item("id_turno"))
                TxtID_Turno.Text = oDs.Tables(0).Rows(0).Item("id_turno")
                ods2 = oObjeto.llamarTurno(oDs.Tables(0).Rows(0).Item("id_turno"),
                                       ValorEstado("Turnos", "Llamado"),
                                       G_UserID,
                                       SeccionesCtrl1.SelectedValue)

                BuscarPorID(oDs.Tables(0).Rows(0).Item("id_turno"), SeccionesCtrl1.SelectedValue)

                EstadosCtrl1.SelectedValue = ValorEstado("Turnos", "Llamado")
                G_seccionID = SeccionesCtrl1.SelectedValue
                oDs = Nothing
                oObjeto = Nothing
                LlamarSiguiente = True

            Else

                oDs = Nothing
                oObjeto = Nothing

                LlamarSiguiente = False

                Exit Function

            End If

        End If



    End Function

    Private Sub OrdenPantalla(id_turno As Integer)

        Dim ods As New DataSet
        Dim ot As New Turnos
        Dim ultimo As Integer
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

        Dim ods2 As New DataSet
        Dim oObjeto As New Turnos

        ods = oObjeto.Turnos_AgregarOrdenPantalla(id_turno, ultimo)


    End Sub

    Private Sub establecercomoprioridad(id_turno As Double)
        Try
            Dim oTurno As New Turnos
            Dim ods As New DataSet
            ods = oTurno.EstablecerPrioridad(id_turno)
        Catch ex As Exception
            MsgBox("Ocurrio un Error...", MsgBoxStyle.Critical, G_AppName)
        End Try


    End Sub



    Private Sub RadButton1_Click(sender As System.Object, e As System.EventArgs) Handles BtnRecargarResoluciones.Click

        ResolucionesCtrl1.Iniciar()

    End Sub



    Private Sub EstadosCtrl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles EstadosCtrl1.SelectedIndexChanged


        'Valido que la grilla este llena sino no se habilita
        If EstadosCtrl1.SelectedIndex = 0 Then

            CmdAgregar.Enabled = True
        Else
            CmdAgregar.Enabled = False


        End If


    End Sub

    Private Sub btnRecargarMotivos_Click(sender As System.Object, e As System.EventArgs) Handles btnRecargarMotivos.Click

        MotivosCtrl1.Iniciar()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        BuscarTodos()

    End Sub

    Private Sub CmdAtender_Click(sender As System.Object, e As System.EventArgs) Handles CmdAtender.Click
        Me.Estado = FormEstado.eEdicion
        Try
            Dim oObjeto As New Turnos
            oObjeto.llamarTurno(TxtID_Turno.Text, ValorEstado("TURNOS", "ATENDIENDO"), G_UserID, SeccionesCtrl1.SelectedValue)
            EstadosCtrl1.SelectedValue = ValorEstado("TURNOS", "ATENDIENDO")
            startTime = Now.TimeOfDay
            Timer2.Start()
        Catch ex As Exception
            MsgBox("Ocurrio un Error...", MsgBoxStyle.Critical, G_AppName)
        End Try

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As System.EventArgs) Handles Timer2.Tick
        Dim elapsed As TimeSpan = Now.TimeOfDay.Subtract(startTime)

        LblCronometro.Text = TimeFormat(elapsed.Hours, 2) & " " & ":" & TimeFormat(elapsed.Minutes, 2) & " " & ":" & TimeFormat(elapsed.Seconds, 2)

        Application.DoEvents()
    End Sub

    Private startTime As TimeSpan
    Private Function TimeFormat(ByRef value As Integer,
                                ByVal maxLength As Byte) As String
        'Variables
        Dim result As String = value.ToString

        'Agrego ceros a la izquierda
        Do While result.Length < maxLength
            result = "0" & result
        Loop

        'Devuelo resultado
        Return Mid(result, 1, 2)
    End Function

    Private Sub SeccionesCtrl1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SeccionesCtrl1.SelectionChangeCommitted
        Grilla.DataSource = Nothing
        BuscarTodos()
    End Sub

    Private Sub EstadosCtrl1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles EstadosCtrl1.SelectionChangeCommitted
        If EstadosCtrl1.SelectedIndex = 0 Then

            CmdAgregar.Enabled = True
        Else
            CmdAgregar.Enabled = False


        End If
        Grilla.DataSource = Nothing
        BuscarTodos()
    End Sub

    Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
        If Validar() = True Then
            Acepto()
        End If
    End Sub

    Private Sub CmdAgregar_Click(sender As Object, e As EventArgs) Handles CmdAgregar.Click
        If Grilla.Rows.Count <= 0 Then
            MsgBox("No hay ningún turno!", MsgBoxStyle.Exclamation, G_AppName)
        Else
            Me.Estado = FormEstado.eAgregar
            LlamarSiguiente()
        End If
    End Sub

    Private Sub CmdPrioridad_Click(sender As Object, e As EventArgs)
        If Grilla.Enabled = True Then
            If EstadosCtrl1.SelectedValue = CInt(ValorEstado("TURNOS", "GENERADO")) Then
                EstablecerPrioridad()
            End If
        End If

    End Sub

    Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click
        Timer2.Stop()

        If MsgBox("Esta seguro de Cancelar?" & vbCrLf &
                  "Se perderán las ultimas modificaciones",
                  vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then
            LimpiarDatos()
            Me.Estado = FormEstado.eVacio
        Else
            startTime = Now.TimeOfDay
            Timer2.Start()
        End If
    End Sub
End Class