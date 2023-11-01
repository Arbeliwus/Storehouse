namespace Storehouse
{
    partial class Form_product_update
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
            button_cancel = new Button();
            button_save = new Button();
            textBox_notes = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox_name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            numericUpDown_quantity = new NumericUpDown();
            comboBox_status = new ComboBox();
            dateTimePicker_productionDate = new DateTimePicker();
            comboBox_workerorderNum = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).BeginInit();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_cancel.Location = new Point(587, 360);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(122, 43);
            button_cancel.TabIndex = 7;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.MouseClick += button_cancel_MouseClick;
            // 
            // button_save
            // 
            button_save.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_save.Location = new Point(459, 360);
            button_save.Name = "button_save";
            button_save.Size = new Size(122, 43);
            button_save.TabIndex = 6;
            button_save.Text = "儲存";
            button_save.UseVisualStyleBackColor = true;
            button_save.MouseClick += button_save_MouseClick;
            // 
            // textBox_notes
            // 
            textBox_notes.BackColor = SystemColors.Window;
            textBox_notes.BorderStyle = BorderStyle.FixedSingle;
            textBox_notes.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_notes.Location = new Point(122, 228);
            textBox_notes.Margin = new Padding(4);
            textBox_notes.Multiline = true;
            textBox_notes.Name = "textBox_notes";
            textBox_notes.Size = new Size(303, 123);
            textBox_notes.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(40, 228);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 35);
            label8.TabIndex = 75;
            label8.Text = "備註:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 172);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 35);
            label5.TabIndex = 73;
            label5.Text = "生產日期:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(383, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 69;
            label4.Text = "狀態:";
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name.Location = new Point(123, 65);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(176, 38);
            textBox_name.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(383, 70);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 35);
            label3.TabIndex = 66;
            label3.Text = "工單編號:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 35);
            label2.TabIndex = 65;
            label2.Text = "品名:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 43);
            label1.TabIndex = 64;
            label1.Text = "修改項目";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(40, 115);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 35);
            label6.TabIndex = 76;
            label6.Text = "數量:";
            // 
            // numericUpDown_quantity
            // 
            numericUpDown_quantity.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_quantity.Location = new Point(122, 119);
            numericUpDown_quantity.Name = "numericUpDown_quantity";
            numericUpDown_quantity.Size = new Size(177, 33);
            numericUpDown_quantity.TabIndex = 77;
            // 
            // comboBox_status
            // 
            comboBox_status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_status.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "入庫", "出庫" });
            comboBox_status.Location = new Point(459, 117);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(231, 33);
            comboBox_status.TabIndex = 78;
            // 
            // dateTimePicker_productionDate
            // 
            dateTimePicker_productionDate.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_productionDate.Location = new Point(175, 172);
            dateTimePicker_productionDate.Name = "dateTimePicker_productionDate";
            dateTimePicker_productionDate.Size = new Size(250, 33);
            dateTimePicker_productionDate.TabIndex = 79;
            dateTimePicker_productionDate.ValueChanged += dateTimePicker_productionDate_ValueChanged;
            // 
            // comboBox_workerorderNum
            // 
            comboBox_workerorderNum.BackColor = Color.White;
            comboBox_workerorderNum.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_workerorderNum.FormattingEnabled = true;
            comboBox_workerorderNum.Location = new Point(516, 72);
            comboBox_workerorderNum.Name = "comboBox_workerorderNum";
            comboBox_workerorderNum.Size = new Size(174, 33);
            comboBox_workerorderNum.TabIndex = 80;
            // 
            // Form_product_update
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(721, 415);
            Controls.Add(comboBox_workerorderNum);
            Controls.Add(dateTimePicker_productionDate);
            Controls.Add(comboBox_status);
            Controls.Add(numericUpDown_quantity);
            Controls.Add(label6);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textBox_notes);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_product_update";
            StartPosition = FormStartPosition.CenterParent;
            Text = "倉儲管理系統";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        private TextBox textBox_notes;
        private Label label8;
        private Label label5;
        private Label label4;
        private TextBox textBox_name;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private NumericUpDown numericUpDown_quantity;
        private ComboBox comboBox_status;
        private DateTimePicker dateTimePicker_productionDate;
        private ComboBox comboBox_workerorderNum;
    }
}