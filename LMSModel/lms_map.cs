/**  版本信息模板在安装目录下，可自行修改。
* lms_map.cs
*
* 功 能： N/A
* 类 名： lms_map
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
namespace LMS.Model
{
	/// <summary>
	/// lms_map:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class lms_map
	{
		public lms_map()
		{}
		#region Model
		private int _booknumber;
		private int _usernumber;
		private DateTime _borrowingdate;
		private DateTime _returndate;
		private int _flage;
		private int _number;
		/// <summary>
		/// 
		/// </summary>
		public int BookNumber
		{
			set{ _booknumber=value;}
			get{return _booknumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserNumber
		{
			set{ _usernumber=value;}
			get{return _usernumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BorrowingDate
		{
			set{ _borrowingdate=value;}
			get{return _borrowingdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReturnDate
		{
			set{ _returndate=value;}
			get{return _returndate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Flage
		{
			set{ _flage=value;}
			get{return _flage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		#endregion Model

	}
}

