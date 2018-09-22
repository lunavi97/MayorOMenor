Public Class MayorOMenor
    Private bits As Integer
    Private numeroGenerado As Integer
    Private minGenerador, maxGenerador As Integer

    Private Sub MayorOMenor_Load(sender As Object, e As EventArgs) Handles Me.Load
        minGenerador = 1
        maxGenerador = 100
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

    Private Sub ApostarButton_Click(sender As Object, e As EventArgs) Handles ApostarButton.Click
        If CantidadApostar.Value > bits Then
            Return
        End If

        If CantidadApostar.Value < 1 Then
            Return
        End If

        Dim numeroAComparar As Integer = numeroGenerado
        numeroGenerado = GenerarNumeroAleatorio(minGenerador, maxGenerador)
        If ApuestaGanada(numeroGenerado, numeroAComparar) Then
            MsgBox("Ganaste " + Format(CantidadApostar.Value) + " bits")
        Else
            MsgBox("Perdiste " + Format(CantidadApostar.Value) + " bits")
        End If
    End Sub

    Private Function GenerarNumeroAleatorio(min As Integer, max As Integer) As Integer
        Randomize()
        Return CInt(Int((max * Rnd()) + min))
    End Function

    Private Function ApuestaGanada(actual As Integer, anterior As Integer) As Boolean
        Return actual > anterior And MayorSel.Checked Or
            actual < anterior And MenorSel.Checked
    End Function
End Class
