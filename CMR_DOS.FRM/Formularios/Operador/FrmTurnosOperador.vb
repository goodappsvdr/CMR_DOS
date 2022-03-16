Imports System.Drawing
Imports CMR_DOS.AD
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.UI.Data
Imports System.ComponentModel
Imports Telerik.WinControls.UI

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
    Private EstadoOperador As Integer

#End Region

#Region "Enumeraciones"

    Public Enum FormEstado
        eVacio = 1
        eAgregar = 2
        eConsulta = 3
        eEdicion = 4
        eAparicion = 5
        eEliminar = 6
        eOcupado = 7
        eDisponible = 8
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
                    PictureAtender.Enabled = False
                    PictureAtender.Visible = False
                    CmdAgregar.Visible = True
                    EstadosCtrl1.Enabled = True
                    SeccionesCtrl1.Enabled = True
                    CmdAtendiendo.Enabled = False
                    CmdAtendiendo.Visible = False
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
                    CmdDisponible.Visible = True
                    CmdDisponible.Enabled = True
                    CmdOcupado.Enabled = Enabled = False
                    CmdOcupado.Visible = False
                    PanelColor.BackColor = Color.FromArgb(74, 97, 132)
                    LblAccion.Text = "LISTO PARA EL SIGUIENTE TURNO"
                    Grilla.Focus()

                Case FormEstado.eAgregar
                    DeshabilitarEdicion()
                    PictureAtender.Visible = True
                    PictureAtender.Enabled = True
                    CmdAgregar.Visible = False
                    CmdAceptar.Enabled = False
                    EstadosCtrl1.Enabled = False
                    SeccionesCtrl1.Enabled = False
                    CmdAtendiendo.Enabled = False
                    CmdAtendiendo.Visible = False
                    Grilla.Enabled = False
                    CmdCancelar.Enabled = True
                    CmdLimpiar.Enabled = False
                    CmdExportar.Enabled = False
                    CmdDisponible.Visible = False
                    CmdDisponible.Enabled = False
                    CmdOcupado.Enabled = Enabled = False
                    CmdOcupado.Visible = True
                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "ESPERANDO AL SOCIO..."

                Case FormEstado.eConsulta

                    DeshabilitarComandos()

                    CmdLimpiar.Enabled = True
                    CmdExportar.Enabled = False
                    DeshabilitarEdicion()
                    SeccionesCtrl1.Iniciar()
                    PictureAtender.Visible = False
                    PictureAtender.Enabled = False
                    CmdAgregar.Visible = True


                Case FormEstado.eEdicion

                    HabilitarEdicion()
                    CmdAgregar.Enabled = True
                    CmdAgregar.Visible = False
                    CmdCancelar.Enabled = True
                    CmdExportar.Enabled = False
                    PictureAtender.Visible = False
                    CmdAtendiendo.Visible = True
                    Grilla.Enabled = False
                    PictureAtender.Enabled = False
                    CmdDisponible.Visible = False
                    CmdDisponible.Enabled = False
                    CmdOcupado.Enabled = Enabled = False
                    CmdOcupado.Visible = True
                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "ATENDIENDO  EL TURNO " & G_CodTurno

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

                Case FormEstado.eOcupado

                    HabilitarEdicion()
                    CmdAgregar.Enabled = True
                    CmdAgregar.Visible = False
                    CmdCancelar.Enabled = True
                    CmdExportar.Enabled = False
                    PictureAtender.Visible = False
                    CmdAtendiendo.Visible = True
                    CmdOcupado.Visible = True
                    CmdOcupado.Enabled = True
                    CmdDisponible.Visible = False
                    CmdDisponible.Enabled = False
                    Grilla.Enabled = False
                    PictureAtender.Enabled = False
                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "OCUPADO... "

                    EstadosCtrl1.Enabled = False
                    SeccionesCtrl1.Enabled = False
                    CmdAceptar.Enabled = False
                    CmdCancelar.Enabled = False
                    ResolucionesCtrl1.Enabled = False
                    MotivosCtrl1.Enabled = False

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
        Grilla.Enabled = False
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
        SeccionesCtrl1.Enabled = False
        TxtFechaObtencion.Enabled = False
        TxtFechaLlamado.Enabled = False
        TxtCodigo.Enabled = False
        ResolucionesCtrl1.Enabled = False
        MotivosCtrl1.Enabled = False
        txtObservaciones.Enabled = False
        BoxesCtrl1.Enabled = False
        On Error GoTo 0

    End Sub

    Public Sub HabilitarEdicion()

        On Error Resume Next



        ResolucionesCtrl1.Enabled = True

        MotivosCtrl1.Enabled = True
        txtObservaciones.Enabled = True

        CmdAceptar.Enabled = True
        SeccionesCtrl1.Enabled = False
        On Error GoTo 0

    End Sub

    Public Sub LimpiarDatos()
        TxtID_Turno.Text = ""
        id_turno = vbNull
        TxtFechaObtencion.Text = ""
        TxtFechaLlamado.Text = ""
        TxtCodigo.Text = ""
        ResolucionesCtrl1.Iniciar()
        MotivosCtrl1.Iniciar()
        SeccionesCtrl1.Iniciar()
        SeccionesCtrl1.SelectedValue = CInt(ValorParametro("SECCION", "SINASIGNAR"))
        TxtFechaObtencion.ReadOnly = True
        TxtFechaLlamado.ReadOnly = True
        TxtCodigo.ReadOnly = True
        Timer2.Stop()
        LblCronometro.Text = "0.00.00"
        txtObservaciones.Text = ""
        EstadosCtrl1.Iniciar("TURNOS")
        EstadosCtrl1.SelectedValue = CInt(ValorEstado("TURNOS", "GENERADO"))
        BoxesCtrl1.Iniciar_conidusuario(G_UserID)
        Grilla.DataSource = Nothing
        Timer1.Start()
    End Sub
    Private Sub EstablecerPrioridad()
        Dim VALOR As MsgBoxResult = MsgBox("Desea establecer este turno como prioridad?", MsgBoxStyle.YesNo, "ESTA SEGURO ?")
        If VALOR = MsgBoxResult.Yes Then
            Me.Estado = FormEstado.eAgregar
            establecercomoprioridad(Grilla.CurrentRow.Cells(0).Value)
            LlamarSiguiente(Grilla.CurrentRow.Cells(0).Value)
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
        Dim Resultado As Integer = 0
        Dim oTurno As New Turnos
        Dim oDS As New DataSet
        Dim oAuditoria As New AuditoriasUsuarios
        Dim oUsuarioTurnos As New UsuariosTurnos
        Dim NuevoTurno As Integer = 0
        Try

            Select Case Me.Estado

                Case FormEstado.eEdicion

                    Resultado = oObjeto.Resolver(TxtID_Turno.Text,
                                    ValorEstado("TURNOS", "SOLUCIONADO"),
                                    ResolucionesCtrl1.SelectedValue,
                                    txtObservaciones.Text,
                                    MotivosCtrl1.SelectedValue,
                                    G_UserID)

                    If ResolucionesCtrl1.SelectedValue = CInt(ValorParametro("RESOLUCION", "TRANFERIDO")) Then

                        NuevoTurno = TranferirTurno(SeccionesCtrl1.SelectedValue)

                        oTurno.AgregarTranferido(TxtID_Turno.Text, NuevoTurno, BoxesCtrl1.SelectedValue, ValorEstado("Turnos", "GENERADO"))

                    End If

                    ' oUsuarioTurno.Modificar(TxtID_Turno.Text, FechaHoraServidor, ValorEstado("TURNOS", "SOLUCIONADO"))
                    oUsuarioTurnos.Modificar(TxtID_Turno.Text, ValorEstado("TURNOS", "SOLUCIONADO"))


                    oAuditoria.ModificarTiempoOcupadoAtendido(G_UserID, ValorEstado("OPERARIO", "LIBRE"))
                    Timer2.Stop()




                    MsgBox("Se modificó el registro" & vbCrLf & "Tiempo: " & LblCronometro.Text, MsgBoxStyle.Information, G_AppName)


                    LimpiarDatos()
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

            Dim ods As New DataSet
            Dim ot As New Turnos
            ods = ot.CancelarLlamado(TxtID_Turno.Text, ValorEstado("TURNOS", "GENERADO"))
            Timer2.Stop()
            LblCronometro.Text = "0.00.00"

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
            Me.Estado = FormEstado.eOcupado
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
        If EstadoOperador = ValorEstado("OPERARIO", "LIBRE") Then
            Me.Estado = FormEstado.eVacio
        Else
            Me.Estado = FormEstado.eOcupado
        End If

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

        If ResolucionesCtrl1.SelectedValue = CInt(ValorParametro("RESOLUCION", "TRANFERIDO")) And SeccionesCtrl1.SelectedValue = CInt(ValorParametro("SECCION", "SINASIGNAR")) Then

            MsgBox("Seleccione una Sección...", MsgBoxStyle.Exclamation, G_AppName)
            Validar = False
            Exit Function

        End If

        If ResolucionesCtrl1.SelectedValue = CInt(ValorParametro("RESOLUCION", "TRANFERIDO")) And BoxesCtrl1.SelectedValue = G_BoxID Then

            MsgBox("No se puede transferir el Turno a tu mismo Box por favor seleccione otro y vuelva a intentar...", MsgBoxStyle.Exclamation, G_AppName)
            Validar = False
            Exit Function

        End If
        If ResolucionesCtrl1.SelectedValue = CInt(ValorParametro("RESOLUCION", "TRANFERIDO")) And BoxesCtrl1.SelectedValue = G_BoxID Then

            MsgBox("No se puede tranferir el turno a su mismo Box...", MsgBoxStyle.Exclamation, G_AppName)
            Validar = False
            Exit Function

        End If



        Validar = True

    End Function

    Public Function BuscarPorID(ByVal ID As Integer) As Boolean

        Dim oDs As New DataSet
        Dim oObjeto As New Turnos


        oDs = oObjeto.BuscarPorID(ID)


        If oDs.Tables(1).Rows.Count > 0 Then
            id_turno = oDs.Tables(1).Rows(0).Item("ID_Turno")
            TxtID_Turno.Text = oDs.Tables(1).Rows(0).Item("ID_Turno")
            TxtCodigo.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("Codigo")))
            SeccionesCtrl1.Iniciar()
            SeccionesCtrl1.SelectedValue = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("ID_Seccion")))
            G_SeccionID = oDs.Tables(1).Rows(0).Item("ID_Seccion")
            TxtFechaObtencion.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("FechaObtencion")))
            TxtFechaLlamado.Text = IIf(IsDBNull(oDs.Tables(1).Rows(0).Item("FechaAtencion")), 1, FechaHoraServidor)
            G_CodTurno = oDs.Tables(1).Rows(0).Item("Codigo")
            ResolucionesCtrl1.Iniciar()
            ResolucionesCtrl1.SelectedValue = IIf(IsDBNull(oDs.Tables(1).Rows(0).Item("id_resolucion")), 1, oDs.Tables(1).Rows(0).Item("id_resolucion"))
            MotivosCtrl1.Iniciar()
            MotivosCtrl1.SelectedValue = IIf(IsDBNull(oDs.Tables(1).Rows(0).Item("id_motivo")), 1, oDs.Tables(1).Rows(0).Item("id_motivo"))




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
        Dim oUsuarioTurnos As New UsuariosTurnos
        Dim oAuditoria As New AuditoriasUsuarios

        Select Case EstadosCtrl1.SelectedValue
            Case CInt(ValorEstado("TURNOS", "GENERADO"))
                oDs = oUsuarioTurnos.BuscarPorID_Usuario(G_UserID)
                If oDs.Tables(0).Rows.Count > 0 Then
                    Me.Estado = FormEstado.eAgregar
                    BuscarPorID(oDs.Tables(0).Rows(0).Item("ID_Turno"))
                    Timer1.Stop()
                    oDs = Nothing
                    oObjeto = Nothing

                    Return True
                Else
                    Grilla.DataSource = Nothing

                    oDs = oObjeto.Turnos_BuscarTransferido(G_BoxID)

                    If oDs.Tables(0).Rows.Count > 0 Then

                        Grilla.DataSource = ""
                        Grilla.DataSource = oDs.Tables(0)

                        Grilla.Columns(0).HeaderText = "#"
                        Grilla.Columns(0).Width = 30
                        Grilla.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

                        oDs = Nothing
                        oObjeto = Nothing

                        Me.Estado = FormEstado.eAgregar
                        Timer1.Stop()
                        LlamarSiguiente(Grilla.CurrentRow.Cells(0).Value)


                        Return True

                    Else
                        ' Si es covadi o roldan directamente busco turnos 
                        If G_UserID = 106 Or G_UserID = 87 Then
                            oDs = oObjeto.Turnos_BuscarTodosGeneradosPorSeccion(G_BoxID, G_UserID)
                            If oDs.Tables(0).Rows.Count > 0 Then

                                Grilla.DataSource = ""
                                Grilla.DataSource = oDs.Tables(0)

                                Grilla.Columns(0).HeaderText = "#"
                                Grilla.Columns(0).Width = 30
                                Grilla.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

                                oDs = Nothing
                                oObjeto = Nothing

                                Me.Estado = FormEstado.eAgregar
                                Timer1.Stop()
                                LlamarSiguiente(Grilla.CurrentRow.Cells(0).Value)


                                Return True

                            Else
                                oDs = Nothing
                                oObjeto = Nothing

                                Return False

                            End If
                        Else

                            ' Consulto si hay mas usuarios disponibles si no hay mas usuarios  busco turnos si hay mas usuarios disponible comparo quien es el qe menos atendio
                            oDs = oAuditoria.BuscarPorID_Usuario_Disponible(G_UserID)
                            If oDs.Tables(0).Rows.Count = 0 Then
                                oDs = oObjeto.Turnos_BuscarTodosGeneradosPorSeccion(G_BoxID, G_UserID)
                                If oDs.Tables(0).Rows.Count > 0 Then

                                    Grilla.DataSource = ""
                                    Grilla.DataSource = oDs.Tables(0)

                                    Grilla.Columns(0).HeaderText = "#"
                                    Grilla.Columns(0).Width = 30
                                    Grilla.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

                                    oDs = Nothing
                                    oObjeto = Nothing

                                    Me.Estado = FormEstado.eAgregar
                                    Timer1.Stop()
                                    LlamarSiguiente(Grilla.CurrentRow.Cells(0).Value)


                                    Return True

                                Else
                                    oDs = Nothing
                                    oObjeto = Nothing

                                    Return False

                                End If

                            Else

                                oDs = oAuditoria.BuscareldeMenorAtencion()
                                If oDs.Tables(0).Rows(0).Item("ID_Usuario") = G_UserID Then
                                    oDs = oObjeto.Turnos_BuscarTodosGeneradosPorSeccion(G_BoxID, G_UserID)
                                    If oDs.Tables(0).Rows.Count > 0 Then

                                        Grilla.DataSource = ""
                                        Grilla.DataSource = oDs.Tables(0)

                                        Grilla.Columns(0).HeaderText = "#"
                                        Grilla.Columns(0).Width = 30
                                        Grilla.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

                                        oDs = Nothing
                                        oObjeto = Nothing

                                        Me.Estado = FormEstado.eAgregar
                                        Timer1.Stop()
                                        LlamarSiguiente(Grilla.CurrentRow.Cells(0).Value)


                                        Return True

                                    Else
                                        oDs = Nothing
                                        oObjeto = Nothing

                                        Return False

                                    End If

                                Else
                                    oDs = Nothing
                                    oObjeto = Nothing

                                    Return False

                                End If
                            End If

                        End If
                    End If
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
                    Timer1.Stop()
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
                    PictureAtender.Focus()
                    EstablecerPrioridad()
                Case CInt(ValorEstado("TURNOS", "ATENDIENDO"))
                    BuscarPorID(Grilla.CurrentRow.Cells(0).Value)
                    Me.Estado = FormEstado.eEdicion
                    startTime = Now.TimeOfDay
                    Timer2.Start()
                Case CInt(ValorEstado("TURNOS", "LLAMADO"))
                    BuscarPorID(Grilla.CurrentRow.Cells(0).Value)
                    Me.Estado = FormEstado.eAgregar
                    LblCronometro.Text = "0.00.00"
                Case CInt(ValorEstado("TURNOS", "SOLUCIONADO"))
                    BuscarPorID(Grilla.CurrentRow.Cells(0).Value)
                    Me.Estado = FormEstado.eConsulta
            End Select

            Grilla.Size = New System.Drawing.Size(646, 176)
            CmdGrid.Text = "+"

        End If

    End Sub

    Private Sub Grilla1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grilla.KeyDown

        If e.KeyCode = 13 Then
            e.Handled = True
            BuscarPorID(Grilla.CurrentRow.Cells(0).Value)
            Grilla.Size = New System.Drawing.Size(646, 176)
            CmdGrid.Text = "+"
        End If

    End Sub

#End Region


    Public Function LlamarSiguiente(ByVal ID As Integer) As Boolean
        Try

            Dim oDs As New DataSet
            Dim oObjeto As New Turnos
            Dim ods2 As New DataSet
            Dim ODS5 As New DataSet
            Dim OT5 As New DataSet
            Dim oAuditoria As New AuditoriasUsuarios

            'obtenemos el id_turno del siguente turno
            If EstadosCtrl1.SelectedValue = ValorEstado("Turnos", "Generado") Then
                OT5 = oObjeto.BuscarPorID(ID)
                If OT5.Tables(0).Rows.Count > 0 Then
                    oDs = oObjeto.ObtenerSiguiente(EstadosCtrl1.SelectedValue, OT5.Tables(1).Rows(0).Item("ID_Seccion"))
                    SeccionesCtrl1.SelectedValue = OT5.Tables(1).Rows(0).Item("ID_Seccion")
                    G_CodTurno = OT5.Tables(1).Rows(0).Item("Codigo")

                End If


                If oDs.Tables(0).Rows.Count > 0 Then

                    OrdenPantalla(ID)
                    TxtID_Turno.Text = ID
                    ods2 = oObjeto.llamarTurno(ID,
                                           ValorEstado("Turnos", "Llamado"),
                                           G_UserID,
                                           SeccionesCtrl1.SelectedValue)

                    BuscarPorID(ID)

                    EstadosCtrl1.SelectedValue = ValorEstado("Turnos", "Llamado")
                    oDs = oAuditoria.BuscarPorID_UsuarioActivo(G_UserID)
                    If oDs.Tables(0).Rows(0).Item("TurnosAtendidos") = 0 Then
                        oAuditoria.ModificarPrimerTurno(G_UserID, ValorEstado("OPERARIO", "OCUPADO"))
                    Else
                        oAuditoria.ModificarTiempoLibre(G_UserID, ValorEstado("OPERARIO", "OCUPADO"))
                    End If
                    oDs = Nothing
                    oObjeto = Nothing
                    General.GetForm("Tienes un nuevo turno asignado...")
                    Me.Show()
                    LlamarSiguiente = True

                    Exit Function
                Else

                    oDs = Nothing
                    oObjeto = Nothing
                    OT5 = Nothing
                    LlamarSiguiente = False

                    Exit Function

                End If

            End If
            Return False

        Catch ex As Exception
            Return False
        End Try
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



    Private Sub RadButton1_Click(sender As System.Object, e As System.EventArgs)

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

    Private Sub btnRecargarMotivos_Click(sender As System.Object, e As System.EventArgs)

        MotivosCtrl1.Iniciar()

    End Sub
    Dim Intervalo = 0
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 10000
        BuscarTodos()

        Intervalo = Intervalo + 1
        If Intervalo = 2 Then
            Intervalo = 0
        End If
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
        BoxesCtrl1.Iniciar(SeccionesCtrl1.SelectedValue)
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
        If CmdAgregar.Enabled = True Then
            If Grilla.Rows.Count <= 0 Then
                MsgBox("No hay ningún turno!", MsgBoxStyle.Exclamation, G_AppName)
            Else
                Me.Estado = FormEstado.eAgregar
                LlamarSiguiente(Grilla.CurrentRow.Cells(0).Value)
            End If
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
        Cancelo()
        'Timer2.Stop()

        'If MsgBox("Esta seguro de Cancelar?" & vbCrLf &
        '          "Se perderán las ultimas modificaciones",
        '          vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

        '    If EstadosCtrl1.SelectedValue = ValorEstado("Turnos", "Generado") Then
        '        Dim ods As New DataSet
        '        Dim ot As New Turnos

        '        ods = ot.CancelarLlamado(TxtID_Turno.Text, EstadosCtrl1.SelectedValue)
        '        Timer2.Stop()
        '        LblCronometro.Text = "0.00.00"

        '    End If
        '    LimpiarDatos()
        '    Me.Estado = FormEstado.eVacio
        'Else
        '    startTime = Now.TimeOfDay
        '    Timer2.Start()
        'End If
    End Sub

    Private Sub Grilla_CellClick(sender As Object, e As GridViewCellEventArgs) Handles Grilla.CellClick
        Timer1.Stop()
    End Sub

    Private Sub Grilla_Click(sender As Object, e As EventArgs) Handles Grilla.Click
        Timer1.Stop()
    End Sub

    Private Sub PictureAtender_Click(sender As Object, e As EventArgs) Handles PictureAtender.Click

        If PictureAtender.Enabled = True Then

            Try
                Me.Estado = FormEstado.eEdicion
                Dim oUsuarioTurno As New UsuariosTurnos
                Dim oObjeto As New Turnos
                EstadosCtrl1.SelectedValue = ValorEstado("TURNOS", "ATENDIENDO")
                oObjeto.llamarTurno(TxtID_Turno.Text, EstadosCtrl1.SelectedValue, G_UserID, SeccionesCtrl1.SelectedValue)
                oUsuarioTurno.Modificar(TxtID_Turno.Text, EstadosCtrl1.SelectedValue)



                startTime = Now.TimeOfDay
                Timer2.Start()
            Catch ex As Exception
                MsgBox("Ocurrio un Error...", MsgBoxStyle.Critical, G_AppName)
            End Try
        End If
    End Sub

    Private Sub txtObservaciones_TextChanged(sender As Object, e As EventArgs) Handles txtObservaciones.TextChanged

    End Sub
    Private Function TranferirTurno(ByVal IDSeccion As Integer)


        Dim oSeccionesTipos As New SeccionesTipo
        Dim oTurno As New Turnos
        Dim oDsConsultaTurno As New DataSet
        Dim oDsTurno As New DataSet
        Dim oDS As New DataSet
        oDS = oSeccionesTipos.ConsultaParaAgregarTurno(IDSeccion)
        oDsConsultaTurno = oTurno.BuscarporSeccionyFecha(CType(oDS.Tables(0).Rows(0).Item("Id_Seccion"), Integer))
        If oDsConsultaTurno.Tables(0).Rows.Count > 0 Then
            id_turno = oTurno.Agregar(oDS.Tables(0).Rows(0).Item("id_Seccion"),
                                      oDS.Tables(0).Rows(0).Item("CodigoSeccion"),
                                      ValorEstado("Turnos", "GENERADO"),
                                      CType(oDsConsultaTurno.Tables(0).Rows(0).Item("nroTurno"), Integer) + 1, True)
            Return id_turno

        Else
            id_turno = oTurno.AgregarPrimero(oDS.Tables(0).Rows(0).Item("id_Seccion"),
                                      oDS.Tables(0).Rows(0).Item("CodigoSeccion"),
                                      ValorEstado("Turnos", "GENERADO"), True)
            Return id_turno

        End If

    End Function

    Private Sub ResolucionesCtrl1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ResolucionesCtrl1.SelectionChangeCommitted
        If ResolucionesCtrl1.SelectedValue = CInt(ValorParametro("RESOLUCION", "TRANFERIDO")) Then
            SeccionesCtrl1.Focus()
            SeccionesCtrl1.SelectedValue = CInt(ValorParametro("SECCION", "SINASIGNAR"))
            BoxesCtrl1.Iniciar()
            BoxesCtrl1.Enabled = True
            SeccionesCtrl1.Enabled = True
        End If
    End Sub

    Private Sub Grilla_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles Grilla.RowFormatting
        If Intervalo = 1 Then
            If e.RowElement.RowInfo.Cells("Estado").Value = "GENERADO" And e.RowElement.RowInfo.Cells("Prioridad").Value = "PRIORIDAD" Then
                e.RowElement.ForeColor = Color.Black
                e.RowElement.BackColor = Color.Yellow

            End If
        End If


    End Sub

    Private Sub CmdOcupado_Click(sender As Object, e As EventArgs) Handles CmdOcupado.Click
        Dim oAuditoria As New AuditoriasUsuarios


        Try
            'Modifico el estado para que poder asigne asignarle un turno
            Dim Estado As Integer = ValorEstado("OPERARIO", "LIBRE")
            oAuditoria.ModificarEstado(G_UserID, Estado, True)
            Timer1.Start()
            Me.Estado = FormEstado.eVacio

        Catch ex As Exception

        Finally

            oAuditoria = Nothing

        End Try
    End Sub

    Private Sub CmdDisponible_Click(sender As Object, e As EventArgs) Handles CmdDisponible.Click
        Dim oAuditoria As New AuditoriasUsuarios


        Try
            If TxtID_Turno.Text <> "" Then
                MsgBox("Tiene turnos asignados debe finalizarlo para pasar a ocupado...", MsgBoxStyle.Information, G_AppName)
            Else
                'Modifico el estado para que no se le asigne ningun turno 
                Dim Estado As Integer = ValorEstado("OPERARIO", "OCUPADO")
                oAuditoria.ModificarEstado(G_UserID, Estado, True)
                EstadoOperador = Estado
                Timer1.Stop()
                Me.Estado = FormEstado.eOcupado

            End If

        Catch ex As Exception

        Finally

            oAuditoria = Nothing

        End Try


    End Sub



    Private Sub FrmTurnosOperador_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If TxtID_Turno.Text <> "" Then
            MsgBox("Tiene turnos asignados debe finalizarlo para poder cerrar el formulario...", MsgBoxStyle.Information, G_AppName)
            e.Cancel = True
        Else
            If MsgBox("Esta seguro de Salir?",
         vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

                Dim oAuditoria As New AuditoriasUsuarios
                oAuditoria.Modificar(G_UserID, ValorEstado("OPERARIO", "OCUPADO"), True)

                Me.Dispose()
            Else
                e.Cancel = True
            End If

        End If

    End Sub


End Class