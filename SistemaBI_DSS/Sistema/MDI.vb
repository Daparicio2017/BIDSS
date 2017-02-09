Public Class MDI
    Private Sub RegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosToolStripMenuItem.Click

    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        NuevoUsuario.Show()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Login.Show()
    End Sub
End Class