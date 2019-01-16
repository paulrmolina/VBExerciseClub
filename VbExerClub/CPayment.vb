'ADD TO FINAL PROJECT
Public Class CPayment
    'class instance variables
    Private _mPmtID As String
    Private _mMbrID As String
    Private _mProgID As String
    Private _mDateDue As Date
    Private _mDatePaid As Date
    Private _mAmtPaid As Single
    Private _isNewPayment As Boolean

    'CONSTRUCTOR
    Public Sub New()
        _mPmtID = ""
        _mMbrID = ""
        _mProgID = ""
        _mDateDue = New Date(Now.Year, Now.Month, Now.Day)
        _mDatePaid = New Date(Now.Year, Now.Month, Now.Day)
        _mAmtPaid = 0
    End Sub

    'PROPERTY ACCESSORS AND MUTATORS
    Public Property PmtID() As String
        Get
            Return _mPmtID
        End Get
        Set(strVal As String)
            _mPmtID = strVal
        End Set
    End Property

    Public Property MbrID() As String
        Get
            Return _mMbrID
        End Get
        Set(strVal As String)
            _mMbrID = strVal
        End Set
    End Property

    Public Property ProgId() As String
        Get
            Return _mProgId
        End Get
        Set(strVal As String)
            _mProgId = strVal
        End Set
    End Property

    Public Property DateDue() As String
        Get
            Return _mDateDue
        End Get
        Set(dtmVal As String)
            _mDateDue = dtmVal
        End Set
    End Property

    Public Property DatePaid() As String
        Get
            Return _mDatePaid
        End Get
        Set(dtmVal As String)
            _mDatePaid = dtmVal
        End Set
    End Property

    Public Property AmtPaid() As String
        Get
            Return _mAmtPaid
        End Get
        Set(sngVal As String)
            _mAmtPaid = sngVal
        End Set
    End Property

    Public Property isNewPayment() As String
        Get
            Return _isNewPayment
        End Get
        Set(blnVal As String)
            _isNewPayment = blnVal
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim paramList As New ArrayList
            paramList.Add(New SqlClient.SqlParameter("PmtID", _mPmtID))
            paramList.Add(New SqlClient.SqlParameter("MbrID", _mMbrID))
            paramList.Add(New SqlClient.SqlParameter("ProgID", _mProgID))
            paramList.Add(New SqlClient.SqlParameter("DateDue", _mDateDue))
            paramList.Add(New SqlClient.SqlParameter("DatePaid", _mDatePaid))
            paramList.Add(New SqlClient.SqlParameter("AmtPaid", _mAmtPaid))
            Return paramList
        End Get
    End Property


    Public Function Save() As Integer
        'if not a new member or it is new and is unique, then do the save (update or insert)
        Return myDB.ExecSP("sp_SavePayment", GetSaveParameters)
    End Function

End Class
