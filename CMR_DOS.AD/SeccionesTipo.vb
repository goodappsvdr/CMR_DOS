Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO

Public Class SeccionesTipo



    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub



    'Insert
    Public Function Agregar(id_seccion As Double, ByVal Nombre As String, ByVal codigo As String, ByVal Id_Estado As Double) As Double


        Try

            Return oDatabase.ExecuteScalar("SeccionesTipo_Agregar", id_seccion, Nombre, codigo, Id_Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(id_secciontipo As Double, ByVal Id_seccion As Double, ByVal Nombre As String, codigo As String, ByVal ID_Estado As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("seccionesTipo_Modificar", id_secciontipo, Id_seccion, Nombre, codigo, ID_Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'buscar por id
    Public Function BuscarPorID(ByVal ID As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("SeccionesTipo_BuscarPorID", ID)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    'buscar por seccion
    Public Function BuscarPorSeccion(ByVal ID As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("SeccionesTipo_BuscarPorIDSeccion", ID)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '[SeccionesTipo_BuscarPorNombreSeccion]
    Public Function SeccionesTipo_BuscarPorNombreSeccion(ByVal nombre As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("SeccionesTipo_BuscarPorNombreSeccion", nombre)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    ''buscar por codigo
    Public Function BuscarPorcodigo(ByVal codigo As String, seccion As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("SeccionesTipo_BuscarPorCodigo", codigo, seccion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    ''buscar por codigo
    Public Function SeccionesTipo_ValidarNombre(ByVal Nombre As String, seccion As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("SeccionesTipo_ValidarNombre", Nombre, seccion)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("SeccionesTipo_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function ConsultaParaAgregarTurno(ID_Seccion) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionesTipo_ConsultaParaAgregarTurno", ID_Seccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function BuscarPorIDOperadorySeccion(id_operador As Integer, id_Seccion As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionesTipo_BuscarPorIDOperadorySeccion", id_operador, id_Seccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Buscar subsecciones por usuario 
    Public Function SeccionesTipo_BuscarPorUsuario(ByVal IdUsuario As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionesTipo_BuscarPorUsuario", IdUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Buscar Subseccion por id subseccionUsuario
    Public Function SeccionesTipo_BuscarPorIdG(ByVal Id As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionesTipo_BuscarPorIdG", Id)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'buscar subsecciones por seccion
    Public Function SeccionesTipo_BucarPorSeccion(ByVal Id As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionesTipo_BucarPorSeccion", Id)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'buscar estados subseccion
    Public Function SeccionesTipo_BuscarPorCategoria() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SeccionesTipo_BuscarPorCategoria")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UsuarioSeccionTipo_Verificar( ByVal IdSeccionTipo As Integer,
                                                 ByVal IdUsuario As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuarioSeccionTipo_Verificar", IdSeccionTipo, IdUsuario)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function SeccionTipo_Verificar(ByVal IdUsuario As Integer, ByVal IdSeccionTipo As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("SeccionTipo_Verificar", IdUsuario, IdSeccionTipo)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
