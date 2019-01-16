Imports System.Data.SqlClient
Public Class CSecuritys
    Private _security As CSecurity

    Public Sub New()
        _security = New CSecurity
    End Sub

    Public Sub CreateNewUserID()
        Clear()
        '  _security.isNewUser = True

    End Sub
    Public ReadOnly Property CurrentObject() As CSecurity
        Get
            Return _security
        End Get
    End Property

    Public Sub Clear()
        _security = New CSecurity
    End Sub

    'Public Function Save() As Integer
    '    Return _security.Save
    'End Function

    Public Function GetMemberbyID(strEmpID As String, strUserID As String, strPassword As String) As CSecurity
        Dim params As ArrayList = New ArrayList
        Dim param1 As New SqlParameter("EmpID", strEmpID)
        params.Add(param1)
        Dim param2 As New SqlParameter("UserID", strUserID)
        params.Add(param2)
        Dim param3 As New SqlParameter("Password", strPassword)
        params.Add(param3)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetMemberbyID", params))
    End Function

    Public Function GetEmpByID(strID As String) As CSecurity

        Dim paramEmpID As New SqlParameter("UserID", strID)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetMemberID", paramEmpID))
        Return _security
    End Function

    Public Function FillObject(sqLDR As SqlDataReader) As CSecurity
        Using sqLDR
            If sqLDR.Read Then
                With _security
                    .EmpID = sqLDR.Item("EmpID") & ""
                    .UserID = sqLDR.Item("UserID") & ""
                    .Password = sqLDR.Item("Password") & ""
                End With
            End If
        End Using
        Return _security
    End Function

End Class
