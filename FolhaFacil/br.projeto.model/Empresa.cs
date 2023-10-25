using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFacil.br.projeto.model
{
    class Empresa
    {
        private String nome;
        private String cnpj;
        private String endereco;
        private String tel;
        private int id;

        public string Nome { get => nome; set => nome = value; }
        public string CNPJ { get => cnpj; set => cnpj = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Tel { get => tel; set => tel = value; }
        public int Id1 { get => id; set => id = value; }
    }
}
