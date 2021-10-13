using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)

        {
            what h = new what();
            demo t = new demo();
            t.todo();
            h.why();
            Console.WriteLine("Hello There !");
            Console.ReadLine();
        }
        private static void staticmethod()
        {
            Console.WriteLine("okay...");
        }
    }
    class demo {
        public void todo()
        {
            Console.WriteLine("okay");
        }
        
    }
}
    

