Public Class Registro
    Dim NUEVO As Boolean
    Dim ID As Integer
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Usuario_TextChanged(sender As Object, e As EventArgs) Handles Usuario.TextChanged

    End Sub

    Private Sub FotoPerfil_Click(sender As Object, e As EventArgs) Handles FotoPerfil.Click
        If NUEVO = True Then
            ID = PK("PERSONA", "ID")
            SQL = "INSERT INTO PERSONA (ID) VALUES(" & ID & ")"
            EJECUTAR(SQL)
            NUEVO = False
        End If
        SELECCIONAR_GUARDAR_MOSTRAR_IMAGEN_CIRCULAR(ABRIR, FotoPerfil, "PERSONA", "ID", ID, "FOTO")
        FotoPerfil.Tag = 1

    End Sub
End Class