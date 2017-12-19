using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Text_model;
using Model_Interface;

namespace Method_impl
{
   public class TextImpl : TextHandle
    {

        public  void showMenu()
        {
            Console.WriteLine("请输入操纵：\n1.新建  2.打开笔记 3.退出");
        }

        public Text OpenFile(string currentFileName)
        {

            Text text = new Text();
            try
            {
                FileInfo fileInfo = new FileInfo(currentFileName);//用此函数时付给currentFileName为要打开的文件明，用GetOpenFile()
                StreamReader reader = fileInfo.OpenText();
                text.Saveroute = currentFileName;
                text.Content = reader.ReadToEnd();
                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return text;
        }

        public void SaveFile(string fileText, string currentFileName)
        {
           
            try
            {

                StreamWriter writer = new StreamWriter(currentFileName);//此处的currentFileName为要保存到的路径文件名
                writer.Write(fileText);
                Console.WriteLine("保存成功");
                writer.Close();


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
            Console.WriteLine("是否保存笔记（Y or N）:");
            String yn = Console.ReadLine();
            //保存笔记
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
                    Console.WriteLine("请填写保存路径：");
                    text.Saveroute = Console.ReadLine() + "/" + text.ParentFolder;
                }
                else
                {
                    //否，默认保存桌面mytext文件夹
                    text.ParentFolder = "myText";
                    text.Saveroute = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/" + text.ParentFolder;
                }

                //判断文件夹是否存在
                if (!Directory.Exists(text.Saveroute))
                {
                    Directory.CreateDirectory(text.Saveroute);
                }
               
                
            }
        }
    }

}
