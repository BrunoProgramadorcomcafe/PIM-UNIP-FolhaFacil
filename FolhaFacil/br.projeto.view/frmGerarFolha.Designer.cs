namespace FolhaFacil.br.projeto.view
{
    partial class frmGerarFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarFolha));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLogado = new ToolStripStatusLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnGerar = new Button();
            txtTotalLiq = new TextBox();
            txtTotalDesc = new TextBox();
            txtTotalVenc = new TextBox();
            label16 = new Label();
            label15 = new Label();
            btnRemove = new Button();
            tbGerarFolha = new DataGridView();
            colunaID = new DataGridViewTextBoxColumn();
            colunaDesc = new DataGridViewTextBoxColumn();
            colunaRef = new DataGridViewTextBoxColumn();
            colunaVenc = new DataGridViewTextBoxColumn();
            colunaDesconto = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            txtBaseIRRF = new TextBox();
            txtBaseINSS = new TextBox();
            txtBaseFGTS = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtFGTS = new TextBox();
            label10 = new Label();
            txtSalario = new TextBox();
            label9 = new Label();
            txtCargo = new TextBox();
            label8 = new Label();
            datePeriodo = new DateTimePicker();
            label7 = new Label();
            dateAdm = new DateTimePicker();
            label5 = new Label();
            cbColaborador = new ComboBox();
            label6 = new Label();
            panel3 = new Panel();
            txtEnd = new TextBox();
            label4 = new Label();
            txtCNPJ = new TextBox();
            label3 = new Label();
            cbEmpresa = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            tbAcresc = new DataGridView();
            colunaIDAcresc = new DataGridViewTextBoxColumn();
            colunaDescAcresc = new DataGridViewTextBoxColumn();
            colunaValorAcresc = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            tbDesc = new DataGridView();
            colunaIDDesc = new DataGridViewTextBoxColumn();
            colunaDescDesc = new DataGridViewTextBoxColumn();
            colunaValorDesc = new DataGridViewTextBoxColumn();
            label17 = new Label();
            label18 = new Label();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGerarFolha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAcresc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDesc).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLightLight;
            statusStrip1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblLogado });
            statusStrip1.Location = new Point(0, 531);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(1137, 22);
            statusStrip1.TabIndex = 8;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(tbDesc);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(tbAcresc);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnGerar);
            panel1.Controls.Add(txtTotalLiq);
            panel1.Controls.Add(txtTotalDesc);
            panel1.Controls.Add(txtTotalVenc);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(tbGerarFolha);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtBaseIRRF);
            panel1.Controls.Add(txtBaseINSS);
            panel1.Controls.Add(txtBaseFGTS);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtFGTS);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtCargo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(datePeriodo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateAdm);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbColaborador);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtEnd);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCNPJ);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbEmpresa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 516);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.MediumTurquoise;
            btnGerar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGerar.Location = new Point(15, 458);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(148, 36);
            btnGerar.TabIndex = 35;
            btnGerar.Text = "Gerar Folha";
            btnGerar.UseVisualStyleBackColor = false;
            // 
            // txtTotalLiq
            // 
            txtTotalLiq.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalLiq.Location = new Point(433, 467);
            txtTotalLiq.Name = "txtTotalLiq";
            txtTotalLiq.ReadOnly = true;
            txtTotalLiq.Size = new Size(126, 27);
            txtTotalLiq.TabIndex = 34;
            // 
            // txtTotalDesc
            // 
            txtTotalDesc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalDesc.Location = new Point(463, 434);
            txtTotalDesc.Name = "txtTotalDesc";
            txtTotalDesc.ReadOnly = true;
            txtTotalDesc.Size = new Size(96, 27);
            txtTotalDesc.TabIndex = 33;
            // 
            // txtTotalVenc
            // 
            txtTotalVenc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalVenc.Location = new Point(361, 434);
            txtTotalVenc.Name = "txtTotalVenc";
            txtTotalVenc.ReadOnly = true;
            txtTotalVenc.Size = new Size(96, 27);
            txtTotalVenc.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(291, 473);
            label16.Name = "label16";
            label16.Size = new Size(136, 21);
            label16.TabIndex = 31;
            label16.Text = "TOTAL LÍQUIDO:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(291, 440);
            label15.Name = "label15";
            label15.Size = new Size(64, 21);
            label15.TabIndex = 30;
            label15.Text = "TOTAL:";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 128, 128);
            btnRemove.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Location = new Point(565, 282);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(56, 42);
            btnRemove.TabIndex = 29;
            btnRemove.Text = "-";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // tbGerarFolha
            // 
            tbGerarFolha.AllowUserToAddRows = false;
            tbGerarFolha.AllowUserToDeleteRows = false;
            tbGerarFolha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbGerarFolha.Columns.AddRange(new DataGridViewColumn[] { colunaID, colunaDesc, colunaRef, colunaVenc, colunaDesconto });
            tbGerarFolha.Location = new Point(15, 282);
            tbGerarFolha.Name = "tbGerarFolha";
            tbGerarFolha.ReadOnly = true;
            tbGerarFolha.RowTemplate.Height = 25;
            tbGerarFolha.Size = new Size(544, 150);
            tbGerarFolha.TabIndex = 27;
            // 
            // colunaID
            // 
            colunaID.HeaderText = "ID";
            colunaID.Name = "colunaID";
            colunaID.ReadOnly = true;
            // 
            // colunaDesc
            // 
            colunaDesc.HeaderText = "Descrição";
            colunaDesc.Name = "colunaDesc";
            colunaDesc.ReadOnly = true;
            // 
            // colunaRef
            // 
            colunaRef.HeaderText = "Referência";
            colunaRef.Name = "colunaRef";
            colunaRef.ReadOnly = true;
            // 
            // colunaVenc
            // 
            colunaVenc.HeaderText = "Vencimentos";
            colunaVenc.Name = "colunaVenc";
            colunaVenc.ReadOnly = true;
            // 
            // colunaDesconto
            // 
            colunaDesconto.HeaderText = "Descontos";
            colunaDesconto.Name = "colunaDesconto";
            colunaDesconto.ReadOnly = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Location = new Point(0, 245);
            panel4.Name = "panel4";
            panel4.Size = new Size(1111, 10);
            panel4.TabIndex = 3;
            // 
            // txtBaseIRRF
            // 
            txtBaseIRRF.Location = new Point(934, 212);
            txtBaseIRRF.Name = "txtBaseIRRF";
            txtBaseIRRF.Size = new Size(113, 23);
            txtBaseIRRF.TabIndex = 26;
            // 
            // txtBaseINSS
            // 
            txtBaseINSS.Location = new Point(755, 212);
            txtBaseINSS.Name = "txtBaseINSS";
            txtBaseINSS.Size = new Size(113, 23);
            txtBaseINSS.TabIndex = 25;
            // 
            // txtBaseFGTS
            // 
            txtBaseFGTS.Location = new Point(565, 212);
            txtBaseFGTS.Name = "txtBaseFGTS";
            txtBaseFGTS.Size = new Size(113, 23);
            txtBaseFGTS.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.MediumTurquoise;
            label14.Location = new Point(881, 218);
            label14.Name = "label14";
            label14.Size = new Size(43, 19);
            label14.TabIndex = 23;
            label14.Text = "IRRF:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.MediumTurquoise;
            label13.Location = new Point(702, 218);
            label13.Name = "label13";
            label13.Size = new Size(45, 19);
            label13.TabIndex = 22;
            label13.Text = "INSS:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.MediumTurquoise;
            label12.Location = new Point(507, 218);
            label12.Name = "label12";
            label12.Size = new Size(49, 19);
            label12.TabIndex = 21;
            label12.Text = "FGTS:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(355, 218);
            label11.Name = "label11";
            label11.Size = new Size(117, 17);
            label11.TabIndex = 20;
            label11.Text = "Base de Cálculo:";
            // 
            // txtFGTS
            // 
            txtFGTS.Location = new Point(175, 212);
            txtFGTS.Name = "txtFGTS";
            txtFGTS.ReadOnly = true;
            txtFGTS.Size = new Size(144, 23);
            txtFGTS.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.MediumTurquoise;
            label10.Location = new Point(57, 218);
            label10.Name = "label10";
            label10.Size = new Size(108, 19);
            label10.TabIndex = 18;
            label10.Text = "FGTS do Mês:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(512, 174);
            txtSalario.Name = "txtSalario";
            txtSalario.ReadOnly = true;
            txtSalario.Size = new Size(142, 23);
            txtSalario.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(441, 180);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 16;
            label9.Text = "Salário:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(228, 176);
            txtCargo.Name = "txtCargo";
            txtCargo.ReadOnly = true;
            txtCargo.Size = new Size(201, 23);
            txtCargo.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(158, 182);
            label8.Name = "label8";
            label8.Size = new Size(54, 17);
            label8.TabIndex = 14;
            label8.Text = "Cargo:";
            // 
            // datePeriodo
            // 
            datePeriodo.Location = new Point(772, 172);
            datePeriodo.Name = "datePeriodo";
            datePeriodo.Size = new Size(200, 23);
            datePeriodo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(694, 178);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 12;
            label7.Text = "Periodo:";
            // 
            // dateAdm
            // 
            dateAdm.Location = new Point(772, 139);
            dateAdm.Name = "dateAdm";
            dateAdm.Size = new Size(200, 23);
            dateAdm.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(677, 145);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 10;
            label5.Text = "Admissão:";
            // 
            // cbColaborador
            // 
            cbColaborador.FormattingEnabled = true;
            cbColaborador.Location = new Point(228, 137);
            cbColaborador.Name = "cbColaborador";
            cbColaborador.Size = new Size(426, 25);
            cbColaborador.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 145);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 8;
            label6.Text = "Colaborador:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(1, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(1111, 10);
            panel3.TabIndex = 2;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(246, 90);
            txtEnd.Name = "txtEnd";
            txtEnd.ReadOnly = true;
            txtEnd.Size = new Size(675, 23);
            txtEnd.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 96);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 6;
            label4.Text = "Endereço:";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(601, 55);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(320, 23);
            txtCNPJ.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 61);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 4;
            label3.Text = "CNPJ:";
            // 
            // cbEmpresa
            // 
            cbEmpresa.FormattingEnabled = true;
            cbEmpresa.Location = new Point(246, 55);
            cbEmpresa.Name = "cbEmpresa";
            cbEmpresa.Size = new Size(272, 25);
            cbEmpresa.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 63);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 2;
            label2.Text = "Empresa:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(1, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 10);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 5);
            label1.Name = "label1";
            label1.Size = new Size(440, 32);
            label1.TabIndex = 0;
            label1.Text = "Cálculo da Folha de Pagamento";
            // 
            // tbAcresc
            // 
            tbAcresc.AllowUserToAddRows = false;
            tbAcresc.AllowUserToDeleteRows = false;
            tbAcresc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbAcresc.Columns.AddRange(new DataGridViewColumn[] { colunaIDAcresc, colunaDescAcresc, colunaValorAcresc });
            tbAcresc.Location = new Point(702, 320);
            tbAcresc.Name = "tbAcresc";
            tbAcresc.ReadOnly = true;
            tbAcresc.RowTemplate.Height = 25;
            tbAcresc.Size = new Size(191, 150);
            tbAcresc.TabIndex = 37;
            // 
            // colunaIDAcresc
            // 
            colunaIDAcresc.HeaderText = "ID";
            colunaIDAcresc.Name = "colunaIDAcresc";
            colunaIDAcresc.ReadOnly = true;
            colunaIDAcresc.Width = 50;
            // 
            // colunaDescAcresc
            // 
            colunaDescAcresc.HeaderText = "Descrição";
            colunaDescAcresc.Name = "colunaDescAcresc";
            colunaDescAcresc.ReadOnly = true;
            // 
            // colunaValorAcresc
            // 
            colunaValorAcresc.HeaderText = "Valor";
            colunaValorAcresc.Name = "colunaValorAcresc";
            colunaValorAcresc.ReadOnly = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1038, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // tbDesc
            // 
            tbDesc.AllowUserToAddRows = false;
            tbDesc.AllowUserToDeleteRows = false;
            tbDesc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbDesc.Columns.AddRange(new DataGridViewColumn[] { colunaIDDesc, colunaDescDesc, colunaValorDesc });
            tbDesc.Location = new Point(906, 320);
            tbDesc.Name = "tbDesc";
            tbDesc.ReadOnly = true;
            tbDesc.RowTemplate.Height = 25;
            tbDesc.Size = new Size(191, 150);
            tbDesc.TabIndex = 39;
            // 
            // colunaIDDesc
            // 
            colunaIDDesc.HeaderText = "ID";
            colunaIDDesc.Name = "colunaIDDesc";
            colunaIDDesc.ReadOnly = true;
            colunaIDDesc.Width = 50;
            // 
            // colunaDescDesc
            // 
            colunaDescDesc.HeaderText = "Descrição";
            colunaDescDesc.Name = "colunaDescDesc";
            colunaDescDesc.ReadOnly = true;
            // 
            // colunaValorDesc
            // 
            colunaValorDesc.HeaderText = "Valor";
            colunaValorDesc.Name = "colunaValorDesc";
            colunaValorDesc.ReadOnly = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(740, 296);
            label17.Name = "label17";
            label17.Size = new Size(112, 21);
            label17.TabIndex = 40;
            label17.Text = "Vencimentos";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(959, 296);
            label18.Name = "label18";
            label18.Size = new Size(91, 21);
            label18.TabIndex = 41;
            label18.Text = "Descontos";
            // 
            // frmGerarFolha
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1137, 553);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmGerarFolha";
            Text = "Gerar Folha de Pagamento";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGerarFolha).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAcresc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDesc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLogado;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private TextBox txtEnd;
        private Label label4;
        private TextBox txtCNPJ;
        private Label label3;
        private ComboBox cbEmpresa;
        private TextBox txtCargo;
        private Label label8;
        private DateTimePicker datePeriodo;
        private Label label7;
        private DateTimePicker dateAdm;
        private Label label5;
        private ComboBox cbColaborador;
        private Label label6;
        private Label label11;
        private TextBox txtFGTS;
        private Label label10;
        private TextBox txtSalario;
        private Label label9;
        private Panel panel4;
        private TextBox txtBaseIRRF;
        private TextBox txtBaseINSS;
        private TextBox txtBaseFGTS;
        private Label label14;
        private Label label13;
        private Label label12;
        private DataGridView tbGerarFolha;
        private DataGridViewTextBoxColumn colunaID;
        private DataGridViewTextBoxColumn colunaDesc;
        private DataGridViewTextBoxColumn colunaRef;
        private DataGridViewTextBoxColumn colunaVenc;
        private DataGridViewTextBoxColumn colunaDesconto;
        private Label label15;
        private Button btnRemove;
        private Button btnGerar;
        private TextBox txtTotalLiq;
        private TextBox txtTotalDesc;
        private TextBox txtTotalVenc;
        private Label label16;
        private PictureBox pictureBox1;
        private DataGridView tbAcresc;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn colunaIDAcresc;
        private DataGridViewTextBoxColumn colunaDescAcresc;
        private DataGridViewTextBoxColumn colunaValorAcresc;
        private Label label17;
        private DataGridView tbDesc;
        private DataGridViewTextBoxColumn colunaIDDesc;
        private DataGridViewTextBoxColumn colunaDescDesc;
        private DataGridViewTextBoxColumn colunaValorDesc;
        private Label label18;
    }
}