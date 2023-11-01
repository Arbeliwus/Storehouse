namespace Storehouse
{
    partial class Form_part_PSI
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button_add = new Button();
            dataGridView1 = new DataGridView();
            button_update = new Button();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            part_no = new DataGridViewTextBoxColumn();
            state = new DataGridViewTextBoxColumn();
            MOQ = new DataGridViewTextBoxColumn();
            model = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            user = new DataGridViewTextBoxColumn();
            nowtime = new DataGridViewTextBoxColumn();
            notes = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.BackColor = Color.Gainsboro;
            button_add.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_add.Location = new Point(13, 756);
            button_add.Margin = new Padding(4);
            button_add.Name = "button_add";
            button_add.Size = new Size(134, 46);
            button_add.TabIndex = 4;
            button_add.Text = "新增項目";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, type, quantity, price, part_no, state, MOQ, model, supplier, user, nowtime, notes });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(13, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1835, 737);
            dataGridView1.TabIndex = 5;
            // 
            // button_update
            // 
            button_update.BackColor = Color.Gainsboro;
            button_update.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_update.Location = new Point(155, 756);
            button_update.Margin = new Padding(4);
            button_update.Name = "button_update";
            button_update.Size = new Size(134, 46);
            button_update.TabIndex = 6;
            button_update.Text = "修改項目";
            button_update.UseVisualStyleBackColor = true;
            button_update.MouseClick += button_update_MouseClick;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.DataPropertyName = "type";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column3.DefaultCellStyle = dataGridViewCellStyle8;
            Column3.HeaderText = "類型";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.DataPropertyName = "name";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = Color.White;
            Column1.DefaultCellStyle = dataGridViewCellStyle9;
            Column1.HeaderText = "品名";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.DataPropertyName = "count";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column2.DefaultCellStyle = dataGridViewCellStyle10;
            Column2.HeaderText = "數量";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.DataPropertyName = "partnum";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column4.DefaultCellStyle = dataGridViewCellStyle11;
            Column4.HeaderText = "料號";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
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
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "品名";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // type
            // 
            type.DataPropertyName = "type";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            type.DefaultCellStyle = dataGridViewCellStyle4;
            type.HeaderText = "類型";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.ReadOnly = true;
            type.Resizable = DataGridViewTriState.True;
            type.Width = 125;
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
            // price
            // 
            price.DataPropertyName = "price";
            price.HeaderText = "價格";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 125;
            // 
            // part_no
            // 
            part_no.DataPropertyName = "partNo";
            part_no.HeaderText = "料號";
            part_no.MinimumWidth = 6;
            part_no.Name = "part_no";
            part_no.ReadOnly = true;
            part_no.Width = 125;
            // 
            // state
            // 
            state.DataPropertyName = "state";
            state.HeaderText = "狀態";
            state.MinimumWidth = 6;
            state.Name = "state";
            state.ReadOnly = true;
            state.Width = 125;
            // 
            // MOQ
            // 
            MOQ.DataPropertyName = "MOQ";
            MOQ.HeaderText = "MOQ";
            MOQ.MinimumWidth = 6;
            MOQ.Name = "MOQ";
            MOQ.ReadOnly = true;
            MOQ.Width = 125;
            // 
            // model
            // 
            model.DataPropertyName = "model";
            model.HeaderText = "型號";
            model.MinimumWidth = 6;
            model.Name = "model";
            model.ReadOnly = true;
            model.Width = 125;
            // 
            // supplier
            // 
            supplier.DataPropertyName = "supplier";
            supplier.HeaderText = "供應商";
            supplier.MinimumWidth = 6;
            supplier.Name = "supplier";
            supplier.ReadOnly = true;
            supplier.Width = 125;
            // 
            // user
            // 
            user.DataPropertyName = "user";
            user.HeaderText = "負責人";
            user.MinimumWidth = 6;
            user.Name = "user";
            user.ReadOnly = true;
            user.Width = 125;
            // 
            // nowtime
            // 
            nowtime.DataPropertyName = "nowTime";
            nowtime.HeaderText = "最後修改時間";
            nowtime.MinimumWidth = 6;
            nowtime.Name = "nowtime";
            nowtime.ReadOnly = true;
            nowtime.Width = 140;
            // 
            // notes
            // 
            notes.DataPropertyName = "notes";
            notes.HeaderText = "備註";
            notes.MinimumWidth = 6;
            notes.Name = "notes";
            notes.ReadOnly = true;
            notes.Width = 125;
            // 
            // Form_part_PSI
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1860, 815);
            Controls.Add(button_update);
            Controls.Add(dataGridView1);
            Controls.Add(button_add);
            Margin = new Padding(4);
            Name = "Form_part_PSI";
            Text = "倉儲管理系統";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_add;
        private DataGridView dataGridView1;
        private Button button_update;

        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn part_no;
        private DataGridViewTextBoxColumn state;
        private DataGridViewTextBoxColumn MOQ;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn supplier;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn nowtime;
        private DataGridViewTextBoxColumn notes;
    }
}