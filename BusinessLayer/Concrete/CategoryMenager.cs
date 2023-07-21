using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryMenager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryMenager(ICategoryDal categorydal)
        {
            _categoryDal = categorydal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryAddBl(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x=>x.CategoryID==id);
        }

        public List<Category> GetCategoryList()
        {
            throw new NotImplementedException();
        }

       



        //GenericRepository<Category> repo = new GenericRepository<Category>();
        //public List<Category> GetAllBl()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBl(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
    }
}
