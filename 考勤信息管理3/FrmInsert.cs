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
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();//添加的方法
        }

        public FrmMain fm;//创建公共的窗体类型变量


        private void Insert()
        {
            //异常处理
            try
            {
                //实例化SE类对象
                SE se = new SE();
                //拿到文本框的值赋给ID  
                se.ID = txtID.Text.Trim();
                //拿到文本框的值赋给Name  
                se.Name = txtName.Text.Trim();
                //拿到文本框的值赋给Age
                se.Age =Convert.ToInt32(txtAge.Text.Trim());
                //判断选中的值是否等于男  
                if (this.cboSex.SelectedItem.ToString() == "男")
                {
                    se.Sex = Enum.男;
                }
                else
                {
                    se.Sex = Enum.女;
                }
                //循环集合list，类型为SE
                foreach (SE item in fm.list)
                {
                    //判断工号是否已经存在，并提示
                    if (item.ID == se.ID)
                    {
                        MessageBox.Show("此工号已经存在");
                        return;
                    }
                }
                //添加到集合中
                fm.list.Add(se);
                //关闭窗体
                this.Close();

            }
            catch (Exception ex)
            {
                //异常提示
                MessageBox.Show("出错:"+ex.Message);
            }
            finally
            {
                //调用绑定数据源的方法
                fm.BindGrid(fm.list);
            }

        }


        private void FrmInsert_Load(object sender, EventArgs e)
        {
            cboSex.SelectedIndex = 0;
            
        }
        



    }
}
