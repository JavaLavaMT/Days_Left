Public Class Form1
    'create a dictionary lookup
    Private dic As New Dictionary(Of String, String)()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'shows current date as Month day and year
        lblTDate.Text = Date.Today.ToLongDateString()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'will so value according to the key
        txtValue.Text = dic(txtKey.Text)
        Dim today As Date = Date.Today
        'your entered date
        Dim yourDate As Date = txtValue.Text
        'math to find the differance 
        Dim t As TimeSpan = yourDate - today
        'makes a string
        Dim result As String = "you have " & t.Days

        txtShow.Text = result



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'add to the Dictionary
        dic.Add(txtKey.Text, txtValue.Text)


    End Sub
End Class
