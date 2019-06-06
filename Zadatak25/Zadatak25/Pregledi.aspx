<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pregledi.aspx.cs" Inherits="Pregledi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml%22%3E
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<asp:GridView ID="Gridview1" runat="server" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging" PageSize="5">
    <Columns>
        <asp:BoundField DataField="ISBN" HeaderText="ISBN" ItemStyle-Width="80" />
        <asp:BoundField DataField="naslov" HeaderText="naslov" ItemStyle-Width="150" />
        <asp:BoundField DataField="stanje" HeaderText="stanje" ItemStyle-Width="150" />
        <asp:BoundField DataField="citano" HeaderText="citano" ItemStyle-Width="150" />
    </Columns>
</asp:GridView>
        </div>
    </form>
</body>
</html>
