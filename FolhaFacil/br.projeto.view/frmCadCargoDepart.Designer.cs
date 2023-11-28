namespace FolhaFacil.br.projeto.view
{
    partial class frmCadCargoDepart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCargoDepart));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLogado = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnCadCargo = new Button();
            label4 = new Label();
            txtDescCargo = new TextBox();
            txtIDCargo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnCadDep = new Button();
            label3 = new Label();
            txtDescDep = new TextBox();
            txtIDDep = new TextBox();
            label5 = new Label();
            label6 = new Label();
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
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1017, 29);
            menuStrip1.TabIndex = 8;
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
            panel1.Controls.Add(btnCadCargo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDescCargo);
            panel1.Controls.Add(txtIDCargo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 532);
            panel1.TabIndex = 10;
            // 
            // btnCadCargo
            // 
            btnCadCargo.BackColor = Color.MediumTurquoise;
            btnCadCargo.Location = new Point(183, 353);
            btnCadCargo.Name = "btnCadCargo";
            btnCadCargo.Size = new Size(116, 42);
            btnCadCargo.TabIndex = 15;
            btnCadCargo.Text = "Cadastrar";
            btnCadCargo.UseVisualStyleBackColor = false;
            btnCadCargo.Click += btnCadCargo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(133, 136);
            label4.Name = "label4";
            label4.Size = new Size(236, 32);
            label4.TabIndex = 14;
            label4.Text = "Cadastrar Cargo";
            // 
            // txtDescCargo
            // 
            txtDescCargo.Location = new Point(183, 266);
            txtDescCargo.Name = "txtDescCargo";
            txtDescCargo.Size = new Size(224, 27);
            txtDescCargo.TabIndex = 12;
            // 
            // txtIDCargo
            // 
            txtIDCargo.Location = new Point(183, 225);
            txtIDCargo.Name = "txtIDCargo";
            txtIDCargo.ReadOnly = true;
            txtIDCargo.Size = new Size(100, 27);
            txtIDCargo.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 272);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 9;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 231);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 8;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnCadDep);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtDescDep);
            panel2.Controls.Add(txtIDDep);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(511, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 532);
            panel2.TabIndex = 11;
            // 
            // btnCadDep
            // 
            btnCadDep.BackColor = Color.MediumTurquoise;
            btnCadDep.Location = new Point(183, 354);
            btnCadDep.Name = "btnCadDep";
            btnCadDep.Size = new Size(116, 42);
            btnCadDep.TabIndex = 21;
            btnCadDep.Text = "Cadastrar";
            btnCadDep.UseVisualStyleBackColor = false;
            btnCadDep.Click += btnCadDep_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 136);
            label3.Name = "label3";
            label3.Size = new Size(343, 32);
            label3.TabIndex = 20;
            label3.Text = "Cadastrar Departamento";
            // 
            // txtDescDep
            // 
            txtDescDep.Location = new Point(183, 267);
            txtDescDep.Name = "txtDescDep";
            txtDescDep.Size = new Size(224, 27);
            txtDescDep.TabIndex = 19;
            // 
            // txtIDDep
            // 
            txtIDDep.Location = new Point(183, 226);
            txtIDDep.Name = "txtIDDep";
            txtIDDep.ReadOnly = true;
            txtIDDep.Size = new Size(100, 27);
            txtIDDep.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 273);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 17;
            label5.Text = "Descrição:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 232);
            label6.Name = "label6";
            label6.Size = new Size(31, 21);
            label6.TabIndex = 16;
            label6.Text = "ID:";
            // 
            // frmCadCargoDepart
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
            Margin = new Padding(4);
            Name = "frmCadCargoDepart";
            Text = "frmCadCargoDepart";
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
        private Button btnCadCargo;
        private Label label4;
        private TextBox txtDescCargo;
        private TextBox txtIDCargo;
        private Label label2;
        private Label label1;
        private Button btnCadDep;
        private Label label3;
        private TextBox txtDescDep;
        private TextBox txtIDDep;
        private Label label5;
        private Label label6;
    }
}