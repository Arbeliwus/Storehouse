namespace Storehouse
{
    partial class Form_product_add
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
            textBox_notes = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox_name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button_save = new Button();
            label_error_name = new Label();
            label_error_workerorderNum = new Label();
            label_error_state = new Label();
            dateTimePicker_productionDate = new DateTimePicker();
            comboBox_status = new ComboBox();
            label_error_quantity = new Label();
            label7 = new Label();
            numericUpDown_quantity = new NumericUpDown();
            comboBox_workerorderNum = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 43);
            label1.TabIndex = 1;
            label1.Text = "新增項目";
            // 
            // textBox_notes
            // 
            textBox_notes.BorderStyle = BorderStyle.FixedSingle;
            textBox_notes.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_notes.Location = new Point(91, 420);
            textBox_notes.Margin = new Padding(4);
            textBox_notes.Multiline = true;
            textBox_notes.Name = "textBox_notes";
            textBox_notes.Size = new Size(351, 147);
            textBox_notes.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 420);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 35);
            label8.TabIndex = 30;
            label8.Text = "備註:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 356);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 35);
            label5.TabIndex = 28;
            label5.Text = "狀態:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 165);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 35);
            label4.TabIndex = 22;
            label4.Text = "生產日期:";
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name.Location = new Point(93, 91);
            textBox_name.Margin = new Padding(4);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "請輸入品名";
            textBox_name.Size = new Size(341, 38);
            textBox_name.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 226);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 35);
            label3.TabIndex = 19;
            label3.Text = "工單編號:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 35);
            label2.TabIndex = 18;
            label2.Text = "品名:";
            // 
            // button_save
            // 
            button_save.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_save.Location = new Point(168, 597);
            button_save.Margin = new Padding(4);
            button_save.Name = "button_save";
            button_save.Size = new Size(96, 43);
            button_save.TabIndex = 6;
            button_save.Text = "儲存";
            button_save.UseVisualStyleBackColor = true;
            button_save.MouseClick += button_save_MouseClick;
            // 
            // label_error_name
            // 
            label_error_name.AutoSize = true;
            label_error_name.ForeColor = Color.Red;
            label_error_name.Location = new Point(150, 133);
            label_error_name.Name = "label_error_name";
            label_error_name.Size = new Size(46, 19);
            label_error_name.TabIndex = 31;
            label_error_name.Text = "*必填";
            label_error_name.Visible = false;
            // 
            // label_error_workerorderNum
            // 
            label_error_workerorderNum.AutoSize = true;
            label_error_workerorderNum.ForeColor = Color.Red;
            label_error_workerorderNum.Location = new Point(152, 268);
            label_error_workerorderNum.Name = "label_error_workerorderNum";
            label_error_workerorderNum.Size = new Size(46, 19);
            label_error_workerorderNum.TabIndex = 32;
            label_error_workerorderNum.Text = "*必填";
            label_error_workerorderNum.Visible = false;
            // 
            // label_error_state
            // 
            label_error_state.AutoSize = true;
            label_error_state.ForeColor = Color.Red;
            label_error_state.Location = new Point(149, 397);
            label_error_state.Name = "label_error_state";
            label_error_state.Size = new Size(61, 19);
            label_error_state.TabIndex = 34;
            label_error_state.Text = "*請選擇";
            label_error_state.Visible = false;
            // 
            // dateTimePicker_productionDate
            // 
            dateTimePicker_productionDate.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_productionDate.Location = new Point(149, 170);
            dateTimePicker_productionDate.Name = "dateTimePicker_productionDate";
            dateTimePicker_productionDate.Size = new Size(285, 33);
            dateTimePicker_productionDate.TabIndex = 35;
            dateTimePicker_productionDate.ValueChanged += dateTimePicker_productionDate_ValueChanged;
            // 
            // comboBox_status
            // 
            comboBox_status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_status.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "入庫", "出庫" });
            comboBox_status.Location = new Point(93, 356);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(345, 33);
            comboBox_status.TabIndex = 36;
            // 
            // label_error_quantity
            // 
            label_error_quantity.AutoSize = true;
            label_error_quantity.ForeColor = Color.Red;
            label_error_quantity.Location = new Point(147, 329);
            label_error_quantity.Name = "label_error_quantity";
            label_error_quantity.Size = new Size(61, 19);
            label_error_quantity.TabIndex = 39;
            label_error_quantity.Text = "*請選擇";
            label_error_quantity.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 289);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 35);
            label7.TabIndex = 38;
            label7.Text = "數量:";
            // 
            // numericUpDown_quantity
            // 
            numericUpDown_quantity.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_quantity.Location = new Point(89, 293);
            numericUpDown_quantity.Name = "numericUpDown_quantity";
            numericUpDown_quantity.Size = new Size(345, 33);
            numericUpDown_quantity.TabIndex = 40;
            // 
            // comboBox_workerorderNum
            // 
            comboBox_workerorderNum.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_workerorderNum.FormattingEnabled = true;
            comboBox_workerorderNum.Location = new Point(147, 234);
            comboBox_workerorderNum.Name = "comboBox_workerorderNum";
            comboBox_workerorderNum.Size = new Size(287, 33);
            comboBox_workerorderNum.TabIndex = 41;
            // 
            // Form_product_add
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 669);
            Controls.Add(comboBox_workerorderNum);
            Controls.Add(numericUpDown_quantity);
            Controls.Add(label_error_quantity);
            Controls.Add(label7);
            Controls.Add(comboBox_status);
            Controls.Add(dateTimePicker_productionDate);
            Controls.Add(label_error_state);
            Controls.Add(label_error_workerorderNum);
            Controls.Add(label_error_name);
            Controls.Add(button_save);
            Controls.Add(textBox_notes);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form_product_add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "倉儲管理系統";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_notes;
        private Label label8;
        private Label label5;
        private Label label4;
        private TextBox textBox_name;
        private Label label3;
        private Label label2;
        private Button button_save;
        private Label label_error_name;
        private Label label_error_workerorderNum;
        private Label label_error_state;
        private DateTimePicker dateTimePicker_productionDate;
        private ComboBox comboBox_status;
        private Label label_error_quantity;
        private Label label7;
        private NumericUpDown numericUpDown_quantity;
        private ComboBox comboBox_workerorderNum;
    }
}