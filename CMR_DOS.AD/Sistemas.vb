Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class Sistemas
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub

    'BuscarPorID
    Public Function TraerTablas() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Sistema_TraerTablas")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function TraerColumnas(ByVal Tabla As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Sistema_TraerColumnas", Tabla)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function TraerColumna(ByVal Tabla As String, ByVal Nombre As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Sistema_TraerColumna", Tabla, Nombre)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
End Class
