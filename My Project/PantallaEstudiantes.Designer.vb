<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaEstudiantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaEstudiantes))
        Me.Cerrar = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTNPoints = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNContinue = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNJoin = New Guna.UI2.WinForms.Guna2Button()
        Me.Configuracion = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseBTN = New Guna.UI2.WinForms.Guna2Button()
        Me.FotoPerfil = New Guna.UI2.WinForms.Guna2CirclePictureBox()
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
        Me.Cerrar.Location = New System.Drawing.Point(1501, 2)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Cerrar.Size = New System.Drawing.Size(36, 34)
        Me.Cerrar.TabIndex = 9
        Me.Cerrar.Text = "X"
        '
        'BTNPoints
        '
        Me.BTNPoints.BackColor = System.Drawing.Color.Transparent
        Me.BTNPoints.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNPoints.BorderRadius = 40
        Me.BTNPoints.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BTNPoints.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPoints.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNPoints.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNPoints.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNPoints.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNPoints.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BTNPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.BTNPoints.ForeColor = System.Drawing.Color.White
        Me.BTNPoints.Location = New System.Drawing.Point(596, 557)
        Me.BTNPoints.Name = "BTNPoints"
        Me.BTNPoints.Size = New System.Drawing.Size(347, 80)
        Me.BTNPoints.TabIndex = 23
        Me.BTNPoints.Text = "Puntuación"
        '
        'BTNContinue
        '
        Me.BTNContinue.BackColor = System.Drawing.Color.Transparent
        Me.BTNContinue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNContinue.BorderRadius = 40
        Me.BTNContinue.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BTNContinue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNContinue.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNContinue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNContinue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNContinue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNContinue.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BTNContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!)
        Me.BTNContinue.ForeColor = System.Drawing.Color.White
        Me.BTNContinue.Location = New System.Drawing.Point(596, 460)
        Me.BTNContinue.Name = "BTNContinue"
        Me.BTNContinue.Size = New System.Drawing.Size(347, 80)
        Me.BTNContinue.TabIndex = 22
        Me.BTNContinue.Text = "Continuar partida"
        '
        'BTNJoin
        '
        Me.BTNJoin.BorderRadius = 40
        Me.BTNJoin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNJoin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNJoin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNJoin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNJoin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNJoin.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BTNJoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNJoin.ForeColor = System.Drawing.Color.White
        Me.BTNJoin.Location = New System.Drawing.Point(596, 363)
        Me.BTNJoin.Name = "BTNJoin"
        Me.BTNJoin.Size = New System.Drawing.Size(347, 80)
        Me.BTNJoin.TabIndex = 21
        Me.BTNJoin.Text = "Jugar"
        '
        'Configuracion
        '
        Me.Configuracion.BackColor = System.Drawing.Color.Transparent
        Me.Configuracion.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Configuracion.BorderRadius = 40
        Me.Configuracion.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Configuracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Configuracion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Configuracion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Configuracion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Configuracion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Configuracion.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Configuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion.ForeColor = System.Drawing.Color.White
        Me.Configuracion.Location = New System.Drawing.Point(1315, 738)
        Me.Configuracion.Name = "Configuracion"
        Me.Configuracion.Size = New System.Drawing.Size(191, 80)
        Me.Configuracion.TabIndex = 25
        Me.Configuracion.Text = "Configuración"
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
        Me.CloseBTN.Location = New System.Drawing.Point(15, 738)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(191, 80)
        Me.CloseBTN.TabIndex = 24
        Me.CloseBTN.Text = "Salir"
        '
        'FotoPerfil
        '
        Me.FotoPerfil.Image = CType(resources.GetObject("FotoPerfil.Image"), System.Drawing.Image)
        Me.FotoPerfil.ImageRotate = 0!
        Me.FotoPerfil.InitialImage = CType(resources.GetObject("FotoPerfil.InitialImage"), System.Drawing.Image)
        Me.FotoPerfil.Location = New System.Drawing.Point(15, 12)
        Me.FotoPerfil.Name = "FotoPerfil"
        Me.FotoPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.FotoPerfil.Size = New System.Drawing.Size(60, 60)
        Me.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPerfil.TabIndex = 26
        Me.FotoPerfil.TabStop = False
        '
        'Titulo
        '
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Font = New System.Drawing.Font("Amiko", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.Red
        Me.Titulo.Location = New System.Drawing.Point(543, 275)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(482, 82)
        Me.Titulo.TabIndex = 27
        Me.Titulo.Text = "PREGUNTADOS"
        Me.Titulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PantallaEstudiantes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1539, 830)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.FotoPerfil)
        Me.Controls.Add(Me.Configuracion)
        Me.Controls.Add(Me.CloseBTN)
        Me.Controls.Add(Me.BTNPoints)
        Me.Controls.Add(Me.BTNContinue)
        Me.Controls.Add(Me.BTNJoin)
        Me.Controls.Add(Me.Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaEstudiantes"
        Me.Text = "PantallaEstudiantes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FotoPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cerrar As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTNPoints As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNContinue As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNJoin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Configuracion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseBTN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FotoPerfil As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Titulo As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
