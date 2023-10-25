namespace FolhaFacil.br.projeto.view
{
    partial class frmConsultaFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaFolha));
            dataGridView1 = new DataGridView();
            colunaIDfolha = new DataGridViewTextBoxColumn();
            colunaDATAfolha = new DataGridViewTextBoxColumn();
            colunaVALORfolha = new DataGridViewTextBoxColumn();
            colunaFUNfolha = new DataGridViewTextBoxColumn();
            colunaEMPRESAfolha = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            colunaIDdesc = new DataGridViewTextBoxColumn();
            colunaDESCdesc = new DataGridViewTextBoxColumn();
            colunaQTDdesc = new DataGridViewTextBoxColumn();
            colunaVALORdesc = new DataGridViewTextBoxColumn();
            colunaFOLHAdesc = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            colunaIDacresc = new DataGridViewTextBoxColumn();
            colunaACRESCacresc = new DataGridViewTextBoxColumn();
            colunaQTDacresc = new DataGridViewTextBoxColumn();
            colunaVALORacresc = new DataGridViewTextBoxColumn();
            colunaFOLHAacresc = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel2 = new Panel();
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
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEnd = new TextBox();
            label4 = new Label();
            txtCNPJ = new TextBox();
            label3 = new Label();
            label15 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLogado = new ToolStripStatusLabel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            txtTotalLiq = new TextBox();
            txtTotalDesc = new TextBox();
            txtTotalVenc = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colunaIDfolha, colunaDATAfolha, colunaVALORfolha, colunaFUNfolha, colunaEMPRESAfolha });
            dataGridView1.Location = new Point(628, 104);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 121);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colunaIDfolha
            // 
            colunaIDfolha.HeaderText = "ID";
            colunaIDfolha.Name = "colunaIDfolha";
            colunaIDfolha.ReadOnly = true;
            // 
            // colunaDATAfolha
            // 
            colunaDATAfolha.HeaderText = "Periodo";
            colunaDATAfolha.Name = "colunaDATAfolha";
            colunaDATAfolha.ReadOnly = true;
            // 
            // colunaVALORfolha
            // 
            colunaVALORfolha.HeaderText = "Valor Final";
            colunaVALORfolha.Name = "colunaVALORfolha";
            colunaVALORfolha.ReadOnly = true;
            // 
            // colunaFUNfolha
            // 
            colunaFUNfolha.HeaderText = "Funcionario";
            colunaFUNfolha.Name = "colunaFUNfolha";
            colunaFUNfolha.ReadOnly = true;
            // 
            // colunaEMPRESAfolha
            // 
            colunaEMPRESAfolha.HeaderText = "Empresa";
            colunaEMPRESAfolha.Name = "colunaEMPRESAfolha";
            colunaEMPRESAfolha.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(628, 67);
            label1.Name = "label1";
            label1.Size = new Size(246, 22);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar por Funcionário:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(txtTotalLiq);
            panel1.Controls.Add(txtTotalDesc);
            panel1.Controls.Add(txtTotalVenc);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtEnd);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCNPJ);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView3);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 602);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(880, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colunaIDdesc, colunaDESCdesc, colunaQTDdesc, colunaVALORdesc, colunaFOLHAdesc });
            dataGridView2.Location = new Point(628, 246);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(246, 150);
            dataGridView2.TabIndex = 3;
            // 
            // colunaIDdesc
            // 
            colunaIDdesc.HeaderText = "ID";
            colunaIDdesc.Name = "colunaIDdesc";
            colunaIDdesc.ReadOnly = true;
            // 
            // colunaDESCdesc
            // 
            colunaDESCdesc.HeaderText = "Desconto";
            colunaDESCdesc.Name = "colunaDESCdesc";
            colunaDESCdesc.ReadOnly = true;
            // 
            // colunaQTDdesc
            // 
            colunaQTDdesc.HeaderText = "Quantidade";
            colunaQTDdesc.Name = "colunaQTDdesc";
            colunaQTDdesc.ReadOnly = true;
            // 
            // colunaVALORdesc
            // 
            colunaVALORdesc.HeaderText = "Valor";
            colunaVALORdesc.Name = "colunaVALORdesc";
            colunaVALORdesc.ReadOnly = true;
            // 
            // colunaFOLHAdesc
            // 
            colunaFOLHAdesc.HeaderText = "Folha";
            colunaFOLHAdesc.Name = "colunaFOLHAdesc";
            colunaFOLHAdesc.ReadOnly = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { colunaIDacresc, colunaACRESCacresc, colunaQTDacresc, colunaVALORacresc, colunaFOLHAacresc });
            dataGridView3.Location = new Point(925, 246);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(246, 150);
            dataGridView3.TabIndex = 4;
            // 
            // colunaIDacresc
            // 
            colunaIDacresc.HeaderText = "ID";
            colunaIDacresc.Name = "colunaIDacresc";
            colunaIDacresc.ReadOnly = true;
            // 
            // colunaACRESCacresc
            // 
            colunaACRESCacresc.HeaderText = "Acréscimo";
            colunaACRESCacresc.Name = "colunaACRESCacresc";
            colunaACRESCacresc.ReadOnly = true;
            // 
            // colunaQTDacresc
            // 
            colunaQTDacresc.HeaderText = "Quantidade";
            colunaQTDacresc.Name = "colunaQTDacresc";
            colunaQTDacresc.ReadOnly = true;
            // 
            // colunaVALORacresc
            // 
            colunaVALORacresc.HeaderText = "Valor";
            colunaVALORacresc.Name = "colunaVALORacresc";
            colunaVALORacresc.ReadOnly = true;
            // 
            // colunaFOLHAacresc
            // 
            colunaFOLHAacresc.HeaderText = "Folha";
            colunaFOLHAacresc.Name = "colunaFOLHAacresc";
            colunaFOLHAacresc.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(342, 8);
            label2.Name = "label2";
            label2.Size = new Size(453, 32);
            label2.TabIndex = 5;
            label2.Text = "Consulta da Folha de Pagamento";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(1174, 10);
            panel2.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.MediumTurquoise;
            label14.Location = new Point(438, 282);
            label14.Name = "label14";
            label14.Size = new Size(43, 19);
            label14.TabIndex = 48;
            label14.Text = "IRRF:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.MediumTurquoise;
            label13.Location = new Point(285, 281);
            label13.Name = "label13";
            label13.Size = new Size(45, 19);
            label13.TabIndex = 47;
            label13.Text = "INSS:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.MediumTurquoise;
            label12.Location = new Point(128, 281);
            label12.Name = "label12";
            label12.Size = new Size(49, 19);
            label12.TabIndex = 46;
            label12.Text = "FGTS:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 284);
            label11.Name = "label11";
            label11.Size = new Size(117, 17);
            label11.TabIndex = 45;
            label11.Text = "Base de Cálculo:";
            // 
            // txtFGTS
            // 
            txtFGTS.Location = new Point(314, 344);
            txtFGTS.Name = "txtFGTS";
            txtFGTS.ReadOnly = true;
            txtFGTS.Size = new Size(126, 23);
            txtFGTS.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.MediumTurquoise;
            label10.Location = new Point(200, 348);
            label10.Name = "label10";
            label10.Size = new Size(108, 19);
            label10.TabIndex = 43;
            label10.Text = "FGTS do Mês:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(376, 191);
            txtSalario.Name = "txtSalario";
            txtSalario.ReadOnly = true;
            txtSalario.Size = new Size(212, 23);
            txtSalario.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(315, 197);
            label9.Name = "label9";
            label9.Size = new Size(55, 17);
            label9.TabIndex = 41;
            label9.Text = "Salário:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(108, 191);
            txtCargo.Name = "txtCargo";
            txtCargo.ReadOnly = true;
            txtCargo.Size = new Size(201, 23);
            txtCargo.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 197);
            label8.Name = "label8";
            label8.Size = new Size(54, 17);
            label8.TabIndex = 39;
            label8.Text = "Cargo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(308, 226);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 37;
            label7.Text = "Periodo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 226);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 35;
            label5.Text = "Admissão:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 168);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 33;
            label6.Text = "Colaborador:";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(108, 133);
            txtEnd.Name = "txtEnd";
            txtEnd.ReadOnly = true;
            txtEnd.Size = new Size(480, 23);
            txtEnd.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 139);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 31;
            label4.Text = "Endereço:";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(367, 104);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Size = new Size(221, 23);
            txtCNPJ.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 110);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 29;
            label3.Text = "CNPJ:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(35, 110);
            label15.Name = "label15";
            label15.Size = new Size(67, 17);
            label15.TabIndex = 27;
            label15.Text = "Empresa:";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLightLight;
            statusStrip1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblLogado });
            statusStrip1.Location = new Point(0, 617);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(1198, 22);
            statusStrip1.TabIndex = 9;
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
            // textBox2
            // 
            textBox2.Location = new Point(110, 104);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 52;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 162);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(480, 23);
            textBox3.TabIndex = 53;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(107, 220);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(201, 23);
            textBox4.TabIndex = 54;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(376, 220);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(212, 23);
            textBox5.TabIndex = 55;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(183, 277);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(96, 23);
            textBox6.TabIndex = 56;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(336, 277);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(96, 23);
            textBox7.TabIndex = 57;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(487, 277);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(101, 23);
            textBox8.TabIndex = 58;
            // 
            // txtTotalLiq
            // 
            txtTotalLiq.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalLiq.Location = new Point(314, 439);
            txtTotalLiq.Name = "txtTotalLiq";
            txtTotalLiq.ReadOnly = true;
            txtTotalLiq.Size = new Size(126, 27);
            txtTotalLiq.TabIndex = 63;
            // 
            // txtTotalDesc
            // 
            txtTotalDesc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalDesc.Location = new Point(314, 373);
            txtTotalDesc.Name = "txtTotalDesc";
            txtTotalDesc.ReadOnly = true;
            txtTotalDesc.Size = new Size(126, 27);
            txtTotalDesc.TabIndex = 62;
            // 
            // txtTotalVenc
            // 
            txtTotalVenc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalVenc.Location = new Point(314, 406);
            txtTotalVenc.Name = "txtTotalVenc";
            txtTotalVenc.ReadOnly = true;
            txtTotalVenc.Size = new Size(126, 27);
            txtTotalVenc.TabIndex = 61;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(172, 445);
            label16.Name = "label16";
            label16.Size = new Size(136, 21);
            label16.TabIndex = 60;
            label16.Text = "TOTAL LÍQUIDO:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(145, 412);
            label17.Name = "label17";
            label17.Size = new Size(163, 21);
            label17.TabIndex = 59;
            label17.Text = "Total de Descontos:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(138, 379);
            label18.Name = "label18";
            label18.Size = new Size(170, 21);
            label18.TabIndex = 64;
            label18.Text = "Total de Acréscimos:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(603, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 554);
            panel3.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(236, 518);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 65;
            button1.Text = "Inativar Folha";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(802, 412);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // frmConsultaFolha
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1198, 639);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmConsultaFolha";
            Text = "Consulta Folha";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colunaIDfolha;
        private DataGridViewTextBoxColumn colunaDATAfolha;
        private DataGridViewTextBoxColumn colunaVALORfolha;
        private DataGridViewTextBoxColumn colunaFUNfolha;
        private DataGridViewTextBoxColumn colunaEMPRESAfolha;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn colunaIDacresc;
        private DataGridViewTextBoxColumn colunaACRESCacresc;
        private DataGridViewTextBoxColumn colunaQTDacresc;
        private DataGridViewTextBoxColumn colunaVALORacresc;
        private DataGridViewTextBoxColumn colunaFOLHAacresc;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colunaIDdesc;
        private DataGridViewTextBoxColumn colunaDESCdesc;
        private DataGridViewTextBoxColumn colunaQTDdesc;
        private DataGridViewTextBoxColumn colunaVALORdesc;
        private DataGridViewTextBoxColumn colunaFOLHAdesc;
        private Panel panel2;
        private Label label2;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtFGTS;
        private Label label10;
        private TextBox txtSalario;
        private Label label9;
        private TextBox txtCargo;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label6;
        private TextBox txtEnd;
        private Label label4;
        private TextBox txtCNPJ;
        private Label label3;
        private Label label15;
        private TextBox textBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLogado;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button1;
        private Panel panel3;
        private Label label18;
        private TextBox txtTotalLiq;
        private TextBox txtTotalDesc;
        private TextBox txtTotalVenc;
        private Label label16;
        private Label label17;
        private PictureBox pictureBox1;
    }
}