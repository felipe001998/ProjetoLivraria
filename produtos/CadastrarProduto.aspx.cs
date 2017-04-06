using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class produtos_CadastrarProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Server=AME0556329W10-1\\SQLEXPRESS;Database=DB_LIVRARIA;Trusted_Connection=Yes"))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO TB_PRODUTOS (NOME, TIPO, QUANTIDADE, PRECO_COMPRA, PRECO_VENDA) VALUES (@NOME, @TIPO, @QUANTIDADE, @PRECO_COMPRA, @PRECO_VENDA)", con))
            {
                int precocompra;
                precocompra = Convert.ToInt32(txtPrecocompra.Text);
                precocompra = int.Parse(txtPrecocompra.Text);

                int precovenda;
                precovenda = Convert.ToInt32(txtPrecovenda.Text);
                precovenda = int.Parse(txtPrecovenda.Text);

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
                        lblMensagem.Text = "Produto cadastrado com sucesso";
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = "Erro: " + ex;
                }
            }
        }
    }
}