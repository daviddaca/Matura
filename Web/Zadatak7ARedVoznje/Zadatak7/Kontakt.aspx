<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kontakt.aspx.cs" Inherits="Vezba5.Kontakt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kontakt</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="page_holder">
                <div class="header_panel">
                    <div class="zadatak_no">
                        <label class="label_text">Zadatak 7</label>
                    </div>
                    <div class="zadatak_naziv">
                        <label class="label_text">Red vožnje</label>
                    </div>
                </div>
                <div class="kontakt">
                    <h2>Kontakt</h2>
                    <hr class="my_hr" />
                    <div class="form-control">
                        <div>
                            <asp:Label ID="Label1" runat="server" Text="Ime i prezime:"></asp:Label>
                        </div>
                        <div>
                            <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-control">
                        <div>
                            <asp:Label ID="Label2" runat="server" Text="E-mail:"></asp:Label>
                        </div>
                        <div>
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-control">
                        <div>
                            <asp:Label ID="Label3" runat="server" Text="Napomena:"></asp:Label>
                        </div>
                        <div>
                            <asp:TextBox ID="txtNapomena" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <asp:Button ID="btnPosalji" runat="server" Text="Pošalji" />
                    </div>
                </div>
                <div class="footer">
                    <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                    <a href="/about.aspx">O autoru</a>
                    <a href="/index.aspx">Početna</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
