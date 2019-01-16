
Public Class CSecurity
    Private _EmpID As String
    Private _userID As String
    Private _password As String
    ' Private _isNewEmployee As Boolean
    Public Sub New()
        _EmpID = ""
        _userID = ""
        _password = ""
    End Sub

    Public Property EmpID() As String
        Get
            Return _EmpID
        End Get
        Set(strVal As String)
            _EmpID = strVal
        End Set
    End Property

    Public Property UserID() As String
        Get
            Return _userID
        End Get
        Set(strVal As String)
            _userID = strVal
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(strVal As String)
            _password = strVal
        End Set
    End Property

    'Public Property isNewUser() As String
    '    Get
    '        Return _isNewEmployee
    '    End Get
    '    Set(blnVal As String)
    '        _isNewEmployee = blnVal
    '    End Set
    'End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim paramList As New ArrayList
            paramList.Add(New SqlClient.SqlParameter("EmpID", _EmpID))
            paramList.Add(New SqlClient.SqlParameter("UserID", _userID))
            paramList.Add(New SqlClient.SqlParameter("Password", _password))
            Return paramList
        End Get
    End Property

    Public Function Save() As Integer
        'If _isNewEmployee Then

        '    Dim strRes As String = myDB.GetSingleValueFromSP("sp_Audit", New SqlClient.SqlParameter("EmpID", _EmpID))
        '    If strRes = 0 Then
        '        Return -1
        '    End If
        'End If
        Return myDB.ExecSP("sp_SaveMember", GetSaveParameters)
    End Function

End Class
