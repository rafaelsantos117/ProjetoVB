Public Class FrmPrincipal
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If CInt(TxtNumero.Text) Mod 2 = 0 Then
            MessageBox.Show("Esse número é par", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Esse número é ímpar", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
