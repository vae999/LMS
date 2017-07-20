using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LMS.DAL;
using LMS.Model;

namespace LMS.BLL

{
    public class LMS_BookBLL
    {
        private LMS_BookDAL _dal = new LMS_BookDAL();
        /// <summary>
        /// 获取指定类型的书籍
        /// </summary>
        /// <param name="Category"></param>
        /// <returns></returns>
        public List<LMS_Book> getCategoryByBook(int Category)
        {
            string sql = string.Format("select* from LMS_Book where bookcategoryid =  '{0}' ",Category);
            return _dal.SelectList(sql);
        }
        /// <summary>
        /// 按编号查找书籍
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LMS_Book findBook(int id)
        {
            string sql = string.Format("select* from LMS_Book where booknumber =  {0}", id);
            return _dal.Select(sql);
        }
        /// <scummary>
        /// 添加书籍
        /// </summary>
        /// <param name="book"></param>
        public bool AddBook(LMS_Book book)
        {
            //string sql = string.Format();
            return _dal.Insert(book);
        }
        /// <summary>
        /// 更新书籍信息
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool Update(LMS_Book book)
        {
           return _dal.Update(book);
        }
        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public bool Delete(int uid)
        {
            return _dal.Del(uid);
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="Field"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<LMS_Book> Select(string Field, string value)
        {
            string sql = "select * from LMS_Book where " + Field + " like '%" + value + "%'";
            return _dal.SelectList(sql);
        }

        public List<LMS_Book> SelectAll()
        {
            string sql = "select * from LMS_Book";
            return _dal.SelectList(sql);
        }
    }
}
