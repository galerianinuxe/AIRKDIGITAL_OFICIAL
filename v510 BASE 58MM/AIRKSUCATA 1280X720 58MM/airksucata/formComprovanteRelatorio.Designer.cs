namespace airksucata
{
    partial class formComprovanteRelatorio
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
            timerRelogioReg = new System.Windows.Forms.Timer(components);
            comprovandoFinal = new Panel();
            panelComprovante = new Panel();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel5 = new Panel();
            label1 = new Label();
            panelCabecalho = new Panel();
            lbNomeEmpresa = new Label();
            panel2 = new Panel();
            logoWhats = new PictureBox();
            panel1 = new Panel();
            lbContatoEmpresa = new Label();
            logoComprovante = new PictureBox();
            label4 = new Label();
            lbLocalEmpresa = new Label();
            labelRegistroRel = new Label();
            labelRelogioReg = new Label();
            listComprovanteRel2 = new ListView();
            label9 = new Label();
            labelTotal = new Label();
            labelTotalRelatorio = new Label();
            button2 = new Button();
            btnConfirmarimprimirRel = new Button();
            panel3 = new Panel();
            comprovandoFinal.SuspendLayout();
            panelComprovante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoWhats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoComprovante).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // timerRelogioReg
            // 
            timerRelogioReg.Enabled = true;
            timerRelogioReg.Interval = 1000;
            // 
            // comprovandoFinal
            // 
            comprovandoFinal.BackColor = Color.White;
            comprovandoFinal.Controls.Add(panelComprovante);
            comprovandoFinal.Dock = DockStyle.Top;
            comprovandoFinal.Location = new Point(0, 0);
            comprovandoFinal.Name = "comprovandoFinal";
            comprovandoFinal.Size = new Size(466, 715);
            comprovandoFinal.TabIndex = 8;
            // 
            // panelComprovante
            // 
            panelComprovante.BackColor = Color.White;
            panelComprovante.Controls.Add(label6);
            panelComprovante.Controls.Add(pictureBox3);
            panelComprovante.Controls.Add(label3);
            panelComprovante.Controls.Add(panel5);
            panelComprovante.Controls.Add(label1);
            panelComprovante.Controls.Add(panelCabecalho);
            panelComprovante.Controls.Add(listComprovanteRel2);
            panelComprovante.Controls.Add(label9);
            panelComprovante.Controls.Add(labelTotal);
            panelComprovante.Controls.Add(labelTotalRelatorio);
            panelComprovante.Location = new Point(0, 0);
            panelComprovante.Name = "panelComprovante";
            panelComprovante.Size = new Size(466, 655);
            panelComprovante.TabIndex = 1;
            panelComprovante.Paint += panelComprovante_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(260, 533);
            label6.Name = "label6";
            label6.Size = new Size(175, 27);
            label6.TabIndex = 48;
            label6.Text = "# REIMPRESSÃO #";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.Image = Properties.Resources.arrow;
            pictureBox3.Location = new Point(153, 570);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 573);
            label3.Name = "label3";
            label3.Size = new Size(154, 27);
            label3.TabIndex = 46;
            label3.Text = "TOTAL À PAGAR";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(2, 606);
            panel5.Name = "panel5";
            panel5.Size = new Size(460, 5);
            panel5.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 614);
            label1.Name = "label1";
            label1.Size = new Size(284, 44);
            label1.TabIndex = 45;
            label1.Text = "Sistema de Controle Exclusivo v5.1.0\r\nSuporte: (11) 96351-2105";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.White;
            panelCabecalho.Controls.Add(lbNomeEmpresa);
            panelCabecalho.Controls.Add(panel2);
            panelCabecalho.Controls.Add(logoWhats);
            panelCabecalho.Controls.Add(panel1);
            panelCabecalho.Controls.Add(lbContatoEmpresa);
            panelCabecalho.Controls.Add(logoComprovante);
            panelCabecalho.Controls.Add(label4);
            panelCabecalho.Controls.Add(lbLocalEmpresa);
            panelCabecalho.Controls.Add(labelRegistroRel);
            panelCabecalho.Controls.Add(labelRelogioReg);
            panelCabecalho.Location = new Point(-1, 2);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(466, 198);
            panelCabecalho.TabIndex = 43;
            // 
            // lbNomeEmpresa
            // 
            lbNomeEmpresa.AutoSize = true;
            lbNomeEmpresa.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbNomeEmpresa.Location = new Point(91, 7);
            lbNomeEmpresa.Name = "lbNomeEmpresa";
            lbNomeEmpresa.Size = new Size(330, 34);
            lbNomeEmpresa.TabIndex = 37;
            lbNomeEmpresa.Text = "ACR - CENTRO DE RECICLAGEM";
            lbNomeEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(3, 188);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 4);
            panel2.TabIndex = 31;
            // 
            // logoWhats
            // 
            logoWhats.Image = Properties.Resources.wppblack;
            logoWhats.Location = new Point(379, 40);
            logoWhats.Name = "logoWhats";
            logoWhats.Size = new Size(57, 64);
            logoWhats.SizeMode = PictureBoxSizeMode.Zoom;
            logoWhats.TabIndex = 36;
            logoWhats.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(2, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 4);
            panel1.TabIndex = 30;
            // 
            // lbContatoEmpresa
            // 
            lbContatoEmpresa.AutoSize = true;
            lbContatoEmpresa.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lbContatoEmpresa.Location = new Point(92, 58);
            lbContatoEmpresa.Name = "lbContatoEmpresa";
            lbContatoEmpresa.Size = new Size(274, 46);
            lbContatoEmpresa.TabIndex = 35;
            lbContatoEmpresa.Text = "(21) 99157-6770";
            lbContatoEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoComprovante
            // 
            logoComprovante.Image = Properties.Resources.ecovidablack1;
            logoComprovante.Location = new Point(3, 2);
            logoComprovante.Name = "logoComprovante";
            logoComprovante.Size = new Size(82, 102);
            logoComprovante.SizeMode = PictureBoxSizeMode.Zoom;
            logoComprovante.TabIndex = 33;
            logoComprovante.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(241, 165);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 8;
            label4.Text = "Nº Registro:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbLocalEmpresa
            // 
            lbLocalEmpresa.AutoSize = true;
            lbLocalEmpresa.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbLocalEmpresa.Location = new Point(4, 131);
            lbLocalEmpresa.Name = "lbLocalEmpresa";
            lbLocalEmpresa.Size = new Size(362, 27);
            lbLocalEmpresa.TabIndex = 34;
            lbLocalEmpresa.Text = "EST. MAGARCA, 4935 - GUARATIBA - RJ";
            lbLocalEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRegistroRel
            // 
            labelRegistroRel.AutoSize = true;
            labelRegistroRel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistroRel.Location = new Point(352, 159);
            labelRegistroRel.Name = "labelRegistroRel";
            labelRegistroRel.Size = new Size(84, 32);
            labelRegistroRel.TabIndex = 9;
            labelRegistroRel.Text = "00000";
            labelRegistroRel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRelogioReg
            // 
            labelRelogioReg.AutoSize = true;
            labelRelogioReg.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelRelogioReg.Location = new Point(2, 160);
            labelRelogioReg.Name = "labelRelogioReg";
            labelRelogioReg.Size = new Size(145, 28);
            labelRelogioReg.TabIndex = 3;
            labelRelogioReg.Text = "DATA E HORA";
            labelRelogioReg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listComprovanteRel2
            // 
            listComprovanteRel2.BorderStyle = BorderStyle.None;
            listComprovanteRel2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listComprovanteRel2.Location = new Point(-1, 202);
            listComprovanteRel2.Name = "listComprovanteRel2";
            listComprovanteRel2.Size = new Size(461, 358);
            listComprovanteRel2.TabIndex = 17;
            listComprovanteRel2.UseCompatibleStateImageBehavior = false;
            listComprovanteRel2.View = View.List;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(413, 1238);
            label9.Name = "label9";
            label9.Size = new Size(185, 25);
            label9.TabIndex = 12;
            label9.Text = "TOTAL À PAGAR";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.Location = new Point(405, 1257);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(180, 44);
            labelTotal.TabIndex = 7;
            labelTotal.Text = "R$ 00,00";
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotalRelatorio
            // 
            labelTotalRelatorio.Anchor = AnchorStyles.Top;
            labelTotalRelatorio.AutoSize = true;
            labelTotalRelatorio.Font = new Font("Calibri", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalRelatorio.Location = new Point(190, 563);
            labelTotalRelatorio.Name = "labelTotalRelatorio";
            labelTotalRelatorio.Size = new Size(124, 37);
            labelTotalRelatorio.TabIndex = 15;
            labelTotalRelatorio.Text = "R$ 00,00";
            labelTotalRelatorio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 30, 30);
            button2.Dock = DockStyle.Left;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(230, 59);
            button2.TabIndex = 6;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnConfirmarimprimirRel
            // 
            btnConfirmarimprimirRel.BackColor = Color.Lime;
            btnConfirmarimprimirRel.Dock = DockStyle.Right;
            btnConfirmarimprimirRel.FlatStyle = FlatStyle.Flat;
            btnConfirmarimprimirRel.Font = new Font("Arial", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarimprimirRel.ForeColor = Color.FromArgb(0, 50, 0);
            btnConfirmarimprimirRel.Location = new Point(236, 0);
            btnConfirmarimprimirRel.Name = "btnConfirmarimprimirRel";
            btnConfirmarimprimirRel.Size = new Size(230, 59);
            btnConfirmarimprimirRel.TabIndex = 5;
            btnConfirmarimprimirRel.Text = "REIMPRIMIR";
            btnConfirmarimprimirRel.UseVisualStyleBackColor = false;
            btnConfirmarimprimirRel.Click += btnConfirmarimprimirRel_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnConfirmarimprimirRel);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 661);
            panel3.Name = "panel3";
            panel3.Size = new Size(466, 59);
            panel3.TabIndex = 9;
            // 
            // formComprovanteRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(466, 720);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(comprovandoFinal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formComprovanteRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprovante do Relatório";
            Load += formComprovanteRelatorio_Load_1;
            comprovandoFinal.ResumeLayout(false);
            panelComprovante.ResumeLayout(false);
            panelComprovante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoWhats).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoComprovante).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerRelogioReg;
        private Panel comprovandoFinal;
        private Button button2;
        private Button btnConfirmarimprimirRel;
        private Panel panelComprovante;
        private ListView listComprovanteRel2;
        private Label labelTotalRelatorio;
        private Label label9;
        private Label labelTotal;
        private Panel panelCabecalho;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label6;
        private Panel panel3;
        private Label lbNomeEmpresa;
        private Panel panel2;
        private PictureBox logoWhats;
        private Panel panel1;
        private Label lbContatoEmpresa;
        private PictureBox logoComprovante;
        private Label label4;
        private Label lbLocalEmpresa;
        private Label labelRegistroRel;
        private Label labelRelogioReg;
    }
}