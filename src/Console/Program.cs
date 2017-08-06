using Database;
using System;
using System.Linq;


namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new KisokDatabase();
            var item = new Item
            {
                Name = "Bread",
                Price = 2,
                QuantityType = 1,
                Stock = 10
            };

            //context.Item.Add(item);
            //context.SaveChanges();

            var quantityType = context.QuantityTypes.Select(u => u.Type);

            for (int i = 0; i < quantityType.Count(); i++)
            {
                Console.WriteLine(quantityType.ToArray()[i]);
            }
            Console.Read();
        }
    }
}
