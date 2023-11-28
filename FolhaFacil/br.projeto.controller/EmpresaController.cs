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
    class EmpresaController
    {

        private SqlConnection conexao;

        public EmpresaController()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(Empresa obj)
        {
            //1 passo - comando sql
            string sql = @"insert into TB_EMPRESA (TB_EMPRESA_NOME, TB_EMPRESA_CNPJ, TB_EMPRESA_ENDERECO, TB_EMPRESA_TEL) values(@empresa_nome, @empresa_cnpj, @empresa_endereco, @empresa_tel)";
            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@empresa_nome", obj.Nome);
            comando.Parameters.AddWithValue("@empresa_cnpj", obj.CNPJ);
            comando.Parameters.AddWithValue("@empresa_tel", obj.Tel);
            comando.Parameters.AddWithValue("@empresa_endereco", obj.Endereco);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void alterar(Empresa obj)
        {

            //1 passo - comando sql
            string sql = @"update TB_EMPRESA set
                            TB_EMPRESA_NOME = @empresa_nome,
                            TB_EMPRESA_CNPJ = @empresa_cnpj,
                            TB_EMPRESA_ENDERECO = @empresa_endereco,
                            TB_EMPRESA_TEL = @empresa_tel
                            where TB_EMPRESA_ID = @empresa_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@empresa_nome", obj.Nome);
            comando.Parameters.AddWithValue("@empresa_cnpj", obj.CNPJ);
            comando.Parameters.AddWithValue("@empresa_endereco", obj.Endereco);
            comando.Parameters.AddWithValue("@empresa_tel", obj.Tel);
            comando.Parameters.AddWithValue("@empresa_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void excluir(Empresa obj)
        {

            //1 passo - comando sql
            string sql = @"delete from TB_EMPRESA
                                where TB_EMPRESA_ID = @empresa_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@empresa_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        #region consultar empresa

        public ColecaoEmpresa SelecionarEmpresa()
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoEmpresa colecaoempresa = new ColecaoEmpresa();
                string comando = "select * from TB_EMPRESA";

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)

                {
                    Empresa empresa = new Empresa();
                    empresa.Id1 = Convert.ToInt32(linha["TB_EMPRESA_ID"]);
                    empresa.Nome = linha["TB_EMPRESA_NOME"].ToString();
                    empresa.CNPJ = linha["TB_EMPRESA_CNPJ"].ToString();
                    empresa.Endereco = linha["TB_EMPRESA_ENDERECO"].ToString();
                    empresa.Tel = linha["TB_EMPRESA_TEL"].ToString();

                    colecaoempresa.Add(empresa);

                }

                return colecaoempresa;


            }


            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion

        public ColecaoEmpresa SelecionarEspecifico(Empresa empresa)
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoEmpresa colecaoempresa = new ColecaoEmpresa();
                String comando = "Select * from TB_EMPRESA where TB_EMPRESA_NOME like '%" + empresa.Nome + "%'";

                conexaoc.LimparParametros();

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)
                {

                    empresa.Id1 = Convert.ToInt32(linha["TB_EMPRESA_ID"]);
                    empresa.Nome = linha["TB_EMPRESA_NOME"].ToString();
                    empresa.CNPJ = linha["TB_EMPRESA_CNPJ"].ToString();
                    empresa.Endereco = linha["TB_EMPRESA_ENDERECO"].ToString();
                    empresa.Tel = linha["TB_EMPRESA_TEL"].ToString();

                    colecaoempresa.Add(empresa);

                }

                return colecaoempresa;

            }
            catch (Exception erro)
            {

                throw erro;

            }
        }
    }
}
