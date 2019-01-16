Imports System.Data.SqlClient

Public Class CPayments
    'this class represents the program payment tables
    Private _Payment As CPayment

    'constructor
    Public Sub New()
        _Payment = New CPayment
    End Sub

    Public ReadOnly Property CurrentObject As CPayment
        Get
            Return _Payment
        End Get
    End Property

    Public Sub Clear()
        _Payment = New CPayment
    End Sub

    Public Sub CreateNewPayment()
        Clear()
        _Payment.isNewPayment = True

    End Sub

    Public Function Save() As Integer
        Return _Payment.Save

    End Function

    Public Function GetPaymentsByMbrID(strID As String) As SqlDataReader

        Dim paramMbrID As New SqlParameter("mbrID", strID)
        Return myDB.GetDataReaderBySP("dbo.sp_GetPaymentByID", paramMbrID)
    End Function


    Public Function GetPaymentList() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetPaymentList")
    End Function


    Public Function FillObject(sqlDR As SqlDataReader) As CPayment
        Using sqlDR
            If sqlDR.Read Then
                With _Payment
                    .PmtID = sqlDR.Item("PmtID") & ""
                    .MbrID = sqlDR.Item("MbrId") & ""
                    .ProgId = sqlDR.Item("ProgID") & ""
                    .DateDue = SafeDate(sqlDR.Item("DateDue").ToString())
                    .DatePaid = SafeDate(sqlDR.Item("DatePaid").ToString())
                    .AmtPaid = SafeDate(sqlDR.Item("AmtPaid").ToString())

                End With
            Else
                'failed for some reason
            End If
        End Using
        Return _Payment
    End Function

End Class
