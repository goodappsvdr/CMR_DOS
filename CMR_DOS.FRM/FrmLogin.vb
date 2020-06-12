Imports CMR_DOS.AD


Public Class FrmLogin

    Private Property FrmMenuPanel As Object


    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click

        IniciarSesion()

        





    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown

        If e.KeyCode = 13 Then
            e.Handled = True


            IniciarSesion()
            '    Dim oDs As New DataSet
            '    Dim oObjeto As New Usuarios

            '    oDs = oObjeto.BuscarPorLoginPass(UsernameTextBox.Text, PasswordTextBox.Text)

            '    If oDs.Tables(0).Rows.Count > 0 Then
            '        G_UserID = oDs.Tables(0).Rows(0).Item("ID_Usuario")
            '        G_UserName = oDs.Tables(0).Rows(0).Item("Nombre")
            '        G_RolID = oDs.Tables(0).Rows(0).Item("ID_Rol")
            '        If G_RolID = ValorRol("ADMINISTRADOR") Then
            '            Dim ods_US As New DataSet
            '            Dim oUS As New UsuariosSecciones
            '            ods_US = oUS.BuscarPorIDUsuario(G_UserID)
            '            If ods_US.Tables(0).Rows.Count > 0 Then
            '                g_seccionID = ods_US.Tables(0).Rows(0).Item("ID_Seccion")
            '            End If

            '        End If

            '        FrmPrincipal.Show()
            '        Me.Hide()
            '    Else

            '        MsgBox("Error al iniciar sesión, verifique su Nombre de Usuario y Contraseña...", MsgBoxStyle.Exclamation, G_AppName)

            '    End If

            '    oDs = Nothing
            '    oObjeto = Nothing

        End If


    End Sub


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        main()
        cargarImagen()
    End Sub
    Private Sub cargarImagen()
        Dim ods As New DataSet
        Dim op As New Parametros
        ods = op.BuscarPorCategoriaNombre("EMPRESA", "LOGO")
        If ods.Tables(0).Rows.Count > 0 Then
            LOGO.ImageLocation = ods.Tables(0).Rows(0).Item("Valor")
        End If

    End Sub
    Private Sub IniciarSesion()
        Dim oDs As New DataSet
        Dim oObjeto As New Usuarios

        oDs = oObjeto.BuscarPorLoginPass(UsernameTextBox.Text, PasswordTextBox.Text)

        If oDs.Tables(0).Rows.Count > 0 Then

            G_UserID = oDs.Tables(0).Rows(0).Item("ID_Usuario")
            G_UserName = oDs.Tables(0).Rows(0).Item("Nombre")
            G_RolID = oDs.Tables(0).Rows(0).Item("ID_Rol")
            Select Case G_RolID


                Case Is = ValorRol("ADMINISTRADOR")
                    Dim ods_US As New DataSet
                    Dim oUS As New UsuariosSecciones
                    ods_US = oUS.BuscarPorIDUsuario(G_UserID)
                    'If ods_US.Tables(0).Rows.Count > 0 Then
                    '    g_seccionID = ods_US.Tables(0).Rows(0).Item("ID_Seccion")
                    'End If
                    FrmPrincipal.Show()
                    Me.Hide()



                Case Is = ValorRol("Sistemas")
                    FrmPrincipal.Show()
                    Me.Hide()



                Case Is = ValorRol("Operador")
                    Dim ods2 As New DataSet
                    Dim ods3 As New DataSet
                    Dim oUST As New UsuariosSeccionesTipo
                    Dim oBU As New BoxesUsuarios
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
                                'MsgBox(ods3.Tables(0).Rows(0).Item("box") & " elegido para esta sesión!", MsgBoxStyle.Exclamation, G_AppName)
                                FrmPrincipal.Show()
                                Me.Hide()
                            Else
                                'si el operador tiene mas de un box activo, elegir en cual box trabajara en este momento.
                                FrmElegirBoxActual.ShowDialog()
                                Dim ban As Boolean = True
                                While ban
                                    If G_BoxID <> Nothing Then
                                        Dim obox As New Boxes
                                        Dim odsbox As New DataSet
                                        odsbox = obox.BuscarPorID(G_BoxID)

                                        ' MsgBox(odsbox.Tables(0).Rows(0).Item("codigobox") & odsbox.Tables(0).Rows(0).Item("nrobox") & " elegido para esta sesión!", MsgBoxStyle.Exclamation, G_AppName)
                                        ban = False
                                    Else
                                        FrmElegirBoxActual.ShowDialog()
                                        ban = True
                                    End If
                                End While

                                FrmPrincipal.Show()
                                Me.Hide()
                            End If

                        Else
                            MsgBox("Aún no tiene un box asignado, pida al administrador que le asigne un box e intentelo nuevamente...", MsgBoxStyle.Exclamation, G_AppName)

                        End If


                    Else
                        MsgBox("Aún no tiene una subsección asignada, pida al administrador que le asigne una subsección e intentelo nuevamente...", MsgBoxStyle.Exclamation, G_AppName)

                    End If



                Case Is = ValorRol("Cliente")
                    FrmPrincipalCliente.Show()
                    Me.Hide()
            End Select





        Else

            MsgBox("Error al iniciar sesión, verifique su Nombre de Usuario y Contraseña...", MsgBoxStyle.Exclamation, G_AppName)

        End If

        oDs = Nothing
        oObjeto = Nothing



    End Sub


End Class
