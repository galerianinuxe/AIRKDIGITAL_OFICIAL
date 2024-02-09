namespace AIRKFormInicio
{
    partial class AIRKAjusteDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIRKAjusteDados));
            label1 = new Label();
            btnImgPrincipal = new Button();
            picImgPrincipal = new PictureBox();
            btnSalvar = new Button();
            txtNomeEmpresa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtUltimoUpdate = new TextBox();
            label4 = new Label();
            txtVersion = new TextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnImgRelatorio = new Button();
            picImgComprovante = new PictureBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtLocal = new TextBox();
            label5 = new Label();
            txtContato = new TextBox();
            btnCopiarTudo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picImgPrincipal).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImgComprovante).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Logo Principal";
            // 
            // btnImgPrincipal
            // 
            btnImgPrincipal.BackColor = Color.FromArgb(0, 20, 20);
            btnImgPrincipal.FlatStyle = FlatStyle.Flat;
            btnImgPrincipal.ForeColor = Color.SpringGreen;
            btnImgPrincipal.Location = new Point(14, 204);
            btnImgPrincipal.Name = "btnImgPrincipal";
            btnImgPrincipal.Size = new Size(150, 29);
            btnImgPrincipal.TabIndex = 1;
            btnImgPrincipal.Text = "Selecionar imagem";
            btnImgPrincipal.UseVisualStyleBackColor = false;
            btnImgPrincipal.Click += btnImgPrincipal_Click;
            // 
            // picImgPrincipal
            // 
            picImgPrincipal.BackColor = Color.FromArgb(150, 150, 150);
            picImgPrincipal.Location = new Point(14, 48);
            picImgPrincipal.Name = "picImgPrincipal";
            picImgPrincipal.Size = new Size(150, 150);
            picImgPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            picImgPrincipal.TabIndex = 2;
            picImgPrincipal.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 60, 0);
            btnSalvar.FlatAppearance.BorderColor = Color.Lime;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(514, 334);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 47);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar Tudo";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.BackColor = Color.FromArgb(0, 20, 20);
            txtNomeEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtNomeEmpresa.ForeColor = Color.White;
            txtNomeEmpresa.Location = new Point(190, 48);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.PlaceholderText = "Digite o nome da empresa";
            txtNomeEmpresa.Size = new Size(274, 23);
            txtNomeEmpresa.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 30);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome da Empresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 74);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 7;
            label3.Text = "Última Atualização:";
            // 
            // txtUltimoUpdate
            // 
            txtUltimoUpdate.BackColor = Color.FromArgb(0, 20, 20);
            txtUltimoUpdate.BorderStyle = BorderStyle.FixedSingle;
            txtUltimoUpdate.ForeColor = Color.White;
            txtUltimoUpdate.Location = new Point(190, 92);
            txtUltimoUpdate.Name = "txtUltimoUpdate";
            txtUltimoUpdate.Size = new Size(274, 23);
            txtUltimoUpdate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 118);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 9;
            label4.Text = "Versão Atual:";
            // 
            // txtVersion
            // 
            txtVersion.BackColor = Color.FromArgb(0, 20, 20);
            txtVersion.BorderStyle = BorderStyle.FixedSingle;
            txtVersion.ForeColor = Color.White;
            txtVersion.Location = new Point(190, 136);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(274, 23);
            txtVersion.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnImgRelatorio);
            groupBox1.Controls.Add(picImgComprovante);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnImgPrincipal);
            groupBox1.Controls.Add(txtVersion);
            groupBox1.Controls.Add(picImgPrincipal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNomeEmpresa);
            groupBox1.Controls.Add(txtUltimoUpdate);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.SpringGreen;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 313);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "AJUSTES GERAIS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(518, 30);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 12;
            label7.Text = "Logo Relatórios";
            // 
            // btnImgRelatorio
            // 
            btnImgRelatorio.BackColor = Color.FromArgb(0, 20, 20);
            btnImgRelatorio.FlatStyle = FlatStyle.Flat;
            btnImgRelatorio.ForeColor = Color.SpringGreen;
            btnImgRelatorio.Location = new Point(489, 204);
            btnImgRelatorio.Name = "btnImgRelatorio";
            btnImgRelatorio.Size = new Size(150, 29);
            btnImgRelatorio.TabIndex = 13;
            btnImgRelatorio.Text = "Selecionar imagem";
            btnImgRelatorio.UseVisualStyleBackColor = false;
            btnImgRelatorio.Click += btnImgComprovante_Click;
            // 
            // picImgComprovante
            // 
            picImgComprovante.BackColor = Color.FromArgb(150, 150, 150);
            picImgComprovante.Location = new Point(489, 48);
            picImgComprovante.Name = "picImgComprovante";
            picImgComprovante.Size = new Size(150, 150);
            picImgComprovante.SizeMode = PictureBoxSizeMode.Zoom;
            picImgComprovante.TabIndex = 14;
            picImgComprovante.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtLocal);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtContato);
            groupBox2.ForeColor = Color.SpringGreen;
            groupBox2.Location = new Point(184, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 133);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "DADOS COMPROVANTE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 74);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 13;
            label6.Text = "Endereço:";
            // 
            // txtLocal
            // 
            txtLocal.BackColor = Color.FromArgb(0, 20, 20);
            txtLocal.BorderStyle = BorderStyle.FixedSingle;
            txtLocal.ForeColor = Color.White;
            txtLocal.Location = new Point(6, 92);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(274, 23);
            txtLocal.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 30);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 11;
            label5.Text = "Contato:";
            // 
            // txtContato
            // 
            txtContato.BackColor = Color.FromArgb(0, 20, 20);
            txtContato.BorderStyle = BorderStyle.FixedSingle;
            txtContato.ForeColor = Color.White;
            txtContato.Location = new Point(6, 48);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(274, 23);
            txtContato.TabIndex = 10;
            // 
            // btnCopiarTudo
            // 
            btnCopiarTudo.BackColor = Color.FromArgb(60, 60, 0);
            btnCopiarTudo.FlatAppearance.BorderColor = Color.Gold;
            btnCopiarTudo.FlatStyle = FlatStyle.Flat;
            btnCopiarTudo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCopiarTudo.ForeColor = Color.White;
            btnCopiarTudo.Location = new Point(358, 334);
            btnCopiarTudo.Name = "btnCopiarTudo";
            btnCopiarTudo.Size = new Size(150, 47);
            btnCopiarTudo.TabIndex = 11;
            btnCopiarTudo.Text = "Abrir Local";
            btnCopiarTudo.UseVisualStyleBackColor = false;
            btnCopiarTudo.Click += btnCopiarTudo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logowhite1;
            pictureBox1.Location = new Point(12, 334);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // AIRKAjusteDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 40, 40);
            ClientSize = new Size(678, 393);
            Controls.Add(pictureBox1);
            Controls.Add(btnCopiarTudo);
            Controls.Add(groupBox1);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AIRKAjusteDados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AIRKAjusteDados";
            Load += AIRKAjusteDados_Load;
            ((System.ComponentModel.ISupportInitialize)picImgPrincipal).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImgComprovante).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnImgPrincipal;
        private PictureBox picImgPrincipal;
        private Button btnSalvar;
        private TextBox txtNomeEmpresa;
        private Label label2;
        private Label label3;
        private TextBox txtUltimoUpdate;
        private Label label4;
        private TextBox txtVersion;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtLocal;
        private Label label5;
        private TextBox txtContato;
        private Label label7;
        private Button btnImgRelatorio;
        private PictureBox picImgComprovante;
        private Button btnCopiarTudo;
        private PictureBox pictureBox1;
    }
}