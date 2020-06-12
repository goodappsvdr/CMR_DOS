
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class MenuRoles
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub

    ''buscar por id
    Function BuscarPorID(Id_menuRol As Double) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("MenuRoles_BuscarPorID", Id_menuRol)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function



    ''buscar todos
    Function BuscarTodos() As DataSet
        Try

            Return oDatabase.ExecuteDataSet("MenuRoles_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function



    ''modificar
    Function Modificar(id_menurol As Double, id_menu As Double, id_rol As Double, acceso As Boolean, id_estado As Double) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("MenuRoles_Modificar", id_menurol, id_menu, id_rol, acceso, id_estado)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    ''AGREGAR
    Function Agregar(id_menu As Double, id_rol As Double, acceso As Boolean, id_estado As Double) As Double
        Try

            Return oDatabase.ExecuteScalar("MenuRoles_Agregar", id_menu, id_rol, acceso, id_estado)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
