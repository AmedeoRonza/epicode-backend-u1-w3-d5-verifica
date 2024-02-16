<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Literal ID="MessageLiteral" runat="server"></asp:Literal>
<asp:Button ID="Button1" runat="server" Text="Aggiungi al carrello" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Torna alla pagina Prodotti" OnClick="Button2_Click" />
    </form>
    <p id="DatiProdotti" runat="server"></p>
    <!-- Qui verranno visualizzati i dettagli del prodotto, incluso l'immagine -->
    
    <asp:Image ID="imgProdotto" runat="server" />
</body>
</html>
