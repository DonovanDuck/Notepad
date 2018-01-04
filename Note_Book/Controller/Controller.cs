using Model_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_model;
using Text_Dao;
using Method_impl;

namespace Controller
{
    public class Controller
    {
        
        public void newText( FunctionEvent e)
        {
            if ("1".Equals(e.Choose))
            {
                e.text = new Text();
                e.th.write(e.text);
                if (e.user == null)
                {
                    Console.WriteLine("请先登录");
                }
                else
                {
                    if (e.dao != null)
                    {
                        e.text.User = e.user.Username;
                        TextDbHandlerImp.insertEvent += e.dao.saveText;
                    }
                    e.th.SaveFile(e.text);
                }
            }
        }

        public void opentext(FunctionEvent e) {
            if ("2".Equals(e.Choose)) {
                e.text = new Text();
                if (e.user != null)
                {
                    if (e.dao != null)
                    {
                        TextDbHandlerImp.searchtextEvent += e.dao.openText;
                        e.text = e.thdb.OpenFile(e.user.Username);
                    }
                    else
                    {
                        e.text = e.th.OpenFile();
                    }
                    Console.WriteLine("笔记内容：\n" + e.text.Content);
                }
                else
                {
                    Console.WriteLine("请先登录");
                }
            }
        }

        public void saveText(FunctionEvent e) {
            if ("3".Equals(e.Choose)) {
                if (e.user != null)
                {
                    if (e.text.Content == null || "".Equals(e.text.Content))
                    {
                        Console.WriteLine("请先新建笔记");
                    }
                    else
                    {
                        TextDbHandlerImp.insertEvent += e.dao.saveText;
                        e.th.SaveFile(e.text);
                    }
                }
                else
                {
                    Console.WriteLine("请先登录");
                }
            }
        }
        public void login( FunctionEvent e)
        {
            if ("4".Equals(e.Choose))
            {
                TextDbHandlerImp.searchuserEvent += e.dao.signIn;
                e.user = e.thdb.signIn();
                if (e.user != null)
                {
                    Console.WriteLine("欢迎：" + e.user.Username + "，请继续操作");
                    if (e.text != null)
                    {
                        e.text.User = e.user.Username;
                    }
                }
                else
                {
                    Console.WriteLine("用户名或密码错误");

                }
            }
        }
        public void register( FunctionEvent e)
        {
            if ("5".Equals(e.Choose))
            {
                TextDbHandlerImp.insertEvent += e.dao.signUp;
                e.thdb.signUp();
            }
        }

        public void exit( FunctionEvent e)
        {
            if ("0".Equals(e.Choose))
            {
                return;
            }
        }
    }


    public class FunctionEvent {
        private  string _choose;
        public Text text;
        public  TextHandle th;
        public TextDbHandlerImp thdb;
        public User user;
        public Text_Dao.Dao dao;

        public FunctionEvent(Text text, TextHandle th, TextDbHandlerImp thdb, User user, Text_Dao.Dao dao)
        {
            this.text = text;
            this.th = th;
            this.thdb = thdb;
            this.user = user;
            this.dao = dao;
        }

        public string Choose
        {
            get
            {
                return _choose;
            }

            set
            {
                _choose = value;
            }
        }
       
    }
}
