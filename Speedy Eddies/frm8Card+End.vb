'Program Name:      Speedy Eddies
'Programmer:        Colm Sheehan (UCC Student Number: 117366653)
'Form Name:         Card+End
'Form Description:  This screen lets the user enter Card details and restart the application.
'Disclaimer:            All code in this poject was taken from lectures, tutorials and https://msdn.microsoft.com/en-us/library/2x7h1hfk(v=vs.120).aspx
Public Class frmCard_End


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'This lets the user navigate to the previous form in the program when the back button is clicked
        Me.Hide()
        frm7Summary.Show()

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Validation:    This if stament ensures the correct information is entered in the 
        '               feilds on the from. If not the error count is incresed
        If cboCardType.SelectedItem = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Card Type, Error Count = " & gintErrorcount)
        ElseIf mtbCardNo.MaskCompleted = False Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Card Number, Error Count = " & gintErrorcount)
        ElseIf mtbNameonCard.Text = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Name on card, Error Count = " & gintErrorcount)
        ElseIf mtbCVC.MaskCompleted = False Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter CVC Number, Error Count = " & gintErrorcount)
        ElseIf mtbCardExp.MaskCompleted = False Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Card Expiration Date, Error Count = " & gintErrorcount)
        ElseIf gintErrorcount < 5 Then
            'This code restarts the application and thus clears all forms and feilds 
            'This code works on desktop's and laptop's with VB on local accounts but not UCC PC's. I beleive this is due to a permissions or networking error/conflict.
            Application.Restart()
        End If
        'Validation:    This if stament causes the from and error count to be rest if the error count reaches 5
        If gintErrorcount = 5 Then
            gintErrorcount = 0
            mtbCardNo.Clear()
            mtbNameonCard.Clear()
            mtbCVC.Clear()
            cboCardType.SelectedIndex = -1
            mtbCardExp.Clear()
            MessageBox.Show("You have reached the max error allowance. The form will now be reset. Error Count = " & gintErrorcount)
        End If
    End Sub
    Private Sub mtbCardExp_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbCardExp.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbCardExp.Text = ""
        [Select](0, 0)
    End Sub

    Private Sub mtbCVC_Click(sender As Object, e As EventArgs) Handles mtbCVC.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbCVC.Text = ""
        [Select](0, 0)
    End Sub

    Private Sub mtbNameonCard_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbNameonCard.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbNameonCard.Text = ""
        [Select](0, 0)
    End Sub

    Private Sub mtbCardNo_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbCardNo.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbCardNo.Text = ""
        [Select](0, 0)
    End Sub
End Class