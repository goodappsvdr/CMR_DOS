Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class BoxesUsuarios
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub



    'desactiva todos los boxes del usuario, y activa solo el box seleccionado
    Public Function ActivarUnBox(ByVal id_Usuario As Double, ByVal id_box As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BoxesUsuarios_ActivarBox", id_Usuario, id_box)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    'consulta los boxes del operador
    Function ObtenerBoxdeOperador(id_operador As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("BoxesUsuarios_ObtenerBox", id_operador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    'BuscarPorID
    Public Function BuscarPorID(ByVal Id As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BoxesUsuarios_BuscarporID", Id)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'Verificar estado
    Public Function Box_VerificarEstado(ByVal Id As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Box_VerificarEstado", Id)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BoxesUsuarios_Verificar(ByVal IdBox As Integer, ByVal IdUsuario As Integer, ByVal IdSeccion As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BoxesUsuarios_Verificar", IdBox, IdUsuario, IdSeccion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'BuscarPorID
    Public Function BuscarBoxesUsuario(ByVal Id As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BuscarBoxesUsuario", Id)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    
    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BoxesUsuarios_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'Insert
    Public Function Agregar(id_BOX As Integer, ByVal id_usuario As Integer, ByVal id_seccion As Integer, ByVal id_estado As Integer) As Double


        Try

            Return oDatabase.ExecuteScalar("BoxesUsuarios_Agregar", id_BOX, id_usuario, id_seccion, id_estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(ByVal id_BoxUsuario As Double, id_BOX As Integer, ByVal id_usuario As Integer, ByVal ID_Seccion As Integer, ByVal id_estado As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BoxesUsuarios_Modificar", id_BoxUsuario, id_BOX, id_usuario, ID_Seccion, id_estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function BoxesUsuarios_BuscarporID(ByVal idboxusuario As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BoxesUsuarios_BuscarporID", idboxusuario)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'Function BuscarTodosporSeccion(id_seccion As Integer) As DataSet
    '    Try

    '        Return oDatabase.ExecuteDataSet("BoxesUsuarios_BuscarTodosPorSeccion", id_seccion)

    '    Catch ex As System.Exception
    '        Throw ex
    '    End Try
    'End Function

    Function buscarporIDAdministador(USER_ID As Double) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("BoxesUsuarios_BuscarTodosPorAdministrador", USER_ID)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    'Update

    Public Function BoxesUsuario_ModificarActivo(ByVal id_usuario As Integer, ByVal id_box As Integer, ByVal id_estado As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BoxesUsuario_ModificarActivo", id_usuario, id_box, id_estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

End Class
