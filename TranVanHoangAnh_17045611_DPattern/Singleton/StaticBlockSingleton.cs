using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class StaticBlockSingleton
    {
        static int count = 0;
        private static StaticBlockSingleton instance;
        private StaticBlockSingleton() {
            count++;
            Console.WriteLine("Value " + count);
        }

        static StaticBlockSingleton()
        {
             try{
             instance = new StaticBlockSingleton();
                }catch(Exception e){
             throw new Exception("Exception occured in creating singleton instance");
             }
             }
        public static StaticBlockSingleton getInstance()
        {
            return instance;
        }
    }
}
