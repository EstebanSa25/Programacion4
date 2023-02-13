<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaLogin))
        Me.Login = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Correo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Contraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.IngresarButtom = New Guna.UI2.WinForms.Guna2Button()
        Me.Cerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.RegistroButtom = New Guna.UI2.WinForms.Guna2Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Login.Size = New System.Drawing.Size(170, 32)
        Me.Login.TabIndex = 1
        Me.Login.Text = "Iniciar Sesion"
        '
        'Correo
        '
        Me.Correo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Correo.BorderRadius = 20
        Me.Correo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Correo.DefaultText = ""
        Me.Correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Correo.IconLeft = CType(resources.GetObject("Correo.IconLeft"), System.Drawing.Image)
        Me.Correo.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.Correo.Location = New System.Drawing.Point(40, 263)
        Me.Correo.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Correo.MaxLength = 100
        Me.Correo.Name = "Correo"
        Me.Correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Correo.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Correo.PlaceholderText = "Correo electrónico"
        Me.Correo.SelectedText = ""
        Me.Correo.Size = New System.Drawing.Size(368, 45)
        Me.Correo.TabIndex = 2
        '
        'Contraseña
        '
        Me.Contraseña.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Contraseña.BorderRadius = 20
        Me.Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Contraseña.DefaultText = ""
        Me.Contraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Contraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Contraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Contraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Contraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Contraseña.IconLeft = CType(resources.GetObject("Contraseña.IconLeft"), System.Drawing.Image)
        Me.Contraseña.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.Contraseña.Location = New System.Drawing.Point(40, 319)
        Me.Contraseña.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Contraseña.MaxLength = 50
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Contraseña.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Contraseña.PlaceholderText = "Contraseña"
        Me.Contraseña.SelectedText = ""
        Me.Contraseña.Size = New System.Drawing.Size(368, 45)
        Me.Contraseña.TabIndex = 3
        '
        'IngresarButtom
        '
        Me.IngresarButtom.BorderRadius = 20
        Me.IngresarButtom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IngresarButtom.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.IngresarButtom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.IngresarButtom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.IngresarButtom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.IngresarButtom.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.IngresarButtom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresarButtom.ForeColor = System.Drawing.Color.White
        Me.IngresarButtom.Location = New System.Drawing.Point(40, 381)
        Me.IngresarButtom.Name = "IngresarButtom"
        Me.IngresarButtom.Size = New System.Drawing.Size(368, 45)
        Me.IngresarButtom.TabIndex = 5
        Me.IngresarButtom.Text = "Ingresar"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PantallaLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(446, 559)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RegistroButtom)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.IngresarButtom)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Correo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Contraseña As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents IngresarButtom As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Cerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents RegistroButtom As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button1 As Button
End Class
