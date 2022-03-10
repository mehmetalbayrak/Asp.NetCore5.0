using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(Blog blog);
        List<Blog> GetList();
        Blog GeyById(int id);
        List<Blog> GetListWithCategory();
        List<Blog> GetBlogsById(int id);
    }
}
