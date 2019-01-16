Public Class frmMain
    Private MemberInfo As frmMember
    Private LoginInfo As frmLogin
    Private ProgramInfo As frmProgram
    'ADD TO FINAL PROJECT
    Private PaymentInfo As frmPayment

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        Me.Hide() ' hide main form
        MemberInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub


    Private Sub PerformNextAction()
        Select Case intNextAction
            Case ACTION_HOME
            Case ACTION_MEMBER
                tsbMember.PerformClick()
            Case ACTION_PROGRAM
                tsbProgram.PerformClick()
            Case ACTION_SHOP
            Case ACTION_CONTACT
            Case ACTION_HELP
            Case ACTION_PAYMENT
                tsbPayment.PerformClick()

            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub tsbProgram_Click(sender As Object, e As EventArgs) Handles tsbProgram.Click
        Me.Hide() ' hide main form
        ProgramInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        EndProgram()
    End Sub

    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbContact.MouseEnter, _
        tsbExit.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbMember.MouseEnter, tsbProgram.MouseEnter, tsbShop.MouseEnter
        'We need to do this only because we are not putting our image in the Image property, but
        'instead in the BackgroundImage property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbContact.MouseLeave, _
        tsbExit.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbMember.MouseLeave, tsbProgram.MouseLeave, tsbShop.MouseLeave
        'We need to do this only because we are not putting our image in the Image property, but
        'instead in the BackgroundImage property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'initialize everything here
        MemberInfo = New frmMember
        ProgramInfo = New frmProgram
        PaymentInfo = New frmPayment
        LoginInfo = New frmLogin
        Try
            myDB.OpenDB()
            'loginform()
        Catch ex As Exception
            MessageBox.Show("Unable to open database. Connection string=" & gstrConn & " Program will end.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EndProgram()
        End Try
    End Sub

    Private Sub EndProgram()
        'close every form except main
        Dim f As Form
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        For Each f In Application.OpenForms
            If f.Name <> Me.Name Then
                If Not f Is Nothing Then
                    f.Close()
                End If
            End If
        Next
        'close database connection
        If Not myDB.sqlConn Is Nothing Then
            myDB.sqlConn.Close()
            myDB.sqlConn.Dispose()
        End If
        Windows.Forms.Cursor.Current = Cursors.Default
        'end the program
        End
    End Sub

    'ADD TO FINAL MAIN FORM
    Private Sub tsbPayment_Click(sender As Object, e As EventArgs) Handles tsbPayment.Click
        'LOAD THE PAYMENTS FORM
        Me.Hide() ' hide main form
        PaymentInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub
    Private Sub loginform()
        Me.Hide()
        LoginInfo.ShowDialog()
    End Sub

End Class
