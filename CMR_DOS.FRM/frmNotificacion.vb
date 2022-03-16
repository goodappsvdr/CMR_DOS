Public Class frmNotificacion
    Private aIndex As Byte = nIdex
    Private Altura As Integer = 100
    Dim x As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Opacity = 0 Then
            Close()
        End If
        'Opacidad
        If x = 200 Then
            Opacity -= 0.01
        End If
        If Not Location.Y = Screen.PrimaryScreen.WorkingArea.Height - Altura Then
            Location = New Point(Location.X, Location.Y - 2)
        End If

        'Opacidad
        If Not x = 200 Then
            x += 1
        End If
    End Sub

    Private Sub frmNotificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(Screen.PrimaryScreen.Bounds.Width - 300, Screen.PrimaryScreen.Bounds.Height)
        If nIdex < 3 Then
            nIdex += 1
        Else
            nIdex = 1
        End If
        If aIndex = 1 Then
            Altura = 100
        ElseIf aIndex = 2 Then
            Altura = 180
        ElseIf aIndex = 3 Then
            Altura = 260
        End If
    End Sub
    '50; 194; 77
End Class
Public Module General
    Public nIdex As Byte = 1

    Public Sub GetForm(mensaje As String)
        Dim frm As New frmNotificacion
        frm.Label1.Text = mensaje
        frm.PictureBox1.Image = My.Resources.Resource1.Error_96px
        frm.Show()
    End Sub
End Module