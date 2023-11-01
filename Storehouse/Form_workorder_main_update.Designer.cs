namespace Storehouse
{
    partial class Form_workorder_main_update
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
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_work_num = new TextBox();
            textBox_name = new TextBox();
            textBox_model = new TextBox();
            textBox_notes = new TextBox();
            button_save = new Button();
            button_cancel = new Button();
            comboBox_status = new ComboBox();
            dateTimePicker_productionDate = new DateTimePicker();
            numericUpDown_quantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).BeginInit();
            SuspendLayout();
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
            label1.TabIndex = 19;
            label1.Text = "修改項目";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(40, 215);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 35);
            label8.TabIndex = 39;
            label8.Text = "備註:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(383, 115);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 35);
            label5.TabIndex = 38;
            label5.Text = "產品數量:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(383, 165);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 35);
            label7.TabIndex = 37;
            label7.Text = "生產日期:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(40, 165);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 35);
            label6.TabIndex = 36;
            label6.Text = "產品狀態:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 35);
            label4.TabIndex = 35;
            label4.Text = "產品型號:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(383, 65);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 35);
            label3.TabIndex = 34;
            label3.Text = "產品名稱:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 35);
            label2.TabIndex = 33;
            label2.Text = "工單編號:";
            // 
            // textBox_work_num
            // 
            textBox_work_num.BorderStyle = BorderStyle.FixedSingle;
            textBox_work_num.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_work_num.Location = new Point(176, 69);
            textBox_work_num.Name = "textBox_work_num";
            textBox_work_num.Size = new Size(151, 33);
            textBox_work_num.TabIndex = 1;
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_name.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name.Location = new Point(519, 73);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(190, 33);
            textBox_name.TabIndex = 2;
            // 
            // textBox_model
            // 
            textBox_model.BorderStyle = BorderStyle.FixedSingle;
            textBox_model.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_model.Location = new Point(176, 119);
            textBox_model.Name = "textBox_model";
            textBox_model.Size = new Size(151, 33);
            textBox_model.TabIndex = 3;
            // 
            // textBox_notes
            // 
            textBox_notes.BorderStyle = BorderStyle.FixedSingle;
            textBox_notes.Location = new Point(113, 223);
            textBox_notes.Multiline = true;
            textBox_notes.Name = "textBox_notes";
            textBox_notes.Size = new Size(359, 131);
            textBox_notes.TabIndex = 7;
            // 
            // button_save
            // 
            button_save.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_save.Location = new Point(459, 360);
            button_save.Name = "button_save";
            button_save.Size = new Size(122, 43);
            button_save.TabIndex = 8;
            button_save.Text = "儲存";
            button_save.UseVisualStyleBackColor = true;
            button_save.MouseClick += button_save_MouseClick;
            // 
            // button_cancel
            // 
            button_cancel.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_cancel.Location = new Point(587, 360);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(122, 43);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.MouseClick += button_cancel_MouseClick;
            // 
            // comboBox_status
            // 
            comboBox_status.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "完成", "未完成" });
            comboBox_status.Location = new Point(176, 167);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(151, 33);
            comboBox_status.TabIndex = 40;
            // 
            // dateTimePicker_productionDate
            // 
            dateTimePicker_productionDate.CalendarFont = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_productionDate.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_productionDate.Location = new Point(519, 164);
            dateTimePicker_productionDate.Name = "dateTimePicker_productionDate";
            dateTimePicker_productionDate.Size = new Size(190, 33);
            dateTimePicker_productionDate.TabIndex = 41;
            // 
            // numericUpDown_quantity
            // 
            numericUpDown_quantity.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_quantity.Location = new Point(519, 118);
            numericUpDown_quantity.Name = "numericUpDown_quantity";
            numericUpDown_quantity.Size = new Size(190, 33);
            numericUpDown_quantity.TabIndex = 42;
            // 
            // Form_workorder_main_update
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(721, 415);
            Controls.Add(numericUpDown_quantity);
            Controls.Add(dateTimePicker_productionDate);
            Controls.Add(comboBox_status);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textBox_notes);
            Controls.Add(textBox_model);
            Controls.Add(textBox_name);
            Controls.Add(textBox_work_num);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form_workorder_main_update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "倉儲管理系統";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox_work_num;
        private TextBox textBox_name;
        private TextBox textBox_model;
        private TextBox textBox_notes;
        private Button button_save;
        private Button button_cancel;
        private ComboBox comboBox_status;
        private DateTimePicker dateTimePicker_productionDate;
        private NumericUpDown numericUpDown_quantity;
    }
}