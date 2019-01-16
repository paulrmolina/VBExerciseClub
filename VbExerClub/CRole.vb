Public Class CRole
    Private _rdID As String
    Private _rdName As String
   
    Public Sub New()
        _rdID = ""
        _rdName = ""
        
    End Sub

    Public Property RoleID() As String
        Get
            Return _rdID
        End Get
        Set(strVal As String)
            _rdID = strVal
        End Set
    End Property

    Public Property RoleName() As String
        Get
            Return _rdName
        End Get
        Set(strVal As String)
            _rdName = strVal
        End Set
    End Property


    'Public ReadOnly Property GetSaveParameters() As ArrayList
    '    Get
    '        Dim paramList As New ArrayList
    '        paramList.Add(New SqlClient.SqlParameter("RoleID", _rdID))
    '        paramList.Add(New SqlClient.SqlParameter("RoleName", _rdName))
    '        Return paramList
    '    End Get
    'End Property

    'Public Function Save() As Integer
    '    Return myDB.ExecSP("sp_Audit", GetSaveParameters)
    'End Function
End Class
