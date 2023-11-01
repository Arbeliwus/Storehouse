using System.Data;
namespace Storehouse
{
    public partial class Form_part_add : Form
    {
        private string url;
        private DataTable PSI_datatable;
        private DateTime nowTime;
        public Form_part_add(DataTable PSI_datatable, string url)
        {
            this.url = url;
            this.PSI_datatable = PSI_datatable;
            this.nowTime = DateTime.Now;
            InitializeComponent();

        }
        private void button_save_Click(object sender, EventArgs e)
        {
            int[] index = { comboBox_type.SelectedIndex, comboBox_status.SelectedIndex };
            string[] text = { textBox_name.Text.Trim(), textBox_partNo.Text.Trim(), textBox_supplier.Text.Trim(), textBox_model.Text.Trim() };
            decimal[] value = { numericUpDown_quantity.Value, numericUpDown_price.Value, numericUpDown_MOQ.Value };
            Label[][] errorLabels ={new Label[]{ label_error_name, label_error_part_no, label_error_supplier,label_error_model},//textBox使用
                                  new Label[]{ label_error_quantity, label_error_price, label_error_MOQ},//numericUpDown使用
                                  new Label[]{ label_error_type, label_error_status}};//comboBox使用

            if (CheckContent.textBox_hasNotContent(text, errorLabels[0]) || CheckContent.numericUpDown_hasNotValue(value, errorLabels[1]) || CheckContent.comboBox_hasNotSelected(index, errorLabels[2]))//判斷輸入內容
                return;
            if (CheckContent.hasRepeat(this.PSI_datatable,text, comboBox_type.SelectedItem.ToString()))
                PostComponentData();
            else
                return;
            this.Close();
        }
        private async void PostComponentData()
        {
            var payload = new FormUrlEncodedContent(new[]{
                new KeyValuePair<string,string>("product",textBox_name.Text),
                new KeyValuePair<string,string>("quantity",numericUpDown_quantity.Value.ToString()),
                new KeyValuePair<string,string>("type",comboBox_type.SelectedItem.ToString()),
                new KeyValuePair<string,string>("partNo",textBox_partNo.Text),
                new KeyValuePair<string,string>("price",numericUpDown_price.Value.ToString()),
                new KeyValuePair<string,string>("moq",numericUpDown_MOQ.Value.ToString()),
                new KeyValuePair<string,string>("status",comboBox_status.SelectedItem.ToString()),
                new KeyValuePair<string,string>("model",textBox_model.Text),
                new KeyValuePair<string,string>("supplier",textBox_supplier.Text),
                new KeyValuePair<string,string>("user",Gobal.account),
                new KeyValuePair<string,string>("lastModified",nowTime.ToString("yyyy/MM/dd HH:mm")),
                new KeyValuePair<string,string>("note",textBox_notes.Text)
            });
            API.PostData(this.url, payload);

        }
        
    }
}
