using BussinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public void CategoryAdd(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryDelete(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
           if(category.CategoryID !=0)
            {
                repo.Delete(category);
            }
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
