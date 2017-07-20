using System.Collections.Generic;
using System.Linq;
using System.Data;
using LMS.Model;
using LMS.Common;

namespace LMS.DAL
{
    public class LMS_BookDAL
    {
        public LMS_Book Select(string sql)
        {
            LMS_Book LMS_Book = new LMS_Book();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            //如果有数据 将DataTable载入到LMS_Book对象
            if (data.Rows.Count > 0)
            {
                var row = data.Rows[0];
                LMS_Book.Bookauthor = row["Bookauthor"].ToString();
                LMS_Book.Bookcategoryid = (int)row["Bookcategoryid"];
                LMS_Book.Bookisbn = row["Bookisbn"].ToString();
                LMS_Book.Bookname = row["Bookname"].ToString();
                LMS_Book.Booknumber = (int)row["Booknumber"];
                LMS_Book.Bookpress = row["Bookpress"].ToString();
                LMS_Book.Bookquantity = (int)row["Bookquantity"];
            }
            //返回书籍信息
            return LMS_Book;
        }

        public List<LMS_Book> SelectList(string sql)
        {
            List<LMS_Book> list = new List<LMS_Book>();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            foreach (DataRow row in data.Rows)
            {
                //利用将当前行数据 新建用户对象 
                LMS_Book LMS_Book = new LMS_Book();
                LMS_Book.Bookauthor = row["Bookauthor"].ToString();
                LMS_Book.Bookcategoryid = (int)row["Bookcategoryid"];
                LMS_Book.Bookisbn = row["Bookisbn"].ToString();
                LMS_Book.Bookname = row["Bookname"].ToString();
                LMS_Book.Booknumber = (int)row["Booknumber"];
                LMS_Book.Bookpress = row["Bookpress"].ToString();
                LMS_Book.Bookquantity = (int)row["Bookquantity"];
                //将用户对象 存入列表
                list.Add(LMS_Book);
            }
            //返回列表
            return list;
        }

        public bool Insert(LMS_Book book)
        {
            //拼接SQL
            string sql = string.Format(@"Insert into LMS_Book
                                           ( 
                                            Bookauthor, 
                                            Bookcategoryid,
                                            Bookisbn,
                                            Bookname,
                                            Bookpress,
                                            Bookquantity
                                            ) 
                                     values('{0}',{1}, '{2}','{3}','{4}','{5}')",
                                           book.Bookauthor,book.Bookcategoryid,book.Bookisbn,book.Bookname,book.Bookpress,book.Bookquantity
                                           );
            //连接数据库 执行SQL
            return DBHeper.SQL(sql);
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool Update(LMS_Book book)
        {
            //  update LMS_Book set Bookstatu = 1 where Bookname = '在人间';
            string sql = string.Format(@"update LMS_Book set Bookauthor='{0}',Bookcategoryid={1},Bookisbn='{2}',Bookname='{3}',Bookpress='{4}',Bookquantity={5} where Booknumber={6} ", 
                book.Bookauthor,book.Bookcategoryid,book.Bookisbn,book.Bookname,book.Bookpress,book.Bookquantity,book.Booknumber);
            return DBHeper.SQL(sql);
        }
        /// <summary>
        /// 更新状态,解决int值不能为null
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        //public bool UpdateEx(LMS_Book book)
        //{
        //    //  update LMS_Book set Bookstatu = 1 where Bookname = '在人间';
        //    string sql = string.Format(@"update LMS_Book set Bookstatu={0},UID=null where Bookname='{1}' ", book.Bookstatu, book.Bookname);
        //    return DBHeper.SQL(sql);
        //}


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="uid"> 账户id</param>
        /// <returns> </returns>
        public bool Del(int uid)
        {
            string sql = string.Format(@"Delete from LMS_Book where Booknumber = '{0}'", uid);
            return DBHeper.SQL(sql);
        }
    }
}
