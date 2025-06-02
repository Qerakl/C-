namespace _52
{
    partial class rereg
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
            mainpass = new TextBox();
            newpass = new TextBox();
            newnewpass = new TextBox();
            button1 = new Button();
            labelWelcome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // mainpass
            // 
            mainpass.Font = new Font("Segoe UI", 15F);
            mainpass.Location = new Point(194, 164);
            mainpass.Margin = new Padding(3, 4, 3, 4);
            mainpass.Name = "mainpass";
            mainpass.PasswordChar = '*';
            mainpass.Size = new Size(313, 41);
            mainpass.TabIndex = 0;
            // 
            // newpass
            // 
            newpass.Font = new Font("Segoe UI", 15F);
            newpass.Location = new Point(194, 248);
            newpass.Margin = new Padding(3, 4, 3, 4);
            newpass.Name = "newpass";
            newpass.PasswordChar = '*';
            newpass.Size = new Size(313, 41);
            newpass.TabIndex = 1;
            // 
            // newnewpass
            // 
            newnewpass.Font = new Font("Segoe UI", 15F);
            newnewpass.Location = new Point(194, 339);
            newnewpass.Margin = new Padding(3, 4, 3, 4);
            newnewpass.Name = "newnewpass";
            newnewpass.PasswordChar = '*';
            newnewpass.Size = new Size(313, 41);
            newnewpass.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(238, 408);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(191, 57);
            button1.TabIndex = 3;
            button1.Text = "Изменить пароль";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 25F);
            labelWelcome.Location = new Point(53, 31);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(0, 57);
            labelWelcome.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(194, 125);
            label1.Name = "label1";
            label1.Size = new Size(191, 35);
            label1.TabIndex = 5;
            label1.Text = "Старый пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(194, 209);
            label2.Name = "label2";
            label2.Size = new Size(184, 35);
            label2.TabIndex = 6;
            label2.Text = "Новый пароль";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(194, 300);
            label3.Name = "label3";
            label3.Size = new Size(184, 35);
            label3.TabIndex = 7;
            label3.Text = "Новый пароль";
            // 
            // rereg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 546);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            Controls.Add(button1);
            Controls.Add(newnewpass);
            Controls.Add(newpass);
            Controls.Add(mainpass);
            Margin = new Padding(3, 4, 3, 4);
            Name = "rereg";
            Text = "rereg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mainpass;
        private TextBox newpass;
        private TextBox newnewpass;
        private Button button1;
        private Label labelWelcome;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}