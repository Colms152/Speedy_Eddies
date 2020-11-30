'Program Name:      Speedy Eddies
'Programmer:        Colm Sheehan (UCC Student Number: 117366653)
'Form Name:         Car+Options
'Form Description:  This form takes what kind of vehicle and model the customer wants, the dates wanted for
'                   and the optional extras that may be sold as per the brief.
'Disclaimer:            All code in this poject was taken from lectures, tutorials and https://msdn.microsoft.com/en-us/library/2x7h1hfk(v=vs.120).aspx


Public Class frmCar_Options

    'This sub lets a window showing the pricing to be shown when a button is clicked
    Private Sub btnPricing_Click(sender As Object, e As EventArgs) Handles btnPricing.Click
        frmSup1VehiclePricing.Show()

    End Sub

    'This sub lets the user navigate to the previous form in the program when the back button is clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frm3CustomerDetails.Show()

    End Sub

    'This sub is for when the next button is Clicked.
    'This button calculates and/or pushes days the car will be rented, car price & vat, extras cost & vat
    'to the summary form.
    'This button also carries out validation
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'This is where the VEHICLE calculation Starts

        'This If statment causes the variables used in the formula for calculating car cost below to  
        'equal constents depening on the users inputs to the form
        If cboCars.Text = "VW Polo 1.0 Lt (or equivalent)" Then
            decY = decPoloDaily
            decZ = decPoloWeekly
            decH = decPoloFortnightly
        ElseIf cboCars.Text = "Opel Corsa 1.2 Lt (or equivalent)" Then
            decY = decCorsaCarDaily
            decZ = decCorsaCarWeekly
            decH = decCorsaCarFortnightly
        ElseIf cboCars.Text = "Skoda Octavia 1.4 Lt (or equivalent)" Then
            decY = decOctaviaDaily
            decZ = decOctaviaWeekly
            decH = decOctaviaFortnightly
        ElseIf cboCars.Text = "Alfa Romeo 1.6 Lt (or equivalent)" Then
            decY = decRomeoDaily
            decZ = decRomeoWeekly
            decH = decRomeoFortnightly
        ElseIf cboCars.Text = "Opel Zafira 8 Seater 2.0 Lt (or equivalent)" Then
            decY = decZafiraDaily
            decZ = decZafiraWeekly
            decH = decZafiraFortnightly
        ElseIf cboVans.Text = "Opel Corsa Van" Then
            decY = decCorsaVanDaily
            decZ = decCorsaVanWeekly
            decH = decCorsaVanFortnightly
        ElseIf cboVans.Text = "Toyota Hiace" Then
            decY = decHiaceDaily
            decZ = decHiaceWeekly
            decH = decHiaceFortnightly
        ElseIf cboVans.Text = "Ford Transit" Then
            decY = decTransitDaily
            decZ = decTransitWeekly
            decH = decTransitFortnightly
        ElseIf cboVans.Text = "Ford Transit Minibus (26 Seater)" Then
            decY = decTransitMinibusDaily
            decZ = decTransitMinibusWeekly
            decH = decTransitMinibusFortnightly
        ElseIf cboVans.Text = "Mercedes Runner" Then
            decY = decRunnerDaily
            decZ = decRunnerWeekly
            decH = decRunnerFortnightly
        ElseIf cboVans.Text = "Nissan Patrol" Then
            decY = decPatrolDaily
            decZ = decPatrolWeekly
            decH = decPatrolFortnightly

        End If

        'This if stament is a formula for calculating the cost of the vehicle depending on
        'the amount of days. This also pushes the cost to the summary form. As there is no 
        'max allowance for the days of rental allowed stated in the breif this fromula will 
        'perpetually work for any amount of days.
        If intDays < 1 Then
            'This intital if ensures that the dates have been enter correctly
            MessageBox.Show("Please Choose Dates Again", "Invalid Date Choice",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf intDays < 7 Then
            'This else if is so that if the rental is less than 7 days the customer will 
            'be charged the daily rate.
            decSubtotal = intDays * decY
            frm7Summary.txtCostExVAT.Text = decSubtotal.ToString("C")
        ElseIf intDays >= 7 And intDays < 14 Then
            'This else if is so that if the rental is equal to a week or more but less than 
            '2 weeks the cumstomer will be charged the weekly rate for the intial week and
            'then the daily rate for any days after that.
            Dim decw4wvalue As Decimal
            Dim decd4wvalue As Decimal

            decw4wvalue = (intDays Mod 7) * decY
            decd4wvalue = ((intDays - (intDays Mod 7)) / 7) * decZ
            decSubtotal = decw4wvalue + decd4wvalue
            frm7Summary.txtCostExVAT.Text = decSubtotal.ToString("C")
        ElseIf intDays >= 14 Then
            'This else if is so that if the rental is equal to 2 weeks (a fortnight) or more the
            'customer will be charged for every two weeks at the fortnightly rate and then any
            'remaing week at the weekly rate and then any reaming days at the daily rate.
            Dim decW4fvalue As Decimal
            Dim decD4fValue As Decimal
            Dim decF4fValue As Decimal

            decD4fValue = ((intDays Mod 14) Mod 7) * decY
            decW4fvalue = (((intDays Mod 14) - ((intDays Mod 14) Mod 7)) / 7) * decZ
            decF4fValue = ((intDays - (intDays Mod 14)) / 14) * decH
            decSubtotal = decD4fValue + decW4fvalue + decF4fValue
            frm7Summary.txtCostExVAT.Text = decSubtotal.ToString("C")
        End If

        'This declares a variable to be used in the calculation of vat and the sum of total Car cost
        Dim decCarVatCost As Decimal
        'This causes the variable to equal VAT and then pushes that number to the summary form
        decCarVatCost = (decSubtotal * decVehicleTaxRate)
        frm7Summary.txtVAT.Text = decCarVatCost.ToString("C")
        'This puts a golbal variable equal to Total car  cost and pushes it to the summary form
        decTotalCarCost = (decSubtotal + decCarVatCost)
        frm7Summary.txtTotalCarCost.Text = decTotalCarCost.ToString("C")

        'This is where the VEHICLES calculation Ends

        'This is where the EXTRAS calculation Starts

        'This declares a variable for the Child seat
        Dim decChildSeatCharge As Decimal
        If chkChildSeat.Checked = True Then
            'This if puts the above variable equal to constant depending on the user inputs
            'This if also pushes the above variable to the summary form
            decChildSeatCharge = decChildSeatprice
            frm7Summary.txtChildSeat.Text = decChildSeatCharge.ToString("C")
        End If
        'This declares a variable for the Luggage Rack 
        Dim decLuggageRackCharge As Decimal
        If chkLuggageRack.Checked = True Then
            'This if puts the above variable equal to constant depending on the user inputs
            'This if also pushes the above variable to the summary form
            decLuggageRackCharge = decLuggageRackprice
            frm7Summary.txtLuggageRack.Text = decLuggageRackCharge.ToString("C")
        End If
        'This declares a variable for the Ski Equipment
        Dim decSkiEqCharge As Decimal
        If chkSkiEq.Checked = True Then
            'This if puts the above variable equal to constant depending on the user inputs
            'This if also pushes the above variable to the summary form
            decSkiEqCharge = decSkiEqprice
            frm7Summary.txtSkiEquip.Text = decSkiEqCharge.ToString("C")
        End If
        'This declares a variable for the SatNav
        Dim decSatNavCost As Integer
        'This if puts the above variable equal to constant depending on the days by multiplying the amount of days by the SatNavRate constant
        decSatNavCost = decSatNavRate * intDays
        If chkSatNav.Checked = True Then
            'This if pushes the above variable to the summary form
            frm7Summary.txtSatNav.Text = decSatNavCost.ToString("C")
        End If

        'This declares a varibale for the sumation of all extra's opted for by the user
        Dim decExtraTotalCost As Decimal
        'This puts that variable equal to a sum and then pushes it to the summary from
        decExtraTotalCost = decChildSeatCharge + decLuggageRackCharge + decSkiEqCharge + decSatNavCost
        frm7Summary.txtTotalExExVAT.Text = decExtraTotalCost.ToString("C")
        'This puts a global variable equal to the sum of the extra's plus vat
        decExtraTotalCostPlusVAT = decExtraTotalCost * 1.2
        frm7Summary.txtTotalExInclVAT.Text = decExtraTotalCostPlusVAT.ToString("C")

        'This is where the EXTRAS calculation Ends

        'Validation:    This if stament ensures the correct information is entered in the 
        '               feilds on the from. If not the error count is incresed

        If intDays <= 0 Then
            gintErrorcount = gintErrorcount + 1
            MessageBox.Show("Rental Duration can not be a negative period of time, Please Choose Dates Again, Error Count = " & gintErrorcount, "Invalid Date Choice",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf rdbCar.Checked Then
            If cboCars.SelectedItem = "" Then
                gintErrorcount = gintErrorcount + 1
                MessageBox.Show("Please Select a Model of Car, Error Count = " & gintErrorcount)
            ElseIf gintErrorcount < 5 Then
                frm7Summary.txtRentalDays.Text = intDays
                Me.Hide()
                frm5DriverDetails.Show()
            End If
        ElseIf rdbVan.Checked Then
            If cboVans.SelectedItem = "" Then
                gintErrorcount = gintErrorcount + 1
                MessageBox.Show("Please Select a Model of Van, Error Count = " & gintErrorcount)
            ElseIf gintErrorcount < 5 Then
                frm7Summary.txtRentalDays.Text = intDays
                Me.Hide()
                frm5DriverDetails.Show()
            End If
        End If
        'Validation:    This if stament causes the from and error count to be rest if the error count reaches 5
        If gintErrorcount = 5 Then
            gintErrorcount = 0
            cboCars.SelectedIndex = -1
            cboVans.SelectedIndex = -1
            MessageBox.Show("You have reached the max error allowance. The form will now be reset. Error Count = " & gintErrorcount)
        End If

    End Sub

    'This sub causes the encapsulated code to occur when the form opens
    Private Sub frmCar_Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This hides the combo boxes where vehicle models are chosen so that they can be later shown 
        'once a specific radio button is selected
        cboCars.Hide()
        cboVans.Hide()
        'This set the minimum day possible to select to the current date
        DtpStart.MinDate = Now.Date
        'This sets the minimum day possible to select to the current Start date when the from loads
        DtpReturn.MinDate = DtpStart.Value
    End Sub

    'This sub is for when the radio button to select cars is checked
    Private Sub rdbCar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCar.CheckedChanged
        If rdbCar.Checked = True Then
            'This if causes the cars combo box to show,vans combo box to hide and resets the text in the van
            'combo box
            cboCars.Show()
            cboVans.Hide()
            cboVans.Text = ""
        End If

        If rdbCar.Checked = True Then
            'This if causes the appropriate extras for cars to show
            chkChildSeat.Show()
            chkSkiEq.Show()
            chkLuggageRack.Show()
        End If

    End Sub

    'This sub is for when the radio button to select vans is checked
    Private Sub rdbVan_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVan.CheckedChanged
        If rdbVan.Checked = True Then
            'This if causes the vans combo box to show,cars combo box to hide and resets the text in the cars
            'combo box
            cboVans.Show()
            cboCars.Hide()
            cboCars.Text = ""
        End If

        If rdbCar.Checked = False Then
            'This if causes the appropriate extras for vans to show
            chkChildSeat.Hide()
            chkSkiEq.Hide()
            chkLuggageRack.Hide()
        End If
    End Sub

    'This sub is for the date time picker of returning the vehicle
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DtpReturn.ValueChanged
        'Declare variables for dates of rental and duration
        Dim dateStart As Date
        Dim dateReturn As Date

        dateStart = DtpStart.Text
        dateReturn = DtpReturn.Text

        'Calculates period of duration from dates chosen.
        intDays = (CInt(dateReturn.Date.Subtract(dateStart).Days))

    End Sub

    'This sub is for the date time picker of getting the vehicle
    Private Sub DtpStart_ValueChanged(sender As Object, e As EventArgs) Handles DtpStart.ValueChanged
        'This sets the minimum day possible to select for returnung the vehicle to the current Start date when its changed
        DtpReturn.MinDate = DtpStart.Value
    End Sub

    'This sub is for when the cars combo box is changed
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCars.SelectedIndexChanged
        'This code has no current purpose (WIP)
        If cboCars.Text = "VW Polo 1.0 Lt (or equivalent)" Then
            strVehicle = strPolo
        End If
        'This resets the the extras when each cars is chosen
        chkChildSeat.Checked = False
        chkLuggageRack.Checked = False
        chkSatNav.Checked = False
        chkSkiEq.Checked = False

    End Sub

    'This sub is for when the vans combo box is changed
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVans.SelectedIndexChanged
        'This resets the the extras when each vans is chosen
        chkChildSeat.Checked = False
        chkLuggageRack.Checked = False
        chkSatNav.Checked = False
        chkSkiEq.Checked = False

        'This is a special exception to the extras as The nissan patrol can have differnt extra's over a van as it's a 4X4
        If cboVans.Text = "Nissan Patrol" Then
            chkSkiEq.Show()
            chkLuggageRack.Show()
        ElseIf cboVans.Text = "Nissan Patrol" = False Then
            chkSkiEq.Hide()
            chkLuggageRack.Hide()
        End If
    End Sub
End Class