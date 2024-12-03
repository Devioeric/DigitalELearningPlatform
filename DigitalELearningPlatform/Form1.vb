Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles RememberCheckButton.CheckedChanged

    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        Me.Hide()
        UserDashboard.Show()
    End Sub
End Class
