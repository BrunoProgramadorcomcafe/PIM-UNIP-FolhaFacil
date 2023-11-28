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
    class CargoController
    {
        private SqlConnection conexao;

        public CargoController()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrar(Cargo obj)
        {
            //1 passo - comando sql
            string sql = @"insert into TB_CARGO (TB_CARGO_DESC) values(@cargo_desc)";
            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cargo_desc", obj.Descricao);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void alterar(Cargo obj)
        {

            //1 passo - comando sql
            string sql = @"update TB_CARGO set
                            TB_CARGO_DESC = @cargo_desc
                            where TB_CARGO_ID = @cargo_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@cargo_desc", obj.Descricao);
            comando.Parameters.AddWithValue("@cargo_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void excluir(Cargo obj)
        {

            //1 passo - comando sql
            string sql = @"delete from TB_CARGO
                                where TB_CARGO_ID = @cargo_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@cargo_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        #region consultar cargo

        public ColecaoCargo SelecionarCargo()
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoCargo colecaocargo = new ColecaoCargo();
                string comando = "select * from TB_CARGO";

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)

                {
                    Cargo cargo = new Cargo();
                    cargo.Id1 = Convert.ToInt32(linha["TB_CARGO_ID"]);
                    cargo.Descricao = linha["TB_CARGO_DESC"].ToString();

                    colecaocargo.Add(cargo);

                }

                return colecaocargo;


            }


            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion

        public ColecaoCargo SelecionarEspecifico(Cargo cargo)
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoCargo colecaocargo = new ColecaoCargo();
                String comando = "Select * from TB_CARGO where TB_CARGO_DESC like '%" + cargo.Descricao + "%'";

                conexaoc.LimparParametros();

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)
                {

                    cargo.Id1 = Convert.ToInt32(linha["TB_CARGO_ID"]);
                    cargo.Descricao = linha["TB_CARGO_DESC"].ToString();

                    colecaocargo.Add(cargo);

                }

                return colecaocargo;

            }
            catch (Exception erro)
            {

                throw erro;

            }
        }

    }
}
