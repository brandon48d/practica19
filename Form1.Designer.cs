namespace practica19
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            Cam1 = new TextBox();
            label3 = new Label();
            Cam2 = new TextBox();
            label4 = new Label();
            Cam3 = new TextBox();
            label5 = new Label();
            Cam4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(299, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 0;
            label1.Text = "Calificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(198, 97);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 1;
            label2.Text = "Calificacion 1";
            // 
            // Cam1
            // 
            Cam1.Location = new Point(326, 95);
            Cam1.Name = "Cam1";
            Cam1.Size = new Size(100, 23);
            Cam1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(177, 142);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 3;
            label3.Text = "Calificacion 2";
            // 
            // Cam2
            // 
            Cam2.Location = new Point(326, 147);
            Cam2.Name = "Cam2";
            Cam2.Size = new Size(100, 23);
            Cam2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(197, 204);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 5;
            label4.Text = "Calificacion 3";
            // 
            // Cam3
            // 
            Cam3.Location = new Point(326, 206);
            Cam3.Name = "Cam3";
            Cam3.Size = new Size(100, 23);
            Cam3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(196, 252);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 7;
            label5.Text = "Calificacion 4";
            // 
            // Cam4
            // 
            Cam4.Location = new Point(326, 254);
            Cam4.Name = "Cam4";
            Cam4.Size = new Size(100, 23);
            Cam4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(316, 318);
            button1.Name = "button1";
            button1.Size = new Size(123, 47);
            button1.TabIndex = 9;
            button1.Text = "Resultado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Cam4);
            Controls.Add(label5);
            Controls.Add(Cam3);
            Controls.Add(label4);
            Controls.Add(Cam2);
            Controls.Add(label3);
            Controls.Add(Cam1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Cam1;
        private Label label3;
        private TextBox Cam2;
        private Label label4;
        private TextBox Cam3;
        private Label label5;
        private TextBox Cam4;
        private Button button1;
    }
}