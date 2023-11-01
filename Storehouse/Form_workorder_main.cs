using Newtonsoft.Json.Linq;
using System.Data;

namespace Storehouse
{
    public partial class Form_workorder_main : Form
    {
        private const string url = "http://localhost/api/WorkOderData.php";
        DataTable datatable;
        public Form_workorder_main()
        {
            this.datatable = new DataTable();
            InitializeComponent();
            InitializedataGridview();
            GetWorkerOrderData();
            if (Gobal.permissions == "guests")
            {
                Gobal.buttonDisenable(button_add, button_update, button_delete);

            }

        }
        private void button_add_MouseClick(object sender, MouseEventArgs e)//新增
        {
            Form_workorder_main_add f4 = new Form_workorder_main_add(this.datatable, url);
            f4.ShowDialog();
            System.Threading.Thread.Sleep(500);
            GetWorkerOrderData();
        }
        public void InitializedataGridview()//初始化
        {
            this.datatable.Columns.Add("id", typeof(string));
            this.datatable.Columns.Add("work_num", typeof(string));
            this.datatable.Columns.Add("name", typeof(string));
            this.datatable.Columns.Add("product_num", typeof(string));
            this.datatable.Columns.Add("count", typeof(string));
            this.datatable.Columns.Add("state", typeof(string));
            this.datatable.Columns.Add("productiondate", typeof(string));
            this.datatable.Columns.Add("user", typeof(string));
            this.datatable.Columns.Add("lastchange", typeof(string));
            this.datatable.Columns.Add("notes", typeof(string));
            this.dataGridView1.DataSource = this.datatable;
        }
        private void button_delete_MouseClick(object sender, MouseEventArgs e)//刪除
        {
            if (this.dataGridView1.SelectedRows.Count == 1)//被選擇index 總數
            {
                DialogResult result = MessageBox.Show("是否確定要刪除這筆資料？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteData();
                    System.Threading.Thread.Sleep(500);
                    GetWorkerOrderData();
                    //被選擇的1st index
                }
            }
            else
                MessageBox.Show("請選擇要刪除的項目", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button_update_MouseClick(object sender, MouseEventArgs e)//修改
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                var id = this.dataGridView1.Rows[this.dataGridView1.SelectedRows[0].Index].Cells["id"].Value.ToString();
                Form_workorder_main_update f4 = new Form_workorder_main_update(this.datatable, id, url);
                f4.ShowDialog();
                System.Threading.Thread.Sleep(500);
                GetWorkerOrderData();
            }
            else
                MessageBox.Show("請選擇要修改的項目", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button_detail_MouseClick(object sender, MouseEventArgs e)//查看詳細資料表
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                var selectRow = this.dataGridView1.SelectedRows[0].Index;
                var selectRow_id = this.dataGridView1.Rows[selectRow].Cells["id"].Value.ToString();//對應資料表中的id
                Form_workorder_detail f4 = new Form_workorder_detail(this.datatable, selectRow_id);//耗材計算
                f4.Show();
                f4.BringToFront();//顯示層級+1
            }
            else
                MessageBox.Show("請選擇要查看的的項目", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async void GetWorkerOrderData()
        {
            this.datatable.Rows.Clear();//每次呼叫時要先清除datatable以免疊加在原本的資料上
            JArray DBresponse = await API.GetData(url);
            if (DBresponse != null)
                for (int i = 0; i < DBresponse.Count; i++)
                //這裡的Count代表length,JArray專用
                {
                    this.datatable.Rows.Add(DBresponse[i]["count"].ToString(),
                                            DBresponse[i]["ticketNo"].ToString(),
                                            DBresponse[i]["productName"].ToString(),
                                            DBresponse[i]["productModel"].ToString(),
                                            DBresponse[i]["productQuantity"].ToString(),
                                            DBresponse[i]["productStatus"].ToString(),
                                            DBresponse[i]["manufacturingDate"].ToString(),
                                            DBresponse[i]["user"].ToString(),
                                            DBresponse[i]["lastModified"].ToString(),
                                            DBresponse[i]["note"].ToString()
                                            );
                }
        }
        private void DeleteData()
        {
            var selectRow = this.dataGridView1.SelectedRows[0].Index;
            var selectRow_id = this.dataGridView1.Rows[selectRow].Cells["id"].Value.ToString();//對應資料表中的id
            API.DeleteData(url, selectRow_id);
        }
    }
}
