﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {   //IDisposable pattern implementation of c#

            using (NortwindContext context=new NortwindContext())

            {
                var addedEntity = context.Entry(entity);     //Referansı yakala
                addedEntity.State = EntityState.Added;        //Eklenebilecek bir nesne ?

                context.SaveChanges();                           //ve ekle.

            }
            //using yazmayıp direk icerideki
            //gibi yazsakda olur ama
            //context ler cok yer kapladıgı
            //icin garbage collector(çöp toplayıcı)
            //using yazılanları işi biter bitmez bellekten
            //silmek için alır çöpe atar.

        }

        public void Delete(Category entity)
        {
            using (NortwindContext context = new NortwindContext())

            {
                var deletedEntity = context.Entry(entity);     
                deletedEntity.State = EntityState.Deleted;        

                context.SaveChanges();                           

            }

        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using (NortwindContext context=new NortwindContext())
            {
                return filter == null ? context.Set<Category>().ToList() :
                    context.Set<Category>().Where(filter).ToList();
;            }
        }

        public void Update(Category entity)
        {
            using (NortwindContext context = new NortwindContext())

            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;

                context.SaveChanges();

            }
        }
    }
}
