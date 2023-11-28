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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FolhaFacil.br.projeto.view
{
    public partial class frmConItensRH : Form
    {
        public frmConItensRH()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            CarregarAcrescimo();

            dataGridView2.AutoGenerateColumns = false;
            CarregarDesconto();
        }

        private void CarregarAcrescimo()
        {
            AcrescimoController daoacrescimo = new AcrescimoController();

            ColecaoAcrescimo colecaoacrescimo = daoacrescimo.SelecionarAcrescimo();

            dataGridView1.DataSource = colecaoacrescimo;
        }

        private void CarregarDesconto()
        {
            DescontoController daodesconto = new DescontoController();

            ColecaoDesconto colecaodesconto = daodesconto.SelecionarDesconto();

            dataGridView2.DataSource = colecaodesconto;
        }

        private void btnAlterarAcres_Click(object sender, EventArgs e)
        {
            try
            {

                Acrescimo obj = new Acrescimo();
                obj.Descricao = txtDescAcresc.Text;
                obj.Valor = double.Parse(txtValorAcresc.Text);
                obj.Id1 = int.Parse(txtIDAcres.Text);

                AcrescimoController dao = new AcrescimoController();
                dao.alterar(obj);
                MessageBox.Show("Alterado com sucesso!");
                dataGridView1.DataSource = dao.SelecionarAcrescimo();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnAlterarDesc_Click(object sender, EventArgs e)
        {
            try
            {

                Desconto obj = new Desconto();
                obj.Descricao = txtDescDesc.Text;
                obj.Valor = double.Parse(txtValorDesc.Text);
                obj.Id1 = int.Parse(txtIDDesc.Text);

                DescontoController dao = new DescontoController();
                dao.alterar(obj);
                MessageBox.Show("Alterado com sucesso!");
                dataGridView2.DataSource = dao.SelecionarDesconto();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnExcluirAcresc_Click(object sender, EventArgs e)
        {
            try
            {

                Acrescimo obj = new Acrescimo();

                obj.Id1 = int.Parse(txtIDAcres.Text);

                AcrescimoController dao = new AcrescimoController();
                dao.excluir(obj);
                MessageBox.Show("Excluido com sucesso!");
                dataGridView1.DataSource = dao.SelecionarAcrescimo();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnExcluirDesc_Click(object sender, EventArgs e)
        {
            try
            {

                Desconto obj = new Desconto();

                obj.Id1 = int.Parse(txtIDDesc.Text);

                DescontoController dao = new DescontoController();
                dao.excluir(obj);
                MessageBox.Show("Excluido com sucesso!");
                dataGridView2.DataSource = dao.SelecionarDesconto();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnLimparAcresc_Click(object sender, EventArgs e)
        {
            Consistencia.limparcampos2(panel1);
        }

        private void btnLimparDesc_Click(object sender, EventArgs e)
        {
            Consistencia.limparcampos2(panel2);
        }

        private void txtPesqAcresc_TextChanged(object sender, EventArgs e)
        {
            if (txtPesqAcresc.Text != string.Empty)
            {

                Acrescimo acrescimo = new Acrescimo();
                acrescimo.Descricao = txtPesqAcresc.Text;

                AcrescimoController daoacrescimo = new AcrescimoController();
                ColecaoAcrescimo colecaoacrescimo = daoacrescimo.SelecionarEspecifico(acrescimo);

                dataGridView1.DataSource = colecaoacrescimo;

            }
            else
            {
                CarregarAcrescimo();
            }
        }

        private void txtPesqDesc_TextChanged(object sender, EventArgs e)
        {
            if (txtPesqDesc.Text != string.Empty)
            {

                Desconto desconto = new Desconto();
                desconto.Descricao = txtPesqDesc.Text;

                DescontoController daodesconto = new DescontoController();
                ColecaoDesconto colecaodesconto = daodesconto.SelecionarEspecifico(desconto);

                dataGridView2.DataSource = colecaodesconto;

            }
            else
            {
                CarregarDesconto();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDAcres.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDescAcresc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtValorAcresc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDDesc.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtDescDesc.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtValorDesc.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
