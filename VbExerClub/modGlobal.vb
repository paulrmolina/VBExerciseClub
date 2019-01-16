Module modGlobal
    'contains all variables, constants, procedures, and functions that need to be
    'accessed in more than one form
    Public Const ACTION_NONE As Integer = 0
    Public Const ACTION_HOME As Integer = 1
    Public Const ACTION_MEMBER As Integer = 2
    Public Const ACTION_PROGRAM As Integer = 3
    Public Const ACTION_SHOP As Integer = 4
    Public Const ACTION_CONTACT As Integer = 5
    Public Const ACTION_HELP As Integer = 6
    Public Const ACTION_PAYMENT As Integer = 7  'ADD TO FINAL
    Public intNextAction As Integer
    Public strNameToSearchFor As String

    Public ReadOnly NULL_DATE As Date = New Date(1900, 1, 1)
    'build the database connection string - use the one appropriate for your version of VS/SQL
    'use this in in GLL 266
    Dim Path As String = Environment.CurrentDirectory
    Public gstrConn As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Path & "\VBExerClubDBU01.mdf;Integrated Security=True;Connect Timeout=30"
    'use this one at home, but change the path if needed
    ' Public gstrConn As String = "Data Source=(LocalDB)\ProjectsV12;AttachDbFilename='E:\COP 4005\Samples - Spring 2015\U01\VbExerClub\VBExerClubDB.mdf';Integrated Security=True;Connect Timeout=30"

    Public myDB As New CDB

End Module
