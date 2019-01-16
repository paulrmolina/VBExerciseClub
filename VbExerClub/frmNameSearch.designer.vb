<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNameSearch
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtLastNameSearch = New System.Windows.Forms.TextBox()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(19, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(165, 32)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtLastNameSearch
        '
        Me.txtLastNameSearch.Location = New System.Drawing.Point(19, 31)
        Me.txtLastNameSearch.Name = "txtLastNameSearch"
        Me.txtLastNameSearch.Size = New System.Drawing.Size(165, 20)
        Me.txtLastNameSearch.TabIndex = 23
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Location = New System.Drawing.Point(19, 110)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(165, 134)
        Me.lstNames.TabIndex = 24
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLastName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblLastName.Location = New System.Drawing.Point(36, 9)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(148, 17)
        Me.lblLastName.TabIndex = 25
        Me.lblLastName.Text = "Search by Last Name:"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(19, 250)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(165, 32)
        Me.btnSelect.TabIndex = 26
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(19, 288)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(165, 32)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmNameSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(203, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.txtLastNameSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "frmNameSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNameSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtLastNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
