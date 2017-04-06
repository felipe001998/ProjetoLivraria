using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class produtos_AlterarProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            string codigo = Request.QueryString["ID"];
            lblCodigo.Text = codigo;


            using (SqlConnection con = new SqlConnection("Server=AME0556329W10-1\\SQLEXPRESS;Database=DB_LIVRARIA;Trusted_Connection=Yes"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TB_PRODUTOS WHERE ID_PRODUTO =" + codigo, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader sdrInfPosts = cmd.ExecuteReader();
                        sdrInfPosts.Read();

                        txtNome.Text = sdrInfPosts.GetString(1);
                        txtTipo.Text = sdrInfPosts.GetString(2);
                        txtQuantidade.Text = sdrInfPosts.GetInt32(3).ToString();
                        txtPrecocompra.Text = sdrInfPosts.GetDecimal(4).ToString();
                        txtPrecovenda.Text = sdrInfPosts.GetDecimal(5).ToString();
                    }
                    catch
                    {
                        //Mensagem de Erro
                        lblMensagem.Text = "Erro do Banco de Dados. Contate o Suporte!";
                    }
                }
            }
        }
    }
}