<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Convertir_Temperatura.aspx.vb" Inherits="Convertir_Temperatura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CONVERTIR TEMPRATURA<br />
            <br />
            <br />
            Temperatura&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="122px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <br />
            A continuacion los valores:<br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp; Fahrengeit a centigrado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; =&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp; Centigrado a fahrengeit&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; =&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
