Public Class MayorOMenor
    Private bits As Integer
    Private numeroGenerado As Integer
    Private minGenerador, maxGenerador As Integer

    Private Sub MayorOMenor_Load(sender As Object, e As EventArgs) Handles Me.Load
        minGenerador = 1
        maxGenerador = 100
        bits = 1000
        ChangeBitsLabel(bits)
        CantidadApostar.Minimum = 0
        ChangeMaximumOfCantidadApostar(bits)
        CantidadApostar.Value = PromedioDeRangoDeApuestas()
        numeroGenerado = 50
        ChangeTextOfGroupBox(numeroGenerado)
    End Sub

    Private Sub ChangeBitsLabel(bits As Integer)
        BitsLabel.Text = "Bits: " & bits
    End Sub

    Private Sub ChangeMaximumOfCantidadApostar(max As Integer)
        CantidadApostar.Maximum = max
    End Sub

    Private Sub ChangeTextOfGroupBox(num As Integer)
        GroupBox.Text = "¿El número siguiente es mayor o menor a " & num & "?"
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
            MensajeVictoria(bits)
            bits += CantidadApostar.Value
        Else
            MensajeDerrota(bits)
            bits -= CantidadApostar.Value
        End If

        ChangeMaximumOfCantidadApostar(bits)
        CantidadApostar.Value = PromedioDeRangoDeApuestas()
        ChangeBitsLabel(bits)
        ChangeTextOfGroupBox(numeroGenerado)
    End Sub

    Private Sub MensajeVictoria(bits As Integer)
        MsgBox("Ganaste " & CantidadApostar.Value & " bits",
               MsgBoxStyle.Information, "Mensaje")
    End Sub

    Private Sub MensajeDerrota(bits As Integer)
        MsgBox("Perdiste " & CantidadApostar.Value & " bits",
               MsgBoxStyle.Critical, "Mensaje")
    End Sub

    Private Function GenerarNumeroAleatorio(min As Integer, max As Integer) As Integer
        Randomize()
        Return CInt(Int((max * Rnd()) + min))
    End Function

    Private Function ApuestaGanada(actual As Integer, anterior As Integer) As Boolean
        Dim mayorAcertado As Boolean = actual > anterior And MayorSel.Checked
        Dim menorAcertado As Boolean = actual < anterior And MenorSel.Checked
        Return mayorAcertado Or menorAcertado
    End Function

    Private Function PromedioDeRangoDeApuestas() As Integer
        Return CantidadApostar.Maximum / 2
    End Function
End Class
