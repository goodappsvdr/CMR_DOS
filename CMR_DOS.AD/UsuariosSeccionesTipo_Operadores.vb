Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

'*************************************************************************************************
'Clase Generada por IDEAS SA
'*************************************************************************************************

Public Class UsuariosSeccionesTipo_Operadores

Dim oDatabase As Database

Public Sub New()

oDatabase = DatabaseFactory.CreateDatabase("Conn")

End Sub

Public Sub New(ByVal str As String)
End Sub

Public Function BuscarPorID(ByVal ID_UsuarioSeccionTipo As Integer) As DataSet
Try
Return oDatabase.ExecuteDataSet("UsuariosSeccionesTipo_Operadores_BuscarPorID",ID_UsuarioSeccionTipo)
Catch ex As System.Exception
Throw ex
End Try
End Function


Public Function BuscarTodos() As DataSet
Try
 Return oDatabase.ExecuteDataSet("UsuariosSeccionesTipo_Operadores_BuscarTodos")
Catch ex As System.Exception
Throw ex
End Try
End Function

Public Function Agregar(ByVal ID_SeccionTipo As Integer,ByVal ID_Usuario As Integer,ByVal ID_Estado As Integer,ByVal ID_Seccion As Integer,ByVal ID_Box As Integer,ByVal Activo As Boolean) as Double
Try
Return oDatabase.ExecuteScalar("UsuariosSeccionesTipo_Operadores_Agregar",ID_SeccionTipo,ID_Usuario,ID_Estado,ID_Seccion,ID_Box,Activo)
Catch ex As System.Exception
Throw ex
End Try
End Function

Public Function Modificar(ByVal ID_UsuarioSeccionTipo As Integer,ByVal ID_SeccionTipo As Integer,ByVal ID_Usuario As Integer,ByVal ID_Estado As Integer,ByVal ID_Seccion As Integer,ByVal ID_Box As Integer,ByVal Activo As Boolean) as Dataset
Try
Return oDatabase.ExecuteDataSet("UsuariosSeccionesTipo_Operadores_Modificar",ID_UsuarioSeccionTipo,ID_SeccionTipo,ID_Usuario,ID_Estado,ID_Seccion,ID_Box,Activo)
Catch ex As System.Exception
Throw ex
End Try
End Function

End Class
