using System.Collections.Generic;
using System.Linq;
using System.Data;
using LMS.Model;
using LMS.Common;

namespace LMS.DAL

{
    public class LMS_RederDAL
    {
        public LMS_Reder Select(string sql)
        {
            LMS_Reder LMS_Reder = new LMS_Reder();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            //如果有数据 将DataTable载入到LMS_Reder对象
            if (data.Rows.Count > 0)
            {
                var row = data.Rows[0];
                LMS_Reder.Userclass = row["Userclass"].ToString();
                LMS_Reder.Useridcard = row["Useridcard"].ToString();
                LMS_Reder.Username = row["Username"].ToString();
                LMS_Reder.Usernumber = (int)row["Usernumber"];
                LMS_Reder.Usersex = row["Usersex"].ToString();
                LMS_Reder.Usertell = row["Usertell"].ToString();

            }
            //返回书籍信息
            return LMS_Reder;
        }

        public List<LMS_Reder> SelectList(string sql)
        {
            List<LMS_Reder> list = new List<LMS_Reder>();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            foreach (DataRow row in data.Rows)
            {
                //利用将当前行数据 新建用户对象 
                LMS_Reder LMS_Reder = new LMS_Reder();
                LMS_Reder.Userclass = row["UserClass"].ToString();
                LMS_Reder.Useridcard = row["Useridcard"].ToString();
                LMS_Reder.Username = row["Username"].ToString();
                LMS_Reder.Usernumber = (int)row["Usernumber"];
                LMS_Reder.Usersex = row["Usersex"].ToString();
                LMS_Reder.Usertell = row["Usertell"].ToString();
                //将用户对象 存入列表
                list.Add(LMS_Reder);
            }
            //返回列表
            return list;
        }

        public bool Insert(LMS_Reder reder)
        {
            //拼接SQL
            string sql = string.Format(@"Insert into LMS_Reder( Userclass, Useridcard, Username,Usersex,Usertell) values('{0}',
                                            '{1}',
                                            '{2}','{3}','{4}')",
                                            reder.Userclass,reder.Useridcard,reder.Username,reder.Usersex,reder.Usertell);
            //连接数据库 执行SQL
            return DBHeper.SQL(sql);
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool Update(LMS_Reder reder)
        {
            //  update LMS_Reder set Bookstatu = 1 where Bookname = '在人间';
            string sql = string.Format(@"update LMS_Reder set  Userclass='{0}', Useridcard='{1}', Username='{2}',Usersex='{3}',Usertell ='{4}'where Usernumber={5} ",reder.Userclass,reder.Useridcard,reder.Username,reder.Usersex,reder.Usertell,reder.Usernumber );
            return DBHeper.SQL(sql);
        }
  


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="uid"> 账户id</param>
        /// <returns> </returns>
        public bool Del(int uid)
        {
            string sql = string.Format(@"Delete from LMS_Reder where Usernumber = '{0}'", uid);
            return DBHeper.SQL(sql);
        }

    }
}
