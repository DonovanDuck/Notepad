using Method_impl;
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
using Text_model;

namespace noteBook
{
    public partial class frmsave : Form
    {
        private Text_Dao.Dao dao = new Text_Dao.Dao();
        private  User user;
        private Text text;
        public frmsave(User user ,Text text)
        {
            this.user = user;
            this.text = text;
            InitializeComponent();
            bindCB(user.Username);
        }
        private void bindCB(string username) {
            //获取数据源
            List<string> klist = dao.searchTextkinds(username);
            //绑定
            comboBox1.DataSource = klist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获取数据
            frmMain mainForm = (frmMain)this.Owner;
            text.Name = this.textBox1.Text;
            text.ParentFolder = comboBox1.Text;
            text.User = user.Username;
            TextDbHandlerImp.TextEvent te = new TextDbHandlerImp.TextEvent(null, text);
            //添加数据
            dao.saveText(te);
            MessageBox.Show("保存成功", "文件保存");
            mainForm.richTextBox.Clear();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmkind fk = new frmkind();
            fk.Show();
        }
    }
}
