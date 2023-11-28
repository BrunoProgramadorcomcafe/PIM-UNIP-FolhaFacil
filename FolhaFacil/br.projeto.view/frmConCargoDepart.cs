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
    public partial class frmConCargoDepart : Form
    {
        public frmConCargoDepart()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            CarregarCargo();
            dataGridView2.AutoGenerateColumns = false;
            CarregarDepartamento();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAlterarCargo_Click(object sender, EventArgs e)
        {
            try
            {

                Cargo obj = new Cargo();
                obj.Descricao = txtDescCargo.Text;
                obj.Id1 = int.Parse(txtIDCargo.Text);


                CargoController dao = new CargoController();
                dao.alterar(obj);
                MessageBox.Show("Alterado com sucesso!");
                dataGridView1.DataSource = dao.SelecionarCargo();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnAlterarDep_Click(object sender, EventArgs e)
        {
            try
            {

                Departamento obj = new Departamento();
                obj.Descricao = txtDescDepart.Text;
                obj.Id1 = int.Parse(txtIDDepart.Text);


                DepartamentoController dao = new DepartamentoController();
                dao.alterar(obj);
                MessageBox.Show("Alterado com sucesso!");
                dataGridView2.DataSource = dao.SelecionarDepartamento();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnExcluirCargo_Click(object sender, EventArgs e)
        {
            try
            {

                Cargo obj = new Cargo();

                obj.Id1 = int.Parse(txtIDCargo.Text);

                CargoController dao = new CargoController();
                dao.excluir(obj);
                MessageBox.Show("Excluido com sucesso!");
                dataGridView1.DataSource = dao.SelecionarCargo();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnExcluirDep_Click(object sender, EventArgs e)
        {
            try
            {

                Departamento obj = new Departamento();

                obj.Id1 = int.Parse(txtIDDepart.Text);

                DepartamentoController dao = new DepartamentoController();
                dao.excluir(obj);
                MessageBox.Show("Excluido com sucesso!");
                dataGridView2.DataSource = dao.SelecionarDepartamento();
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnLimparCargo_Click(object sender, EventArgs e)
        {
            Consistencia.limparcampos2(panel1);
        }

        private void btnLimparDep_Click(object sender, EventArgs e)
        {
            Consistencia.limparcampos2(panel2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDCargo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDescCargo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDDepart.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtDescDepart.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void CarregarCargo()
        {
            CargoController daocargo = new CargoController();

            ColecaoCargo colecaocargo = daocargo.SelecionarCargo();

            dataGridView1.DataSource = colecaocargo;
        }

        private void CarregarDepartamento()
        {
            DepartamentoController daodepartamento = new DepartamentoController();

            ColecaoDepartamento colecaodepartamento = daodepartamento.SelecionarDepartamento();

            dataGridView2.DataSource = colecaodepartamento;
        }

        private void txtPesqCargo_TextChanged(object sender, EventArgs e)
        {
            if (txtPesqCargo.Text != string.Empty)
            {

                Cargo cargo = new Cargo();
                cargo.Descricao = txtPesqCargo.Text;

                CargoController daocargo = new CargoController();
                ColecaoCargo colecaocargo = daocargo.SelecionarEspecifico(cargo);

                dataGridView1.DataSource = colecaocargo;

            }
            else
            {
                CarregarCargo();
            }
        }

        private void txtPesqDepart_TextChanged(object sender, EventArgs e)
        {
            if (txtPesqDepart.Text != string.Empty)
            {

                Departamento departamento = new Departamento();
                departamento.Descricao = txtPesqDepart.Text;

                DepartamentoController daodepartamento = new DepartamentoController();
                ColecaoDepartamento colecaodepartamento = daodepartamento.SelecionarEspecifico(departamento);

                dataGridView2.DataSource = colecaodepartamento;

            }
            else
            {
                CarregarDepartamento();
            }
        }
    }
}
