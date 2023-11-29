namespace FolhaFacil.br.projeto.view
{
    partial class frmConEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConEmpresa));
            panel1 = new Panel();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            txtID = new TextBox();
            txtTel = new TextBox();
            txtEnd = new TextBox();
            txtCNPJ = new TextBox();
            txtNome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtPesqNome = new TextBox();
            label18 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            ENDERECO = new DataGridViewTextBoxColumn();
            TEL = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtTel);
            panel1.Controls.Add(txtEnd);
            panel1.Controls.Add(txtCNPJ);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(540, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 503);
            panel1.TabIndex = 8;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.MediumTurquoise;
            btnLimpar.Location = new Point(411, 368);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 31);
            btnLimpar.TabIndex = 43;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.MediumTurquoise;
            btnExcluir.Location = new Point(266, 368);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 31);
            btnExcluir.TabIndex = 42;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.MediumTurquoise;
            btnAlterar.Location = new Point(104, 368);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 31);
            btnAlterar.TabIndex = 41;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(192, 173);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(149, 27);
            txtID.TabIndex = 11;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(192, 305);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(300, 27);
            txtTel.TabIndex = 10;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(192, 272);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(300, 27);
            txtEnd.TabIndex = 9;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(192, 239);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(300, 27);
            txtCNPJ.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(192, 206);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(300, 27);
            txtNome.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 311);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 6;
            label6.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 278);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 5;
            label5.Text = "Endereço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 245);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 4;
            label4.Text = "CNPJ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 212);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 3;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 179);
            label2.Name = "label2";
            label2.Size = new Size(31, 21);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 100);
            label1.Name = "label1";
            label1.Size = new Size(354, 32);
            label1.TabIndex = 1;
            label1.Text = "Alterar ou Excluir Empresa";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(txtPesqNome);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 503);
            panel2.TabIndex = 9;
            // 
            // txtPesqNome
            // 
            txtPesqNome.Cursor = Cursors.IBeam;
            txtPesqNome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesqNome.Location = new Point(150, 444);
            txtPesqNome.Name = "txtPesqNome";
            txtPesqNome.Size = new Size(356, 27);
            txtPesqNome.TabIndex = 44;
            txtPesqNome.TextChanged += txtPesqNome_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(240, 422);
            label18.Name = "label18";
            label18.Size = new Size(162, 19);
            label18.TabIndex = 43;
            label18.Text = "Pesquisa por Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 397);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, NOME, cnpj, ENDERECO, TEL });
            dataGridView1.Location = new Point(3, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(516, 383);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id1";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // NOME
            // 
            NOME.DataPropertyName = "Nome";
            NOME.HeaderText = "Nome";
            NOME.Name = "NOME";
            NOME.ReadOnly = true;
            // 
            // cnpj
            // 
            cnpj.DataPropertyName = "CNPJ";
            cnpj.HeaderText = "CNPJ";
            cnpj.Name = "cnpj";
            cnpj.ReadOnly = true;
            // 
            // ENDERECO
            // 
            ENDERECO.DataPropertyName = "Endereco";
            ENDERECO.HeaderText = "Endereço";
            ENDERECO.Name = "ENDERECO";
            ENDERECO.ReadOnly = true;
            // 
            // TEL
            // 
            TEL.DataPropertyName = "Tel";
            TEL.HeaderText = "Telefone";
            TEL.Name = "TEL";
            TEL.ReadOnly = true;
            // 
            // frmConEmpresa
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1137, 525);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmConEmpresa";
            Text = "Consulta de Empresas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtID;
        private TextBox txtTel;
        private TextBox txtEnd;
        private TextBox txtCNPJ;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAlterar;
        private DataGridView dataGridView1;
        private TextBox txtPesqNome;
        private Label label18;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn cnpj;
        private DataGridViewTextBoxColumn ENDERECO;
        private DataGridViewTextBoxColumn TEL;
    }
}