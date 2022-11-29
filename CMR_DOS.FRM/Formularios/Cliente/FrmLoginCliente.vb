Imports CMR_DOS.AD


Public Class FrmLoginCliente

    Private Property FrmMenuPanel As Object


    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click



        Dim oDs As New DataSet
        Dim oObjeto As New Usuarios
        Dim id_rol As Double = ValorRol("CLIENTE")
        oDs = oObjeto.BuscarPorLoginPassRol(UsernameTextBox.Text, PasswordTextBox.Text, id_rol)

        If oDs.Tables(0).Rows.Count > 0 Then

            G_UserID = oDs.Tables(0).Rows(0).Item("ID_Usuario")
            G_UserName = oDs.Tables(0).Rows(0).Item("Nombre")
            G_RolID = oDs.Tables(0).Rows(0).Item("ID_Rol")

            FrmPrincipalCliente.Show()
            Me.Hide()
        Else

            MsgBox("Error al iniciar sesión, verifique que su Nombre de Usuario y Contraseña sean correctos...", MsgBoxStyle.Exclamation, G_AppName)

        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown

        If e.KeyCode = 13 Then
            e.Handled = True

            Dim oDs As New DataSet
            Dim oObjeto As New Usuarios
            Dim id_rol As Double = ValorRol("CLIENTE")
            oDs = oObjeto.BuscarPorLoginPassRol(UsernameTextBox.Text, PasswordTextBox.Text, id_rol)

            If oDs.Tables(0).Rows.Count > 0 Then
                G_UserID = oDs.Tables(0).Rows(0).Item("ID_Usuario")
                G_UserName = oDs.Tables(0).Rows(0).Item("Nombre")
                G_RolID = oDs.Tables(0).Rows(0).Item("ID_Rol")
                FrmPrincipalCliente.Show()
                Me.Hide()
            Else

                MsgBox("Error al iniciar sesión, verifique su Nombre de Usuario y Contraseña...", MsgBoxStyle.Exclamation, G_AppName)

            End If

            oDs = Nothing
            oObjeto = Nothing

        End If


    End Sub


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub UsernameTextBox_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles UsernameTextBox.MouseClick
        Try
            Process.Start("osk.exe")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub UsernameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub
End Class
