using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Storehouse
{
    public partial class Form_workorder_detail_add : Form
    {
        private DataTable dataTable;
        private string url;
        private string work_id;
        private DateTime nowtime = DateTime.Now;
        private const string getProductUrl = "http://localhost/api/getProduct.php";

        public Form_workorder_detail_add(DataTable dataTable, string url, string work_id)
        {
            this.dataTable = dataTable;
            this.url = url;
            this.work_id = work_id;
            InitializeComponent();
            GetProduct();
        }
        private void save_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DataRow row in dataTable.Rows)
                if (row["name"].ToString().Contains(comboBox_name.Text) && row["product_num"].ToString().Contains(comboBox_partNo.Text) && row["supplier"].ToString().Contains(comboBox_supplier.Text))
                {
                    MessageBox.Show("該品名已經存在", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            postWorlOderDetail();
            this.Close();
        }
        private async void postWorlOderDetail()
        {
            var payload = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string,string>("workOderNo",this.work_id),
                new KeyValuePair<string,string>("product",comboBox_name.Text),
                new KeyValuePair<string,string>("partNo",comboBox_partNo.Text),
                new KeyValuePair<string,string>("consumptionQuantity",numericUpDown_quantity.Value.ToString()),
                new KeyValuePair<string,string>("supplier",comboBox_supplier.Text),
                new KeyValuePair<string,string>("lastModified",nowtime.ToString("yyyy/MM/dd HH:mm")),
                new KeyValuePair<string,string>("note",textBox_notes.Text)
            });
            API.PostData(this.url, payload);
        }
        private async void GetProduct()
        {

            JArray jsonArray = await API.GetData(getProductUrl);
            Dictionary<int, string> items = new Dictionary<int, string>();
            for (int i = 0; i < jsonArray.Count; i++)
                if (!items.ContainsValue(jsonArray[i]["product"].ToString()))//判斷有沒有重複的資料
                    items.Add(i, jsonArray[i]["product"].ToString());
            Gobal.comboBoxSetDataSource(comboBox_name, items);
        }

        private void comboBox_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getProductDetail();
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
    }
}
