<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Zadatak11.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Numerološko slaganje</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text" >Zadatak 11</label>
                </div>
                <div class="zadatak_naziv">  
                    <label class="label_text">Numerološko slaganje</label>
                </div>
            </div>
            <div class="back_panel">
                <div class="podaci_o_osobi">
                    <div>
                        <h2>Osoba 1</h2>
                        <hr class="my_hr" />
                    </div>
                    <div>
                        <label>Ime osobe:</label>
                    </div>
                    <div>
                        <asp:TextBox ID="txtImeOsobe1" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <label>Datum rodjenja:</label>
                    </div>
                    <div>
                        <asp:TextBox ID="txtDatumRodjenja1" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="back_panel">
                <div class="podaci_o_osobi">
                    <div>
                        <h2>Osoba 2</h2>
                        <hr class="my_hr" />
                    </div>
                    <div>
                        <label>Ime osobe:</label>
                    </div>
                    <div>
                        <asp:TextBox ID="txtImeOsobe2" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <label>Datum rodjenja:</label>
                    </div>
                    <div>
                        <asp:TextBox ID="txtDatumRodjenja2" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div style="clear: both;"></div>
            <div class="command">
                <asp:Button ID="btnIzracunaj" runat="server" Text="Izračunaj" OnClick="btnIzracunaj_Click" />
                <hr class="my_hr" />
            </div>
            <div class="result">
                <asp:Label ID="lblerror_message" runat="server" Text=""></asp:Label>
                <asp:Panel ID="pnlResult" runat="server" Visible="false">
                    <div>
                        <div class="result_holder_names">
                            <div class="result_field">
                                <label>
                                    <asp:Label class="result_label1" ID="lblImeOsobe1" runat="server" Text=""></asp:Label>
                                </label>
                            </div>
                        </div>
                        <div class="result_holder">
                            <div class="result_field">
                                <label>
                                    <asp:Label class="result_label_percent" ID="lblProcenatSlaganja" runat="server" Text=""></asp:Label>
                                </label>
                            </div>
                        </div>
                        <div class="result_holder_names">
                            <div class="result_field">
                                <label>
                                    <asp:Label class="result_label2" ID="lblImeOsobe2" runat="server" Text=""></asp:Label>
                                </label>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <div style="clear: both;"></div>
            <div class="footer">
                <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                <a href="/about.aspx">O autoru</a>
                <a href="/uputstvo.aspx">Uputstvo</a>
            </div>
        </div>
    </form>
</body>
</html>
