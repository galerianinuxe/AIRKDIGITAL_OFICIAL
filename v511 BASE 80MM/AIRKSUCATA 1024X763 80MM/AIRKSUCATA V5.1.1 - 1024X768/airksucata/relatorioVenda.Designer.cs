namespace airksucata
{
    partial class relatorioVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatorioVenda));
            panel1 = new Panel();
            btnFechar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            btn3d = new Button();
            btn30d = new Button();
            btn7d = new Button();
            label3 = new Label();
            btnConsultarPeso = new Button();
            dateTimePickerPeso = new DateTimePicker();
            label4 = new Label();
            panel4 = new Panel();
            listViewResultadoPeso = new ListView();
            listViewResultadoUnid = new ListView();
            panel3 = new Panel();
            splitContainer1 = new SplitContainer();
            btnImprimirUnitario = new Button();
            btnAbrirDestino = new Button();
            btnRelatorioUnit = new Button();
            groupBox1 = new GroupBox();
            lbQuantidade = new Label();
            groupBox2 = new GroupBox();
            lbValorTotalUnit = new Label();
            btnImprimirPeso = new Button();
            btnRelatorioPeso = new Button();
            button5 = new Button();
            groupBox5 = new GroupBox();
            lbPesoTotal = new Label();
            groupBox6 = new GroupBox();
            lbValorTotalKg = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 50, 0);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 53);
            panel1.TabIndex = 4;
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Dock = DockStyle.Right;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(918, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(62, 53);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(377, 27);
            label1.TabIndex = 1;
            label1.Text = "Consulta de Relatórios de Vendas";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn3d);
            panel2.Controls.Add(btn30d);
            panel2.Controls.Add(btn7d);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnConsultarPeso);
            panel2.Controls.Add(dateTimePickerPeso);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 577);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(391, 49);
            button1.Name = "button1";
            button1.Size = new Size(120, 38);
            button1.TabIndex = 45;
            button1.Text = "Últimos 60D";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn60d_Click;
            // 
            // btn3d
            // 
            btn3d.Cursor = Cursors.Hand;
            btn3d.FlatStyle = FlatStyle.Flat;
            btn3d.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3d.ForeColor = Color.Gold;
            btn3d.Location = new Point(12, 49);
            btn3d.Name = "btn3d";
            btn3d.Size = new Size(120, 38);
            btn3d.TabIndex = 42;
            btn3d.Text = "Últimos 3D";
            btn3d.UseVisualStyleBackColor = true;
            btn3d.Click += btn3d_Click;
            // 
            // btn30d
            // 
            btn30d.Cursor = Cursors.Hand;
            btn30d.FlatStyle = FlatStyle.Flat;
            btn30d.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn30d.ForeColor = Color.Gold;
            btn30d.Location = new Point(265, 49);
            btn30d.Name = "btn30d";
            btn30d.Size = new Size(120, 38);
            btn30d.TabIndex = 44;
            btn30d.Text = "Últimos 30D";
            btn30d.UseVisualStyleBackColor = true;
            btn30d.Click += btn30d_Click;
            // 
            // btn7d
            // 
            btn7d.Cursor = Cursors.Hand;
            btn7d.FlatStyle = FlatStyle.Flat;
            btn7d.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7d.ForeColor = Color.Gold;
            btn7d.Location = new Point(138, 49);
            btn7d.Name = "btn7d";
            btn7d.Size = new Size(120, 38);
            btn7d.TabIndex = 43;
            btn7d.Text = "Últimos 7D";
            btn7d.UseVisualStyleBackColor = true;
            btn7d.Click += btn7d_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Avignon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(841, 105);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 40;
            label3.Text = "Vendas por Peso";
            // 
            // btnConsultarPeso
            // 
            btnConsultarPeso.Cursor = Cursors.Hand;
            btnConsultarPeso.FlatStyle = FlatStyle.Flat;
            btnConsultarPeso.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarPeso.ForeColor = Color.White;
            btnConsultarPeso.Location = new Point(744, 49);
            btnConsultarPeso.Name = "btnConsultarPeso";
            btnConsultarPeso.Size = new Size(224, 38);
            btnConsultarPeso.TabIndex = 39;
            btnConsultarPeso.Text = "CONSULTAR";
            btnConsultarPeso.UseVisualStyleBackColor = true;
            btnConsultarPeso.Click += btnConsultarPeso_Click;
            // 
            // dateTimePickerPeso
            // 
            dateTimePickerPeso.Anchor = AnchorStyles.None;
            dateTimePickerPeso.CalendarMonthBackground = Color.Lime;
            dateTimePickerPeso.Cursor = Cursors.Hand;
            dateTimePickerPeso.CustomFormat = "";
            dateTimePickerPeso.DropDownAlign = LeftRightAlignment.Right;
            dateTimePickerPeso.Font = new Font("Avignon Pro Demi", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerPeso.Format = DateTimePickerFormat.Short;
            dateTimePickerPeso.Location = new Point(517, 48);
            dateTimePickerPeso.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePickerPeso.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dateTimePickerPeso.Name = "dateTimePickerPeso";
            dateTimePickerPeso.Size = new Size(224, 40);
            dateTimePickerPeso.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Avignon Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(329, 105);
            label4.Name = "label4";
            label4.Size = new Size(155, 19);
            label4.TabIndex = 33;
            label4.Text = "Vendas por Unidade";
            // 
            // panel4
            // 
            panel4.Controls.Add(listViewResultadoPeso);
            panel4.Controls.Add(listViewResultadoUnid);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(980, 450);
            panel4.TabIndex = 27;
            // 
            // listViewResultadoPeso
            // 
            listViewResultadoPeso.Dock = DockStyle.Right;
            listViewResultadoPeso.Location = new Point(491, 0);
            listViewResultadoPeso.Name = "listViewResultadoPeso";
            listViewResultadoPeso.Size = new Size(489, 450);
            listViewResultadoPeso.TabIndex = 21;
            listViewResultadoPeso.UseCompatibleStateImageBehavior = false;
            listViewResultadoPeso.View = View.Details;
            // 
            // listViewResultadoUnid
            // 
            listViewResultadoUnid.Dock = DockStyle.Left;
            listViewResultadoUnid.Location = new Point(0, 0);
            listViewResultadoUnid.Name = "listViewResultadoUnid";
            listViewResultadoUnid.Size = new Size(489, 450);
            listViewResultadoUnid.TabIndex = 20;
            listViewResultadoUnid.UseCompatibleStateImageBehavior = false;
            listViewResultadoUnid.View = View.Details;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 30, 0);
            panel3.Controls.Add(splitContainer1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(980, 158);
            panel3.TabIndex = 29;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnImprimirUnitario);
            splitContainer1.Panel1.Controls.Add(btnAbrirDestino);
            splitContainer1.Panel1.Controls.Add(btnRelatorioUnit);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnImprimirPeso);
            splitContainer1.Panel2.Controls.Add(btnRelatorioPeso);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(groupBox5);
            splitContainer1.Panel2.Controls.Add(groupBox6);
            splitContainer1.Size = new Size(980, 158);
            splitContainer1.SplitterDistance = 488;
            splitContainer1.TabIndex = 0;
            // 
            // btnImprimirUnitario
            // 
            btnImprimirUnitario.Anchor = AnchorStyles.Top;
            btnImprimirUnitario.Cursor = Cursors.Hand;
            btnImprimirUnitario.FlatStyle = FlatStyle.Flat;
            btnImprimirUnitario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimirUnitario.ForeColor = Color.Lime;
            btnImprimirUnitario.Location = new Point(226, 106);
            btnImprimirUnitario.Name = "btnImprimirUnitario";
            btnImprimirUnitario.Size = new Size(246, 36);
            btnImprimirUnitario.TabIndex = 44;
            btnImprimirUnitario.Text = "Imprimir Relatório";
            btnImprimirUnitario.UseVisualStyleBackColor = true;
            btnImprimirUnitario.Click += btnImprimirUnitario_Click;
            // 
            // btnAbrirDestino
            // 
            btnAbrirDestino.Anchor = AnchorStyles.Top;
            btnAbrirDestino.Cursor = Cursors.Hand;
            btnAbrirDestino.FlatStyle = FlatStyle.Flat;
            btnAbrirDestino.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrirDestino.ForeColor = Color.Gold;
            btnAbrirDestino.Location = new Point(226, 63);
            btnAbrirDestino.Name = "btnAbrirDestino";
            btnAbrirDestino.Size = new Size(246, 36);
            btnAbrirDestino.TabIndex = 43;
            btnAbrirDestino.Text = "Abrir Local do Arquivo";
            btnAbrirDestino.UseVisualStyleBackColor = true;
            btnAbrirDestino.Click += btnAbrirDestino_Click;
            // 
            // btnRelatorioUnit
            // 
            btnRelatorioUnit.Anchor = AnchorStyles.Top;
            btnRelatorioUnit.Cursor = Cursors.Hand;
            btnRelatorioUnit.FlatStyle = FlatStyle.Flat;
            btnRelatorioUnit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRelatorioUnit.ForeColor = Color.White;
            btnRelatorioUnit.Location = new Point(226, 21);
            btnRelatorioUnit.Name = "btnRelatorioUnit";
            btnRelatorioUnit.Size = new Size(246, 36);
            btnRelatorioUnit.TabIndex = 42;
            btnRelatorioUnit.Text = "Gerar Relatório";
            btnRelatorioUnit.UseVisualStyleBackColor = true;
            btnRelatorioUnit.Click += btnRelatorioUnit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(lbQuantidade);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(9, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 65);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quantidade Itens:";
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuantidade.ForeColor = Color.Lime;
            lbQuantidade.Location = new Point(9, 23);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(21, 24);
            lbQuantidade.TabIndex = 26;
            lbQuantidade.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(lbValorTotalUnit);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(9, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(211, 65);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total em Vendas";
            // 
            // lbValorTotalUnit
            // 
            lbValorTotalUnit.AutoSize = true;
            lbValorTotalUnit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorTotalUnit.ForeColor = Color.Lime;
            lbValorTotalUnit.Location = new Point(9, 28);
            lbValorTotalUnit.Name = "lbValorTotalUnit";
            lbValorTotalUnit.Size = new Size(91, 24);
            lbValorTotalUnit.TabIndex = 26;
            lbValorTotalUnit.Text = "R$ 00,00";
            // 
            // btnImprimirPeso
            // 
            btnImprimirPeso.Anchor = AnchorStyles.Top;
            btnImprimirPeso.Cursor = Cursors.Hand;
            btnImprimirPeso.FlatStyle = FlatStyle.Flat;
            btnImprimirPeso.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimirPeso.ForeColor = Color.Lime;
            btnImprimirPeso.Location = new Point(226, 105);
            btnImprimirPeso.Name = "btnImprimirPeso";
            btnImprimirPeso.Size = new Size(246, 36);
            btnImprimirPeso.TabIndex = 46;
            btnImprimirPeso.Text = "Imprimir Relatório";
            btnImprimirPeso.UseVisualStyleBackColor = true;
            btnImprimirPeso.Click += btnImprimirPeso_Click;
            // 
            // btnRelatorioPeso
            // 
            btnRelatorioPeso.Anchor = AnchorStyles.Top;
            btnRelatorioPeso.Cursor = Cursors.Hand;
            btnRelatorioPeso.FlatStyle = FlatStyle.Flat;
            btnRelatorioPeso.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRelatorioPeso.ForeColor = Color.White;
            btnRelatorioPeso.Location = new Point(226, 21);
            btnRelatorioPeso.Name = "btnRelatorioPeso";
            btnRelatorioPeso.Size = new Size(246, 36);
            btnRelatorioPeso.TabIndex = 44;
            btnRelatorioPeso.Text = "Gerar Relatório";
            btnRelatorioPeso.UseVisualStyleBackColor = true;
            btnRelatorioPeso.Click += btnRelatorioPeso_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Gold;
            button5.Location = new Point(226, 62);
            button5.Name = "button5";
            button5.Size = new Size(246, 36);
            button5.TabIndex = 45;
            button5.Text = "Abrir Local do Arquivo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top;
            groupBox5.Controls.Add(lbPesoTotal);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(9, 77);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(211, 65);
            groupBox5.TabIndex = 37;
            groupBox5.TabStop = false;
            groupBox5.Text = "Peso Total KG";
            // 
            // lbPesoTotal
            // 
            lbPesoTotal.AutoSize = true;
            lbPesoTotal.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbPesoTotal.ForeColor = Color.Lime;
            lbPesoTotal.Location = new Point(9, 28);
            lbPesoTotal.Name = "lbPesoTotal";
            lbPesoTotal.Size = new Size(60, 24);
            lbPesoTotal.TabIndex = 26;
            lbPesoTotal.Text = "0,000";
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top;
            groupBox6.Controls.Add(lbValorTotalKg);
            groupBox6.FlatStyle = FlatStyle.Flat;
            groupBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(9, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(211, 65);
            groupBox6.TabIndex = 36;
            groupBox6.TabStop = false;
            groupBox6.Text = "Total em Vendas";
            // 
            // lbValorTotalKg
            // 
            lbValorTotalKg.AutoSize = true;
            lbValorTotalKg.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbValorTotalKg.ForeColor = Color.Lime;
            lbValorTotalKg.Location = new Point(9, 28);
            lbValorTotalKg.Name = "lbValorTotalKg";
            lbValorTotalKg.Size = new Size(91, 24);
            lbValorTotalKg.TabIndex = 26;
            lbValorTotalKg.Text = "R$ 00,00";
            // 
            // relatorioVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(980, 764);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "relatorioVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "relatorioVenda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnFechar;
        private Label label1;
        private Panel panel2;
        private ListView listViewResultadoUnid;
        private Panel panel3;
        private Panel panel4;
        private ListView listViewResultadoPeso;
        private Label label4;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label lbQuantidade;
        private GroupBox groupBox2;
        private Label lbValorTotalUnit;
        private GroupBox groupBox5;
        private Label lbPesoTotal;
        private GroupBox groupBox6;
        private Label lbValorTotalKg;
        private Button btnConsultarPeso;
        private DateTimePicker dateTimePickerPeso;
        private Button btn3d;
        private Button btn30d;
        private Button btn7d;
        private Label label3;
        private Button button1;
        private Button btnImprimirUnitario;
        private Button btnAbrirDestino;
        private Button btnRelatorioUnit;
        private Button btnImprimirPeso;
        private Button btnRelatorioPeso;
        private Button button5;
    }
}