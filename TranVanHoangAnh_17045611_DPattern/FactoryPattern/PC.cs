using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class PC : Computer
    {
        private String ram;
        private String hdd;
        private String cpu;

        public PC(String ram, String hdd, String cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

         public override String getRAM()
                {
                    return this.ram;
                }

         public override String getHDD()
                {
                    return this.hdd;
                }

         public override String getCPU()
                {
                    return this.cpu;
                }
            }
}
