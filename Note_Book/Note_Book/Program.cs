
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
using Controller;
using Note_Book;

namespace Note_Book
{
    class Program
    {
        private static Text text;
        private static TextHandle th;
        private static TextDbHandlerImp thdb; 
        private static User user;
        private static Text_Dao.Dao dao;
        public delegate void MenuEvents( FunctionEvent e);
        public static event MenuEvents menuevnts;
        public static Controller.Controller con;
       static public  void menu(Text text, TextHandle th, TextDbHandlerImp thdb, User user, Text_Dao.Dao dao, FunctionEvent e) {
            
            th.showMenu();
            string s = Console.ReadLine();
            e.Choose = s;
            onFunction(menuevnts, e);
        }

       protected static void onFunction(MenuEvents menuevnts, FunctionEvent e) {
            menuevnts?.Invoke(e);
        }

       static void Main(string[] args)
        {
            Console.WriteLine("请选择版本：1.0 / 1.1");
            string c = Console.ReadLine();
            if ("1.0".Equals(c))
            {
                user = new User();
                th = new TextImpl();
            }
            else
            {
                dao = new Text_Dao.Dao();
                th = new TextDbHandlerImp();
                thdb = new TextDbHandlerImp();
            }
            con = new Controller.Controller();
            FunctionEvent e = new FunctionEvent(text, th, thdb, user, dao);
            menuevnts += con.newText;
            menuevnts += con.opentext;
            menuevnts += con.saveText;
            menuevnts += con.login;
            menuevnts += con.register;
            menuevnts += con.exit;
            while (true)
            {
                menu(text, th, thdb, user, dao,e);
            }
        }
    }
}
