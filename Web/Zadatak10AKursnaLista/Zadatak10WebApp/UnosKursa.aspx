<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnosKursa.aspx.cs" Inherits="Zadatak10WebApp.UnosKursa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unos kursa</title>
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
                <h2>Unos kursa</h2>
                <hr class="my_hr" />
                <div>
                    <asp:Label ID="lblerror_message" ForeColor="Red" runat="server" Text="Label"></asp:Label>
                    <div class="filed_holder">
                        <div class="filed_label">
                            <label>Datum:</label>
                        </div>
                        <asp:TextBox ID="txtDatum" runat="server"></asp:TextBox>
                    </div>
                    <div class="filed_holder">
                        <div class="filed_label">
                            <label>Valuta:</label>
                        </div>
                        <asp:DropDownList ID="ddlValute" runat="server"></asp:DropDownList>
                    </div>
                    <div class="filed_holder">
                        <div class="filed_label">
                            <label>Iznos:</label>
                        </div>
                        <asp:TextBox ID="txtIznos" runat="server"></asp:TextBox>
                    </div>
                </div>
                <hr class="my_hr" />
                <div>
                    <asp:Button ID="btnSnimi" runat="server" Text="Snimi" OnClick="btnSnimi_Click" />
                    <asp:Button ID="btnOdustani" runat="server" Text="Odustani" OnClick="btnOdustani_Click" />
                </div>
            </div>
            <div class="footer">
                <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                <a href="/about.aspx">O autoru</a>
                <a href="/KursNaDan.aspx">Kurs na dan</a>
            </div>
        </div>
    </form>
</body>
</html>
