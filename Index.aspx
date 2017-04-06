<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Livraria leia feliz :)</h1>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </p>
    
    </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
        <p>
            <asp:Label ID="lblMensagem" runat="server" Text="Preecha o usuario e senha para acessar o sistema"></asp:Label>
        </p>
    </form>
</body>
</html>
