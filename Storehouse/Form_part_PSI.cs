using Newtonsoft.Json.Linq;
using System.Data;


namespace Storehouse
{
    public partial class Form_part_PSI : Form
    {
        DataTable datatable;
        private const string url = "http://localhost/api/ComponentData.php";
        public Form_part_PSI()
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
            datatable.Columns.Add("type", typeof(string));
            datatable.Columns.Add("quantity", typeof(string));
            datatable.Columns.Add("price", typeof(string));
            datatable.Columns.Add("partNo", typeof(string));
            datatable.Columns.Add("state", typeof(string));
            datatable.Columns.Add("MOQ", typeof(string));
            datatable.Columns.Add("model", typeof(string));
            datatable.Columns.Add("supplier", typeof(string));
            datatable.Columns.Add("user", typeof(string));
            datatable.Columns.Add("nowTime", typeof(string));
            datatable.Columns.Add("notes", typeof(string));
            dataGridView1.DataSource = datatable;
            GetComponentData();
        }
        private void button_add_Click(object sender, EventArgs e)//新增
        {
            Form_part_add f2 = new Form_part_add(this.datatable, url);
            f2.ShowDialog();
            System.Threading.Thread.Sleep(500);//等待資料表更新
            GetComponentData();
        }
        private void button_update_MouseClick(object sender, MouseEventArgs e)//修改
        {
            if (this.dataGridView1.SelectedRows.Count == 1)//gridview被選擇一項
            {
                var selectRow = this.dataGridView1.SelectedRows[0].Index;
                var selectRow_id = this.dataGridView1.Rows[selectRow].Cells["id"].Value.ToString();//對應資料表中的id
                Form_part_update f3 = new Form_part_update(this.datatable, selectRow_id, url);
                f3.ShowDialog();
                System.Threading.Thread.Sleep(500);//等待資料表更新
                GetComponentData();
            }
            else
            {
                MessageBox.Show("請選擇要修改的項目", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void GetComponentData()
        {
            this.datatable.Rows.Clear();//每次呼叫時要先清除datatable以免疊加在原本的資料上
            JArray DBresponse = await API.GetData(url);
            if (DBresponse != null)
                for (int i = 0; i < DBresponse.Count; i++)
                //Count代表length,每一個項目欄位+1(JArray專用)
                {
                    this.datatable.Rows.Add(DBresponse[i]["count"].ToString(),
                                            DBresponse[i]["product"].ToString(),
                                            DBresponse[i]["type"].ToString(),
                                            DBresponse[i]["quantity"].ToString(),
                                            DBresponse[i]["price"].ToString(),
                                            DBresponse[i]["partNo"].ToString(),
                                            DBresponse[i]["status"].ToString(),
                                            DBresponse[i]["moq"].ToString(),
                                            DBresponse[i]["model"].ToString(),
                                            DBresponse[i]["supplier"].ToString(),
                                            DBresponse[i]["user"].ToString(),
                                            DBresponse[i]["lastModified"].ToString(),
                                            DBresponse[i]["note"].ToString()
                                            );
                }
        }
    }
}
