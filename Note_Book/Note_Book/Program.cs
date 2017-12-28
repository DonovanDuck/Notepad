
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_model;
using Method_impl;
using Model_Interface;
using System.IO;

namespace Note_Book
{
    class Program
    {
        private static Text text;
        private static TextHandle th;

        
        static void Main(string[] args)
        {
            
            th = new TextImpl();
            while (true) {
                th.showMenu();
                string s = Console.ReadLine();
                
                switch (s)
                {
                    case "1":
                        {
                            text = new Text();
                            th.write(text);
                            th.SaveFile(text.Content, text.Saveroute + "/" + text.Name);
                            break;
                        }
                    case "2": {
                            text = new Text();
                            Console.WriteLine("请输入打开文件分类：");
                            String op = Console.ReadLine();
                            Console.WriteLine("请输入打开文件名：");
                            op +="/" +Console.ReadLine()+".txt";
                            text = th.OpenFile(op);

                            Console.WriteLine("笔记内容：\n"+text.Content);
                            break;
                        }
                    case "3": {
                            
                            break;
                        }
                }
            }
            
        }
    }
}
