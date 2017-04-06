using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PainelAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TRECHO VERIFICA SE EXISTE A SESSAO  "autenticado", SE NÃO EXISTIR
        //REDIRECIONA O USUARIO PARA A PAGE INDEX
        if (Session["autenticado"]==null)
        {
            Response.Redirect("index.aspx");
        }
        lblUsuario.Text = Session["nome"].ToString();
    }
}