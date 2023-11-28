using FolhaFacil.br.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFacil.br.projeto.controller
{
    class ItensAcrescimoController
    {

        private SqlConnection conexao;

        public ItensAcrescimoController()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(ItensAcrescimo obj)
        {
            //1 passo - comando sql
            string sql = @"insert into TB_ITENSACRESCIMO (TB_ITENSACRESCIMO_QTD, TB_ITENSACRESCIMO_VALORT, TB_ACRESCIMOS_ID, TB_FOLHA_ID) values(@itensacrescimo_qtd, @itensacrescimo_valort, @itensacrescimo_acrescimos, @itensacrescimo_folha)";
            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@itensacrescimo_qtd", obj.Qtd);
            comando.Parameters.AddWithValue("@itensacrescimo_valort", obj.ValorTotal);
            comando.Parameters.AddWithValue("@itensacrescimo_acrescimos", obj.Acrescimo);
            comando.Parameters.AddWithValue("@itensacrescimo_folha", obj.Folha);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        #region mostrar acrescimo

        public DataTable CarregarAcrescimo()
        {
            ConexaoController conexaoc = new ConexaoController();

            string comando = "select * from TB_ACRESCIMOS";

            DataTable dt = conexaoc.ConsultarRegistro(comando);

            return dt;
        }


        #endregion

        public void excluiracresc(ItensAcrescimo obj)
        {

            //1 passo - comando sql
            string sql = @"delete from TB_ITENSACRESCIMO
                                where TB_FOLHA_ID = @itensa_folha";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@itensa_folha", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }
    }
}
