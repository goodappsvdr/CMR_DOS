
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO


Public Class Roles

    
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub

    'BuscarPorID
    Public Function BuscarPorID(ByVal Id_rol As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Roles_BuscarPorID", Id_rol)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Roles_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarPorDescripcion(ByVal Descripcion As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Roles_BuscarPorDescripcion", Descripcion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '*********************BUSQUEDA POR LOS DIFERENTES CAMPOS DE LA TABLA****************


    'Insert
    Public Function Agregar(ByVal Descripcion As String, ByVal Estado As Double) As Double

        Try

            Return oDatabase.ExecuteScalar("Roles_Agregar", Descripcion, Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(ByVal Id_rol As Double, ByVal Descripcion As String, ByVal Estado As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Roles_Modificar", Id_rol, Descripcion, Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Function BuscarPorNombre(RoleName As String) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Roles_BuscarPorNombre", RoleName)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Function BuscarAdminYCliente() As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Roles_BuscarADmyCliente")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Function BuscarTodosMenosSistemas() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Roles_BuscarTodosmenosSistemas")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class

