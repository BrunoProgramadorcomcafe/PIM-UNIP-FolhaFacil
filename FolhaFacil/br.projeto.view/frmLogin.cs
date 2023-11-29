using FolhaFacil.br.projeto.controller;
using FolhaFacil.br.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFacil.br.projeto.view
{
    public partial class frmLogin : Form
    {
        Funcionario funcionarioretorno = new Funcionario();
        public bool retorno = false;
        public frmLogin()
        {
            InitializeComponent();
            move.Height = btnTLogin.Height;
            move.Top = btnTLogin.Top;
            //userInicio1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTLogin_Click(object sender, EventArgs e)
        {
            move.Height = btnTLogin.Height;
            move.Top = btnTLogin.Top;
            panel3.BringToFront();
        }

        private void btnTManual_Click(object sender, EventArgs e)
        {
            move.Height = btnTManual.Height;
            move.Top = btnTManual.Top;
            panel1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //frmMenu tela = new frmMenu();
            //tela.Show();
            Funcionario funcionario = new Funcionario();
            funcionario.Email = txtUsuario.Text;
            funcionario.Senha = txtSenha.Text;

            FuncionarioController daofun = new FuncionarioController();
            funcionarioretorno = daofun.Login_funcionario(funcionario);

            if (funcionarioretorno.Nome != null)
            {
                MessageBox.Show("Bem vindo ao Folha Fácil!- Sr(a) "
                    + funcionarioretorno.Nome);

                frmMenu tela = new frmMenu();
                tela.lblLogado.Text = funcionarioretorno.Nome.ToString();

                retorno = true;
                this.Visible = false;
                tela.Show();
            }
            else
            {
                MessageBox.Show("Usuário invalido !");
                txtUsuario.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnManualUsuario_Click(object sender, EventArgs e)
        {
            frmManual tela = new frmManual();
            tela.Show();
        }
    }
}

