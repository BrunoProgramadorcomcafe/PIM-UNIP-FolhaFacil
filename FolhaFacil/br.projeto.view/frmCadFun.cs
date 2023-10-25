using FolhaFacil.br.projeto.controller;
using FolhaFacil.br.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FolhaFacil.br.projeto.view
{
    public partial class frmCadFun : Form
    {
        public frmCadFun()
        {
            InitializeComponent();
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

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            try
            {

                Funcionario obj = new Funcionario();
                obj.Nome = txtNome.Text;
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


                FuncionarioController dao = new FuncionarioController();
                dao.cadastrar(obj);
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                Consistencia.limparcampos2(panel1);
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }
    }
}
