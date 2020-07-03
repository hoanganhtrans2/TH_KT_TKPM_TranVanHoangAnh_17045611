using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ThreadSafeSingleton
    {
        static int count = 0;
        private static ThreadSafeSingleton instance;
        private ThreadSafeSingleton() {
            count++;
            Console.WriteLine("Value " + count);
        }
        public static ThreadSafeSingleton getInstance()
        {
            if (instance == null)
            {
                instance = new ThreadSafeSingleton();
            }
            return instance;
        }

    }
}
