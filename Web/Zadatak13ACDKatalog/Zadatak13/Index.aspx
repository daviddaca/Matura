<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Zadatak13.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CD Katalog</title>
    <link type="text/css" rel="stylesheet" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 13</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">CD Katalog</label>
                </div>
            </div>
            <div class="back_panel">
                <div>
                    <asp:Label ID="lbl_error_message" runat="server" Visible="false" ForeColor="Red" Text=""></asp:Label>
                </div>
                <div style="background-color: white; height: 100px; padding-top: 5px;">
                    <div>
                        Parametri za pretragu:
                    </div>
                    <div style="padding-top: 5px; float: left; margin: 5px;">
                        <div style="width: 250px;">
                            <asp:Label ID="Label1" runat="server" Text="Izvodjač"></asp:Label>
                            <asp:TextBox ID="txtIzvodjac" runat="server"></asp:TextBox>
                        </div>
                        <div style="width: 250px;">
                            <asp:Label ID="Label5" runat="server" Text="Naziv"></asp:Label>
                            <asp:TextBox ID="txtNaziv" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div style="padding-top: 5px; float: left; margin: 5px;">
                        <div style="width: 250px;">
                            <asp:Label ID="Label2" runat="server" Text="Žanr"></asp:Label>
                            <asp:DropDownList ID="dlZanr" runat="server"></asp:DropDownList>
                        </div>
                        <div style="width: 250px;">
                            <asp:Label ID="Label3" runat="server" Text="Godina"></asp:Label>
                            <asp:DropDownList ID="dlGodina" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div style="padding-top: 5px; float: left; margin: 5px;">
                        <div style="width: 250px;">
                            <asp:Label ID="Label4" runat="server" Text="Izdavačka kuća"></asp:Label>
                            <asp:TextBox ID="txtIzdavackaKuca" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="btnTrazi" runat="server" Text="Traži" OnClick="btnTrazi_Click" />
                    <div style="clear: both;"></div>
                </div>
                <div style="background-color: gray; height: 3px;"></div>
                <div style="background-color: white; padding-top: 10px;">
                    <asp:Table CssClass="tabela" ID="tblRezultati" runat="server"></asp:Table>
                </div>
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
