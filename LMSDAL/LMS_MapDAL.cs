using System.Collections.Generic;
using System.Linq;
using System.Data;
using LMS.Model;
using LMS.Common;
namespace LMS.DAL

{
    public class LMS_MapDAL
    {
        public LMS_Map Select(string sql)
        {
            LMS_Map LMS_Map = new LMS_Map();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            //如果有数据 将DataTable载入到LMS_Map对象
            if (data.Rows.Count > 0)
            {
                var row = data.Rows[0];
                LMS_Map.Booknumber = (int)row["Booknumber"];
                LMS_Map.Usernumber = (int)row["Usernumber"];
                LMS_Map.Borrowingdate = row["Borrowingdate"].ToString();
                LMS_Map.Returndate = row["Returndate"].ToString();
                LMS_Map.Flage = (int)row["Flage"];
                LMS_Map.Number = (int)row["Number"];

            }
            //返回书籍信息
            return LMS_Map;
        } 

        public List<LMS_Map> SelectList(string sql)
        {
            List<LMS_Map> list = new List<LMS_Map>();
            //从数据库获取信息
            DataTable data = DBHeper.Select(sql);
            foreach (DataRow row in data.Rows)
            {
                //利用将当前行数据 新建用户对象 
                LMS_Map LMS_Map = new LMS_Map();
                LMS_Map.Booknumber = (int)row["Booknumber"];
                LMS_Map.Usernumber = (int)row["Usernumber"];
                LMS_Map.Borrowingdate = row["Borrowingdate"].ToString();
                LMS_Map.Returndate = row["Returndate"].ToString();
                LMS_Map.Flage= (int)row["Flage"];
                LMS_Map.Number = (int)row["Number"];
                //将用户对象 存入列表
                list.Add(LMS_Map);
            }
            //返回列表
            return list;
        }

        public bool Insert(LMS_Map map)
        {
            //拼接SQL
            string sql = string.Format(@"Insert into LMS_Map
                                           ( Booknumber,Usernumber,Borrowingdate,Returndate,flage) 
                                     values({0},{1},'{2}','{3}',1
                                            )",
                                           map.Booknumber,map.Usernumber,map.Borrowingdate,map.Returndate );
            //连接数据库 执行SQL
            return DBHeper.SQL(sql);
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool Update(LMS_Map map)
        {
            //  update LMS_Map set Bookstatu = 1 where Bookname = '在人间';
            string sql = string.Format(@"update LMS_Map set flage={0} where number={1} ", map.Flage,map.Number);
            return DBHeper.SQL(sql);
        }


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="uid"> 账户id</param>
        /// <returns> </returns>
        public bool Del(int uid)
        {
            string sql = string.Format(@"Delete from LMS_Map where number = {0}", uid);
            return DBHeper.SQL(sql);
        }
    }
}
