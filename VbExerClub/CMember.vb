Public Class CMember
    'represents a single record in the Members table
    Private _mstrMbrID As String
    Private _mstrLName As String
    Private _mstrFName As String
    Private _mstrAddress As String
    Private _mstrCity As String
    Private _mstrState As String
    Private _mstrZip As String
    Private _mstrPhone As String
    Private _mdtmDateJoined As Date
    Private _mstrEmail As String
    Private _mstrProgID As String
    Private _mstrPhotoPath As String
    Private _isNewMember As Boolean

    'constructor
    Public Sub New()
        'initialize class instance variables
        _mstrMbrID = ""
        'do the rest here
        'date values are initialized to 1/1/0001 by default, so we set it to today instead
        _mdtmDateJoined = New Date(Now.Year, Now.Month, Now.Day)
    End Sub

    Public Property MbrID() As String
        Get
            Return _mstrMbrID
        End Get
        Set(strVal As String)
            _mstrMbrID = strVal
        End Set
    End Property

    Public Property LName() As String
        Get
            Return _mstrLName
        End Get
        Set(strVal As String)
            _mstrLName = strVal
        End Set
    End Property
    Public Property FName() As String
        Get
            Return _mstrFName
        End Get
        Set(strVal As String)
            _mstrFName = strVal
        End Set
    End Property
    Public Property Address() As String
        Get
            Return _mstrAddress
        End Get
        Set(strVal As String)
            _mstrAddress = strVal
        End Set
    End Property
    Public Property City() As String
        Get
            Return _mstrCity
        End Get
        Set(strVal As String)
            _mstrCity = strVal
        End Set
    End Property
    Public Property State() As String
        Get
            Return _mstrState
        End Get
        Set(strVal As String)
            _mstrState = strVal
        End Set
    End Property
    Public Property Zip() As String
        Get
            Return _mstrZip
        End Get
        Set(strVal As String)
            _mstrZip = strVal
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return _mstrPhone
        End Get
        Set(strVal As String)
            _mstrPhone = strVal
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _mstrEmail
        End Get
        Set(strVal As String)
            _mstrEmail = strVal
        End Set
    End Property
    Public Property ProgID() As String
        Get
            Return _mstrProgID
        End Get
        Set(strVal As String)
            _mstrProgID = strVal
        End Set
    End Property

    'NEW CODE
    Public Property PhotoPath() As String
        Get
            Return _mstrPhotoPath
        End Get
        Set(strVal As String)
            _mstrPhotoPath = strVal
        End Set
    End Property

    Public Property DateJoined() As Date
        Get
            Return _mdtmDateJoined
        End Get
        Set(dtmVal As Date)
            _mdtmDateJoined = dtmVal
        End Set
    End Property

    Public Property IsNewMember() As Boolean
        Get
            Return _isNewMember
        End Get
        Set(blnVal As Boolean)
            _isNewMember = blnVal
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim paramList As New ArrayList
            paramList.Add(New SqlClient.SqlParameter("mbrID", _mstrMbrID))
            paramList.Add(New SqlClient.SqlParameter("lName", _mstrLName))
            paramList.Add(New SqlClient.SqlParameter("fName", _mstrFName))
            paramList.Add(New SqlClient.SqlParameter("address", _mstrAddress))
            paramList.Add(New SqlClient.SqlParameter("city", _mstrCity))
            paramList.Add(New SqlClient.SqlParameter("state", _mstrState))
            paramList.Add(New SqlClient.SqlParameter("zip", _mstrZip))
            paramList.Add(New SqlClient.SqlParameter("phone", _mstrPhone))
            paramList.Add(New SqlClient.SqlParameter("datejoined", _mdtmDateJoined))
            paramList.Add(New SqlClient.SqlParameter("email", _mstrEmail))
            paramList.Add(New SqlClient.SqlParameter("progid", _mstrProgID))
            'NEW CODE
            paramList.Add(New SqlClient.SqlParameter("photopath", _mstrPhotoPath))
            'NEW CODE
            Return paramList
        End Get
    End Property
    Public Function Save() As Integer
        'return -1 if the ID already exists and we can't create a new record
        If IsNewMember Then
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckMemberIDExists", _
                                                             New SqlClient.SqlParameter("MbrID", _mstrMbrID))
            If Not strRes = 0 Then
                Return -1 'ID NOT unique!!
            End If
        End If
        'if not a new member or it is new and is unique, then do the save (update or insert)
        Return myDB.ExecSP("sp_SaveMember", GetSaveParameters)
    End Function
End Class
