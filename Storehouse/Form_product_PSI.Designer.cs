namespace Storehouse
{
    partial class Form_product_PSI
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            button_add = new Button();
            button_update = new Button();
            id = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Column3, Column1, quantity, Column2, Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.Location = new Point(13, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1835, 737);
            dataGridView1.TabIndex = 6;
            // 
            // button_add
            // 
            button_add.BackColor = SystemColors.Info;
            button_add.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_add.Location = new Point(13, 756);
            button_add.Margin = new Padding(4);
            button_add.Name = "button_add";
            button_add.Size = new Size(134, 46);
            button_add.TabIndex = 7;
            button_add.Text = "新增項目";
            button_add.UseVisualStyleBackColor = true;
            button_add.MouseClick += button_add_MouseClick;
            // 
            // button_update
            // 
            button_update.BackColor = Color.Gainsboro;
            button_update.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_update.Location = new Point(155, 756);
            button_update.Margin = new Padding(4);
            button_update.Name = "button_update";
            button_update.Size = new Size(134, 46);
            button_update.TabIndex = 8;
            button_update.Text = "修改項目";
            button_update.UseVisualStyleBackColor = true;
            button_update.MouseClick += button_update_MouseClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            id.DefaultCellStyle = dataGridViewCellStyle3;
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "name";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column3.DefaultCellStyle = dataGridViewCellStyle4;
            Column3.HeaderText = "品名";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 140;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "workerorderNum";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column1.DefaultCellStyle = dataGridViewCellStyle5;
            Column1.HeaderText = "工單編號";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 140;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "數量";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "productionDate";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column2.DefaultCellStyle = dataGridViewCellStyle6;
            Column2.HeaderText = "生產日期";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 140;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "status";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column5.DefaultCellStyle = dataGridViewCellStyle7;
            Column5.HeaderText = "狀態";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 140;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "user";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column6.DefaultCellStyle = dataGridViewCellStyle8;
            Column6.HeaderText = "負責人";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 140;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "nowTime";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column7.DefaultCellStyle = dataGridViewCellStyle9;
            Column7.HeaderText = "最後修改時間";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 140;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "notes";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column8.DefaultCellStyle = dataGridViewCellStyle10;
            Column8.HeaderText = "備註";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 140;
            // 
            // Form_product_PSI
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1860, 815);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(dataGridView1);
            Name = "Form_product_PSI";
            Text = "倉儲管理系統";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_add;
        private Button button_update;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}