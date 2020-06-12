Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO


Public Class Resoluciones
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub



    'BuscarPorID
    Public Function BuscarPorID(ByVal id_resolucion As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Resoluciones_BuscarporID", id_resolucion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Resoluciones_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarporSeccionTipo(ByVal id_secciontipo As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Resoluciones_BuscarTodosporSeccionTipo", id_secciontipo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '*********************BUSQUEDA POR LOS DIFERENTES CAMPOS DE LA TABLA****************


    'Insert
    Public Function Agregar(ByVal id_SeccionTipo As Integer, ByVal descripcion As String, activo As Boolean) As Double

        Try

            Return oDatabase.ExecuteScalar("Resoluciones_Agregar", id_SeccionTipo, descripcion, activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(id_resolucion As Integer, ByVal id_SeccionTipo As Integer, ByVal descripcion As String, activo As Boolean) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Resoluciones_Modificar", id_resolucion, id_SeccionTipo, descripcion, activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'VERIFICAR MODIFICACION DE PROCEDIMIENTO
    Public Function BuscarPorNombre(ByVal descripcion As String, ByVal id_SeccionTipo As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Resoluciones_BuscarPorNombre", descripcion, id_SeccionTipo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function BuscarTodosPorID_Usuario(id_usuario As Double) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Resoluciones_BuscarTodosPorID_Usuario", id_usuario)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
