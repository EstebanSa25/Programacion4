Imports System.Data.OleDb
Imports System.Data.SqlClient

Module BIBLIOTECA_IMAGEN
    Public DIRECCION_IMAGEN_VENTANA_DIALOGO As String = ""
    Public SERVIDOR As String = "DR-SALAS\DRSALAS" 'NOMBRE DEL SERVIDOR
    Public BD As String = "CLASESQ12023" 'NOMBRE DE LA BASE DE DATOS
    Public DA As SqlDataAdapter
    Public CONEXION As New SqlConnection("Data Source=" & SERVIDOR & ";" & "Initial Catalog=" & BD & ";Integrated Security=" & True)

    Friend Sub MOSTRAR_IMAGEN_CIRCULAR(ByRef PICTUREBOX As PictureBox, ByVal TABLA As String, ByVal CAMPO_ID As String, ByVal ID As Integer, ByVal CAMPO_IMAGEN As String)
        'OBTENEMOS LA IMAGEN EN LA BASE DE DATOS Y LA CARGAMOS EL PICTUREBOX 
        Dim SQL As String

        Try
            Dim DT As New DataTable
            SQL = "SELECT " & CAMPO_IMAGEN & " FROM " & TABLA & " WHERE " & CAMPO_ID & " = " & ID
            DA = New SqlDataAdapter(SQL, CONEXION)
            CONEXION.Open()
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                If Not IsDBNull(DT.Rows(0).Item(CAMPO_IMAGEN)) Then
                    Dim MS As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
                    Dim IMAGEBUFFER() As Byte = CType(DT.Rows(0).Item(CAMPO_IMAGEN), Byte()) 'Convertimos la imagen cargada en el datatable a Bytes.
                    MS = New System.IO.MemoryStream(IMAGEBUFFER) 'Cargamos el MemoryStream con la imagen ya convertida en Bytes.
                    PICTUREBOX.Image = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
                    PICTUREBOX.Image = (Image.FromStream(MS)) 'Cargamos la imagen al PictureBox, Nota: Lo hacemos como .BackgroundImage pero igual lo podemos hacer como .Image.                    
                    CONEXION.Close()
                    DT.Clear()
                    DT.Reset()
                    MS.Dispose()
                    MS.Close()
                    SQL = ""
                Else
                    PICTUREBOX.Image = My.Resources
                End If
            End If
            CONEXION.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema durante el proceso de muestra de la imagen el cual se indica seguidamente: " & vbNewLine & vbNewLine & ex.Message, vbExclamation + vbYesNo, "Problema al cargar la imagen")
        End Try
    End Sub

    Friend Sub SELECCIONAR_GUARDAR_MOSTRAR_IMAGEN_CIRCULAR(ByRef CUADRO_DIALOGO As OpenFileDialog, ByRef PICTUREBOX As PictureBox, ByVal TABLA As String, ByVal CAMPO_ID As String, ByVal ID As Integer, ByVal CAMPO_IMAGEN As String)

        Dim SQL As String
        If CUADRO_DIALOGO.ShowDialog = DialogResult.OK Then
            PICTUREBOX.Image = Image.FromFile(CUADRO_DIALOGO.FileName)
            DIRECCION_IMAGEN_VENTANA_DIALOGO = CUADRO_DIALOGO.FileName

            Try
                Dim MS1 As New System.IO.MemoryStream() 'Creamos el MemoryStream.
                PICTUREBOX.Image.Save(MS1, System.Drawing.Imaging.ImageFormat.Jpeg) 'Salvamos el imagen que tenomos cargada en el PictureBox en el MemoryStream.
                SQL = "UPDATE " & TABLA & " SET " & CAMPO_IMAGEN & " = (@IMAGEN) WHERE " & CAMPO_ID & " = " & ID 'Creamos el Query.
                CONEXION.Close()
                CONEXION.Open() 'Abrimos la Conexión de la base de datos.
                Dim CMD As New SqlCommand(SQL, CONEXION) 'Creamos el comando.
                CMD.Parameters.Add(New SqlParameter("@IMAGEN", MS1.GetBuffer())) 'Agregamos el MemoryStream a los parametros para poderlos guardar en la base de datos.
                CMD.ExecuteNonQuery() 'ejecutamos el query.
                CONEXION.Close()
                CMD = Nothing
                MS1.Dispose()
                MS1.Close()
                CONEXION.Close()
                MOSTRAR_IMAGEN_CIRCULAR(PICTUREBOX, TABLA, CAMPO_ID, ID, CAMPO_IMAGEN)
            Catch ex As Exception
                MsgBox("Al intentar mostrar la imagen se ha presentado el siguiente inconveniente: " & vbNewLine + vbNewLine & ex.Message, vbExclamation + vbOKOnly, "Problemas al mostrar la imagen")
                CONEXION.Close()
            End Try
        End If
    End Sub
End Module