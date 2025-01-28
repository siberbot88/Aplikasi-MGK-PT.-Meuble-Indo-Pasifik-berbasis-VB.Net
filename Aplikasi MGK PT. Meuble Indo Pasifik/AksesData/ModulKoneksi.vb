'Tempat menampung variabel dan prosedur aplikasi
Imports MySql.Data.MySqlClient
Imports System.Data
Module ModulKoneksi
    Public Koneksi As New MySqlConnection
    Public read As MySqlDataReader
    Public strcon As String
    Public ds As New DataSet
    Public olecon As New MySqlConnection
    Public adapter As New MySqlDataAdapter
    Public dataset As New DataSet
    Dim muser As New MySqlCommand

    'hak akses database 
    Public Sub bukaDB()
        Koneksi = New MySqlConnection
        strcon = New String("Server=localhost;userid=root;database=inventory")
        Koneksi.ConnectionString = strcon
        Koneksi.Open()
    End Sub

    Public Sub StatusKoneksi()
        Koneksi.Close()
        Koneksi.Open()
    End Sub
End Module

