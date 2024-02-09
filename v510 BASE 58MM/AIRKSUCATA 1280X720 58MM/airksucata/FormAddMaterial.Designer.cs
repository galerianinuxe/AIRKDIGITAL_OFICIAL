namespace airksucata
{
    partial class FormAddMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMaterial));
            panel1 = new Panel();
            btnFechar = new Button();
            label1 = new Label();
            txtNomematerial = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtValorkg = new TextBox();
            btnAddValor01 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            button1 = new Button();
            panel3 = new Panel();
            btnTraço = new Button();
            btnPonto = new Button();
            btnNum9 = new Button();
            btnNum8 = new Button();
            btnNum7 = new Button();
            btnNum6 = new Button();
            a = new Button();
            btnNum4 = new Button();
            btnNum3 = new Button();
            btnNum2 = new Button();
            btnNum1 = new Button();
            btnNum0 = new Button();
            btnDelete = new Button();
            btnSpace = new Button();
            btnÇ = new Button();
            btnP = new Button();
            btnM = new Button();
            btnN = new Button();
            btnB = new Button();
            btnV = new Button();
            btnC = new Button();
            btnX = new Button();
            btnZ = new Button();
            btnL = new Button();
            btnK = new Button();
            btnJ = new Button();
            btnH = new Button();
            btnG = new Button();
            btnF = new Button();
            btnD = new Button();
            btnS = new Button();
            btnA = new Button();
            btnO = new Button();
            btnI = new Button();
            btnU = new Button();
            btnY = new Button();
            btnT = new Button();
            btnR = new Button();
            btnE = new Button();
            btnW = new Button();
            btnQ = new Button();
            label5 = new Label();
            btnSalvar = new Button();
            btnCorrigir = new Button();
            btnZerar = new Button();
            btnAddValor1000 = new Button();
            btnAddValor500 = new Button();
            btnAddValor100 = new Button();
            btnAddValor50 = new Button();
            btnAddValor10 = new Button();
            label4 = new Label();
            btnsMateriais2 = new Panel();
            timerUpdateValues = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(1280, 49);
            panel1.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Dock = DockStyle.Right;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(1182, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(98, 49);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(812, 9);
            label1.Name = "label1";
            label1.Size = new Size(364, 29);
            label1.TabIndex = 1;
            label1.Text = "Editar Informações dos Materiais";
            // 
            // txtNomematerial
            // 
            txtNomematerial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNomematerial.BorderStyle = BorderStyle.FixedSingle;
            txtNomematerial.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomematerial.Location = new Point(26, 55);
            txtNomematerial.Name = "txtNomematerial";
            txtNomematerial.PlaceholderText = "Nome do Material";
            txtNomematerial.ReadOnly = true;
            txtNomematerial.Size = new Size(430, 39);
            txtNomematerial.TabIndex = 2;
            txtNomematerial.TabStop = false;
            txtNomematerial.TextAlign = HorizontalAlignment.Center;
            txtNomematerial.Leave += txtNomematerial_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(26, 22);
            label2.Name = "label2";
            label2.Size = new Size(235, 26);
            label2.TabIndex = 3;
            label2.Text = "Material Selecionado";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label3.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(608, 8);
            label3.Name = "label3";
            label3.Size = new Size(228, 39);
            label3.TabIndex = 5;
            label3.Text = "Valor por KG";
            // 
            // txtValorkg
            // 
            txtValorkg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtValorkg.BorderStyle = BorderStyle.None;
            txtValorkg.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            txtValorkg.Location = new Point(646, 51);
            txtValorkg.Name = "txtValorkg";
            txtValorkg.PlaceholderText = "00,00";
            txtValorkg.Size = new Size(179, 46);
            txtValorkg.TabIndex = 4;
            txtValorkg.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddValor01
            // 
            btnAddValor01.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddValor01.BackColor = Color.FromArgb(0, 80, 0);
            btnAddValor01.Cursor = Cursors.Hand;
            btnAddValor01.FlatAppearance.BorderSize = 0;
            btnAddValor01.FlatStyle = FlatStyle.Flat;
            btnAddValor01.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddValor01.ForeColor = Color.Lime;
            btnAddValor01.Location = new Point(462, 107);
            btnAddValor01.Name = "btnAddValor01";
            btnAddValor01.Size = new Size(180, 52);
            btnAddValor01.TabIndex = 6;
            btnAddValor01.Text = "+R$ 0,01";
            btnAddValor01.UseVisualStyleBackColor = false;
            btnAddValor01.Click += btnAddValor_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 30);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNomematerial);
            panel2.Controls.Add(txtValorkg);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnCorrigir);
            panel2.Controls.Add(btnZerar);
            panel2.Controls.Add(btnAddValor1000);
            panel2.Controls.Add(btnAddValor500);
            panel2.Controls.Add(btnAddValor100);
            panel2.Controls.Add(btnAddValor50);
            panel2.Controls.Add(btnAddValor10);
            panel2.Controls.Add(btnAddValor01);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(1280, 340);
            panel2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(80, 0, 0);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(831, 182);
            button2.Name = "button2";
            button2.Size = new Size(436, 70);
            button2.TabIndex = 63;
            button2.Text = "FECHAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Image = Properties.Resources.lixeira;
            pictureBox3.Location = new Point(847, 64);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 62;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.add;
            pictureBox2.Location = new Point(847, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.BackColor = Color.FromArgb(80, 0, 0);
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.Red;
            btnExcluir.Location = new Point(898, 60);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(369, 47);
            btnExcluir.TabIndex = 60;
            btnExcluir.Text = "Excluir Selecionado ↓";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdicionar.BackColor = Color.FromArgb(0, 80, 0);
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.ForeColor = Color.Lime;
            btnAdicionar.Location = new Point(898, 9);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(369, 47);
            btnAdicionar.TabIndex = 59;
            btnAdicionar.Text = "Inserir +1 Material ↑";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(462, 50);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 58;
            button1.Text = "←Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(btnTraço);
            panel3.Controls.Add(btnPonto);
            panel3.Controls.Add(btnNum9);
            panel3.Controls.Add(btnNum8);
            panel3.Controls.Add(btnNum7);
            panel3.Controls.Add(btnNum6);
            panel3.Controls.Add(a);
            panel3.Controls.Add(btnNum4);
            panel3.Controls.Add(btnNum3);
            panel3.Controls.Add(btnNum2);
            panel3.Controls.Add(btnNum1);
            panel3.Controls.Add(btnNum0);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnSpace);
            panel3.Controls.Add(btnÇ);
            panel3.Controls.Add(btnP);
            panel3.Controls.Add(btnM);
            panel3.Controls.Add(btnN);
            panel3.Controls.Add(btnB);
            panel3.Controls.Add(btnV);
            panel3.Controls.Add(btnC);
            panel3.Controls.Add(btnX);
            panel3.Controls.Add(btnZ);
            panel3.Controls.Add(btnL);
            panel3.Controls.Add(btnK);
            panel3.Controls.Add(btnJ);
            panel3.Controls.Add(btnH);
            panel3.Controls.Add(btnG);
            panel3.Controls.Add(btnF);
            panel3.Controls.Add(btnD);
            panel3.Controls.Add(btnS);
            panel3.Controls.Add(btnA);
            panel3.Controls.Add(btnO);
            panel3.Controls.Add(btnI);
            panel3.Controls.Add(btnU);
            panel3.Controls.Add(btnY);
            panel3.Controls.Add(btnT);
            panel3.Controls.Add(btnR);
            panel3.Controls.Add(btnE);
            panel3.Controls.Add(btnW);
            panel3.Controls.Add(btnQ);
            panel3.Location = new Point(26, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 227);
            panel3.TabIndex = 18;
            // 
            // btnTraço
            // 
            btnTraço.FlatStyle = FlatStyle.Flat;
            btnTraço.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnTraço.ForeColor = Color.Gold;
            btnTraço.Location = new Point(342, 128);
            btnTraço.Name = "btnTraço";
            btnTraço.Size = new Size(40, 40);
            btnTraço.TabIndex = 59;
            btnTraço.Text = "-";
            btnTraço.UseVisualStyleBackColor = true;
            btnTraço.Click += btnTraço_Click;
            // 
            // btnPonto
            // 
            btnPonto.FlatStyle = FlatStyle.Flat;
            btnPonto.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnPonto.ForeColor = Color.Gold;
            btnPonto.Location = new Point(300, 128);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(40, 40);
            btnPonto.TabIndex = 58;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnNum9
            // 
            btnNum9.FlatStyle = FlatStyle.Flat;
            btnNum9.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum9.ForeColor = Color.Gold;
            btnNum9.Location = new Point(342, 2);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(40, 40);
            btnNum9.TabIndex = 57;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnNum8
            // 
            btnNum8.FlatStyle = FlatStyle.Flat;
            btnNum8.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum8.ForeColor = Color.Gold;
            btnNum8.Location = new Point(300, 2);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(40, 40);
            btnNum8.TabIndex = 56;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum7
            // 
            btnNum7.FlatStyle = FlatStyle.Flat;
            btnNum7.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum7.ForeColor = Color.Gold;
            btnNum7.Location = new Point(258, 2);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(40, 40);
            btnNum7.TabIndex = 55;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum6
            // 
            btnNum6.FlatStyle = FlatStyle.Flat;
            btnNum6.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum6.ForeColor = Color.Gold;
            btnNum6.Location = new Point(216, 2);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(40, 40);
            btnNum6.TabIndex = 54;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += btnNum6_Click;
            // 
            // a
            // 
            a.FlatStyle = FlatStyle.Flat;
            a.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            a.ForeColor = Color.Gold;
            a.Location = new Point(174, 2);
            a.Name = "a";
            a.Size = new Size(40, 40);
            a.TabIndex = 53;
            a.Text = "5";
            a.UseVisualStyleBackColor = true;
            a.Click += a_Click;
            // 
            // btnNum4
            // 
            btnNum4.FlatStyle = FlatStyle.Flat;
            btnNum4.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum4.ForeColor = Color.Gold;
            btnNum4.Location = new Point(132, 2);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(40, 40);
            btnNum4.TabIndex = 52;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnNum3
            // 
            btnNum3.FlatStyle = FlatStyle.Flat;
            btnNum3.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum3.ForeColor = Color.Gold;
            btnNum3.Location = new Point(90, 2);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(40, 40);
            btnNum3.TabIndex = 51;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum2
            // 
            btnNum2.FlatStyle = FlatStyle.Flat;
            btnNum2.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum2.ForeColor = Color.Gold;
            btnNum2.Location = new Point(48, 2);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(40, 40);
            btnNum2.TabIndex = 50;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum1
            // 
            btnNum1.FlatStyle = FlatStyle.Flat;
            btnNum1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum1.ForeColor = Color.Gold;
            btnNum1.Location = new Point(6, 2);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(40, 40);
            btnNum1.TabIndex = 49;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnNum0
            // 
            btnNum0.FlatStyle = FlatStyle.Flat;
            btnNum0.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNum0.ForeColor = Color.Gold;
            btnNum0.Location = new Point(384, 2);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(40, 40);
            btnNum0.TabIndex = 48;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            btnNum0.Click += btnNum0_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(384, 128);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 40);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "←";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSpace
            // 
            btnSpace.FlatStyle = FlatStyle.Flat;
            btnSpace.Font = new Font("Microsoft Sans Serif", 14.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpace.ForeColor = Color.Gold;
            btnSpace.Location = new Point(6, 170);
            btnSpace.Name = "btnSpace";
            btnSpace.Size = new Size(418, 53);
            btnSpace.TabIndex = 46;
            btnSpace.Text = "ESPAÇO";
            btnSpace.UseVisualStyleBackColor = true;
            btnSpace.Click += btnSpace_Click_1;
            // 
            // btnÇ
            // 
            btnÇ.FlatStyle = FlatStyle.Flat;
            btnÇ.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnÇ.ForeColor = Color.White;
            btnÇ.Location = new Point(384, 86);
            btnÇ.Name = "btnÇ";
            btnÇ.Size = new Size(40, 40);
            btnÇ.TabIndex = 45;
            btnÇ.Text = "Ç";
            btnÇ.UseVisualStyleBackColor = true;
            btnÇ.Click += btnÇ_Click;
            // 
            // btnP
            // 
            btnP.FlatStyle = FlatStyle.Flat;
            btnP.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnP.ForeColor = Color.White;
            btnP.Location = new Point(384, 44);
            btnP.Name = "btnP";
            btnP.Size = new Size(40, 40);
            btnP.TabIndex = 44;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = true;
            btnP.Click += btnP_Click;
            // 
            // btnM
            // 
            btnM.FlatStyle = FlatStyle.Flat;
            btnM.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnM.ForeColor = Color.White;
            btnM.Location = new Point(258, 128);
            btnM.Name = "btnM";
            btnM.Size = new Size(40, 40);
            btnM.TabIndex = 41;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = true;
            btnM.Click += btnM_Click;
            // 
            // btnN
            // 
            btnN.FlatStyle = FlatStyle.Flat;
            btnN.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnN.ForeColor = Color.White;
            btnN.Location = new Point(216, 128);
            btnN.Name = "btnN";
            btnN.Size = new Size(40, 40);
            btnN.TabIndex = 40;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = true;
            btnN.Click += btnN_Click;
            // 
            // btnB
            // 
            btnB.FlatStyle = FlatStyle.Flat;
            btnB.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnB.ForeColor = Color.White;
            btnB.Location = new Point(174, 128);
            btnB.Name = "btnB";
            btnB.Size = new Size(40, 40);
            btnB.TabIndex = 39;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnV
            // 
            btnV.FlatStyle = FlatStyle.Flat;
            btnV.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnV.ForeColor = Color.White;
            btnV.Location = new Point(132, 128);
            btnV.Name = "btnV";
            btnV.Size = new Size(40, 40);
            btnV.TabIndex = 38;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = true;
            btnV.Click += btnV_Click;
            // 
            // btnC
            // 
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(90, 128);
            btnC.Name = "btnC";
            btnC.Size = new Size(40, 40);
            btnC.TabIndex = 37;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnX
            // 
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnX.ForeColor = Color.White;
            btnX.Location = new Point(48, 128);
            btnX.Name = "btnX";
            btnX.Size = new Size(40, 40);
            btnX.TabIndex = 36;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // btnZ
            // 
            btnZ.FlatStyle = FlatStyle.Flat;
            btnZ.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnZ.ForeColor = Color.White;
            btnZ.Location = new Point(6, 128);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(40, 40);
            btnZ.TabIndex = 35;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = true;
            btnZ.Click += btnZ_Click;
            // 
            // btnL
            // 
            btnL.FlatStyle = FlatStyle.Flat;
            btnL.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnL.ForeColor = Color.White;
            btnL.Location = new Point(342, 86);
            btnL.Name = "btnL";
            btnL.Size = new Size(40, 40);
            btnL.TabIndex = 34;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = true;
            btnL.Click += btnL_Click;
            // 
            // btnK
            // 
            btnK.FlatStyle = FlatStyle.Flat;
            btnK.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnK.ForeColor = Color.White;
            btnK.Location = new Point(300, 86);
            btnK.Name = "btnK";
            btnK.Size = new Size(40, 40);
            btnK.TabIndex = 33;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = true;
            btnK.Click += btnK_Click;
            // 
            // btnJ
            // 
            btnJ.FlatStyle = FlatStyle.Flat;
            btnJ.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnJ.ForeColor = Color.White;
            btnJ.Location = new Point(258, 86);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(40, 40);
            btnJ.TabIndex = 32;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = true;
            btnJ.Click += btnJ_Click;
            // 
            // btnH
            // 
            btnH.FlatStyle = FlatStyle.Flat;
            btnH.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnH.ForeColor = Color.White;
            btnH.Location = new Point(216, 86);
            btnH.Name = "btnH";
            btnH.Size = new Size(40, 40);
            btnH.TabIndex = 31;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = true;
            btnH.Click += btnH_Click;
            // 
            // btnG
            // 
            btnG.FlatStyle = FlatStyle.Flat;
            btnG.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnG.ForeColor = Color.White;
            btnG.Location = new Point(174, 86);
            btnG.Name = "btnG";
            btnG.Size = new Size(40, 40);
            btnG.TabIndex = 30;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = true;
            btnG.Click += btnG_Click;
            // 
            // btnF
            // 
            btnF.FlatStyle = FlatStyle.Flat;
            btnF.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnF.ForeColor = Color.White;
            btnF.Location = new Point(132, 86);
            btnF.Name = "btnF";
            btnF.Size = new Size(40, 40);
            btnF.TabIndex = 29;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = true;
            btnF.Click += btnF_Click;
            // 
            // btnD
            // 
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnD.ForeColor = Color.White;
            btnD.Location = new Point(90, 86);
            btnD.Name = "btnD";
            btnD.Size = new Size(40, 40);
            btnD.TabIndex = 28;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnS
            // 
            btnS.FlatStyle = FlatStyle.Flat;
            btnS.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnS.ForeColor = Color.White;
            btnS.Location = new Point(48, 86);
            btnS.Name = "btnS";
            btnS.Size = new Size(40, 40);
            btnS.TabIndex = 27;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = true;
            btnS.Click += btnS_Click;
            // 
            // btnA
            // 
            btnA.FlatStyle = FlatStyle.Flat;
            btnA.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnA.ForeColor = Color.White;
            btnA.Location = new Point(6, 86);
            btnA.Name = "btnA";
            btnA.Size = new Size(40, 40);
            btnA.TabIndex = 26;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnO
            // 
            btnO.FlatStyle = FlatStyle.Flat;
            btnO.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnO.ForeColor = Color.White;
            btnO.Location = new Point(342, 44);
            btnO.Name = "btnO";
            btnO.Size = new Size(40, 40);
            btnO.TabIndex = 25;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            btnO.Click += btnO_Click;
            // 
            // btnI
            // 
            btnI.FlatStyle = FlatStyle.Flat;
            btnI.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnI.ForeColor = Color.White;
            btnI.Location = new Point(300, 44);
            btnI.Name = "btnI";
            btnI.Size = new Size(40, 40);
            btnI.TabIndex = 24;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = true;
            btnI.Click += btnI_Click;
            // 
            // btnU
            // 
            btnU.FlatStyle = FlatStyle.Flat;
            btnU.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnU.ForeColor = Color.White;
            btnU.Location = new Point(258, 44);
            btnU.Name = "btnU";
            btnU.Size = new Size(40, 40);
            btnU.TabIndex = 23;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = true;
            btnU.Click += btnU_Click;
            // 
            // btnY
            // 
            btnY.FlatStyle = FlatStyle.Flat;
            btnY.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnY.ForeColor = Color.White;
            btnY.Location = new Point(216, 44);
            btnY.Name = "btnY";
            btnY.Size = new Size(40, 40);
            btnY.TabIndex = 22;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = true;
            btnY.Click += btnY_Click;
            // 
            // btnT
            // 
            btnT.FlatStyle = FlatStyle.Flat;
            btnT.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnT.ForeColor = Color.White;
            btnT.Location = new Point(174, 44);
            btnT.Name = "btnT";
            btnT.Size = new Size(40, 40);
            btnT.TabIndex = 21;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = true;
            btnT.Click += btnT_Click;
            // 
            // btnR
            // 
            btnR.FlatStyle = FlatStyle.Flat;
            btnR.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnR.ForeColor = Color.White;
            btnR.Location = new Point(132, 44);
            btnR.Name = "btnR";
            btnR.Size = new Size(40, 40);
            btnR.TabIndex = 20;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // btnE
            // 
            btnE.FlatStyle = FlatStyle.Flat;
            btnE.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnE.ForeColor = Color.White;
            btnE.Location = new Point(90, 44);
            btnE.Name = "btnE";
            btnE.Size = new Size(40, 40);
            btnE.TabIndex = 19;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = true;
            btnE.Click += btnE_Click;
            // 
            // btnW
            // 
            btnW.FlatStyle = FlatStyle.Flat;
            btnW.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnW.ForeColor = Color.White;
            btnW.Location = new Point(48, 44);
            btnW.Name = "btnW";
            btnW.Size = new Size(40, 40);
            btnW.TabIndex = 18;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = true;
            btnW.Click += btnW_Click;
            // 
            // btnQ
            // 
            btnQ.FlatStyle = FlatStyle.Flat;
            btnQ.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ.ForeColor = Color.White;
            btnQ.Location = new Point(6, 44);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(40, 40);
            btnQ.TabIndex = 17;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = true;
            btnQ.Click += btnQ_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(30, 30, 30);
            label5.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(580, 56);
            label5.Name = "label5";
            label5.Size = new Size(63, 39);
            label5.TabIndex = 16;
            label5.Text = "R$";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalvar.BackColor = Color.FromArgb(0, 99, 0);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(831, 258);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(436, 70);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "SALVAR ALTERAÇÃO";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCorrigir
            // 
            btnCorrigir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCorrigir.Cursor = Cursors.Hand;
            btnCorrigir.FlatStyle = FlatStyle.Flat;
            btnCorrigir.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnCorrigir.ForeColor = Color.Gold;
            btnCorrigir.Location = new Point(645, 272);
            btnCorrigir.Name = "btnCorrigir";
            btnCorrigir.Size = new Size(180, 56);
            btnCorrigir.TabIndex = 13;
            btnCorrigir.Text = "CORRIGIR";
            btnCorrigir.UseVisualStyleBackColor = true;
            btnCorrigir.Click += btnCorrigir_Click;
            // 
            // btnZerar
            // 
            btnZerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnZerar.Cursor = Cursors.Hand;
            btnZerar.FlatStyle = FlatStyle.Flat;
            btnZerar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnZerar.ForeColor = Color.Red;
            btnZerar.Location = new Point(462, 272);
            btnZerar.Name = "btnZerar";
            btnZerar.Size = new Size(180, 56);
            btnZerar.TabIndex = 12;
            btnZerar.Text = "ZERAR";
            btnZerar.UseVisualStyleBackColor = true;
            btnZerar.Click += btnZerar_Click;
            // 
            // btnAddValor1000
            // 
            btnAddValor1000.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddValor1000.BackColor = Color.FromArgb(0, 80, 0);
            btnAddValor1000.Cursor = Cursors.Hand;
            btnAddValor1000.FlatAppearance.BorderSize = 0;
            btnAddValor1000.FlatStyle = FlatStyle.Flat;
            btnAddValor1000.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddValor1000.ForeColor = Color.Lime;
            btnAddValor1000.Location = new Point(645, 217);
            btnAddValor1000.Name = "btnAddValor1000";
            btnAddValor1000.Size = new Size(180, 52);
            btnAddValor1000.TabIndex = 11;
            btnAddValor1000.Text = "+R$ 10,00";
            btnAddValor1000.UseVisualStyleBackColor = false;
            btnAddValor1000.Click += btnAddValor_Click;
            // 
            // btnAddValor500
            // 
            btnAddValor500.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddValor500.BackColor = Color.FromArgb(0, 80, 0);
            btnAddValor500.Cursor = Cursors.Hand;
            btnAddValor500.FlatAppearance.BorderSize = 0;
            btnAddValor500.FlatStyle = FlatStyle.Flat;
            btnAddValor500.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddValor500.ForeColor = Color.Lime;
            btnAddValor500.Location = new Point(462, 217);
            btnAddValor500.Name = "btnAddValor500";
            btnAddValor500.Size = new Size(180, 52);
            btnAddValor500.TabIndex = 10;
            btnAddValor500.Text = "+R$ 5,00";
            btnAddValor500.UseVisualStyleBackColor = false;
            btnAddValor500.Click += btnAddValor_Click;
            // 
            // btnAddValor100
            // 
            btnAddValor100.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddValor100.BackColor = Color.FromArgb(0, 80, 0);
            btnAddValor100.Cursor = Cursors.Hand;
            btnAddValor100.FlatAppearance.BorderSize = 0;
            btnAddValor100.FlatStyle = FlatStyle.Flat;
            btnAddValor100.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddValor100.ForeColor = Color.Lime;
            btnAddValor100.Location = new Point(645, 162);
            btnAddValor100.Name = "btnAddValor100";
            btnAddValor100.Size = new Size(180, 52);
            btnAddValor100.TabIndex = 9;
            btnAddValor100.Text = "+R$ 1,00";
            btnAddValor100.UseVisualStyleBackColor = false;
            btnAddValor100.Click += btnAddValor_Click;
            // 
            // btnAddValor50
            // 
            btnAddValor50.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddValor50.BackColor = Color.FromArgb(0, 80, 0);
            btnAddValor50.Cursor = Cursors.Hand;
            btnAddValor50.FlatAppearance.BorderSize = 0;
            btnAddValor50.FlatStyle = FlatStyle.Flat;
            btnAddValor50.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddValor50.ForeColor = Color.Lime;
            btnAddValor50.Location = new Point(462, 162);
            btnAddValor50.Name = "btnAddValor50";
            btnAddValor50.Size = new Size(180, 52);
            btnAddValor50.TabIndex = 8;
            btnAddValor50.Text = "+R$ 0,50";
            btnAddValor50.UseVisualStyleBackColor = false;
            btnAddValor50.Click += btnAddValor_Click;
            // 
            // btnAddValor10
            // 
            btnAddValor10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddValor10.BackColor = Color.FromArgb(0, 80, 0);
            btnAddValor10.Cursor = Cursors.Hand;
            btnAddValor10.FlatAppearance.BorderSize = 0;
            btnAddValor10.FlatStyle = FlatStyle.Flat;
            btnAddValor10.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddValor10.ForeColor = Color.Lime;
            btnAddValor10.Location = new Point(645, 107);
            btnAddValor10.Name = "btnAddValor10";
            btnAddValor10.Size = new Size(180, 52);
            btnAddValor10.TabIndex = 7;
            btnAddValor10.Text = "+R$ 0,10";
            btnAddValor10.UseVisualStyleBackColor = false;
            btnAddValor10.Click += btnAddValor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(5, 52);
            label4.Name = "label4";
            label4.Size = new Size(333, 20);
            label4.TabIndex = 3;
            label4.Text = "TOQUE NO MATERIAL PARA SELECIONAR";
            // 
            // btnsMateriais2
            // 
            btnsMateriais2.Location = new Point(5, 75);
            btnsMateriais2.Name = "btnsMateriais2";
            btnsMateriais2.Size = new Size(1270, 299);
            btnsMateriais2.TabIndex = 14;
            // 
            // timerUpdateValues
            // 
            timerUpdateValues.Interval = 1000;
            timerUpdateValues.Tick += timerUpdateValues_Tick;
            // 
            // FormAddMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1280, 720);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(btnsMateriais2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Material";
            FormClosed += FormAddMaterial_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtNomematerial;
        private Label label2;
        private Label label3;
        private TextBox txtValorkg;
        private Button btnAddValor01;
        private Panel panel2;
        private Button btnAddValor50;
        private Button btnAddValor10;
        private Button btnCorrigir;
        private Button btnZerar;
        private Button btnAddValor1000;
        private Button btnAddValor500;
        private Button btnAddValor100;
        private Panel btnsMateriais2;
        private Button btnSalvar;
        private Button btnFechar;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timerUpdateValues;
        private Button btnQ;
        private Panel panel3;
        private Button btnM;
        private Button btnN;
        private Button btnB;
        private Button btnV;
        private Button btnC;
        private Button btnX;
        private Button btnZ;
        private Button btnL;
        private Button btnK;
        private Button btnJ;
        private Button btnH;
        private Button btnG;
        private Button btnF;
        private Button btnD;
        private Button btnS;
        private Button btnA;
        private Button btnO;
        private Button btnI;
        private Button btnU;
        private Button btnY;
        private Button btnT;
        private Button btnR;
        private Button btnE;
        private Button btnW;
        private Button btnÇ;
        private Button btnP;
        private Button btnSpace;
        private Button btnDelete;
        private Button btnNum9;
        private Button btnNum8;
        private Button btnNum7;
        private Button btnNum6;
        private Button a;
        private Button btnNum4;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private Button btnNum0;
        private Button button1;
        private Button btnTraço;
        private Button btnPonto;
        private Button btnAdicionar;
        private Button btnExcluir;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button2;
    }
}