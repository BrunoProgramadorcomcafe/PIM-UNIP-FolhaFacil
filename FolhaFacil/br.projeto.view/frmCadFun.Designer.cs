namespace FolhaFacil.br.projeto.view
{
    partial class frmCadFun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFun));
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLogado = new ToolStripStatusLabel();
            panel1 = new Panel();
            dateNasc = new DateTimePicker();
            cbDepartamento = new ComboBox();
            cbContrato = new ComboBox();
            label18 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtSalario = new TextBox();
            dateContrato = new DateTimePicker();
            txtTel = new TextBox();
            label17 = new Label();
            txtID = new TextBox();
            label16 = new Label();
            btnCad = new Button();
            pictureBox1 = new PictureBox();
            cbEmpresa = new ComboBox();
            cbSituacao = new ComboBox();
            cbCargo = new ComboBox();
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
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(931, 29);
            menuStrip1.TabIndex = 0;
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
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLightLight;
            statusStrip1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblLogado });
            statusStrip1.Location = new Point(0, 513);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(931, 22);
            statusStrip1.TabIndex = 5;
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
            panel1.Controls.Add(dateNasc);
            panel1.Controls.Add(cbDepartamento);
            panel1.Controls.Add(cbContrato);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtSalario);
            panel1.Controls.Add(dateContrato);
            panel1.Controls.Add(txtTel);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(btnCad);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cbEmpresa);
            panel1.Controls.Add(cbSituacao);
            panel1.Controls.Add(cbCargo);
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
            panel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(40, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 478);
            panel1.TabIndex = 6;
            // 
            // dateNasc
            // 
            dateNasc.CustomFormat = "yyyy-MM-dd";
            dateNasc.Format = DateTimePickerFormat.Custom;
            dateNasc.Location = new Point(204, 171);
            dateNasc.Name = "dateNasc";
            dateNasc.Size = new Size(356, 23);
            dateNasc.TabIndex = 42;
            // 
            // cbDepartamento
            // 
            cbDepartamento.FormattingEnabled = true;
            cbDepartamento.Location = new Point(204, 400);
            cbDepartamento.Name = "cbDepartamento";
            cbDepartamento.Size = new Size(179, 25);
            cbDepartamento.TabIndex = 41;
            // 
            // cbContrato
            // 
            cbContrato.FormattingEnabled = true;
            cbContrato.Location = new Point(204, 332);
            cbContrato.Name = "cbContrato";
            cbContrato.Size = new Size(179, 25);
            cbContrato.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(144, 305);
            label18.Name = "label18";
            label18.Size = new Size(47, 17);
            label18.TabIndex = 39;
            label18.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(204, 299);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(356, 23);
            txtEmail.TabIndex = 38;
            // 
            // txtSenha
            // 
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Location = new Point(607, 437);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(179, 23);
            txtSenha.TabIndex = 37;
            // 
            // txtSalario
            // 
            txtSalario.Cursor = Cursors.IBeam;
            txtSalario.Location = new Point(607, 330);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(179, 23);
            txtSalario.TabIndex = 36;
            // 
            // dateContrato
            // 
            dateContrato.CustomFormat = "yyyy-MM-dd";
            dateContrato.Format = DateTimePickerFormat.Custom;
            dateContrato.Location = new Point(607, 402);
            dateContrato.Name = "dateContrato";
            dateContrato.Size = new Size(179, 23);
            dateContrato.TabIndex = 35;
            // 
            // txtTel
            // 
            txtTel.Cursor = Cursors.IBeam;
            txtTel.Location = new Point(204, 270);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(356, 23);
            txtTel.TabIndex = 34;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(127, 276);
            label17.Name = "label17";
            label17.Size = new Size(65, 17);
            label17.TabIndex = 33;
            label17.Text = "Telefone:";
            // 
            // txtID
            // 
            txtID.Cursor = Cursors.IBeam;
            txtID.Location = new Point(204, 39);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(179, 23);
            txtID.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(167, 45);
            label16.Name = "label16";
            label16.Size = new Size(25, 17);
            label16.TabIndex = 31;
            label16.Text = "ID:";
            // 
            // btnCad
            // 
            btnCad.BackColor = Color.MediumTurquoise;
            btnCad.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCad.Location = new Point(389, 449);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(107, 27);
            btnCad.TabIndex = 30;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = false;
            btnCad.Click += btnCad_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(581, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // cbEmpresa
            // 
            cbEmpresa.FormattingEnabled = true;
            cbEmpresa.Location = new Point(607, 365);
            cbEmpresa.Name = "cbEmpresa";
            cbEmpresa.Size = new Size(179, 25);
            cbEmpresa.TabIndex = 26;
            // 
            // cbSituacao
            // 
            cbSituacao.FormattingEnabled = true;
            cbSituacao.Location = new Point(204, 433);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(179, 25);
            cbSituacao.TabIndex = 24;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(204, 363);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(179, 25);
            cbCargo.TabIndex = 22;
            // 
            // txtPIS
            // 
            txtPIS.Cursor = Cursors.IBeam;
            txtPIS.Location = new Point(204, 237);
            txtPIS.Name = "txtPIS";
            txtPIS.Size = new Size(356, 23);
            txtPIS.TabIndex = 20;
            // 
            // txtCTPS
            // 
            txtCTPS.Cursor = Cursors.IBeam;
            txtCTPS.Location = new Point(204, 204);
            txtCTPS.Name = "txtCTPS";
            txtCTPS.Size = new Size(356, 23);
            txtCTPS.TabIndex = 19;
            // 
            // txtEnd
            // 
            txtEnd.Cursor = Cursors.IBeam;
            txtEnd.Location = new Point(204, 138);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(356, 23);
            txtEnd.TabIndex = 17;
            // 
            // txtCPF
            // 
            txtCPF.Cursor = Cursors.IBeam;
            txtCPF.Location = new Point(204, 105);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(356, 23);
            txtCPF.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(204, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(356, 23);
            txtNome.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(524, 373);
            label15.Name = "label15";
            label15.Size = new Size(67, 17);
            label15.TabIndex = 14;
            label15.Text = "Empresa:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(540, 443);
            label14.Name = "label14";
            label14.Size = new Size(51, 17);
            label14.TabIndex = 13;
            label14.Text = "Senha:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(536, 338);
            label13.Name = "label13";
            label13.Size = new Size(55, 17);
            label13.TabIndex = 12;
            label13.Text = "Salário:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(461, 408);
            label12.Name = "label12";
            label12.Size = new Size(130, 17);
            label12.TabIndex = 11;
            label12.Text = "Data de Contrato:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(162, 243);
            label11.Name = "label11";
            label11.Size = new Size(29, 17);
            label11.TabIndex = 10;
            label11.Text = "PIS:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(79, 406);
            label10.Name = "label10";
            label10.Size = new Size(109, 17);
            label10.TabIndex = 9;
            label10.Text = "Departamento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(134, 371);
            label9.Name = "label9";
            label9.Size = new Size(54, 17);
            label9.TabIndex = 8;
            label9.Text = "Cargo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(116, 336);
            label8.Name = "label8";
            label8.Size = new Size(72, 17);
            label8.TabIndex = 7;
            label8.Text = "Contrato:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 441);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 6;
            label7.Text = "Situação:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 177);
            label6.Name = "label6";
            label6.Size = new Size(90, 17);
            label6.TabIndex = 5;
            label6.Text = "Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 210);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 4;
            label5.Text = "CTPS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 144);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 111);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 78);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(273, 1);
            label1.Name = "label1";
            label1.Size = new Size(337, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionário";
            // 
            // frmCadFun
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
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmCadFun";
            Text = "Cadastro Funcionário";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLogado;
        private Panel panel1;
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
        private TextBox txtPIS;
        private TextBox txtCTPS;
        private TextBox txtEnd;
        private TextBox txtCPF;
        private TextBox txtNome;
        private ComboBox cbEmpresa;
        private ComboBox cbSituacao;
        private ComboBox cbCargo;
        private PictureBox pictureBox1;
        private Button btnCad;
        private TextBox txtID;
        private Label label16;
        private TextBox txtTel;
        private Label label17;
        private DateTimePicker dateContrato;
        private TextBox txtSenha;
        private TextBox txtSalario;
        private Label label18;
        private TextBox txtEmail;
        private ComboBox cbDepartamento;
        private ComboBox cbContrato;
        private DateTimePicker dateNasc;
    }
}