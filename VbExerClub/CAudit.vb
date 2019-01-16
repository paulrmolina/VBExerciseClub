Public Class CAudit
    Private _Audit As String
    Private _EmpID As String
    Private _accesstimestamp As Date
    Private _success As Boolean

    Public Sub New()
        _EmpID = ""
        _Audit = ""


    End Sub

    Public Property EmpID() As String
        Get
            Return _EmpID
        End Get
        Set(strVal As String)
            _EmpID = strVal
        End Set
    End Property


    Public Property AccessTimeStamp() As Date
        Get
            Return _accesstimestamp
        End Get
        Set(strVal As Date)
            _accesstimestamp = strVal
        End Set
    End Property

    Public Property Success() As Boolean
        Get
            Return _success
        End Get
        Set(blnVal As Boolean)
            _success = blnVal
        End Set
    End Property


    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim i As Integer
            Dim paramList As New ArrayList

            paramList.Add(New SqlClient.SqlParameter("EmpID", _EmpID))
            paramList.Add(New SqlClient.SqlParameter("AccessTimeStamp", _accesstimestamp))
            paramList.Add(New SqlClient.SqlParameter("success", _success))
            For i = 0 To paramList.Count
                i += 1
                _Audit = i
            Next
            Return paramList
        End Get
    End Property

    Public Function Save() As Integer
        Return myDB.ExecSP("sp_Audit", GetSaveParameters)
    End Function

End Class
