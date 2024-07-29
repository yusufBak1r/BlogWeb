﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
         Context c = new Context();
        public void AddCategory(Category category)
        {
           c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            
            c.Remove(category); 
            c.SaveChanges();    
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
