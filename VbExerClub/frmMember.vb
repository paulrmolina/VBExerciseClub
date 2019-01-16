'This Form Has been modified heavily from its original state by {Paul Molina} to add several functionalities which include
'--Automatic MemberID generation for new Members
'--Member Photo Support
'--Member Last Name Search support
'Original Author: Prof. Patricia McDermott-Wells
'Modifier: Paul Molina

Imports System.Data.SqlClient
Public Class frmMember
    Private objMembers As CMembers
    Private objPrograms As CPrograms
    Private objReader As SqlDataReader
    Private blnClearing As Boolean
    Private blnNew As Boolean
    Private Search As frmNameSearch

    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objMembers = New CMembers
        objPrograms = New CPrograms
    End Sub



    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        'do nothing
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
        intNextAction = ACTION_PAYMENT
        Me.Hide()
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
        'load the phone search combo
        objReader = objMembers.GetMemberPhoneList
        cboPhone.Items.Clear()
        While objReader.Read 'rebuild the list to include current records
            cboPhone.Items.Add(objReader.Item("Phone"))
        End While
        objReader.Close()
        'load the Programs combo
        objReader = objPrograms.GetAllProgramIDs
        cboPrograms.Items.Clear()
        While objReader.Read 'rebuild the list to include current records
            cboPrograms.Items.Add(objReader.Item("ProgID"))
        End While
        objReader.Close()

    End Sub

    Private Sub frmMember_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadMemberCombos()
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        blnClearing = True
        ClearScreenControls(Me)
        tslStatus.Text = ""
        blnClearing = False
        errProv.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnError As Boolean
        Dim strNextID
        'first do form input data validation for proper data types and non-blank fields
        'NEW CODE
        errProv.Clear()
        objReader = objMembers.GetLastID
        objReader.Read()
        strNextID = objReader.Item("MBRID")
        strNextID = "M" & CInt(strNextID.Substring(1, strNextID.Length - 1) + 1)
        objReader.Close()

        'Checks validation for New Member's ID
        If chkNew.Checked Then
            If Not validateID(strNextID, txtID, errProv) Then 'Ensures proper name has been input
                blnError = True
            End If
        Else
            If Not validateTextBoxLength(txtID, errProv) Then 'Ensures proper address has been input
                blnError = True
            End If
        End If



        'Validation for New Member's Last Name
        If Not validateTextBoxLength(txtLName, errProv) Then 'Ensures proper address has been input
            blnError = True
        End If
        'Validation for Members's First Name
        If Not validateTextBoxLength(txtFName, errProv) Then 'Ensures proper address has been input
            blnError = True
        End If
        'Validates for Members's Address
        If Not validateTextBoxLength(txtAddress, errProv) Then 'Ensures proper address has been input
            blnError = True
        End If
        'Validates for Members's City
        If Not validateTextBoxLength(txtCity, errProv) Then 'Ensures proper address has been input
            blnError = True
        End If
        'Validates for Members's State
        If Not validateTextBoxLength(txtState, errProv) Then 'Ensures proper address has been input
            blnError = True
        End If
        'Validation for Members's Zip Code
        If Not validateMaskedTextBox(mskZip, errProv) Then
            blnError = True
        End If
        'Validation for Customer's Phone Number
        If Not validateMaskedTextBox(mskPhone, errProv) Then
            blnError = True
        End If
        'Validates correct Join Date (not in the future)
        If Not validateJoinDate(dtmJoined, errProv) Then
            blnError = True
        End If
        If Not validateTextBoxLength(txtEmail, errProv) Then 'Ensures proper address has been input
            blnError = True
        End If
        If Not validateCombo(cboPrograms, errProv) Then
            blnError = True
        End If
        If Not validatePictureBoxPath(picPhoto, errProv) Then
            blnError = True
        End If
        'NEW CODE
        If blnError Then
            Exit Sub
        End If
        'now load the CMember object with form data
        With objMembers.CurrentObject
            .MbrID = Trim(txtID.Text) 'trim strips off leading and trailing blanks
            .FName = txtFName.Text
            .LName = txtLName.Text
            .Address = txtAddress.Text
            .City = txtCity.Text
            .State = txtState.Text
            .Zip = mskZip.Text
            .Phone = mskPhone.Text
            .Email = txtEmail.Text
            .DateJoined = dtmJoined.Value.Date
            .ProgID = cboPrograms.SelectedItem.ToString
            'NEW CODE
            .PhotoPath = picPhoto.ImageLocation
        End With
        'now give the CMember object back to the business layer
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            intResult = objMembers.Save
            tslStatus.Text = "Member record saved"
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            If intResult = -1 Then 'id value is not unique
                MessageBox.Show("Member ID must be unique. Unable to save member record.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else ' some other error
                MessageBox.Show("Unable to save member record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Try
        blnClearing = True
        ClearScreenControls(grpSearch)
        blnClearing = False
    End Sub

    Private Sub LoadMemberData(aMember As CMember)
        If Not aMember Is Nothing Then
            With aMember
                txtID.Text = .MbrID
                txtLName.Text = .LName
                txtFName.Text = .FName
                txtAddress.Text = .Address
                txtCity.Text = .City
                txtState.Text = .State
                mskZip.Text = .Zip
                mskPhone.Text = .Phone
                dtmJoined.Value = .DateJoined
                txtEmail.Text = .Email
                cboPrograms.SelectedIndex = cboPrograms.FindStringExact(.ProgID)
                'NEW CODE
                picPhoto.ImageLocation = .PhotoPath
                txtID.ReadOnly = True
                dtmJoined.Enabled = False
            End With
        End If
    End Sub

    'NEW CODE
    Public Sub LoadMemberBySearch(strNameToSearchFor As String)
        LoadMemberFormByName(strNameToSearchFor)
    End Sub

    Private Sub LoadMemberFormByName(strFullName As String)
        Dim strNames() As String 'a string array
        'NEW CODE
        errProv.Clear()
        'NEW CODE
        'clear contents of member form first
        ClearScreenControls(grpMemberInfo)
        strNames = strFullName.Split(","c)
        objMembers.GetMemberByName(Trim(strNames(0)), Trim(strNames(1)))
        LoadMemberData(objMembers.CurrentObject)
    End Sub


    Private Sub LoadMemberFormByPhone(strPhone As String)
        'NEW CODE
        errProv.Clear()
        'NEW CODE
        ClearScreenControls(grpMemberInfo)
        objMembers.GetMemberByPhone(strPhone)
        LoadMemberData(objMembers.CurrentObject)
    End Sub


    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        If Not blnClearing Then
            blnNew = False
            blnClearing = True
            cboPhone.SelectedIndex = -1
            chkNew.Checked = False
            blnClearing = False
            LoadMemberFormByName(cboName.SelectedItem.ToString)
        End If
    End Sub


    Private Sub cboPhone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPhone.SelectedIndexChanged
        If Not blnClearing Then
            blnNew = False
            blnClearing = True
            cboName.SelectedIndex = -1
            chkNew.Checked = False
            blnClearing = False
            LoadMemberFormByPhone(cboPhone.SelectedItem.ToString)
        End If
    End Sub


    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If chkNew.CheckState = CheckState.Checked Then
            blnNew = True
            ClearScreenControls(grpMemberInfo)
                dtmJoined.Enabled = False
            'NEW ITEM (CLEAR PICTURE PATH)
            picPhoto.ImageLocation = vbNullString
            'NEW ITEM
            blnClearing = True
            cboName.SelectedIndex = -1
            cboPhone.SelectedIndex = -1
            Dim strNewID As String
            Try
                'NEW CODE
                'here is where you build the next member id value
                objReader = objMembers.GetLastID
                objReader.Read()
                strNewID = objReader.Item("MBRID")
                strNewID = "M" & CInt(strNewID.Substring(1, strNewID.Length - 1) + 1)
                txtID.Text = strNewID
                objReader.Close()
                'NEW CODE
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            blnClearing = False
        Else
            blnNew = False
        End If
    End Sub


    Private Sub grpSearch_Enter(sender As Object, e As EventArgs) Handles grpSearch.Enter

    End Sub

    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Search = New frmNameSearch
        Search.Hide()
        txtID.ReadOnly = True
        dtmJoined.Enabled = False
    End Sub

    'NEW CODE
    Private Sub btnNameSearch_Click(sender As Object, e As EventArgs) Handles btnNameSearch.Click
        frmNameSearch.txtLastNameSearch.Clear()
        frmNameSearch.lstNames.Items.Clear()
        frmNameSearch.ShowDialog()
        'Resets all of the values in the name search screen before searching
        If Not frmNameSearch.lstNames.SelectedIndex = -1 Then
            errProv.Clear()
            LoadMemberFormByName(frmNameSearch.lstNames.SelectedItem.ToString)
        End If
    End Sub
    'NEW CODE

    'NEW CODE
    'Looks for picture when browse is clicked
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'Handles open file dialogue and all relevant options
        Dim strPicLocation As String
        Dim intResult As Integer
        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.Filter = "JPEG Files(*.jpg)|*.jpg;*.jpeg;*.jpe;*.jfif" &
                         "Bitmap Files(*.bmp*)|*.bmp;*.dib|"
        ofdOpen.FilterIndex = 2
        intResult = ofdOpen.ShowDialog
        If intResult = DialogResult.Cancel Then 'user has clicked cancel button
            Exit Sub
        End If
        strPicLocation = ofdOpen.FileName

        Try
            InputPicture(strPicLocation)
        Catch ex As Exception
        End Try
    End Sub
    'NEW CODE

    'NEW CODE
    'Inputs the location of the picture once chosen.
    Private Sub InputPicture(strLocation As String)
        picPhoto.ImageLocation = strLocation
    End Sub
    'NEW CODE


End Class