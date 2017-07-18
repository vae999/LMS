/**  版本信息模板在安装目录下，可自行修改。
* lms_map.cs
*
* 功 能： N/A
* 类 名： lms_map
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/18 15:53:26   N/A    初版
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
	/// 数据访问类:lms_map
	/// </summary>
	public partial class lms_map
	{
		public lms_map()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DBMySQLHelper.GetMaxID("Number", "lms_map"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Number)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from lms_map");
			strSql.Append(" where Number=@Number ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Number", MySqlDbType.Int32,11)			};
			parameters[0].Value = Number;

			return DBMySQLHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LMS.Model.lms_map model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into lms_map(");
			strSql.Append("BookNumber,UserNumber,BorrowingDate,ReturnDate,Flage,Number)");
			strSql.Append(" values (");
			strSql.Append("@BookNumber,@UserNumber,@BorrowingDate,@ReturnDate,@Flage,@Number)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BookNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@UserNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@BorrowingDate", MySqlDbType.Date),
					new MySqlParameter("@ReturnDate", MySqlDbType.Date),
					new MySqlParameter("@Flage", MySqlDbType.Int32,11),
					new MySqlParameter("@Number", MySqlDbType.Int32,11)};
			parameters[0].Value = model.BookNumber;
			parameters[1].Value = model.UserNumber;
			parameters[2].Value = model.BorrowingDate;
			parameters[3].Value = model.ReturnDate;
			parameters[4].Value = model.Flage;
			parameters[5].Value = model.Number;

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
		public bool Update(LMS.Model.lms_map model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update lms_map set ");
			strSql.Append("BookNumber=@BookNumber,");
			strSql.Append("UserNumber=@UserNumber,");
			strSql.Append("BorrowingDate=@BorrowingDate,");
			strSql.Append("ReturnDate=@ReturnDate,");
			strSql.Append("Flage=@Flage");
			strSql.Append(" where Number=@Number ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@BookNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@UserNumber", MySqlDbType.Int32,11),
					new MySqlParameter("@BorrowingDate", MySqlDbType.Date),
					new MySqlParameter("@ReturnDate", MySqlDbType.Date),
					new MySqlParameter("@Flage", MySqlDbType.Int32,11),
					new MySqlParameter("@Number", MySqlDbType.Int32,11)};
			parameters[0].Value = model.BookNumber;
			parameters[1].Value = model.UserNumber;
			parameters[2].Value = model.BorrowingDate;
			parameters[3].Value = model.ReturnDate;
			parameters[4].Value = model.Flage;
			parameters[5].Value = model.Number;

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
		public bool Delete(int Number)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from lms_map ");
			strSql.Append(" where Number=@Number ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Number", MySqlDbType.Int32,11)			};
			parameters[0].Value = Number;

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
		public bool DeleteList(string Numberlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from lms_map ");
			strSql.Append(" where Number in ("+Numberlist + ")  ");
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
		public LMS.Model.lms_map GetModel(int Number)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select BookNumber,UserNumber,BorrowingDate,ReturnDate,Flage,Number from lms_map ");
			strSql.Append(" where Number=@Number ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Number", MySqlDbType.Int32,11)			};
			parameters[0].Value = Number;

			LMS.Model.lms_map model=new LMS.Model.lms_map();
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
		public LMS.Model.lms_map DataRowToModel(DataRow row)
		{
			LMS.Model.lms_map model=new LMS.Model.lms_map();
			if (row != null)
			{
				if(row["BookNumber"]!=null && row["BookNumber"].ToString()!="")
				{
					model.BookNumber=int.Parse(row["BookNumber"].ToString());
				}
				if(row["UserNumber"]!=null && row["UserNumber"].ToString()!="")
				{
					model.UserNumber=int.Parse(row["UserNumber"].ToString());
				}
				if(row["BorrowingDate"]!=null && row["BorrowingDate"].ToString()!="")
				{
					model.BorrowingDate=DateTime.Parse(row["BorrowingDate"].ToString());
				}
				if(row["ReturnDate"]!=null && row["ReturnDate"].ToString()!="")
				{
					model.ReturnDate=DateTime.Parse(row["ReturnDate"].ToString());
				}
				if(row["Flage"]!=null && row["Flage"].ToString()!="")
				{
					model.Flage=int.Parse(row["Flage"].ToString());
				}
				if(row["Number"]!=null && row["Number"].ToString()!="")
				{
					model.Number=int.Parse(row["Number"].ToString());
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
			strSql.Append("select BookNumber,UserNumber,BorrowingDate,ReturnDate,Flage,Number ");
			strSql.Append(" FROM lms_map ");
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
			strSql.Append("select count(1) FROM lms_map ");
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
				strSql.Append("order by T.Number desc");
			}
			strSql.Append(")AS Row, T.*  from lms_map T ");
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
			parameters[0].Value = "lms_map";
			parameters[1].Value = "Number";
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

