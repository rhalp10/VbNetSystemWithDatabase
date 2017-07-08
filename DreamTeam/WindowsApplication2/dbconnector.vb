Imports System.Data.OleDb

Public Class dbconnector

    Private con As New OleDb.OleDbConnection
    Private da As OleDb.OleDbDataAdapter
    Private command As OleDb.OleDbCommand

    Sub connect() 'method na nagcoconnect sa DB
        Dim dbProvider As String
        Dim dbSource As String

        dbProvider = "Provider = Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = dt.accdb;"

        con.ConnectionString = dbProvider & dbSource
        con.Open()
    End Sub
    Function sqlSelect(ByVal sqlString As String)
        Dim ds As New DataSet 'nagstore ng mga data galing db
        ds.Clear()
        da = New OleDbDataAdapter(sqlString, con)
        da.Fill(ds, "Results") 'ilalagay ung mga data sa ds 
        con.Close()
        Return ds 'eto daw ung magagamit na data
    End Function
    
End Class
