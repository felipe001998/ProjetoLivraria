<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarProduto.aspx.cs" Inherits="produtos_AlterarProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Alterar Produto</h2>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/PainelAdmin.aspx">Painel</asp:HyperLink>
        &gt;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/produtos/IndexProduto.aspx">Produtos</asp:HyperLink>
        &gt;<asp:Label ID="Label8" runat="server" Text="Alterar"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Código:"></asp:Label>
        <asp:Label ID="lblCodigo" runat="server"></asp:Label>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Quantidade:"></asp:Label>
            <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblTipo" runat="server" Text="Tipo:"></asp:Label>
            <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Preço da compra:"></asp:Label>
            <asp:TextBox ID="txtPrecocompra" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label6" runat="server" Text="Preço da venda:"></asp:Label>
        <asp:TextBox ID="txtPrecovenda" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAlterar" runat="server" OnClick="btnAlterar_Click" Text="Alterar" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblMensagem" runat="server" Text="Preencha os campos e clique no botão cadastrar"></asp:Label>
        <p>
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/produtos/IndexProduto.aspx">Voltar</asp:HyperLink>
        </p>
    </form>
</body>
</html>
