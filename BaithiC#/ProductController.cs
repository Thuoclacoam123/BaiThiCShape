using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaithiC_
{
    internal class ProductController
    {
        public ProductDBContext dBContext;
        public ProductController()
        {
            var productsDbOptions = new DbContextOptionsBuilder<ProductDBContext>()
                  .UseSqlServer("Data Source=WINDOWS-OUKPPCL\\SQLEXPRESS;Initial Catalog=DemoConnection;Persist Security Info=True;User ID=sa;Password=12345678;Encrypt=False")
                  .Options;
            this.dBContext = new ProductDBContext(productsDbOptions);
        }
        public void ViewAll()
        {
            var products = dBContext.Products.ToList();
            foreach(var item  in products)
            {
                Console.WriteLine("{0} {1} {2}",item.ProductId,item.ProductName,item.Price);
            }
        }

        public void New()
        {
            Console.Write("Enter Product Id: ");
            string? id = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            string? Name = Console.ReadLine();
            Console.Write("Enter Price: ");
            int Price = Convert.ToInt32(Console.ReadLine());
            var product = new Product
            {
                ProductId = id,
               ProductName = Name,
               Price =Price
            };
            try
            {
                dBContext.Products.Add(product);
                dBContext.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Delete()
        {
            Console.Write("Enter id: ");
            string? id = Console.ReadLine();
            var product = dBContext.Products.FirstOrDefault(x => x.ProductId == id);
            if (product != null)
            {
                dBContext.Products.Remove(product);
                dBContext.SaveChanges();
            }
        }
    }
}
