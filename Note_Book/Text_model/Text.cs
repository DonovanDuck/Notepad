using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_model
{
  public class Text
    {
        private string _name;//笔记名
        private string _content; //内容
        private string _saveroute; // 保存路径
        private string _parentFolder; //所属分类文件夹
        public Text() { }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
            }
        }

        public string Saveroute
        {
            get
            {
                return _saveroute;
            }

            set
            {
                _saveroute = value;
            }
        }

        public string ParentFolder
        {
            get
            {
                return _parentFolder;
            }

            set
            {
                _parentFolder = value;
            }
        }

        public Text(string _name, string _content, string _saveroute, string _parentFolder)
        {
            this.Name = _name;
            this.Content = _content;
            this.Saveroute = _saveroute;
            this.ParentFolder = _parentFolder;
        }
    
}
}
