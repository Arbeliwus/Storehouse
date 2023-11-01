using System.Data;

namespace Storehouse
{
    public partial class Form_product_update : Form
    {
        private DataTable commodity_table;
        private string url;
        private string selectRow_id;
        private int table_row;
        private const string getTickNO_url = "http://localhost/api/getTicketNo.php";
        public Form_product_update(DataTable commodity_table, string selectRow_id, string url)
        {
            this.commodity_table = commodity_table;
            this.url = url;
            this.selectRow_id = selectRow_id;
            InitializeComponent();
            Initialize_CorrespondField();
        }
        public void Initialize_CorrespondField()//初始化顯示該row內容
        {
            this.table_row = Gobal.FindSelectedRow(this.commodity_table, this.selectRow_id);
            textBox_name.Text = commodity_table.Rows[this.table_row][1].ToString();
            comboBox_workerorderNum.Text = commodity_table.Rows[this.table_row][2].ToString();
            numericUpDown_quantity.Value = Convert.ToDecimal(commodity_table.Rows[this.table_row][3]);
            dateTimePicker_productionDate.Value = Convert.ToDateTime(commodity_table.Rows[this.table_row][4]);
            comboBox_status.SelectedIndex = commodity_table.Rows[this.table_row][5].ToString() == "入庫" ? 0 : 1;
            textBox_notes.Text = commodity_table.Rows[this.table_row][8].ToString();
        }
        private void button_save_MouseClick(object sender, MouseEventArgs e)//儲存
        {
            DialogResult result = MessageBox.Show("是否儲存?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PutProductdata();
                this.Close();
            }
        }
        private void button_cancel_MouseClick(object sender, MouseEventArgs e)//取消
        {
            DialogResult result = MessageBox.Show("尚未儲存您的變更\n\n要捨棄變更嗎", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private async void PutProductdata()
        {
            var payload = new
            {
                id = commodity_table.Rows[this.table_row][0],
                product = textBox_name.Text.Trim(),
                ticketNo = comboBox_workerorderNum.Text.Trim(),
                quantity = numericUpDown_quantity.Value,
                manufacturingDate = dateTimePicker_productionDate.Value.ToString("yyyy/MM/dd"),
                status = comboBox_status.Text.Trim(),
                user = Gobal.account,
                lastModified = DateTime.Now.ToString("yyyy/MM/dd HH:mm"),
                note = textBox_notes.Text.Trim(),
            };
            API.PutData(url, payload);
        }
        private void dateTimePicker_productionDate_ValueChanged(object sender, EventArgs e)
        {
            setDateTimePicker();
        }
        public void setDateTimePicker()//依據選定日期顯示目前完成的工單
        {
            var payload = new FormUrlEncodedContent(new[] {
            new KeyValuePair<string,string>("manufacturingDate",dateTimePicker_productionDate.Value.ToString("yyyy/MM/dd"))
           });
            API.getTickNo_PostData(getTickNO_url, payload, comboBox_workerorderNum);
        }
    }
}
