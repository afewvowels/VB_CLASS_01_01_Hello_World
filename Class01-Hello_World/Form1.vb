Public Class Form1

    Private Sub PushButton_Click(sender As Object, e As EventArgs) Handles PushButton.Click
        ' Simply set message box to message "Hello World" and ensure
        ' that message box is visible
        'MessageLabel.Text = "Hello World"
        'MessageLabel.Visible = True

        ' Set label text
        MessageLabel.Text = "Hello World"

        ' Toggle message box visibility
        If MessageLabel.Visible = False Then
            MessageLabel.Visible = True
        Else
            MessageLabel.Visible = False
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Exit the program
        Me.Close()
    End Sub

    Private Sub PushButton_MouseHover(sender As Object, e As EventArgs) Handles PushButton.MouseHover
        MessageLabel.Visible = True
        MessageLabel.Text = "Click the button"
    End Sub
End Class
