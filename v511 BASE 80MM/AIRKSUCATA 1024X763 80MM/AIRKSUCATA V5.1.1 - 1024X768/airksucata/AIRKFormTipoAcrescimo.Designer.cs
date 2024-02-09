namespace airksucata
{
    partial class AIRKFormTipoAcrescimo
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
            panel2 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            pnlHeader = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            btnValor = new Button();
            btnPorcentagem = new Button();
            label4 = new Label();
            btnFechar = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(10, 390);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 10);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGreen;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(580, 10);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 60, 30);
            label1.Location = new Point(101, 17);
            label1.Name = "label1";
            label1.Size = new Size(398, 60);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Acréscimo:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightGreen;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(10, 10);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(580, 98);
            pnlHeader.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 400);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(590, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 390);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(16, 275);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 9;
            label2.Text = "Por Valor R$ 0,00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(470, 275);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 10;
            label3.Text = "Em Porcentagem %";
            // 
            // btnValor
            // 
            btnValor.BackColor = Color.FromArgb(0, 30, 0);
            btnValor.Cursor = Cursors.Hand;
            btnValor.FlatStyle = FlatStyle.Flat;
            btnValor.Font = new Font("Avignon Pro Medium", 48F, FontStyle.Bold, GraphicsUnit.Point);
            btnValor.ForeColor = Color.Lime;
            btnValor.Location = new Point(17, 111);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(280, 158);
            btnValor.TabIndex = 14;
            btnValor.Text = "R$";
            btnValor.UseVisualStyleBackColor = false;
            btnValor.Click += btnValor_Click;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.FromArgb(40, 40, 0);
            btnPorcentagem.Cursor = Cursors.Hand;
            btnPorcentagem.Enabled = false;
            btnPorcentagem.FlatStyle = FlatStyle.Flat;
            btnPorcentagem.Font = new Font("Avignon Pro Medium", 48F, FontStyle.Bold, GraphicsUnit.Point);
            btnPorcentagem.ForeColor = Color.Gold;
            btnPorcentagem.Location = new Point(303, 111);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(280, 158);
            btnPorcentagem.TabIndex = 13;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(40, 40, 0);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(393, 131);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 15;
            label4.Text = "Indisponível";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(40, 0, 0);
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(18, 322);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(566, 62);
            btnFechar.TabIndex = 16;
            btnFechar.Text = "CANCELAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // AIRKFormTipoAcrescimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(600, 400);
            ControlBox = false;
            Controls.Add(btnFechar);
            Controls.Add(label4);
            Controls.Add(btnValor);
            Controls.Add(btnPorcentagem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlHeader);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AIRKFormTipoAcrescimo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AIRKFormTipoAcrescimo";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        private Panel pnlHeader;
        private Button button1;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Button btnValor;
        private Button btnPorcentagem;
        private Label label4;
        private Button btnFechar;
    }
}