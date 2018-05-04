namespace MyCar_Rental
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tcUlit = new System.Windows.Forms.TabControl();
            this.tpRental = new System.Windows.Forms.TabPage();
            this.lblBiao = new System.Windows.Forms.Label();
            this.btnType = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpTheCar = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCencel1 = new System.Windows.Forms.Button();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvList1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpInsert = new System.Windows.Forms.TabPage();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtTruckLoad = new System.Windows.Forms.TextBox();
            this.txtDailyRent = new System.Windows.Forms.TextBox();
            this.txtRentDate = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtLicenseNo = new System.Windows.Forms.TextBox();
            this.lblKaChe = new System.Windows.Forms.Label();
            this.lblYanSe = new System.Windows.Forms.Label();
            this.lblMeiRi = new System.Windows.Forms.Label();
            this.lblShijian = new System.Windows.Forms.Label();
            this.lblCheXing = new System.Windows.Forms.Label();
            this.lblChe = new System.Windows.Forms.Label();
            this.btnRegion = new System.Windows.Forms.Button();
            this.rbTruck = new System.Windows.Forms.RadioButton();
            this.rbcar = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCencel = new System.Windows.Forms.Button();
            this.tcUlit.SuspendLayout();
            this.tpRental.SuspendLayout();
            this.tpTheCar.SuspendLayout();
            this.tpInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUlit
            // 
            this.tcUlit.Controls.Add(this.tpRental);
            this.tcUlit.Controls.Add(this.tpTheCar);
            this.tcUlit.Controls.Add(this.tpInsert);
            this.tcUlit.Location = new System.Drawing.Point(12, 101);
            this.tcUlit.Name = "tcUlit";
            this.tcUlit.SelectedIndex = 0;
            this.tcUlit.Size = new System.Drawing.Size(794, 453);
            this.tcUlit.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcUlit.TabIndex = 0;
            // 
            // tpRental
            // 
            this.tpRental.Controls.Add(this.lblBiao);
            this.tpRental.Controls.Add(this.btnType);
            this.tpRental.Controls.Add(this.btnRefresh);
            this.tpRental.Controls.Add(this.txtName);
            this.tpRental.Controls.Add(this.label1);
            this.tpRental.Controls.Add(this.lvList);
            this.tpRental.Location = new System.Drawing.Point(4, 25);
            this.tpRental.Name = "tpRental";
            this.tpRental.Padding = new System.Windows.Forms.Padding(3);
            this.tpRental.Size = new System.Drawing.Size(786, 424);
            this.tpRental.TabIndex = 0;
            this.tpRental.Text = "租车";
            this.tpRental.UseVisualStyleBackColor = true;
            // 
            // lblBiao
            // 
            this.lblBiao.AutoSize = true;
            this.lblBiao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBiao.Location = new System.Drawing.Point(327, 16);
            this.lblBiao.Name = "lblBiao";
            this.lblBiao.Size = new System.Drawing.Size(93, 20);
            this.lblBiao.TabIndex = 4;
            this.lblBiao.Text = "可租车辆";
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(393, 373);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(75, 33);
            this.btnType.TabIndex = 3;
            this.btnType.Text = "租车";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(251, 373);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 33);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(340, 328);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 25);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "租用者";
            // 
            // lvList
            // 
            this.lvList.AllowColumnReorder = true;
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvList.FullRowSelect = true;
            this.lvList.Location = new System.Drawing.Point(6, 51);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(765, 260);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "车牌号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "车名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "颜色";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "使用时间";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "日租金";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "卡车载重";
            this.columnHeader6.Width = 130;
            // 
            // tpTheCar
            // 
            this.tpTheCar.Controls.Add(this.label3);
            this.tpTheCar.Controls.Add(this.button2);
            this.tpTheCar.Controls.Add(this.btnCencel1);
            this.tpTheCar.Controls.Add(this.txtDay);
            this.tpTheCar.Controls.Add(this.label2);
            this.tpTheCar.Controls.Add(this.lvList1);
            this.tpTheCar.Location = new System.Drawing.Point(4, 25);
            this.tpTheCar.Name = "tpTheCar";
            this.tpTheCar.Padding = new System.Windows.Forms.Padding(3);
            this.tpTheCar.Size = new System.Drawing.Size(786, 424);
            this.tpTheCar.TabIndex = 1;
            this.tpTheCar.Text = "还车";
            this.tpTheCar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(328, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "结算";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCencel1
            // 
            this.btnCencel1.Location = new System.Drawing.Point(393, 379);
            this.btnCencel1.Name = "btnCencel1";
            this.btnCencel1.Size = new System.Drawing.Size(100, 39);
            this.btnCencel1.TabIndex = 3;
            this.btnCencel1.Text = "选择结算";
            this.btnCencel1.UseVisualStyleBackColor = true;
            this.btnCencel1.Click += new System.EventHandler(this.btnCencel1_Click);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(290, 342);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(189, 25);
            this.txtDay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "租用天数";
            // 
            // lvList1
            // 
            this.lvList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvList1.FullRowSelect = true;
            this.lvList1.Location = new System.Drawing.Point(6, 52);
            this.lvList1.Name = "lvList1";
            this.lvList1.Size = new System.Drawing.Size(774, 282);
            this.lvList1.TabIndex = 0;
            this.lvList1.UseCompatibleStateImageBehavior = false;
            this.lvList1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "车牌号";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "车名";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "颜色";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "使用时间";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "日租金";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "卡车载重";
            this.columnHeader12.Width = 110;
            // 
            // tpInsert
            // 
            this.tpInsert.Controls.Add(this.cbColor);
            this.tpInsert.Controls.Add(this.txtTruckLoad);
            this.tpInsert.Controls.Add(this.txtDailyRent);
            this.tpInsert.Controls.Add(this.txtRentDate);
            this.tpInsert.Controls.Add(this.textBox2);
            this.tpInsert.Controls.Add(this.txtLicenseNo);
            this.tpInsert.Controls.Add(this.lblKaChe);
            this.tpInsert.Controls.Add(this.lblYanSe);
            this.tpInsert.Controls.Add(this.lblMeiRi);
            this.tpInsert.Controls.Add(this.lblShijian);
            this.tpInsert.Controls.Add(this.lblCheXing);
            this.tpInsert.Controls.Add(this.lblChe);
            this.tpInsert.Controls.Add(this.btnRegion);
            this.tpInsert.Controls.Add(this.rbTruck);
            this.tpInsert.Controls.Add(this.rbcar);
            this.tpInsert.Location = new System.Drawing.Point(4, 25);
            this.tpInsert.Name = "tpInsert";
            this.tpInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tpInsert.Size = new System.Drawing.Size(786, 424);
            this.tpInsert.TabIndex = 2;
            this.tpInsert.Text = "新车入库";
            this.tpInsert.UseVisualStyleBackColor = true;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(307, 151);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(201, 23);
            this.cbColor.TabIndex = 4;
            // 
            // txtTruckLoad
            // 
            this.txtTruckLoad.Location = new System.Drawing.Point(307, 287);
            this.txtTruckLoad.Name = "txtTruckLoad";
            this.txtTruckLoad.Size = new System.Drawing.Size(201, 25);
            this.txtTruckLoad.TabIndex = 3;
            // 
            // txtDailyRent
            // 
            this.txtDailyRent.Location = new System.Drawing.Point(307, 239);
            this.txtDailyRent.Name = "txtDailyRent";
            this.txtDailyRent.Size = new System.Drawing.Size(201, 25);
            this.txtDailyRent.TabIndex = 3;
            // 
            // txtRentDate
            // 
            this.txtRentDate.Location = new System.Drawing.Point(307, 197);
            this.txtRentDate.Name = "txtRentDate";
            this.txtRentDate.Size = new System.Drawing.Size(201, 25);
            this.txtRentDate.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(307, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 25);
            this.textBox2.TabIndex = 3;
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.Location = new System.Drawing.Point(307, 70);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(201, 25);
            this.txtLicenseNo.TabIndex = 3;
            // 
            // lblKaChe
            // 
            this.lblKaChe.AutoSize = true;
            this.lblKaChe.Location = new System.Drawing.Point(153, 287);
            this.lblKaChe.Name = "lblKaChe";
            this.lblKaChe.Size = new System.Drawing.Size(67, 15);
            this.lblKaChe.TabIndex = 2;
            this.lblKaChe.Text = "卡车载重";
            // 
            // lblYanSe
            // 
            this.lblYanSe.AutoSize = true;
            this.lblYanSe.Location = new System.Drawing.Point(153, 159);
            this.lblYanSe.Name = "lblYanSe";
            this.lblYanSe.Size = new System.Drawing.Size(37, 15);
            this.lblYanSe.TabIndex = 2;
            this.lblYanSe.Text = "颜色";
            // 
            // lblMeiRi
            // 
            this.lblMeiRi.AutoSize = true;
            this.lblMeiRi.Location = new System.Drawing.Point(153, 239);
            this.lblMeiRi.Name = "lblMeiRi";
            this.lblMeiRi.Size = new System.Drawing.Size(67, 15);
            this.lblMeiRi.TabIndex = 2;
            this.lblMeiRi.Text = "每日租金";
            // 
            // lblShijian
            // 
            this.lblShijian.AutoSize = true;
            this.lblShijian.Location = new System.Drawing.Point(153, 197);
            this.lblShijian.Name = "lblShijian";
            this.lblShijian.Size = new System.Drawing.Size(67, 15);
            this.lblShijian.TabIndex = 2;
            this.lblShijian.Text = "使用时间";
            // 
            // lblCheXing
            // 
            this.lblCheXing.AutoSize = true;
            this.lblCheXing.Location = new System.Drawing.Point(153, 119);
            this.lblCheXing.Name = "lblCheXing";
            this.lblCheXing.Size = new System.Drawing.Size(37, 15);
            this.lblCheXing.TabIndex = 2;
            this.lblCheXing.Text = "车型";
            // 
            // lblChe
            // 
            this.lblChe.AutoSize = true;
            this.lblChe.Location = new System.Drawing.Point(153, 80);
            this.lblChe.Name = "lblChe";
            this.lblChe.Size = new System.Drawing.Size(52, 15);
            this.lblChe.TabIndex = 2;
            this.lblChe.Text = "车牌号";
            // 
            // btnRegion
            // 
            this.btnRegion.Location = new System.Drawing.Point(290, 360);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(83, 34);
            this.btnRegion.TabIndex = 1;
            this.btnRegion.Text = "入库";
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.btnRegion_Click);
            // 
            // rbTruck
            // 
            this.rbTruck.AutoSize = true;
            this.rbTruck.Checked = true;
            this.rbTruck.Location = new System.Drawing.Point(391, 31);
            this.rbTruck.Name = "rbTruck";
            this.rbTruck.Size = new System.Drawing.Size(58, 19);
            this.rbTruck.TabIndex = 0;
            this.rbTruck.TabStop = true;
            this.rbTruck.Text = "卡车";
            this.rbTruck.UseVisualStyleBackColor = true;
            // 
            // rbcar
            // 
            this.rbcar.AutoSize = true;
            this.rbcar.Location = new System.Drawing.Point(245, 31);
            this.rbcar.Name = "rbcar";
            this.rbcar.Size = new System.Drawing.Size(58, 19);
            this.rbcar.TabIndex = 0;
            this.rbcar.Text = "轿车";
            this.rbcar.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(299, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(185, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "汽车租赁系统";
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(711, 560);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(91, 33);
            this.btnCencel.TabIndex = 1;
            this.btnCencel.Text = "退出";
            this.btnCencel.UseVisualStyleBackColor = true;
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 597);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tcUlit);
            this.Name = "FrmMain";
            this.Text = "汽车租赁系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcUlit.ResumeLayout(false);
            this.tpRental.ResumeLayout(false);
            this.tpRental.PerformLayout();
            this.tpTheCar.ResumeLayout(false);
            this.tpTheCar.PerformLayout();
            this.tpInsert.ResumeLayout(false);
            this.tpInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcUlit;
        private System.Windows.Forms.TabPage tpRental;
        private System.Windows.Forms.TabPage tpTheCar;
        private System.Windows.Forms.TabPage tpInsert;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBiao;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCencel1;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.RadioButton rbTruck;
        private System.Windows.Forms.RadioButton rbcar;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Label lblKaChe;
        private System.Windows.Forms.Label lblYanSe;
        private System.Windows.Forms.Label lblMeiRi;
        private System.Windows.Forms.Label lblShijian;
        private System.Windows.Forms.Label lblCheXing;
        private System.Windows.Forms.Label lblChe;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox txtTruckLoad;
        private System.Windows.Forms.TextBox txtDailyRent;
        private System.Windows.Forms.TextBox txtRentDate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtLicenseNo;
    }
}

