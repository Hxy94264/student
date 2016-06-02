using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GengdanContactsMIS_WinForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql ="select count(*) from Users where UserName='admin' and UserPassword='123'";
            //string sql = "select count(*) from Users where UserName='"+txtName.Text+"' and UserPassword='"+txtPassword.Text+"'";
            if (DB.GetCount(sql) > 0)
            {
                MainFrm f = new MainFrm();
                f.Show();
            }
            else
                MessageBox.Show("用户名或密码错误！");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
