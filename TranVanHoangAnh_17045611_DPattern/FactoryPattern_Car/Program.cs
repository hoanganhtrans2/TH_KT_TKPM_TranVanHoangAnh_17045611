using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car honda = CarFactory.getCar("Honda", "hd123", "4 banh", "Honda", "Tu dong lai");
            Car nexus = CarFactory.getCar("Nexus", "nx123", "4 banh", "Nexus", "Phun xang dien tu");
            Car toyota = CarFactory.getCar("Toyota", "ty123", "4 banh", "Toyota", "Di xuyen tuong");

            Console.WriteLine("Factory Honda Config: \n" + honda.toString());
            Console.WriteLine("Factory Nexus Config: \n" + nexus.toString());
            Console.WriteLine("Factory Toyota Config: \n" + nexus.toString());

            Console.ReadKey();
        }
    }

    
}
