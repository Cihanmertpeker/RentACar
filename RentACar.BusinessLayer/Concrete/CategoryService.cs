﻿using RentACar.BusinessLayer.Abstract;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericDal<Category> _categoryDal;

        public CategoryService(IGenericDal<Category> categoryDal)
        {
            _categoryDal = categoryDal;
        }

		

		public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
           _categoryDal.Update(entity);
        }
    }
}
