namespace Storehouse
{
    partial class Form_workorder_detail
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label_num = new Label();
            label2 = new Label();
            label_model = new Label();
            label4 = new Label();
            label_count = new Label();
            label7 = new Label();
            label_name = new Label();
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            label_state = new Label();
            label10 = new Label();
            label_productiondate = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            workid = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "工單編號:";
            // 
            // label_num
            // 
            label_num.BackColor = SystemColors.ControlLight;
            label_num.BorderStyle = BorderStyle.FixedSingle;
            label_num.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_num.Location = new Point(122, 33);
            label_num.Name = "label_num";
            label_num.Size = new Size(133, 25);
            label_num.TabIndex = 4;
            label_num.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 9;
            label2.Text = "產品型號:";
            // 
            // label_model
            // 
            label_model.BackColor = SystemColors.ControlLight;
            label_model.BorderStyle = BorderStyle.FixedSingle;
            label_model.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_model.Location = new Point(122, 78);
            label_model.Name = "label_model";
            label_model.Size = new Size(133, 25);
            label_model.TabIndex = 10;
            label_model.Text = "                   ";
            label_model.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(261, 78);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 11;
            label4.Text = "產品數量:";
            // 
            // label_count
            // 
            label_count.BackColor = SystemColors.ControlLight;
            label_count.BorderStyle = BorderStyle.FixedSingle;
            label_count.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_count.Location = new Point(359, 78);
            label_count.Name = "label_count";
            label_count.Size = new Size(169, 25);
            label_count.TabIndex = 12;
            label_count.Text = "                   ";
            label_count.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(261, 33);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 13;
            label7.Text = "產品名稱:";
            // 
            // label_name
            // 
            label_name.BackColor = SystemColors.ControlLight;
            label_name.BorderStyle = BorderStyle.FixedSingle;
            label_name.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.Location = new Point(359, 33);
            label_name.Name = "label_name";
            label_name.Size = new Size(169, 25);
            label_name.TabIndex = 14;
            label_name.Text = "                   ";
            label_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_add
            // 
            button_add.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_add.Location = new Point(534, 27);
            button_add.Name = "button_add";
            button_add.Size = new Size(117, 38);
            button_add.TabIndex = 15;
            button_add.Text = "新增項目";
            button_add.UseVisualStyleBackColor = true;
            button_add.MouseClick += button_add_MouseClick;
            // 
            // button_update
            // 
            button_update.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_update.Location = new Point(534, 71);
            button_update.Name = "button_update";
            button_update.Size = new Size(117, 38);
            button_update.TabIndex = 16;
            button_update.Text = "修改項目";
            button_update.UseVisualStyleBackColor = true;
            button_update.MouseClick += button_update_MouseClick;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_delete.Location = new Point(534, 115);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(117, 38);
            button_delete.TabIndex = 17;
            button_delete.Text = "刪除項目";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.MouseClick += button_delete_MouseClick;
            // 
            // label_state
            // 
            label_state.BackColor = SystemColors.ControlLight;
            label_state.BorderStyle = BorderStyle.FixedSingle;
            label_state.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_state.Location = new Point(122, 122);
            label_state.Name = "label_state";
            label_state.Size = new Size(133, 25);
            label_state.TabIndex = 20;
            label_state.Text = "         ";
            label_state.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(24, 122);
            label10.Name = "label10";
            label10.Size = new Size(97, 25);
            label10.TabIndex = 19;
            label10.Text = "產品狀態:";
            // 
            // label_productiondate
            // 
            label_productiondate.BackColor = SystemColors.ControlLight;
            label_productiondate.BorderStyle = BorderStyle.FixedSingle;
            label_productiondate.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_productiondate.Location = new Point(359, 122);
            label_productiondate.Name = "label_productiondate";
            label_productiondate.Size = new Size(169, 25);
            label_productiondate.TabIndex = 22;
            label_productiondate.Text = "                   ";
            label_productiondate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(261, 122);
            label12.Name = "label12";
            label12.Size = new Size(97, 25);
            label12.TabIndex = 21;
            label12.Text = "生產日期:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, workid, Column2, Column3, Column4, Column5, Column6, Column8, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.ButtonFace;
            dataGridView1.Location = new Point(24, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1424, 431);
            dataGridView1.TabIndex = 23;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // workid
            // 
            workid.DataPropertyName = "work_id";
            workid.HeaderText = "workid";
            workid.MinimumWidth = 6;
            workid.Name = "workid";
            workid.ReadOnly = true;
            workid.Visible = false;
            workid.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            Column2.HeaderText = "品名";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "product_num";
            Column3.HeaderText = "料號";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "consume";
            Column4.HeaderText = "消耗數量";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "supplier";
            Column5.HeaderText = "供應商";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "leftover";
            Column6.HeaderText = "使用剩餘量";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "lastchange";
            Column8.HeaderText = "最後修改時間";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 160;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "notes";
            Column7.HeaderText = "備註";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Form_workorder_detail
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1460, 615);
            Controls.Add(dataGridView1);
            Controls.Add(label_productiondate);
            Controls.Add(label12);
            Controls.Add(label_state);
            Controls.Add(label10);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(label_name);
            Controls.Add(label7);
            Controls.Add(label_count);
            Controls.Add(label4);
            Controls.Add(label_model);
            Controls.Add(label2);
            Controls.Add(label_num);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form_workorder_detail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "倉儲管理系統-工單詳細資料";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_num;
        private Label label2;
        private Label label_model;
        private Label label4;
        private Label label_count;
        private Label label7;
        private Label label_name;
        private Button button_add;
        private Button button_update;
        private Button button_delete;
        private Label label_state;
        private Label label10;
        private Label label_productiondate;
        private Label label12;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn workid;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
    }
}