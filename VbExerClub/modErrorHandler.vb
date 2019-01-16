Module modErrorHandler



    Public Function validateTextBoxLength(ByVal obj As TextBox, ByVal errP As ErrorProvider) As Boolean

        'this function validates that a textbox is not empty.
        If obj.Text.Length = 0 Then 'no text in the textbox
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft) 'set error provider placement
            errP.SetError(obj, "You must enter a value here!")
            obj.Focus()
            Return False
        Else
            'turn off any prior error msg
            errP.SetError(obj, "")
            Return True
        End If

    End Function


    Public Function validateNameSearch(ByVal obj As TextBox, ByVal errP As ErrorProvider) As Boolean

        'this function validates that a textbox is not empty.
        If obj.Text.Length <= 2 Then 'no text in the textbox
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft) 'set error provider placement
            errP.SetError(obj, "Must enter at least 3 characters!")
            obj.Focus()
            Return False
        Else
            'turn off any prior error msg
            errP.SetError(obj, "")
            Return True
        End If

    End Function


    Public Function validateTextBoxNumeric(ByVal obj As TextBox, ByVal errP As ErrorProvider) As Boolean

        'this function validates that a textbox is not empty.
        If Not IsNumeric(obj.Text) Then 'not a numberic value
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft) 'set error provider placement
            errP.SetError(obj, "You must enter a numeric value here!")
            obj.Focus()
            Return False
        Else
            'turn off any prior error msg
            errP.SetError(obj, "")
            Return True
        End If

    End Function



    Public Function validateMaskTextBoxDate(ByVal obj As MaskedTextBox, ByVal errP As ErrorProvider) As Boolean

        'This function validates that a maskedtextbox has a valid date value
        If Not IsDate(obj.Text) Then 'not a valid date
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must enter a valid date here!")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If

    End Function



    Public Function validateMaskedTextBox(ByVal obj As MaskedTextBox, ByVal errP As ErrorProvider) As Boolean

        'This function validates that a selection has been made in the combo
        If Not obj.MaskCompleted Then 'no selection was made
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must complete the form!!")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If

    End Function



    Public Function validateCombo(ByVal obj As ComboBox, ByVal errP As ErrorProvider) As Boolean

        'This function validates that a selection has been made in the combo
        If obj.SelectedIndex = -1 Then 'no selection was made
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must make a selection here")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If

    End Function


    Public Function validatePayments(ByVal obj As ComboBox, ByVal errP As ErrorProvider) As Boolean

        'This function validates that a selection has been made in the combo
        If obj.SelectedIndex = -1 Then 'no selection was made
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleRight)
            errP.SetError(obj, "You must make a selection here")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If

    End Function

    Public Function validatePictureBoxPath(ByVal obj As PictureBox, ByVal errP As ErrorProvider) As Boolean

        'This function validates that a picture box has a selected path for a picture
        If obj.ImageLocation Is vbNullString Or obj.ImageLocation = "" Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must provide an image!")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If

    End Function



    Public Function validateJoinDate(ByVal obj As DateTimePicker, ByVal errP As ErrorProvider) As Boolean

        'ensure that the join date is today or earlier, not a future date
        If obj.Value <= Today Then 'this is not a future date
            Return True
        Else
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "Invalid Join Date!")
            obj.Focus()
            Return False
            Return False
        End If

    End Function


    Public Function validateID(strNextID As String, ByVal obj As TextBox, ByVal errP As ErrorProvider) As Boolean

        'this function validates that a textbox is not empty.
        If Not String.Equals(strNextID, obj.Text) Then 'invalid next ID for new member
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft) 'set error provider placement
            errP.SetError(obj, "The next valid ID is: " & strNextID)
            obj.Focus()
            Return False
        Else
            'turn off any prior error msg
            errP.SetError(obj, "")
            Return True
        End If

    End Function

End Module