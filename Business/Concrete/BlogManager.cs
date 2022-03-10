using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetBlogsById(int id)
        {
            return _blogDal.GetAll(x => x.BlogId == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetAll();
        }

        public List<Blog> GetListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GeyById(int id)
        {
            return _blogDal.GetById(id);
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
