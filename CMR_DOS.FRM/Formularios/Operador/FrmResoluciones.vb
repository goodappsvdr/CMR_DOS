Imports System.Drawing
Imports CMR_DOS.AD
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.UI.Data

Public Class FrmResoluciones


#Region "Variables"

    Private eEstado As FormEstado

    Private aAcceso As Boolean
    Private aNuevo As Boolean
    Private aEditar As Boolean
    Private aEliminar As Boolean
    Private aExportar As Boolean
    Private aImprimir As Boolean
    Private aConsultar As Boolean


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

                    If aConsultar = True Then

                        BuscarTodos()
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

                    TxtID.Enabled = False

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
                    TxtID.Enabled = False
                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "Agregando"
                    TxtDescripcion.Focus()

                Case FormEstado.eConsulta

                    DeshabilitarComandos()
                    CmdAgregar.Enabled = True
                    CmdModificar.Enabled = True
                    CmdEliminar.Enabled = True
                    CmdLimpiar.Enabled = True
                    CmdExportar.Enabled = False
                    DeshabilitarEdicion()
                    TxtID.Enabled = False

                Case FormEstado.eEdicion

                    DeshabilitarComandos()
                    CmdAceptar.Enabled = True
                    CmdCancelar.Enabled = True
                    CmdExportar.Enabled = False
                    HabilitarEdicion()
                    Grilla.Enabled = False
                    TxtID.Enabled = False
                    PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    LblAccion.Text = "Editando"
                    TxtDescripcion.Focus()


                Case FormEstado.eEliminar

                    DeshabilitarComandos()
                    CmdAceptar.Enabled = True
                    CmdCancelar.Enabled = True
                    CmdExportar.Enabled = False

                    Grilla.Enabled = False
                    TxtID.Enabled = False
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

        On Error Resume Next

    End Sub

    Public Sub HabilitarComandos()

        On Error Resume Next

        TxtID.Enabled = True
        TxtID.Focus()

        On Error GoTo 0

    End Sub

    Public Sub DeshabilitarEdicion()

        On Error Resume Next

        TxtID.Enabled = False
        TxtDescripcion.Enabled = False
        SeccionesCtrl1.Enabled = False
        SeccionesTipoCtrl1.Enabled = False
        checkVisible.Enabled = False


        On Error GoTo 0

    End Sub

    Public Sub HabilitarEdicion()

        On Error Resume Next


        TxtID.Enabled = True
        TxtDescripcion.Enabled = True
        SeccionesCtrl1.Enabled = True
        SeccionesTipoCtrl1.Enabled = True
        checkVisible.Enabled = True



        On Error GoTo 0

    End Sub

    Public Sub LimpiarDatos()

        TxtID.Text = ""
        TxtDescripcion.Text = ""

        SeccionesCtrl1.Iniciar()
        SeccionesTipoCtrl1.Iniciar(SeccionesCtrl1.SelectedValue)
        checkVisible.Checked = True




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


        Dim oObjeto As New Resoluciones

        Dim resultado As Double

        Try

            Select Case Me.Estado


                Case FormEstado.eAgregar


                    resultado = oObjeto.Agregar(SeccionesTipoCtrl1.SelectedValue, TxtDescripcion.Text, checkVisible.Checked)



                    'MsgBox("Se agregó el registro " & resultado, MsgBoxStyle.Information, G_AppName)
                    Me.Estado = FormEstado.eVacio

                Case FormEstado.eEdicion



                    oObjeto.Modificar( _
                                        TxtID.Text, _
                                        SeccionesTipoCtrl1.SelectedValue, _
                                        TxtDescripcion.Text, _
 _
                                        checkVisible.Checked)


                    'MsgBox("Se modificó el registro", MsgBoxStyle.Information, G_AppName)
                    Me.Estado = FormEstado.eVacio


                Case FormEstado.eEliminar


            End Select

        Catch

            Select Case Me.Estado

                Case FormEstado.eAgregar


                    MsgBox("Ocurrió un error al Agregar - " & vbCrLf & _
                     vbCrLf & _
                    Err.Description, MsgBoxStyle.Critical, G_AppName)


                Case FormEstado.eEdicion


                    MsgBox("Ocurrió un error al Modificar - " & vbCrLf & _
                     vbCrLf & _
                    Err.Description, MsgBoxStyle.Critical, G_AppName)



            End Select

        Finally

            oObjeto = Nothing

        End Try





    End Sub

    Private Sub Cancelo()

        On Error GoTo ManejoErrores

        If MsgBox("Esta seguro de Cancelar?" & vbCrLf & _
                  "Se perderán las ultimas modificaciones", _
                  vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Me.Estado = FormEstado.eVacio

        End If
        Exit Sub

ManejoErrores:
        MsgBox("Ocurrió el error " & vbCrLf & _
                 vbCrLf & _
                Err.Description)

    End Sub

#End Region

#Region "Formulario"


    Private Sub FrmResoluciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub FrmResoluciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Dispose()
        End If

    End Sub

    Private Sub FrmResoluciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        DeshabilitarPermisos()
        CargarPermisos()

        If aAcceso = True Then

            Me.BringToFront()
            Me.Estado = FormEstado.eVacio
            TxtID.Focus()

        Else

            MsgBox("No tiene permisos para realizar ninguna tarea en este formulario, consulte con el Administrador del Sistema", MsgBoxStyle.Exclamation, G_AppName)
            Me.Close()

        End If


    End Sub




#End Region

#Region "Botones de Comando"


    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgregar.Click
        Me.Estado = FormEstado.eAgregar
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

        exporter.SheetName = "Usuarios"
        exporter.SummariesExportOption = SummariesOption.DoNotExport

        Dim fileName As String = Application.StartupPath & "\Usuarios.xls"
        exporter.RunExport(fileName)

        Process.Start(Application.StartupPath & "\Usuarios.xls")

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


        If TxtDescripcion.Text = "" Or SeccionesTipoCtrl1.SelectedValue = Nothing Then

            MsgBox("Complete sus datos...", MsgBoxStyle.Exclamation, G_AppName)
            Validar = False
            Exit Function


        End If




        Validar = True

    End Function

    Public Function BuscarPorID(ByVal ID As Integer) As Boolean

        Dim oDs As New DataSet
        Dim oObjeto As New Resoluciones


        oDs = oObjeto.BuscarPorID(ID)


        If oDs.Tables(0).Rows.Count > 0 Then

            TxtID.Text = oDs.Tables(0).Rows(0).Item(0)
            TxtDescripcion.Text = LTrim(RTrim(oDs.Tables(0).Rows(0).Item("Descripcion")))
            SeccionesCtrl1.SelectedValue = LTrim(RTrim(oDs.Tables(0).Rows(0).Item("id_seccion")))
            SeccionesTipoCtrl1.Iniciar(LTrim(RTrim(oDs.Tables(0).Rows(0).Item("id_seccion"))))
            SeccionesTipoCtrl1.SelectedValue = oDs.Tables(0).Rows(0).Item("id_secciontipo")


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
        Dim oObjeto As New Resoluciones

        oDs = oObjeto.BuscarTodos()

        If oDs.Tables(0).Rows.Count > 0 Then

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

        If Grilla.Enabled = True Then

            BuscarPorID(Grilla.CurrentRow.Cells(0).Value)
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

#Region "Text ID"

    Private Sub TxtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtID.TextChanged

        If TxtID.Text <> "" And aEditar = True Then
            CmdModificar.Enabled = True
            CmdEliminar.Enabled = False
        Else
            CmdModificar.Enabled = False
            CmdEliminar.Enabled = False

        End If
    End Sub

    Private Sub SeccionesCtrl1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SeccionesCtrl1.SelectionChangeCommitted
        SeccionesTipoCtrl1.Iniciar(SeccionesCtrl1.SelectedValue)
    End Sub

#End Region




End Class