Imports CMR_DOS.AD


Public Class FrmPrincipalCliente

    Private Sub FrmPrincipalCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '  cargarBotones()
        main()
        IniciarSesion()
    End Sub


    Private Sub IniciarSesion()
        Dim oDs As New DataSet
        Dim oObjeto As New Usuarios

        oDs = oObjeto.BuscarPorLoginPass("V", "V")

        If oDs.Tables(0).Rows.Count > 0 Then

            G_UserID = oDs.Tables(0).Rows(0).Item("ID_Usuario")
            G_UserName = oDs.Tables(0).Rows(0).Item("Nombre")
            G_RolID = oDs.Tables(0).Rows(0).Item("ID_Rol")

        Else

            MsgBox("Error al iniciar sesión, verifique su Nombre de Usuario y Contraseña...", MsgBoxStyle.Exclamation, G_AppName)

        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        FrmSeccionesTipoCliente.Show()
        Me.Hide()
    End Sub

End Class
