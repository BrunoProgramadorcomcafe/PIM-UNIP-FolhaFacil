namespace FolhaFacil.br.projeto.view
{
    partial class frmConFun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConFun));
            panel1 = new Panel();
            txtEmail = new TextBox();
            label19 = new Label();
            dateNasc = new DateTimePicker();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            txtSenha = new TextBox();
            txtSalario = new TextBox();
            dateContrato = new DateTimePicker();
            txtTel = new TextBox();
            label17 = new Label();
            txtID = new TextBox();
            label16 = new Label();
            cbEmpresa = new ComboBox();
            cbSituacao = new ComboBox();
            cbDepartamento = new ComboBox();
            cbCargo = new ComboBox();
            cbContrato = new ComboBox();
            txtPIS = new TextBox();
            txtCTPS = new TextBox();
            txtEnd = new TextBox();
            txtCPF = new TextBox();
            txtNome = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label18 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            ENDERECO = new DataGridViewTextBoxColumn();
            NASC = new DataGridViewTextBoxColumn();
            CTPS = new DataGridViewTextBoxColumn();
            PIS = new DataGridViewTextBoxColumn();
            TELEFONE = new DataGridViewTextBoxColumn();
            CONTRATO = new DataGridViewTextBoxColumn();
            CARGO = new DataGridViewTextBoxColumn();
            DEPARTAMENTO = new DataGridViewTextBoxColumn();
            SITUACAO = new DataGridViewTextBoxColumn();
            SALARIO = new DataGridViewTextBoxColumn();
            EMPRESA = new DataGridViewTextBoxColumn();
            DATACONTRATO = new DataGridViewTextBoxColumn();
            SENHA = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(dateNasc);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(dateContrato);
            panel1.Controls.Add(txtTel);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(cbEmpresa);
            panel1.Controls.Add(cbSituacao);
            panel1.Controls.Add(cbDepartamento);
            panel1.Controls.Add(cbCargo);
            panel1.Controls.Add(cbContrato);
            panel1.Controls.Add(txtPIS);
            panel1.Controls.Add(txtCTPS);
            panel1.Controls.Add(txtEnd);
            panel1.Controls.Add(txtCPF);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(540, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 503);
            panel1.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(161, 285);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(356, 23);
            txtEmail.TabIndex = 43;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(108, 291);
            label19.Name = "label19";
            label19.Size = new Size(47, 17);
            label19.TabIndex = 42;
            label19.Text = "Email:";
            // 
            // dateNasc
            // 
            dateNasc.CustomFormat = "yyyy-MM-dd";
            dateNasc.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateNasc.Format = DateTimePickerFormat.Custom;
            dateNasc.Location = new Point(161, 169);
            dateNasc.Name = "dateNasc";
            dateNasc.Size = new Size(356, 23);
            dateNasc.TabIndex = 41;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.MediumTurquoise;
            btnLimpar.Location = new Point(410, 465);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 31);
            btnLimpar.TabIndex = 40;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.MediumTurquoise;
            btnExcluir.Location = new Point(265, 465);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 31);
            btnExcluir.TabIndex = 39;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.MediumTurquoise;
            btnAlterar.Location = new Point(103, 465);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 31);
            btnAlterar.TabIndex = 38;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(417, 418);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(142, 23);
            txtSenha.TabIndex = 37;
            // 
            // txtSalario
            // 
            txtSalario.Cursor = Cursors.IBeam;
            txtSalario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalario.Location = new Point(417, 313);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(142, 23);
            txtSalario.TabIndex = 36;
            // 
            // dateContrato
            // 
            dateContrato.CustomFormat = "yyyy-MM-dd";
            dateContrato.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateContrato.Format = DateTimePickerFormat.Custom;
            dateContrato.Location = new Point(417, 383);
            dateContrato.Name = "dateContrato";
            dateContrato.Size = new Size(142, 23);
            dateContrato.TabIndex = 35;
            // 
            // txtTel
            // 
            txtTel.Cursor = Cursors.IBeam;
            txtTel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTel.Location = new Point(161, 256);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(356, 23);
            txtTel.TabIndex = 34;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(90, 262);
            label17.Name = "label17";
            label17.Size = new Size(65, 17);
            label17.TabIndex = 33;
            label17.Text = "Telefone:";
            // 
            // txtID
            // 
            txtID.Cursor = Cursors.IBeam;
            txtID.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(161, 53);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(179, 23);
            txtID.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(130, 59);
            label16.Name = "label16";
            label16.Size = new Size(25, 17);
            label16.TabIndex = 31;
            label16.Text = "ID:";
            // 
            // cbEmpresa
            // 
            cbEmpresa.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmpresa.FormattingEnabled = true;
            cbEmpresa.Location = new Point(417, 346);
            cbEmpresa.Name = "cbEmpresa";
            cbEmpresa.Size = new Size(142, 25);
            cbEmpresa.TabIndex = 26;
            // 
            // cbSituacao
            // 
            cbSituacao.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbSituacao.FormattingEnabled = true;
            cbSituacao.Location = new Point(132, 421);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(142, 25);
            cbSituacao.TabIndex = 24;
            // 
            // cbDepartamento
            // 
            cbDepartamento.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Location = new Point(132, 386);
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(142, 25);
            cbDepartamento.TabIndex = 23;
            // 
            // cbCargo
            // 
            cbCargo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(132, 351);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(142, 25);
            cbCargo.TabIndex = 22;
            // 
            // cbContrato
            // 
            cbContrato.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbContrato.FormattingEnabled = true;
            cbContrato.Location = new Point(132, 316);
            cbContrato.Name = "cbContrato";
            cbContrato.Size = new Size(142, 25);
            cbContrato.TabIndex = 21;
            // 
            // txtPIS
            // 
            txtPIS.Cursor = Cursors.IBeam;
            txtPIS.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPIS.Location = new Point(161, 227);
            txtPIS.Name = "txtPIS";
            txtPIS.Size = new Size(356, 23);
            txtPIS.TabIndex = 20;
            // 
            // txtCTPS
            // 
            txtCTPS.Cursor = Cursors.IBeam;
            txtCTPS.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCTPS.Location = new Point(161, 198);
            txtCTPS.Name = "txtCTPS";
            txtCTPS.Size = new Size(356, 23);
            txtCTPS.TabIndex = 19;
            // 
            // txtEnd
            // 
            txtEnd.Cursor = Cursors.IBeam;
            txtEnd.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnd.Location = new Point(161, 140);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(356, 23);
            txtEnd.TabIndex = 17;
            // 
            // txtCPF
            // 
            txtCPF.Cursor = Cursors.IBeam;
            txtCPF.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(161, 111);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(356, 23);
            txtCPF.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(161, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(356, 23);
            txtNome.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(344, 354);
            label15.Name = "label15";
            label15.Size = new Size(67, 17);
            label15.TabIndex = 14;
            label15.Text = "Empresa:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(360, 424);
            label14.Name = "label14";
            label14.Size = new Size(51, 17);
            label14.TabIndex = 13;
            label14.Text = "Senha:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(356, 319);
            label13.Name = "label13";
            label13.Size = new Size(55, 17);
            label13.TabIndex = 12;
            label13.Text = "Salário:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(281, 389);
            label12.Name = "label12";
            label12.Size = new Size(130, 17);
            label12.TabIndex = 11;
            label12.Text = "Data de Contrato:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(126, 233);
            label11.Name = "label11";
            label11.Size = new Size(29, 17);
            label11.TabIndex = 10;
            label11.Text = "PIS:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(17, 394);
            label10.Name = "label10";
            label10.Size = new Size(109, 17);
            label10.TabIndex = 9;
            label10.Text = "Departamento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(72, 359);
            label9.Name = "label9";
            label9.Size = new Size(54, 17);
            label9.TabIndex = 8;
            label9.Text = "Cargo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(54, 324);
            label8.Name = "label8";
            label8.Size = new Size(72, 17);
            label8.TabIndex = 7;
            label8.Text = "Contrato:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(57, 429);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 6;
            label7.Text = "Situação:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(65, 175);
            label6.Name = "label6";
            label6.Size = new Size(90, 17);
            label6.TabIndex = 5;
            label6.Text = "Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(113, 204);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 4;
            label5.Text = "CTPS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(82, 146);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 117);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(103, 88);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(392, 32);
            label1.TabIndex = 0;
            label1.Text = "Alterar ou Excluir Funcionário";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 398);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(pictureBox1);
            panel2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 503);
            panel2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(150, 445);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 27);
            textBox1.TabIndex = 41;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(240, 423);
            label18.Name = "label18";
            label18.Size = new Size(162, 19);
            label18.TabIndex = 31;
            label18.Text = "Pesquisa por Nome:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, CPF, ENDERECO, NASC, CTPS, PIS, TELEFONE, CONTRATO, CARGO, DEPARTAMENTO, SITUACAO, SALARIO, EMPRESA, DATACONTRATO, SENHA, EMAIL });
            dataGridView1.Location = new Point(3, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(516, 383);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id1";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // CPF
            // 
            CPF.DataPropertyName = "Cpf";
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            // 
            // ENDERECO
            // 
            ENDERECO.DataPropertyName = "Endereco";
            ENDERECO.HeaderText = "Endereço";
            ENDERECO.Name = "ENDERECO";
            // 
            // NASC
            // 
            NASC.DataPropertyName = "DataNasc";
            NASC.HeaderText = "Nasc";
            NASC.Name = "NASC";
            // 
            // CTPS
            // 
            CTPS.DataPropertyName = "CTPS";
            CTPS.HeaderText = "CTPS";
            CTPS.Name = "CTPS";
            // 
            // PIS
            // 
            PIS.DataPropertyName = "PIS";
            PIS.HeaderText = "PIS";
            PIS.Name = "PIS";
            // 
            // TELEFONE
            // 
            TELEFONE.DataPropertyName = "Tel";
            TELEFONE.HeaderText = "Tel";
            TELEFONE.Name = "TELEFONE";
            // 
            // CONTRATO
            // 
            CONTRATO.DataPropertyName = "Contrato";
            CONTRATO.HeaderText = "Contrato";
            CONTRATO.Name = "CONTRATO";
            // 
            // CARGO
            // 
            CARGO.DataPropertyName = "Cargo";
            CARGO.HeaderText = "Cargo";
            CARGO.Name = "CARGO";
            // 
            // DEPARTAMENTO
            // 
            DEPARTAMENTO.DataPropertyName = "Departamento";
            DEPARTAMENTO.HeaderText = "Depart";
            DEPARTAMENTO.Name = "DEPARTAMENTO";
            // 
            // SITUACAO
            // 
            SITUACAO.DataPropertyName = "Situacao";
            SITUACAO.HeaderText = "Situação";
            SITUACAO.Name = "SITUACAO";
            // 
            // SALARIO
            // 
            SALARIO.DataPropertyName = "Salario";
            SALARIO.HeaderText = "Salário";
            SALARIO.Name = "SALARIO";
            // 
            // EMPRESA
            // 
            EMPRESA.DataPropertyName = "Empresa";
            EMPRESA.HeaderText = "Empresa";
            EMPRESA.Name = "EMPRESA";
            // 
            // DATACONTRATO
            // 
            DATACONTRATO.DataPropertyName = "DataCon";
            DATACONTRATO.HeaderText = "Data Contrato";
            DATACONTRATO.Name = "DATACONTRATO";
            // 
            // SENHA
            // 
            SENHA.DataPropertyName = "Senha";
            SENHA.HeaderText = "Senha";
            SENHA.Name = "SENHA";
            // 
            // EMAIL
            // 
            EMAIL.DataPropertyName = "Email";
            EMAIL.HeaderText = "Email";
            EMAIL.Name = "EMAIL";
            // 
            // frmConFun
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1137, 524);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmConFun";
            Text = "Consulta de Funcionário";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DateTimePicker dateContrato;
        private TextBox txtTel;
        private Label label17;
        private TextBox txtID;
        private Label label16;
        private ComboBox cbEmpresa;
        private ComboBox cbSituacao;
        private ComboBox cbDepartamento;
        private ComboBox cbCargo;
        private ComboBox cbContrato;
        private TextBox txtPIS;
        private TextBox txtCTPS;
        private TextBox txtEnd;
        private TextBox txtCPF;
        private TextBox txtNome;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtSenha;
        private TextBox txtSalario;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAlterar;
        private Label label18;
        private TextBox textBox1;
        private DateTimePicker dateNasc;
        private TextBox txtEmail;
        private Label label19;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn ENDERECO;
        private DataGridViewTextBoxColumn NASC;
        private DataGridViewTextBoxColumn CTPS;
        private DataGridViewTextBoxColumn PIS;
        private DataGridViewTextBoxColumn TELEFONE;
        private DataGridViewTextBoxColumn CONTRATO;
        private DataGridViewTextBoxColumn CARGO;
        private DataGridViewTextBoxColumn DEPARTAMENTO;
        private DataGridViewTextBoxColumn SITUACAO;
        private DataGridViewTextBoxColumn SALARIO;
        private DataGridViewTextBoxColumn EMPRESA;
        private DataGridViewTextBoxColumn DATACONTRATO;
        private DataGridViewTextBoxColumn SENHA;
        private DataGridViewTextBoxColumn EMAIL;
    }
}