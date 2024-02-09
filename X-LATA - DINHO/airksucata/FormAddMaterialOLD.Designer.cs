namespace airksucata
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            cmbRegistros = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbRegistros
            // 
            cmbRegistros.FlatStyle = FlatStyle.Flat;
            cmbRegistros.Font = new Font("Century Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRegistros.FormattingEnabled = true;
            cmbRegistros.Items.AddRange(new object[] { "Ferro", "Cobre 1°", "Cobre 2°", "Cobre 3°", "Metal", "Inox", "Alumínio 1", "Alumínio 2", "Alumínio 3", "Alumínio 4", "Papelão", "Papel Branco", "Papel Colorido", "Papel Misto", "Latinha", "Fio Tipo 1", "Fio Tipo 2", "Fio Tipo 3", "Vidro Misto", "Vidro T 2", "Vidro T 3", "Eletrônico 1", "Eletrônico 2", "Eletrônico 3", "Eletrônico 4", "Plástico Misto", "Plástico T 2", "Plástico T 3", "Plástico PVC", "Plástico PS", "Bloco 1", "Bloco 2", "Material S/ Seleção" });
            cmbRegistros.Location = new Point(29, 216);
            cmbRegistros.Name = "cmbRegistros";
            cmbRegistros.Size = new Size(794, 57);
            cmbRegistros.TabIndex = 0;
            //cmbRegistros.SelectedIndexChanged += cmbRegistros_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 30, 30);
            label1.Font = new Font("Century Gothic", 27F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(29, 164);
            label1.Name = "label1";
            label1.Size = new Size(378, 43);
            label1.TabIndex = 1;
            label1.Text = "Selecione o Material";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 0);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 148);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 10);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 34F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 50);
            label2.Name = "label2";
            label2.Size = new Size(653, 55);
            label2.TabIndex = 3;
            label2.Text = "Adicionar Material no Painel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(698, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAddMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(850, 1200);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(cmbRegistros);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddMaterial";
            //Load += FormAddMaterial_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRegistros;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
    }
}