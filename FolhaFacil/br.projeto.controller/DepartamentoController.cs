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
    class DepartamentoController
    {

        private SqlConnection conexao;

        public DepartamentoController()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(Departamento obj)
        {
            //1 passo - comando sql
            string sql = @"insert into TB_DEPARTAMENTO (TB_DEPARTAMENTO_DESC) values(@departamento_desc)";
            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@departamento_desc", obj.Descricao);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void alterar(Departamento obj)
        {

            //1 passo - comando sql
            string sql = @"update TB_DEPARTAMENTO set
                            TB_DEPARTAMENTO_DESC = @departamento_desc
                            where TB_DEPARTAMENTO_ID = @departamento_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@departamento_desc", obj.Descricao);
            comando.Parameters.AddWithValue("@departamento_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void excluir(Departamento obj)
        {

            //1 passo - comando sql
            string sql = @"delete from TB_DEPARTAMENTO
                                where TB_DEPARTAMENTO_ID = @departamento_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@departamento_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        #region consultar departamento

        public ColecaoDepartamento SelecionarDepartamento()
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoDepartamento colecaodepartamento= new ColecaoDepartamento();
                string comando = "select * from TB_DEPARTAMENTO";

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)

                {
                    Departamento departamento = new Departamento();
                    departamento.Id1 = Convert.ToInt32(linha["TB_DEPARTAMENTO_ID"]);
                    departamento.Descricao = linha["TB_DEPARTAMENTO_DESC"].ToString();

                    colecaodepartamento.Add(departamento);

                }

                return colecaodepartamento;


            }


            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion

        public ColecaoDepartamento SelecionarEspecifico(Departamento departamento)
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoDepartamento colecaodepartamento = new ColecaoDepartamento();
                String comando = "Select * from TB_DEPARTAMENTO where TB_DEPARTAMENTO_DESC like '%" + departamento.Descricao + "%'";

                conexaoc.LimparParametros();

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)
                {

                    departamento.Id1 = Convert.ToInt32(linha["TB_DEPARTAMENTO_ID"]);
                    departamento.Descricao = linha["TB_DEPARTAMENTO_DESC"].ToString();

                    colecaodepartamento.Add(departamento);

                }

                return colecaodepartamento;

            }
            catch (Exception erro)
            {

                throw erro;

            }
        }
    }
}
