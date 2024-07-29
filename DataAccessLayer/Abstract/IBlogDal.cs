using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> ListAllBlog();
        void AddBlog(Blog category);
        void DeleteBlog(Blog category);

        void UpdateBlog(Blog category);
        Category GetById(int id);
    }
}
