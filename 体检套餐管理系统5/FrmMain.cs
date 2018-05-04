using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoutiqueSuite
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
            this.cmbolist.SelectedIndex = 0;//显示系统默认套餐
        }
        
        //采用泛型集合List保存所有的体检项目
        List<HealthCheckItem> AllItems = new List<HealthCheckItem>();
        //采用泛型集合List保存套餐中的体检项目
        List<HealthCheckItem> items = new List<HealthCheckItem>();
        //定义双列集合拿到对应套餐列表项目
        Dictionary<string, HealthCheckSet> HealthSet = new Dictionary<string, HealthCheckSet>();
        HealthCheckItem height, weight, sight, hearing, liverFun, ekg;//检查项目
        //定义一个默认套餐
        HealthCheckSet setA;

        #region 初始化
        private void FrmMain_Load(object sender, EventArgs e)
        {
            dgvHealthList.AutoGenerateColumns = false;

            

            lblSetName.Text = "";
            lblSetPrice.Text = "";
            this.btnDelete.Enabled = false;
            this.btnInsertcheckName.Enabled = false;
            InitItems();//检查项目
            MoRen();
            Init();
           

        }
          #endregion
        //单击添加按钮，将新键的套餐添加到套餐集合中，并在下拉框套餐列表中显示
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txttaocanName.Text != null)
            {
                InserttaocanName();//用户输入的集合加到套餐列表中
            }
            else
            {
                MessageBox.Show("请输入一个套餐名称！");
            }
            

        }

        #region 检查项目信息
        public void InitItems()
        {
            //使用构造函数添加检查项目，使用对象集合初始化器
            height =  new HealthCheckItem("身高", 5, "用于检查身高");
            weight = new HealthCheckItem("体重", 8, "用于检查体重");
            sight = new HealthCheckItem("视力", 10, "用于检查视力");
            hearing = new HealthCheckItem("听力", 10, "用于检查听力");
            liverFun = new HealthCheckItem("肝功能", 50, "用于检查肝功能");
            ekg = new HealthCheckItem("心电图", 100, "用于检查心电图");

            AllItems.Add(height);
            AllItems.Add(weight);
            AllItems.Add(sight);
            AllItems.Add(hearing);
            AllItems.Add(liverFun);
            AllItems.Add(ekg);
        } 
        #endregion


        public void Init()
        {
            //清空下拉列表
            this.cobItemName.Items.Clear();
            //添加请选择
            this.cobItemName.Items.Add("请选择");
            foreach (HealthCheckItem key in AllItems)
            {
                this.cobItemName.Items.Add(key.Name);
                this.btnInsertcheckName.Enabled = true;
                //   MessageBox.Show(key);
            }
            this.cobItemName.SelectedIndex = 0;
        }
        //在套餐列表中的默认一个“入学体检”并给此套餐设置制定的检查项目
        public void MoRen()
        {
            items = new List<HealthCheckItem>();
            items.Add(height);//添加检查项目
            items.Add(weight);
            items.Add(liverFun);
            setA = new HealthCheckSet("入学体检", items);
            
            this.HealthSet.Add("入学体检", setA);
            //计算价格
            setA.CalcPrice();
            //更新
            UpdateSet(setA);
            foreach (var item in HealthSet)
            {
                this.cmbolist.Items.Add(item.Key);
            }


        }
        /// <summary>
        /// 用户输入的套餐名称加到套餐列表中
        /// </summary>
        private void InserttaocanName()
        {
            if (this.txttaocanName.Text.Trim()!="")//非空判断
            {
                string taocannam= this.txttaocanName.Text;
                if (!this.cmbolist.Items.Contains(taocannam))
                {

                    this.HealthSet.Add(this.txttaocanName.Text, setA);//使用Add方法添加进去
                    this.cmbolist.Items.Clear();//先清除项
                    
                    this.cmbolist.Items.Add("请选择");//添加项

                    foreach (string key in HealthSet.Keys)//利用foreach循环将用户要添加的套餐名称加到集合中
                    {
                        this.cmbolist.Items.Add(key);//加到列表项中
                    }
                    this.cmbolist.SelectedIndex = this.HealthSet.Count;
                    this.cmbolist.Text = txttaocanName.Text;//显示请选择
                    this.dgvHealthList.Rows.Clear();//清空
                    MessageBox.Show("添加成功！");
                    this.txttaocanName.Text = null;//文本框置空
                }
                else
                {
                    MessageBox.Show("已存在该套餐！");
                }
            }
            else
            {
                MessageBox.Show("请输入一个套餐名称！");
            }
        }
        //选择套餐列表下拉列表事件
        private void cmbolist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string setName = this.cmbolist.Text;//套餐列表名
            if (setName == "请选择")
            {
                this.dgvHealthList.DataSource = new BindingList<HealthCheckItem>();//绑定数据到DataGridView上
                lblSetName.Text = "";
                lblSetPrice.Text = "";
                this.btnDelete.Enabled = false;
                return;
            }
            //设置套餐名称
            lblSetName.Text = setName;
            //设置套餐总价
            lblSetPrice.Text = this.HealthSet[setName].Price.ToString();
            //更新套餐检查项目
            UpdateSet(HealthSet[setName]);
            //此时设置删除按钮为可用状态
            this.btnDelete.Enabled = true;
        }
        //更新套餐检查项目
        private void UpdateSet(HealthCheckSet set)
        {
             this.dgvHealthList.DataSource = new BindingList<HealthCheckItem>(set.Items);//重新绑定
        }
        //检查项目单击添加按钮，将选中项添加到泛型集合，并重新绑定DataGridView
        private void btnInsertcheckName_Click(object sender, EventArgs e)
        {
            InsertCheck();//将检查项目添加到集合中并在DataGridView中显示
            
        }
        //检查项目单击添加按钮，将选中项添加到泛型集合，并重新绑定DataGridView
        private void InsertCheck()
        {
            if (this.cmbolist.Text!= "请选择")//没有选择的判断
            {
                if (this.cobItemName.SelectedIndex != 0)
                {
                    string cmbolist = this.cmbolist.Text;//拿到用户选中的值
                    int index = this.cobItemName.SelectedIndex -1;//拿到用户选择的值得索引
                    if (!this.HealthSet[cmbolist].Items.Contains(AllItems[index]))//判断集合中是否已经有此项目了
                    {
                        //添加检查项目
                        this.HealthSet[cmbolist].Items.Add(AllItems[index]);
                        //重新计算总价格
                        this.HealthSet[cmbolist].CalcPrice();
                        //更新套餐检查项目
                        UpdateSet(this.HealthSet[cmbolist]);
                        //刷新套餐名
                        //this.lblSetName.Text = HealthSet[cmbolist].Name;
                        //MessageBox.Show(this.lblSetName.Text);
                        //刷新价格
                        this.lblSetPrice.Text = HealthSet[cmbolist].Price.ToString();
                        MessageBox.Show("添加成功！");
                    }
                    else
                    {
                        MessageBox.Show("该项目存在！");
                    }
                }
                else
                {
                    MessageBox.Show("请选择一个项目！");
                }
            }
            else
            {
                MessageBox.Show("请选择一个套餐！");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //删除检查项目
            string setName = this.cmbolist.Text;
            //MessageBox.Show(setName);
            if (this.dgvHealthList.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一项删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //获得所删除项的索引
                int index = this.dgvHealthList.SelectedRows[0].Index;
                //MessageBox.Show(index.ToString());
                //删除所选中的项
                this.HealthSet[setName].Items.RemoveAt(index);
                //重新计算价格
                this.HealthSet[setName].CalcPrice();
                //更新数据
                UpdateSet(HealthSet[setName]);
                this.lblSetName.Text = setA.Name;
                string cboSetText = this.cobItemName.Text;
                this.lblSetPrice.Text = setA.Price.ToString(); ;
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        

    }
}
