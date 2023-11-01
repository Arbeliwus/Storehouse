namespace Storehouse
{
    partial class Form_part_update
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
            textBox_partNo = new TextBox();
            label5 = new Label();
            textBox_supplier = new TextBox();
            label6 = new Label();
            label4 = new Label();
            textBox_name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            comboBox_type = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            comboBox_status = new ComboBox();
            numericUpDown_quantity = new NumericUpDown();
            numericUpDown_price = new NumericUpDown();
            numericUpDown_MOQ = new NumericUpDown();
            textBox_model = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MOQ).BeginInit();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_cancel.Location = new Point(587, 360);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(122, 43);
            button_cancel.TabIndex = 11;
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
            button_save.TabIndex = 10;
            button_save.Text = "儲存";
            button_save.UseVisualStyleBackColor = true;
            button_save.MouseClick += button_save_MouseClick;
            // 
            // textBox_notes
            // 
            textBox_notes.BorderStyle = BorderStyle.FixedSingle;
            textBox_notes.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_notes.Location = new Point(433, 270);
            textBox_notes.Margin = new Padding(4);
            textBox_notes.Multiline = true;
            textBox_notes.Name = "textBox_notes";
            textBox_notes.Size = new Size(192, 83);
            textBox_notes.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(350, 270);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 35);
            label8.TabIndex = 75;
            label8.Text = "備註:";
            // 
            // textBox_partNo
            // 
            textBox_partNo.BorderStyle = BorderStyle.FixedSingle;
            textBox_partNo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_partNo.Location = new Point(121, 170);
            textBox_partNo.Margin = new Padding(4);
            textBox_partNo.Name = "textBox_partNo";
            textBox_partNo.PlaceholderText = "請輸入料號";
            textBox_partNo.Size = new Size(176, 38);
            textBox_partNo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 170);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 35);
            label5.TabIndex = 73;
            label5.Text = "料號:";
            // 
            // textBox_supplier
            // 
            textBox_supplier.BorderStyle = BorderStyle.FixedSingle;
            textBox_supplier.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_supplier.Location = new Point(433, 220);
            textBox_supplier.Margin = new Padding(4);
            textBox_supplier.Name = "textBox_supplier";
            textBox_supplier.PlaceholderText = "請輸入供應商";
            textBox_supplier.Size = new Size(192, 38);
            textBox_supplier.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(323, 223);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 35);
            label6.TabIndex = 71;
            label6.Text = "供應商:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(350, 70);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 69;
            label4.Text = "類型:";
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name.Location = new Point(121, 70);
            textBox_name.Margin = new Padding(4);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "請輸入品名";
            textBox_name.Size = new Size(176, 38);
            textBox_name.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 122);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 35);
            label3.TabIndex = 66;
            label3.Text = "數量:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 70);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 220);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 35);
            label7.TabIndex = 79;
            label7.Text = "MOQ:";
            // 
            // comboBox_type
            // 
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_type.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Items.AddRange(new object[] { "主料", "替代料" });
            comboBox_type.Location = new Point(432, 73);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new Size(193, 33);
            comboBox_type.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(350, 120);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 35);
            label9.TabIndex = 82;
            label9.Text = "價格:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(351, 172);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(75, 35);
            label10.TabIndex = 83;
            label10.Text = "狀態:";
            // 
            // comboBox_status
            // 
            comboBox_status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_status.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "進貨", "出貨" });
            comboBox_status.Location = new Point(433, 175);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(192, 33);
            comboBox_status.TabIndex = 6;
            // 
            // numericUpDown_quantity
            // 
            numericUpDown_quantity.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_quantity.Location = new Point(121, 124);
            numericUpDown_quantity.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown_quantity.Name = "numericUpDown_quantity";
            numericUpDown_quantity.Size = new Size(176, 33);
            numericUpDown_quantity.TabIndex = 3;
            numericUpDown_quantity.ThousandsSeparator = true;
            // 
            // numericUpDown_price
            // 
            numericUpDown_price.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_price.Location = new Point(433, 124);
            numericUpDown_price.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown_price.Name = "numericUpDown_price";
            numericUpDown_price.Size = new Size(192, 33);
            numericUpDown_price.TabIndex = 4;
            numericUpDown_price.ThousandsSeparator = true;
            // 
            // numericUpDown_MOQ
            // 
            numericUpDown_MOQ.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_MOQ.Location = new Point(120, 227);
            numericUpDown_MOQ.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown_MOQ.Name = "numericUpDown_MOQ";
            numericUpDown_MOQ.Size = new Size(177, 33);
            numericUpDown_MOQ.TabIndex = 7;
            numericUpDown_MOQ.ThousandsSeparator = true;
            // 
            // textBox_model
            // 
            textBox_model.BorderStyle = BorderStyle.FixedSingle;
            textBox_model.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_model.Location = new Point(121, 270);
            textBox_model.Margin = new Padding(4);
            textBox_model.Name = "textBox_model";
            textBox_model.PlaceholderText = "請輸入型號";
            textBox_model.Size = new Size(176, 38);
            textBox_model.TabIndex = 84;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(38, 270);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(75, 35);
            label11.TabIndex = 85;
            label11.Text = "型號:";
            // 
            // Form_part_update
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(721, 415);
            Controls.Add(textBox_model);
            Controls.Add(label11);
            Controls.Add(numericUpDown_MOQ);
            Controls.Add(numericUpDown_price);
            Controls.Add(numericUpDown_quantity);
            Controls.Add(comboBox_status);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox_type);
            Controls.Add(label7);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textBox_notes);
            Controls.Add(label8);
            Controls.Add(textBox_partNo);
            Controls.Add(label5);
            Controls.Add(textBox_supplier);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBox_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_part_update";
            StartPosition = FormStartPosition.CenterParent;
            Text = "倉儲管理系統";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MOQ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        private TextBox textBox_notes;
        private Label label8;
        private TextBox textBox_partNo;
        private Label label5;
        private TextBox textBox_supplier;
        private Label label6;
        private Label label4;
        private TextBox textBox_name;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox comboBox_type;
        private Label label9;
        private Label label10;
        private ComboBox comboBox_status;
        private NumericUpDown numericUpDown_quantity;
        private NumericUpDown numericUpDown_price;
        private NumericUpDown numericUpDown_MOQ;
        private TextBox textBox_model;
        private Label label11;
    }
}