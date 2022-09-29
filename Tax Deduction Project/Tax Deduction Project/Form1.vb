Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
Dim rnd as integer
dim s as integer = 1
        do 
            dim x as float 
            
            randomize()
            rnd = rnd((126-98) * 9)
            rnd = int(rnd)
            if s > 50 then 
                x = 1
                Else 
                    x = (s - 1)
                    delay(x)
            End If
        Loop until button1.click = True
