using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            Regist();
            this.Close();
        }

        public static Ulit[] num = new Ulit[20];

        private void Regist()
        {
            foreach (var item in num)
            {
                Ulit.Name1 = txtName.Text;
                Ulit.Pwd1 = txtPwd.Text;
                Ulit.Shen1 = txtShen.Text;
                Ulit.You1 = txtYou.Text;
                Ulit.Que1 = txtQue.Text;
                Ulit.QueRen1 = txtQueRen.Text;
            }

            if (Ulit.Name1.Equals(""))
            {
                MessageBox.Show("姓名不能为空！","提示");
                txtName.Focus();
            }
            else if (Ulit.Pwd1.Equals(""))
            {
                MessageBox.Show("密码不能为空！","提示");
                txtPwd.Focus();
            }
            else if (Ulit.Shen1.Equals(""))
            {
                MessageBox.Show("身份证号不能为空并且不能小于18位","提示");
                txtShen.Focus();
            }
            else if (Ulit.You1.Equals(""))
            {
                MessageBox.Show("邮箱不能为空","提示");
                txtYou.Focus();
            }
            else if (Ulit.Que1.Equals("") && txtYou.Text != txtQue.Text)
            {
                MessageBox.Show("确认邮箱不能为空，并且必须一致","提示");
                txtQue.Focus();
            }
            else if (Ulit.QueRen1.Equals("") && txtPwd.Text != txtQueRen.Text)
            {
                MessageBox.Show("确认密码不能为空，并且必须一致","提示");
                txtQueRen.Focus();
            }
            else
            {
                MessageBox.Show("注册成功！","提示");
            }
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegist_Load(object sender, EventArgs e)
        {

        }




    }
}
