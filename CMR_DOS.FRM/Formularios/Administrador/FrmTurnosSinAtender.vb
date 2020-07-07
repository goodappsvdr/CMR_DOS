Imports System.Drawing
Imports CMR_DOS.AD
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.UI.Data
Imports System.ComponentModel

Public Class FrmTurnosSinAtender
    Dim ultimo As Integer
#Region "Variables"

    Private eEstado As FormEstado

    Private aAcceso As Boolean
    Private aNuevo As Boolean
    Private aEditar As Boolean
    Private aEliminar As Boolean
    Private aExportar As Boolean
    Private aImprimir As Boolean
    Private aConsultar As Boolean


    Private id_turno As Integer
    Private id_secciontipo As Integer

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
                    CmdAtender.Enabled = False
                    If aConsultar = True Then
                        Timer1.Enabled = True
                        Grilla.Enabled = True
                    Else

                        Grilla.Enabled = False

                    End If

                    If aNuevo = True Then
                        CmdAgregar.Enabled = True
                    Else
                        CmdAgregar.Enabled = False
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

                    DeshabilitarComandos()
                    HabilitarEdicion()
                    LimpiarDatos()
                    Grilla.Enabled = False
                    CmdCancelar.Enabled = True
                    CmdAceptar.Enabled = True
                    CmdLimpiar.Enabled = True
                    CmdExportar.Enabled = False
                    'TxtID.Enabled = False
                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "Agregando"
                    TxtSeccion.Focus()

                Case FormEstado.eConsulta

                    DeshabilitarComandos()
                    CmdAgregar.Enabled = True
                    CmdModificar.Enabled = True
                    CmdEliminar.Enabled = True
                    CmdLimpiar.Enabled = True
                    CmdExportar.Enabled = False
                    DeshabilitarEdicion()
                    'TxtID.Enabled = False

                Case FormEstado.eEdicion

                    DeshabilitarComandos()
                    CmdAceptar.Enabled = True
                    CmdCancelar.Enabled = True
                    CmdExportar.Enabled = False
                    HabilitarEdicion()
                    Grilla.Enabled = False
                    'TxtID.Enabled = False
                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "Editando"
                    TxtSeccion.Focus()


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
        CmdAgregar.Enabled = False
        CmdModificar.Enabled = False
        CmdExportar.Enabled = False
        CmdLimpiar.Enabled = False
        CmdEliminar.Enabled = False
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
        TxtSubSeccion.Enabled = False
        TxtFechaObtencion.Enabled = False
        TxtFechaLlamado.Enabled = False
        TxtCodigo.Enabled = False
        ResolucionesCtrl1.Enabled = False
        checkPrioridad.Enabled = False
        BtnRecargarResoluciones.Enabled = False
        MotivosCtrl1.Enabled = False
        txtObservaciones.Enabled = False

        btnRecargarMotivos.Enabled = False
        On Error GoTo 0

    End Sub

    Public Sub HabilitarEdicion()

        On Error Resume Next


        TxtSeccion.Enabled = True
        TxtSubSeccion.Enabled = True
        TxtFechaObtencion.Enabled = True
        TxtFechaLlamado.Enabled = True
        TxtCodigo.Enabled = True
        ResolucionesCtrl1.Enabled = True
        checkPrioridad.Enabled = True
        BtnRecargarResoluciones.Enabled = True
        MotivosCtrl1.Enabled = True
        txtObservaciones.Enabled = True
        btnRecargarMotivos.Enabled = True
        On Error GoTo 0

    End Sub

    Public Sub LimpiarDatos()

        id_turno = vbNull
        TxtSeccion.Text = ""
        TxtSubSeccion.Text = ""
        TxtFechaObtencion.Text = ""
        TxtFechaLlamado.Text = ""
        TxtCodigo.Text = ""

        TxtSeccion.ReadOnly = True
        TxtSubSeccion.ReadOnly = True
        TxtFechaObtencion.ReadOnly = True
        TxtFechaLlamado.ReadOnly = True
        TxtCodigo.ReadOnly = True
        ResolucionesCtrl1.DataSource = Nothing
        checkPrioridad.Checked = False
        MotivosCtrl1.DataSource = Nothing
        txtObservaciones.Text = ""



    End Sub
    'Private Sub EstablecerPrioridad()
    '    Dim VALOR As MsgBoxResult = MsgBox("Desea establecer este turno como prioridad?", MsgBoxStyle.YesNo, "ESTA SEGURO ?")

    '    If VALOR = MsgBoxResult.Yes Then
    '        establecercomoprioridad(Grilla.CurrentRow.Cells(0).Value)
    '        LlamarSiguiente()
    '    End If
    'End Sub


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

        'Dim resultado As Double

        Try

            Select Case Me.Estado


                'Case FormEstado.eAgregar


                '    resultado = oObjeto.Agregar(TxtNombre.Text, TxtCodigo.Text, EstadosCtrl1.SelectedValue)



                '    'MsgBox("Se agregó el registro " & resultado, MsgBoxStyle.Information, G_AppName)
                '   Me.Estado = FormEstado.eVacio

                Case FormEstado.eEdicion

                    oObjeto.Resolver(id_turno,
                                    ValorEstado("TURNOS", "SINATENDER"),
                                    ResolucionesCtrl1.SelectedValue,
                                    txtObservaciones.Text,
                                    MotivosCtrl1.SelectedValue,
                                    G_UserID)

                    Timer2.Stop()
                    ' MsgBox("Se modificó el registro" & vbCrLf & "Tiempo: " & LblCronometro.Text, MsgBoxStyle.Information, G_AppName)


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

                ods = ot.CancelarLlamado(id_turno, id_estado)
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

        If e.KeyCode = Keys.F4 And CmdModificar.Enabled = True Then ' modificar
            Me.Estado = FormEstado.eEdicion
        End If

        If e.KeyCode = Keys.F10 And CmdEliminar.Enabled = True Then ' eliminar
            Me.Estado = FormEstado.eEliminar
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



        DeshabilitarPermisos()
        CargarPermisos()

        If aAcceso = True Then

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


    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgregar.Click
        If Grilla.Rows.Count <= 0 Then
            MsgBox("No hay ningùn turno!", MsgBoxStyle.Exclamation)
        Else

            'llamar turno 

            'Me.Estado = FormEstado.eAgregar
            If Me.Estado = FormEstado.eVacio Then
                CmdAtender.Enabled = True
                ' LlamarSiguiente()
                DeshabilitarEdicion()
            ElseIf Me.Estado = FormEstado.eEdicion Then
                If Validar() = True Then
                    Acepto()
                    ' LlamarSiguiente()
                Else
                End If
            End If

        End If

    End Sub

    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdModificar.Click
        Me.Estado = FormEstado.eEdicion
    End Sub

    Private Sub CmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEliminar.Click
        Me.Estado = FormEstado.eEliminar
    End Sub

    Private Sub CmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLimpiar.Click
        Me.Estado = FormEstado.eVacio
    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Cancelo()
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        If Validar() = True Then
            Acepto()
        Else
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

        Dim id_resolucion As Integer = ValorResolucion("SIN ASIGNAR", id_secciontipo)
        Dim id_motivo As Integer = ValorMotivo("SIN ASIGNAR", id_secciontipo)
        If ResolucionesCtrl1.SelectedValue = id_resolucion Or MotivosCtrl1.SelectedValue = id_motivo Then

            MsgBox("Asigne la resolucion y motivo al turno para continuar ...", MsgBoxStyle.Exclamation, G_AppName)
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
            LblID_Turno.Text = oDs.Tables(1).Rows(0).Item(0)
            id_turno = oDs.Tables(1).Rows(0).Item(0)
            TxtCodigo.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("Codigo")))
            TxtSeccion.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("Seccion")))
            TxtSubSeccion.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("Subseccion")))
            TxtFechaObtencion.Text = LTrim(RTrim(oDs.Tables(1).Rows(0).Item("FechaObtencion")))
            TxtFechaLlamado.Text = oDs.Tables(1).Rows(0).Item("FechaAtencion").ToString
            checkPrioridad.Checked = oDs.Tables(1).Rows(0).Item("prioridad")
            id_secciontipo = (oDs.Tables(1).Rows(0).Item("id_seccionTipo"))
            ResolucionesCtrl1.Iniciar(oDs.Tables(1).Rows(0).Item("id_seccionTipo"))
            ResolucionesCtrl1.SelectedValue = oDs.Tables(1).Rows(0).Item("ID_RESOLUCION")
            MotivosCtrl1.Iniciar(oDs.Tables(1).Rows(0).Item("id_seccionTipo"))
            MotivosCtrl1.SelectedValue = oDs.Tables(1).Rows(0).Item("ID_MOTIVO")

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
        oDs = oObjeto.BuscarTodosLlamdosSinAtender

        If oDs.Tables(0).Rows.Count <> Grilla.Rows.Count Then
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

    End Function

#End Region

#Region "Grilla"

    Private Sub Grilla_CellDoubleClick(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Grilla.CellDoubleClick

        'If Grilla.Enabled = True Then
        '    If EstadosCtrl1.Text = "SINATENDER" Then
        '        If Me.Estado = FormEstado.eVacio Then
        '            EstablecerPrioridad()
        '        ElseIf Me.Estado = FormEstado.eEdicion Then
        '            If Validar() = True Then
        '                Acepto()
        '                EstablecerPrioridad()
        '            Else

        '            End If
        '        End If


        '    End If
        'If EstadosCtrl1.Text = "SOLUCIONADO" Or EstadosCtrl1.Text = "LLAMADO" Or EstadosCtrl1.Text = "ATENDIENDO" Then
        '    Me.Estado = FormEstado.eEdicion
        '    BuscarPorID(Grilla.CurrentRow.Cells(0).Value)
        '    Grilla.Size = New System.Drawing.Size(646, 176)
        '    CmdGrid.Text = "+"

        '    If EstadosCtrl1.Text = "ATENDIENDO" Then

        '        startTime = Now.TimeOfDay
        '        Timer2.Start()
        '    End If

        '    If EstadosCtrl1.Text = "LLAMADO" Then
        '        LblCronometro.Text = "0.00.00"
        '        CmdAtender.Enabled = True


        '    End If


        'End If
        BuscarPorID(Grilla.CurrentRow.Cells(0).Value)
        Grilla.Size = New System.Drawing.Size(646, 176)
            CmdGrid.Text = "+"

       ' End If

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

#Region "Text ID"

    Private Sub TxtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If id_turno <> "" And aEditar = True Then
            CmdModificar.Enabled = True
            CmdEliminar.Enabled = False
        Else
            CmdModificar.Enabled = False
            CmdEliminar.Enabled = False

        End If
    End Sub

#End Region


    'Public Function LlamarSiguiente() As Boolean

    '    Dim oDs As New DataSet
    '    Dim oObjeto As New Turnos
    '    Dim ods2 As New DataSet
    '    Dim ODS5 As New DataSet
    '    Dim OT5 As New Turnos
    '    'obtenemos el id_turno del siguente turno
    '    oDs = oObjeto.ObtenerSiguiente(G_UserID, ValorEstado("Turnos", "Generado"))


    '    If oDs.Tables(0).Rows.Count > 0 Then
    '        OrdenPantalla(oDs.Tables(0).Rows(0).Item("id_turno"))
    '        LblID_Turno.Text = oDs.Tables(0).Rows(0).Item("id_turno")
    '        ods2 = oObjeto.llamarTurno(oDs.Tables(0).Rows(0).Item("id_turno"), ValorEstado("Turnos", "Llamado"), G_UserID)


    '        BuscarPorID(oDs.Tables(0).Rows(0).Item("id_turno"))


    '        oDs = Nothing
    '        oObjeto = Nothing
    '        Me.Estado = FormEstado.eEdicion
    '        LlamarSiguiente = True

    '    Else

    '        oDs = Nothing
    '        oObjeto = Nothing

    '        LlamarSiguiente = False

    '        Exit Function

    '    End If



    'End Function

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
        Dim oTurno As New Turnos
        Dim ods As New DataSet
        ods = oTurno.EstablecerPrioridad(id_turno)
        CmdAtender.Enabled = True
    End Sub



    Private Sub RadButton1_Click(sender As System.Object, e As System.EventArgs) Handles BtnRecargarResoluciones.Click
        If id_secciontipo <> vbNull Then
            ResolucionesCtrl1.Iniciar(CType(id_secciontipo, Integer))
        End If
    End Sub



    Private Sub EstadosCtrl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles EstadosCtrl1.SelectedIndexChanged
        Try
            Me.BringToFront()
            Me.Estado = FormEstado.eVacio
            txtObservaciones.Focus()
        Catch ex As Exception

        End Try

        'Valido que la grilla este llena sino no se habilita
        If EstadosCtrl1.SelectedIndex = 0 Then
            CmdAgregar.Enabled = True
        Else
            If Grilla.Rows.Count <= 0 Then
                Grilla.Enabled = False
                CmdAgregar.Enabled = False
            Else
                Grilla.Enabled = True
                CmdAgregar.Enabled = False
            End If
        End If


    End Sub




    Private Sub btnRecargarMotivos_Click(sender As System.Object, e As System.EventArgs) Handles btnRecargarMotivos.Click
        If id_secciontipo <> vbNull Then
            MotivosCtrl1.Iniciar(id_secciontipo)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        BuscarTodos()

    End Sub

    Private Sub CmdAtender_Click(sender As System.Object, e As System.EventArgs) Handles CmdAtender.Click
        Dim oObjeto As New Turnos
        'BuscarPorID(LblID_Turno.Text)
        ' If MsgBox("Desea iniciar la resolucion del turno?", MsgBoxStyle.YesNo, G_AppName) = MsgBoxResult.Yes Then
        oObjeto.llamarTurno(LblID_Turno.Text, ValorEstado("TURNOS", "ATENDIENDO"), G_UserID)
        HabilitarEdicion()
        CmdAtender.Enabled = False
        startTime = Now.TimeOfDay
        Timer2.Start()
        '  Else
        '  End If
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

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigo.TextChanged
        If TxtCodigo.Text <> "" Then
            CmdModificar.Enabled = True
        Else
            CmdModificar.Enabled = False
        End If
    End Sub

    'Private Sub FrmTurnosOperador_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    If Grilla.Rows.Count > 0 Then
    '        Dim result As Integer = MessageBox.Show("¿Tiene turnos sin atender desea cerrar de todo modos " + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '        If result = DialogResult.Yes Then

    '        End If
    '    End If
    'End Sub
End Class