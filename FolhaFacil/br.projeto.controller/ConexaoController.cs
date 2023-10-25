using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFacil.br.projeto.controller
{
    public class ConexaoController
    {

        private SqlParameterCollection sqlparametroColecao = new SqlCommand().Parameters;

        #region MetodoConexao
        //cria conexao
        private SqlConnection ConexaoSQL()
        {
            return new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=folhafacil;Data Source=BRUNO\\SQLEXPRESS");
        }

        #endregion

        #region MetodoAdicionarParametro
        //metodo que vou usar para adicionar a informacao na conexaoDAO
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            //recebe dos parametros que sao o nome e o valor do parametro para poder funcionar 
            sqlparametroColecao.Add(new SqlParameter(nomeParametro, valorParametro));
        }


        #endregion

        #region MetodoLimparParametro

        public void LimparParametros()
        {
            //usado para limpar os dados que foram armazenados no metodo adicionar parametros mysqlparametroColecao
            sqlparametroColecao.Clear();
        }

        #endregion

        #region MetodoManipulacaoBancoDados

        //persistencia inserir/alterar/excluir
        public object Manipulacao(string comando)
        {
            SqlConnection sqlconnection = ConexaoSQL();
            try
            {
                sqlconnection.Open();

                SqlCommand sqlcommand = sqlconnection.CreateCommand();

                sqlcommand.CommandText = comando;

                foreach (SqlParameter sqlparametro in sqlparametroColecao)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlparametro.ParameterName, sqlparametro.Value));
                }

                return sqlcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                sqlconnection.Close();
            }
        }

        #endregion

        #region Metodoconsulta

        //consulta registro
        public DataTable ConsultarRegistro(string comando)
        {
            SqlConnection sqlconnection = ConexaoSQL();

            try
            {
                sqlconnection.Open();

                SqlCommand sqlcommand = sqlconnection.CreateCommand();

                sqlcommand.CommandText = comando;

                foreach (SqlParameter sqlparametro in sqlparametroColecao)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlparametro.ParameterName, sqlparametro.Value));
                }

                SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcommand);

                DataTable dt = new DataTable();

                sqldataadapter.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                sqlconnection.Close();
            }
        }
        #endregion

        #region MetodoconsultaProcedure

        //consulta registro
        public DataTable ConsultarRegistros(string comando, CommandType tipo)
        {
            SqlConnection sqlconnection = ConexaoSQL();

            try
            {
                sqlconnection.Open();

                SqlCommand sqlcommand = sqlconnection.CreateCommand();

                sqlcommand.CommandText = comando;
                sqlcommand.CommandType = tipo;

                foreach (SqlParameter sqlparametro in sqlparametroColecao)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlparametro.ParameterName, sqlparametro.Value));
                }

                SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcommand);

                DataTable dt = new DataTable();

                sqldataadapter.Fill(dt);
                //mysqldataadapter.Fill(ds, "TABELA");

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        #endregion

        #region MetodoManipulacaoBancoDadosProcedure

        //persistencia inserir/alterar/excluir
        //metodo para manipular o banco de dadso
        public object Manipulacao(string comando, CommandType tipo) //acresscenta o commandtype
        {
            SqlConnection sqlconnection = ConexaoSQL();
            try
            {
                sqlconnection.Open();

                SqlCommand sqlcommand = sqlconnection.CreateCommand();

                sqlcommand.CommandText = comando;
                sqlcommand.CommandType = tipo; // acrescenta essa linha

                foreach (SqlParameter sqlparametro in sqlparametroColecao)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlparametro.ParameterName, sqlparametro.Value));
                }

                return sqlcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                sqlconnection.Close();
            }
        }

        #endregion
    }
}