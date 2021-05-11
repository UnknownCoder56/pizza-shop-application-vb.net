Public Class ChoosePizza

    Public Property pizzachoice As String

    Public Property pizzacost As Integer



    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 1 Then
            Label6.Text = "Margherita"
            pizzacost = 60
        ElseIf NumericUpDown1.Value = 2 Then
            Label6.Text = "Veggie Delight"
            pizzacost = 80
        ElseIf NumericUpDown1.Value = 3 Then
            Label6.Text = "Deluxe Veggie"
            pizzacost = 100
        ElseIf NumericUpDown1.Value = 4 Then
            Label6.Text = "Veggie Paradise"
            pizzacost = 150
        ElseIf NumericUpDown1.Value = 5 Then
            Label6.Text = "Cheese and Corn"
        ElseIf NumericUpDown1.Value = 6 Then
            Label6.Text = "Tomato"
            pizzacost = 55
        ElseIf NumericUpDown1.Value = 7 Then
            Label6.Text = "Chicken Fusion"
            pizzacost = 180
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pizzachoice = Label6.Text
        Me.Hide()
        ChooseSize.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If NumericUpDown1.Value = 1 Then
            Label6.Text = "Margherita"
            pizzacost = 60
        End If
    End Sub
End Class
