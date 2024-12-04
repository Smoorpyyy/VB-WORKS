Imports System.Drawing.Text

Public Class Form2
    Private Const AllowedUsername As String = "admin"
    Private Const AllowedPassword As String = "admin123"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String = TextBox1.Text
        Dim Password As String = TextBox2.Text

        If Username = AllowedUsername AndAlso Password = AllowedPassword Then
            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Label4.Text = "LOGIN SUCCESSFULLY"
            Label4.ForeColor = Color.Green
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Invalid Username or Password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label4.Text = "Invalid Username or Password"
            Label4.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class