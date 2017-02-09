Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.SqlClient



Public Class Clase_Conexion

    Public conexion As New SqlClient.SqlConnection

    Public Function conectado() As Boolean
        Dim strConexion As String = ("server=ArielAlvarenga/SQLEXPRESSS;Integrated Security=true;database=SISTEMABIDSSV1")
        Try
            conexion = New SqlClient.SqlConnection(strConexion)
            conexion.Open()
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function

End Class
