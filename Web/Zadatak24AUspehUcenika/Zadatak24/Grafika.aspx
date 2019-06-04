<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grafika.aspx.cs" Inherits="Zadatak24.Grafika" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

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
                    <asp:Chart ID="Chart" runat="server" Height="421px" Width="715px">
                        <Titles>
                            <asp:Title Text="Uspeh učenika po razredima"></asp:Title>
                        </Titles>
                        <Series>
                            <asp:Series Name="UspehUcenika" ChartType="Column" ChartArea="MainChartArea" BackGradientStyle="TopBottom" IsValueShownAsLabel="true">
                            </asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="MainChartArea"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </div>
            </div>
            <div class="footer">
                <label class="label_text">Elektrotehnička škola "Nikola Tesla" Niš</label>
                <a href="/about.aspx">O autoru</a>
                <a href="/uputstvo.aspx">Uputstvo</a>
                <a href="/index.aspx">Početna</a>
            </div>
        </div>
    </form>
</body>
</html>
