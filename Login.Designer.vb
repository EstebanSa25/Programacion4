<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaLogin))
        Me.Login = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_Correo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_Contraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_Ingresar = New Guna.UI2.WinForms.Guna2Button()
        Me.Cerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.RegistroButtom = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_error_login = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Login.AvoidGeometryAntialias = True
        Me.Login.BackColor = System.Drawing.Color.Transparent
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(137, 197)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(212, 40)
        Me.Login.TabIndex = 1
        Me.Login.Text = "Iniciar Sesion"
        '
        'txt_Correo
        '
        Me.txt_Correo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_Correo.BorderRadius = 20
        Me.txt_Correo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Correo.DefaultText = ""
        Me.txt_Correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Correo.IconLeft = CType(resources.GetObject("txt_Correo.IconLeft"), System.Drawing.Image)
        Me.txt_Correo.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.txt_Correo.Location = New System.Drawing.Point(40, 263)
        Me.txt_Correo.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txt_Correo.MaxLength = 100
        Me.txt_Correo.Name = "txt_Correo"
        Me.txt_Correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Correo.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txt_Correo.PlaceholderText = "Correo electrónico"
        Me.txt_Correo.SelectedText = ""
        Me.txt_Correo.Size = New System.Drawing.Size(368, 45)
        Me.txt_Correo.TabIndex = 2
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_Contraseña.BorderRadius = 20
        Me.txt_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Contraseña.DefaultText = ""
        Me.txt_Contraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Contraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Contraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Contraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Contraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Contraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Contraseña.IconLeft = CType(resources.GetObject("txt_Contraseña.IconLeft"), System.Drawing.Image)
        Me.txt_Contraseña.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.txt_Contraseña.Location = New System.Drawing.Point(40, 319)
        Me.txt_Contraseña.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_Contraseña.MaxLength = 50
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Contraseña.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txt_Contraseña.PlaceholderText = "Contraseña"
        Me.txt_Contraseña.SelectedText = ""
        Me.txt_Contraseña.Size = New System.Drawing.Size(368, 45)
        Me.txt_Contraseña.TabIndex = 3
        '
        'btn_Ingresar
        '
        Me.btn_Ingresar.BorderRadius = 20
        Me.btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Ingresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Ingresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Ingresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Ingresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Ingresar.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btn_Ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ingresar.ForeColor = System.Drawing.Color.White
        Me.btn_Ingresar.Location = New System.Drawing.Point(40, 381)
        Me.btn_Ingresar.Name = "btn_Ingresar"
        Me.btn_Ingresar.Size = New System.Drawing.Size(368, 45)
        Me.btn_Ingresar.TabIndex = 5
        Me.btn_Ingresar.Text = "Ingresar"
        '
        'Cerrar
        '
        Me.Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Cerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Cerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Cerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Cerrar.FillColor = System.Drawing.Color.IndianRed
        Me.Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cerrar.ForeColor = System.Drawing.Color.White
        Me.Cerrar.Location = New System.Drawing.Point(398, 12)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Cerrar.Size = New System.Drawing.Size(36, 34)
        Me.Cerrar.TabIndex = 7
        Me.Cerrar.Text = "X"
        '
        'RegistroButtom
        '
        Me.RegistroButtom.BorderRadius = 20
        Me.RegistroButtom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegistroButtom.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RegistroButtom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RegistroButtom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RegistroButtom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RegistroButtom.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.RegistroButtom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistroButtom.ForeColor = System.Drawing.Color.White
        Me.RegistroButtom.Location = New System.Drawing.Point(40, 441)
        Me.RegistroButtom.Name = "RegistroButtom"
        Me.RegistroButtom.Size = New System.Drawing.Size(368, 45)
        Me.RegistroButtom.TabIndex = 8
        Me.RegistroButtom.Text = "Registrarse"
        '
        'txt_error_login
        '
        Me.txt_error_login.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_error_login.AvoidGeometryAntialias = True
        Me.txt_error_login.BackColor = System.Drawing.Color.Transparent
        Me.txt_error_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_error_login.Location = New System.Drawing.Point(82, 136)
        Me.txt_error_login.Name = "txt_error_login"
        Me.txt_error_login.Size = New System.Drawing.Size(140, 41)
        Me.txt_error_login.TabIndex = 10
        Me.txt_error_login.Text = "Txt_error"
        Me.txt_error_login.Visible = False
        '
        'PantallaLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(446, 559)
        Me.Controls.Add(Me.txt_error_login)
        Me.Controls.Add(Me.RegistroButtom)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.btn_Ingresar)
        Me.Controls.Add(Me.txt_Contraseña)
        Me.Controls.Add(Me.txt_Correo)
        Me.Controls.Add(Me.Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_Correo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Contraseña As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_Ingresar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Cerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents RegistroButtom As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_error_login As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
