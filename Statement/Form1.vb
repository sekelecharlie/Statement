Public Class Form1
    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click
        Dim country As String

        country = txtCountry.Text.ToUpper
        If country = "SOUTH AFRICA" Then
            MsgBox("THOBELA")

        ElseIf country = "SPAIN" Then
            MsgBox("OLE")

        ElseIf country = "ZIMBABWE" Then
            MsgBox("ZWIRIBO")

        Else
            MsgBox("Hello")

        End If

    End Sub
End Class
