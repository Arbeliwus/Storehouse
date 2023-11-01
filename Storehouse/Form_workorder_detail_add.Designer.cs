namespace Storehouse
{
    partial class Form_workorder_detail_add
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
            label6 = new Label();
            label4 = new Label();
            save = new Button();
            label3 = new Label();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBox_name = new ComboBox();
            comboBox_partNo = new ComboBox();
            comboBox_supplier = new ComboBox();
            numericUpDown_quantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).BeginInit();
            SuspendLayout();
            // 
            // textBox_notes
            // 
            textBox_notes.BorderStyle = BorderStyle.FixedSingle;
            textBox_notes.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_notes.Location = new Point(97, 337);
            textBox_notes.Margin = new Padding(4);
            textBox_notes.Multiline = true;
            textBox_notes.Name = "textBox_notes";
            textBox_notes.Size = new Size(351, 252);
            textBox_notes.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(20, 337);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 35);
            label8.TabIndex = 48;
            label8.Text = "備註:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 206);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 35);
            label5.TabIndex = 46;
            label5.Text = "消耗數量:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 272);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 35);
            label6.TabIndex = 42;
            label6.Text = "供應商:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 40;
            label4.Text = "料號:";
            // 
            // save
            // 
            save.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            save.Location = new Point(168, 597);
            save.Margin = new Padding(4);
            save.Name = "save";
            save.Size = new Size(96, 43);
            save.TabIndex = 7;
            save.Text = "儲存";
            save.UseVisualStyleBackColor = true;
            save.MouseClick += save_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 35);
            label3.TabIndex = 36;
            label3.Text = "品名:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(158, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 43);
            label1.TabIndex = 34;
            label1.Text = "新增項目";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(154, 117);
            label9.Name = "label9";
            label9.Size = new Size(46, 19);
            label9.TabIndex = 50;
            label9.Text = "*必填";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(154, 181);
            label10.Name = "label10";
            label10.Size = new Size(46, 19);
            label10.TabIndex = 51;
            label10.Text = "*必填";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(158, 248);
            label11.Name = "label11";
            label11.Size = new Size(46, 19);
            label11.TabIndex = 52;
            label11.Text = "*必填";
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(154, 314);
            label12.Name = "label12";
            label12.Size = new Size(46, 19);
            label12.TabIndex = 53;
            label12.Text = "*必填";
            label12.Visible = false;
            // 
            // comboBox_name
            // 
            comboBox_name.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_name.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_name.FormattingEnabled = true;
            comboBox_name.Location = new Point(97, 78);
            comboBox_name.Name = "comboBox_name";
            comboBox_name.Size = new Size(345, 33);
            comboBox_name.TabIndex = 54;
            comboBox_name.SelectionChangeCommitted += comboBox_name_SelectionChangeCommitted;
            // 
            // comboBox_partNo
            // 
            comboBox_partNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_partNo.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_partNo.FormattingEnabled = true;
            comboBox_partNo.Location = new Point(97, 142);
            comboBox_partNo.Name = "comboBox_partNo";
            comboBox_partNo.Size = new Size(345, 33);
            comboBox_partNo.TabIndex = 55;
            // 
            // comboBox_supplier
            // 
            comboBox_supplier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_supplier.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_supplier.FormattingEnabled = true;
            comboBox_supplier.Location = new Point(130, 272);
            comboBox_supplier.Name = "comboBox_supplier";
            comboBox_supplier.Size = new Size(312, 33);
            comboBox_supplier.TabIndex = 56;
            // 
            // numericUpDown_quantity
            // 
            numericUpDown_quantity.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_quantity.Location = new Point(154, 210);
            numericUpDown_quantity.Name = "numericUpDown_quantity";
            numericUpDown_quantity.Size = new Size(288, 33);
            numericUpDown_quantity.TabIndex = 57;
            // 
            // Form_workorder_detail_add
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(465, 669);
            Controls.Add(numericUpDown_quantity);
            Controls.Add(comboBox_supplier);
            Controls.Add(comboBox_partNo);
            Controls.Add(comboBox_name);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox_notes);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(save);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form_workorder_detail_add";
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
        private Label label6;
        private Label label4;
        private Button save;
        private Label label3;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboBox_name;
        private ComboBox comboBox_partNo;
        private ComboBox comboBox_supplier;
        private NumericUpDown numericUpDown_quantity;
    }
}