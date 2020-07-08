Imports CMR_DOS.AD


Public Class FrmPrincipalCliente

    Private Sub FrmPrincipalCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '  cargarBotones()

    End Sub


    Private Sub cargarBotones()

        Dim I As Integer = 1
        Dim oObjeto As New Secciones
        Dim G_SeccionTable As DataTable = oObjeto.Secciones_BuscarTodosporEstadoyUsuario(G_UserID).Tables(0)

        If G_SeccionTable.Rows.Count > 0 Then
            If G_SeccionTable.Rows.Count = 1 Then
                Dim id_seccion As String = G_SeccionTable.Rows(0).Item("id_Seccion")
                Dim oST As New SeccionesTipo

                G_SecciontipoTable = oST.BuscarPorSeccion(id_seccion)
                FrmSeccionesTipoCliente.Show()
                Me.Dispose()
            Else
                For Each fila As DataRow In G_SeccionTable.Rows

                    Dim b As New Button()
                    b.Text = CStr(fila("Nombre"))
                    b.Name = CStr(fila("id_seccion")) & "a"
                    Dim myFontpredet As System.Drawing.Font = b.Font
                    Dim fontsizepredet As Double = myFontpredet.Size
                    Dim heightpredet As Double = b.Height
                    If G_SeccionTable.Rows.Count >= 5 Then
                        b.Height = Panel1.Height / G_SeccionTable.Rows.Count - 4
                    Else
                        b.Height = Panel1.Height / 5 - 4
                    End If

                    b.Left = 10
                    b.Width = Panel1.Width - 20

                    b.Top = (I - 1) * (b.Height + 3)
                    b.ForeColor = Color.White
                    Dim newfontsize As Double = ((b.Height * fontsizepredet) / heightpredet) * 0.5
                    Dim fontsizereal As Single = newfontsize
                    Dim myFont As System.Drawing.Font
                    myFont = New System.Drawing.Font("Segoe UI", fontsizereal, FontStyle.Bold Or FontStyle.Italic)
                    b.Font = myFont

                    'Opcional, conectar el evento click:
                    AddHandler b.Click, AddressOf Button_Click
                    Panel1.Controls.Add(b)
                    I += 1

                Next
            End If
        End If
    End Sub



    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim id_seccion As String = CType(sender, System.Windows.Forms.Button).Name.ToString
        Dim oObjeto As New SeccionesTipo
        Dim id As Integer = CType(Mid(id_seccion, 1, Len(id_seccion) - 1), Integer)
        G_SecciontipoTable = oObjeto.BuscarPorSeccion(id)
        FrmSeccionesTipoCliente.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LblFechayHora.Text = DateTime.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmSeccionesTipoCliente.Show()
        Me.Dispose()
    End Sub
End Class
