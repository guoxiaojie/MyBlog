using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Common;
using System.Data;

namespace Blog.DAL
{
    public class articleDal
    {
        public CommonList GetarticleList(int pageIndex, int pageSize, string where)
        {
            if (string.IsNullOrEmpty(where))
            {
                where = " 1=1";
            }
            int n = 0;
            //文章列表
            SqlParameter[] sp = {
            new SqlParameter ("@TableFields", "*"),
            new SqlParameter ("@TableName", "blog_article"),
            new SqlParameter ("@SqlWhere", where),
            new SqlParameter ("@OrderBy", "id"),
            new SqlParameter ("@PageIndex", pageIndex),
            new SqlParameter ("@PageSize", pageSize),
            new SqlParameter ("@TotalCount", n)
            };
            sp[6].Direction = System.Data.ParameterDirection.InputOutput;//设置条数为返回参数

            List<blog_article> article = SQLHelper.ExcuteList<blog_article>("Proc_Paging", CommandType.StoredProcedure, sp);
            CommonList Result = new CommonList();
            Result.pageinfo = new PageInfo { PaggeSize = pageSize,
                TotalCount = Convert.ToInt32(sp[6].Value) };
            Result.Articlelist = article;
            return Result;
        }

    }
}
