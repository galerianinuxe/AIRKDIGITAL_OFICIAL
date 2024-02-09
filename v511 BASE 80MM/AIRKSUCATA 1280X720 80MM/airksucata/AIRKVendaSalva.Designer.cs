namespace airksucata
{
    partial class AIRKVendaSalva
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Avignon Pro", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(24, 175);
            button1.Name = "button1";
            button1.Size = new Size(336, 70);
            button1.TabIndex = 0;
            button1.Text = "Ok, Fechar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Avignon Pro Demi", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 110);
            label1.Name = "label1";
            label1.Size = new Size(322, 44);
            label1.TabIndex = 1;
            label1.Text = "Venda Registrada!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Avignon Pro Demi", 30.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(103, 21);
            label2.Name = "label2";
            label2.Size = new Size(179, 48);
            label2.TabIndex = 2;
            label2.Text = "Sucesso!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 30, 0);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 90);
            panel1.TabIndex = 3;
            // 
            // AIRKVendaSalva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AIRKVendaSalva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AIRKVendaSalva";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}