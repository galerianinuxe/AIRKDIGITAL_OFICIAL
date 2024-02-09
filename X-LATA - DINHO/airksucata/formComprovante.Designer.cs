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
            pictureBox3 = new PictureBox();
            label9 = new Label();
            labelTotal = new Label();
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
            comprovandoFinal = new Panel();
            panelComprovante = new Panel();
            lbNomeCliente = new Label();
            listaComprovante = new ListView();
            btnConfirmarimprimir = new Button();
            btnSoSalvar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoWhats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoComprovante).BeginInit();
            comprovandoFinal.SuspendLayout();
            panelComprovante.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timerRelogioReg_Tick;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = Properties.Resources.arrow;
            pictureBox3.Location = new Point(160, 301);
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
            label9.Location = new Point(5, 302);
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
            labelTotal.Location = new Point(209, 297);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(124, 37);
            labelTotal.TabIndex = 34;
            labelTotal.Text = "R$ 00,00";
            labelTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.White;
            panelCabecalho.Controls.Add(pictureBox3);
            panelCabecalho.Controls.Add(lbNomeEmpresa);
            panelCabecalho.Controls.Add(label9);
            panelCabecalho.Controls.Add(panel2);
            panelCabecalho.Controls.Add(labelTotal);
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
            panelCabecalho.Size = new Size(466, 339);
            panelCabecalho.TabIndex = 34;
            panelCabecalho.Paint += panelCabecalho_Paint;
            // 
            // lbNomeEmpresa
            // 
            lbNomeEmpresa.AutoSize = true;
            lbNomeEmpresa.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeEmpresa.Location = new Point(118, 1);
            lbNomeEmpresa.Name = "lbNomeEmpresa";
            lbNomeEmpresa.Size = new Size(295, 58);
            lbNomeEmpresa.TabIndex = 32;
            lbNomeEmpresa.Text = "RECICLANDO PARA UM\r\nFUTURO SUSTENTÁVEL";
            lbNomeEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(3, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 4);
            panel2.TabIndex = 31;
            // 
            // logoWhats
            // 
            logoWhats.Image = Properties.Resources.wppblack;
            logoWhats.Location = new Point(386, 85);
            logoWhats.Name = "logoWhats";
            logoWhats.Size = new Size(68, 83);
            logoWhats.SizeMode = PictureBoxSizeMode.Zoom;
            logoWhats.TabIndex = 31;
            logoWhats.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(5, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 4);
            panel1.TabIndex = 30;
            // 
            // lbContatoEmpresa
            // 
            lbContatoEmpresa.AutoSize = true;
            lbContatoEmpresa.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lbContatoEmpresa.Location = new Point(120, 73);
            lbContatoEmpresa.Name = "lbContatoEmpresa";
            lbContatoEmpresa.Size = new Size(274, 46);
            lbContatoEmpresa.TabIndex = 10;
            lbContatoEmpresa.Text = "(11) 97953-8160";
            lbContatoEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 261);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 8;
            label4.Text = "Nº Registro:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // logoComprovante
            // 
            logoComprovante.Image = Properties.Resources.LOGOBLACK;
            logoComprovante.Location = new Point(4, 3);
            logoComprovante.Name = "logoComprovante";
            logoComprovante.Size = new Size(112, 164);
            logoComprovante.SizeMode = PictureBoxSizeMode.Zoom;
            logoComprovante.TabIndex = 0;
            logoComprovante.TabStop = false;
            // 
            // labelRegistro
            // 
            labelRegistro.AutoSize = true;
            labelRegistro.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegistro.Location = new Point(132, 251);
            labelRegistro.Name = "labelRegistro";
            labelRegistro.Size = new Size(107, 37);
            labelRegistro.TabIndex = 9;
            labelRegistro.Text = "00000";
            labelRegistro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbLocalEmpresa
            // 
            lbLocalEmpresa.AutoSize = true;
            lbLocalEmpresa.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbLocalEmpresa.Location = new Point(3, 173);
            lbLocalEmpresa.Name = "lbLocalEmpresa";
            lbLocalEmpresa.Size = new Size(336, 27);
            lbLocalEmpresa.TabIndex = 1;
            lbLocalEmpresa.Text = "AV. GUAPIRA, 1883 - TUCURUVI - SP";
            lbLocalEmpresa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRelogio
            // 
            labelRelogio.AutoSize = true;
            labelRelogio.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelRelogio.Location = new Point(3, 216);
            labelRelogio.Name = "labelRelogio";
            labelRelogio.Size = new Size(216, 35);
            labelRelogio.TabIndex = 3;
            labelRelogio.Text = "DATA E HORA";
            labelRelogio.TextAlign = ContentAlignment.MiddleCenter;
            labelRelogio.TextChanged += labelRelogio_TextChanged;
            // 
            // comprovandoFinal
            // 
            comprovandoFinal.BackColor = Color.White;
            comprovandoFinal.Controls.Add(panelComprovante);
            comprovandoFinal.Location = new Point(0, 0);
            comprovandoFinal.Name = "comprovandoFinal";
            comprovandoFinal.Size = new Size(466, 373);
            comprovandoFinal.TabIndex = 4;
            // 
            // panelComprovante
            // 
            panelComprovante.BackColor = Color.White;
            panelComprovante.Controls.Add(lbNomeCliente);
            panelComprovante.Controls.Add(panelCabecalho);
            panelComprovante.Controls.Add(listaComprovante);
            panelComprovante.Location = new Point(0, 0);
            panelComprovante.Name = "panelComprovante";
            panelComprovante.Size = new Size(466, 373);
            panelComprovante.TabIndex = 1;
            // 
            // lbNomeCliente
            // 
            lbNomeCliente.AutoSize = true;
            lbNomeCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeCliente.Location = new Point(12, 343);
            lbNomeCliente.Name = "lbNomeCliente";
            lbNomeCliente.Size = new Size(0, 25);
            lbNomeCliente.TabIndex = 40;
            // 
            // listaComprovante
            // 
            listaComprovante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listaComprovante.BackColor = Color.White;
            listaComprovante.BorderStyle = BorderStyle.None;
            listaComprovante.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listaComprovante.ForeColor = Color.White;
            listaComprovante.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listaComprovante.Location = new Point(2, 343);
            listaComprovante.Name = "listaComprovante";
            listaComprovante.Size = new Size(464, 25);
            listaComprovante.TabIndex = 6;
            listaComprovante.UseCompatibleStateImageBehavior = false;
            listaComprovante.View = View.Details;
            // 
            // btnConfirmarimprimir
            // 
            btnConfirmarimprimir.BackColor = Color.FromArgb(0, 40, 0);
            btnConfirmarimprimir.Cursor = Cursors.Hand;
            btnConfirmarimprimir.Dock = DockStyle.Bottom;
            btnConfirmarimprimir.Enabled = false;
            btnConfirmarimprimir.FlatStyle = FlatStyle.Flat;
            btnConfirmarimprimir.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarimprimir.ForeColor = Color.Lime;
            btnConfirmarimprimir.Location = new Point(0, 340);
            btnConfirmarimprimir.Name = "btnConfirmarimprimir";
            btnConfirmarimprimir.Size = new Size(466, 79);
            btnConfirmarimprimir.TabIndex = 12;
            btnConfirmarimprimir.Text = "IMPRIMIR";
            btnConfirmarimprimir.UseVisualStyleBackColor = false;
            btnConfirmarimprimir.Click += btnPrint_Click;
            // 
            // btnSoSalvar
            // 
            btnSoSalvar.BackColor = Color.FromArgb(40, 40, 0);
            btnSoSalvar.Cursor = Cursors.Hand;
            btnSoSalvar.Dock = DockStyle.Bottom;
            btnSoSalvar.Enabled = false;
            btnSoSalvar.FlatStyle = FlatStyle.Flat;
            btnSoSalvar.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoSalvar.ForeColor = Color.Gold;
            btnSoSalvar.Location = new Point(0, 419);
            btnSoSalvar.Name = "btnSoSalvar";
            btnSoSalvar.Size = new Size(466, 71);
            btnSoSalvar.TabIndex = 13;
            btnSoSalvar.Text = "SÓ SALVAR";
            btnSoSalvar.UseVisualStyleBackColor = false;
            btnSoSalvar.Click += btnSoSalvar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(40, 0, 0);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Bottom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(0, 490);
            button2.Name = "button2";
            button2.Size = new Size(466, 71);
            button2.TabIndex = 14;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormComprovante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(466, 561);
            Controls.Add(btnConfirmarimprimir);
            Controls.Add(btnSoSalvar);
            Controls.Add(button2);
            Controls.Add(comprovandoFinal);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormComprovante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprovante de Compra";
            Load += FormComprovante_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoWhats).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoComprovante).EndInit();
            comprovandoFinal.ResumeLayout(false);
            panelComprovante.ResumeLayout(false);
            panelComprovante.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbNomeEmpresa;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox3;
        private Label label9;
        private Label labelTotal;
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
        private Panel comprovandoFinal;
        private Panel panelComprovante;
        private Label lbNomeCliente;
        private ListView listaComprovante;
        private Button btnConfirmarimprimir;
        private Button btnSoSalvar;
        private Button button2;
    }
}