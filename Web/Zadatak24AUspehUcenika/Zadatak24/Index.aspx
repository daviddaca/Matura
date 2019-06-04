<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Zadatak24.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Uspeh učenika</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 24</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Uspeh učenika</label>
                </div>
            </div>
            <div class="back_panel">
                <div>
                    <asp:Label ID="err_label" runat="server" Text="" Visible="false"></asp:Label>
                </div>
                <div>
                    <asp:GridView ID="GridView" runat="server">
                        <Columns>
                            <asp:BoundField DataField="Razred" HeaderText="Razred" />
                            <asp:BoundField DataField="Nedovoljan" HeaderText="Br. nedovoljnih" />
                            <asp:BoundField DataField="Dovoljan" HeaderText="Br. dovoljnih" />
                            <asp:BoundField DataField="Dobar" HeaderText="Br. dobrih" />
                            <asp:BoundField DataField="Vrlodobar" HeaderText="Br. vrlodobrih" />
                            <asp:BoundField DataField="Odlican" HeaderText="Br. odličnih" />
                            <asp:BoundField DataField="ProsecnaOcena" HeaderText="Prosečna ocena" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            <div class="footer">
                <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                <a href="/about.aspx">O autoru</a>
                <a href="/uputstvo.aspx">Uputstvo</a>
                <a href="/grafika.aspx">Grafika</a>
            </div>
        </div>
    </form>
</body>
</html>
