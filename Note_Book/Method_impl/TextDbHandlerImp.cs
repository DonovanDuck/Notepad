using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_Interface;
using Text_model;

namespace Method_impl
{
   
    public class TextDbHandlerImp : TextDbHandler
    {
        //查询事件
        public delegate User Search(string str1,string str2);
        public static event Search searchuserEvent;

        public delegate Text SearchT(string str1, string str2);
        public static event SearchT searchtextEvent;
        //添加事件
        public delegate void Insert(TextEvent e);
        public static event Insert insertEvent;
        public Text OpenFile(string username)
        {
            Text text;
            Console.WriteLine("请输入打开文件名：");
            string name = Console.ReadLine() + ".txt";
            try {
                text = searchtextEvent(name, username);
                return text;
            }
            catch (Exception msg) {
                Console.WriteLine("文件打开失败");
                return null; 
            }
            
        }

        public void SaveFile(Text text)
        {
            try
            {
                Console.WriteLine("是否保存笔记（Y or N）:");
                String yn = Console.ReadLine();
                //是否保存笔记
                if (yn.Equals("Y"))
                {
                    Console.WriteLine("请填写文件名：");
                    text.Name = Console.ReadLine() + ".txt";
                    //创建分类
                    Console.WriteLine("是否创建分类（Y or N）:");
                    yn = Console.ReadLine();
                    if (yn.Equals("Y"))
                    {
                        Console.WriteLine("请填写分类名");
                        text.ParentFolder = Console.ReadLine();
                    }
                    else
                    {
                        //否，默认保存mytext类型
                        text.ParentFolder = "myText";
                    }
                    TextEvent e = new TextEvent(null, text);
                        insertEvent(e);
                        Console.WriteLine("保存成功");
                    }
            }
            catch (Exception msg)
            {
                Console.WriteLine("保存失败");
            }
        }

        public void showMenu()
        {
            Console.WriteLine("********************");
            Console.WriteLine("**   1.新建笔记    **");
            Console.WriteLine("**   2.打开笔记    **");
            Console.WriteLine("**   3.保存笔记    **");
            Console.WriteLine("**   4.登  录      **");
            Console.WriteLine("**   5.注  册      **");
            Console.WriteLine("**   0.退  出      **");
            Console.WriteLine("********************");
        }

        public User signIn()
        {
            try {
                string username;
                string password;
                Console.WriteLine("请输入用户名：");
                username = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                password = Console.ReadLine();
                User user = searchuserEvent(username, password);
                if (user != null)
                {
                    return user;
                }
                return null;
            }
            catch (Exception e) {
                Console.WriteLine("用户名或密码错误");
                return null;
            }

        }

        public void signUp()
        {
            User user = new User();
            Console.WriteLine("请填写姓名：");
            user.Username = Console.ReadLine();
            Console.WriteLine("请设置密码：");
            user.Password = Console.ReadLine();
            Console.WriteLine("请填写性别：");
            user.Sex = Console.ReadLine();
            Console.WriteLine("请填写邮箱：");
            user.Email = Console.ReadLine();
            TextEvent e = new TextEvent(user,null);
            try {
                insertEvent(e);
                Console.WriteLine("注册成功");
            }
            catch (Exception msg) {
                Console.WriteLine("注册失败，请稍后重试"); 
            }
            
        }

        public void write(Text text)
        {
            String end = "";
            string content = "";
            Console.WriteLine("请编写内容：\n");
            while (!end.Equals("#"))
            {
                content = content + Console.ReadLine();
                end = content.Substring(content.Length - 1, 1);
            }
            text.Content = content.Substring(0, content.Length - 1);
        }

        public Text OpenFile()
        {
            throw new NotImplementedException();
        }

        public class TextEvent : EventArgs
        {
            public User user;
            public Text text;

            public TextEvent(User user, Text text)
            {
                this.user = user;
                this.text = text;
            }
        }
    }
    
}
