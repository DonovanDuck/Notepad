using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_model;

namespace Model_Interface
{
   public interface TextHandle
    {
        /// <summary>
        /// 打开文件
        /// </summary>
        Text OpenFile();
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="fileText">包含路径的文件名</param>
        void SaveFile(Text text);
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="text">笔记本对象</param>
       void write(Text text);
        /// <summary>
        /// 目录
        /// </summary>
        void showMenu();
        
        
    }
}
