using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;// class içerisinde kullanmak için _product değişkeni oluşturuldu.

        public InMemoryProductDal()//constructor yapısı olusturularak, arka planda veri gönderilip, çalıştırıldı.
        {
            _products = new List<Product>//bu metod içersinde çalışması için new'lenip kullanıma sunduk.
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Hızlı Okuma Teknikleri", UnitPrice=20, UnitInStock=150},
                new Product{ProductId=2, CategoryId=1, ProductName="Boyama Kitabı", UnitPrice=15, UnitInStock=150},
                new Product{ProductId=3, CategoryId=2, ProductName="Macbook", UnitPrice=10000, UnitInStock=8},
                new Product{ProductId=4, CategoryId=3, ProductName="Deterjan", UnitPrice=10, UnitInStock=750},
                new Product{ProductId=5, CategoryId=4, ProductName="Kazak", UnitPrice=90, UnitInStock=100},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
        }
    }

    
    }

