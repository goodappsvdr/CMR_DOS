Imports CMR_DOS.AD


Public Class FrmPrincipalCliente

    Private Sub FrmPrincipalCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        IniciarSesion()
    End Sub


    Private Sub IniciarSesion()
        Dim oDs As New DataSet
        Dim oObjeto As New Usuarios


        Try
            oDs = oObjeto.BuscarPorLoginPass(ValorParametro("USUARIO", "CLIENTELOGIN"), ValorParametro("USUARIO", "CLIENTEPASS"))
            If oDs.Tables(0).Rows.Count > 0 Then

                G_UserID = oDs.Tables(0).Rows(0).Item("ID_Usuario")
                G_UserName = oDs.Tables(0).Rows(0).Item("Nombre")
                G_RolID = oDs.Tables(0).Rows(0).Item("ID_Rol")

            Else

                MsgBox("Error al iniciar sesión, verifique su Nombre de Usuario y Contraseña...", MsgBoxStyle.Exclamation, G_AppName)

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error... ", MsgBoxStyle.Exclamation, G_AppName)
        Finally
            oDs = Nothing
            oObjeto = Nothing

        End Try




    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Start()
        G_Click = G_Click + 1
        If G_Click = 6 Then
            Dim result As Integer = MessageBox.Show("¿ Desea cerrar la aplicación ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Application.Exit()
            Else
                G_Click = 0
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Timer1.Start()
        G_Click = G_Click + 1
        If G_Click = 6 Then
            Dim result As Integer = MessageBox.Show("¿ Desea cerrar la aplicación ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Application.Exit()
            Else
                G_Click = 0
                Timer1.Stop()
            End If
        End If

    End Sub
    Dim SEGUNDOS As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SEGUNDOS = SEGUNDOS + 1
        If SEGUNDOS = 30 Then
            Timer1.Stop()
            SEGUNDOS = 0
            G_Click = 0
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            FrmSeccionesTipoCliente.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Ocurrio un error... ", MsgBoxStyle.Exclamation, G_AppName)

        End Try
    End Sub

    Private Sub FrmPrincipalCliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class
