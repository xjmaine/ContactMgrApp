Imports System.Data.OleDb

Public Class msForm
    ''globall variables
    Dim con As New OleDb.OleDbConnection
    Dim dataAdapter As New OleDbDataAdapter
    Dim dataSet As New DataSet
    Dim conString As String
    Dim sql As String
    Dim maxRows As Integer
    Dim dataSetNewRow As DataRow
    Dim index As Integer

    Private Sub msForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='Contact_DB.accdb'"
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Person_TB"
            dataAdapter = New OleDbDataAdapter(sql, con)
            dataAdapter.Fill(dataSet, "AddressBook")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        NavigateRecord()
        DisableControl()
        btnCancel.Enabled = False
        btnCommit.Enabled = False
        btnSave.Enabled = False
    End Sub

    'linking each contorl/object to a specific column/table
    Private Sub NavigateRecord()
        txtContactID.Text = dataSet.Tables("AddressBook").Rows(index).Item(0)
        txtfFirstName.Text = dataSet.Tables("AddressBook").Rows(index).Item(1)
        txtSecondName.Text = dataSet.Tables("AddressBook").Rows(index).Item(2)
        cmbGender.Text = dataSet.Tables("AddressBook").Rows(index).Item(3)
        txtDate.Value = dataSet.Tables("AddressBook").Rows(index).Item(4)
        txtEmail.Text = dataSet.Tables("AddressBook").Rows(index).Item(5)
        txtNumber.Text = dataSet.Tables("AddressBook").Rows(index).Item(6)
        txtAddress.Text = dataSet.Tables("AddressBook").Rows(index).Item(7)
        txtDetails.Text = dataSet.Tables("AddressBook").Rows(index).Item(8)
        maxRows = dataSet.Tables("AddressBook").Rows.Count
    End Sub

    Private Sub DisableControl()
        txtContactID.ReadOnly = True
        txtfFirstName.ReadOnly = True
        txtSecondName.ReadOnly = True
        cmbGender.Enabled = False
        txtDate.Enabled = False
        txtEmail.ReadOnly = True
        txtNumber.ReadOnly = True
        txtAddress.ReadOnly = True
        txtDetails.ReadOnly = True
    End Sub

    Private Sub EnableControl()
        txtContactID.ReadOnly = False
        txtfFirstName.ReadOnly = False
        txtSecondName.ReadOnly = False
        cmbGender.Enabled = True
        txtDate.Enabled = True
        txtEmail.ReadOnly = False
        txtNumber.ReadOnly = False
        txtAddress.ReadOnly = False
        txtDetails.ReadOnly = False
    End Sub

    Private Sub clearRecord()
        txtContactID.Text = ""
        txtfFirstName.Text = ""
        txtSecondName.Text = ""
        cmbGender.Text = "Female"
        txtDate.Value = Today()
        txtEmail.Text = ""
        txtNumber.Text = ""
        txtAddress.Text = ""
        txtDetails.Text = ""
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If index <> 0 Then
            index = 0
            NavigateRecord()
        Else
            MessageBox.Show("This is the first record")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If index <> 0 Then
            index -= 1
            NavigateRecord()
        Else
            MessageBox.Show("End of records!")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index <> maxRows - 1 Then
            index = index + 1
            NavigateRecord()
        Else
            MessageBox.Show("Last record")
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Try
            If index <> maxRows - 1 Then
                index = maxRows - 1
                NavigateRecord()
            Else
                MessageBox.Show("End of records!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub AddRecord()
        dataSetNewRow.Item("FirstName") = txtfFirstName.Text
        dataSetNewRow.Item("LastName") = txtSecondName.Text
        dataSetNewRow.Item("Gender") = cmbGender.Text
        dataSetNewRow.Item("DateOfBirth") = txtDate.Value
        dataSetNewRow.Item("email") = txtEmail.Text
        dataSetNewRow.Item("PhoneNumber") = txtNumber.Text
        dataSetNewRow.Item("Address") = txtfFirstName.Text
        dataSetNewRow.Item("Details") = txtDetails.Text
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'txtContactID.Enabled = False
        btnCommit.Enabled = True
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        clearRecord()
        EnableControl()
        MessageBox.Show("Alert! Fill in information and commit!")
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Dim cb As New OleDbCommandBuilder(dataAdapter)
        Try
            dataSetNewRow = dataSet.Tables("AddressBook").NewRow()
            AddRecord()
            dataSet.Tables("AddressBook").Rows.Add(dataSetNewRow)
            dataAdapter.Update(dataSet, "AddressBook")
            MessageBox.Show("Record saved successfully!")
            btnCommit.Enabled = False
            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnCancel.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        'reload form
        msForm_Load(Me, New System.EventArgs)
        NavigateRecord()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnCommit.Enabled = False
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnSave.Enabled = True
        EnableControl()
        MessageBox.Show("Please make changes and select save.")
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        searchRecord()
    End Sub

    Private Sub searchRecord()
        Dim ID As String
        Static keepID As Integer
        Dim ISFound As Boolean = False
        index = 0
        Try
            ID = InputBox("Ente ID to search")
            If ID = "" Then
                MessageBox.Show("You must enter a value to search")
                Exit Sub
            Else
                Do While index < maxRows
                    If ID = dataSet.Tables("AddressBook").Rows(index).Item("P_ID") Then
                        keepID = index
                        ISFound = True
                        Exit Try
                    End If
                    index = index + 1
                Loop
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        If ISFound Then
            index = keepID
            NavigateRecord()
        Else
            MessageBox.Show("Record not found")
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenSQLWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenSQLWindowToolStripMenuItem.Click
        ContactManagerSQL.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                MessageBox.Show("Operation Cancelled")
                Exit Sub
            Else
                Dim cb As New OleDbCommandBuilder(dataAdapter)
                dataSet.Tables("AddressBook").Rows(index).Delete()
                maxRows = maxRows - 1
                index = 0
                dataAdapter.Update(dataSet, "AddressBook")
                clearRecord()
                NavigateRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cb As New OleDbCommandBuilder(dataAdapter)
        Try
            dataSet.Tables("AddressBook").Rows(index).Item(1) = txtfFirstName.Text
            dataSet.Tables("AddressBook").Rows(index).Item(1) = txtfFirstName.Text
            dataSet.Tables("AddressBook").Rows(index).Item(2) = txtSecondName.Text
            dataSet.Tables("AddressBook").Rows(index).Item(3) = cmbGender.Text
            dataSet.Tables("AddressBook").Rows(index).Item(4) = txtDate.Value
            dataSet.Tables("AddressBook").Rows(index).Item(5) = txtEmail.Text
            dataSet.Tables("AddressBook").Rows(index).Item(6) = txtNumber.Text
            dataSet.Tables("AddressBook").Rows(index).Item(7) = txtAddress.Text
            dataSet.Tables("AddressBook").Rows(index).Item(8) = txtDetails.Text
            dataAdapter.Update(dataSet, "AddressBook")
            btnCommit.Enabled = False
            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnCancel.Enabled = False
            btnSave.Enabled = False
            DisableControl()
            MessageBox.Show("Update was saved successful!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        NavigateRecord()
        MessageBox.Show("editing stopped")
        btnCancel.Enabled = False
        btnCommit.Enabled = False
        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchRecord()
    End Sub

    Private Sub MessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessagesToolStripMenuItem.Click
        Dim Person_ID As String = txtContactID.Text
        Dim messageForm As New frmViewContactMessages
        messageForm.Tag = Person_ID
        messageForm.ShowDialog()
    End Sub
End Class
