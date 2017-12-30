using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_model;


namespace Model_Interface
{
   public interface TextDbHandler : TextHandle
    {
        /// <summary>
        /// 注册
        /// </summary>
        void signUp();
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        User signIn();

        Text OpenFile(string username);
    }
}
