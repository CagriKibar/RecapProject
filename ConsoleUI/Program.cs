using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            productManager.Add(new Product{ CategoryId=3, ProductId=3, ProductName="araba", UnitInStock=5, UnitPrice=150000});

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);

            }

        }
    }
}
