using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storehouse
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            label1.Text += Gobal.account;
        }
        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button_part_Click(object sender, EventArgs e)//零件表
        {
            panel_refresh(new Form_part_PSI(), this.panel_main);
            button_part.FlatStyle = FlatStyle.Flat;
            button_workorder.FlatStyle = FlatStyle.Standard;
            button_commodity.FlatStyle = FlatStyle.Standard;
            label1.Text = "正在瀏覽-零件進銷存";
        }
        private void button_commodity_Click(object sender, EventArgs e)//產品表
        {
            panel_refresh(new Form_product_PSI(), this.panel_main);
            button_commodity.FlatStyle = FlatStyle.Flat;
            button_workorder.FlatStyle = FlatStyle.Standard;
            button_part.FlatStyle = FlatStyle.Standard;
            label1.Text = "正在瀏覽-產品進銷存";
        }

        private void button_workorder_Click(object sender, EventArgs e)//工單
        {
            panel_refresh(new Form_workorder_main(), this.panel_main);
            button_workorder.FlatStyle = FlatStyle.Flat;
            button_part.FlatStyle = FlatStyle.Standard;
            button_commodity.FlatStyle = FlatStyle.Standard;
            label1.Text = "正在瀏覽-工單排程表";
        }

        private void button_logout_Click(object sender, EventArgs e)//登出
        {
            DialogResult result = MessageBox.Show("確定要登出嗎?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form_login f1 = new Form_login();
                f1.Show();
            }
            else
            {
                MessageBox.Show("登出失敗", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel_refresh(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }

    }
}
