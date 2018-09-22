using Blog.Model;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL
{
    public class categoryDal
    {
        /// <summary>
        /// 获取所有分类
        /// </summary>
        /// <returns></returns>
        public List<blog_category> GetcategoryList()
        {
            string sql = " select  * from blog_category";
            List<blog_category> result = SQLHelper.ExcuteList<blog_category>(sql);
            return result;
        }
    }
}
