namespace airksucata
{
    partial class formRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelatorios));
            label1 = new Label();
            panel1 = new Panel();
            btnFechar = new Button();
            btnConsultar = new Button();
            listViewResultado = new ListView();
            lbTotalCompra = new Label();
            panel2 = new Panel();
            btnImprimir = new Button();
            btnCancelar = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            lbTotalPesoMaterialMaisComprado = new Label();
            lbMaisComprado = new Label();
            groupBox2 = new GroupBox();
            lbTotalPeso = new Label();
            groupBox1 = new GroupBox();
            btnAbrirDestino = new Button();
            btnGerarPDF = new Button();
            panel3 = new Panel();
            btnConsultarData = new Button();
            dateTimePickerDia = new DateTimePicker();
            radioTudo = new RadioButton();
            groupBox4 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            radio30d = new RadioButton();
            radio3d = new RadioButton();
            listaMateriais = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(414, 36);
            label1.TabIndex = 1;
            label1.Text = "Consulta de Relatório Compra";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 50, 0);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 52);
            panel1.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Dock = DockStyle.Right;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(942, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(58, 52);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = Color.Gold;
            btnConsultar.Location = new Point(462, 104);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(292, 41);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // listViewResultado
            // 
            listViewResultado.Dock = DockStyle.Top;
            listViewResultado.Location = new Point(0, 207);
            listViewResultado.Name = "listViewResultado";
            listViewResultado.Size = new Size(1000, 363);
            listViewResultado.TabIndex = 19;
            listViewResultado.UseCompatibleStateImageBehavior = false;
            // 
            // lbTotalCompra
            // 
            lbTotalCompra.AutoSize = true;
            lbTotalCompra.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalCompra.ForeColor = Color.Lime;
            lbTotalCompra.Location = new Point(9, 25);
            lbTotalCompra.Name = "lbTotalCompra";
            lbTotalCompra.Size = new Size(115, 29);
            lbTotalCompra.TabIndex = 26;
            lbTotalCompra.Text = "R$ 00,00";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 30, 0);
            panel2.Controls.Add(btnImprimir);
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(btnAbrirDestino);
            panel2.Controls.Add(btnGerarPDF);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 570);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 152);
            panel2.TabIndex = 28;
            // 
            // btnImprimir
            // 
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.Enabled = false;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.ForeColor = Color.Gold;
            btnImprimir.Location = new Point(878, 105);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(110, 36);
            btnImprimir.TabIndex = 35;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(764, 105);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 36);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Fechar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(lbTotalPesoMaterialMaisComprado);
            groupBox3.Controls.Add(lbMaisComprado);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(393, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(361, 134);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mais Comprado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 68);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 35;
            label7.Text = "Peso Total KG";
            label7.TextAlign = ContentAlignment.BottomRight;
            // 
            // lbTotalPesoMaterialMaisComprado
            // 
            lbTotalPesoMaterialMaisComprado.AutoSize = true;
            lbTotalPesoMaterialMaisComprado.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalPesoMaterialMaisComprado.ForeColor = Color.Lime;
            lbTotalPesoMaterialMaisComprado.Location = new Point(6, 94);
            lbTotalPesoMaterialMaisComprado.Name = "lbTotalPesoMaterialMaisComprado";
            lbTotalPesoMaterialMaisComprado.Size = new Size(76, 29);
            lbTotalPesoMaterialMaisComprado.TabIndex = 34;
            lbTotalPesoMaterialMaisComprado.Text = "0,000";
            lbTotalPesoMaterialMaisComprado.TextAlign = ContentAlignment.BottomRight;
            // 
            // lbMaisComprado
            // 
            lbMaisComprado.AutoSize = true;
            lbMaisComprado.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaisComprado.ForeColor = Color.Lime;
            lbMaisComprado.Location = new Point(4, 22);
            lbMaisComprado.Name = "lbMaisComprado";
            lbMaisComprado.Size = new Size(128, 36);
            lbMaisComprado.TabIndex = 33;
            lbMaisComprado.Text = "Material";
            lbMaisComprado.TextAlign = ContentAlignment.BottomRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbTotalPeso);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 65);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Peso Total KG";
            // 
            // lbTotalPeso
            // 
            lbTotalPeso.AutoSize = true;
            lbTotalPeso.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalPeso.ForeColor = Color.Lime;
            lbTotalPeso.Location = new Point(9, 25);
            lbTotalPeso.Name = "lbTotalPeso";
            lbTotalPeso.Size = new Size(76, 29);
            lbTotalPeso.TabIndex = 26;
            lbTotalPeso.Text = "0,000";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTotalCompra);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 65);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total em Compras";
            // 
            // btnAbrirDestino
            // 
            btnAbrirDestino.Cursor = Cursors.Hand;
            btnAbrirDestino.FlatStyle = FlatStyle.Flat;
            btnAbrirDestino.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrirDestino.ForeColor = Color.White;
            btnAbrirDestino.Location = new Point(764, 56);
            btnAbrirDestino.Name = "btnAbrirDestino";
            btnAbrirDestino.Size = new Size(224, 45);
            btnAbrirDestino.TabIndex = 29;
            btnAbrirDestino.Text = "Abrir Pasta do Destino";
            btnAbrirDestino.UseVisualStyleBackColor = true;
            btnAbrirDestino.Click += btnAbrirDestino_Click;
            // 
            // btnGerarPDF
            // 
            btnGerarPDF.BackgroundImageLayout = ImageLayout.None;
            btnGerarPDF.Cursor = Cursors.Hand;
            btnGerarPDF.FlatStyle = FlatStyle.Flat;
            btnGerarPDF.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerarPDF.ForeColor = Color.Lime;
            btnGerarPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerarPDF.Location = new Point(764, 16);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(224, 36);
            btnGerarPDF.TabIndex = 28;
            btnGerarPDF.Text = "Gerar Relatório em XLSX";
            btnGerarPDF.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGerarPDF.UseVisualStyleBackColor = true;
            btnGerarPDF.Click += btnGerarPDF_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnConsultarData);
            panel3.Controls.Add(dateTimePickerDia);
            panel3.Controls.Add(radioTudo);
            panel3.Controls.Add(groupBox4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnConsultar);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(radio30d);
            panel3.Controls.Add(radio3d);
            panel3.Controls.Add(listaMateriais);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 155);
            panel3.TabIndex = 29;
            // 
            // btnConsultarData
            // 
            btnConsultarData.Cursor = Cursors.Hand;
            btnConsultarData.FlatStyle = FlatStyle.Flat;
            btnConsultarData.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarData.ForeColor = Color.White;
            btnConsultarData.Location = new Point(765, 104);
            btnConsultarData.Name = "btnConsultarData";
            btnConsultarData.Size = new Size(223, 41);
            btnConsultarData.TabIndex = 40;
            btnConsultarData.Text = "CONSULTAR POR DATA";
            btnConsultarData.UseVisualStyleBackColor = true;
            btnConsultarData.Click += btnConsultarData_Click;
            // 
            // dateTimePickerDia
            // 
            dateTimePickerDia.Anchor = AnchorStyles.None;
            dateTimePickerDia.CalendarMonthBackground = Color.Lime;
            dateTimePickerDia.Cursor = Cursors.Hand;
            dateTimePickerDia.CustomFormat = "";
            dateTimePickerDia.DropDownAlign = LeftRightAlignment.Right;
            dateTimePickerDia.Font = new Font("Avignon Pro Demi", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerDia.Format = DateTimePickerFormat.Short;
            dateTimePickerDia.Location = new Point(764, 41);
            dateTimePickerDia.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateTimePickerDia.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dateTimePickerDia.Name = "dateTimePickerDia";
            dateTimePickerDia.Size = new Size(224, 40);
            dateTimePickerDia.TabIndex = 39;
            // 
            // radioTudo
            // 
            radioTudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioTudo.AutoSize = true;
            radioTudo.Cursor = Cursors.Hand;
            radioTudo.FlatStyle = FlatStyle.Flat;
            radioTudo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            radioTudo.ForeColor = Color.Lime;
            radioTudo.Location = new Point(647, 54);
            radioTudo.Name = "radioTudo";
            radioTudo.Size = new Size(112, 41);
            radioTudo.TabIndex = 27;
            radioTudo.TabStop = true;
            radioTudo.Text = "Tudo";
            radioTudo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Avignon Pro", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Gold;
            groupBox4.Location = new Point(9, 89);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(439, 57);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "Precisa de ajuda?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Avignon Pro", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 27);
            label4.Name = "label4";
            label4.Size = new Size(404, 19);
            label4.TabIndex = 27;
            label4.Text = "Chame o Desenvolvedor no WhatsApp: (11) 96351-2105";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(475, 3);
            label3.Name = "label3";
            label3.Size = new Size(495, 29);
            label3.TabIndex = 21;
            label3.Text = "Selecione o Período ou Selecione a Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 3);
            label2.Name = "label2";
            label2.Size = new Size(254, 29);
            label2.TabIndex = 20;
            label2.Text = "Selecione o Material";
            // 
            // radio30d
            // 
            radio30d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radio30d.AutoSize = true;
            radio30d.Cursor = Cursors.Hand;
            radio30d.FlatStyle = FlatStyle.Flat;
            radio30d.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            radio30d.ForeColor = Color.Lime;
            radio30d.Location = new Point(545, 54);
            radio30d.Name = "radio30d";
            radio30d.Size = new Size(96, 41);
            radio30d.TabIndex = 25;
            radio30d.TabStop = true;
            radio30d.Text = "30D";
            radio30d.UseVisualStyleBackColor = true;
            // 
            // radio3d
            // 
            radio3d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radio3d.AutoSize = true;
            radio3d.Cursor = Cursors.Hand;
            radio3d.FlatStyle = FlatStyle.Flat;
            radio3d.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            radio3d.ForeColor = Color.Lime;
            radio3d.Location = new Point(462, 54);
            radio3d.Name = "radio3d";
            radio3d.Size = new Size(77, 41);
            radio3d.TabIndex = 23;
            radio3d.TabStop = true;
            radio3d.Text = "3D";
            radio3d.UseVisualStyleBackColor = true;
            // 
            // listaMateriais
            // 
            listaMateriais.BackColor = Color.FromArgb(0, 40, 0);
            listaMateriais.Cursor = Cursors.Hand;
            listaMateriais.DropDownStyle = ComboBoxStyle.DropDownList;
            listaMateriais.FlatStyle = FlatStyle.Flat;
            listaMateriais.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            listaMateriais.ForeColor = Color.Lime;
            listaMateriais.FormattingEnabled = true;
            listaMateriais.IntegralHeight = false;
            listaMateriais.ItemHeight = 25;
            listaMateriais.Location = new Point(9, 40);
            listaMateriais.MaxDropDownItems = 15;
            listaMateriais.Name = "listaMateriais";
            listaMateriais.Size = new Size(439, 33);
            listaMateriais.TabIndex = 19;
            listaMateriais.DropDown += ListaMateriais_DropDown;
            // 
            // formRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1000, 722);
            Controls.Add(panel2);
            Controls.Add(listViewResultado);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formRelatorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formRelatorios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView listViewResultados;

        private Label label1;
        private Panel panel1;
        private Button btnFechar;
        private Button btnConsultar;
        private ListBox listBoxResultado;
        private ListView listViewResultado;
        private Label lbTotalCompra;
        private Panel panel2;
        private Button btnAbrirDestino;
        private Button btnGerarPDF;
        private GroupBox groupBox2;
        private Label lbTotalPeso;
        private GroupBox groupBox1;
        private Label lbMaisComprado;
        private GroupBox groupBox3;
        private Label label7;
        private Label lbTotalPesoMaterialMaisComprado;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private RadioButton radio30d;
        private ComboBox listaMateriais;
        private Button btnCancelar;
        private Button btnImprimir;
        private GroupBox groupBox4;
        private Label label4;
        private RadioButton radioTudo;
        private DateTimePicker dateTimePickerDia;
        private Button btnConsultarData;
        private RadioButton radio3d;
    }
}