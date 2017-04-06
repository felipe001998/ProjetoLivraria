using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Session.Abandon();
        }
    }

    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Server=AME0556329W10-1\\SQLEXPRESS;Database=DB_LIVRARIA;Trusted_Connection=Yes;"))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM TB_USUARIOS where NOME_USUARIO = @usuario AND SENHA =@senha", con))
            {
                cmd.Parameters.AddWithValue("usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                try
                {
                    con.Open();
                    SqlDataReader sdrUsuario = cmd.ExecuteReader();
                    sdrUsuario.Read();
                    if (sdrUsuario.HasRows)
                    {
                        Session["autenticado"] = "OK";
                        Session["nome"] = sdrUsuario.GetString(1);
                        Response.Redirect("PainelAdmin.aspx");
                    }
                    else
                    {
                        lblMensagem.Text = "Usuario ou senha inválido";
                    }
                }
                catch(Exception ex)
                {
                    lblMensagem.Text = "Erro de banco de dados. Contate o suporte." + ex.Message;
                }
            }
        }
    }
}