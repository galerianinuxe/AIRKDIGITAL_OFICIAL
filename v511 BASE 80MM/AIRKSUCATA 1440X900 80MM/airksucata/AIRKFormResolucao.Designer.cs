namespace airksucata
{
    partial class AIRKFormResolucao
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
            btn1024x768 = new Button();
            btn1280x720 = new Button();
            btn1024x1280 = new Button();
            btn1440x900 = new Button();
            SuspendLayout();
            // 
            // btn1024x768
            // 
            btn1024x768.Dock = DockStyle.Left;
            btn1024x768.FlatStyle = FlatStyle.Flat;
            btn1024x768.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1024x768.ForeColor = Color.Lime;
            btn1024x768.Location = new Point(0, 0);
            btn1024x768.Name = "btn1024x768";
            btn1024x768.Size = new Size(150, 330);
            btn1024x768.TabIndex = 0;
            btn1024x768.Text = "1024x768px\r\nHorizontal";
            btn1024x768.UseVisualStyleBackColor = true;
            btn1024x768.Click += btn1024x768_Click;
            // 
            // btn1280x720
            // 
            btn1280x720.Dock = DockStyle.Left;
            btn1280x720.FlatStyle = FlatStyle.Flat;
            btn1280x720.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1280x720.ForeColor = Color.Lime;
            btn1280x720.Location = new Point(150, 0);
            btn1280x720.Name = "btn1280x720";
            btn1280x720.Size = new Size(150, 330);
            btn1280x720.TabIndex = 1;
            btn1280x720.Text = "1280x720px\r\nHorizontal";
            btn1280x720.UseVisualStyleBackColor = true;
            // 
            // btn1024x1280
            // 
            btn1024x1280.Dock = DockStyle.Left;
            btn1024x1280.FlatStyle = FlatStyle.Flat;
            btn1024x1280.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1024x1280.ForeColor = Color.Lime;
            btn1024x1280.Location = new Point(300, 0);
            btn1024x1280.Name = "btn1024x1280";
            btn1024x1280.Size = new Size(150, 330);
            btn1024x1280.TabIndex = 2;
            btn1024x1280.Text = "1024x1280px\r\nVertical";
            btn1024x1280.UseVisualStyleBackColor = true;
            // 
            // btn1440x900
            // 
            btn1440x900.Dock = DockStyle.Left;
            btn1440x900.FlatStyle = FlatStyle.Flat;
            btn1440x900.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1440x900.ForeColor = Color.Lime;
            btn1440x900.Location = new Point(450, 0);
            btn1440x900.Name = "btn1440x900";
            btn1440x900.Size = new Size(150, 330);
            btn1440x900.TabIndex = 3;
            btn1440x900.Text = "1440x900px\r\nHorizontal";
            btn1440x900.UseVisualStyleBackColor = true;
            btn1440x900.Click += btn1440x900_Click;
            // 
            // AIRKFormResolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(602, 330);
            Controls.Add(btn1440x900);
            Controls.Add(btn1024x1280);
            Controls.Add(btn1280x720);
            Controls.Add(btn1024x768);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AIRKFormResolucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecione uma resolução.";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1024x768;
        private Button btn1280x720;
        private Button btn1024x1280;
        private Button btn1440x900;
    }
}