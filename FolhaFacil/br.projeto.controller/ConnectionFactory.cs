using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFacil.br.projeto.controller
{
    class ConnectionFactory
    {
        public SqlConnection getConnection()
        {

            try
            {
                //var conexao = ConfigurationManager.ConnectionStrings["folhafacil"].ConnectionString;
                //string conexao = ConfigurationManager.ConnectionStrings["folhafacil"].ConnectionString;
                string conexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=folhafacil;Data Source=BRUNO\SQLEXPRESS";
                return new SqlConnection(conexao);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar: " + erro);

                return null;
            }

        }
    }
}
