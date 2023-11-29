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
    public partial class frmManual : Form
    {
        public frmManual()
        {
            InitializeComponent();
            move.Height = button1.Height;
            move.Top = button1.Top;
            panel1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            move.Height = button1.Height;
            move.Top = button1.Top;
            panel1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            move.Height = button2.Height;
            move.Top = button2.Top;
            panel2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            move.Height = button3.Height;
            move.Top = button3.Top;
            panel3.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            move.Height = button4.Height;
            move.Top = button4.Top;
            panel4.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            move.Height = button5.Height;
            move.Top = button5.Top;
            panel5.BringToFront();
        }
    }
}
