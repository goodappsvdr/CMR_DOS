Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO


Public Class Usuarios

    Dim oDatabase As Database


    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
        oDatabase = DatabaseFactory.CreateDatabase(str)
    End Sub
    'BuscarPorID
    Public Function BuscarPorID(ByVal Id_usuario As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarPorID", Id_usuario)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarPorID_Empresa(ByVal ID_Empresa As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarPorID_Empresa", ID_Empresa)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '*********************BUSQUEDA POR LOS DIFERENTES CAMPOS DE LA TABLA****************

    Public Function BuscarPorDescripcion(ByVal Descripcion As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarporDescripcion", Descripcion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function BuscarPorId_rol(ByVal Id_rol As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarporIdrol", Id_rol)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

   


    Public Function BuscarPorLogin(ByVal Login As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarporLogin", Login)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function BuscarPorLoginPass(ByVal Login As String, ByVal Pass As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarPorLoginPass", Login, Pass)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function BuscarPorLoginPassRol(ByVal Login As String, ByVal Pass As String, id_rol As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarPorLoginPassRol", Login, Pass, id_rol)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarPorPass(ByVal Pass As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarporPass", Pass)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function BuscarPorEstado(ByVal Estado As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_BuscarporEstado", Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function




    'Insert
    Public Function Agregar(ByVal Nombre As String, ByVal Login As String, ByVal Password As String, ByVal Id_Rol As Double, ByVal Id_Estado As Double) As Double


        Try

            Return oDatabase.ExecuteScalar("Usuarios_Agregar", Nombre, Login, Password, Id_Rol, Id_Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(ByVal Id_usuario As Double, ByVal Nombre As String, ByVal Login As String, ByVal Pass As String, ByVal Id_rol As Double, ByVal ID_Estado As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_Modificar", Id_usuario, Nombre, Login, Pass, Id_rol, ID_Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function Eliminar(ByVal Id_usuario As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Usuarios_Eliminar", Id_usuario)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Function BuscarPorId_rolID_Seccion(Rol As Double, seccion As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Usuarios_buscarporRolySeccion", Rol, seccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function BuscarPorID_Seccion(ByVal seccion As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Usuarios_BuscarPorID_Seccion", seccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function BuscarTodosporAdministrador(user_id As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Usuarios_BuscarTodosporAdministrador", user_id)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function BuscarBuscarOperadoresparaAdministrador(id_rol As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Usuarios_BuscarOperadoresparaAdministrador", id_rol)
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class

