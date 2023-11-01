using System.Data;

namespace Storehouse
{
    public partial class Form_workorder_main_update : Form
    {
        private DataTable worktable;
        private DateTime nowtime;
        private string url;
        private string selectRow_id;
        private int table_row;
        public Form_workorder_main_update(DataTable worktable, string selectRow_id, string url)
        {
            this.worktable = worktable;
            this.selectRow_id = selectRow_id;
            this.nowtime = DateTime.Now;
            this.url = url;
            InitializeComponent();
            Initialize_CorrespondField();
        }
        public void Initialize_CorrespondField()
        {
            this.table_row = Gobal.FindSelectedRow(this.worktable, this.selectRow_id);
            textBox_work_num.Text = worktable.Rows[table_row][1].ToString();
            textBox_name.Text = worktable.Rows[table_row][2].ToString();
            textBox_model.Text = worktable.Rows[table_row][3].ToString();
            numericUpDown_quantity.Value = Convert.ToDecimal(worktable.Rows[table_row][4]);
            comboBox_status.SelectedIndex = worktable.Rows[this.table_row][5].ToString() == "未完成" ? 1 : 0;
            dateTimePicker_productionDate.Value = Convert.ToDateTime(worktable.Rows[table_row][6]);
            textBox_notes.Text = worktable.Rows[table_row][9].ToString();
        }
        private void button_save_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否儲存?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PutWorkorderdata();
                this.Close();
            }
        }
        private void button_cancel_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("尚未儲存您的變更\n\n要捨棄變更嗎", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private async void PutWorkorderdata()
        {
            var payload = new
            {
                id = worktable.Rows[this.table_row][0],
                ticketNo = textBox_work_num.Text,
                productName = textBox_name.Text,
                productModel = textBox_model.Text,
                productQuantity = numericUpDown_quantity.Value,
                productStatus = comboBox_status.Text.Trim(),
                manufacturingDate = dateTimePicker_productionDate.Value.ToString("yyyy/MM/dd"),
                user = Gobal.account,
                lastModified = nowtime.ToString("yyyy/MM/dd HH:mm"),
                note = textBox_notes.Text,
            };
            API.PutData(url, payload);
        }
    }
}
