using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCar_Rental
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public Dictionary<string, Vehicle> vehicle = new Dictionary<string,Vehicle>();//保存租车的集合
        public Dictionary<string, Vehicle> rentVehicles = new Dictionary<string, Vehicle>();//保存租出车的集合

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Initialization();
            color();
        }

        public void color()
        {
            List<Vehicle> list = new List<Vehicle>();

            Car car1 = new Car();
            car1.Color = "黑色";
            Car car2 = new Car();
            car1.Color = "白色";
            Car car3 = new Car();
            car1.Color = "粉红色";
            Car car4 = new Car();
            car1.Color = "红色";
            Car car5 = new Car();
            car1.Color = "绿色";
            list.Add(car1);
            list.Add(car2);
            list.Add(car3);
            list.Add(car4);
            list.Add(car5);
            foreach (var item in list)
            {
                string color = item.Color;
            }
            //cbColor.DataSource = new BindingList<Vehicle>(list);

        }



        #region 初始化
        public void Initialization()
        {
            Car car = new Car("白色", 240, "京A0000", "奥迪A6", 3);
            vehicle.Add(car.LicenseNO, car);
            Car car1 = new Car("白色", 240, "京A1111", "宝马", 3);
            vehicle.Add(car1.LicenseNO, car1);

            Truck tr = new Truck("蓝色", 50, "京N1111", "东风", 3, 50);
            rentVehicles.Add(tr.LicenseNO, tr);
            Truck tr1 = new Truck("蓝色", 30, "京N2222", "东风", 3, 40);
            rentVehicles.Add(tr1.LicenseNO, tr1);

        } 
        #endregion


        #region 绑定租车数据

        public void Zuchelist()
        {
            lvList.Items.Clear();
            foreach (var item in vehicle)
            {
                ListViewItem item1 = new ListViewItem(item.Key);
                item1.SubItems.Add(item.Value.Name);
                item1.SubItems.Add(item.Value.Color);
                item1.SubItems.Add(item.Value.RentDate.ToString());
                item1.SubItems.Add(item.Value.DailyRent.ToString());
                if (item.Value is Truck)
                {
                    item1.SubItems.Add(((item.Value) as Truck).Load.ToString());
                }
                else
                {
                    item1.SubItems.Add("无");
                }
                lvList.Items.Add(item1);
            }
        }
        #endregion

        #region 绑定已租还车数据

        public void Huaichelist()
        {
            lvList1.Items.Clear();
            foreach (var item in rentVehicles)
            {
                ListViewItem item2 = new ListViewItem(item.Key);
                item2.SubItems.Add(item.Value.Name);
                item2.SubItems.Add(item.Value.Color);
                item2.SubItems.Add(item.Value.RentDate.ToString());
                item2.SubItems.Add(item.Value.DailyRent.ToString());
                if (item.Value is Truck)
                {
                    item2.SubItems.Add(((item.Value) as Truck).Load.ToString());
                }
                else
                {
                    item2.SubItems.Add("无");
                }
                lvList1.Items.Add(item2);
            }
        }
        #endregion




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Zuchelist();
            
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Huaichelist();
        }
        

        private void btnType_Click(object sender, EventArgs e)
        {
            TianJia();//添加
            
        }

        #region 租出
        private void TianJia()
        {
            
            string key = lvList.SelectedItems[0].Text;

            vehicle[key].RentUser = this.txtName.Text;
            rentVehicles.Add(vehicle[key].LicenseNO, vehicle[key]);
            if (vehicle.ContainsKey(key))
            {
                vehicle.Remove(key);
                Zuchelist();
                MessageBox.Show("已租出。", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("未选中车辆！", "提示");
            }
        }
        #endregion

        private void btnCencel1_Click(object sender, EventArgs e)
        {
            Count();//结算价格

        }

        #region 结算价格
        private void Count()
        {
            if (txtDay.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入租用天数");
            }
            if (lvList1.SelectedItems.Count < 0)
            {
                MessageBox.Show("请选择您要结算得车辆");
            }
            else
            {
                string key = lvList1.SelectedItems[0].Text;
                
                    rentVehicles[key].YearsOfService = int.Parse(txtDay.Text);
                    if (txtDay.Text != string.Empty)
                    {
                        double totalPrice = rentVehicles[key].Price();
                        MessageBox.Show("您的总价是：" + totalPrice.ToString());
                        vehicle.Add(rentVehicles[key].LicenseNO, rentVehicles[key]);
                        if (rentVehicles.ContainsKey(key))
                        {
                            rentVehicles.Remove(key);
                            Huaichelist();
                        }
                    }
            }
        } 
        #endregion


        #region 非空判断
        public bool emptyNo()
        {
            //如果选择了汽车           
            if (this.rbcar.Checked == true)
            {
                if (this.txtLicenseNo.Text != "" && this.
                    txtDailyRent.Text != "" && this.txtName.Text != "" && this.txtRentDate.Text != "")
                {
                    try
                    {
                        //文本框数字验证
                        int rntDate = int.Parse(this.txtRentDate.Text);
                        int dailyRent = int.Parse(this.txtDailyRent.Text);
                        //double truckLoad = double.Parse(this.txtTruckLoad.Text);
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("使用时间，日租金应输入数字！");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("请完善新入库汽车信息！");
                    return false;
                }

            }
            else if (this.rbTruck.Checked == true)
            {
                if (this.txtLicenseNo.Text != "" && this.txtDailyRent.Text != "" && this.txtName.Text != "" && this.txtRentDate.Text != "" && this.txtTruckLoad.Text != "")
                {
                    try
                    {
                        //文本框数字验证
                        int rntDate = int.Parse(this.txtRentDate.Text);
                        int dailyRent = int.Parse(this.txtDailyRent.Text);
                        double truckLoad = double.Parse(this.txtTruckLoad.Text);
                        return true;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("使用时间，日租金或卡车载重应输入数字！");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("请完善新入库卡车信息！");
                    return false;
                }
            }
            return true;//防止报错
        } 
        #endregion



        private void btnRegion_Click(object sender, EventArgs e)
        {
            Insert();//入库

        }

        private void Insert()
        {
            //文本框非空验证       
            if (emptyNo())
            {
                //对车载重的值做一个判断，然后存入不同的集合
                if (this.txtTruckLoad.Visible == false)
                {
                    //车牌号是唯一的
                    string licenseNo = this.txtLicenseNo.Text;//车牌号
                    foreach (string ve in vehicle.Keys)//循环查看是否有相同的车牌号，有给出提示
                    {
                        if (ve == licenseNo)
                        {
                            MessageBox.Show("已经有相同的汽车车牌号，请您重新确认车牌号！");
                            return;
                        }
                    }

                    string name = this.txtName.Text;//车名
                    string cbColor = this.cbColor.SelectedItem.ToString();//颜色
                    int rentDate = Convert.ToInt32(this.txtRentDate.Text);//使用时间
                    double dailyRent = Convert.ToDouble(this.txtDailyRent.Text);//每日租金
                    //双列集合一般用对象初始化器，单列集合用集合初始化器，在添加数据的时候比较方便   
                    Car car = new Car(licenseNo, name, cbColor, rentDate, dailyRent);
                    //添加到可租车集合
                    vehicle.Add(car.LicenseNO, car);
                    MessageBox.Show("汽车入库成功!");
                }
                else if (this.txtTruckLoad.Visible == true)
                {
                    //车牌号是唯一的
                    string licenseNo = this.txtLicenseNo.Text;//车牌号
                    foreach (string rve in vehicle.Keys)//循环查看是否有相同的车牌号，有给出提示
                    {
                        if (rve == licenseNo)
                        {
                            MessageBox.Show("已经有相同的卡车车牌号，请您重新确认车牌号！");
                            return;
                        }
                    }
                    string name = this.txtName.Text;//车名
                    string cbColor = this.cbColor.SelectedItem.ToString();//颜色
                    int rentDate = Convert.ToInt32(this.txtRentDate.Text);//使用时间
                    double dailyRent = Convert.ToDouble(this.txtDailyRent.Text);//每日租金
                    int load = Convert.ToInt32(this.txtTruckLoad.Text);
                    //双列集合一般用对象初始化器，单列集合用集合初始化器，在添加数据的时候比较方便   
                    Truck tk = new Truck(licenseNo, name, cbColor, rentDate, dailyRent, load);
                    //添加到可租车集合
                    vehicle.Add(tk.LicenseNO, tk);

                    MessageBox.Show("卡车入库成功!");
                }

            }
        }



    }
}
