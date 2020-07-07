Public Class FrmPantallaInicio
    Private Sub Btn_SolicitarTurno_Click(sender As Object, e As EventArgs) Handles Btn_SolicitarTurno.Click
        FrmPrincipalCliente.Show()
        Me.Dispose()
    End Sub
End Class