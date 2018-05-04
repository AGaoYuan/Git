namespace MyTheaterTicket
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
            this.msUlit = new System.Windows.Forms.MenuStrip();
            this.购票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取新放映列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.继续销售ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcName = new System.Windows.Forms.TabControl();
            this.tpName = new System.Windows.Forms.TabPage();
            this.tvMovie = new System.Windows.Forms.TreeView();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.lblCalcPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblProjecting = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.gbTe = new System.Windows.Forms.GroupBox();
            this.txtZeng = new System.Windows.Forms.TextBox();
            this.cboZheKou = new System.Windows.Forms.ComboBox();
            this.lblXueSheng = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.rboXueSheng = new System.Windows.Forms.RadioButton();
            this.rboZengPiao = new System.Windows.Forms.RadioButton();
            this.rboPuTong = new System.Windows.Forms.RadioButton();
            this.tcFang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbQing = new System.Windows.Forms.PictureBox();
            this.msUlit.SuspendLayout();
            this.tcName.SuspendLayout();
            this.tpName.SuspendLayout();
            this.gbName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbTe.SuspendLayout();
            this.tcFang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQing)).BeginInit();
            this.SuspendLayout();
            // 
            // msUlit
            // 
            this.msUlit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.购票ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.msUlit.Location = new System.Drawing.Point(0, 0);
            this.msUlit.Name = "msUlit";
            this.msUlit.Size = new System.Drawing.Size(1228, 28);
            this.msUlit.TabIndex = 0;
            this.msUlit.Text = "menuStrip1";
            // 
            // 购票ToolStripMenuItem
            // 
            this.购票ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.获取新放映列表ToolStripMenuItem,
            this.继续销售ToolStripMenuItem,
            this.toolStripSeparator1,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出ToolStripMenuItem});
            this.购票ToolStripMenuItem.Name = "购票ToolStripMenuItem";
            this.购票ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.购票ToolStripMenuItem.Text = "购票";
            // 
            // 获取新放映列表ToolStripMenuItem
            // 
            this.获取新放映列表ToolStripMenuItem.Name = "获取新放映列表ToolStripMenuItem";
            this.获取新放映列表ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.获取新放映列表ToolStripMenuItem.Text = "获取新放映列表";
            this.获取新放映列表ToolStripMenuItem.Click += new System.EventHandler(this.获取新放映列表ToolStripMenuItem_Click);
            // 
            // 继续销售ToolStripMenuItem
            // 
            this.继续销售ToolStripMenuItem.Name = "继续销售ToolStripMenuItem";
            this.继续销售ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.继续销售ToolStripMenuItem.Text = "继续销售";
            this.继续销售ToolStripMenuItem.Click += new System.EventHandler(this.继续销售ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // tcName
            // 
            this.tcName.Controls.Add(this.tpName);
            this.tcName.Location = new System.Drawing.Point(12, 43);
            this.tcName.Name = "tcName";
            this.tcName.SelectedIndex = 0;
            this.tcName.Size = new System.Drawing.Size(232, 705);
            this.tcName.TabIndex = 1;
            // 
            // tpName
            // 
            this.tpName.BackColor = System.Drawing.Color.Gray;
            this.tpName.Controls.Add(this.tvMovie);
            this.tpName.Location = new System.Drawing.Point(4, 25);
            this.tpName.Name = "tpName";
            this.tpName.Padding = new System.Windows.Forms.Padding(3);
            this.tpName.Size = new System.Drawing.Size(224, 676);
            this.tpName.TabIndex = 0;
            this.tpName.Text = "放映列表";
            // 
            // tvMovie
            // 
            this.tvMovie.Location = new System.Drawing.Point(6, 6);
            this.tvMovie.Name = "tvMovie";
            this.tvMovie.Size = new System.Drawing.Size(212, 667);
            this.tvMovie.TabIndex = 0;
            this.tvMovie.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMovie_AfterSelect);
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.lblCalcPrice);
            this.gbName.Controls.Add(this.label7);
            this.gbName.Controls.Add(this.label6);
            this.gbName.Controls.Add(this.label5);
            this.gbName.Controls.Add(this.label4);
            this.gbName.Controls.Add(this.label3);
            this.gbName.Controls.Add(this.label1);
            this.gbName.Controls.Add(this.lblDirector);
            this.gbName.Controls.Add(this.lblDiscount);
            this.gbName.Controls.Add(this.lblOriginal);
            this.gbName.Controls.Add(this.lblProjecting);
            this.gbName.Controls.Add(this.lblType);
            this.gbName.Controls.Add(this.lblStar);
            this.gbName.Controls.Add(this.lblTitle);
            this.gbName.Controls.Add(this.pbImage);
            this.gbName.Location = new System.Drawing.Point(250, 31);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(648, 269);
            this.gbName.TabIndex = 2;
            this.gbName.TabStop = false;
            this.gbName.Text = "详情";
            // 
            // lblCalcPrice
            // 
            this.lblCalcPrice.AutoSize = true;
            this.lblCalcPrice.ForeColor = System.Drawing.Color.Red;
            this.lblCalcPrice.Location = new System.Drawing.Point(449, 224);
            this.lblCalcPrice.Name = "lblCalcPrice";
            this.lblCalcPrice.Size = new System.Drawing.Size(55, 15);
            this.lblCalcPrice.TabIndex = 14;
            this.lblCalcPrice.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(293, 21);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(52, 15);
            this.lblDirector.TabIndex = 7;
            this.lblDirector.Text = "导演：";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblDiscount.Location = new System.Drawing.Point(278, 231);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(67, 15);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "优惠价：";
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(278, 188);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(67, 15);
            this.lblOriginal.TabIndex = 5;
            this.lblOriginal.Text = "原票价：";
            // 
            // lblProjecting
            // 
            this.lblProjecting.AutoSize = true;
            this.lblProjecting.Location = new System.Drawing.Point(263, 140);
            this.lblProjecting.Name = "lblProjecting";
            this.lblProjecting.Size = new System.Drawing.Size(82, 15);
            this.lblProjecting.TabIndex = 4;
            this.lblProjecting.Text = "放映时间：";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(293, 101);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 15);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "类型：";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(293, 62);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(52, 15);
            this.lblStar.TabIndex = 2;
            this.lblStar.Text = "主演：";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "片名：";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(19, 43);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(170, 220);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // gbTe
            // 
            this.gbTe.Controls.Add(this.txtZeng);
            this.gbTe.Controls.Add(this.cboZheKou);
            this.gbTe.Controls.Add(this.lblXueSheng);
            this.gbTe.Controls.Add(this.lblPerson);
            this.gbTe.Controls.Add(this.rboXueSheng);
            this.gbTe.Controls.Add(this.rboZengPiao);
            this.gbTe.Controls.Add(this.rboPuTong);
            this.gbTe.Location = new System.Drawing.Point(904, 156);
            this.gbTe.Name = "gbTe";
            this.gbTe.Size = new System.Drawing.Size(308, 144);
            this.gbTe.TabIndex = 3;
            this.gbTe.TabStop = false;
            this.gbTe.Text = "特殊票：";
            // 
            // txtZeng
            // 
            this.txtZeng.Location = new System.Drawing.Point(87, 96);
            this.txtZeng.Name = "txtZeng";
            this.txtZeng.Size = new System.Drawing.Size(137, 25);
            this.txtZeng.TabIndex = 7;
            // 
            // cboZheKou
            // 
            this.cboZheKou.FormattingEnabled = true;
            this.cboZheKou.Location = new System.Drawing.Point(87, 55);
            this.cboZheKou.Name = "cboZheKou";
            this.cboZheKou.Size = new System.Drawing.Size(137, 23);
            this.cboZheKou.TabIndex = 6;
            this.cboZheKou.SelectedIndexChanged += new System.EventHandler(this.cboZheKou_SelectedIndexChanged);
            // 
            // lblXueSheng
            // 
            this.lblXueSheng.AutoSize = true;
            this.lblXueSheng.Location = new System.Drawing.Point(6, 63);
            this.lblXueSheng.Name = "lblXueSheng";
            this.lblXueSheng.Size = new System.Drawing.Size(82, 15);
            this.lblXueSheng.TabIndex = 4;
            this.lblXueSheng.Text = "学生折扣：";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(6, 106);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(67, 15);
            this.lblPerson.TabIndex = 5;
            this.lblPerson.Text = "增送者：";
            // 
            // rboXueSheng
            // 
            this.rboXueSheng.AutoSize = true;
            this.rboXueSheng.Location = new System.Drawing.Point(182, 24);
            this.rboXueSheng.Name = "rboXueSheng";
            this.rboXueSheng.Size = new System.Drawing.Size(73, 19);
            this.rboXueSheng.TabIndex = 0;
            this.rboXueSheng.TabStop = true;
            this.rboXueSheng.Text = "学生票";
            this.rboXueSheng.UseVisualStyleBackColor = true;
            this.rboXueSheng.CheckedChanged += new System.EventHandler(this.rboXueSheng_CheckedChanged);
            // 
            // rboZengPiao
            // 
            this.rboZengPiao.AutoSize = true;
            this.rboZengPiao.Location = new System.Drawing.Point(105, 24);
            this.rboZengPiao.Name = "rboZengPiao";
            this.rboZengPiao.Size = new System.Drawing.Size(58, 19);
            this.rboZengPiao.TabIndex = 0;
            this.rboZengPiao.TabStop = true;
            this.rboZengPiao.Text = "赠票";
            this.rboZengPiao.UseVisualStyleBackColor = true;
            this.rboZengPiao.CheckedChanged += new System.EventHandler(this.rboZengPiao_CheckedChanged);
            // 
            // rboPuTong
            // 
            this.rboPuTong.AutoSize = true;
            this.rboPuTong.Location = new System.Drawing.Point(17, 24);
            this.rboPuTong.Name = "rboPuTong";
            this.rboPuTong.Size = new System.Drawing.Size(73, 19);
            this.rboPuTong.TabIndex = 0;
            this.rboPuTong.TabStop = true;
            this.rboPuTong.Text = "普通票";
            this.rboPuTong.UseVisualStyleBackColor = true;
            this.rboPuTong.CheckedChanged += new System.EventHandler(this.rboPuTong_CheckedChanged);
            // 
            // tcFang
            // 
            this.tcFang.Controls.Add(this.tabPage1);
            this.tcFang.Location = new System.Drawing.Point(250, 306);
            this.tcFang.Name = "tcFang";
            this.tcFang.SelectedIndex = 0;
            this.tcFang.Size = new System.Drawing.Size(966, 442);
            this.tcFang.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "放映厅";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbQing
            // 
            this.pbQing.Image = global::MyTheaterTicket.Properties.Resources.QQ图片20180422155524;
            this.pbQing.Location = new System.Drawing.Point(904, 31);
            this.pbQing.Name = "pbQing";
            this.pbQing.Size = new System.Drawing.Size(308, 116);
            this.pbQing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQing.TabIndex = 5;
            this.pbQing.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 760);
            this.Controls.Add(this.pbQing);
            this.Controls.Add(this.tcFang);
            this.Controls.Add(this.gbTe);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.tcName);
            this.Controls.Add(this.msUlit);
            this.MainMenuStrip = this.msUlit;
            this.Name = "FrmMain";
            this.Text = "“青鸟”影院售票系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msUlit.ResumeLayout(false);
            this.msUlit.PerformLayout();
            this.tcName.ResumeLayout(false);
            this.tpName.ResumeLayout(false);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbTe.ResumeLayout(false);
            this.gbTe.PerformLayout();
            this.tcFang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msUlit;
        private System.Windows.Forms.ToolStripMenuItem 购票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.TabControl tcName;
        private System.Windows.Forms.TabPage tpName;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.GroupBox gbTe;
        private System.Windows.Forms.RadioButton rboPuTong;
        private System.Windows.Forms.RadioButton rboXueSheng;
        private System.Windows.Forms.RadioButton rboZengPiao;
        private System.Windows.Forms.TextBox txtZeng;
        private System.Windows.Forms.ComboBox cboZheKou;
        private System.Windows.Forms.Label lblXueSheng;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.TabControl tcFang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem 获取新放映列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 继续销售ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbQing;
        private System.Windows.Forms.TreeView tvMovie;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblProjecting;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblCalcPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

