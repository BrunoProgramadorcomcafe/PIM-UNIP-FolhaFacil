using FolhaFacil.br.projeto.controller;
using FolhaFacil.br.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFacil.br.projeto.view
{
    public partial class frmCadItensRH : Form
    {
        public frmCadItensRH()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadAcresc_Click(object sender, EventArgs e)
        {
            try
            {

                Acrescimo obj = new Acrescimo();
                obj.Descricao = txtDescAcresc.Text;
                obj.Valor = double.Parse(txtValorAcresc.Text);

                AcrescimoController dao = new AcrescimoController();
                dao.cadastrar(obj);
                MessageBox.Show("Acréscimo cadastrado com sucesso!");
                Consistencia.limparcampos2(panel1);
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnCadDesc_Click(object sender, EventArgs e)
        {
            try
            {

                Desconto obj = new Desconto();
                obj.Descricao = txtDescDesc.Text;
                obj.Valor = double.Parse(txtValorDesc.Text);

                DescontoController dao = new DescontoController();
                dao.cadastrar(obj);
                MessageBox.Show("Desconto cadastrado com sucesso!");
                Consistencia.limparcampos2(panel2);
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }
    }
}
