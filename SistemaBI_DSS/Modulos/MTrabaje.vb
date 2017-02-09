Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Module MTrabajo
    Public Tipoconexion As Char = CChar("")
    Public texto As Integer
    Public objusuario As New CValidar
    Public adapter As SqlClient.SqlDataAdapter
    Public sql As String
    Public encriptar_contraseña As String
    Public cdm As New SqlClient.SqlCommand
    Public m_nombre As String
    Public m_password As String
    Public m_password2 As String
    Public m_permiso As String
    Public m_mail As String
    Dim mensaje As String
    Public Fusu As New CValidar


    Public conn As New SqlClient.SqlConnection

    Public Function conectar(ByVal server As String, ByVal BIDSS As String) As Boolean

        Dim String_Conection As String = ("server=" & server & ";INITIAL catalog=" & BIDSS & ";Integrated security=true")
        Try
            conn.ConnectionString = String_Conection
            If conn.State = ConnectionState.Open Then
                conectar = True
            Else
                conn.Open()
                conectar = True
                MessageBox.Show("Conexión Exitosa")
            End If
        Catch ex As Exception
            conectar = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Conectar a la BD")

        End Try

    End Function
    Public Sub Cerrar_BD()
        If conn.State = ConnectionState.Closed Then

        Else
            conn.Close()
        End If
    End Sub
    Public Sub Abrir_BD()
        If conn.State = ConnectionState.Open Then

        Else
            conn.Open()
        End If

    End Sub

End Module