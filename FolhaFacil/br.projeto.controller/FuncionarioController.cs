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
    class FuncionarioController
    {
        private SqlConnection conexao;

        public FuncionarioController()
        {
            conexao = new ConnectionFactory().getConnection();
        }

        #region Login funcionario

        public Funcionario Login_funcionario(Funcionario funcionario)
        {

        ConexaoController conexaoc = new ConexaoController();
            try
            {
                string comando = "sp_Login";
                conexaoc.LimparParametros();
                conexaoc.AdicionarParametros("@email", funcionario.Email);
                conexaoc.AdicionarParametros("@senha", funcionario.Senha);

                DataTable dt = conexaoc.ConsultarRegistros(comando, CommandType.StoredProcedure);


                foreach (DataRow linha in dt.Rows)
                {
                    funcionario.Id1 = Convert.ToInt32(linha["TB_FUNCIONARIO_ID"]);
                    funcionario.Nome = linha["TB_FUNCIONARIO_NOME"].ToString();
                }

                return funcionario;
            }
            catch (Exception EX)
            {

                throw EX;
            }
        }

        #endregion

        public void cadastrar(Funcionario obj)
        {
            //1 passo - comando sql
            string sql = @"insert into TB_FUNCIONARIO (TB_FUNCIONARIO_NOME, TB_FUNCIONARIO_CPF, TB_FUNCIONARIO_DT_CONTRATO, TB_FUNCIONARIO_DT_NASC, TB_FUNCIONARIO_TEL, TB_FUNCIONARIO_senha, TB_FUNCIONARIO_EMAIL, TB_FUNCIONARIO_CTPS, TB_FUNCIONARIO_PIS, TB_FUNCIONARIO_ENDERECO, TB_FUNCIONARIO_SALARIO, TB_CARGO_ID, TB_DEPARTAMENTO_ID, TB_SITUACAO_ID, TB_EMPRESA_ID, TB_CONTRATO_ID) values(@funcionario_nome, @funcionario_cpf, @funcionario_dtcontrato, @funcionario_dtnasc, @funcionario_tel, @funcionario_senha, @funcionario_email, @funcionario_ctps, @funcionario_pis, @funcionario_endereco, @funcionario_salario, @funcionario_cargo, @funcionario_departamento, @funcionario_situacao, @funcionario_empresa, @funcionario_contrato)";
            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@funcionario_nome", obj.Nome);
            comando.Parameters.AddWithValue("@funcionario_cpf", obj.Cpf);
            comando.Parameters.AddWithValue("@funcionario_dtcontrato", obj.DataCon);
            comando.Parameters.AddWithValue("@funcionario_dtnasc", obj.DataNasc);
            comando.Parameters.AddWithValue("@funcionario_tel", obj.Tel);
            comando.Parameters.AddWithValue("@funcionario_senha", obj.Senha);
            comando.Parameters.AddWithValue("@funcionario_email", obj.Email);
            comando.Parameters.AddWithValue("@funcionario_ctps", obj.CTPS);
            comando.Parameters.AddWithValue("@funcionario_pis", obj.PIS);
            comando.Parameters.AddWithValue("@funcionario_endereco", obj.Endereco);
            comando.Parameters.AddWithValue("@funcionario_salario", obj.Salario);
            comando.Parameters.AddWithValue("@funcionario_cargo", obj.Cargo);
            comando.Parameters.AddWithValue("@funcionario_departamento", obj.Departamento);
            comando.Parameters.AddWithValue("@funcionario_situacao", obj.Situacao);
            comando.Parameters.AddWithValue("@funcionario_empresa", obj.Empresa);
            comando.Parameters.AddWithValue("@funcionario_contrato", obj.Contrato);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void alterar(Funcionario obj)
        {

            //1 passo - comando sql
            string sql = @"update TB_FUNCIONARIO set
                            TB_FUNCIONARIO_NOME = @funcionario_nome,
                            TB_FUNCIONARIO_CPF = @funcionario_cpf,
                            TB_FUNCIONARIO_DT_CONTRATO = @funcionario_dtcontrato,
                            TB_FUNCIONARIO_DT_NASC = @funcionario_dtnasc,
                            TB_FUNCIONARIO_TEL = @funcionario_tel,
                            TB_FUNCIONARIO_SENHA = @funcionario_senha,
                            TB_FUNCIONARIO_email = @funcionario_email,
                            TB_FUNCIONARIO_CTPS = @funcionario_ctps,
                            TB_FUNCIONARIO_PIS = @funcionario_pis,
                            TB_FUNCIONARIO_ENDERECO = @funcionario_endereco,
                            TB_FUNCIONARIO_SALARIO = @funcionario_salario,
                            TB_CARGO_ID = @funcionario_cargo,
                            TB_DEPARTAMENTO_ID = @funcionario_departamento,
                            TB_SITUACAO_ID = @funcionario_situacao,
                            TB_EMPRESA_ID = @funcionario_empresa,
                            TB_CONTRATO_ID = @funcionario_contrato
                            where TB_FUNCIONARIO_ID = @funcionario_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@funcionario_nome", obj.Nome);
            comando.Parameters.AddWithValue("@funcionario_cpf", obj.Cpf);
            comando.Parameters.AddWithValue("@funcionario_dtcontrato", obj.DataCon);
            comando.Parameters.AddWithValue("@funcionario_dtnasc", obj.DataNasc);
            comando.Parameters.AddWithValue("@funcionario_tel", obj.Tel);
            comando.Parameters.AddWithValue("@funcionario_senha", obj.Senha);
            comando.Parameters.AddWithValue("@funcionario_email", obj.Email);
            comando.Parameters.AddWithValue("@funcionario_ctps", obj.CTPS);
            comando.Parameters.AddWithValue("@funcionario_pis", obj.PIS);
            comando.Parameters.AddWithValue("@funcionario_endereco", obj.Endereco);
            comando.Parameters.AddWithValue("@funcionario_salario", obj.Salario);
            comando.Parameters.AddWithValue("@funcionario_cargo", obj.Cargo);
            comando.Parameters.AddWithValue("@funcionario_departamento", obj.Departamento);
            comando.Parameters.AddWithValue("@funcionario_situacao", obj.Situacao);
            comando.Parameters.AddWithValue("@funcionario_empresa", obj.Empresa);
            comando.Parameters.AddWithValue("@funcionario_contrato", obj.Contrato);
            comando.Parameters.AddWithValue("@funcionario_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        public void excluir(Funcionario obj)
        {

            //1 passo - comando sql
            string sql = @"delete from TB_FUNCIONARIO
                                where TB_FUNCIONARIO_ID = @funcionario_id";

            //2 passo - Organizar
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@funcionario_id", obj.Id1);

            //3 passo - abrir conexao
            conexao.Open();

            //4 passo - executa o comando sql e fecha conexao
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        #region consultar funcionario

        public ColecaoFuncionario SelecionarFuncionario()
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoFuncionario colecaofuncionario = new ColecaoFuncionario();
                string comando = "select * from TB_FUNCIONARIO";

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)

                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.Id1 = Convert.ToInt32(linha["TB_FUNCIONARIO_ID"]);
                    funcionario.Nome = linha["TB_FUNCIONARIO_NOME"].ToString();
                    funcionario.Cpf = linha["TB_FUNCIONARIO_CPF"].ToString();
                    funcionario.Endereco = linha["TB_FUNCIONARIO_ENDERECO"].ToString();
                    funcionario.DataNasc = linha["TB_FUNCIONARIO_DT_NASC"].ToString();
                    funcionario.CTPS = linha["TB_FUNCIONARIO_CTPS"].ToString();
                    funcionario.PIS = linha["TB_FUNCIONARIO_PIS"].ToString();
                    funcionario.Tel = linha["TB_FUNCIONARIO_TEL"].ToString();
                    funcionario.Contrato = Convert.ToInt32(linha["TB_CONTRATO_ID"]);
                    funcionario.Cargo = Convert.ToInt32(linha["TB_CARGO_ID"]);
                    funcionario.Departamento = Convert.ToInt32(linha["TB_DEPARTAMENTO_ID"]);
                    funcionario.Situacao = Convert.ToInt32(linha["TB_SITUACAO_ID"]);
                    funcionario.Salario = Convert.ToDouble(linha["TB_FUNCIONARIO_SALARIO"]);
                    funcionario.Empresa = Convert.ToInt32(linha["TB_EMPRESA_ID"]);
                    funcionario.DataCon = linha["TB_FUNCIONARIO_DT_CONTRATO"].ToString();
                    funcionario.Senha = linha["TB_FUNCIONARIO_SENHA"].ToString();
                    funcionario.Email = linha["TB_FUNCIONARIO_email"].ToString();

                    colecaofuncionario.Add(funcionario);

                }

                return colecaofuncionario;


            }


            catch (Exception erro)
            {

                throw erro;
            }
        }

        #endregion

        #region mostrar Cargo

        public DataTable CarregarCargo()
        {
            ConexaoController conexaoc = new ConexaoController();

            string comando = "select * from TB_CARGO";

            DataTable dt = conexaoc.ConsultarRegistro(comando);

            return dt;
        }


        #endregion

        #region mostrar situação

        public DataTable CarregarSituacao()
        {
            ConexaoController conexaoc = new ConexaoController();

            string comando = "select * from TB_SITUACAO";

            DataTable dt1 = conexaoc.ConsultarRegistro(comando);

            return dt1;
        }


        #endregion

        #region mostrar empresa

        public DataTable CarregarEmpresa()
        {
            ConexaoController conexaoc = new ConexaoController();

            string comando = "select * from TB_EMPRESA";

            DataTable dt2 = conexaoc.ConsultarRegistro(comando);

            return dt2;
        }


        #endregion

        #region mostrar departamento

        public DataTable CarregarDep()
        {
            ConexaoController conexaoc = new ConexaoController();

            string comando = "select * from TB_DEPARTAMENTO";

            DataTable dt3 = conexaoc.ConsultarRegistro(comando);

            return dt3;
        }


        #endregion

        #region mostrar contratos

        public DataTable CarregarContrato()
        {
            ConexaoController conexaoc = new ConexaoController();

            string comando = "select * from TB_CONTRATO";

            DataTable dt4 = conexaoc.ConsultarRegistro(comando);

            return dt4;
        }


        #endregion

        public ColecaoFuncionario SelecionarEspecifico(Funcionario funcionario)
        {
            ConexaoController conexaoc = new ConexaoController();
            try
            {

                ColecaoFuncionario colecaofuncionario = new ColecaoFuncionario();
                String comando = "Select * from TB_FUNCIONARIO where TB_FUNCIONARIO_NOME like '%" + funcionario.Nome + "%'";

                conexaoc.LimparParametros();

                DataTable dt = conexaoc.ConsultarRegistro(comando);

                foreach (DataRow linha in dt.Rows)
                {

                    funcionario.Id1 = Convert.ToInt32(linha["TB_FUNCIONARIO_ID"]);
                    funcionario.Nome = linha["TB_FUNCIONARIO_NOME"].ToString();
                    funcionario.Cpf = linha["TB_FUNCIONARIO_CPF"].ToString();
                    funcionario.Endereco = linha["TB_FUNCIONARIO_ENDERECO"].ToString();
                    funcionario.DataNasc = linha["TB_FUNCIONARIO_DT_NASC"].ToString();
                    funcionario.CTPS = linha["TB_FUNCIONARIO_CTPS"].ToString();
                    funcionario.PIS = linha["TB_FUNCIONARIO_PIS"].ToString();
                    funcionario.Tel = linha["TB_FUNCIONARIO_TEL"].ToString();
                    funcionario.Contrato = Convert.ToInt32(linha["TB_CONTRATO_ID"]);
                    funcionario.Cargo = Convert.ToInt32(linha["TB_CARGO_ID"]);
                    funcionario.Departamento = Convert.ToInt32(linha["TB_DEPARTAMENTO_ID"]);
                    funcionario.Situacao = Convert.ToInt32(linha["TB_SITUACAO_ID"]);
                    funcionario.Salario = Convert.ToDouble(linha["TB_FUNCIONARIO_SALARIO"]);
                    funcionario.Empresa = Convert.ToInt32(linha["TB_EMPRESA_ID"]);
                    funcionario.DataCon = linha["TB_FUNCIONARIO_DT_CONTRATO"].ToString();
                    funcionario.Senha = linha["TB_FUNCIONARIO_SENHA"].ToString();
                    funcionario.Email = linha["TB_FUNCIONARIO_email"].ToString();

                    colecaofuncionario.Add(funcionario);

                }

                return colecaofuncionario;

            }
            catch (Exception erro)
            {

                throw erro;

            }
        }
    }
}
