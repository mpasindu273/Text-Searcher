Imports System.Text.RegularExpressions

Public Class Form1

    Dim readfile As String
    Dim search_word_count, total_word_count As Integer
    Dim searchtxt As String


    Private Sub bsearch_Click(sender As Object, e As EventArgs) Handles bsearch.Click

        If tlocation.Text = "" Then
            MsgBox("Enter File Location")
        ElseIf tsearchtxt.Text = "" Then
            MsgBox("Enter word to search")
        Else

            Try
                readfile = IO.File.ReadAllText(tlocation.Text)
                searchtxt = tsearchtxt.Text
                total_word_count = readfile.Split().Count

                If checkbox.Checked Then
                    search_word_count = Regex.Matches(readfile, tsearchtxt.Text, RegexOptions.IgnoreCase).Count
                Else
                    search_word_count = Regex.Matches(readfile, tsearchtxt.Text).Count
                End If

                If search_word_count > 0 Then
                    tresult.Text = search_word_count & " times out of " & total_word_count & " words"
                Else
                    tresult.Text = "Text Not Found!"
                End If

            Catch
                MsgBox("Please give a valid text file location")
            End Try
        End If

    End Sub

    Private Sub bbrowse_Click(sender As Object, e As EventArgs) Handles bbrowse.Click

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            tlocation.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub tsearchtxt_TextChanged(sender As Object, e As EventArgs) Handles tsearchtxt.TextChanged
        tresult.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

End Class
