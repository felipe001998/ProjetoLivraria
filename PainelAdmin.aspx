<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PainelAdmin.aspx.cs" Inherits="PainelAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>&nbsp;</h2>
        <h2>Livraria Leia Feliz :)</h2>
        <p>
            <strong>Painel Administrativo</strong></p>
    
        <asp:Label ID="lblUsuario" runat="server" Text="Label"></asp:Label>
&nbsp;-
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx">Sair</asp:HyperLink>
    
    </div>
    <p>
        <strong>Usuarios</strong></p>
    <ul>
        <li>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/usuarios/CadastrarUsuario.aspx">Cadastrar Usuario</asp:HyperLink>
        </li>
        <li>Listar todos</li>
        <li>Pesquisar</li>
    </ul>
    <p>
        <strong>Produtos</strong></p>
    <ul>
        <li>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/produtos/CadastrarProduto.aspx">Cadastrar Produto</asp:HyperLink>
        </li>
        <li>Listar todos</li>
        <li>Pesquiar</li>
    </ul>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
