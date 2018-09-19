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
    public class articleController : ApiController
    {
        //TODO:列表，详情
        /// <summary>
        /// 获取文章列表|get请求
        /// </summary>
        /// <param name="pageIndex">当前页</param>
        /// <param name="PageSize">页容量</param>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        [HttpGet]
        public CommonList GetaticleList(int pageIndex, int PageSize, string where)
        {
            articleDal dal = new articleDal();
            CommonList Result = dal.GetarticleList(pageIndex, PageSize, where);
            return Result;
        }

    }
}
