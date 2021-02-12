using Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{ //class referans tip olabilir
    //IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new lenebilir
    public interface IEntityRepository<T> where T:class,IEntity, new()//T yi kisitladik
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre=null filtre vermeyebilirsin demek
        T Get(Expression<Func<T, bool>> filter);
        

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
