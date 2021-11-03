Imports CMR_DOS.AD
Imports System.Reflection

Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Text & " " & "USUARIO: " & G_UserName



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
                 "CMR_DOS.FRM." & item.Name)
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

    Private Sub FrmPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If MsgBox("Esta seguro de Salir?",
           vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Dim oAuditoria As New AuditoriasUsuarios
            oAuditoria.CerrarSesion(G_UserID, ValorEstado("OPERARIO", "OCUPADO"), False)


            Application.Exit()
        End If
    End Sub
End Class