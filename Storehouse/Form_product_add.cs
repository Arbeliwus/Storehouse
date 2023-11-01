using System.Data;
using Label = System.Windows.Forms.Label;

namespace Storehouse
{
    public partial class Form_product_add : Form
    {
        private string url;
        private DataTable datatable;
        private DateTime nowTime;
        private const string getTickNO_url = "http://localhost/api/getTicketNo.php";
        public Form_product_add(DataTable datatable, string url)
        {
            this.datatable = datatable;
            this.url = url;
            this.nowTime = DateTime.Now;
            InitializeComponent();
        }
        private void button_save_MouseClick(object sender, MouseEventArgs e)
        {
            string[] text = { textBox_name.Text, };
            int[] index = { comboBox_status.SelectedIndex };
            decimal[] value = { numericUpDown_quantity.Value };
            Label[][] errorLabels = { new Label[]{label_error_name  },//textBox使用
                                      new Label[]{label_error_state },//numericUpDown使用
                                      new Label[]{label_error_quantity, label_error_workerorderNum } };//comboBox使用
            if (CheckContent.textBox_hasNotContent(text, errorLabels[0]) || CheckContent.comboBox_hasNotSelected(index, errorLabels[1]) || CheckContent.numericUpDown_hasNotValue(value, errorLabels[2]))
                return;
            PostProductData();
            this.Close();        }
        private async void PostProductData()
        {
            var payload = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string,string>("product",textBox_name.Text.Trim()),
                new KeyValuePair<string,string>("ticketNo",comboBox_workerorderNum.Text.Trim()),
                new KeyValuePair<string,string>("manufacturingDate",dateTimePicker_productionDate.Value.ToString("yyyy/MM/dd")),
                new KeyValuePair<string,string>("quantity",numericUpDown_quantity.Value.ToString()),
                new KeyValuePair<string,string>("status",comboBox_status.SelectedItem.ToString()),
                new KeyValuePair<string,string>("user",Gobal.account),
                new KeyValuePair<string,string>("lastModified",nowTime.ToString("yyyy/MM/dd HH:mm")),
                new KeyValuePair<string,string>("note",textBox_notes.Text.Trim())
            });
            API.PostData(this.url, payload);
        }
        private async void dateTimePicker_productionDate_ValueChanged(object sender, EventArgs e)
        {
            setDateTimePicker();
        }

        public void setDateTimePicker()//依據選定日期顯示目前完成的工單
        {
            var payload = new FormUrlEncodedContent(new[] {
            new KeyValuePair<string,string>("manufacturingDate",dateTimePicker_productionDate.Value.ToString("yyyy/MM/dd"))
           });
            API.getTickNo_PostData(getTickNO_url, payload,comboBox_workerorderNum);
        }
    }
}
