    using Newtonsoft.Json.Linq;
using System.Data;

namespace Storehouse
{
    public partial class Form_workorder_detail_update : Form
    {
        private const string getProductUrl = "http://localhost/api/getProduct.php";
        private DataTable worktable;
        private string work_id;
        private string url;
        private int table_row;
        private string selectRow_id;

        public Form_workorder_detail_update(DataTable worktable, string selectRow_id, string work_id, string url)
        {

            this.worktable = worktable;
            this.work_id = work_id;
            this.url = url;
            this.selectRow_id = selectRow_id;
            InitializeComponent();
            InitializeTextbox();
            GetProduct();
        }
        public void InitializeTextbox()
        {
            this.table_row = Gobal.FindSelectedRow(this.worktable, this.selectRow_id);
            foreach (var item in comboBox_name.Items)
            {
                if (item.ToString().Contains(worktable.Rows[table_row][2].ToString()))
                {
                    comboBox_name.SelectedItem = item;
                    break;
                }
            }
            comboBox_partNo.Text = worktable.Rows[table_row][3].ToString();
            numericUpDown_quantity.Text = worktable.Rows[table_row][4].ToString();
            comboBox_supplier.Text = worktable.Rows[table_row][5].ToString();
            textBox_notes.Text = worktable.Rows[table_row][8].ToString();
        }
        private async void GetProduct()
        {
            JArray jsonArray = await API.GetData(getProductUrl);
            Dictionary<int, string> items = new Dictionary<int, string>();
            for (int i = 0, index = 0; i < jsonArray.Count; i++)
                if (!items.ContainsValue(jsonArray[i]["product"].ToString()))//判斷有沒有重複的資料
                    items.Add(index++, jsonArray[i]["product"].ToString());
            Gobal.comboBoxSetDataSource(comboBox_name, items);
        }
        private void button_save_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否儲存?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Putdata();
                this.Close();
            }
        }

        private void button_cancel_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("尚未儲存您的變更\n\n要捨棄變更嗎", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private async void Putdata()
        {
            var payload = new
            {
                workOderNo = this.work_id,
                id = worktable.Rows[this.table_row][1],
                product = comboBox_name.Text,
                partNo = comboBox_partNo.Text,
                consumptionQuantity = numericUpDown_quantity.Text,
                supplier = comboBox_supplier.Text,
                lastModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                note = textBox_notes.Text,
            };
            API.PutData(this.url, payload);
        }
        private async void getProductDetail()
        {
            Dictionary<int, string> partNoItems = new Dictionary<int, string>();
            Dictionary<int, string> supplierItems = new Dictionary<int, string>();
            var payload = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string,string>("product",comboBox_name.Text)
                });
            JArray jsonArray = await API.getProductDetail_PostData(payload); 
            for (int i = 0; i < jsonArray.Count; i++)
            {
                if (!partNoItems.ContainsValue(jsonArray[i]["partNo"].ToString()))
                    partNoItems.Add(i, jsonArray[i]["partNo"].ToString());
                if (!supplierItems.ContainsValue(jsonArray[i]["supplier"].ToString()))
                    supplierItems.Add(i, jsonArray[i]["supplier"].ToString());
                // 在這裡處理 partNO 和 supplier 的值
                // ...
            }
            Gobal.comboBoxSetDataSource(comboBox_partNo, partNoItems);
            Gobal.comboBoxSetDataSource(comboBox_supplier, supplierItems);
        }
        private void comboBox_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getProductDetail();
        }
    }
}
