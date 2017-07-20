using System.Collections.Generic;
using System.Linq;
using System.Data;
using LMS.Model;
using LMS.Common;

namespace LMS.DAL
{
    public  class LMS_AdminDAL
    {
        public LMS_Admin Select(string sql)
        {
            LMS_Admin LMS_Admin = new LMS_Admin();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            //如果有数据 将DataTable载入到LMS_Admin对象
            if (data.Rows.Count > 0)
            {
                var row = data.Rows[0];
                LMS_Admin.Adminname = row["Adminname"].ToString();
                LMS_Admin.Adminnumber = (int)row["Adminnumber"];
                LMS_Admin.Adminuid = row["Adminuid"].ToString();
                LMS_Admin.Adminpwd = row["Adminpwd"].ToString();
            }
            //返回书籍信息
            return LMS_Admin;
        }

        public List<LMS_Admin> SelectList(string sql)
        {
            List<LMS_Admin> list = new List<LMS_Admin>();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            foreach (DataRow row in data.Rows)
            {
                //利用将当前行数据 新建用户对象 
                LMS_Admin LMS_Admin = new LMS_Admin();
                LMS_Admin.Adminname = row["Adminname"].ToString();
                LMS_Admin.Adminnumber = (int)row["Adminnumber"];
                LMS_Admin.Adminuid = row["Adminuid"].ToString();
                LMS_Admin.Adminpwd = row["Adminpwd"].ToString();
                //将用户对象 存入列表
                list.Add(LMS_Admin);
            }
            //返回列表
            return list;
        }

        public bool Insert(LMS_Admin admin)
        {
            //拼接SQL
            string sql = string.Format(@"Insert into LMS_Admin
                                           ( 
                                            Adminname, 
                                            Adminuid, 
                                            Adminpwd
                                            ) 
                                     values('{0}',
                                            '{1}',
                                            '{2}')",
                                            admin.Adminname,
                                            admin.Adminuid,
                                            admin.Adminpwd
                                           );
            //连接数据库 执行SQL
            return DBHeper.SQL(sql);
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool Update(LMS_Admin admin)
        {
            //  update LMS_Admin set Bookstatu = 1 where Bookname = '在人间';
            string sql = string.Format(@"update LMS_Admin set Adminname='{0}',Adminuid='{1}',Adminpwd='{2}' where Adminnumber={3} ", admin.Adminname,admin.Adminuid, admin.Adminpwd,admin.Adminnumber);
            return DBHeper.SQL(sql);
        }
        /// <summary>
        /// 更新状态,解决int值不能为null
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        //public bool UpdateEx(LMS_Admin book)
        //{
        //    //  update LMS_Admin set Bookstatu = 1 where Bookname = '在人间';
        //    string sql = string.Format(@"update LMS_Admin set Bookstatu={0},UID=null where Bookname='{1}' ", book.Bookstatu, book.Bookname);
        //    return DBHeper.SQL(sql);
        //}


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="uid"> 账户id</param>
        /// <returns> </returns>
        public bool Del(int uid)
        {
            string sql = string.Format(@"Delete from LMS_Admin where Adminnumber = '{0}'", uid);
            return DBHeper.SQL(sql);
        }

    }
}
