'Program Name:      Speedy Eddies
'Programmer:        Colm Sheehan (UCC Student Number: 117366653)
'Form Name:         Driver Details
'Form Description:  This screen lets the user enter driver credentials
'Disclaimer:            All code in this poject was taken from lectures, tutorials and https://msdn.microsoft.com/en-us/library/2x7h1hfk(v=vs.120).aspx

Public Class frm5DriverDetails
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'This lets the user navigate to the previous form in the program when the back button is clicked
        Me.Hide()
        frmCar_Options.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Validation:    This if stament ensures the correct information is entered in the 
        '               feilds on the from. If not the error count is incresed
        If mtbLicense.Text = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter License Number, Error Count = " & gintErrorcount)
        ElseIf mtbYears.Text = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Years of Driving expirience, Error Count = " & gintErrorcount)
        ElseIf cboGender.SelectedItem = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Driver Gender, Error Count = " & gintErrorcount)
        ElseIf mtbPoints.Text = "" Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Enter Driver Penality Points, Error Count = " & gintErrorcount)
        ElseIf gintErrorcount < 5 Then
            Me.Hide()
            frm6Insurance.Show()
        End If
        'Validation:    This if stament causes the from and error count to be rest if the error count reaches 5
        If gintErrorcount = 5 Then
            gintErrorcount = 0
            mtbLicense.Clear()
            mtbYears.Clear()
            cboGender.SelectedIndex = -1
            mtbPoints.Clear()
            MessageBox.Show("You have reached the max error allowance. The form will now be reset. Error Count = " & gintErrorcount)
        End If


    End Sub

    Private Sub mtbPoints_MouseClick(sender As Object, e As MouseEventArgs) Handles mtbPoints.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbPoints.Text = ""
        [Select](0, 0)
    End Sub

    Private Sub mtbYears_DoubleClick(sender As Object, e As EventArgs) Handles mtbYears.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbYears.Text = ""
        [Select](0, 0)
    End Sub

    Private Sub mtbLicense_DoubleClick(sender As Object, e As EventArgs) Handles mtbLicense.MouseClick
        'Brings Typing curser to start of masked text box when clicked
        mtbLicense.Text = ""
        [Select](0, 0)
    End Sub

End Class