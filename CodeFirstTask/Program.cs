using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopInfo;

namespace CodeFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShopContext context = new ShopContext())
            {
                Console.Read();
            }


            Console.ReadKey();
        }
    }
}
