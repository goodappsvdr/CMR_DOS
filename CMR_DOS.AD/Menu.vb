
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO


Public Class Menu

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub



    'BuscarPorID
    Public Function BuscarPorID(ByVal Id_menu As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarPorID", Id_menu)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function CargarWeb(ByVal Id_Usuario As Integer, ByVal UID As String, ByVal Emp As String, ByVal URID As String, ByVal UAD As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_CargarWeb", Id_Usuario, UID, Emp, URID, UAD)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function CargarCabecera(ByVal Id_Usuario As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_CargarCabecera", Id_Usuario)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function BuscarTodosPadre() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarTodosPadre")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function BuscarTodosHijos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarTodosHijos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarFormularios() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarFormularios")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function CargarCabecera() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_CargarCabecera")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    '*********************BUSQUEDA POR LOS DIFERENTES CAMPOS DE LA TABLA****************

    Public Function BuscarPorNombre(ByVal Nombre As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarporNombre", Nombre)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function BuscarPorId_padre(ByVal Id_padre As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarporId_padre", Id_padre)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    Public Function BuscarPorId_padre(ByVal Id_padre As Double, ByVal ID_Usuario As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarporId_padre", Id_padre, ID_Usuario)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BuscarPorId_padreFRM(ByVal Id_padre As Double, ByVal ID_Usuario As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarporId_padreFRM", Id_padre, ID_Usuario)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function BuscarPorId_modulo(ByVal Id_modulo As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarporId_modulo", Id_modulo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Public Function BuscarPorEstado(ByVal Estado As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_BuscarporEstado", Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function




    'Insert
    Public Function Agregar(ByVal Nombre As String, ByVal Id_padre As Double, ByVal Formulario As String, ByVal Descripcion As String, ByVal ShowInMenu As Boolean, ByVal Orden As Double, ByVal Estado As Double) As Double

        Try

            Return oDatabase.ExecuteScalar("Menu_Agregar", Nombre, Id_padre, Formulario, Descripcion, ShowInMenu, Orden, 1, Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(ByVal Id_menu As Double, ByVal Nombre As String, ByVal Id_padre As Double, ByVal Formulario As String, ByVal Descripcion As String, ByVal ShowInMenu As Boolean, ByVal Orden As Double, ByVal Estado As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_Modificar", Id_menu, Nombre, Id_padre, Formulario, Descripcion, ShowInMenu, Orden, 1, Estado)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function Eliminar(ByVal Id_menu As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Menu_Eliminar", Id_menu)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

End Class

