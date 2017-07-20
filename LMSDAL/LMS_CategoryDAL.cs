using System.Collections.Generic;
using System.Linq;
using System.Data;
using LMS.Model;
using LMS.Common;

namespace LMS.DAL
{
    public class LMS_CategoryDAL
    {
        public LMS_Category Select(string sql)
        {
            LMS_Category LMS_Category = new LMS_Category();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            //如果有数据 将DataTable载入到LMS_Category对象
            if (data.Rows.Count > 0)
            {
                var row = data.Rows[0];
                LMS_Category.Category = row["Category"].ToString();
                LMS_Category.Categoryid = (int)row["Categoryid"];

            }
            //返回书籍信息
            return LMS_Category;
        }

        public List<LMS_Category> SelectList(string sql)
        {
            List<LMS_Category> list = new List<LMS_Category>();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            foreach (DataRow row in data.Rows)
            {
                //利用将当前行数据 新建用户对象 
                LMS_Category LMS_Category = new LMS_Category();
                LMS_Category.Category = row["Category"].ToString();
                LMS_Category.Categoryid = (int)row["Categoryid"];
                //将用户对象 存入列表
                list.Add(LMS_Category);
            }
            //返回列表
            return list;
        }

        public bool Insert(LMS_Category Category)
        {
            //拼接SQL
            string sql = string.Format(@"Insert into LMS_Category
                                           ( 
                                            Category
                                            ) 
                                     values('{0}'
                                            )",
                                            Category.Category
                                           );
            //连接数据库 执行SQL
            return DBHeper.SQL(sql);
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool Update(LMS_Category Category)
        {
            //  update LMS_Category set Bookstatu = 1 where Bookname = '在人间';
            string sql = string.Format(@"update LMS_Category set Category='{0}' where Categoryid={1} ", Category.Category, Category.Categoryid);
            return DBHeper.SQL(sql);
        }
        /// <summary>
        /// 更新状态,解决int值不能为null
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        //public bool UpdateEx(LMS_Category book)
        //{
        //    //  update LMS_Category set Bookstatu = 1 where Bookname = '在人间';
        //    string sql = string.Format(@"update LMS_Category set Bookstatu={0},UID=null where Bookname='{1}' ", book.Bookstatu, book.Bookname);
        //    return DBHeper.SQL(sql);
        //}


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="uid"> 账户id</param>
        /// <returns> </returns>
        public bool Del(int uid)
        {
            string sql = string.Format(@"Delete from LMS_Category where Adminnumber = '{0}'", uid);
            return DBHeper.SQL(sql);
        }
    }
}
