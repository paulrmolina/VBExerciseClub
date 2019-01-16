Imports System.Data.SqlClient
Public Class CMembers
    'This class represents the Members table and the associated business rules
    Private _Member As CMember
    'constructor
    Public Sub New()
        'instantiate the CMember object
        _Member = New CMember
    End Sub

    Public ReadOnly Property CurrentObject() As CMember
        Get
            Return _Member
        End Get
    End Property

    Public Function IsValidJoinDate(dtmDate As Date) As Boolean
        'ensure that the join date is today or earlier, not a future date
        If dtmDate <= Today Then 'this is not a future date
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Clear()
        _Member = New CMember
    End Sub

    Public Sub CreateNewMember() 'call me when you are clearing the screen to create a new member
        Clear()
        _Member.IsNewMember = True
    End Sub

    Public Function Save() As Integer
        Return _Member.Save
    End Function

    Public Function GetMemberList() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetMemberList")
    End Function
    'NEW CODE'
    Public Function GetSearchedLastName(strSearchedLastName As String) As SqlDataReader
        Dim param As New SqlParameter("lname", strSearchedLastName)
        Return myDB.GetDataReaderBySP("dbo.sp_SearchByLastName", param)
    End Function
    'NEW CODE'

    Public Function GetMemberPhoneList() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetMemberPhoneList")
    End Function

    Public Function GetMemberByName(strLName As String, strFName As String) As CMember
        Dim params As New ArrayList
        Dim param1 As New SqlParameter("lname", strLName)
        params.Add(param1)
        Dim param2 As New SqlParameter("fname", strFName)
        params.Add(param2)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetMemberByName", params))
        Return _Member
    End Function

    Public Function GetMemberByPhone(strPhone As String) As CMember
        Dim aParam As New SqlParameter("phone", strPhone)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetMemberByPhone", aParam))
        Return _Member
    End Function
    'NEW CODE'
    Public Function GetLastID() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetLastID")
    End Function
    'NEW CODE


    'Public Function GetLastMemberID() As String

    'End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CMember
        Using sqlDR
            If sqlDR.Read Then
                With _Member
                    .MbrID = sqlDR.Item("MbrID") & ""
                    .LName = sqlDR.Item("LName") & ""
                    .FName = sqlDR.Item("FName") & ""
                    .Address = sqlDR.Item("Address") & ""
                    .City = sqlDR.Item("City") & ""
                    .State = sqlDR.Item("State") & ""
                    .Zip = sqlDR.Item("Zip") & ""
                    .Phone = sqlDR.Item("Phone") & ""
                    .DateJoined = SafeDate(sqlDR.Item("DateJoined").ToString())
                    .Email = sqlDR.Item("Email") & ""
                    .ProgID = sqlDR.Item("ProgID") & ""
                    'NEW CODE
                    .PhotoPath = sqlDR.Item("PhotoPath") & ""
                    'NEW CODE'
                End With
            Else
                'NEW CODE'
                MessageBox.Show("Error Filling Member Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'NEW CODE' 
            End If
        End Using
        Return _Member
    End Function

End Class
