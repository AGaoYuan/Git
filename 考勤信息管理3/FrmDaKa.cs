using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 考勤信息管理
{
    public partial class FrmDaKa : Form
    {
        public FrmDaKa()
        {
            InitializeComponent();
        }

        //定义Dictionary属性
        public Dictionary<string, Record> dic {get;set; }
        FrmMain fm = new FrmMain();
        private void FrmDaKa_Load(object sender, EventArgs e)
        {
            //使没有绑定数据源的值不显示在DataGridView上
            dgvList.AutoGenerateColumns = false;
            //实例化BindingSource对象
            BindingSource bs = new BindingSource();
            //先绑定在BindingSource对象的数据源上
            bs.DataSource = fm.dic.Values;
            //在绑定DataGridView上
            this.dgvList.DataSource = bs;
            //调用共有多少条记录的方法
            Rows();
        }

        public void Rows()
        {
            //获取DataGridView上的行数
            int row = dgvList.RowCount;
            //拼接到Label标签上
            this.lblName.Text = "共有"+row+"条打印记录";
        }



    }
}
