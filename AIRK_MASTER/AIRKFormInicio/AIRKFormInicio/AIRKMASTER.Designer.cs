namespace AIRKFormInicio
{
    partial class AIRKMASTER
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIRKMASTER));
            splitContainer1 = new SplitContainer();
            label12 = new Label();
            label10 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lvClientes = new ListView();
            btnDados = new Button();
            btnGerarContrato = new Button();
            btnExcluirCliente = new Button();
            label11 = new Label();
            btnSalvar = new Button();
            btnCadastrar = new Button();
            panel1 = new Panel();
            txtWhats = new MaskedTextBox();
            label13 = new Label();
            txtCpfCnpj = new MaskedTextBox();
            txtRg = new MaskedTextBox();
            txtCep = new MaskedTextBox();
            comboUf = new ComboBox();
            label9 = new Label();
            txtCidade = new TextBox();
            label8 = new Label();
            txtBairro = new TextBox();
            label7 = new Label();
            comboPlanos = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtNumero = new TextBox();
            txtEndereco = new TextBox();
            label3 = new Label();
            txtNomeEmpresa = new TextBox();
            label4 = new Label();
            lbCpf = new Label();
            lbRg = new Label();
            txtNomeCliente = new TextBox();
            lbNomeCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(0, 35, 35);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(0, 10, 10);
            splitContainer1.Panel1.Controls.Add(label12);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(lvClientes);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(0, 35, 35);
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.bg011;
            splitContainer1.Panel2.Controls.Add(btnDados);
            splitContainer1.Panel2.Controls.Add(btnGerarContrato);
            splitContainer1.Panel2.Controls.Add(btnExcluirCliente);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(btnSalvar);
            splitContainer1.Panel2.Controls.Add(btnCadastrar);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1264, 681);
            splitContainer1.SplitterDistance = 573;
            splitContainer1.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.SpringGreen;
            label12.Location = new Point(302, 98);
            label12.Name = "label12";
            label12.Size = new Size(213, 32);
            label12.TabIndex = 5;
            label12.Text = "(11) 96351-2105";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(300, 51);
            label10.Name = "label10";
            label10.Size = new Size(216, 16);
            label10.TabIndex = 3;
            label10.Text = "PARA CONTROLE DE CLIENTES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(278, 26);
            label1.Name = "label1";
            label1.Size = new Size(260, 24);
            label1.TabIndex = 2;
            label1.Text = "SISTEMA DE CADASTRO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logowhite;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lvClientes
            // 
            lvClientes.BackColor = Color.FromArgb(0, 20, 20);
            lvClientes.BorderStyle = BorderStyle.None;
            lvClientes.Dock = DockStyle.Bottom;
            lvClientes.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lvClientes.ForeColor = Color.White;
            lvClientes.Location = new Point(0, 149);
            lvClientes.Name = "lvClientes";
            lvClientes.Size = new Size(573, 532);
            lvClientes.TabIndex = 0;
            lvClientes.UseCompatibleStateImageBehavior = false;
            lvClientes.View = View.List;
            lvClientes.SelectedIndexChanged += LvClientes_SelectedIndexChanged;
            // 
            // btnDados
            // 
            btnDados.BackColor = Color.DarkSlateBlue;
            btnDados.Cursor = Cursors.Hand;
            btnDados.FlatAppearance.BorderColor = Color.SlateBlue;
            btnDados.FlatAppearance.BorderSize = 2;
            btnDados.FlatStyle = FlatStyle.Flat;
            btnDados.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDados.ForeColor = Color.White;
            btnDados.Image = Properties.Resources.edit2;
            btnDados.ImageAlign = ContentAlignment.MiddleLeft;
            btnDados.Location = new Point(167, 626);
            btnDados.Name = "btnDados";
            btnDados.Padding = new Padding(0, 0, 5, 0);
            btnDados.Size = new Size(154, 45);
            btnDados.TabIndex = 26;
            btnDados.Text = "Ajustar Dados";
            btnDados.TextAlign = ContentAlignment.MiddleRight;
            btnDados.UseVisualStyleBackColor = false;
            btnDados.Click += btnDados_Click;
            // 
            // btnGerarContrato
            // 
            btnGerarContrato.BackColor = Color.CadetBlue;
            btnGerarContrato.Cursor = Cursors.Hand;
            btnGerarContrato.FlatAppearance.BorderColor = Color.Teal;
            btnGerarContrato.FlatAppearance.BorderSize = 2;
            btnGerarContrato.FlatStyle = FlatStyle.Flat;
            btnGerarContrato.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerarContrato.ForeColor = Color.White;
            btnGerarContrato.Image = Properties.Resources.edit2;
            btnGerarContrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerarContrato.Location = new Point(167, 570);
            btnGerarContrato.Name = "btnGerarContrato";
            btnGerarContrato.Padding = new Padding(0, 0, 5, 0);
            btnGerarContrato.Size = new Size(154, 45);
            btnGerarContrato.TabIndex = 25;
            btnGerarContrato.Text = "Gerar Contrato";
            btnGerarContrato.TextAlign = ContentAlignment.MiddleRight;
            btnGerarContrato.UseVisualStyleBackColor = false;
            btnGerarContrato.Click += btnGerarContrato_Click;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.BackColor = Color.IndianRed;
            btnExcluirCliente.Cursor = Cursors.Hand;
            btnExcluirCliente.Enabled = false;
            btnExcluirCliente.FlatAppearance.BorderColor = Color.Brown;
            btnExcluirCliente.FlatAppearance.BorderSize = 2;
            btnExcluirCliente.FlatStyle = FlatStyle.Flat;
            btnExcluirCliente.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluirCliente.ForeColor = Color.White;
            btnExcluirCliente.Image = Properties.Resources.delete1;
            btnExcluirCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirCliente.Location = new Point(7, 626);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Padding = new Padding(0, 0, 2, 0);
            btnExcluirCliente.Size = new Size(154, 45);
            btnExcluirCliente.TabIndex = 22;
            btnExcluirCliente.Text = "Excluir Cadastro";
            btnExcluirCliente.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirCliente.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Beauty Wind", 16.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 120, 100);
            label11.Location = new Point(441, 645);
            label11.Name = "label11";
            label11.Size = new Size(237, 26);
            label11.TabIndex = 4;
            label11.Text = "Development by Rick Costa";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.SeaGreen;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Enabled = false;
            btnSalvar.FlatAppearance.BorderColor = Color.LightGreen;
            btnSalvar.FlatAppearance.BorderSize = 2;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Image = Properties.Resources.edit2;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(7, 570);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(0, 0, 5, 0);
            btnSalvar.Size = new Size(154, 45);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar Alteração";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(0, 50, 30);
            btnCadastrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderColor = Color.SpringGreen;
            btnCadastrar.FlatAppearance.BorderSize = 2;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Image = Properties.Resources.newuser2;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(525, 570);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Padding = new Padding(0, 0, 5, 0);
            btnCadastrar.Size = new Size(154, 45);
            btnCadastrar.TabIndex = 24;
            btnCadastrar.Text = "Cadastrar Novo";
            btnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 40, 40);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(txtWhats);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtCpfCnpj);
            panel1.Controls.Add(txtRg);
            panel1.Controls.Add(txtCep);
            panel1.Controls.Add(comboUf);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtCidade);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtBairro);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboPlanos);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(txtEndereco);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNomeEmpresa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbCpf);
            panel1.Controls.Add(lbRg);
            panel1.Controls.Add(txtNomeCliente);
            panel1.Controls.Add(lbNomeCliente);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 560);
            panel1.TabIndex = 1;
            // 
            // txtWhats
            // 
            txtWhats.BackColor = Color.FromArgb(0, 20, 20);
            txtWhats.BorderStyle = BorderStyle.FixedSingle;
            txtWhats.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtWhats.ForeColor = Color.White;
            txtWhats.Location = new Point(12, 159);
            txtWhats.Mask = "(00) 00000-0000";
            txtWhats.Name = "txtWhats";
            txtWhats.Size = new Size(100, 23);
            txtWhats.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.SpringGreen;
            label13.Location = new Point(11, 141);
            label13.Name = "label13";
            label13.Size = new Size(66, 15);
            label13.TabIndex = 22;
            label13.Text = "WhatsApp:";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.BackColor = Color.FromArgb(0, 20, 20);
            txtCpfCnpj.BorderStyle = BorderStyle.FixedSingle;
            txtCpfCnpj.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCnpj.ForeColor = Color.White;
            txtCpfCnpj.Location = new Point(469, 29);
            txtCpfCnpj.Mask = "000.000.000-00";
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(205, 23);
            txtCpfCnpj.TabIndex = 5;
            // 
            // txtRg
            // 
            txtRg.BackColor = Color.FromArgb(0, 20, 20);
            txtRg.BorderStyle = BorderStyle.FixedSingle;
            txtRg.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRg.ForeColor = Color.White;
            txtRg.Location = new Point(309, 29);
            txtRg.Mask = "00.000.000-0";
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(154, 23);
            txtRg.TabIndex = 3;
            // 
            // txtCep
            // 
            txtCep.BackColor = Color.FromArgb(0, 20, 20);
            txtCep.BorderStyle = BorderStyle.FixedSingle;
            txtCep.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCep.ForeColor = Color.White;
            txtCep.Location = new Point(11, 115);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(101, 23);
            txtCep.TabIndex = 13;
            // 
            // comboUf
            // 
            comboUf.BackColor = Color.FromArgb(0, 20, 20);
            comboUf.FlatStyle = FlatStyle.Flat;
            comboUf.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboUf.ForeColor = Color.White;
            comboUf.FormattingEnabled = true;
            comboUf.Location = new Point(497, 113);
            comboUf.Name = "comboUf";
            comboUf.Size = new Size(41, 24);
            comboUf.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.SpringGreen;
            label9.Location = new Point(497, 95);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 18;
            label9.Text = "UF:";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.FromArgb(0, 20, 20);
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.ForeColor = Color.White;
            txtCidade.Location = new Point(295, 114);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(196, 23);
            txtCidade.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.SpringGreen;
            label8.Location = new Point(295, 95);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 16;
            label8.Text = "Cidade:";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.FromArgb(0, 20, 20);
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.ForeColor = Color.White;
            txtBairro.Location = new Point(118, 114);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(171, 23);
            txtBairro.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.SpringGreen;
            label7.Location = new Point(118, 95);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 14;
            label7.Text = "Bairro:";
            // 
            // comboPlanos
            // 
            comboPlanos.BackColor = Color.FromArgb(0, 20, 20);
            comboPlanos.FlatStyle = FlatStyle.Flat;
            comboPlanos.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboPlanos.ForeColor = Color.White;
            comboPlanos.FormattingEnabled = true;
            comboPlanos.Location = new Point(544, 113);
            comboPlanos.Name = "comboPlanos";
            comboPlanos.Size = new Size(130, 24);
            comboPlanos.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.SpringGreen;
            label5.Location = new Point(544, 95);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 20;
            label5.Text = "Tipo de Plano:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.SpringGreen;
            label6.Location = new Point(11, 95);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 12;
            label6.Text = "CEP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(616, 53);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 10;
            label2.Text = "Nº:";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(0, 20, 20);
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.ForeColor = Color.White;
            txtNumero.Location = new Point(616, 71);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(58, 23);
            txtNumero.TabIndex = 11;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.FromArgb(0, 20, 20);
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.ForeColor = Color.White;
            txtEndereco.Location = new Point(309, 71);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(301, 23);
            txtEndereco.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.SpringGreen;
            label3.Location = new Point(309, 53);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 8;
            label3.Text = "Endereço Completo:";
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.BackColor = Color.FromArgb(0, 20, 20);
            txtNomeEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtNomeEmpresa.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeEmpresa.ForeColor = Color.White;
            txtNomeEmpresa.Location = new Point(11, 71);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(292, 23);
            txtNomeEmpresa.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.SpringGreen;
            label4.Location = new Point(11, 53);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 6;
            label4.Text = "Nome da Empresa:";
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.ForeColor = Color.SpringGreen;
            lbCpf.Location = new Point(469, 11);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(66, 15);
            lbCpf.TabIndex = 4;
            lbCpf.Text = "CPF/CNPJ";
            // 
            // lbRg
            // 
            lbRg.AutoSize = true;
            lbRg.ForeColor = Color.SpringGreen;
            lbRg.Location = new Point(309, 11);
            lbRg.Name = "lbRg";
            lbRg.Size = new Size(76, 15);
            lbRg.TabIndex = 2;
            lbRg.Text = "Número RG:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = Color.FromArgb(0, 20, 20);
            txtNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCliente.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.ForeColor = Color.White;
            txtNomeCliente.Location = new Point(11, 29);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(292, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // lbNomeCliente
            // 
            lbNomeCliente.AutoSize = true;
            lbNomeCliente.ForeColor = Color.SpringGreen;
            lbNomeCliente.Location = new Point(11, 11);
            lbNomeCliente.Name = "lbNomeCliente";
            lbNomeCliente.Size = new Size(101, 15);
            lbNomeCliente.TabIndex = 0;
            lbNomeCliente.Text = "Nome Completo:";
            // 
            // AIRKMASTER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(splitContainer1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AIRKMASTER";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN AIRK DIGITAL";
            Load += AIRKMASTER_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView lvClientes;
        private Panel panel1;
        private TextBox txtNomeCliente;
        private Label lbNomeCliente;
        private Button btnSalvar;
        private Button btnCadastrar;
        private Label lbRg;
        private Label lbCpf;
        private TextBox txtEndereco;
        private Label label3;
        private TextBox txtNomeEmpresa;
        private Label label4;
        private Label label2;
        private TextBox txtNumero;
        private ComboBox comboPlanos;
        private Label label5;
        private Label label6;
        private TextBox txtCidade;
        private Label label8;
        private TextBox txtBairro;
        private Label label7;
        private ComboBox comboUf;
        private Label label9;
        private Button btnExcluirCliente;
        private Label label11;
        private Label label10;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label12;
        private MaskedTextBox txtCpfCnpj;
        private MaskedTextBox txtRg;
        private MaskedTextBox txtCep;
        private Label label13;
        private MaskedTextBox txtWhats;
        private Button btnGerarContrato;
        private Button btnDados;
    }
}