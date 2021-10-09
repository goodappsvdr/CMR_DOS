Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

'*************************************************************************************************
'Clase Generada por IDEAS SA
'*************************************************************************************************

Public Class UsuariosLogin

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorID(ByVal ID_UsuarioLogin As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_BuscarPorID", ID_UsuarioLogin)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorIDFecha(ByVal ID_Usuario As Integer, ByVal Fecha As DateTime) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_BuscarID_Fecha", ID_Usuario, Fecha)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_UsuarioLogin(ByVal ID_UsuarioLogin As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_BuscarPorID_UsuarioLogin", ID_UsuarioLogin)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_Usuario(ByVal ID_Usuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_BuscarPorID_Usuario", ID_Usuario)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID_UsuarioUltimoLogin(ByVal ID_Usuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_BuscarPorID_Usuario_UltimoLogin", ID_Usuario)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID_Rol(ByVal ID_Rol As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_BuscarPorID_Rol", ID_Rol)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal ID_Usuario As Integer, ByVal ID_Rol As Integer, ByVal FechaInicioSesion As Date, ByVal FechaCierreSesion As Date, ByVal Estado As Integer, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("UsuariosLogin_Agregar", ID_Usuario, ID_Rol, FechaInicioSesion, FechaCierreSesion, Estado, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_UsuarioLogin As Integer, ByVal ID_Usuario As Integer, ByVal ID_Rol As Integer, ByVal FechaInicioSesion As Date, ByVal FechaCierreSesion As Date, ByVal Estado As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_Modificar", ID_UsuarioLogin, ID_Usuario, ID_Rol, FechaInicioSesion, FechaCierreSesion, Estado, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ByVal ID_UsuarioLogin As Integer, ByVal FechaCierreSesion As Date, ByVal Estado As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_CerrarSesion", ID_UsuarioLogin, FechaCierreSesion, Estado, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ByVal ID_UsuarioLogin As Integer, ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosLogin_Modificar_Estado", ID_UsuarioLogin, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
