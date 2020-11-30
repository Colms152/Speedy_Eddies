'Program Name:      Speedy Eddies
'Programmer:        Colm Sheehan (UCC Student Number: 117366653)
'Form Name:         Customer details
'Form Description:  This form takes cumstomer details as per the brief 
'Disclaimer:        All code in this poject was taken from lectures, tutorials and https://msdn.microsoft.com/en-us/library/2x7h1hfk(v=vs.120).aspx

Public Class frm3CustomerDetails
    'The enclosed code occurs when the next button is clicked
    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click

        'Validation:    This if stament ensures the correct iformation is entered in the 
        '               feilds on the from. If not the error count is incresed
        If mtbName.Text = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Name, Error Count = " & gintErrorcount)
        ElseIf txtStAd.Text = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Street Address, Error Count = " & gintErrorcount)
        ElseIf mtbCity.Text = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter City/Town, Error Count = " & gintErrorcount)
        ElseIf cboCounty.SelectedItem = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter County, Error Count = " & gintErrorcount)
        ElseIf mtbPhoneNo.MaskCompleted = False Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Phone Number, Error Count = " & gintErrorcount)
        ElseIf mtbDOB.MaskCompleted = False Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Date of birth, Error Count = " & gintErrorcount)
        ElseIf txtemail.Text = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Email Address, Error Count = " & gintErrorcount)
        ElseIf gintErrorcount < 5 Then
            Me.Hide()
            frmCar_Options.Show()
        End If

        'Validation:    This if stament causes the from and error count to be rest if the error count reaches 5
        If gintErrorcount = 5 Then
            gintErrorcount = 0
            mtbName.Clear()
            txtStAd.Clear()
            txtStAdLine2.Clear()
            mtbCity.Clear()
            cboCounty.SelectedIndex = -1
            mtbPhoneNo.Clear()
            mtbDOB.Clear()
            txtemail.Clear()
            MessageBox.Show("You have reached the max error allowance. The form will now be reset. Error Count = " & gintErrorcount)
        End If
    End Sub

    'The enclosed code occurs when the text is changed
    Private Sub txtStAd_TextChanged(sender As Object, e As EventArgs) Handles txtStAd.TextChanged
        'Making the maxmimum characters 25 as per the breif 50 but half as there are 2 lines
        txtStAd.MaxLength = 25
    End Sub
    'The enclosed code occurs when the text box box is clicked on
    Private Sub mtbName_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbName.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbName.Text = ""
        [Select](0, 0)
    End Sub
    'The enclosed code occurs when the text box box is clicked on
    Private Sub mtbCity_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbCity.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbCity.Text = ""
        [Select](0, 0)
    End Sub
    'The enclosed code occurs when the text box box is clicked on
    Private Sub mtbPhoneNo_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbPhoneNo.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbPhoneNo.Text = ""
        [Select](0, 0)
    End Sub
    'The enclosed code occurs when the text box box is clicked on
    Private Sub mtbDOB_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbDOB.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbDOB.Text = ""
        [Select](0, 0)
    End Sub
    'The enclosed code occurs when the text is changed in the text box
    Private Sub txtStAdLine2_TextChanged(sender As Object, e As EventArgs) Handles txtStAdLine2.TextChanged
        'Making the maxmimum characters 25 as per the breif 50 but half as there are 2 lines
        txtStAd.MaxLength = 25
    End Sub
End Class