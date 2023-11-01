namespace Storehouse
{
    partial class Form_login
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
            label3 = new Label();
            textBox_account = new TextBox();
            textBox_password = new TextBox();
            login_button = new Button();
            label_account = new Label();
            label_password = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 47);
            label1.TabIndex = 0;
            label1.Text = "登入";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 1;
            label2.Text = "帳號:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 184);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 30);
            label3.TabIndex = 2;
            label3.Text = "密碼:";
            // 
            // textBox_account
            // 
            textBox_account.Location = new Point(90, 120);
            textBox_account.Margin = new Padding(4);
            textBox_account.Name = "textBox_account";
            textBox_account.Size = new Size(287, 27);
            textBox_account.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(90, 184);
            textBox_password.Margin = new Padding(4);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(287, 27);
            textBox_password.TabIndex = 4;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // login_button
            // 
            login_button.Anchor = AnchorStyles.Bottom;
            login_button.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.Location = new Point(161, 246);
            login_button.Margin = new Padding(4);
            login_button.Name = "login_button";
            login_button.Size = new Size(96, 43);
            login_button.TabIndex = 5;
            login_button.Text = "登入";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // label_account
            // 
            label_account.AutoSize = true;
            label_account.ForeColor = Color.Red;
            label_account.Location = new Point(92, 149);
            label_account.Name = "label_account";
            label_account.Size = new Size(91, 19);
            label_account.TabIndex = 6;
            label_account.Text = "*請輸入帳號";
            label_account.Visible = false;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.ForeColor = Color.Red;
            label_password.Location = new Point(92, 215);
            label_password.Name = "label_password";
            label_password.Size = new Size(91, 19);
            label_password.TabIndex = 7;
            label_password.Text = "*請輸入密碼";
            label_password.Visible = false;
            // 
            // Form_login
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 312);
            Controls.Add(label_password);
            Controls.Add(label_account);
            Controls.Add(login_button);
            Controls.Add(textBox_password);
            Controls.Add(textBox_account);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "倉儲管理系統";
            FormClosing += Form_login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_account;
        private TextBox textBox_password;
        private Button login_button;
        private Label label_account;
        private Label label_password;
    }
}