'Program Name:      Speedy Eddies
'Programmer:        Colm Sheehan (UCC Student Number: 117366653)
'Form Name:         Splash Screen
'Form Description:  This Splash screen intends to breifly show the user the 
'                   name/logo of the rental company software version and the 
'                   developer name.
'Disclaimer:            All code in this poject was taken from lectures, tutorials and https://msdn.microsoft.com/en-us/library/2x7h1hfk(v=vs.120).aspx

Public Class frm1SplashScreen


    'This Sub makes the splash screen close after a timer runs and display the next form
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            frm2LogIn.Show()
            Me.Close()
        End If

    End Sub


End Class
