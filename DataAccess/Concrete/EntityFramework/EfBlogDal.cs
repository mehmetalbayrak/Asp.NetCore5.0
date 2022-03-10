using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : GenericRepositories<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var context = new Context())
            {
                return context.Blogs.Include(x => x.Category).ToList();
            }
        }
    }
}
