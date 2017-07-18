/**  版本信息模板在安装目录下，可自行修改。
* lms_category.cs
*
* 功 能： N/A
* 类 名： lms_category
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/18 15:53:25   N/A    初版
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
	/// 数据访问类:lms_category
	/// </summary>
	public partial class lms_category
	{
		public lms_category()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DBMySQLHelper.GetMaxID("CategoryID", "lms_category"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CategoryID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from lms_category");
			strSql.Append(" where CategoryID=@CategoryID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CategoryID", MySqlDbType.Int32,11)			};
			parameters[0].Value = CategoryID;

			return DBMySQLHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LMS.Model.lms_category model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into lms_category(");
			strSql.Append("Category,CategoryID)");
			strSql.Append(" values (");
			strSql.Append("@Category,@CategoryID)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Category", MySqlDbType.VarChar,20),
					new MySqlParameter("@CategoryID", MySqlDbType.Int32,11)};
			parameters[0].Value = model.Category;
			parameters[1].Value = model.CategoryID;

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
		public bool Update(LMS.Model.lms_category model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update lms_category set ");
			strSql.Append("Category=@Category");
			strSql.Append(" where CategoryID=@CategoryID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Category", MySqlDbType.VarChar,20),
					new MySqlParameter("@CategoryID", MySqlDbType.Int32,11)};
			parameters[0].Value = model.Category;
			parameters[1].Value = model.CategoryID;

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
		public bool Delete(int CategoryID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from lms_category ");
			strSql.Append(" where CategoryID=@CategoryID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CategoryID", MySqlDbType.Int32,11)			};
			parameters[0].Value = CategoryID;

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
		public bool DeleteList(string CategoryIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from lms_category ");
			strSql.Append(" where CategoryID in ("+CategoryIDlist + ")  ");
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
		public LMS.Model.lms_category GetModel(int CategoryID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Category,CategoryID from lms_category ");
			strSql.Append(" where CategoryID=@CategoryID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CategoryID", MySqlDbType.Int32,11)			};
			parameters[0].Value = CategoryID;

			LMS.Model.lms_category model=new LMS.Model.lms_category();
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
		public LMS.Model.lms_category DataRowToModel(DataRow row)
		{
			LMS.Model.lms_category model=new LMS.Model.lms_category();
			if (row != null)
			{
				if(row["Category"]!=null)
				{
					model.Category=row["Category"].ToString();
				}
				if(row["CategoryID"]!=null && row["CategoryID"].ToString()!="")
				{
					model.CategoryID=int.Parse(row["CategoryID"].ToString());
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
			strSql.Append("select Category,CategoryID ");
			strSql.Append(" FROM lms_category ");
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
			strSql.Append("select count(1) FROM lms_category ");
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
				strSql.Append("order by T.CategoryID desc");
			}
			strSql.Append(")AS Row, T.*  from lms_category T ");
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
			parameters[0].Value = "lms_category";
			parameters[1].Value = "CategoryID";
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

