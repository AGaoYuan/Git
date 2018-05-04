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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblXia_Click(object sender, EventArgs e)
        {
            //显示注册窗体
            FrmRegist fr = new FrmRegist();
            fr.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            PanDuan();//调用判断的方法

            
        }


        #region 判断的方法
        private void PanDuan()
        {
            try
            {
                if (Ulit.Name1.Equals(txtName.Text) && Ulit.Pwd1.Equals(txtPwd.Text))
                {
                    FrmMain fm = new FrmMain();
                    fm.Name = txtName.Text;
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "提示");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("没有此用户，请先注册", "提示");
            }
        }
        #endregion

        

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pbimage2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
