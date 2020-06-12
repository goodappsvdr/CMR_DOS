Imports CMR_DOS.AD
Imports System.Windows.Forms
Imports System.Drawing

Partial Public Class UsuariosCtrl

    Inherits System.Windows.Forms.ComboBox

    Public Sub New()

        DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
        Font = New System.Drawing.Font("Segoe UI", 8.25, FontStyle.Regular)

    End Sub

    Public Sub Iniciar(ByVal Rol As Double)

        Dim oDs As New DataSet
        Dim oObjeto As New Usuarios

        oDs = oObjeto.BuscarPorId_rol(Rol)

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        Else
            MsgBox("No se encontraron Estados.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub
    Public Sub IniciarPorRolySeccion(ByVal Rol As Double, seccion As Double)

        Dim oDs As New DataSet
        Dim oObjeto As New Usuarios

        oDs = oObjeto.BuscarPorId_rolID_Seccion(Rol, seccion)

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        Else
            'MsgBox("No se encontraron usuarios.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub

    Sub IniciarOperadoresparaAdministrador(id_rol As Integer, UserID As Double)
        Dim oDs As New DataSet
        Dim oObjeto As New Usuarios

        oDs = oObjeto.BuscarBuscarOperadoresparaAdministrador(id_rol, UserID)

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        Else
            'MsgBox("No se encontraron usuarios.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing
    End Sub

End Class
