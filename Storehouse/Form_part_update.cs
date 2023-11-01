using System.Data;
namespace Storehouse
{
    public partial class Form_part_update : Form
    {
        private DataTable part_datatable;
        private string url;
        private string selectRow_id;
        private int table_row;
        public Form_part_update(DataTable part_datatable, string selectRow_id, string url)
        {
            this.part_datatable = part_datatable;
            this.url = url;
            this.selectRow_id = selectRow_id;
            InitializeComponent();
            Initialize_CorrespondField();

        }
        public void Initialize_CorrespondField()
        {
            this.table_row = Gobal.FindSelectedRow(this.part_datatable, this.selectRow_id);
            textBox_name.Text = part_datatable.Rows[this.table_row][1].ToString();
            comboBox_type.SelectedIndex = part_datatable.Rows[this.table_row][2].ToString() == "主料" ? 0 : 1;
            numericUpDown_quantity.Value = Convert.ToDecimal(part_datatable.Rows[this.table_row][3]);
            numericUpDown_price.Value = Convert.ToDecimal(part_datatable.Rows[this.table_row][4]);
            textBox_partNo.Text = part_datatable.Rows[this.table_row][5].ToString();
            comboBox_status.SelectedIndex = part_datatable.Rows[this.table_row][6].ToString() == "進貨" ? 0 : 1;
            numericUpDown_MOQ.Value = Convert.ToDecimal(part_datatable.Rows[this.table_row][7]);
            textBox_model.Text = part_datatable.Rows[this.table_row][8].ToString();
            textBox_supplier.Text = part_datatable.Rows[this.table_row][9].ToString();
            textBox_notes.Text = part_datatable.Rows[this.table_row][12].ToString();
        }
        private void button_cancel_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("尚未儲存您的變更\n\n要捨棄變更嗎", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();
        }
        private void button_save_MouseClick(object sender, MouseEventArgs e)
        {
            string[] text = { textBox_name.Text.Trim(), textBox_partNo.Text.Trim(), textBox_supplier.Text.Trim(), textBox_model.Text.Trim() };

            DialogResult result = MessageBox.Show("是否儲存?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (CheckContent.hasRepeat(this.part_datatable, text, comboBox_type.SelectedItem.ToString()))
                    PutComponentData();
                else
                    return;
            }
            this.Close();
        }
        private async void PutComponentData()
        {
            var payload = new
            {
                id = part_datatable.Rows[this.table_row][0],
                product = textBox_name.Text.Trim(),
                quantity = numericUpDown_quantity.Value,
                type = comboBox_type.SelectedItem,
                partNo = textBox_partNo.Text.Trim(),
                moq = numericUpDown_MOQ.Value,
                supplier = textBox_supplier.Text.Trim(),
                price = numericUpDown_price.Value,
                status = comboBox_status.SelectedItem,
                model = textBox_model.Text.Trim(),
                note = textBox_notes.Text,
                user = Gobal.account,
                lastModified = DateTime.Now.ToString("yyyy/MM/dd HH:mm")
            };
            API.PutData(this.url, payload);

        }
    }
}
