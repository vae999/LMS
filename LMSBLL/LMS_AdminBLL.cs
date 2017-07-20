using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LMS.DAL;
using LMS.Model;

namespace LMS.BLL

{
    public class LMS_AdminBLL
    {
        private LMS_AdminDAL _dal = new LMS_AdminDAL();
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="code"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public LMS_Admin Login(string code, string pwd)
        {
            //拼接SQL

            string sql = string.Format("select* from LMS_Admin where AdminUid =  '{0}' and AdminPwd = '{1}'", code, pwd);
            //执行SQL 从数据库获取信息
            LMS_Admin admin = _dal.Select(sql);
            //返回用户信息
            return admin;
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="UID"></param>
        /// <returns></returns>
        public bool Resist(string name, string pwd,string UID)
        {
            //拼接SQL
            string sql = string.Format("select* from LMS_Admin where AdminUid =  '{0}'", UID);
            LMS_Admin admin = _dal.Select(sql);
            //判断用户是否存在
            if (admin.Adminnumber > 0)
            {
                return false;
            }else
            {
                admin.Adminname = name;
                admin.Adminpwd = pwd;
                admin.Adminuid = UID;
                _dal.Insert(admin);
                return true;
            }
        }
      
          
        public LMS_Admin FindPwd(string name, string uid)
        {

            string sql = string.Format("select* from LMS_Admin where AdminUid =  '{0}' and adminname ='{1}'", uid,name);
            LMS_Admin admin = _dal.Select(sql);
            //判断用户是否存在
            return admin;

        }
    }
}
