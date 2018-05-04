using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace MyTheaterTicket
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public Cinema cinema = new Cinema();

        public void Visibie()
        {
            label1.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            lblCalcPrice.Text = "";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.rboPuTong.Checked = true;
            Visibie();//隐藏Label
            ShowLabel();//动态生成Label


        }

        //定义要打印的数量
        int seatRow = 7;
        int seatLine = 5;
        //定义Label集合，来接收所有Label成员
        Dictionary<string,Label> labels = new Dictionary<string, Label>();


        #region 动态生成座位
        public void ShowLabel()
        {
            for (int i = 0; i < seatRow; i++)
            {
                for (int j = 0; j < seatLine; j++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Yellow;
                    label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    label.AutoSize = false;
                    label.Size = new System.Drawing.Size(50, 25);
                    label.Text = (j + 1).ToString() + "-" + (i + 1).ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Location = new Point(60 + (i * 90), 60 + (j * 60));
                    label.Click += label_Click;
                    tabPage1.Controls.Add(label);
                    labels.Add(label.Text, label);
                    Seat seat = new Seat((j + 1).ToString() + "-" + (i + 1).ToString(), Color.Yellow);
                    cinema.Seats.Add(seat.SeatNum, seat);
                }
            }
            foreach (Ticket tickey in cinema.SoldTickets)
            {
                foreach (Seat seat in cinema.Seats.Values)
                {
                    if ((tickey.ScheduleItem.Time == key) && (tickey.Seat.SeatNum == seat.SeatNum))
                    {
                        seat.Color = Color.Red;
                    }
                }
            }

        }
        #endregion


        void label_Click(object sender, EventArgs e)
        {
            try
            {
                string seatNum = ((Label) sender).Text.ToString();
                string customerName = this.txtZeng.Text;
                int discount = 0;
                string type = "";
                if (this.rboXueSheng.Checked)
                {
                    type = "student";
                    if (this.cboZheKou.Text == null)
                    {
                        MessageBox.Show("请输入折扣数！","提示");
                        return;
                    }
                    else
                    {
                        discount = int.Parse(this.cboZheKou.Text);
                    }
                }
                else if (this.rboZengPiao.Checked)
                {
                    if (string.IsNullOrEmpty(this.txtZeng.Text))
                    {
                        MessageBox.Show("请输入增票者姓名！","提示");
                        return;
                    }
                    else
                    {
                        type = "free";
                    }
                }
                Ticket newTicket = TicketUtil.CreateTicket(cinema.Schedule.Items[key], cinema.Seats[seatNum], discount,
                    customerName, type);
                if (cinema.Seats[seatNum].Color == Color.Yellow)
                {
                    DialogResult result = MessageBox.Show("是否购买?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        cinema.Seats[seatNum].Color = Color.Red;
                        UpdateSeat();
                        newTicket.CalcPrice();
                        cinema.SoldTickets.Add(newTicket);
                        lblCalcPrice.Text = newTicket.Price.ToString();
                        newTicket.Print();
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    foreach (Ticket tic in cinema.SoldTickets)
                    {
                        if (tic.Seat.SeatNum == seatNum && tic.ScheduleItem.Time == 
                            tvMovie.SelectedNode.Text 
                            &&tic.ScheduleItem.Movie.MovieName == tvMovie.SelectedNode.Parent.Text)
                        {
                            tic.Show();
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #region 更新座位状态
        private void UpdateSeat()
        {
            foreach (string key in cinema.Seats.Keys)
            {
                labels[key].BackColor = cinema.Seats[key].Color;
            }
        } 
        #endregion



        private void 获取新放映列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cinema.Schedule.LoadItems();//调用读取的方法
            InitTreeView();//读取XML文件绑定到TreeView上

        }

         
        #region 绑定到TreeView上
        public void InitTreeView()
        {
            string movieName = string.Empty;
            TreeNode node = null;
            foreach (ScheduleItem item in cinema.Schedule.Items.Values)
            {
                if (item.Movie.MovieName != movieName)
                {
                    node = new TreeNode(item.Movie.MovieName);
                    tvMovie.Nodes.Add(node);
                }
                TreeNode tn = new TreeNode(item.Time);
                node.Nodes.Add(tn);
                movieName = item.Movie.MovieName;
            }
        } 
        #endregion


        string key = string.Empty;
        private void tvMovie_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            TreeNode node = tvMovie.SelectedNode;
            if (node == null) return;
            if (node.Level != 1)return;
            key = node.Text;
            
            this.label1.Text = cinema.Schedule.Items[key].Movie.MovieName;

            this.label3.Text = cinema.Schedule.Items[key].Movie.Director;
            this.label4.Text = cinema.Schedule.Items[key].Movie.Actor;
            this.label5.Text = cinema.Schedule.Items[key].Movie.MovieType.ToString();
            this.label6.Text = cinema.Schedule.Items[key].Time;
            this.label7.Text = cinema.Schedule.Items[key].Movie.Price.ToString();
            this.pbImage.Image = Image.FromFile(cinema.Schedule.Items[key].Movie.Poster);
            this.lblCalcPrice.Text = ""; 


        }

        private void rboZengPiao_CheckedChanged(object sender, EventArgs e)
        {
            this.txtZeng.Enabled = true;
            this.cboZheKou.Enabled = false;
            this.cboZheKou.Text = "";
            this.lblCalcPrice.Text = "0";

        }

        private void rboXueSheng_CheckedChanged(object sender, EventArgs e)
        {
            this.txtZeng.Enabled = false;
            this.txtZeng.Text = "";
            this.cboZheKou.Enabled = true;
            string[] add = {"7", "8"};
            cboZheKou.DataSource = add;
            
        }

        private void cboZheKou_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.label7.Text != "")
            {
                int price = int.Parse(this.label7.Text);
                int discount = int.Parse(this.cboZheKou.Text);
                this.lblCalcPrice.Text = (price * discount / 10).ToString();
            }
        }

        private void rboPuTong_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rboPuTong.Text == "普通票")
            {
                this.cboZheKou.Text = "";
                this.txtZeng.Text = "";
                this.lblCalcPrice.Text = "";
            }

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定保存吗?", "提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                cinema.Save();
                MessageBox.Show("保存成功！","提示");
            }
            
        }

        private void 继续销售ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cinema.Schedule.LoadItems();//调用读取的方法
            InitTreeView();
            cinema.Load();
        }

        


    }
}
