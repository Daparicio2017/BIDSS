Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Windows.Forms
Imports System.Configuration

Public Class Login

    Dim intentos As Integer = 1
    Dim comando As SqlClient.SqlCommand


    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Try
            With objusuario
                .nombre = Textname.Text
                .password = Textpassw.Text
            End With



            If (intentos > 3) Then

                cdm = New SqlClient.SqlCommand("UPDATE Usuario set Estado ='" & 0 & "'where Usuario ='" & Textname.Text & "'", MTrabajo.conn)
                cdm.ExecuteNonQuery()
                MsgBox("Usuario Bloqueado, Comuniquese con el Administrador!", MsgBoxStyle.Information, "BIDSS")
                Me.Close()


            End If

            intentos = intentos + 1
            encriptar_contraseña = CPassword.Encriptar(Textpassw.Text)

            sql = ("SELECT Usuario  FROM TBL_Usuario WHERE Usuario='" & Me.Textname.Text & "' and Contraseña='" & Me.Textpassw.Text & "'")
            adapter = New SqlClient.SqlDataAdapter(sql, MTrabajo.conn)
            Dim table As New DataTable
            table.Clear()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture

            If adapter.Fill(table) Then

                'CONTRASEÑA CORRECTA

                MsgBox("Usuario Aceptado")
                MsgBox("Bienvenido al Sistema: " & Textname.Text)
                MDI.Show()
                Call limpiar()
                Textname.Focus()
                Me.Hide()
                Me.Focus()



                'CONTRASEÑA INCORRECTA

            Else
                MsgBox("Usuario/Contraseña Incorrectos, Por Favor Vuelva a Intentarlo")
                Textname.Focus()
                Textname.Clear()
                Textpassw.Clear()
                'Me.lbintentos.Text = "Solo le Quedan " & 1 - intentos & " Intentos"

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        CValidar.valdidarmayusculas(Me.Textname.Text)
    End Sub
    Sub limpiar()
        Textname.Text = ""
        Textpassw.Text = ""
    End Sub
    Private Sub Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MTrabajo.conectar("DEGA-HP", "BIDSS")
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        NuevoUsuario.Show()
    End Sub

    'Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
    '    If MsgBox("¿Desea terminar la aplicación?", vbQuestion + vbYesNo, "¿Salir?") = vbYes Then
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Recuperar_Contrasñ.Show()
    End Sub

End Class