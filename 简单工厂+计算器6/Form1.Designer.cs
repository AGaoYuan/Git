namespace 简单工厂_计算器
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
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(106, 63);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(182, 25);
            this.txtName1.TabIndex = 0;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(479, 64);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(219, 25);
            this.txtName2.TabIndex = 0;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(715, 63);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 35);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "计算";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(331, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboType.Location = new System.Drawing.Point(309, 66);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(146, 23);
            this.cboType.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 534);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.Name = "FrmMain";
            this.Text = "简单工厂+计算器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboType;
    }
}

