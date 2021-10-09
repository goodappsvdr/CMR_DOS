Imports System.Runtime.InteropServices
Imports CMR_DOS.AD


Public Class FrmLogin

    Private Property FrmMenuPanel As Object

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If CInt(e.KeyCode) = CInt(Keys.Enter) Then
            IniciarSesion(UsernameTextBox.Text, PasswordTextBox.Text)
        End If
    End Sub


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        main()

    End Sub
    Private Sub IniciarSesion(ByVal Usuario As String, ByVal Password As String)
        Dim oDs As New DataSet
        Dim oObjeto As New Usuarios
        Dim oUsuarioLogin As New UsuariosLogin


        oDs = oObjeto.BuscarPorLoginPass(Usuario, Password)

        If oDs.Tables(0).Rows.Count > 0 Then

            G_UserID = oDs.Tables(0).Rows(0).Item("ID_Usuario")
            G_UserName = oDs.Tables(0).Rows(0).Item("Nombre")
            G_RolID = oDs.Tables(0).Rows(0).Item("ID_Rol")
            G_UsuarioLogin = oUsuarioLogin.Agregar(G_UserID, G_RolID, FechaHoraServidor, FechaHoraServidor, ValorEstado("OPERARIO", "OCUPADO"), True)
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
                    Dim oUST As New UsuariosSecciones
                    Dim oBU As New BoxesUsuarios

                    Dim ods4 As New DataSet

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

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Btn_IniciarSesion_Click(sender As Object, e As EventArgs) Handles Btn_IniciarSesion.Click
        IniciarSesion(UsernameTextBox.Text, PasswordTextBox.Text)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Application.Exit()
    End Sub

    Private Sub PasswordTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyUp
        If CInt(e.KeyCode) = CInt(Keys.Enter) Then
            IniciarSesion(UsernameTextBox.Text, PasswordTextBox.Text)
        End If

    End Sub

End Class
