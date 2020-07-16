Imports CMR_DOS.AD


Public Class FrmElegirBoxActual

    Private Property FrmMenuPanel As Object

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SeccionesCtrl1.IniciarPorID_Usuario(G_UserID)
        BoxesCtrl1.Iniciar(SeccionesCtrl1.SelectedValue)
        ' CargarBoxes(G_UserID)
        main()
    End Sub

    'Private Sub CargarBoxes(UserID As Double)

    '    BoxesCtrl1.Iniciar_conidusuario(UserID)
    'End Sub

    Private Sub CmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles CmdAceptar.Click
        Dim ods As New DataSet
        Dim oBU As New BoxesUsuarios
        ods = oBU.ActivarUnBox(G_UserID, BoxesCtrl1.SelectedValue)
        'ods = oBU.BoxesUsuario_ModificarActivo(G_UserID, G_BoxID, 1)
        G_BoxID = BoxesCtrl1.SelectedValue
        G_seccionID = SeccionesCtrl1.SelectedValue
        Me.Dispose()

    End Sub

    Private Sub SeccionesCtrl1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SeccionesCtrl1.SelectionChangeCommitted
        BoxesCtrl1.Iniciar(SeccionesCtrl1.SelectedValue)
    End Sub





    'Private Sub CmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles CmdAceptar.Click
    '    Dim ods As New DataSet
    '    Dim oBU As New BoxesUsuarios
    '    Dim obo As New Boxes
    '    'ods = oBU.ActivarUnBox(G_UserID, BoxesCtrl1.SelectedValue)
    '    'verifico el estado del box seleccionado
    '    ods = obo.Box_VerificarEstado(BoxesCtrl1.SelectedValue)
    '    G_BoxID = BoxesCtrl1.SelectedValue
    '    'bandera indica si esta activo o no el box
    '    bandera = Convert.ToString(ods.Tables(0).Rows(0).Item("activo"))
    '    If bandera = True Then
    '        'si esta en true, el box esta libre y se modifica

    '        'modifico a ocupado e iniciamos
    '        ods = obo.BoxModificarEstado(G_UserID, G_BoxID, 0)
    '        ods = oBU.BoxesUsuario_ModificarActivo(G_UserID, G_BoxID, 1)
    '        FrmPrincipal.Show()
    '        FrmLogin.Close()
    '        Me.Close()
    '        'Me.Hide()
    '    Else
    '        MsgBox("El box esta ocupado!", MsgBoxStyle.Exclamation, G_AppName)
    '        'Me.Dispose()

    '    End If




End Class
