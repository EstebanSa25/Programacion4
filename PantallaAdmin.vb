Public Class PantallaAdmin
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub

    Private Sub BTNPerfiles_Click(sender As Object, e As EventArgs) Handles BTNPerfiles.Click
        PantallaPerfiles.Show()
        Me.Close()
    End Sub
End Class