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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void cADASTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFun tela = new frmCadFun();
            tela.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Sair ?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEmpresa tela = new frmCadEmpresa();
            tela.Show();
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConFun tela = new frmConFun();
            tela.Show();
        }

        private void menuAcresDesc_Click(object sender, EventArgs e)
        {
            frmCadItensRH tela = new frmCadItensRH();
            tela.Show();
        }

        private void menuCargoDep_Click(object sender, EventArgs e)
        {
            frmCadCargoDepart tela = new frmCadCargoDepart();
            tela.Show();
        }

        private void empresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConEmpresa tela = new frmConEmpresa();
            tela.Show();
        }

        private void menuConAcresDesc_Click(object sender, EventArgs e)
        {
            frmConItensRH tela = new frmConItensRH();
            tela.Show();
        }

        private void menuConCargoDepar_Click(object sender, EventArgs e)
        {
            frmConCargoDepart tela = new frmConCargoDepart();
            tela.Show();
        }

        private void gERARFOLHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerarFolha tela = new frmGerarFolha();
            tela.Show();
        }

        private void folhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFolha tela = new frmConsultaFolha();
            tela.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }
    }
}
