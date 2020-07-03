using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class LazyInitializedSingleton
    {
        static int count = 0;
        private static LazyInitializedSingleton instance;
        private LazyInitializedSingleton() {
            count++;
            Console.WriteLine("Value " + count);
        }
        public static LazyInitializedSingleton getInstance()
        {
            if (instance == null)
            {
                instance = new LazyInitializedSingleton();
            }
            return instance;
        }
    }
}
