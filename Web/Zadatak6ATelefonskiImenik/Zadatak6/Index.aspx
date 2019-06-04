<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Vezba4.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Telefonski imenik</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 6</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Telefonski imenik</label>
                </div>
            </div>
            <div class="back_panel">
                <div style="background-color: white; height: 100px; padding-top: 5px;">
                    <div>
                        Parametri za pretragu:
                    </div>
                    <div style="padding-top: 5px; float: left; margin: 5px;">
                        <div style="width: 250px;">
                            <asp:Label ID="lblIme" runat="server" Text="Ime: "></asp:Label>
                            <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                        </div>
                        <div style="width: 250px;">
                            <asp:Label ID="lblPrezime" runat="server" Text="Prezime: "></asp:Label>
                            <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div style="padding-top: 5px; float: left; margin: 5px;">
                        <div style="width: 250px;">
                            <asp:Label ID="Label1" runat="server" Text="Adresa: "></asp:Label>
                            <asp:TextBox ID="txtAdresa" runat="server"></asp:TextBox>
                        </div>
                        <div style="width: 250px;">
                            <asp:Label ID="Mesto" runat="server" Text="Mesto: "></asp:Label>              
                            <asp:DropDownList ID="cmbMesta" runat="server"></asp:DropDownList>             
                        </div>
                    </div>
                    <div style="padding-top: 5px; float: left; margin: 5px;">
                        <div style="width: 250px;">
                            <asp:Label ID="Label2" runat="server" Text="Telefon: "></asp:Label>
                            <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                        </div>
                        <div style="width: 250px;">
                            <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <asp:Button ID="btnTrazi" runat="server" Text="Traži" OnClick="btnTrazi_Click" />
                    </div>
                    <div style="clear: both;"></div>
                </div>
                <div style="background-color: gray; height: 3px;"></div>
                <div style="background-color: white; padding-top: 10px;">
                    <asp:Table CssClass="tabela" GridLines="Both" ID="tblKontakti" runat="server"></asp:Table>
                </div>
            </div>
            <div class="footer">
                <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                <a href="/about.aspx">O autoru</a>
                <a href="/uputstvo.aspx">Uputstvo</a>
                <a href="/VazniTelefoni.aspx">Važni telefoni</a>
            </div>
        </div>
    </form>
</body>
</html>
