Public Class MayorOMenor
    Private bits As Integer
    Private numeroGenerado As Integer

    Private Sub MayorOMenor_Load(sender As Object, e As EventArgs) Handles Me.Load
        bits = 1000
        ChangeBitsLabel(bits)
        CantidadApostar.Minimum = 1
        ChangeMaximumOfCantidadApostar(bits)
        numeroGenerado = 50
        ChangeTextOfGroupBox(numeroGenerado)
    End Sub

    Private Sub ChangeBitsLabel(bits As Integer)
        BitsLabel.Text = "Bits: " + Format(bits)
    End Sub

    Private Sub ChangeMaximumOfCantidadApostar(max As Integer)
        CantidadApostar.Maximum = max
    End Sub

    Private Sub ChangeTextOfGroupBox(num As Integer)
        GroupBox.Text = "¿El número siguiente es mayor o menor a " + Format(num) + "?"
    End Sub
End Class
