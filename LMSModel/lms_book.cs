/**  版本信息模板在安装目录下，可自行修改。
* lms_book.cs
*
* 功 能： N/A
* 类 名： lms_book
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
	/// lms_book:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class lms_book
	{
		public lms_book()
		{}
		#region Model
		private string _bookname;
		private int _booknumber;
		private string _bookisbn;
		private int _bookcategoryid;
		private string _bookauthor;
		private string _bookpress;
		private int _bookquantity;
		/// <summary>
		/// 
		/// </summary>
		public string BookName
		{
			set{ _bookname=value;}
			get{return _bookname;}
		}
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
		public string BookISBN
		{
			set{ _bookisbn=value;}
			get{return _bookisbn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BookCategoryID
		{
			set{ _bookcategoryid=value;}
			get{return _bookcategoryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BookAuthor
		{
			set{ _bookauthor=value;}
			get{return _bookauthor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BookPress
		{
			set{ _bookpress=value;}
			get{return _bookpress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BookQuantity
		{
			set{ _bookquantity=value;}
			get{return _bookquantity;}
		}
		#endregion Model

	}
}

