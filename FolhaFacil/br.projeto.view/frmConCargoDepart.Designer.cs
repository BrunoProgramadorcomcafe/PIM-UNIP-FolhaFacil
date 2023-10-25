namespace FolhaFacil.br.projeto.view
{
    partial class frmConCargoDepart
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLogado = new ToolStripStatusLabel();
            panel1 = new Panel();
            txtPesqCargo = new TextBox();
            label18 = new Label();
            dataGridView1 = new DataGridView();
            IDCargo = new DataGridViewTextBoxColumn();
            DESCCargo = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txtPesqDepart = new TextBox();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            IDDepart = new DataGridViewTextBoxColumn();
            DESCDepart = new DataGridViewTextBoxColumn();
            txtDescDepart = new TextBox();
            label6 = new Label();
            txtIDDepart = new TextBox();
            button3 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            txtDescCargo = new TextBox();
            txtIDCargo = new TextBox();
            btnAlterarCargo = new Button();
            btnExcluirCargo = new Button();
            btnLimparCargo = new Button();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLightLight;
            statusStrip1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblLogado });
            statusStrip1.Location = new Point(0, 531);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1137, 22);
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnAlterarCargo);
            panel1.Controls.Add(txtDescCargo);
            panel1.Controls.Add(btnExcluirCargo);
            panel1.Controls.Add(btnLimparCargo);
            panel1.Controls.Add(txtIDCargo);
            panel1.Controls.Add(txtPesqCargo);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 516);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // txtPesqCargo
            // 
            txtPesqCargo.Cursor = Cursors.IBeam;
            txtPesqCargo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesqCargo.Location = new Point(102, 65);
            txtPesqCargo.Name = "txtPesqCargo";
            txtPesqCargo.Size = new Size(356, 27);
            txtPesqCargo.TabIndex = 61;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(192, 43);
            label18.Name = "label18";
            label18.Size = new Size(163, 19);
            label18.TabIndex = 60;
            label18.Text = "Pesquisa por Cargo:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDCargo, DESCCargo });
            dataGridView1.Location = new Point(155, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(243, 150);
            dataGridView1.TabIndex = 59;
            // 
            // IDCargo
            // 
            IDCargo.HeaderText = "ID";
            IDCargo.Name = "IDCargo";
            IDCargo.ReadOnly = true;
            // 
            // DESCCargo
            // 
            DESCCargo.HeaderText = "Descrição";
            DESCCargo.Name = "DESCCargo";
            DESCCargo.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 423);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 55;
            label4.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 382);
            label5.Name = "label5";
            label5.Size = new Size(31, 21);
            label5.TabIndex = 54;
            label5.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(117, 319);
            label1.Name = "label1";
            label1.Size = new Size(324, 32);
            label1.TabIndex = 45;
            label1.Text = "Alterar ou Excluir Cargo";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(txtPesqDepart);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(txtDescDepart);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtIDDepart);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(570, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 516);
            panel2.TabIndex = 9;
            // 
            // txtPesqDepart
            // 
            txtPesqDepart.Cursor = Cursors.IBeam;
            txtPesqDepart.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesqDepart.Location = new Point(99, 65);
            txtPesqDepart.Name = "txtPesqDepart";
            txtPesqDepart.Size = new Size(356, 27);
            txtPesqDepart.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(171, 43);
            label7.Name = "label7";
            label7.Size = new Size(227, 19);
            label7.TabIndex = 62;
            label7.Text = "Pesquisa por Departamento:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IDDepart, DESCDepart });
            dataGridView2.Location = new Point(162, 131);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(243, 150);
            dataGridView2.TabIndex = 60;
            // 
            // IDDepart
            // 
            IDDepart.HeaderText = "ID";
            IDDepart.Name = "IDDepart";
            IDDepart.ReadOnly = true;
            // 
            // DESCDepart
            // 
            DESCDepart.HeaderText = "Descrição";
            DESCDepart.Name = "DESCDepart";
            DESCDepart.ReadOnly = true;
            // 
            // txtDescDepart
            // 
            txtDescDepart.Location = new Point(210, 417);
            txtDescDepart.Name = "txtDescDepart";
            txtDescDepart.Size = new Size(224, 27);
            txtDescDepart.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(61, 319);
            label6.Name = "label6";
            label6.Size = new Size(431, 32);
            label6.TabIndex = 59;
            label6.Text = "Alterar ou Excluir Departamento";
            // 
            // txtIDDepart
            // 
            txtIDDepart.Location = new Point(210, 376);
            txtIDDepart.Name = "txtIDDepart";
            txtIDDepart.ReadOnly = true;
            txtIDDepart.Size = new Size(100, 27);
            txtIDDepart.TabIndex = 65;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Location = new Point(83, 466);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 60;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 423);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 64;
            label2.Text = "Descrição:";
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Location = new Point(245, 466);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 61;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 382);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 63;
            label3.Text = "ID:";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Location = new Point(390, 466);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 62;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtDescCargo
            // 
            txtDescCargo.Location = new Point(215, 417);
            txtDescCargo.Name = "txtDescCargo";
            txtDescCargo.Size = new Size(224, 27);
            txtDescCargo.TabIndex = 68;
            // 
            // txtIDCargo
            // 
            txtIDCargo.Location = new Point(215, 376);
            txtIDCargo.Name = "txtIDCargo";
            txtIDCargo.ReadOnly = true;
            txtIDCargo.Size = new Size(100, 27);
            txtIDCargo.TabIndex = 67;
            // 
            // btnAlterarCargo
            // 
            btnAlterarCargo.BackColor = Color.MediumTurquoise;
            btnAlterarCargo.Location = new Point(96, 466);
            btnAlterarCargo.Name = "btnAlterarCargo";
            btnAlterarCargo.Size = new Size(75, 31);
            btnAlterarCargo.TabIndex = 67;
            btnAlterarCargo.Text = "Alterar";
            btnAlterarCargo.UseVisualStyleBackColor = false;
            // 
            // btnExcluirCargo
            // 
            btnExcluirCargo.BackColor = Color.MediumTurquoise;
            btnExcluirCargo.Location = new Point(258, 466);
            btnExcluirCargo.Name = "btnExcluirCargo";
            btnExcluirCargo.Size = new Size(75, 31);
            btnExcluirCargo.TabIndex = 68;
            btnExcluirCargo.Text = "Excluir";
            btnExcluirCargo.UseVisualStyleBackColor = false;
            // 
            // btnLimparCargo
            // 
            btnLimparCargo.BackColor = Color.MediumTurquoise;
            btnLimparCargo.Location = new Point(403, 466);
            btnLimparCargo.Name = "btnLimparCargo";
            btnLimparCargo.Size = new Size(75, 31);
            btnLimparCargo.TabIndex = 69;
            btnLimparCargo.Text = "Limpar";
            btnLimparCargo.UseVisualStyleBackColor = false;
            // 
            // frmConCargoDepart
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1137, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmConCargoDepart";
            Text = "Consulta de Cargo e Departamento";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private TextBox txtValorAcresc;
        private TextBox txtDescAcresc;
        private TextBox txtIDAcres;
        private Label label4;
        private Label label5;
        private Button btnLimparAcresc;
        private Button btnExcluirAcresc;
        private TextBox txtDescDepart;
        private Label label6;
        private TextBox txtIDDepart;
        private Button button3;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDCargo;
        private DataGridViewTextBoxColumn DESCCargo;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IDDepart;
        private DataGridViewTextBoxColumn DESCDepart;
        private TextBox txtPesqCargo;
        private Label label18;
        private TextBox txtPesqDepart;
        private Label label7;
        private Button btnAlterarCargo;
        private TextBox txtDescCargo;
        private Button btnExcluirCargo;
        private Button btnLimparCargo;
        private TextBox txtIDCargo;
    }
}