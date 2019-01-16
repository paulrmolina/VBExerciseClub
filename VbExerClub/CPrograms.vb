Imports System.Data.SqlClient
Public Class CPrograms
    Private _Program As CProgram
    'constructor
    Public Sub New()
        _Program = New CProgram
    End Sub

    Public ReadOnly Property CurrentObject() As CProgram
        Get
            Return _Program
        End Get
    End Property

    Public Sub Clear()
        _Program = New CProgram
    End Sub

    Public Sub CreateNewProgram() 'call me when you're clearing the screen to add a new program
        Clear()
        _Program.IsNewProgram = True
    End Sub

    Public Function Save() As Integer
        Return _Program.Save
    End Function

    Public Function GetAllProgramIDs() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllProgramIDs")
    End Function

    Public Function GetProgramByDesc(strDesc As String) As CProgram
        Dim aParam As New SqlParameter("desc", strDesc)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetProgramByDesc", aParam))
        Return _Program
    End Function

    Public Function GetProgramByID(strID As String) As CProgram
        Dim aParam As New SqlParameter("progid", strID)
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetProgramByID", aParam))
        Return _Program
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CProgram
        Using sqlDR
            If sqlDR.Read Then 'we have data
                With _Program
                    .ProgId = sqlDR.Item("ProgID") 'use database table field name in quotes
                    .ProgDesc = sqlDR.Item("ProgDesc")
                    .MonthFee = sqlDR.Item("MonthFee")
                    .AnnualDiscount = sqlDR.Item("AnnualDiscount")
                End With
            End If
        End Using
        Return _Program
    End Function
End Class
