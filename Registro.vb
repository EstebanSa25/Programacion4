Public Class Registro
    Dim NUEVO As Boolean
    Dim ID As Integer

    Public Sub Validaciones()
        If Cedula.Text <> "" And Usuario.Text <> "" And Correo.Text <> "" And Contra.Text <> "" Then
            If IsNumeric((Cedula.Text)) And IsNumeric((Telefono.Text)) Then
                RegistroButtom.Enabled = True
            End If
        Else
            RegistroButtom.Enabled = False
        End If
    End Sub
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Usuario_TextChanged(sender As Object, e As EventArgs) Handles Usuario.TextChanged
        Validaciones()
    End Sub

    Private Sub FotoPerfil_Click(sender As Object, e As EventArgs) Handles FotoPerfil.Click
        If NUEVO = True Then
            ID = PK("USUARIO", "ID")
            SQL = "INSERT INTO USUARIO (ID) VALUES(" & ID & ")"
            EJECUTAR(SQL)
            NUEVO = False
        End If
        SELECCIONAR_GUARDAR_MOSTRAR_IMAGEN_CIRCULAR(ABRIR, FotoPerfil, "PERSONA", "ID", ID, "FOTO")
        FotoPerfil.Tag = 1

    End Sub

    Private Sub RegistroButtom_Click(sender As Object, e As EventArgs) Handles RegistroButtom.Click
        ''Image.Save(MS1, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
        ' SQL = "UPDATE " & TABLA & " SET " & CAMPO_IMAGEN & " = (@IMAGEN) WHERE " & CAMPO_ID & " = " & ID
        SQL = "INSERT INTO USUARIO VALUES(" & Cedula.Text & ",'" & Usuario.Text & "','" & Correo.Text & "','" & Contra.Text & "','','1')" 'Hay que quitar ese 1 cuando ya haya una accion de guardar rol'
        EJECUTAR(SQL)
    End Sub

    Private Sub Reg_Click(sender As Object, e As EventArgs) Handles Reg.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Cedula.TextChanged
        Validaciones()
    End Sub

    Private Sub Correo_TextChanged(sender As Object, e As EventArgs) Handles Correo.TextChanged
        Validaciones()
    End Sub

    Private Sub Contra_TextChanged(sender As Object, e As EventArgs) Handles Contra.TextChanged
        Validaciones()
    End Sub

    Private Sub Telefono_TextChanged(sender As Object, e As EventArgs) Handles Telefono.TextChanged
        Validaciones()
    End Sub
End Class