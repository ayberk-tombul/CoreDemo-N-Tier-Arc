using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Category blog);
        void BlogDelete(Category blog);
        void BlogUpdate(Category blog);
        List<Blog> GetList();
        Blog GetById(int id);

        List<Blog> GetBlogListWithCategory();
    }
}
