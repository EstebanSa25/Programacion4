Module CONEXIONES
    Public Db As New OleDb.OleDbConnection
    Public T As New DataSet
    Public SQL As String


    Friend Sub CONECTAR()
        Dim Ruta As String
        Ruta = "File Name=" & Application.StartupPath & "\CONEX.udl"
        Db.ConnectionString = Ruta
        Db.Open()
        Exit Sub
    End Sub

    Friend Sub DESCONECTAR()
        Db.Close()
    End Sub

End Module

