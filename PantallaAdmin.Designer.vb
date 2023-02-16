<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaAdmin))
        Me.Cerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.FotoPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.BTNNotas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNPlay = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNPerfiles = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.Titulo = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        Me.Cerrar.Location = New System.Drawing.Point(1498, 3)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Cerrar.Size = New System.Drawing.Size(36, 34)
        Me.Cerrar.TabIndex = 8
        Me.Cerrar.Text = "X"
        '
        'FotoPerfil
        '
        Me.FotoPerfil.Image = CType(resources.GetObject("FotoPerfil.Image"), System.Drawing.Image)
        Me.FotoPerfil.ImageRotate = 0!
        Me.FotoPerfil.InitialImage = CType(resources.GetObject("FotoPerfil.InitialImage"), System.Drawing.Image)
        Me.FotoPerfil.Location = New System.Drawing.Point(23, 21)
        Me.FotoPerfil.Name = "FotoPerfil"
        Me.FotoPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FotoPerfil.Size = New System.Drawing.Size(60, 60)
        Me.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPerfil.TabIndex = 17
        Me.FotoPerfil.TabStop = False
        '
        'BTNNotas
        '
        Me.BTNNotas.BackColor = System.Drawing.Color.Transparent
        Me.BTNNotas.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNNotas.BorderRadius = 40
        Me.BTNNotas.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BTNNotas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNotas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNNotas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNNotas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNNotas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNNotas.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BTNNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNotas.ForeColor = System.Drawing.Color.White
        Me.BTNNotas.Location = New System.Drawing.Point(618, 573)
        Me.BTNNotas.Name = "BTNNotas"
        Me.BTNNotas.Size = New System.Drawing.Size(347, 80)
        Me.BTNNotas.TabIndex = 20
        Me.BTNNotas.Text = "Notas"
        '
        'BTNCreate
        '
        Me.BTNCreate.BackColor = System.Drawing.Color.Transparent
        Me.BTNCreate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNCreate.BorderRadius = 40
        Me.BTNCreate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BTNCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNCreate.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BTNCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.BTNCreate.ForeColor = System.Drawing.Color.White
        Me.BTNCreate.Location = New System.Drawing.Point(618, 476)
        Me.BTNCreate.Name = "BTNCreate"
        Me.BTNCreate.Size = New System.Drawing.Size(347, 80)
        Me.BTNCreate.TabIndex = 19
        Me.BTNCreate.Text = "Crea categoría"
        '
        'BTNPlay
        '
        Me.BTNPlay.BorderRadius = 40
        Me.BTNPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNPlay.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BTNPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPlay.ForeColor = System.Drawing.Color.White
        Me.BTNPlay.Location = New System.Drawing.Point(618, 378)
        Me.BTNPlay.Name = "BTNPlay"
        Me.BTNPlay.Size = New System.Drawing.Size(347, 80)
        Me.BTNPlay.TabIndex = 18
        Me.BTNPlay.Text = "Crear juego"
        '
        'BTNPerfiles
        '
        Me.BTNPerfiles.BackColor = System.Drawing.Color.Transparent
        Me.BTNPerfiles.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNPerfiles.BorderRadius = 40
        Me.BTNPerfiles.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BTNPerfiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPerfiles.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNPerfiles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNPerfiles.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNPerfiles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNPerfiles.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BTNPerfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPerfiles.ForeColor = System.Drawing.Color.White
        Me.BTNPerfiles.Location = New System.Drawing.Point(1333, 768)
        Me.BTNPerfiles.Name = "BTNPerfiles"
        Me.BTNPerfiles.Size = New System.Drawing.Size(191, 80)
        Me.BTNPerfiles.TabIndex = 22
        Me.BTNPerfiles.Text = "Perfiles"
        '
        'CloseBTN
        '
        Me.CloseBTN.BackColor = System.Drawing.Color.Transparent
        Me.CloseBTN.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CloseBTN.BorderRadius = 40
        Me.CloseBTN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.CloseBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CloseBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CloseBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CloseBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CloseBTN.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.CloseBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBTN.ForeColor = System.Drawing.Color.White
        Me.CloseBTN.Location = New System.Drawing.Point(23, 769)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(191, 80)
        Me.CloseBTN.TabIndex = 21
        Me.CloseBTN.Text = "Salir"
        '
        'Titulo
        '
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Font = New System.Drawing.Font("Amiko", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.Red
        Me.Titulo.Location = New System.Drawing.Point(548, 256)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(482, 82)
        Me.Titulo.TabIndex = 28
        Me.Titulo.Text = "PREGUNTADOS"
        Me.Titulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PantallaAdmin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1536, 860)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.BTNPerfiles)
        Me.Controls.Add(Me.CloseBTN)
        Me.Controls.Add(Me.BTNNotas)
        Me.Controls.Add(Me.BTNCreate)
        Me.Controls.Add(Me.BTNPlay)
        Me.Controls.Add(Me.FotoPerfil)
        Me.Controls.Add(Me.Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaAdmin"
        Me.Text = "PantallaAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents FotoPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BTNNotas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNPlay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNPerfiles As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Titulo As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
