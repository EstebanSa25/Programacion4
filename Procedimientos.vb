Module PROCEDIMIENTOS
    Friend Sub CARGAR_TABLA(ByRef Tabla_Temporal As DataSet, ByVal Sql As String)
        CONECTAR()
        Dim Consulta As New OleDb.OleDbDataAdapter(Sql, Db)
        Consulta.Fill(Tabla_Temporal)
        DESCONECTAR()
    End Sub

    Friend Sub EJECUTAR(ByVal Sql As String)
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, Db)
        Comando.ExecuteNonQuery()
        DESCONECTAR()
    End Sub

    Function PK(ByVal TABLA As String, ByVal ID As String) As Integer
        T.Tables.Clear()
        Sql = "SELECT " & ID & " FROM " & TABLA
        CARGAR_TABLA(T, Sql)
        If T.Tables(0).Rows.Count > 0 Then
            T.Tables.Clear()
            Sql = "SELECT MAX(ID) FROM " & TABLA
            CARGAR_TABLA(T, Sql)
            PK = T.Tables(0).Rows(0).ItemArray(0) + 1
        Else
            PK = 1
        End If
    End Function
End Module