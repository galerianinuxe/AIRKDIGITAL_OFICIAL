namespace airksucata
{
    partial class AIRKTipoDeVenda
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
            btnPorPeso = new Button();
            btnPorUnid = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(481, 55);
            label1.TabIndex = 0;
            label1.Text = "Qual tipo de Venda?";
            // 
            // btnPorPeso
            // 
            btnPorPeso.FlatStyle = FlatStyle.Flat;
            btnPorPeso.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPorPeso.ForeColor = Color.White;
            btnPorPeso.Location = new Point(54, 250);
            btnPorPeso.Name = "btnPorPeso";
            btnPorPeso.Size = new Size(243, 123);
            btnPorPeso.TabIndex = 1;
            btnPorPeso.Text = "Por Peso KG";
            btnPorPeso.UseVisualStyleBackColor = true;
            btnPorPeso.Click += btnPorPeso_Click;
            // 
            // btnPorUnid
            // 
            btnPorUnid.FlatStyle = FlatStyle.Flat;
            btnPorUnid.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPorUnid.ForeColor = Color.White;
            btnPorUnid.Location = new Point(303, 250);
            btnPorUnid.Name = "btnPorUnid";
            btnPorUnid.Size = new Size(243, 123);
            btnPorUnid.TabIndex = 2;
            btnPorUnid.Text = "Por Unidade";
            btnPorUnid.UseVisualStyleBackColor = true;
            btnPorUnid.Click += btnPorUnid_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_balance_64;
            pictureBox1.Location = new Point(125, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.quantidade;
            pictureBox2.Location = new Point(374, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(54, 390);
            button1.Name = "button1";
            button1.Size = new Size(492, 94);
            button1.TabIndex = 5;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(170, 502);
            label2.Name = "label2";
            label2.Size = new Size(240, 16);
            label2.TabIndex = 6;
            label2.Text = "Atendimento ou Suporte: 11 96351-2105";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 534);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 3);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 534);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lime;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 3);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lime;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(597, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 531);
            panel4.TabIndex = 10;
            // 
            // AIRKTipoDeVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(600, 537);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnPorUnid);
            Controls.Add(btnPorPeso);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AIRKTipoDeVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venda por Quantidade ou Peso?";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPorPeso;
        private Button btnPorUnid;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}