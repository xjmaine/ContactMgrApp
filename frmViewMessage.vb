Imports System.Data.OleDb
Public Class frmViewMessage
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim personSQL As String
    Dim messageSQL As String
    Dim conString As String
    Dim inc As Integer

    Private Sub frmViewMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Contact_DB.accdb'"
        con.ConnectionString = conString
        Dim Message_ID As String
        Message_ID = Me.Tag.ToString
        Dim messageSQL As String = "select * from Message_TB where M_ID=?"
        Dim cmdMessage As New OleDb.OleDbCommand(messageSQL, con)
        cmdMessage.CommandType = CommandType.Text
        cmdMessage.Parameters.AddWithValue("M_ID", Message_ID)
        con.Open()
        cmdMessage.ExecuteNonQuery()
        da.SelectCommand = cmdMessage
        da.Fill(ds, "selectedMessage")
        con.Close()
        displayMessage()
    End Sub

    Private Sub displayMessage()
        txtMID.Text = ds.Tables("selectedMessage").Rows(inc).Item(0).ToString
        txtSender.Text = ds.Tables("selectedMessage").Rows(inc).Item(1)
        txtSentDate.Text = ds.Tables("selectedMessage").Rows(inc).Item(2)
        txtContent.Text = ds.Tables("selectedMessage").Rows(inc).Item(3)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class