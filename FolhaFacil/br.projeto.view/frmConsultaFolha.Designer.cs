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
            tbFolha = new DataGridView();
            colunaIDfolha = new DataGridViewTextBoxColumn();
            colunaDATAfolha = new DataGridViewTextBoxColumn();
            colunaVALORfolha = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            colunaFUNfolha = new DataGridViewTextBoxColumn();
            colunaEMPRESAfolha = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1 = new Panel();
            btnExcluir = new Button();
            label3 = new Label();
            txtStatus = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtId = new TextBox();
            label15 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtPesqFun = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLogado = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)tbFolha).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbFolha
            // 
            tbFolha.AllowUserToAddRows = false;
            tbFolha.AllowUserToDeleteRows = false;
            tbFolha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbFolha.Columns.AddRange(new DataGridViewColumn[] { colunaIDfolha, colunaDATAfolha, colunaVALORfolha, Column1, colunaFUNfolha, colunaEMPRESAfolha });
            tbFolha.Location = new Point(48, 122);
            tbFolha.Margin = new Padding(2);
            tbFolha.Name = "tbFolha";
            tbFolha.ReadOnly = true;
            tbFolha.RowTemplate.Height = 25;
            tbFolha.Size = new Size(645, 121);
            tbFolha.TabIndex = 0;
            tbFolha.CellClick += tbFolha_CellClick;
            tbFolha.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colunaIDfolha
            // 
            colunaIDfolha.DataPropertyName = "Id1";
            colunaIDfolha.HeaderText = "ID";
            colunaIDfolha.Name = "colunaIDfolha";
            colunaIDfolha.ReadOnly = true;
            // 
            // colunaDATAfolha
            // 
            colunaDATAfolha.DataPropertyName = "Periodo";
            colunaDATAfolha.HeaderText = "Periodo";
            colunaDATAfolha.Name = "colunaDATAfolha";
            colunaDATAfolha.ReadOnly = true;
            // 
            // colunaVALORfolha
            // 
            colunaVALORfolha.DataPropertyName = "ValorFinal";
            colunaVALORfolha.HeaderText = "Valor Final";
            colunaVALORfolha.Name = "colunaVALORfolha";
            colunaVALORfolha.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Status";
            Column1.HeaderText = "Status";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // colunaFUNfolha
            // 
            colunaFUNfolha.DataPropertyName = "Funcionario";
            colunaFUNfolha.HeaderText = "Funcionario";
            colunaFUNfolha.Name = "colunaFUNfolha";
            colunaFUNfolha.ReadOnly = true;
            // 
            // colunaEMPRESAfolha
            // 
            colunaEMPRESAfolha.DataPropertyName = "Empresa";
            colunaEMPRESAfolha.HeaderText = "Empresa";
            colunaEMPRESAfolha.Name = "colunaEMPRESAfolha";
            colunaEMPRESAfolha.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 85);
            label1.Name = "label1";
            label1.Size = new Size(300, 22);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar por ID do Funcionário:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtStatus);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPesqFun);
            panel1.Controls.Add(tbFolha);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 602);
            panel1.TabIndex = 2;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.Location = new Point(118, 442);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(134, 42);
            btnExcluir.TabIndex = 69;
            btnExcluir.Text = "Excluir Folha";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 325);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 68;
            label3.Text = "Status:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(118, 319);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(198, 23);
            txtStatus.TabIndex = 67;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(365, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(118, 377);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 65;
            button1.Text = "Inativar Folha";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 276);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(198, 23);
            txtId.TabIndex = 52;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(48, 282);
            label15.Name = "label15";
            label15.Size = new Size(64, 17);
            label15.TabIndex = 27;
            label15.Text = "ID Folha:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 10);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 11);
            label2.Name = "label2";
            label2.Size = new Size(453, 32);
            label2.TabIndex = 5;
            label2.Text = "Consulta da Folha de Pagamento";
            // 
            // txtPesqFun
            // 
            txtPesqFun.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesqFun.Location = new Point(354, 80);
            txtPesqFun.Name = "txtPesqFun";
            txtPesqFun.Size = new Size(338, 27);
            txtPesqFun.TabIndex = 2;
            txtPesqFun.TextChanged += txtPesqFun_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLightLight;
            statusStrip1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblLogado });
            statusStrip1.Location = new Point(0, 617);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(766, 22);
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
            // frmConsultaFolha
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(766, 639);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmConsultaFolha";
            Text = "Consulta Folha";
            ((System.ComponentModel.ISupportInitialize)tbFolha).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tbFolha;
        private Label label1;
        private Panel panel1;
        private TextBox txtPesqFun;
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
        private TextBox txtId;
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
        private DataGridViewTextBoxColumn colunaIDfolha;
        private DataGridViewTextBoxColumn colunaDATAfolha;
        private DataGridViewTextBoxColumn colunaVALORfolha;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn colunaFUNfolha;
        private DataGridViewTextBoxColumn colunaEMPRESAfolha;
        private Button btnExcluir;
        private TextBox txtStatus;
    }
}