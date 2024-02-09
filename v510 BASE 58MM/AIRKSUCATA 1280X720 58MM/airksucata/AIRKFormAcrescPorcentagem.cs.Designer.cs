namespace airksucata
{
    partial class AIRKFormAcrescPorcentagem
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
            panel2 = new Panel();
            txtPorcentagem = new TextBox();
            btnCancelar = new Button();
            btn025 = new Button();
            btnProntoPorcentagem = new Button();
            btn050 = new Button();
            btn100 = new Button();
            btn001 = new Button();
            btn005 = new Button();
            btn010 = new Button();
            btnZerar = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 60);
            panel1.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Avignon Pro", 17.996F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(383, 29);
            label1.TabIndex = 0;
            label1.Text = "ACRÉSCIMO EM PORCENTAGEM %";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 5);
            panel2.Controls.Add(txtPorcentagem);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btn025);
            panel2.Controls.Add(btnProntoPorcentagem);
            panel2.Controls.Add(btn050);
            panel2.Controls.Add(btn100);
            panel2.Controls.Add(btn001);
            panel2.Controls.Add(btn005);
            panel2.Controls.Add(btn010);
            panel2.Controls.Add(btnZerar);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 293);
            panel2.TabIndex = 66;
            // 
            // txtPorcentagem
            // 
            txtPorcentagem.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPorcentagem.Location = new Point(32, 47);
            txtPorcentagem.Name = "txtPorcentagem";
            txtPorcentagem.PlaceholderText = "R$ 0,00";
            txtPorcentagem.Size = new Size(178, 46);
            txtPorcentagem.TabIndex = 77;
            txtPorcentagem.Text = "0%";
            txtPorcentagem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(60, 10, 10);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Avignon Pro Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(21, 224);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(188, 54);
            btnCancelar.TabIndex = 73;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btn025
            // 
            btn025.Anchor = AnchorStyles.Top;
            btn025.BackColor = Color.FromArgb(5, 30, 5);
            btn025.Cursor = Cursors.Hand;
            btn025.FlatStyle = FlatStyle.Flat;
            btn025.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn025.ForeColor = Color.Lime;
            btn025.Location = new Point(30, 162);
            btn025.Name = "btn025";
            btn025.Size = new Size(117, 51);
            btn025.TabIndex = 74;
            btn025.Text = "+ 25%";
            btn025.UseVisualStyleBackColor = false;
            // 
            // btnProntoPorcentagem
            // 
            btnProntoPorcentagem.BackColor = Color.FromArgb(10, 60, 10);
            btnProntoPorcentagem.FlatStyle = FlatStyle.Flat;
            btnProntoPorcentagem.Font = new Font("Avignon Pro Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnProntoPorcentagem.ForeColor = Color.Lime;
            btnProntoPorcentagem.Location = new Point(214, 224);
            btnProntoPorcentagem.Name = "btnProntoPorcentagem";
            btnProntoPorcentagem.Size = new Size(188, 54);
            btnProntoPorcentagem.TabIndex = 72;
            btnProntoPorcentagem.Text = "PRONTO";
            btnProntoPorcentagem.UseVisualStyleBackColor = false;
            btnProntoPorcentagem.Click += btnProntoPorcentagem_Click;
            // 
            // btn050
            // 
            btn050.Anchor = AnchorStyles.Top;
            btn050.BackColor = Color.FromArgb(5, 30, 5);
            btn050.Cursor = Cursors.Hand;
            btn050.FlatStyle = FlatStyle.Flat;
            btn050.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn050.ForeColor = Color.Lime;
            btn050.Location = new Point(153, 162);
            btn050.Name = "btn050";
            btn050.Size = new Size(117, 51);
            btn050.TabIndex = 73;
            btn050.Text = "+ 50%";
            btn050.UseVisualStyleBackColor = false;
            // 
            // btn100
            // 
            btn100.Anchor = AnchorStyles.Top;
            btn100.BackColor = Color.FromArgb(5, 30, 5);
            btn100.Cursor = Cursors.Hand;
            btn100.FlatStyle = FlatStyle.Flat;
            btn100.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn100.ForeColor = Color.Lime;
            btn100.Location = new Point(276, 162);
            btn100.Name = "btn100";
            btn100.Size = new Size(117, 51);
            btn100.TabIndex = 72;
            btn100.Text = "+ 100%";
            btn100.UseVisualStyleBackColor = false;
            // 
            // btn001
            // 
            btn001.Anchor = AnchorStyles.Top;
            btn001.BackColor = Color.FromArgb(5, 30, 5);
            btn001.Cursor = Cursors.Hand;
            btn001.FlatStyle = FlatStyle.Flat;
            btn001.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn001.ForeColor = Color.Lime;
            btn001.Location = new Point(30, 105);
            btn001.Name = "btn001";
            btn001.Size = new Size(117, 51);
            btn001.TabIndex = 71;
            btn001.Text = "+ 1%";
            btn001.UseVisualStyleBackColor = false;
            // 
            // btn005
            // 
            btn005.Anchor = AnchorStyles.Top;
            btn005.BackColor = Color.FromArgb(5, 30, 5);
            btn005.Cursor = Cursors.Hand;
            btn005.FlatStyle = FlatStyle.Flat;
            btn005.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn005.ForeColor = Color.Lime;
            btn005.Location = new Point(153, 105);
            btn005.Name = "btn005";
            btn005.Size = new Size(117, 51);
            btn005.TabIndex = 70;
            btn005.Text = "+ 5%";
            btn005.UseVisualStyleBackColor = false;
            // 
            // btn010
            // 
            btn010.Anchor = AnchorStyles.Top;
            btn010.BackColor = Color.FromArgb(5, 30, 5);
            btn010.Cursor = Cursors.Hand;
            btn010.FlatStyle = FlatStyle.Flat;
            btn010.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn010.ForeColor = Color.Lime;
            btn010.Location = new Point(276, 105);
            btn010.Name = "btn010";
            btn010.Size = new Size(117, 51);
            btn010.TabIndex = 69;
            btn010.Text = "+ 10%";
            btn010.UseVisualStyleBackColor = false;
            // 
            // btnZerar
            // 
            btnZerar.Anchor = AnchorStyles.Top;
            btnZerar.Cursor = Cursors.Hand;
            btnZerar.FlatStyle = FlatStyle.Flat;
            btnZerar.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnZerar.ForeColor = Color.Gold;
            btnZerar.Location = new Point(216, 45);
            btnZerar.Name = "btnZerar";
            btnZerar.Size = new Size(178, 51);
            btnZerar.TabIndex = 66;
            btnZerar.Text = "Zerar";
            btnZerar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Avignon Pro Demi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 12);
            label2.Name = "label2";
            label2.Size = new Size(295, 29);
            label2.TabIndex = 65;
            label2.Text = "Porcentagem % Adicional";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Avignon Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(73, 362);
            label3.Name = "label3";
            label3.Size = new Size(274, 14);
            label3.TabIndex = 78;
            label3.Text = "AIRK DIGITAL - TODOS OS DIREITOS RESERVADOS";
            // 
            // AIRKFormAcrescPorcentagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(420, 381);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AIRKFormAcrescPorcentagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AIRKFormAcrescPorcentagem";
            Load += AIRKFormAcrescPorcentagem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btn025;
        private Button btn050;
        private Button btn100;
        private Button btn001;
        private Button btn005;
        private Button btn010;
        private Button btnZerar;
        private Label label2;
        private Button btnCancelar;
        private Button btnProntoPorcentagem;
        private Label label3;
        private TextBox txtPorcentagem;
    }
}