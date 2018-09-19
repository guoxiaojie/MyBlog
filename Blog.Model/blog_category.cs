/**  版本信息模板在安装目录下，可自行修改。
* blog_category.cs
*
* 功 能： N/A
* 类 名： blog_category
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/8/7 21:39:24   N/A    初版
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
	/// blog_category:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class blog_category
	{
		public blog_category()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _index;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? index
		{
			set{ _index=value;}
			get{return _index;}
		}
		#endregion Model

	}
}

