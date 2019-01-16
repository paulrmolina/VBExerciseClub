Imports System.Data.SqlClient
Public Class CAudits
    Private _audit As CAudit

    Public Sub New()
        _audit = New CAudit
    End Sub

    Public Sub CreateNewUserID()
        Clear()
        '  _audit.isNewUser = True

    End Sub
    Public ReadOnly Property CurrentObject() As CAudit
        Get
            Return _audit
        End Get
    End Property

    Public Sub Clear()
        _audit = New CAudit
    End Sub

    Public Function Save() As Integer
        Return _audit.Save
    End Function

    Public Function GetMemberbyID(strEmpID As String, strAuditID As String, dtAccessTimeStamp As Date, blnsuccess As Boolean) As CAudit
        Dim params As ArrayList = New ArrayList
        Dim param1 As New SqlParameter("EmpID", strEmpID)
        params.Add(param1)

        Dim param3 As New SqlParameter("AccessTimeStamp", dtAccessTimeStamp)
        params.Add(param3)
        Dim param4 As New SqlParameter("success", blnsuccess)
        params.Add(param4)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_Audit", params))
    End Function

    Public Function GetEmpByID(strID As String) As CAudit

        Dim paramEmpID As New SqlParameter("UserID", strID)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetMemberID", paramEmpID))
        Return _audit
    End Function

    Public Function FillObject(sqLDR As SqlDataReader) As CAudit
        Using sqLDR
            If sqLDR.Read Then
                With _audit

                    .EmpID = sqLDR.Item("EMPID") & ""
                    .AccessTimeStamp = SafeDate(sqLDR.Item("AccessTimeStamp").ToString())
                    .Success = sqLDR.Item("Success") & ""
                End With
            End If
        End Using
        Return _audit
    End Function

End Class
