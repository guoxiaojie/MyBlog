using Blog.Model;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL
{
    public class tagDal
    {
        /// <summary>
        /// 获取所有标签
        /// </summary>
        /// <returns></returns>
        public List<blog_tag> GettagList()
        {
            string sql = " select * from blog_tag";
            List<blog_tag> result = SQLHelper.ExcuteList<blog_tag>(sql);
            return result;
        }
    }
}
