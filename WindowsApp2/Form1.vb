Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub But1_Click(sender As Object, e As EventArgs) Handles But1.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub But2_Click(sender As Object, e As EventArgs) Handles But2.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class
