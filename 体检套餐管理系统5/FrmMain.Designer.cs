namespace BoutiqueSuite
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInserttaocanName = new System.Windows.Forms.Button();
            this.txttaocanName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSetPrice = new System.Windows.Forms.Label();
            this.lblSetName = new System.Windows.Forms.Label();
            this.dgvHealthList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsertcheckName = new System.Windows.Forms.Button();
            this.cobItemName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbolist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInserttaocanName);
            this.groupBox1.Controls.Add(this.txttaocanName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新建套餐";
            // 
            // btnInserttaocanName
            // 
            this.btnInserttaocanName.Location = new System.Drawing.Point(367, 33);
            this.btnInserttaocanName.Name = "btnInserttaocanName";
            this.btnInserttaocanName.Size = new System.Drawing.Size(98, 36);
            this.btnInserttaocanName.TabIndex = 2;
            this.btnInserttaocanName.Text = "添 加";
            this.btnInserttaocanName.UseVisualStyleBackColor = true;
            this.btnInserttaocanName.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttaocanName
            // 
            this.txttaocanName.Location = new System.Drawing.Point(160, 41);
            this.txttaocanName.Name = "txttaocanName";
            this.txttaocanName.Size = new System.Drawing.Size(178, 25);
            this.txttaocanName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "套餐名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSetPrice);
            this.groupBox2.Controls.Add(this.lblSetName);
            this.groupBox2.Controls.Add(this.dgvHealthList);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnInsertcheckName);
            this.groupBox2.Controls.Add(this.cobItemName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbolist);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 385);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "检查套餐维护";
            // 
            // lblSetPrice
            // 
            this.lblSetPrice.AutoSize = true;
            this.lblSetPrice.Location = new System.Drawing.Point(422, 145);
            this.lblSetPrice.Name = "lblSetPrice";
            this.lblSetPrice.Size = new System.Drawing.Size(47, 15);
            this.lblSetPrice.TabIndex = 10;
            this.lblSetPrice.Text = "price";
            // 
            // lblSetName
            // 
            this.lblSetName.AutoSize = true;
            this.lblSetName.Location = new System.Drawing.Point(161, 145);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(37, 15);
            this.lblSetName.TabIndex = 9;
            this.lblSetName.Text = "套餐";
            // 
            // dgvHealthList
            // 
            this.dgvHealthList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHealthList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHealthList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvHealthList.Location = new System.Drawing.Point(15, 175);
            this.dgvHealthList.Name = "dgvHealthList";
            this.dgvHealthList.RowTemplate.Height = 27;
            this.dgvHealthList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHealthList.Size = new System.Drawing.Size(640, 204);
            this.dgvHealthList.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "项目名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Description";
            this.Column2.HeaderText = "描述";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "价格";
            this.Column3.Name = "Column3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "套餐名：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(490, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删 除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsertcheckName
            // 
            this.btnInsertcheckName.Location = new System.Drawing.Point(367, 91);
            this.btnInsertcheckName.Name = "btnInsertcheckName";
            this.btnInsertcheckName.Size = new System.Drawing.Size(98, 36);
            this.btnInsertcheckName.TabIndex = 4;
            this.btnInsertcheckName.Text = "添 加";
            this.btnInsertcheckName.UseVisualStyleBackColor = true;
            this.btnInsertcheckName.Click += new System.EventHandler(this.btnInsertcheckName_Click);
            // 
            // cobItemName
            // 
            this.cobItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobItemName.FormattingEnabled = true;
            this.cobItemName.Location = new System.Drawing.Point(461, 45);
            this.cobItemName.Name = "cobItemName";
            this.cobItemName.Size = new System.Drawing.Size(178, 23);
            this.cobItemName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "检查项目：";
            // 
            // cmbolist
            // 
            this.cmbolist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbolist.FormattingEnabled = true;
            this.cmbolist.Items.AddRange(new object[] {
            "请选择"});
            this.cmbolist.Location = new System.Drawing.Point(160, 45);
            this.cmbolist.Name = "cmbolist";
            this.cmbolist.Size = new System.Drawing.Size(178, 23);
            this.cmbolist.TabIndex = 1;
            this.cmbolist.SelectedIndexChanged += new System.EventHandler(this.cmbolist_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "套餐列表：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "体检套餐管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInserttaocanName;
        private System.Windows.Forms.TextBox txttaocanName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cobItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbolist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsertcheckName;
        private System.Windows.Forms.DataGridView dgvHealthList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSetPrice;
        private System.Windows.Forms.Label lblSetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

