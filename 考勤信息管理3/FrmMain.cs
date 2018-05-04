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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //定义了泛型集合List<SE>
        public List<SE> list = new List<SE>();

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //实例化增加的窗体对象
            FrmInsert fi = new FrmInsert();
            //通过this.调用当前对象的属性或者方法，
            fi.fm = this;
            //显示增加窗体
            fi.Show();
        }

        

        private void 打卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmDaKa fd = new FrmDaKa();//创建打卡窗体的对象
            fd.dic = this.dic;//通过this.调用当前对象的属性或者方法。
            fd.Show();//显示打卡的窗体
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }
        //刷新的方法，把List集合当参数传递
        public void BindGrid(List<SE> list)
        {
            //绑定当前DataGridView上
            this.dgvList.DataSource = new BindingList<SE>(list);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region 删除方法
            //使用DialogResult类型接受返回值
            DialogResult result = MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel);
            //判断用户的选择
            if (result == DialogResult.OK)
            {
                //获取当前选中的用户选中的列进行删除
                string num = dgvList.SelectedRows[0].Cells[0].Value.ToString();
                //循环打印集合中的元素
                for (int i = 0; i < list.Count; i++)
                {
                    //判断集合的第i位的ID是否和选中的ID一致
                    if (list[i].ID == num)
                    {
                        //删除对象
                        list.Remove(list[i]);
                        //调用绑定数据源的方法重新绑定数据源
                        BindGrid(list);
                        //提示语句
                        MessageBox.Show("删除成功！", "提示");
                    }
                }
            }
            #endregion

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            #region 模糊查询
            //定义泛型List<SE>类型的临时集合
            List<SE> temp = new List<SE>();
            //foreach循环原始集合list，类型为SE
            foreach (SE item in list)
            {
                //判断是否有返回值，并且通过ID来模糊查询，使用到了IndexOf方法
                if (item.ID.IndexOf(this.txtID.Text.Trim()) != -1)
                {
                    //绑定到临时集合中
                    temp.Add(item);
                }
            }
            //重新绑定数据源
            this.dgvList.DataSource = new BindingList<SE>(temp); 
            #endregion

        }
        //实例化双列集合Dictionary。Key为字符串类型，Record类为它的值
        public Dictionary<string, Record>  dic = new Dictionary<string, Record>();
        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断选中的行是否大于0
            if (this.dgvList.SelectedRows.Count < 1)
            {
                //给用户提示。
                MessageBox.Show("请选中一行!");
                return;
            }
            //获取DataGridView选中的值。
            string workNo = dgvList.CurrentRow.Cells[0].Value.ToString();
            //循环string类型的键
            foreach (string id in dic.Keys)
            {
                //判断选中的值和id是否相同
                if (workNo == id)
                {
                    //如果相同就证明已经签到过了
                    MessageBox.Show("您已经签到过了！");
                    return;
                }
            }
            //实例化Record类的对象
            Record record = new Record();
            //把选中的值给ID
            record.ID = workNo;
            //将选中的值给变量name
            record.Name = dgvList.CurrentRow.Cells[1].Value.ToString();
            //获取当前本机上的时间。
            record.SignInTime = DateTime.Now;
            //添加到双列集合Dictionary中，ID为键，整个对象为值
            this.dic.Add(record.ID,record);
            //提示用户
            MessageBox.Show("签到成功！");
        }

        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断选中的行数是否大于1，并提示
            if (this.dgvList.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选中一行！");
                return;
            }
            //将选中的值赋给变量ID
            string ID = dgvList.CurrentRow.Cells[0].Value.ToString();
            //定义布尔变量，为false
            bool isOut = false;
            //循环Key键
            foreach (string key in dic.Keys)
            {
                //判断是否相等
                if (key == ID)
                {
                    //签退的时间，并提示
                    this.dic[key].SignOutTime = DateTime.Now;
                    MessageBox.Show("签退成功！");
                    //布尔变量改为true并退出。
                    isOut = true;
                    break;
                }
            }
            //判断还没有签到就签退。
            if (!isOut)
            {
                MessageBox.Show("很抱歉，尚未签到！");
            }
        }



    }
}
