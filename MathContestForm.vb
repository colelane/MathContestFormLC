﻿Public Class MathContestForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim goodData As Boolean

        goodData = EvaluateTextboxes()
        If goodData = False Then
            Exit Sub
        End If
        EvaluateAnswer()

    End Sub

    Function EvaluateTextboxes()
        Dim eval As Boolean
        Dim age As Integer
        Dim grade As Integer
        ArrowBox1.Visible = False
        ArrowBox2.Visible = False
        ArrowBox3.Visible = False
        ArrowBox4.Visible = False
        ArrowBox5.Visible = False
        ArrowBox6.Visible = False
        ArrowBox7.Visible = False
        ArrowBox8.Visible = False

        If NameTextBox.Text = Nothing Then
            ActiveControl = NameTextBox
            ArrowBox1.Image = My.Resources.BigRedArrow
            ArrowBox1.Visible = True
            ArrowBox1.BringToFront()
            MsgBox("Sir. Enter a name.")
            Exit Function
        ElseIf NameTextBox.Text > Nothing Then
            ArrowBox1.Visible = False
        End If

        If AgeTextBox.Text = Nothing Then
            ActiveControl = AgeTextBox
            ArrowBox2.Image = My.Resources.BigRedArrow
            ArrowBox2.Visible = True
            ArrowBox2.BringToFront()
            MsgBox("Sir. Enter an age.")
            Exit Function
        ElseIf AgeTextBox.Text > Nothing Then
            Try
                age = CInt(AgeTextBox.Text)
            Catch ex As Exception
                ArrowBox2.Image = My.Resources.BigRedArrow
                ArrowBox2.Visible = True
                ArrowBox2.BringToFront()
                MsgBox("Age must be a number")
                ActiveControl = AgeTextBox
                Exit Function
            End Try
            If CInt(AgeTextBox.Text) > 11 Or CInt(AgeTextBox.Text) < 7 Then
                MsgBox("Age must be between 7 and 11")
                ArrowBox2.Image = My.Resources.BigRedArrow
                ArrowBox2.Visible = True
                ArrowBox2.BringToFront()
                Exit Function
            End If
            ArrowBox2.Visible = False
        End If

        If GradeTextBox.Text = Nothing Then
            ActiveControl = GradeTextBox
            ArrowBox3.Image = My.Resources.BigRedArrow
            ArrowBox3.Visible = True
            ArrowBox3.BringToFront()
            MsgBox("Sir. Enter a Grade.")
            Exit Function
        ElseIf GradeTextBox.Text > Nothing Then
            Try
                grade = CInt(GradeTextBox.Text)
            Catch ex As Exception
                ArrowBox3.Image = My.Resources.BigRedArrow
                ArrowBox3.Visible = True
                ArrowBox3.BringToFront()
                MsgBox("Grade must be a number")
                ActiveControl = GradeTextBox
                Exit Function
            End Try
            If CInt(GradeTextBox.Text) > 4 Or CInt(GradeTextBox.Text) < 1 Then
                MsgBox("Grade must be between 1 and 4")
                ArrowBox3.Image = My.Resources.BigRedArrow
                ArrowBox3.Visible = True
                ArrowBox3.BringToFront()
                Exit Function
            End If
            ArrowBox3.Visible = False
        End If

        If AddRadioButton.Checked = False And SubtractRadioButton.Checked = False And MultiplyRadioButton.Checked = False And DivideRadioButton.Checked = False Then
            ArrowBox5.Image = My.Resources.BigRedArrow
            ArrowBox5.Visible = True
            ArrowBox5.BringToFront()
            ArrowBox6.Image = My.Resources.BigRedArrow
            ArrowBox6.Visible = True
            ArrowBox6.BringToFront()
            ArrowBox7.Image = My.Resources.BigRedArrow
            ArrowBox7.Visible = True
            ArrowBox7.BringToFront()
            ArrowBox8.Image = My.Resources.BigRedArrow
            ArrowBox8.Visible = True
            ArrowBox8.BringToFront()
            MsgBox("Sir. Check one of the bubbles.")
            Exit Function
        ElseIf AddRadioButton.Checked = True Or SubtractRadioButton.Checked = True Or MultiplyRadioButton.Checked = True Or DivideRadioButton.Checked = True Then
            ArrowBox5.Visible = False
            ArrowBox6.Visible = False
            ArrowBox7.Visible = False
            ArrowBox8.Visible = False
        End If

        If SATextBox.Text = Nothing Then
            ActiveControl = SATextBox
            ArrowBox4.Image = My.Resources.BigRedArrow
            ArrowBox4.Visible = True
            ArrowBox4.BringToFront()
            MsgBox("Sir. Enter an answer.")
            Exit Function
        ElseIf SATextBox.Text > Nothing Then
            ArrowBox4.Visible = False
        End If
        eval = True
        Return eval
    End Function

    Sub EvaluateAnswer()
        Dim answer As Integer
        Dim useresponse As Integer
        If AddRadioButton.Checked = True Then
            answer = 20
        ElseIf SubtractRadioButton.Checked = True Then
            answer = 0
        ElseIf MultiplyRadioButton.Checked = True Then
            answer = 100
        ElseIf DivideRadioButton.Checked = True Then
            answer = 1
        End If
        useresponse = SATextBox.Text
        If useresponse = answer Then
            MsgBox("That's the right answer! Good work!")
            Else
            MsgBox("That is the wrong answer.")
        End If

    End Sub
End Class
