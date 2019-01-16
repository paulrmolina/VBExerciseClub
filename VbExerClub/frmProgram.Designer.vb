<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgram
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
        Me.tssStatus = New System.Windows.Forms.StatusStrip()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstPrograms = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtAnnDiscount = New System.Windows.Forms.TextBox()
        Me.txtMonthlyFee = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtProgID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbProgram = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbShop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbContact = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbReturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPayment = New System.Windows.Forms.ToolStripButton()
        Me.tssStatus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tssStatus
        '
        Me.tssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslStatus})
        Me.tssStatus.Location = New System.Drawing.Point(0, 337)
        Me.tssStatus.Name = "tssStatus"
        Me.tssStatus.Size = New System.Drawing.Size(741, 22)
        Me.tssStatus.TabIndex = 3
        '
        'tslStatus
        '
        Me.tslStatus.AutoSize = False
        Me.tslStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(400, 17)
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Manage Exercise Programs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstPrograms)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 202)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Programs"
        '
        'lstPrograms
        '
        Me.lstPrograms.FormattingEnabled = True
        Me.lstPrograms.ItemHeight = 17
        Me.lstPrograms.Location = New System.Drawing.Point(14, 30)
        Me.lstPrograms.Name = "lstPrograms"
        Me.lstPrograms.Size = New System.Drawing.Size(268, 157)
        Me.lstPrograms.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.txtAnnDiscount)
        Me.GroupBox2.Controls.Add(Me.txtMonthlyFee)
        Me.GroupBox2.Controls.Add(Me.txtDesc)
        Me.GroupBox2.Controls.Add(Me.txtProgID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 193)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Program Details"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(214, 148)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 31)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(100, 148)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 31)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtAnnDiscount
        '
        Me.txtAnnDiscount.Location = New System.Drawing.Point(136, 117)
        Me.txtAnnDiscount.Name = "txtAnnDiscount"
        Me.txtAnnDiscount.Size = New System.Drawing.Size(176, 25)
        Me.txtAnnDiscount.TabIndex = 7
        '
        'txtMonthlyFee
        '
        Me.txtMonthlyFee.Location = New System.Drawing.Point(136, 87)
        Me.txtMonthlyFee.Name = "txtMonthlyFee"
        Me.txtMonthlyFee.Size = New System.Drawing.Size(176, 25)
        Me.txtMonthlyFee.TabIndex = 6
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(136, 56)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(176, 25)
        Me.txtDesc.TabIndex = 5
        '
        'txtProgID
        '
        Me.txtProgID.Location = New System.Drawing.Point(136, 25)
        Me.txtProgID.Name = "txtProgID"
        Me.txtProgID.Size = New System.Drawing.Size(176, 25)
        Me.txtProgID.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Annual Discount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Monthly Fee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Program ID"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbHome, Me.ToolStripSeparator3, Me.tsbMember, Me.ToolStripSeparator4, Me.tsbProgram, Me.ToolStripSeparator5, Me.tsbShop, Me.ToolStripSeparator6, Me.tsbContact, Me.ToolStripSeparator2, Me.ToolStripSeparator9, Me.tsbReturn, Me.ToolStripSeparator8, Me.tsbHelp, Me.ToolStripSeparator7, Me.tsbPayment})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(741, 75)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 75)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.VbExerClub.My.Resources.Resources.home_2
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(65, 70)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 75)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.VbExerClub.My.Resources.Resources.person_1
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(65, 70)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 75)
        '
        'tsbProgram
        '
        Me.tsbProgram.AutoSize = False
        Me.tsbProgram.BackgroundImage = Global.VbExerClub.My.Resources.Resources.barbells
        Me.tsbProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbProgram.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProgram.Name = "tsbProgram"
        Me.tsbProgram.Size = New System.Drawing.Size(65, 70)
        Me.tsbProgram.Text = "PROGRAM"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 75)
        '
        'tsbShop
        '
        Me.tsbShop.AutoSize = False
        Me.tsbShop.BackgroundImage = Global.VbExerClub.My.Resources.Resources.shopping
        Me.tsbShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbShop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbShop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbShop.Name = "tsbShop"
        Me.tsbShop.Size = New System.Drawing.Size(65, 70)
        Me.tsbShop.Text = "SHOP"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 75)
        '
        'tsbContact
        '
        Me.tsbContact.AutoSize = False
        Me.tsbContact.BackgroundImage = Global.VbExerClub.My.Resources.Resources.email
        Me.tsbContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbContact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbContact.Name = "tsbContact"
        Me.tsbContact.Size = New System.Drawing.Size(65, 70)
        Me.tsbContact.Text = "CONTACT"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 75)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 75)
        '
        'tsbReturn
        '
        Me.tsbReturn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbReturn.AutoSize = False
        Me.tsbReturn.BackgroundImage = Global.VbExerClub.My.Resources.Resources.return2
        Me.tsbReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbReturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReturn.Name = "tsbReturn"
        Me.tsbReturn.Size = New System.Drawing.Size(65, 70)
        Me.tsbReturn.Text = "RETURN"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 75)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.VbExerClub.My.Resources.Resources.question
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(65, 70)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 75)
        '
        'tsbPayment
        '
        Me.tsbPayment.AutoSize = False
        Me.tsbPayment.BackgroundImage = Global.VbExerClub.My.Resources.Resources.payment_methods_banknotes_icon
        Me.tsbPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPayment.Name = "tsbPayment"
        Me.tsbPayment.Size = New System.Drawing.Size(65, 70)
        Me.tsbPayment.Text = "ToolStripButton1"
        '
        'frmProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(741, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tssStatus)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmProgram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exercise Program Information"
        Me.tssStatus.ResumeLayout(False)
        Me.tssStatus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tssStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstPrograms As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAnnDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthlyFee As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtProgID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbMember As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbProgram As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbShop As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbContact As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbReturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPayment As System.Windows.Forms.ToolStripButton
End Class
