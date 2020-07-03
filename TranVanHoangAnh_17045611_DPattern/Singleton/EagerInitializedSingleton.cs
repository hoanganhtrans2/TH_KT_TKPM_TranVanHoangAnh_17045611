using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class EagerInitializedSingleton
    {
        static int count = 0;
        private static readonly EagerInitializedSingleton instance = new EagerInitializedSingleton();
        private EagerInitializedSingleton() {
            count++;
            Console.WriteLine("Value " + count);
        }
        
        public static EagerInitializedSingleton getInstance()
        {
            return instance;
        }
    }
}
