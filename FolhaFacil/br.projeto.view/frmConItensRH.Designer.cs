﻿namespace FolhaFacil.br.projeto.view
{
    partial class frmConItensRH
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
            panel1 = new Panel();
            txtPesqAcresc = new TextBox();
            label18 = new Label();
            dataGridView1 = new DataGridView();
            idAcresc = new DataGridViewTextBoxColumn();
            DESCAcresc = new DataGridViewTextBoxColumn();
            VALORAcresc = new DataGridViewTextBoxColumn();
            txtValorAcresc = new TextBox();
            txtDescAcresc = new TextBox();
            txtIDAcres = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            btnLimparAcresc = new Button();
            btnExcluirAcresc = new Button();
            btnAlterarAcres = new Button();
            panel2 = new Panel();
            txtPesqDesc = new TextBox();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            IDDesc = new DataGridViewTextBoxColumn();
            DESCDesc = new DataGridViewTextBoxColumn();
            VALORDesc = new DataGridViewTextBoxColumn();
            label8 = new Label();
            txtValorDesc = new TextBox();
            label7 = new Label();
            txtDescDesc = new TextBox();
            label6 = new Label();
            txtIDDesc = new TextBox();
            label2 = new Label();
            btnLimparDesc = new Button();
            btnExcluirDesc = new Button();
            btnAlterarDesc = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(txtPesqAcresc);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtValorAcresc);
            panel1.Controls.Add(txtDescAcresc);
            panel1.Controls.Add(txtIDAcres);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLimparAcresc);
            panel1.Controls.Add(btnExcluirAcresc);
            panel1.Controls.Add(btnAlterarAcres);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 516);
            panel1.TabIndex = 8;
            // 
            // txtPesqAcresc
            // 
            txtPesqAcresc.Cursor = Cursors.IBeam;
            txtPesqAcresc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesqAcresc.Location = new Point(89, 51);
            txtPesqAcresc.Name = "txtPesqAcresc";
            txtPesqAcresc.Size = new Size(356, 27);
            txtPesqAcresc.TabIndex = 53;
            txtPesqAcresc.TextChanged += txtPesqAcresc_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(168, 29);
            label18.Name = "label18";
            label18.Size = new Size(197, 19);
            label18.TabIndex = 52;
            label18.Text = "Pesquisa por Acréscimo:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idAcresc, DESCAcresc, VALORAcresc });
            dataGridView1.Location = new Point(97, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(344, 168);
            dataGridView1.TabIndex = 51;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idAcresc
            // 
            idAcresc.DataPropertyName = "Id1";
            idAcresc.HeaderText = "ID";
            idAcresc.Name = "idAcresc";
            idAcresc.ReadOnly = true;
            // 
            // DESCAcresc
            // 
            DESCAcresc.DataPropertyName = "Descricao";
            DESCAcresc.HeaderText = "Descrição";
            DESCAcresc.Name = "DESCAcresc";
            DESCAcresc.ReadOnly = true;
            // 
            // VALORAcresc
            // 
            VALORAcresc.DataPropertyName = "Valor";
            VALORAcresc.HeaderText = "Valor";
            VALORAcresc.Name = "VALORAcresc";
            VALORAcresc.ReadOnly = true;
            // 
            // txtValorAcresc
            // 
            txtValorAcresc.Location = new Point(201, 426);
            txtValorAcresc.Name = "txtValorAcresc";
            txtValorAcresc.Size = new Size(100, 27);
            txtValorAcresc.TabIndex = 50;
            // 
            // txtDescAcresc
            // 
            txtDescAcresc.Location = new Point(201, 383);
            txtDescAcresc.Name = "txtDescAcresc";
            txtDescAcresc.Size = new Size(224, 27);
            txtDescAcresc.TabIndex = 49;
            // 
            // txtIDAcres
            // 
            txtIDAcres.Location = new Point(201, 342);
            txtIDAcres.Name = "txtIDAcres";
            txtIDAcres.ReadOnly = true;
            txtIDAcres.Size = new Size(100, 27);
            txtIDAcres.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 432);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 47;
            label3.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 389);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 46;
            label4.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 348);
            label5.Name = "label5";
            label5.Size = new Size(31, 21);
            label5.TabIndex = 45;
            label5.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 288);
            label1.Name = "label1";
            label1.Size = new Size(393, 32);
            label1.TabIndex = 44;
            label1.Text = "Alterar ou Excluir Acréscimos";
            // 
            // btnLimparAcresc
            // 
            btnLimparAcresc.BackColor = Color.MediumTurquoise;
            btnLimparAcresc.Location = new Point(385, 482);
            btnLimparAcresc.Name = "btnLimparAcresc";
            btnLimparAcresc.Size = new Size(75, 31);
            btnLimparAcresc.TabIndex = 43;
            btnLimparAcresc.Text = "Limpar";
            btnLimparAcresc.UseVisualStyleBackColor = false;
            btnLimparAcresc.Click += btnLimparAcresc_Click;
            // 
            // btnExcluirAcresc
            // 
            btnExcluirAcresc.BackColor = Color.MediumTurquoise;
            btnExcluirAcresc.Location = new Point(240, 482);
            btnExcluirAcresc.Name = "btnExcluirAcresc";
            btnExcluirAcresc.Size = new Size(75, 31);
            btnExcluirAcresc.TabIndex = 42;
            btnExcluirAcresc.Text = "Excluir";
            btnExcluirAcresc.UseVisualStyleBackColor = false;
            btnExcluirAcresc.Click += btnExcluirAcresc_Click;
            // 
            // btnAlterarAcres
            // 
            btnAlterarAcres.BackColor = Color.MediumTurquoise;
            btnAlterarAcres.Location = new Point(78, 482);
            btnAlterarAcres.Name = "btnAlterarAcres";
            btnAlterarAcres.Size = new Size(75, 31);
            btnAlterarAcres.TabIndex = 41;
            btnAlterarAcres.Text = "Alterar";
            btnAlterarAcres.UseVisualStyleBackColor = false;
            btnAlterarAcres.Click += btnAlterarAcres_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(txtPesqDesc);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtValorDesc);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDescDesc);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtIDDesc);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnLimparDesc);
            panel2.Controls.Add(btnExcluirDesc);
            panel2.Controls.Add(btnAlterarDesc);
            panel2.Location = new Point(570, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 516);
            panel2.TabIndex = 9;
            // 
            // txtPesqDesc
            // 
            txtPesqDesc.Cursor = Cursors.IBeam;
            txtPesqDesc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesqDesc.Location = new Point(91, 51);
            txtPesqDesc.Name = "txtPesqDesc";
            txtPesqDesc.Size = new Size(356, 27);
            txtPesqDesc.TabIndex = 55;
            txtPesqDesc.TextChanged += txtPesqDesc_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(170, 29);
            label9.Name = "label9";
            label9.Size = new Size(185, 19);
            label9.TabIndex = 54;
            label9.Text = "Pesquisa por Desconto:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IDDesc, DESCDesc, VALORDesc });
            dataGridView2.Location = new Point(97, 99);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(344, 168);
            dataGridView2.TabIndex = 53;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // IDDesc
            // 
            IDDesc.DataPropertyName = "Id1";
            IDDesc.HeaderText = "ID";
            IDDesc.Name = "IDDesc";
            IDDesc.ReadOnly = true;
            // 
            // DESCDesc
            // 
            DESCDesc.DataPropertyName = "Descricao";
            DESCDesc.HeaderText = "Descrição";
            DESCDesc.Name = "DESCDesc";
            DESCDesc.ReadOnly = true;
            // 
            // VALORDesc
            // 
            VALORDesc.DataPropertyName = "Valor";
            VALORDesc.HeaderText = "Valor";
            VALORDesc.Name = "VALORDesc";
            VALORDesc.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(170, 348);
            label8.Name = "label8";
            label8.Size = new Size(31, 21);
            label8.TabIndex = 47;
            label8.Text = "ID:";
            // 
            // txtValorDesc
            // 
            txtValorDesc.Location = new Point(207, 426);
            txtValorDesc.Name = "txtValorDesc";
            txtValorDesc.Size = new Size(100, 27);
            txtValorDesc.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 389);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 48;
            label7.Text = "Descrição:";
            // 
            // txtDescDesc
            // 
            txtDescDesc.Location = new Point(207, 383);
            txtDescDesc.Name = "txtDescDesc";
            txtDescDesc.Size = new Size(224, 27);
            txtDescDesc.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 432);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 49;
            label6.Text = "Valor:";
            // 
            // txtIDDesc
            // 
            txtIDDesc.Location = new Point(207, 342);
            txtIDDesc.Name = "txtIDDesc";
            txtIDDesc.ReadOnly = true;
            txtIDDesc.Size = new Size(100, 27);
            txtIDDesc.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 288);
            label2.Name = "label2";
            label2.Size = new Size(376, 32);
            label2.TabIndex = 45;
            label2.Text = "Alterar ou Excluir Descontos";
            // 
            // btnLimparDesc
            // 
            btnLimparDesc.BackColor = Color.MediumTurquoise;
            btnLimparDesc.Location = new Point(385, 482);
            btnLimparDesc.Name = "btnLimparDesc";
            btnLimparDesc.Size = new Size(75, 31);
            btnLimparDesc.TabIndex = 46;
            btnLimparDesc.Text = "Limpar";
            btnLimparDesc.UseVisualStyleBackColor = false;
            btnLimparDesc.Click += btnLimparDesc_Click;
            // 
            // btnExcluirDesc
            // 
            btnExcluirDesc.BackColor = Color.MediumTurquoise;
            btnExcluirDesc.Location = new Point(240, 482);
            btnExcluirDesc.Name = "btnExcluirDesc";
            btnExcluirDesc.Size = new Size(75, 31);
            btnExcluirDesc.TabIndex = 45;
            btnExcluirDesc.Text = "Excluir";
            btnExcluirDesc.UseVisualStyleBackColor = false;
            btnExcluirDesc.Click += btnExcluirDesc_Click;
            // 
            // btnAlterarDesc
            // 
            btnAlterarDesc.BackColor = Color.MediumTurquoise;
            btnAlterarDesc.Location = new Point(78, 482);
            btnAlterarDesc.Name = "btnAlterarDesc";
            btnAlterarDesc.Size = new Size(75, 31);
            btnAlterarDesc.TabIndex = 44;
            btnAlterarDesc.Text = "Alterar";
            btnAlterarDesc.UseVisualStyleBackColor = false;
            btnAlterarDesc.Click += btnAlterarDesc_Click;
            // 
            // frmConItensRH
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1137, 535);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmConItensRH";
            Text = "Consulta Itens RH";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button btnLimparAcresc;
        private Button btnExcluirAcresc;
        private Button btnAlterarAcres;
        private Button btnLimparDesc;
        private Button btnExcluirDesc;
        private Button btnAlterarDesc;
        private Label label1;
        private Label label2;
        private TextBox txtDescAcresc;
        private TextBox txtIDAcres;
        private Label label4;
        private Label label5;
        private Label label8;
        private TextBox txtValorDesc;
        private Label label7;
        private TextBox txtDescDesc;
        private Label label6;
        private TextBox txtIDDesc;
        private DataGridView dataGridView1;
        private TextBox txtPesqAcresc;
        private Label label18;
        private TextBox txtPesqDesc;
        private Label label9;
        private DataGridView dataGridView2;
        private TextBox txtValorAcresc;
        private Label label3;
        private DataGridViewTextBoxColumn idAcresc;
        private DataGridViewTextBoxColumn DESCAcresc;
        private DataGridViewTextBoxColumn VALORAcresc;
        private DataGridViewTextBoxColumn IDDesc;
        private DataGridViewTextBoxColumn DESCDesc;
        private DataGridViewTextBoxColumn VALORDesc;
    }
}