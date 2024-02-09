namespace airksucata
{
    partial class CustomMessageBox
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
            btnOK = new Button();
            lbAviso = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Dock = DockStyle.Bottom;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Century Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point);
            btnOK.ForeColor = Color.Gold;
            btnOK.Location = new Point(0, 234);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(659, 80);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK, ENTENDI";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lbAviso
            // 
            lbAviso.AutoSize = true;
            lbAviso.Font = new Font("Century Gothic", 34F, FontStyle.Regular, GraphicsUnit.Point);
            lbAviso.ForeColor = Color.White;
            lbAviso.Location = new Point(196, 87);
            lbAviso.Name = "lbAviso";
            lbAviso.Size = new Size(460, 112);
            lbAviso.TabIndex = 1;
            lbAviso.Text = "Você esqueceu do\r\npeso na balança...";
            lbAviso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 46F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(283, 14);
            label1.Name = "label1";
            label1.Size = new Size(286, 73);
            label1.TabIndex = 2;
            label1.Text = "Calma...";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 10);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbAviso);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(659, 216);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pensando;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 50, 0);
            ClientSize = new Size(659, 314);
            Controls.Add(btnOK);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Peso Invalido";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Label lbAviso;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}