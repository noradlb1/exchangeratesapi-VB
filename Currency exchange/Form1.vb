Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim amount As Decimal = Decimal.Parse(txtAmount.Text)
        Dim fromCurrency As String = cmbFromCurrency.SelectedItem.ToString()
        Dim toCurrency As String = cmbToCurrency.SelectedItem.ToString()
        Dim convertedAmount As Decimal = ConvertCurrency(amount, fromCurrency, toCurrency)
        lblResult.Text = $"{amount} {fromCurrency} = {convertedAmount} {toCurrency}"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currencies As String() = {"USD", "EUR", "GBP", "JPY", "AUD", "CAD"}
        cmbFromCurrency.Items.AddRange(currencies)
        cmbToCurrency.Items.AddRange(currencies)
        cmbFromCurrency.SelectedIndex = 0
        cmbToCurrency.SelectedIndex = 1
    End Sub

    Private Function ConvertCurrency(amount As Decimal, fromCurrency As String, toCurrency As String) As Decimal
        Dim apiKey As String = "YOUR_API_KEY" ' استبدل هذا بمفتاح API الخاص بك
        Dim url As String = $"https://api.exchangeratesapi.io/latest?base={fromCurrency}&symbols={toCurrency}"

        Using client As New WebClient()
            Dim json As String = client.DownloadString(url)
            Dim rates As JObject = JObject.Parse(json)
            Dim rate As Decimal = rates("rates")(toCurrency).Value(Of Decimal)()
            Return amount * rate
        End Using
    End Function

End Class
