using FolhaFacil.br.projeto.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFacil.br.projeto.controller
{
    class ItensDescontoController
    {

        private SqlConnection conexao;

        public ItensDescontoController()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(ItensDesconto obj)
        {
            //1 passo - comando sql
            string sql = @"insert into TB_ITENSDESCONTO (TB_ITENSDESCONTO_QTD, TB_ITENSDESCONTO_VALORT, TB_DESCONTOS_ID, TB_FOLHA_ID) values(@itensdesconto_qtd, @itensdesconto_valort, @itensdesconto_descontos, @itensdesconto_folha)";
            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@itensdesconto_qtd", obj.Qtd);
            comando.Parameters.AddWithValue("@itensdesconto_valort", obj.ValorTotal);
            comando.Parameters.AddWithValue("@itensdesconto_descontos", obj.Desconto);
            comando.Parameters.AddWithValue("@itensdesconto_folha", obj.Folha);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        #region mostrar desconto

        public DataTable CarregarDescontoo()
        {
            ConexaoController conexaoc = new ConexaoController();

            string comando = "select * from TB_DESCONTOS";

            DataTable dt = conexaoc.ConsultarRegistro(comando);

            return dt;
        }


        #endregion

        public void excluirdescont(ItensDesconto obj)
        {

            //1 passo - comando sql
            string sql = @"delete from TB_ITENSDESCONTO
                                where TB_FOLHA_ID = @itensd_folha";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@itensd_folha", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }
    }
}
