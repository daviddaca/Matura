<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Zadatak12.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Knjiga utisaka</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 12</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Knjiga utisaka</label>
                </div>
            </div>
            <div class="back_panel">
                <h2>Knjiga utisaka</h2>
                <hr class="my_hr" />
                <div>
                    <asp:Label ID="lblerror_message" ForeColor="Red" runat="server" Text="" ></asp:Label>
                    <div class="filed_holder">
                        <div class="filed_label">
                            <label>Ime:</label>
                        </div>
                        <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                    </div>
                    <div class="filed_holder">
                        <div class="filed_label">
                            <label>Email:</label>
                        </div>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </div>
                    <div class="filed_holder">
                        <div class="filed_label">
                            <label>Komenatar:</label>
                        </div>
                        <asp:TextBox ID="txtKomentar" runat="server" TextMode="MultiLine" Rows="5" Columns="50"></asp:TextBox>
                    </div>
                </div>
                <hr class="my_hr" />
                <div>
                    <asp:Button ID="btnSnimi" runat="server" Text="Dodaj komentar" OnClick="btnSnimi_Click"/>                  
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
