namespace airksucata
{
    partial class formCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastro));
            btnCadastro = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtNovaSenha = new TextBox();
            txtNovoUser = new TextBox();
            pictureBox4 = new PictureBox();
            txtConfirmarSenha = new TextBox();
            btnTeste7d = new Button();
            btnTeste30d = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(30, 30, 30);
            btnCadastro.FlatAppearance.BorderColor = Color.Lime;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastro.ForeColor = Color.Lime;
            btnCadastro.Location = new Point(18, 351);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(445, 44);
            btnCadastro.TabIndex = 8;
            btnCadastro.TabStop = false;
            btnCadastro.Text = "ACESSO VITALÍCIO";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastrar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 163);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 204);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNovaSenha.Location = new Point(59, 205);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '•';
            txtNovaSenha.PlaceholderText = "NOVA SENHA";
            txtNovaSenha.Size = new Size(404, 34);
            txtNovaSenha.TabIndex = 6;
            txtNovaSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNovoUser
            // 
            txtNovoUser.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNovoUser.Location = new Point(59, 165);
            txtNovoUser.Name = "txtNovoUser";
            txtNovoUser.PlaceholderText = "NOVO USUÁRIO";
            txtNovoUser.Size = new Size(404, 34);
            txtNovoUser.TabIndex = 5;
            txtNovoUser.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 244);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarSenha.Location = new Point(59, 245);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '•';
            txtConfirmarSenha.PlaceholderText = "CONFIRMA SENHA";
            txtConfirmarSenha.Size = new Size(404, 34);
            txtConfirmarSenha.TabIndex = 11;
            txtConfirmarSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTeste7d
            // 
            btnTeste7d.BackColor = Color.FromArgb(30, 30, 30);
            btnTeste7d.FlatAppearance.BorderColor = Color.Gold;
            btnTeste7d.FlatStyle = FlatStyle.Flat;
            btnTeste7d.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeste7d.ForeColor = Color.Gold;
            btnTeste7d.Location = new Point(18, 298);
            btnTeste7d.Name = "btnTeste7d";
            btnTeste7d.Size = new Size(210, 44);
            btnTeste7d.TabIndex = 14;
            btnTeste7d.TabStop = false;
            btnTeste7d.Text = "ACESSO 7 DIAS";
            btnTeste7d.UseVisualStyleBackColor = false;
            btnTeste7d.Click += btnTeste_Click;
            // 
            // btnTeste30d
            // 
            btnTeste30d.BackColor = Color.FromArgb(30, 30, 30);
            btnTeste30d.FlatAppearance.BorderColor = Color.Gold;
            btnTeste30d.FlatStyle = FlatStyle.Flat;
            btnTeste30d.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeste30d.ForeColor = Color.Gold;
            btnTeste30d.Location = new Point(253, 298);
            btnTeste30d.Name = "btnTeste30d";
            btnTeste30d.Size = new Size(210, 44);
            btnTeste30d.TabIndex = 15;
            btnTeste30d.TabStop = false;
            btnTeste30d.Text = "ACESSO 30 DIAS";
            btnTeste30d.UseVisualStyleBackColor = false;
            btnTeste30d.Click += btnTeste30d_Click;
            // 
            // formCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(475, 418);
            Controls.Add(btnTeste30d);
            Controls.Add(btnTeste7d);
            Controls.Add(pictureBox4);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(btnCadastro);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtNovoUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Usuário";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtNovaSenha;
        private TextBox txtNovoUser;
        private PictureBox pictureBox4;
        private TextBox txtConfirmarSenha;
        private Button btnTeste7d;
        private Button btnTeste30d;
    }
}