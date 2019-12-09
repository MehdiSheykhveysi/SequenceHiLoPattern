using Microsoft.EntityFrameworkCore;
using SequenceHiloPattern.DataBase.Context;
using SequenceHiloPattern.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceHiloPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UseSequenceDbContext context = new UseSequenceDbContextFactory().CreateDbContext())
            {
                //context.Products.Add(new Product
                //{
                //    ProductGalleries = new List<ProductGallery>
                //    {
                //        new ProductGallery
                //        {
                //            Path="123",
                //            IsDefault=true
                //        }
                //    },
                //    OrderDetails = new List<OrderDetail>
                //    {
                //        new OrderDetail
                //        {
                //            Order=new Order
                //            {
                //                Title="order1"
                //            }
                //        }
                //    },
                //    Category = new Category
                //    {
                //        Title = "category1"
                //    },
                //    Name = "product"
                //});
                //context.SaveChanges();
                var result = context.OrderDetails.Where(od => od.Order.ID == 2).Select(od => new
                {
                    Galleries = od.Product.ProductGalleries.Where(g => g.IsDefault).ToList(),
                    od.Order
                }).FirstOrDefault();
            }

            Console.WriteLine("\r\nPress any key to continue ...");
            Console.Read();
        }
    }

    public class MyDto
    {
        public List<Author> Authors { get; set; }
        public decimal MyProperty { get; set; }
    }
}
