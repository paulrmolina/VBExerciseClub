Imports System.Data.SqlClient
Public Class CRoles
    Private _role As CRole

    Public Sub New()
        _role = New CRole
    End Sub

    Public Sub CreateNewUserID()
        Clear()
        '  _role.isNewUser = True

    End Sub
    Public ReadOnly Property CurrentObject() As CRole
        Get
            Return _role
        End Get
    End Property

    Public Sub Clear()
        _role = New CRole
    End Sub

    'Public Function Save() As Integer
    '    Return _role.Save
    'End Function

    Public Function GetRoleID(strrdID As String, strrdName As String) As CRole
        Dim params As ArrayList
        Dim param1 As New SqlParameter("ROLEID", strrdID)
        params.Add(param1)
        Dim param2 As New SqlParameter("ROLENAME", strrdName)
        params.Add(param2)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_role", params))
        Return _role
    End Function
    Public Function GetRoleByID(strID As String) As CRole

        Dim paramEmpID As New SqlParameter("EmpID", strID)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetMemberID", paramEmpID))
        Return _role
    End Function

    Public Function FillObject(sqLDR As SqlDataReader) As CRole
        Using sqLDR
            If sqLDR.Read Then
                With _role
                    .RoleID = sqLDR.Item("ROLEID") & ""
                    .RoleName = sqLDR.Item("ROLENAME") & ""
                End With
            End If
        End Using
        Return _role
    End Function

End Class
