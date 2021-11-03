Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

'*************************************************************************************************
'Clase Generada por IDEAS SA
'*************************************************************************************************

Public Class UsuariosTurnos

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorID(ByVal ID_UsuarioTurno As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_BuscarPorID", ID_UsuarioTurno)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_UsuarioTurno(ByVal ID_UsuarioTurno As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_BuscarPorID_UsuarioTurno", ID_UsuarioTurno)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_UsuarioLogin(ByVal ID_UsuarioLogin As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_BuscarPorID_UsuarioLogin", ID_UsuarioLogin)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_UsuarioLoginEstado(ByVal ID_UsuarioLogin As Integer, ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_BuscarAsignados", ID_UsuarioLogin, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID_Usuario(ByVal ID_Usuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_BuscarPorID_Usuario", ID_Usuario)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID_Turno(ByVal ID_Turno As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_BuscarPorID_Turno", ID_Turno)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal ID_AuditoriaUsuario As Integer, ByVal ID_Usuario As Integer, ByVal ID_Turno As Integer, ByVal Fecha As Date, ByVal Estado As Integer) As Double
        Try
            Return oDatabase.ExecuteScalar("UsuariosTurnos_Agregar", ID_AuditoriaUsuario, ID_Usuario, ID_Turno, Fecha, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_UsuarioTurno As Integer, ByVal ID_UsuarioLogin As Integer, ByVal ID_Turno As Integer, ByVal UltimoTurno As Date, ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_Modificar", ID_UsuarioTurno, ID_UsuarioLogin, ID_Turno, UltimoTurno, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ByVal ID_UsuarioLogin As Integer, ByVal ID_Turno As Integer, ByVal UltimoTurno As Date, ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_Modificar_UltimoTurno", ID_UsuarioLogin, ID_Turno, UltimoTurno, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_Turno As Integer, ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosTurnos_Modificar_Estado", ID_Turno, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
