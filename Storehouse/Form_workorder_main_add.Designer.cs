namespace Storehouse
{
    partial class Form_workorder_main_add
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
            textBox_notes = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            textBox_model = new TextBox();
            label4 = new Label();
            save = new Button();
            textBox_name = new TextBox();
            textBox_workerorderNum = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label_error_workerorderNum = new Label();
            label_error_name = new Label();
            label_error_model = new Label();
            label_error_quantity = new Label();
            numericUpDown_quantity = new NumericUpDown();
            dateTimePicker_productionDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).BeginInit();
            SuspendLayout();
            // 
            // textBox_notes
            // 
            textBox_notes.BorderStyle = BorderStyle.FixedSingle;
            textBox_notes.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_notes.Location = new Point(89, 393);
            textBox_notes.Margin = new Padding(4);
            textBox_notes.Multiline = true;
            textBox_notes.Name = "textBox_notes";
            textBox_notes.Size = new Size(351, 178);
            textBox_notes.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(17, 393);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 35);
            label8.TabIndex = 32;
            label8.Text = "備註:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 261);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 35);
            label5.TabIndex = 30;
            label5.Text = "數量:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 321);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 35);
            label7.TabIndex = 28;
            label7.Text = "生產日期:";
            // 
            // textBox_model
            // 
            textBox_model.BorderStyle = BorderStyle.FixedSingle;
            textBox_model.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_model.Location = new Point(89, 195);
            textBox_model.Margin = new Padding(4);
            textBox_model.Name = "textBox_model";
            textBox_model.PlaceholderText = "請輸入型號";
            textBox_model.Size = new Size(351, 38);
            textBox_model.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 195);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 24;
            label4.Text = "型號:";
            // 
            // save
            // 
            save.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            save.Location = new Point(168, 597);
            save.Margin = new Padding(4);
            save.Name = "save";
            save.Size = new Size(96, 43);
            save.TabIndex = 8;
            save.Text = "儲存";
            save.UseVisualStyleBackColor = true;
            save.MouseClick += save_MouseClick;
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name.Location = new Point(89, 138);
            textBox_name.Margin = new Padding(4);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "請輸入名稱";
            textBox_name.Size = new Size(351, 38);
            textBox_name.TabIndex = 2;
            // 
            // textBox_workerorderNum
            // 
            textBox_workerorderNum.BackColor = Color.White;
            textBox_workerorderNum.BorderStyle = BorderStyle.FixedSingle;
            textBox_workerorderNum.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_workerorderNum.Location = new Point(150, 73);
            textBox_workerorderNum.Margin = new Padding(4);
            textBox_workerorderNum.Name = "textBox_workerorderNum";
            textBox_workerorderNum.PlaceholderText = "請輸入工單編號";
            textBox_workerorderNum.Size = new Size(290, 37);
            textBox_workerorderNum.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 35);
            label3.TabIndex = 20;
            label3.Text = "名稱:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 35);
            label2.TabIndex = 19;
            label2.Text = "工單編號:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(158, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 43);
            label1.TabIndex = 18;
            label1.Text = "新增項目";
            // 
            // label_error_workerorderNum
            // 
            label_error_workerorderNum.AutoSize = true;
            label_error_workerorderNum.ForeColor = Color.Red;
            label_error_workerorderNum.Location = new Point(146, 115);
            label_error_workerorderNum.Name = "label_error_workerorderNum";
            label_error_workerorderNum.Size = new Size(46, 19);
            label_error_workerorderNum.TabIndex = 33;
            label_error_workerorderNum.Text = "*必填";
            label_error_workerorderNum.Visible = false;
            // 
            // label_error_name
            // 
            label_error_name.AutoSize = true;
            label_error_name.ForeColor = Color.Red;
            label_error_name.Location = new Point(146, 176);
            label_error_name.Name = "label_error_name";
            label_error_name.Size = new Size(46, 19);
            label_error_name.TabIndex = 34;
            label_error_name.Text = "*必填";
            label_error_name.Visible = false;
            // 
            // label_error_model
            // 
            label_error_model.AutoSize = true;
            label_error_model.ForeColor = Color.Red;
            label_error_model.Location = new Point(146, 237);
            label_error_model.Name = "label_error_model";
            label_error_model.Size = new Size(46, 19);
            label_error_model.TabIndex = 35;
            label_error_model.Text = "*必填";
            label_error_model.Visible = false;
            // 
            // label_error_quantity
            // 
            label_error_quantity.AutoSize = true;
            label_error_quantity.ForeColor = Color.Red;
            label_error_quantity.Location = new Point(152, 300);
            label_error_quantity.Name = "label_error_quantity";
            label_error_quantity.Size = new Size(61, 19);
            label_error_quantity.TabIndex = 36;
            label_error_quantity.Text = "*請選擇";
            label_error_quantity.Visible = false;
            // 
            // numericUpDown_quantity
            // 
            numericUpDown_quantity.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_quantity.Location = new Point(89, 265);
            numericUpDown_quantity.Name = "numericUpDown_quantity";
            numericUpDown_quantity.Size = new Size(351, 33);
            numericUpDown_quantity.TabIndex = 39;
            // 
            // dateTimePicker_productionDate
            // 
            dateTimePicker_productionDate.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_productionDate.Location = new Point(146, 323);
            dateTimePicker_productionDate.Name = "dateTimePicker_productionDate";
            dateTimePicker_productionDate.Size = new Size(294, 33);
            dateTimePicker_productionDate.TabIndex = 40;
            // 
            // Form_workorder_main_add
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(465, 669);
            Controls.Add(dateTimePicker_productionDate);
            Controls.Add(numericUpDown_quantity);
            Controls.Add(label_error_quantity);
            Controls.Add(label_error_model);
            Controls.Add(label_error_name);
            Controls.Add(label_error_workerorderNum);
            Controls.Add(textBox_notes);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(textBox_model);
            Controls.Add(label4);
            Controls.Add(save);
            Controls.Add(textBox_name);
            Controls.Add(textBox_workerorderNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form_workorder_main_add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "倉儲管理系統";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_notes;
        private Label label8;
        private Label label5;
        private Label label7;
        private TextBox textBox_model;
        private Label label4;
        private Button save;
        private TextBox textBox_name;
        private TextBox textBox_workerorderNum;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label_error_workerorderNum;
        private Label label_error_name;
        private Label label_error_model;
        private Label label_error_quantity;
        private NumericUpDown numericUpDown_quantity;
        private DateTimePicker dateTimePicker_productionDate;
    }
}