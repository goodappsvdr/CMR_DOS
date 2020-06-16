Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO

Public Class Secciones

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub



    'Insert
    Public Function Agregar(ByVal Nombre As String, ByVal codigo As String, ByVal Id_Estado As Double) As Double


        Try

            Return oDatabase.ExecuteScalar("Secciones_Agregar", Nombre, codigo, Id_Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(ByVal Id_seccion As Double, ByVal Nombre As String, codigo As String, ByVal ID_Estado As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("secciones_Modificar", Id_seccion, Nombre, codigo, ID_Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'buscar todos
    Public Function BuscarPorID(ByVal ID As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Secciones_BuscarPorID", ID)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function





    'buscar todos
    Public Function SeccionesPorUsuario(ByVal ID As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosSecciones_BuscarPorID_Usuario", ID)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'validar descripcion seccion
    Public Function Seccion_ValidarDesc(ByVal Desc As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Seccion_ValidarDesc", Desc)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    ''buscar por codigo
    Public Function BuscarPorcodigo(ByVal codigo As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Secciones_BuscarPorCodigo", codigo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    Public Function Secciones_BuscarPornOMBRE(ByVal codigo As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Secciones_BuscarPornOMBRE", codigo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Secciones_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarTodos
    Public Function BuscarTodosporEstado() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Secciones_BuscarTodosporEstado")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '  [Secciones_BuscarTodosporEstadoyUsuario]
    'BuscarTodos
    Public Function Secciones_BuscarTodosporEstadoyUsuario(id_usuario As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Secciones_BuscarTodosporEstadoyUsuario", id_usuario)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Function BuscarporIDOperador(id_operador As Object) As DataSet
        Try

            Return oDatabase.ExecuteDataSet("Secciones_BuscarPorIDOperador", id_operador)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Function BuscarporIDAdministrador(id_administrador As Object) As DataSet
        ''Secciones_BuscarPorIDAdministrador
        Try

            Return oDatabase.ExecuteDataSet("Secciones_BuscarPorIDAdministrador", id_administrador)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Function BuscarporIDOperadoryAdministrador(id_operador As Object, id_administrador As Object) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionesBuscarporOperadoryAdministrador", id_operador, id_administrador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
