Imports CMR_DOS.AD
Imports System.Reflection
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives

Public Class FrmMenuPanel

    Private Sub FrmMenuPanel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Esta seguro de Salir?",
         vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Dim oAuditoria As New AuditoriasUsuarios
            oAuditoria.Modificar(G_UserID, ValorEstado("OPERARIO", "OCUPADO"), False)

            System.Windows.Forms.Application.Exit()
        Else
            e.Cancel = True
        End If


        End
    End Sub

    Private Sub FrmMenuPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'If ValorParametro("FONDO", "CLARO", G_EmpresaID) = 1 Then

        '    Panel1.BackColor = Color.WhiteSmoke

        'Else

        '    Panel1.BackColor = Color.FromArgb(41, 56, 82)

        'End If

        ' Dim Dir As String = My.Application.Info.DirectoryPath
        ' PbLogo.Image = Image.FromFile(Dir & "\Img\LogoEmpresa.png")


        Dim Xpos As Integer
        Dim ypos As Integer


        Xpos = (Panel1.Width / 2) - (PbLogo.Width / 2)
        ypos = (Panel1.Height / 2) - (PbLogo.Height / 2)
        Me.PbLogo.Location = New Point(Xpos, ypos)





        Dim ods As New DataSet
        Dim ods2 As New DataSet
        Dim omenu As New Menu


        ods = omenu.CargarCabecera(G_UserID)

        For i = 0 To ods.Tables(0).Rows.Count - 1


            Dim menu1 As New ToolStripMenuItem() With {.Text = ods.Tables(0).Rows(i).Item("Nombre"), .Name = ods.Tables(0).Rows(i).Item("ID_Menu")}
            AddHandler menu1.Click, AddressOf mnuItem_Clicked

            MenuStrip1.Items.Add(menu1)


            ods2 = omenu.BuscarPorId_padre(ods.Tables(0).Rows(i).Item("ID_Menu"), G_UserID)

            For j = 0 To ods2.Tables(0).Rows.Count - 1

                'Add a submenu to Menu 1
                Dim menu2 As New ToolStripMenuItem() With {.Text = ods2.Tables(0).Rows(j).Item("Nombre"), .Name = ods2.Tables(0).Rows(j).Item("Formulario")}
                'We have a reference to menu1 already, but here's how you can find the menu item by name...

                For Each item As ToolStripMenuItem In MenuStrip1.Items
                    If item.Name = ods.Tables(0).Rows(i).Item("ID_Menu") Then
                        item.DropDownItems.Add(menu2)
                        AddHandler menu2.Click, AddressOf mnuItem_Clicked
                    End If
                Next



            Next



        Next



    End Sub

  

    Private Sub mnuItem_Clicked(ByVal sender As Object, ByVal e As EventArgs)

        ' On Error Resume Next

        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        'If item IsNot Nothing Then
        '    MsgBox("You've clicked " & item.Text)
        'End If

        If Mid(item.Name, 1, 3) = "Frm" Then

            Dim frm As New Form

            Dim Type As Type = Assembly.GetExecutingAssembly().GetType(
                 "IDEAS.FRM." & item.Name)
            If Type IsNot Nothing Then
                frm = Activator.CreateInstance(Type)
                frm.TopLevel = False
                frm.StartPosition = FormStartPosition.Manual
                frm.Location = New Point(270, 5)
                frm.Parent = Me.Panel1
                frm.Show()

            End If

        End If

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button1.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button2.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button3.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button4.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button5.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button6.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button7.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button8.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button9.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button10.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button11.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Dim ods As New DataSet
        Dim omenu As New Menu
        ods = omenu.BuscarPorNombre(Button12.Text)
        Dim prueba As String
        prueba = ods.Tables(0).Rows(0).Item("Formulario")

        Try

            Dim asm As System.Reflection.Assembly = _
                System.Reflection.Assembly.GetExecutingAssembly()

            Dim frm As Form = _
                CType(asm.CreateInstance("IDEAS.FRM." & prueba), Form)
            frm.TopLevel = False
            frm.Parent = Me.Panel1
            frm.StartPosition = FormStartPosition.Manual
            frm.Location = New Point(270, 5)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub



    Private Sub Button1_MouseHover(sender As Object, e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(41, 56, 82)
        Button1.ForeColor = Color.White
    End Sub


    Private Sub Button2_MouseHover(sender As Object, e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(41, 56, 82)
        Button2.ForeColor = Color.White
    End Sub


    Private Sub Button3_MouseHover(sender As Object, e As System.EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.White
        Button3.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.FromArgb(41, 56, 82)
        Button3.ForeColor = Color.White
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As System.EventArgs) Handles Button4.MouseHover
        Button4.BackColor = Color.White
        Button4.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.FromArgb(41, 56, 82)
        Button4.ForeColor = Color.White
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As System.EventArgs) Handles Button5.MouseHover
        Button5.BackColor = Color.White
        Button5.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As System.EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.FromArgb(41, 56, 82)
        Button5.ForeColor = Color.White
    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As System.EventArgs) Handles Button6.MouseHover
        Button6.BackColor = Color.White
        Button6.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As System.EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.FromArgb(41, 56, 82)
        Button6.ForeColor = Color.White
    End Sub

    Private Sub Button7_MouseHover(sender As Object, e As System.EventArgs) Handles Button7.MouseHover
        Button7.BackColor = Color.White
        Button7.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As System.EventArgs) Handles Button7.MouseLeave
        Button7.BackColor = Color.FromArgb(41, 56, 82)
        Button7.ForeColor = Color.White
    End Sub

    Private Sub Button8_MouseHover(sender As Object, e As System.EventArgs) Handles Button8.MouseHover
        Button8.BackColor = Color.White
        Button8.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As System.EventArgs) Handles Button8.MouseLeave
        Button8.BackColor = Color.FromArgb(41, 56, 82)
        Button8.ForeColor = Color.White
    End Sub

    Private Sub Button9_MouseHover(sender As Object, e As System.EventArgs) Handles Button9.MouseHover
        Button9.BackColor = Color.White
        Button9.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button9_MouseLeave(sender As Object, e As System.EventArgs) Handles Button9.MouseLeave
        Button9.BackColor = Color.FromArgb(41, 56, 82)
        Button9.ForeColor = Color.White
    End Sub

    Private Sub Button10_MouseHover(sender As Object, e As System.EventArgs) Handles Button10.MouseHover
        Button10.BackColor = Color.White
        Button10.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button10_MouseLeave(sender As Object, e As System.EventArgs) Handles Button10.MouseLeave
        Button10.BackColor = Color.FromArgb(41, 56, 82)
        Button10.ForeColor = Color.White
    End Sub

    Private Sub Button11_MouseHover(sender As Object, e As System.EventArgs) Handles Button11.MouseHover
        Button11.BackColor = Color.White
        Button11.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button11_MouseLeave(sender As Object, e As System.EventArgs) Handles Button11.MouseLeave
        Button11.BackColor = Color.FromArgb(41, 56, 82)
        Button11.ForeColor = Color.White
    End Sub

    Private Sub Button12_MouseHover(sender As Object, e As System.EventArgs) Handles Button12.MouseHover
        Button12.BackColor = Color.White
        Button12.ForeColor = Color.FromArgb(41, 56, 82)
    End Sub

    Private Sub Button12_MouseLeave(sender As Object, e As System.EventArgs) Handles Button12.MouseLeave
        Button12.BackColor = Color.FromArgb(41, 56, 82)
        Button12.ForeColor = Color.White
    End Sub

   
  
    Private Sub PanelColor_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelColor.Paint

    End Sub

    Private Sub FrmMenuPanel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim oAuditoria As New AuditoriasUsuarios
        oAuditoria.CerrarSesion(G_UserID, ValorEstado("OPERARIO", "OCUPADO"), False)
    End Sub
End Class