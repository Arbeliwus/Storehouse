using Newtonsoft.Json.Linq;
using System.Data;
using System.Linq;

namespace Storehouse
{
    public partial class Form_workorder_detail : Form
    {
        private string work_id;
        private string url;
        private DataTable datatable;
        private DataTable workordertable;
        public Form_workorder_detail(DataTable workordertable, string work_id)
        {
            this.url = "http://localhost/api/WorlOderDetail.php";
            this.datatable = new DataTable();
            this.workordertable = workordertable;
            this.work_id = work_id;
            InitializeComponent();
            InitializedataGridview();
            Initializedata();
            Initializelabel();
            if (Gobal.permissions == "guests")
            {
                Gobal.buttonDisenable(button_add, button_update, button_delete);

            }
        }
        public void InitializedataGridview()
        {
            datatable.Columns.Add("work_id", typeof(string));
            datatable.Columns.Add("id", typeof(string));
            datatable.Columns.Add("name", typeof(string));
            datatable.Columns.Add("product_num", typeof(string));
            datatable.Columns.Add("consume", typeof(string));
            datatable.Columns.Add("supplier", typeof(string));
            datatable.Columns.Add("leftover", typeof(string));
            datatable.Columns.Add("lastchange", typeof(string));
            datatable.Columns.Add("notes", typeof(string));
            dataGridView1.DataSource = datatable;
        }
        public void Initializelabel()
        {
            int row = 0;
            foreach (DataRow i in workordertable.Rows)
            {
                if (work_id == i[0].ToString())
                {

                    row = workordertable.Rows.IndexOf(i);
                    break;
                }
            }
            label_num.Text = workordertable.Rows[row][1].ToString();
            label_name.Text = workordertable.Rows[row][2].ToString();
            label_model.Text = workordertable.Rows[row][3].ToString();
            label_count.Text = workordertable.Rows[row][4].ToString();
            label_state.Text = workordertable.Rows[row][5].ToString();
            label_productiondate.Text = workordertable.Rows[row][6].ToString();
        }
        private void button_add_MouseClick(object sender, MouseEventArgs e)
        {
            Form_workorder_detail_add f5 = new Form_workorder_detail_add(this.datatable, this.url, this.work_id);
            f5.ShowDialog();
            System.Threading.Thread.Sleep(500);
            Initializedata();
        }
        private void button_delete_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)//被選擇index 總數
            {
                DialogResult result = MessageBox.Show("是否確定要刪除這筆資料？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Deldata();
                    System.Threading.Thread.Sleep(500);
                    Initializedata();
                }
                //被選擇的1st index
            }
            else
                MessageBox.Show("請選擇要刪除的項目", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button_update_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                var id = this.dataGridView1.Rows[this.dataGridView1.SelectedRows[0].Index].Cells["id"].Value.ToString();
                Form_workorder_detail_update f5 = new Form_workorder_detail_update(this.datatable, id, this.work_id, this.url);
                f5.ShowDialog();
                System.Threading.Thread.Sleep(500);
                Initializedata();
            }
            else
                MessageBox.Show("請選擇要修改的項目", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private async void Initializedata()
        {
            this.datatable.Rows.Clear();//每次呼叫時要先清除datatable以免疊加在原本的資料上
            JArray DBresponse = await API.GetData(this.url + "?workOderNo=" + this.work_id);
            if (DBresponse != null)
            {
                for (int i = 0; i < DBresponse.Count; i++)
                //這裡的Count代表length,JArray專用
                {
                    this.datatable.Rows.Add(this.work_id,
                                            DBresponse[i]["count"].ToString(),
                                            DBresponse[i]["product"].ToString(),
                                            DBresponse[i]["partNo"].ToString(),
                                            DBresponse[i]["consumptionQuantity"].ToString(),
                                            DBresponse[i]["supplier"].ToString(),
                                            DBresponse[i]["remainingQuantity"].ToString(),
                                            DBresponse[i]["lastModified"].ToString(),
                                            DBresponse[i]["note"].ToString()
                                            );
                }
            }
        }
        private async void Deldata()
        {
            var selectRow = this.dataGridView1.SelectedRows[0].Index;
            var selectRow_id = this.dataGridView1.Rows[selectRow].Cells["id"].Value.ToString();//對應資料表中的id
            API.DeleteData(url, selectRow_id);
        }
    }
}
