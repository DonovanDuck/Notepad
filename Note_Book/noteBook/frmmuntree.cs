using NoteBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Text_Dao;
using Text_model;

namespace noteBook
{
    public partial class frmmuntree : Form
    {
        private static Text_Dao.Dao dao = new Text_Dao.Dao();
        private User user;
        private string textname;
        public frmmuntree(User user)
        {
            this.user = user;
            InitializeComponent();
            showTexttree();
        }

        private void showTexttree() {
            //获取所有分类
            List<string> vareitys = dao.searchTextkinds(user.Username);
            //循环所有分类
            foreach (string v in vareitys) {
                //设置父节点
                TreeNode tn = new TreeNode(v);
                this.treeView1.Nodes.Add(tn);
                //获取每个分类的所有笔记
                List<Text> texts = dao.searchTextBykind(user.Username,v);
                //将获得的笔记设为父节点的子节点
                foreach (Text t in texts) {
                    tn.Nodes.Add(t.Name);
                }
            }

        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Expand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //根据名称查出笔记,为main设置Text对象
           frmMain.text = dao.openText(textname, "tom");
           frmMain mainForm = (frmMain)this.Owner;
            if (frmMain.needToSave == true)
            {
                DialogResult result = MessageBox.Show("当前文件是否需要保存", "保存提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Yes:
                        {
                            mainForm.menuItem32_Click(sender, e);
                            mainForm.richTextBox.Clear();
                            this.Text = "文本编辑--新建文本";
                            break;
                        }
                    case DialogResult.No:
                        {
                            mainForm.richTextBox.Clear();
                            this.Text = "文本编辑--新建文本";
                            frmMain.needToSave = false;
                            break;
                        }
                }
            }
            mainForm.richTextBox.Text = frmMain.text.Content;
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textname = e.Node.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        //{
        //    TreeViewItems.Add(e.Node);
        //}
    }
}
