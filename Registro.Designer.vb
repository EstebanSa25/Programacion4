<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.Cerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Telefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Correo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Reg = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FotoPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Usuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Contra = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RegistroButtom = New Guna.UI2.WinForms.Guna2Button()
        Me.ABRIR = New System.Windows.Forms.OpenFileDialog()
        CType(Me.FotoPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Cerrar.Location = New System.Drawing.Point(380, 12)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Cerrar.Size = New System.Drawing.Size(36, 34)
        Me.Cerrar.TabIndex = 8
        Me.Cerrar.Text = "X"
        '
        'Telefono
        '
        Me.Telefono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Telefono.BorderRadius = 20
        Me.Telefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Telefono.DefaultText = ""
        Me.Telefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Telefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Telefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Telefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Telefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Telefono.IconLeft = CType(resources.GetObject("Telefono.IconLeft"), System.Drawing.Image)
        Me.Telefono.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.Telefono.Location = New System.Drawing.Point(31, 374)
        Me.Telefono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Telefono.MaxLength = 50
        Me.Telefono.Name = "Telefono"
        Me.Telefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Telefono.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Telefono.PlaceholderText = "Teléfono"
        Me.Telefono.SelectedText = ""
        Me.Telefono.Size = New System.Drawing.Size(368, 45)
        Me.Telefono.TabIndex = 10
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
        Me.Correo.Location = New System.Drawing.Point(31, 265)
        Me.Correo.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Correo.MaxLength = 100
        Me.Correo.Name = "Correo"
        Me.Correo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Correo.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Correo.PlaceholderText = "Correo electrónico"
        Me.Correo.SelectedText = ""
        Me.Correo.Size = New System.Drawing.Size(368, 45)
        Me.Correo.TabIndex = 9
        '
        'Reg
        '
        Me.Reg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Reg.AvoidGeometryAntialias = True
        Me.Reg.BackColor = System.Drawing.Color.Transparent
        Me.Reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reg.Location = New System.Drawing.Point(146, 51)
        Me.Reg.Name = "Reg"
        Me.Reg.Size = New System.Drawing.Size(107, 32)
        Me.Reg.TabIndex = 11
        Me.Reg.Text = "Registro"
        '
        'FotoPerfil
        '
        Me.FotoPerfil.Image = CType(resources.GetObject("FotoPerfil.Image"), System.Drawing.Image)
        Me.FotoPerfil.ImageRotate = 0!
        Me.FotoPerfil.InitialImage = CType(resources.GetObject("FotoPerfil.InitialImage"), System.Drawing.Image)
        Me.FotoPerfil.Location = New System.Drawing.Point(146, 89)
        Me.FotoPerfil.Name = "FotoPerfil"
        Me.FotoPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FotoPerfil.Size = New System.Drawing.Size(110, 103)
        Me.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPerfil.TabIndex = 12
        Me.FotoPerfil.TabStop = False
        '
        'Usuario
        '
        Me.Usuario.BorderRadius = 20
        Me.Usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Usuario.DefaultText = ""
        Me.Usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Usuario.IconLeft = CType(resources.GetObject("Usuario.IconLeft"), System.Drawing.Image)
        Me.Usuario.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.Usuario.Location = New System.Drawing.Point(31, 209)
        Me.Usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Usuario.MaxLength = 50
        Me.Usuario.Name = "Usuario"
        Me.Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Usuario.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Usuario.PlaceholderText = "Usuario"
        Me.Usuario.SelectedText = ""
        Me.Usuario.Size = New System.Drawing.Size(368, 45)
        Me.Usuario.TabIndex = 13
        '
        'Contra
        '
        Me.Contra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Contra.BorderRadius = 20
        Me.Contra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Contra.DefaultText = ""
        Me.Contra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Contra.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Contra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Contra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Contra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Contra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contra.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Contra.IconLeft = CType(resources.GetObject("Contra.IconLeft"), System.Drawing.Image)
        Me.Contra.IconLeftSize = New System.Drawing.Size(32, 32)
        Me.Contra.Location = New System.Drawing.Point(31, 321)
        Me.Contra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Contra.MaxLength = 50
        Me.Contra.Name = "Contra"
        Me.Contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Contra.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Contra.PlaceholderText = "Contraseña"
        Me.Contra.SelectedText = ""
        Me.Contra.Size = New System.Drawing.Size(368, 45)
        Me.Contra.TabIndex = 14
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
        Me.RegistroButtom.Location = New System.Drawing.Point(31, 426)
        Me.RegistroButtom.Name = "RegistroButtom"
        Me.RegistroButtom.Size = New System.Drawing.Size(368, 45)
        Me.RegistroButtom.TabIndex = 15
        Me.RegistroButtom.Text = "Registrarse"
        '
        'ABRIR
        '
        Me.ABRIR.FileName = "OpenFileDialog1"
        '
        'Registro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(428, 512)
        Me.Controls.Add(Me.RegistroButtom)
        Me.Controls.Add(Me.Contra)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.FotoPerfil)
        Me.Controls.Add(Me.Reg)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        CType(Me.FotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Telefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Correo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Reg As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FotoPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Usuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Contra As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RegistroButtom As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ABRIR As OpenFileDialog
End Class
