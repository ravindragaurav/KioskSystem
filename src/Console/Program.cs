using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
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

            context.Item.Add(item);
            context.SaveChanges();

        }
    }
}
