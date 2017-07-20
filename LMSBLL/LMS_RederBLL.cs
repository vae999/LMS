using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LMS.DAL;
using LMS.Model;

namespace LMS.BLL
{
   public  class LMS_RederBLL
    {
        private LMS_RederDAL _dal = new LMS_RederDAL();
        /// <summary>
        /// 添加一个读者
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public bool AddReder(LMS_Reder reder)
        {
            return _dal.Insert(reder);
        }
        public LMS_Reder FindbyNumber(int number)
        {
            string sql = string.Format("select* from LMS_Reder where usernumber =  {0}", number);
            return _dal.Select(sql);
        }

        /// <summary>
        /// 返回全部读者
        /// </summary>
        /// <returns></returns>
        public List<LMS_Reder>SelectAll()
        {
            string sql = string.Format("select * from LMS_Reder ");
            return _dal.SelectList(sql);
        }
        /// <summary>
        /// 更新数据
        /// </summry>
        /// <param name="reder"></param>
        /// <returns></returns>
        public bool Update(LMS_Reder reder)
        {
            return _dal.Update(reder);
        }
        /// <summary>
        /// 删除读者
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public bool Delete(int uid)
        {
            return _dal.Del(uid);
        }

        public List<LMS_Reder> Select(string Field, string value)
        {
            string sql = "select * from LMS_reder where " + Field + " like '%" + value + "%'";
            return _dal.SelectList(sql);
        }







    }
}
