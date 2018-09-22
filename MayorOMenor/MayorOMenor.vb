Public Class MayorOMenor
    Private Sub ApostarText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ApostarText.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
End Class
