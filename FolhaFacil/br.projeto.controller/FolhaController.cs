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
    class FolhaController
    {
        private SqlConnection conexao;

        public FolhaController()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(Folha obj)
        {
            //1 passo - comando sql
            string sql = @"insert into TB_FOLHA (TB_FOLHA_PERIODO, TB_FOLHA_VALORFINAL, TB_FOLHA_STATUS, TB_FUNCIONARIO_ID, TB_EMPRESA_ID) values(@folha_periodo, @folha_valorfinal, @folha_status, @folha_funcionario, @folha_empresa)";
            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@folha_periodo", obj.Periodo);
            comando.Parameters.AddWithValue("@folha_valorfinal", obj.ValorFinal);
            comando.Parameters.AddWithValue("@folha_status", obj.Status);
            comando.Parameters.AddWithValue("@folha_funcionario", obj.Funcionario);
            comando.Parameters.AddWithValue("@folha_empresa", obj.Empresa);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public int retornaIdUltimaFolha()
        {

            int id = 0;
            //2 Passo - Organizar o sql
            string sql = "select max(TB_FOLHA_ID) TB_FOLHA_ID from TB_FOLHA";
            SqlCommand comando = new SqlCommand(sql, conexao);


            //3 Passo-abrir aconexao e executaro comando 
            conexao.Open();
            comando.ExecuteNonQuery();

            //4 Passo - criar o SqlDataReader
            SqlDataReader da = comando.ExecuteReader();

            Folha obj = new Folha();

            if (da.Read())
            {

                id = da.GetInt32(0);

            }
            return id;
        }

        #region mostrar empresa

        public DataTable CarregarEmpresa()
        {
            ConexaoController conexaoc = new ConexaoController();

            string comando = "select * from TB_EMPRESA";

            DataTable dt = conexaoc.ConsultarRegistro(comando);

            return dt;
        }


        #endregion

        #region mostrar funcionario

        public DataTable CarregarFuncionario()
        {
            ConexaoController conexaoc = new ConexaoController();

            string comando = "select * from TB_FUNCIONARIO";

            DataTable dt1 = conexaoc.ConsultarRegistro(comando);

            return dt1;
        }


        #endregion

        #region consultar folha

        public ColecaoFolha SelecionarFolha()
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoFolha colecaofolha = new ColecaoFolha();
                string comando = "select * from TB_FOLHA";

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)

                {
                    Folha folha = new Folha();
                    folha.Id1 = Convert.ToInt32(linha["TB_FOLHA_ID"]);
                    folha.Periodo = linha["TB_FOLHA_PERIODO"].ToString();
                    folha.ValorFinal = Convert.ToDouble(linha["TB_FOLHA_VALORFINAL"]);
                    folha.Status = Convert.ToInt32(linha["TB_FOLHA_STATUS"]);
                    folha.Empresa = Convert.ToInt32(linha["TB_EMPRESA_ID"]);
                    folha.Funcionario = Convert.ToInt32(linha["TB_FUNCIONARIO_ID"]);

                    colecaofolha.Add(folha);

                }

                return colecaofolha;


            }


            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion

        public ColecaoFolha SelecionarEspecifico(Folha folha)
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoFolha colecaofolha = new ColecaoFolha();
                String comando = "Select * from TB_FOLHA where TB_FOLHA_ID like '%" + folha.Id1 + "%'";

                conexaoc.LimparParametros();

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)
                {

                    folha.Id1 = Convert.ToInt32(linha["TB_FOLHA_ID"]);
                    folha.Periodo = linha["TB_FOLHA_PERIODO"].ToString();
                    folha.ValorFinal = Convert.ToDouble(linha["TB_FOLHA_VALORFINAL"]);
                    folha.Status = Convert.ToInt32(linha["TB_FOLHA_STATUS"]);
                    folha.Funcionario = Convert.ToInt32(linha["TB_FUNCIONARIO_ID"]);
                    folha.Empresa = Convert.ToInt32(linha["TB_EMPRESA_ID"]);

                    colecaofolha.Add(folha);

                }

                return colecaofolha;

            }
            catch (Exception erro)
            {

                throw erro;

            }
        }

        public void alterar(Folha obj)
        {

            //1 passo - comando sql
            string sql = @"update TB_FOLHA set
                            TB_FOLHA_STATUS = @folha_status
                            where TB_FOLHA_ID = @folha_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@folha_status", obj.Status);
            comando.Parameters.AddWithValue("@folha_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void excluirfolha(Folha obj)
        {

            //1 passo - comando sql
            string sql = @"delete from TB_FOLHA
                                where TB_FOLHA_ID = @folha_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@folha_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }
    }
}
