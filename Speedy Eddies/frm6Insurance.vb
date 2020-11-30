'Program Name:      Speedy Eddies
'Programmer:        Colm Sheehan (UCC Student Number: 117366653)
'Form Name:         Insurance
'Form Description:  This screen lets the user choose what insurance options they would like for their rental
'Disclaimer:            All code in this poject was taken from lectures, tutorials and https://msdn.microsoft.com/en-us/library/2x7h1hfk(v=vs.120).aspx

Public Class frm6Insurance
    'The enclosed code occurs when the button is clicked on
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTandC.Click
        'This shows the terms and condtions 
        frmSup2TandC.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'This lets the user navigate to the previous form in the program when the back button is clicked
        Me.Hide()
        frm5DriverDetails.Show()


    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'This lets the user navigate to the next form in the program when the next button is clicked
        Me.Hide()
        frm7Summary.Show()

        'Insurance Calculation Start

        If chkCDW.Checked = True Then
            'This if calculates the collision damage waier figure if the user checkes the option to take it
            decCollisionInsurance = intDays * decCollisionDamageW
            deccollisionIcharge = decCollisionInsurance
            frm7Summary.txtCollision.Text = deccollisionIcharge.ToString("C")
        ElseIf chkCDW.Checked = False Then
            'This else if adds The colliosn damage surcharge(refered to as a deposit in form) if the user does not check the insurance option
            deccollisionIcharge = decVehicleCollisiondep
            frm7Summary.txtCollision.Text = deccollisionIcharge.ToString("C")

        End If


        If chkTheftInsurance.Checked = True Then
            'This if calculates the Theft Insurance figure if the user checkes the option to take it
            decTheftInsuranceSum = intDays * decTheftInsurance
            dectheftIcharge = decTheftInsuranceSum
            frm7Summary.txtTheft.Text = dectheftIcharge.ToString("C")
        ElseIf chkTheftInsurance.Checked = False Then
            'This else if adds The Theft surcharge(refered to as a deposit in form) if the user does not check the insurance option
            dectheftIcharge = decTheftdep
            frm7Summary.txtTheft.Text = dectheftIcharge.ToString("c")
        End If

        'Declaring the Vehicle Contents Insurance variables
        Dim decDailyContRate As Decimal
        Dim decWeeklyContRate As Decimal

        If chkVehicleContents.Checked = True Then
            If intDays < 7 Then
                'This calculates the cost of contents iinsurance when then rental period is less than 1 week
                decContentsInsuranceSum = intDays * decVehicleContentsDR
                frm7Summary.txtContents.Text = decContentsInsuranceSum.ToString("C")
            ElseIf intDays >= 7 Then
                'This calculates the cost of contents insurance when the rental period is one week of greater. The weeks are charged at 
                'the weekly rate And any remaining days are charged at the daily rate
                decDailyContRate = (intDays Mod 7) * decVehicleContentsDR
                decWeeklyContRate = ((intDays - (intDays Mod 7)) / 7) * DecVehicleContentsWR
                decContentsInsuranceSum = decDailyContRate + decWeeklyContRate
                frm7Summary.txtContents.Text = decContentsInsuranceSum.ToString("C")

            End If
        End If

        'Declare Variable for summing the insurance
        Dim decInsuranceTotal As Decimal
        'Summing the Insurance figuring and pushing the figure to the summary form
        decInsuranceTotal = decContentsInsuranceSum + dectheftIcharge + deccollisionIcharge
        frm7Summary.txtTotalInsurance.Text = decInsuranceTotal.ToString("C")

        'Insurance Calculation End


        'Declaration of cahrge variable
        Dim decTotalCharge As Decimal
        'Total Charge Summation and pushing figure to summary form
        decTotalCharge = decTotalCarCost + decInsuranceTotal + decExtraTotalCostPlusVAT
        frm7Summary.txtTotalCharge.Text = decTotalCharge.ToString("C")
    End Sub
End Class