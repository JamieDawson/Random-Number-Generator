Public Class Form1

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim generator As New Random
        Dim myRand As Integer
        listRandomNumbers.Items.Clear()

        Do
            myRand = generator.Next(0, 20)
            listRandomNumbers.Items.Add(myRand.ToString())
        Loop While myRand <> 5
    End Sub
End Class
