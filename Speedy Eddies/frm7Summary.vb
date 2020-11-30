'Program Name:      Speedy Eddies
'Programmer:        Colm Sheehan (UCC Student Number: 117366653)
'Form Name:         Summary
'Form Description:  This screen lets the user see a break down of all rental costs and the total
'Disclaimer:            All code in this poject was taken from lectures, tutorials and https://msdn.microsoft.com/en-us/library/2x7h1hfk(v=vs.120).aspx
Public Class frm7Summary



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Closes current form and shows the next one in this program  
        Me.Hide()
        frm6Insurance.Show()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'This lets the user navigate to the previous form in the program when the back button is clicked
        Me.Hide()
        frmCard_End.Show()


    End Sub

    Private Sub frm7Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When this form loads the information from pervious from is pushed to this one to summarise the prossess
        txtName.Text() = frm3CustomerDetails.mtbName.Text()
        txtStAd.Text() = frm3CustomerDetails.txtStAd.Text()
        txtStAdLine2.Text() = frm3CustomerDetails.txtStAdLine2.Text()
        txtTown.Text() = frm3CustomerDetails.mtbCity.Text()
        txtCounty.Text() = frm3CustomerDetails.cboCounty.Text()
        txtPhoneNo.Text() = frm3CustomerDetails.mtbPhoneNo.Text()
        txtDOB.Text() = frm3CustomerDetails.mtbDOB.Text()
        txtEmail.Text() = frm3CustomerDetails.txtemail.Text()

        txtLicenseNo.Text() = frm5DriverDetails.mtbLicense.Text()
        txtYears.Text() = frm5DriverDetails.mtbYears.Text()
        txtGender.Text() = frm5DriverDetails.cboGender.Text()
        txtPenaltyPoints.Text() = frm5DriverDetails.mtbPoints.Text()

        txtEmployee.Text() = gstrUserName

    End Sub

End Class