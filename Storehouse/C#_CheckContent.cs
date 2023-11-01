using System.Data;
namespace Storehouse
{
    public class CheckContent
    {
        public static bool textBox_hasNotContent(string[] input, Label[] errorLabels)//判斷textBox沒有內容
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "")
                {
                    errorLabels[i].Visible = true;
                    return errorLabels[i].Visible;
                }
                else
                    errorLabels[i].Visible = false;
            }
            return false;
        }
        public static bool comboBox_hasNotSelected(int[] input, Label[] errorLabels)//判斷comboBox沒有選擇
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == -1)
                {
                    errorLabels[i].Visible = true;
                    return errorLabels[i].Visible;
                }
                else
                    errorLabels[i].Visible = false;
            }
            return false;
        }
        public static bool numericUpDown_hasNotValue(decimal[] input, Label[] errorLabels)//判斷numericUpDown沒有數值
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 0)
                {
                    errorLabels[i].Visible = true;
                    return errorLabels[i].Visible;
                }
                else
                    errorLabels[i].Visible = false;
            }
            return false;
        }
        public static  bool hasRepeat(DataTable datatable ,string[] text,string type_index)
        {
            foreach (DataRow row in datatable.Rows)

                if (row["partNo"].ToString() == text[1] && row["supplier"].ToString() == text[2] && row["model"].ToString() == text[3])
                {
                    if (row["name"].ToString() == text[0])
                        return true;
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("型號/料號相同,名稱不同");
                        DialogResult result = MessageBox.Show("名稱和對應料號/型號不同,是否儲存?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        return (result == DialogResult.Yes);
                    }
                }
                else if (row["partNo"].ToString() == text[1] && row["supplier"].ToString() == text[2])//料號相同,供應商不同
                {
                    System.Diagnostics.Debug.WriteLine("料號相同,供應商不同");
                    DialogResult result = MessageBox.Show("料號已經存在,是否儲存?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return (result == DialogResult.Yes);

                }
                else if (row["model"].ToString() == text[3] && row["supplier"].ToString() == text[2])//型號相同,供應商不同
                {
                    System.Diagnostics.Debug.WriteLine("型號相同,供應商不同");
                    DialogResult result = MessageBox.Show("該型號已經存在,是否儲存?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return (result == DialogResult.Yes);
                }
                else if (row["name"].ToString() == text[0] && row["type"].ToString() == "主料")//主料重複
                {
                    System.Diagnostics.Debug.WriteLine("主料已存在");
                    DialogResult result = MessageBox.Show("該品名主料已經存在,是否儲存?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return (result == DialogResult.Yes);
                }
            System.Diagnostics.Debug.WriteLine("我沒有找到重複資料");
            return true;
        }
    }
}
