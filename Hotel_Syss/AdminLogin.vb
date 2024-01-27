Public Class AdminLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then

            Form1.Show()
            Me.Hide()

        Else

            MessageBox.Show("NAKU MALI ANG IMONG PASSWORD")

        End If
    End Sub
End Class