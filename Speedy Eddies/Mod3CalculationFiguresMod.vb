'Program Name:          Speedy Eddies
'Programmer:            Colm Sheehan (UCC Student Number: 117366653)
'Module Name:           Mod3CalculationFiguresMod  
'Module Description:    This module is used to declare global variables and constants whose main use is calculating costs.
'Disclaimer:            All code in this poject was taken from lectures, tutorials and https://msdn.microsoft.com/en-us/library/2x7h1hfk(v=vs.120).aspx
Module Mod3CalculationFiguresMod

    'These are global decimal variables to be used in calculating the insurance
    Public deccollisionIcharge As Decimal
    Public deccontentsIcharge As Decimal
    Public dectheftIcharge As Decimal

    'This is a declaration of a global integer variable to be used in calculations where length of rental is required
    Public intDays As Integer

    'This is a declaration of a global decimal variable to be used when calculating the cost of vehicle
    Public decSubtotal As Decimal

    'These are declarations of global decimal variables to be used when calculating the cost of vehicles
    'These variables are put equal to constants depening on vehicle choice (using an if statment)
    Public decY As Decimal
    Public decZ As Decimal
    Public decH As Decimal

    '(*1)These global string constants are currently not used as they are part of a work in progress
    Public Const strPolo As String = "VW Polo"
    Public Const strCorsaCar As String = "Opel Corsa Car"
    Public Const strOctavia As String = "Skoda Octatia"
    Public Const strRomeo As String = "Alfa Romeo"
    Public Const strZafira As String = "Opel Zafira"
    '(*1)
    Public Const strCorsaVan As String = "Opel Corsa Van"
    Public Const strHiace As String = "Toyota Hiace"
    Public Const strTransit As String = "Ford Transit"
    Public Const strTransitMinibus As String = "Ford Transit Minibus (26 seater)"
    Public Const strRunner As String = "Mercedes Runner"
    Public Const strPatrol As String = "Nissan Patrol 4X4"

    'This is the START of where the global decimal constants are declared for daily, weekly
    'and fortnighlty rental rates for each vehicle 
    Public Const decPoloDaily As Decimal = 37.5D
    Public Const decPoloWeekly As Decimal = 236.25D
    Public Const decPoloFortnightly As Decimal = 448.9D

    Public Const decCorsaCarDaily As Decimal = 43.25D
    Public Const decCorsaCarWeekly As Decimal = 272.48D
    Public Const decCorsaCarFortnightly As Decimal = 517.7D

    Public Const decOctaviaDaily As Decimal = 49.7
    Public Const decOctaviaWeekly As Decimal = 313.11
    Public Const decOctaviaFortnightly As Decimal = 594.91

    Public Const decRomeoDaily As Decimal = 55.3
    Public Const decRomeoWeekly As Decimal = 348.39
    Public Const decRomeoFortnightly As Decimal = 661.95

    Public Const decZafiraDaily As Decimal = 63.15
    Public Const decZafiraWeekly As Decimal = 397.85
    Public Const decZafiraFortnightly As Decimal = 755.92

    Public Const decCorsaVanDaily As Decimal = 35.1
    Public Const decCorsaVanWeekly As Decimal = 221.13
    Public Const decCorsaVanFortnightly As Decimal = 420.15

    Public Const decHiaceDaily As Decimal = 39.9
    Public Const decHiaceWeekly As Decimal = 251.37
    Public Const decHiaceFortnightly As Decimal = 477.6

    Public Const decTransitDaily As Decimal = 65.4
    Public Const decTransitWeekly As Decimal = 412.02
    Public Const decTransitFortnightly As Decimal = 782.84

    Public Const decTransitMinibusDaily As Decimal = 68.9
    Public Const decTransitMinibusWeekly As Decimal = 434.07
    Public Const decTransitMinibusFortnightly As Decimal = 824.73

    Public Const decRunnerDaily As Decimal = 89.6
    Public Const decRunnerWeekly As Decimal = 564.48
    Public Const decRunnerFortnightly As Decimal = 1072.51

    Public Const decPatrolDaily As Decimal = 78.8
    Public Const decPatrolWeekly As Decimal = 496.44
    Public Const decPatrolFortnightly As Decimal = 943.24
    'This is the END of where the global decimal constants are declared for daily, weekly
    'and fortnighlty rental rates for each vehicle 

    'These global string constants are currently not used as they are part of a work in progress
    Public StartDate As String
    Public ReturnDate As String
    Public strVehicle As String = "Vehicle"

    'This is the declaration of a global decimal constant which represents the VAT rate of 20%
    Public Const decVehicleTaxRate As Decimal = 0.2

    'These are the declarations of global decimal constants for the costs of various insurance options
    Public Const decCollisionDamageW As Decimal = 2
    Public Const decTheftInsurance As Decimal = 3
    Public Const decVehicleContentsDR As Decimal = 5
    Public Const DecVehicleContentsWR As Decimal = 25
    Public Const decVehicleCollisiondep As Decimal = 2000
    Public Const decTheftdep As Decimal = 3000

    'These are the declarations of global decimal constants for the costs of various Extra's options
    Public Const decChildSeatprice As Decimal = 22
    Public Const decSkiEqprice As Decimal = 78
    Public Const decLuggageRackprice As Decimal = 45
    Public Const decSatNavRate As Decimal = 5

    'These are global decimal variables to be used in calculating the insurance
    Public decCollisionInsurance As Decimal
    Public decTheftInsuranceSum As Decimal
    Public decContentsInsuranceSum As Decimal

    'This is a global decimal variable to be used in calculating the SATNAV extra Option
    Public decSatNavCost As Decimal

    'These are declarations of global decimal variables to be used when calculating the cost of vehicle
    Public decTotalCarCost As Decimal
    Public decExtraTotalCostPlusVAT As Decimal



End Module
