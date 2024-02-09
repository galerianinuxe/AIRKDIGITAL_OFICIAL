namespace airksucata
{
    partial class AIRKFormAcrescValor
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
            btnCancelar = new Button();
            txtValorAcrescimo = new TextBox();
            btnPronto = new Button();
            btnValor025 = new Button();
            btnValor100 = new Button();
            btnValor250 = new Button();
            btnValor001 = new Button();
            btnValor005 = new Button();
            btnValor010 = new Button();
            btnZerar = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 30, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 60);
            panel1.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Avignon Pro", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(28, 13);
            label1.Name = "label1";
            label1.Size = new Size(364, 35);
            label1.TabIndex = 0;
            label1.Text = "ACRÉSCIMO POR VALOR R$";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 20, 5);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(txtValorAcrescimo);
            panel2.Controls.Add(btnPronto);
            panel2.Controls.Add(btnValor025);
            panel2.Controls.Add(btnValor100);
            panel2.Controls.Add(btnValor250);
            panel2.Controls.Add(btnValor001);
            panel2.Controls.Add(btnValor005);
            panel2.Controls.Add(btnValor010);
            panel2.Controls.Add(btnZerar);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 293);
            panel2.TabIndex = 65;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(60, 10, 10);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Avignon Pro Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(21, 224);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(188, 54);
            btnCancelar.TabIndex = 67;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtValorAcrescimo
            // 
            txtValorAcrescimo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtValorAcrescimo.Location = new Point(28, 43);
            txtValorAcrescimo.Name = "txtValorAcrescimo";
            txtValorAcrescimo.PlaceholderText = "R$ 0,00";
            txtValorAcrescimo.Size = new Size(178, 46);
            txtValorAcrescimo.TabIndex = 76;
            txtValorAcrescimo.Text = "R$ 0,00";
            txtValorAcrescimo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPronto
            // 
            btnPronto.BackColor = Color.FromArgb(10, 60, 10);
            btnPronto.Cursor = Cursors.Hand;
            btnPronto.FlatStyle = FlatStyle.Flat;
            btnPronto.Font = new Font("Avignon Pro Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPronto.ForeColor = Color.Lime;
            btnPronto.Location = new Point(214, 224);
            btnPronto.Name = "btnPronto";
            btnPronto.Size = new Size(188, 54);
            btnPronto.TabIndex = 66;
            btnPronto.Text = "PRONTO";
            btnPronto.UseVisualStyleBackColor = false;
            btnPronto.Click += btnPronto_Click;
            // 
            // btnValor025
            // 
            btnValor025.Anchor = AnchorStyles.Top;
            btnValor025.BackColor = Color.FromArgb(5, 30, 5);
            btnValor025.Cursor = Cursors.Hand;
            btnValor025.FlatStyle = FlatStyle.Flat;
            btnValor025.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnValor025.ForeColor = Color.Lime;
            btnValor025.Location = new Point(28, 158);
            btnValor025.Name = "btnValor025";
            btnValor025.Size = new Size(117, 51);
            btnValor025.TabIndex = 74;
            btnValor025.Text = "+R$ 0,25";
            btnValor025.UseVisualStyleBackColor = false;
            btnValor025.Click += btnValor025_Click;
            // 
            // btnValor100
            // 
            btnValor100.Anchor = AnchorStyles.Top;
            btnValor100.BackColor = Color.FromArgb(5, 30, 5);
            btnValor100.Cursor = Cursors.Hand;
            btnValor100.FlatStyle = FlatStyle.Flat;
            btnValor100.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnValor100.ForeColor = Color.Lime;
            btnValor100.Location = new Point(151, 158);
            btnValor100.Name = "btnValor100";
            btnValor100.Size = new Size(117, 51);
            btnValor100.TabIndex = 73;
            btnValor100.Text = "+R$ 1,00";
            btnValor100.UseVisualStyleBackColor = false;
            btnValor100.Click += btnValor100_Click;
            // 
            // btnValor250
            // 
            btnValor250.Anchor = AnchorStyles.Top;
            btnValor250.BackColor = Color.FromArgb(5, 30, 5);
            btnValor250.Cursor = Cursors.Hand;
            btnValor250.FlatStyle = FlatStyle.Flat;
            btnValor250.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnValor250.ForeColor = Color.Lime;
            btnValor250.Location = new Point(274, 158);
            btnValor250.Name = "btnValor250";
            btnValor250.Size = new Size(117, 51);
            btnValor250.TabIndex = 72;
            btnValor250.Text = "+R$ 2,50";
            btnValor250.UseVisualStyleBackColor = false;
            btnValor250.Click += btnValor250_Click;
            // 
            // btnValor001
            // 
            btnValor001.Anchor = AnchorStyles.Top;
            btnValor001.BackColor = Color.FromArgb(5, 30, 5);
            btnValor001.Cursor = Cursors.Hand;
            btnValor001.FlatStyle = FlatStyle.Flat;
            btnValor001.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnValor001.ForeColor = Color.Lime;
            btnValor001.Location = new Point(28, 101);
            btnValor001.Name = "btnValor001";
            btnValor001.Size = new Size(117, 51);
            btnValor001.TabIndex = 71;
            btnValor001.Text = "+R$ 0,01";
            btnValor001.UseVisualStyleBackColor = false;
            btnValor001.Click += btnValor001_Click;
            // 
            // btnValor005
            // 
            btnValor005.Anchor = AnchorStyles.Top;
            btnValor005.BackColor = Color.FromArgb(5, 30, 5);
            btnValor005.Cursor = Cursors.Hand;
            btnValor005.FlatStyle = FlatStyle.Flat;
            btnValor005.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnValor005.ForeColor = Color.Lime;
            btnValor005.Location = new Point(151, 101);
            btnValor005.Name = "btnValor005";
            btnValor005.Size = new Size(117, 51);
            btnValor005.TabIndex = 70;
            btnValor005.Text = "+R$ 0,05";
            btnValor005.UseVisualStyleBackColor = false;
            btnValor005.Click += btnValor005_Click;
            // 
            // btnValor010
            // 
            btnValor010.Anchor = AnchorStyles.Top;
            btnValor010.BackColor = Color.FromArgb(5, 30, 5);
            btnValor010.Cursor = Cursors.Hand;
            btnValor010.FlatStyle = FlatStyle.Flat;
            btnValor010.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnValor010.ForeColor = Color.Lime;
            btnValor010.Location = new Point(274, 101);
            btnValor010.Name = "btnValor010";
            btnValor010.Size = new Size(117, 51);
            btnValor010.TabIndex = 69;
            btnValor010.Text = "+R$ 0,10";
            btnValor010.UseVisualStyleBackColor = false;
            btnValor010.Click += btnValor010_Click;
            // 
            // btnZerar
            // 
            btnZerar.Anchor = AnchorStyles.Top;
            btnZerar.Cursor = Cursors.Hand;
            btnZerar.FlatStyle = FlatStyle.Flat;
            btnZerar.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnZerar.ForeColor = Color.Red;
            btnZerar.Location = new Point(214, 41);
            btnZerar.Name = "btnZerar";
            btnZerar.Size = new Size(178, 51);
            btnZerar.TabIndex = 66;
            btnZerar.Text = "Limpar";
            btnZerar.UseVisualStyleBackColor = true;
            btnZerar.Click += btnZerar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Avignon Pro Demi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 8);
            label2.Name = "label2";
            label2.Size = new Size(178, 29);
            label2.TabIndex = 65;
            label2.Text = "Valor Adicional";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Avignon Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(80, 80, 80);
            label3.Location = new Point(73, 361);
            label3.Name = "label3";
            label3.Size = new Size(274, 14);
            label3.TabIndex = 77;
            label3.Text = "AIRK DIGITAL - TODOS OS DIREITOS RESERVADOS";
            // 
            // AIRKFormAcrescValor
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
            Name = "AIRKFormAcrescValor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AIRKFormAcrescValor";
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
        private Button btnZerar;
        private Label label2;
        private Button btnPronto;
        private Button btnCancelar;
        private Button btnValor025;
        private Button btnValor100;
        private Button btnValor250;
        private Button btnValor001;
        private Button btnValor005;
        private Button btnValor010;
        private TextBox txtValorAcrescimo;
        private Label label3;
    }
}