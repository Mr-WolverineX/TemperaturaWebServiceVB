
Partial Class Convertir_Temperatura
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim wsConvert As New ReferenciaTempVB.Convert()
        Dim temperature As Double
        temperature = System.Convert.ToDouble(TextBox1.Text)

        Label1.Text = "Fahrenheit To Celsius = " & _
            wsConvert.FahrenheitToCelsius(temperature).ToString()

        Label2.Text = "Celsius To Fahrenheit = " & _
            wsConvert.CelsiusToFahrenheit(temperature).ToString()



    End Sub
    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
