Public Class frmProgram
    Private objPrograms As CPrograms
    Private blnClearing As Boolean

    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objPrograms = New CPrograms
    End Sub


    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbReturn_Click(sender As Object, e As EventArgs) Handles tsbReturn.Click
        intNextAction = ACTION_NONE
        Me.Hide()
    End Sub

    Private Sub tsbContact_Click(sender As Object, e As EventArgs) Handles tsbContact.Click
        intNextAction = ACTION_CONTACT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbShop_Click(sender As Object, e As EventArgs) Handles tsbShop.Click
        intNextAction = ACTION_SHOP
        Me.Hide()
    End Sub



    Private Sub tsbPayment_Click(sender As Object, e As EventArgs) Handles tsbPayment.Click
        intNextAction = ACTION_PAYMENT
        Me.Hide()
    End Sub

    Private Sub tsbProgram_Click(sender As Object, e As EventArgs) Handles tsbProgram.Click
        'nothing to do, we are already on the Program form
    End Sub

    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs)
        'We need to do this only because we are not putting our image in the Image property, but
        'instead in the BackgroundImage property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs)
        'We need to do this only because we are not putting our image in the Image property, but
        'instead in the BackgroundImage property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub LoadPrograms()
        Dim objReader As SqlClient.SqlDataReader
        lstPrograms.Items.Clear()
        objReader = objPrograms.GetAllProgramIDs()
        Do While objReader.Read
            lstPrograms.Items.Add(objReader.Item("ProgID"))
        Loop
        objReader.Close()
    End Sub

    Private Sub lstPrograms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrograms.SelectedIndexChanged
        'load textboxes when user selects a program ID from the listbox
        If blnClearing Then
            Exit Sub
        End If
        Try
            objPrograms.GetProgramByID(lstPrograms.SelectedItem.ToString)
            'now load the textboxes
            With objPrograms.CurrentObject
                txtProgID.Text = .ProgId
                txtDesc.Text = .ProgDesc
                txtMonthlyFee.Text = FormatNumber(.MonthFee, 2)
                txtAnnDiscount.Text = FormatNumber(.AnnualDiscount, 2)
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading program values", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProgram_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadPrograms()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        blnClearing = True
        ClearScreenControls(Me)
        tslStatus.Text = ""
        blnClearing = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'first do input data validation
        '----- add your data validation code here -----

        'if we get here, all the data is good
        With objPrograms.CurrentObject
            .ProgId = txtProgID.Text
            .ProgDesc = txtDesc.Text
            .MonthFee = CSng(txtMonthlyFee.Text)
            .AnnualDiscount = CSng(txtAnnDiscount.Text)
        End With
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            objPrograms.Save()
            Windows.Forms.Cursor.Current = Cursors.Default
            tslStatus.Text = "Record successfully saved"
        Catch ex As Exception
            MessageBox.Show("Unable to save program record: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class