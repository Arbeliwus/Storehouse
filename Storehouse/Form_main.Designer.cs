namespace Storehouse
{
    partial class Form_main
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
            button_part = new Button();
            button_workorder = new Button();
            button_commodity = new Button();
            button_logout = new Button();
            panel_main = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_part
            // 
            button_part.BackColor = SystemColors.ScrollBar;
            button_part.FlatAppearance.BorderSize = 2;
            button_part.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_part.Location = new Point(53, 95);
            button_part.Name = "button_part";
            button_part.Size = new Size(247, 58);
            button_part.TabIndex = 0;
            button_part.Text = "零件進銷存紀錄";
            button_part.UseVisualStyleBackColor = false;
            button_part.Click += button_part_Click;
            // 
            // button_workorder
            // 
            button_workorder.BackColor = Color.DarkKhaki;
            button_workorder.FlatAppearance.BorderSize = 2;
            button_workorder.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_workorder.Location = new Point(653, 95);
            button_workorder.Name = "button_workorder";
            button_workorder.Size = new Size(247, 58);
            button_workorder.TabIndex = 1;
            button_workorder.Text = "工單排程";
            button_workorder.UseVisualStyleBackColor = false;
            button_workorder.Click += button_workorder_Click;
            // 
            // button_commodity
            // 
            button_commodity.BackColor = SystemColors.ScrollBar;
            button_commodity.FlatAppearance.BorderSize = 2;
            button_commodity.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_commodity.Location = new Point(353, 95);
            button_commodity.Name = "button_commodity";
            button_commodity.Size = new Size(247, 58);
            button_commodity.TabIndex = 3;
            button_commodity.Text = "產品進銷存紀錄";
            button_commodity.UseVisualStyleBackColor = false;
            button_commodity.Click += button_commodity_Click;
            // 
            // button_logout
            // 
            button_logout.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button_logout.Location = new Point(1643, 95);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(247, 58);
            button_logout.TabIndex = 4;
            button_logout.Text = "登   出";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // panel_main
            // 
            panel_main.Location = new Point(12, 159);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1878, 862);
            panel_main.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1095, 105);
            label1.Name = "label1";
            label1.Size = new Size(182, 40);
            label1.TabIndex = 6;
            label1.Text = "歡迎使用者-";
            // 
            // Form_main
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label1);
            Controls.Add(panel_main);
            Controls.Add(button_logout);
            Controls.Add(button_commodity);
            Controls.Add(button_workorder);
            Controls.Add(button_part);
            MaximizeBox = false;
            Name = "Form_main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "倉儲管理系統";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form_main_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_part;
        private Button button_workorder;
        private Button button_commodity;
        private Button button_logout;
        private Panel panel_main;
        private Label label1;
    }
}