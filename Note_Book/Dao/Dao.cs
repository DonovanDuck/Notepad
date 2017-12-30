using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Text_model;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Data;
using Common;
using Method_impl;

namespace Text_Dao
{
    public class Dao
    {
        private Connection conn;

        /// <summary>
        /// 查找所有笔记分类
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public List<string> searchTextkinds(string username)
        {
            List<string> kinds = new List<string>();
            conn = new Connection();
            //建立连接
            MySqlConnection connection = Connection.sqlConn();
            string sql = "select distinct parentFolder from text where user = " + username;
            MySqlCommand scd = new MySqlCommand(sql, connection);
            MySqlDataReader result = scd.ExecuteReader();
            while (result.Read())
            {
                kinds.Add((string)result[4]);
            }
            connection.Close();
            
            return kinds;
        }

        /// <summary>
        /// 查找某分类所有笔记
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="veriaty">分类</param>
        /// <returns></returns>
        public List<Text> searchTextBykind(string username, string veriaty)
        {
            List<Text> TextList = new List<Text>();
            conn = new Connection();
            //建立连接
            MySqlConnection connection = Connection.sqlConn();
            string sql = "select * from text where user = " + username + " and parentFolder=" + veriaty;
            MySqlCommand scd = new MySqlCommand(sql, connection);
            MySqlDataReader result = scd.ExecuteReader();
            while (result.Read())
            {
                Text text = new Text();
                text.Name = (string)result[0];
                text.Content = (string)result[1];
                text.Saveroute = (string)result[2];
                text.User = (string)result[3];
                text.ParentFolder = (string)result[4];
                TextList.Add(text);
            }
            connection.Close();
            return TextList;
        }

        public void saveText(TextDbHandlerImp.TextEvent e) {
            conn = new Connection();
            //建立连接
            MySqlConnection connection = Connection.sqlConn();
            string sql = "insert into text values ('" + e.text.Name + "','" + e.text.Content + "','" + e.text.User + "','" + e.text.ParentFolder + "')";
            MySqlCommand scd = new MySqlCommand(sql, connection);
            scd.ExecuteNonQuery();
            connection.Close();
        }

        public Text openText(string textname,string username) {
            conn = new Connection();
            //建立连接
            MySqlConnection connection = Connection.sqlConn();
            string sql = "select * from text where name='" + textname + "' and user='" + username + "'";
            MySqlCommand scd = new MySqlCommand(sql, connection);
            MySqlDataReader result = scd.ExecuteReader();
            Text text = new Text();
            while (result.Read())
            {

                text.Name = (string)result[0];
                text.Content= (string)result[1];
                text.User = (string)result[2];
                text.ParentFolder = (string)result[3];

            }
            connection.Close();
            return text;
        }

        public   void signUp(TextDbHandlerImp.TextEvent e) {
            conn = new Connection();
            //建立连接
            MySqlConnection connection = Connection.sqlConn();
            string sql = "insert into user values ('"+e.user.Username+"','"+e.user.Password+"','"+e.user.Sex+"','"+e.user.Email+"')";
            MySqlCommand scd = new MySqlCommand(sql, connection);
            scd.ExecuteNonQuery();
            connection.Close();
        }

        public User signIn(string username,string password) {
            conn = new Connection();
            //建立连接
            MySqlConnection connection = Connection.sqlConn();
            string sql = "select * from user where username='"+username+"' and password='"+password+"'";
            MySqlCommand scd = new MySqlCommand(sql, connection);
            MySqlDataReader result =  scd.ExecuteReader();
            User user = new User();
            while (result.Read())
            {
                
                user.Username = (string)result[0];
                user.Sex = (string)result[2];
                user.Email = (string)result[3];
          
            }
            connection.Close();
            return user;
        }
    }

    
}
