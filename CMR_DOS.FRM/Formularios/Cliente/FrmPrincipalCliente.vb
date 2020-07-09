Imports CMR_DOS.AD


Public Class FrmPrincipalCliente

    Private Sub FrmPrincipalCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        main()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        FrmSeccionesTipoCliente.Show()
        Me.Dispose()
    End Sub
End Class
