Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.IO

Public Class Boxes
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub


    'constructor base con parametros
    Public Sub New(ByVal str As String)
    End Sub

    'BuscarPorID
    Public Function BuscarPorID(ByVal id_box As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Boxes_BuscarporID", id_box)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    'BuscarPorIDNombre
    Public Function BuscarPorIDNombre(ByVal id_box As Double) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Boxes_BuscarporIDNombre", id_box)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'verificar
    Public Function Box_Verificar(ByVal Nombre As String, ByVal Numero As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Box_Verificar", Nombre, Numero)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function


    'BuscarTodos
    Public Function BuscarTodos() As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Boxes_BuscarTodos")

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    'Public Function BuscarporSeccionTipo(ByVal id_secciontipo As Integer) As DataSet

    '    Try

    '        Return oDatabase.ExecuteDataSet("Boxes_BuscarporSeccionTipo", id_secciontipo)

    '    Catch ex As System.Exception
    '        Throw ex
    '    End Try

    'End Function
    'Public Function BuscarporSeccion(ByVal id_seccion As Integer) As DataSet

    '    Try

    '        Return oDatabase.ExecuteDataSet("Boxes_BuscarporSeccion", id_seccion)

    '    Catch ex As System.Exception
    '        Throw ex
    '    End Try

    'End Function

    '*********************BUSQUEDA POR LOS DIFERENTES CAMPOS DE LA TABLA****************


    'Insert
    Public Function Agregar(ByVal Tran As SqlTransaction, ByVal codigo As String, ByVal nro As Integer, activo As Boolean) As Double

        Try

            Return oDatabase.ExecuteScalar(Tran, "Boxes_Agregar", codigo, nro, activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    'Update

    Public Function Modificar(id_box As Integer, ByVal codigo As String, ByVal nro As Integer, activo As Boolean) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Boxes_Modificar", id_box, codigo, nro, activo)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



    Function buscarporIDAdministador(UserID As Double) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Boxes_buscarporIDAdministador", UserID)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function BoxUsuarioVerificar(ByVal id_box As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BoxUsuarioVerificar", id_box)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function BoxModificarEstado(ByVal iduser As Integer, ByVal id_box As Integer, ByVal valor As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("BoxModificarEstado", iduser, id_box, valor)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function
    Public Function Box_VerificarEstado(ByVal id_box As Integer) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("Box_VerificarEstado", id_box)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function



End Class
