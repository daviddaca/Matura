<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Zadatak12.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>O autoru</title>
    <link rel="stylesheet" type="text/css" href="MyStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="page_holder">
                <div class="header_panel">
                    <div class="zadatak_no">
                        <label class="label_text">Zadatak 12</label>
                    </div>
                    <div class="zadatak_naziv">
                        <label class="label_text">Knjiga utisaka</label>
                    </div>
                </div>
                <div class="about">
                    <div>
                        <h3>Podaci o autoru</h3>
                    </div>
                    <div>
                        <label><strong>Učenik:</strong> Ime i prezime</label>
                    </div>
                    <div>
                        <label><strong>Odeljenje:</strong> IV-4</label>
                    </div>
                    <div>
                        <label><strong>E-mail:</strong> ucenik@email.com</label>
                    </div>
                </div>
                <div class="footer">
                    <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                    <a href="/uputstvo.aspx">Uputstvo</a>
                    <a href="/index.aspx">Početna</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
