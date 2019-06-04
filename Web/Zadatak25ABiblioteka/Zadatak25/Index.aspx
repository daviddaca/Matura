<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Zadatak25.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Biblioteka</title>
    <link type="text/css" rel="stylesheet" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 25</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Biblioteka</label>
                </div>
            </div>

            <div class="back_panel">
                <div>
                    Operater:
                    <asp:Label ID="lblOperater" runat="server" Text=""></asp:Label>
                    <asp:LinkButton ID="lnkOdjava" runat="server" OnClick="lnkOdjava_Click">Odjavi se</asp:LinkButton>
                </div>

                <hr class="my_hr" />

                <asp:Label ID="error_message" runat="server" Visible="false" Text=""></asp:Label>
                <asp:Table ID="tbl_knjige" runat="server">
                    <asp:TableRow>
                        <asp:TableHeaderCell CssClass="colISBN" Text="ISBN"></asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="colNaslov" Text="Naslov"></asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="colStanje" Text="Stanje"></asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="colCitano" Text="Čitano"></asp:TableHeaderCell>
                    </asp:TableRow>
                </asp:Table>
            </div>

            <div class="footer">
                <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                <a href="/about.aspx">O autoru</a>
                <a href="/uputstvo.aspx">Uputstvo</a>
            </div>
        </div>
    </form>
</body>
</html>
