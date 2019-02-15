using SequenceHiloPattern.DataBase.Context;
using System;

namespace SequenceHiloPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UseSequenceDbContext context = new UseSequenceDbContextFactory().CreateDbContext())
            {
                context.Categories.Add(new Entitties.Category { Title = "Wearable int" });
           //     context.Products.Add(new Entitties.Product { Name = "Eye Glass" });
                context.SaveChanges();
            }

            Console.WriteLine("\r\nPress any key to continue ...");
            Console.Read();
        }
    }
}
