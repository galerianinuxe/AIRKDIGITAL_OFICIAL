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
            btnPrint = new Button();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            labelTotal = new Label();
            label6 = new Label();
            panelCabecalho = new Panel();
            lbNomeEmpresa = new Label();
            panel2 = new Panel();
            logoWhats = new PictureBox();
            panel1 = new Panel();
            lbContatoEmpresa = new Label();
            label4 = new Label();
            logoComprovante = new PictureBox();
            labelRegistro = new Label();
            lbLocalEmpresa = new Label();
            labelRelogio = new Label();
            listaComprovante = new ListView();
            comprovandoFinal = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            btnSoSalvar = new Button();
            btnConfirmarimprimir = new Button();
            panelComprovante.SuspendLayout();
            panelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoWhats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoComprovante).BeginInit();
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
            btnPrint.Visible = false;
            btnPrint.Click += btnPrint_Click;
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
            label6.Text = "Sistema de Controle Exclusivo v5.1.0\r\nSuporte: (11) 96351-2105";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.White;
            panelCabecalho.Controls.Add(lbNomeEmpresa);
            panelCabecalho.Controls.Add(panel2);
            panelCabecalho.Controls.Add(logoWhats);
            panelCabecalho.Controls.Add(panel1);
            panelCabecalho.Controls.Add(lbContatoEmpresa);
            panelCabecalho.Controls.Add(label4);
            panelCabecalho.Controls.Add(logoComprovante);
            panelCabecalho.Controls.Add(labelRegistro);
            panelCabecalho.Controls.Add(lbLocalEmpresa);
            panelCabecalho.Controls.Add(labelRelogio);
            panelCabecalho.Location = new Point(0, 1);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(466, 237);
            panelCabecalho.TabIndex = 34;
            panelCabecalho.Paint += panelCabecalho_Paint;
            // 
            // lbNomeEmpresa
            // 
            lbNomeEmpresa.AutoSize = true;
            lbNomeEmpresa.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbNomeEmpresa.Location = new Point(110, 10);
            lbNomeEmpresa.Name = "lbNomeEmpresa";
            lbNomeEmpresa.Size = new Size(330, 34);
            lbNomeEmpresa.TabIndex = 32;
            lbNomeEmpresa.Text = "ACR - CENTRO DE RECICLAGEM";
            lbNomeEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(3, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 4);
            panel2.TabIndex = 31;
            // 
            // logoWhats
            // 
            logoWhats.Image = Properties.Resources.wppblack;
            logoWhats.Location = new Point(381, 107);
            logoWhats.Name = "logoWhats";
            logoWhats.Size = new Size(57, 46);
            logoWhats.SizeMode = PictureBoxSizeMode.Zoom;
            logoWhats.TabIndex = 31;
            logoWhats.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(2, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 4);
            panel1.TabIndex = 30;
            // 
            // lbContatoEmpresa
            // 
            lbContatoEmpresa.AutoSize = true;
            lbContatoEmpresa.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lbContatoEmpresa.Location = new Point(111, 107);
            lbContatoEmpresa.Name = "lbContatoEmpresa";
            lbContatoEmpresa.Size = new Size(274, 46);
            lbContatoEmpresa.TabIndex = 10;
            lbContatoEmpresa.Text = "(21) 99157-6770";
            lbContatoEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(241, 202);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 8;
            label4.Text = "Nº Registro:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // logoComprovante
            // 
            logoComprovante.Image = Properties.Resources.ecovidablack1;
            logoComprovante.Location = new Point(4, 1);
            logoComprovante.Name = "logoComprovante";
            logoComprovante.Size = new Size(105, 167);
            logoComprovante.SizeMode = PictureBoxSizeMode.Zoom;
            logoComprovante.TabIndex = 0;
            logoComprovante.TabStop = false;
            // 
            // labelRegistro
            // 
            labelRegistro.AutoSize = true;
            labelRegistro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistro.Location = new Point(352, 197);
            labelRegistro.Name = "labelRegistro";
            labelRegistro.Size = new Size(84, 32);
            labelRegistro.TabIndex = 9;
            labelRegistro.Text = "00000";
            labelRegistro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbLocalEmpresa
            // 
            lbLocalEmpresa.AutoSize = true;
            lbLocalEmpresa.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbLocalEmpresa.Location = new Point(3, 165);
            lbLocalEmpresa.Name = "lbLocalEmpresa";
            lbLocalEmpresa.Size = new Size(362, 27);
            lbLocalEmpresa.TabIndex = 1;
            lbLocalEmpresa.Text = "EST. MAGARCA, 4935 - GUARATIBA - RJ";
            lbLocalEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRelogio
            // 
            labelRelogio.AutoSize = true;
            labelRelogio.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelRelogio.Location = new Point(2, 198);
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
            listaComprovante.Location = new Point(2, 244);
            listaComprovante.Name = "listaComprovante";
            listaComprovante.Size = new Size(464, 370);
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
            btnConfirmarimprimir.Click += btnPrint_Click;
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
            ((System.ComponentModel.ISupportInitialize)logoWhats).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoComprovante).EndInit();
            comprovandoFinal.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lbNomeEmpresa;
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
        private PictureBox logoWhats;
        private Panel panel1;
        private Label lbContatoEmpresa;
        private Label label4;
        private PictureBox logoComprovante;
        private Label labelRegistro;
        private Label lbLocalEmpresa;
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