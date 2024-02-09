namespace airksucata
{
    partial class AIRKAlertaEdicaoMaterial
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnReiniciarTudo = new Button();
            btnNaoReiniciar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(112, 24);
            label1.Name = "label1";
            label1.Size = new Size(377, 56);
            label1.TabIndex = 1;
            label1.Text = "OBRIGATÓRIO!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 119);
            label2.Name = "label2";
            label2.Size = new Size(501, 56);
            label2.TabIndex = 2;
            label2.Text = "O sistema deve ser reiniciado para que as\r\nalterações sejam atualizadas por completo.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(44, 196);
            label3.Name = "label3";
            label3.Size = new Size(513, 28);
            label3.TabIndex = 3;
            label3.Text = "Quer Reiniciar o Sistema Automaticamente?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReiniciarTudo
            // 
            btnReiniciarTudo.FlatStyle = FlatStyle.Flat;
            btnReiniciarTudo.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnReiniciarTudo.ForeColor = Color.Lime;
            btnReiniciarTudo.Location = new Point(308, 247);
            btnReiniciarTudo.Name = "btnReiniciarTudo";
            btnReiniciarTudo.Size = new Size(280, 75);
            btnReiniciarTudo.TabIndex = 4;
            btnReiniciarTudo.Text = "SIM";
            btnReiniciarTudo.UseVisualStyleBackColor = true;
            btnReiniciarTudo.Click += btnReiniciarTudo_Click;
            // 
            // btnNaoReiniciar
            // 
            btnNaoReiniciar.FlatStyle = FlatStyle.Flat;
            btnNaoReiniciar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNaoReiniciar.ForeColor = Color.Red;
            btnNaoReiniciar.Location = new Point(12, 247);
            btnNaoReiniciar.Name = "btnNaoReiniciar";
            btnNaoReiniciar.Size = new Size(280, 75);
            btnNaoReiniciar.TabIndex = 5;
            btnNaoReiniciar.Text = "NÃO";
            btnNaoReiniciar.UseVisualStyleBackColor = true;
            btnNaoReiniciar.Click += btnNaoReiniciar_Click;
            // 
            // AIRKAlertaEdicaoMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 30, 0);
            ClientSize = new Size(600, 334);
            Controls.Add(btnNaoReiniciar);
            Controls.Add(btnReiniciarTudo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AIRKAlertaEdicaoMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REINICIE O SISTEMA AIRKSUCATA";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnReiniciarTudo;
        private Button btnNaoReiniciar;
    }
}