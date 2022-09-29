Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim original As Single
        Dim taxed As Single
        Dim country As String
        Dim taxtype As String
        Dim margin As Single
        Dim premargin As Single
        Dim percentage As Single
        Dim neww As Single
        Dim per As Integer
        Dim newer As Integer
        Dim taxed2 As Integer

        original = TextBox1.Text
        taxtype = ComboBox1.Text
        If taxtype = "Select" Then
            MsgBox("Please Select Tax Type")
        End If
        If CheckBox1.Checked = True Then
            country = "UK"
        ElseIf CheckBox2.Checked = True Then
            country = "USA"
        End If
        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("Please Select A Country")
        End If
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            MsgBox("Please Only Select One Country")
        End If
        If taxtype = "VAT" Then
            If country = "UK" Then
                percentage = 1.2
                taxed = original * percentage
                neww = taxed - original
                neww = neww * 100
                newer = Int(neww)
                neww = newer / 100
                taxed = taxed * 100
                taxed2 = Int(taxed)
                taxed = taxed2 / 100
                TextBox4.Text = "£ " & neww
                TextBox2.Text = "£ " & taxed
                TextBox3.Text = 20 & "%"
            End If
            If country = "USA" Then
                percentage = 1.1

            End If
        End If
        If taxtype = "Sales Tax" Then
            If country = "UK" Then
                percentage = 1.18
                taxed = original * percentage
                neww = taxed - original
                neww = neww * 100
                newer = Int(neww)
                neww = newer / 100
                taxed = taxed * 100
                taxed2 = Int(taxed)
                taxed = taxed2 / 100
                TextBox4.Text = "£ " & neww
                TextBox2.Text = "£ " & taxed
                TextBox3.Text = 18 & "%"
            End If

            If country = "USA" Then
                Dim state As String
                state = ComboBox2.Text
                If state = "Alabama" Then
                    percentage = 1.04
                End If
                If state = "Alaska" Then
                    percentage = 1
                End If
                If state = "Arizona" Then
                    percentage = 1.056
                End If
                If state = "Arkansas" Then
                    percentage = 1.065
                End If
                If state = "California" Then
                    percentage = 1.0725
                End If
                If state = "Colorado" Then
                    percentage = 1.029
                End If
                If state = "Connecticut" Then
                    percentage = 1.0635
                End If
                If state = "Delaware" Then
                    percentage = 1
                End If
                If state = "Florida" Then
                    percentage = 1.06
                End If
                If state = "Georgia" Then
                    percentage = 1.04
                End If
                If state = "Hawaii" Then
                    percentage = 1.04
                End If
                If state = "Idaho" Then
                    percentage = 1.06
                End If
                If state = "Illinois" Then
                    percentage = 1.06
                End If
                If state = "Indiana" Then
                    percentage = 1.07
                End If
                If state = "Iowa" Then
                    percentage = 1.065
                End If
                If state = "Kansas" Then
                    percentage = 1.065
                End If
                If state = "Kentucky" Then
                    percentage = 1.06
                End If
                If state = "Louisiana" Then
                    percentage = 1.05
                End If
                If state = "Maine" Then
                    percentage = 1.055
                End If
                If state = "Maryland" Then
                    percentage = 1.06
                End If
                If state = "Massachusetts" Then

                    percentage = 1.0625
                End If
                If state = "Michigan" Then
                    percentage = 1.06
                End If
                If state = "Minnesota" Then
                    percentage = 1.06875
                End If
                If state = "Mississippi" Then
                    percentage = 1.07
                End If
                If state = "Missouri" Then
                    percentage = 1.04225
                End If
                If state = "Montana" Then
                    percentage = 1.0
                End If
                If state = "Nebraska" Then
                    percentage = 1.055
                End If
                If state = "Nevada" Then
                    percentage = 1.0685
                End If
                If state = "New Hampshire" Then
                    percentage = 1.0
                End If
                If state = "New Jersey" Then
                    percentage = 1.06785
                End If
                If state = "New Mexico" Then
                    percentage = 1.05125
                End If
                If state = "New York" Then
                    percentage = 1.04
                End If
                If state = "North Carolina" Then
                    percentage = 1.0475
                End If
                If state = "North Dakota" Then
                    percentage = 1.05
                End If
                If state = "Ohio" Then
                    percentage = 1.0575
                End If
                If state = "Oklahoma" Then
                    percentage = 1.045
                End If
                If state = "Oregon" Then
                    percentage = 1.0
                End If
                If state = "Rhode Island" Then
                    percentage = 1.04
                End If
                If state = "South Carolina" Then
                    percentage = 1.06
                End If
                If state = "South Dakota" Then
                    percentage = 1.045
                End If
                If state = "Tennessee" Then
                    percentage = 1.07
                End If
                If state = "Texas" Then
                    percentage = 1.0625
                End If
                If state = "Utah" Then
                    percentage = 1.0595
                End If
                If state = "Vermont" Then
                    percentage = 1.06
                End If
                If state = "Virginia" Then
                    percentage = 1.053
                End If
                If state = "Washington" Then
                    percentage = 1.06
                End If
                If state = "West Virginia" Then
                    percentage = 1.06
                End If
                If state = "Wisconsin" Then
                    percentage = 1.05
                End If
                If state = "Wyoming" Then
                    percentage = 1.04
                End If
                taxed = original * percentage
                neww = taxed - original
                neww = neww * 100
                newer = Int(neww)
                neww = newer / 100
                taxed = taxed * 100
                taxed2 = Int(taxed)
                taxed = taxed2 / 100
                per = percentage * 1000
                percentage = Int(per)
                percentage = percentage / 1000
                TextBox4.Text = "£ " & neww
                TextBox2.Text = "£ " & taxed
                TextBox3.Text = (percentage) & "%"
            End If
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "VAT" Then
            Label2.Text = "Item Cost"
            Label4.Text = "New Cost"
            Label6.Text = "Added Price"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If ComboBox1.Text = "Sales Tax" Then
            ComboBox2.Visible = True
            Label7.Visible = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Visible = False
        Label7.Visible = False
    End Sub
End Class