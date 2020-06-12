Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO

Public Class UsuariosSecciones
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

            Return oDatabase.ExecuteDataSet("UsuariosSecciones_BuscarPorID", Id)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function BuscarPorIDUsuario(ByVal Id_operador As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosSecciones_BuscarPorIDUsuario", Id_operador)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarPorIDUsuarioyadministrador(ByVal Id_operador As Double, ByVal id_administrador As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosSecciones_BuscarPorIDUsuarioyAdministrador", Id_operador, id_administrador)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosSecciones_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'Insert
    Public Function Agregar(ByVal id_usuario As Integer, ByVal id_seccion As Integer, ByVal id_estado As Integer)


        Return oDatabase.ExecuteScalar("UsuariosSecciones_Agregar", id_usuario, id_seccion, id_estado)


    End Function



    'Update

    Public Function Modificar(ByVal id_UsuarioSeccion As Integer, ByVal id_Usuario As Double, ByVal id_seccion As Integer, ByVal ID_Estado As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosSecciones_Modificar", id_UsuarioSeccion, id_Usuario, id_seccion, ID_Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Function BuscarPorIDUsuarioySeccion(id_Usuario As Double, id_seccion As Double) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("UsuariosSecciones_BuscarPorUsuarioySeccion", id_Usuario, id_seccion)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function



    Function UsuarioSecciones_Verificar(ByVal IdUsuario As Integer, ByVal IdSeccion As Integer) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("UsuarioSecciones_Verificar", IdUsuario, IdSeccion)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
