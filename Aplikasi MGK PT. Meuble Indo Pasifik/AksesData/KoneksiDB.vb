'menghubungkan project ke data mysql
Imports MySql.Data.MySqlClient
Namespace AksesData
    Public Class KoneksiDB
        Dim conn As New MySqlConnection("Server=localhost;user id=root;database=inventory;pooling=false;Connection TimeOut=5")
        Public Function open() As MySqlConnection
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Return conn
        End Function
    End Class
End Namespace
