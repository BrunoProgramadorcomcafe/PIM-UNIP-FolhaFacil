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
    public partial class frmConsultaFolha : Form
    {
        public frmConsultaFolha()
        {
            InitializeComponent();
            tbFolha.AutoGenerateColumns = false;
            CarregarFolha();
        }

        private void CarregarFolha()
        {
            FolhaController daoafolha = new FolhaController();

            ColecaoFolha colecaofolha = daoafolha.SelecionarFolha();

            tbFolha.DataSource = null;
            tbFolha.DataSource = colecaofolha;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente Inativar?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Folha obj = new Folha();
                    obj.Status = 0;
                    obj.Id1 = int.Parse(txtId.Text);

                    FolhaController dao = new FolhaController();
                    dao.alterar(obj);
                    MessageBox.Show("Alterado com sucesso!");
                    tbFolha.DataSource = dao.SelecionarFolha();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void txtPesqFun_TextChanged(object sender, EventArgs e)
        {
            if (txtPesqFun.Text != string.Empty)
            {

                Folha folha = new Folha();
                folha.Id1 = Convert.ToInt32(txtPesqFun.Text);

                FolhaController daof = new FolhaController();
                ColecaoFolha colecaofolha = daof.SelecionarEspecifico(folha);

                tbFolha.DataSource = colecaofolha;

            }
            else
            {
                CarregarFolha();
            }
        }

        private void tbFolha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = tbFolha.CurrentRow.Cells[0].Value.ToString();
            txtStatus.Text = tbFolha.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente Excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ItensAcrescimo obj2 = new ItensAcrescimo();
                    obj2.Id1 = int.Parse(txtId.Text);
                    ItensAcrescimoController dao2 = new ItensAcrescimoController();
                    dao2.excluiracresc(obj2);

                    ItensDesconto obj3 = new ItensDesconto();
                    obj3.Id1 = int.Parse(txtId.Text);
                    ItensDescontoController dao3 = new ItensDescontoController();
                    dao3.excluirdescont(obj3);

                    Folha obj = new Folha();
                    obj.Id1 = int.Parse(txtId.Text);
                    FolhaController dao = new FolhaController();
                    dao.excluirfolha(obj);

                    MessageBox.Show("Excluido com sucesso!");
                    tbFolha.DataSource = dao.SelecionarFolha();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }
    }
}
