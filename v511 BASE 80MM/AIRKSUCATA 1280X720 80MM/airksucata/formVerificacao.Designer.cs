namespace airksucata
{
    partial class formVerificacao
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
            label1 = new Label();
            txtPassConfig = new TextBox();
            pictureBox1 = new PictureBox();
            btnPlastic = new Button();
            btnEletronic = new Button();
            btnWire = new Button();
            btnSilver = new Button();
            label2 = new Label();
            btnFechar = new Button();
            panel1 = new Panel();
            btnAlum = new Button();
            btnGlass = new Button();
            btnIron = new Button();
            btnCan = new Button();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 54);
            label1.Name = "label1";
            label1.Size = new Size(411, 46);
            label1.TabIndex = 0;
            label1.Text = "ACESSO RESTRITO!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassConfig
            // 
            txtPassConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassConfig.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassConfig.Location = new Point(557, 599);
            txtPassConfig.Name = "txtPassConfig";
            txtPassConfig.PlaceholderText = "SENHA DE ACESSO";
            txtPassConfig.Size = new Size(561, 60);
            txtPassConfig.TabIndex = 1;
            txtPassConfig.TextAlign = HorizontalAlignment.Center;
            txtPassConfig.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.alert;
            pictureBox1.Location = new Point(7, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnPlastic
            // 
            btnPlastic.Cursor = Cursors.Hand;
            btnPlastic.FlatAppearance.CheckedBackColor = Color.Red;
            btnPlastic.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPlastic.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlastic.FlatStyle = FlatStyle.Flat;
            btnPlastic.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlastic.ForeColor = Color.Gold;
            btnPlastic.Image = Properties.Resources.plastico1;
            btnPlastic.ImageAlign = ContentAlignment.TopCenter;
            btnPlastic.Location = new Point(8, 6);
            btnPlastic.Name = "btnPlastic";
            btnPlastic.Padding = new Padding(10, 0, 0, 0);
            btnPlastic.Size = new Size(268, 95);
            btnPlastic.TabIndex = 3;
            btnPlastic.Text = "Plástico";
            btnPlastic.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPlastic.UseVisualStyleBackColor = true;
            btnPlastic.Click += btnPlastic_Click;
            // 
            // btnEletronic
            // 
            btnEletronic.Cursor = Cursors.Hand;
            btnEletronic.FlatAppearance.CheckedBackColor = Color.Red;
            btnEletronic.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEletronic.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEletronic.FlatStyle = FlatStyle.Flat;
            btnEletronic.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEletronic.ForeColor = Color.Gold;
            btnEletronic.Image = Properties.Resources.eletronicos2;
            btnEletronic.ImageAlign = ContentAlignment.TopCenter;
            btnEletronic.Location = new Point(278, 6);
            btnEletronic.Name = "btnEletronic";
            btnEletronic.Size = new Size(268, 95);
            btnEletronic.TabIndex = 5;
            btnEletronic.Text = "Eletrônico";
            btnEletronic.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEletronic.UseVisualStyleBackColor = true;
            btnEletronic.Click += btnEletronic_Click;
            // 
            // btnWire
            // 
            btnWire.Cursor = Cursors.Hand;
            btnWire.FlatAppearance.CheckedBackColor = Color.Red;
            btnWire.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnWire.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnWire.FlatStyle = FlatStyle.Flat;
            btnWire.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnWire.ForeColor = Color.Gold;
            btnWire.Image = Properties.Resources.fios2;
            btnWire.ImageAlign = ContentAlignment.TopCenter;
            btnWire.Location = new Point(278, 103);
            btnWire.Name = "btnWire";
            btnWire.Padding = new Padding(0, 0, 10, 0);
            btnWire.Size = new Size(268, 95);
            btnWire.TabIndex = 9;
            btnWire.Text = "Fios";
            btnWire.TextImageRelation = TextImageRelation.ImageAboveText;
            btnWire.UseVisualStyleBackColor = true;
            btnWire.Click += btnWire_Click;
            // 
            // btnSilver
            // 
            btnSilver.Cursor = Cursors.Hand;
            btnSilver.FlatAppearance.CheckedBackColor = Color.Red;
            btnSilver.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSilver.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSilver.FlatStyle = FlatStyle.Flat;
            btnSilver.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSilver.ForeColor = Color.Gold;
            btnSilver.Image = Properties.Resources.prata2;
            btnSilver.ImageAlign = ContentAlignment.TopCenter;
            btnSilver.Location = new Point(8, 103);
            btnSilver.Name = "btnSilver";
            btnSilver.Padding = new Padding(10, 0, 0, 0);
            btnSilver.Size = new Size(268, 95);
            btnSilver.TabIndex = 7;
            btnSilver.Text = "Prata";
            btnSilver.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSilver.UseVisualStyleBackColor = true;
            btnSilver.Click += btnSilver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 29.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 14);
            label2.Name = "label2";
            label2.Size = new Size(328, 45);
            label2.TabIndex = 11;
            label2.Text = "Você está sendo";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(417, 2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(156, 42);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "[ X ] Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAlum);
            panel1.Controls.Add(btnGlass);
            panel1.Controls.Add(btnIron);
            panel1.Controls.Add(btnCan);
            panel1.Controls.Add(btnWire);
            panel1.Controls.Add(btnSilver);
            panel1.Controls.Add(btnPlastic);
            panel1.Controls.Add(btnEletronic);
            panel1.Location = new Point(7, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 401);
            panel1.TabIndex = 13;
            // 
            // btnAlum
            // 
            btnAlum.Cursor = Cursors.Hand;
            btnAlum.FlatAppearance.CheckedBackColor = Color.Red;
            btnAlum.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAlum.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAlum.FlatStyle = FlatStyle.Flat;
            btnAlum.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlum.ForeColor = Color.Gold;
            btnAlum.Image = Properties.Resources.aluminio2;
            btnAlum.ImageAlign = ContentAlignment.TopCenter;
            btnAlum.Location = new Point(278, 297);
            btnAlum.Name = "btnAlum";
            btnAlum.Padding = new Padding(0, 0, 10, 0);
            btnAlum.Size = new Size(268, 95);
            btnAlum.TabIndex = 17;
            btnAlum.Text = "Alumínio";
            btnAlum.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAlum.UseVisualStyleBackColor = true;
            btnAlum.Click += btnAlum_Click;
            // 
            // btnGlass
            // 
            btnGlass.Cursor = Cursors.Hand;
            btnGlass.FlatAppearance.CheckedBackColor = Color.Red;
            btnGlass.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGlass.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGlass.FlatStyle = FlatStyle.Flat;
            btnGlass.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnGlass.ForeColor = Color.Gold;
            btnGlass.Image = Properties.Resources.vidro1;
            btnGlass.ImageAlign = ContentAlignment.TopCenter;
            btnGlass.Location = new Point(8, 297);
            btnGlass.Name = "btnGlass";
            btnGlass.Padding = new Padding(0, 0, 10, 0);
            btnGlass.Size = new Size(268, 95);
            btnGlass.TabIndex = 15;
            btnGlass.Text = "Vidro";
            btnGlass.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGlass.UseVisualStyleBackColor = true;
            btnGlass.Click += btnGlass_Click;
            // 
            // btnIron
            // 
            btnIron.Cursor = Cursors.Hand;
            btnIron.FlatAppearance.CheckedBackColor = Color.Red;
            btnIron.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIron.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIron.FlatStyle = FlatStyle.Flat;
            btnIron.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnIron.ForeColor = Color.Gold;
            btnIron.Image = Properties.Resources.ferro2;
            btnIron.ImageAlign = ContentAlignment.TopCenter;
            btnIron.Location = new Point(8, 200);
            btnIron.Name = "btnIron";
            btnIron.Size = new Size(268, 95);
            btnIron.TabIndex = 11;
            btnIron.Text = "Ferro";
            btnIron.TextImageRelation = TextImageRelation.ImageAboveText;
            btnIron.UseVisualStyleBackColor = true;
            btnIron.Click += btnIron_Click;
            // 
            // btnCan
            // 
            btnCan.Cursor = Cursors.Hand;
            btnCan.FlatAppearance.CheckedBackColor = Color.Red;
            btnCan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCan.FlatStyle = FlatStyle.Flat;
            btnCan.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnCan.ForeColor = Color.Gold;
            btnCan.Image = Properties.Resources.lata21;
            btnCan.ImageAlign = ContentAlignment.TopCenter;
            btnCan.Location = new Point(278, 200);
            btnCan.Name = "btnCan";
            btnCan.Padding = new Padding(0, 10, 0, 0);
            btnCan.Size = new Size(268, 95);
            btnCan.TabIndex = 13;
            btnCan.Text = "Latinha";
            btnCan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCan.UseVisualStyleBackColor = true;
            btnCan.Click += btnCan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 33.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(62, 60);
            label3.Name = "label3";
            label3.Size = new Size(332, 53);
            label3.TabIndex = 14;
            label3.Text = "MONITORADO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.vigilancia;
            pictureBox6.Location = new Point(412, 11);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(98, 110);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 526);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 149);
            panel2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Avignon Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(150, 150, 150);
            label5.Location = new Point(12, 126);
            label5.Name = "label5";
            label5.Size = new Size(324, 14);
            label5.TabIndex = 17;
            label5.Text = "Esqueceu a senha? - Chame no WhatsApp 11 96351-2105";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Avignon Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(150, 150, 150);
            label4.Location = new Point(428, 126);
            label4.Name = "label4";
            label4.Size = new Size(135, 14);
            label4.TabIndex = 16;
            label4.Text = "Powered by Rick Costa";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formVerificacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 0, 0);
            ClientSize = new Size(575, 675);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnFechar);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassConfig);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formVerificacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entre com a senha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassConfig;
        private PictureBox pictureBox1;
        private Button btnPlastic;
        private Button btnEletronic;
        private PictureBox pictureBox4;
        private Button btnWire;
        private Button btnSilver;
        private Label label2;
        private Button btnFechar;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox6;
        private Panel panel2;
        private Label label4;
        private Button btnAlum;
        private Button btnGlass;
        private Button btnIron;
        private Button btnCan;
        private Label label5;
    }
}