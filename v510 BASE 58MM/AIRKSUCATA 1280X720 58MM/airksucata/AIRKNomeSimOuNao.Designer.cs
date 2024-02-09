namespace airksucata
{
    partial class AIRKNomeSimOuNao
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
            label1 = new Label();
            btnNao = new Button();
            btnSim = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Avignon Pro", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(357, 33);
            label1.TabIndex = 0;
            label1.Text = "INSERIR NOME DO CLIENTE ?";
            // 
            // btnNao
            // 
            btnNao.FlatStyle = FlatStyle.Flat;
            btnNao.Font = new Font("Avignon Pro", 18.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNao.ForeColor = Color.Red;
            btnNao.Location = new Point(219, 82);
            btnNao.Name = "btnNao";
            btnNao.Size = new Size(199, 78);
            btnNao.TabIndex = 1;
            btnNao.Text = "Não";
            btnNao.UseVisualStyleBackColor = true;
            btnNao.Click += btnNao_Click;
            // 
            // btnSim
            // 
            btnSim.FlatStyle = FlatStyle.Flat;
            btnSim.Font = new Font("Avignon Pro", 18.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btnSim.ForeColor = Color.Lime;
            btnSim.Location = new Point(14, 82);
            btnSim.Name = "btnSim";
            btnSim.Size = new Size(199, 78);
            btnSim.TabIndex = 2;
            btnSim.Text = "Sim";
            btnSim.UseVisualStyleBackColor = true;
            btnSim.Click += btnSim_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 30, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 68);
            panel1.TabIndex = 3;
            // 
            // AIRKNomeSimOuNao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(434, 175);
            Controls.Add(panel1);
            Controls.Add(btnSim);
            Controls.Add(btnNao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AIRKNomeSimOuNao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AIRKNomeSimOuNao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnNao;
        private Button btnSim;
        private Panel panel1;
    }
}