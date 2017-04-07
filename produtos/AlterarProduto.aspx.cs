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

    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        string codigo = Request.QueryString["ID"];
        lblCodigo.Text = codigo;

        using (SqlConnection con = new SqlConnection("Server=AME0556329W10-1\\SQLEXPRESS;Database=DB_LIVRARIA;Trusted_Connection=Yes"))
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE TB_PRODUTOS SET NOME = @NOME, TIPO = @TIPO, QUANTIDADE = @QUANTIDADE, PRECO_COMPRA = @PRECO_COMPRA, PRECO_VENDA = @PRECO_VENDA WHERE ID_PRODUTO = " + codigo, con))
            {
                decimal precocompra;
                precocompra = Convert.ToDecimal(txtPrecocompra.Text);
                precocompra = decimal.Parse(txtPrecocompra.Text);

                decimal precovenda;
                precovenda = Convert.ToDecimal(txtPrecovenda.Text);
                precovenda = decimal.Parse(txtPrecovenda.Text);

                int quantidade;
                quantidade = Convert.ToInt32(txtQuantidade.Text);
                quantidade = int.Parse(txtQuantidade.Text);

                cmd.Parameters.AddWithValue("NOME", txtNome.Text);
                cmd.Parameters.AddWithValue("TIPO", txtTipo.Text);
                cmd.Parameters.AddWithValue("QUANTIDADE", quantidade);
                cmd.Parameters.AddWithValue("PRECO_COMPRA", precocompra);
                cmd.Parameters.AddWithValue("PRECO_VENDA", precovenda);

                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > -1)
                    {
                        lblMensagem.Text = "Produto Alterado com Sucesso!. Volte para a Index no botão, 'Voltar'";
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = "Houve algum problema: " + ex;
                }
            }
        }
    }
}