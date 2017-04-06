<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IndexProduto.aspx.cs" Inherits="produtos_IndexProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PainelAdmin.aspx">Painel</asp:HyperLink>
        &gt;<asp:Label ID="Label1" runat="server" Text="Produtos"></asp:Label>
    
    </div>
        <h3>
            <asp:Label ID="Label2" runat="server" Text="Livraria Leia Feliz :)"></asp:Label>
        </h3>
        <asp:Label ID="Label3" runat="server" Text="Modulos de Produtos"></asp:Label>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/produtos/CadastrarProduto.aspx">Cadastrar novo Produto</asp:HyperLink>
        </p>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/produtos/PesqusiarProduto.aspx">Pesquisar Produto</asp:HyperLink>
        <asp:DataList ID="dtlProdutos" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("NOME") %>'></asp:Label>
                &nbsp;-
                <asp:Label ID="Label6" runat="server" Text='<%# Eval("QUANTIDADE") %>'></asp:Label>
                &nbsp;-
                <asp:Label ID="Label7" runat="server" Text='<%# Eval("PRECO_COMPRA") %>'></asp:Label>
                &nbsp;-
                <asp:Label ID="Label8" runat="server" Text='<%# Eval("PRECO_VENDA") %>'></asp:Label>
                &nbsp;-
                <asp:Label ID="Label9" runat="server" Text='<%# Eval("DATA_CADASTRO") %>'></asp:Label>
                &nbsp;-
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl='<%# Eval("ID_PRODUTO","VerProduto.aspx?id={0}") %>' Text='<%# "Ver Produto" %>'></asp:HyperLink>
                &nbsp; -
                <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl='<%# Eval("ID_PRODUTO","AlterarProduto.aspx?id={0}") %>' Text='<%# "Alterar Produto" %>'></asp:HyperLink>
                &nbsp;-
                <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl='<%# Eval("ID_PRODUTO","ExcluirProduto.aspx?id={0}") %>' Text='<%# "Excluir Produto" %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:DataList>
        <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/PainelAdmin.aspx">Voltar</asp:HyperLink>
    </form>
</body>
</html>
