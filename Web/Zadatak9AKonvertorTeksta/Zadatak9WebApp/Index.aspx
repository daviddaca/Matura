<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Zadatak9WebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Konvertor teksta</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 9</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Konvertor teksta</label>
                </div>
            </div>
            <div class="field_holder">
                <div>
                    <label>Tekst na latinici:</label>
                </div>
                <div>
                    <asp:TextBox ID="txtLatinica" runat="server" TextMode="MultiLine" Columns="80" Rows="10"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnLatUCir" runat="server" Text="Prevedu na ćirilicu" OnClick="btnLatUCir_Click" />
                </div>
                <hr class="my_hr" />
                <div>
                    <label>Tekst na ćirilici:</label>
                </div>
                <div>
                    <asp:TextBox ID="txtCirilica" runat="server" TextMode="MultiLine" Columns="80" Rows="10"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnCirULat" runat="server" Text="Prevedu na latinicu" OnClick="btnCirULat_Click" />
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
