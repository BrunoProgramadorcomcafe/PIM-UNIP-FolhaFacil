namespace FolhaFacil.br.projeto.view
{
    partial class frmCadItensRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadItensRH));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLogado = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDAcres = new TextBox();
            txtDescAcresc = new TextBox();
            txtValorAcresc = new TextBox();
            label4 = new Label();
            btnCadAcresc = new Button();
            btnCadDesc = new Button();
            label5 = new Label();
            txtValorDesc = new TextBox();
            txtDescDesc = new TextBox();
            txtIDDesc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLightLight;
            statusStrip1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblLogado });
            statusStrip1.Location = new Point(0, 567);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1017, 22);
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
            menuStrip1.Size = new Size(1017, 29);
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
            panel1.Controls.Add(btnCadAcresc);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtValorAcresc);
            panel1.Controls.Add(txtDescAcresc);
            panel1.Controls.Add(txtIDAcres);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 532);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnCadDesc);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtValorDesc);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDescDesc);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtIDDesc);
            panel2.Location = new Point(511, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 532);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 214);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 255);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 298);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 2;
            label3.Text = "Valor:";
            // 
            // txtIDAcres
            // 
            txtIDAcres.Location = new Point(185, 208);
            txtIDAcres.Name = "txtIDAcres";
            txtIDAcres.ReadOnly = true;
            txtIDAcres.Size = new Size(100, 27);
            txtIDAcres.TabIndex = 3;
            // 
            // txtDescAcresc
            // 
            txtDescAcresc.Location = new Point(185, 249);
            txtDescAcresc.Name = "txtDescAcresc";
            txtDescAcresc.Size = new Size(224, 27);
            txtDescAcresc.TabIndex = 4;
            // 
            // txtValorAcresc
            // 
            txtValorAcresc.Location = new Point(185, 292);
            txtValorAcresc.Name = "txtValorAcresc";
            txtValorAcresc.Size = new Size(100, 27);
            txtValorAcresc.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(102, 143);
            label4.Name = "label4";
            label4.Size = new Size(305, 32);
            label4.TabIndex = 6;
            label4.Text = "Cadastrar Acréscimos";
            // 
            // btnCadAcresc
            // 
            btnCadAcresc.BackColor = Color.MediumTurquoise;
            btnCadAcresc.Location = new Point(185, 358);
            btnCadAcresc.Name = "btnCadAcresc";
            btnCadAcresc.Size = new Size(116, 42);
            btnCadAcresc.TabIndex = 7;
            btnCadAcresc.Text = "Cadastrar";
            btnCadAcresc.UseVisualStyleBackColor = false;
            // 
            // btnCadDesc
            // 
            btnCadDesc.BackColor = Color.MediumTurquoise;
            btnCadDesc.Location = new Point(177, 358);
            btnCadDesc.Name = "btnCadDesc";
            btnCadDesc.Size = new Size(116, 42);
            btnCadDesc.TabIndex = 15;
            btnCadDesc.Text = "Cadastrar";
            btnCadDesc.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(100, 143);
            label5.Name = "label5";
            label5.Size = new Size(288, 32);
            label5.TabIndex = 14;
            label5.Text = "Cadastrar Descontos";
            // 
            // txtValorDesc
            // 
            txtValorDesc.Location = new Point(177, 292);
            txtValorDesc.Name = "txtValorDesc";
            txtValorDesc.Size = new Size(100, 27);
            txtValorDesc.TabIndex = 13;
            // 
            // txtDescDesc
            // 
            txtDescDesc.Location = new Point(177, 249);
            txtDescDesc.Name = "txtDescDesc";
            txtDescDesc.Size = new Size(224, 27);
            txtDescDesc.TabIndex = 12;
            // 
            // txtIDDesc
            // 
            txtIDDesc.Location = new Point(177, 208);
            txtIDDesc.Name = "txtIDDesc";
            txtIDDesc.ReadOnly = true;
            txtIDDesc.Size = new Size(100, 27);
            txtIDDesc.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 298);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 10;
            label6.Text = "Valor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 255);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 9;
            label7.Text = "Descrição:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(140, 214);
            label8.Name = "label8";
            label8.Size = new Size(31, 21);
            label8.TabIndex = 8;
            label8.Text = "ID:";
            // 
            // frmCadItensRH
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1017, 589);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmCadItensRH";
            Text = "frmCadItensRH";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Button btnCadAcresc;
        private Label label4;
        private TextBox txtValorAcresc;
        private TextBox txtDescAcresc;
        private TextBox txtIDAcres;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCadDesc;
        private Label label5;
        private Label label8;
        private TextBox txtValorDesc;
        private Label label7;
        private TextBox txtDescDesc;
        private Label label6;
        private TextBox txtIDDesc;
    }
}