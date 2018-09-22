using Blog.DAL;
using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyBlogApi.Controllers
{
    public class categroyController : ApiController
    {
        categoryDal dal = new categoryDal();

        /// <summary>
        /// 获取所有分类
        /// </summary>
        /// <returns></returns>
        [Filter.CrossSite]
        [HttpGet]
        public List<blog_category> GetcategoryList()
        {
            var list= dal.GetcategoryList();
            return list;
        }
    }
}
