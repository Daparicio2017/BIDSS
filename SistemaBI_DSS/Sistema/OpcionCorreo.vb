Public Class OpcionCorreo
    Public usuario As String = "sistemabidss@gmail.com"
    Public contraseña As String = "Bidds2017"
    Public asunto As String = "Clave Recuperada"
    Public contenido As String = "Estimado Usuario su Contraseña es:"
    Public para As String
    Dim prueba As String
    Dim ruta As String = ""
    Dim enviar As New ClaseCorreo
    Dim correo As String
    Dim password As String
    Dim username As String
    'Dim envio As New cambiarcontra
    Dim id_usuario As Integer



    Private Sub OpcionCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'username = (session("user"))
        'txt_usuario, Attribute.add(Value(txt_usuario.Text))
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged
        enviar.consultar_correo_username(txt_usuario.Text)
    End Sub

    Private Sub btn_enviar_correo_Click(sender As Object, e As EventArgs) Handles btn_enviar_correo.Click
        MsgBox("Espere PorFavor", MsgBoxStyle.Information, "Login")
        Dim confirmar As Integer
        Dim nusuario As String
        nusuario = (txt_usuario.Text)
        If txt_usuario.Text = "" Then
            MsgBox("Debe ingresar su Nombre de Usuario", MsgBoxStyle.OkOnly, "OpcionCorreo")
            Exit Sub
        Else
            '      correo = enviar.EMAIL
            confirmar = MsgBox("Enviaremos Su Contraseña a la siguiente direccion;" + correo, MsgBoxStyle.YesNo, "OpcionCorreo")
            If confirmar = vbYes Then
                '         password = enviar.generar_contraseña
                prueba = contenido & "  " & password

                '        If enviar.socket(usuario, contraseña, prueba, contenido, correo) = True Then
                '       envio.actualizar_contraseña(id_usuario, password)
                '      session.add("user", nusuario)
                CambiarContraseña.show

                Else
                    Exit Sub


                End If
            ' Else
            confirmar = vbNo
                Login.Show()
            End If
        'End If
    End Sub
End Class