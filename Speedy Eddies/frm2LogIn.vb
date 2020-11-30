'Program Name:      Speedy Eddies
'Programmer:        Colm Sheehan (UCC Student Number: 117366653)
'Form Name:         Log In
'Form Description:  This Log in form is inteneded to meet the breif requiremnet to allow 
'                   the service staff, those only with access to proceed through the program
'Disclaimer:            All code in this poject was taken from lectures, tutorials and https://msdn.microsoft.com/en-us/library/2x7h1hfk(v=vs.120).aspx
'

Public Class frm2LogIn

    'This code inside this sub occurs when the login button is pressed
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'This if statment determins the userName and required password
        If txtUserID.Text = "Admin" Then
            gstrUserName = "Admin"
            gstrPassword = "Admin"
        ElseIf txtUserID.Text = "Employee 1" Then
            gstrUserName = "Employee 1"
            gstrPassword = "1"
        ElseIf txtUserID.Text = "Employee 2" Then
            gstrUserName = "Employee 2"
            gstrPassword = "2"
        End If

        'If Statment to the users credentials
        If txtUserID.Text = gstrUserName And txtPassword.Text = gstrPassword Then
            frm3CustomerDetails.Show()
            Me.Hide()
            'This elseif is a from of valiation as per the breif
        ElseIf gintErrorcount < 5 Then
            gintErrorcount = gintErrorcount + 1
            MsgBox("Username or Password Incorrect", MsgBoxStyle.Exclamation, MessageBoxButtons.OK)
        End If

        'Validation:    This if stament causes the from and error count to be rest if the error count reaches 5
        If gintErrorcount = 5 Then
            gintErrorcount = 0
            txtUserID.Clear()
            txtPassword.Clear()


            MessageBox.Show("You have reached the max error allowance. The form will now be reset. Error Count = " & gintErrorcount)
        End If

    End Sub

End Class