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
    public partial class frmConFun : Form
    {
        public frmConFun()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            CarregarFuncionario();

            #region Carregar cargo

            FuncionarioController daofuncionario = new FuncionarioController();
            DataTable dt = daofuncionario.CarregarCargo();

            cbCargo.DataSource = dt;

            cbCargo.ValueMember = "TB_CARGO_ID";
            cbCargo.DisplayMember = "TB_CARGO_DESC";

            #endregion

            #region carregar situação
            DataTable dt1 = daofuncionario.CarregarSituacao();

            cbSituacao.DataSource = dt1;

            cbSituacao.ValueMember = "TB_SITUACAO_ID";
            cbSituacao.DisplayMember = "TB_SITUACAO_DESC";

            #endregion

            #region carregar empresa
            DataTable dt2 = daofuncionario.CarregarEmpresa();

            cbEmpresa.DataSource = dt2;

            cbEmpresa.ValueMember = "TB_EMPRESA_ID";
            cbEmpresa.DisplayMember = "TB_EMPRESA_NOME";

            #endregion

            #region carregar dep
            DataTable dt3 = daofuncionario.CarregarDep();

            cbDepartamento.DataSource = dt3;

            cbDepartamento.ValueMember = "TB_DEPARTAMENTO_ID";
            cbDepartamento.DisplayMember = "TB_DEPARTAMENTO_DESC";

            #endregion

            #region carregar contrato
            DataTable dt4 = daofuncionario.CarregarContrato();

            cbContrato.DataSource = dt4;

            cbContrato.ValueMember = "TB_CONTRATO_ID";
            cbContrato.DisplayMember = "TB_CONTRATO_DESC";

            #endregion
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCPF.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEnd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateNasc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCTPS.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPIS.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbContrato.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbCargo.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cbDepartamento.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cbSituacao.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtSalario.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cbEmpresa.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            dateContrato.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtSenha.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
        }

        private void CarregarFuncionario()
        {
            FuncionarioController daofuncionario = new FuncionarioController();

            ColecaoFuncionario colecaofuncionario = daofuncionario.SelecionarFuncionario();

            dataGridView1.DataSource = colecaofuncionario;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                Funcionario obj = new Funcionario();
                obj.Nome = txtNome.Text;
                obj.Email = txtEmail.Text;
                obj.Cpf = txtCPF.Text;
                obj.DataCon = dateContrato.Text;
                obj.DataNasc = dateNasc.Text;
                obj.Tel = txtTel.Text;
                obj.Senha = txtSenha.Text;
                obj.Email = txtEmail.Text;
                obj.CTPS = txtCTPS.Text;
                obj.PIS = txtPIS.Text;
                obj.Endereco = txtEnd.Text;
                obj.Salario = double.Parse(txtSalario.Text);
                obj.Cargo = Convert.ToInt32(cbCargo.SelectedValue);
                obj.Situacao = Convert.ToInt32(cbSituacao.SelectedValue);
                obj.Empresa = Convert.ToInt32(cbEmpresa.SelectedValue);
                obj.Departamento = Convert.ToInt32(cbDepartamento.SelectedValue);
                obj.Contrato = Convert.ToInt32(cbContrato.SelectedValue);
                obj.Id1 = int.Parse(txtID.Text);


                FuncionarioController dao = new FuncionarioController();
                dao.alterar(obj);
                MessageBox.Show("Alterado com sucesso!");
                dataGridView1.DataSource = dao.SelecionarFuncionario();
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

                Funcionario obj = new Funcionario();

                obj.Id1 = int.Parse(txtID.Text);

                FuncionarioController dao = new FuncionarioController();
                dao.excluir(obj);
                MessageBox.Show("Excluido com sucesso!");
                dataGridView1.DataSource = dao.SelecionarFuncionario();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {

                Funcionario funcionario = new Funcionario();
                funcionario.Nome = textBox1.Text;

                FuncionarioController daofuncionario = new FuncionarioController();
                ColecaoFuncionario colecaofuncionario = daofuncionario.SelecionarEspecifico(funcionario);

                dataGridView1.DataSource = colecaofuncionario;

            }
            else
            {
                CarregarFuncionario();
            }
        }
    }
}
