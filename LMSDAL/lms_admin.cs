/**  版本信息模板在安装目录下，可自行修改。
* lms_admin.cs
*
* 功 能： N/A
* 类 名： lms_admin
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/18 15:53:24   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
using LMS.Common;
namespace LMS.DAL
{
	/// <summary>
	/// 数据访问类:lms_admin
	/// </summary>
	public partial class lms_admin
	{
		public lms_admin()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DBMySQLHelper.GetMaxID("AdminNumber", "lms_admin"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AdminNumber)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from lms_admin");
			strSql.Append(" where AdminNumber=@AdminNumber ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AdminNumber", MySqlDbType.Int32,11)			};
			parameters[0].Value = AdminNumber;

			return DBMySQLHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LMS.Model.lms_admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into lms_admin(");
			strSql.Append("AdminUid,AdminPwd,AdminNumber,AdminName)");
			strSql.Append(" values (");
			strSql.Append("@AdminUid,@AdminPwd,@AdminNumber,@AdminName)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AdminUid", MySqlDbType.VarChar,16),
					new MySqlParameter("@AdminPwd", MySqlDbType.VarChar,16),
					new MySqlParameter("@AdminNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@AdminName", MySqlDbType.VarChar,16)};
			parameters[0].Value = model.AdminUid;
			parameters[1].Value = model.AdminPwd;
			parameters[2].Value = model.AdminNumber;
			parameters[3].Value = model.AdminName;

			int rows=DBMySQLHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LMS.Model.lms_admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update lms_admin set ");
			strSql.Append("AdminUid=@AdminUid,");
			strSql.Append("AdminPwd=@AdminPwd,");
			strSql.Append("AdminName=@AdminName");
			strSql.Append(" where AdminNumber=@AdminNumber ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AdminUid", MySqlDbType.VarChar,16),
					new MySqlParameter("@AdminPwd", MySqlDbType.VarChar,16),
					new MySqlParameter("@AdminName", MySqlDbType.VarChar,16),
					new MySqlParameter("@AdminNumber", MySqlDbType.Int32,11)};
			parameters[0].Value = model.AdminUid;
			parameters[1].Value = model.AdminPwd;
			parameters[2].Value = model.AdminName;
			parameters[3].Value = model.AdminNumber;

			int rows=DBMySQLHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int AdminNumber)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from lms_admin ");
			strSql.Append(" where AdminNumber=@AdminNumber ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AdminNumber", MySqlDbType.Int32,11)			};
			parameters[0].Value = AdminNumber;

			int rows=DBMySQLHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string AdminNumberlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from lms_admin ");
			strSql.Append(" where AdminNumber in ("+AdminNumberlist + ")  ");
			int rows=DBMySQLHelper.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LMS.Model.lms_admin GetModel(int AdminNumber)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AdminUid,AdminPwd,AdminNumber,AdminName from lms_admin ");
			strSql.Append(" where AdminNumber=@AdminNumber ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AdminNumber", MySqlDbType.Int32,11)			};
			parameters[0].Value = AdminNumber;

			LMS.Model.lms_admin model=new LMS.Model.lms_admin();
			DataSet ds=DBMySQLHelper.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LMS.Model.lms_admin DataRowToModel(DataRow row)
		{
			LMS.Model.lms_admin model=new LMS.Model.lms_admin();
			if (row != null)
			{
				if(row["AdminUid"]!=null)
				{
					model.AdminUid=row["AdminUid"].ToString();
				}
				if(row["AdminPwd"]!=null)
				{
					model.AdminPwd=row["AdminPwd"].ToString();
				}
				if(row["AdminNumber"]!=null && row["AdminNumber"].ToString()!="")
				{
					model.AdminNumber=int.Parse(row["AdminNumber"].ToString());
				}
				if(row["AdminName"]!=null)
				{
					model.AdminName=row["AdminName"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AdminUid,AdminPwd,AdminNumber,AdminName ");
			strSql.Append(" FROM lms_admin ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DBMySQLHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM lms_admin ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.AdminNumber desc");
			}
			strSql.Append(")AS Row, T.*  from lms_admin T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DBMySQLHelper.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "lms_admin";
			parameters[1].Value = "AdminNumber";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DBMySQLHelper.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

