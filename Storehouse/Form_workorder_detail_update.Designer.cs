namespace Storehouse
{
    partial class Form_workorder_detail_update
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
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            button_cancel = new Button();
            button_save = new Button();
            comboBox_name = new ComboBox();
            comboBox_partNo = new ComboBox();
            numericUpDown_quantity = new NumericUpDown();
            comboBox_supplier = new ComboBox();
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
            label1.TabIndex = 20;
            label1.Text = "修改項目";
            // 
            // textBox_notes
            // 
            textBox_notes.BorderStyle = BorderStyle.FixedSingle;
            textBox_notes.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_notes.Location = new Point(123, 172);
            textBox_notes.Margin = new Padding(4);
            textBox_notes.Multiline = true;
            textBox_notes.Name = "textBox_notes";
            textBox_notes.Size = new Size(335, 170);
            textBox_notes.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(40, 172);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 35);
            label8.TabIndex = 60;
            label8.Text = "備註:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 112);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 35);
            label5.TabIndex = 58;
            label5.Text = "消耗數量:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(383, 114);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 35);
            label6.TabIndex = 56;
            label6.Text = "供應商:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(383, 60);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 54;
            label4.Text = "料號:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 63);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 35);
            label3.TabIndex = 51;
            label3.Text = "品名:";
            // 
            // button_cancel
            // 
            button_cancel.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_cancel.Location = new Point(579, 360);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(122, 43);
            button_cancel.TabIndex = 8;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.MouseClick += button_cancel_MouseClick;
            // 
            // button_save
            // 
            button_save.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_save.Location = new Point(451, 360);
            button_save.Name = "button_save";
            button_save.Size = new Size(122, 43);
            button_save.TabIndex = 7;
            button_save.Text = "儲存";
            button_save.UseVisualStyleBackColor = true;
            button_save.MouseClick += button_save_MouseClick;
            // 
            // comboBox_name
            // 
            comboBox_name.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_name.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_name.FormattingEnabled = true;
            comboBox_name.Location = new Point(113, 66);
            comboBox_name.Name = "comboBox_name";
            comboBox_name.Size = new Size(204, 33);
            comboBox_name.TabIndex = 61;
            comboBox_name.SelectionChangeCommitted += comboBox_name_SelectionChangeCommitted;
            // 
            // comboBox_partNo
            // 
            comboBox_partNo.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_partNo.FormattingEnabled = true;
            comboBox_partNo.Location = new Point(465, 62);
            comboBox_partNo.Name = "comboBox_partNo";
            comboBox_partNo.Size = new Size(222, 33);
            comboBox_partNo.TabIndex = 62;
            // 
            // numericUpDown_quantity
            // 
            numericUpDown_quantity.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_quantity.Location = new Point(176, 116);
            numericUpDown_quantity.Name = "numericUpDown_quantity";
            numericUpDown_quantity.Size = new Size(141, 33);
            numericUpDown_quantity.TabIndex = 63;
            // 
            // comboBox_supplier
            // 
            comboBox_supplier.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_supplier.FormattingEnabled = true;
            comboBox_supplier.Location = new Point(492, 115);
            comboBox_supplier.Name = "comboBox_supplier";
            comboBox_supplier.Size = new Size(195, 33);
            comboBox_supplier.TabIndex = 64;
            // 
            // Form_workorder_detail_update
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 415);
            Controls.Add(comboBox_supplier);
            Controls.Add(numericUpDown_quantity);
            Controls.Add(comboBox_partNo);
            Controls.Add(comboBox_name);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textBox_notes);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form_workorder_detail_update";
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
        private Label label6;
        private Label label4;
        private Label label3;
        private Button button_cancel;
        private Button button_save;
        private ComboBox comboBox_name;
        private ComboBox comboBox_partNo;
        private NumericUpDown numericUpDown_quantity;
        private ComboBox comboBox_supplier;
    }
}