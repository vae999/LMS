using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LMS.DAL;
using LMS.Model;
namespace LMS.BLL
{
    public class LMS_MapBLL
    {
        private LMS_MapDAL _dal = new LMS_MapDAL();
        /// <summary>
        /// 借阅书籍
        /// </summary>
        /// <param name="map"></param>
        /// <returns></returns>
        public bool Borrow(LMS_Map map)
        {
            return _dal.Insert(map);
        }
        /// <summary>
        /// 按照读者编号查找记录
        /// </summary>
        /// <param name="userNumber"></param>
        /// <returns></returns>
        public List<LMS_Map> SelectBook(int userNumber)
        {
            string sql = string.Format("select* from LMS_map where usernumber =  {0}", userNumber);
            return _dal.SelectList(sql);
        }
        /// <summary>
        /// 按图书编号查找记录
        /// </summary>
        /// <param name="bookNumber"></param>
        /// <returns></returns>
        public List<LMS_Map>SelectReder(int bookNumber)
        {
            string sql = string.Format("select* from LMS_map where booknumber =  {0}", bookNumber);
            return _dal.SelectList(sql);
        }

        /// <summary>
        /// 归还书籍
        /// </summary>
        /// <param name="map"></param>
        /// <returns></returns>
        public bool returnBook(LMS_Map map)
        {
            return _dal.Update(map);
           // string sql = string.Format("select* from LMS_map where usernumber =  {0}", userNumber);
        }

    }
}
