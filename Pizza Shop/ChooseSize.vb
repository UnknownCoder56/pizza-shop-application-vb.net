Public Class ChooseSize

    Public Property psizecost As Integer

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = ChoosePizza.pizzachoice
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        psizecost = 0
        Me.Hide()
        Summary.show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        psizecost = 10
        Me.Hide()
        Summary.show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        psizecost = 20
        Me.Hide()
        Summary.show()
    End Sub
End Class