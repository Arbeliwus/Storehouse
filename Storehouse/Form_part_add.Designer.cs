namespace Storehouse
{
    partial class Form_part_add
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
            label2 = new Label();
            label3 = new Label();
            textBox_name = new TextBox();
            button_save = new Button();
            label6 = new Label();
            textBox_supplier = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label8 = new Label();
            textBox_notes = new TextBox();
            label_error_name = new Label();
            label_error_quantity = new Label();
            label_error_price = new Label();
            label_error_MOQ = new Label();
            label_error_supplier = new Label();
            label_error_type = new Label();
            label_error_part_no = new Label();
            textBox_partNo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            comboBox_status = new ComboBox();
            label_error_status = new Label();
            label4 = new Label();
            comboBox_type = new ComboBox();
            numericUpDown_quantity = new NumericUpDown();
            numericUpDown_price = new NumericUpDown();
            numericUpDown_MOQ = new NumericUpDown();
            label_error_model = new Label();
            textBox_model = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MOQ).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 43);
            label1.TabIndex = 0;
            label1.Text = "新增項目";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 35);
            label2.TabIndex = 1;
            label2.Text = "品名:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 154);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 35);
            label3.TabIndex = 2;
            label3.Text = "數量:";
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_name.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name.Location = new Point(81, 80);
            textBox_name.Margin = new Padding(4);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "請輸入品名";
            textBox_name.Size = new Size(181, 38);
            textBox_name.TabIndex = 1;
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.Top;
            button_save.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_save.Location = new Point(235, 595);
            button_save.Margin = new Padding(4);
            button_save.Name = "button_save";
            button_save.Size = new Size(96, 43);
            button_save.TabIndex = 11;
            button_save.Text = "儲存";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 317);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 35);
            label6.TabIndex = 10;
            label6.Text = "MOQ:";
            // 
            // textBox_supplier
            // 
            textBox_supplier.BorderStyle = BorderStyle.FixedSingle;
            textBox_supplier.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_supplier.Location = new Point(108, 397);
            textBox_supplier.Margin = new Padding(4);
            textBox_supplier.Name = "textBox_supplier";
            textBox_supplier.PlaceholderText = "請輸入供應商";
            textBox_supplier.Size = new Size(156, 38);
            textBox_supplier.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(11, 400);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 35);
            label7.TabIndex = 12;
            label7.Text = "供應商:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(287, 157);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 35);
            label5.TabIndex = 14;
            label5.Text = "價格:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 472);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 35);
            label8.TabIndex = 16;
            label8.Text = "備註:";
            // 
            // textBox_notes
            // 
            textBox_notes.BorderStyle = BorderStyle.FixedSingle;
            textBox_notes.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_notes.Location = new Point(95, 462);
            textBox_notes.Margin = new Padding(4);
            textBox_notes.Multiline = true;
            textBox_notes.Name = "textBox_notes";
            textBox_notes.Size = new Size(445, 106);
            textBox_notes.TabIndex = 10;
            // 
            // label_error_name
            // 
            label_error_name.AutoSize = true;
            label_error_name.ForeColor = Color.Red;
            label_error_name.Location = new Point(81, 122);
            label_error_name.Name = "label_error_name";
            label_error_name.Size = new Size(91, 19);
            label_error_name.TabIndex = 17;
            label_error_name.Text = "*請輸入品名";
            label_error_name.Visible = false;
            // 
            // label_error_quantity
            // 
            label_error_quantity.AutoSize = true;
            label_error_quantity.ForeColor = Color.Red;
            label_error_quantity.Location = new Point(110, 194);
            label_error_quantity.Name = "label_error_quantity";
            label_error_quantity.Size = new Size(91, 19);
            label_error_quantity.TabIndex = 18;
            label_error_quantity.Text = "*請填寫數量";
            label_error_quantity.Visible = false;
            // 
            // label_error_price
            // 
            label_error_price.AutoSize = true;
            label_error_price.ForeColor = Color.Red;
            label_error_price.Location = new Point(369, 195);
            label_error_price.Name = "label_error_price";
            label_error_price.Size = new Size(91, 19);
            label_error_price.TabIndex = 20;
            label_error_price.Text = "*請填寫價格";
            label_error_price.Visible = false;
            // 
            // label_error_MOQ
            // 
            label_error_MOQ.AutoSize = true;
            label_error_MOQ.ForeColor = Color.Red;
            label_error_MOQ.Location = new Point(95, 361);
            label_error_MOQ.Name = "label_error_MOQ";
            label_error_MOQ.Size = new Size(99, 19);
            label_error_MOQ.TabIndex = 21;
            label_error_MOQ.Text = "*請填寫MOQ";
            label_error_MOQ.Visible = false;
            // 
            // label_error_supplier
            // 
            label_error_supplier.AutoSize = true;
            label_error_supplier.ForeColor = Color.Red;
            label_error_supplier.Location = new Point(108, 439);
            label_error_supplier.Name = "label_error_supplier";
            label_error_supplier.Size = new Size(106, 19);
            label_error_supplier.TabIndex = 22;
            label_error_supplier.Text = "*請輸入供應商";
            label_error_supplier.Visible = false;
            // 
            // label_error_type
            // 
            label_error_type.AutoSize = true;
            label_error_type.ForeColor = Color.Red;
            label_error_type.Location = new Point(363, 120);
            label_error_type.Name = "label_error_type";
            label_error_type.Size = new Size(91, 19);
            label_error_type.TabIndex = 26;
            label_error_type.Text = "*請選擇類型";
            label_error_type.Visible = false;
            // 
            // label_error_part_no
            // 
            label_error_part_no.AutoSize = true;
            label_error_part_no.ForeColor = Color.Red;
            label_error_part_no.Location = new Point(83, 276);
            label_error_part_no.Name = "label_error_part_no";
            label_error_part_no.Size = new Size(91, 19);
            label_error_part_no.TabIndex = 29;
            label_error_part_no.Text = "*請輸入料號";
            label_error_part_no.Visible = false;
            // 
            // textBox_partNo
            // 
            textBox_partNo.BorderStyle = BorderStyle.FixedSingle;
            textBox_partNo.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_partNo.Location = new Point(83, 234);
            textBox_partNo.Margin = new Padding(4);
            textBox_partNo.Name = "textBox_partNo";
            textBox_partNo.PlaceholderText = "請輸入料號";
            textBox_partNo.Size = new Size(181, 38);
            textBox_partNo.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(11, 240);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 35);
            label9.TabIndex = 28;
            label9.Text = "料號:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(287, 234);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(75, 35);
            label10.TabIndex = 31;
            label10.Text = "狀態:";
            // 
            // comboBox_status
            // 
            comboBox_status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_status.FlatStyle = FlatStyle.System;
            comboBox_status.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "進貨", "出貨" });
            comboBox_status.Location = new Point(359, 234);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(177, 33);
            comboBox_status.TabIndex = 6;
            // 
            // label_error_status
            // 
            label_error_status.AutoSize = true;
            label_error_status.ForeColor = Color.Red;
            label_error_status.Location = new Point(363, 270);
            label_error_status.Name = "label_error_status";
            label_error_status.Size = new Size(91, 19);
            label_error_status.TabIndex = 33;
            label_error_status.Text = "*請選擇狀態";
            label_error_status.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(287, 80);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 34;
            label4.Text = "類型:";
            // 
            // comboBox_type
            // 
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_type.FlatStyle = FlatStyle.System;
            comboBox_type.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Items.AddRange(new object[] { "主料", "替代料" });
            comboBox_type.Location = new Point(359, 80);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new Size(177, 33);
            comboBox_type.TabIndex = 2;
            // 
            // numericUpDown_quantity
            // 
            numericUpDown_quantity.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_quantity.Location = new Point(95, 155);
            numericUpDown_quantity.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown_quantity.Name = "numericUpDown_quantity";
            numericUpDown_quantity.Size = new Size(171, 37);
            numericUpDown_quantity.TabIndex = 3;
            numericUpDown_quantity.ThousandsSeparator = true;
            // 
            // numericUpDown_price
            // 
            numericUpDown_price.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_price.Location = new Point(369, 155);
            numericUpDown_price.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown_price.Name = "numericUpDown_price";
            numericUpDown_price.Size = new Size(171, 37);
            numericUpDown_price.TabIndex = 4;
            numericUpDown_price.ThousandsSeparator = true;
            // 
            // numericUpDown_MOQ
            // 
            numericUpDown_MOQ.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_MOQ.Location = new Point(95, 321);
            numericUpDown_MOQ.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown_MOQ.Name = "numericUpDown_MOQ";
            numericUpDown_MOQ.Size = new Size(171, 37);
            numericUpDown_MOQ.TabIndex = 7;
            numericUpDown_MOQ.ThousandsSeparator = true;
            // 
            // label_error_model
            // 
            label_error_model.AutoSize = true;
            label_error_model.ForeColor = Color.Red;
            label_error_model.Location = new Point(369, 356);
            label_error_model.Name = "label_error_model";
            label_error_model.Size = new Size(91, 19);
            label_error_model.TabIndex = 40;
            label_error_model.Text = "*請輸入型號";
            label_error_model.Visible = false;
            // 
            // textBox_model
            // 
            textBox_model.BorderStyle = BorderStyle.FixedSingle;
            textBox_model.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_model.Location = new Point(359, 314);
            textBox_model.Margin = new Padding(4);
            textBox_model.Name = "textBox_model";
            textBox_model.PlaceholderText = "請輸入型號";
            textBox_model.Size = new Size(181, 38);
            textBox_model.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(287, 317);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(75, 35);
            label12.TabIndex = 39;
            label12.Text = "型號:";
            // 
            // Form_part_add
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 670);
            Controls.Add(label_error_model);
            Controls.Add(textBox_model);
            Controls.Add(label12);
            Controls.Add(numericUpDown_MOQ);
            Controls.Add(numericUpDown_price);
            Controls.Add(numericUpDown_quantity);
            Controls.Add(comboBox_type);
            Controls.Add(label4);
            Controls.Add(label_error_status);
            Controls.Add(comboBox_status);
            Controls.Add(label10);
            Controls.Add(label_error_part_no);
            Controls.Add(textBox_partNo);
            Controls.Add(label9);
            Controls.Add(label_error_type);
            Controls.Add(label_error_supplier);
            Controls.Add(label_error_MOQ);
            Controls.Add(label_error_price);
            Controls.Add(label_error_quantity);
            Controls.Add(label_error_name);
            Controls.Add(textBox_notes);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textBox_supplier);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button_save);
            Controls.Add(textBox_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form_part_add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "倉儲管理系統";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_MOQ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox textBox_name;
        private Button button_save;
        private TextBox textBox_supplier;
        private Label label7;
        private Label label5;
        private Label label8;
        private TextBox textBox_notes;
        private Label label_error_name;
        private Label label_error_quantity;
        private Label label_error_price;
        private Label label_error_MOQ;
        private Label label_error_supplier;
        private Label label_error_type;
        private Label label_error_part_no;
        private TextBox textBox_partNo;
        private Label label9;
        private Label label10;
        private ComboBox comboBox_status;
        private Label label_error_status;
        private Label label4;
        private ComboBox comboBox_type;
        private NumericUpDown numericUpDown_quantity;
        private NumericUpDown numericUpDown_price;
        private NumericUpDown numericUpDown_MOQ;
        private Label label_error_model;
        private TextBox textBox_model;
        private Label label12;
    }
}