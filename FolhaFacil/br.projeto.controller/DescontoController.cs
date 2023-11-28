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
    class DescontoController
    {
        private SqlConnection conexao;

        public DescontoController()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(Desconto obj)
        {
            //1 passo - comando sql
            string sql = @"insert into TB_DESCONTOS (TB_DESCONTOS_DESC, TB_DESCONTOS_VALOR) values(@descontos_desc, @descontos_valor)";
            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@descontos_desc", obj.Descricao);
            comando.Parameters.AddWithValue("@descontos_valor", obj.Valor);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void alterar(Desconto obj)
        {

            //1 passo - comando sql
            string sql = @"update TB_DESCONTOS set
                            TB_DESCONTOS_DESC = @descontos_desc,
                            TB_DESCONTOS_VALOR = @descontos_valor
                            where TB_DESCONTOS_ID = @descontos_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@descontos_desc", obj.Descricao);
            comando.Parameters.AddWithValue("@descontos_valor", obj.Valor);
            comando.Parameters.AddWithValue("@descontos_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void excluir(Desconto obj)
        {

            //1 passo - comando sql
            string sql = @"delete from TB_DESCONTOS
                                where TB_DESCONTOS_ID = @descontos_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@descontos_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        #region consultar desconto

        public ColecaoDesconto SelecionarDesconto()
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoDesconto colecaodesconto = new ColecaoDesconto();
                string comando = "select * from TB_DESCONTOS";

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)

                {
                    Desconto desconto = new Desconto();
                    desconto.Id1 = Convert.ToInt32(linha["TB_DESCONTOS_ID"]);
                    desconto.Descricao = linha["TB_DESCONTOS_DESC"].ToString();
                    desconto.Valor = Convert.ToDouble(linha["TB_DESCONTOS_VALOR"]);

                    colecaodesconto.Add(desconto);

                }

                return colecaodesconto;


            }


            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion

        public ColecaoDesconto SelecionarEspecifico(Desconto desconto)
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoDesconto colecaodesconto = new ColecaoDesconto();
                String comando = "Select * from TB_DESCONTOS where TB_DESCONTOS_DESC like '%" + desconto.Descricao + "%'";

                conexaoc.LimparParametros();

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)
                {

                    desconto.Id1 = Convert.ToInt32(linha["TB_DESCONTOS_ID"]);
                    desconto.Descricao = linha["TB_DESCONTOS_DESC"].ToString();
                    desconto.Valor = Convert.ToDouble(linha["TB_DESCONTOS_VALOR"]);

                    colecaodesconto.Add(desconto);

                }

                return colecaodesconto;

            }
            catch (Exception erro)
            {

                throw erro;

            }
        }
    }
}
