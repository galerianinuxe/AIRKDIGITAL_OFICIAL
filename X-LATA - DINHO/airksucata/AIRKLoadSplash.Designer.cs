namespace airksucata
{
    partial class AIRKLoadSplash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIRKLoadSplash));
            pictureBox1 = new PictureBox();
            labelFrase = new Label();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            label2 = new Label();
            lbUpdate = new Label();
            lbVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.IMG_SOFTWARE4;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(629, 413);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelFrase
            // 
            labelFrase.BackColor = Color.FromArgb(4, 45, 46);
            labelFrase.FlatStyle = FlatStyle.Flat;
            labelFrase.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelFrase.ForeColor = Color.FromArgb(0, 190, 150);
            labelFrase.Location = new Point(15, 259);
            labelFrase.Margin = new Padding(0);
            labelFrase.Name = "labelFrase";
            labelFrase.Padding = new Padding(0, 0, 10, 0);
            labelFrase.Size = new Size(395, 52);
            labelFrase.TabIndex = 2;
            labelFrase.Text = "Carregando sistema, aguarde";
            labelFrase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSpringGreen;
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 17);
            panel2.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSpringGreen;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(629, 2);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(4, 45, 46);
            label2.Font = new Font("Avignon Pro", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 327);
            label2.Name = "label2";
            label2.Size = new Size(289, 36);
            label2.TabIndex = 7;
            label2.Text = "Atendimento via WhatsApp 11 96351-2105\r\nou acesse nosso site www.airk.com.br";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbUpdate
            // 
            lbUpdate.AutoSize = true;
            lbUpdate.BackColor = Color.FromArgb(4, 45, 46);
            lbUpdate.Font = new Font("Avignon Pro", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbUpdate.ForeColor = Color.FromArgb(0, 100, 100);
            lbUpdate.Location = new Point(16, 377);
            lbUpdate.Name = "lbUpdate";
            lbUpdate.Size = new Size(102, 14);
            lbUpdate.TabIndex = 11;
            lbUpdate.Text = "Última Atualização:";
            lbUpdate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.BackColor = Color.FromArgb(4, 45, 46);
            lbVersion.Font = new Font("Avignon Pro", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbVersion.ForeColor = Color.FromArgb(0, 100, 100);
            lbVersion.Location = new Point(16, 390);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(73, 14);
            lbVersion.TabIndex = 10;
            lbVersion.Text = "Versão atual:";
            lbVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AIRKLoadSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 60, 50);
            ClientSize = new Size(629, 413);
            Controls.Add(lbUpdate);
            Controls.Add(lbVersion);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(labelFrase);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AIRKLoadSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carregando AIRK SUCATA";
            Load += AIRKLoadSplash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Label labelFrase;
        private Panel panel3;
        private Label label2;
        private Label lbUpdate;
        private Label lbVersion;
    }
}