using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LMS.DAL;
using LMS.Model;

namespace LMS.BLL

{
    public class LMS_CategoryBLL
    {
        private LMS_CategoryDAL _dal = new LMS_CategoryDAL();
        //private List<LMS_Category> CategoryAll;
        public List<LMS_Category> SelectAll()
        {
            string sql = string.Format("select* from LMS_Category ");
            List<LMS_Category> CategoryAll = _dal.SelectList(sql);
            return CategoryAll;
        } 
        /// <summary>
        /// 获取书籍类型对应的ID
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public LMS_Category getId(string text)
        {
            string sql = string.Format("select* from LMS_Category where Category='{0}'", text);
            return _dal.Select(sql);
        }

        public LMS_Category getType(int id)
        {
            string sql = string.Format("select* from LMS_Category where Categoryid={0}", id);
            return _dal.Select(sql);
        }
        
    }
}
