﻿/**  版本信息模板在安装目录下，可自行修改。
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
namespace LMS.Model
{
	/// <summary>
	/// lms_admin:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class lms_admin
	{
		public lms_admin()
		{}
		#region Model
		private string _adminuid;
		private string _adminpwd;
		private int _adminnumber;
		private string _adminname;
		/// <summary>
		/// 
		/// </summary>
		public string AdminUid
		{
			set{ _adminuid=value;}
			get{return _adminuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdminPwd
		{
			set{ _adminpwd=value;}
			get{return _adminpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AdminNumber
		{
			set{ _adminnumber=value;}
			get{return _adminnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AdminName
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		#endregion Model

	}
}
