namespace 考勤信息管理
{
    partial class FrmInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbName = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.btnInsert);
            this.gbName.Controls.Add(this.cboSex);
            this.gbName.Controls.Add(this.txtName);
            this.gbName.Controls.Add(this.txtAge);
            this.gbName.Controls.Add(this.txtID);
            this.gbName.Controls.Add(this.lblID);
            this.gbName.Controls.Add(this.lblAge);
            this.gbName.Controls.Add(this.lblName);
            this.gbName.Controls.Add(this.lblSex);
            this.gbName.Location = new System.Drawing.Point(37, 12);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(500, 497);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "信息维护";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(212, 431);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 34);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "保存";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cboSex
            // 
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(153, 377);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(226, 23);
            this.cboSex.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 264);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 25);
            this.txtName.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(153, 155);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(226, 25);
            this.txtAge.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(153, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(226, 25);
            this.txtID.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(59, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "工号";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(59, 165);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 15);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "年龄";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 274);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(59, 385);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(37, 15);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "性别";
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 521);
            this.Controls.Add(this.gbName);
            this.Name = "FrmInsert";
            this.Text = "员工信息维护";
            this.Load += new System.EventHandler(this.FrmInsert_Load);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnInsert;
    }
}