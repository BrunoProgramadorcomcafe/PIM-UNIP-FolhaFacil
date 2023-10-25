using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFacil.br.projeto.model
{
    class ItensAcrescimo
    {
        private int qtd;
        private double valortotal;
        private int id;
        private int acrescimo;
        private int folha;

        public double ValorTotal { get => valortotal; set => valortotal = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public int Acrescimo { get => acrescimo; set => acrescimo = value; }
        public int Folha { get => folha; set => folha = value; }
        public int Id1 { get => id; set => id = value; }
    }
}
