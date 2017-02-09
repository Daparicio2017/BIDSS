Imports System.Data



Public Class Recuperar_Contrasñ
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If rbcorreo.Checked = True Then
            OpcionCorreo.Show()
        Else
            rbcorreo.Checked = False
            If rbpreguntas.Checked = True Then

            Else
                rbpreguntas.Checked = False
            End If
        End If
    End Sub

    Private Sub rbcorreo_CheckedChanged(sender As Object, e As EventArgs) Handles rbcorreo.CheckedChanged

        If rbpreguntas.Checked = True Then
            OpcionCorreo.Show()
        Else
            rbpreguntas.Checked = False
            If rbpreguntas.Checked = True Then

            Else
                rbpreguntas.Checked = False
            End If
        End If


    End Sub
End Class
