namespace airksucata;

partial class formSistema
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    /*protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }*/

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSistema));
        panel1 = new Panel();
        btFechar = new Button();
        label7 = new Label();
        label1 = new Label();
        timer1 = new System.Windows.Forms.Timer(components);
        contextMenuStrip1 = new ContextMenuStrip(components);
        removerToolStripMenuItem_Click_1 = new ToolStripMenuItem();
        panel2 = new Panel();
        lbMax = new Label();
        logoPrincipal = new PictureBox();
        panel3 = new Panel();
        lbAcrescimo = new Label();
        label3 = new Label();
        label4 = new Label();
        valorKg = new Label();
        totalPagarLb = new Label();
        lbNomeCliente = new Label();
        lbQuantRegistros = new Label();
        panel9 = new Panel();
        nomeProduto = new Label();
        listaRegistrosListView = new ListView();
        btnReimprimir = new Button();
        btnVenda = new Button();
        btnInserir = new Button();
        btnAcrescimo = new Button();
        btnImprimir = new Button();
        btnInserirNome = new Button();
        btnAlterarNome = new Button();
        btnAtualizar = new Button();
        lbUpdate = new Label();
        label2 = new Label();
        label5 = new Label();
        btnConfig = new Button();
        pictureBox3 = new PictureBox();
        panel4 = new Panel();
        label8 = new Label();
        listRegistros = new ListView();
        pictureBox2 = new PictureBox();
        panel8 = new Panel();
        btnsMaterial = new Panel();
        labelRelogio = new Label();
        panel5 = new Panel();
        panel6 = new Panel();
        btnZerar = new Button();
        btn0 = new Button();
        btnCe = new Button();
        btnVirg = new Button();
        btn1 = new Button();
        btn3 = new Button();
        btn2 = new Button();
        btn4 = new Button();
        btn6 = new Button();
        btn5 = new Button();
        btn7 = new Button();
        btn9 = new Button();
        btn8 = new Button();
        txtPeso = new TextBox();
        panel12 = new Panel();
        lbVersion = new Label();
        label12 = new Label();
        pictureBox4 = new PictureBox();
        timer2 = new System.Windows.Forms.Timer(components);
        panel1.SuspendLayout();
        contextMenuStrip1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)logoPrincipal).BeginInit();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        panel8.SuspendLayout();
        panel5.SuspendLayout();
        panel6.SuspendLayout();
        panel12.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(btFechar);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1440, 36);
        panel1.TabIndex = 0;
        // 
        // btFechar
        // 
        btFechar.BackColor = Color.FromArgb(150, 0, 0);
        btFechar.Dock = DockStyle.Right;
        btFechar.FlatStyle = FlatStyle.Popup;
        btFechar.ForeColor = Color.White;
        btFechar.Location = new Point(1302, 0);
        btFechar.Name = "btFechar";
        btFechar.Size = new Size(138, 36);
        btFechar.TabIndex = 3;
        btFechar.Text = "[ X ] FECHAR";
        btFechar.UseVisualStyleBackColor = false;
        btFechar.Click += button1_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        label7.ForeColor = SystemColors.ScrollBar;
        label7.Location = new Point(979, 11);
        label7.Name = "label7";
        label7.Size = new Size(293, 15);
        label7.TabIndex = 2;
        label7.Text = "Precisa de ajuda? Chame no WhatsApp: 11 96351-2105";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.Lime;
        label1.Location = new Point(5, 8);
        label1.Name = "label1";
        label1.Size = new Size(429, 18);
        label1.TabIndex = 1;
        label1.Text = "SISTEMA DE CONTROLE PARA SUCATAS - BY AIRK DIGITAL";
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Items.AddRange(new ToolStripItem[] { removerToolStripMenuItem_Click_1 });
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(122, 26);
        // 
        // removerToolStripMenuItem_Click_1
        // 
        removerToolStripMenuItem_Click_1.Name = "removerToolStripMenuItem_Click_1";
        removerToolStripMenuItem_Click_1.Size = new Size(121, 22);
        removerToolStripMenuItem_Click_1.Text = "Remover";
        // 
        // panel2
        // 
        panel2.Controls.Add(lbMax);
        panel2.Controls.Add(logoPrincipal);
        panel2.Controls.Add(panel3);
        panel2.Controls.Add(btnReimprimir);
        panel2.Controls.Add(btnVenda);
        panel2.Controls.Add(btnInserir);
        panel2.Controls.Add(btnAcrescimo);
        panel2.Controls.Add(btnImprimir);
        panel2.Controls.Add(btnInserirNome);
        panel2.Controls.Add(btnAlterarNome);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 36);
        panel2.Name = "panel2";
        panel2.Size = new Size(1440, 158);
        panel2.TabIndex = 27;
        // 
        // lbMax
        // 
        lbMax.Anchor = AnchorStyles.Top;
        lbMax.AutoSize = true;
        lbMax.BackColor = Color.Red;
        lbMax.Font = new Font("Arial", 11.75F, FontStyle.Bold, GraphicsUnit.Point);
        lbMax.ForeColor = Color.White;
        lbMax.Location = new Point(907, 27);
        lbMax.Name = "lbMax";
        lbMax.Padding = new Padding(5);
        lbMax.Size = new Size(150, 29);
        lbMax.TabIndex = 30;
        lbMax.Text = "LIMITE ATINGIDO";
        lbMax.TextAlign = ContentAlignment.MiddleCenter;
        lbMax.Visible = false;
        // 
        // logoPrincipal
        // 
        logoPrincipal.Image = Properties.Resources.logo3;
        logoPrincipal.Location = new Point(4, 1);
        logoPrincipal.Name = "logoPrincipal";
        logoPrincipal.Size = new Size(117, 147);
        logoPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
        logoPrincipal.TabIndex = 29;
        logoPrincipal.TabStop = false;
        // 
        // panel3
        // 
        panel3.Controls.Add(lbAcrescimo);
        panel3.Controls.Add(label3);
        panel3.Controls.Add(label4);
        panel3.Controls.Add(valorKg);
        panel3.Controls.Add(totalPagarLb);
        panel3.Controls.Add(lbNomeCliente);
        panel3.Controls.Add(lbQuantRegistros);
        panel3.Controls.Add(panel9);
        panel3.Controls.Add(nomeProduto);
        panel3.Controls.Add(listaRegistrosListView);
        panel3.Location = new Point(122, 1);
        panel3.Name = "panel3";
        panel3.Size = new Size(756, 156);
        panel3.TabIndex = 28;
        // 
        // lbAcrescimo
        // 
        lbAcrescimo.Anchor = AnchorStyles.Right;
        lbAcrescimo.AutoSize = true;
        lbAcrescimo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
        lbAcrescimo.ForeColor = Color.LightGreen;
        lbAcrescimo.Location = new Point(424, 103);
        lbAcrescimo.Name = "lbAcrescimo";
        lbAcrescimo.Size = new Size(97, 18);
        lbAcrescimo.TabIndex = 30;
        lbAcrescimo.Text = "+ R$ 0,00/kg";
        lbAcrescimo.Visible = false;
        lbAcrescimo.TextChanged += lbAcrescimo_TextChanged;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.White;
        label3.Location = new Point(428, 50);
        label3.Name = "label3";
        label3.Size = new Size(81, 16);
        label3.TabIndex = 4;
        label3.Text = "Valor por KG";
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.White;
        label4.Location = new Point(569, 50);
        label4.Name = "label4";
        label4.Size = new Size(83, 16);
        label4.TabIndex = 5;
        label4.Text = "Total à Pagar";
        // 
        // valorKg
        // 
        valorKg.Anchor = AnchorStyles.Right;
        valorKg.AutoSize = true;
        valorKg.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point);
        valorKg.ForeColor = Color.White;
        valorKg.Location = new Point(422, 68);
        valorKg.Name = "valorKg";
        valorKg.Size = new Size(102, 30);
        valorKg.TabIndex = 6;
        valorKg.Text = "R$ 0,00";
        // 
        // totalPagarLb
        // 
        totalPagarLb.Anchor = AnchorStyles.Right;
        totalPagarLb.AutoSize = true;
        totalPagarLb.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point);
        totalPagarLb.ForeColor = Color.Lime;
        totalPagarLb.Location = new Point(563, 67);
        totalPagarLb.Name = "totalPagarLb";
        totalPagarLb.Size = new Size(102, 30);
        totalPagarLb.TabIndex = 7;
        totalPagarLb.Text = "R$ 0,00";
        // 
        // lbNomeCliente
        // 
        lbNomeCliente.Anchor = AnchorStyles.Right;
        lbNomeCliente.AutoSize = true;
        lbNomeCliente.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        lbNomeCliente.ForeColor = Color.LightGreen;
        lbNomeCliente.Location = new Point(427, 130);
        lbNomeCliente.Name = "lbNomeCliente";
        lbNomeCliente.Size = new Size(63, 17);
        lbNomeCliente.TabIndex = 31;
        lbNomeCliente.Text = "# NOME";
        lbNomeCliente.Visible = false;
        // 
        // lbQuantRegistros
        // 
        lbQuantRegistros.Anchor = AnchorStyles.Right;
        lbQuantRegistros.AutoSize = true;
        lbQuantRegistros.BackColor = Color.FromArgb(20, 20, 20);
        lbQuantRegistros.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lbQuantRegistros.ForeColor = Color.Gold;
        lbQuantRegistros.Location = new Point(401, 5);
        lbQuantRegistros.Name = "lbQuantRegistros";
        lbQuantRegistros.Size = new Size(17, 19);
        lbQuantRegistros.TabIndex = 29;
        lbQuantRegistros.Text = "0";
        // 
        // panel9
        // 
        panel9.Anchor = AnchorStyles.Right;
        panel9.BackColor = Color.Lime;
        panel9.Location = new Point(425, 38);
        panel9.Name = "panel9";
        panel9.Size = new Size(330, 3);
        panel9.TabIndex = 15;
        // 
        // nomeProduto
        // 
        nomeProduto.Anchor = AnchorStyles.Right;
        nomeProduto.AutoSize = true;
        nomeProduto.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
        nomeProduto.ForeColor = Color.Lime;
        nomeProduto.Location = new Point(426, 4);
        nomeProduto.Name = "nomeProduto";
        nomeProduto.Size = new Size(221, 29);
        nomeProduto.TabIndex = 1;
        nomeProduto.Text = "Nome do Material";
        nomeProduto.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // listaRegistrosListView
        // 
        listaRegistrosListView.Anchor = AnchorStyles.Right;
        listaRegistrosListView.BackColor = Color.FromArgb(20, 20, 20);
        listaRegistrosListView.BorderStyle = BorderStyle.None;
        listaRegistrosListView.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
        listaRegistrosListView.ForeColor = Color.White;
        listaRegistrosListView.Location = new Point(-2, 3);
        listaRegistrosListView.Name = "listaRegistrosListView";
        listaRegistrosListView.Size = new Size(423, 147);
        listaRegistrosListView.TabIndex = 12;
        listaRegistrosListView.UseCompatibleStateImageBehavior = false;
        listaRegistrosListView.DoubleClick += listaRegistrosListView_DoubleClick;
        // 
        // btnReimprimir
        // 
        btnReimprimir.Anchor = AnchorStyles.Right;
        btnReimprimir.BackColor = Color.FromArgb(80, 80, 0);
        btnReimprimir.Cursor = Cursors.Hand;
        btnReimprimir.FlatStyle = FlatStyle.Flat;
        btnReimprimir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnReimprimir.ForeColor = Color.Gold;
        btnReimprimir.Image = Properties.Resources.REPRINT;
        btnReimprimir.ImageAlign = ContentAlignment.TopCenter;
        btnReimprimir.Location = new Point(1305, 2);
        btnReimprimir.Name = "btnReimprimir";
        btnReimprimir.Padding = new Padding(0, 0, 0, 3);
        btnReimprimir.Size = new Size(132, 75);
        btnReimprimir.TabIndex = 32;
        btnReimprimir.Text = "Reimprimir";
        btnReimprimir.TextAlign = ContentAlignment.BottomCenter;
        btnReimprimir.UseVisualStyleBackColor = false;
        btnReimprimir.Click += btnReimprimir_Click;
        // 
        // btnVenda
        // 
        btnVenda.Anchor = AnchorStyles.Right;
        btnVenda.BackColor = Color.FromArgb(0, 30, 0);
        btnVenda.Cursor = Cursors.Hand;
        btnVenda.FlatStyle = FlatStyle.Flat;
        btnVenda.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnVenda.ForeColor = Color.Lime;
        btnVenda.Image = Properties.Resources.buy21;
        btnVenda.ImageAlign = ContentAlignment.TopCenter;
        btnVenda.Location = new Point(1305, 79);
        btnVenda.Name = "btnVenda";
        btnVenda.Padding = new Padding(0, 5, 0, 3);
        btnVenda.Size = new Size(132, 75);
        btnVenda.TabIndex = 27;
        btnVenda.Text = "+1 Venda";
        btnVenda.TextAlign = ContentAlignment.BottomCenter;
        btnVenda.UseVisualStyleBackColor = false;
        btnVenda.Click += btnVenda_Click;
        // 
        // btnInserir
        // 
        btnInserir.Anchor = AnchorStyles.Top;
        btnInserir.BackColor = Color.FromArgb(80, 80, 80);
        btnInserir.Cursor = Cursors.Hand;
        btnInserir.FlatStyle = FlatStyle.Flat;
        btnInserir.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        btnInserir.ForeColor = Color.Gainsboro;
        btnInserir.Image = Properties.Resources.add2;
        btnInserir.ImageAlign = ContentAlignment.MiddleRight;
        btnInserir.Location = new Point(880, 2);
        btnInserir.Name = "btnInserir";
        btnInserir.Padding = new Padding(10, 0, 15, 0);
        btnInserir.Size = new Size(210, 75);
        btnInserir.TabIndex = 30;
        btnInserir.Text = "Inserir +1";
        btnInserir.TextAlign = ContentAlignment.MiddleLeft;
        btnInserir.UseVisualStyleBackColor = false;
        btnInserir.Click += btnInserir_Click;
        // 
        // btnAcrescimo
        // 
        btnAcrescimo.Anchor = AnchorStyles.Top;
        btnAcrescimo.BackColor = Color.FromArgb(30, 30, 30);
        btnAcrescimo.Cursor = Cursors.Hand;
        btnAcrescimo.Enabled = false;
        btnAcrescimo.FlatStyle = FlatStyle.Flat;
        btnAcrescimo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        btnAcrescimo.ForeColor = Color.LightGreen;
        btnAcrescimo.Image = Properties.Resources.acrescimo;
        btnAcrescimo.ImageAlign = ContentAlignment.MiddleRight;
        btnAcrescimo.Location = new Point(880, 79);
        btnAcrescimo.Name = "btnAcrescimo";
        btnAcrescimo.Padding = new Padding(10, 0, 15, 0);
        btnAcrescimo.Size = new Size(210, 75);
        btnAcrescimo.TabIndex = 33;
        btnAcrescimo.Text = "Acréscimo";
        btnAcrescimo.TextAlign = ContentAlignment.MiddleLeft;
        btnAcrescimo.UseVisualStyleBackColor = false;
        btnAcrescimo.Click += btnAcrescimo_Click;
        // 
        // btnImprimir
        // 
        btnImprimir.Anchor = AnchorStyles.Top;
        btnImprimir.BackColor = Color.FromArgb(0, 60, 0);
        btnImprimir.Cursor = Cursors.Hand;
        btnImprimir.FlatStyle = FlatStyle.Flat;
        btnImprimir.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        btnImprimir.ForeColor = Color.Lime;
        btnImprimir.Image = Properties.Resources.print2;
        btnImprimir.ImageAlign = ContentAlignment.MiddleRight;
        btnImprimir.Location = new Point(1092, 2);
        btnImprimir.Name = "btnImprimir";
        btnImprimir.Padding = new Padding(10, 0, 15, 0);
        btnImprimir.Size = new Size(210, 75);
        btnImprimir.TabIndex = 31;
        btnImprimir.Text = "Imprimir";
        btnImprimir.TextAlign = ContentAlignment.MiddleLeft;
        btnImprimir.UseVisualStyleBackColor = false;
        btnImprimir.Click += btnImprimir_Click;
        // 
        // btnInserirNome
        // 
        btnInserirNome.Anchor = AnchorStyles.Top;
        btnInserirNome.BackColor = Color.FromArgb(30, 30, 30);
        btnInserirNome.Cursor = Cursors.Hand;
        btnInserirNome.Enabled = false;
        btnInserirNome.FlatStyle = FlatStyle.Flat;
        btnInserirNome.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        btnInserirNome.ForeColor = Color.Khaki;
        btnInserirNome.Image = Properties.Resources.name1;
        btnInserirNome.ImageAlign = ContentAlignment.MiddleRight;
        btnInserirNome.Location = new Point(1092, 79);
        btnInserirNome.Name = "btnInserirNome";
        btnInserirNome.Padding = new Padding(10, 0, 15, 0);
        btnInserirNome.Size = new Size(210, 75);
        btnInserirNome.TabIndex = 34;
        btnInserirNome.Text = "Inserir Nome";
        btnInserirNome.TextAlign = ContentAlignment.MiddleLeft;
        btnInserirNome.UseVisualStyleBackColor = false;
        btnInserirNome.Click += btnInserirNome_Click;
        // 
        // btnAlterarNome
        // 
        btnAlterarNome.Anchor = AnchorStyles.Top;
        btnAlterarNome.Cursor = Cursors.Hand;
        btnAlterarNome.FlatStyle = FlatStyle.Flat;
        btnAlterarNome.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        btnAlterarNome.ForeColor = Color.Red;
        btnAlterarNome.Location = new Point(1092, 79);
        btnAlterarNome.Name = "btnAlterarNome";
        btnAlterarNome.Size = new Size(210, 75);
        btnAlterarNome.TabIndex = 35;
        btnAlterarNome.Text = "Editar Nome";
        btnAlterarNome.UseVisualStyleBackColor = true;
        btnAlterarNome.Visible = false;
        btnAlterarNome.Click += btnInserirNome_Click;
        // 
        // btnAtualizar
        // 
        btnAtualizar.Anchor = AnchorStyles.Right;
        btnAtualizar.BackColor = Color.FromArgb(30, 30, 30);
        btnAtualizar.Cursor = Cursors.Hand;
        btnAtualizar.FlatStyle = FlatStyle.Flat;
        btnAtualizar.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
        btnAtualizar.ForeColor = Color.Goldenrod;
        btnAtualizar.Image = Properties.Resources.refresh3;
        btnAtualizar.ImageAlign = ContentAlignment.MiddleRight;
        btnAtualizar.Location = new Point(394, 5);
        btnAtualizar.Name = "btnAtualizar";
        btnAtualizar.Padding = new Padding(15, 0, 20, 0);
        btnAtualizar.Size = new Size(210, 73);
        btnAtualizar.TabIndex = 30;
        btnAtualizar.Text = "Atualizar Tudo";
        btnAtualizar.TextAlign = ContentAlignment.MiddleLeft;
        btnAtualizar.TextImageRelation = TextImageRelation.TextBeforeImage;
        btnAtualizar.UseVisualStyleBackColor = false;
        btnAtualizar.Click += RefreshButton_Click;
        // 
        // lbUpdate
        // 
        lbUpdate.AutoSize = true;
        lbUpdate.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
        lbUpdate.ForeColor = Color.FromArgb(120, 120, 120);
        lbUpdate.Location = new Point(396, 167);
        lbUpdate.Name = "lbUpdate";
        lbUpdate.Size = new Size(301, 17);
        lbUpdate.TabIndex = 39;
        lbUpdate.Text = "Última Atualização Oficial: 30/11/2023 - 14:25";
        lbUpdate.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        label2.ForeColor = Color.White;
        label2.Location = new Point(106, 565);
        label2.Name = "label2";
        label2.Size = new Size(282, 46);
        label2.TabIndex = 40;
        label2.Text = "AIRK DIGITAL";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial", 14F, FontStyle.Italic, GraphicsUnit.Point);
        label5.ForeColor = Color.Gold;
        label5.Location = new Point(108, 545);
        label5.Name = "label5";
        label5.Size = new Size(176, 23);
        label5.TabIndex = 34;
        label5.Text = "Uso Autorizado por\r\n";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnConfig
        // 
        btnConfig.Anchor = AnchorStyles.Right;
        btnConfig.BackColor = Color.FromArgb(60, 60, 60);
        btnConfig.BackgroundImageLayout = ImageLayout.Zoom;
        btnConfig.Cursor = Cursors.Hand;
        btnConfig.FlatAppearance.BorderSize = 0;
        btnConfig.FlatStyle = FlatStyle.Flat;
        btnConfig.Font = new Font("Arial", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
        btnConfig.ForeColor = Color.Lime;
        btnConfig.Image = Properties.Resources.config;
        btnConfig.ImageAlign = ContentAlignment.MiddleRight;
        btnConfig.Location = new Point(606, 5);
        btnConfig.Name = "btnConfig";
        btnConfig.Padding = new Padding(10, 0, 20, 0);
        btnConfig.RightToLeft = RightToLeft.No;
        btnConfig.Size = new Size(211, 73);
        btnConfig.TabIndex = 30;
        btnConfig.Text = "Configurações";
        btnConfig.TextAlign = ContentAlignment.MiddleLeft;
        btnConfig.TextImageRelation = TextImageRelation.TextBeforeImage;
        btnConfig.UseVisualStyleBackColor = false;
        btnConfig.Click += btnConfig_Click;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = Properties.Resources.certified3;
        pictureBox3.Location = new Point(12, 524);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(98, 112);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 37;
        pictureBox3.TabStop = false;
        // 
        // panel4
        // 
        panel4.Controls.Add(label8);
        panel4.Controls.Add(listRegistros);
        panel4.Controls.Add(pictureBox2);
        panel4.Controls.Add(panel8);
        panel4.Controls.Add(lbUpdate);
        panel4.Controls.Add(labelRelogio);
        panel4.Controls.Add(label2);
        panel4.Controls.Add(label5);
        panel4.Controls.Add(btnAtualizar);
        panel4.Controls.Add(pictureBox3);
        panel4.Controls.Add(panel5);
        panel4.Controls.Add(btnConfig);
        panel4.Dock = DockStyle.Top;
        panel4.Location = new Point(0, 194);
        panel4.Name = "panel4";
        panel4.Size = new Size(1440, 668);
        panel4.TabIndex = 28;
        // 
        // label8
        // 
        label8.Anchor = AnchorStyles.Top;
        label8.AutoSize = true;
        label8.Font = new Font("Avignon Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
        label8.ForeColor = Color.Lime;
        label8.Location = new Point(1338, -1);
        label8.Name = "label8";
        label8.Size = new Size(99, 14);
        label8.TabIndex = 29;
        label8.Text = "Últimos Registros:";
        // 
        // listRegistros
        // 
        listRegistros.Anchor = AnchorStyles.Top;
        listRegistros.BackColor = Color.FromArgb(20, 20, 20);
        listRegistros.BorderStyle = BorderStyle.None;
        listRegistros.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
        listRegistros.ForeColor = Color.Lime;
        listRegistros.Location = new Point(819, 13);
        listRegistros.Name = "listRegistros";
        listRegistros.Size = new Size(618, 175);
        listRegistros.TabIndex = 33;
        listRegistros.UseCompatibleStateImageBehavior = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.clock;
        pictureBox2.Location = new Point(413, 100);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(51, 43);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 33;
        pictureBox2.TabStop = false;
        // 
        // panel8
        // 
        panel8.BackColor = Color.FromArgb(50, 0, 0);
        panel8.Controls.Add(btnsMaterial);
        panel8.Location = new Point(395, 191);
        panel8.Name = "panel8";
        panel8.Size = new Size(1040, 479);
        panel8.TabIndex = 29;
        // 
        // btnsMaterial
        // 
        btnsMaterial.BackColor = Color.FromArgb(30, 30, 30);
        btnsMaterial.Dock = DockStyle.Fill;
        btnsMaterial.Location = new Point(0, 0);
        btnsMaterial.Name = "btnsMaterial";
        btnsMaterial.Size = new Size(1040, 479);
        btnsMaterial.TabIndex = 22;
        // 
        // labelRelogio
        // 
        labelRelogio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        labelRelogio.AutoSize = true;
        labelRelogio.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        labelRelogio.ForeColor = Color.Lime;
        labelRelogio.Location = new Point(473, 105);
        labelRelogio.Name = "labelRelogio";
        labelRelogio.Size = new Size(617, 32);
        labelRelogio.TabIndex = 31;
        labelRelogio.Text = "DateTime.Now.ToString(\"dd/MM/yyyy HH:mm:ss\")";
        // 
        // panel5
        // 
        panel5.Controls.Add(panel6);
        panel5.Controls.Add(txtPeso);
        panel5.Location = new Point(7, 5);
        panel5.Name = "panel5";
        panel5.Size = new Size(384, 484);
        panel5.TabIndex = 27;
        // 
        // panel6
        // 
        panel6.Controls.Add(btnZerar);
        panel6.Controls.Add(btn0);
        panel6.Controls.Add(btnCe);
        panel6.Controls.Add(btnVirg);
        panel6.Controls.Add(btn1);
        panel6.Controls.Add(btn3);
        panel6.Controls.Add(btn2);
        panel6.Controls.Add(btn4);
        panel6.Controls.Add(btn6);
        panel6.Controls.Add(btn5);
        panel6.Controls.Add(btn7);
        panel6.Controls.Add(btn9);
        panel6.Controls.Add(btn8);
        panel6.Location = new Point(3, 74);
        panel6.Name = "panel6";
        panel6.Size = new Size(381, 407);
        panel6.TabIndex = 8;
        // 
        // btnZerar
        // 
        btnZerar.Cursor = Cursors.Hand;
        btnZerar.Dock = DockStyle.Bottom;
        btnZerar.FlatStyle = FlatStyle.Flat;
        btnZerar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
        btnZerar.ForeColor = Color.Gold;
        btnZerar.Location = new Point(0, 328);
        btnZerar.Name = "btnZerar";
        btnZerar.Size = new Size(381, 79);
        btnZerar.TabIndex = 17;
        btnZerar.Text = "ZERAR BALANÇA";
        btnZerar.UseVisualStyleBackColor = true;
        btnZerar.Click += btnZerar_Click_1;
        btnZerar.MouseCaptureChanged += btnZerar_Click;
        // 
        // btn0
        // 
        btn0.Cursor = Cursors.Hand;
        btn0.FlatStyle = FlatStyle.Flat;
        btn0.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn0.ForeColor = Color.White;
        btn0.Location = new Point(1, 248);
        btn0.Name = "btn0";
        btn0.Size = new Size(125, 77);
        btn0.TabIndex = 14;
        btn0.Text = "0";
        btn0.UseVisualStyleBackColor = true;
        btn0.Click += btn0_Click;
        // 
        // btnCe
        // 
        btnCe.Cursor = Cursors.Hand;
        btnCe.FlatStyle = FlatStyle.Flat;
        btnCe.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btnCe.ForeColor = Color.Red;
        btnCe.Location = new Point(253, 248);
        btnCe.Name = "btnCe";
        btnCe.Size = new Size(125, 77);
        btnCe.TabIndex = 16;
        btnCe.Text = "C";
        btnCe.UseVisualStyleBackColor = true;
        btnCe.Click += btnCe_Click;
        // 
        // btnVirg
        // 
        btnVirg.Cursor = Cursors.Hand;
        btnVirg.FlatStyle = FlatStyle.Flat;
        btnVirg.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btnVirg.ForeColor = Color.White;
        btnVirg.Location = new Point(127, 248);
        btnVirg.Name = "btnVirg";
        btnVirg.Size = new Size(125, 77);
        btnVirg.TabIndex = 15;
        btnVirg.Text = ",";
        btnVirg.UseVisualStyleBackColor = true;
        btnVirg.Click += btnVirg_Click;
        // 
        // btn1
        // 
        btn1.Cursor = Cursors.Hand;
        btn1.FlatStyle = FlatStyle.Flat;
        btn1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn1.ForeColor = Color.White;
        btn1.Location = new Point(1, 170);
        btn1.Name = "btn1";
        btn1.Size = new Size(125, 77);
        btn1.TabIndex = 11;
        btn1.Text = "1";
        btn1.UseVisualStyleBackColor = true;
        btn1.Click += btn1_Click;
        // 
        // btn3
        // 
        btn3.Cursor = Cursors.Hand;
        btn3.FlatStyle = FlatStyle.Flat;
        btn3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn3.ForeColor = Color.White;
        btn3.Location = new Point(253, 170);
        btn3.Name = "btn3";
        btn3.Size = new Size(125, 77);
        btn3.TabIndex = 13;
        btn3.Text = "3";
        btn3.UseVisualStyleBackColor = true;
        btn3.Click += btn3_Click;
        // 
        // btn2
        // 
        btn2.Cursor = Cursors.Hand;
        btn2.FlatStyle = FlatStyle.Flat;
        btn2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn2.ForeColor = Color.White;
        btn2.Location = new Point(127, 170);
        btn2.Name = "btn2";
        btn2.Size = new Size(125, 77);
        btn2.TabIndex = 12;
        btn2.Text = "2";
        btn2.UseVisualStyleBackColor = true;
        btn2.Click += btn2_Click;
        // 
        // btn4
        // 
        btn4.Cursor = Cursors.Hand;
        btn4.FlatStyle = FlatStyle.Flat;
        btn4.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn4.ForeColor = Color.White;
        btn4.Location = new Point(1, 92);
        btn4.Name = "btn4";
        btn4.Size = new Size(125, 77);
        btn4.TabIndex = 8;
        btn4.Text = "4";
        btn4.UseVisualStyleBackColor = true;
        btn4.Click += btn4_Click;
        // 
        // btn6
        // 
        btn6.Cursor = Cursors.Hand;
        btn6.FlatStyle = FlatStyle.Flat;
        btn6.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn6.ForeColor = Color.White;
        btn6.Location = new Point(253, 92);
        btn6.Name = "btn6";
        btn6.Size = new Size(125, 77);
        btn6.TabIndex = 10;
        btn6.Text = "6";
        btn6.UseVisualStyleBackColor = true;
        btn6.Click += btn6_Click;
        // 
        // btn5
        // 
        btn5.Cursor = Cursors.Hand;
        btn5.FlatStyle = FlatStyle.Flat;
        btn5.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn5.ForeColor = Color.White;
        btn5.Location = new Point(127, 92);
        btn5.Name = "btn5";
        btn5.Size = new Size(125, 77);
        btn5.TabIndex = 9;
        btn5.Text = "5";
        btn5.UseVisualStyleBackColor = true;
        btn5.Click += btn5_Click;
        // 
        // btn7
        // 
        btn7.Cursor = Cursors.Hand;
        btn7.FlatStyle = FlatStyle.Flat;
        btn7.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn7.ForeColor = Color.White;
        btn7.Location = new Point(1, 14);
        btn7.Name = "btn7";
        btn7.Size = new Size(125, 77);
        btn7.TabIndex = 5;
        btn7.Text = "7";
        btn7.UseVisualStyleBackColor = true;
        btn7.Click += btn7_Click;
        // 
        // btn9
        // 
        btn9.Cursor = Cursors.Hand;
        btn9.FlatStyle = FlatStyle.Flat;
        btn9.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn9.ForeColor = Color.White;
        btn9.Location = new Point(253, 14);
        btn9.Name = "btn9";
        btn9.Size = new Size(125, 77);
        btn9.TabIndex = 7;
        btn9.Text = "9";
        btn9.UseVisualStyleBackColor = true;
        btn9.Click += btn9_Click;
        // 
        // btn8
        // 
        btn8.Cursor = Cursors.Hand;
        btn8.FlatStyle = FlatStyle.Flat;
        btn8.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
        btn8.ForeColor = Color.White;
        btn8.Location = new Point(127, 14);
        btn8.Name = "btn8";
        btn8.Size = new Size(125, 77);
        btn8.TabIndex = 6;
        btn8.Text = "8";
        btn8.UseVisualStyleBackColor = true;
        btn8.Click += btn8_Click;
        // 
        // txtPeso
        // 
        txtPeso.BackColor = Color.FromArgb(0, 60, 0);
        txtPeso.BorderStyle = BorderStyle.None;
        txtPeso.Dock = DockStyle.Top;
        txtPeso.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point);
        txtPeso.ForeColor = Color.Lime;
        txtPeso.Location = new Point(0, 0);
        txtPeso.Name = "txtPeso";
        txtPeso.PlaceholderText = "0,000";
        txtPeso.Size = new Size(384, 73);
        txtPeso.TabIndex = 4;
        txtPeso.TextAlign = HorizontalAlignment.Center;
        txtPeso.TextChanged += txtPeso_TextChanged;
        // 
        // panel12
        // 
        panel12.BackColor = Color.FromArgb(0, 40, 0);
        panel12.Controls.Add(lbVersion);
        panel12.Controls.Add(label12);
        panel12.Controls.Add(pictureBox4);
        panel12.Dock = DockStyle.Bottom;
        panel12.Location = new Point(0, 865);
        panel12.Name = "panel12";
        panel12.Size = new Size(1440, 35);
        panel12.TabIndex = 29;
        // 
        // lbVersion
        // 
        lbVersion.AutoSize = true;
        lbVersion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        lbVersion.ForeColor = Color.Lime;
        lbVersion.Location = new Point(1344, 9);
        lbVersion.Name = "lbVersion";
        lbVersion.Size = new Size(84, 16);
        lbVersion.TabIndex = 45;
        lbVersion.Text = "Versão: 5.0.9";
        lbVersion.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
        label12.ForeColor = Color.White;
        label12.Location = new Point(118, 10);
        label12.Name = "label12";
        label12.Size = new Size(770, 15);
        label12.TabIndex = 44;
        label12.Text = "Airk Digital © Todos os Direitos Reservados - Sistema de Uso Exclusivo e Autorizado - Evite golpes, contrate somente com o desenvolvedor.";
        label12.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pictureBox4
        // 
        pictureBox4.Image = Properties.Resources.logowhite2;
        pictureBox4.Location = new Point(0, 3);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(85, 29);
        pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox4.TabIndex = 41;
        pictureBox4.TabStop = false;
        // 
        // timer2
        // 
        timer2.Enabled = true;
        timer2.Interval = 300;
        timer2.Tick += timer2_Tick;
        // 
        // formSistema
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(30, 30, 30);
        ClientSize = new Size(1440, 900);
        ControlBox = false;
        Controls.Add(panel12);
        Controls.Add(panel4);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "formSistema";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AIRK Sistema de Controle v508";
        Load += formSistema_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        contextMenuStrip1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)logoPrincipal).EndInit();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        panel8.ResumeLayout(false);
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        panel6.ResumeLayout(false);
        panel12.ResumeLayout(false);
        panel12.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Label label7;
    private System.Windows.Forms.Timer timer1;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem removerToolStripMenuItem_Click_1;
    private Button btFechar;
    private Panel panel2;
    private Button btnAtualizar;
    private PictureBox logoPrincipal;
    private Panel panel3;
    private Label nomeProduto;
    private Label label3;
    private ListView listaRegistrosListView;
    private Label label4;
    private Label valorKg;
    private Label totalPagarLb;
    private Panel panel4;
    private Button btnConfig;
    private Label labelRelogio;
    private Button btnVenda;
    private Panel panel5;
    private Button btnZerar;
    private Panel panel6;
    private Button btn0;
    private Button btnCe;
    private Button btnVirg;
    private Button btn1;
    private Button btn3;
    private Button btn2;
    private Button btn4;
    private Button btn6;
    private Button btn5;
    private Button btn7;
    private Button btn9;
    private Button btn8;
    private TextBox txtPeso;
    private Panel btnsMaterial;
    private Panel panel8;
    private Button btnImprimir;
    private Button btnInserir;
    private Panel panel9;
    private Button btnReimprimir;
    private PictureBox pictureBox2;
    private Label label5;
    private PictureBox pictureBox3;
    private Label lbUpdate;
    private Panel panel12;
    private Label lbVersion;
    private Label label12;
    private Label label2;
    private PictureBox pictureBox4;
    private Label lbQuantRegistros;
    private Label lbMax;
    private Label lbAcrescimo;
    private Button btnAcrescimo;
    private Label lbNomeCliente;
    private System.Windows.Forms.Timer timer2;
    private Button btnInserirNome;
    private Button btnAlterarNome;
    private Label label8;
    private ListView listRegistros;

    //public EventHandler btnReimprimir_Click { get; private set; }
    public EventHandler btnVenda_Click_1 { get; private set; }
}