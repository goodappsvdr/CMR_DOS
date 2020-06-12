Imports CMR_DOS.AD


Public Class FrmLoginOperador

    Private Property FrmMenuPanel As Object


    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click

        '''''''''''''''SISTEMAS Y ADMINISTRADOR

        Dim oDs As New DataSet
        Dim oObjeto As New Usuarios
        Dim id_rol As Double = ValorRol("OPERADOR")

        oDs = oObjeto.BuscarPorLoginPassRol(UsernameTextBox.Text, PasswordTextBox.Text, id_rol)

        If oDs.Tables(0).Rows.Count > 0 Then
            Dim ods2 As New DataSet
            Dim ods3 As New DataSet
            Dim oUST As New UsuariosSeccionesTipo
            Dim oBU As New BoxesUsuarios

            G_UserID = oDs.Tables(0).Rows(0).Item("ID_Usuario")
            G_UserName = oDs.Tables(0).Rows(0).Item("Nombre")
            G_RolID = oDs.Tables(0).Rows(0).Item("ID_Rol")
            ods2 = oUST.BuscarPorIDUsuario(G_UserID)
            'verifico que el operador tenga una secciontipo
            If ods2.Tables(0).Rows.Count > 0 Then
                ods3 = oBU.ObtenerBoxdeOperador(G_UserID)
                'verifico que el operador tenga un box
                If ods3.Tables(0).Rows.Count > 0 Then
                    'verifico que el operador no tenga mas de un box asignado
                    If ods3.Tables(0).Rows.Count = 1 Then
                        G_BoxID = ods3.Tables(0).Rows(0).Item("id_box")
                        'me aseguro de que el box dado de alta este activo
                        oBU.ActivarUnBox(G_UserID, G_BoxID)
                        FrmPrincipal.Show()
                        Me.Hide()
                    Else
                        'si el operador tiene mas de un box activo, elegir en cual box trabajara en este momento.
                        FrmElegirBoxActual.ShowDialog()
                        FrmPrincipal.Show()
                        Me.Hide()
                    End If

                Else
                    MsgBox("Aún no tiene un box asignado, pida al administrador que le asigne un box e intentelo nuevamente...", MsgBoxStyle.Exclamation, G_AppName)

                End If


            Else
                MsgBox("Aún no tiene una subseccion asignada, pida al administrador que le asigne una subseccion e intentelo nuevamente...", MsgBoxStyle.Exclamation, G_AppName)

            End If

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
            Dim id_rol As Double = ValorRol("OPERADOR")
            oDs = oObjeto.BuscarPorLoginPassRol(UsernameTextBox.Text, PasswordTextBox.Text, id_rol)

            If oDs.Tables(0).Rows.Count > 0 Then
                Dim ods2 As New DataSet
                Dim ods3 As New DataSet
                Dim oUST As New UsuariosSeccionesTipo
                Dim oBU As New BoxesUsuarios

                G_UserID = oDs.Tables(0).Rows(0).Item("ID_Usuario")
                G_UserName = oDs.Tables(0).Rows(0).Item("Nombre")
                G_RolID = oDs.Tables(0).Rows(0).Item("ID_Rol")
                ods2 = oUST.BuscarPorIDUsuario(G_UserID)
                'verifico que el operador tenga una secciontipo
                If ods2.Tables(0).Rows.Count > 0 Then
                    ods3 = oBU.ObtenerBoxdeOperador(G_UserID)
                    'verifico que el operador tenga un box
                    If ods3.Tables(0).Rows.Count > 0 Then
                        'verifico que el operador no tenga mas de un box asignado
                        If ods3.Tables(0).Rows.Count = 1 Then
                            G_BoxID = ods3.Tables(0).Rows(0).Item("id_box")
                            'me aseguro de que el box dado de alta este activo
                            oBU.ActivarUnBox(G_UserID, G_BoxID)
                            FrmPrincipal.Show()
                            Me.Hide()
                        Else
                            'si el operador tiene mas de un box activo, elegir en cual box trabajara en este momento.
                            FrmElegirBoxActual.ShowDialog()
                            FrmPrincipal.Show()
                            Me.Hide()
                        End If

                    Else
                        MsgBox("Aún no tiene un box asignado, pida al administrador que le asigne un box e intentelo nuevamente...", MsgBoxStyle.Exclamation, G_AppName)

                    End If


                Else
                    MsgBox("Aún no tiene una subseccion asignada, pida al administrador que le asigne una subseccion e intentelo nuevamente...", MsgBoxStyle.Exclamation, G_AppName)

                End If

            Else

                MsgBox("Error al iniciar sesión, verifique que su Nombre de Usuario y Contraseña sean correctos...", MsgBoxStyle.Exclamation, G_AppName)

            End If

                oDs = Nothing
                oObjeto = Nothing

            End If


    End Sub


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        main()
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
