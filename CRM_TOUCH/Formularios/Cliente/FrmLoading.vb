

Public Class FrmLoading
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub FrmLoading_Load(sender As Object, e As EventArgs) Handles Me.Load


        MiLoading.Image = My.Resources.loading
        MiLoading.Location = New Point(Me.Width / 2 - MiLoading.Width / 2, Me.Height / 2 - MiLoading.Height / 2)
    End Sub
End Class