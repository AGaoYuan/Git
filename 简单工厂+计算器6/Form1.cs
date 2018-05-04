using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单工厂_计算器
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.cboType.SelectedIndex = 0;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string number1 = txtName1.Text;
            string number2 = txtName2.Text;
            string oper = cboType.Text;

            Calcuator cal = CalculatorFactory.getInstance(oper);

            cal.NumBer1 =Convert.ToDouble(number1);
            cal.NumBer2 = Convert.ToDouble(number2);


            try
            {
                double Count =  cal.Calc();
                label1.Text = "计算结果" + Count.ToString();
                label1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                label1.Text = "";
            }


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }



    }
}
