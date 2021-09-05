<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMessage
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMID = New System.Windows.Forms.TextBox()
        Me.txtSender = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sender = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtSentDate = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtContent)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 181)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(426, 351)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message"
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(0, 26)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(434, 316)
        Me.txtContent.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSentDate)
        Me.Panel1.Controls.Add(Me.txtMID)
        Me.Panel1.Controls.Add(Me.txtSender)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Sender)
        Me.Panel1.Location = New System.Drawing.Point(23, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 162)
        Me.Panel1.TabIndex = 1
        '
        'txtMID
        '
        Me.txtMID.Location = New System.Drawing.Point(133, 61)
        Me.txtMID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMID.Name = "txtMID"
        Me.txtMID.Size = New System.Drawing.Size(136, 27)
        Me.txtMID.TabIndex = 11
        '
        'txtSender
        '
        Me.txtSender.Location = New System.Drawing.Point(133, 21)
        Me.txtSender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Size = New System.Drawing.Size(136, 27)
        Me.txtSender.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Message ID"
        '
        'Sender
        '
        Me.Sender.AutoSize = True
        Me.Sender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sender.Location = New System.Drawing.Point(57, 28)
        Me.Sender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sender.Name = "Sender"
        Me.Sender.Size = New System.Drawing.Size(68, 20)
        Me.Sender.TabIndex = 7
        Me.Sender.Text = "Sender"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(362, 530)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 34)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtSentDate
        '
        Me.txtSentDate.Location = New System.Drawing.Point(133, 105)
        Me.txtSentDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSentDate.Name = "txtSentDate"
        Me.txtSentDate.Size = New System.Drawing.Size(136, 27)
        Me.txtSentDate.TabIndex = 12
        '
        'frmViewMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 571)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmViewMessage"
        Me.Text = "frmViewMessage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtContent As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtMID As TextBox
    Friend WithEvents txtSender As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Sender As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtSentDate As TextBox
End Class
