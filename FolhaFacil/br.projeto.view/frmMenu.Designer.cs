namespace FolhaFacil.br.projeto.view
{
    partial class frmMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            menuStrip1 = new MenuStrip();
            cADASTROSToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            empresaToolStripMenuItem = new ToolStripMenuItem();
            menuAcresDesc = new ToolStripMenuItem();
            menuCargoDep = new ToolStripMenuItem();
            cONSULTASToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem1 = new ToolStripMenuItem();
            empresaToolStripMenuItem1 = new ToolStripMenuItem();
            menuConAcresDesc = new ToolStripMenuItem();
            menuConCargoDepar = new ToolStripMenuItem();
            folhaToolStripMenuItem = new ToolStripMenuItem();
            gERARFOLHAToolStripMenuItem = new ToolStripMenuItem();
            sAIRToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLogado = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            lblData = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            lblHora = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cADASTROSToolStripMenuItem, cONSULTASToolStripMenuItem, gERARFOLHAToolStripMenuItem, sAIRToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(874, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROSToolStripMenuItem
            // 
            cADASTROSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionárioToolStripMenuItem, empresaToolStripMenuItem, menuAcresDesc, menuCargoDep });
            cADASTROSToolStripMenuItem.Image = (Image)resources.GetObject("cADASTROSToolStripMenuItem.Image");
            cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            cADASTROSToolStripMenuItem.Size = new Size(123, 24);
            cADASTROSToolStripMenuItem.Text = "CADASTROS";
            cADASTROSToolStripMenuItem.Click += cADASTROSToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(257, 24);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // empresaToolStripMenuItem
            // 
            empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            empresaToolStripMenuItem.Size = new Size(257, 24);
            empresaToolStripMenuItem.Text = "Empresa";
            empresaToolStripMenuItem.Click += empresaToolStripMenuItem_Click;
            // 
            // menuAcresDesc
            // 
            menuAcresDesc.Name = "menuAcresDesc";
            menuAcresDesc.Size = new Size(257, 24);
            menuAcresDesc.Text = "Acréscimos e Descontos";
            menuAcresDesc.Click += menuAcresDesc_Click;
            // 
            // menuCargoDep
            // 
            menuCargoDep.Name = "menuCargoDep";
            menuCargoDep.Size = new Size(257, 24);
            menuCargoDep.Text = "Cargo e Departamento";
            menuCargoDep.Click += menuCargoDep_Click;
            // 
            // cONSULTASToolStripMenuItem
            // 
            cONSULTASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionárioToolStripMenuItem1, empresaToolStripMenuItem1, menuConAcresDesc, menuConCargoDepar, folhaToolStripMenuItem });
            cONSULTASToolStripMenuItem.Image = (Image)resources.GetObject("cONSULTASToolStripMenuItem.Image");
            cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            cONSULTASToolStripMenuItem.Size = new Size(121, 24);
            cONSULTASToolStripMenuItem.Text = "CONSULTAS";
            // 
            // funcionárioToolStripMenuItem1
            // 
            funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            funcionárioToolStripMenuItem1.Size = new Size(257, 24);
            funcionárioToolStripMenuItem1.Text = "Funcionário";
            funcionárioToolStripMenuItem1.Click += funcionárioToolStripMenuItem1_Click;
            // 
            // empresaToolStripMenuItem1
            // 
            empresaToolStripMenuItem1.Name = "empresaToolStripMenuItem1";
            empresaToolStripMenuItem1.Size = new Size(257, 24);
            empresaToolStripMenuItem1.Text = "Empresa";
            empresaToolStripMenuItem1.Click += empresaToolStripMenuItem1_Click;
            // 
            // menuConAcresDesc
            // 
            menuConAcresDesc.Name = "menuConAcresDesc";
            menuConAcresDesc.Size = new Size(257, 24);
            menuConAcresDesc.Text = "Acréscimos e Descontos";
            menuConAcresDesc.Click += menuConAcresDesc_Click;
            // 
            // menuConCargoDepar
            // 
            menuConCargoDepar.Name = "menuConCargoDepar";
            menuConCargoDepar.Size = new Size(257, 24);
            menuConCargoDepar.Text = "Cargo e Departamento";
            menuConCargoDepar.Click += menuConCargoDepar_Click;
            // 
            // folhaToolStripMenuItem
            // 
            folhaToolStripMenuItem.Name = "folhaToolStripMenuItem";
            folhaToolStripMenuItem.Size = new Size(257, 24);
            folhaToolStripMenuItem.Text = "Folha";
            folhaToolStripMenuItem.Click += folhaToolStripMenuItem_Click;
            // 
            // gERARFOLHAToolStripMenuItem
            // 
            gERARFOLHAToolStripMenuItem.Image = (Image)resources.GetObject("gERARFOLHAToolStripMenuItem.Image");
            gERARFOLHAToolStripMenuItem.Name = "gERARFOLHAToolStripMenuItem";
            gERARFOLHAToolStripMenuItem.Size = new Size(139, 24);
            gERARFOLHAToolStripMenuItem.Text = "GERAR FOLHA";
            gERARFOLHAToolStripMenuItem.Click += gERARFOLHAToolStripMenuItem_Click;
            // 
            // sAIRToolStripMenuItem
            // 
            sAIRToolStripMenuItem.Image = (Image)resources.GetObject("sAIRToolStripMenuItem.Image");
            sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            sAIRToolStripMenuItem.Size = new Size(69, 24);
            sAIRToolStripMenuItem.Text = "SAIR";
            sAIRToolStripMenuItem.Click += sAIRToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLightLight;
            statusStrip1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblLogado, toolStripStatusLabel3, lblData, toolStripStatusLabel5, lblHora });
            statusStrip1.Location = new Point(0, 522);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(874, 22);
            statusStrip1.TabIndex = 4;
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
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(42, 17);
            toolStripStatusLabel3.Text = "Data:";
            // 
            // lblData
            // 
            lblData.Name = "lblData";
            lblData.Size = new Size(141, 17);
            lblData.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(42, 17);
            toolStripStatusLabel5.Text = "Hora:";
            // 
            // lblHora
            // 
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(141, 17);
            lblHora.Text = "toolStripStatusLabel6";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(382, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 200);
            label1.Name = "label1";
            label1.Size = new Size(308, 41);
            label1.TabIndex = 6;
            label1.Text = "Economize Papel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 252);
            label2.Name = "label2";
            label2.Size = new Size(314, 41);
            label2.TabIndex = 7;
            label2.Text = "Imprima somente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 304);
            label3.Name = "label3";
            label3.Size = new Size(241, 41);
            label3.TabIndex = 8;
            label3.Text = "o necessário!";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(874, 544);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cADASTROSToolStripMenuItem;
        private ToolStripMenuItem cONSULTASToolStripMenuItem;
        private ToolStripMenuItem gERARFOLHAToolStripMenuItem;
        private ToolStripMenuItem sAIRToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem empresaToolStripMenuItem;
        private ToolStripMenuItem menuAcresDesc;
        private ToolStripMenuItem menuCargoDep;
        private ToolStripMenuItem funcionárioToolStripMenuItem1;
        private ToolStripMenuItem empresaToolStripMenuItem1;
        private ToolStripMenuItem menuConAcresDesc;
        private ToolStripMenuItem menuConCargoDepar;
        private ToolStripMenuItem folhaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lblData;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel lblHora;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        public ToolStripStatusLabel lblLogado;
    }
}