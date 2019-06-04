<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KursNaDan.aspx.cs" Inherits="Zadatak10WebApp.KursNaDan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kursna lista na dan</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 10</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Kursna lista</label>
                </div>
            </div>
            <div class="back_panel">

                 <asp:Label ID="lblerror_message" runat="server" Text=""></asp:Label>

                <div class="search_criteria">
                    <asp:Label ID="Label1" runat="server" Text="Datum:"></asp:Label>
                    <asp:TextBox ID="txtDatum" runat="server"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="Valuta:"></asp:Label>
                    <asp:DropDownList ID="ddlValute" runat="server"></asp:DropDownList>
                    <asp:Button ID="btnPrikazi" runat="server" Text="Prikaži" OnClick="btnPrikazi_Click" />
                    <asp:Button ID="btnDodaj" runat="server" Text="Dodaj" OnClick="btnDodaj_Click" />
                </div>

                <hr class="my_hr" />

                <div class="kurs_na_dan_holder">
                    <label class="kurs_na_dan">Kurs na dan:</label>
                    <asp:Label CssClass="kurs_na_dan" ID="lblKursNaDan" runat="server" Text="Label"></asp:Label>
                </div>

            </div>
            <div class="footer">
                <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                <a href="/about.aspx">O autoru</a>
                <a href="/UnosKursa.aspx">Unos kursa</a>                
            </div>
        </div>
    </form>
</body>
</html>
