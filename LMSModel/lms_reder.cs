/**  版本信息模板在安装目录下，可自行修改。
* lms_reder.cs
*
* 功 能： N/A
* 类 名： lms_reder
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
namespace LMS.Model
{
	/// <summary>
	/// lms_reder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class lms_reder
	{
		public lms_reder()
		{}
		#region Model
		private int _usernumber;
		private string _username;
		private string _userclass;
		private string _usersex;
		private string _useridcard;
		private string _usertell;
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserClass
		{
			set{ _userclass=value;}
			get{return _userclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserSex
		{
			set{ _usersex=value;}
			get{return _usersex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserIDCard
		{
			set{ _useridcard=value;}
			get{return _useridcard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserTell
		{
			set{ _usertell=value;}
			get{return _usertell;}
		}
		#endregion Model

	}
}

