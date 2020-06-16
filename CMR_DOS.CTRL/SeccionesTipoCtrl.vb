Imports CMR_DOS.AD
Imports System.Windows.Forms
Imports System.Drawing

Partial Public Class SeccionesTipoCtrl

    Inherits System.Windows.Forms.ComboBox

    Public Sub New()

        DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
        Font = New System.Drawing.Font("Segoe UI", 8.25, FontStyle.Regular)

    End Sub

    Public Sub Iniciar(id_Seccion As Integer)

        Dim oDs As New DataSet
        Dim oObjeto As New SeccionesTipo

        oDs = oObjeto.BuscarPorSeccion(id_Seccion)

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(2).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        Else
            MsgBox("No se encontraron subsecciones para esta seccion.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub

    Public Sub Iniciar_administrador(id_Seccion As Integer)

        Dim oDs As New DataSet
        Dim oObjeto As New SeccionesTipo

        oDs = oObjeto.BuscarPorSeccion(id_Seccion)

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(2).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
        Else
            MsgBox("No se encontraron subsecciones para esta seccion.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing

    End Sub

End Class
