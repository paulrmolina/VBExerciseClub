Imports System.Data.SqlClient
Public Class frmLogin
    Private objSecurity As CSecuritys
    Private objAudit As CAudits
    Private objRole As CRoles
    Private objReader As SqlDataReader
    Private blnNew As Boolean
    Private i As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objSecurity = New CSecuritys
        objAudit = New CAudits
        objRole = New CRoles
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim intResult As Integer
        Try
            If txtusername.Text = vbNullString Or txtpassword.Text = vbNullString Then
                MessageBox.Show("Must supply both Username AND Password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                blnNew = False

                With objAudit.CurrentObject

                    .EmpID = "E0000"
                    .AccessTimeStamp = FormatDateTime(Now)
                    .Success = blnNew
                End With
                LoadAuditbyID(objAudit.Save())
            ElseIf objSecurity.GetEmpByID(txtusername.Text).UserID = txtusername.Text And objSecurity.GetEmpByID(txtpassword.Text).Password = txtpassword.Text Then
                blnNew = True
                With objAudit.CurrentObject
                    .EmpID = objSecurity.CurrentObject.EmpID
                    .AccessTimeStamp = FormatDateTime(Now)
                    .Success = blnNew
                End With
                LoadAuditbyID(objAudit.Save())
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong Username or password")
                blnNew = False
                With objAudit.CurrentObject

                    .EmpID = "E0000"
                    .AccessTimeStamp = FormatDateTime(Now)
                    .Success = blnNew
                End With
                LoadAuditbyID(objAudit.Save())
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If intResult = -1 Then
                MessageBox.Show("Unable to save member record.", "database error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Try
    End Sub
    Private Sub LoadAuditData(aAudit As CAudit)
        Dim time As Date
        time = FormatDateTime(Now)
        If Not aAudit Is Nothing Then
            With aAudit
                .EmpID = txtusername.Text

                .Success = blnNew
                .AccessTimeStamp = time
            End With
        End If
    End Sub
    Private Sub LoadAuditbyID(strEmpID As String)
        LoadAuditData(objAudit.CurrentObject)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class