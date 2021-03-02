using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal //interfacein operasyonları public olur kendisine ayrı public atamak lazım
    {
        List<Product> GetAll();
        // burada product'ı referanslamamız lazım Entitities'i biz kullanacağız DAL olarak biz entity'e bağımlıyız 
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetByCategory(int categoryId);
    }
}
