<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Recnik.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Englesko - Srpski rečnik</title>
    <link type="text/css" rel="stylesheet" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 19</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Englesko - Srpski rečnik</label>
                </div>
            </div>

            <div class="back_panel">
                <div class="page_header">
                    <h2>Englesko - Srpski rečnik</h2>
                </div>
                <hr class="my_hr" />
                <div style="padding-top: 5px;">
                    <asp:DropDownList ID="cmb_smer" runat="server"></asp:DropDownList>
                </div>
                <div style="padding-top: 5px;">
                    <asp:Label ID="lbl_rec" runat="server" Text="Reč za prevod"></asp:Label>
                    <asp:TextBox ID="txt_rec" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_prevedi" runat="server" Text="Prevedi" OnClick="btn_prevedi_Click" />
                </div>
                <hr class="my_hr" />
                <asp:Label ID="lvlprevod" runat="server" Text="Prevod:"></asp:Label>
                <div>
                    <asp:ListBox ID="lst_prevod" runat="server" Width="229px"></asp:ListBox>
                </div>
            </div>

            <div class="footer">
                <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                <a href="/about.aspx">O autoru</a>
                <a href="/uputstvo.aspx">Uputstvo</a>
                <a href="/dodavanje.aspx">Dodaj</a>
            </div>
        </div>
    </form>
</body>
</html>
