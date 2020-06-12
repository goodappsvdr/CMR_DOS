Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO
Public Class UsuariosSeccionesTipo
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub

    

    'BuscarPorID
    Public Function BuscarPorID(ByVal Id As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosSeccionesTipo_BuscarPorID", Id)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function BuscarPorIDUsuario(ByVal Id As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosSeccionesTipo_BuscarPorIDUSUARIO", Id)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosSeccionesTipo_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'Insert
    Public Function Agregar(id_secciontipo As Integer, ByVal id_usuario As Integer, ByVal id_estado As Integer, ByVal id_seccion As Integer) As Double


        Try

            Return oDatabase.ExecuteScalar("UsuariosSeccionesTipo_Agregar", id_secciontipo, id_usuario, id_estado, id_seccion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(ByVal id_UsuarioSeccionTipo As Double, ByVal id_secciontipo As Double, ByVal id_usuario As Double, ByVal ID_Estado As Double, ByVal id_seccion As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosSeccionesTipo_Modificar", id_UsuarioSeccionTipo, id_secciontipo, id_usuario, ID_Estado, id_seccion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarTodosporSeccionesDeAdmin(userid As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("UsuariosSeccionesTipo_BuscarTodosPorSeccionesDelAdmin", userid)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
   



End Class
