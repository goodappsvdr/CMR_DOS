Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO


Public Class Motivos
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub

    ''buscar por codigo
    Public Function Motivos_ValidarNombre(ByVal Nombre As String, seccion As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Motivos_ValidarNombre", Nombre, seccion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'BuscarPorID
    Public Function BuscarPorID(ByVal id_motivo As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Motivos_BuscarporID", id_motivo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Motivos_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarporSeccionTipo(ByVal id_secciontipo As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Motivos_BuscarTodosporSeccionTipo", id_secciontipo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '*********************BUSQUEDA POR LOS DIFERENTES CAMPOS DE LA TABLA****************


    'Insert
    Public Function Agregar(ByVal id_SeccionTipo As Integer, ByVal descripcion As String, activo As Boolean) As Double

        Try

            Return oDatabase.ExecuteScalar("Motivos_Agregar", id_SeccionTipo, descripcion, activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(id_resolucion As Integer, ByVal id_SeccionTipo As Integer, ByVal descripcion As String, activo As Boolean) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Motivos_Modificar", id_resolucion, id_SeccionTipo, descripcion, activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function BuscarPorNombre(ByVal descripcion As String, ByVal id_SeccionTipo As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Motivos_BuscarPorNombre", descripcion, id_SeccionTipo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function BuscarTodosPorID_Usuario(id_usuario As Double) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Motivos_BuscarTodosPorID_Usuario", id_usuario)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
