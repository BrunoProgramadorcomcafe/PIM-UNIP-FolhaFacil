using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFacil.br.projeto.model
{
    public class Funcionario
    {
        private String nome;
        private String cpf;
        private String datacontrato;
        private String datanasc;
        private String tel;
        private String senha;
        private String email;
        private String ctps;
        private String pis;
        private String endereco;
        private double salario;
        private int cargo;
        private int departamento;
        private int situacao;
        private int empresa;
        private int contrato;
        private int id;

        public int Id1 { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string DataCon { get => datacontrato; set => datacontrato = value; }
        public string DataNasc { get => datanasc; set => datanasc = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
        public string CTPS { get => ctps; set => ctps = value; }
        public string PIS { get => pis; set => pis = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public double Salario { get => salario; set => salario = value; }
        public int Cargo { get => cargo; set => cargo = value; }
        public int Situacao { get => situacao; set => situacao = value; }
        public int Empresa { get => empresa; set => empresa = value; }
        public int Departamento { get => departamento; set => departamento = value; }
        public int Contrato { get => contrato; set => contrato = value; }
    }
}
