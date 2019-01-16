Imports System.Data.SqlClient
Public Class frmPayment
    Private objMembers As CMembers
    Private objPayments As CPayments
    Private objPrograms As CPrograms
    Private objReader As SqlDataReader
    Private blnClearing As Boolean
    Private blnNew As Boolean
    Private dblTotalAmount As Double

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objMembers = New CMembers
        objPayments = New CPayments
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

    Private Sub tsbProgram_Click(sender As Object, e As EventArgs) Handles tsbProgram.Click
        intNextAction = ACTION_PROGRAM
        Me.Hide()
    End Sub

    Private Sub tsbPayment_Click(sender As Object, e As EventArgs) Handles tsbPayment.Click
        'Do Nothing
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

    Private Sub LoadMemberCombos()
        'load the member name search combo
        objReader = objMembers.GetMemberList
        cboName.Items.Clear()
        While objReader.Read 'rebuild the list to include current records
            cboName.Items.Add(objReader.Item("LName") & ", " & objReader.Item("Fname"))
        End While
        objReader.Close()
    End Sub

    Private Sub loadPaymentGrid()
        'load the member name search combo
        objReader = objMembers.GetMemberList
        cboName.Items.Clear()
        While objReader.Read 'rebuild the list to include current records
            cboName.Items.Add(objReader.Item("LName") & ", " & objReader.Item("Fname"))
        End While
        objReader.Close()
    End Sub

    Private Sub LoadDataGridPayments(strFullName As String)
        Dim strNames() As String 'a string array
        'clear contents of member form first
        'ClearScreenControls(grpMemberInfo)
        strNames = strFullName.Split(","c)
        objReader = objPayments.GetPaymentsByMbrID(objMembers.GetMemberByName(Trim(strNames(0)), Trim(strNames(1))).MbrID)
        While objReader.Read 'rebuild the list to include current records
            dgvPayments.Rows.Add(New String() {objReader.Item("PMTID"), objReader.Item("MBRID"), objReader.Item("PROGID"), objReader.Item("DATEDUE"), objReader.Item("DATEPAID"), objReader.Item("AMTPAID")})
        End While
        objReader.Close()
    End Sub


    Private Sub frmPayment_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadMemberCombos()

        For index As Integer = 1 To 12
            cboPeriod.Items.Add(index)
        Next

        RefreshForm()

        dgvPayments.Rows.Clear()
        lblNextPaymentDueDate.Text = "NO PAYMENTS"
        lblProgram.Text = "_______________"
        cboPeriod.SelectedIndex = -1
        lblPaymentAmount.Text = "($0.00)"
        lblEffectiveUntil.Text = "___________"
    End Sub

    Private Sub RefreshForm()
        Dim s(2) As String
        Dim foundaPayment As Boolean = False

        lblEffectiveDate.Text = Date.Today
        s(1) = "0001"
        objReader = objPayments.GetPaymentList
        While objReader.Read
            s = objReader.Item("PMTID").Split("P"c)
            foundaPayment = True
        End While
        objReader.Close()

        If foundaPayment = True Then
            s(1) = s(1) + 1
        End If

        Dim i As Integer
        i = s(1)
        txtPaymentID.Text = String.Format("P{0:D4}", i)



        If dgvPayments.RowCount < 2 Then
            lblNextPaymentDueDate.Text = "NO PAYMENTS"
        Else
            lblNextPaymentDueDate.Text = dgvPayments.Rows(dgvPayments.RowCount - 2).Cells(3).Value
        End If
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        Dim strNames() As String
        If Not blnClearing Then
            blnNew = False
            blnClearing = True
            dgvPayments.Rows.Clear()
            cboPeriod.SelectedIndex = -1
            lblPaymentAmount.Text = "$0.00"
            blnClearing = False
            LoadDataGridPayments(cboName.SelectedItem.ToString)
            strNames = cboName.SelectedItem.ToString.Split(","c)
            objMembers.GetMemberByName(Trim(strNames(0)), Trim(strNames(1)))
            lblProgram.Text = objMembers.CurrentObject.ProgID
            RefreshForm()
            lblEffectiveUntil.Text = "___________"
        End If
    End Sub



    Private Sub cboPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriod.SelectedIndexChanged
        objPrograms.GetProgramByID(lblProgram.Text)

        If cboPeriod.SelectedIndex <> -1 Then
            If cboPeriod.SelectedItem.ToString = "12" Then
                dblTotalAmount = (cboPeriod.SelectedItem.ToString * objPrograms.CurrentObject.MonthFee)
                dblTotalAmount = dblTotalAmount - (dblTotalAmount * objPrograms.CurrentObject.AnnualDiscount)
            Else
                dblTotalAmount = (cboPeriod.SelectedItem.ToString * objPrograms.CurrentObject.MonthFee)
            End If
            lblPaymentAmount.Text = FormatCurrency(dblTotalAmount, , , TriState.True, TriState.True)
            Dim dueDate As DateTime = Today.AddMonths(cboPeriod.SelectedItem.ToString)
            lblEffectiveUntil.Text = dueDate

        End If
    End Sub

    Private Sub btnProcessPayment_Click(sender As Object, e As EventArgs) Handles btnProcessPayment.Click
        Dim intResult As Integer
        Dim i As Integer
        Dim blnError As Boolean

        If Not validatePayments(cboPeriod, errProv) Then
            blnError = True
        End If
        If Not validateCombo(cboName, errProv) Then
            blnError = True
        End If
        'NEW CODE
        If blnError Then
            Exit Sub
        End If


        For counter As Integer = 1 To cboPeriod.SelectedItem.ToString
            Dim s(2) As String

            With objPayments.CurrentObject
                .PmtID = Trim(txtPaymentID.Text) 'trim strips off leading and trailing blanks
                .MbrID = objMembers.CurrentObject.MbrID
                .ProgId = lblProgram.Text
                .DateDue = Today.AddMonths(counter)
                .DatePaid = Today.Date
                .AmtPaid = FormatCurrency(objPrograms.CurrentObject.MonthFee, , , TriState.True, TriState.True)
            End With

            Try
                Windows.Forms.Cursor.Current = Cursors.WaitCursor
                intResult = objPayments.Save
                'tslStatus.Text = "Member record saved"
                Windows.Forms.Cursor.Current = Cursors.Default
            Catch ex As Exception
                If intResult = -1 Then 'id value is not unique
                    MessageBox.Show("Member ID must be unique. Unable to save member record.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else ' some other error
                    MessageBox.Show("Unable to save member record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Try

            s = Trim(txtPaymentID.Text).Split("P"c)
            s(1) = s(1) + 1

            i = s(1)
            txtPaymentID.Text = String.Format("P{0:D4}", i)

        Next







        dgvPayments.Rows.Clear()
        cboPeriod.SelectedIndex = -1
        lblPaymentAmount.Text = "$0.00"
        LoadDataGridPayments(cboName.SelectedItem.ToString)
        RefreshForm()
    End Sub

    Private Sub gboPayment_Enter(sender As Object, e As EventArgs) Handles gboPayment.Enter

    End Sub
End Class