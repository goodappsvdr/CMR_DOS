Imports System.Drawing
Imports CMR_DOS.AD
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.UI.Data

Public Class FrmReportes


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

                    'DeshabilitarComandos()
                    DeshabilitarEdicion()
                    LimpiarDatos()

                    'If aConsultar = True Then

                    '    'BuscarTodos()
                    '    'Grilla.Enabled = True
                    'Else

                    '    'Grilla.Enabled = False

                    'End If

                    'If aNuevo = True Then
                    '    CmdAgregar.Enabled = True
                    'Else
                    '    CmdAgregar.Enabled = False
                    'End If

                    'CmdAceptar.Enabled = False
                    'CmdLimpiar.Enabled = True

                    If aExportar = True Then
                        CmdExportar.Enabled = True
                    Else
                        CmdExportar.Enabled = False
                    End If

                    'TxtID.Enabled = False

                    PanelColor.BackColor = Color.FromArgb(74, 97, 132)
                    LblAccion.Text = "Listo"
                    'Grilla.Focus()

                Case FormEstado.eAgregar

                    'DeshabilitarComandos()
                    'HabilitarEdicion()
                    'LimpiarDatos()
                    ''Grilla.Enabled = False
                    'CmdCancelar.Enabled = True
                    'CmdAceptar.Enabled = True
                    'CmdLimpiar.Enabled = True
                    'CmdExportar.Enabled = False
                    ''TxtID.Enabled = False
                    'PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    'LblAccion.Text = "Agregando"
                    ''TxtNombre.Focus()

                Case FormEstado.eConsulta

                    'DeshabilitarComandos()
                    'CmdAgregar.Enabled = True
                    'CmdModificar.Enabled = True
                    'CmdEliminar.Enabled = True
                    'CmdLimpiar.Enabled = True
                    'CmdExportar.Enabled = False
                    'DeshabilitarEdicion()
                    ''TxtID.Enabled = False

                Case FormEstado.eEdicion

                    'DeshabilitarComandos()
                    'CmdAceptar.Enabled = True
                    'CmdCancelar.Enabled = True
                    'CmdExportar.Enabled = False
                    'HabilitarEdicion()
                    ''Grilla.Enabled = False
                    ''TxtID.Enabled = False
                    'PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    'LblAccion.Text = "Editando"
                    ''TxtNombre.Focus()


                Case FormEstado.eEliminar

                    'DeshabilitarComandos()
                    'CmdAceptar.Enabled = True
                    'CmdCancelar.Enabled = True
                    'CmdExportar.Enabled = False

                    ''Grilla.Enabled = False
                    ''TxtID.Enabled = False
                    'PanelColor.BackColor = Color.FromArgb(206, 81, 0)
                    'LblAccion.Text = "Eliminando"


            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

#Region "Procedimientos Propios"

   

    Public Sub HabilitarComandos()

        On Error Resume Next

        'TxtID.Enabled = True
        'TxtID.Focus()

        On Error GoTo 0

    End Sub

    Public Sub DeshabilitarEdicion()

        On Error Resume Next

        'TxtID.Enabled = False
        '' BoxesCtrl1.Enabled = False
        'UsuariosCtrl1.Enabled = False
        'EstadosCtrl1.Enabled = False
        'SeccionesTipoCtrl1.Enabled = False
        On Error GoTo 0

    End Sub

    Public Sub HabilitarEdicion()

        On Error Resume Next

        'TxtID.Enabled = True
        ''  BoxesCtrl1.Enabled = True
        'UsuariosCtrl1.Enabled = True
        'EstadosCtrl1.Enabled = True
        'SeccionesTipoCtrl1.Enabled = True


        On Error GoTo 0

    End Sub

    Public Sub LimpiarDatos()

        GeneralCrl1.IniciarParametro()
        GeneralCrl1.SelectedIndex = 0
        EstadosCtrl1.IniciarconTodos("TURNOS")
        EstadosCtrl1.SelectedIndex = 3
        iniciarCombos()
        fechadesde.Value = Date.Now
        fechahasta.Value = Date.Now


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




    

#End Region

#Region "Formulario"


    

    Private Sub FrmRoles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Dispose()
        End If

    End Sub

    Private Sub FrmRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        DeshabilitarPermisos()
        CargarPermisos()

        If aAcceso = True Then

            Me.BringToFront()
            Me.Estado = FormEstado.eVacio
            'TxtID.Focus()

        Else

            MsgBox("No tiene permisos para realizar ninguna tarea en este formulario, consulte con el Administrador del Sistema", MsgBoxStyle.Exclamation, G_AppName)
            Me.Close()

        End If


    End Sub




#End Region

#Region "Botones de Comando"


    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub CmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLimpiar.Click

    End Sub

    
    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click

        If Validar() = True Then
            acepto()
        End If
    End Sub

#End Region

#Region "Acepto"
    Public Sub acepto()
        Select Case GeneralCrl1.Text.ToString


            Case Is = "MOTIVOS"
                If GeneralCrl4.SelectedValue.ToString <> "" And EstadosCtrl1.SelectedValue.ToString <> "" Then
                    R_IDMotivo = GeneralCrl4.SelectedValue
                    R_IDEstado = EstadosCtrl1.SelectedValue
                    R_Fechadesde = fechadesde.Value
                    R_FechaHasta = fechahasta.Value
                    R_Reporte = "MOTIVOS"
                    R_Viewer.Show()
                    R_Viewer.WindowState = FormWindowState.Maximized
                End If

            Case Is = "RESOLUCIONES"
                If GeneralCrl4.SelectedValue.ToString <> "" And EstadosCtrl1.SelectedValue.ToString <> "" Then
                    R_IDResolucion = GeneralCrl4.SelectedValue
                    R_IDEstado = EstadosCtrl1.SelectedValue
                    R_Fechadesde = fechadesde.Value
                    R_FechaHasta = fechahasta.Value
                    R_Reporte = "RESOLUCIONES"
                    R_Viewer.Show()
                    R_Viewer.WindowState = FormWindowState.Maximized
                End If

            Case Is = "OPERADORES"
                If GeneralCrl2.SelectedValue.ToString <> "" And EstadosCtrl1.SelectedValue.ToString <> "" Then
                    R_IDOperador = GeneralCrl2.SelectedValue
                    R_IDEstado = EstadosCtrl1.SelectedValue
                    R_Fechadesde = fechadesde.Value
                    R_FechaHasta = fechahasta.Value
                    R_Reporte = "OPERADORES"
                    R_Viewer.Show()
                    R_Viewer.WindowState = FormWindowState.Maximized
                End If

            Case Is = "SECCIONES"
                If GeneralCrl2.SelectedValue.ToString <> "" And EstadosCtrl1.SelectedValue.ToString <> "" Then
                    R_IDSeccion = GeneralCrl2.SelectedValue
                    R_IDEstado = EstadosCtrl1.SelectedValue
                    R_Fechadesde = fechadesde.Value
                    R_FechaHasta = fechahasta.Value
                    R_Reporte = "SECCIONES"
                    R_Viewer.Show()
                    R_Viewer.WindowState = FormWindowState.Maximized
                End If


        End Select

    End Sub


#End Region


#Region "Funciones Propias"

    Private Function Validar() As Boolean

        'Dim ods As New DataSet
        'Dim oUST As New UsuariosSeccionesTipo
        'ods = oUST.BuscarPorIDUsuario(UsuariosCtrl1.SelectedValue)
        'If ods.Tables(0).Rows.Count > 0 Then
        '    Dim i As Integer = 0
        '    While (i < ods.Tables(0).Rows.Count)
        '        If ods.Tables(0).Rows(i).Item("id_seccionTipo") = SeccionesTipoCtrl1.SelectedValue Then
        '            MsgBox("Este usuario ya se encuentra relacionado con esta subseccion...", MsgBoxStyle.Exclamation, G_AppName)
        '            Validar = False
        '            Exit Function
        '        End If
        '        i = i + 1
        '    End While
        'End If
        'If TxtNombre.Text = "" Then

        '    MsgBox("Ingrese Descripción...", MsgBoxStyle.Exclamation, G_AppName)
        '    Validar = False
        '    Exit Function

        'End If

        If fechadesde.Value > fechahasta.Value Then
            MsgBox("Ingrese fechas correctas...", MsgBoxStyle.Exclamation, G_AppName)
            Validar = False
            Exit Function
        End If
        If fechadesde.Value <= DateTime.Today Then
            Validar = True
        Else
            MsgBox("Ingrese fechas correctas...", MsgBoxStyle.Exclamation, G_AppName)
            Validar = False
            Exit Function
        End If

        If fechahasta.Value <= DateTime.Today Then
            Validar = True
        Else
            MsgBox("Ingrese fechas correctas...", MsgBoxStyle.Exclamation, G_AppName)
            Validar = False
            Exit Function
        End If

        Validar = True

    End Function

    Public Function BuscarPorID(ByVal ID As Integer) As Boolean

        Dim oDs As New DataSet
        Dim oObjeto As New UsuariosSeccionesTipo


        oDs = oObjeto.BuscarPorID(ID)


        If oDs.Tables(0).Rows.Count > 0 Then

            'TxtID.Text = oDs.Tables(0).Rows(0).Item(0)
            'UsuariosCtrl1.SelectedValue = oDs.Tables(0).Rows(0).Item("ID_USUARIO")
            'EstadosCtrl1.SelectedValue = oDs.Tables(0).Rows(0).Item("ID_Estado")
            'SeccionesTipoCtrl1.SelectedValue = oDs.Tables(0).Rows(0).Item("ID_SeccionesTipo")

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

    'Private Function BuscarTodos() As Boolean

    'Dim oDs As New DataSet
    'Dim oObjeto As New UsuariosSeccionesTipo

    'oDs = oObjeto.BuscarTodos

    'If oDs.Tables(0).Rows.Count > 0 Then

    '    Grilla.DataSource = oDs.Tables(0)

    '    Grilla.Columns(0).HeaderText = "#"
    '    Grilla.Columns(0).Width = 30
    '    Grilla.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

    '    oDs = Nothing
    '    oObjeto = Nothing

    '    Return True

    'Else
    '    oDs = Nothing
    '    oObjeto = Nothing

    '    Return False

    'End If

    'End Function

#End Region

    Private Sub iniciarCombos()
        etiqueta1.Text = ""

        etiqueta3.Text = ""
        GeneralCrl2.Visible = False

        GeneralCrl4.Visible = False
        GeneralCrl2.DataSource = Nothing

        GeneralCrl4.DataSource = Nothing


        Try
            Select Case GeneralCrl1.Text.ToString
                Case Is = "ESTADOS"
                    GeneralCrl2.DataSource = Nothing

                    GeneralCrl4.DataSource = Nothing
                    GeneralCrl2.IniciarSegunCaso("ESTADOS", vbNull, vbNull)
                    etiqueta1.Text = "ESTADOS"
                    GeneralCrl2.Visible = True
                Case Is = "MOTIVOS"
                    GeneralCrl2.DataSource = Nothing

                    GeneralCrl4.DataSource = Nothing
                    GeneralCrl2.IniciarSegunCaso("SECCIONES", vbNull, G_UserID)
                    etiqueta1.Text = "SECCIONES"
                    GeneralCrl2.Visible = True
                    GeneralCrl4.IniciarSegunCaso("MOTIVOS", vbNull, vbNull)
                    etiqueta3.Text = "MOTIVOS"
                    GeneralCrl4.Visible = True
                Case Is = "RESOLUCIONES"
                    GeneralCrl2.DataSource = Nothing

                    GeneralCrl4.DataSource = Nothing
                    GeneralCrl2.IniciarSegunCaso("SECCIONES", vbNull, G_UserID)
                    etiqueta1.Text = "SECCIONES"
                    GeneralCrl2.Visible = True

                    GeneralCrl4.IniciarSegunCaso("RESOLUCIONES", vbNull, vbNull)
                    etiqueta3.Text = "RESOLUCIONES"
                    GeneralCrl4.Visible = True
                Case Is = "OPERADORES"
                    GeneralCrl2.DataSource = Nothing
                    'GeneralCrl3.DataSource = Nothing
                    GeneralCrl4.DataSource = Nothing
                    GeneralCrl2.IniciarSegunCaso("SECCIONES", vbNull, G_UserID)
                    etiqueta1.Text = "SECCIONES"
                    GeneralCrl2.Visible = True
                    'GeneralCrl3.IniciarSegunCaso("OPERADORES", GeneralCrl2.SelectedValue, vbNull, vbNull)
                    'etiqueta2.Text = "OPERADORES"
                    'GeneralCrl3.Visible = True
                    'GeneralCrl4.IniciarSegunCaso("OPERADORES", vbNull, vbNull, GeneralCrl3.SelectedValue)
                    'etiqueta3.Text = "OPERADORES"
                    'GeneralCrl4.Visible = True
                Case Is = "SECCIONES"
                    GeneralCrl2.DataSource = Nothing

                    GeneralCrl4.DataSource = Nothing
                    GeneralCrl2.IniciarSegunCaso("SECCIONES", vbNull, G_UserID)
                    etiqueta1.Text = "SECCIONES"
                    GeneralCrl2.Visible = True
                Case Is = "SUBSECCIONES"
                    GeneralCrl2.DataSource = Nothing
                    'GeneralCrl3.DataSource = Nothing
                    GeneralCrl4.DataSource = Nothing
                    GeneralCrl2.IniciarSegunCaso("SECCIONES", vbNull, G_UserID)
                    etiqueta1.Text = "SECCIONES"
                    GeneralCrl2.Visible = True
                    ' GeneralCrl3.IniciarSegunCaso("SUBSECCIONES", GeneralCrl2.SelectedValue, vbNull, vbNull)
                    'etiqueta2.Text = "SUBSECCIONES"
                    'GeneralCrl3.Visible = True
            End Select







        Catch ex As Exception

        End Try
    End Sub



















    Private Sub GeneralCrl2_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles GeneralCrl2.SelectionChangeCommitted
        'etiqueta2.Text = ""
        'etiqueta3.Text = ""
        'GeneralCrl3.Visible = False
        GeneralCrl4.Visible = False
        Select Case GeneralCrl1.Text.ToString
            'Case Is = "SUBSECCIONES"
            '    GeneralCrl3.DataSource = Nothing
            '    GeneralCrl4.DataSource = Nothing
            '    GeneralCrl3.IniciarSegunCaso("SUBSECCIONES", GeneralCrl2.SelectedValue, vbNull, vbNull)
            '    etiqueta2.Text = "SUBSECCIONES"
            '    GeneralCrl3.Visible = True
            Case Is = "MOTIVOS"
                'GeneralCrl3.DataSource = Nothing
                'GeneralCrl4.DataSource = Nothing
                'GeneralCrl3.IniciarSegunCaso("SUBSECCIONES", GeneralCrl2.SelectedValue, vbNull, vbNull)
                'etiqueta2.Text = "SUBSECCIONES"
                'GeneralCrl3.Visible = True
                GeneralCrl4.IniciarSegunCaso("MOTIVOS", vbNull, vbNull)
                etiqueta3.Text = "MOTIVOS"
                GeneralCrl4.Visible = True
            Case Is = "RESOLUCIONES"
                'GeneralCrl3.DataSource = Nothing
                'GeneralCrl4.DataSource = Nothing
                'GeneralCrl3.IniciarSegunCaso("SUBSECCIONES", GeneralCrl2.SelectedValue, vbNull, vbNull)
                'etiqueta2.Text = "SUBSECCIONES"
                'GeneralCrl3.Visible = True
                GeneralCrl4.IniciarSegunCaso("RESOLUCIONES", vbNull, vbNull)
                etiqueta3.Text = "RESOLUCIONES"
                GeneralCrl4.Visible = True
            Case Is = "OPERADORES"

                'GeneralCrl3.DataSource = Nothing
                'GeneralCrl4.DataSource = Nothing
                'GeneralCrl3.IniciarSegunCaso("OPERADORES", GeneralCrl2.SelectedValue, vbNull)
                'etiqueta2.Text = "OPERADORES"
                'GeneralCrl3.Visible = True
        End Select
    End Sub

    Private Sub GeneralCrl3_SelectionChangeCommitted(sender As Object, e As System.EventArgs)
        Try
            If GeneralCrl1.Text.ToString <> "OPERADORES" Then
                etiqueta3.Text = ""
                GeneralCrl4.Visible = False

                GeneralCrl4.DataSource = Nothing
                Select Case GeneralCrl1.Text.ToString
                    Case Is = "MOTIVOS"
                        GeneralCrl4.IniciarSegunCaso("MOTIVOS", vbNull, vbNull)
                        etiqueta3.Text = "MOTIVOS"
                        GeneralCrl4.Visible = True

                    Case Is = "RESOLUCIONES"
                        GeneralCrl4.IniciarSegunCaso("RESOLUCIONES", vbNull, vbNull)
                        etiqueta3.Text = "RESOLUCIONES"
                        GeneralCrl4.Visible = True

                        'Case Is = "OPERADORES"
                        '    GeneralCrl4.IniciarSegunCaso("OPERADORES", GeneralCrl3.SelectedValue, vbNull, vbNull)
                        '    etiqueta3.Text = "OPERADORES"
                        '    GeneralCrl4.Visible = True
                End Select
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GeneralCrl1_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles GeneralCrl1.SelectionChangeCommitted
        Try
            iniciarCombos()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub CmdExportar_Click(sender As System.Object, e As System.EventArgs) Handles CmdExportar.Click
        Select Case GeneralCrl1.Text.ToString


            Case Is = "MOTIVOS"
                If GeneralCrl4.SelectedValue.ToString <> "" And EstadosCtrl1.SelectedValue.ToString <> "" Then
                    R_IDMotivo = GeneralCrl4.SelectedValue
                    R_IDEstado = EstadosCtrl1.SelectedValue
                    R_Fechadesde = fechadesde.Value
                    R_FechaHasta = fechahasta.Value
                    R_Reporte = "MOTIVOS_EXP"
                    R_Viewer.Show()
                    R_Viewer.WindowState = FormWindowState.Maximized
                End If

            Case Is = "RESOLUCIONES"
                If GeneralCrl4.SelectedValue.ToString <> "" And EstadosCtrl1.SelectedValue.ToString <> "" Then
                    R_IDResolucion = GeneralCrl4.SelectedValue
                    R_IDEstado = EstadosCtrl1.SelectedValue
                    R_Fechadesde = fechadesde.Value
                    R_FechaHasta = fechahasta.Value
                    R_Reporte = "RESOLUCIONES_EXP"
                    R_Viewer.Show()
                    R_Viewer.WindowState = FormWindowState.Maximized
                End If

            Case Is = "OPERADORES"
                If GeneralCrl2.SelectedValue.ToString <> "" And EstadosCtrl1.SelectedValue.ToString <> "" Then
                    R_IDOperador = GeneralCrl2.SelectedValue
                    R_IDEstado = EstadosCtrl1.SelectedValue
                    R_Fechadesde = fechadesde.Value
                    R_FechaHasta = fechahasta.Value
                    R_Reporte = "OPERADORES_EXP"
                    R_Viewer.Show()
                    R_Viewer.WindowState = FormWindowState.Maximized
                End If

            Case Is = "SECCIONES"
                If GeneralCrl2.SelectedValue.ToString <> "" And EstadosCtrl1.SelectedValue.ToString <> "" Then
                    R_IDSeccion = GeneralCrl2.SelectedValue
                    R_IDEstado = EstadosCtrl1.SelectedValue
                    R_Fechadesde = fechadesde.Value
                    R_FechaHasta = fechahasta.Value
                    R_Reporte = "SECCIONES_EXP"
                    R_Viewer.Show()
                    R_Viewer.WindowState = FormWindowState.Maximized
                End If

                'Case Is = "SUBSECCIONES"
                '    If GeneralCrl.SelectedValue.ToString <> "" And EstadosCtrl1.SelectedValue.ToString <> "" Then
                '        R_IDSeccionTipo = GeneralCrl3.SelectedValue
                '        R_IDEstado = EstadosCtrl1.SelectedValue
                '        R_Fechadesde = fechadesde.Value
                '        R_FechaHasta = fechahasta.Value
                '        R_Reporte = "SUBSECCIONES_EXP"
                '        R_Viewer.Show()
                '        R_Viewer.WindowState = FormWindowState.Maximized
                'End If



        End Select
    End Sub
End Class