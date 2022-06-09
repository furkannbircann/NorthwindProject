using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductGetAllTest();
            //CategoryTest();
            //ProductDetails();

            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine("{0} / {1} - {2} - {3}", item.ProductId, item.ProductName, item.CategoryName, item.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }

        private static void ProductDetails()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            foreach (var item in productManager.GetProductDetails().Data)
            {
                Console.WriteLine("{0} / {1} - {2} - {3}", item.ProductId, item.ProductName, item.CategoryName, item.UnitsInStock);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var c in categoryManager.GetAll().Data)
            {
                Console.WriteLine(c.CategoryName);
            }
            Console.WriteLine("{0} / 2.category", categoryManager.GetById(2).Data.CategoryName);
        }

        private static void ProductGetAllTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            foreach (var item in productManager.GetAll().Data)
            {
                Console.WriteLine(item.ProductID + " Id'li " + item.ProductName);
            }
        }
    }
}
