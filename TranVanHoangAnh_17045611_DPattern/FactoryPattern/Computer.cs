using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class Computer
    {
        public abstract String getRAM();
        public abstract String getHDD();
        public abstract String getCPU();

        public String toString()
        {
            return "RAM= " + this.getRAM() + ", HDD=" + this.getHDD() + ", CPU = "+this.getCPU();
        }
    }
}
