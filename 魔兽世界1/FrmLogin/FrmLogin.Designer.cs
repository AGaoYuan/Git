namespace FrmLogin
{
    partial class FrmLogin
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblZhu = new System.Windows.Forms.Label();
            this.lblZhuCe = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblXia = new System.Windows.Forms.Label();
            this.pbimage2 = new System.Windows.Forms.PictureBox();
            this.pbimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(151, 177);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "电子邮件地址";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPwd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPwd.Location = new System.Drawing.Point(151, 327);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(37, 15);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "密码";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 219);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(652, 25);
            this.txtName.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(154, 362);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(652, 25);
            this.txtPwd.TabIndex = 5;
            // 
            // lblZhu
            // 
            this.lblZhu.AutoSize = true;
            this.lblZhu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblZhu.Location = new System.Drawing.Point(151, 531);
            this.lblZhu.Name = "lblZhu";
            this.lblZhu.Size = new System.Drawing.Size(150, 15);
            this.lblZhu.TabIndex = 6;
            this.lblZhu.Text = "还没有身份证?现在就";
            // 
            // lblZhuCe
            // 
            this.lblZhuCe.AutoSize = true;
            this.lblZhuCe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblZhuCe.Location = new System.Drawing.Point(317, 535);
            this.lblZhuCe.Name = "lblZhuCe";
            this.lblZhuCe.Size = new System.Drawing.Size(39, 15);
            this.lblZhuCe.TabIndex = 7;
            this.lblZhuCe.Text = "____";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(154, 439);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 37);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblXia
            // 
            this.lblXia.AutoSize = true;
            this.lblXia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblXia.Location = new System.Drawing.Point(317, 531);
            this.lblXia.Name = "lblXia";
            this.lblXia.Size = new System.Drawing.Size(37, 15);
            this.lblXia.TabIndex = 9;
            this.lblXia.Text = "注册";
            this.lblXia.Click += new System.EventHandler(this.lblXia_Click);
            // 
            // pbimage2
            // 
            this.pbimage2.Image = global::FrmLogin.Properties.Resources.关闭;
            this.pbimage2.Location = new System.Drawing.Point(917, 0);
            this.pbimage2.Name = "pbimage2";
            this.pbimage2.Size = new System.Drawing.Size(46, 40);
            this.pbimage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimage2.TabIndex = 1;
            this.pbimage2.TabStop = false;
            this.pbimage2.Click += new System.EventHandler(this.pbimage2_Click);
            // 
            // pbimage
            // 
            this.pbimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbimage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbimage.Image = global::FrmLogin.Properties.Resources.魔兽登录图标;
            this.pbimage.Location = new System.Drawing.Point(0, 0);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(963, 149);
            this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimage.TabIndex = 0;
            this.pbimage.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(963, 653);
            this.Controls.Add(this.lblXia);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblZhuCe);
            this.Controls.Add(this.lblZhu);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbimage2);
            this.Controls.Add(this.pbimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔兽登录窗体";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.PictureBox pbimage2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblZhu;
        private System.Windows.Forms.Label lblZhuCe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblXia;
    }
}

