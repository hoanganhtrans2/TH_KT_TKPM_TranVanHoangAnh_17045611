using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            EagerInitializedSingleton one = EagerInitializedSingleton.getInstance();
            EagerInitializedSingleton two = EagerInitializedSingleton.getInstance();

            //StaticBlockSingleton one = StaticBlockSingleton.getInstance();
            //StaticBlockSingleton two = StaticBlockSingleton.getInstance();

            //LazyInitializedSingleton one = LazyInitializedSingleton.getInstance();
            //LazyInitializedSingleton two = LazyInitializedSingleton.getInstance();

            //BillPughSingleton one = BillPughSingleton.getInstance();
            //BillPughSingleton two = BillPughSingleton.getInstance();

            //ThreadSafeSingleton one = ThreadSafeSingleton.getInstance();
            //ThreadSafeSingleton two = ThreadSafeSingleton.getInstance();

            Console.ReadKey();

        }

    }
}
