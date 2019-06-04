<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dodavanje.aspx.cs" Inherits="Recnik.Dodavanje" %>

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
                <asp:Label ID="lblError" runat="server" Text="" Visible="false"></asp:Label>

                <div>
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Engleska reč"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtEngleskaRec" runat="server"></asp:TextBox>
                </div>

                <div>
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Srpska reč"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtSrpskaRec" runat="server"></asp:TextBox>
                </div>

                <div>
                    <div>
                        <asp:Label ID="Label3" runat="server" Text="Opis"></asp:Label>
                    </div>
                    <asp:TextBox ID="txtOpis" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
                </div>

                <asp:Button ID="btnSnimi" runat="server" Text="Snimi" OnClick="btnSnimi_Click" />
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
