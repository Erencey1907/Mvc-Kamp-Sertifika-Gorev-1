﻿using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> Repo = new GenericRepository<Category>();
        
        public List<Category> GetAll()
        {
            return Repo.List();
        }

        public void CategoryAdd(Category p)
        {
            if (p.CategoryName==""||p.CategoryName.Length<=3||p.CategoryDescription==""||p.CategoryName.Length>=51)
            
            {
                //Hata Mesajı    
            }
            else
            {
                Repo.Insert(p);
                
            }
        }
    
    
    }
}
