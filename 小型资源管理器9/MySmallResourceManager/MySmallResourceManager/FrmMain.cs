using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MySmallResourceManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //定义成员变量
        TreeNode tn;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //检索计算机上的所有逻辑驱动器的驱动器名称。
            DriveInfo[] di = DriveInfo.GetDrives();
            //循环创建磁盘节点
            foreach (DriveInfo item in di)
            {
                tn = new TreeNode(item.Name);
                tn.Tag = item.Name;
                tvList.Nodes.Add(tn);
            }

        }

        private void tvList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取选中的节点
            TreeNode tn = tvList.SelectedNode;
            //将选中的节点传递给方法进行读取子目录
            BingInfo(tn);


        }

        public void BingInfo(TreeNode tn)
        {
            lvList.Items.Clear();
            //绑定子目录
            DirectoryInfo dic = new DirectoryInfo(tn.Tag.ToString());
            //加载子文件夹
            DirectoryInfo[] info = dic.GetDirectories();
            //循环子文件夹
            foreach (DirectoryInfo item in info)
            {
                //每加载一个文件夹就创建一个节点
                TreeNode temp = new TreeNode();
                temp.Text = item.Name;
                temp.Tag = item.FullName;
                tn.Nodes.Add(temp);
            }

            //获取目录下文件列表
            FileInfo[] fileinfo = dic.GetFiles();
            //定义泛型集合存储文件信息
            List<MyFile> files = new List<MyFile>();
            //遍历文件列表
            foreach (FileInfo it in fileinfo)
            {
                //把文件夹中的文件类型赋给成员变量
                MyFile file = new MyFile();
                file.FileName = it.Name;
                file.FileLength = it.Length;
                file.FileType = it.Extension;
                file.FilePath = it.FullName;
                files.Add(file);
            }
            //绑定到listview中
            foreach (MyFile em in files)
            {
                ListViewItem lv = new ListViewItem(em.FileName);
                lv.SubItems.Add(em.FileLength.ToString());
                lv.SubItems.Add(em.FileType);
                lv.SubItems.Add(em.FilePath);
                lvList.Items.Add(lv);
            }
        }

        private void tvList_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void 赋值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断ListView中的项是否为空
            if (this.lvList.SelectedItems.Count == 0)
            {
                return;
            }
            //提示用户选择文件夹
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            //打开的文件夹浏览对话框上的描述  
            fbd.Description = "请选择一个文件夹"; 
            //源文件路径
            string sourcePath = lvList.SelectedItems[0].SubItems[3].Text;
            //目标文件路径
            string desPath = null;
            //如果正确选择目标位置，执行复制操作

            if (result == DialogResult.OK)
            {
                desPath = fbd.SelectedPath;
                desPath += "\\" + lvList.SelectedItems[0].SubItems[0].Text;
                //复制文件
                File.Copy(sourcePath, desPath);
                MessageBox.Show("复制成功！");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvList.SelectedItems.Count == 0)
            {
                return;
            }
            //要删除的文件
            string sourcePath = lvList.SelectedItems[0].SubItems[3].Text;
            DialogResult result = MessageBox.Show(this, "确定要删除吗?", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                File.Delete(sourcePath);
                MessageBox.Show("删除成功!");
                //移除
                this.lvList.SelectedItems[0].Remove();
            }
        }



    }
}
