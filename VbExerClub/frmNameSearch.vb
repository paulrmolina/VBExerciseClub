'Affirmation of Authorship:
'Name: Paul Molina
'Date: 04/25/2015
'I affirm that this program was created by me. It is solely my work and does not include any work done by anyone else.

Imports System.Data.SqlClient
Public Class frmNameSearch
    Private objMembers As CMembers
    Private objReader As SqlDataReader


    Private Sub lblLastName_Click(sender As Object, e As EventArgs) Handles lblLastName.Click

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadLastNameSearch(txtLastNameSearch.Text)
    End Sub

    Private Sub LoadLastNameSearch(strNameToSearchFor As String)
        Dim blnError As Boolean

        If Not validateNameSearch(txtLastNameSearch, frmMember.errProv) Then
            blnError = True
        End If

        If blnError Then
            Exit Sub
        End If
        'load the member name search combo
        objReader = objMembers.GetSearchedLastName(strNameToSearchFor)
        lstNames.Items.Clear()
        While objReader.Read 'rebuild the list to include current records
            lstNames.Items.Add(objReader.Item("LName") & ", " & objReader.Item("Fname"))
        End While
        objReader.Close()
    End Sub

    Private Sub frmNameSearch_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMembers = New CMembers
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Clears all relevant fields once cancelled for next search
        lstNames.ClearSelected()
        lstNames.Items.Clear()
        Me.Hide()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        'Error validation for selected name
        If lstNames.SelectedIndex = -1 And Not lstNames.Items.Count = 0 Then
            frmMember.errProv.SetIconAlignment(lstNames, ErrorIconAlignment.TopLeft)
            frmMember.errProv.SetError(lstNames, "You must choose a member from the List!")
        Else
            Me.Hide()
        End If
    End Sub
End Class