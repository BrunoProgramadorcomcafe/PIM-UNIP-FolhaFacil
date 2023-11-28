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
    class AcrescimoController
    {

        private SqlConnection conexao;

        public AcrescimoController()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(Acrescimo obj)
        {
            //1 passo - comando sql
            string sql = @"insert into TB_ACRESCIMOS (TB_ACRESCIMOS_DESC, TB_ACRESCIMOS_VALOR) values(@acrescimos_desc, @acrescimos_valor)";
            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@acrescimos_desc", obj.Descricao);
            comando.Parameters.AddWithValue("@acrescimos_valor", obj.Valor);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void alterar(Acrescimo obj)
        {

            //1 passo - comando sql
            string sql = @"update TB_ACRESCIMOS set
                            TB_ACRESCIMOS_DESC = @acrescimos_desc,
                            TB_ACRESCIMOS_VALOR = @acrescimos_valor
                            where TB_ACRESCIMOS_ID = @acrescimos_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@acrescimos_desc", obj.Descricao);
            comando.Parameters.AddWithValue("@acrescimos_valor", obj.Valor);
            comando.Parameters.AddWithValue("@acrescimos_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void excluir(Acrescimo obj)
        {

            //1 passo - comando sql
            string sql = @"delete from TB_ACRESCIMOS
                                where TB_ACRESCIMOS_ID = @acrescimos_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@acrescimos_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        #region consultar acrescimo

        public ColecaoAcrescimo SelecionarAcrescimo()
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoAcrescimo colecaoacrescimo = new ColecaoAcrescimo();
                string comando = "select * from TB_ACRESCIMOS";

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)

                {
                    Acrescimo acrescimo = new Acrescimo();
                    acrescimo.Id1 = Convert.ToInt32(linha["TB_ACRESCIMOS_ID"]);
                    acrescimo.Descricao = linha["TB_ACRESCIMOS_DESC"].ToString();
                    acrescimo.Valor = Convert.ToDouble(linha["TB_ACRESCIMOS_VALOR"]);

                    colecaoacrescimo.Add(acrescimo);

                }

                return colecaoacrescimo;


            }


            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion

        public ColecaoAcrescimo SelecionarEspecifico(Acrescimo acrescimo)
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoAcrescimo colecaoacrescimo = new ColecaoAcrescimo();
                String comando = "Select * from TB_ACRESCIMOS where TB_ACRESCIMOS_DESC like '%" + acrescimo.Descricao + "%'";

                conexaoc.LimparParametros();

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)
                {

                    acrescimo.Id1 = Convert.ToInt32(linha["TB_ACRESCIMOS_ID"]);
                    acrescimo.Descricao = linha["TB_ACRESCIMOS_DESC"].ToString();
                    acrescimo.Valor = Convert.ToDouble(linha["TB_ACRESCIMOS_VALOR"]);

                    colecaoacrescimo.Add(acrescimo);

                }

                return colecaoacrescimo;

            }
            catch (Exception erro)
            {

                throw erro;

            }
        }
    }
}
