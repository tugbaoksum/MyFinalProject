using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint (kısıt)
    //class : referans tip
    //new : mew'lenebilir olmalı.
    public interface IEntityRepository<T> where T: class,IEntity,new() //T IEntity olabilir  veya ordan implement olan bir nesne olabilir.
    {
        List<T> GetAll(Expression<Func<T,bool>>filter = null);
        T Get(Expression<Func<T, bool>> filter); //tek bir şeyin detayını getirmek için kullanılır. 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
