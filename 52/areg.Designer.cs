namespace _52
{
    partial class areg
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
            log = new TextBox();
            pas = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // log
            // 
            log.Font = new Font("Segoe UI", 15F);
            log.Location = new Point(121, 183);
            log.Margin = new Padding(3, 4, 3, 4);
            log.Name = "log";
            log.Size = new Size(345, 41);
            log.TabIndex = 0;
            log.TextChanged += log_TextChanged;
            // 
            // pas
            // 
            pas.Font = new Font("Segoe UI", 15F);
            pas.Location = new Point(121, 280);
            pas.Margin = new Padding(3, 4, 3, 4);
            pas.Name = "pas";
            pas.PasswordChar = '*';
            pas.Size = new Size(345, 41);
            pas.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(209, 355);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(167, 53);
            button1.TabIndex = 2;
            button1.Text = "Авторизация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(121, 144);
            label1.Name = "label1";
            label1.Size = new Size(86, 35);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(121, 241);
            label2.Name = "label2";
            label2.Size = new Size(102, 35);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(182, 51);
            label3.Name = "label3";
            label3.Size = new Size(223, 46);
            label3.TabIndex = 5;
            label3.Text = "Авторизация";
            // 
            // areg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 509);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pas);
            Controls.Add(log);
            Margin = new Padding(3, 4, 3, 4);
            Name = "areg";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox log;
        private TextBox pas;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
