Imports CMR_DOS.AD
Imports System.Windows.Forms
Imports System.Drawing

Partial Public Class SeccionesCtrl

    Inherits System.Windows.Forms.ComboBox

    Public Sub New()

        DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
        Font = New System.Drawing.Font("Segoe UI", 8.25, FontStyle.Regular)

    End Sub

    Public Sub Iniciar()

        Dim oDs As New DataSet
        Dim oObjeto As New Secciones

        oDs = oObjeto.BuscarTodos()

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        Else
            MsgBox("No se encontraron Secciones.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub






    Public Sub Iniciarcombo()

        Dim oDs As New DataSet
        Dim oObjeto As New Boxes

        oDs = oObjeto.BuscarTodos()

        DataSource = oDs.Tables(0)
        DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
        ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        
       

    End Sub
    Public Sub IniciarPorID_Usuario(ID_Usuario)

        Dim oDs As New DataSet
        Dim oObjeto As New Secciones

        oDs = oObjeto.SeccionesPorUsuario(ID_Usuario)

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        Else
            MsgBox("No se encontraron secciones para este operador.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub
    Public Sub Iniciar_Operador2(id_operador, id_administrador)

        Dim oDs As New DataSet
        Dim oObjeto As New Secciones

        oDs = oObjeto.BuscarporIDOperadoryAdministrador(id_operador, id_administrador)

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        Else
            MsgBox("No se encontraron secciones para este operador.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub

    ''Secciones_BuscarPorIDAdministrador
    Public Sub Iniciar_Administrador(id_administrador)

        Dim oDs As New DataSet
        Dim oObjeto As New Secciones

        oDs = oObjeto.BuscarporIDAdministrador(id_administrador)

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        Else
            MsgBox("No se encontraron secciones para este operador.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub

End Class
