Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO

Public Class Periodos
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub


    Function Agregar(nombre As String, fechadesde As Date, fechahasta As Date) As Double
        Try
            Return oDatabase.ExecuteScalar("Periodos_Agregar", nombre, fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Periodos_buscarTodos")
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function BuscarPorID(id_periodo As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Periodos_buscarPorID", id_periodo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function Modificar(id_periodo As Integer, nombre As String, fechadesde As Date, fechahasta As Date) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Periodos_Modificar", id_periodo, nombre, fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
