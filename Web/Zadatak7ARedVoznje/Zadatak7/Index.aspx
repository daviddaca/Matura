<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Vezba5.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Red vožnje</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 7</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Red vožnje</label>
                </div>
            </div>
            <div class="back_panel">
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Linija:"></asp:Label>
                    <asp:DropDownList ID="cmbLinije" runat="server" OnSelectedIndexChanged="cmbLinije_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

                    <asp:Label ID="Label2" runat="server" Text="Smer:"></asp:Label>
                    <asp:DropDownList ID="cmbSmerovi" runat="server"></asp:DropDownList>

                    <asp:Button ID="btnPrikazi" runat="server" Text="Prikaži" OnClick="btnPrikazi_Click" />

                </div>
                <hr class="my_hr" />
                <div>
                    <asp:Label ID="Label3" runat="server" Text="Polasci:"></asp:Label>
                </div>
                <div>
                    <asp:Table ID="tblPolasci" runat="server"></asp:Table>
                </div>
            </div>
            <div class="footer">
                <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                <a href="/about.aspx">O autoru</a>
                <a href="/uputstvo.aspx">Uputstvo</a>
                <a href="/kontakt.aspx">Kontakt</a>
            </div>
        </div>
    </form>
</body>
</html>
