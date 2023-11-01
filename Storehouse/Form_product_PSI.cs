using Newtonsoft.Json.Linq;
using System.Data;

namespace Storehouse
{
    public partial class Form_product_PSI : Form
    {
        DataTable datatable;
        private const string url = "http://localhost/api/productData.php";
        public Form_product_PSI()
        {

            this.datatable = new DataTable();
            InitializeComponent();
            InitializedataGridview();
            if (Gobal.permissions == "guests")
                Gobal.buttonDisenable(button_add, button_update);
        }
        public void InitializedataGridview()//初始化gridview
        {
            datatable.Columns.Add("id", typeof(string));
            datatable.Columns.Add("name", typeof(string));
            datatable.Columns.Add("workerorderNum", typeof(string));
            datatable.Columns.Add("quantity", typeof(string));
            datatable.Columns.Add("productionDate", typeof(string));
            datatable.Columns.Add("status", typeof(string));
            datatable.Columns.Add("user", typeof(string));
            datatable.Columns.Add("nowTime", typeof(string));
            datatable.Columns.Add("notes", typeof(string));
            dataGridView1.DataSource = datatable;
            GetProductData();
        }
        private void button_add_MouseClick(object sender, MouseEventArgs e)//新增
        {
            Form_product_add f2 = new Form_product_add(this.datatable, url);
            f2.ShowDialog();
            System.Threading.Thread.Sleep(500);//等待資料表更新
            GetProductData();
        }
        private void button_update_MouseClick(object sender, MouseEventArgs e)//修改
        {
            if (this.dataGridView1.SelectedRows.Count == 1)//gridview被選擇一項
            {
                var selectRow = this.dataGridView1.SelectedRows[0].Index;
                var selectRow_id = this.dataGridView1.Rows[selectRow].Cells["id"].Value.ToString();//對應資料表中的id
                Form_product_update f3 = new Form_product_update(this.datatable, selectRow_id, url);
                f3.ShowDialog();
                System.Threading.Thread.Sleep(500);//等待資料表更新
                GetProductData();
            }
            else
                MessageBox.Show("請選擇要修改的項目", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async void GetProductData()
        {
            this.datatable.Rows.Clear();//每次呼叫時要先清除datatable以免疊加在原本的資料上
            JArray DBresponse = await API.GetData(url);
            if (DBresponse != null)
                for (int i = 0; i < DBresponse.Count; i++)
                //這裡的Count代表length,JArray專用
                {
                    this.datatable.Rows.Add(DBresponse[i]["count"].ToString(),
                                            DBresponse[i]["product"].ToString(),
                                            DBresponse[i]["ticketNo"].ToString(),
                                            DBresponse[i]["quantity"].ToString(),
                                            DBresponse[i]["manufacturingDate"].ToString(),
                                            DBresponse[i]["status"].ToString(),
                                            DBresponse[i]["user"].ToString(),
                                            DBresponse[i]["lastModified"].ToString(),
                                            DBresponse[i]["note"].ToString()
                                            );
                }
        }
    }
}
