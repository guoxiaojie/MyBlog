using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Model
{
    public class CommonList
    {
        /// <summary>
        /// 分页信息
        /// </summary>
        public PageInfo pageinfo { get; set; }
        /// <summary>
        /// 文章列表
        /// </summary>
        public List<blog_article> Articlelist { get; set; }
    }
}