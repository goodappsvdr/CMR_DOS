Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

'*************************************************************************************************
'Clase Generada por IDEAS SA
'*************************************************************************************************

Public Class AuditoriasUsuarios

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorID(ByVal ID_AuditoriaUsuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_BuscarPorID", ID_AuditoriaUsuario)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_AuditoriaUsuario(ByVal ID_AuditoriaUsuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_BuscarPorID_AuditoriaUsuario", ID_AuditoriaUsuario)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_UsuarioActivo(ByVal ID_Usuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_BuscarPorID_Usuario_Activo", ID_Usuario)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID_Usuario(ByVal ID_Usuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_BuscarPorID_Usuario", ID_Usuario)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Desactivar(ByVal ID_Usuario As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_Desactivar", ID_Usuario, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorEstado(ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_BuscarPorEstado", Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarEstado(ByVal ID_Usuario As Integer, ByVal Estado As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_ModificarEstado", ID_Usuario, Estado, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar(ByVal ID_Usuario As Integer, ByVal FechaInicioSesion As Date, ByVal FechaCierreSesion As Date, ByVal TiempoOcupado As String, ByVal TiempoLibre As String, ByVal TurnosAtendidos As Integer, ByVal PrimerTurno As Date, ByVal UltimoTurno As Date, ByVal Estado As Integer) As Double
        Try
            Return oDatabase.ExecuteScalar("AuditoriasUsuarios_Agregar", ID_Usuario, FechaInicioSesion, FechaCierreSesion, TiempoOcupado, TiempoLibre, TurnosAtendidos, PrimerTurno, UltimoTurno, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function IniciarSesion(ByVal ID_Usuario As Integer, ByVal FechaInicioSesion As Date, ByVal TurnosAtendidos As Integer, ByVal Estado As Integer, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("AuditoriasUsuarios_IniciarSesion", ID_Usuario, FechaInicioSesion, TurnosAtendidos, Estado, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function CerrarSesion(ByVal ID_Usuario As Integer, ByVal Estado As Integer, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("AuditoriasUsuarios_CerrarSesion", ID_Usuario, Estado, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ByVal ID_AuditoriaUsuario As Integer, ByVal ID_Usuario As Integer, ByVal FechaInicioSesion As Date, ByVal FechaCierreSesion As Date, ByVal TiempoOcupado As String, ByVal TiempoLibre As String, ByVal TurnosAtendidos As Integer, ByVal PrimerTurno As Date, ByVal UltimoTurno As Date, ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_Modificar", ID_AuditoriaUsuario, ID_Usuario, FechaInicioSesion, FechaCierreSesion, TiempoOcupado, TiempoLibre, TurnosAtendidos, PrimerTurno, UltimoTurno, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Modificar(ByVal ID_Usuario As Integer, ByVal Estado As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_ModificarEstado", ID_Usuario, Estado, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarPrimerTurno(ByVal ID_Usuario As Integer, ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_PrimerTurno", ID_Usuario, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarUltimoTurno(ByVal ID_Usuario As Integer, ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_UltimoTurno", ID_Usuario, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function ModificarTiempoLibre(ByVal ID_Usuario As Integer, ByVal Estado As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_ModificarTiempoLibre", ID_Usuario, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Function BuscarOperadorLibre() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("AuditoriasUsuarios_BuscarOperadorLibre")
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
