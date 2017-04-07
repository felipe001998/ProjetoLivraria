<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExcluirProduto.aspx.cs" Inherits="produtos_ExcluirProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    
        <h2>Excluir Produto</h2>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/PainelAdmin.aspx">Painel</asp:HyperLink>
        &gt;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/produtos/IndexProduto.aspx">Produtos</asp:HyperLink>
        &gt;<asp:Label ID="Label8" runat="server" Text="Excluir"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Código:"></asp:Label>
        <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
        <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Quantidade:"></asp:Label>
            <asp:Label ID="lblQuantidade" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lbllabel" runat="server" Text="Tipo:"></asp:Label>
            <asp:Label ID="lblTipo" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Preço da compra:"></asp:Label>
            <asp:Label ID="lblPrecocompra" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Label ID="Label6" runat="server" Text="Preço da venda:"></asp:Label>
        <asp:Label ID="lblPrecovenda" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <p>
            <asp:Button ID="btnExcluir" runat="server" OnClick="btnCadastrar_Click" Text="Excluir" />
        </p>
        <asp:Label ID="lblMensagem" runat="server" Text="Clique em Excluir se deseja Excluir o produto"></asp:Label>
        <p>
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/produtos/IndexProduto.aspx">Voltar</asp:HyperLink>
        </p>
    
    </div>
    </form>
</body>
</html>
