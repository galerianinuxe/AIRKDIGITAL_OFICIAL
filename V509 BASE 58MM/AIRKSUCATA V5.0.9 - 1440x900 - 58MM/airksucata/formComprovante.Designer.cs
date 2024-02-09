namespace airksucata
{
    partial class FormComprovante
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprovante));
            timer1 = new System.Windows.Forms.Timer(components);
            panelComprovante = new Panel();
            lbNomeCliente = new Label();
            panelRodape = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            labelTotal = new Label();
            label6 = new Label();
            panelCabecalho = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label8 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            labelRegistro = new Label();
            label2 = new Label();
            labelRelogio = new Label();
            listaComprovante = new ListView();
            comprovandoFinal = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            btnSoSalvar = new Button();
            btnConfirmarimprimir = new Button();
            btnPrint = new Button();
            panelComprovante.SuspendLayout();
            panelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            comprovandoFinal.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timerRelogioReg_Tick;
            // 
            // panelComprovante
            // 
            panelComprovante.BackColor = Color.White;
            panelComprovante.Controls.Add(lbNomeCliente);
            panelComprovante.Controls.Add(panelRodape);
            panelComprovante.Controls.Add(panelCabecalho);
            panelComprovante.Controls.Add(listaComprovante);
            panelComprovante.Location = new Point(0, 0);
            panelComprovante.Name = "panelComprovante";
            panelComprovante.Size = new Size(466, 703);
            panelComprovante.TabIndex = 1;
            // 
            // lbNomeCliente
            // 
            lbNomeCliente.AutoSize = true;
            lbNomeCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeCliente.Location = new Point(5, 589);
            lbNomeCliente.Name = "lbNomeCliente";
            lbNomeCliente.Size = new Size(0, 25);
            lbNomeCliente.TabIndex = 40;
            // 
            // panelRodape
            // 
            panelRodape.Controls.Add(btnPrint);
            panelRodape.Controls.Add(panel4);
            panelRodape.Controls.Add(pictureBox3);
            panelRodape.Controls.Add(label9);
            panelRodape.Controls.Add(labelTotal);
            panelRodape.Controls.Add(label6);
            panelRodape.Dock = DockStyle.Bottom;
            panelRodape.Location = new Point(0, 620);
            panelRodape.Name = "panelRodape";
            panelRodape.Size = new Size(466, 83);
            panelRodape.TabIndex = 35;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(5, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 5);
            panel4.TabIndex = 36;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = Properties.Resources.arrow;
            pictureBox3.Location = new Point(150, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(4, 5);
            label9.Name = "label9";
            label9.Size = new Size(154, 27);
            label9.TabIndex = 37;
            label9.Text = "TOTAL À PAGAR";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.None;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.Location = new Point(191, -1);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(124, 37);
            labelTotal.TabIndex = 34;
            labelTotal.Text = "R$ 00,00";
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(5, 40);
            label6.Name = "label6";
            label6.Size = new Size(284, 44);
            label6.TabIndex = 39;
            label6.Text = "Sistema de Controle Exclusivo v5.0.9\r\nSuporte: (11) 96351-2105";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.White;
            panelCabecalho.Controls.Add(label1);
            panelCabecalho.Controls.Add(panel2);
            panelCabecalho.Controls.Add(pictureBox2);
            panelCabecalho.Controls.Add(panel1);
            panelCabecalho.Controls.Add(label8);
            panelCabecalho.Controls.Add(label4);
            panelCabecalho.Controls.Add(pictureBox1);
            panelCabecalho.Controls.Add(labelRegistro);
            panelCabecalho.Controls.Add(label2);
            panelCabecalho.Controls.Add(labelRelogio);
            panelCabecalho.Location = new Point(0, 1);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(466, 152);
            panelCabecalho.TabIndex = 34;
            panelCabecalho.Paint += panelCabecalho_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 5);
            label1.Name = "label1";
            label1.Size = new Size(330, 34);
            label1.TabIndex = 32;
            label1.Text = "ACR - CENTRO DE RECICLAGEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(3, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 4);
            panel2.TabIndex = 31;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.wppblack;
            pictureBox2.Location = new Point(372, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(2, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 4);
            panel1.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(102, 40);
            label8.Name = "label8";
            label8.Size = new Size(274, 46);
            label8.TabIndex = 10;
            label8.Text = "(21) 99157-6770";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(241, 122);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 8;
            label4.Text = "Nº Registro:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ecovidablack1;
            pictureBox1.Location = new Point(4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelRegistro
            // 
            labelRegistro.AutoSize = true;
            labelRegistro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistro.Location = new Point(352, 117);
            labelRegistro.Name = "labelRegistro";
            labelRegistro.Size = new Size(84, 32);
            labelRegistro.TabIndex = 9;
            labelRegistro.Text = "00000";
            labelRegistro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(87, 86);
            label2.Name = "label2";
            label2.Size = new Size(362, 27);
            label2.TabIndex = 1;
            label2.Text = "EST. MAGARCA, 4935 - GUARATIBA - RJ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRelogio
            // 
            labelRelogio.AutoSize = true;
            labelRelogio.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelRelogio.Location = new Point(2, 118);
            labelRelogio.Name = "labelRelogio";
            labelRelogio.Size = new Size(145, 28);
            labelRelogio.TabIndex = 3;
            labelRelogio.Text = "DATA E HORA";
            labelRelogio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listaComprovante
            // 
            listaComprovante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listaComprovante.BackColor = Color.White;
            listaComprovante.BorderStyle = BorderStyle.None;
            listaComprovante.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listaComprovante.ForeColor = Color.White;
            listaComprovante.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listaComprovante.Location = new Point(2, 151);
            listaComprovante.Name = "listaComprovante";
            listaComprovante.Size = new Size(464, 463);
            listaComprovante.TabIndex = 6;
            listaComprovante.UseCompatibleStateImageBehavior = false;
            listaComprovante.View = View.Details;
            // 
            // comprovandoFinal
            // 
            comprovandoFinal.BackColor = Color.White;
            comprovandoFinal.Controls.Add(panelComprovante);
            comprovandoFinal.Location = new Point(0, 0);
            comprovandoFinal.Name = "comprovandoFinal";
            comprovandoFinal.Size = new Size(466, 706);
            comprovandoFinal.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnSoSalvar);
            panel3.Controls.Add(btnConfirmarimprimir);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 708);
            panel3.Name = "panel3";
            panel3.Size = new Size(466, 56);
            panel3.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 30, 30);
            button2.Dock = DockStyle.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(1, 0);
            button2.Name = "button2";
            button2.Size = new Size(165, 56);
            button2.TabIndex = 8;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSoSalvar
            // 
            btnSoSalvar.BackColor = Color.Gold;
            btnSoSalvar.Dock = DockStyle.Right;
            btnSoSalvar.FlatStyle = FlatStyle.Flat;
            btnSoSalvar.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoSalvar.ForeColor = Color.FromArgb(50, 50, 0);
            btnSoSalvar.Location = new Point(166, 0);
            btnSoSalvar.Name = "btnSoSalvar";
            btnSoSalvar.Size = new Size(150, 56);
            btnSoSalvar.TabIndex = 7;
            btnSoSalvar.Text = "SÓ SALVAR";
            btnSoSalvar.UseVisualStyleBackColor = false;
            btnSoSalvar.Click += btnSoSalvar_Click;
            // 
            // btnConfirmarimprimir
            // 
            btnConfirmarimprimir.BackColor = Color.Lime;
            btnConfirmarimprimir.Dock = DockStyle.Right;
            btnConfirmarimprimir.FlatStyle = FlatStyle.Flat;
            btnConfirmarimprimir.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarimprimir.ForeColor = Color.FromArgb(0, 50, 0);
            btnConfirmarimprimir.Location = new Point(316, 0);
            btnConfirmarimprimir.Name = "btnConfirmarimprimir";
            btnConfirmarimprimir.Size = new Size(150, 56);
            btnConfirmarimprimir.TabIndex = 6;
            btnConfirmarimprimir.Text = "IMPRIMIR";
            btnConfirmarimprimir.UseVisualStyleBackColor = false;
            btnConfirmarimprimir.Click += btnConfirmarimprimir_Click_1;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.ForeColor = Color.Black;
            btnPrint.Location = new Point(316, 47);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(131, 28);
            btnPrint.TabIndex = 40;
            btnPrint.Text = "IMPRIMIR";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // FormComprovante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(466, 764);
            Controls.Add(panel3);
            Controls.Add(comprovandoFinal);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormComprovante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprovante de Compra";
            Load += FormComprovante_Load;
            panelComprovante.ResumeLayout(false);
            panelComprovante.PerformLayout();
            panelRodape.ResumeLayout(false);
            panelRodape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            comprovandoFinal.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Panel panelComprovante;
        private Panel comprovandoFinal;
        private Panel panelRodape;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label9;
        private Label labelTotal;
        private Label label6;
        private Panel panelCabecalho;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label8;
        private Label label4;
        private PictureBox pictureBox1;
        private Label labelRegistro;
        private Label label2;
        private Label labelRelogio;
        private ListView listaComprovante;
        private Label lbNomeCliente;
        private Panel panel3;
        private Button btnSoSalvar;
        private Button button2;
        private Button btnConfirmarimprimir;
        private Button btnPrint;
    }
}