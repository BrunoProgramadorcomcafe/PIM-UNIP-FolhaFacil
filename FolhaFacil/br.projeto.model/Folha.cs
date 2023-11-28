using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFacil.br.projeto.model
{
    class Folha
    {
        private String periodo;
        private double valorfinal;
        private int status;
        private int funcionario;
        private int empresa;
        private int id;

        public string Periodo { get => periodo; set => periodo = value; }
        public double ValorFinal { get => valorfinal; set => valorfinal = value; }
        public int Status { get => status; set => status = value; }
        public int Funcionario { get => funcionario; set => funcionario = value; }
        public int Empresa { get => empresa; set => empresa = value; }
        public int Id1 { get => id; set => id = value; }
    }
}
