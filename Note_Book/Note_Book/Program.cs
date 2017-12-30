
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_model;
using Method_impl;
using Model_Interface;
using System.IO;
using System.Windows.Forms;


namespace Note_Book
{
    class Program
    {
        private static Text text;
        private static TextHandle th;
        private static TextDbHandlerImp thdb; 
        private static User user;
        private static Text_Dao.Dao dao;


        static void Main(string[] args)
        {
            
            Console.WriteLine("请选择版本：1.0 / 1.1");
            string c = Console.ReadLine();
            if ("1.0".Equals(c))
            {
                user = new User();
                th = new TextImpl();
            }
            else {
                dao = new Text_Dao.Dao();
                th = new TextDbHandlerImp();
                thdb = new TextDbHandlerImp();
            }
            
            while (true)
            {
                th.showMenu();
                string s = Console.ReadLine();

                switch (s)
                {
                    case "1":
                        {
                            text = new Text();
                            th.write(text);
                            if (user == null)
                            {
                                Console.WriteLine("请先登录");
                            }
                            else
                            {
                                if (dao!=null) {
                                    text.User = user.Username;
                                    TextDbHandlerImp.insertEvent += dao.saveText;
                                }
                                th.SaveFile(text);
                            }
                            break;
                        }
                    case "2":
                        {
                            text = new Text();
                            if (user!=null) {
                                if (dao != null)
                                {
                                    TextDbHandlerImp.searchtextEvent += dao.openText;
                                    text = thdb.OpenFile(user.Username);
                                }
                                else {
                                    text = th.OpenFile();
                                }
                                Console.WriteLine("笔记内容：\n" + text.Content);
                            }
                            else {
                                Console.WriteLine("请先登录");
                            }
                            break;
                        }
                    case "3":
                        {
                            if (user != null) {
                                if (text.Content == null || "".Equals(text.Content)) {
                                    Console.WriteLine("请先新建笔记");
                                }
                                else {
                                    TextDbHandlerImp.insertEvent += dao.saveText;
                                    th.SaveFile(text);
                                }    
                            }
                            else {
                                Console.WriteLine("请先登录");
                            }
                            
                            break;
                        }
                    case "4": {
                            TextDbHandlerImp.searchuserEvent += dao.signIn;
                            user =  thdb.signIn();
                            if (user != null)
                            {
                                Console.WriteLine("欢迎：" + user.Username + "，请继续操作");
                                if (text != null)
                                {
                                    text.User = user.Username;
                                }
                            }
                            else
                            {
                                Console.WriteLine("用户名或密码错误");
                                
                            }

                            break;
                        }
                    case "5":
                        {
                            TextDbHandlerImp.insertEvent += dao.signUp;
                            thdb.signUp();
                            break;
                        }
                    case "0":
                        {
                            return;
                        }
                }
            }


        }
    }
}
