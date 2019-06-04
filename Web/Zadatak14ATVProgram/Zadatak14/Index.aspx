<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Zadatak14.Index" %>

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
                    <label class="label_text">Zadatak 14</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">TV Program</label>
                </div>
            </div>
            <div class="back_panel">
                <div class="search_parameters">
                    <div class="src_datum">
                        <label>Datum:</label>
                        <asp:DropDownList ID="ddlDatum" runat="server"></asp:DropDownList>
                    </div>
                    <div class="src_tip_emisije">
                        <label>Tip emisije:</label>
                        <asp:DropDownList ID="ddlTipEmisije" runat="server"></asp:DropDownList>
                    </div>
                    <div>
                        <asp:Button ID="btnSearch" runat="server" Text="Pronadji" OnClick="btnSearch_Click" />
                    </div>
                </div>
                 <div style="clear:both;"></div>
                 <hr class="my_hr" />
                <div>
                    <asp:Table ID="tblEmisije" class="tabela" runat="server">
                        <asp:TableRow>
                            <asp:TableHeaderCell CssClass="colVreme" Text="Vreme"></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="colNaziv" Text="Naziv Emisije"></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="colTip" Text="Tip Emisije"></asp:TableHeaderCell>
                        </asp:TableRow>
                    </asp:Table>
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
