<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.components = New System.ComponentModel.Container()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.dgcPmtID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcMbrID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcProgId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcDateDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcDatePaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcAmtPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboPayment = New System.Windows.Forms.GroupBox()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEffectiveUntil = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPaymentAmount = New System.Windows.Forms.Label()
        Me.lblPaymentA = New System.Windows.Forms.Label()
        Me.lblPaymentSummary = New System.Windows.Forms.Label()
        Me.cboPeriod = New System.Windows.Forms.ComboBox()
        Me.lblEffectiveDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNextPaymentDueDate = New System.Windows.Forms.Label()
        Me.btnProcessPayment = New System.Windows.Forms.Button()
        Me.errProv = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.grpSearch.SuspendLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboPayment.SuspendLayout()
        CType(Me.errProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboName
        '
        Me.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(139, 14)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(155, 24)
        Me.cboName.TabIndex = 19
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.Label11)
        Me.grpSearch.Controls.Add(Me.cboName)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.ForeColor = System.Drawing.Color.DarkBlue
        Me.grpSearch.Location = New System.Drawing.Point(12, 88)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(312, 52)
        Me.grpSearch.TabIndex = 17
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Find By Name"
        '
        'dgvPayments
        '
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcPmtID, Me.dgcMbrID, Me.dgcProgId, Me.dgcDateDue, Me.dgcDatePaid, Me.dgcAmtPaid})
        Me.dgvPayments.Location = New System.Drawing.Point(12, 146)
        Me.dgvPayments.MultiSelect = False
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.Size = New System.Drawing.Size(669, 150)
        Me.dgvPayments.TabIndex = 18
        '
        'dgcPmtID
        '
        Me.dgcPmtID.HeaderText = "Payment ID"
        Me.dgcPmtID.Name = "dgcPmtID"
        Me.dgcPmtID.ReadOnly = True
        '
        'dgcMbrID
        '
        Me.dgcMbrID.HeaderText = "Member ID"
        Me.dgcMbrID.Name = "dgcMbrID"
        Me.dgcMbrID.ReadOnly = True
        '
        'dgcProgId
        '
        Me.dgcProgId.HeaderText = "Program ID"
        Me.dgcProgId.Name = "dgcProgId"
        Me.dgcProgId.ReadOnly = True
        '
        'dgcDateDue
        '
        Me.dgcDateDue.HeaderText = "Date Due"
        Me.dgcDateDue.Name = "dgcDateDue"
        Me.dgcDateDue.ReadOnly = True
        '
        'dgcDatePaid
        '
        Me.dgcDatePaid.HeaderText = "Date Paid"
        Me.dgcDatePaid.Name = "dgcDatePaid"
        Me.dgcDatePaid.ReadOnly = True
        '
        'dgcAmtPaid
        '
        Me.dgcAmtPaid.HeaderText = "Amount Paid"
        Me.dgcAmtPaid.Name = "dgcAmtPaid"
        Me.dgcAmtPaid.ReadOnly = True
        '
        'txtPaymentID
        '
        Me.txtPaymentID.Location = New System.Drawing.Point(138, 49)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(93, 20)
        Me.txtPaymentID.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Payment ID:  "
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(8, 105)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(128, 13)
        Me.lblPeriod.TabIndex = 23
        Me.lblPeriod.Text = "Payment Period (Months):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Payment Effective Date:"
        '
        'gboPayment
        '
        Me.gboPayment.Controls.Add(Me.lblProgram)
        Me.gboPayment.Controls.Add(Me.Label6)
        Me.gboPayment.Controls.Add(Me.lblEffectiveUntil)
        Me.gboPayment.Controls.Add(Me.Label4)
        Me.gboPayment.Controls.Add(Me.Label2)
        Me.gboPayment.Controls.Add(Me.lblPaymentAmount)
        Me.gboPayment.Controls.Add(Me.lblPaymentA)
        Me.gboPayment.Controls.Add(Me.lblPaymentSummary)
        Me.gboPayment.Controls.Add(Me.cboPeriod)
        Me.gboPayment.Controls.Add(Me.lblEffectiveDate)
        Me.gboPayment.Controls.Add(Me.Label3)
        Me.gboPayment.Controls.Add(Me.Label1)
        Me.gboPayment.Controls.Add(Me.lblPeriod)
        Me.gboPayment.Controls.Add(Me.txtPaymentID)
        Me.gboPayment.Location = New System.Drawing.Point(13, 302)
        Me.gboPayment.Name = "gboPayment"
        Me.gboPayment.Size = New System.Drawing.Size(668, 134)
        Me.gboPayment.TabIndex = 25
        Me.gboPayment.TabStop = False
        Me.gboPayment.Text = "Make a Payment"
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Location = New System.Drawing.Point(136, 78)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(97, 13)
        Me.lblProgram.TabIndex = 33
        Me.lblProgram.Text = "_______________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Program:"
        '
        'lblEffectiveUntil
        '
        Me.lblEffectiveUntil.AutoSize = True
        Me.lblEffectiveUntil.Location = New System.Drawing.Point(455, 101)
        Me.lblEffectiveUntil.Name = "lblEffectiveUntil"
        Me.lblEffectiveUntil.Size = New System.Drawing.Size(73, 13)
        Me.lblEffectiveUntil.TabIndex = 31
        Me.lblEffectiveUntil.Text = "___________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Effective until:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Payment Options"
        '
        'lblPaymentAmount
        '
        Me.lblPaymentAmount.AutoSize = True
        Me.lblPaymentAmount.Location = New System.Drawing.Point(455, 75)
        Me.lblPaymentAmount.Name = "lblPaymentAmount"
        Me.lblPaymentAmount.Size = New System.Drawing.Size(40, 13)
        Me.lblPaymentAmount.TabIndex = 28
        Me.lblPaymentAmount.Text = "($0.00)"
        '
        'lblPaymentA
        '
        Me.lblPaymentA.AutoSize = True
        Me.lblPaymentA.Location = New System.Drawing.Point(328, 75)
        Me.lblPaymentA.Name = "lblPaymentA"
        Me.lblPaymentA.Size = New System.Drawing.Size(90, 13)
        Me.lblPaymentA.TabIndex = 27
        Me.lblPaymentA.Text = "Payment Amount:"
        '
        'lblPaymentSummary
        '
        Me.lblPaymentSummary.AutoSize = True
        Me.lblPaymentSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentSummary.Location = New System.Drawing.Point(328, 25)
        Me.lblPaymentSummary.Name = "lblPaymentSummary"
        Me.lblPaymentSummary.Size = New System.Drawing.Size(100, 13)
        Me.lblPaymentSummary.TabIndex = 26
        Me.lblPaymentSummary.Text = "Payment Sumary"
        '
        'cboPeriod
        '
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.Location = New System.Drawing.Point(138, 102)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(51, 21)
        Me.cboPeriod.TabIndex = 23
        '
        'lblEffectiveDate
        '
        Me.lblEffectiveDate.AutoSize = True
        Me.lblEffectiveDate.Location = New System.Drawing.Point(455, 51)
        Me.lblEffectiveDate.Name = "lblEffectiveDate"
        Me.lblEffectiveDate.Size = New System.Drawing.Size(36, 13)
        Me.lblEffectiveDate.TabIndex = 25
        Me.lblEffectiveDate.Text = "(Date)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(364, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Next Payment Due Date: "
        '
        'lblNextPaymentDueDate
        '
        Me.lblNextPaymentDueDate.AutoSize = True
        Me.lblNextPaymentDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextPaymentDueDate.ForeColor = System.Drawing.Color.Red
        Me.lblNextPaymentDueDate.Location = New System.Drawing.Point(556, 108)
        Me.lblNextPaymentDueDate.Name = "lblNextPaymentDueDate"
        Me.lblNextPaymentDueDate.Size = New System.Drawing.Size(72, 17)
        Me.lblNextPaymentDueDate.TabIndex = 31
        Me.lblNextPaymentDueDate.Text = "00/00/00"
        '
        'btnProcessPayment
        '
        Me.btnProcessPayment.Location = New System.Drawing.Point(571, 445)
        Me.btnProcessPayment.Name = "btnProcessPayment"
        Me.btnProcessPayment.Size = New System.Drawing.Size(110, 32)
        Me.btnProcessPayment.TabIndex = 32
        Me.btnProcessPayment.Text = "Process Payment"
        Me.btnProcessPayment.UseVisualStyleBackColor = True
        '
        'errProv
        '
        Me.errProv.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbHome, Me.ToolStripSeparator3, Me.tsbMember, Me.ToolStripSeparator4, Me.tsbProgram, Me.ToolStripSeparator5, Me.tsbShop, Me.ToolStripSeparator6, Me.tsbContact, Me.ToolStripSeparator2, Me.ToolStripSeparator9, Me.tsbReturn, Me.ToolStripSeparator8, Me.tsbHelp, Me.ToolStripSeparator7, Me.tsbPayment})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(693, 75)
        Me.ToolStrip1.TabIndex = 33
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
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(693, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnProcessPayment)
        Me.Controls.Add(Me.lblNextPaymentDueDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvPayments)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.gboPayment)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment Information"
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboPayment.ResumeLayout(False)
        Me.gboPayment.PerformLayout()
        CType(Me.errProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvPayments As System.Windows.Forms.DataGridView
    Friend WithEvents dgcPmtID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcMbrID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcProgId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcDateDue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcDatePaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcAmtPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPaymentID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gboPayment As System.Windows.Forms.GroupBox
    Friend WithEvents lblEffectiveDate As System.Windows.Forms.Label
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaymentSummary As System.Windows.Forms.Label
    Friend WithEvents lblPaymentAmount As System.Windows.Forms.Label
    Friend WithEvents lblPaymentA As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEffectiveUntil As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNextPaymentDueDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnProcessPayment As System.Windows.Forms.Button
    Friend WithEvents lblProgram As System.Windows.Forms.Label
    Friend WithEvents errProv As System.Windows.Forms.ErrorProvider
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
