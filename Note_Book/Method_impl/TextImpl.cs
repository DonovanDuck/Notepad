using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Text_model;
using Model_Interface;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Data;
using Common;

namespace Method_impl
{
   public class TextImpl : TextHandle
    {
        private string getsavePath() {
            string savefodler = System.Configuration.ConfigurationSettings.AppSettings["MySavePathStringModel"];
            return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+"\\TEXT";
        }
        public  void showMenu()
        {
            Console.WriteLine("请输入操纵：\n1.新建  2.打开笔记 0.退出");
        }

        public Text OpenFile()
        {

            Text text = new Text();
            try
            {
                Console.WriteLine("请输入打开文件分类：");
                String op = Console.ReadLine();
                Console.WriteLine("请输入打开文件名：");
                string name = Console.ReadLine() + ".txt";
                FileInfo fileInfo = new FileInfo(getsavePath()+"\\"+ op + "\\"+ name);//用此函数时付给currentFileName为要打开的文件明，用GetOpenFile()
                StreamReader reader = fileInfo.OpenText();
                text.Saveroute = op;
                text.Content = reader.ReadToEnd();
                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return text;
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
                        text.Saveroute = getsavePath() + "\\" + text.ParentFolder;
                    }
                    else
                    {
                        //否，默认保存桌面mytext文件夹
                        text.ParentFolder = "myText";
                        text.Saveroute = getsavePath() + "\\" + text.ParentFolder;
                    }

                    //判断文件夹是否存在
                    if (!Directory.Exists(text.Saveroute))
                    {
                        Directory.CreateDirectory(text.Saveroute);
                    }

                    //保存
                    StreamWriter writer = new StreamWriter(text.Saveroute + "\\" + text.Name);//此处的currentFileName为要保存到的路径文件名
                    writer.Write(text.Content);
                    Console.WriteLine("成功保存到：" + text.Saveroute);
                    writer.Close();
                }
               


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void write(Text text) {
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
        
        
    }

}
