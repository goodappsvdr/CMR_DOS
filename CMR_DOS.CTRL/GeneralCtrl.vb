Imports CMR_DOS.AD
Imports System.Windows.Forms
Imports System.Drawing


Partial Public Class GeneralCrl
    Inherits System.Windows.Forms.ComboBox

    Public Sub New()

        DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
        Font = New System.Drawing.Font("Segoe UI", 8.25, FontStyle.Regular)

    End Sub

    Public Sub IniciarParametro()
        Dim oDs As New DataSet
        Dim oObjeto As New Parametros

        oDs = oObjeto.BuscarPorCategoria("R_COMBO")

        If oDs.Tables(0).Rows.Count > 0 Then


            DataSource = oDs.Tables(0)
            DisplayMember = oDs.Tables(0).Columns(0).Caption.ToString
            ValueMember = oDs.Tables(0).Columns(1).Caption.ToString
        Else
            MsgBox("No se encontraron Estados.", MsgBoxStyle.Exclamation, "Información...")
        End If

        oDs = Nothing
        oObjeto = Nothing



    End Sub
    Public Sub IniciarSegunCaso(Parametro As String, seccion As Double, userid As Double)

        Dim oDs As New DataSet
        Select Case Parametro



            Case Is = "ESTADOS"
                Dim oObjeto As New Estados
                oDs = oObjeto.BuscarPorCategoria("Turnos")
                If oDs.Tables(0).Rows.Count > 0 Then
                    DataSource = oDs.Tables(0)
                    DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
                    ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
                Else
                    MsgBox("No se encontraron Estados.", MsgBoxStyle.Exclamation, "Información...")
                End If



            Case Is = "SECCIONES"
                Dim oObjeto As New Secciones
                oDs = oObjeto.BuscarporIDAdministrador(userid)
                If oDs.Tables(0).Rows.Count > 0 Then
                    DataSource = oDs.Tables(0)
                    DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
                    ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
                Else
                    MsgBox("No se encontraron secciones.", MsgBoxStyle.Exclamation, "Información...")
                End If




            'Case Is = "SUBSECCIONES"
            '    Dim oObjeto As New SeccionesTipo
            '    oDs = oObjeto.BuscarPorSeccion(seccion)
            '    If oDs.Tables(0).Rows.Count > 0 Then
            '        DataSource = oDs.Tables(0)
            '        DisplayMember = oDs.Tables(0).Columns(2).Caption.ToString
            '        ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
            '    Else
            '        MsgBox("No se encontraron subsecciones.", MsgBoxStyle.Exclamation, "Información...")
            '    End If




            Case Is = "OPERADORES"
                Dim oObjeto As New Usuarios
                oDs = oObjeto.BuscarPorId_rolID_Seccion(4, seccion)
                If oDs.Tables(0).Rows.Count > 0 Then
                    DataSource = oDs.Tables(0)
                    DisplayMember = oDs.Tables(0).Columns(1).Caption.ToString
                    ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
                Else
                    MsgBox("No se encontraron operadores.", MsgBoxStyle.Exclamation, "Información...")
                End If




            Case Is = "MOTIVOS"
                Dim oObjeto As New Motivos
                oDs = oObjeto.BuscarTodos
                If oDs.Tables(0).Rows.Count > 0 Then
                    DataSource = oDs.Tables(0)
                    DisplayMember = oDs.Tables(0).Columns(2).Caption.ToString
                    ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
                Else
                    MsgBox("No se encontraron motivos.", MsgBoxStyle.Exclamation, "Información...")
                End If




            Case Is = "RESOLUCIONES"
                Dim oObjeto As New Resoluciones
                oDs = oObjeto.BuscarTodos
                If oDs.Tables(0).Rows.Count > 0 Then
                    DataSource = oDs.Tables(0)
                    DisplayMember = oDs.Tables(0).Columns(2).Caption.ToString
                    ValueMember = oDs.Tables(0).Columns(0).Caption.ToString
                Else
                    MsgBox("No se encontraron resoluciones.", MsgBoxStyle.Exclamation, "Información...")
                End If



        End Select




        oDs = Nothing

    End Sub
End Class
