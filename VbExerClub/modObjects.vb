Module modObjects
    Public Sub ClearScreenControls(ByVal objContainer As Control)
        'This procedure will clear all controls on the form that is passed in as the argument.
        Dim obj As Control  'generic control object variable
        Dim strControlType As String

        For Each obj In objContainer.Controls
            strControlType = TypeName(obj)  'TypeNames returns the class names of the control
            Select Case strControlType
                Case "TextBox"
                    Dim cntrl As TextBox
                    cntrl = CType(obj, TextBox)
                    cntrl.Clear()
                Case "CheckBox"
                    Dim cntrl As CheckBox
                    cntrl = CType(obj, CheckBox)
                    cntrl.Checked = False
                Case "ComboBox"
                    Dim cntrl As ComboBox
                    cntrl = CType(obj, ComboBox)
                    cntrl.SelectedIndex = -1
                Case "CommandButton"
                    'no action needed
                Case "RadioButton"
                    Dim cntrl As RadioButton
                    cntrl = CType(obj, RadioButton)
                    cntrl.Checked = False
                Case "Frame"
                    'no action needed
                Case "ListBox"
                    Dim cntrl As ListBox
                    cntrl = CType(obj, ListBox)
                    cntrl.SelectedIndex = -1
                Case "DateTimePicker"
                    Dim cntrl As DateTimePicker
                    cntrl = CType(obj, DateTimePicker)
                    cntrl.Value = Today
                Case "MaskedTextBox"
                    Dim cntrl As MaskedTextBox
                    cntrl = CType(obj, MaskedTextBox)
                    cntrl.Clear()
                Case "ToolStripStatusLabel"
                    ' can't do it here
                Case "GroupBox"
                    Dim cntrl As GroupBox
                    cntrl = CType(obj, GroupBox)
                    'recursively call this routine to cycle through all controls in the groupbox container
                    ClearScreenControls(cntrl)
                Case Else   'for any control not specifically listed above
                    'do nothing, or add some error trapping code here
            End Select
        Next
    End Sub

    Public Function SafeDate(strIn As String) As DateTime
        If strIn Is Nothing Then
            Return NULL_DATE
        End If
        Dim dt As Date = NULL_DATE
        If Date.TryParse(strIn, dt) Then
            Return dt
        Else
            'Message about bad date?
            Return dt 'should return null date
        End If
    End Function
End Module
