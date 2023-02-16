Public Class PantallaLogin
    Friend Sub VALIDACION_CAMPOS()
        If txt_Correo.Text <> "" And txt_Contraseña.Text <> "" Then
            btn_Ingresar.Enabled = True
        Else
            btn_Ingresar.Enabled = False
        End If
    End Sub
    Function Validar_Correo(Correo As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(Correo, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function
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
        If (Validar_Correo(txt_Correo.Text).Equals(True)) Then
            SQL = "declare @retorno bit;exec @retorno=PR_VALIDAR_LOGIN'" & txt_Correo.Text & "','" & txt_Contraseña.Text & "'select 'LOGIN'=@retorno;"
            Dim login As Boolean = RETORNAR(SQL)
            If login.Equals(True) Then
                PantallaAdmin.Show()
                MsgBox("Se ingreso al sistema")
            Else

                txt_error_login.Text = "Error,verifique los datos"
                txt_error_login.Location = New Point(82, 136)
                txt_error_login.Visible = True
            End If

        Else
            txt_error_login.Text = "Digite un correo valido"
            txt_error_login.Location = New Point(105, 138)
            txt_error_login.Visible = True
            'MsgBox("Correo invalido")
        End If
    End Sub

    Private Sub txt_Contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_Contraseña.TextChanged
        VALIDACION_CAMPOS()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles ProfsPruebas.Click
        PantallaAdmin.Show()
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        PantallaEstudiantes.Show()
    End Sub
End Class
