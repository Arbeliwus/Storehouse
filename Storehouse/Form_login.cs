using Newtonsoft.Json;

namespace Storehouse
{
    public partial class Form_login : Form
    {
        private const string url = "http://localhost/api/login.php";
        public Form_login()
        {
            InitializeComponent();
        }
        private async void login_button_Click(object sender, EventArgs e)
        {
            Dictionary<string, (string, Label)> user = new Dictionary<string, (string, Label)>(){
                                          {"account",(textBox_account.Text,label_account)},
                                          {"password",(textBox_password.Text,label_password)}};
            foreach (KeyValuePair<string, (string, Label)> i in user)//當textbox為空時顯示對應label
            {
                if (i.Value.Item1 == "")
                {
                    i.Value.Item2.Visible = true;
                    return;
                }
                else
                    i.Value.Item2.Visible = false;
            }
            bool login_status = await API.GetUserInformation_GetData(url, textBox_account.Text, textBox_password.Text);
            if (login_status)
            {
                Form_main f2 = new Form_main();
                this.Visible = false;
                f2.Visible = true;
            }
            else
                MessageBox.Show("您的帳號或密碼錯誤，或是該帳號不存在", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Form_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}