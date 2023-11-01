namespace Storehouse
{
    partial class Form_workorder_main
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
            button_add = new Button();
            button_update = new Button();
            button_delete = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            button_detail = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_add.Location = new Point(153, 755);
            button_add.Name = "button_add";
            button_add.Size = new Size(134, 46);
            button_add.TabIndex = 0;
            button_add.Text = "新增項目";
            button_add.UseVisualStyleBackColor = true;
            button_add.MouseClick += button_add_MouseClick;
            // 
            // button_update
            // 
            button_update.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_update.Location = new Point(293, 757);
            button_update.Name = "button_update";
            button_update.Size = new Size(134, 46);
            button_update.TabIndex = 10;
            button_update.Text = "修改項目";
            button_update.UseVisualStyleBackColor = true;
            button_update.MouseClick += button_update_MouseClick;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_delete.Location = new Point(433, 757);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(134, 46);
            button_delete.TabIndex = 11;
            button_delete.Text = "刪除項目";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.MouseClick += button_delete_MouseClick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 8.3F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Column1, Column2, Column3, Column4, Column5, Column6, Column8, Column9, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.ButtonFace;
            dataGridView1.Location = new Point(13, 20);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1835, 729);
            dataGridView1.TabIndex = 13;
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
            // Column1
            // 
            Column1.DataPropertyName = "work_num";
            Column1.HeaderText = "工單編號";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 140;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            Column2.HeaderText = "名稱";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "product_num";
            Column3.HeaderText = "型號";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 140;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "count";
            Column4.HeaderText = "數量";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 140;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "state";
            Column5.HeaderText = "狀態";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 140;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "productiondate";
            Column6.HeaderText = "生產日期";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 140;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "user";
            Column8.HeaderText = "負責人";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 140;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "lastchange";
            Column9.HeaderText = "最後修改時間";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 140;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "notes";
            Column7.HeaderText = "備註";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 140;
            // 
            // button_detail
            // 
            button_detail.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_detail.Location = new Point(13, 755);
            button_detail.Name = "button_detail";
            button_detail.Size = new Size(134, 46);
            button_detail.TabIndex = 14;
            button_detail.Text = "詳細資料";
            button_detail.UseVisualStyleBackColor = true;
            button_detail.MouseClick += button_detail_MouseClick;
            // 
            // Form_workorder_main
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1860, 815);
            Controls.Add(button_detail);
            Controls.Add(dataGridView1);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Name = "Form_workorder_main";
            Text = "倉庫管理系統";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_add;
        private Button button_update;
        private Button button_delete;
        private DataGridView dataGridView1;
        private Button button_detail;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column7;
    }
}