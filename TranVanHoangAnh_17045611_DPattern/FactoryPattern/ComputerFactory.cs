using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryPattern
{
    class ComputerFactory
    {
        public static Computer getComputer(String type, String ram, String hdd, String cpu)
        {
            if ("PC".Equals(type))
                return new PC(ram, hdd, cpu);
            else if ("Server".Equals(type))
                return new Server(ram, hdd, cpu);
            return null;
        }
    }
}
