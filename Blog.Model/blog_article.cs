/**  版本信息模板在安装目录下，可自行修改。
* blog_article.cs
*
* 功 能： N/A
* 类 名： blog_article
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
using System.Collections.Generic;

namespace Blog.Model
{
    /// <summary>
    /// blog_article:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class blog_article
    {
        public blog_article()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _desc;
        private string _content;
        private int? _click_count;
        private int? _is_recommend;
        private DateTime? _date_publish;
        private string _username;
        private int? _category;
        private string _tag;
        private int? _isdel;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string desc
        {
            set { _desc = value; }
            get { return _desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? click_count
        {
            set { _click_count = value; }
            get { return _click_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_recommend
        {
            set { _is_recommend = value; }
            get { return _is_recommend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? date_publish
        {
            set { _date_publish = value; }
            get { return _date_publish; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? category
        {
            set { _category = value; }
            get { return _category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tag
        {
            set { _tag = value; }
            get { return _tag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isdel
        {
            set { _isdel = value; }
            get { return _isdel; }
        }
        #endregion Model

        ///// <summary>
        ///// 标签列表
        ///// </summary>
        //public List<blog_tag> Taglist { get; set; }

        ///// <summary>
        ///// 评论列表
        ///// </summary>
        //public List<blog_comment> Commentlist { get; set; }
    }
}

