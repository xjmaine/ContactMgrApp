<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewContactMessages
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvMessages = New System.Windows.Forms.DataGridView()
        Me.View_Message = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSQLWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CallsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContactID = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtfFirstName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSecondName = New System.Windows.Forms.TextBox()
        Me.infoPanel1 = New System.Windows.Forms.Panel()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.infoPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvMessages)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 431)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(748, 158)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Messages"
        '
        'dgvMessages
        '
        Me.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMessages.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.View_Message})
        Me.dgvMessages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMessages.Location = New System.Drawing.Point(3, 18)
        Me.dgvMessages.Name = "dgvMessages"
        Me.dgvMessages.RowHeadersWidth = 51
        Me.dgvMessages.RowTemplate.Height = 24
        Me.dgvMessages.Size = New System.Drawing.Size(742, 137)
        Me.dgvMessages.TabIndex = 0
        '
        'View_Message
        '
        Me.View_Message.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.View_Message.HeaderText = "View Data"
        Me.View_Message.MinimumWidth = 6
        Me.View_Message.Name = "View_Message"
        Me.View_Message.Text = "View Message"
        Me.View_Message.UseColumnTextForButtonValue = True
        Me.View_Message.Width = 125
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ActionToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenSQLWindowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenSQLWindowToolStripMenuItem
        '
        Me.OpenSQLWindowToolStripMenuItem.Name = "OpenSQLWindowToolStripMenuItem"
        Me.OpenSQLWindowToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.OpenSQLWindowToolStripMenuItem.Text = "Open SQL Window"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessagesToolStripMenuItem, Me.CallsToolStripMenuItem1, Me.AllContactsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'MessagesToolStripMenuItem
        '
        Me.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem"
        Me.MessagesToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.MessagesToolStripMenuItem.Text = "Messages"
        '
        'CallsToolStripMenuItem1
        '
        Me.CallsToolStripMenuItem1.Name = "CallsToolStripMenuItem1"
        Me.CallsToolStripMenuItem1.Size = New System.Drawing.Size(171, 26)
        Me.CallsToolStripMenuItem1.Text = "Calls"
        '
        'AllContactsToolStripMenuItem
        '
        Me.AllContactsToolStripMenuItem.Name = "AllContactsToolStripMenuItem"
        Me.AllContactsToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.AllContactsToolStripMenuItem.Text = "All Contacts"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Non-Binary"})
        Me.cmbGender.Location = New System.Drawing.Point(136, 113)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(87, 24)
        Me.cmbGender.TabIndex = 15
        Me.cmbGender.Text = "Female"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(136, 239)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(212, 94)
        Me.txtAddress.TabIndex = 14
        '
        'txtDate
        '
        Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate.Location = New System.Drawing.Point(136, 144)
        Me.txtDate.MaxDate = New Date(9998, 1, 1, 0, 0, 0, 0)
        Me.txtDate.MinDate = New Date(1940, 12, 31, 0, 0, 0, 0)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(212, 22)
        Me.txtDate.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Phone Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Date of Birth:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Contact ID:"
        '
        'txtContactID
        '
        Me.txtContactID.Location = New System.Drawing.Point(136, 3)
        Me.txtContactID.Name = "txtContactID"
        Me.txtContactID.ReadOnly = True
        Me.txtContactID.Size = New System.Drawing.Size(87, 22)
        Me.txtContactID.TabIndex = 0
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(136, 205)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(212, 22)
        Me.txtNumber.TabIndex = 5
        '
        'txtfFirstName
        '
        Me.txtfFirstName.Location = New System.Drawing.Point(136, 40)
        Me.txtfFirstName.Name = "txtfFirstName"
        Me.txtfFirstName.Size = New System.Drawing.Size(212, 22)
        Me.txtfFirstName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(136, 172)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(212, 22)
        Me.txtEmail.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "First Name:"
        '
        'txtSecondName
        '
        Me.txtSecondName.Location = New System.Drawing.Point(136, 78)
        Me.txtSecondName.Name = "txtSecondName"
        Me.txtSecondName.Size = New System.Drawing.Size(212, 22)
        Me.txtSecondName.TabIndex = 2
        '
        'infoPanel1
        '
        Me.infoPanel1.Controls.Add(Me.cmbGender)
        Me.infoPanel1.Controls.Add(Me.txtAddress)
        Me.infoPanel1.Controls.Add(Me.txtDate)
        Me.infoPanel1.Controls.Add(Me.Label8)
        Me.infoPanel1.Controls.Add(Me.Label7)
        Me.infoPanel1.Controls.Add(Me.Label6)
        Me.infoPanel1.Controls.Add(Me.Label5)
        Me.infoPanel1.Controls.Add(Me.Label4)
        Me.infoPanel1.Controls.Add(Me.Label3)
        Me.infoPanel1.Controls.Add(Me.Label2)
        Me.infoPanel1.Controls.Add(Me.Label1)
        Me.infoPanel1.Controls.Add(Me.txtContactID)
        Me.infoPanel1.Controls.Add(Me.txtNumber)
        Me.infoPanel1.Controls.Add(Me.txtfFirstName)
        Me.infoPanel1.Controls.Add(Me.txtEmail)
        Me.infoPanel1.Controls.Add(Me.txtSecondName)
        Me.infoPanel1.Location = New System.Drawing.Point(7, 21)
        Me.infoPanel1.Name = "infoPanel1"
        Me.infoPanel1.Size = New System.Drawing.Size(371, 344)
        Me.infoPanel1.TabIndex = 6
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(3, 49)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(284, 284)
        Me.txtDetails.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Details"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDetails)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(385, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 343)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.infoPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 408)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Information"
        '
        'frmViewContactMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 601)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmViewContactMessages"
        Me.Text = "frmViewContactMessages"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvMessages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.infoPanel1.ResumeLayout(False)
        Me.infoPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenSQLWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CallsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AllContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContactID As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtfFirstName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecondName As TextBox
    Friend WithEvents infoPanel1 As Panel
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvMessages As DataGridView
    Friend WithEvents View_Message As DataGridViewButtonColumn
End Class
