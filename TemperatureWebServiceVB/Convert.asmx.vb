Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Convert
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function




    <WebMethod()>
    Public Function FahrenheitToCelsius(ByVal Fahrenheit As Double) _
    As Double

        Return ((Fahrenheit - 32) * 5) / 9
    End Function




    <WebMethod()>
    Public Function CelsiusToFahrenheit(ByVal Celsius As Double) _
    As Double
        Return ((Celsius * 9) / 5) + 32
    End Function



End Class