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
    public partial class frmCadCargoDepart : Form
    {
        public frmCadCargoDepart()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadCargo_Click(object sender, EventArgs e)
        {
            try
            {

                Cargo obj = new Cargo();
                obj.Descricao = txtDescCargo.Text;

                CargoController dao = new CargoController();
                dao.cadastrar(obj);
                MessageBox.Show("Cargo cadastrado com sucesso!");
                Consistencia.limparcampos2(panel1);
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }

        private void btnCadDep_Click(object sender, EventArgs e)
        {
            try
            {

                Departamento obj = new Departamento();
                obj.Descricao = txtDescDep.Text;

                DepartamentoController dao = new DepartamentoController();
                dao.cadastrar(obj);
                MessageBox.Show("Departamento cadastrado com sucesso!");
                Consistencia.limparcampos2(panel2);
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }
        }
    }
}
