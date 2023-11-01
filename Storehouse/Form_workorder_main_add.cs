using System.Data;

namespace Storehouse
{
    public partial class Form_workorder_main_add : Form
    {
        private DataTable datatable;
        private string url;
        private DateTime nowtime;
        public Form_workorder_main_add(DataTable datatable, string url)
        {
            this.datatable = datatable;
            this.url = url;
            this.nowtime = DateTime.Now;
            InitializeComponent();
        }
        private void save_MouseClick(object sender, MouseEventArgs e)//儲存
        {
            string[] text = { textBox_workerorderNum.Text, textBox_name.Text, textBox_model.Text };
            decimal[] value = { numericUpDown_quantity.Value };
            Label[][] errorLabels = { new Label[] { label_error_workerorderNum, label_error_name, label_error_model},//text使用
                                       new Label[]{ label_error_quantity}};//value使用
            if (CheckContent.textBox_hasNotContent(text, errorLabels[0]) || CheckContent.numericUpDown_hasNotValue(value, errorLabels[1]))
                return;
            PostWorkOrderdata();
            this.Close();
        }
        private async void PostWorkOrderdata()
        {
            var payload = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string,string>("ticketNo",textBox_workerorderNum.Text),
                new KeyValuePair<string,string>("productName",textBox_name.Text),
                new KeyValuePair<string,string>("productModel",textBox_model.Text),
                new KeyValuePair<string,string>("productQuantity",numericUpDown_quantity.Value.ToString()),
                new KeyValuePair<string,string>("productStatus","未完成"),
                new KeyValuePair<string,string>("manufacturingDate",dateTimePicker_productionDate.Value.ToString("yyyy/MM/dd")),
                new KeyValuePair<string,string>("user",Gobal.account),
                new KeyValuePair<string,string>("lastModified",nowtime.ToString("yyyy/MM/dd HH:mm")),
                new KeyValuePair<string,string>("note",textBox_notes.Text)
            });
            API.PostData(this.url, payload);
        }

    }
}
