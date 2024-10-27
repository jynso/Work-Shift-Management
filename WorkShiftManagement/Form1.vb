Imports System.Windows.Forms
Public Class Form1
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Labelwelcome.Location = New Point(Labelwelcome.Left - PictureBoxqcu.Left, Labelwelcome.Top - PictureBoxqcu.Top)
        Labelwelcome.Parent = PictureBoxqcu

        Labelback.Location = New Point(Labelback.Left - PictureBoxqcu.Left, Labelback.Top - PictureBoxqcu.Top)
        Labelback.Parent = PictureBoxqcu
    End Sub

    Private Sub PictureBoxqcu_Click(sender As Object, e As EventArgs)

    End Sub
End Class
