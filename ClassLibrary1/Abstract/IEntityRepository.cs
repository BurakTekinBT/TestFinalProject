using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{       //generic constraint generic kısıt
    //new()  newlenmek zorunda. Ientity newlenemediği için T yerine IEntity koyamayız. Bu sayede sadece T veri tabanı nesneleri ile çalşışır hale geldi
    public interface IEntityRepository<T> where T:class,IEntity,new() // T bir referans tip ve bir entity ya da entityden türüyen bir referans olmalı
    {                                   // T class olmak zorunda T demek referans tip demek
        List<T> GetAll(Expression<Func<T,bool>> filter =null); //filtre zorunlu değil
        T Get(Expression<Func<T, bool>> filter); //Burada filtre zorunlu
        //Expression filtre yazmamızı sağlar
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
