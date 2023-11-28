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
    public partial class frmGerarFolha : Form
    {
        double subtotala = 0;
        double subtotald = 0;
        double totalacrescimo;
        double totaldesconto;
        double total = 0;
        public frmGerarFolha()
        {
            InitializeComponent();
            tbAcresc.AutoGenerateColumns = false;
            CarregarAcrescimo();
            tbDesc.AutoGenerateColumns = false;
            CarregarDesconto();
            tbColaborador.AutoGenerateColumns = false;
            CarregarFuncionario();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CarregarAcrescimo()
        {
            AcrescimoController daoacrescimo = new AcrescimoController();

            ColecaoAcrescimo colecaoacrescimo = daoacrescimo.SelecionarAcrescimo();

            tbAcresc.DataSource = null;
            tbAcresc.DataSource = colecaoacrescimo;
        }

        private void CarregarDesconto()
        {
            DescontoController daoadesconto = new DescontoController();

            ColecaoDesconto colecaodesconto = daoadesconto.SelecionarDesconto();

            tbDesc.DataSource = null;
            tbDesc.DataSource = colecaodesconto;
        }

        private void CarregarFuncionario()
        {
            FuncionarioController daoafuncionario = new FuncionarioController();

            ColecaoFuncionario colecaofuncionario = daoafuncionario.SelecionarFuncionario();

            tbColaborador.DataSource = null;
            tbColaborador.DataSource = colecaofuncionario;
        }

        private void tbAcresc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItem.Text = tbAcresc.CurrentRow.Cells[0].Value.ToString();
            txtValorU.Text = tbAcresc.CurrentRow.Cells[2].Value.ToString();
        }

        private void tbDesc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItem.Text = tbDesc.CurrentRow.Cells[0].Value.ToString();
            txtValorU.Text = tbDesc.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnCarVenc_Click(object sender, EventArgs e)
        {
            subtotala = double.Parse(txtQTD.Text) * double.Parse(txtValorU.Text);

            DataGridViewRow row = (DataGridViewRow)tbGerarFolha.Rows[0].Clone();

            row.Cells[0].Value = txtItem.Text;
            row.Cells[1].Value = subtotala;
            row.Cells[2].Value = txtItem.Text;
            row.Cells[4].Value = txtQTD.Text;

            tbGerarFolha.Rows.Add(row);

            try
            {
                if (total == 0)
                {
                    total += (subtotala * double.Parse(txtSalario.Text)) + double.Parse(txtSalario.Text);
                    totalacrescimo += subtotala;

                    txtTotalVenc.Text = totalacrescimo.ToString();
                    txtTotalLiq.Text = total.ToString();

                    Consistencia.limparcampos2(panel3);
                }
                else
                {
                    total += subtotala * double.Parse(txtSalario.Text);
                    totalacrescimo += subtotala;

                    txtTotalVenc.Text = totalacrescimo.ToString();
                    txtTotalLiq.Text = total.ToString();

                    Consistencia.limparcampos2(panel3);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }

        }

        private void btnCarDesconto_Click(object sender, EventArgs e)
        {
            subtotald = double.Parse(txtQTD.Text) * double.Parse(txtValorU.Text);

            DataGridViewRow row = (DataGridViewRow)tbGerarFolha.Rows[0].Clone();

            row.Cells[0].Value = txtItem.Text;
            row.Cells[1].Value = subtotald;
            row.Cells[3].Value = txtItem.Text;
            row.Cells[4].Value = txtQTD.Text;

            tbGerarFolha.Rows.Add(row);

            try
            {
                if (total == 0)
                {
                    total = double.Parse(txtSalario.Text);
                    total -= subtotald * double.Parse(txtSalario.Text);
                    totaldesconto += subtotald;

                    txtTotalDesc.Text = totaldesconto.ToString();
                    txtTotalLiq.Text = total.ToString();

                    Consistencia.limparcampos2(panel3);
                }
                else
                {
                    total -= subtotald * double.Parse(txtSalario.Text);
                    totaldesconto += subtotald;

                    txtTotalDesc.Text = totaldesconto.ToString();
                    txtTotalLiq.Text = total.ToString();

                    Consistencia.limparcampos2(panel3);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO" + erro);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbGerarFolha.Rows.Count > 0)
                {
                    tbGerarFolha.Rows.Remove(tbGerarFolha.CurrentRow);
                }
                else { MessageBox.Show("SELECIONE UMA LINHA!!!"); }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void tbColaborador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = tbColaborador.CurrentRow.Cells[0].Value.ToString();
            txtCargo.Text = tbColaborador.CurrentRow.Cells[2].Value.ToString();
            txtSalario.Text = tbColaborador.CurrentRow.Cells[3].Value.ToString();
            dateCon.Text = tbColaborador.CurrentRow.Cells[4].Value.ToString();
            txtEmpresa.Text = tbColaborador.CurrentRow.Cells[5].Value.ToString();
            txtBaseFGTS.Text = tbColaborador.CurrentRow.Cells[3].Value.ToString();
            txtBaseIRRF.Text = tbColaborador.CurrentRow.Cells[3].Value.ToString();
            txtBaseINSS.Text = tbColaborador.CurrentRow.Cells[3].Value.ToString();

            double n;
            n = double.Parse(txtSalario.Text) * 0.08;
            txtFGTS.Text = n.ToString();
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            if (txtPesq.Text != string.Empty)
            {

                Funcionario funcionario = new Funcionario();
                funcionario.Nome = txtPesq.Text;

                FuncionarioController daofuncionario = new FuncionarioController();
                ColecaoFuncionario colecaofuncionario = daofuncionario.SelecionarEspecifico(funcionario);

                tbColaborador.DataSource = colecaofuncionario;

            }
            else
            {
                CarregarFuncionario();
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Folha f = new Folha();
            FolhaController daof = new FolhaController();

            f.Periodo = datePeriodo.Text;
            f.ValorFinal = double.Parse(txtTotalLiq.Text);
            f.Status = 1;
            f.Funcionario = Convert.ToInt32(txtNome.Text);
            f.Empresa = Convert.ToInt32(txtEmpresa.Text);

            daof.cadastrar(f);

            //Descobrir o id da ultima folha
            int idfolha = daof.retornaIdUltimaFolha();

            ItensAcrescimoController daoiacrescimo = new ItensAcrescimoController();
            ItensDescontoController daoidesconto = new ItensDescontoController();

            for (int rows = 0; rows < tbGerarFolha.Rows.Count - 1; rows++)
            {

                ItensAcrescimo item = new ItensAcrescimo();

                item.Folha = idfolha;
                item.Qtd = int.Parse(tbGerarFolha.Rows[rows].Cells["colunaQtd"].Value.ToString());
                item.Acrescimo = int.Parse(tbGerarFolha.Rows[rows].Cells["colunaID"].Value.ToString());
                item.ValorTotal = double.Parse(txtTotalVenc.Text);

                daoiacrescimo.cadastrar(item);

            }

            for (int rows = 0; rows < tbGerarFolha.Rows.Count - 1; rows++)
            {

                ItensDesconto item = new ItensDesconto();

                item.Folha = idfolha;
                item.Qtd = int.Parse(tbGerarFolha.Rows[rows].Cells["colunaQtd"].Value.ToString());
                item.Desconto = int.Parse(tbGerarFolha.Rows[rows].Cells["colunaID"].Value.ToString());
                item.ValorTotal = double.Parse(txtTotalDesc.Text);

                daoidesconto.cadastrar(item);

            }

            MessageBox.Show("Folha lançada com Sucesso!");
            Consistencia.limparcampos2(this);
            Consistencia.limparcampos2(panel1);
        }
    }
}
