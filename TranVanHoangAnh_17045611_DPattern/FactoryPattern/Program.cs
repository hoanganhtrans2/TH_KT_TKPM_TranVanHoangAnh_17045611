using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer pc = ComputerFactory.getComputer("PC", "2 GB", "128 GB", "2.3 GHz");
            Computer server = ComputerFactory.getComputer("Server", "4 GB", "500 GB", "2.4 GHz");

            Console.WriteLine("Factory PC Config: "+pc.toString());
            Console.WriteLine("Factory Server Config: " +server.toString());

            Console.ReadKey();
        }
    }
}
