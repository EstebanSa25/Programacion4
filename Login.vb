Public Class PantallaLogin
    Friend Sub VALIDACION_CAMPOS()
        If txt_Correo.Text <> "" And txt_Contraseña.Text <> "" Then
            btn_Ingresar.Enabled = True
        Else
            btn_Ingresar.Enabled = False
        End If
    End Sub
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        End
    End Sub

    Private Sub RegistroButtom_Click(sender As Object, e As EventArgs) Handles RegistroButtom.Click
        Registro.Show()
    End Sub

    Private Sub Correo_TextChanged(sender As Object, e As EventArgs) Handles txt_Correo.TextChanged
        VALIDACION_CAMPOS()
    End Sub

    Private Sub IngresarButtom_Click(sender As Object, e As EventArgs) Handles btn_Ingresar.Click
        VALIDACION_CAMPOS()
        SQL = "declare @retorno bit;exec @retorno=PR_VALIDAR_LOGIN'" & txt_Correo.Text & "','" & txt_Contraseña.Text & "'select 'LOGIN'=@retorno;"
        Dim login As Boolean = RETORNAR(SQL)
        If login.Equals(True) Then
            MsgBox("Se ingreso al sistema")
        Else
            MsgBox("Contraseña o correo electronico incorrecto")
        End If
    End Sub

    Private Sub txt_Contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_Contraseña.TextChanged
    End Sub
End Class
