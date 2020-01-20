using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace giraffe
{
    class Program
    {
        public static void reLoop(string loopstring, int count)
        {
             Console.WriteLine(String.Concat(Enumerable.Repeat(loopstring,count)));
        }
        static void Main(string[] args)
        {
            // Exemple
            reLoop("zakaria ", 3);
            reLoop("Hello world ", 10);
            Console.ReadKey();
        }
    }
}
