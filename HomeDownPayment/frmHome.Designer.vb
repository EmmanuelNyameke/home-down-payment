<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeading = New Label()
        btnPayment = New Button()
        lstDisplay = New ListBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        lblTitle = New Label()
        lblAmt = New Label()
        lblCheck = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(237, 36)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(440, 42)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Home Down Payment"
        ' 
        ' btnPayment
        ' 
        btnPayment.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPayment.Location = New Point(351, 131)
        btnPayment.Name = "btnPayment"
        btnPayment.Size = New Size(212, 44)
        btnPayment.TabIndex = 1
        btnPayment.Text = "Enter Payment"
        btnPayment.UseVisualStyleBackColor = True
        ' 
        ' lstDisplay
        ' 
        lstDisplay.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstDisplay.FormattingEnabled = True
        lstDisplay.ItemHeight = 23
        lstDisplay.Location = New Point(297, 204)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(319, 119)
        lstDisplay.TabIndex = 2
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(914, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuClear, mnuExit})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(101, 22)
        mnuClear.Text = "&Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(101, 22)
        mnuExit.Text = "E&xit"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        lblTitle.Location = New Point(0, 78)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(686, 32)
        lblTitle.TabIndex = 4
        lblTitle.Text = "Required Amount for Home Down Payment: "
        ' 
        ' lblAmt
        ' 
        lblAmt.AutoSize = True
        lblAmt.Font = New Font("Verdana", 20.25F, FontStyle.Bold)
        lblAmt.Location = New Point(692, 78)
        lblAmt.Name = "lblAmt"
        lblAmt.Size = New Size(76, 32)
        lblAmt.TabIndex = 5
        lblAmt.Text = "Amt"
        ' 
        ' lblCheck
        ' 
        lblCheck.AutoSize = True
        lblCheck.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCheck.Location = New Point(0, 349)
        lblCheck.Name = "lblCheck"
        lblCheck.Size = New Size(102, 29)
        lblCheck.TabIndex = 8
        lblCheck.Text = "Label1"
        ' 
        ' frmHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        BackgroundImage = My.Resources.Resources.Home
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 420)
        Controls.Add(lblCheck)
        Controls.Add(lblAmt)
        Controls.Add(lblTitle)
        Controls.Add(lstDisplay)
        Controls.Add(btnPayment)
        Controls.Add(lblHeading)
        Controls.Add(MenuStrip1)
        Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        MainMenuStrip = MenuStrip1
        Name = "frmHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home Down Payment"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnPayment As Button
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAmt As Label
    Friend WithEvents lblCheck As Label

End Class
