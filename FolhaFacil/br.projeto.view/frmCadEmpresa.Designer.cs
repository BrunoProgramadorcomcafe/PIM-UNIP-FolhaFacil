namespace FolhaFacil.br.projeto.view
{
    partial class frmCadEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEmpresa));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLogado = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnCad = new Button();
            pictureBox1 = new PictureBox();
            txtTel = new TextBox();
            txtEnd = new TextBox();
            txtCNPJ = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLightLight;
            statusStrip1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblLogado });
            statusStrip1.Location = new Point(0, 513);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(931, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.ControlLightLight;
            toolStripStatusLabel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(92, 17);
            toolStripStatusLabel1.Text = "Logado com:";
            // 
            // lblLogado
            // 
            lblLogado.Name = "lblLogado";
            lblLogado.Size = new Size(141, 17);
            lblLogado.Text = "toolStripStatusLabel2";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(931, 29);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Image = (Image)resources.GetObject("voltarToolStripMenuItem.Image");
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(65, 25);
            voltarToolStripMenuItem.Text = "Sair";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnCad);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtTel);
            panel1.Controls.Add(txtEnd);
            panel1.Controls.Add(txtCNPJ);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(51, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 478);
            panel1.TabIndex = 8;
            // 
            // btnCad
            // 
            btnCad.BackColor = Color.MediumTurquoise;
            btnCad.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCad.Location = new Point(380, 379);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(124, 35);
            btnCad.TabIndex = 32;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = false;
            btnCad.Click += btnCad_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(538, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(194, 292);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(310, 27);
            txtTel.TabIndex = 10;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(194, 259);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(310, 27);
            txtEnd.TabIndex = 9;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(194, 226);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(310, 27);
            txtCNPJ.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(194, 193);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(310, 27);
            txtNome.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(194, 160);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(149, 27);
            txtID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 265);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 5;
            label6.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 232);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 4;
            label5.Text = "CNPJ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 298);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 199);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 166);
            label2.Name = "label2";
            label2.Size = new Size(31, 21);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 66);
            label1.Name = "label1";
            label1.Size = new Size(299, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Empresa";
            // 
            // frmCadEmpresa
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(931, 535);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmCadEmpresa";
            Text = "Cadastro de Empresa";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLogado;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtTel;
        private TextBox txtEnd;
        private TextBox txtCNPJ;
        private TextBox txtNome;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCad;
        private PictureBox pictureBox1;
        private ComboBox cbSenha;
        private ComboBox cbDataCon;
        private ComboBox cbEmpresa;
        private ComboBox cbSalario;
        private ComboBox cbSituacao;
        private ComboBox cbDep;
        private ComboBox cbCargo;
        private ComboBox cbCont;
        private TextBox txtPIS;
        private TextBox txtCTPS;
        private TextBox txtNasc;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}