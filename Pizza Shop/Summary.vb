Public Class Summary

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = ChoosePizza.pizzachoice
        If ChooseSize.psizecost = 0 Then
            Label5.Text = "Small"
        ElseIf ChooseSize.psizecost = 10 Then
            Label5.Text = "Medium"
        ElseIf ChooseSize.psizecost = 20 Then
            Label5.Text = "Large"
        End If
        Label6.Text = "Rs. " + Str(ChoosePizza.pizzacost)
        Label7.Text = "+Rs. " + Str(ChooseSize.psizecost)
        Label9.Text = "Rs. " + Str(ChoosePizza.pizzacost + ChooseSize.psizecost)
        Label11.Text = System.DateTime.Now
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class