<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Zadatak25.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Biblioteka</title>
    <link type="text/css" rel="stylesheet" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="page_holder">
            <div class="header_panel">
                <div class="zadatak_no">
                    <label class="label_text">Zadatak 25</label>
                </div>
                <div class="zadatak_naziv">
                    <label class="label_text">Biblioteka</label>
                </div>
            </div>

            <div class="back_panel">
                <div class="login_form">
                    <asp:Label ID="error_message" runat="server" Visible="false" Text=""></asp:Label>

                    <div class="login_data">
                        <div class="login_label">
                            <asp:Label ID="Label1" runat="server" Text="Korisničko ime"></asp:Label>
                        </div>
                        <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
                    </div>
                    <div class="login_data">
                        <div class="login_label">
                            <asp:Label ID="Label2" runat="server" Text="Lozinka"></asp:Label>
                        </div>
                        <asp:TextBox ID="txt_passowrd" TextMode="Password" runat="server"></asp:TextBox>
                    </div>
                    <div class="login_data">
                        <asp:Button ID="btn_login" runat="server" Text="Prijavi se" OnClick="btn_login_Click" />
                    </div>
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
