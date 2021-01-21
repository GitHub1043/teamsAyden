Public Class Form1

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim intAge As Integer
        Dim intYears As Integer

        intAge = Val(txtAge.Text)
        intYears = Val(txtYears.Text)

        If (intAge < 8) And (intYears <= intAge / 2) Then
            MessageBox.Show("Registered in Junior / Beginner League")
        ElseIf (intAge >= 8) And (intYears <= intAge / 2) Then
            MessageBox.Show("Registered in Senior / Beginner League")
        ElseIf (intAge < 8) And (intYears > intAge / 2) Then
            MessageBox.Show("Registered in Junior / Advanced League")
        ElseIf (intAge >= 8) And (intYears > intAge / 2) Then
            MessageBox.Show("Registered in Senior / Advanced League")
        End If

        If (intAge < 4) Then
            MessageBox.Show("Too young to participate")
        ElseIf (intAge = 16) And (intYears = 13) Then
            MessageBox.Show("Registered in Ultra-Elite Teen League")
        ElseIf (intAge >= 18) Then
            MessageBox.Show("Too old to participate")
        End If

        If (intYears > intAge) Then
            MessageBox.Show("Impossible experience")
        End If

    End Sub
End Class
