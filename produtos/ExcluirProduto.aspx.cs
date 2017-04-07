using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class produtos_ExcluirProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string codigo = Request.QueryString["ID"];
        lblID.Text = codigo;

        using (SqlConnection con = new SqlConnection("Server=AME0556329W10-1\\SQLEXPRESS;Database=DB_LIVRARIA;Trusted_Connection=Yes"))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM TB_PRODUTOS WHERE ID_PRODUTO =" + codigo, con))
            {
                try
                {
                    con.Open();
                    SqlDataReader sdrInfPosts = cmd.ExecuteReader();
                    sdrInfPosts.Read();

                    lblNome.Text = sdrInfPosts.GetString(1);
                    lblTipo.Text = sdrInfPosts.GetString(2);
                    lblQuantidade.Text = sdrInfPosts.GetInt32(3).ToString();
                    lblPrecocompra.Text = sdrInfPosts.GetDecimal(4).ToString();
                    lblPrecovenda.Text = sdrInfPosts.GetDecimal(5).ToString();
                }
                catch
                {
                    //Mensagem de Erro
                    lblMensagem.Text = "Erro do Banco de Dados. Contate o Suporte!";
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        string codigo = Request.QueryString["ID"];

        using (SqlConnection con = new SqlConnection("Server=AME0556329W10-1\\SQLEXPRESS;Database=DB_LIVRARIA;Trusted_Connection=Yes"))
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM TB_PRODUTOS WHERE ID_PRODUTO = " + codigo, con))
            {

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lblNome.Text = "";
                    lblTipo.Text = "";
                    lblQuantidade.Text = "";
                    lblPrecocompra.Text = "";
                    lblPrecovenda.Text = "";

                    lblMensagem.Text = "Post Excluido com Sucesso!. Volte para a Index no botão, 'Voltar'";
                }
                catch
                {
                    lblMensagem.Text = "Ocorreu um erro no banco de dados. Contate a Assistência!";
                }
            }
        }
    }
}
