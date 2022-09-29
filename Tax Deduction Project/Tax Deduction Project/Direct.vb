Public Class Direct
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

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
        If taxtype = "Income Tax" Then
            If country = "UK" Then
                If original <= 14667 Then
                    percentage = 0.81
                ElseIf original > 14667 And original <= 25296 Then
                    percentage = 0.8
                ElseIf original > 25296 And original < 43662 Then
                    percentage = 0.79
                ElseIf original >= 43662 And original <= 150000 Then
                    percentage = 0.59
                ElseIf original > 150000 Then
                    percentage = 0.55
                End If

                taxed = original * percentage
                neww = original * (1 - percentage)
                neww = neww * 100
                newer = Int(neww)
                neww = newer / 100
                taxed = taxed * 100
                taxed2 = Int(taxed)
                taxed = taxed2 / 100
                TextBox4.Text = "£ " & neww
                TextBox2.Text = "£ " & taxed
                percentage = percentage * 100
                per = percentage
                Int(per)
                per = 100 - per
                TextBox3.Text = per & "%"
            End If
            If country = "USA" Then
                If original <= 15000 Then
                    percentage = 0.99
                ElseIf original > 15000 And original <= 30000 Then
                    percentage = 0.986
                ElseIf original > 30000 And original <= 50000 Then
                    percentage = 0.959
                ElseIf original > 50000 And original <= 100000 Then
                    percentage = 0.851
                ElseIf original > 100000 And original <= 200000 Then
                    percentage = 0.781
                ElseIf original > 200000 And original <= 250000 Then
                    percentage = 0.941
                ElseIf original > 250000 Then
                    percentage = 0.484

                End If

                taxed = original * percentage
                neww = original * (1 - percentage)
                neww = neww * 100
                newer = Int(neww)
                neww = newer / 100
                taxed = taxed * 100
                taxed2 = Int(taxed)
                taxed = taxed2 / 100
                TextBox4.Text = "$ " & neww
                TextBox2.Text = "$ " & taxed
                percentage = percentage * 100
                per = percentage
                Int(per)
                per = 100 - per
                TextBox3.Text = per & "%"
            End If
        End If
        If taxtype = "Capital Gains Tax" Then
            If country = "UK" Then
                percentage = 0.8
                taxed = original * percentage
                neww = original * (1 - percentage)
                neww = neww * 100
                newer = Int(neww)
                neww = newer / 100
                taxed = taxed * 100
                taxed2 = Int(taxed)
                taxed = taxed2 / 100
                TextBox4.Text = "$ " & neww
                TextBox2.Text = "$ " & taxed
                percentage = percentage * 100
                per = percentage
                Int(per)
                per = 100 - per
                TextBox3.Text = per & "%"
            End If
            If country = "USA" Then
                If original >= 452400 Then
                    percentage = 0.8
                ElseIf original >= 51701 And original < 452400 Then
                    percentage = 0.85
                ElseIf original < 51701 Then
                    original = 0
                End If
                taxed = original * percentage
                neww = original * (1 - percentage)
                neww = neww * 100
                newer = Int(neww)
                neww = newer / 100
                taxed = taxed * 100
                taxed2 = Int(taxed)
                taxed = taxed2 / 100
                TextBox4.Text = "$ " & neww
                TextBox2.Text = "$ " & taxed
                percentage = percentage * 100
                per = percentage
                Int(per)
                per = 100 - per
                TextBox3.Text = per & "%"
            End If

        End If
        If taxtype = "Securities Transaction Tax" Then
            If country = "UK" Then
                percentage = 0.985
                taxed = original * percentage
                neww = original * (1 - percentage)
                neww = neww * 100
                newer = Int(neww)
                neww = newer / 100
                taxed = taxed * 100
                taxed2 = Int(taxed)
                taxed = taxed2 / 100
                TextBox4.Text = "$ " & neww
                TextBox2.Text = "$ " & taxed
                percentage = percentage * 100
                per = percentage
                Int(per)
                per = 100 - per
                TextBox3.Text = per & "%"
            End If
            If country = "USA" Then
                percentage = 0.99
                taxed = original * percentage
                neww = original * (1 - percentage)
                neww = neww * 100
                newer = Int(neww)
                neww = newer / 100
                taxed = taxed * 100
                taxed2 = Int(taxed)
                taxed = taxed2 / 100
                TextBox4.Text = "$ " & neww
                TextBox2.Text = "$ " & taxed
                percentage = percentage * 100
                per = percentage
                Int(per)
                per = 100 - per
                TextBox3.Text = per & "%"
            End If
        End If

    End Sub
End Class