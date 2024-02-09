namespace airksucata
{
    partial class confirmarDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmarDelete));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Yes;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(46, 258);
            button1.Name = "button1";
            button1.Size = new Size(376, 120);
            button1.TabIndex = 0;
            button1.Text = "Sim";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.No;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(46, 384);
            button2.Name = "button2";
            button2.Size = new Size(376, 120);
            button2.TabIndex = 1;
            button2.Text = "Não";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 144);
            label1.Name = "label1";
            label1.Size = new Size(381, 84);
            label1.TabIndex = 2;
            label1.Text = "Deseja remover o\r\nmaterial selecionado?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 15);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 533);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 12);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 30, 0);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(466, 110);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(224, 36);
            label3.Name = "label3";
            label3.Size = new Size(221, 36);
            label3.TabIndex = 7;
            label3.Text = "VAI PRO LIXO!";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(75, 36);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 6;
            label2.Text = "CUIDADO,";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lixeira;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // confirmarDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(466, 545);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "confirmarDelete";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar Delete";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}