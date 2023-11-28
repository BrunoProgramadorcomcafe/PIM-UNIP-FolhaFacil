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
    public partial class frmConEmpresa : Form
    {
        public frmConEmpresa()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            CarregarEmpresa();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                Empresa obj = new Empresa();
                obj.Nome = txtNome.Text;
                obj.CNPJ = txtCNPJ.Text;
                obj.Endereco = txtEnd.Text;
                obj.Tel = txtTel.Text;
                obj.Id1 = int.Parse(txtID.Text);


                EmpresaController dao = new EmpresaController();
                dao.alterar(obj);
                MessageBox.Show("Alterado com sucesso!");
                dataGridView1.DataSource = dao.SelecionarEmpresa();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                Empresa obj = new Empresa();

                obj.Id1 = int.Parse(txtID.Text);

                EmpresaController dao = new EmpresaController();
                dao.excluir(obj);
                MessageBox.Show("Excluido com sucesso!");
                dataGridView1.DataSource = dao.SelecionarEmpresa();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Consistencia.limparcampos2(panel1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEnd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void CarregarEmpresa()
        {
            EmpresaController daoempresa = new EmpresaController();

            ColecaoEmpresa colecaoempresa = daoempresa.SelecionarEmpresa();

            dataGridView1.DataSource = colecaoempresa;
        }

        private void txtPesqNome_TextChanged(object sender, EventArgs e)
        {
            if (txtPesqNome.Text != string.Empty)
            {

                Empresa empresa = new Empresa();
                empresa.Nome = txtPesqNome.Text;

                EmpresaController daoempresa = new EmpresaController();
                ColecaoEmpresa colecaoempresa = daoempresa.SelecionarEspecifico(empresa);

                dataGridView1.DataSource = colecaoempresa;

            }
            else
            {
                CarregarEmpresa();
            }
        }
    }
}
