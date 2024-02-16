<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <html>
    <body>
        <main>
            <asp:Repeater ID="ProductRepeater" runat="server">
            <HeaderTemplate>
                <div class="row">
            </HeaderTemplate>
            <ItemTemplate>
    <div class="col-md-3">
        <div class="card">
            <img class="card-img-top" src='<%# Eval("UrlImmagine") %>' alt="headphones" runat="server" id="UrlImmagine" />
            <div class="card-body">
                <h5 class="card-title text-black"><%# Eval("Nome") %></h5>
                <p class="card-text text-black"><%# Eval("Descrizione") %></p>
                <p class="card-text text-black">€<%# Eval("Prezzo") %></p>
                <asp:Button ID="Button1" runat="server" Text="Dettagli" OnClick="Dettagli_Click" />
                <asp:Literal ID="Nome" runat="server" Visible="false" Text='<%# Eval("Nome") %>'></asp:Literal>
                <asp:Literal ID="Prezzo" runat="server" Visible="false" Text='<%# Eval("Prezzo") %>'></asp:Literal>
                <asp:Image ID='Image1' runat="server" Visible="false" Text='<%# Eval("UrlImmagine") %>'></asp:Image>
            </div>
        </div>
    </div>
</ItemTemplate>



            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
        </main>
    </body>
    </html>
</asp:Content>