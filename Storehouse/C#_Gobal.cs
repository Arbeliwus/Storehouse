using System.Data;
namespace Storehouse
{
    internal class Gobal
    {
        public static string account { set; get; }//使用者帳號
        public static string permissions { get; set; }//使用者權限

        public static DateTime nowtime = DateTime.Now;
        public static int FindSelectedRow(DataTable dataTable,string selectRow_id)//尋找在update時對應的Rows,以免gridview被排序時讀錯位置
        {
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["id"] };//設置PSI_datatable主鍵，用於尋找對應id
            DataRow find_id = dataTable.Rows.Find(selectRow_id);
            return dataTable.Rows.IndexOf(find_id);
        }
        public static void buttonDisenable(Button add, Button update)//適用part、product
        {
            add.Enabled = false;
            add.Visible = false;
            update.Enabled = false;
            update.Visible = false;
        }
        public static void buttonDisenable(Button add,Button update,Button delete)//適用part、product、workorder
        {
            add.Enabled = false;
            add.Visible = false;
            update.Enabled = false;
            update.Visible = false;
            delete.Enabled = false;
            delete.Visible = false;
        }
        public static void comboBoxSetDataSource(ComboBox comboBox, Dictionary<int, string>Items)
        {
            comboBox.DataSource = new BindingSource(Items, null);
            comboBox.DisplayMember = "Value";   // 要顯示的鍵對應的值
            comboBox.ValueMember = "Key";       // 鍵的值
        }

    }
}
