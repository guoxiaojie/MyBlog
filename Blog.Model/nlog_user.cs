/**  版本信息模板在安装目录下，可自行修改。
* nlog_user.cs
*
* 功 能： N/A
* 类 名： nlog_user
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/8/7 21:39:25   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Blog.Model
{
	/// <summary>
	/// nlog_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class nlog_user
	{
		public nlog_user()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _password;
		private DateTime? _last_login;
		private string _last_ip;
		private int? _is_superuser;
		private string _truename;
		private string _email;
		private string _qq;
		private string _moblie;
		private DateTime? _intime;
		private string _url;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? last_login
		{
			set{ _last_login=value;}
			get{return _last_login;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string last_ip
		{
			set{ _last_ip=value;}
			get{return _last_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_superuser
		{
			set{ _is_superuser=value;}
			get{return _is_superuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string truename
		{
			set{ _truename=value;}
			get{return _truename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string moblie
		{
			set{ _moblie=value;}
			get{return _moblie;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? intime
		{
			set{ _intime=value;}
			get{return _intime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		#endregion Model

	}
}

