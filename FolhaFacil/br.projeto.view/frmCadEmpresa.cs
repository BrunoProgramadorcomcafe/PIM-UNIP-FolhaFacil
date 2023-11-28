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
    public partial class frmCadEmpresa : Form
    {
        public frmCadEmpresa()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            try
            {

                Empresa obj = new Empresa();
                obj.Nome = txtNome.Text;
                obj.CNPJ = txtCNPJ.Text;
                obj.Endereco = txtEnd.Text;
                obj.Tel = txtTel.Text;

                EmpresaController dao = new EmpresaController();
                dao.cadastrar(obj);
                MessageBox.Show("Empresa cadastrada com sucesso!");
                Consistencia.limparcampos2(panel1);
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }
    }
}
