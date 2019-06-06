<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx">Почетна</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Pregledi.aspx">Прегледи</asp:HyperLink>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Autor.aspx">О аутору</asp:HyperLink>
            <asp:Label ID="error_message" runat="server" Visible="false" Text=""></asp:Label>
            <br /><br />

            <%
                if (Session["auth"] != null)
                {
                %>

                Dobro dosli <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Logout.aspx">Odjava</asp:HyperLink>
            <%
                }
                else {
                %>

            <asp:TextBox ID="TextBox1" runat="server" Text="Korisnicko ime"></asp:TextBox><br /><br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Text="Password"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Prijavi se" OnClick="Button1_Click1" />
            <%
                }%>
        </div>
    </form>
</body>
</html>
