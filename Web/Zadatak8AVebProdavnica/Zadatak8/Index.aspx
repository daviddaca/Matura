<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Vezba7.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Veb prodavnica</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 8</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Veb prodavnica</label>
                </div>
            </div>
            <div class="back_panel">
                <div>
                    <div style="width: 100px; height: 100px; float: left; background-image: url('/Slike/webshop.png'); background-size: 100px 80px; background-repeat: no-repeat;"></div>
                    <h1 style="text-align: center; color: #264c73;">Web prodavnica</h1>
                </div>
                <div style="clear: both;"></div>
                <div style="background-color: gray; height: 3px;"></div>
                <div style="background-color: white; height: 100px; padding-top: 5px;">
                    <div>
                        Parametri za pretragu:
                    </div>
                    <div style="padding-top: 5px; float: left; margin: 5px;">
                        <div style="width: 250px;">
                            <asp:Label CssClass="searchlabel" ID="lblProizvodjac" runat="server" Text="Proizvođač: "></asp:Label>
                            <asp:DropDownList ID="Proizvodjac" runat="server"></asp:DropDownList>
                        </div>
                        <div style="width: 250px;">
                            <asp:Label CssClass="searchlabel" ID="lblRadnaMemorija" runat="server" Text="RAM: "></asp:Label>
                            <asp:DropDownList ID="RadnaMemorija" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div style="padding-top: 5px; float: left; margin: 5px;">
                        <div style="width: 250px;">
                            <asp:Label CssClass="searchlabel" ID="lblKamera" runat="server" Text="Kamera: "></asp:Label>
                            <asp:DropDownList ID="Kamera" runat="server"></asp:DropDownList>
                        </div>
                        <div style="width: 250px;">
                            <asp:Label CssClass="searchlabel" ID="lblDualSim" runat="server" Text="Dual SIM: "></asp:Label>
                            <asp:DropDownList ID="DualSIM" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div style="padding-top: 5px; float: left; margin: 5px;">
                        <div style="width: 250px;">
                            <asp:Label CssClass="searchlabel" ID="lblEkran" runat="server" Text="Ekran: "></asp:Label>
                            <asp:DropDownList ID="Ekran" runat="server"></asp:DropDownList>
                        </div>
                        <div style="width: 250px;">
                            <asp:Label CssClass="searchlabel" ID="lblProcesor" runat="server" Text="Procesor: "></asp:Label>
                            <asp:DropDownList ID="Procesor" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div>
                        <asp:Button ID="btnTrazi" runat="server" Text="Traži" OnClick="btnTrazi_Click" />
                    </div>
                    <div style="clear: both;"></div>
                </div>
                <div style="background-color: gray; height: 3px;"></div>
                <div style="background-color: white; padding-top: 10px;">
                    <asp:Table CssClass="tabela" GridLines="Both" ID="tblProizvodi" runat="server"></asp:Table>
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
