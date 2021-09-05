Imports System.Data.OleDb
Public Class frmViewContactMessages
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim personSQL As String
    Dim messageSQL As String
    Dim conString As String
    Dim inc As Integer
    Private Sub frmViewContactMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Contact_DB.accdb'"
        con.ConnectionString = conString

        'used to store the ID of the selected contact passed from Form1
        Dim Person_ID As String
        Person_ID = Me.Tag.ToString

        'the parameterize query to fetch data on the selected contact
        Dim personSQL As String = "select * from Person_TB where P_ID=?"
        Dim cmdPerson As New OleDb.OleDbCommand(personSQL, con)
        cmdPerson.CommandType = CommandType.Text

        'Creating the parameter and passing the value of the selected ID
        cmdPerson.Parameters.AddWithValue("Sender_ID", Person_ID)
        con.Open()
        cmdPerson.ExecuteNonQuery()
        da.SelectCommand = cmdPerson
        da.Fill(ds, "selectedPerson")

        'the parameterize query to fetch data on the messages sent by the selected contact
        Dim messageSQL As String = "select * from Message_TB where Sender_ID=?“
        Dim cmdMessage As New OleDb.OleDbCommand(messageSQL, con)
        cmdMessage.CommandType = CommandType.Text
        'Creating the parameter and passing the value of the selected ID
        cmdMessage.Parameters.AddWithValue("Sender_ID", Person_ID)
        cmdMessage.ExecuteNonQuery()
        da.SelectCommand = cmdMessage
        da.Fill(ds, "selectedPersonMessages")
        con.Close()
        showData()
    End Sub

    Private Sub showData()
        txtContactID.Text = ds.Tables("selectedPerson").Rows(inc).Item(0)
        txtfFirstName.Text = ds.Tables("selectedPerson").Rows(inc).Item(1)
        txtSecondName.Text = ds.Tables("selectedPerson").Rows(inc).Item(2)
        cmbGender.Text = ds.Tables("selectedPerson").Rows(inc).Item(3)
        txtDate.Value = ds.Tables("selectedPerson").Rows(inc).Item(4)
        txtEmail.Text = ds.Tables("selectedPerson").Rows(inc).Item(5)
        txtNumber.Text = ds.Tables("selectedPerson").Rows(inc).Item(6)
        txtAddress.Text = ds.Tables("selectedPerson").Rows(inc).Item(7)
        txtDetails.Text = ds.Tables("selectedPerson").Rows(inc).Item(8)

        'link (bound) the Datagridviewcontrol to the selectedPersonMessagesin the ds dataset
        dgvMessages.DataSource = ds.Tables("selectedPerson")
        'Display the inserted (ViewMessage) column as the last column in the datagridview
        dgvMessages.Columns("View_Message").DisplayIndex = 4
    End Sub

    Private Sub dgvMessages_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMessages.CellContentClick
        If e.ColumnIndex = 0 Then
            ' ViewMessagebutton clicked
            ' Get the ID of the selected Message
            Dim i As Integer = e.RowIndex
            Dim row As DataGridViewRow = dgvMessages.Rows(i)
            Dim cell As DataGridViewCell = row.Cells(1)
            Dim MessageID As String = cell.Value.ToString
            ' Display the ViewMessageform
            Dim messageForm As New frmViewMessage
            messageForm.Tag = MessageID
            messageForm.ShowDialog()
        End If
    End Sub
End Class