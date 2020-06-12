Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO

Public Class Turnos


    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub


    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Turnos_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'BuscarPorID
    Public Function BuscarPorID(ByVal id_turno As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Turnos_BuscarPorID", id_turno)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarPorID
    Public Function AgregarPrimero(ByVal id_seccionTipo As Double, codigoSeccionTipo As String, id_seccion As Double, codigoSeccion As String, id_estado As Integer, id_resolucion As Integer, id_motivo As Double) As Double

        Try

            Return oDatabase.ExecuteScalar("Turnos_AgregarPrimero", id_seccionTipo, codigoSeccionTipo, id_seccion, codigoSeccion, id_estado, id_resolucion, id_motivo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    Public Function Agregar(ByVal id_seccionTipo As Double, codigoSeccionTipo As String, id_seccion As Double, codigoSeccion As String, id_estado As Integer, id_resolucion As Integer, nroturno As Integer, id_motivo As Double) As Double

        Try

            Return oDatabase.ExecuteScalar("Turnos_Agregar", id_seccionTipo, codigoSeccionTipo, id_seccion, codigoSeccion, id_estado, id_resolucion, nroturno, id_motivo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarSiguente(id_seccion As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_BuscarSiguiente", id_seccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarporSeccionyFecha(id_seccion As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_BuscarporSeccionyFecha", id_seccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarporSeccionTipoyFecha(id_secciontipo As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_BuscarporSeccionTipoyFecha", id_secciontipo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function BuscarTodosPorUsuario(id_usuario As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_Buscarporoperador", id_usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function Turnos_BuscarPorOperadoryEstado(id_usuario As Double, id_estado As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_BuscarPorOperadoryEstado", id_usuario, id_estado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function ObtenerSiguiente(id_usuario As Double, id_estado As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_ObtenerSiguiente", id_usuario, id_estado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function EstablecerPrioridad(id_turno As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_EstablecerPrioridad", id_turno)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function llamarTurno(id_turno As Double, id_estado As Double, id_usuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_LlamarTurno", id_turno, id_estado, id_usuario)
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Function Resolver(id_turno As Double, id_estado As Double, id_resolucion As Double, observaciones As String, id_motivo As Double, id_usuario As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_Resolucion", id_turno, id_estado, id_resolucion, observaciones, id_motivo, id_usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function CancelarLlamado(id_turno As Double, id_estado As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_cancelarLlamado", id_turno, id_estado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Function Turnos_Buscarultimoordenpantalla() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_Buscarultimoordenpantalla")
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Function Turnos_AgregarOrdenPantalla(ByVal ID As Integer, ByVal ORDEN As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Turnos_AgregarOrdenPantalla", ID, ORDEN)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
