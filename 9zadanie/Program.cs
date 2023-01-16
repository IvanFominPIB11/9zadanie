using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9zadanie
{
    class zadanie9
    {
        static void Main()
        {
            Console.Write("Ввести первое число a:");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Ввести первое число b:");
            var b = int.Parse(Console.ReadLine());
            Console.Write("Ввести первое число c:");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine(a - 1);
            Console.WriteLine(b);
            Console.WriteLine(c + 1);
            Console.ReadKey();
        }
    }
}