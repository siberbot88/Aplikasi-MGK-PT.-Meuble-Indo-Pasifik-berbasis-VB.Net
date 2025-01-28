Imports MySql.Data.MySqlClient
Namespace AksesData
    Public Class DataControl
        Private Myconnection As New AksesData.KoneksiDB
        Public Function GetDataSet(ByVal SQL As String) As DataSet
            Dim adapter As New MySqlDataAdapter(SQL, Myconnection.open)
            Dim myData As New DataSet
            adapter.Fill(myData, "Data")
            Return myData
        End Function
    End Class
End Namespace