Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
        If Panel1.BackColor = Color.ForestGreen Then
            Panel1.BackColor = Color.IndianRed
            Label1.BackColor = Color.IndianRed
        Else
            Panel1.BackColor = Color.ForestGreen
            Label1.BackColor = Color.ForestGreen
        End If

    End Sub
End Class
